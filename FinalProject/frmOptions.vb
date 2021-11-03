Imports System.Globalization

Public Class frmOptions
    'TimeSlots Object
    Public TimeSlot As TimeSlots
    'time slots object collection
    Public timeSlots As New List(Of TimeSlots)

    'variables to manipulate date and time
    Dim currentDateTime As Date = DateTime.Now
    Dim startTime As String = currentDateTime.ToLongTimeString
    Dim endTime As Date = currentDateTime.AddHours(4)
    Dim endTimeString As String = endTime.ToLongTimeString

    'verify if data inserted into the form is valid
    'create collection of timeslots accordingly to span value between start and end time
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'verify data
        If IsValidData() Then

            'create objects for each timeSoltsUnits available
            createCollection()

            'close form
            Me.Close()
        End If
    End Sub

    'evalute all data entered in the text box
    Private Function IsValidData() As Boolean
        Return _
            IsPresent(txtMinutes, "Minutes per Window") AndAlso
            IsPresent(txtGuests, "Guests per Window") AndAlso
            IsPresent(txtStart, "Start Time") AndAlso
            IsPresent(txtEnd, "End Time") AndAlso
            IsPresent(txtFirstTicket, "First Ticket Number") AndAlso
            IsInt32(txtMinutes, "Minutes per Window") AndAlso
            IsInt32(txtGuests, "Guests per Window") AndAlso
            IsInt32(txtFirstTicket, "First Ticket Number") AndAlso
            IsDateTime(txtStart, "Start Time") AndAlso
            IsDateTime(txtEnd, "End Time") AndAlso
            IsBiggerThanTwo(txtStart, txtEnd, "At Least Two Time Slots")

    End Function

    'verify if slots between start and time are bigger than two
    Private Function IsBiggerThanTwo(txtStart As TextBox, txtEnd As TextBox, name As String) As Boolean
        Dim slotsLikely As Integer = TimeSpanSlots()
        If slotsLikely >= 2 Then
            Return True
        Else
            MessageBox.Show(name & " must allow 2 time slots between start and end time.", "Entry Error")
            txtEnd.Select()
            Return False
        End If
    End Function

    'verify if textbox with time is a DateTime object
    Private Function IsDateTime(textBox As TextBox, name As String) As Boolean
        If IsDate(textBox.Text) Then
            Return True
        Else
            MessageBox.Show(name & " is a required field.", "Entry Error")
            textBox.Select()
            Return False
        End If
    End Function

    'verify if textBox is not empty
    Private Function IsPresent(textBox As TextBox, name As String) As Boolean
        If textBox.Text = "" Then
            MessageBox.Show(name & " is a required field.", "Entry Error")
            textBox.Select()
            Return False
        Else
            Return True
        End If
    End Function

    'verify if textBox value is Int32
    Private Function IsInt32(textBox As TextBox, name As String) As Boolean
        Dim number As Integer = 0
        If Int32.TryParse(textBox.Text, NumberStyles.None, CultureInfo.CurrentCulture, number) Then
            Return True
        Else
            MessageBox.Show(name & " must be an integer.", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
    End Function

    'load form with default values
    Private Sub frmOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMinutes.Text = "5"
        txtGuests.Text = "5"
        txtStart.Text = startTime
        txtEnd.Text = endTimeString
        txtFirstTicket.Text = "1"
    End Sub

    'count how the amount of time slot fits between star and end time
    Public Function TimeSpanSlots() As Integer
        Dim startTime As Date = CDate(txtStart.Text)
        Dim endTime As Date = CDate(txtEnd.Text)
        Dim timeTillEnd As TimeSpan = endTime.Subtract(startTime)
        Dim minAmount As Integer = CInt(timeTillEnd.TotalMinutes)

        Dim totalSlots As Integer = CInt(minAmount / CInt(txtMinutes.Text))

        'to test if it is count correctly
        'MessageBox.Show("minutes amount: " & minAmount & vbCrLf &
        '                "totalSlots: " & totalSlots)

        Return totalSlots
    End Function

    'this should create a time slot object for each time slot between the start and end times
    Public Sub createCollection()
        'variable to test each object collection
        Dim msg As String = ""
        'calc space between start and time 
        Dim timeSlotsUnits As Integer = TimeSpanSlots()

        Dim size As Integer = CInt(txtMinutes.Text)

        'loop through number of slots available between end and start time
        'creating attributes to a new slot
        Dim startNewSlot As Date = CDate(txtStart.Text)
        'size
        Dim endNewSlot As Date
        'guests
        Dim newFirstTicket As Integer = CInt(txtFirstTicket.Text)


        For i As Integer = 0 To timeSlotsUnits - 1

            TimeSlot = New TimeSlots(startNewSlot, size, CInt(txtGuests.Text), newFirstTicket)
            endNewSlot = TimeSlot.EndTime
            timeSlots.Add(TimeSlot)

            'creating attributes to a new slot
            startNewSlot = startNewSlot.AddMinutes(size)
            'size '5
            endNewSlot = endNewSlot
            'guests '5
            newFirstTicket += size
        Next

        'to test each collecton item
        'For Each t As TimeSlots In timeSlots
        '    msg &= (t.GetDisplayText() & vbCrLf)
        'Next

        'MessageBox.Show(msg)
    End Sub
End Class