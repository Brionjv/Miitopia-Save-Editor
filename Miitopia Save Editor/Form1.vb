Public Class Form1
    Dim common As String
    Dim hero As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog
        open.Filter = "SAV files|*.sav"
        open.Title = "Open save common.sav"
        open.ShowDialog()
        common = open.FileName
        Readfilecommon()
    End Sub
    Private Sub Readfilecommon()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim open1 As New OpenFileDialog
        open1.Filter = "SAV files|*.sav"
        open1.Title = "Open save hero.sav"
        open1.ShowDialog()
        hero = open1.FileName
        Readfilehero()
    End Sub
    Private Sub Readfilehero()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label14.Text = TextBox2.Text & " Stats"
    End Sub
End Class
