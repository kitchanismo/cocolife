Public Class Reports
    Dim cm As New ClientService

    Private Sub Reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpTo.Text = cm.getDate("max")
        dtpFrom.Text = cm.getDate("min")
        cm.showReports(lvClient)
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        view()
    End Sub

    Sub view()
        Dim datefrom As Date = dtpFrom.Value.ToShortDateString
        Dim dateto As Date = dtpTo.Value.ToShortDateString
        cm.generateReports(lvClient, datefrom.AddDays(-1), dateto.AddDays(1))
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReportPrintPreview.Show()
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        pos = GetLocation(Me)
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location = SetLocation(pos, MousePosition)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class