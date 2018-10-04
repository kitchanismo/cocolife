Public Class ArchiveClient

    Dim cm As New ClientService
    Dim id As Integer = 0

    Private Sub ArchiveClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cm.ShowArchive(lvClient)
    End Sub

    Private Sub lvClient_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvClient.MouseClick
        'assign policy number when client is select
        With lvClient.SelectedItems(0)
            id = .SubItems(0).Text
            lblclient.Text = "Client List - " & .SubItems(2).Text.ToUpper
        End With
    End Sub

    Private Sub btnretrive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnretrive.Click
        'if client is not selected in list
        If lvClient.SelectedItems.Count = 0 Or id = 0 Then
            MsgBox("Select Client from List", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        cm.Retrive(id)
        cm.ShowArchive(lvClient)
        lblclient.Text = "Client List"
        id = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        pos = GetLocation(Me)
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location = SetLocation(pos, MousePosition)
        End If
    End Sub

End Class