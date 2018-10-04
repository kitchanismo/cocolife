'all users database operations will be happen here

Imports DynamicCard
Imports DynamicCard.Styles

Public Class UserService
    Inherits User


    Public Function GetUserCards() As List(Of Card)
        Dim cards As New List(Of Card)

        Connected()
        sql = "Select username,role,gender,isverify from tblUser"
        CommandRead(sql)

        Dim path = Application.StartupPath & "\img\"

        While (dr.Read())
            Dim pic
            If dr("gender") = "Male" Then
                pic = "boy.png"
            Else
                pic = "girl.png"
            End If

            cards.Add(New UserCard With {
                .Key = Guid.NewGuid.ToString,
                .Title = dr("username"),
                .Subtitle = dr("role"),
                .ImagePath = path & pic,
                .Category = dr("isverify")
             })
        End While

        Return cards
    End Function

    'check if user is authentic/authorize with username and password as parameters
    'will return true if user is authentic, otherwise it return false
    Public Function isUserAuthentic(ByVal username As String, ByVal password As String) As Boolean
        Connected()
        sql = "Select * from tblUser where username = '" & username & "' and pword = '" & password & "'"
        CommandRead(sql)
        If dr.HasRows() Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function isUserVerified(ByVal username As String) As Boolean
        Connected()
        sql = "Select * from tblUser where username = '" & username & "' and isverify = 'true'"
        CommandRead(sql)
        If dr.HasRows() Then
            Return True
        Else
            Return False
        End If
    End Function

    'get the user role base on his/her username
    Public Function getUserRole(ByVal username As String) As String
        Connected()
        sql = "Select role from tblUser where username = '" & username & "' "
        CommandRead(sql)
        If dr.HasRows() Then
            While dr.Read()
                Return dr.Item("role")
            End While
        End If
        Return ""
    End Function

    'not implented this yet, since we have no User maintenance
    Public Function isUserExist(ByVal username As String) As Boolean
        Connected()
        sql = "Select * from tblUser where username = '" & username & "' "
        CommandRead(sql)
        If dr.HasRows() Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub SaveUser(ByVal username As String, ByVal password As String, ByVal gender As String)

        Connected()
        sql = "INSERT INTO tblUser (username,pword,gender,role,isverify)values('" & username & "','" & password & "','" & gender & "','staff','false')"
        CommandExecute(sql)
    End Sub

    Public Sub UpdateStatus(ByVal username As String)
        Connected()
        sql = "update tblUser set isverify = 'true' where username = '" & username & "'"
        CommandExecute(sql)
    End Sub
End Class
