
Public Class frmTimeSlot
    'Queue of tickets
    Dim ticketsQ As New Queue(Of Ticket)

    Dim optionForm As New frmOptions  'frmOption

    'count clicks in the issue button
    Private countIssue As Integer = 0

    'object ticket to create tickets
    Dim ticket As New Ticket()

    'count time slots to use as index to tickets list
    Dim countTimeSlots As Integer = 1

    'to be used to insert the atual time on the bar
    Dim currentTime As Date

    'to get the entry time to the ticket object
    Dim secTimeEntry As Date = Nothing

    'control tickets if and add queue
    Dim countTickets As Integer = 0

    'show frmOption and initialize some variables
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Stop() 'stop timer until option form is ok

        optionForm.ShowDialog() 'show option form
        If optionForm.TimeSlot IsNot Nothing Then 'check if user enter data in the form
            CreateTicketObject()
            FillTimeSlotLabels()
            currentTime = DateTime.Now
            Timer1.Start() 'start time second by second
            Me.Text = currentTime.ToLongTimeString 'show timer on the bar
        End If
    End Sub

    'insert time in the form bar it will be updated at each tick(1000 milliseconds)
    'the formats here was inputed in the properties windows form
    Private Sub barTime(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentTime = DateTime.Now
        Me.Text = currentTime.ToLongTimeString

        Dim checkSlot As Integer = countTimeSlots + 1

        If currentTime < optionForm.timeSlots.Item(checkSlot).StartTime Then
            Me.Text += " (Close)"
        Else
            Me.Text += " (Open)"
        End If

    End Sub

    'create a new ticket object with updated time and first ticket
    Private Sub CreateTicketObject()
        Dim secFirstTicket As Integer = optionForm.timeSlots.Item(countTimeSlots + 1).FirstTicket - 1
        secTimeEntry = optionForm.timeSlots.Item(countTimeSlots).StartTime
        ticket = New Ticket(secFirstTicket, secTimeEntry)

    End Sub

    'create labels to be inserted in the listBox
    Private Sub btnIssueTicket_Click(sender As Object, e As EventArgs) Handles btnIssueTicket.Click

        'if count click less than time slots available
        If countIssue < CInt(optionForm.TimeSlot.Guests) Then
            If ticketsQ.Count = countTickets Then
                'add ticket to the list
                ticketsQ.Enqueue(ticket)

                'set next number to ticket
                Dim nextValue As Integer = ticket.SetNextTicket()
                ticket = New Ticket(nextValue, secTimeEntry)

                'update labels
                FillTimeSlotLabels()

                'fill list box
                FillSlotsIssuedList()
            End If
        Else
            countTimeSlots += 1
            countIssue = 0

            CreateTicketObject()

            'add ticket to the list
            ticketsQ.Enqueue(ticket)

            'set next number to ticket
            Dim nextValue As Integer = ticket.SetNextTicket()
            ticket = New Ticket(nextValue, secTimeEntry)

            'update labels
            FillTimeSlotLabels()

            'fill list box

            FillSlotsIssuedList()

        End If

        If optionForm.timeSlots(countTimeSlots - 1).StartTime = currentTime Then
            ticketsDequeue()
        End If

        countIssue += 1
    End Sub

    'if slots start time - current time remove from the list
    Public Sub ticketsDequeue()
        Dim numTickets As Integer = 0
        Dim test As Boolean = False
        Dim ticketToCheckSlot As Date
        currentTime = DateTime.Now
        Do
            If ticketsQ.Count > 0 Then
                ticketToCheckSlot = ticketsQ.Peek().Slot

                If ticketToCheckSlot = currentTime Then
                    ticketsQ.Dequeue()
                    lstTicketsIssued.Items.RemoveAt(numTickets)
                    countTickets -= 1
                    FillTimeSlotLabels()
                    If ticketsQ.Count = 0 Then
                        test = False
                    Else
                        test = True
                    End If

                Else
                    test = False
                End If
            End If

        Loop While test = True
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click

        'dialog box to check if user want to delete outstanding tickets list
        Dim button As DialogResult = MessageBox.Show("Are you sure you want delete all
        outstanding tickets?", "Options", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2)

        If button = DialogResult.Yes Then
            'clear outstanding ticket and list
            Timer1.Stop()
            ClearTickets()
            countIssue = 0
            countTimeSlots = 1
            optionForm.timeSlots.Clear()

            optionForm.ShowDialog() 'show option form
            If optionForm.TimeSlot IsNot Nothing Then 'check if user enter data in the form
                Timer1.Start()
                Me.Text = currentTime.ToLongTimeString
                CreateTicketObject()

                FillTimeSlotLabels()
            End If
        End If

    End Sub

    'Fill Label with data got from timeSlots collection
    Private Sub FillTimeSlotLabels()
        'fill guests textBox
        Dim secLabel As Integer = optionForm.timeSlots.Item(countTimeSlots + 1).FirstTicket - 1

        lblGuests.Text = optionForm.timeSlots.Item(countTimeSlots - 1).FirstTicket & " - " & secLabel.ToString

        'fill outsdanding ticket
        lblOutstanding2.Text = countTickets.ToString

        'fill next entry
        lblNextEntry2.Text = secTimeEntry.ToShortTimeString()
    End Sub

    'close the form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'fill list of slots issued
    Private Sub FillSlotsIssuedList()
        countTickets += 1
        FillTimeSlotLabels()
        lstTicketsIssued.Items.Add(ticket.GetDisplayText)
    End Sub

    'clear all tickets in the list
    Private Sub ClearTickets()
        countTickets = 0
        lstTicketsIssued.Items.Clear()
        ticketsQ.Clear()
        ClearLabels()
    End Sub

    'clear labels after new option form is open
    Private Sub ClearLabels()
        lblGuests.Text = ""
        lblOutstanding2.Text = ""
        lblNextEntry2.Text = ""
    End Sub
End Class
