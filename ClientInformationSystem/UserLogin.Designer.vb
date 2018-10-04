<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserLogin))
        Me.btnlgn = New System.Windows.Forms.Button()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpword = New System.Windows.Forms.TextBox()
        Me.pnlogin = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Login = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.pnsignup = New System.Windows.Forms.Panel()
        Me.CboGender = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtconfirm = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtspword = New System.Windows.Forms.TextBox()
        Me.txtsuname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlogin.SuspendLayout()
        Me.Login.SuspendLayout()
        Me.pnsignup.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnlgn
        '
        Me.btnlgn.BackColor = System.Drawing.Color.Peru
        Me.btnlgn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlgn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlgn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlgn.ForeColor = System.Drawing.Color.White
        Me.btnlgn.Location = New System.Drawing.Point(263, 309)
        Me.btnlgn.Name = "btnlgn"
        Me.btnlgn.Size = New System.Drawing.Size(96, 39)
        Me.btnlgn.TabIndex = 6
        Me.btnlgn.Text = "Login"
        Me.btnlgn.UseVisualStyleBackColor = False
        '
        'txtuname
        '
        Me.txtuname.BackColor = System.Drawing.Color.White
        Me.txtuname.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtuname.Location = New System.Drawing.Point(129, 125)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(247, 37)
        Me.txtuname.TabIndex = 1
        Me.txtuname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(123, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(123, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'txtpword
        '
        Me.txtpword.BackColor = System.Drawing.Color.White
        Me.txtpword.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpword.Location = New System.Drawing.Point(129, 227)
        Me.txtpword.Name = "txtpword"
        Me.txtpword.Size = New System.Drawing.Size(247, 37)
        Me.txtpword.TabIndex = 2
        Me.txtpword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpword.UseSystemPasswordChar = True
        '
        'pnlogin
        '
        Me.pnlogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlogin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.pnlogin.Controls.Add(Me.Label3)
        Me.pnlogin.Controls.Add(Me.Login)
        Me.pnlogin.Controls.Add(Me.btnclose)
        Me.pnlogin.Controls.Add(Me.txtpword)
        Me.pnlogin.Controls.Add(Me.txtuname)
        Me.pnlogin.Controls.Add(Me.Label2)
        Me.pnlogin.Controls.Add(Me.btnlgn)
        Me.pnlogin.Controls.Add(Me.Label1)
        Me.pnlogin.ForeColor = System.Drawing.Color.White
        Me.pnlogin.Location = New System.Drawing.Point(137, 155)
        Me.pnlogin.Name = "pnlogin"
        Me.pnlogin.Size = New System.Drawing.Size(479, 444)
        Me.pnlogin.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(4, 415)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Sign up"
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.Color.Tan
        Me.Login.Controls.Add(Me.lbltitle)
        Me.Login.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Login.Location = New System.Drawing.Point(0, 0)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(500, 41)
        Me.Login.TabIndex = 7
        '
        'lbltitle
        '
        Me.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.White
        Me.lbltitle.Location = New System.Drawing.Point(2, 1)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(179, 33)
        Me.lbltitle.TabIndex = 20
        Me.lbltitle.Text = "Please, login"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.OldLace
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnclose.Location = New System.Drawing.Point(149, 309)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(96, 39)
        Me.btnclose.TabIndex = 4
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'pnsignup
        '
        Me.pnsignup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnsignup.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.pnsignup.Controls.Add(Me.CboGender)
        Me.pnsignup.Controls.Add(Me.Label9)
        Me.pnsignup.Controls.Add(Me.Label4)
        Me.pnsignup.Controls.Add(Me.txtconfirm)
        Me.pnsignup.Controls.Add(Me.Label8)
        Me.pnsignup.Controls.Add(Me.Panel3)
        Me.pnsignup.Controls.Add(Me.txtspword)
        Me.pnsignup.Controls.Add(Me.txtsuname)
        Me.pnsignup.Controls.Add(Me.Label6)
        Me.pnsignup.Controls.Add(Me.btnSave)
        Me.pnsignup.Controls.Add(Me.Label7)
        Me.pnsignup.ForeColor = System.Drawing.Color.White
        Me.pnsignup.Location = New System.Drawing.Point(137, 155)
        Me.pnsignup.Name = "pnsignup"
        Me.pnsignup.Size = New System.Drawing.Size(479, 444)
        Me.pnsignup.TabIndex = 9
        '
        'CboGender
        '
        Me.CboGender.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboGender.FormattingEnabled = True
        Me.CboGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.CboGender.Location = New System.Drawing.Point(128, 178)
        Me.CboGender.Name = "CboGender"
        Me.CboGender.Size = New System.Drawing.Size(247, 38)
        Me.CboGender.TabIndex = 83
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(124, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 30)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Back to login"
        '
        'txtconfirm
        '
        Me.txtconfirm.BackColor = System.Drawing.Color.White
        Me.txtconfirm.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtconfirm.Location = New System.Drawing.Point(128, 336)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.Size = New System.Drawing.Size(247, 37)
        Me.txtconfirm.TabIndex = 9
        Me.txtconfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtconfirm.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(122, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 30)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Confirm Password"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Tan
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel3.Location = New System.Drawing.Point(-2, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(489, 42)
        Me.Panel3.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 33)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Please, Sign up"
        '
        'txtspword
        '
        Me.txtspword.BackColor = System.Drawing.Color.White
        Me.txtspword.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtspword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtspword.Location = New System.Drawing.Point(129, 256)
        Me.txtspword.Name = "txtspword"
        Me.txtspword.Size = New System.Drawing.Size(247, 37)
        Me.txtspword.TabIndex = 2
        Me.txtspword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtspword.UseSystemPasswordChar = True
        '
        'txtsuname
        '
        Me.txtsuname.BackColor = System.Drawing.Color.White
        Me.txtsuname.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsuname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsuname.Location = New System.Drawing.Point(129, 101)
        Me.txtsuname.Name = "txtsuname"
        Me.txtsuname.Size = New System.Drawing.Size(247, 37)
        Me.txtsuname.TabIndex = 1
        Me.txtsuname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(122, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 30)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Password"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Peru
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(367, 390)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 39)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(123, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 30)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(12, 643)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 30)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "kitchanismo"
        '
        'UserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1091, 683)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlogin)
        Me.Controls.Add(Me.pnsignup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "UserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlogin.ResumeLayout(False)
        Me.pnlogin.PerformLayout()
        Me.Login.ResumeLayout(False)
        Me.Login.PerformLayout()
        Me.pnsignup.ResumeLayout(False)
        Me.pnsignup.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnlgn As System.Windows.Forms.Button
    Friend WithEvents txtuname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpword As System.Windows.Forms.TextBox
    Friend WithEvents pnlogin As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Login As System.Windows.Forms.Panel
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnsignup As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtspword As TextBox
    Friend WithEvents txtsuname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtconfirm As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CboGender As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
End Class
