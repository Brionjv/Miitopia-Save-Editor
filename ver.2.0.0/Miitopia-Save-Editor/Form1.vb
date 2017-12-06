﻿Imports System.Net
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
    Dim innmii As Image
    Dim Miiname As String
    Dim Warcry As String
    Dim Personality As String
    Dim Job As String
    Dim Pose As String
    Dim Tummy As String
    Dim Innroom As String
    Dim Innroomposition As String
    Dim Sick As String
    Dim Expwarrior As String
    Dim Expmage As String
    Dim Expcleric As String
    Dim Expthief As String
    Dim Exppopstar As String
    Dim Expvampire As String
    Dim Expchef As String
    Dim Exptank As String
    Dim Expimp As String
    Dim Expprincess As String
    Dim Expflower As String
    Dim Expscientist As String
    Dim Expcat As String
    Dim Expelf As String
    Dim Daysick As String
    Dim FoodexpHP As String
    Dim FoodexpMP As String
    Dim Foodexpattack As String
    Dim Foodexpdefense As String
    Dim Foodexpmagic As String
    Dim Foodexpspeed As String
    Dim Active_interac As String
    Dim Interac_Mii As String
    Dim Interac_activity As String
    Dim Battles As String
    Dim Fblows As String
    Dim Defeats As String
    Dim Tlooparty As String
    Dim Hbgobbled As String
    Dim Mcgulped As String
    Dim Ggrubbed As String
    Dim Ggrabbed As String

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

    Public Sub Resetinnicon()
        Icon_inn_room_no.Image = Nothing
        Icon_inn_room_botleft_left.Image = Nothing
        Icon_inn_room_botleft_right.Image = Nothing
        Icon_inn_room_botright_left.Image = Nothing
        Icon_inn_room_botright_right.Image = Nothing
        Icon_inn_room_topleft_left.Image = Nothing
        Icon_inn_room_topleft_right.Image = Nothing
        Icon_inn_room_topright_left.Image = Nothing
        Icon_inn_room_topright_right.Image = Nothing
        Icon_inn_room_center_left.Image = Nothing
        Icon_inn_room_center_right.Image = Nothing
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

    Public Sub readfilehero()
        Try
            Dim Reader As New PackageIO.Reader(hero, PackageIO.Endian.Little)
            
            Button_open_hero.Visible = False
            Button_save_hero.Visible = True
        Catch ex As Exception
            fdialog.Title.Text = "Miitopia Save Editor : Read hero.sav"
            fdialog.Msg.Text = "Oops, something goes wrong" & vbNewLine & "opening of hero.sav failed, please report this issue or try again"
            fdialog.ShowDialog()
            Button_open_hero.Visible = True
            Button_save_hero.Visible = False
        End Try
    End Sub
    Public Sub writehero()
        Try
            Dim writer As New PackageIO.Writer(hero, PackageIO.Endian.Little)
            
            fdialog.Title.Text = "Miitopia Save Editor : write hero.sav"
            fdialog.Msg.Text = "hero.sav has been saved"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Title.Text = "Miitopia Save Editor : write hero.sav"
            fdialog.Msg.Text = "An error has occured" & vbNewLine & "please report this issue"
            fdialog.ShowDialog()
        End Try
    End Sub

    Public Sub makebakhero()
        Try
            If Filever_text.Text = "EU" Then
                My.Computer.FileSystem.CopyFile(
                          hero,
                        applicationpath & "\bak\hero.sav\EUR\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\hero.sav")
            End If
            If Filever_text.Text = "US" Then
                My.Computer.FileSystem.CopyFile(
                          hero,
                        applicationpath & "\bak\hero.sav\USA\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\hero.sav")
            End If
            If Filever_text.Text = "JP" Then
                My.Computer.FileSystem.CopyFile(
                          hero,
                        applicationpath & "\bak\hero.sav\JPN\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\hero.sav")
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

    Private Sub Text_menu_buttonS_Click(sender As Object, e As EventArgs) Handles Text_menu_buttonS.Click
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

    Private Sub Text_menu_buttonH_Click(sender As Object, e As EventArgs) Handles Text_menu_buttonH.Click
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
        Select_sick.SelectedItem = Select_sick.Items.Item(0)
        Select_world.SelectedItem = Select_world.Items.Item(0)
        Select_pose.SelectedItem = Select_pose.Items.Item(0)
        Select_personnality.SelectedItem = Select_personnality.Items.Item(0)
        Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(0)
        Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(0)
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
            valu_personnality.Visible = True
            valu_pose.Visible = True
            valu_job.Visible = True
            valu_tummy.Visible = True
            valu_inn_room.Visible = True
            valu_inn_roomposition.Visible = True
            valu_sick.Visible = True
            Bar_exp_warrior.Visible = True
            Bar_exp_mage.Visible = True
            Bar_exp_cleric.Visible = True
            Bar_exp_thief.Visible = True
            Bar_exp_popstar.Visible = True
            Bar_exp_vampire.Visible = True
            Bar_exp_chef.Visible = True
            Bar_exp_tank.Visible = True
            Bar_exp_imp.Visible = True
            Bar_exp_princess.Visible = True
            Bar_exp_flower.Visible = True
            Bar_exp_scientist.Visible = True
            Bar_exp_cat.Visible = True
            Bar_exp_elf.Visible = True
            valu_interaction.Visible = True
            valu_interac_Mii.Visible = True
            valu_interac_activity.Visible = True
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
            valu_personnality.Visible = False
            valu_pose.Visible = False
            valu_job.Visible = False
            valu_tummy.Visible = False
            valu_inn_room.Visible = False
            valu_inn_roomposition.Visible = False
            valu_sick.Visible = False
            Bar_exp_warrior.Visible = False
            Bar_exp_mage.Visible = False
            Bar_exp_cleric.Visible = False
            Bar_exp_thief.Visible = False
            Bar_exp_popstar.Visible = False
            Bar_exp_vampire.Visible = False
            Bar_exp_chef.Visible = False
            Bar_exp_tank.Visible = False
            Bar_exp_imp.Visible = False
            Bar_exp_princess.Visible = False
            Bar_exp_flower.Visible = False
            Bar_exp_scientist.Visible = False
            Bar_exp_cat.Visible = False
            Bar_exp_elf.Visible = False
            valu_interaction.Visible = False
            valu_interac_Mii.Visible = False
            valu_interac_activity.Visible = False
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

    Private Sub Text_open_hero_Click(sender As Object, e As EventArgs) Handles Text_open_hero.Click
        Dim open As New OpenFileDialog
        fdialog.Title.Text = "Miitopia Save Editor"
        fdialog.Msg.Text = "Open hero.sav file" & vbNewLine & "Miitopia Save Editor will make a backup of your save file, check ''bak'' folder" & vbNewLine & "Make a backup of your entire save file folder in case"
        fdialog.ShowDialog()
        open.Filter = "SAV files|*hero.sav"
        open.Title = "Open save hero.sav"
        open.ShowDialog()
        hero = open.FileName
        readfilehero()
        TextBox_fpath_hero.Text = hero
        makebakhero()
    End Sub

    Private Sub text_open_hero_MouseMove(sender As Object, e As EventArgs) Handles Text_open_hero.MouseMove, Button_save_hero.MouseMove
        Button_open_hero.BackgroundImage = My.Resources.button_save
    End Sub

    Private Sub text_open_hero_MouseLeave(sender As Object, e As EventArgs) Handles Text_open_hero.MouseLeave, Button_save_hero.MouseLeave
        Button_open_hero.BackgroundImage = My.Resources.button_open
    End Sub

    Private Sub Text_save_hero_Click(sender As Object, e As EventArgs) Handles Text_save_hero.Click
        writehero()
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
        ElseIf valu_job.Value = 255 Then
            Icon_job.Image = My.Resources.job_traveler
            innmii = Icon_job.Image
        End If
    End Sub

    Private Sub Icon_job_Click(sender As Object, e As EventArgs) Handles Icon_job.Click
        If valu_job.Value < 255 Then
            valu_job.Value = valu_job.Value + 1
        ElseIf valu_job.Value = 255 Then
            valu_job.Value = 0
        End If
        If valu_job.Value > 14 Then
            valu_job.Value = 255
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

    Private Sub valu_pose_ValueChanged(sender As Object, e As EventArgs) Handles valu_pose.ValueChanged
        If valu_pose.Value = 0 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(0)
        ElseIf valu_pose.Value = 1 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(1)
        ElseIf valu_pose.Value = 2 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(2)
        ElseIf valu_pose.Value = 3 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(3)
        ElseIf valu_pose.Value = 4 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(4)
        ElseIf valu_pose.Value = 5 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(5)
        ElseIf valu_pose.Value = 6 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(6)
        ElseIf valu_pose.Value = 7 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(7)
        ElseIf valu_pose.Value = 8 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(8)
        ElseIf valu_pose.Value = 9 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(9)
        ElseIf valu_pose.Value = 10 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(10)
        ElseIf valu_pose.Value = 11 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(11)
        ElseIf valu_pose.Value >= 12 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(12)
        End If
    End Sub

    Private Sub Select_pose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_pose.SelectedIndexChanged
        If Select_pose.SelectedItem = Select_pose.Items.Item(0) Then
            valu_pose.Value = 0
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(1) Then
            valu_pose.Value = 1
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(2) Then
            valu_pose.Value = 2
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(3) Then
            valu_pose.Value = 3
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(4) Then
            valu_pose.Value = 4
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(5) Then
            valu_pose.Value = 5
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(6) Then
            valu_pose.Value = 6
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(7) Then
            valu_pose.Value = 7
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(8) Then
            valu_pose.Value = 8
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(9) Then
            valu_pose.Value = 9
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(10) Then
            valu_pose.Value = 10
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(11) Then
            valu_pose.Value = 11
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(12) Then
            valu_pose.Value = 12
        End If
    End Sub

    Private Sub Text_showstats_Click(sender As Object, e As EventArgs) Handles Text_showstats.Click
        If Panel_hero_sw1.Visible = True Then
            Panel_hero_sw2.Visible = True
            Panel_hero_sw1.Visible = False
            Text_showstats.Text = "Hide stats"
        ElseIf Panel_hero_sw2.Visible = True Then
            Panel_hero_sw1.Visible = True
            Panel_hero_sw2.Visible = False
            Text_showstats.Text = "Show stats"
        End If
    End Sub

    Private Sub valu_inn_room_ValueChanged(sender As Object, e As EventArgs) Handles valu_inn_room.ValueChanged
        innmii = Icon_job.Image
        Resetinnicon()
        If valu_inn_room.Value = 0 And valu_inn_roomposition.Value = 0 Then
            Icon_inn_room_no.Image = innmii
        ElseIf valu_inn_room.Value = 0 And valu_inn_roomposition.Value = 1 Then
            Icon_inn_room_no.Image = innmii
        ElseIf valu_inn_room.Value = 1 And valu_inn_roomposition.Value = 0 Then
            Icon_inn_room_center_left.Image = innmii
        ElseIf valu_inn_room.Value = 1 And valu_inn_roomposition.Value = 1 Then
            Icon_inn_room_center_right.Image = innmii
        ElseIf valu_inn_room.Value = 2 And valu_inn_roomposition.Value = 0 Then
            Icon_inn_room_topleft_left.Image = innmii
        ElseIf valu_inn_room.Value = 2 And valu_inn_roomposition.Value = 1 Then
            Icon_inn_room_topleft_right.Image = innmii
        ElseIf valu_inn_room.Value = 3 And valu_inn_roomposition.Value = 0 Then
            Icon_inn_room_topright_left.Image = innmii
        ElseIf valu_inn_room.Value = 3 And valu_inn_roomposition.Value = 1 Then
            Icon_inn_room_topright_right.Image = innmii
        ElseIf valu_inn_room.Value = 4 And valu_inn_roomposition.Value = 0 Then
            Icon_inn_room_botleft_left.Image = innmii
        ElseIf valu_inn_room.Value = 4 And valu_inn_roomposition.Value = 1 Then
            Icon_inn_room_botleft_right.Image = innmii
        ElseIf valu_inn_room.Value = 5 And valu_inn_roomposition.Value = 0 Then
            Icon_inn_room_botright_left.Image = innmii
        ElseIf valu_inn_room.Value = 5 And valu_inn_roomposition.Value = 1 Then
            Icon_inn_room_botright_right.Image = innmii
        End If
    End Sub

    Private Sub valu_inn_roomposition_ValueChanged(sender As Object, e As EventArgs) Handles valu_inn_roomposition.ValueChanged
        innmii = Icon_job.Image
        Resetinnicon()
        If valu_inn_room.Value = 0 And valu_inn_roomposition.Value = 0 Then
            Icon_inn_room_no.Image = innmii
        ElseIf valu_inn_room.Value = 0 And valu_inn_roomposition.Value = 1 Then
            Icon_inn_room_no.Image = innmii
        ElseIf valu_inn_room.Value = 1 And valu_inn_roomposition.Value = 0 Then
            Icon_inn_room_center_left.Image = innmii
        ElseIf valu_inn_room.Value = 1 And valu_inn_roomposition.Value = 1 Then
            Icon_inn_room_center_right.Image = innmii
        ElseIf valu_inn_room.Value = 2 And valu_inn_roomposition.Value = 0 Then
            Icon_inn_room_topleft_left.Image = innmii
        ElseIf valu_inn_room.Value = 2 And valu_inn_roomposition.Value = 1 Then
            Icon_inn_room_topleft_right.Image = innmii
        ElseIf valu_inn_room.Value = 3 And valu_inn_roomposition.Value = 0 Then
            Icon_inn_room_topright_left.Image = innmii
        ElseIf valu_inn_room.Value = 3 And valu_inn_roomposition.Value = 1 Then
            Icon_inn_room_topright_right.Image = innmii
        ElseIf valu_inn_room.Value = 4 And valu_inn_roomposition.Value = 0 Then
            Icon_inn_room_botleft_left.Image = innmii
        ElseIf valu_inn_room.Value = 4 And valu_inn_roomposition.Value = 1 Then
            Icon_inn_room_botleft_right.Image = innmii
        ElseIf valu_inn_room.Value = 5 And valu_inn_roomposition.Value = 0 Then
            Icon_inn_room_botright_left.Image = innmii
        ElseIf valu_inn_room.Value = 5 And valu_inn_roomposition.Value = 1 Then
            Icon_inn_room_botright_right.Image = innmii
        End If
    End Sub

    Private Sub Icon_inn_room_no_Click(sender As Object, e As EventArgs) Handles Icon_inn_room_no.Click
        valu_inn_room.Value = 0
        valu_inn_roomposition.Value = 0
    End Sub

    Private Sub Icon_inn_room_center_left_Click(sender As Object, e As EventArgs) Handles Icon_inn_room_center_left.Click
        valu_inn_room.Value = 1
        valu_inn_roomposition.Value = 0
    End Sub

    Private Sub Icon_inn_room_center_right_Click(sender As Object, e As EventArgs) Handles Icon_inn_room_center_right.Click
        valu_inn_room.Value = 1
        valu_inn_roomposition.Value = 1
    End Sub

    Private Sub Icon_inn_room_topleft_left_Click(sender As Object, e As EventArgs) Handles Icon_inn_room_topleft_left.Click
        valu_inn_room.Value = 2
        valu_inn_roomposition.Value = 0
    End Sub

    Private Sub Icon_inn_room_topleft_right_Click(sender As Object, e As EventArgs) Handles Icon_inn_room_topleft_right.Click
        valu_inn_room.Value = 2
        valu_inn_roomposition.Value = 1
    End Sub

    Private Sub Icon_inn_room_topright_left_Click(sender As Object, e As EventArgs) Handles Icon_inn_room_topright_left.Click
        valu_inn_room.Value = 3
        valu_inn_roomposition.Value = 0
    End Sub

    Private Sub Icon_inn_room_topright_right_Click(sender As Object, e As EventArgs) Handles Icon_inn_room_topright_right.Click
        valu_inn_room.Value = 3
        valu_inn_roomposition.Value = 1
    End Sub

    Private Sub Icon_inn_room_botleft_left_Click(sender As Object, e As EventArgs) Handles Icon_inn_room_botleft_left.Click
        valu_inn_room.Value = 4
        valu_inn_roomposition.Value = 0
    End Sub

    Private Sub Icon_inn_room_botleft_right_Click(sender As Object, e As EventArgs) Handles Icon_inn_room_botleft_right.Click
        valu_inn_room.Value = 4
        valu_inn_roomposition.Value = 1
    End Sub

    Private Sub Icon_inn_room_botright_left_Click(sender As Object, e As EventArgs) Handles Icon_inn_room_botright_left.Click
        valu_inn_room.Value = 5
        valu_inn_roomposition.Value = 0
    End Sub

    Private Sub Icon_inn_room_botright_right_Click(sender As Object, e As EventArgs) Handles Icon_inn_room_botright_right.Click
        valu_inn_room.Value = 5
        valu_inn_roomposition.Value = 1
    End Sub

    Private Sub valu_sick_ValueChanged(sender As Object, e As EventArgs) Handles valu_sick.ValueChanged
        If valu_sick.Value = 0 Then
            Select_sick.SelectedItem = Select_sick.Items.Item(0)
        ElseIf valu_sick.Value = 1 Then
            Select_sick.SelectedItem = Select_sick.Items.Item(1)
        End If
    End Sub

    Private Sub Select_sick_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_sick.SelectedIndexChanged
        If Select_sick.SelectedItem = Select_sick.Items.Item(0) Then
            valu_sick.Value = 0
        ElseIf Select_sick.SelectedItem = Select_sick.Items.Item(1) Then
            valu_sick.Value = 1
        End If
    End Sub

    Private Sub Select_Mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_Mii.SelectedIndexChanged
        Try
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(0)
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(0)
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(0)
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(0)
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(0)
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(0)
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(0)
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(0)
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(0)
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(0)
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(0)
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(0)
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(0)
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(0)
            Dim Reader As New PackageIO.Reader(hero, PackageIO.Endian.Little)
            If Filever_text.Text = "US" Or Filever_text.Text = "EU" Then
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(0) Then
                    Reader.Position = &H70
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H86
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HC5
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HC6
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HC7
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HC8
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HC9
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HCA
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HCB
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HD8
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HDC
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HE0
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HE4
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HE8
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HEC
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HF0
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HF4
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HF8
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HFC
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &H100
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &H104
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &H108
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &H10C
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &H110
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &H114
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &H118
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &H11C
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H120
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H124
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H128
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H368
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H36A
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H36B
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H374
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H378
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H37C
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H380
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H384
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H388
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H38C
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H390
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(1) Then
                    Reader.Position = &H70 + &H398
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H86 + &H398
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HC5 + &H398
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HC6 + &H398
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HC7 + &H398
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HC8 + &H398
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HC9 + &H398
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HCA + &H398
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HCB + &H398
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HD8 + &H398
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + &H398
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + &H398
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + &H398
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + &H398
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + &H398
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + &H398
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + &H398
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + &H398
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + &H398
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + &H398
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + &H398
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + &H398
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &H10C + &H398
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &H110 + &H398
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &H114 + &H398
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &H118 + &H398
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &H11C + &H398
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H120 + &H398
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H124 + &H398
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H128 + &H398
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + &H398
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H36A + &H398
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H36B + &H398
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H374 + &H398
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + &H398
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + &H398
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + &H398
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + &H398
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + &H398
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + &H398
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + &H398
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    Reader.Position = &H70 + (&H398 * 2)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H86 + (&H398 * 2)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HC5 + (&H398 * 2)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HC6 + (&H398 * 2)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HC7 + (&H398 * 2)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HC8 + (&H398 * 2)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HC9 + (&H398 * 2)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HCA + (&H398 * 2)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HCB + (&H398 * 2)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HD8 + (&H398 * 2)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H398 * 2)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H398 * 2)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H398 * 2)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H398 * 2)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H398 * 2)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H398 * 2)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H398 * 2)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H398 * 2)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H398 * 2)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H398 * 2)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H398 * 2)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H398 * 2)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &H10C + (&H398 * 2)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &H110 + (&H398 * 2)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &H114 + (&H398 * 2)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &H118 + (&H398 * 2)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &H11C + (&H398 * 2)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H120 + (&H398 * 2)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H124 + (&H398 * 2)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H128 + (&H398 * 2)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H398 * 2)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H36A + (&H398 * 2)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H36B + (&H398 * 2)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H374 + (&H398 * 2)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 2)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 2)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 2)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 2)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 2)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 2)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 2)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(3) Then
                    Reader.Position = &H70 + (&H398 * 3)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H86 + (&H398 * 3)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HC5 + (&H398 * 3)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HC6 + (&H398 * 3)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HC7 + (&H398 * 3)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HC8 + (&H398 * 3)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HC9 + (&H398 * 3)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HCA + (&H398 * 3)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HCB + (&H398 * 3)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HD8 + (&H398 * 3)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H398 * 3)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H398 * 3)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H398 * 3)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H398 * 3)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H398 * 3)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H398 * 3)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H398 * 3)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H398 * 3)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H398 * 3)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H398 * 3)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H398 * 3)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H398 * 3)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &H10C + (&H398 * 3)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &H110 + (&H398 * 3)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &H114 + (&H398 * 3)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &H118 + (&H398 * 3)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &H11C + (&H398 * 3)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H120 + (&H398 * 3)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H124 + (&H398 * 3)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H128 + (&H398 * 3)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H398 * 3)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H36A + (&H398 * 3)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H36B + (&H398 * 3)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H374 + (&H398 * 3)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 3)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 3)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 3)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 3)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 3)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 3)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 3)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(4) Then
                    Reader.Position = &H70 + (&H398 * 4)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H86 + (&H398 * 4)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HC5 + (&H398 * 4)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HC6 + (&H398 * 4)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HC7 + (&H398 * 4)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HC8 + (&H398 * 4)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HC9 + (&H398 * 4)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HCA + (&H398 * 4)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HCB + (&H398 * 4)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HD8 + (&H398 * 4)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H398 * 4)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H398 * 4)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H398 * 4)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H398 * 4)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H398 * 4)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H398 * 4)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H398 * 4)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H398 * 4)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H398 * 4)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H398 * 4)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H398 * 4)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H398 * 4)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &H10C + (&H398 * 4)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &H110 + (&H398 * 4)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &H114 + (&H398 * 4)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &H118 + (&H398 * 4)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &H11C + (&H398 * 4)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H120 + (&H398 * 4)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H124 + (&H398 * 4)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H128 + (&H398 * 4)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H398 * 4)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H36A + (&H398 * 4)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H36B + (&H398 * 4)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H374 + (&H398 * 4)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 4)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 4)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 4)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 4)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 4)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 4)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 4)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(5) Then
                    Reader.Position = &H70 + (&H398 * 5)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H86 + (&H398 * 5)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HC5 + (&H398 * 5)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HC6 + (&H398 * 5)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HC7 + (&H398 * 5)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HC8 + (&H398 * 5)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HC9 + (&H398 * 5)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HCA + (&H398 * 5)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HCB + (&H398 * 5)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HD8 + (&H398 * 5)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H398 * 5)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H398 * 5)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H398 * 5)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H398 * 5)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H398 * 5)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H398 * 5)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H398 * 5)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H398 * 5)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H398 * 5)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H398 * 5)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H398 * 5)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H398 * 5)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &H10C + (&H398 * 5)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &H110 + (&H398 * 5)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &H114 + (&H398 * 5)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &H118 + (&H398 * 5)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &H11C + (&H398 * 5)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H120 + (&H398 * 5)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H124 + (&H398 * 5)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H128 + (&H398 * 5)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H398 * 5)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H36A + (&H398 * 5)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H36B + (&H398 * 5)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H374 + (&H398 * 5)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 5)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 5)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 5)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 5)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 5)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 5)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 5)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(6) Then
                    Reader.Position = &H70 + (&H398 * 6)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H86 + (&H398 * 6)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HC5 + (&H398 * 6)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HC6 + (&H398 * 6)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HC7 + (&H398 * 6)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HC8 + (&H398 * 6)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HC9 + (&H398 * 6)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HCA + (&H398 * 6)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HCB + (&H398 * 6)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HD8 + (&H398 * 6)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H398 * 6)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H398 * 6)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H398 * 6)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H398 * 6)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H398 * 6)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H398 * 6)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H398 * 6)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H398 * 6)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H398 * 6)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H398 * 6)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H398 * 6)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H398 * 6)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &H10C + (&H398 * 6)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &H110 + (&H398 * 6)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &H114 + (&H398 * 6)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &H118 + (&H398 * 6)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &H11C + (&H398 * 6)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H120 + (&H398 * 6)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H124 + (&H398 * 6)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H128 + (&H398 * 6)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H398 * 6)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H36A + (&H398 * 6)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H36B + (&H398 * 6)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H374 + (&H398 * 6)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 6)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 6)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 6)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 6)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 6)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 6)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 6)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(7) Then
                    Reader.Position = &H70 + (&H398 * 7)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H86 + (&H398 * 7)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HC5 + (&H398 * 7)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HC6 + (&H398 * 7)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HC7 + (&H398 * 7)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HC8 + (&H398 * 7)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HC9 + (&H398 * 7)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HCA + (&H398 * 7)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HCB + (&H398 * 7)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HD8 + (&H398 * 7)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H398 * 7)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H398 * 7)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H398 * 7)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H398 * 7)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H398 * 7)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H398 * 7)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H398 * 7)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H398 * 7)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H398 * 7)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H398 * 7)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H398 * 7)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H398 * 7)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &H10C + (&H398 * 7)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &H110 + (&H398 * 7)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &H114 + (&H398 * 7)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &H118 + (&H398 * 7)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &H11C + (&H398 * 7)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H120 + (&H398 * 7)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H124 + (&H398 * 7)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H128 + (&H398 * 7)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H398 * 7)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H36A + (&H398 * 7)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H36B + (&H398 * 7)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H374 + (&H398 * 7)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 7)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 7)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 7)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 7)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 7)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 7)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 7)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(8) Then
                    Reader.Position = &H70 + (&H398 * 8)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H86 + (&H398 * 8)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HC5 + (&H398 * 8)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HC6 + (&H398 * 8)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HC7 + (&H398 * 8)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HC8 + (&H398 * 8)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HC9 + (&H398 * 8)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HCA + (&H398 * 8)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HCB + (&H398 * 8)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HD8 + (&H398 * 8)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H398 * 8)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H398 * 8)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H398 * 8)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H398 * 8)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H398 * 8)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H398 * 8)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H398 * 8)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H398 * 8)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H398 * 8)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H398 * 8)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H398 * 8)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H398 * 8)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &H10C + (&H398 * 8)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &H110 + (&H398 * 8)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &H114 + (&H398 * 8)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &H118 + (&H398 * 8)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &H11C + (&H398 * 8)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H120 + (&H398 * 8)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H124 + (&H398 * 8)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H128 + (&H398 * 8)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H398 * 8)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H36A + (&H398 * 8)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H36B + (&H398 * 8)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H374 + (&H398 * 8)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 8)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 8)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 8)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 8)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 8)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 8)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 8)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(9) Then
                    Reader.Position = &H70 + (&H398 * 9)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H86 + (&H398 * 9)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HC5 + (&H398 * 9)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HC6 + (&H398 * 9)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HC7 + (&H398 * 9)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HC8 + (&H398 * 9)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HC9 + (&H398 * 9)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HCA + (&H398 * 9)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HCB + (&H398 * 9)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HD8 + (&H398 * 9)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H398 * 9)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H398 * 9)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H398 * 9)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H398 * 9)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H398 * 9)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H398 * 9)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H398 * 9)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H398 * 9)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H398 * 9)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H398 * 9)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H398 * 9)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H398 * 9)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &H10C + (&H398 * 9)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &H110 + (&H398 * 9)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &H114 + (&H398 * 9)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &H118 + (&H398 * 9)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &H11C + (&H398 * 9)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H120 + (&H398 * 9)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H124 + (&H398 * 9)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H128 + (&H398 * 9)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H398 * 9)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H36A + (&H398 * 9)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H36B + (&H398 * 9)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H374 + (&H398 * 9)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 9)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 9)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 9)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 9)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 9)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 9)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 9)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If
            End If
            If Filever_text.Text = "JP" Then
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(0) Then
                    Reader.Position = &H70
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H8C
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HA5
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HA6
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HA7
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HA8
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HA9
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HAA
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HAB
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HB8
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HBC
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HC0
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HC4
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HC8
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HCC
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HD0
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HD4
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HD8
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HDC
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &HE0
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &HE4
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &HE8
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &HEC
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &HF0
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &HF4
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &HF8
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &HFC
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H100
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H104
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H108
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H348
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H34A
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H34B
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H354
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H358
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H35C
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H360
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H364
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H368
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H36C
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H370
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(1) Then
                    Reader.Position = &H70 + &H378
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H8C + &H378
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HA5 + &H378
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HA6 + &H378
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HA7 + &H378
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HA8 + &H378
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HA9 + &H378
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HAA + &H378
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HAB + &H378
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HB8 + &H378
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HBC + &H378
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HC0 + &H378
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HC4 + &H378
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HC8 + &H378
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HCC + &H378
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HD0 + &H378
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HD4 + &H378
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HD8 + &H378
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + &H378
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + &H378
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + &H378
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + &H378
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + &H378
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + &H378
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + &H378
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + &H378
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + &H378
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + &H378
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + &H378
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + &H378
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H348 + &H378
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H34A + &H378
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H34B + &H378
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H354 + &H378
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + &H378
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + &H378
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + &H378
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + &H378
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + &H378
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + &H378
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + &H378
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    Reader.Position = &H70 + (&H378 * 2)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H8C + (&H378 * 2)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HA5 + (&H378 * 2)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HA6 + (&H378 * 2)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HA7 + (&H378 * 2)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HA8 + (&H378 * 2)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HA9 + (&H378 * 2)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HAA + (&H378 * 2)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HAB + (&H378 * 2)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HB8 + (&H378 * 2)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HBC + (&H378 * 2)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HC0 + (&H378 * 2)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HC4 + (&H378 * 2)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HC8 + (&H378 * 2)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HCC + (&H378 * 2)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HD0 + (&H378 * 2)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HD4 + (&H378 * 2)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HD8 + (&H378 * 2)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H378 * 2)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H378 * 2)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H378 * 2)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H378 * 2)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H378 * 2)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H378 * 2)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H378 * 2)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H378 * 2)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H378 * 2)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H378 * 2)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H378 * 2)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H378 * 2)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H348 + (&H378 * 2)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H34A + (&H378 * 2)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H34B + (&H378 * 2)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H354 + (&H378 * 2)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 2)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 2)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 2)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 2)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 2)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 2)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 2)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    Reader.Position = &H70 + (&H378 * 3)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H8C + (&H378 * 3)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HA5 + (&H378 * 3)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HA6 + (&H378 * 3)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HA7 + (&H378 * 3)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HA8 + (&H378 * 3)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HA9 + (&H378 * 3)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HAA + (&H378 * 3)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HAB + (&H378 * 3)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HB8 + (&H378 * 3)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HBC + (&H378 * 3)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HC0 + (&H378 * 3)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HC4 + (&H378 * 3)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HC8 + (&H378 * 3)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HCC + (&H378 * 3)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HD0 + (&H378 * 3)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HD4 + (&H378 * 3)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HD8 + (&H378 * 3)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H378 * 3)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H378 * 3)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H378 * 3)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H378 * 3)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H378 * 3)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H378 * 3)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H378 * 3)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H378 * 3)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H378 * 3)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H378 * 3)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H378 * 3)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H378 * 3)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H348 + (&H378 * 3)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H34A + (&H378 * 3)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H34B + (&H378 * 3)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H354 + (&H378 * 3)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 3)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 3)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 3)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 3)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 3)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 3)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 3)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    Reader.Position = &H70 + (&H378 * 4)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H8C + (&H378 * 4)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HA5 + (&H378 * 4)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HA6 + (&H378 * 4)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HA7 + (&H378 * 4)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HA8 + (&H378 * 4)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HA9 + (&H378 * 4)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HAA + (&H378 * 4)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HAB + (&H378 * 4)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HB8 + (&H378 * 4)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HBC + (&H378 * 4)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HC0 + (&H378 * 4)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HC4 + (&H378 * 4)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HC8 + (&H378 * 4)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HCC + (&H378 * 4)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HD0 + (&H378 * 4)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HD4 + (&H378 * 4)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HD8 + (&H378 * 4)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H378 * 4)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H378 * 4)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H378 * 4)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H378 * 4)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H378 * 4)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H378 * 4)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H378 * 4)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H378 * 4)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H378 * 4)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H378 * 4)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H378 * 4)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H378 * 4)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H348 + (&H378 * 4)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H34A + (&H378 * 4)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H34B + (&H378 * 4)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H354 + (&H378 * 4)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 4)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 4)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 4)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 4)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 4)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 4)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 4)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    Reader.Position = &H70 + (&H378 * 5)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H8C + (&H378 * 5)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HA5 + (&H378 * 5)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HA6 + (&H378 * 5)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HA7 + (&H378 * 5)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HA8 + (&H378 * 5)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HA9 + (&H378 * 5)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HAA + (&H378 * 5)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HAB + (&H378 * 5)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HB8 + (&H378 * 5)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HBC + (&H378 * 5)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HC0 + (&H378 * 5)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HC4 + (&H378 * 5)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HC8 + (&H378 * 5)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HCC + (&H378 * 5)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HD0 + (&H378 * 5)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HD4 + (&H378 * 5)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HD8 + (&H378 * 5)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H378 * 5)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H378 * 5)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H378 * 5)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H378 * 5)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H378 * 5)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H378 * 5)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H378 * 5)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H378 * 5)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H378 * 5)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H378 * 5)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H378 * 5)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H378 * 5)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H348 + (&H378 * 5)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H34A + (&H378 * 5)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H34B + (&H378 * 5)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H354 + (&H378 * 5)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 5)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 5)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 5)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 5)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 5)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 5)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 5)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    Reader.Position = &H70 + (&H378 * 6)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H8C + (&H378 * 6)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HA5 + (&H378 * 6)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HA6 + (&H378 * 6)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HA7 + (&H378 * 6)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HA8 + (&H378 * 6)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HA9 + (&H378 * 6)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HAA + (&H378 * 6)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HAB + (&H378 * 6)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HB8 + (&H378 * 6)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HBC + (&H378 * 6)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HC0 + (&H378 * 6)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HC4 + (&H378 * 6)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HC8 + (&H378 * 6)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HCC + (&H378 * 6)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HD0 + (&H378 * 6)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HD4 + (&H378 * 6)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HD8 + (&H378 * 6)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H378 * 6)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H378 * 6)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H378 * 6)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H378 * 6)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H378 * 6)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H378 * 6)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H378 * 6)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H378 * 6)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H378 * 6)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H378 * 6)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H378 * 6)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H378 * 6)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H348 + (&H378 * 6)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H34A + (&H378 * 6)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H34B + (&H378 * 6)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H354 + (&H378 * 6)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 6)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 6)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 6)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 6)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 6)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 6)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 6)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    Reader.Position = &H70 + (&H378 * 7)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H8C + (&H378 * 7)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HA5 + (&H378 * 7)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HA6 + (&H378 * 7)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HA7 + (&H378 * 7)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HA8 + (&H378 * 7)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HA9 + (&H378 * 7)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HAA + (&H378 * 7)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HAB + (&H378 * 7)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HB8 + (&H378 * 7)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HBC + (&H378 * 7)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HC0 + (&H378 * 7)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HC4 + (&H378 * 7)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HC8 + (&H378 * 7)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HCC + (&H378 * 7)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HD0 + (&H378 * 7)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HD4 + (&H378 * 7)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HD8 + (&H378 * 7)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H378 * 7)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H378 * 7)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H378 * 7)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H378 * 7)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H378 * 7)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H378 * 7)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H378 * 7)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H378 * 7)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H378 * 7)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H378 * 7)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H378 * 7)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H378 * 7)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H348 + (&H378 * 7)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H34A + (&H378 * 7)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H34B + (&H378 * 7)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H354 + (&H378 * 7)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 7)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 7)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 7)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 7)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 7)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 7)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 7)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    Reader.Position = &H70 + (&H378 * 8)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H8C + (&H378 * 8)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HA5 + (&H378 * 8)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HA6 + (&H378 * 8)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HA7 + (&H378 * 8)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HA8 + (&H378 * 8)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HA9 + (&H378 * 8)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HAA + (&H378 * 8)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HAB + (&H378 * 8)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HB8 + (&H378 * 8)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HBC + (&H378 * 8)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HC0 + (&H378 * 8)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HC4 + (&H378 * 8)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HC8 + (&H378 * 8)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HCC + (&H378 * 8)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HD0 + (&H378 * 8)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HD4 + (&H378 * 8)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HD8 + (&H378 * 8)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H378 * 8)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H378 * 8)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H378 * 8)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H378 * 8)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H378 * 8)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H378 * 8)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H378 * 8)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H378 * 8)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H378 * 8)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H378 * 8)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H378 * 8)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H378 * 8)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H348 + (&H378 * 8)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H34A + (&H378 * 8)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H34B + (&H378 * 8)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H354 + (&H378 * 8)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 8)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 8)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 8)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 8)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 8)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 8)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 8)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If

                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    Reader.Position = &H70 + (&H378 * 9)
                    Miiname = Reader.Position
                    Text_Mii_name.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &H8C + (&H378 * 9)
                    Warcry = Reader.Position
                    Text_warcry.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &HA5 + (&H378 * 9)
                    Personality = Reader.Position
                    valu_personnality.Value = Reader.ReadInt8
                    Reader.Position = &HA6 + (&H378 * 9)
                    Job = Reader.Position
                    valu_job.Value = Reader.ReadInt8
                    Reader.Position = &HA7 + (&H378 * 9)
                    Pose = Reader.Position
                    valu_pose.Value = Reader.ReadByte
                    Reader.Position = &HA8 + (&H378 * 9)
                    Tummy = Reader.Position
                    valu_tummy.Value = Reader.ReadInt8
                    Reader.Position = &HA9 + (&H378 * 9)
                    Innroom = Reader.Position
                    valu_inn_room.Value = Reader.ReadInt8
                    Reader.Position = &HAA + (&H378 * 9)
                    Innroomposition = Reader.Position
                    valu_inn_roomposition.Value = Reader.ReadInt8
                    Reader.Position = &HAB + (&H378 * 9)
                    Sick = Reader.Position
                    valu_sick.Value = Reader.ReadInt8
                    Reader.Position = &HB8 + (&H378 * 9)
                    Expwarrior = Reader.Position
                    valu_exp_warrior.Value = Reader.ReadUInt32
                    Reader.Position = &HBC + (&H378 * 9)
                    Expmage = Reader.Position
                    valu_exp_mage.Value = Reader.ReadUInt32
                    Reader.Position = &HC0 + (&H378 * 9)
                    Expcleric = Reader.Position
                    valu_exp_cleric.Value = Reader.ReadUInt32
                    Reader.Position = &HC4 + (&H378 * 9)
                    Expthief = Reader.Position
                    valu_exp_thief.Value = Reader.ReadUInt32
                    Reader.Position = &HC8 + (&H378 * 9)
                    Exppopstar = Reader.Position
                    valu_exp_popstar.Value = Reader.ReadUInt32
                    Reader.Position = &HCC + (&H378 * 9)
                    Expvampire = Reader.Position
                    valu_exp_vampire.Value = Reader.ReadUInt32
                    Reader.Position = &HD0 + (&H378 * 9)
                    Expchef = Reader.Position
                    valu_exp_chef.Value = Reader.ReadUInt32
                    Reader.Position = &HD4 + (&H378 * 9)
                    Exptank = Reader.Position
                    valu_exp_tank.Value = Reader.ReadUInt32
                    Reader.Position = &HD8 + (&H378 * 9)
                    Expimp = Reader.Position
                    valu_exp_imp.Value = Reader.ReadUInt32
                    Reader.Position = &HDC + (&H378 * 9)
                    Expprincess = Reader.Position
                    valu_exp_princess.Value = Reader.ReadUInt32
                    Reader.Position = &HE0 + (&H378 * 9)
                    Expflower = Reader.Position
                    valu_exp_flower.Value = Reader.ReadUInt32
                    Reader.Position = &HE4 + (&H378 * 9)
                    Expscientist = Reader.Position
                    valu_exp_scientist.Value = Reader.ReadUInt32
                    Reader.Position = &HE8 + (&H378 * 9)
                    Expcat = Reader.Position
                    valu_exp_cat.Value = Reader.ReadUInt32
                    Reader.Position = &HEC + (&H378 * 9)
                    Expelf = Reader.Position
                    valu_exp_elf.Value = Reader.ReadUInt32
                    Reader.Position = &HF0 + (&H378 * 9)
                    Daysick = Reader.Position
                    valu_daysick.Value = Reader.ReadUInt32
                    Reader.Position = &HF4 + (&H378 * 9)
                    FoodexpHP = Reader.Position
                    valu_foodexp_HP.Value = Reader.ReadUInt32
                    Reader.Position = &HF8 + (&H378 * 9)
                    FoodexpMP = Reader.Position
                    valu_foodexp_MP.Value = Reader.ReadUInt32
                    Reader.Position = &HFC + (&H378 * 9)
                    Foodexpattack = Reader.Position
                    valu_foodexp_attack.Value = Reader.ReadUInt32
                    Reader.Position = &H100 + (&H378 * 9)
                    Foodexpdefense = Reader.Position
                    valu_foodexp_defense.Value = Reader.ReadUInt32
                    Reader.Position = &H104 + (&H378 * 9)
                    Foodexpmagic = Reader.Position
                    valu_foodexp_magic.Value = Reader.ReadUInt32
                    Reader.Position = &H108 + (&H378 * 9)
                    Foodexpspeed = Reader.Position
                    valu_foodexp_speed.Value = Reader.ReadUInt32
                    Reader.Position = &H348 + (&H378 * 9)
                    Active_interac = Reader.Position
                    valu_interaction.Value = Reader.ReadUInt16
                    Reader.Position = &H34A + (&H378 * 9)
                    Interac_Mii = Reader.Position
                    valu_interac_Mii.Value = Reader.ReadByte
                    Reader.Position = &H34B + (&H378 * 9)
                    Interac_activity = Reader.Position
                    valu_interac_activity.Value = Reader.ReadByte
                    Reader.Position = &H354 + (&H378 * 9)
                    Battles = Reader.Position
                    valu_battles.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 9)
                    Fblows = Reader.Position
                    valu_fblows.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 9)
                    Defeats = Reader.Position
                    valu_defeats.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 9)
                    Tlooparty = Reader.Position
                    valu_tlooparty.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 9)
                    Hbgobbled = Reader.Position
                    valu_hbgobbled.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 9)
                    Mcgulped = Reader.Position
                    valu_mcgulped.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 9)
                    Ggrubbed = Reader.Position
                    valu_ggrubbed.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 9)
                    Ggrabbed = Reader.Position
                    valu_ggrabbed.Value = Reader.ReadUInt32
                End If
            End If
        Catch ex As Exception
            Select_Mii.SelectedItem = Nothing
            fdialog.Title.Text = "Miitopia Save Editor : select Mii"
            fdialog.Msg.Text = "An error has occured, load a save file first"
            fdialog.ShowDialog()
        End Try
    End Sub

    Private Sub Icon_interaction_Click(sender As Object, e As EventArgs) Handles Icon_interaction.Click
        If valu_interaction.Value = 65280 Then
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(0) Then
                valu_interaction.Value = 1
            ElseIf Select_Mii.SelectedItem = Select_Mii.Items.Item(1) Then
                valu_interaction.Value = 258
            ElseIf Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                valu_interaction.Value = 515
            ElseIf Select_Mii.SelectedItem = Select_Mii.Items.Item(3) Then
                valu_interaction.Value = 772
            ElseIf Select_Mii.SelectedItem = Select_Mii.Items.Item(4) Then
                valu_interaction.Value = 1029
            ElseIf Select_Mii.SelectedItem = Select_Mii.Items.Item(5) Then
                valu_interaction.Value = 1286
            ElseIf Select_Mii.SelectedItem = Select_Mii.Items.Item(6) Then
                valu_interaction.Value = 1543
            ElseIf Select_Mii.SelectedItem = Select_Mii.Items.Item(7) Then
                valu_interaction.Value = 1800
            ElseIf Select_Mii.SelectedItem = Select_Mii.Items.Item(8) Then
                valu_interaction.Value = 2057
            ElseIf Select_Mii.SelectedItem = Select_Mii.Items.Item(9) Then
                valu_interaction.Value = 2314
            End If
            valu_interac_Mii.Value = 1
        ElseIf valu_interaction.Value < 65280 Then
            valu_interaction.Value = 65280
            valu_interac_Mii.Value = 255
            valu_interac_activity.Value = 0
        End If
    End Sub

    Private Sub valu_interaction_ValueChanged(sender As Object, e As EventArgs) Handles valu_interaction.ValueChanged
        If valu_interaction.Value = 65280 Then
            Icon_interaction.Image = My.Resources.mse_nostub
        ElseIf valu_interaction.Value < 65280 Then
            Icon_interaction.Image = My.Resources.mse_stub
        End If
    End Sub

    Private Sub Icon_tummy_Click(sender As Object, e As EventArgs) Handles Icon_tummy.Click
        If valu_tummy.Value > 0 And valu_tummy.Value < 100 Then
            valu_tummy.Value = 0
        ElseIf valu_tummy.Value = 0 Then
            valu_tummy.Value = 100
        ElseIf valu_tummy.Value = 100 Then
            valu_tummy.Value = 0
        End If
    End Sub

    Private Sub valu_tummy_ValueChanged(sender As Object, e As EventArgs) Handles valu_tummy.ValueChanged
        If valu_tummy.Value > 0 And valu_tummy.Value < 100 Then
            Icon_tummy.Image = My.Resources.tumunknow
        ElseIf valu_tummy.Value = 0 Then
            Icon_tummy.Image = My.Resources.Tumempty
        ElseIf valu_tummy.Value = 100 Then
            Icon_tummy.Image = My.Resources.Tumfull
        End If
    End Sub

    Private Sub Select_exp_warrior_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_warrior.SelectedIndexChanged
        If Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(0) Then
            valu_exp_warrior.Value = 0
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(1) Then
            valu_exp_warrior.Value = 10
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(2) Then
            valu_exp_warrior.Value = 50
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(3) Then
            valu_exp_warrior.Value = 150
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(4) Then
            valu_exp_warrior.Value = 340
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(5) Then
            valu_exp_warrior.Value = 650
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(6) Then
            valu_exp_warrior.Value = 1140
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(7) Then
            valu_exp_warrior.Value = 1870
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(8) Then
            valu_exp_warrior.Value = 2920
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(9) Then
            valu_exp_warrior.Value = 4390
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(10) Then
            valu_exp_warrior.Value = 6390
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(11) Then
            valu_exp_warrior.Value = 9060
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(12) Then
            valu_exp_warrior.Value = 12570
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(13) Then
            valu_exp_warrior.Value = 17120
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(14) Then
            valu_exp_warrior.Value = 22920
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(15) Then
            valu_exp_warrior.Value = 30230
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(16) Then
            valu_exp_warrior.Value = 39340
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(17) Then
            valu_exp_warrior.Value = 50580
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(18) Then
            valu_exp_warrior.Value = 64320
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(19) Then
            valu_exp_warrior.Value = 80960
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(20) Then
            valu_exp_warrior.Value = 100960
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(21) Then
            valu_exp_warrior.Value = 124820
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(22) Then
            valu_exp_warrior.Value = 153090
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(23) Then
            valu_exp_warrior.Value = 186360
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(24) Then
            valu_exp_warrior.Value = 225300
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(25) Then
            valu_exp_warrior.Value = 270610
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(26) Then
            valu_exp_warrior.Value = 315920
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(27) Then
            valu_exp_warrior.Value = 361230
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(28) Then
            valu_exp_warrior.Value = 406540
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(29) Then
            valu_exp_warrior.Value = 451850
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(30) Then
            valu_exp_warrior.Value = 497160
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(31) Then
            valu_exp_warrior.Value = 545590
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(32) Then
            valu_exp_warrior.Value = 599690
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(33) Then
            valu_exp_warrior.Value = 659900
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(34) Then
            valu_exp_warrior.Value = 726690
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(35) Then
            valu_exp_warrior.Value = 800540
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(36) Then
            valu_exp_warrior.Value = 881950
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(37) Then
            valu_exp_warrior.Value = 971440
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(38) Then
            valu_exp_warrior.Value = 1069540
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(39) Then
            valu_exp_warrior.Value = 1176790
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(40) Then
            valu_exp_warrior.Value = 1293750
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(41) Then
            valu_exp_warrior.Value = 1420990
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(42) Then
            valu_exp_warrior.Value = 1559090
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(43) Then
            valu_exp_warrior.Value = 1708640
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(44) Then
            valu_exp_warrior.Value = 1870250
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(45) Then
            valu_exp_warrior.Value = 2044530
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(46) Then
            valu_exp_warrior.Value = 2232090
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(47) Then
            valu_exp_warrior.Value = 2448870
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(48) Then
            valu_exp_warrior.Value = 2698120
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(49) Then
            valu_exp_warrior.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_mage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_mage.SelectedIndexChanged
        If Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(0) Then
            valu_exp_mage.Value = 0
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(1) Then
            valu_exp_mage.Value = 10
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(2) Then
            valu_exp_mage.Value = 50
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(3) Then
            valu_exp_mage.Value = 150
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(4) Then
            valu_exp_mage.Value = 340
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(5) Then
            valu_exp_mage.Value = 650
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(6) Then
            valu_exp_mage.Value = 1140
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(7) Then
            valu_exp_mage.Value = 1870
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(8) Then
            valu_exp_mage.Value = 2920
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(9) Then
            valu_exp_mage.Value = 4390
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(10) Then
            valu_exp_mage.Value = 6390
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(11) Then
            valu_exp_mage.Value = 9060
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(12) Then
            valu_exp_mage.Value = 12570
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(13) Then
            valu_exp_mage.Value = 17120
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(14) Then
            valu_exp_mage.Value = 22920
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(15) Then
            valu_exp_mage.Value = 30230
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(16) Then
            valu_exp_mage.Value = 39340
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(17) Then
            valu_exp_mage.Value = 50580
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(18) Then
            valu_exp_mage.Value = 64320
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(19) Then
            valu_exp_mage.Value = 80960
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(20) Then
            valu_exp_mage.Value = 100960
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(21) Then
            valu_exp_mage.Value = 124820
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(22) Then
            valu_exp_mage.Value = 153090
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(23) Then
            valu_exp_mage.Value = 186360
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(24) Then
            valu_exp_mage.Value = 225300
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(25) Then
            valu_exp_mage.Value = 270610
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(26) Then
            valu_exp_mage.Value = 315920
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(27) Then
            valu_exp_mage.Value = 361230
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(28) Then
            valu_exp_mage.Value = 406540
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(29) Then
            valu_exp_mage.Value = 451850
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(30) Then
            valu_exp_mage.Value = 497160
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(31) Then
            valu_exp_mage.Value = 545590
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(32) Then
            valu_exp_mage.Value = 599690
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(33) Then
            valu_exp_mage.Value = 659900
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(34) Then
            valu_exp_mage.Value = 726690
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(35) Then
            valu_exp_mage.Value = 800540
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(36) Then
            valu_exp_mage.Value = 881950
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(37) Then
            valu_exp_mage.Value = 971440
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(38) Then
            valu_exp_mage.Value = 1069540
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(39) Then
            valu_exp_mage.Value = 1176790
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(40) Then
            valu_exp_mage.Value = 1293750
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(41) Then
            valu_exp_mage.Value = 1420990
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(42) Then
            valu_exp_mage.Value = 1559090
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(43) Then
            valu_exp_mage.Value = 1708640
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(44) Then
            valu_exp_mage.Value = 1870250
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(45) Then
            valu_exp_mage.Value = 2044530
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(46) Then
            valu_exp_mage.Value = 2232090
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(47) Then
            valu_exp_mage.Value = 2448870
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(48) Then
            valu_exp_mage.Value = 2698120
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(49) Then
            valu_exp_mage.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_cleric_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_cleric.SelectedIndexChanged
        If Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(0) Then
            valu_exp_cleric.Value = 0
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(1) Then
            valu_exp_cleric.Value = 10
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(2) Then
            valu_exp_cleric.Value = 50
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(3) Then
            valu_exp_cleric.Value = 150
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(4) Then
            valu_exp_cleric.Value = 340
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(5) Then
            valu_exp_cleric.Value = 650
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(6) Then
            valu_exp_cleric.Value = 1140
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(7) Then
            valu_exp_cleric.Value = 1870
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(8) Then
            valu_exp_cleric.Value = 2920
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(9) Then
            valu_exp_cleric.Value = 4390
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(10) Then
            valu_exp_cleric.Value = 6390
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(11) Then
            valu_exp_cleric.Value = 9060
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(12) Then
            valu_exp_cleric.Value = 12570
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(13) Then
            valu_exp_cleric.Value = 17120
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(14) Then
            valu_exp_cleric.Value = 22920
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(15) Then
            valu_exp_cleric.Value = 30230
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(16) Then
            valu_exp_cleric.Value = 39340
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(17) Then
            valu_exp_cleric.Value = 50580
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(18) Then
            valu_exp_cleric.Value = 64320
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(19) Then
            valu_exp_cleric.Value = 80960
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(20) Then
            valu_exp_cleric.Value = 100960
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(21) Then
            valu_exp_cleric.Value = 124820
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(22) Then
            valu_exp_cleric.Value = 153090
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(23) Then
            valu_exp_cleric.Value = 186360
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(24) Then
            valu_exp_cleric.Value = 225300
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(25) Then
            valu_exp_cleric.Value = 270610
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(26) Then
            valu_exp_cleric.Value = 315920
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(27) Then
            valu_exp_cleric.Value = 361230
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(28) Then
            valu_exp_cleric.Value = 406540
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(29) Then
            valu_exp_cleric.Value = 451850
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(30) Then
            valu_exp_cleric.Value = 497160
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(31) Then
            valu_exp_cleric.Value = 545590
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(32) Then
            valu_exp_cleric.Value = 599690
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(33) Then
            valu_exp_cleric.Value = 659900
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(34) Then
            valu_exp_cleric.Value = 726690
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(35) Then
            valu_exp_cleric.Value = 800540
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(36) Then
            valu_exp_cleric.Value = 881950
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(37) Then
            valu_exp_cleric.Value = 971440
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(38) Then
            valu_exp_cleric.Value = 1069540
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(39) Then
            valu_exp_cleric.Value = 1176790
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(40) Then
            valu_exp_cleric.Value = 1293750
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(41) Then
            valu_exp_cleric.Value = 1420990
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(42) Then
            valu_exp_cleric.Value = 1559090
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(43) Then
            valu_exp_cleric.Value = 1708640
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(44) Then
            valu_exp_cleric.Value = 1870250
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(45) Then
            valu_exp_cleric.Value = 2044530
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(46) Then
            valu_exp_cleric.Value = 2232090
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(47) Then
            valu_exp_cleric.Value = 2448870
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(48) Then
            valu_exp_cleric.Value = 2698120
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(49) Then
            valu_exp_cleric.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_thief_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_thief.SelectedIndexChanged
        If Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(0) Then
            valu_exp_thief.Value = 0
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(1) Then
            valu_exp_thief.Value = 10
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(2) Then
            valu_exp_thief.Value = 50
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(3) Then
            valu_exp_thief.Value = 150
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(4) Then
            valu_exp_thief.Value = 340
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(5) Then
            valu_exp_thief.Value = 650
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(6) Then
            valu_exp_thief.Value = 1140
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(7) Then
            valu_exp_thief.Value = 1870
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(8) Then
            valu_exp_thief.Value = 2920
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(9) Then
            valu_exp_thief.Value = 4390
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(10) Then
            valu_exp_thief.Value = 6390
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(11) Then
            valu_exp_thief.Value = 9060
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(12) Then
            valu_exp_thief.Value = 12570
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(13) Then
            valu_exp_thief.Value = 17120
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(14) Then
            valu_exp_thief.Value = 22920
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(15) Then
            valu_exp_thief.Value = 30230
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(16) Then
            valu_exp_thief.Value = 39340
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(17) Then
            valu_exp_thief.Value = 50580
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(18) Then
            valu_exp_thief.Value = 64320
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(19) Then
            valu_exp_thief.Value = 80960
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(20) Then
            valu_exp_thief.Value = 100960
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(21) Then
            valu_exp_thief.Value = 124820
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(22) Then
            valu_exp_thief.Value = 153090
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(23) Then
            valu_exp_thief.Value = 186360
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(24) Then
            valu_exp_thief.Value = 225300
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(25) Then
            valu_exp_thief.Value = 270610
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(26) Then
            valu_exp_thief.Value = 315920
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(27) Then
            valu_exp_thief.Value = 361230
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(28) Then
            valu_exp_thief.Value = 406540
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(29) Then
            valu_exp_thief.Value = 451850
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(30) Then
            valu_exp_thief.Value = 497160
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(31) Then
            valu_exp_thief.Value = 545590
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(32) Then
            valu_exp_thief.Value = 599690
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(33) Then
            valu_exp_thief.Value = 659900
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(34) Then
            valu_exp_thief.Value = 726690
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(35) Then
            valu_exp_thief.Value = 800540
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(36) Then
            valu_exp_thief.Value = 881950
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(37) Then
            valu_exp_thief.Value = 971440
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(38) Then
            valu_exp_thief.Value = 1069540
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(39) Then
            valu_exp_thief.Value = 1176790
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(40) Then
            valu_exp_thief.Value = 1293750
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(41) Then
            valu_exp_thief.Value = 1420990
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(42) Then
            valu_exp_thief.Value = 1559090
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(43) Then
            valu_exp_thief.Value = 1708640
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(44) Then
            valu_exp_thief.Value = 1870250
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(45) Then
            valu_exp_thief.Value = 2044530
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(46) Then
            valu_exp_thief.Value = 2232090
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(47) Then
            valu_exp_thief.Value = 2448870
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(48) Then
            valu_exp_thief.Value = 2698120
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(49) Then
            valu_exp_thief.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_popstar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_popstar.SelectedIndexChanged
        If Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(0) Then
            valu_exp_popstar.Value = 0
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(1) Then
            valu_exp_popstar.Value = 10
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(2) Then
            valu_exp_popstar.Value = 50
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(3) Then
            valu_exp_popstar.Value = 150
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(4) Then
            valu_exp_popstar.Value = 340
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(5) Then
            valu_exp_popstar.Value = 650
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(6) Then
            valu_exp_popstar.Value = 1140
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(7) Then
            valu_exp_popstar.Value = 1870
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(8) Then
            valu_exp_popstar.Value = 2920
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(9) Then
            valu_exp_popstar.Value = 4390
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(10) Then
            valu_exp_popstar.Value = 6390
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(11) Then
            valu_exp_popstar.Value = 9060
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(12) Then
            valu_exp_popstar.Value = 12570
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(13) Then
            valu_exp_popstar.Value = 17120
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(14) Then
            valu_exp_popstar.Value = 22920
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(15) Then
            valu_exp_popstar.Value = 30230
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(16) Then
            valu_exp_popstar.Value = 39340
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(17) Then
            valu_exp_popstar.Value = 50580
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(18) Then
            valu_exp_popstar.Value = 64320
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(19) Then
            valu_exp_popstar.Value = 80960
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(20) Then
            valu_exp_popstar.Value = 100960
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(21) Then
            valu_exp_popstar.Value = 124820
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(22) Then
            valu_exp_popstar.Value = 153090
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(23) Then
            valu_exp_popstar.Value = 186360
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(24) Then
            valu_exp_popstar.Value = 225300
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(25) Then
            valu_exp_popstar.Value = 270610
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(26) Then
            valu_exp_popstar.Value = 315920
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(27) Then
            valu_exp_popstar.Value = 361230
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(28) Then
            valu_exp_popstar.Value = 406540
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(29) Then
            valu_exp_popstar.Value = 451850
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(30) Then
            valu_exp_popstar.Value = 497160
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(31) Then
            valu_exp_popstar.Value = 545590
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(32) Then
            valu_exp_popstar.Value = 599690
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(33) Then
            valu_exp_popstar.Value = 659900
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(34) Then
            valu_exp_popstar.Value = 726690
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(35) Then
            valu_exp_popstar.Value = 800540
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(36) Then
            valu_exp_popstar.Value = 881950
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(37) Then
            valu_exp_popstar.Value = 971440
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(38) Then
            valu_exp_popstar.Value = 1069540
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(39) Then
            valu_exp_popstar.Value = 1176790
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(40) Then
            valu_exp_popstar.Value = 1293750
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(41) Then
            valu_exp_popstar.Value = 1420990
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(42) Then
            valu_exp_popstar.Value = 1559090
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(43) Then
            valu_exp_popstar.Value = 1708640
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(44) Then
            valu_exp_popstar.Value = 1870250
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(45) Then
            valu_exp_popstar.Value = 2044530
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(46) Then
            valu_exp_popstar.Value = 2232090
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(47) Then
            valu_exp_popstar.Value = 2448870
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(48) Then
            valu_exp_popstar.Value = 2698120
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(49) Then
            valu_exp_popstar.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_vampire_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_vampire.SelectedIndexChanged
        If Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(0) Then
            valu_exp_vampire.Value = 0
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(1) Then
            valu_exp_vampire.Value = 10
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(2) Then
            valu_exp_vampire.Value = 50
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(3) Then
            valu_exp_vampire.Value = 150
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(4) Then
            valu_exp_vampire.Value = 340
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(5) Then
            valu_exp_vampire.Value = 650
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(6) Then
            valu_exp_vampire.Value = 1140
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(7) Then
            valu_exp_vampire.Value = 1870
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(8) Then
            valu_exp_vampire.Value = 2920
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(9) Then
            valu_exp_vampire.Value = 4390
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(10) Then
            valu_exp_vampire.Value = 6390
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(11) Then
            valu_exp_vampire.Value = 9060
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(12) Then
            valu_exp_vampire.Value = 12570
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(13) Then
            valu_exp_vampire.Value = 17120
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(14) Then
            valu_exp_vampire.Value = 22920
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(15) Then
            valu_exp_vampire.Value = 30230
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(16) Then
            valu_exp_vampire.Value = 39340
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(17) Then
            valu_exp_vampire.Value = 50580
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(18) Then
            valu_exp_vampire.Value = 64320
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(19) Then
            valu_exp_vampire.Value = 80960
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(20) Then
            valu_exp_vampire.Value = 100960
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(21) Then
            valu_exp_vampire.Value = 124820
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(22) Then
            valu_exp_vampire.Value = 153090
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(23) Then
            valu_exp_vampire.Value = 186360
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(24) Then
            valu_exp_vampire.Value = 225300
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(25) Then
            valu_exp_vampire.Value = 270610
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(26) Then
            valu_exp_vampire.Value = 315920
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(27) Then
            valu_exp_vampire.Value = 361230
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(28) Then
            valu_exp_vampire.Value = 406540
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(29) Then
            valu_exp_vampire.Value = 451850
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(30) Then
            valu_exp_vampire.Value = 497160
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(31) Then
            valu_exp_vampire.Value = 545590
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(32) Then
            valu_exp_vampire.Value = 599690
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(33) Then
            valu_exp_vampire.Value = 659900
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(34) Then
            valu_exp_vampire.Value = 726690
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(35) Then
            valu_exp_vampire.Value = 800540
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(36) Then
            valu_exp_vampire.Value = 881950
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(37) Then
            valu_exp_vampire.Value = 971440
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(38) Then
            valu_exp_vampire.Value = 1069540
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(39) Then
            valu_exp_vampire.Value = 1176790
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(40) Then
            valu_exp_vampire.Value = 1293750
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(41) Then
            valu_exp_vampire.Value = 1420990
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(42) Then
            valu_exp_vampire.Value = 1559090
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(43) Then
            valu_exp_vampire.Value = 1708640
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(44) Then
            valu_exp_vampire.Value = 1870250
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(45) Then
            valu_exp_vampire.Value = 2044530
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(46) Then
            valu_exp_vampire.Value = 2232090
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(47) Then
            valu_exp_vampire.Value = 2448870
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(48) Then
            valu_exp_vampire.Value = 2698120
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(49) Then
            valu_exp_vampire.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_chef_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_chef.SelectedIndexChanged
        If Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(0) Then
            valu_exp_chef.Value = 0
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(1) Then
            valu_exp_chef.Value = 10
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(2) Then
            valu_exp_chef.Value = 50
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(3) Then
            valu_exp_chef.Value = 150
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(4) Then
            valu_exp_chef.Value = 340
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(5) Then
            valu_exp_chef.Value = 650
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(6) Then
            valu_exp_chef.Value = 1140
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(7) Then
            valu_exp_chef.Value = 1870
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(8) Then
            valu_exp_chef.Value = 2920
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(9) Then
            valu_exp_chef.Value = 4390
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(10) Then
            valu_exp_chef.Value = 6390
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(11) Then
            valu_exp_chef.Value = 9060
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(12) Then
            valu_exp_chef.Value = 12570
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(13) Then
            valu_exp_chef.Value = 17120
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(14) Then
            valu_exp_chef.Value = 22920
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(15) Then
            valu_exp_chef.Value = 30230
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(16) Then
            valu_exp_chef.Value = 39340
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(17) Then
            valu_exp_chef.Value = 50580
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(18) Then
            valu_exp_chef.Value = 64320
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(19) Then
            valu_exp_chef.Value = 80960
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(20) Then
            valu_exp_chef.Value = 100960
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(21) Then
            valu_exp_chef.Value = 124820
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(22) Then
            valu_exp_chef.Value = 153090
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(23) Then
            valu_exp_chef.Value = 186360
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(24) Then
            valu_exp_chef.Value = 225300
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(25) Then
            valu_exp_chef.Value = 270610
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(26) Then
            valu_exp_chef.Value = 315920
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(27) Then
            valu_exp_chef.Value = 361230
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(28) Then
            valu_exp_chef.Value = 406540
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(29) Then
            valu_exp_chef.Value = 451850
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(30) Then
            valu_exp_chef.Value = 497160
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(31) Then
            valu_exp_chef.Value = 545590
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(32) Then
            valu_exp_chef.Value = 599690
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(33) Then
            valu_exp_chef.Value = 659900
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(34) Then
            valu_exp_chef.Value = 726690
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(35) Then
            valu_exp_chef.Value = 800540
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(36) Then
            valu_exp_chef.Value = 881950
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(37) Then
            valu_exp_chef.Value = 971440
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(38) Then
            valu_exp_chef.Value = 1069540
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(39) Then
            valu_exp_chef.Value = 1176790
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(40) Then
            valu_exp_chef.Value = 1293750
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(41) Then
            valu_exp_chef.Value = 1420990
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(42) Then
            valu_exp_chef.Value = 1559090
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(43) Then
            valu_exp_chef.Value = 1708640
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(44) Then
            valu_exp_chef.Value = 1870250
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(45) Then
            valu_exp_chef.Value = 2044530
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(46) Then
            valu_exp_chef.Value = 2232090
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(47) Then
            valu_exp_chef.Value = 2448870
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(48) Then
            valu_exp_chef.Value = 2698120
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(49) Then
            valu_exp_chef.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_tank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_tank.SelectedIndexChanged
        If Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(0) Then
            valu_exp_tank.Value = 0
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(1) Then
            valu_exp_tank.Value = 10
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(2) Then
            valu_exp_tank.Value = 50
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(3) Then
            valu_exp_tank.Value = 150
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(4) Then
            valu_exp_tank.Value = 340
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(5) Then
            valu_exp_tank.Value = 650
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(6) Then
            valu_exp_tank.Value = 1140
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(7) Then
            valu_exp_tank.Value = 1870
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(8) Then
            valu_exp_tank.Value = 2920
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(9) Then
            valu_exp_tank.Value = 4390
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(10) Then
            valu_exp_tank.Value = 6390
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(11) Then
            valu_exp_tank.Value = 9060
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(12) Then
            valu_exp_tank.Value = 12570
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(13) Then
            valu_exp_tank.Value = 17120
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(14) Then
            valu_exp_tank.Value = 22920
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(15) Then
            valu_exp_tank.Value = 30230
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(16) Then
            valu_exp_tank.Value = 39340
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(17) Then
            valu_exp_tank.Value = 50580
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(18) Then
            valu_exp_tank.Value = 64320
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(19) Then
            valu_exp_tank.Value = 80960
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(20) Then
            valu_exp_tank.Value = 100960
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(21) Then
            valu_exp_tank.Value = 124820
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(22) Then
            valu_exp_tank.Value = 153090
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(23) Then
            valu_exp_tank.Value = 186360
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(24) Then
            valu_exp_tank.Value = 225300
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(25) Then
            valu_exp_tank.Value = 270610
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(26) Then
            valu_exp_tank.Value = 315920
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(27) Then
            valu_exp_tank.Value = 361230
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(28) Then
            valu_exp_tank.Value = 406540
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(29) Then
            valu_exp_tank.Value = 451850
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(30) Then
            valu_exp_tank.Value = 497160
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(31) Then
            valu_exp_tank.Value = 545590
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(32) Then
            valu_exp_tank.Value = 599690
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(33) Then
            valu_exp_tank.Value = 659900
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(34) Then
            valu_exp_tank.Value = 726690
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(35) Then
            valu_exp_tank.Value = 800540
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(36) Then
            valu_exp_tank.Value = 881950
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(37) Then
            valu_exp_tank.Value = 971440
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(38) Then
            valu_exp_tank.Value = 1069540
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(39) Then
            valu_exp_tank.Value = 1176790
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(40) Then
            valu_exp_tank.Value = 1293750
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(41) Then
            valu_exp_tank.Value = 1420990
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(42) Then
            valu_exp_tank.Value = 1559090
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(43) Then
            valu_exp_tank.Value = 1708640
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(44) Then
            valu_exp_tank.Value = 1870250
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(45) Then
            valu_exp_tank.Value = 2044530
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(46) Then
            valu_exp_tank.Value = 2232090
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(47) Then
            valu_exp_tank.Value = 2448870
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(48) Then
            valu_exp_tank.Value = 2698120
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(49) Then
            valu_exp_tank.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_imp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_imp.SelectedIndexChanged
        If Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(0) Then
            valu_exp_imp.Value = 0
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(1) Then
            valu_exp_imp.Value = 10
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(2) Then
            valu_exp_imp.Value = 50
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(3) Then
            valu_exp_imp.Value = 150
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(4) Then
            valu_exp_imp.Value = 340
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(5) Then
            valu_exp_imp.Value = 650
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(6) Then
            valu_exp_imp.Value = 1140
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(7) Then
            valu_exp_imp.Value = 1870
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(8) Then
            valu_exp_imp.Value = 2920
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(9) Then
            valu_exp_imp.Value = 4390
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(10) Then
            valu_exp_imp.Value = 6390
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(11) Then
            valu_exp_imp.Value = 9060
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(12) Then
            valu_exp_imp.Value = 12570
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(13) Then
            valu_exp_imp.Value = 17120
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(14) Then
            valu_exp_imp.Value = 22920
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(15) Then
            valu_exp_imp.Value = 30230
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(16) Then
            valu_exp_imp.Value = 39340
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(17) Then
            valu_exp_imp.Value = 50580
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(18) Then
            valu_exp_imp.Value = 64320
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(19) Then
            valu_exp_imp.Value = 80960
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(20) Then
            valu_exp_imp.Value = 100960
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(21) Then
            valu_exp_imp.Value = 124820
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(22) Then
            valu_exp_imp.Value = 153090
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(23) Then
            valu_exp_imp.Value = 186360
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(24) Then
            valu_exp_imp.Value = 225300
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(25) Then
            valu_exp_imp.Value = 270610
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(26) Then
            valu_exp_imp.Value = 315920
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(27) Then
            valu_exp_imp.Value = 361230
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(28) Then
            valu_exp_imp.Value = 406540
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(29) Then
            valu_exp_imp.Value = 451850
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(30) Then
            valu_exp_imp.Value = 497160
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(31) Then
            valu_exp_imp.Value = 545590
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(32) Then
            valu_exp_imp.Value = 599690
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(33) Then
            valu_exp_imp.Value = 659900
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(34) Then
            valu_exp_imp.Value = 726690
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(35) Then
            valu_exp_imp.Value = 800540
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(36) Then
            valu_exp_imp.Value = 881950
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(37) Then
            valu_exp_imp.Value = 971440
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(38) Then
            valu_exp_imp.Value = 1069540
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(39) Then
            valu_exp_imp.Value = 1176790
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(40) Then
            valu_exp_imp.Value = 1293750
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(41) Then
            valu_exp_imp.Value = 1420990
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(42) Then
            valu_exp_imp.Value = 1559090
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(43) Then
            valu_exp_imp.Value = 1708640
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(44) Then
            valu_exp_imp.Value = 1870250
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(45) Then
            valu_exp_imp.Value = 2044530
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(46) Then
            valu_exp_imp.Value = 2232090
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(47) Then
            valu_exp_imp.Value = 2448870
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(48) Then
            valu_exp_imp.Value = 2698120
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(49) Then
            valu_exp_imp.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_princess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_princess.SelectedIndexChanged
        If Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(0) Then
            valu_exp_princess.Value = 0
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(1) Then
            valu_exp_princess.Value = 10
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(2) Then
            valu_exp_princess.Value = 50
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(3) Then
            valu_exp_princess.Value = 150
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(4) Then
            valu_exp_princess.Value = 340
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(5) Then
            valu_exp_princess.Value = 650
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(6) Then
            valu_exp_princess.Value = 1140
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(7) Then
            valu_exp_princess.Value = 1870
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(8) Then
            valu_exp_princess.Value = 2920
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(9) Then
            valu_exp_princess.Value = 4390
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(10) Then
            valu_exp_princess.Value = 6390
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(11) Then
            valu_exp_princess.Value = 9060
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(12) Then
            valu_exp_princess.Value = 12570
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(13) Then
            valu_exp_princess.Value = 17120
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(14) Then
            valu_exp_princess.Value = 22920
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(15) Then
            valu_exp_princess.Value = 30230
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(16) Then
            valu_exp_princess.Value = 39340
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(17) Then
            valu_exp_princess.Value = 50580
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(18) Then
            valu_exp_princess.Value = 64320
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(19) Then
            valu_exp_princess.Value = 80960
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(20) Then
            valu_exp_princess.Value = 100960
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(21) Then
            valu_exp_princess.Value = 124820
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(22) Then
            valu_exp_princess.Value = 153090
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(23) Then
            valu_exp_princess.Value = 186360
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(24) Then
            valu_exp_princess.Value = 225300
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(25) Then
            valu_exp_princess.Value = 270610
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(26) Then
            valu_exp_princess.Value = 315920
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(27) Then
            valu_exp_princess.Value = 361230
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(28) Then
            valu_exp_princess.Value = 406540
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(29) Then
            valu_exp_princess.Value = 451850
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(30) Then
            valu_exp_princess.Value = 497160
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(31) Then
            valu_exp_princess.Value = 545590
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(32) Then
            valu_exp_princess.Value = 599690
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(33) Then
            valu_exp_princess.Value = 659900
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(34) Then
            valu_exp_princess.Value = 726690
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(35) Then
            valu_exp_princess.Value = 800540
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(36) Then
            valu_exp_princess.Value = 881950
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(37) Then
            valu_exp_princess.Value = 971440
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(38) Then
            valu_exp_princess.Value = 1069540
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(39) Then
            valu_exp_princess.Value = 1176790
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(40) Then
            valu_exp_princess.Value = 1293750
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(41) Then
            valu_exp_princess.Value = 1420990
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(42) Then
            valu_exp_princess.Value = 1559090
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(43) Then
            valu_exp_princess.Value = 1708640
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(44) Then
            valu_exp_princess.Value = 1870250
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(45) Then
            valu_exp_princess.Value = 2044530
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(46) Then
            valu_exp_princess.Value = 2232090
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(47) Then
            valu_exp_princess.Value = 2448870
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(48) Then
            valu_exp_princess.Value = 2698120
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(49) Then
            valu_exp_princess.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_flower_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_flower.SelectedIndexChanged
        If Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(0) Then
            valu_exp_flower.Value = 0
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(1) Then
            valu_exp_flower.Value = 10
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(2) Then
            valu_exp_flower.Value = 50
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(3) Then
            valu_exp_flower.Value = 150
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(4) Then
            valu_exp_flower.Value = 340
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(5) Then
            valu_exp_flower.Value = 650
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(6) Then
            valu_exp_flower.Value = 1140
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(7) Then
            valu_exp_flower.Value = 1870
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(8) Then
            valu_exp_flower.Value = 2920
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(9) Then
            valu_exp_flower.Value = 4390
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(10) Then
            valu_exp_flower.Value = 6390
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(11) Then
            valu_exp_flower.Value = 9060
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(12) Then
            valu_exp_flower.Value = 12570
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(13) Then
            valu_exp_flower.Value = 17120
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(14) Then
            valu_exp_flower.Value = 22920
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(15) Then
            valu_exp_flower.Value = 30230
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(16) Then
            valu_exp_flower.Value = 39340
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(17) Then
            valu_exp_flower.Value = 50580
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(18) Then
            valu_exp_flower.Value = 64320
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(19) Then
            valu_exp_flower.Value = 80960
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(20) Then
            valu_exp_flower.Value = 100960
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(21) Then
            valu_exp_flower.Value = 124820
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(22) Then
            valu_exp_flower.Value = 153090
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(23) Then
            valu_exp_flower.Value = 186360
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(24) Then
            valu_exp_flower.Value = 225300
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(25) Then
            valu_exp_flower.Value = 270610
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(26) Then
            valu_exp_flower.Value = 315920
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(27) Then
            valu_exp_flower.Value = 361230
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(28) Then
            valu_exp_flower.Value = 406540
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(29) Then
            valu_exp_flower.Value = 451850
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(30) Then
            valu_exp_flower.Value = 497160
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(31) Then
            valu_exp_flower.Value = 545590
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(32) Then
            valu_exp_flower.Value = 599690
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(33) Then
            valu_exp_flower.Value = 659900
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(34) Then
            valu_exp_flower.Value = 726690
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(35) Then
            valu_exp_flower.Value = 800540
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(36) Then
            valu_exp_flower.Value = 881950
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(37) Then
            valu_exp_flower.Value = 971440
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(38) Then
            valu_exp_flower.Value = 1069540
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(39) Then
            valu_exp_flower.Value = 1176790
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(40) Then
            valu_exp_flower.Value = 1293750
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(41) Then
            valu_exp_flower.Value = 1420990
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(42) Then
            valu_exp_flower.Value = 1559090
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(43) Then
            valu_exp_flower.Value = 1708640
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(44) Then
            valu_exp_flower.Value = 1870250
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(45) Then
            valu_exp_flower.Value = 2044530
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(46) Then
            valu_exp_flower.Value = 2232090
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(47) Then
            valu_exp_flower.Value = 2448870
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(48) Then
            valu_exp_flower.Value = 2698120
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(49) Then
            valu_exp_flower.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_scientist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_scientist.SelectedIndexChanged
        If Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(0) Then
            valu_exp_scientist.Value = 0
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(1) Then
            valu_exp_scientist.Value = 10
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(2) Then
            valu_exp_scientist.Value = 50
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(3) Then
            valu_exp_scientist.Value = 150
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(4) Then
            valu_exp_scientist.Value = 340
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(5) Then
            valu_exp_scientist.Value = 650
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(6) Then
            valu_exp_scientist.Value = 1140
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(7) Then
            valu_exp_scientist.Value = 1870
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(8) Then
            valu_exp_scientist.Value = 2920
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(9) Then
            valu_exp_scientist.Value = 4390
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(10) Then
            valu_exp_scientist.Value = 6390
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(11) Then
            valu_exp_scientist.Value = 9060
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(12) Then
            valu_exp_scientist.Value = 12570
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(13) Then
            valu_exp_scientist.Value = 17120
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(14) Then
            valu_exp_scientist.Value = 22920
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(15) Then
            valu_exp_scientist.Value = 30230
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(16) Then
            valu_exp_scientist.Value = 39340
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(17) Then
            valu_exp_scientist.Value = 50580
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(18) Then
            valu_exp_scientist.Value = 64320
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(19) Then
            valu_exp_scientist.Value = 80960
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(20) Then
            valu_exp_scientist.Value = 100960
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(21) Then
            valu_exp_scientist.Value = 124820
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(22) Then
            valu_exp_scientist.Value = 153090
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(23) Then
            valu_exp_scientist.Value = 186360
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(24) Then
            valu_exp_scientist.Value = 225300
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(25) Then
            valu_exp_scientist.Value = 270610
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(26) Then
            valu_exp_scientist.Value = 315920
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(27) Then
            valu_exp_scientist.Value = 361230
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(28) Then
            valu_exp_scientist.Value = 406540
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(29) Then
            valu_exp_scientist.Value = 451850
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(30) Then
            valu_exp_scientist.Value = 497160
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(31) Then
            valu_exp_scientist.Value = 545590
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(32) Then
            valu_exp_scientist.Value = 599690
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(33) Then
            valu_exp_scientist.Value = 659900
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(34) Then
            valu_exp_scientist.Value = 726690
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(35) Then
            valu_exp_scientist.Value = 800540
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(36) Then
            valu_exp_scientist.Value = 881950
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(37) Then
            valu_exp_scientist.Value = 971440
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(38) Then
            valu_exp_scientist.Value = 1069540
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(39) Then
            valu_exp_scientist.Value = 1176790
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(40) Then
            valu_exp_scientist.Value = 1293750
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(41) Then
            valu_exp_scientist.Value = 1420990
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(42) Then
            valu_exp_scientist.Value = 1559090
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(43) Then
            valu_exp_scientist.Value = 1708640
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(44) Then
            valu_exp_scientist.Value = 1870250
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(45) Then
            valu_exp_scientist.Value = 2044530
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(46) Then
            valu_exp_scientist.Value = 2232090
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(47) Then
            valu_exp_scientist.Value = 2448870
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(48) Then
            valu_exp_scientist.Value = 2698120
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(49) Then
            valu_exp_scientist.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_cat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_cat.SelectedIndexChanged
        If Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(0) Then
            valu_exp_cat.Value = 0
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(1) Then
            valu_exp_cat.Value = 10
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(2) Then
            valu_exp_cat.Value = 50
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(3) Then
            valu_exp_cat.Value = 150
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(4) Then
            valu_exp_cat.Value = 340
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(5) Then
            valu_exp_cat.Value = 650
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(6) Then
            valu_exp_cat.Value = 1140
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(7) Then
            valu_exp_cat.Value = 1870
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(8) Then
            valu_exp_cat.Value = 2920
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(9) Then
            valu_exp_cat.Value = 4390
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(10) Then
            valu_exp_cat.Value = 6390
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(11) Then
            valu_exp_cat.Value = 9060
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(12) Then
            valu_exp_cat.Value = 12570
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(13) Then
            valu_exp_cat.Value = 17120
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(14) Then
            valu_exp_cat.Value = 22920
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(15) Then
            valu_exp_cat.Value = 30230
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(16) Then
            valu_exp_cat.Value = 39340
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(17) Then
            valu_exp_cat.Value = 50580
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(18) Then
            valu_exp_cat.Value = 64320
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(19) Then
            valu_exp_cat.Value = 80960
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(20) Then
            valu_exp_cat.Value = 100960
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(21) Then
            valu_exp_cat.Value = 124820
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(22) Then
            valu_exp_cat.Value = 153090
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(23) Then
            valu_exp_cat.Value = 186360
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(24) Then
            valu_exp_cat.Value = 225300
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(25) Then
            valu_exp_cat.Value = 270610
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(26) Then
            valu_exp_cat.Value = 315920
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(27) Then
            valu_exp_cat.Value = 361230
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(28) Then
            valu_exp_cat.Value = 406540
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(29) Then
            valu_exp_cat.Value = 451850
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(30) Then
            valu_exp_cat.Value = 497160
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(31) Then
            valu_exp_cat.Value = 545590
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(32) Then
            valu_exp_cat.Value = 599690
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(33) Then
            valu_exp_cat.Value = 659900
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(34) Then
            valu_exp_cat.Value = 726690
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(35) Then
            valu_exp_cat.Value = 800540
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(36) Then
            valu_exp_cat.Value = 881950
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(37) Then
            valu_exp_cat.Value = 971440
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(38) Then
            valu_exp_cat.Value = 1069540
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(39) Then
            valu_exp_cat.Value = 1176790
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(40) Then
            valu_exp_cat.Value = 1293750
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(41) Then
            valu_exp_cat.Value = 1420990
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(42) Then
            valu_exp_cat.Value = 1559090
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(43) Then
            valu_exp_cat.Value = 1708640
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(44) Then
            valu_exp_cat.Value = 1870250
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(45) Then
            valu_exp_cat.Value = 2044530
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(46) Then
            valu_exp_cat.Value = 2232090
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(47) Then
            valu_exp_cat.Value = 2448870
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(48) Then
            valu_exp_cat.Value = 2698120
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(49) Then
            valu_exp_cat.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_elf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_elf.SelectedIndexChanged
        If Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(0) Then
            valu_exp_elf.Value = 0
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(1) Then
            valu_exp_elf.Value = 10
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(2) Then
            valu_exp_elf.Value = 50
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(3) Then
            valu_exp_elf.Value = 150
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(4) Then
            valu_exp_elf.Value = 340
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(5) Then
            valu_exp_elf.Value = 650
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(6) Then
            valu_exp_elf.Value = 1140
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(7) Then
            valu_exp_elf.Value = 1870
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(8) Then
            valu_exp_elf.Value = 2920
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(9) Then
            valu_exp_elf.Value = 4390
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(10) Then
            valu_exp_elf.Value = 6390
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(11) Then
            valu_exp_elf.Value = 9060
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(12) Then
            valu_exp_elf.Value = 12570
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(13) Then
            valu_exp_elf.Value = 17120
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(14) Then
            valu_exp_elf.Value = 22920
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(15) Then
            valu_exp_elf.Value = 30230
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(16) Then
            valu_exp_elf.Value = 39340
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(17) Then
            valu_exp_elf.Value = 50580
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(18) Then
            valu_exp_elf.Value = 64320
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(19) Then
            valu_exp_elf.Value = 80960
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(20) Then
            valu_exp_elf.Value = 100960
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(21) Then
            valu_exp_elf.Value = 124820
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(22) Then
            valu_exp_elf.Value = 153090
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(23) Then
            valu_exp_elf.Value = 186360
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(24) Then
            valu_exp_elf.Value = 225300
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(25) Then
            valu_exp_elf.Value = 270610
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(26) Then
            valu_exp_elf.Value = 315920
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(27) Then
            valu_exp_elf.Value = 361230
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(28) Then
            valu_exp_elf.Value = 406540
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(29) Then
            valu_exp_elf.Value = 451850
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(30) Then
            valu_exp_elf.Value = 497160
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(31) Then
            valu_exp_elf.Value = 545590
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(32) Then
            valu_exp_elf.Value = 599690
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(33) Then
            valu_exp_elf.Value = 659900
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(34) Then
            valu_exp_elf.Value = 726690
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(35) Then
            valu_exp_elf.Value = 800540
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(36) Then
            valu_exp_elf.Value = 881950
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(37) Then
            valu_exp_elf.Value = 971440
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(38) Then
            valu_exp_elf.Value = 1069540
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(39) Then
            valu_exp_elf.Value = 1176790
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(40) Then
            valu_exp_elf.Value = 1293750
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(41) Then
            valu_exp_elf.Value = 1420990
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(42) Then
            valu_exp_elf.Value = 1559090
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(43) Then
            valu_exp_elf.Value = 1708640
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(44) Then
            valu_exp_elf.Value = 1870250
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(45) Then
            valu_exp_elf.Value = 2044530
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(46) Then
            valu_exp_elf.Value = 2232090
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(47) Then
            valu_exp_elf.Value = 2448870
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(48) Then
            valu_exp_elf.Value = 2698120
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(49) Then
            valu_exp_elf.Value = 2983350
        End If
    End Sub

    Private Sub valu_exp_warrior_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_warrior.ValueChanged
        If valu_exp_warrior.Value > 0 And valu_exp_warrior.Value < 10 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(0)
        ElseIf valu_exp_warrior.Value >= 10 And valu_exp_warrior.Value < 50 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(1)
        ElseIf valu_exp_warrior.Value >= 50 And valu_exp_warrior.Value < 150 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(2)
        ElseIf valu_exp_warrior.Value >= 150 And valu_exp_warrior.Value < 340 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(3)
        ElseIf valu_exp_warrior.Value >= 340 And valu_exp_warrior.Value < 650 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(4)
        ElseIf valu_exp_warrior.Value >= 650 And valu_exp_warrior.Value < 1140 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(5)
        ElseIf valu_exp_warrior.Value >= 1140 And valu_exp_warrior.Value < 1870 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(6)
        ElseIf valu_exp_warrior.Value >= 1870 And valu_exp_warrior.Value < 2920 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(7)
        ElseIf valu_exp_warrior.Value >= 2920 And valu_exp_warrior.Value < 4390 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(8)
        ElseIf valu_exp_warrior.Value >= 4390 And valu_exp_warrior.Value < 6390 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(9)
        ElseIf valu_exp_warrior.Value >= 6390 And valu_exp_warrior.Value < 9060 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(10)
        ElseIf valu_exp_warrior.Value >= 9060 And valu_exp_warrior.Value < 12570 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(11)
        ElseIf valu_exp_warrior.Value >= 12570 And valu_exp_warrior.Value < 17120 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(12)
        ElseIf valu_exp_warrior.Value >= 17120 And valu_exp_warrior.Value < 22920 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(13)
        ElseIf valu_exp_warrior.Value >= 22920 And valu_exp_warrior.Value < 30230 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(14)
        ElseIf valu_exp_warrior.Value >= 30230 And valu_exp_warrior.Value < 39340 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(15)
        ElseIf valu_exp_warrior.Value >= 39340 And valu_exp_warrior.Value < 50580 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(16)
        ElseIf valu_exp_warrior.Value >= 50580 And valu_exp_warrior.Value < 64320 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(17)
        ElseIf valu_exp_warrior.Value >= 64320 And valu_exp_warrior.Value < 80960 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(18)
        ElseIf valu_exp_warrior.Value >= 80960 And valu_exp_warrior.Value < 100960 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(19)
        ElseIf valu_exp_warrior.Value >= 100960 And valu_exp_warrior.Value < 124820 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(20)
        ElseIf valu_exp_warrior.Value >= 124820 And valu_exp_warrior.Value < 153090 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(21)
        ElseIf valu_exp_warrior.Value >= 153090 And valu_exp_warrior.Value < 186360 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(22)
        ElseIf valu_exp_warrior.Value >= 186360 And valu_exp_warrior.Value < 225300 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(23)
        ElseIf valu_exp_warrior.Value >= 225300 And valu_exp_warrior.Value < 270610 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(24)
        ElseIf valu_exp_warrior.Value >= 270610 And valu_exp_warrior.Value < 315920 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(25)
        ElseIf valu_exp_warrior.Value >= 315920 And valu_exp_warrior.Value < 361230 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(26)
        ElseIf valu_exp_warrior.Value >= 361230 And valu_exp_warrior.Value < 406540 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(27)
        ElseIf valu_exp_warrior.Value >= 406540 And valu_exp_warrior.Value < 451850 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(28)
        ElseIf valu_exp_warrior.Value >= 451850 And valu_exp_warrior.Value < 497160 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(29)
        ElseIf valu_exp_warrior.Value >= 497160 And valu_exp_warrior.Value < 545590 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(30)
        ElseIf valu_exp_warrior.Value >= 545590 And valu_exp_warrior.Value < 599690 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(31)
        ElseIf valu_exp_warrior.Value >= 599690 And valu_exp_warrior.Value < 659900 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(32)
        ElseIf valu_exp_warrior.Value >= 659900 And valu_exp_warrior.Value < 726690 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(33)
        ElseIf valu_exp_warrior.Value >= 726690 And valu_exp_warrior.Value < 800540 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(34)
        ElseIf valu_exp_warrior.Value >= 800540 And valu_exp_warrior.Value < 881950 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(35)
        ElseIf valu_exp_warrior.Value >= 881950 And valu_exp_warrior.Value < 971440 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(36)
        ElseIf valu_exp_warrior.Value >= 971440 And valu_exp_warrior.Value < 1069540 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(37)
        ElseIf valu_exp_warrior.Value >= 1069540 And valu_exp_warrior.Value < 1176790 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(38)
        ElseIf valu_exp_warrior.Value >= 1176790 And valu_exp_warrior.Value < 1293750 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(39)
        ElseIf valu_exp_warrior.Value >= 1293750 And valu_exp_warrior.Value < 1420990 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(40)
        ElseIf valu_exp_warrior.Value >= 1420990 And valu_exp_warrior.Value < 1559090 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(41)
        ElseIf valu_exp_warrior.Value >= 1559090 And valu_exp_warrior.Value < 1708640 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(42)
        ElseIf valu_exp_warrior.Value >= 1708640 And valu_exp_warrior.Value < 1870250 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(43)
        ElseIf valu_exp_warrior.Value >= 1870250 And valu_exp_warrior.Value < 2044530 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(44)
        ElseIf valu_exp_warrior.Value >= 2044530 And valu_exp_warrior.Value < 2232090 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(45)
        ElseIf valu_exp_warrior.Value >= 2232090 And valu_exp_warrior.Value < 2448870 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(46)
        ElseIf valu_exp_warrior.Value >= 2448870 And valu_exp_warrior.Value < 2698120 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(47)
        ElseIf valu_exp_warrior.Value >= 2698120 And valu_exp_warrior.Value < 2983350 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(48)
        ElseIf valu_exp_warrior.Value >= 2983350 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_mage_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_mage.ValueChanged
        If valu_exp_mage.Value > 0 And valu_exp_mage.Value < 10 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(0)
        ElseIf valu_exp_mage.Value >= 10 And valu_exp_mage.Value < 50 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(1)
        ElseIf valu_exp_mage.Value >= 50 And valu_exp_mage.Value < 150 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(2)
        ElseIf valu_exp_mage.Value >= 150 And valu_exp_mage.Value < 340 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(3)
        ElseIf valu_exp_mage.Value >= 340 And valu_exp_mage.Value < 650 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(4)
        ElseIf valu_exp_mage.Value >= 650 And valu_exp_mage.Value < 1140 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(5)
        ElseIf valu_exp_mage.Value >= 1140 And valu_exp_mage.Value < 1870 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(6)
        ElseIf valu_exp_mage.Value >= 1870 And valu_exp_mage.Value < 2920 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(7)
        ElseIf valu_exp_mage.Value >= 2920 And valu_exp_mage.Value < 4390 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(8)
        ElseIf valu_exp_mage.Value >= 4390 And valu_exp_mage.Value < 6390 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(9)
        ElseIf valu_exp_mage.Value >= 6390 And valu_exp_mage.Value < 9060 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(10)
        ElseIf valu_exp_mage.Value >= 9060 And valu_exp_mage.Value < 12570 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(11)
        ElseIf valu_exp_mage.Value >= 12570 And valu_exp_mage.Value < 17120 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(12)
        ElseIf valu_exp_mage.Value >= 17120 And valu_exp_mage.Value < 22920 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(13)
        ElseIf valu_exp_mage.Value >= 22920 And valu_exp_mage.Value < 30230 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(14)
        ElseIf valu_exp_mage.Value >= 30230 And valu_exp_mage.Value < 39340 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(15)
        ElseIf valu_exp_mage.Value >= 39340 And valu_exp_mage.Value < 50580 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(16)
        ElseIf valu_exp_mage.Value >= 50580 And valu_exp_mage.Value < 64320 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(17)
        ElseIf valu_exp_mage.Value >= 64320 And valu_exp_mage.Value < 80960 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(18)
        ElseIf valu_exp_mage.Value >= 80960 And valu_exp_mage.Value < 100960 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(19)
        ElseIf valu_exp_mage.Value >= 100960 And valu_exp_mage.Value < 124820 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(20)
        ElseIf valu_exp_mage.Value >= 124820 And valu_exp_mage.Value < 153090 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(21)
        ElseIf valu_exp_mage.Value >= 153090 And valu_exp_mage.Value < 186360 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(22)
        ElseIf valu_exp_mage.Value >= 186360 And valu_exp_mage.Value < 225300 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(23)
        ElseIf valu_exp_mage.Value >= 225300 And valu_exp_mage.Value < 270610 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(24)
        ElseIf valu_exp_mage.Value >= 270610 And valu_exp_mage.Value < 315920 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(25)
        ElseIf valu_exp_mage.Value >= 315920 And valu_exp_mage.Value < 361230 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(26)
        ElseIf valu_exp_mage.Value >= 361230 And valu_exp_mage.Value < 406540 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(27)
        ElseIf valu_exp_mage.Value >= 406540 And valu_exp_mage.Value < 451850 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(28)
        ElseIf valu_exp_mage.Value >= 451850 And valu_exp_mage.Value < 497160 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(29)
        ElseIf valu_exp_mage.Value >= 497160 And valu_exp_mage.Value < 545590 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(30)
        ElseIf valu_exp_mage.Value >= 545590 And valu_exp_mage.Value < 599690 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(31)
        ElseIf valu_exp_mage.Value >= 599690 And valu_exp_mage.Value < 659900 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(32)
        ElseIf valu_exp_mage.Value >= 659900 And valu_exp_mage.Value < 726690 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(33)
        ElseIf valu_exp_mage.Value >= 726690 And valu_exp_mage.Value < 800540 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(34)
        ElseIf valu_exp_mage.Value >= 800540 And valu_exp_mage.Value < 881950 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(35)
        ElseIf valu_exp_mage.Value >= 881950 And valu_exp_mage.Value < 971440 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(36)
        ElseIf valu_exp_mage.Value >= 971440 And valu_exp_mage.Value < 1069540 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(37)
        ElseIf valu_exp_mage.Value >= 1069540 And valu_exp_mage.Value < 1176790 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(38)
        ElseIf valu_exp_mage.Value >= 1176790 And valu_exp_mage.Value < 1293750 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(39)
        ElseIf valu_exp_mage.Value >= 1293750 And valu_exp_mage.Value < 1420990 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(40)
        ElseIf valu_exp_mage.Value >= 1420990 And valu_exp_mage.Value < 1559090 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(41)
        ElseIf valu_exp_mage.Value >= 1559090 And valu_exp_mage.Value < 1708640 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(42)
        ElseIf valu_exp_mage.Value >= 1708640 And valu_exp_mage.Value < 1870250 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(43)
        ElseIf valu_exp_mage.Value >= 1870250 And valu_exp_mage.Value < 2044530 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(44)
        ElseIf valu_exp_mage.Value >= 2044530 And valu_exp_mage.Value < 2232090 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(45)
        ElseIf valu_exp_mage.Value >= 2232090 And valu_exp_mage.Value < 2448870 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(46)
        ElseIf valu_exp_mage.Value >= 2448870 And valu_exp_mage.Value < 2698120 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(47)
        ElseIf valu_exp_mage.Value >= 2698120 And valu_exp_mage.Value < 2983350 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(48)
        ElseIf valu_exp_mage.Value >= 2983350 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_cleric_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_cleric.ValueChanged
        If valu_exp_cleric.Value > 0 And valu_exp_cleric.Value < 10 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(0)
        ElseIf valu_exp_cleric.Value >= 10 And valu_exp_cleric.Value < 50 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(1)
        ElseIf valu_exp_cleric.Value >= 50 And valu_exp_cleric.Value < 150 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(2)
        ElseIf valu_exp_cleric.Value >= 150 And valu_exp_cleric.Value < 340 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(3)
        ElseIf valu_exp_cleric.Value >= 340 And valu_exp_cleric.Value < 650 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(4)
        ElseIf valu_exp_cleric.Value >= 650 And valu_exp_cleric.Value < 1140 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(5)
        ElseIf valu_exp_cleric.Value >= 1140 And valu_exp_cleric.Value < 1870 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(6)
        ElseIf valu_exp_cleric.Value >= 1870 And valu_exp_cleric.Value < 2920 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(7)
        ElseIf valu_exp_cleric.Value >= 2920 And valu_exp_cleric.Value < 4390 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(8)
        ElseIf valu_exp_cleric.Value >= 4390 And valu_exp_cleric.Value < 6390 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(9)
        ElseIf valu_exp_cleric.Value >= 6390 And valu_exp_cleric.Value < 9060 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(10)
        ElseIf valu_exp_cleric.Value >= 9060 And valu_exp_cleric.Value < 12570 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(11)
        ElseIf valu_exp_cleric.Value >= 12570 And valu_exp_cleric.Value < 17120 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(12)
        ElseIf valu_exp_cleric.Value >= 17120 And valu_exp_cleric.Value < 22920 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(13)
        ElseIf valu_exp_cleric.Value >= 22920 And valu_exp_cleric.Value < 30230 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(14)
        ElseIf valu_exp_cleric.Value >= 30230 And valu_exp_cleric.Value < 39340 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(15)
        ElseIf valu_exp_cleric.Value >= 39340 And valu_exp_cleric.Value < 50580 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(16)
        ElseIf valu_exp_cleric.Value >= 50580 And valu_exp_cleric.Value < 64320 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(17)
        ElseIf valu_exp_cleric.Value >= 64320 And valu_exp_cleric.Value < 80960 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(18)
        ElseIf valu_exp_cleric.Value >= 80960 And valu_exp_cleric.Value < 100960 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(19)
        ElseIf valu_exp_cleric.Value >= 100960 And valu_exp_cleric.Value < 124820 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(20)
        ElseIf valu_exp_cleric.Value >= 124820 And valu_exp_cleric.Value < 153090 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(21)
        ElseIf valu_exp_cleric.Value >= 153090 And valu_exp_cleric.Value < 186360 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(22)
        ElseIf valu_exp_cleric.Value >= 186360 And valu_exp_cleric.Value < 225300 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(23)
        ElseIf valu_exp_cleric.Value >= 225300 And valu_exp_cleric.Value < 270610 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(24)
        ElseIf valu_exp_cleric.Value >= 270610 And valu_exp_cleric.Value < 315920 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(25)
        ElseIf valu_exp_cleric.Value >= 315920 And valu_exp_cleric.Value < 361230 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(26)
        ElseIf valu_exp_cleric.Value >= 361230 And valu_exp_cleric.Value < 406540 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(27)
        ElseIf valu_exp_cleric.Value >= 406540 And valu_exp_cleric.Value < 451850 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(28)
        ElseIf valu_exp_cleric.Value >= 451850 And valu_exp_cleric.Value < 497160 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(29)
        ElseIf valu_exp_cleric.Value >= 497160 And valu_exp_cleric.Value < 545590 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(30)
        ElseIf valu_exp_cleric.Value >= 545590 And valu_exp_cleric.Value < 599690 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(31)
        ElseIf valu_exp_cleric.Value >= 599690 And valu_exp_cleric.Value < 659900 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(32)
        ElseIf valu_exp_cleric.Value >= 659900 And valu_exp_cleric.Value < 726690 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(33)
        ElseIf valu_exp_cleric.Value >= 726690 And valu_exp_cleric.Value < 800540 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(34)
        ElseIf valu_exp_cleric.Value >= 800540 And valu_exp_cleric.Value < 881950 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(35)
        ElseIf valu_exp_cleric.Value >= 881950 And valu_exp_cleric.Value < 971440 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(36)
        ElseIf valu_exp_cleric.Value >= 971440 And valu_exp_cleric.Value < 1069540 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(37)
        ElseIf valu_exp_cleric.Value >= 1069540 And valu_exp_cleric.Value < 1176790 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(38)
        ElseIf valu_exp_cleric.Value >= 1176790 And valu_exp_cleric.Value < 1293750 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(39)
        ElseIf valu_exp_cleric.Value >= 1293750 And valu_exp_cleric.Value < 1420990 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(40)
        ElseIf valu_exp_cleric.Value >= 1420990 And valu_exp_cleric.Value < 1559090 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(41)
        ElseIf valu_exp_cleric.Value >= 1559090 And valu_exp_cleric.Value < 1708640 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(42)
        ElseIf valu_exp_cleric.Value >= 1708640 And valu_exp_cleric.Value < 1870250 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(43)
        ElseIf valu_exp_cleric.Value >= 1870250 And valu_exp_cleric.Value < 2044530 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(44)
        ElseIf valu_exp_cleric.Value >= 2044530 And valu_exp_cleric.Value < 2232090 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(45)
        ElseIf valu_exp_cleric.Value >= 2232090 And valu_exp_cleric.Value < 2448870 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(46)
        ElseIf valu_exp_cleric.Value >= 2448870 And valu_exp_cleric.Value < 2698120 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(47)
        ElseIf valu_exp_cleric.Value >= 2698120 And valu_exp_cleric.Value < 2983350 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(48)
        ElseIf valu_exp_cleric.Value >= 2983350 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_thief_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_thief.ValueChanged
        If valu_exp_thief.Value > 0 And valu_exp_thief.Value < 10 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(0)
        ElseIf valu_exp_thief.Value >= 10 And valu_exp_thief.Value < 50 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(1)
        ElseIf valu_exp_thief.Value >= 50 And valu_exp_thief.Value < 150 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(2)
        ElseIf valu_exp_thief.Value >= 150 And valu_exp_thief.Value < 340 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(3)
        ElseIf valu_exp_thief.Value >= 340 And valu_exp_thief.Value < 650 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(4)
        ElseIf valu_exp_thief.Value >= 650 And valu_exp_thief.Value < 1140 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(5)
        ElseIf valu_exp_thief.Value >= 1140 And valu_exp_thief.Value < 1870 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(6)
        ElseIf valu_exp_thief.Value >= 1870 And valu_exp_thief.Value < 2920 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(7)
        ElseIf valu_exp_thief.Value >= 2920 And valu_exp_thief.Value < 4390 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(8)
        ElseIf valu_exp_thief.Value >= 4390 And valu_exp_thief.Value < 6390 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(9)
        ElseIf valu_exp_thief.Value >= 6390 And valu_exp_thief.Value < 9060 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(10)
        ElseIf valu_exp_thief.Value >= 9060 And valu_exp_thief.Value < 12570 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(11)
        ElseIf valu_exp_thief.Value >= 12570 And valu_exp_thief.Value < 17120 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(12)
        ElseIf valu_exp_thief.Value >= 17120 And valu_exp_thief.Value < 22920 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(13)
        ElseIf valu_exp_thief.Value >= 22920 And valu_exp_thief.Value < 30230 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(14)
        ElseIf valu_exp_thief.Value >= 30230 And valu_exp_thief.Value < 39340 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(15)
        ElseIf valu_exp_thief.Value >= 39340 And valu_exp_thief.Value < 50580 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(16)
        ElseIf valu_exp_thief.Value >= 50580 And valu_exp_thief.Value < 64320 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(17)
        ElseIf valu_exp_thief.Value >= 64320 And valu_exp_thief.Value < 80960 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(18)
        ElseIf valu_exp_thief.Value >= 80960 And valu_exp_thief.Value < 100960 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(19)
        ElseIf valu_exp_thief.Value >= 100960 And valu_exp_thief.Value < 124820 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(20)
        ElseIf valu_exp_thief.Value >= 124820 And valu_exp_thief.Value < 153090 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(21)
        ElseIf valu_exp_thief.Value >= 153090 And valu_exp_thief.Value < 186360 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(22)
        ElseIf valu_exp_thief.Value >= 186360 And valu_exp_thief.Value < 225300 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(23)
        ElseIf valu_exp_thief.Value >= 225300 And valu_exp_thief.Value < 270610 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(24)
        ElseIf valu_exp_thief.Value >= 270610 And valu_exp_thief.Value < 315920 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(25)
        ElseIf valu_exp_thief.Value >= 315920 And valu_exp_thief.Value < 361230 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(26)
        ElseIf valu_exp_thief.Value >= 361230 And valu_exp_thief.Value < 406540 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(27)
        ElseIf valu_exp_thief.Value >= 406540 And valu_exp_thief.Value < 451850 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(28)
        ElseIf valu_exp_thief.Value >= 451850 And valu_exp_thief.Value < 497160 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(29)
        ElseIf valu_exp_thief.Value >= 497160 And valu_exp_thief.Value < 545590 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(30)
        ElseIf valu_exp_thief.Value >= 545590 And valu_exp_thief.Value < 599690 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(31)
        ElseIf valu_exp_thief.Value >= 599690 And valu_exp_thief.Value < 659900 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(32)
        ElseIf valu_exp_thief.Value >= 659900 And valu_exp_thief.Value < 726690 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(33)
        ElseIf valu_exp_thief.Value >= 726690 And valu_exp_thief.Value < 800540 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(34)
        ElseIf valu_exp_thief.Value >= 800540 And valu_exp_thief.Value < 881950 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(35)
        ElseIf valu_exp_thief.Value >= 881950 And valu_exp_thief.Value < 971440 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(36)
        ElseIf valu_exp_thief.Value >= 971440 And valu_exp_thief.Value < 1069540 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(37)
        ElseIf valu_exp_thief.Value >= 1069540 And valu_exp_thief.Value < 1176790 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(38)
        ElseIf valu_exp_thief.Value >= 1176790 And valu_exp_thief.Value < 1293750 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(39)
        ElseIf valu_exp_thief.Value >= 1293750 And valu_exp_thief.Value < 1420990 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(40)
        ElseIf valu_exp_thief.Value >= 1420990 And valu_exp_thief.Value < 1559090 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(41)
        ElseIf valu_exp_thief.Value >= 1559090 And valu_exp_thief.Value < 1708640 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(42)
        ElseIf valu_exp_thief.Value >= 1708640 And valu_exp_thief.Value < 1870250 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(43)
        ElseIf valu_exp_thief.Value >= 1870250 And valu_exp_thief.Value < 2044530 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(44)
        ElseIf valu_exp_thief.Value >= 2044530 And valu_exp_thief.Value < 2232090 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(45)
        ElseIf valu_exp_thief.Value >= 2232090 And valu_exp_thief.Value < 2448870 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(46)
        ElseIf valu_exp_thief.Value >= 2448870 And valu_exp_thief.Value < 2698120 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(47)
        ElseIf valu_exp_thief.Value >= 2698120 And valu_exp_thief.Value < 2983350 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(48)
        ElseIf valu_exp_thief.Value >= 2983350 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_popstar_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_popstar.ValueChanged
        If valu_exp_popstar.Value > 0 And valu_exp_popstar.Value < 10 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(0)
        ElseIf valu_exp_popstar.Value >= 10 And valu_exp_popstar.Value < 50 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(1)
        ElseIf valu_exp_popstar.Value >= 50 And valu_exp_popstar.Value < 150 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(2)
        ElseIf valu_exp_popstar.Value >= 150 And valu_exp_popstar.Value < 340 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(3)
        ElseIf valu_exp_popstar.Value >= 340 And valu_exp_popstar.Value < 650 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(4)
        ElseIf valu_exp_popstar.Value >= 650 And valu_exp_popstar.Value < 1140 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(5)
        ElseIf valu_exp_popstar.Value >= 1140 And valu_exp_popstar.Value < 1870 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(6)
        ElseIf valu_exp_popstar.Value >= 1870 And valu_exp_popstar.Value < 2920 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(7)
        ElseIf valu_exp_popstar.Value >= 2920 And valu_exp_popstar.Value < 4390 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(8)
        ElseIf valu_exp_popstar.Value >= 4390 And valu_exp_popstar.Value < 6390 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(9)
        ElseIf valu_exp_popstar.Value >= 6390 And valu_exp_popstar.Value < 9060 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(10)
        ElseIf valu_exp_popstar.Value >= 9060 And valu_exp_popstar.Value < 12570 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(11)
        ElseIf valu_exp_popstar.Value >= 12570 And valu_exp_popstar.Value < 17120 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(12)
        ElseIf valu_exp_popstar.Value >= 17120 And valu_exp_popstar.Value < 22920 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(13)
        ElseIf valu_exp_popstar.Value >= 22920 And valu_exp_popstar.Value < 30230 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(14)
        ElseIf valu_exp_popstar.Value >= 30230 And valu_exp_popstar.Value < 39340 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(15)
        ElseIf valu_exp_popstar.Value >= 39340 And valu_exp_popstar.Value < 50580 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(16)
        ElseIf valu_exp_popstar.Value >= 50580 And valu_exp_popstar.Value < 64320 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(17)
        ElseIf valu_exp_popstar.Value >= 64320 And valu_exp_popstar.Value < 80960 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(18)
        ElseIf valu_exp_popstar.Value >= 80960 And valu_exp_popstar.Value < 100960 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(19)
        ElseIf valu_exp_popstar.Value >= 100960 And valu_exp_popstar.Value < 124820 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(20)
        ElseIf valu_exp_popstar.Value >= 124820 And valu_exp_popstar.Value < 153090 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(21)
        ElseIf valu_exp_popstar.Value >= 153090 And valu_exp_popstar.Value < 186360 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(22)
        ElseIf valu_exp_popstar.Value >= 186360 And valu_exp_popstar.Value < 225300 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(23)
        ElseIf valu_exp_popstar.Value >= 225300 And valu_exp_popstar.Value < 270610 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(24)
        ElseIf valu_exp_popstar.Value >= 270610 And valu_exp_popstar.Value < 315920 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(25)
        ElseIf valu_exp_popstar.Value >= 315920 And valu_exp_popstar.Value < 361230 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(26)
        ElseIf valu_exp_popstar.Value >= 361230 And valu_exp_popstar.Value < 406540 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(27)
        ElseIf valu_exp_popstar.Value >= 406540 And valu_exp_popstar.Value < 451850 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(28)
        ElseIf valu_exp_popstar.Value >= 451850 And valu_exp_popstar.Value < 497160 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(29)
        ElseIf valu_exp_popstar.Value >= 497160 And valu_exp_popstar.Value < 545590 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(30)
        ElseIf valu_exp_popstar.Value >= 545590 And valu_exp_popstar.Value < 599690 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(31)
        ElseIf valu_exp_popstar.Value >= 599690 And valu_exp_popstar.Value < 659900 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(32)
        ElseIf valu_exp_popstar.Value >= 659900 And valu_exp_popstar.Value < 726690 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(33)
        ElseIf valu_exp_popstar.Value >= 726690 And valu_exp_popstar.Value < 800540 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(34)
        ElseIf valu_exp_popstar.Value >= 800540 And valu_exp_popstar.Value < 881950 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(35)
        ElseIf valu_exp_popstar.Value >= 881950 And valu_exp_popstar.Value < 971440 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(36)
        ElseIf valu_exp_popstar.Value >= 971440 And valu_exp_popstar.Value < 1069540 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(37)
        ElseIf valu_exp_popstar.Value >= 1069540 And valu_exp_popstar.Value < 1176790 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(38)
        ElseIf valu_exp_popstar.Value >= 1176790 And valu_exp_popstar.Value < 1293750 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(39)
        ElseIf valu_exp_popstar.Value >= 1293750 And valu_exp_popstar.Value < 1420990 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(40)
        ElseIf valu_exp_popstar.Value >= 1420990 And valu_exp_popstar.Value < 1559090 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(41)
        ElseIf valu_exp_popstar.Value >= 1559090 And valu_exp_popstar.Value < 1708640 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(42)
        ElseIf valu_exp_popstar.Value >= 1708640 And valu_exp_popstar.Value < 1870250 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(43)
        ElseIf valu_exp_popstar.Value >= 1870250 And valu_exp_popstar.Value < 2044530 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(44)
        ElseIf valu_exp_popstar.Value >= 2044530 And valu_exp_popstar.Value < 2232090 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(45)
        ElseIf valu_exp_popstar.Value >= 2232090 And valu_exp_popstar.Value < 2448870 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(46)
        ElseIf valu_exp_popstar.Value >= 2448870 And valu_exp_popstar.Value < 2698120 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(47)
        ElseIf valu_exp_popstar.Value >= 2698120 And valu_exp_popstar.Value < 2983350 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(48)
        ElseIf valu_exp_popstar.Value >= 2983350 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_vampire_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_vampire.ValueChanged
        If valu_exp_vampire.Value > 0 And valu_exp_vampire.Value < 10 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(0)
        ElseIf valu_exp_vampire.Value >= 10 And valu_exp_vampire.Value < 50 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(1)
        ElseIf valu_exp_vampire.Value >= 50 And valu_exp_vampire.Value < 150 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(2)
        ElseIf valu_exp_vampire.Value >= 150 And valu_exp_vampire.Value < 340 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(3)
        ElseIf valu_exp_vampire.Value >= 340 And valu_exp_vampire.Value < 650 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(4)
        ElseIf valu_exp_vampire.Value >= 650 And valu_exp_vampire.Value < 1140 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(5)
        ElseIf valu_exp_vampire.Value >= 1140 And valu_exp_vampire.Value < 1870 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(6)
        ElseIf valu_exp_vampire.Value >= 1870 And valu_exp_vampire.Value < 2920 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(7)
        ElseIf valu_exp_vampire.Value >= 2920 And valu_exp_vampire.Value < 4390 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(8)
        ElseIf valu_exp_vampire.Value >= 4390 And valu_exp_vampire.Value < 6390 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(9)
        ElseIf valu_exp_vampire.Value >= 6390 And valu_exp_vampire.Value < 9060 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(10)
        ElseIf valu_exp_vampire.Value >= 9060 And valu_exp_vampire.Value < 12570 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(11)
        ElseIf valu_exp_vampire.Value >= 12570 And valu_exp_vampire.Value < 17120 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(12)
        ElseIf valu_exp_vampire.Value >= 17120 And valu_exp_vampire.Value < 22920 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(13)
        ElseIf valu_exp_vampire.Value >= 22920 And valu_exp_vampire.Value < 30230 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(14)
        ElseIf valu_exp_vampire.Value >= 30230 And valu_exp_vampire.Value < 39340 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(15)
        ElseIf valu_exp_vampire.Value >= 39340 And valu_exp_vampire.Value < 50580 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(16)
        ElseIf valu_exp_vampire.Value >= 50580 And valu_exp_vampire.Value < 64320 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(17)
        ElseIf valu_exp_vampire.Value >= 64320 And valu_exp_vampire.Value < 80960 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(18)
        ElseIf valu_exp_vampire.Value >= 80960 And valu_exp_vampire.Value < 100960 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(19)
        ElseIf valu_exp_vampire.Value >= 100960 And valu_exp_vampire.Value < 124820 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(20)
        ElseIf valu_exp_vampire.Value >= 124820 And valu_exp_vampire.Value < 153090 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(21)
        ElseIf valu_exp_vampire.Value >= 153090 And valu_exp_vampire.Value < 186360 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(22)
        ElseIf valu_exp_vampire.Value >= 186360 And valu_exp_vampire.Value < 225300 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(23)
        ElseIf valu_exp_vampire.Value >= 225300 And valu_exp_vampire.Value < 270610 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(24)
        ElseIf valu_exp_vampire.Value >= 270610 And valu_exp_vampire.Value < 315920 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(25)
        ElseIf valu_exp_vampire.Value >= 315920 And valu_exp_vampire.Value < 361230 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(26)
        ElseIf valu_exp_vampire.Value >= 361230 And valu_exp_vampire.Value < 406540 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(27)
        ElseIf valu_exp_vampire.Value >= 406540 And valu_exp_vampire.Value < 451850 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(28)
        ElseIf valu_exp_vampire.Value >= 451850 And valu_exp_vampire.Value < 497160 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(29)
        ElseIf valu_exp_vampire.Value >= 497160 And valu_exp_vampire.Value < 545590 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(30)
        ElseIf valu_exp_vampire.Value >= 545590 And valu_exp_vampire.Value < 599690 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(31)
        ElseIf valu_exp_vampire.Value >= 599690 And valu_exp_vampire.Value < 659900 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(32)
        ElseIf valu_exp_vampire.Value >= 659900 And valu_exp_vampire.Value < 726690 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(33)
        ElseIf valu_exp_vampire.Value >= 726690 And valu_exp_vampire.Value < 800540 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(34)
        ElseIf valu_exp_vampire.Value >= 800540 And valu_exp_vampire.Value < 881950 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(35)
        ElseIf valu_exp_vampire.Value >= 881950 And valu_exp_vampire.Value < 971440 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(36)
        ElseIf valu_exp_vampire.Value >= 971440 And valu_exp_vampire.Value < 1069540 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(37)
        ElseIf valu_exp_vampire.Value >= 1069540 And valu_exp_vampire.Value < 1176790 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(38)
        ElseIf valu_exp_vampire.Value >= 1176790 And valu_exp_vampire.Value < 1293750 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(39)
        ElseIf valu_exp_vampire.Value >= 1293750 And valu_exp_vampire.Value < 1420990 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(40)
        ElseIf valu_exp_vampire.Value >= 1420990 And valu_exp_vampire.Value < 1559090 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(41)
        ElseIf valu_exp_vampire.Value >= 1559090 And valu_exp_vampire.Value < 1708640 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(42)
        ElseIf valu_exp_vampire.Value >= 1708640 And valu_exp_vampire.Value < 1870250 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(43)
        ElseIf valu_exp_vampire.Value >= 1870250 And valu_exp_vampire.Value < 2044530 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(44)
        ElseIf valu_exp_vampire.Value >= 2044530 And valu_exp_vampire.Value < 2232090 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(45)
        ElseIf valu_exp_vampire.Value >= 2232090 And valu_exp_vampire.Value < 2448870 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(46)
        ElseIf valu_exp_vampire.Value >= 2448870 And valu_exp_vampire.Value < 2698120 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(47)
        ElseIf valu_exp_vampire.Value >= 2698120 And valu_exp_vampire.Value < 2983350 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(48)
        ElseIf valu_exp_vampire.Value >= 2983350 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_chef_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_chef.ValueChanged
        If valu_exp_chef.Value > 0 And valu_exp_chef.Value < 10 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(0)
        ElseIf valu_exp_chef.Value >= 10 And valu_exp_chef.Value < 50 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(1)
        ElseIf valu_exp_chef.Value >= 50 And valu_exp_chef.Value < 150 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(2)
        ElseIf valu_exp_chef.Value >= 150 And valu_exp_chef.Value < 340 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(3)
        ElseIf valu_exp_chef.Value >= 340 And valu_exp_chef.Value < 650 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(4)
        ElseIf valu_exp_chef.Value >= 650 And valu_exp_chef.Value < 1140 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(5)
        ElseIf valu_exp_chef.Value >= 1140 And valu_exp_chef.Value < 1870 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(6)
        ElseIf valu_exp_chef.Value >= 1870 And valu_exp_chef.Value < 2920 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(7)
        ElseIf valu_exp_chef.Value >= 2920 And valu_exp_chef.Value < 4390 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(8)
        ElseIf valu_exp_chef.Value >= 4390 And valu_exp_chef.Value < 6390 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(9)
        ElseIf valu_exp_chef.Value >= 6390 And valu_exp_chef.Value < 9060 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(10)
        ElseIf valu_exp_chef.Value >= 9060 And valu_exp_chef.Value < 12570 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(11)
        ElseIf valu_exp_chef.Value >= 12570 And valu_exp_chef.Value < 17120 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(12)
        ElseIf valu_exp_chef.Value >= 17120 And valu_exp_chef.Value < 22920 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(13)
        ElseIf valu_exp_chef.Value >= 22920 And valu_exp_chef.Value < 30230 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(14)
        ElseIf valu_exp_chef.Value >= 30230 And valu_exp_chef.Value < 39340 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(15)
        ElseIf valu_exp_chef.Value >= 39340 And valu_exp_chef.Value < 50580 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(16)
        ElseIf valu_exp_chef.Value >= 50580 And valu_exp_chef.Value < 64320 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(17)
        ElseIf valu_exp_chef.Value >= 64320 And valu_exp_chef.Value < 80960 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(18)
        ElseIf valu_exp_chef.Value >= 80960 And valu_exp_chef.Value < 100960 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(19)
        ElseIf valu_exp_chef.Value >= 100960 And valu_exp_chef.Value < 124820 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(20)
        ElseIf valu_exp_chef.Value >= 124820 And valu_exp_chef.Value < 153090 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(21)
        ElseIf valu_exp_chef.Value >= 153090 And valu_exp_chef.Value < 186360 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(22)
        ElseIf valu_exp_chef.Value >= 186360 And valu_exp_chef.Value < 225300 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(23)
        ElseIf valu_exp_chef.Value >= 225300 And valu_exp_chef.Value < 270610 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(24)
        ElseIf valu_exp_chef.Value >= 270610 And valu_exp_chef.Value < 315920 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(25)
        ElseIf valu_exp_chef.Value >= 315920 And valu_exp_chef.Value < 361230 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(26)
        ElseIf valu_exp_chef.Value >= 361230 And valu_exp_chef.Value < 406540 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(27)
        ElseIf valu_exp_chef.Value >= 406540 And valu_exp_chef.Value < 451850 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(28)
        ElseIf valu_exp_chef.Value >= 451850 And valu_exp_chef.Value < 497160 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(29)
        ElseIf valu_exp_chef.Value >= 497160 And valu_exp_chef.Value < 545590 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(30)
        ElseIf valu_exp_chef.Value >= 545590 And valu_exp_chef.Value < 599690 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(31)
        ElseIf valu_exp_chef.Value >= 599690 And valu_exp_chef.Value < 659900 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(32)
        ElseIf valu_exp_chef.Value >= 659900 And valu_exp_chef.Value < 726690 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(33)
        ElseIf valu_exp_chef.Value >= 726690 And valu_exp_chef.Value < 800540 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(34)
        ElseIf valu_exp_chef.Value >= 800540 And valu_exp_chef.Value < 881950 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(35)
        ElseIf valu_exp_chef.Value >= 881950 And valu_exp_chef.Value < 971440 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(36)
        ElseIf valu_exp_chef.Value >= 971440 And valu_exp_chef.Value < 1069540 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(37)
        ElseIf valu_exp_chef.Value >= 1069540 And valu_exp_chef.Value < 1176790 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(38)
        ElseIf valu_exp_chef.Value >= 1176790 And valu_exp_chef.Value < 1293750 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(39)
        ElseIf valu_exp_chef.Value >= 1293750 And valu_exp_chef.Value < 1420990 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(40)
        ElseIf valu_exp_chef.Value >= 1420990 And valu_exp_chef.Value < 1559090 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(41)
        ElseIf valu_exp_chef.Value >= 1559090 And valu_exp_chef.Value < 1708640 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(42)
        ElseIf valu_exp_chef.Value >= 1708640 And valu_exp_chef.Value < 1870250 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(43)
        ElseIf valu_exp_chef.Value >= 1870250 And valu_exp_chef.Value < 2044530 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(44)
        ElseIf valu_exp_chef.Value >= 2044530 And valu_exp_chef.Value < 2232090 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(45)
        ElseIf valu_exp_chef.Value >= 2232090 And valu_exp_chef.Value < 2448870 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(46)
        ElseIf valu_exp_chef.Value >= 2448870 And valu_exp_chef.Value < 2698120 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(47)
        ElseIf valu_exp_chef.Value >= 2698120 And valu_exp_chef.Value < 2983350 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(48)
        ElseIf valu_exp_chef.Value >= 2983350 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_tank_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_tank.ValueChanged
        If valu_exp_tank.Value > 0 And valu_exp_tank.Value < 10 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(0)
        ElseIf valu_exp_tank.Value >= 10 And valu_exp_tank.Value < 50 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(1)
        ElseIf valu_exp_tank.Value >= 50 And valu_exp_tank.Value < 150 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(2)
        ElseIf valu_exp_tank.Value >= 150 And valu_exp_tank.Value < 340 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(3)
        ElseIf valu_exp_tank.Value >= 340 And valu_exp_tank.Value < 650 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(4)
        ElseIf valu_exp_tank.Value >= 650 And valu_exp_tank.Value < 1140 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(5)
        ElseIf valu_exp_tank.Value >= 1140 And valu_exp_tank.Value < 1870 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(6)
        ElseIf valu_exp_tank.Value >= 1870 And valu_exp_tank.Value < 2920 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(7)
        ElseIf valu_exp_tank.Value >= 2920 And valu_exp_tank.Value < 4390 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(8)
        ElseIf valu_exp_tank.Value >= 4390 And valu_exp_tank.Value < 6390 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(9)
        ElseIf valu_exp_tank.Value >= 6390 And valu_exp_tank.Value < 9060 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(10)
        ElseIf valu_exp_tank.Value >= 9060 And valu_exp_tank.Value < 12570 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(11)
        ElseIf valu_exp_tank.Value >= 12570 And valu_exp_tank.Value < 17120 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(12)
        ElseIf valu_exp_tank.Value >= 17120 And valu_exp_tank.Value < 22920 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(13)
        ElseIf valu_exp_tank.Value >= 22920 And valu_exp_tank.Value < 30230 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(14)
        ElseIf valu_exp_tank.Value >= 30230 And valu_exp_tank.Value < 39340 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(15)
        ElseIf valu_exp_tank.Value >= 39340 And valu_exp_tank.Value < 50580 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(16)
        ElseIf valu_exp_tank.Value >= 50580 And valu_exp_tank.Value < 64320 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(17)
        ElseIf valu_exp_tank.Value >= 64320 And valu_exp_tank.Value < 80960 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(18)
        ElseIf valu_exp_tank.Value >= 80960 And valu_exp_tank.Value < 100960 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(19)
        ElseIf valu_exp_tank.Value >= 100960 And valu_exp_tank.Value < 124820 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(20)
        ElseIf valu_exp_tank.Value >= 124820 And valu_exp_tank.Value < 153090 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(21)
        ElseIf valu_exp_tank.Value >= 153090 And valu_exp_tank.Value < 186360 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(22)
        ElseIf valu_exp_tank.Value >= 186360 And valu_exp_tank.Value < 225300 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(23)
        ElseIf valu_exp_tank.Value >= 225300 And valu_exp_tank.Value < 270610 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(24)
        ElseIf valu_exp_tank.Value >= 270610 And valu_exp_tank.Value < 315920 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(25)
        ElseIf valu_exp_tank.Value >= 315920 And valu_exp_tank.Value < 361230 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(26)
        ElseIf valu_exp_tank.Value >= 361230 And valu_exp_tank.Value < 406540 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(27)
        ElseIf valu_exp_tank.Value >= 406540 And valu_exp_tank.Value < 451850 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(28)
        ElseIf valu_exp_tank.Value >= 451850 And valu_exp_tank.Value < 497160 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(29)
        ElseIf valu_exp_tank.Value >= 497160 And valu_exp_tank.Value < 545590 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(30)
        ElseIf valu_exp_tank.Value >= 545590 And valu_exp_tank.Value < 599690 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(31)
        ElseIf valu_exp_tank.Value >= 599690 And valu_exp_tank.Value < 659900 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(32)
        ElseIf valu_exp_tank.Value >= 659900 And valu_exp_tank.Value < 726690 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(33)
        ElseIf valu_exp_tank.Value >= 726690 And valu_exp_tank.Value < 800540 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(34)
        ElseIf valu_exp_tank.Value >= 800540 And valu_exp_tank.Value < 881950 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(35)
        ElseIf valu_exp_tank.Value >= 881950 And valu_exp_tank.Value < 971440 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(36)
        ElseIf valu_exp_tank.Value >= 971440 And valu_exp_tank.Value < 1069540 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(37)
        ElseIf valu_exp_tank.Value >= 1069540 And valu_exp_tank.Value < 1176790 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(38)
        ElseIf valu_exp_tank.Value >= 1176790 And valu_exp_tank.Value < 1293750 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(39)
        ElseIf valu_exp_tank.Value >= 1293750 And valu_exp_tank.Value < 1420990 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(40)
        ElseIf valu_exp_tank.Value >= 1420990 And valu_exp_tank.Value < 1559090 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(41)
        ElseIf valu_exp_tank.Value >= 1559090 And valu_exp_tank.Value < 1708640 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(42)
        ElseIf valu_exp_tank.Value >= 1708640 And valu_exp_tank.Value < 1870250 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(43)
        ElseIf valu_exp_tank.Value >= 1870250 And valu_exp_tank.Value < 2044530 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(44)
        ElseIf valu_exp_tank.Value >= 2044530 And valu_exp_tank.Value < 2232090 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(45)
        ElseIf valu_exp_tank.Value >= 2232090 And valu_exp_tank.Value < 2448870 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(46)
        ElseIf valu_exp_tank.Value >= 2448870 And valu_exp_tank.Value < 2698120 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(47)
        ElseIf valu_exp_tank.Value >= 2698120 And valu_exp_tank.Value < 2983350 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(48)
        ElseIf valu_exp_tank.Value >= 2983350 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_imp_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_imp.ValueChanged
        If valu_exp_imp.Value > 0 And valu_exp_imp.Value < 10 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(0)
        ElseIf valu_exp_imp.Value >= 10 And valu_exp_imp.Value < 50 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(1)
        ElseIf valu_exp_imp.Value >= 50 And valu_exp_imp.Value < 150 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(2)
        ElseIf valu_exp_imp.Value >= 150 And valu_exp_imp.Value < 340 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(3)
        ElseIf valu_exp_imp.Value >= 340 And valu_exp_imp.Value < 650 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(4)
        ElseIf valu_exp_imp.Value >= 650 And valu_exp_imp.Value < 1140 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(5)
        ElseIf valu_exp_imp.Value >= 1140 And valu_exp_imp.Value < 1870 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(6)
        ElseIf valu_exp_imp.Value >= 1870 And valu_exp_imp.Value < 2920 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(7)
        ElseIf valu_exp_imp.Value >= 2920 And valu_exp_imp.Value < 4390 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(8)
        ElseIf valu_exp_imp.Value >= 4390 And valu_exp_imp.Value < 6390 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(9)
        ElseIf valu_exp_imp.Value >= 6390 And valu_exp_imp.Value < 9060 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(10)
        ElseIf valu_exp_imp.Value >= 9060 And valu_exp_imp.Value < 12570 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(11)
        ElseIf valu_exp_imp.Value >= 12570 And valu_exp_imp.Value < 17120 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(12)
        ElseIf valu_exp_imp.Value >= 17120 And valu_exp_imp.Value < 22920 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(13)
        ElseIf valu_exp_imp.Value >= 22920 And valu_exp_imp.Value < 30230 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(14)
        ElseIf valu_exp_imp.Value >= 30230 And valu_exp_imp.Value < 39340 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(15)
        ElseIf valu_exp_imp.Value >= 39340 And valu_exp_imp.Value < 50580 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(16)
        ElseIf valu_exp_imp.Value >= 50580 And valu_exp_imp.Value < 64320 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(17)
        ElseIf valu_exp_imp.Value >= 64320 And valu_exp_imp.Value < 80960 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(18)
        ElseIf valu_exp_imp.Value >= 80960 And valu_exp_imp.Value < 100960 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(19)
        ElseIf valu_exp_imp.Value >= 100960 And valu_exp_imp.Value < 124820 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(20)
        ElseIf valu_exp_imp.Value >= 124820 And valu_exp_imp.Value < 153090 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(21)
        ElseIf valu_exp_imp.Value >= 153090 And valu_exp_imp.Value < 186360 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(22)
        ElseIf valu_exp_imp.Value >= 186360 And valu_exp_imp.Value < 225300 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(23)
        ElseIf valu_exp_imp.Value >= 225300 And valu_exp_imp.Value < 270610 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(24)
        ElseIf valu_exp_imp.Value >= 270610 And valu_exp_imp.Value < 315920 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(25)
        ElseIf valu_exp_imp.Value >= 315920 And valu_exp_imp.Value < 361230 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(26)
        ElseIf valu_exp_imp.Value >= 361230 And valu_exp_imp.Value < 406540 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(27)
        ElseIf valu_exp_imp.Value >= 406540 And valu_exp_imp.Value < 451850 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(28)
        ElseIf valu_exp_imp.Value >= 451850 And valu_exp_imp.Value < 497160 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(29)
        ElseIf valu_exp_imp.Value >= 497160 And valu_exp_imp.Value < 545590 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(30)
        ElseIf valu_exp_imp.Value >= 545590 And valu_exp_imp.Value < 599690 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(31)
        ElseIf valu_exp_imp.Value >= 599690 And valu_exp_imp.Value < 659900 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(32)
        ElseIf valu_exp_imp.Value >= 659900 And valu_exp_imp.Value < 726690 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(33)
        ElseIf valu_exp_imp.Value >= 726690 And valu_exp_imp.Value < 800540 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(34)
        ElseIf valu_exp_imp.Value >= 800540 And valu_exp_imp.Value < 881950 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(35)
        ElseIf valu_exp_imp.Value >= 881950 And valu_exp_imp.Value < 971440 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(36)
        ElseIf valu_exp_imp.Value >= 971440 And valu_exp_imp.Value < 1069540 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(37)
        ElseIf valu_exp_imp.Value >= 1069540 And valu_exp_imp.Value < 1176790 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(38)
        ElseIf valu_exp_imp.Value >= 1176790 And valu_exp_imp.Value < 1293750 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(39)
        ElseIf valu_exp_imp.Value >= 1293750 And valu_exp_imp.Value < 1420990 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(40)
        ElseIf valu_exp_imp.Value >= 1420990 And valu_exp_imp.Value < 1559090 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(41)
        ElseIf valu_exp_imp.Value >= 1559090 And valu_exp_imp.Value < 1708640 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(42)
        ElseIf valu_exp_imp.Value >= 1708640 And valu_exp_imp.Value < 1870250 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(43)
        ElseIf valu_exp_imp.Value >= 1870250 And valu_exp_imp.Value < 2044530 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(44)
        ElseIf valu_exp_imp.Value >= 2044530 And valu_exp_imp.Value < 2232090 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(45)
        ElseIf valu_exp_imp.Value >= 2232090 And valu_exp_imp.Value < 2448870 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(46)
        ElseIf valu_exp_imp.Value >= 2448870 And valu_exp_imp.Value < 2698120 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(47)
        ElseIf valu_exp_imp.Value >= 2698120 And valu_exp_imp.Value < 2983350 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(48)
        ElseIf valu_exp_imp.Value >= 2983350 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_princess_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_princess.ValueChanged
        If valu_exp_princess.Value > 0 And valu_exp_princess.Value < 10 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(0)
        ElseIf valu_exp_princess.Value >= 10 And valu_exp_princess.Value < 50 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(1)
        ElseIf valu_exp_princess.Value >= 50 And valu_exp_princess.Value < 150 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(2)
        ElseIf valu_exp_princess.Value >= 150 And valu_exp_princess.Value < 340 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(3)
        ElseIf valu_exp_princess.Value >= 340 And valu_exp_princess.Value < 650 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(4)
        ElseIf valu_exp_princess.Value >= 650 And valu_exp_princess.Value < 1140 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(5)
        ElseIf valu_exp_princess.Value >= 1140 And valu_exp_princess.Value < 1870 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(6)
        ElseIf valu_exp_princess.Value >= 1870 And valu_exp_princess.Value < 2920 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(7)
        ElseIf valu_exp_princess.Value >= 2920 And valu_exp_princess.Value < 4390 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(8)
        ElseIf valu_exp_princess.Value >= 4390 And valu_exp_princess.Value < 6390 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(9)
        ElseIf valu_exp_princess.Value >= 6390 And valu_exp_princess.Value < 9060 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(10)
        ElseIf valu_exp_princess.Value >= 9060 And valu_exp_princess.Value < 12570 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(11)
        ElseIf valu_exp_princess.Value >= 12570 And valu_exp_princess.Value < 17120 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(12)
        ElseIf valu_exp_princess.Value >= 17120 And valu_exp_princess.Value < 22920 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(13)
        ElseIf valu_exp_princess.Value >= 22920 And valu_exp_princess.Value < 30230 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(14)
        ElseIf valu_exp_princess.Value >= 30230 And valu_exp_princess.Value < 39340 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(15)
        ElseIf valu_exp_princess.Value >= 39340 And valu_exp_princess.Value < 50580 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(16)
        ElseIf valu_exp_princess.Value >= 50580 And valu_exp_princess.Value < 64320 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(17)
        ElseIf valu_exp_princess.Value >= 64320 And valu_exp_princess.Value < 80960 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(18)
        ElseIf valu_exp_princess.Value >= 80960 And valu_exp_princess.Value < 100960 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(19)
        ElseIf valu_exp_princess.Value >= 100960 And valu_exp_princess.Value < 124820 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(20)
        ElseIf valu_exp_princess.Value >= 124820 And valu_exp_princess.Value < 153090 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(21)
        ElseIf valu_exp_princess.Value >= 153090 And valu_exp_princess.Value < 186360 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(22)
        ElseIf valu_exp_princess.Value >= 186360 And valu_exp_princess.Value < 225300 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(23)
        ElseIf valu_exp_princess.Value >= 225300 And valu_exp_princess.Value < 270610 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(24)
        ElseIf valu_exp_princess.Value >= 270610 And valu_exp_princess.Value < 315920 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(25)
        ElseIf valu_exp_princess.Value >= 315920 And valu_exp_princess.Value < 361230 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(26)
        ElseIf valu_exp_princess.Value >= 361230 And valu_exp_princess.Value < 406540 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(27)
        ElseIf valu_exp_princess.Value >= 406540 And valu_exp_princess.Value < 451850 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(28)
        ElseIf valu_exp_princess.Value >= 451850 And valu_exp_princess.Value < 497160 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(29)
        ElseIf valu_exp_princess.Value >= 497160 And valu_exp_princess.Value < 545590 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(30)
        ElseIf valu_exp_princess.Value >= 545590 And valu_exp_princess.Value < 599690 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(31)
        ElseIf valu_exp_princess.Value >= 599690 And valu_exp_princess.Value < 659900 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(32)
        ElseIf valu_exp_princess.Value >= 659900 And valu_exp_princess.Value < 726690 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(33)
        ElseIf valu_exp_princess.Value >= 726690 And valu_exp_princess.Value < 800540 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(34)
        ElseIf valu_exp_princess.Value >= 800540 And valu_exp_princess.Value < 881950 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(35)
        ElseIf valu_exp_princess.Value >= 881950 And valu_exp_princess.Value < 971440 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(36)
        ElseIf valu_exp_princess.Value >= 971440 And valu_exp_princess.Value < 1069540 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(37)
        ElseIf valu_exp_princess.Value >= 1069540 And valu_exp_princess.Value < 1176790 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(38)
        ElseIf valu_exp_princess.Value >= 1176790 And valu_exp_princess.Value < 1293750 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(39)
        ElseIf valu_exp_princess.Value >= 1293750 And valu_exp_princess.Value < 1420990 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(40)
        ElseIf valu_exp_princess.Value >= 1420990 And valu_exp_princess.Value < 1559090 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(41)
        ElseIf valu_exp_princess.Value >= 1559090 And valu_exp_princess.Value < 1708640 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(42)
        ElseIf valu_exp_princess.Value >= 1708640 And valu_exp_princess.Value < 1870250 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(43)
        ElseIf valu_exp_princess.Value >= 1870250 And valu_exp_princess.Value < 2044530 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(44)
        ElseIf valu_exp_princess.Value >= 2044530 And valu_exp_princess.Value < 2232090 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(45)
        ElseIf valu_exp_princess.Value >= 2232090 And valu_exp_princess.Value < 2448870 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(46)
        ElseIf valu_exp_princess.Value >= 2448870 And valu_exp_princess.Value < 2698120 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(47)
        ElseIf valu_exp_princess.Value >= 2698120 And valu_exp_princess.Value < 2983350 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(48)
        ElseIf valu_exp_princess.Value >= 2983350 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_flower_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_flower.ValueChanged
        If valu_exp_flower.Value > 0 And valu_exp_flower.Value < 10 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(0)
        ElseIf valu_exp_flower.Value >= 10 And valu_exp_flower.Value < 50 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(1)
        ElseIf valu_exp_flower.Value >= 50 And valu_exp_flower.Value < 150 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(2)
        ElseIf valu_exp_flower.Value >= 150 And valu_exp_flower.Value < 340 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(3)
        ElseIf valu_exp_flower.Value >= 340 And valu_exp_flower.Value < 650 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(4)
        ElseIf valu_exp_flower.Value >= 650 And valu_exp_flower.Value < 1140 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(5)
        ElseIf valu_exp_flower.Value >= 1140 And valu_exp_flower.Value < 1870 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(6)
        ElseIf valu_exp_flower.Value >= 1870 And valu_exp_flower.Value < 2920 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(7)
        ElseIf valu_exp_flower.Value >= 2920 And valu_exp_flower.Value < 4390 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(8)
        ElseIf valu_exp_flower.Value >= 4390 And valu_exp_flower.Value < 6390 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(9)
        ElseIf valu_exp_flower.Value >= 6390 And valu_exp_flower.Value < 9060 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(10)
        ElseIf valu_exp_flower.Value >= 9060 And valu_exp_flower.Value < 12570 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(11)
        ElseIf valu_exp_flower.Value >= 12570 And valu_exp_flower.Value < 17120 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(12)
        ElseIf valu_exp_flower.Value >= 17120 And valu_exp_flower.Value < 22920 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(13)
        ElseIf valu_exp_flower.Value >= 22920 And valu_exp_flower.Value < 30230 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(14)
        ElseIf valu_exp_flower.Value >= 30230 And valu_exp_flower.Value < 39340 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(15)
        ElseIf valu_exp_flower.Value >= 39340 And valu_exp_flower.Value < 50580 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(16)
        ElseIf valu_exp_flower.Value >= 50580 And valu_exp_flower.Value < 64320 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(17)
        ElseIf valu_exp_flower.Value >= 64320 And valu_exp_flower.Value < 80960 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(18)
        ElseIf valu_exp_flower.Value >= 80960 And valu_exp_flower.Value < 100960 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(19)
        ElseIf valu_exp_flower.Value >= 100960 And valu_exp_flower.Value < 124820 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(20)
        ElseIf valu_exp_flower.Value >= 124820 And valu_exp_flower.Value < 153090 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(21)
        ElseIf valu_exp_flower.Value >= 153090 And valu_exp_flower.Value < 186360 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(22)
        ElseIf valu_exp_flower.Value >= 186360 And valu_exp_flower.Value < 225300 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(23)
        ElseIf valu_exp_flower.Value >= 225300 And valu_exp_flower.Value < 270610 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(24)
        ElseIf valu_exp_flower.Value >= 270610 And valu_exp_flower.Value < 315920 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(25)
        ElseIf valu_exp_flower.Value >= 315920 And valu_exp_flower.Value < 361230 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(26)
        ElseIf valu_exp_flower.Value >= 361230 And valu_exp_flower.Value < 406540 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(27)
        ElseIf valu_exp_flower.Value >= 406540 And valu_exp_flower.Value < 451850 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(28)
        ElseIf valu_exp_flower.Value >= 451850 And valu_exp_flower.Value < 497160 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(29)
        ElseIf valu_exp_flower.Value >= 497160 And valu_exp_flower.Value < 545590 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(30)
        ElseIf valu_exp_flower.Value >= 545590 And valu_exp_flower.Value < 599690 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(31)
        ElseIf valu_exp_flower.Value >= 599690 And valu_exp_flower.Value < 659900 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(32)
        ElseIf valu_exp_flower.Value >= 659900 And valu_exp_flower.Value < 726690 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(33)
        ElseIf valu_exp_flower.Value >= 726690 And valu_exp_flower.Value < 800540 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(34)
        ElseIf valu_exp_flower.Value >= 800540 And valu_exp_flower.Value < 881950 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(35)
        ElseIf valu_exp_flower.Value >= 881950 And valu_exp_flower.Value < 971440 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(36)
        ElseIf valu_exp_flower.Value >= 971440 And valu_exp_flower.Value < 1069540 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(37)
        ElseIf valu_exp_flower.Value >= 1069540 And valu_exp_flower.Value < 1176790 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(38)
        ElseIf valu_exp_flower.Value >= 1176790 And valu_exp_flower.Value < 1293750 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(39)
        ElseIf valu_exp_flower.Value >= 1293750 And valu_exp_flower.Value < 1420990 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(40)
        ElseIf valu_exp_flower.Value >= 1420990 And valu_exp_flower.Value < 1559090 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(41)
        ElseIf valu_exp_flower.Value >= 1559090 And valu_exp_flower.Value < 1708640 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(42)
        ElseIf valu_exp_flower.Value >= 1708640 And valu_exp_flower.Value < 1870250 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(43)
        ElseIf valu_exp_flower.Value >= 1870250 And valu_exp_flower.Value < 2044530 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(44)
        ElseIf valu_exp_flower.Value >= 2044530 And valu_exp_flower.Value < 2232090 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(45)
        ElseIf valu_exp_flower.Value >= 2232090 And valu_exp_flower.Value < 2448870 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(46)
        ElseIf valu_exp_flower.Value >= 2448870 And valu_exp_flower.Value < 2698120 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(47)
        ElseIf valu_exp_flower.Value >= 2698120 And valu_exp_flower.Value < 2983350 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(48)
        ElseIf valu_exp_flower.Value >= 2983350 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_scientist_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_scientist.ValueChanged
        If valu_exp_scientist.Value > 0 And valu_exp_scientist.Value < 10 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(0)
        ElseIf valu_exp_scientist.Value >= 10 And valu_exp_scientist.Value < 50 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(1)
        ElseIf valu_exp_scientist.Value >= 50 And valu_exp_scientist.Value < 150 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(2)
        ElseIf valu_exp_scientist.Value >= 150 And valu_exp_scientist.Value < 340 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(3)
        ElseIf valu_exp_scientist.Value >= 340 And valu_exp_scientist.Value < 650 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(4)
        ElseIf valu_exp_scientist.Value >= 650 And valu_exp_scientist.Value < 1140 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(5)
        ElseIf valu_exp_scientist.Value >= 1140 And valu_exp_scientist.Value < 1870 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(6)
        ElseIf valu_exp_scientist.Value >= 1870 And valu_exp_scientist.Value < 2920 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(7)
        ElseIf valu_exp_scientist.Value >= 2920 And valu_exp_scientist.Value < 4390 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(8)
        ElseIf valu_exp_scientist.Value >= 4390 And valu_exp_scientist.Value < 6390 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(9)
        ElseIf valu_exp_scientist.Value >= 6390 And valu_exp_scientist.Value < 9060 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(10)
        ElseIf valu_exp_scientist.Value >= 9060 And valu_exp_scientist.Value < 12570 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(11)
        ElseIf valu_exp_scientist.Value >= 12570 And valu_exp_scientist.Value < 17120 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(12)
        ElseIf valu_exp_scientist.Value >= 17120 And valu_exp_scientist.Value < 22920 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(13)
        ElseIf valu_exp_scientist.Value >= 22920 And valu_exp_scientist.Value < 30230 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(14)
        ElseIf valu_exp_scientist.Value >= 30230 And valu_exp_scientist.Value < 39340 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(15)
        ElseIf valu_exp_scientist.Value >= 39340 And valu_exp_scientist.Value < 50580 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(16)
        ElseIf valu_exp_scientist.Value >= 50580 And valu_exp_scientist.Value < 64320 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(17)
        ElseIf valu_exp_scientist.Value >= 64320 And valu_exp_scientist.Value < 80960 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(18)
        ElseIf valu_exp_scientist.Value >= 80960 And valu_exp_scientist.Value < 100960 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(19)
        ElseIf valu_exp_scientist.Value >= 100960 And valu_exp_scientist.Value < 124820 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(20)
        ElseIf valu_exp_scientist.Value >= 124820 And valu_exp_scientist.Value < 153090 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(21)
        ElseIf valu_exp_scientist.Value >= 153090 And valu_exp_scientist.Value < 186360 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(22)
        ElseIf valu_exp_scientist.Value >= 186360 And valu_exp_scientist.Value < 225300 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(23)
        ElseIf valu_exp_scientist.Value >= 225300 And valu_exp_scientist.Value < 270610 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(24)
        ElseIf valu_exp_scientist.Value >= 270610 And valu_exp_scientist.Value < 315920 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(25)
        ElseIf valu_exp_scientist.Value >= 315920 And valu_exp_scientist.Value < 361230 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(26)
        ElseIf valu_exp_scientist.Value >= 361230 And valu_exp_scientist.Value < 406540 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(27)
        ElseIf valu_exp_scientist.Value >= 406540 And valu_exp_scientist.Value < 451850 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(28)
        ElseIf valu_exp_scientist.Value >= 451850 And valu_exp_scientist.Value < 497160 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(29)
        ElseIf valu_exp_scientist.Value >= 497160 And valu_exp_scientist.Value < 545590 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(30)
        ElseIf valu_exp_scientist.Value >= 545590 And valu_exp_scientist.Value < 599690 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(31)
        ElseIf valu_exp_scientist.Value >= 599690 And valu_exp_scientist.Value < 659900 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(32)
        ElseIf valu_exp_scientist.Value >= 659900 And valu_exp_scientist.Value < 726690 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(33)
        ElseIf valu_exp_scientist.Value >= 726690 And valu_exp_scientist.Value < 800540 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(34)
        ElseIf valu_exp_scientist.Value >= 800540 And valu_exp_scientist.Value < 881950 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(35)
        ElseIf valu_exp_scientist.Value >= 881950 And valu_exp_scientist.Value < 971440 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(36)
        ElseIf valu_exp_scientist.Value >= 971440 And valu_exp_scientist.Value < 1069540 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(37)
        ElseIf valu_exp_scientist.Value >= 1069540 And valu_exp_scientist.Value < 1176790 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(38)
        ElseIf valu_exp_scientist.Value >= 1176790 And valu_exp_scientist.Value < 1293750 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(39)
        ElseIf valu_exp_scientist.Value >= 1293750 And valu_exp_scientist.Value < 1420990 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(40)
        ElseIf valu_exp_scientist.Value >= 1420990 And valu_exp_scientist.Value < 1559090 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(41)
        ElseIf valu_exp_scientist.Value >= 1559090 And valu_exp_scientist.Value < 1708640 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(42)
        ElseIf valu_exp_scientist.Value >= 1708640 And valu_exp_scientist.Value < 1870250 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(43)
        ElseIf valu_exp_scientist.Value >= 1870250 And valu_exp_scientist.Value < 2044530 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(44)
        ElseIf valu_exp_scientist.Value >= 2044530 And valu_exp_scientist.Value < 2232090 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(45)
        ElseIf valu_exp_scientist.Value >= 2232090 And valu_exp_scientist.Value < 2448870 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(46)
        ElseIf valu_exp_scientist.Value >= 2448870 And valu_exp_scientist.Value < 2698120 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(47)
        ElseIf valu_exp_scientist.Value >= 2698120 And valu_exp_scientist.Value < 2983350 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(48)
        ElseIf valu_exp_scientist.Value >= 2983350 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_cat_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_cat.ValueChanged
        If valu_exp_cat.Value > 0 And valu_exp_cat.Value < 10 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(0)
        ElseIf valu_exp_cat.Value >= 10 And valu_exp_cat.Value < 50 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(1)
        ElseIf valu_exp_cat.Value >= 50 And valu_exp_cat.Value < 150 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(2)
        ElseIf valu_exp_cat.Value >= 150 And valu_exp_cat.Value < 340 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(3)
        ElseIf valu_exp_cat.Value >= 340 And valu_exp_cat.Value < 650 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(4)
        ElseIf valu_exp_cat.Value >= 650 And valu_exp_cat.Value < 1140 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(5)
        ElseIf valu_exp_cat.Value >= 1140 And valu_exp_cat.Value < 1870 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(6)
        ElseIf valu_exp_cat.Value >= 1870 And valu_exp_cat.Value < 2920 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(7)
        ElseIf valu_exp_cat.Value >= 2920 And valu_exp_cat.Value < 4390 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(8)
        ElseIf valu_exp_cat.Value >= 4390 And valu_exp_cat.Value < 6390 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(9)
        ElseIf valu_exp_cat.Value >= 6390 And valu_exp_cat.Value < 9060 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(10)
        ElseIf valu_exp_cat.Value >= 9060 And valu_exp_cat.Value < 12570 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(11)
        ElseIf valu_exp_cat.Value >= 12570 And valu_exp_cat.Value < 17120 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(12)
        ElseIf valu_exp_cat.Value >= 17120 And valu_exp_cat.Value < 22920 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(13)
        ElseIf valu_exp_cat.Value >= 22920 And valu_exp_cat.Value < 30230 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(14)
        ElseIf valu_exp_cat.Value >= 30230 And valu_exp_cat.Value < 39340 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(15)
        ElseIf valu_exp_cat.Value >= 39340 And valu_exp_cat.Value < 50580 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(16)
        ElseIf valu_exp_cat.Value >= 50580 And valu_exp_cat.Value < 64320 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(17)
        ElseIf valu_exp_cat.Value >= 64320 And valu_exp_cat.Value < 80960 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(18)
        ElseIf valu_exp_cat.Value >= 80960 And valu_exp_cat.Value < 100960 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(19)
        ElseIf valu_exp_cat.Value >= 100960 And valu_exp_cat.Value < 124820 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(20)
        ElseIf valu_exp_cat.Value >= 124820 And valu_exp_cat.Value < 153090 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(21)
        ElseIf valu_exp_cat.Value >= 153090 And valu_exp_cat.Value < 186360 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(22)
        ElseIf valu_exp_cat.Value >= 186360 And valu_exp_cat.Value < 225300 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(23)
        ElseIf valu_exp_cat.Value >= 225300 And valu_exp_cat.Value < 270610 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(24)
        ElseIf valu_exp_cat.Value >= 270610 And valu_exp_cat.Value < 315920 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(25)
        ElseIf valu_exp_cat.Value >= 315920 And valu_exp_cat.Value < 361230 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(26)
        ElseIf valu_exp_cat.Value >= 361230 And valu_exp_cat.Value < 406540 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(27)
        ElseIf valu_exp_cat.Value >= 406540 And valu_exp_cat.Value < 451850 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(28)
        ElseIf valu_exp_cat.Value >= 451850 And valu_exp_cat.Value < 497160 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(29)
        ElseIf valu_exp_cat.Value >= 497160 And valu_exp_cat.Value < 545590 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(30)
        ElseIf valu_exp_cat.Value >= 545590 And valu_exp_cat.Value < 599690 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(31)
        ElseIf valu_exp_cat.Value >= 599690 And valu_exp_cat.Value < 659900 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(32)
        ElseIf valu_exp_cat.Value >= 659900 And valu_exp_cat.Value < 726690 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(33)
        ElseIf valu_exp_cat.Value >= 726690 And valu_exp_cat.Value < 800540 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(34)
        ElseIf valu_exp_cat.Value >= 800540 And valu_exp_cat.Value < 881950 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(35)
        ElseIf valu_exp_cat.Value >= 881950 And valu_exp_cat.Value < 971440 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(36)
        ElseIf valu_exp_cat.Value >= 971440 And valu_exp_cat.Value < 1069540 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(37)
        ElseIf valu_exp_cat.Value >= 1069540 And valu_exp_cat.Value < 1176790 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(38)
        ElseIf valu_exp_cat.Value >= 1176790 And valu_exp_cat.Value < 1293750 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(39)
        ElseIf valu_exp_cat.Value >= 1293750 And valu_exp_cat.Value < 1420990 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(40)
        ElseIf valu_exp_cat.Value >= 1420990 And valu_exp_cat.Value < 1559090 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(41)
        ElseIf valu_exp_cat.Value >= 1559090 And valu_exp_cat.Value < 1708640 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(42)
        ElseIf valu_exp_cat.Value >= 1708640 And valu_exp_cat.Value < 1870250 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(43)
        ElseIf valu_exp_cat.Value >= 1870250 And valu_exp_cat.Value < 2044530 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(44)
        ElseIf valu_exp_cat.Value >= 2044530 And valu_exp_cat.Value < 2232090 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(45)
        ElseIf valu_exp_cat.Value >= 2232090 And valu_exp_cat.Value < 2448870 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(46)
        ElseIf valu_exp_cat.Value >= 2448870 And valu_exp_cat.Value < 2698120 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(47)
        ElseIf valu_exp_cat.Value >= 2698120 And valu_exp_cat.Value < 2983350 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(48)
        ElseIf valu_exp_cat.Value >= 2983350 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_elf_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_elf.ValueChanged
        If valu_exp_elf.Value > 0 And valu_exp_elf.Value < 10 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(0)
        ElseIf valu_exp_elf.Value >= 10 And valu_exp_elf.Value < 50 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(1)
        ElseIf valu_exp_elf.Value >= 50 And valu_exp_elf.Value < 150 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(2)
        ElseIf valu_exp_elf.Value >= 150 And valu_exp_elf.Value < 340 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(3)
        ElseIf valu_exp_elf.Value >= 340 And valu_exp_elf.Value < 650 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(4)
        ElseIf valu_exp_elf.Value >= 650 And valu_exp_elf.Value < 1140 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(5)
        ElseIf valu_exp_elf.Value >= 1140 And valu_exp_elf.Value < 1870 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(6)
        ElseIf valu_exp_elf.Value >= 1870 And valu_exp_elf.Value < 2920 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(7)
        ElseIf valu_exp_elf.Value >= 2920 And valu_exp_elf.Value < 4390 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(8)
        ElseIf valu_exp_elf.Value >= 4390 And valu_exp_elf.Value < 6390 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(9)
        ElseIf valu_exp_elf.Value >= 6390 And valu_exp_elf.Value < 9060 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(10)
        ElseIf valu_exp_elf.Value >= 9060 And valu_exp_elf.Value < 12570 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(11)
        ElseIf valu_exp_elf.Value >= 12570 And valu_exp_elf.Value < 17120 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(12)
        ElseIf valu_exp_elf.Value >= 17120 And valu_exp_elf.Value < 22920 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(13)
        ElseIf valu_exp_elf.Value >= 22920 And valu_exp_elf.Value < 30230 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(14)
        ElseIf valu_exp_elf.Value >= 30230 And valu_exp_elf.Value < 39340 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(15)
        ElseIf valu_exp_elf.Value >= 39340 And valu_exp_elf.Value < 50580 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(16)
        ElseIf valu_exp_elf.Value >= 50580 And valu_exp_elf.Value < 64320 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(17)
        ElseIf valu_exp_elf.Value >= 64320 And valu_exp_elf.Value < 80960 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(18)
        ElseIf valu_exp_elf.Value >= 80960 And valu_exp_elf.Value < 100960 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(19)
        ElseIf valu_exp_elf.Value >= 100960 And valu_exp_elf.Value < 124820 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(20)
        ElseIf valu_exp_elf.Value >= 124820 And valu_exp_elf.Value < 153090 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(21)
        ElseIf valu_exp_elf.Value >= 153090 And valu_exp_elf.Value < 186360 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(22)
        ElseIf valu_exp_elf.Value >= 186360 And valu_exp_elf.Value < 225300 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(23)
        ElseIf valu_exp_elf.Value >= 225300 And valu_exp_elf.Value < 270610 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(24)
        ElseIf valu_exp_elf.Value >= 270610 And valu_exp_elf.Value < 315920 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(25)
        ElseIf valu_exp_elf.Value >= 315920 And valu_exp_elf.Value < 361230 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(26)
        ElseIf valu_exp_elf.Value >= 361230 And valu_exp_elf.Value < 406540 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(27)
        ElseIf valu_exp_elf.Value >= 406540 And valu_exp_elf.Value < 451850 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(28)
        ElseIf valu_exp_elf.Value >= 451850 And valu_exp_elf.Value < 497160 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(29)
        ElseIf valu_exp_elf.Value >= 497160 And valu_exp_elf.Value < 545590 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(30)
        ElseIf valu_exp_elf.Value >= 545590 And valu_exp_elf.Value < 599690 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(31)
        ElseIf valu_exp_elf.Value >= 599690 And valu_exp_elf.Value < 659900 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(32)
        ElseIf valu_exp_elf.Value >= 659900 And valu_exp_elf.Value < 726690 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(33)
        ElseIf valu_exp_elf.Value >= 726690 And valu_exp_elf.Value < 800540 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(34)
        ElseIf valu_exp_elf.Value >= 800540 And valu_exp_elf.Value < 881950 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(35)
        ElseIf valu_exp_elf.Value >= 881950 And valu_exp_elf.Value < 971440 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(36)
        ElseIf valu_exp_elf.Value >= 971440 And valu_exp_elf.Value < 1069540 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(37)
        ElseIf valu_exp_elf.Value >= 1069540 And valu_exp_elf.Value < 1176790 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(38)
        ElseIf valu_exp_elf.Value >= 1176790 And valu_exp_elf.Value < 1293750 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(39)
        ElseIf valu_exp_elf.Value >= 1293750 And valu_exp_elf.Value < 1420990 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(40)
        ElseIf valu_exp_elf.Value >= 1420990 And valu_exp_elf.Value < 1559090 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(41)
        ElseIf valu_exp_elf.Value >= 1559090 And valu_exp_elf.Value < 1708640 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(42)
        ElseIf valu_exp_elf.Value >= 1708640 And valu_exp_elf.Value < 1870250 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(43)
        ElseIf valu_exp_elf.Value >= 1870250 And valu_exp_elf.Value < 2044530 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(44)
        ElseIf valu_exp_elf.Value >= 2044530 And valu_exp_elf.Value < 2232090 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(45)
        ElseIf valu_exp_elf.Value >= 2232090 And valu_exp_elf.Value < 2448870 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(46)
        ElseIf valu_exp_elf.Value >= 2448870 And valu_exp_elf.Value < 2698120 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(47)
        ElseIf valu_exp_elf.Value >= 2698120 And valu_exp_elf.Value < 2983350 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(48)
        ElseIf valu_exp_elf.Value >= 2983350 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(49)
        End If
    End Sub

    Private Sub valu_interac_Mii_ValueChanged(sender As Object, e As EventArgs) Handles valu_interac_Mii.ValueChanged
        If valu_interac_Mii.Value = 0 Or valu_interac_Mii.Value > 100 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(0)
        ElseIf valu_interac_Mii.Value = 1 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(1)
        ElseIf valu_interac_Mii.Value = 2 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(2)
        ElseIf valu_interac_Mii.Value = 3 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(3)
        ElseIf valu_interac_Mii.Value = 4 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(4)
        ElseIf valu_interac_Mii.Value = 5 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(5)
        ElseIf valu_interac_Mii.Value = 6 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(6)
        ElseIf valu_interac_Mii.Value = 7 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(7)
        ElseIf valu_interac_Mii.Value = 8 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(8)
        ElseIf valu_interac_Mii.Value = 9 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(9)
        ElseIf valu_interac_Mii.Value = 10 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(10)
        End If
    End Sub
End Class