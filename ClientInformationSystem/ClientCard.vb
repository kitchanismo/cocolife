Imports DynamicCard

Public Class ClientCard
    Inherits Card

    Sub New()
        InitializeComponent()
    End Sub


    Private Sub InitializeComponent()
        CType(Me.CardImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblSubtitle
        '
        Me.LblSubtitle.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubtitle.Location = New System.Drawing.Point(116, 48)
        Me.LblSubtitle.Size = New System.Drawing.Size(314, 23)
        '
        'LblTitle
        '
        Me.LblTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblTitle.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(115, 15)
        Me.LblTitle.Size = New System.Drawing.Size(315, 23)
        Me.LblTitle.Text = Me.Title
        '
        'CardImage
        '
        Me.CardImage.BackColor = System.Drawing.Color.Tan
        Me.CardImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.CardImage.Size = New System.Drawing.Size(99, 110)
        '
        'ClientCard
        '
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "ClientCard"
        Me.Size = New System.Drawing.Size(449, 110)
        CType(Me.CardImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


    Private Sub onFocus(sender As Object, e As EventArgs)
        Me.LblTitle.Text = Me.Title.ToUpper
        Me.LblSubtitle.Text = "Policy No: " & Me.Subtitle

        ResizePhoto()
    End Sub

    Private Sub ClientCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LblTitle.Text = Me.Title.ToUpper
        Me.LblSubtitle.Text = "Policy No: " & Me.Subtitle

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
