<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserVerification
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CardContainer1 = New DynamicCard.CardContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.CboStatus = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Tan
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(36, 534)
        Me.Panel1.TabIndex = 77
        '
        'CardContainer1
        '
        Me.CardContainer1.BackColor = System.Drawing.Color.White
        Me.CardContainer1.Layout = DynamicCard.Layout.Vertical
        Me.CardContainer1.Location = New System.Drawing.Point(53, 61)
        Me.CardContainer1.Name = "CardContainer1"
        Me.CardContainer1.OrderBy = DynamicCard.OrderBy.ASCENDING
        Me.CardContainer1.Primary = System.Drawing.Color.Tan
        Me.CardContainer1.Secondary = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CardContainer1.Size = New System.Drawing.Size(784, 403)
        Me.CardContainer1.TabIndex = 78
        Me.CardContainer1.Theme = DynamicCard.Themes.Light
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.Honeydew
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(743, 478)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 31)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "Verify"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsearch.Location = New System.Drawing.Point(314, 18)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(523, 31)
        Me.txtsearch.TabIndex = 80
        Me.txtsearch.Text = " "
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboStatus
        '
        Me.CboStatus.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboStatus.FormattingEnabled = True
        Me.CboStatus.Items.AddRange(New Object() {"Verified", "Unverified", "All"})
        Me.CboStatus.Location = New System.Drawing.Point(53, 20)
        Me.CboStatus.Name = "CboStatus"
        Me.CboStatus.Size = New System.Drawing.Size(183, 30)
        Me.CboStatus.TabIndex = 82
        Me.CboStatus.Text = " - Status -"
        '
        'UserVerification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(857, 519)
        Me.Controls.Add(Me.CboStatus)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CardContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "UserVerification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserVerification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CardContainer1 As DynamicCard.CardContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents CboStatus As ComboBox
End Class
