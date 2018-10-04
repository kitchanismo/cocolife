Public Class UserLogin

    Public role As String
    Public username As String

    Dim password As String
    Dim user As New UserService

    Private Sub lblexit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnlgn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnlgn.Click

        username = txtuname.Text.ToLower
        password = txtpword.Text.ToLower

        'check if user is unauthorized or valid
        If Not user.isUserAuthentic(username, password) Then
            MsgBox("Username And Password is incorrect!", MsgBoxStyle.Exclamation)

            Exit Sub
        End If

        If Not user.isUserVerified(username) Then
            MsgBox("Unverified user!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'get and assign the role of the user
        role = user.getUserRole(username)

        MsgBox("Successfully Login!", MsgBoxStyle.Information)
        Dashboard.Show()
        Me.Hide()
        txtuname.Clear()
        txtpword.Clear()
    End Sub


    Private Sub btnclose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnclose.Click

        End
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Login.MouseDown
        pos = GetLocation(pnlogin)
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Login.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            pnlogin.Location = SetLocation(pos, MousePosition)
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtsuname.Text = "" Or txtspword.Text = "" Or CboGender.Text = "" Then
            MsgBox("Missing input!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtsuname.TextLength < 6 Or txtsuname.TextLength < 6 Then
            MsgBox("username/Password must have atleast 6 characters long!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Not txtspword.Text = txtconfirm.Text Then
            MsgBox("Password not match!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If user.isUserExist(txtsuname.Text) Then
            MsgBox(txtsuname.Text & " is taken!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        user.SaveUser(txtsuname.Text, txtspword.Text, CboGender.Text)
        MsgBox("Successfully save! Please, wait for verification.", MsgBoxStyle.Information)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        pnlogin.SendToBack()
        pnsignup.BringToFront()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        pnsignup.SendToBack()
        pnlogin.BringToFront()
    End Sub

    Private Sub pnlogin_Paint(sender As Object, e As PaintEventArgs) Handles pnlogin.Paint

    End Sub

    Private Sub txtspword_TextChanged(sender As Object, e As EventArgs) Handles txtspword.TextChanged

    End Sub

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
