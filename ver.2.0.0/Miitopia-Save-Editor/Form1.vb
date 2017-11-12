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
    Dim hero As String
    Dim quest As String
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
        Panel_quest.Visible = False
        Panel_hero.Visible = False
    End Sub

    Public Sub Hidefilepath()
        File_path_common.Visible = False
        File_path_quest.Visible = False
        File_path_hero.Visible = False
    End Sub

    Public Sub Checkupdates()
        Try
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
        Catch ex As Exception
            fdialog.Title.Text = "Miitopia Save Editor : Update"
            fdialog.Msg.Text = "An error has occured"
            fdialog.ShowDialog()
        End Try
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
            Reader.Position = &H1D
            valu_world.Value = Reader.ReadInt8
            Reader.Position = &H1E
            valu_level.Value = Reader.ReadInt8
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
            Reader.Position = &H234
            valu_wp_warrior.Value = Reader.ReadUInt32
            Reader.Position = &H238
            valu_wp_mage.Value = Reader.ReadUInt32
            Reader.Position = &H23C
            valu_wp_cleric.Value = Reader.ReadUInt32
            Reader.Position = &H240
            valu_wp_thief.Value = Reader.ReadUInt32
            Reader.Position = &H244
            valu_wp_popstar.Value = Reader.ReadUInt32
            Reader.Position = &H248
            valu_wp_vampire.Value = Reader.ReadUInt32
            Reader.Position = &H24C
            valu_wp_chef.Value = Reader.ReadUInt32
            Reader.Position = &H250
            valu_wp_tank.Value = Reader.ReadUInt32
            Reader.Position = &H254
            valu_wp_imp.Value = Reader.ReadUInt32
            Reader.Position = &H258
            valu_wp_princess.Value = Reader.ReadUInt32
            Reader.Position = &H25C
            valu_wp_flower.Value = Reader.ReadUInt32
            Reader.Position = &H260
            valu_wp_scientist.Value = Reader.ReadUInt32
            Reader.Position = &H264
            valu_wp_cat.Value = Reader.ReadUInt32
            Reader.Position = &H268
            valu_wp_elf.Value = Reader.ReadUInt32
            Reader.Position = &H26C
            valu_ct_warrior.Value = Reader.ReadUInt32
            Reader.Position = &H270
            valu_ct_mage.Value = Reader.ReadUInt32
            Reader.Position = &H274
            valu_ct_cleric.Value = Reader.ReadUInt32
            Reader.Position = &H278
            valu_ct_thief.Value = Reader.ReadUInt32
            Reader.Position = &H27C
            valu_ct_popstar.Value = Reader.ReadUInt32
            Reader.Position = &H280
            valu_ct_vampire.Value = Reader.ReadUInt32
            Reader.Position = &H284
            valu_ct_chef.Value = Reader.ReadUInt32
            Reader.Position = &H288
            valu_ct_tank.Value = Reader.ReadUInt32
            Reader.Position = &H28C
            valu_ct_imp.Value = Reader.ReadUInt32
            Reader.Position = &H290
            valu_ct_princess.Value = Reader.ReadUInt32
            Reader.Position = &H294
            valu_ct_flower.Value = Reader.ReadUInt32
            Reader.Position = &H298
            valu_ct_scientist.Value = Reader.ReadUInt32
            Reader.Position = &H29C
            valu_ct_cat.Value = Reader.ReadUInt32
            Reader.Position = &H2A0
            valu_ct_elf.Value = Reader.ReadUInt32
            Reader.Position = &H170
            valu_bananaeat.Value = Reader.ReadUInt32
            Reader.Position = &H174
            valu_candyeat.Value = Reader.ReadUInt32
            Reader.Position = &H178
            valu_chestsopen.Value = Reader.ReadUInt32
            Reader.Position = &H17C
            valu_questsucc.Value = Reader.ReadUInt32
            Button_Open.Visible = False
            Button_Save.Visible = True
        Catch ex As Exception
            fdialog.Title.Text = "Miitopia Save Editor : Read common.sav"
            fdialog.Msg.Text = "Oops, something goes wrong" & vbNewLine & "opening of common.sav failed, please report this issue or try again"
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
            writer.Position = &H1D
            writer.WriteInt8(valu_world.Value)
            writer.Position = &H1E
            writer.WriteInt8(valu_level.Value)
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
            writer.Position = &H234
            writer.WriteUInt32(valu_wp_warrior.Value)
            writer.Position = &H238
            writer.WriteUInt32(valu_wp_mage.Value)
            writer.Position = &H23C
            writer.WriteUInt32(valu_wp_cleric.Value)
            writer.Position = &H240
            writer.WriteUInt32(valu_wp_thief.Value)
            writer.Position = &H244
            writer.WriteUInt32(valu_wp_popstar.Value)
            writer.Position = &H248
            writer.WriteUInt32(valu_wp_vampire.Value)
            writer.Position = &H24C
            writer.WriteUInt32(valu_wp_chef.Value)
            writer.Position = &H250
            writer.WriteUInt32(valu_wp_tank.Value)
            writer.Position = &H254
            writer.WriteUInt32(valu_wp_imp.Value)
            writer.Position = &H258
            writer.WriteUInt32(valu_wp_princess.Value)
            writer.Position = &H25C
            writer.WriteUInt32(valu_wp_flower.Value)
            writer.Position = &H260
            writer.WriteUInt32(valu_wp_scientist.Value)
            writer.Position = &H264
            writer.WriteUInt32(valu_wp_cat.Value)
            writer.Position = &H268
            writer.WriteUInt32(valu_wp_elf.Value)
            writer.Position = &H26C
            writer.WriteUInt32(valu_ct_warrior.Value)
            writer.Position = &H270
            writer.WriteUInt32(valu_ct_mage.Value)
            writer.Position = &H274
            writer.WriteUInt32(valu_ct_cleric.Value)
            writer.Position = &H278
            writer.WriteUInt32(valu_ct_thief.Value)
            writer.Position = &H27C
            writer.WriteUInt32(valu_ct_popstar.Value)
            writer.Position = &H280
            writer.WriteUInt32(valu_ct_vampire.Value)
            writer.Position = &H284
            writer.WriteUInt32(valu_ct_chef.Value)
            writer.Position = &H288
            writer.WriteUInt32(valu_ct_tank.Value)
            writer.Position = &H28C
            writer.WriteUInt32(valu_ct_imp.Value)
            writer.Position = &H290
            writer.WriteUInt32(valu_ct_princess.Value)
            writer.Position = &H294
            writer.WriteUInt32(valu_ct_flower.Value)
            writer.Position = &H298
            writer.WriteUInt32(valu_ct_scientist.Value)
            writer.Position = &H29C
            writer.WriteUInt32(valu_ct_cat.Value)
            writer.Position = &H2A0
            writer.WriteUInt32(valu_ct_elf.Value)
            writer.Position = &H170
            writer.WriteUInt32(valu_bananaeat.Value)
            writer.Position = &H174
            writer.WriteUInt32(valu_candyeat.Value)
            writer.Position = &H178
            writer.WriteUInt32(valu_chestsopen.Value)
            writer.Position = &H17C
            writer.WriteUInt32(valu_questsucc.Value)

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
                        applicationpath & "\bak\common.sav\EUR\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\common.sav")
            End If
            If Filever_text.Text = "US" Then
                My.Computer.FileSystem.CopyFile(
                          common,
                        applicationpath & "\bak\common.sav\USA\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\common.sav")
            End If
            If Filever_text.Text = "JP" Then
                My.Computer.FileSystem.CopyFile(
                          common,
                        applicationpath & "\bak\common.sav\JPN\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\common.sav")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub readfilequest()
        Try
            Dim Reader As New PackageIO.Reader(quest, PackageIO.Endian.Little)
            Reader.Position = &H4B9C
            valu_dragonclass.Value = Reader.ReadUInt32
            Reader.Position = &H4BA4
            valu_villa.Value = Reader.ReadUInt32
            Button_open_quest.Visible = False
            Button_save_quest.Visible = True
        Catch ex As Exception
            fdialog.Title.Text = "Miitopia Save Editor : Read quest.sav"
            fdialog.Msg.Text = "Oops, something goes wrong" & vbNewLine & "opening of quest.sav failed, please report this issue or try again"
            fdialog.ShowDialog()
            Button_open_quest.Visible = True
            Button_save_quest.Visible = False
        End Try
    End Sub
    Public Sub writequest()
        Try
            Dim writer As New PackageIO.Writer(quest, PackageIO.Endian.Little)
            writer.Position = &H4B9C
            writer.WriteUInt32(valu_dragonclass.Value)
            writer.Position = &H4BA4
            writer.WriteUInt32(valu_villa.Value)
            fdialog.Title.Text = "Miitopia Save Editor : write quest.sav"
            fdialog.Msg.Text = "quest.sav has been saved"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Title.Text = "Miitopia Save Editor : write quest.sav"
            fdialog.Msg.Text = "An error has occured" & vbNewLine & "please report this issue"
            fdialog.ShowDialog()
        End Try
    End Sub

    Public Sub makebakquest()
        Try
            If Filever_text.Text = "EU" Then
                My.Computer.FileSystem.CopyFile(
                          common,
                        applicationpath & "\bak\quest.sav\EUR\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\quest.sav")
            End If
            If Filever_text.Text = "US" Then
                My.Computer.FileSystem.CopyFile(
                          common,
                        applicationpath & "\bak\quest.sav\USA\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\quest.sav")
            End If
            If Filever_text.Text = "JP" Then
                My.Computer.FileSystem.CopyFile(
                          common,
                        applicationpath & "\bak\quest.sav\JPN\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\quest.sav")
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

    Private Sub Menu_settings_MouseMove(sender As Object, e As EventArgs) Handles Menu_settings.MouseMove, Menu_text_settings.MouseMove
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

    Private Sub Menu_settings_Click(sender As Object, e As EventArgs) Handles Menu_settings.Click, Menu_text_settings.Click
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
            File_path_common.Visible = True
        End If
        If Setting_filepath.Checked = False Then
            Hidefilepath()
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
            valu_world.Visible = True
            Select_world.Location = New Point(35, 14)
            Bar_wp_warrior.Visible = True
            Bar_wp_mage.Visible = True
            Bar_wp_cleric.Visible = True
            Bar_wp_thief.Visible = True
            Bar_wp_popstar.Visible = True
            Bar_wp_vampire.Visible = True
            Bar_wp_chef.Visible = True
            Bar_wp_tank.Visible = True
            Bar_wp_imp.Visible = True
            Bar_wp_princess.Visible = True
            Bar_wp_flower.Visible = True
            Bar_wp_scientist.Visible = True
            Bar_wp_cat.Visible = True
            Bar_wp_elf.Visible = True
            Bar_ct_warrior.Visible = True
            Bar_ct_mage.Visible = True
            Bar_ct_cleric.Visible = True
            Bar_ct_thief.Visible = True
            Bar_ct_popstar.Visible = True
            Bar_ct_vampire.Visible = True
            Bar_ct_chef.Visible = True
            Bar_ct_tank.Visible = True
            Bar_ct_imp.Visible = True
            Bar_ct_princess.Visible = True
            Bar_ct_flower.Visible = True
            Bar_ct_scientist.Visible = True
            Bar_ct_cat.Visible = True
            Bar_ct_elf.Visible = True
            Bar_dragonclass.Visible = True
            Icon_dragonclass.Location = New Point(21, 21)
            Bar_villa.Visible = True
            Icon_villa.Location = New Point(21, 21)
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
            valu_world.Visible = False
            Select_world.Location = New Point(18, 14)
            Bar_wp_warrior.Visible = False
            Bar_wp_mage.Visible = False
            Bar_wp_cleric.Visible = False
            Bar_wp_thief.Visible = False
            Bar_wp_popstar.Visible = False
            Bar_wp_vampire.Visible = False
            Bar_wp_chef.Visible = False
            Bar_wp_tank.Visible = False
            Bar_wp_imp.Visible = False
            Bar_wp_princess.Visible = False
            Bar_wp_flower.Visible = False
            Bar_wp_scientist.Visible = False
            Bar_wp_cat.Visible = False
            Bar_wp_elf.Visible = False
            Bar_ct_warrior.Visible = False
            Bar_ct_mage.Visible = False
            Bar_ct_cleric.Visible = False
            Bar_ct_thief.Visible = False
            Bar_ct_popstar.Visible = False
            Bar_ct_vampire.Visible = False
            Bar_ct_chef.Visible = False
            Bar_ct_tank.Visible = False
            Bar_ct_imp.Visible = False
            Bar_ct_princess.Visible = False
            Bar_ct_flower.Visible = False
            Bar_ct_scientist.Visible = False
            Bar_ct_cat.Visible = False
            Bar_ct_elf.Visible = False
            Bar_dragonclass.Visible = False
            Icon_dragonclass.Location = New Point(21, 12)
            Bar_villa.Visible = False
            Icon_villa.Location = New Point(21, 12)
        End If
    End Sub

    Private Sub Setting_music_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_music.CheckedChanged
        startmusic()
    End Sub

    Private Sub Menu_common_Click(sender As Object, e As EventArgs) Handles Menu_common.Click, Menu_text_common.Click
        Hidepanels()
        If Setting_filepath.Checked = True Then
            Hidefilepath()
            File_path_common.Visible = True
        End If
        Panel_common.Visible = True
        Hidemenu()
    End Sub

    Private Sub Menu_common_MouseMove(sender As Object, e As EventArgs) Handles Menu_common.MouseMove, Menu_text_common.MouseMove
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

    Private Sub Menu_hero_Click(sender As Object, e As EventArgs) Handles Menu_hero.Click
        Hidepanels()
        If Setting_filepath.Checked = True Then
            Hidefilepath()
            File_path_hero.Visible = True
        End If
        Panel_hero.Visible = True
        Hidemenu()
    End Sub

    Private Sub Menu_hero_MouseMove(sender As Object, e As EventArgs) Handles Menu_hero.MouseMove, Menu_text_hero.MouseMove
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

    Private Sub Menu_quest_Click(sender As Object, e As EventArgs) Handles Menu_quest.Click, Menu_text_quest.Click
        Hidepanels()
        If Setting_filepath.Checked = True Then
            Hidefilepath()
            File_path_quest.Visible = True
        End If
        Panel_quest.Visible = True
        Hidemenu()
    End Sub

    Private Sub Menu_quest_MouseMove(sender As Object, e As EventArgs) Handles Menu_quest.MouseMove, Menu_text_quest.MouseMove
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
        fdialog.Msg.Text = "Open common.sav file" & vbNewLine & "Miitopia Save Editor will make a backup of your save file, check ''bak'' folder" & vbNewLine & "Make a backup of your entire save file folder in case"
        fdialog.ShowDialog()
        open.Filter = "SAV files|*common.sav"
        open.Title = "Open save common.sav"
        open.ShowDialog()
        common = open.FileName
        readfilecommon()
        TextBox_fpath_common.Text = common
        makebakcommon()
    End Sub

    Private Sub text_open_MouseMove(sender As Object, e As EventArgs) Handles text_open.MouseMove, Button_Open.MouseMove
        Button_Open.BackgroundImage = My.Resources.button_save
    End Sub

    Private Sub text_open_MouseLeave(sender As Object, e As EventArgs) Handles text_open.MouseLeave, Button_Open.MouseLeave
        Button_Open.BackgroundImage = My.Resources.button_open
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

    Private Sub text_save_MouseMove(sender As Object, e As EventArgs) Handles text_save.MouseMove, Button_Save.MouseMove
        Button_Save.BackgroundImage = My.Resources.button_open
    End Sub

    Private Sub text_save_MouseLeave(sender As Object, e As EventArgs) Handles text_save.MouseLeave, Button_Save.MouseLeave
        Button_Save.BackgroundImage = My.Resources.button_save
    End Sub

    Private Sub valu_world_ValueChanged(sender As Object, e As EventArgs) Handles valu_world.ValueChanged
        If valu_world.Value = 0 Then
            Select_world.SelectedItem = Select_world.Items.Item(0)
        ElseIf valu_world.Value = 1 Then
            Select_world.SelectedItem = Select_world.Items.Item(1)
        ElseIf valu_world.Value = 2 Then
            Select_world.SelectedItem = Select_world.Items.Item(2)
        ElseIf valu_world.Value = 3 Then
            Select_world.SelectedItem = Select_world.Items.Item(3)
        ElseIf valu_world.Value = 4 Then
            Select_world.SelectedItem = Select_world.Items.Item(4)
        ElseIf valu_world.Value = 5 Then
            Select_world.SelectedItem = Select_world.Items.Item(5)
        ElseIf valu_world.Value = 6 Then
            Select_world.SelectedItem = Select_world.Items.Item(6)
        ElseIf valu_world.Value = 7 Then
            Select_world.SelectedItem = Select_world.Items.Item(7)
        ElseIf valu_world.Value = 8 Then
            Select_world.SelectedItem = Select_world.Items.Item(8)
        ElseIf valu_world.Value = 9 Then
            Select_world.SelectedItem = Select_world.Items.Item(9)
        ElseIf valu_world.Value = 10 Then
            Select_world.SelectedItem = Select_world.Items.Item(10)
        ElseIf valu_world.Value = 11 Then
            Select_world.SelectedItem = Select_world.Items.Item(11)
        ElseIf valu_world.Value = 12 Then
            Select_world.SelectedItem = Select_world.Items.Item(12)
        ElseIf valu_world.Value = 13 Then
            Select_world.SelectedItem = Select_world.Items.Item(13)
        ElseIf valu_world.Value = 14 Then
            Select_world.SelectedItem = Select_world.Items.Item(14)
        ElseIf valu_world.Value = 15 Then
            Select_world.SelectedItem = Select_world.Items.Item(15)
        ElseIf valu_world.Value = 16 Then
            Select_world.SelectedItem = Select_world.Items.Item(16)
        ElseIf valu_world.Value = 17 Then
            Select_world.SelectedItem = Select_world.Items.Item(17)
        ElseIf valu_world.Value = 18 Then
            Select_world.SelectedItem = Select_world.Items.Item(18)
        ElseIf valu_world.Value = 19 Then
            Select_world.SelectedItem = Select_world.Items.Item(19)
        ElseIf valu_world.Value = 20 Then
            Select_world.SelectedItem = Select_world.Items.Item(20)
        ElseIf valu_world.Value = 21 Then
            Select_world.SelectedItem = Select_world.Items.Item(21)
        ElseIf valu_world.Value = 22 Then
            Select_world.SelectedItem = Select_world.Items.Item(22)
        ElseIf valu_world.Value = 23 Then
            Select_world.SelectedItem = Select_world.Items.Item(23)
        ElseIf valu_world.Value = 24 Then
            Select_world.SelectedItem = Select_world.Items.Item(24)
        ElseIf valu_world.Value = 25 Then
            Select_world.SelectedItem = Select_world.Items.Item(25)
        ElseIf valu_world.Value = 26 Then
            Select_world.SelectedItem = Select_world.Items.Item(26)
        ElseIf valu_world.Value = 27 Then
            Select_world.SelectedItem = Select_world.Items.Item(27)
        ElseIf valu_world.Value = 28 Then
            Select_world.SelectedItem = Select_world.Items.Item(28)
        ElseIf valu_world.Value = 29 Then
            Select_world.SelectedItem = Select_world.Items.Item(29)
        ElseIf valu_world.Value = 30 Then
            Select_world.SelectedItem = Select_world.Items.Item(30)
        ElseIf valu_world.Value = 31 Then
            Select_world.SelectedItem = Select_world.Items.Item(31)
        ElseIf valu_world.Value = 32 Then
            Select_world.SelectedItem = Select_world.Items.Item(32)
        ElseIf valu_world.Value = 33 Then
            Select_world.SelectedItem = Select_world.Items.Item(33)
        ElseIf valu_world.Value = 34 Then
            Select_world.SelectedItem = Select_world.Items.Item(34)
        ElseIf valu_world.Value = 35 Then
            Select_world.SelectedItem = Select_world.Items.Item(35)
        ElseIf valu_world.Value = 36 Then
            Select_world.SelectedItem = Select_world.Items.Item(36)
        ElseIf valu_world.Value = 37 Then
            Select_world.SelectedItem = Select_world.Items.Item(37)
        ElseIf valu_world.Value = 38 Then
            Select_world.SelectedItem = Select_world.Items.Item(38)
        ElseIf valu_world.Value = 39 Then
            Select_world.SelectedItem = Select_world.Items.Item(39)
        ElseIf valu_world.Value = 40 Then
            Select_world.SelectedItem = Select_world.Items.Item(40)
        ElseIf valu_world.Value = 41 Then
            Select_world.SelectedItem = Select_world.Items.Item(41)
        ElseIf valu_world.Value = 42 Then
            Select_world.SelectedItem = Select_world.Items.Item(42)
        ElseIf valu_world.Value = 43 Then
            Select_world.SelectedItem = Select_world.Items.Item(43)
        End If
    End Sub

    Private Sub Select_world_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_world.SelectedIndexChanged
        If Select_world.SelectedItem = Select_world.Items.Item(0) Then
            valu_world.Value = 0
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(1) Then
            valu_world.Value = 1
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(2) Then
            valu_world.Value = 2
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(3) Then
            valu_world.Value = 3
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(4) Then
            valu_world.Value = 4
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(5) Then
            valu_world.Value = 5
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(6) Then
            valu_world.Value = 6
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(7) Then
            valu_world.Value = 7
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(8) Then
            valu_world.Value = 8
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(9) Then
            valu_world.Value = 9
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(10) Then
            valu_world.Value = 10
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(11) Then
            valu_world.Value = 11
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(12) Then
            valu_world.Value = 12
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(13) Then
            valu_world.Value = 13
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(14) Then
            valu_world.Value = 14
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(15) Then
            valu_world.Value = 15
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(16) Then
            valu_world.Value = 16
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(17) Then
            valu_world.Value = 17
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(18) Then
            valu_world.Value = 18
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(19) Then
            valu_world.Value = 19
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(20) Then
            valu_world.Value = 20
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(21) Then
            valu_world.Value = 21
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(22) Then
            valu_world.Value = 22
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(23) Then
            valu_world.Value = 23
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(24) Then
            valu_world.Value = 24
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(25) Then
            valu_world.Value = 25
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(26) Then
            valu_world.Value = 26
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(27) Then
            valu_world.Value = 27
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(28) Then
            valu_world.Value = 28
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(29) Then
            valu_world.Value = 29
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(30) Then
            valu_world.Value = 30
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(31) Then
            valu_world.Value = 31
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(32) Then
            valu_world.Value = 32
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(33) Then
            valu_world.Value = 33
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(34) Then
            valu_world.Value = 34
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(35) Then
            valu_world.Value = 35
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(36) Then
            valu_world.Value = 36
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(37) Then
            valu_world.Value = 37
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(38) Then
            valu_world.Value = 38
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(39) Then
            valu_world.Value = 39
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(40) Then
            valu_world.Value = 40
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(41) Then
            valu_world.Value = 41
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(42) Then
            valu_world.Value = 42
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(43) Then
            valu_world.Value = 43
        End If
    End Sub

    Private Sub Info_level_Click(sender As Object, e As EventArgs) Handles Info_level.Click
        fdialog.Title.Text = "Miitopia Save Editor : select level info"
        fdialog.Msg.Text = "Be careful by editing level, common.sav can be corrupt if a wrong value is used, if common.sav is corrupted set a lower value"
        fdialog.ShowDialog()
    End Sub

    Private Sub Fea_wp_warrior_Click(sender As Object, e As EventArgs) Handles Fea_wp_warrior.Click, Icon_wp_warrior.Click
        valu_wp_warrior.Value = 4294967295
    End Sub

    Private Sub Fea_wp_mage_Click(sender As Object, e As EventArgs) Handles Fea_wp_mage.Click, Icon_wp_mage.Click
        valu_wp_mage.Value = 4294967295
    End Sub

    Private Sub Fea_wp_cleric_Click(sender As Object, e As EventArgs) Handles Fea_wp_cleric.Click, Icon_wp_cleric.Click
        valu_wp_cleric.Value = 4294967295
    End Sub

    Private Sub Fea_wp_thief_Click(sender As Object, e As EventArgs) Handles Fea_wp_thief.Click, Icon_wp_thief.Click
        valu_wp_thief.Value = 4294967295
    End Sub

    Private Sub Fea_wp_popstar_Click(sender As Object, e As EventArgs) Handles Fea_wp_popstar.Click, Icon_wp_popstar.Click
        valu_wp_popstar.Value = 4294967295
    End Sub

    Private Sub Fea_wp_vampire_Click(sender As Object, e As EventArgs) Handles Fea_wp_vampire.Click, Icon_wp_vampire.Click
        valu_wp_vampire.Value = 4294967295
    End Sub

    Private Sub Fea_wp_chef_Click(sender As Object, e As EventArgs) Handles Fea_wp_chef.Click, Icon_wp_chef.Click
        valu_wp_chef.Value = 4294967295
    End Sub

    Private Sub Fea_wp_tank_Click(sender As Object, e As EventArgs) Handles Fea_wp_tank.Click, Icon_wp_tank.Click
        valu_wp_tank.Value = 4294967295
    End Sub

    Private Sub Fea_wp_imp_Click(sender As Object, e As EventArgs) Handles Fea_wp_imp.Click, Icon_wp_imp.Click
        valu_wp_imp.Value = 4294967295
    End Sub

    Private Sub Fea_wp_princess_Click(sender As Object, e As EventArgs) Handles Fea_wp_princess.Click, Icon_wp_princess.Click
        valu_wp_princess.Value = 4294967295
    End Sub

    Private Sub Fea_wp_flower_Click(sender As Object, e As EventArgs) Handles Fea_wp_flower.Click, Icon_wp_flower.Click
        valu_wp_flower.Value = 4294967295
    End Sub

    Private Sub Fea_wp_scientist_Click(sender As Object, e As EventArgs) Handles Fea_wp_scientist.Click, Icon_wp_scientist.Click
        valu_wp_scientist.Value = 4294967295
    End Sub

    Private Sub Fea_wp_cat_Click(sender As Object, e As EventArgs) Handles Fea_wp_cat.Click, Icon_wp_cat.Click
        valu_wp_cat.Value = 4294967295
    End Sub

    Private Sub Fea_wp_elf_Click(sender As Object, e As EventArgs) Handles Fea_wp_elf.Click, Icon_wp_elf.Click
        valu_wp_elf.Value = 4294967295
    End Sub

    Private Sub Fea_ct_warrior_Click(sender As Object, e As EventArgs) Handles Fea_ct_warrior.Click, Icon_ct_warrior.Click
        valu_ct_warrior.Value = 4294967295
    End Sub

    Private Sub Fea_ct_mage_Click(sender As Object, e As EventArgs) Handles Fea_ct_mage.Click, Icon_ct_mage.Click
        valu_ct_mage.Value = 4294967295
    End Sub

    Private Sub Fea_ct_cleric_Click(sender As Object, e As EventArgs) Handles Fea_ct_cleric.Click, Icon_ct_cleric.Click
        valu_ct_cleric.Value = 4294967295
    End Sub

    Private Sub Fea_ct_thief_Click(sender As Object, e As EventArgs) Handles Fea_ct_thief.Click, Icon_ct_thief.Click
        valu_ct_thief.Value = 4294967295
    End Sub

    Private Sub Fea_ct_popstar_Click(sender As Object, e As EventArgs) Handles Fea_ct_popstar.Click, Icon_ct_popstar.Click
        valu_ct_popstar.Value = 4294967295
    End Sub

    Private Sub Fea_ct_vampire_Click(sender As Object, e As EventArgs) Handles Fea_ct_vampire.Click, Icon_ct_vampire.Click
        valu_ct_vampire.Value = 4294967295
    End Sub

    Private Sub Fea_ct_chef_Click(sender As Object, e As EventArgs) Handles Fea_ct_chef.Click, Icon_ct_chef.Click
        valu_ct_chef.Value = 4294967295
    End Sub

    Private Sub Fea_ct_tank_Click(sender As Object, e As EventArgs) Handles Fea_ct_tank.Click, Icon_ct_tank.Click
        valu_ct_tank.Value = 4294967295
    End Sub

    Private Sub Fea_ct_imp_Click(sender As Object, e As EventArgs) Handles Fea_ct_imp.Click, Icon_ct_imp.Click
        valu_ct_imp.Value = 4294967295
    End Sub

    Private Sub Fea_ct_princess_Click(sender As Object, e As EventArgs) Handles Fea_ct_princess.Click, Icon_ct_princess.Click
        valu_ct_princess.Value = 4294967295
    End Sub

    Private Sub Fea_ct_flower_Click(sender As Object, e As EventArgs) Handles Fea_ct_flower.Click, Icon_ct_flower.Click
        valu_ct_flower.Value = 4294967295
    End Sub

    Private Sub Fea_ct_scientist_Click(sender As Object, e As EventArgs) Handles Fea_ct_scientist.Click, Icon_ct_scientist.Click
        valu_ct_scientist.Value = 4294967295
    End Sub

    Private Sub Fea_ct_cat_Click(sender As Object, e As EventArgs) Handles Fea_ct_cat.Click, Icon_ct_cat.Click
        valu_ct_cat.Value = 4294967295
    End Sub

    Private Sub Fea_ct_elf_Click(sender As Object, e As EventArgs) Handles Fea_ct_elf.Click, Icon_ct_elf.Click
        valu_ct_elf.Value = 4294967295
    End Sub

    Private Sub Fea_bananaeat_Click(sender As Object, e As EventArgs) Handles Fea_bananaeat.Click, Icon_bananaeat.Click
        valu_bananaeat.Value = 9999
    End Sub

    Private Sub Fea_candyeat_Click(sender As Object, e As EventArgs) Handles Fea_candyeat.Click, Icon_candyeat.Click
        valu_candyeat.Value = 9999
    End Sub

    Private Sub Fea_chestsopen_Click(sender As Object, e As EventArgs) Handles Fea_chestsopen.Click, Icon_chestsopen.Click
        valu_chestsopen.Value = 9999
    End Sub

    Private Sub Fea_questsucc_Click(sender As Object, e As EventArgs) Handles Fea_questsucc.Click, Icon_questsucc.Click
        valu_questsucc.Value = 9999
    End Sub

    Private Sub Fea_dragonclass_Click(sender As Object, e As EventArgs) Handles Fea_dragonclass.Click, Icon_dragonclass.Click
        valu_dragonclass.Value = 4294967295
    End Sub

    Private Sub Fea_villa_Click(sender As Object, e As EventArgs) Handles Fea_villa.Click, Icon_villa.Click
        valu_villa.Value = 1
    End Sub

    Private Sub Text_open_quest_Click(sender As Object, e As EventArgs) Handles Text_open_quest.Click
        Dim open As New OpenFileDialog
        fdialog.Title.Text = "Miitopia Save Editor"
        fdialog.Msg.Text = "Open quest.sav file" & vbNewLine & "Miitopia Save Editor will make a backup of your save file, check ''bak'' folder" & vbNewLine & "Make a backup of your entire save file folder in case"
        fdialog.ShowDialog()
        open.Filter = "SAV files|*quest.sav"
        open.Title = "Open save quest.sav"
        open.ShowDialog()
        quest = open.FileName
        readfilequest()
        TextBox_fpath_quest.Text = quest
        makebakquest()
    End Sub

    Private Sub text_open_quest_MouseMove(sender As Object, e As EventArgs) Handles Text_open_quest.MouseMove, Button_save_quest.MouseMove
        Button_open_quest.BackgroundImage = My.Resources.button_save
    End Sub

    Private Sub text_open_quest_MouseLeave(sender As Object, e As EventArgs) Handles Text_open_quest.MouseLeave, Button_save_quest.MouseLeave
        Button_open_quest.BackgroundImage = My.Resources.button_open
    End Sub

    Private Sub Text_save_quest_Click(sender As Object, e As EventArgs) Handles Text_save_quest.Click
        writequest()
    End Sub

    Private Sub text_save_quest_MouseMove(sender As Object, e As EventArgs) Handles Text_save_quest.MouseMove, Button_save_quest.MouseMove
        Button_save_quest.BackgroundImage = My.Resources.button_open
    End Sub

    Private Sub text_save_quest_MouseLeave(sender As Object, e As EventArgs) Handles Text_save_quest.MouseLeave, Button_save_quest.MouseLeave
        Button_save_quest.BackgroundImage = My.Resources.button_save
    End Sub

    Private Sub text_open_hero_MouseMove(sender As Object, e As EventArgs) Handles Text_open_hero.MouseMove, Button_save_hero.MouseMove
        Button_open_hero.BackgroundImage = My.Resources.button_save
    End Sub

    Private Sub text_open_hero_MouseLeave(sender As Object, e As EventArgs) Handles Text_open_hero.MouseLeave, Button_save_hero.MouseLeave
        Button_open_hero.BackgroundImage = My.Resources.button_open
    End Sub

    Private Sub text_save_hero_MouseMove(sender As Object, e As EventArgs) Handles Text_save_hero.MouseMove, Button_save_hero.MouseMove
        Button_save_hero.BackgroundImage = My.Resources.button_open
    End Sub

    Private Sub text_save_hero_MouseLeave(sender As Object, e As EventArgs) Handles Text_save_hero.MouseLeave, Button_save_hero.MouseLeave
        Button_save_hero.BackgroundImage = My.Resources.button_save
    End Sub

    Private Sub valu_job_ValueChanged(sender As Object, e As EventArgs) Handles valu_job.ValueChanged
        If valu_job.Value = 0 Then
            Icon_job.Image = My.Resources.job_warrior
        ElseIf valu_job.Value = 1 Then
            Icon_job.Image = My.Resources.job_mage
        ElseIf valu_job.Value = 2 Then
            Icon_job.Image = My.Resources.job_cleric
        ElseIf valu_job.Value = 3 Then
            Icon_job.Image = My.Resources.job_thief
        ElseIf valu_job.Value = 4 Then
            Icon_job.Image = My.Resources.job_popstar
        ElseIf valu_job.Value = 5 Then
            Icon_job.Image = My.Resources.job_popstarg
        ElseIf valu_job.Value = 6 Then
            Icon_job.Image = My.Resources.job_vampire
        ElseIf valu_job.Value = 7 Then
            Icon_job.Image = My.Resources.job_chef
        ElseIf valu_job.Value = 8 Then
            Icon_job.Image = My.Resources.job_tank
        ElseIf valu_job.Value = 9 Then
            Icon_job.Image = My.Resources.job_imp
        ElseIf valu_job.Value = 10 Then
            Icon_job.Image = My.Resources.job_princess
        ElseIf valu_job.Value = 11 Then
            Icon_job.Image = My.Resources.job_flower
        ElseIf valu_job.Value = 12 Then
            Icon_job.Image = My.Resources.job_scientist
        ElseIf valu_job.Value = 13 Then
            Icon_job.Image = My.Resources.job_cat
        ElseIf valu_job.Value = 14 Then
            Icon_job.Image = My.Resources.job_elf
        End If
    End Sub

    Private Sub Icon_job_Click(sender As Object, e As EventArgs) Handles Icon_job.Click
        valu_job.Value = valu_job.Value + 1
        If valu_job.Value > 14 Then
            valu_job.Value = 0
        End If
    End Sub

    Private Sub valu_personnality_ValueChanged(sender As Object, e As EventArgs) Handles valu_personnality.ValueChanged
        If valu_personnality.Value = 0 Then
            Select_personnality.SelectedItem = Select_personnality.Items.Item(0)
        ElseIf valu_personnality.Value = 1 Then
            Select_personnality.SelectedItem = Select_personnality.Items.Item(1)
        ElseIf valu_personnality.Value = 2 Then
            Select_personnality.SelectedItem = Select_personnality.Items.Item(2)
        ElseIf valu_personnality.Value = 3 Then
            Select_personnality.SelectedItem = Select_personnality.Items.Item(3)
        ElseIf valu_personnality.Value = 4 Then
            Select_personnality.SelectedItem = Select_personnality.Items.Item(4)
        ElseIf valu_personnality.Value = 5 Then
            Select_personnality.SelectedItem = Select_personnality.Items.Item(5)
        ElseIf valu_personnality.Value = 6 Then
            Select_personnality.SelectedItem = Select_personnality.Items.Item(6)
        End If
    End Sub

    Private Sub Select_personnality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_personnality.SelectedIndexChanged
        If Select_personnality.SelectedItem = Select_personnality.Items.Item(0) Then
            valu_personnality.Value = 0
        ElseIf Select_personnality.SelectedItem = Select_personnality.Items.Item(1) Then
            valu_personnality.Value = 1
        ElseIf Select_personnality.SelectedItem = Select_personnality.Items.Item(2) Then
            valu_personnality.Value = 2
        ElseIf Select_personnality.SelectedItem = Select_personnality.Items.Item(3) Then
            valu_personnality.Value = 3
        ElseIf Select_personnality.SelectedItem = Select_personnality.Items.Item(4) Then
            valu_personnality.Value = 4
        ElseIf Select_personnality.SelectedItem = Select_personnality.Items.Item(5) Then
            valu_personnality.Value = 5
        ElseIf Select_personnality.SelectedItem = Select_personnality.Items.Item(6) Then
            valu_personnality.Value = 6
        End If
    End Sub
End Class