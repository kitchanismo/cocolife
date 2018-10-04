Public Class ClientPrintPreview

    Private Sub ClientPrintPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showData()
        Print()
    End Sub

    Dim cm As New ClientService

    'this method will display data from designated controls
    Public Sub showData()

        'get policy number in main form when double click
        cm.id = MainForm.id.ToString

        'call Show data where policy number will get
        cm.ShowClientById(cm.id)

        'assign those data to controls
        txtPolicy.Text = cm.policyNumber
        txtLastName.Text = cm.firstName & " " & cm.middleName & " " & cm.lastName
        txtAddress.Text = cm.address
        txtgender.Text = cm.gender
        txtContact.Text = cm.contact
        txtcivil.Text = cm.civil
        txtBirth.Text = cm.birthDate
        txtPromo.Text = cm.promoOfficer
        txtSales.Text = cm.salesOfficer
        txtAppointment.Text = cm.appointDate
        txtInsured.Text = cm.insuredDate
    End Sub


    Private Sub Print()
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(50, 50, 30, 10)
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        Me.Close()
    End Sub
End Class