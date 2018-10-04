Imports DynamicCard

Public Class UserCard
    Inherits Card

    Friend WithEvents lblisverify As Label

    Sub New()
        InitializeComponent()
    End Sub


    Private Sub InitializeComponent()
        Me.lblisverify = New System.Windows.Forms.Label()
        CType(Me.CardImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblSubtitle
        '
        Me.LblSubtitle.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubtitle.Location = New System.Drawing.Point(10, 229)
        Me.LblSubtitle.Size = New System.Drawing.Size(158, 23)
        '
        'LblTitle
        '
        Me.LblTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblTitle.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(10, 195)
        Me.LblTitle.Size = New System.Drawing.Size(159, 23)
        Me.LblTitle.Text = Me.Title
        '
        'CardImage
        '
        Me.CardImage.BackColor = System.Drawing.Color.Tan
        Me.CardImage.Size = New System.Drawing.Size(214, 175)
        '
        'lblisverify
        '
        Me.lblisverify.AutoSize = True
        Me.lblisverify.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblisverify.Location = New System.Drawing.Point(10, 266)
        Me.lblisverify.Name = "lblisverify"
        Me.lblisverify.Size = New System.Drawing.Size(57, 20)
        Me.lblisverify.TabIndex = 3
        Me.lblisverify.Text = "Label1"
        '
        'UserCard
        '
        Me.Controls.Add(Me.lblisverify)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "UserCard"
        Me.Size = New System.Drawing.Size(214, 306)
        Me.Controls.SetChildIndex(Me.CardImage, 0)
        Me.Controls.SetChildIndex(Me.LblSubtitle, 0)
        Me.Controls.SetChildIndex(Me.LblTitle, 0)
        Me.Controls.SetChildIndex(Me.lblisverify, 0)
        CType(Me.CardImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private Sub ClientCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LblTitle.Text = Me.Title.ToUpper
        Me.LblSubtitle.Text = Me.Subtitle
        If Me.Category = "true" Then
            Me.lblisverify.Text = "Verified"
            lblisverify.ForeColor = Color.Green
        Else
            Me.lblisverify.Text = "Unverified"
            lblisverify.ForeColor = Color.Red
        End If

        ResizePhoto()
    End Sub

    Protected Overrides Sub OnGotFocus(e As EventArgs)

        MyBase.OnGotFocus(e)
        Me.BackColor = Color.Tan
        LblTitle.ForeColor = Color.White
        LblSubtitle.ForeColor = Color.White
    End Sub

    Protected Overrides Sub OnLostFocus(e As EventArgs)
        MyBase.OnLostFocus(e)

        Me.BackColor = Color.White

        LblSubtitle.ForeColor = Color.Tan
        LblTitle.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub

    Protected Overrides Sub ResizePhoto()
        MyBase.ResizePhoto()
    End Sub


End Class
