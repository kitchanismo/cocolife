<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.txtrole = New System.Windows.Forms.Label()
        Me.timerdate = New System.Windows.Forms.Timer(Me.components)
        Me.btnreports = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.lbllogout = New System.Windows.Forms.Label()
        Me.pnbtns = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnarchive = New System.Windows.Forms.Button()
        Me.btnview = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CardContainer1 = New DynamicCard.CardContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnbtns.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnadd.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnadd.Location = New System.Drawing.Point(7, 241)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(103, 49)
        Me.btnadd.TabIndex = 46
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsearch.Location = New System.Drawing.Point(559, 93)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(511, 31)
        Me.txtsearch.TabIndex = 48
        Me.txtsearch.Text = " "
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnrefresh
        '
        Me.btnrefresh.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnrefresh.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnrefresh.Location = New System.Drawing.Point(7, 8)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(103, 31)
        Me.btnrefresh.TabIndex = 51
        Me.btnrefresh.Text = "REFRESH"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'txtrole
        '
        Me.txtrole.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtrole.AutoSize = True
        Me.txtrole.BackColor = System.Drawing.Color.Transparent
        Me.txtrole.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtrole.Location = New System.Drawing.Point(8, 615)
        Me.txtrole.Name = "txtrole"
        Me.txtrole.Size = New System.Drawing.Size(152, 20)
        Me.txtrole.TabIndex = 53
        Me.txtrole.Text = "User Role Date Time"
        '
        'timerdate
        '
        Me.timerdate.Enabled = True
        Me.timerdate.Interval = 1000
        '
        'btnreports
        '
        Me.btnreports.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnreports.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnreports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreports.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnreports.Location = New System.Drawing.Point(7, 66)
        Me.btnreports.Name = "btnreports"
        Me.btnreports.Size = New System.Drawing.Size(103, 31)
        Me.btnreports.TabIndex = 54
        Me.btnreports.Text = "REPORT"
        Me.btnreports.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnedit.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnedit.Location = New System.Drawing.Point(7, 299)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(103, 49)
        Me.btnedit.TabIndex = 55
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btndelete.BackColor = System.Drawing.Color.MistyRose
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Crimson
        Me.btndelete.Location = New System.Drawing.Point(7, 357)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(103, 49)
        Me.btndelete.TabIndex = 56
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'lbllogout
        '
        Me.lbllogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbllogout.AutoSize = True
        Me.lbllogout.BackColor = System.Drawing.Color.Transparent
        Me.lbllogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbllogout.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogout.ForeColor = System.Drawing.Color.Crimson
        Me.lbllogout.Location = New System.Drawing.Point(986, 614)
        Me.lbllogout.Name = "lbllogout"
        Me.lbllogout.Size = New System.Drawing.Size(63, 25)
        Me.lbllogout.TabIndex = 57
        Me.lbllogout.Text = "Back"
        '
        'pnbtns
        '
        Me.pnbtns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnbtns.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnbtns.Controls.Add(Me.Panel1)
        Me.pnbtns.Controls.Add(Me.btnarchive)
        Me.pnbtns.Controls.Add(Me.btnview)
        Me.pnbtns.Controls.Add(Me.btnrefresh)
        Me.pnbtns.Controls.Add(Me.btnadd)
        Me.pnbtns.Controls.Add(Me.btndelete)
        Me.pnbtns.Controls.Add(Me.btnreports)
        Me.pnbtns.Controls.Add(Me.btnedit)
        Me.pnbtns.Location = New System.Drawing.Point(954, 131)
        Me.pnbtns.Name = "pnbtns"
        Me.pnbtns.Size = New System.Drawing.Size(116, 474)
        Me.pnbtns.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel1.Location = New System.Drawing.Point(9, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(99, 3)
        Me.Panel1.TabIndex = 61
        '
        'btnarchive
        '
        Me.btnarchive.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnarchive.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnarchive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnarchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnarchive.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnarchive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnarchive.Location = New System.Drawing.Point(8, 105)
        Me.btnarchive.Name = "btnarchive"
        Me.btnarchive.Size = New System.Drawing.Size(103, 31)
        Me.btnarchive.TabIndex = 58
        Me.btnarchive.Text = "ARCHIVE"
        Me.btnarchive.UseVisualStyleBackColor = False
        '
        'btnview
        '
        Me.btnview.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnview.BackColor = System.Drawing.Color.LightBlue
        Me.btnview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnview.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnview.Location = New System.Drawing.Point(7, 415)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(103, 49)
        Me.btnview.TabIndex = 57
        Me.btnview.Text = "VIEW"
        Me.btnview.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipTitle = "creator"
        '
        'CardContainer1
        '
        Me.CardContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CardContainer1.BackColor = System.Drawing.Color.White
        Me.CardContainer1.Layout = DynamicCard.Layout.Vertical
        Me.CardContainer1.Location = New System.Drawing.Point(12, 131)
        Me.CardContainer1.Name = "CardContainer1"
        Me.CardContainer1.OrderBy = DynamicCard.OrderBy.ASCENDING
        Me.CardContainer1.Primary = System.Drawing.Color.Tan
        Me.CardContainer1.Secondary = System.Drawing.Color.DarkGoldenrod
        Me.CardContainer1.Size = New System.Drawing.Size(933, 474)
        Me.CardContainer1.TabIndex = 61
        Me.CardContainer1.Theme = DynamicCard.Themes.Light
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(483, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "SEARCH"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1077, 646)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CardContainer1)
        Me.Controls.Add(Me.pnbtns)
        Me.Controls.Add(Me.lbllogout)
        Me.Controls.Add(Me.txtrole)
        Me.Controls.Add(Me.txtsearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main_Form"
        Me.pnbtns.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents txtrole As System.Windows.Forms.Label
    Friend WithEvents timerdate As System.Windows.Forms.Timer
    Friend WithEvents btnreports As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents lbllogout As System.Windows.Forms.Label
    Friend WithEvents pnbtns As System.Windows.Forms.Panel
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnarchive As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CardContainer1 As DynamicCard.CardContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
