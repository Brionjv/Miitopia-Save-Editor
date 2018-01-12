Public Class Repair_save
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim Rcommon As String
    Dim Rhero As String
    Dim Rquest As String
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
        TextBox_fpath_common.Text = Rcommon
        readRcommon()
        makebakRcommon()
    End Sub

    Private Sub text_open_MouseMove(sender As Object, e As EventArgs) Handles text_open.MouseMove, Button_Open.MouseMove
        Button_Open.BackgroundImage = My.Resources.button_save
        If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to open common.sav"
        ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour ouvrir common.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub text_open_MouseLeave(sender As Object, e As EventArgs) Handles text_open.MouseLeave, Button_Open.MouseLeave
        Button_Open.BackgroundImage = My.Resources.button_open
        Descrip_panel.Visible = False
    End Sub

    Private Sub text_save_Click(sender As Object, e As EventArgs) Handles text_save.Click
        If valu_header.BackColor = Color.LightCoral Then
            Dim Writer As New PackageIO.Writer(Rcommon, PackageIO.Endian.Little)
            Writer.Position = &H0
            Writer.WriteUInt64(4)
        End If
        Button_Open.Visible = True
        Button_Save.Visible = False
    End Sub

    Private Sub text_save_MouseMove(sender As Object, e As EventArgs) Handles text_save.MouseMove, Button_Save.MouseMove
        Button_Save.BackgroundImage = My.Resources.button_open
        If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to repair common.sav"
        ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour réparer common.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub text_save_MouseLeave(sender As Object, e As EventArgs) Handles text_save.MouseLeave, Button_Save.MouseLeave
        Button_Save.BackgroundImage = My.Resources.button_save
        Descrip_panel.Visible = False
    End Sub

    Public Sub readRcommon()
        Try
            Dim Reader As New PackageIO.Reader(Rcommon, PackageIO.Endian.Little)
            Reader.Position = &H0
            valu_header.Text = Reader.ReadHexString(8)
            Button_Open.Visible = False
            Button_Save.Visible = True
        Catch ex As Exception
            If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : Read common.sav"
                fdialog.Msg.Text = "Oops, something goes wrong" & vbNewLine & "opening of common.sav failed, please report this issue or try again"
                fdialog.ShowDialog()
            ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Lecture common.sav"
                fdialog.Msg.Text = "Oups, quelque chose ne va pas" & vbNewLine & "l'ouverture de common.sav a échoué, veuillez signalez cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If
            Button_Open.Visible = True
            Button_Save.Visible = False
        End Try
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

    Private Sub text_open_hero_Click(sender As Object, e As EventArgs) Handles Text_open_hero.Click
        Dim open As New OpenFileDialog
        If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
            fdialog.Title.Text = "Miitopia Save Editor"
            fdialog.Msg.Text = "Open hero.sav file" & vbNewLine & "Miitopia Save Editor will make a backup of your save file, check ''bakRepair'' folder" & vbNewLine & "Make a backup of your entire save file folder in case"
            fdialog.ShowDialog()
        ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
            fdialog.Title.Text = "Miitopia Save Editor"
            fdialog.Msg.Text = "Ouvrez le fichier hero.sav" & vbNewLine & "Miitopia Save Editor va faire une copie de votre sauvegarde, vérifiez le dossier ''bakRepair''" & vbNewLine & "Faites une copie du dossier entier de sauvegarde au cas où"
            fdialog.ShowDialog()
        End If
        open.Filter = "SAV files|*hero.sav"
        open.Title = "Open save hero.sav"
        open.ShowDialog()
        Rhero = open.FileName
        TextBox_fpath_hero.Text = Rhero
        readRhero()
        makebakRhero()
    End Sub

    Private Sub text_open_hero_MouseMove(sender As Object, e As EventArgs) Handles Text_open_hero.MouseMove, Button_open_hero.MouseMove
        Button_open_hero.BackgroundImage = My.Resources.button_save
        If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to open hero.sav"
        ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour ouvrir hero.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub text_open_hero_MouseLeave(sender As Object, e As EventArgs) Handles Text_open_hero.MouseLeave, Button_open_hero.MouseLeave
        Button_open_hero.BackgroundImage = My.Resources.button_open
        Descrip_panel.Visible = False
    End Sub

    Private Sub text_save_hero_Click(sender As Object, e As EventArgs) Handles Text_save_hero.Click
        If valu_header_hero.BackColor = Color.LightCoral Then
            Dim Writer As New PackageIO.Writer(Rhero, PackageIO.Endian.Little)
            Writer.Position = &H0
            Writer.WriteUInt64(42949672972)
        End If
        Button_open_hero.Visible = True
        Button_save_hero.Visible = False
    End Sub

    Private Sub text_save_hero_MouseMove(sender As Object, e As EventArgs) Handles Text_save_hero.MouseMove, Button_save_hero.MouseMove
        Button_save_hero.BackgroundImage = My.Resources.button_open
        If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to repair hero.sav"
        ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour réparer hero.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub text_save_hero_MouseLeave(sender As Object, e As EventArgs) Handles Text_save_hero.MouseLeave, Button_save_hero.MouseLeave
        Button_save_hero.BackgroundImage = My.Resources.button_save
        Descrip_panel.Visible = False
    End Sub

    Public Sub readRhero()
        Try
            Dim Reader As New PackageIO.Reader(Rhero, PackageIO.Endian.Little)
            Reader.Position = &H0
            valu_header_hero.Text = Reader.ReadHexString(8)
            Button_open_hero.Visible = False
            Button_save_hero.Visible = True
        Catch ex As Exception
            If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : Read hero.sav"
                fdialog.Msg.Text = "Oops, something goes wrong" & vbNewLine & "opening of hero.sav failed, please report this issue or try again"
                fdialog.ShowDialog()
            ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Lecture hero.sav"
                fdialog.Msg.Text = "Oups, quelque chose ne va pas" & vbNewLine & "l'ouverture de hero.sav a échoué, veuillez signalez cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If
            Button_open_hero.Visible = True
            Button_save_hero.Visible = False
        End Try
    End Sub

    Public Sub makebakRhero()
        Try
            If Miitopia_SE.Filever_text.Text = "EU" Then
                My.Computer.FileSystem.CopyFile(
                          Rhero,
                        applicationpath & "\bakRepair\hero.sav\EUR\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\hero.sav")
            End If
            If Miitopia_SE.Filever_text.Text = "US" Then
                My.Computer.FileSystem.CopyFile(
                          Rhero,
                        applicationpath & "\bakRepair\hero.sav\USA\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\hero.sav")
            End If
            If Miitopia_SE.Filever_text.Text = "JP" Then
                My.Computer.FileSystem.CopyFile(
                          Rhero,
                        applicationpath & "\bakRepair\hero.sav\JPN\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\hero.sav")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub text_open_quest_Click(sender As Object, e As EventArgs) Handles Text_open_quest.Click
        Dim open As New OpenFileDialog
        If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
            fdialog.Title.Text = "Miitopia Save Editor"
            fdialog.Msg.Text = "Open quest.sav file" & vbNewLine & "Miitopia Save Editor will make a backup of your save file, check ''bakRepair'' folder" & vbNewLine & "Make a backup of your entire save file folder in case"
            fdialog.ShowDialog()
        ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
            fdialog.Title.Text = "Miitopia Save Editor"
            fdialog.Msg.Text = "Ouvrez le fichier quest.sav" & vbNewLine & "Miitopia Save Editor va faire une copie de votre sauvegarde, vérifiez le dossier ''bakRepair''" & vbNewLine & "Faites une copie du dossier entier de sauvegarde au cas où"
            fdialog.ShowDialog()
        End If
        open.Filter = "SAV files|*quest.sav"
        open.Title = "Open save quest.sav"
        open.ShowDialog()
        Rquest = open.FileName
        TextBox_fpath_quest.Text = Rquest
        readRquest()
        makebakRquest()
    End Sub

    Private Sub text_open_quest_MouseMove(sender As Object, e As EventArgs) Handles Text_open_quest.MouseMove, Button_open_quest.MouseMove
        Button_Open_quest.BackgroundImage = My.Resources.button_save
        If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to open quest.sav"
        ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour ouvrir quest.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub text_open_quest_MouseLeave(sender As Object, e As EventArgs) Handles Text_open_quest.MouseLeave, Button_open_quest.MouseLeave
        Button_Open_quest.BackgroundImage = My.Resources.button_open
        Descrip_panel.Visible = False
    End Sub

    Private Sub text_save_quest_Click(sender As Object, e As EventArgs) Handles Text_save_quest.Click
        If valu_header_quest.BackColor = Color.LightCoral Then
            Dim Writer As New PackageIO.Writer(Rquest, PackageIO.Endian.Little)
            Writer.Position = &H0
            Writer.WriteInt64(9)
        End If
        Button_Open_quest.Visible = True
        Button_Save_quest.Visible = False
    End Sub

    Private Sub text_save_quest_MouseMove(sender As Object, e As EventArgs) Handles Text_save_quest.MouseMove, Button_save_quest.MouseMove
        Button_Save_quest.BackgroundImage = My.Resources.button_open
        If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to repair quest.sav"
        ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour réparer quest.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub text_save_quest_MouseLeave(sender As Object, e As EventArgs) Handles Text_save_quest.MouseLeave, Button_save_quest.MouseLeave
        Button_Save_quest.BackgroundImage = My.Resources.button_save
        Descrip_panel.Visible = False
    End Sub

    Public Sub readRquest()
        Try
            Dim Reader As New PackageIO.Reader(Rquest, PackageIO.Endian.Little)
            Reader.Position = &H0
            valu_header_quest.Text = Reader.ReadHexString(8)
            Button_Open_quest.Visible = False
            Button_Save_quest.Visible = True
        Catch ex As Exception
            If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : Read quest.sav"
                fdialog.Msg.Text = "Oops, something goes wrong" & vbNewLine & "opening of quest.sav failed, please report this issue or try again"
                fdialog.ShowDialog()
            ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Lecture quest.sav"
                fdialog.Msg.Text = "Oups, quelque chose ne va pas" & vbNewLine & "l'ouverture de quest.sav a échoué, veuillez signalez cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If
            Button_Open_quest.Visible = True
            Button_Save_quest.Visible = False
        End Try
    End Sub

    Public Sub makebakRquest()
        Try
            If Miitopia_SE.Filever_text.Text = "EU" Then
                My.Computer.FileSystem.CopyFile(
                          Rquest,
                        applicationpath & "\bakRepair\quest.sav\EUR\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\quest.sav")
            End If
            If Miitopia_SE.Filever_text.Text = "US" Then
                My.Computer.FileSystem.CopyFile(
                          Rquest,
                        applicationpath & "\bakRepair\quest.sav\USA\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\quest.sav")
            End If
            If Miitopia_SE.Filever_text.Text = "JP" Then
                My.Computer.FileSystem.CopyFile(
                          Rquest,
                        applicationpath & "\bakRepair\quest.sav\JPN\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\quest.sav")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub hidepanel()
        Panel_common.Visible = False
        Panel_hero.Visible = False
        Panel_quest.Visible = False
    End Sub

    Public Sub Hidefilepath()
        File_path_common.Visible = False
        File_path_quest.Visible = False
        File_path_hero.Visible = False
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

    Private Sub MSE_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MSE_header.MouseDown, MSE_logo.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub MSE_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MSE_header.MouseUp, MSE_logo.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub MSE_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MSE_header.MouseMove, MSE_logo.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Private Sub valu_header_TextChanged(sender As Object, e As EventArgs) Handles valu_header.TextChanged
        If valu_header.Text <> "0400000000000000" Then
            valu_header.BackColor = Color.LightCoral
        Else
            valu_header.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub Group_common_Click(sender As Object, e As EventArgs) Handles Group_common.Click, Text_common.Click
        Hidefilepath()
        hidepanel()
        File_path_common.Visible = True
        Panel_common.Visible = True
    End Sub

    Private Sub Group_common_MouseMove(sender As Object, e As EventArgs) Handles Group_common.MouseMove, Text_common.MouseMove
        Group_common.ForeColor = Color.WhiteSmoke
        Text_common.ForeColor = Color.WhiteSmoke
        If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to try to repair common.sav"
        ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour tenter de réparer common.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Group_common_MouseLeave(sender As Object, e As EventArgs) Handles Group_common.MouseLeave
        Group_common.ForeColor = Color.Black
        Text_common.ForeColor = Color.Black
        Descrip_panel.Visible = False
    End Sub

    Private Sub valu_header_hero_TextChanged(sender As Object, e As EventArgs) Handles valu_header_hero.TextChanged
        If valu_header_hero.Text <> "0C0000000A000000" Then
            valu_header_hero.BackColor = Color.LightCoral
        Else
            valu_header_hero.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub Group_hero_Click(sender As Object, e As EventArgs) Handles Group_hero.Click, Text_hero.Click
        Hidefilepath()
        hidepanel()
        File_path_hero.Visible = True
        Panel_hero.Visible = True
    End Sub

    Private Sub Group_hero_MouseMove(sender As Object, e As EventArgs) Handles Group_hero.MouseMove, Text_hero.MouseMove
        Group_hero.ForeColor = Color.WhiteSmoke
        Text_hero.ForeColor = Color.WhiteSmoke
        If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to try to repair hero.sav"
        ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour tenter de réparer hero.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Group_hero_MouseLeave(sender As Object, e As EventArgs) Handles Group_hero.MouseLeave
        Group_hero.ForeColor = Color.Black
        Text_hero.ForeColor = Color.Black
        Descrip_panel.Visible = False
    End Sub

    Private Sub valu_header_quest_TextChanged(sender As Object, e As EventArgs) Handles valu_header_quest.TextChanged
        If valu_header_quest.Text <> "0900000000000000" Then
            valu_header_quest.BackColor = Color.LightCoral
        Else
            valu_header_quest.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub Group_quest_Click(sender As Object, e As EventArgs) Handles Group_quest.Click, Text_quest.Click
        Hidefilepath()
        hidepanel()
        File_path_quest.Visible = True
        Panel_quest.Visible = True
    End Sub

    Private Sub Group_quest_MouseMove(sender As Object, e As EventArgs) Handles Group_quest.MouseMove, Text_quest.MouseMove
        Group_quest.ForeColor = Color.WhiteSmoke
        Text_quest.ForeColor = Color.WhiteSmoke
        If Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to try to repair quest.sav"
        ElseIf Miitopia_SE.Select_language.SelectedItem = Miitopia_SE.Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour tenter de réparer quest.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Group_quest_MouseLeave(sender As Object, e As EventArgs) Handles Group_quest.MouseLeave
        Group_quest.ForeColor = Color.Black
        Text_quest.ForeColor = Color.Black
        Descrip_panel.Visible = False
    End Sub

End Class