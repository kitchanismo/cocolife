Public Class Dashboard

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub btnlgn_Click(sender As Object, e As EventArgs) Handles btnlgn.Click
        UserVerification.ShowDialog()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'grant access to user 

        If UserLogin.role.ToLower = "manager" Then
            btnlgn.Visible = True
        Else
            btnlgn.Visible = False

        End If
    End Sub

    Private Sub lbllogout_Click(sender As Object, e As EventArgs) Handles lbllogout.Click

        Dim msg As String = MsgBox("Are you sure do you want to logout? ", MsgBoxStyle.YesNo)
        If msg = MsgBoxResult.Yes Then
            Me.Close()
            UserLogin.username = ""
            UserLogin.role = ""
            UserLogin.Show()
        End If
    End Sub

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub
End Class