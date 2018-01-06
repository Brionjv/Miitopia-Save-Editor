Public Class Repair_save
    Dim Rcommon As String
    Dim applicationpath = Application.StartupPath
    Dim fdialog As New Form2

    Private Sub text_open_Click(sender As Object, e As EventArgs) Handles text_open.Click
        Dim open As New OpenFileDialog
        If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
            fdialog.Title.Text = "Miitopia Save Editor"
            fdialog.Msg.Text = "Open common.sav file" & vbNewLine & "Miitopia Save Editor will make a backup of your save file, check ''bakRepair'' folder" & vbNewLine & "Make a backup of your entire save file folder in case"
            fdialog.ShowDialog()
        ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
            fdialog.Title.Text = "Miitopia Save Editor"
            fdialog.Msg.Text = "Ouvrez le fichier common.sav" & vbNewLine & "Miitopia Save Editor va faire une copie de votre sauvegarde, vérifiez le dossier ''bakRepair''" & vbNewLine & "Faites une copie du dossier entier de sauvegarde au cas où"
            fdialog.ShowDialog()
        End If
        open.Filter = "SAV files|*common.sav"
        open.Title = "Open save common.sav"
        open.ShowDialog()
        Rcommon = open.FileName
        readRcommon()
        makebakRcommon()
    End Sub

    Public Sub readRcommon()

    End Sub

    Public Sub makebakRcommon()
        Try
            If Miitopia_SE.Filever_text.Text = "EU" Then
                My.Computer.FileSystem.CopyFile(
                          Rcommon,
                        applicationpath & "\bakRepair\common.sav\EUR\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\common.sav")
            End If
            If Miitopia_SE.Filever_text.Text = "US" Then
                My.Computer.FileSystem.CopyFile(
                          Rcommon,
                        applicationpath & "\bakRepair\common.sav\USA\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\common.sav")
            End If
            If Miitopia_SE.Filever_text.Text = "JP" Then
                My.Computer.FileSystem.CopyFile(
                          Rcommon,
                        applicationpath & "\bakRepair\common.sav\JPN\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\common.sav")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ClosebuttonMouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.closebuttonred
    End Sub

    Private Sub ClosebuttonMouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.closebutton
    End Sub

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
        Miitopia_SE.Show()
    End Sub
End Class