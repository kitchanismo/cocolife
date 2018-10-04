Public Class ReportPrintPreview
    Dim cm As New ClientService

    Private Sub PrintPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view()
        Dim _from As String = Reports.dtpFrom.Value.ToLongDateString
        Dim _to As String = Reports.dtpTo.Value.ToLongDateString

        lbldate.Text = "Reports from " & _from & " to " & _to
        Print()
        Me.Close()
    End Sub

    Sub view()
        Dim datefrom As Date = Reports.dtpFrom.Value.ToShortDateString
        Dim dateto As Date = Reports.dtpTo.Value.ToShortDateString
        cm.generateReports(lvClient, datefrom.AddDays(-1), dateto.AddDays(1))
    End Sub



    Private Sub Print()
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(50, 50, 30, 10)
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class