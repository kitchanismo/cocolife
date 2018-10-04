Public Class User
    'all users property/variables will be here

    Private uname As String
    Public Property username() As String
        Get
            Return uname
        End Get
        Set(ByVal value As String)
            uname = value
        End Set
    End Property


    Private pword As String
    Public Property password() As String
        Get
            Return pword
        End Get
        Set(ByVal value As String)
            pword = value
        End Set
    End Property


    Private role As String
    Public Property userRole() As String
        Get
            Return role
        End Get
        Set(ByVal value As String)
            role = value
        End Set
    End Property


End Class
