Public Class AddClient
    'instantiate client model
    Dim cm As New ClientService
    'initialize all data to client models to be saved
    Sub init()
        cm.policyNumber = txtPolicy.Text
        cm.firstName = txtFirstName.Text
        cm.lastName = txtLastName.Text
        cm.middleName = txtMiddle.Text
        cm.address = txtAddress.Text
        cm.gender = cmbGender.Text
        cm.contact = Val(txtContact.Text)
        cm.civil = cmbStatus.Text
        cm.birthDate = txtBirth.Text
        cm.promoOfficer = txtPromo.Text
        cm.salesOfficer = txtSales.Text
        cm.appointDate = txtAppointment.Text
        cm.insuredDate = txtInsured.Text
    End Sub

    Private Sub SaveClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'call initialization
        init()

        If IsValidateInput() = False Then
            MsgBox("Policy Number and Fullname is required", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cm.isPolicyNumExist(txtPolicy.Text) Then
            MsgBox("Policy Number " & txtPolicy.Text & " is already taken! ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'call save data from client model
        cm.Insert()

        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Function IsValidateInput() As Boolean
        'put here another validations to other properties if you want
        If txtPolicy.Text = "" Or txtLastName.Text = "" Or txtFirstName.Text = "" Or txtMiddle.Text = "" Then
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

    Private Sub lblAppointment_Click(sender As Object, e As EventArgs) Handles lblAppointment.Click

    End Sub
End Class