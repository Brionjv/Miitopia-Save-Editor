Public Class Form3
    Dim i As Integer
    Dim strmessage As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://www.paypal.me/Brionjv")
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        strmessage = "" & vbNewLine & "French language : " & vbNewLine & "Brion (gbatemp.net)" & vbNewLine & vbNewLine & "Spanish language : " & vbNewLine & "MiqellDestroyer (gbatemp.net)" & vbNewLine & vbNewLine & "Visual Studio 2012"
    End Sub

    Private Sub Timer1_tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i += 3
        Label1.Text += strmessage.Substring(i - 3, 3)
        If i = strmessage.Length Then Timer1.Enabled = False
    End Sub

    Private Sub Form3_Click(sender As Object, e As EventArgs) Handles MyBase.Click, Label1.Click, Label2.Click
        Me.Close()
    End Sub
End Class