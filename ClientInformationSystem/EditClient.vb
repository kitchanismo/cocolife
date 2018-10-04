Public Class EditClient
    'instantiate client model
    Dim cm As New ClientService
    'initialize all data to client models to be edit
    Sub init()
        cm.policyNumber = txtPolicy.Text
        cm.firstName = txtFirstName.Text
        cm.lastName = txtLastName.Text
        cm.middleName = txtMiddle.Text
        cm.address = txtAddress.Text
        cm.gender = cmbGender.Text
        cm.contact = txtContact.Text
        cm.civil = cmbStatus.Text
        cm.birthDate = txtBirth.Text
        cm.promoOfficer = txtPromo.Text
        cm.salesOfficer = txtSales.Text
        cm.appointDate = txtAppointment.Text
        cm.insuredDate = txtInsured.Text
    End Sub

    'this method will display data from designated controls
    Sub showData()

        'get policy number in main form when double click
        cm.id = MainForm.cardArgs.Key.ToString

        'call Show data where policy number will get
        cm.ShowClientById(cm.id)

        'assign those data to controls
        txtPolicy.Text = cm.policyNumber
        txtFirstName.Text = cm.firstName
        txtLastName.Text = cm.lastName
        txtMiddle.Text = cm.middleName
        txtAddress.Text = cm.address
        cmbGender.Text = cm.gender
        txtContact.Text = cm.contact
        cmbStatus.Text = cm.civil
        txtBirth.Text = cm.birthDate
        txtPromo.Text = cm.promoOfficer
        txtSales.Text = cm.salesOfficer
        txtAppointment.Text = cm.appointDate
        txtInsured.Text = cm.insuredDate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        init()

        If IsValidateInput() = False Then
            MsgBox("Fullname is required", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        cm.Update(cm.id)
        MainForm.cardArgs.Key = Nothing
        Me.Close()
    End Sub

    Private Sub EditClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Public Function IsValidateInput() As Boolean
        'put here another validations to other properties if you want
        If txtLastName.Text = "" Or txtFirstName.Text = "" Or txtMiddle.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        pos = GetLocation(Me)
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location = SetLocation(pos, MousePosition)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class