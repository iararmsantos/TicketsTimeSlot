'class ticket will be used to create tickets in the frmTimeSlot
Public Class Ticket
    'attributes
    Private m_TicketNumber As Integer
    Private m_Slot As Date

    'defaul constructor
    Public Sub New()

    End Sub

    'constructor with values to each attribute
    Public Sub New(ticketNumber As Integer, timeSlot As Date)
        m_TicketNumber = ticketNumber
        m_Slot = timeSlot
    End Sub

    'get and set of m_TicketNumber
    Public Property Number As Integer
        Get
            Return m_TicketNumber
        End Get
        Set(value As Integer)
            m_TicketNumber = value
        End Set
    End Property

    'get and set of m_Slot
    Public Property Slot As Date
        Get
            Return m_Slot
        End Get
        Set(value As Date)
            m_Slot = value
        End Set
    End Property

    'set the next m_ticketNumber value
    Public Function SetNextTicket() As Integer
        Dim nextValue = m_TicketNumber + 1
        Return nextValue
    End Function

    'format string to be inserted in the listBox
    Public Function GetDisplayText() As String
        Dim text As String = "Ticket " & m_TicketNumber & ": " & m_Slot.ToShortTimeString
        Return text
    End Function
End Class
