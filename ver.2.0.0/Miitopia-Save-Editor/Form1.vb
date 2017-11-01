Imports System.Net
Imports PackageIO
Imports System.IO
Public Class Miitopia_SE
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim fdialog As New Form2
    Dim common As String
    Dim AudioMiitopia As System.IO.UnmanagedMemoryStream

    Public Sub Hidemenu() ' MSE Functions
        If Menu_panel.Width = 34 Then
            Menu_panel.Location = New Point(-35, 57)
        End If
        If Menu_panel.Width = 150 Then
            Menu_panel.Location = New Point(-150, 57)
        End If
        Menu_buttonH.Visible = False
        Menu_buttonS.Visible = True
    End Sub

    Public Sub Hidepanels()
        Panel_common.Visible = False
        Panel_settings.Visible = False
    End Sub

    Public Sub Checkupdates()
        Dim MAJ As New WebClient
        Dim lastupdate As String = MAJ.DownloadString("https://raw.githubusercontent.com/Brionjv/Miitopia-Save-Editor/master/Version.txt")
        If Label7.Text = lastupdate Then
            MSE_icon.Visible = True
            MSE_iconupdate.Visible = False
        Else
            MSE_icon.Visible = False
            MSE_iconupdate.Visible = True
            fdialog.Title.Text = "Miitopia Save Editor : Update"
            fdialog.Msg.Text = "An update is avalible click on Miitopia Save Editor icon to download new version"
            fdialog.ShowDialog()
        End If
    End Sub

    Public Sub startmusic()
        Panel_music.Visible = True
        If Select_music.SelectedItem = Select_music.Items.Item(0) Then
            AudioMiitopia = My.Resources.sound1
        ElseIf Select_music.SelectedItem = Select_music.Items.Item(1) Then
            AudioMiitopia = My.Resources.sound2
        ElseIf Select_music.SelectedItem = Select_music.Items.Item(2) Then
            AudioMiitopia = My.Resources.sound3
        End If
        If Setting_music.Checked = True Then
            My.Computer.Audio.Play(AudioMiitopia, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
            Panel_music.Visible = False
        End If
    End Sub

    Public Sub readfilecommon()
        Try
            Dim Reader As New PackageIO.Reader(common, PackageIO.Endian.Little)
            Reader.Position = &H1C
            valu_party.Value = Reader.ReadInt8
            Reader.Position = &H24
            valu_gold.Value = Reader.ReadUInt32
            Reader.Position = &H28
            valu_bananas.Value = Reader.ReadUInt16
            Reader.Position = &H2A
            valu_candies.Value = Reader.ReadUInt16
            Reader.Position = &H100
            valu_sprinkles.Value = Reader.ReadByte
            Reader.Position = &H130
            valu_rescued.Value = Reader.ReadUInt16
            Reader.Position = &H134
            valu_allweapons.Value = Reader.ReadUInt16
            Reader.Position = &H2A4
            valu_costamiibo.Value = Reader.ReadUInt64
            Reader.Position = &H83A
            valu_ticket.Value = Reader.ReadUInt16
            Reader.Position = &H102
            valu_safespot.Value = Reader.ReadInt8
            Button_Open.Visible = False
            Button_Save.Visible = True
        Catch ex As Exception
            fdialog.Title.Text = "Miitopia Save Editor : Read common.sav"
            fdialog.Msg.Text = "Oops, something goes wrong" & vbNewLine & "opening of common.sav failed, please report this issue"
            fdialog.ShowDialog()
            Button_Open.Visible = True
            Button_Save.Visible = False
        End Try
    End Sub

    Public Sub writecommon()
        Try
            Dim writer As New PackageIO.Writer(common, PackageIO.Endian.Little)
            writer.Position = &H1C
            writer.WriteInt8(valu_party.Value)
            writer.Position = &H24
            writer.WriteUInt32(valu_gold.Value)
            writer.Position = &H28
            writer.WriteUInt16(valu_bananas.Value)
            writer.Position = &H2A
            writer.WriteUInt16(valu_candies.Value)
            writer.Position = &H130
            writer.WriteUInt16(valu_rescued.Value)
            writer.Position = &H134
            writer.WriteUInt16(valu_allweapons.Value)
            writer.Position = &H2A4
            writer.WriteUInt64(valu_costamiibo.Value)
            writer.Position = &H83A
            writer.WriteUInt16(valu_ticket.Value)
            writer.Position = &H102
            writer.WriteInt8(valu_safespot.Value)

            Dim writerx As New System.IO.FileStream(common, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            writerx.Position = &H100
            writerx.WriteByte(valu_sprinkles.Value)

            fdialog.Title.Text = "Miitopia Save Editor : write common.sav"
            fdialog.Msg.Text = "common.sav has been saved"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Title.Text = "Miitopia Save Editor : write common.sav"
            fdialog.Msg.Text = "An error has occured" & vbNewLine & "please report this issue"
            fdialog.ShowDialog()
        End Try
    End Sub

    Public Sub makebakcommon()
        Try
            If Filever_text.Text = "EU" Then
                My.Computer.FileSystem.CopyFile(
                          common,
                        applicationpath & "\bak\common.sav\EUR\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "_" & TimeOfDay.Minute & "\common.sav")
            End If
            If Filever_text.Text = "US" Then
                My.Computer.FileSystem.CopyFile(
                          common,
                        applicationpath & "\bak\common.sav\USA\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "_" & TimeOfDay.Minute & "\common.sav")
            End If
            If Filever_text.Text = "JP" Then
                My.Computer.FileSystem.CopyFile(
                          common,
                        applicationpath & "\bak\common.sav\JPN\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "_" & TimeOfDay.Minute & "\common.sav")
            End If
        Catch ex As Exception
        End Try
    End Sub

    'MSE Features
    Private Sub ClosebuttonMouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.closebuttonred
    End Sub

    Private Sub ClosebuttonMouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.closebutton
    End Sub

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
    End Sub

    Private Sub Menu_width_Click(sender As Object, e As EventArgs) Handles Menu_width.Click
        If Menu_panel.Width = 34 Then
            Menu_panel.Width = 150
            Menu_width.Location = New Point(116, 0)
        Else
            Menu_panel.Width = 34
            Menu_width.Location = New Point(0, 0)
        End If

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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If Menu_panel.Width = 34 Then
            Menu_panel.Location = New Point(-35, 57)
            Do Until Menu_panel.Location.X = -10
                Menu_panel.Location = New Point(Menu_panel.Location.X + 5, 57)
            Loop
            Do Until Menu_panel.Location.X = 0
                Menu_panel.Location = New Point(Menu_panel.Location.X + 5, 57)
                Refresh()
                System.Threading.Thread.Sleep(20)
            Loop
        End If
        If Menu_panel.Width = 150 Then
            Menu_panel.Location = New Point(-150, 57)
            Do Until Menu_panel.Location.X = -10
                Menu_panel.Location = New Point(Menu_panel.Location.X + 10, 57)
            Loop
            Do Until Menu_panel.Location.X = 0
                Menu_panel.Location = New Point(Menu_panel.Location.X + 10, 57)
                Refresh()
                System.Threading.Thread.Sleep(30)
            Loop
        End If
        Menu_buttonS.Visible = False
        Menu_buttonH.Visible = True
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If Menu_panel.Width = 34 Then
            Menu_panel.Location = New Point(-35, 57)
        End If
        If Menu_panel.Width = 150 Then
            Menu_panel.Location = New Point(-150, 57)
        End If
        Menu_buttonH.Visible = False
        Menu_buttonS.Visible = True
    End Sub

    Private Sub Menu_settings_MouseMove(sender As Object, e As EventArgs) Handles Menu_settings.MouseMove, Label1.MouseMove
        Menu_settings.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to access to Miitopia Save Editor settings"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour accéder aux paramètres de Miitopia Save Editor"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Menu_settings_MouseLeave(sender As Object, e As EventArgs) Handles Menu_settings.MouseLeave
        Menu_settings.BorderStyle = BorderStyle.None
        Descrip_panel.Visible = False
    End Sub

    Private Sub Menu_settings_Click(sender As Object, e As EventArgs) Handles Menu_settings.Click, Label1.Click
        Hidepanels()
        Panel_settings.Visible = True
        Hidemenu()
    End Sub

    Private Sub Miitopia_SE_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If Menu_panel.Width = 34 Then
            Menu_panel.Location = New Point(0, 57)
            Do Until Menu_panel.Location.X = -35
                Menu_panel.Location = New Point(Menu_panel.Location.X - 5, 57)
                Refresh()
            Loop
            Do Until Menu_panel.Location.X = -35
                Menu_panel.Location = New Point(Menu_panel.Location.X - 5, 57)
                System.Threading.Thread.Sleep(10)
                Refresh()
            Loop
        End If
        If Menu_panel.Width = 150 Then
            Menu_panel.Location = New Point(0, 57)
            Do Until Menu_panel.Location.X = -150
                Menu_panel.Location = New Point(Menu_panel.Location.X - 30, 57)
                Refresh()
            Loop
            Do Until Menu_panel.Location.X = -150
                Menu_panel.Location = New Point(Menu_panel.Location.X - 30, 57)
                System.Threading.Thread.Sleep(10)
                Refresh()
            Loop
        End If
        Menu_buttonH.Visible = False
        Menu_buttonS.Visible = True
        Panel_common.Visible = True
        Checkupdates()
    End Sub

    Private Sub Setting_filepath_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_filepath.CheckedChanged
        If Setting_filepath.Checked = True Then
            File_path.Visible = True
        Else
            File_path.Visible = False
        End If
    End Sub

    Private Sub Miitopia_SE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select_language.SelectedItem = Select_language.Items.Item(0)
        Select_music.SelectedItem = Select_music.Items.Item(0)
        Try
            Setting_music.Checked = My.Settings.S_music
            Setting_hidden.Checked = My.Settings.S_hide
            Setting_filepath.Checked = My.Settings.S_fpath
            Select_language.SelectedItem = My.Settings.S_lang
            Select_music.SelectedItem = My.Settings.S_Smusic
            Menu_panel.Width = My.Settings.S_menu_t
            If Menu_panel.Width = 150 Then
                Menu_width.Location = New Point(116, 0)
            Else
                Menu_width.Location = New Point(0, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Miitopia_SE_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        My.Settings.S_music = Setting_music.Checked
        My.Settings.S_hide = Setting_hidden.Checked
        My.Settings.S_fpath = Setting_filepath.Checked
        My.Settings.S_lang = Select_language.SelectedItem
        My.Settings.S_Smusic = Select_music.SelectedItem
        My.Settings.S_menu_t = Menu_panel.Width
    End Sub

    Private Sub Setting_hidden_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_hidden.CheckedChanged
        If Setting_hidden.Checked = True Then
            Hidden_things.Visible = True
            Bar_allweapons.Visible = True
            icon_allweapons.Location = New Point(23, 23)
            Bar_costamiibo.Visible = True
            icon_costamiibo.Location = New Point(23, 23)
            Bar_sprinkles.Visible = True
            icon_sprinkles.Location = New Point(23, 23)
            valu_party.Visible = True
            valu_safespot.Visible = True
        Else
            Hidden_things.Visible = False
            Bar_allweapons.Visible = False
            icon_allweapons.Location = New Point(23, 14)
            Bar_costamiibo.Visible = False
            icon_costamiibo.Location = New Point(23, 14)
            Bar_sprinkles.Visible = False
            icon_sprinkles.Location = New Point(23, 14)
            valu_party.Visible = False
            valu_safespot.Visible = False
        End If
    End Sub

    Private Sub Setting_music_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_music.CheckedChanged
        startmusic()
    End Sub

    Private Sub Menu_common_Click(sender As Object, e As EventArgs) Handles Menu_common.Click, Label2.Click
        Hidepanels()
        Panel_common.Visible = True
        Hidemenu()
    End Sub

    Private Sub Menu_common_MouseMove(sender As Object, e As EventArgs) Handles Menu_common.MouseMove, Label2.MouseMove
        Menu_common.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to edit common.sav"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour éditer common.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Menu_common_MouseLeave(sender As Object, e As EventArgs) Handles Menu_common.MouseLeave
        Menu_common.BorderStyle = BorderStyle.None
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_gold_Click(sender As Object, e As EventArgs) Handles Fea_gold.Click
        valu_gold.Value = 9999999
    End Sub

    Private Sub Label10_MouseMove(sender As Object, e As EventArgs) Handles text_open.MouseMove, Button_Save.MouseMove
        Button_Open.BackgroundImage = My.Resources.button_save
    End Sub

    Private Sub Label10_MouseLeave(sender As Object, e As EventArgs) Handles text_open.MouseLeave, Button_Save.MouseLeave
        Button_Open.BackgroundImage = My.Resources.button_open
    End Sub

    Private Sub Menu_hero_MouseMove(sender As Object, e As EventArgs) Handles Menu_hero.MouseMove, Label3.MouseMove
        Menu_hero.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to edit hero.sav"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour éditer hero.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Menu_hero_MouseLeave(sender As Object, e As EventArgs) Handles Menu_hero.MouseLeave
        Menu_hero.BorderStyle = BorderStyle.None
        Descrip_panel.Visible = False
    End Sub

    Private Sub Menu_quest_MouseMove(sender As Object, e As EventArgs) Handles Menu_quest.MouseMove, Label4.MouseMove
        Menu_quest.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to edit quest.sav"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour éditer quest.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Menu_quest_MouseLeave(sender As Object, e As EventArgs) Handles Menu_quest.MouseLeave
        Menu_quest.BorderStyle = BorderStyle.None
        Descrip_panel.Visible = False
    End Sub

    Private Sub MSE_iconupdate_Click(sender As Object, e As EventArgs) Handles MSE_iconupdate.Click
        Process.Start("https://github.com/Brionjv/Miitopia-Save-Editor/releases")
    End Sub

    Private Sub Filever_text_Click(sender As Object, e As EventArgs) Handles Filever_text.Click
        If Filever_text.Text = "US" Then
            Filever_text.Text = "EU"
        ElseIf Filever_text.Text = "EU" Then
            Filever_text.Text = "JP"
        ElseIf Filever_text.Text = "JP" Then
            Filever_text.Text = "US"
        End If
    End Sub

    Private Sub Fea_bananas_Click(sender As Object, e As EventArgs) Handles Fea_bananas.Click
        valu_bananas.Value = 999
    End Sub

    Private Sub Fea_candies_Click(sender As Object, e As EventArgs) Handles Fea_candies.Click
        valu_candies.Value = 999
    End Sub

    Private Sub Fea_allweapons_Click(sender As Object, e As EventArgs) Handles Fea_allweapons.Click
        valu_allweapons.Value = 65535
    End Sub

    Private Sub Fea_costamiibos_Click(sender As Object, e As EventArgs) Handles Fea_costamiibo.Click
        valu_costamiibo.Value = 4294967295
    End Sub

    Private Sub Fea_ticket_Click(sender As Object, e As EventArgs) Handles Fea_ticket.Click
        valu_ticket.Value = 9999
    End Sub

    Private Sub Fea_sprinkles_Click(sender As Object, e As EventArgs) Handles Fea_sprinkles.Click
        valu_sprinkles.Value = 31
    End Sub

    Private Sub icon_party_Click(sender As Object, e As EventArgs) Handles icon_party.Click
        If valu_party.Value = 0 Then
            valu_party.Value = 1
        ElseIf valu_party.Value = 1 Then
            valu_party.Value = 2
        ElseIf valu_party.Value = 2 Then
            valu_party.Value = 0
        End If
    End Sub

    Private Sub valu_party_ValueChanged(sender As Object, e As EventArgs) Handles valu_party.ValueChanged
        If valu_party.Value = 0 Then
            icon_party.Image = My.Resources.inn
        ElseIf valu_party.Value = 1 Then
            icon_party.Image = My.Resources.level
        ElseIf valu_party.Value = 2 Then
            icon_party.Image = My.Resources.overworld
        End If
    End Sub

    Private Sub Dragon_map_Click(sender As Object, e As EventArgs) Handles Dragon_map.Click
        Try
            Dim Writer As New PackageIO.Writer(common, PackageIO.Endian.Little)
            Writer.Position = &H1F
            Writer.WriteInt8(1)
            Dragon_map.Visible = False
            Info_dragon_map.Visible = False
            Dragon_map2.Visible = True
            Info_dragon_map2.Visible = True
        Catch ex As Exception
            fdialog.Title.Text = "Miitopia Save Editor : ride on the dragon"
            fdialog.Msg.Text = "An error has occured, load a save file first"
            fdialog.ShowDialog()
            Dragon_map.Visible = True
            Info_dragon_map.Visible = True
            Dragon_map2.Visible = False
            Info_dragon_map2.Visible = False
        End Try

    End Sub

    Private Sub text_Open_Click(sender As Object, e As EventArgs) Handles text_open.Click
        Dim open As New OpenFileDialog
        fdialog.Title.Text = "Miitopia Save Editor"
        fdialog.Msg.Text = "Open common.sav file" & vbNewLine & "Miitopia Save Editor will make a backup of your save file" & vbNewLine & "Check ''bak'' folder"
        fdialog.ShowDialog()
        open.Filter = "SAV files|*common.sav"
        open.Title = "Open save common.sav"
        open.ShowDialog()
        common = open.FileName
        readfilecommon()
        TextBox_fpath.Text = common
        makebakcommon()
    End Sub

    Private Sub Info_party_Click(sender As Object, e As EventArgs) Handles Info_party.Click
        fdialog.Title.Text = "Miitopia Save Editor : Party is in"
        fdialog.Msg.Text = "To set party in Overworld you need to defeat Dark Lord"
        fdialog.ShowDialog()
    End Sub

    Private Sub Info_dragon_map_Click(sender As Object, e As EventArgs) Handles Info_dragon_map.Click, Info_dragon_map2.Click
        fdialog.Title.Text = "Miitopia Save Editor : ride on the dragon"
        fdialog.Msg.Text = "When your save file will be load, you will be on the dragon, visit Travelers Hub to unlock the Dragon"
        fdialog.ShowDialog()
    End Sub

    Private Sub Fea_foods_Click(sender As Object, e As EventArgs) Handles Fea_foods.Click
        Grub_editor.ShowDialog()
    End Sub

    Private Sub Select_music_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_music.SelectedIndexChanged
        startmusic()
    End Sub

    Private Sub icon_safespot_Click(sender As Object, e As EventArgs) Handles icon_safespot.Click
        valu_safespot.Value = 1
    End Sub

    Private Sub text_save_Click(sender As Object, e As EventArgs) Handles text_save.Click
        writecommon()
    End Sub
End Class