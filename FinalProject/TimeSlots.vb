'class TimeSlots will be used to crete objectsin the frmOptions
Public Class TimeSlots
    'attributes
    Private m_StartTime As Date
    Private m_EndTime As Date 
    Private m_Length As Integer 'minutes per time slot
    Private m_Guests As Integer 'amount of tickets
    Private m_FirstTicket As Integer

    'default constructor
    Public Sub New()

    End Sub

    'construtor with values to each attibute
    Public Sub New(startTime As Date, length As Integer, guests As Integer, firstTicket As Integer)
        m_StartTime = startTime
        m_Length = length
        m_Guests = guests
        m_FirstTicket = firstTicket
        m_EndTime = m_StartTime.AddMinutes(m_Length)
    End Sub

    'get and set of m_StartTime
    Public Property StartTime As Date
        Get
            Return m_StartTime
        End Get
        Set(value As Date)
            m_StartTime = value
        End Set
    End Property

    'get and set of m_Length
    Public Property Length As Integer
        Get
            Return m_Length
        End Get
        Set(value As Integer)
            m_Length = value
        End Set
    End Property

    'get and set of m_FirstTicket
    Public Property FirstTicket As Integer
        Get
            Return m_FirstTicket
        End Get
        Set(value As Integer)
            m_FirstTicket = value
        End Set
    End Property

    'set to m_EndTime that add the length to each ticket startTime
    Public ReadOnly Property EndTime As Date
        Get
            m_EndTime = m_StartTime.AddHours(m_Length)
            Return m_EndTime
        End Get
    End Property

    'get and set to m_Guests
    Public Property Guests As Integer
        Get
            Return m_Guests
        End Get
        Set(value As Integer)
            m_Guests = value
        End Set
    End Property

    'display text just to test
    Public Function GetDisplayText() As String
        Dim text As String = "start: " & m_StartTime & " size: " & m_Length & " guests: " & m_Guests & vbCrLf & "firstTicket: " & m_FirstTicket & " endTime: " & m_EndTime & vbCrLf
        Return text
    End Function
End Class
