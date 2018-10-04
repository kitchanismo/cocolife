Public Class LoadScreen
    Dim ctr As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ctr += 1
        If ctr = 1 Then
            'check database if okay
            Timer1.Stop()
            Connected()
            Timer1.Start()
        ElseIf ctr = 2 Then
            ctr = 0
            Timer1.Stop()
            Me.Hide()
            UserLogin.Show()

            ' Connected()
            'sql = "Drop Table tblUser"
            '' CommandExecute(sql)
            '' sql = "CREATE TABLE tblUser (username varchar(255) NOT NULL, pword varchar(255) NOT NULL, gender varchar(255) NOT NULL,role varchar(255) NOT NULL,isverify varchar(255) NOT NULL);"
            'CommandExecute(sql)
        End If
    End Sub


    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LoadScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class