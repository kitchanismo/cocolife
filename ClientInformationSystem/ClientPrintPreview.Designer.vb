<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientPrintPreview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientPrintPreview))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.lblPolicy = New System.Windows.Forms.Label()
        Me.lblPromo = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblInsured = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPolicy = New System.Windows.Forms.TextBox()
        Me.txtInsured = New System.Windows.Forms.TextBox()
        Me.txtPromo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblAddr = New System.Windows.Forms.Label()
        Me.lblBday = New System.Windows.Forms.Label()
        Me.lblAppointment = New System.Windows.Forms.Label()
        Me.txtBirth = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtAppointment = New System.Windows.Forms.TextBox()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.txtcivil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(231, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 39)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Client Information"
        '
        'txtSales
        '
        Me.txtSales.BackColor = System.Drawing.Color.White
        Me.txtSales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSales.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSales.Location = New System.Drawing.Point(568, 171)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.ReadOnly = True
        Me.txtSales.Size = New System.Drawing.Size(198, 22)
        Me.txtSales.TabIndex = 100
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.White
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContact.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContact.Location = New System.Drawing.Point(130, 281)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(194, 22)
        Me.txtContact.TabIndex = 94
        '
        'lblPolicy
        '
        Me.lblPolicy.AutoSize = True
        Me.lblPolicy.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPolicy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPolicy.Location = New System.Drawing.Point(26, 134)
        Me.lblPolicy.Name = "lblPolicy"
        Me.lblPolicy.Size = New System.Drawing.Size(78, 23)
        Me.lblPolicy.TabIndex = 85
        Me.lblPolicy.Text = "Policy No:"
        '
        'lblPromo
        '
        Me.lblPromo.AutoSize = True
        Me.lblPromo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPromo.Location = New System.Drawing.Point(435, 133)
        Me.lblPromo.Name = "lblPromo"
        Me.lblPromo.Size = New System.Drawing.Size(107, 23)
        Me.lblPromo.TabIndex = 104
        Me.lblPromo.Text = "Promo Officer:"
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSales.Location = New System.Drawing.Point(442, 171)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(100, 23)
        Me.lblSales.TabIndex = 102
        Me.lblSales.Text = "Sales Officer:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(14, 318)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(87, 23)
        Me.lblStatus.TabIndex = 95
        Me.lblStatus.Text = "Civil Status:"
        '
        'lblInsured
        '
        Me.lblInsured.AutoSize = True
        Me.lblInsured.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsured.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInsured.Location = New System.Drawing.Point(440, 207)
        Me.lblInsured.Name = "lblInsured"
        Me.lblInsured.Size = New System.Drawing.Size(102, 23)
        Me.lblInsured.TabIndex = 107
        Me.lblInsured.Text = "Date Insured:"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(130, 357)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(311, 137)
        Me.txtAddress.TabIndex = 92
        '
        'txtPolicy
        '
        Me.txtPolicy.BackColor = System.Drawing.Color.White
        Me.txtPolicy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPolicy.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPolicy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPolicy.Location = New System.Drawing.Point(130, 134)
        Me.txtPolicy.Name = "txtPolicy"
        Me.txtPolicy.ReadOnly = True
        Me.txtPolicy.Size = New System.Drawing.Size(172, 22)
        Me.txtPolicy.TabIndex = 84
        '
        'txtInsured
        '
        Me.txtInsured.BackColor = System.Drawing.Color.White
        Me.txtInsured.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInsured.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsured.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtInsured.Location = New System.Drawing.Point(568, 207)
        Me.txtInsured.Name = "txtInsured"
        Me.txtInsured.ReadOnly = True
        Me.txtInsured.Size = New System.Drawing.Size(198, 22)
        Me.txtInsured.TabIndex = 98
        '
        'txtPromo
        '
        Me.txtPromo.BackColor = System.Drawing.Color.White
        Me.txtPromo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPromo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPromo.Location = New System.Drawing.Point(568, 133)
        Me.txtPromo.Name = "txtPromo"
        Me.txtPromo.ReadOnly = True
        Me.txtPromo.Size = New System.Drawing.Size(198, 22)
        Me.txtPromo.TabIndex = 99
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(14, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 23)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Contact No:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(37, 207)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(67, 23)
        Me.lblGender.TabIndex = 93
        Me.lblGender.Text = "Gender:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(19, 171)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(85, 23)
        Me.lblLastName.TabIndex = 105
        Me.lblLastName.Text = "Full Name:"
        '
        'lblAddr
        '
        Me.lblAddr.AutoSize = True
        Me.lblAddr.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAddr.Location = New System.Drawing.Point(29, 357)
        Me.lblAddr.Name = "lblAddr"
        Me.lblAddr.Size = New System.Drawing.Size(72, 23)
        Me.lblAddr.TabIndex = 101
        Me.lblAddr.Text = "Address:"
        '
        'lblBday
        '
        Me.lblBday.AutoSize = True
        Me.lblBday.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblBday.Location = New System.Drawing.Point(8, 243)
        Me.lblBday.Name = "lblBday"
        Me.lblBday.Size = New System.Drawing.Size(96, 23)
        Me.lblBday.TabIndex = 97
        Me.lblBday.Text = "Date of Birth:"
        '
        'lblAppointment
        '
        Me.lblAppointment.AutoSize = True
        Me.lblAppointment.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAppointment.Location = New System.Drawing.Point(406, 243)
        Me.lblAppointment.Name = "lblAppointment"
        Me.lblAppointment.Size = New System.Drawing.Size(136, 23)
        Me.lblAppointment.TabIndex = 106
        Me.lblAppointment.Text = "Appointment Date:"
        '
        'txtBirth
        '
        Me.txtBirth.BackColor = System.Drawing.Color.White
        Me.txtBirth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBirth.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBirth.Location = New System.Drawing.Point(130, 244)
        Me.txtBirth.Name = "txtBirth"
        Me.txtBirth.ReadOnly = True
        Me.txtBirth.Size = New System.Drawing.Size(194, 22)
        Me.txtBirth.TabIndex = 91
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.White
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastName.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(130, 172)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(281, 22)
        Me.txtLastName.TabIndex = 87
        '
        'txtAppointment
        '
        Me.txtAppointment.BackColor = System.Drawing.Color.White
        Me.txtAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAppointment.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppointment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAppointment.Location = New System.Drawing.Point(568, 243)
        Me.txtAppointment.Name = "txtAppointment"
        Me.txtAppointment.ReadOnly = True
        Me.txtAppointment.Size = New System.Drawing.Size(198, 22)
        Me.txtAppointment.TabIndex = 96
        '
        'txtgender
        '
        Me.txtgender.BackColor = System.Drawing.Color.White
        Me.txtgender.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtgender.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtgender.Location = New System.Drawing.Point(130, 208)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.ReadOnly = True
        Me.txtgender.Size = New System.Drawing.Size(194, 22)
        Me.txtgender.TabIndex = 108
        '
        'txtcivil
        '
        Me.txtcivil.BackColor = System.Drawing.Color.White
        Me.txtcivil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcivil.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcivil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcivil.Location = New System.Drawing.Point(130, 319)
        Me.txtcivil.Name = "txtcivil"
        Me.txtcivil.ReadOnly = True
        Me.txtcivil.Size = New System.Drawing.Size(194, 22)
        Me.txtcivil.TabIndex = 109
        '
        'ClientPrintPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(783, 672)
        Me.Controls.Add(Me.txtcivil)
        Me.Controls.Add(Me.txtgender)
        Me.Controls.Add(Me.txtAppointment)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtBirth)
        Me.Controls.Add(Me.lblAppointment)
        Me.Controls.Add(Me.lblBday)
        Me.Controls.Add(Me.lblAddr)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPromo)
        Me.Controls.Add(Me.txtInsured)
        Me.Controls.Add(Me.txtPolicy)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblInsured)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.lblPromo)
        Me.Controls.Add(Me.lblPolicy)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClientPrintPreview"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrintPreview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents txtcivil As System.Windows.Forms.TextBox
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents txtAppointment As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtBirth As System.Windows.Forms.TextBox
    Friend WithEvents lblAppointment As System.Windows.Forms.Label
    Friend WithEvents lblBday As System.Windows.Forms.Label
    Friend WithEvents lblAddr As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPromo As System.Windows.Forms.TextBox
    Friend WithEvents txtInsured As System.Windows.Forms.TextBox
    Friend WithEvents txtPolicy As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblInsured As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblSales As System.Windows.Forms.Label
    Friend WithEvents lblPromo As System.Windows.Forms.Label
    Friend WithEvents lblPolicy As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtSales As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
