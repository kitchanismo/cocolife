Public Class ViewClient
    'instantiate client model
    Dim cm As New ClientService

    'this method will display data from designated controls
    Public Sub showData()

        'get policy number in main form when double click
        cm.id = MainForm.cardArgs.Key

        'call Show data where policy number will get
        cm.ShowClientById(cm.id)

        'assign those data to controls
        txtPolicy.Text = cm.policyNumber
        txtFirstName.Text = cm.firstName
        txtLastName.Text = cm.lastName
        txtMiddle.Text = cm.middleName
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
  
    Private Sub EditClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       showData()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        ClientPrintPreview.Show()
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        pos = GetLocation(Me)
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location = SetLocation(pos, MousePosition)
        End If
    End Sub

    Private Sub txtPolicy_TextChanged(sender As Object, e As EventArgs) Handles txtPolicy.TextChanged

    End Sub
End Class