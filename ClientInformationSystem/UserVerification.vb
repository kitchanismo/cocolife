Imports DynamicCard

Public Class UserVerification
    Dim user As New UserService
    Public cardArgs As New CardEventArgs

    Private Sub Card_OnClick(ByVal sender As Object, ByVal e As CardEventArgs) Handles CardContainer1.OnClick
        cardArgs = e
    End Sub

    Private Sub UserVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CardContainer1.AddRangeAsync(user.GetUserCards())
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboStatus.SelectedIndexChanged
        If CboStatus.Text = "Verified" Then
            CardContainer1.FilterByCategoryAsync("true")
        ElseIf CboStatus.Text = "Unverified" Then
            CardContainer1.FilterByCategoryAsync("false")
        Else
            CardContainer1.FilterAsync()
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        CardContainer1.FilterAsync(txtsearch.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cardArgs.Title = Nothing Then
            MsgBox("Select User", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cardArgs.Category = True Then
            MsgBox(cardArgs.Title.ToUpper() & " is Already Verified", MsgBoxStyle.Information)
            Exit Sub
        End If

        user.UpdateStatus(cardArgs.Title)
        CardContainer1.AddRangeAsync(user.GetUserCards())
        MsgBox(cardArgs.Title.ToUpper() & " is Now Verified", MsgBoxStyle.Information)
        cardArgs.Title = Nothing
    End Sub
End Class