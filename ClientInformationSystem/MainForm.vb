Imports DynamicCard

Public Class MainForm
    'policyNumber will be get the value if client is selected
    Public id As Integer
    'instantiate Client Model
    Dim client As New ClientService
    Public cardArgs As New CardEventArgs

    Private Sub Card_OnClick(ByVal sender As Object, ByVal e As CardEventArgs) Handles CardContainer1.OnClick
        cardArgs = e
    End Sub


    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Async Sub Main_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtrole.Text = "Loading ..."

        'grant access to user role
        AccessGranted(UserLogin.role)

        Await CardContainer1.AddRangeAsync(client.GetClientCards())
    End Sub

    Private Async Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Await CardContainer1.FilterAsync(txtsearch.Text)

    End Sub

    Private Async Sub btnrefresh_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Await CardContainer1.AddRangeAsync(client.GetClientCards())

        txtsearch.Text = " "
    End Sub

    Private Async Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        AddClient.ShowDialog()
        Await CardContainer1.AddRangeAsync(client.GetClientCards())

    End Sub

    Private Async Sub btnarchive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnarchive.Click
        ArchiveClient.ShowDialog()
        Await CardContainer1.AddRangeAsync(client.GetClientCards())

    End Sub

    Private Sub btnreports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreports.Click

        Reports.ShowDialog()
    End Sub

    Private Sub timerdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerdate.Tick
        'get the username and role into the User form and concatenate Date and Time
        txtrole.Text = UserLogin.username.ToUpper & " | " & UserLogin.role.ToUpper & " | " & Format(Date.Now, "short date") & " | " & TimeOfDay
    End Sub


    Private Async Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click

        If cardArgs.Key = Nothing Then

            MsgBox("Select Client from List", MsgBoxStyle.Exclamation)

            Exit Sub
        End If


        'show edit form
        EditClient.ShowDialog()
        'refresh client
        Await CardContainer1.AddRangeAsync(client.GetClientCards())

        cardArgs.Key = Nothing
        '.Text = "Client List"
    End Sub

    Private Async Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Me.TopMost = False
        If cardArgs.Key = Nothing Then
            MsgBox("Select Client from List", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'confirm if user want to delete or not
        Dim msg As String = MsgBox("Are you sure do you want to delete? " & vbNewLine & vbNewLine & cardArgs.Title.ToUpper, MsgBoxStyle.YesNo)
        If msg = MsgBoxResult.Yes Then
            'execute delete
            client.Delete(cardArgs.Key)
            'refresh client
            Await CardContainer1.AddRangeAsync(client.GetClientCards())

        End If

        'reset
        cardArgs.Key = Nothing
        '.Text = "Client List"

        Me.TopMost = True
    End Sub

    Private Sub lbllogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbllogout.Click

        Me.Close()
        Dashboard.Show()


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        'if client is not selected in list


        If cardArgs.Key = Nothing Then

            MsgBox("Select Client from List", MsgBoxStyle.Exclamation)

            Exit Sub
        End If

        ViewClient.ShowDialog()
        cardArgs.Key = Nothing

    End Sub

    'if user role is manager then access all,if not access view only
    Sub AccessGranted(ByVal role As String)
        If role.ToLower = "manager" Then
            ButtonVisible(True)
        Else
            ButtonVisible(False)
        End If
    End Sub

    Sub ButtonVisible(ByVal i As Boolean)
        btnadd.Visible = i
        btnedit.Visible = i
        btndelete.Visible = i
        btnreports.Visible = i
        btnarchive.Visible = i
    End Sub

    Private Async Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Await CardContainer1.FilterAsync(txtsearch.Text)
    End Sub
End Class