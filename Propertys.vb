Public Class Propertys
    Private _code As String
    Private _name As String
    Private _storaged As Integer
    Private _pic As Byte()

    Public Property code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
        End Set
    End Property

    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property storaged As Integer
        Get
            Return _storaged
        End Get
        Set(value As Integer)
            _storaged = value
        End Set
    End Property

    Public Property pic As Byte()
        Get
            Return _pic
        End Get
        Set(value As Byte())
            _pic = value
        End Set
    End Property

End Class
