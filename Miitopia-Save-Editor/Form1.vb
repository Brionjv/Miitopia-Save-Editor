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
    Dim Equipweapon As String
    Dim Equiphat As String
    Dim Equipclothe As String
    Dim Equipweaponap As String
    Dim Equiphatap As String
    Dim Equipclotheap As String
    Dim Relationship As String
    Dim relation1 As String
    Dim relation2 As String
    Dim relation3 As String
    Dim relation4 As String
    Dim relation5 As String
    Dim relation6 As String
    Dim relation7 As String
    Dim relation8 As String
    Dim relation9 As String
    Dim relation10 As String
    Dim relation11 As String
    Dim relation12 As String
    Dim relation13 As String
    Dim relation14 As String
    Dim relation15 As String
    Dim relation16 As String
    Dim relation17 As String
    Dim relation18 As String
    Dim relation19 As String
    Dim relation20 As String
    Dim relation21 As String
    Dim relation22 As String
    Dim relation23 As String
    Dim relation24 As String
    Dim relation25 As String

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

    Public Sub notification()
        If Setting_hidden.Checked = False Then
            Panel_notification.Visible = True
            Timer_notification.Start()
        End If
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

    Public Sub readrelationship()
        Try
            Dim Reader As New PackageIO.Reader(hero, PackageIO.Endian.Little)
            If Select_rela_gMii.SelectedItem = Select_rela_gMii.Items.Item(0) Then
                Reader.Position = Relationship
                relation1 = Reader.Position
                valu_relation_1.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H2
                relation2 = Reader.Position
                valu_relation_2.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H4
                relation3 = Reader.Position
                valu_relation_3.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H6
                relation4 = Reader.Position
                valu_relation_4.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H8
                relation5 = Reader.Position
                valu_relation_5.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HA
                relation6 = Reader.Position
                valu_relation_6.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HC
                relation7 = Reader.Position
                valu_relation_7.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HE
                relation8 = Reader.Position
                valu_relation_8.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H10
                relation9 = Reader.Position
                valu_relation_9.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H12
                relation10 = Reader.Position
                valu_relation_10.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H20
                relation11 = Reader.Position
                valu_relation_11.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H22
                relation12 = Reader.Position
                valu_relation_12.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H24
                relation13 = Reader.Position
                valu_relation_13.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H26
                relation14 = Reader.Position
                valu_relation_14.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H28
                relation15 = Reader.Position
                valu_relation_15.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H2A
                relation16 = Reader.Position
                valu_relation_16.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H2C
                relation17 = Reader.Position
                valu_relation_17.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H2E
                relation18 = Reader.Position
                valu_relation_18.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H30
                relation19 = Reader.Position
                valu_relation_19.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H32
                relation20 = Reader.Position
                valu_relation_20.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H34
                relation21 = Reader.Position
                valu_relation_21.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H36
                relation22 = Reader.Position
                valu_relation_22.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H38
                relation23 = Reader.Position
                valu_relation_23.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H3A
                relation24 = Reader.Position
                valu_relation_24.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H3C
                relation25 = Reader.Position
                valu_relation_25.Value = Reader.ReadUInt16
            ElseIf Select_rela_gMii.SelectedItem = Select_rela_gMii.Items.Item(1) Then
                Reader.Position = Relationship + &H3E
                relation1 = Reader.Position
                valu_relation_1.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H40
                relation2 = Reader.Position
                valu_relation_2.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H42
                relation3 = Reader.Position
                valu_relation_3.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H44
                relation4 = Reader.Position
                valu_relation_4.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H46
                relation5 = Reader.Position
                valu_relation_5.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H48
                relation6 = Reader.Position
                valu_relation_6.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H4A
                relation7 = Reader.Position
                valu_relation_7.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H4C
                relation8 = Reader.Position
                valu_relation_8.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H4E
                relation9 = Reader.Position
                valu_relation_9.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H50
                relation10 = Reader.Position
                valu_relation_10.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H52
                relation11 = Reader.Position
                valu_relation_11.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H54
                relation12 = Reader.Position
                valu_relation_12.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H56
                relation13 = Reader.Position
                valu_relation_13.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H58
                relation14 = Reader.Position
                valu_relation_14.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H5A
                relation15 = Reader.Position
                valu_relation_15.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H5C
                relation16 = Reader.Position
                valu_relation_16.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H5E
                relation17 = Reader.Position
                valu_relation_17.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H60
                relation18 = Reader.Position
                valu_relation_18.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H62
                relation19 = Reader.Position
                valu_relation_19.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H64
                relation20 = Reader.Position
                valu_relation_20.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H66
                relation21 = Reader.Position
                valu_relation_21.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H68
                relation22 = Reader.Position
                valu_relation_22.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H6A
                relation23 = Reader.Position
                valu_relation_23.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H6C
                relation24 = Reader.Position
                valu_relation_24.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H6E
                relation25 = Reader.Position
                valu_relation_25.Value = Reader.ReadUInt16
            ElseIf Select_rela_gMii.SelectedItem = Select_rela_gMii.Items.Item(2) Then
                Reader.Position = Relationship + &H70
                relation1 = Reader.Position
                valu_relation_1.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H72
                relation2 = Reader.Position
                valu_relation_2.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H74
                relation3 = Reader.Position
                valu_relation_3.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H76
                relation4 = Reader.Position
                valu_relation_4.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H78
                relation5 = Reader.Position
                valu_relation_5.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H7A
                relation6 = Reader.Position
                valu_relation_6.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H7C
                relation7 = Reader.Position
                valu_relation_7.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H7E
                relation8 = Reader.Position
                valu_relation_8.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H80
                relation9 = Reader.Position
                valu_relation_9.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H82
                relation10 = Reader.Position
                valu_relation_10.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H84
                relation11 = Reader.Position
                valu_relation_11.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H86
                relation12 = Reader.Position
                valu_relation_12.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H88
                relation13 = Reader.Position
                valu_relation_13.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H8A
                relation14 = Reader.Position
                valu_relation_14.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H8C
                relation15 = Reader.Position
                valu_relation_15.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H8E
                relation16 = Reader.Position
                valu_relation_16.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H90
                relation17 = Reader.Position
                valu_relation_17.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H92
                relation18 = Reader.Position
                valu_relation_18.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H94
                relation19 = Reader.Position
                valu_relation_19.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H96
                relation20 = Reader.Position
                valu_relation_20.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H98
                relation21 = Reader.Position
                valu_relation_21.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H9A
                relation22 = Reader.Position
                valu_relation_22.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H9C
                relation23 = Reader.Position
                valu_relation_23.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &H9E
                relation24 = Reader.Position
                valu_relation_24.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HA0
                relation25 = Reader.Position
                valu_relation_25.Value = Reader.ReadUInt16
            ElseIf Select_rela_gMii.SelectedItem = Select_rela_gMii.Items.Item(3) Then
                Reader.Position = Relationship + &HA2
                relation1 = Reader.Position
                valu_relation_1.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HA4
                relation2 = Reader.Position
                valu_relation_2.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HA6
                relation3 = Reader.Position
                valu_relation_3.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HA8
                relation4 = Reader.Position
                valu_relation_4.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HAA
                relation5 = Reader.Position
                valu_relation_5.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HAC
                relation6 = Reader.Position
                valu_relation_6.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HAE
                relation7 = Reader.Position
                valu_relation_7.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HB0
                relation8 = Reader.Position
                valu_relation_8.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HB2
                relation9 = Reader.Position
                valu_relation_9.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HB4
                relation10 = Reader.Position
                valu_relation_10.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HB6
                relation11 = Reader.Position
                valu_relation_11.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HB8
                relation12 = Reader.Position
                valu_relation_12.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HBA
                relation13 = Reader.Position
                valu_relation_13.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HBC
                relation14 = Reader.Position
                valu_relation_14.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HBE
                relation15 = Reader.Position
                valu_relation_15.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HC0
                relation16 = Reader.Position
                valu_relation_16.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HC2
                relation17 = Reader.Position
                valu_relation_17.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HC4
                relation18 = Reader.Position
                valu_relation_18.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HC6
                relation19 = Reader.Position
                valu_relation_19.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HC8
                relation20 = Reader.Position
                valu_relation_20.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HCA
                relation21 = Reader.Position
                valu_relation_21.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HCC
                relation22 = Reader.Position
                valu_relation_22.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HCE
                relation23 = Reader.Position
                valu_relation_23.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HD0
                relation24 = Reader.Position
                valu_relation_24.Value = Reader.ReadUInt16
                Reader.Position = Relationship + &HD2
                relation25 = Reader.Position
                valu_relation_25.Value = Reader.ReadUInt16
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : Read relationship"
                fdialog.Msg.Text = "An error has occured"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Lecture relations"
                fdialog.Msg.Text = "Une erreur est survenue"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Public Sub writerelationship()
        Try
            Dim writer As New PackageIO.Writer(hero, PackageIO.Endian.Little)
            writer.Position = relation1
            writer.WriteUInt16(valu_relation_1.Value)
            writer.Position = relation2
            writer.WriteUInt16(valu_relation_2.Value)
            writer.Position = relation3
            writer.WriteUInt16(valu_relation_3.Value)
            writer.Position = relation4
            writer.WriteUInt16(valu_relation_4.Value)
            writer.Position = relation5
            writer.WriteUInt16(valu_relation_5.Value)
            writer.Position = relation6
            writer.WriteUInt16(valu_relation_6.Value)
            writer.Position = relation7
            writer.WriteUInt16(valu_relation_7.Value)
            writer.Position = relation8
            writer.WriteUInt16(valu_relation_8.Value)
            writer.Position = relation9
            writer.WriteUInt16(valu_relation_9.Value)
            writer.Position = relation10
            writer.WriteUInt16(valu_relation_10.Value)
            writer.Position = relation11
            writer.WriteUInt16(valu_relation_11.Value)
            writer.Position = relation12
            writer.WriteUInt16(valu_relation_12.Value)
            writer.Position = relation13
            writer.WriteUInt16(valu_relation_13.Value)
            writer.Position = relation14
            writer.WriteUInt16(valu_relation_14.Value)
            writer.Position = relation15
            writer.WriteUInt16(valu_relation_15.Value)
            writer.Position = relation16
            writer.WriteUInt16(valu_relation_16.Value)
            writer.Position = relation17
            writer.WriteUInt16(valu_relation_17.Value)
            writer.Position = relation18
            writer.WriteUInt16(valu_relation_18.Value)
            writer.Position = relation19
            writer.WriteUInt16(valu_relation_19.Value)
            writer.Position = relation20
            writer.WriteUInt16(valu_relation_20.Value)
            writer.Position = relation21
            writer.WriteUInt16(valu_relation_21.Value)
            writer.Position = relation22
            writer.WriteUInt16(valu_relation_22.Value)
            writer.Position = relation23
            writer.WriteUInt16(valu_relation_23.Value)
            writer.Position = relation24
            writer.WriteUInt16(valu_relation_24.Value)
            writer.Position = relation25
            writer.WriteUInt16(valu_relation_25.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : Write relationship"
                fdialog.Msg.Text = "An error has occured"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Écriture relations"
                fdialog.Msg.Text = "Une erreur est survenue"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Public Sub selectlanguage()
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            text_open.Text = "Open"
            text_save.Text = "Save"
            Text_menu_buttonH.Text = "Menu"
            Text_menu_buttonS.Text = "Menu"
            Menu_text_settings.Text = "Settings"
            Tab_common_main.Text = "Main"
            Tab_common_ency.Text = "Encyclopedia"
            Tab_common_extras.Text = "Extras"
            Panel_partyworld.Text = "Party is in world"
            Panel_partylevel.Text = "Party is in level"
            Group_party.Text = "Party is in"
            Group_safespot.Text = "Safe spot"
            Text_rescued.Text = "Rescued :"
            Text_open_hero.Text = "Open"
            Text_save_hero.Text = "Save"
            Tab_hero_Miiedit.Text = "Mii edition"
            Tab_hero_Inn.Text = "Inn"
            Tab_hero_Levboost.Text = "Levels / Boosts"
            Group_hero_equip.Text = "Equiped equipments"
            Group_hero_equipapp.Text = "Appearance equipments"
            Text_showstats.Text = "Show stats"
            Text_showequipments.Text = "Show equipments"
            Group_warcry.Text = "War cry"
            Text_battles.Text = "Battles"
            Text__fblows.Text = "Final blows"
            Text_defeats.Text = "Defeats"
            Text_tlooparty.Text = "Times left out of party"
            Text_hbgobbled.Text = "HP Bananas gobbled"
            Text_mcgulped.Text = "MP Candies gulped"
            Text_ggrubbed.Text = "Grub grubbed"
            Text_ggrabbed.Text = "Gold grabbed"
            Select_personnality.Items.Item(0) = "Kind"
            Select_personnality.Items.Item(1) = "Energetic"
            Select_personnality.Items.Item(2) = "Laid-back"
            Select_personnality.Items.Item(3) = "Cool"
            Select_personnality.Items.Item(4) = "Stubborn"
            Select_personnality.Items.Item(5) = "Airheaded"
            Select_personnality.Items.Item(6) = "Cautious"
            Select_pose.Items.Item(0) = "Pose 1"
            Select_pose.Items.Item(1) = "Pose 2"
            Select_pose.Items.Item(2) = "Pose 3"
            Select_pose.Items.Item(3) = "Pose 4"
            Select_pose.Items.Item(4) = "Pose 5"
            Select_pose.Items.Item(5) = "Pose 6"
            Select_pose.Items.Item(6) = "Pose 7"
            Select_pose.Items.Item(7) = "Pose 8"
            Select_pose.Items.Item(8) = "Pose 9"
            Select_pose.Items.Item(9) = "Pose 10"
            Select_pose.Items.Item(10) = "Pose 11"
            Select_pose.Items.Item(11) = "Pose 12"
            Select_pose.Items.Item(12) = "???"
            Group_health.Text = "Health"
            Text_hero_for.Text = "for"
            Text_hero_days.Text = "days"
            Group_interaction.Text = "Interaction"
            Text_hero_with.Text = "with"
            Text_hero_for_2.Text = "for"
            Tab_ency_weap.Text = "Weapons"
            Tab_ency_cost.Text = "Costumes"
            Select_sick.Items.Item(0) = "Not sick"
            Select_sick.Items.Item(1) = "Sick"
            Select_interac_Mii.Items.Item(0) = "(None)"
            Group_hero_bHP.Text = "Boost HP"
            Group_hero_bMP.Text = "Boost MP"
            Group_hero_batk.Text = "Boost attack"
            Group_hero_bdef.Text = "Boost defense"
            Group_hero_bmgc.Text = "Boost magic"
            Group_hero_bspd.Text = "Boost speed"
            Tab_quest_main.Text = "Main"
            Setting_music.Text = "Active background music"
            Setting_ckupdate.Text = "Unactive check updates"
            Setting_filepath.Text = "Show file path"
            Setting_hidden.Text = "Show hidden things"
            Group_settings.Text = "Settings"
            Text_language.Text = "Language"
            Tab_settings.Text = "Settings"
            Tab_changelog.Text = "Changelog"
            Tab_credits.Text = "Credits"
            Group_changelog.Text = "Changelog"
            Group_credits.Text = "Credits"
            Text_open_quest.Text = "Open"
            Text_save_quest.Text = "Save"
            Select_interac_activity.Items.Item(0) = "You talk in your sleep!"
            Select_interac_activity.Items.Item(1) = "There was a bug on your face!"
            Select_interac_activity.Items.Item(2) = "Sit-ups"
            Select_interac_activity.Items.Item(3) = "Push-ups"
            Select_interac_activity.Items.Item(4) = "Sidestepping"
            Select_interac_activity.Items.Item(5) = "Who do you like?"
            Select_interac_activity.Items.Item(6) = "So do you like anyone?"
            Select_interac_activity.Items.Item(7) = "You should tell me who you like."
            Select_interac_activity.Items.Item(8) = "Who do you like? Tell me!"
            Select_interac_activity.Items.Item(9) = "Tell me the name of the person you like."
            Select_interac_activity.Items.Item(10) = "Rules: Keep the world clean"
            Select_interac_activity.Items.Item(11) = "Rules: No painting"
            Select_interac_activity.Items.Item(12) = "Rules: Ignore the whispers"
            Select_interac_activity.Items.Item(13) = "Get well soon!"
            Select_interac_activity.Items.Item(14) = "Rest as long as you need."
            Select_interac_activity.Items.Item(15) = "How are you feeling?"
            Select_interac_activity.Items.Item(16) = "Dual Quarrel: I'm sorry."
            Select_interac_activity.Items.Item(17) = "Dual Quarrel: I think we should be friends again."
            Select_interac_activity.Items.Item(18) = "Quarrel: I'm sorry for being so mean."
            Select_interac_activity.Items.Item(19) = "??? (Change00)"
            Select_interac_activity.Items.Item(20) = "??? (ChangeCold)"
            Select_interac_activity.Items.Item(21) = "??? (ChangeRepair)"
            Select_interac_activity.Items.Item(22) = "Rumor"
            Select_interac_activity.Items.Item(23) = "??? (GameEnd00)"
            Select_interac_activity.Items.Item(24) = "??? (GameEnd01)"
            Select_interac_activity.Items.Item(25) = "Fond memory"
            Select_interac_activity.Items.Item(26) = "Singing (Greenhorne)"
            Select_interac_activity.Items.Item(27) = "Singing (???)"
            Select_interac_activity.Items.Item(28) = "Cleaning (Thank you!)"
            Select_interac_activity.Items.Item(29) = "Cleaning (I can help!)"
            Select_interac_activity.Items.Item(30) = "Cleaning (Cheering)"
            Select_interac_activity.Items.Item(31) = "Time for a new look!"
            Select_interac_activity.Items.Item(32) = "Impressions"
            Text_notification.Text = "Done"
            Check_medal_unlock.Text = "Unlock"
            Check_medal_reset.Text = "Reset"
            Check_music_unlock.Text = "Unlock"
            Check_music_reset.Text = "Reset"
            Check_foods_unlock.Text = "Unlock"
            Check_foods_reset.Text = "Reset"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            text_open.Text = "Ouvrir"
            text_save.Text = "Enregistrer"
            Text_menu_buttonH.Text = "Menu"
            Text_menu_buttonS.Text = "Menu"
            Menu_text_settings.Text = "Paramètres"
            Tab_common_main.Text = "Principal"
            Tab_common_ency.Text = "Encyclopédie"
            Tab_common_extras.Text = "Extras"
            Panel_partyworld.Text = "L'équipe est dans le monde"
            Panel_partylevel.Text = "L'équipe est dans le niveau"
            Group_party.Text = "L'équipe est dans"
            Group_safespot.Text = "Abri"
            Text_rescued.Text = "Sauvés :"
            Text_open_hero.Text = "Ouvrir"
            Text_save_hero.Text = "Enregistrer"
            Tab_hero_Miiedit.Text = "Édition Mii"
            Tab_hero_Inn.Text = "Auberge"
            Tab_hero_Levboost.Text = "Niveaux / Boosts"
            Group_hero_equip.Text = "Équipements équipés"
            Group_hero_equipapp.Text = "Apparance équipements"
            Text_showstats.Text = "Afficher stats"
            Text_showequipments.Text = "Afficher équipements"
            Group_warcry.Text = "Cri de guerre"
            Text_battles.Text = "Combats"
            Text__fblows.Text = "Coups de grâce"
            Text_defeats.Text = "Défaites"
            Text_tlooparty.Text = "Fois hors de l'équipe"
            Text_hbgobbled.Text = "Bananes PV dévorées"
            Text_mcgulped.Text = "Bonbons PM avalés"
            Text_ggrubbed.Text = "Vivres engloutis"
            Text_ggrabbed.Text = "Argent dépensé"
            Select_personnality.Items.Item(0) = "Gentil"
            Select_personnality.Items.Item(1) = "Énergique"
            Select_personnality.Items.Item(2) = "Relax"
            Select_personnality.Items.Item(3) = "Assuré"
            Select_personnality.Items.Item(4) = "Déterminé"
            Select_personnality.Items.Item(5) = "Rêveur"
            Select_personnality.Items.Item(6) = "Prudent"
            Select_pose.Items.Item(0) = "Pose 1"
            Select_pose.Items.Item(1) = "Pose 2"
            Select_pose.Items.Item(2) = "Pose 3"
            Select_pose.Items.Item(3) = "Pose 4"
            Select_pose.Items.Item(4) = "Pose 5"
            Select_pose.Items.Item(5) = "Pose 6"
            Select_pose.Items.Item(6) = "Pose 7"
            Select_pose.Items.Item(7) = "Pose 8"
            Select_pose.Items.Item(8) = "Pose 9"
            Select_pose.Items.Item(9) = "Pose 10"
            Select_pose.Items.Item(10) = "Pose 11"
            Select_pose.Items.Item(11) = "Pose 12"
            Select_pose.Items.Item(12) = "???"
            Group_health.Text = "Santé"
            Text_hero_for.Text = "pour"
            Text_hero_days.Text = "jours"
            Group_interaction.Text = "Interaction"
            Text_hero_with.Text = "avec"
            Text_hero_for_2.Text = "pour"
            Tab_ency_weap.Text = "Armes"
            Tab_ency_cost.Text = "Costumes"
            Select_sick.Items.Item(0) = "Pas malade"
            Select_sick.Items.Item(1) = "Malade"
            Select_interac_Mii.Items.Item(0) = "(Aucun)"
            Group_hero_bHP.Text = "Boost PV"
            Group_hero_bMP.Text = "Boost PM"
            Group_hero_batk.Text = "Boost attaque"
            Group_hero_bdef.Text = "Boost défense"
            Group_hero_bmgc.Text = "Boost magie"
            Group_hero_bspd.Text = "Boost vitesse"
            Tab_quest_main.Text = "Principal"
            Setting_music.Text = "Activer la musique de fond"
            Setting_ckupdate.Text = "Désactiver la vérification des mises à jour"
            Setting_filepath.Text = "Afficher le chemin du fichier"
            Setting_hidden.Text = "Afficher les éléments cachés"
            Group_settings.Text = "Paramètres"
            Text_language.Text = "Langage"
            Tab_settings.Text = "Paramètres"
            Tab_changelog.Text = "Changelog"
            Tab_credits.Text = "Crédits"
            Group_changelog.Text = "Changelog"
            Group_credits.Text = "Crédits"
            Text_open_quest.Text = "Ouvrir"
            Text_save_quest.Text = "Enregistrer"
            Select_interac_activity.Items.Item(0) = "Tu parles dans ton sommeil !"
            Select_interac_activity.Items.Item(1) = "Il y avait un insecte sur ton visage !"
            Select_interac_activity.Items.Item(2) = "Place à l’entraînement ! (Abdos)"
            Select_interac_activity.Items.Item(3) = "Place à l’entraînement ! (Pompes)"
            Select_interac_activity.Items.Item(4) = "Place à l’entraînement ! (Danse)"
            Select_interac_activity.Items.Item(5) = "Qui aimes-tu ?"
            Select_interac_activity.Items.Item(6) = "Alors tu aimes quelqu'un ?"
            Select_interac_activity.Items.Item(7) = "Tu devrais me dire qui tu aimes."
            Select_interac_activity.Items.Item(8) = "Qui aimes-tu ? Dit-moi !"
            Select_interac_activity.Items.Item(9) = "Dit-moi le nom de la personne que tu aimes."
            Select_interac_activity.Items.Item(10) = "Règles: Gardez le monde propre"
            Select_interac_activity.Items.Item(11) = "Règles: Tout ranger"
            Select_interac_activity.Items.Item(12) = "Règles: Pas faire de bruit"
            Select_interac_activity.Items.Item(13) = "J’espère que tu seras vite sur pieds"
            Select_interac_activity.Items.Item(14) = "Repose toi aussi longtemps que tu as besoin."
            Select_interac_activity.Items.Item(15) = "Comment  tu te sens ?"
            Select_interac_activity.Items.Item(16) = "Double Querelle: Je suis désolé."
            Select_interac_activity.Items.Item(17) = "Double Querelle: Je pense que nous devrions être amis à nouveau."
            Select_interac_activity.Items.Item(18) = "Querelle: Je suis désolé d'avoir été si méchant."
            Select_interac_activity.Items.Item(19) = "??? (Changer00)"
            Select_interac_activity.Items.Item(20) = "??? (ChangeFroid)"
            Select_interac_activity.Items.Item(21) = "??? (ChangeRéparer)"
            Select_interac_activity.Items.Item(22) = "Rumeur"
            Select_interac_activity.Items.Item(23) = "??? (FindeJeu00)"
            Select_interac_activity.Items.Item(24) = "??? (FindeJeu01)"
            Select_interac_activity.Items.Item(25) = "Mémoire de fond"
            Select_interac_activity.Items.Item(26) = "Chant (Plaine d'Udébu)"
            Select_interac_activity.Items.Item(27) = "Chant (???)"
            Select_interac_activity.Items.Item(28) = "Nettoyage (merci!)"
            Select_interac_activity.Items.Item(29) = "Nettoyage (je peux aider!)"
            Select_interac_activity.Items.Item(30) = "Nettoyage (Acclamations)"
            Select_interac_activity.Items.Item(31) = "Il est temps pour un nouveau look!"
            Select_interac_activity.Items.Item(32) = "Impressions"
            Text_notification.Text = "Terminé"
            Check_medal_unlock.Text = "Débloquer"
            Check_medal_reset.Text = "Réinitialiser"
            Check_music_unlock.Text = "Débloquer"
            Check_music_reset.Text = "Réinitialiser"
            Check_foods_unlock.Text = "Débloquer"
            Check_foods_reset.Text = "Réinitialiser"
        End If
    End Sub

    Public Sub Checkupdates()
        If Setting_ckupdate.Checked = False Then
            Try
                Dim MAJ As New WebClient
                Dim lastupdate As String = MAJ.DownloadString("https://raw.githubusercontent.com/Brionjv/Miitopia-Save-Editor/master/Version.txt")
                If Label7.Text = lastupdate Then
                    MSE_icon.Visible = True
                    MSE_iconupdate.Visible = False
                Else
                    MSE_icon.Visible = False
                    MSE_iconupdate.Visible = True
                    If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                        fdialog.Title.Text = "Miitopia Save Editor : Update"
                        fdialog.Msg.Text = "An update is avalible, click on Miitopia Save Editor icon to download new version"
                        fdialog.ShowDialog()
                    ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                        fdialog.Title.Text = "Miitopia Save Editor : Mise à jour"
                        fdialog.Msg.Text = "Une mise à jour est disponible, cliquez sur l'icone de Miitopia Save Editor pour télécharger la nouvelle version"
                        fdialog.ShowDialog()
                    End If
                End If
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    fdialog.Title.Text = "Miitopia Save Editor : Update"
                    fdialog.Msg.Text = "An error has occured"
                    fdialog.ShowDialog()
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    fdialog.Title.Text = "Miitopia Save Editor : Mise à jour"
                    fdialog.Msg.Text = "Une erreur est survenue"
                    fdialog.ShowDialog()
                End If
            End Try
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

    Public Sub readequipements()
        Try
            Dim Reader As New PackageIO.Reader(hero, PackageIO.Endian.Little)
            If Filever_text.Text = "US" Or Filever_text.Text = "EU" Then
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(0) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H280
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H280 + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H280 + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H280 + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H280 + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H280 + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H280 + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H280 + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H280 + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H280 + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H280 + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H280 + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H280 + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H280 + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H280 + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(1) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H280 + &H398
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H280 + &H398 + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398 + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398 + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H280 + &H398 + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398 + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398 + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H280 + &H398 + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398 + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398 + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H280 + &H398 + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398 + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398 + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H280 + &H398 + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398 + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398 + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H280 + &H398 + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398 + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398 + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H280 + &H398 + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398 + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398 + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H280 + &H398 + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398 + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398 + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H280 + &H398 + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398 + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398 + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H280 + &H398 + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398 + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398 + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H280 + &H398 + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398 + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398 + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H280 + &H398 + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398 + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398 + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H280 + &H398 + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398 + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398 + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H280 + &H398 + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + &H398 + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + &H398 + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H280 + (&H398 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H280 + (&H398 * 2) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H280 + (&H398 * 2) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H280 + (&H398 * 2) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H280 + (&H398 * 2) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H280 + (&H398 * 2) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H280 + (&H398 * 2) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H280 + (&H398 * 2) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H280 + (&H398 * 2) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H280 + (&H398 * 2) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H280 + (&H398 * 2) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H280 + (&H398 * 2) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H280 + (&H398 * 2) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H280 + (&H398 * 2) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H280 + (&H398 * 2) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 2) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 2) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(3) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H280 + (&H398 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H280 + (&H398 * 3) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H280 + (&H398 * 3) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H280 + (&H398 * 3) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H280 + (&H398 * 3) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H280 + (&H398 * 3) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H280 + (&H398 * 3) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H280 + (&H398 * 3) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H280 + (&H398 * 3) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H280 + (&H398 * 3) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H280 + (&H398 * 3) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H280 + (&H398 * 3) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H280 + (&H398 * 3) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H280 + (&H398 * 3) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H280 + (&H398 * 3) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 3) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 3) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(4) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H280 + (&H398 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H280 + (&H398 * 4) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H280 + (&H398 * 4) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H280 + (&H398 * 4) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H280 + (&H398 * 4) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H280 + (&H398 * 4) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H280 + (&H398 * 4) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H280 + (&H398 * 4) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H280 + (&H398 * 4) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H280 + (&H398 * 4) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H280 + (&H398 * 4) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H280 + (&H398 * 4) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H280 + (&H398 * 4) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H280 + (&H398 * 4) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H280 + (&H398 * 4) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 4) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 4) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(5) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H280 + (&H398 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H280 + (&H398 * 5) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H280 + (&H398 * 5) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H280 + (&H398 * 5) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H280 + (&H398 * 5) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H280 + (&H398 * 5) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H280 + (&H398 * 5) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H280 + (&H398 * 5) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H280 + (&H398 * 5) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H280 + (&H398 * 5) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H280 + (&H398 * 5) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H280 + (&H398 * 5) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H280 + (&H398 * 5) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H280 + (&H398 * 5) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H280 + (&H398 * 5) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 5) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 5) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(6) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H280 + (&H398 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H280 + (&H398 * 6) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H280 + (&H398 * 6) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H280 + (&H398 * 6) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H280 + (&H398 * 6) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H280 + (&H398 * 6) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H280 + (&H398 * 6) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H280 + (&H398 * 6) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H280 + (&H398 * 6) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H280 + (&H398 * 6) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H280 + (&H398 * 6) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H280 + (&H398 * 6) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H280 + (&H398 * 6) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H280 + (&H398 * 6) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H280 + (&H398 * 6) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 6) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 6) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(7) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H280 + (&H398 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H280 + (&H398 * 7) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H280 + (&H398 * 7) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H280 + (&H398 * 7) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H280 + (&H398 * 7) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H280 + (&H398 * 7) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H280 + (&H398 * 7) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H280 + (&H398 * 7) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H280 + (&H398 * 7) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H280 + (&H398 * 7) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H280 + (&H398 * 7) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H280 + (&H398 * 7) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H280 + (&H398 * 7) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H280 + (&H398 * 7) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H280 + (&H398 * 7) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 7) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 7) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(8) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H280 + (&H398 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H280 + (&H398 * 8) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H280 + (&H398 * 8) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H280 + (&H398 * 8) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H280 + (&H398 * 8) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H280 + (&H398 * 8) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H280 + (&H398 * 8) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H280 + (&H398 * 8) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H280 + (&H398 * 8) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H280 + (&H398 * 8) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H280 + (&H398 * 8) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H280 + (&H398 * 8) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H280 + (&H398 * 8) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H280 + (&H398 * 8) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H280 + (&H398 * 8) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 8) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 8) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(9) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H280 + (&H398 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H280 + (&H398 * 9) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H280 + (&H398 * 9) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H280 + (&H398 * 9) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H280 + (&H398 * 9) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H280 + (&H398 * 9) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H280 + (&H398 * 9) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H280 + (&H398 * 9) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H280 + (&H398 * 9) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H280 + (&H398 * 9) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H280 + (&H398 * 9) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H280 + (&H398 * 9) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H280 + (&H398 * 9) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H280 + (&H398 * 9) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H280 + (&H398 * 9) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H281 + (&H398 * 9) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H282 + (&H398 * 9) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
            End If

            If Filever_text.Text = "JP" Then
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(0) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H260
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H260 + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H260 + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H260 + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H260 + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H260 + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H260 + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H260 + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H260 + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H260 + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H260 + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H260 + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H260 + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H260 + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H260 + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(1) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H260 + &H378
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H260 + &H378 + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378 + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378 + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H260 + &H378 + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378 + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378 + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H260 + &H378 + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378 + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378 + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H260 + &H378 + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378 + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378 + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H260 + &H378 + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378 + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378 + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H260 + &H378 + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378 + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378 + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H260 + &H378 + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378 + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378 + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H260 + &H378 + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378 + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378 + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H260 + &H378 + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378 + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378 + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H260 + &H378 + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378 + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378 + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H260 + &H378 + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378 + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378 + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H260 + &H378 + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378 + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378 + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H260 + &H378 + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378 + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378 + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H260 + &H378 + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + &H378 + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + &H378 + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H260 + (&H378 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H260 + (&H378 * 2) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H260 + (&H378 * 2) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H260 + (&H378 * 2) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H260 + (&H378 * 2) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H260 + (&H378 * 2) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H260 + (&H378 * 2) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H260 + (&H378 * 2) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H260 + (&H378 * 2) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H260 + (&H378 * 2) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H260 + (&H378 * 2) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H260 + (&H378 * 2) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H260 + (&H378 * 2) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H260 + (&H378 * 2) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H260 + (&H378 * 2) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 2) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 2) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(3) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H260 + (&H378 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H260 + (&H378 * 3) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H260 + (&H378 * 3) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H260 + (&H378 * 3) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H260 + (&H378 * 3) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H260 + (&H378 * 3) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H260 + (&H378 * 3) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H260 + (&H378 * 3) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H260 + (&H378 * 3) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H260 + (&H378 * 3) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H260 + (&H378 * 3) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H260 + (&H378 * 3) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H260 + (&H378 * 3) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H260 + (&H378 * 3) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H260 + (&H378 * 3) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 3) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 3) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(4) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H260 + (&H378 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H260 + (&H378 * 4) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H260 + (&H378 * 4) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H260 + (&H378 * 4) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H260 + (&H378 * 4) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H260 + (&H378 * 4) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H260 + (&H378 * 4) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H260 + (&H378 * 4) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H260 + (&H378 * 4) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H260 + (&H378 * 4) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H260 + (&H378 * 4) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H260 + (&H378 * 4) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H260 + (&H378 * 4) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H260 + (&H378 * 4) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H260 + (&H378 * 4) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 4) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 4) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(5) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H260 + (&H378 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H260 + (&H378 * 5) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H260 + (&H378 * 5) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H260 + (&H378 * 5) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H260 + (&H378 * 5) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H260 + (&H378 * 5) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H260 + (&H378 * 5) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H260 + (&H378 * 5) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H260 + (&H378 * 5) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H260 + (&H378 * 5) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H260 + (&H378 * 5) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H260 + (&H378 * 5) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H260 + (&H378 * 5) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H260 + (&H378 * 5) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H260 + (&H378 * 5) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 5) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 5) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(6) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H260 + (&H378 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H260 + (&H378 * 6) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H260 + (&H378 * 6) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H260 + (&H378 * 6) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H260 + (&H378 * 6) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H260 + (&H378 * 6) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H260 + (&H378 * 6) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H260 + (&H378 * 6) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H260 + (&H378 * 6) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H260 + (&H378 * 6) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H260 + (&H378 * 6) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H260 + (&H378 * 6) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H260 + (&H378 * 6) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H260 + (&H378 * 6) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H260 + (&H378 * 6) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 6) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 6) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(7) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H260 + (&H378 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H260 + (&H378 * 7) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H260 + (&H378 * 7) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H260 + (&H378 * 7) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H260 + (&H378 * 7) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H260 + (&H378 * 7) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H260 + (&H378 * 7) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H260 + (&H378 * 7) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H260 + (&H378 * 7) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H260 + (&H378 * 7) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H260 + (&H378 * 7) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H260 + (&H378 * 7) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H260 + (&H378 * 7) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H260 + (&H378 * 7) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H260 + (&H378 * 7) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 7) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 7) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(8) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H260 + (&H378 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H260 + (&H378 * 8) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H260 + (&H378 * 8) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H260 + (&H378 * 8) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H260 + (&H378 * 8) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H260 + (&H378 * 8) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H260 + (&H378 * 8) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H260 + (&H378 * 8) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H260 + (&H378 * 8) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H260 + (&H378 * 8) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H260 + (&H378 * 8) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H260 + (&H378 * 8) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H260 + (&H378 * 8) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H260 + (&H378 * 8) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H260 + (&H378 * 8) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 8) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 8) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(9) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H260 + (&H378 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H260 + (&H378 * 9) + &H4
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9) + &H4
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9) + &H4
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H260 + (&H378 * 9) + (&H4 * 2)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9) + (&H4 * 2)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9) + (&H4 * 2)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H260 + (&H378 * 9) + (&H4 * 3)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9) + (&H4 * 3)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9) + (&H4 * 3)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H260 + (&H378 * 9) + (&H4 * 4)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9) + (&H4 * 4)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9) + (&H4 * 4)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H260 + (&H378 * 9) + (&H4 * 5)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9) + (&H4 * 5)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9) + (&H4 * 5)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H260 + (&H378 * 9) + (&H4 * 6)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9) + (&H4 * 6)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9) + (&H4 * 6)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H260 + (&H378 * 9) + (&H4 * 7)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9) + (&H4 * 7)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9) + (&H4 * 7)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H260 + (&H378 * 9) + (&H4 * 8)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9) + (&H4 * 8)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9) + (&H4 * 8)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H260 + (&H378 * 9) + (&H4 * 9)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9) + (&H4 * 9)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9) + (&H4 * 9)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H260 + (&H378 * 9) + (&H4 * 10)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9) + (&H4 * 10)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9) + (&H4 * 10)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H260 + (&H378 * 9) + (&H4 * 11)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9) + (&H4 * 11)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9) + (&H4 * 11)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H260 + (&H378 * 9) + (&H4 * 12)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9) + (&H4 * 12)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9) + (&H4 * 12)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H260 + (&H378 * 9) + (&H4 * 13)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9) + (&H4 * 13)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9) + (&H4 * 13)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H260 + (&H378 * 9) + (&H4 * 14)
                        Equipweapon = Reader.Position
                        valu_equip_weapon.Value = Reader.ReadByte
                        Reader.Position = &H261 + (&H378 * 9) + (&H4 * 14)
                        Equiphat = Reader.Position
                        valu_equip_hat.Value = Reader.ReadByte
                        Reader.Position = &H262 + (&H378 * 9) + (&H4 * 14)
                        Equipclothe = Reader.Position
                        valu_equip_clothe.Value = Reader.ReadByte
                    End If
                End If
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : Read equipments"
                fdialog.Msg.Text = "Oops, something goes wrong" & vbNewLine & "reading equipments failed, please report this issue or try again"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Lecture équipements"
                fdialog.Msg.Text = "Oups, quelque chose ne va pas" & vbNewLine & "la lecture des équipements a échoué, veuillez signalez cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If

        End Try
    End Sub

    Public Sub writeequipements()
        Try
            Dim writerx As New System.IO.FileStream(hero, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            writerx.Position = Equipweapon
            writerx.WriteByte(valu_equip_weapon.Value)
            writerx.Position = Equiphat
            writerx.WriteByte(valu_equip_hat.Value)
            writerx.Position = Equipclothe
            writerx.WriteByte(valu_equip_clothe.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : Write equipments"
                fdialog.Msg.Text = "Oops, something goes wrong" & vbNewLine & "writing equipments failed, please report this issue or try again"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Écriture équipements"
                fdialog.Msg.Text = "Oups, quelque chose ne va pas" & vbNewLine & "l'écriture des équipements a échoué, veuillez signalez cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If

        End Try
    End Sub

    Public Sub readequipappearance()
        Try
            Dim Reader As New PackageIO.Reader(hero, PackageIO.Endian.Little)
            If Filever_text.Text = "US" Or Filever_text.Text = "EU" Then
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(0) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H2BC
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H2BC + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H2BC + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H2BC + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H2BC + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H2BC + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H2BC + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H2BC + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H2BC + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H2BC + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H2BC + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H2BC + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H2BC + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H2BC + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H2BC + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(1) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H2BC + &H398
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H2BC + &H398 + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398 + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398 + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H2BC + &H398 + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398 + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398 + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H2BC + &H398 + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398 + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398 + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H2BC + &H398 + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398 + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398 + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H2BC + &H398 + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398 + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398 + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H2BC + &H398 + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398 + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398 + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H2BC + &H398 + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398 + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398 + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H2BC + &H398 + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398 + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398 + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H2BC + &H398 + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398 + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398 + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H2BC + &H398 + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398 + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398 + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H2BC + &H398 + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398 + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398 + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H2BC + &H398 + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398 + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398 + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H2BC + &H398 + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398 + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398 + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H2BC + &H398 + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + &H398 + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + &H398 + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H2BC + (&H398 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H2BC + (&H398 * 2) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H2BC + (&H398 * 2) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H2BC + (&H398 * 2) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H2BC + (&H398 * 2) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H2BC + (&H398 * 2) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H2BC + (&H398 * 2) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H2BC + (&H398 * 2) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H2BC + (&H398 * 2) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H2BC + (&H398 * 2) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H2BC + (&H398 * 2) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H2BC + (&H398 * 2) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H2BC + (&H398 * 2) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H2BC + (&H398 * 2) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H2BC + (&H398 * 2) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 2) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 2) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(3) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H2BC + (&H398 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H2BC + (&H398 * 3) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H2BC + (&H398 * 3) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H2BC + (&H398 * 3) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H2BC + (&H398 * 3) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H2BC + (&H398 * 3) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H2BC + (&H398 * 3) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H2BC + (&H398 * 3) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H2BC + (&H398 * 3) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H2BC + (&H398 * 3) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H2BC + (&H398 * 3) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H2BC + (&H398 * 3) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H2BC + (&H398 * 3) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H2BC + (&H398 * 3) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H2BC + (&H398 * 3) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 3) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 3) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(4) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H2BC + (&H398 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H2BC + (&H398 * 4) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H2BC + (&H398 * 4) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H2BC + (&H398 * 4) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H2BC + (&H398 * 4) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H2BC + (&H398 * 4) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H2BC + (&H398 * 4) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H2BC + (&H398 * 4) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H2BC + (&H398 * 4) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H2BC + (&H398 * 4) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H2BC + (&H398 * 4) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H2BC + (&H398 * 4) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H2BC + (&H398 * 4) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H2BC + (&H398 * 4) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H2BC + (&H398 * 4) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 4) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 4) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(5) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H2BC + (&H398 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H2BC + (&H398 * 5) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H2BC + (&H398 * 5) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H2BC + (&H398 * 5) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H2BC + (&H398 * 5) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H2BC + (&H398 * 5) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H2BC + (&H398 * 5) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H2BC + (&H398 * 5) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H2BC + (&H398 * 5) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H2BC + (&H398 * 5) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H2BC + (&H398 * 5) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H2BC + (&H398 * 5) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H2BC + (&H398 * 5) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H2BC + (&H398 * 5) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H2BC + (&H398 * 5) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 5) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 5) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(6) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H2BC + (&H398 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H2BC + (&H398 * 6) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H2BC + (&H398 * 6) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H2BC + (&H398 * 6) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H2BC + (&H398 * 6) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H2BC + (&H398 * 6) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H2BC + (&H398 * 6) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H2BC + (&H398 * 6) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H2BC + (&H398 * 6) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H2BC + (&H398 * 6) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H2BC + (&H398 * 6) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H2BC + (&H398 * 6) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H2BC + (&H398 * 6) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H2BC + (&H398 * 6) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H2BC + (&H398 * 6) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 6) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 6) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(7) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H2BC + (&H398 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H2BC + (&H398 * 7) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H2BC + (&H398 * 7) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H2BC + (&H398 * 7) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H2BC + (&H398 * 7) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H2BC + (&H398 * 7) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H2BC + (&H398 * 7) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H2BC + (&H398 * 7) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H2BC + (&H398 * 7) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H2BC + (&H398 * 7) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H2BC + (&H398 * 7) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H2BC + (&H398 * 7) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H2BC + (&H398 * 7) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H2BC + (&H398 * 7) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H2BC + (&H398 * 7) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 7) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 7) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(8) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H2BC + (&H398 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H2BC + (&H398 * 8) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H2BC + (&H398 * 8) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H2BC + (&H398 * 8) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H2BC + (&H398 * 8) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H2BC + (&H398 * 8) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H2BC + (&H398 * 8) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H2BC + (&H398 * 8) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H2BC + (&H398 * 8) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H2BC + (&H398 * 8) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H2BC + (&H398 * 8) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H2BC + (&H398 * 8) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H2BC + (&H398 * 8) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H2BC + (&H398 * 8) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H2BC + (&H398 * 8) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 8) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 8) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(9) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H2BC + (&H398 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H2BC + (&H398 * 9) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H2BC + (&H398 * 9) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H2BC + (&H398 * 9) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H2BC + (&H398 * 9) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H2BC + (&H398 * 9) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H2BC + (&H398 * 9) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H2BC + (&H398 * 9) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H2BC + (&H398 * 9) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H2BC + (&H398 * 9) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H2BC + (&H398 * 9) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H2BC + (&H398 * 9) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H2BC + (&H398 * 9) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H2BC + (&H398 * 9) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H2BC + (&H398 * 9) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H2BD + (&H398 * 9) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H2BE + (&H398 * 9) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
            End If

            If Filever_text.Text = "JP" Then
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(0) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H29C
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H29C + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H29C + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H29C + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H29C + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H29C + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H29C + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H29C + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H29C + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H29C + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H29C + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H29C + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H29C + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H29C + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H29C + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(1) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H29C + &H378
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H29C + &H378 + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378 + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378 + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H29C + &H378 + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378 + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378 + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H29C + &H378 + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378 + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378 + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H29C + &H378 + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378 + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378 + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H29C + &H378 + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378 + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378 + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H29C + &H378 + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378 + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378 + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H29C + &H378 + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378 + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378 + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H29C + &H378 + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378 + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378 + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H29C + &H378 + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378 + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378 + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H29C + &H378 + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378 + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378 + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H29C + &H378 + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378 + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378 + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H29C + &H378 + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378 + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378 + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H29C + &H378 + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378 + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378 + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H29C + &H378 + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + &H378 + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + &H378 + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H29C + (&H378 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H29C + (&H378 * 2) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H29C + (&H378 * 2) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H29C + (&H378 * 2) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H29C + (&H378 * 2) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H29C + (&H378 * 2) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H29C + (&H378 * 2) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H29C + (&H378 * 2) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H29C + (&H378 * 2) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H29C + (&H378 * 2) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H29C + (&H378 * 2) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H29C + (&H378 * 2) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H29C + (&H378 * 2) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H29C + (&H378 * 2) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H29C + (&H378 * 2) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 2) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 2) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(3) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H29C + (&H378 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H29C + (&H378 * 3) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H29C + (&H378 * 3) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H29C + (&H378 * 3) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H29C + (&H378 * 3) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H29C + (&H378 * 3) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H29C + (&H378 * 3) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H29C + (&H378 * 3) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H29C + (&H378 * 3) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H29C + (&H378 * 3) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H29C + (&H378 * 3) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H29C + (&H378 * 3) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H29C + (&H378 * 3) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H29C + (&H378 * 3) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H29C + (&H378 * 3) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 3) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 3) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(4) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H29C + (&H378 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H29C + (&H378 * 4) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H29C + (&H378 * 4) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H29C + (&H378 * 4) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H29C + (&H378 * 4) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H29C + (&H378 * 4) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H29C + (&H378 * 4) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H29C + (&H378 * 4) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H29C + (&H378 * 4) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H29C + (&H378 * 4) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H29C + (&H378 * 4) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H29C + (&H378 * 4) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H29C + (&H378 * 4) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H29C + (&H378 * 4) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H29C + (&H378 * 4) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 4) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 4) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(5) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H29C + (&H378 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H29C + (&H378 * 5) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H29C + (&H378 * 5) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H29C + (&H378 * 5) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H29C + (&H378 * 5) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H29C + (&H378 * 5) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H29C + (&H378 * 5) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H29C + (&H378 * 5) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H29C + (&H378 * 5) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H29C + (&H378 * 5) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H29C + (&H378 * 5) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H29C + (&H378 * 5) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H29C + (&H378 * 5) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H29C + (&H378 * 5) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H29C + (&H378 * 5) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 5) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 5) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(6) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H29C + (&H378 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H29C + (&H378 * 6) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H29C + (&H378 * 6) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H29C + (&H378 * 6) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H29C + (&H378 * 6) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H29C + (&H378 * 6) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H29C + (&H378 * 6) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H29C + (&H378 * 6) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H29C + (&H378 * 6) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H29C + (&H378 * 6) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H29C + (&H378 * 6) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H29C + (&H378 * 6) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H29C + (&H378 * 6) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H29C + (&H378 * 6) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H29C + (&H378 * 6) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 6) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 6) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(7) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H29C + (&H378 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H29C + (&H378 * 7) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H29C + (&H378 * 7) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H29C + (&H378 * 7) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H29C + (&H378 * 7) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H29C + (&H378 * 7) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H29C + (&H378 * 7) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H29C + (&H378 * 7) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H29C + (&H378 * 7) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H29C + (&H378 * 7) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H29C + (&H378 * 7) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H29C + (&H378 * 7) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H29C + (&H378 * 7) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H29C + (&H378 * 7) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H29C + (&H378 * 7) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 7) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 7) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(8) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H29C + (&H378 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H29C + (&H378 * 8) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H29C + (&H378 * 8) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H29C + (&H378 * 8) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H29C + (&H378 * 8) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H29C + (&H378 * 8) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H29C + (&H378 * 8) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H29C + (&H378 * 8) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H29C + (&H378 * 8) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H29C + (&H378 * 8) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H29C + (&H378 * 8) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H29C + (&H378 * 8) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H29C + (&H378 * 8) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H29C + (&H378 * 8) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H29C + (&H378 * 8) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 8) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 8) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(9) Then
                    If valu_job.Value = 0 Then
                        Reader.Position = &H29C + (&H378 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 1 Then
                        Reader.Position = &H29C + (&H378 * 9) + &H4
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9) + &H4
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9) + &H4
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 2 Then
                        Reader.Position = &H29C + (&H378 * 9) + (&H4 * 2)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9) + (&H4 * 2)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9) + (&H4 * 2)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 3 Then
                        Reader.Position = &H29C + (&H378 * 9) + (&H4 * 3)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9) + (&H4 * 3)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9) + (&H4 * 3)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 4 Then
                        Reader.Position = &H29C + (&H378 * 9) + (&H4 * 4)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9) + (&H4 * 4)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9) + (&H4 * 4)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 5 Then
                        Reader.Position = &H29C + (&H378 * 9) + (&H4 * 5)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9) + (&H4 * 5)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9) + (&H4 * 5)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 6 Then
                        Reader.Position = &H29C + (&H378 * 9) + (&H4 * 6)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9) + (&H4 * 6)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9) + (&H4 * 6)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 7 Then
                        Reader.Position = &H29C + (&H378 * 9) + (&H4 * 7)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9) + (&H4 * 7)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9) + (&H4 * 7)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 8 Then
                        Reader.Position = &H29C + (&H378 * 9) + (&H4 * 8)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9) + (&H4 * 8)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9) + (&H4 * 8)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 9 Then
                        Reader.Position = &H29C + (&H378 * 9) + (&H4 * 9)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9) + (&H4 * 9)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9) + (&H4 * 9)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 10 Then
                        Reader.Position = &H29C + (&H378 * 9) + (&H4 * 10)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9) + (&H4 * 10)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9) + (&H4 * 10)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 11 Then
                        Reader.Position = &H29C + (&H378 * 9) + (&H4 * 11)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9) + (&H4 * 11)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9) + (&H4 * 11)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 12 Then
                        Reader.Position = &H29C + (&H378 * 9) + (&H4 * 12)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9) + (&H4 * 12)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9) + (&H4 * 12)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 13 Then
                        Reader.Position = &H29C + (&H378 * 9) + (&H4 * 13)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9) + (&H4 * 13)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9) + (&H4 * 13)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    ElseIf valu_job.Value = 14 Then
                        Reader.Position = &H29C + (&H378 * 9) + (&H4 * 14)
                        Equipweaponap = Reader.Position
                        valu_appea_weapon.Value = Reader.ReadByte
                        Reader.Position = &H29D + (&H378 * 9) + (&H4 * 14)
                        Equiphatap = Reader.Position
                        valu_appea_hat.Value = Reader.ReadByte
                        Reader.Position = &H29E + (&H378 * 9) + (&H4 * 14)
                        Equipclotheap = Reader.Position
                        valu_appea_clothe.Value = Reader.ReadByte
                    End If
                End If
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : Read equipments appearance"
                fdialog.Msg.Text = "Oops, something goes wrong" & vbNewLine & "reading equipments appearance failed, please report this issue or try again"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Lecture apparance équipements"
                fdialog.Msg.Text = "Oups, quelque chose ne va pas" & vbNewLine & "la lecture de l'apparance des équipements a échouée, veuillez signalez cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Public Sub writeequipappearance()
        Try
            Dim writerx As New System.IO.FileStream(hero, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            writerx.Position = Equipweaponap
            writerx.WriteByte(valu_appea_weapon.Value)
            writerx.Position = Equiphatap
            writerx.WriteByte(valu_appea_hat.Value)
            writerx.Position = Equipclotheap
            writerx.WriteByte(valu_appea_clothe.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : Write equipments appearance"
                fdialog.Msg.Text = "Oops, something goes wrong" & vbNewLine & "writing equipments appearance failed, please report this issue or try again"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Écriture apparance équipements"
                fdialog.Msg.Text = "Oups, quelque chose ne va pas" & vbNewLine & "l'écriture de l'apparance des équipements a échoué, veuillez signalez cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If
        End Try
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
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : Read common.sav"
                fdialog.Msg.Text = "Oops, something goes wrong" & vbNewLine & "opening of common.sav failed, please report this issue or try again"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Lecture common.sav"
                fdialog.Msg.Text = "Oups, quelque chose ne va pas" & vbNewLine & "l'ouverture de common.sav a échoué, veuillez signalez cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If
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
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : write common.sav"
                fdialog.Msg.Text = "common.sav has been saved"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Écriture common.sav"
                fdialog.Msg.Text = "common.sav a été sauvegardé"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : write common.sav"
                fdialog.Msg.Text = "An error has occured" & vbNewLine & "please report this issue"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Écriture common.sav"
                fdialog.Msg.Text = "Une erreur est survenue" & vbNewLine & "veuillez signalez cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If
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
            Reader.Position = &H4B7C
            valu_catalog.Value = Reader.ReadUInt32
            Button_open_quest.Visible = False
            Button_save_quest.Visible = True
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : Read quest.sav"
                fdialog.Msg.Text = "Oops, something goes wrong" & vbNewLine & "opening of quest.sav failed, please report this issue or try again"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Lecture quest.sav"
                fdialog.Msg.Text = "Oups, quelque chose ne va pas" & vbNewLine & "l'ouverture de quest.sav a échoué, veuillez signaler cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If
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
            writer.Position = &H4B7C
            writer.WriteUInt32(valu_catalog.Value)
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : write quest.sav"
                fdialog.Msg.Text = "quest.sav has been saved"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Lecture quest.sav"
                fdialog.Msg.Text = "quest.sav a été enregistré"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : write quest.sav"
                fdialog.Msg.Text = "An error has occured" & vbNewLine & "please report this issue"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Lecture quest.sav"
                fdialog.Msg.Text = "Une erreur est survenue" & vbNewLine & "veuillez signaler cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If
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
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : Read hero.sav"
                fdialog.Msg.Text = "Oops, something goes wrong" & vbNewLine & "opening of hero.sav failed, please report this issue or try again"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Lecture hero.sav"
                fdialog.Msg.Text = "Oups, quelque chose ne va pas" & vbNewLine & "l'ouverture de hero.sav a échoué, veuillez signaler cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If
            Button_open_hero.Visible = True
            Button_save_hero.Visible = False
        End Try
    End Sub
    Public Sub writehero()
        Try
            Dim writer As New PackageIO.Writer(hero, PackageIO.Endian.Little)
            If Filever_text.Text = "US" Or Filever_text.Text = "EU" Then
                For i As Integer = 0 To 9
                    writer.Position = Miiname + i
                    writer.WriteInt8(0)
                Next
            End If
            If Filever_text.Text = "JP" Then
                For i As Integer = 0 To 5
                    writer.Position = Miiname + i
                    writer.WriteInt8(0)
                Next
            End If
            writer.Position = Miiname
            writer.WriteUnicodeString(Text_Mii_name.Text)
            If Filever_text.Text = "US" Or Filever_text.Text = "EU" Then
                For i As Integer = 0 To 25
                    writer.Position = Warcry + i
                    writer.WriteInt8(0)
                Next
            End If
            If Filever_text.Text = "JP" Then
                For i As Integer = 0 To 9
                    writer.Position = Warcry + i
                    writer.WriteInt8(0)
                Next
            End If
            writer.Position = Warcry
            writer.WriteUnicodeString(Text_warcry.Text)
            writer.Position = Personality
            writer.WriteInt8(valu_personnality.Value)
            writer.Position = Job
            writer.WriteInt8(valu_job.Value)
            writer.Position = Tummy
            writer.WriteInt8(valu_tummy.Value)
            writer.Position = Innroom
            writer.WriteInt8(valu_inn_room.Value)
            writer.Position = Innroomposition
            writer.WriteInt8(valu_inn_roomposition.Value)
            writer.Position = Sick
            writer.WriteInt8(valu_sick.Value)
            writer.Position = Expwarrior
            writer.WriteUInt32(valu_exp_warrior.Value)
            writer.Position = Expmage
            writer.WriteUInt32(valu_exp_mage.Value)
            writer.Position = Expcleric
            writer.WriteUInt32(valu_exp_cleric.Value)
            writer.Position = Expthief
            writer.WriteUInt32(valu_exp_thief.Value)
            writer.Position = Exppopstar
            writer.WriteUInt32(valu_exp_popstar.Value)
            writer.Position = Expvampire
            writer.WriteUInt32(valu_exp_vampire.Value)
            writer.Position = Expchef
            writer.WriteUInt32(valu_exp_chef.Value)
            writer.Position = Exptank
            writer.WriteUInt32(valu_exp_tank.Value)
            writer.Position = Expimp
            writer.WriteUInt32(valu_exp_imp.Value)
            writer.Position = Expprincess
            writer.WriteUInt32(valu_exp_princess.Value)
            writer.Position = Expflower
            writer.WriteUInt32(valu_exp_flower.Value)
            writer.Position = Expscientist
            writer.WriteUInt32(valu_exp_scientist.Value)
            writer.Position = Expcat
            writer.WriteUInt32(valu_exp_cat.Value)
            writer.Position = Expelf
            writer.WriteUInt32(valu_exp_elf.Value)
            writer.Position = Daysick
            writer.WriteUInt32(valu_daysick.Value)
            writer.Position = FoodexpHP
            writer.WriteUInt32(valu_foodexp_HP.Value)
            writer.Position = FoodexpMP
            writer.WriteUInt32(valu_foodexp_MP.Value)
            writer.Position = Foodexpattack
            writer.WriteUInt32(valu_foodexp_attack.Value)
            writer.Position = Foodexpdefense
            writer.WriteUInt32(valu_foodexp_defense.Value)
            writer.Position = Foodexpmagic
            writer.WriteUInt32(valu_foodexp_magic.Value)
            writer.Position = Foodexpspeed
            writer.WriteUInt32(valu_foodexp_speed.Value)
            writer.Position = Active_interac
            writer.WriteUInt16(valu_interaction.Value)
            writer.Position = Battles
            writer.WriteUInt32(valu_battles.Value)
            writer.Position = Fblows
            writer.WriteUInt32(valu_fblows.Value)
            writer.Position = Defeats
            writer.WriteUInt32(valu_defeats.Value)
            writer.Position = Tlooparty
            writer.WriteUInt32(valu_tlooparty.Value)
            writer.Position = Hbgobbled
            writer.WriteUInt32(valu_hbgobbled.Value)
            writer.Position = Mcgulped
            writer.WriteUInt32(valu_mcgulped.Value)
            writer.Position = Ggrubbed
            writer.WriteUInt32(valu_ggrubbed.Value)
            writer.Position = Ggrabbed
            writer.WriteUInt32(valu_ggrabbed.Value)

            Dim fs As New FileStream(hero, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            fs.Position = Pose
            fs.WriteByte(valu_pose.Value)
            fs.Position = Interac_Mii
            fs.WriteByte(valu_interac_Mii.Value)
            fs.Position = Interac_activity
            fs.WriteByte(valu_interac_activity.Value)
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : write hero.sav"
                fdialog.Msg.Text = "hero.sav has been saved"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : écriture hero.sav"
                fdialog.Msg.Text = "hero.sav a été enregistré"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : write hero.sav"
                fdialog.Msg.Text = "An error has occured" & vbNewLine & "please report this issue"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : écriture hero.sav"
                fdialog.Msg.Text = "Une erreur est survenue" & vbNewLine & "veuillez signaler cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If
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
            Setting_ckupdate.Checked = My.Settings.S_ckupdate
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
        My.Settings.S_ckupdate = Setting_ckupdate.Checked
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
            Bar_catalog.Visible = True
            Icon_catalog.Location = New Point(21, 21)
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
            Bar_catalog.Visible = False
            Icon_catalog.Location = New Point(21, 12)
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

    Private Sub Fea_gold_MouseMove(sender As Object, e As EventArgs) Handles Fea_gold.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to max gold"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour mettre l'argent au maximum"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_gold_MouseLeave(sender As Object, e As EventArgs) Handles Fea_gold.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Menu_hero_Click(sender As Object, e As EventArgs) Handles Menu_hero.Click, Menu_text_hero.Click
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

    Private Sub Menu_Repair_Click(sender As Object, e As EventArgs) Handles Menu_Repair.Click, Menu_text_repair.Click
        Hidemenu()
        Me.Hide()
        Repair_save.Show()
    End Sub

    Private Sub Menu_Repair_MouseMove(sender As Object, e As EventArgs) Handles Menu_Repair.MouseMove, Menu_text_repair.MouseMove
        Menu_Repair.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to try to repair save files"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour tenter de réparer les sauvegardes"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Menu_Repair_MouseLeave(sender As Object, e As EventArgs) Handles Menu_Repair.MouseLeave
        Menu_Repair.BorderStyle = BorderStyle.None
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

    Private Sub Filever_text_MouseMove(sender As Object, e As EventArgs) Handles Filever_text.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to change save file version"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour changer la version de la sauvegarde"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Filever_text_MouseLeave(sender As Object, e As EventArgs) Handles Filever_text.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_bananas_Click(sender As Object, e As EventArgs) Handles Fea_bananas.Click
        valu_bananas.Value = 999
    End Sub

    Private Sub Fea_bananas_MouseMove(sender As Object, e As EventArgs) Handles Fea_bananas.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to max HP bananas"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour mettre les Bananes PV au maximum"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_bananas_MouseLeave(sender As Object, e As EventArgs) Handles Fea_bananas.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_candies_Click(sender As Object, e As EventArgs) Handles Fea_candies.Click
        valu_candies.Value = 999
    End Sub

    Private Sub Fea_candies_MouseMove(sender As Object, e As EventArgs) Handles Fea_candies.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to max MP candies"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour mettre les Bonbons PM au maximum"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_candies_MouseLeave(sender As Object, e As EventArgs) Handles Fea_candies.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_allweapons_Click(sender As Object, e As EventArgs) Handles Fea_allweapons.Click
        valu_allweapons.Value = 65535
        notification()
    End Sub

    Private Sub Fea_allweapons_MouseMove(sender As Object, e As EventArgs) Handles Fea_allweapons.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all classes"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les classes"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_allweapons_MouseLeave(sender As Object, e As EventArgs) Handles Fea_allweapons.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_costamiibo_Click(sender As Object, e As EventArgs) Handles Fea_costamiibo.Click
        valu_costamiibo.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_costamiibo_MouseMove(sender As Object, e As EventArgs) Handles Fea_costamiibo.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all amiibo costumes"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes amiibo"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_costamiibo_MouseLeave(sender As Object, e As EventArgs) Handles Fea_costamiibo.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ticket_Click(sender As Object, e As EventArgs) Handles Fea_ticket.Click
        valu_ticket.Value = 9999
    End Sub

    Private Sub Fea_ticket_MouseMove(sender As Object, e As EventArgs) Handles Fea_ticket.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to max tickets"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour mettre les tickets au maximum"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ticket_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ticket.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_sprinkles_Click(sender As Object, e As EventArgs) Handles Fea_sprinkles.Click
        valu_sprinkles.Value = 31
        notification()
    End Sub

    Private Sub Fea_sprinkles_MouseMove(sender As Object, e As EventArgs) Handles Fea_sprinkles.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all sprinkles"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les salières"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_sprinkles_MouseLeave(sender As Object, e As EventArgs) Handles Fea_sprinkles.MouseLeave
        Descrip_panel.Visible = False
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
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : ride on the dragon"
                fdialog.Msg.Text = "An error has occured, load a save file first"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : monter sur le dragon"
                fdialog.Msg.Text = "Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.ShowDialog()
            End If
            Dragon_map.Visible = True
            Info_dragon_map.Visible = True
            Dragon_map2.Visible = False
            Info_dragon_map2.Visible = False
        End Try

    End Sub

    Private Sub Dragon_map_MouseMove(sender As Object, e As EventArgs) Handles Dragon_map.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to ride on the dragon"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour monter sur le dragon"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Dragon_map_MouseLeave(sender As Object, e As EventArgs) Handles Dragon_map.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub text_Open_Click(sender As Object, e As EventArgs) Handles text_open.Click
        Dim open As New OpenFileDialog
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            fdialog.Title.Text = "Miitopia Save Editor"
            fdialog.Msg.Text = "Open common.sav file" & vbNewLine & "Miitopia Save Editor will make a backup of your save file, check ''bak'' folder" & vbNewLine & "Make a backup of your entire save file folder in case"
            fdialog.ShowDialog()
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            fdialog.Title.Text = "Miitopia Save Editor"
            fdialog.Msg.Text = "Ouvrez le fichier common.sav" & vbNewLine & "Miitopia Save Editor va faire une copie de votre sauvegarde, vérifiez le dossier ''bak''" & vbNewLine & "Faites une copie du dossier entier de sauvegarde au cas où"
            fdialog.ShowDialog()
        End If
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
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to open common.sav"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour ouvrir common.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub text_open_MouseLeave(sender As Object, e As EventArgs) Handles text_open.MouseLeave, Button_Open.MouseLeave
        Button_Open.BackgroundImage = My.Resources.button_open
        Descrip_panel.Visible = False
    End Sub

    Private Sub Info_party_Click(sender As Object, e As EventArgs) Handles Info_party.Click
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            fdialog.Title.Text = "Miitopia Save Editor : Party is in"
            fdialog.Msg.Text = "To set party in Overworld you need to defeat Dark Lord"
            fdialog.ShowDialog()
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            fdialog.Title.Text = "Miitopia Save Editor : L'équipe est dans"
            fdialog.Msg.Text = "Pour mettre l'équipe au dessus de l'île, vous devez combattre l'Avatar du Mal"
            fdialog.ShowDialog()
        End If
    End Sub

    Private Sub Info_dragon_map_Click(sender As Object, e As EventArgs) Handles Info_dragon_map.Click, Info_dragon_map2.Click
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            fdialog.Title.Text = "Miitopia Save Editor : ride on the dragon"
            fdialog.Msg.Text = "When your save file will be load, you will be on the dragon, visit Travelers Hub to unlock the Dragon"
            fdialog.ShowDialog()
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            fdialog.Title.Text = "Miitopia Save Editor : monter sur le dragon"
            fdialog.Msg.Text = "Lorsque votre sauvegarde sera chargé, vous serez sur le dragon, visitez la cité des voyageurs pour débloquez le Dragon"
            fdialog.ShowDialog()
        End If
    End Sub

    Private Sub Fea_foods_Click(sender As Object, e As EventArgs) Handles Fea_foods.Click
        Grub_editor.ShowDialog()
    End Sub

    Private Sub Fea_foods_MouseMove(sender As Object, e As EventArgs) Handles Fea_foods.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to edit grubs"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour éditer la nourriture"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_foods_MouseLeave(sender As Object, e As EventArgs) Handles Fea_foods.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Select_music_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_music.SelectedIndexChanged
        startmusic()
    End Sub

    Private Sub icon_safespot_Click(sender As Object, e As EventArgs) Handles icon_safespot.Click
        valu_safespot.Value = 1
        notification()
    End Sub

    Private Sub Group_safespot_MouseMove(sender As Object, e As EventArgs) Handles Group_safespot.MouseMove, icon_safespot.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock safe spot"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer l'abri"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Group_safespot_MouseLeave(sender As Object, e As EventArgs) Handles Group_safespot.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub text_save_Click(sender As Object, e As EventArgs) Handles text_save.Click
        writecommon()
    End Sub

    Private Sub text_save_MouseMove(sender As Object, e As EventArgs) Handles text_save.MouseMove, Button_Save.MouseMove
        Button_Save.BackgroundImage = My.Resources.button_open
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to save common.sav"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour sauvegarder common.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub text_save_MouseLeave(sender As Object, e As EventArgs) Handles text_save.MouseLeave, Button_Save.MouseLeave
        Button_Save.BackgroundImage = My.Resources.button_save
        Descrip_panel.Visible = False
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
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            fdialog.Title.Text = "Miitopia Save Editor : select level info"
            fdialog.Msg.Text = "Be careful by editing level, common.sav can be corrupt if a wrong value is used, if common.sav is corrupted set a lower value"
            fdialog.ShowDialog()
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            fdialog.Title.Text = "Miitopia Save Editor : info sélection niveau"
            fdialog.Msg.Text = "Soyez prudent en éditant le niveau, common.sav peut être corrompu si une mauvaise valeur est utilisé, si common.sav est corrompu utilisez une valeur inférieur"
            fdialog.ShowDialog()
        End If
    End Sub

    Private Sub Fea_wp_warrior_Click(sender As Object, e As EventArgs) Handles Fea_wp_warrior.Click, Icon_wp_warrior.Click
        valu_wp_warrior.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_wp_warrior_MouseMove(sender As Object, e As EventArgs) Handles Fea_wp_warrior.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all warrior weapons in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les armes de guerrier dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_wp_warrior_MouseLeave(sender As Object, e As EventArgs) Handles Fea_wp_warrior.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_wp_mage_Click(sender As Object, e As EventArgs) Handles Fea_wp_mage.Click, Icon_wp_mage.Click
        valu_wp_mage.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_wp_mage_MouseMove(sender As Object, e As EventArgs) Handles Fea_wp_mage.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all mage weapons in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les armes de mage dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_wp_mage_MouseLeave(sender As Object, e As EventArgs) Handles Fea_wp_mage.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_wp_cleric_Click(sender As Object, e As EventArgs) Handles Fea_wp_cleric.Click, Icon_wp_cleric.Click
        valu_wp_cleric.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_wp_cleric_MouseMove(sender As Object, e As EventArgs) Handles Fea_wp_cleric.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all cleric weapons in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les armes de prêtre dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_wp_cleric_MouseLeave(sender As Object, e As EventArgs) Handles Fea_wp_cleric.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_wp_thief_Click(sender As Object, e As EventArgs) Handles Fea_wp_thief.Click, Icon_wp_thief.Click
        valu_wp_thief.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_wp_thief_MouseMove(sender As Object, e As EventArgs) Handles Fea_wp_thief.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all thief weapons in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les armes de voleur dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_wp_thief_MouseLeave(sender As Object, e As EventArgs) Handles Fea_wp_thief.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_wp_popstar_Click(sender As Object, e As EventArgs) Handles Fea_wp_popstar.Click, Icon_wp_popstar.Click
        valu_wp_popstar.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_wp_popstar_MouseMove(sender As Object, e As EventArgs) Handles Fea_wp_popstar.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all pop star weapons in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les armes de chanteur(se) dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_wp_popstar_MouseLeave(sender As Object, e As EventArgs) Handles Fea_wp_popstar.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_wp_vampire_Click(sender As Object, e As EventArgs) Handles Fea_wp_vampire.Click, Icon_wp_vampire.Click
        valu_wp_vampire.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_wp_vampire_MouseMove(sender As Object, e As EventArgs) Handles Fea_wp_vampire.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all vampire weapons in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les armes de vampire dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_wp_vampire_MouseLeave(sender As Object, e As EventArgs) Handles Fea_wp_vampire.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_wp_chef_Click(sender As Object, e As EventArgs) Handles Fea_wp_chef.Click, Icon_wp_chef.Click
        valu_wp_chef.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_wp_chef_MouseMove(sender As Object, e As EventArgs) Handles Fea_wp_chef.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all chef weapons in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les armes de cuisinier dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_wp_chef_MouseLeave(sender As Object, e As EventArgs) Handles Fea_wp_chef.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_wp_tank_Click(sender As Object, e As EventArgs) Handles Fea_wp_tank.Click, Icon_wp_tank.Click
        valu_wp_tank.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_wp_tank_MouseMove(sender As Object, e As EventArgs) Handles Fea_wp_tank.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all tank weapons in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les armes de tank dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_wp_tank_MouseLeave(sender As Object, e As EventArgs) Handles Fea_wp_tank.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_wp_imp_Click(sender As Object, e As EventArgs) Handles Fea_wp_imp.Click, Icon_wp_imp.Click
        valu_wp_imp.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_wp_imp_MouseMove(sender As Object, e As EventArgs) Handles Fea_wp_imp.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all imp weapons in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les armes de diablotin dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_wp_imp_MouseLeave(sender As Object, e As EventArgs) Handles Fea_wp_imp.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_wp_princess_Click(sender As Object, e As EventArgs) Handles Fea_wp_princess.Click, Icon_wp_princess.Click
        valu_wp_princess.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_wp_princess_MouseMove(sender As Object, e As EventArgs) Handles Fea_wp_princess.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all princess weapons in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les armes de princesse dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_wp_princess_MouseLeave(sender As Object, e As EventArgs) Handles Fea_wp_princess.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_wp_flower_Click(sender As Object, e As EventArgs) Handles Fea_wp_flower.Click, Icon_wp_flower.Click
        valu_wp_flower.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_wp_flower_MouseMove(sender As Object, e As EventArgs) Handles Fea_wp_flower.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all flower weapons in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les armes de fleur dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_wp_flower_MouseLeave(sender As Object, e As EventArgs) Handles Fea_wp_flower.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_wp_scientist_Click(sender As Object, e As EventArgs) Handles Fea_wp_scientist.Click, Icon_wp_scientist.Click
        valu_wp_scientist.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_wp_scientist_MouseMove(sender As Object, e As EventArgs) Handles Fea_wp_scientist.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all scientist weapons in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les armes de scientifique dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_wp_scientist_MouseLeave(sender As Object, e As EventArgs) Handles Fea_wp_scientist.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_wp_cat_Click(sender As Object, e As EventArgs) Handles Fea_wp_cat.Click, Icon_wp_cat.Click
        valu_wp_cat.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_wp_cat_MouseMove(sender As Object, e As EventArgs) Handles Fea_wp_cat.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all cat weapons in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les armes de chat dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_wp_cat_MouseLeave(sender As Object, e As EventArgs) Handles Fea_wp_cat.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_wp_elf_Click(sender As Object, e As EventArgs) Handles Fea_wp_elf.Click, Icon_wp_elf.Click
        valu_wp_elf.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_wp_elf_MouseMove(sender As Object, e As EventArgs) Handles Fea_wp_elf.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all elf weapons in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer toutes les armes d'elfe dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_wp_elf_MouseLeave(sender As Object, e As EventArgs) Handles Fea_wp_elf.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ct_warrior_Click(sender As Object, e As EventArgs) Handles Fea_ct_warrior.Click, Icon_ct_warrior.Click
        valu_ct_warrior.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_ct_warrior_MouseMove(sender As Object, e As EventArgs) Handles Fea_ct_warrior.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all warrior costumes in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes de guerrier dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ct_warrior_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ct_warrior.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ct_mage_Click(sender As Object, e As EventArgs) Handles Fea_ct_mage.Click, Icon_ct_mage.Click
        valu_ct_mage.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_ct_mage_MouseMove(sender As Object, e As EventArgs) Handles Fea_ct_mage.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all mage costumes in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes de mage dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ct_mage_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ct_mage.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ct_cleric_Click(sender As Object, e As EventArgs) Handles Fea_ct_cleric.Click, Icon_ct_cleric.Click
        valu_ct_cleric.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_ct_cleric_MouseMove(sender As Object, e As EventArgs) Handles Fea_ct_cleric.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all cleric costumes in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes de prêtre dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ct_cleric_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ct_cleric.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ct_thief_Click(sender As Object, e As EventArgs) Handles Fea_ct_thief.Click, Icon_ct_thief.Click
        valu_ct_thief.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_ct_thief_MouseMove(sender As Object, e As EventArgs) Handles Fea_ct_thief.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all thief costumes in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes de voleur dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ct_thief_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ct_thief.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ct_popstar_Click(sender As Object, e As EventArgs) Handles Fea_ct_popstar.Click, Icon_ct_popstar.Click
        valu_ct_popstar.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_ct_popstar_MouseMove(sender As Object, e As EventArgs) Handles Fea_ct_popstar.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all popstar costumes in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes de chanteur(se) dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ct_popstar_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ct_popstar.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ct_vampire_Click(sender As Object, e As EventArgs) Handles Fea_ct_vampire.Click, Icon_ct_vampire.Click
        valu_ct_vampire.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_ct_vampire_MouseMove(sender As Object, e As EventArgs) Handles Fea_ct_vampire.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all vampire costumes in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes de vampire dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ct_vampire_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ct_vampire.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ct_chef_Click(sender As Object, e As EventArgs) Handles Fea_ct_chef.Click, Icon_ct_chef.Click
        valu_ct_chef.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_ct_chef_MouseMove(sender As Object, e As EventArgs) Handles Fea_ct_chef.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all chef costumes in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes de cuisinier dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ct_chef_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ct_chef.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ct_tank_Click(sender As Object, e As EventArgs) Handles Fea_ct_tank.Click, Icon_ct_tank.Click
        valu_ct_tank.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_ct_tank_MouseMove(sender As Object, e As EventArgs) Handles Fea_ct_tank.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all tank costumes in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes de tank dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ct_tank_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ct_tank.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ct_imp_Click(sender As Object, e As EventArgs) Handles Fea_ct_imp.Click, Icon_ct_imp.Click
        valu_ct_imp.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_ct_imp_MouseMove(sender As Object, e As EventArgs) Handles Fea_ct_imp.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all imp costumes in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes de diablotin dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ct_imp_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ct_imp.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ct_princess_Click(sender As Object, e As EventArgs) Handles Fea_ct_princess.Click, Icon_ct_princess.Click
        valu_ct_princess.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_ct_princess_MouseMove(sender As Object, e As EventArgs) Handles Fea_ct_princess.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all princess costumes in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes de princesse dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ct_princess_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ct_princess.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ct_flower_Click(sender As Object, e As EventArgs) Handles Fea_ct_flower.Click, Icon_ct_flower.Click
        valu_ct_flower.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_ct_flower_MouseMove(sender As Object, e As EventArgs) Handles Fea_ct_flower.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all flower costumes in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes de fleur dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ct_flower_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ct_flower.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ct_scientist_Click(sender As Object, e As EventArgs) Handles Fea_ct_scientist.Click, Icon_ct_scientist.Click
        valu_ct_scientist.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_ct_scientist_MouseMove(sender As Object, e As EventArgs) Handles Fea_ct_scientist.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all scientist costumes in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes de scientifique dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ct_scientist_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ct_scientist.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ct_cat_Click(sender As Object, e As EventArgs) Handles Fea_ct_cat.Click, Icon_ct_cat.Click
        valu_ct_cat.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_ct_cat_MouseMove(sender As Object, e As EventArgs) Handles Fea_ct_cat.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all cat costumes in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes de chat dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ct_cat_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ct_cat.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ct_elf_Click(sender As Object, e As EventArgs) Handles Fea_ct_elf.Click, Icon_ct_elf.Click
        valu_ct_elf.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_ct_elf_MouseMove(sender As Object, e As EventArgs) Handles Fea_ct_elf.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock all elf costumes in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer tous les costumes de elfe dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ct_elf_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ct_elf.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_bananaeat_Click(sender As Object, e As EventArgs) Handles Fea_bananaeat.Click, Icon_bananaeat.Click
        valu_bananaeat.Value = 9999
    End Sub

    Private Sub Fea_bananaeat_MouseMove(sender As Object, e As EventArgs) Handles Fea_bananaeat.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to max HP bananas ate"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour mettre les Bananes PV mangés au maximum"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_bananaeat_MouseLeave(sender As Object, e As EventArgs) Handles Fea_bananaeat.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_candyeat_Click(sender As Object, e As EventArgs) Handles Fea_candyeat.Click, Icon_candyeat.Click
        valu_candyeat.Value = 9999
    End Sub

    Private Sub Fea_candyeat_MouseMove(sender As Object, e As EventArgs) Handles Fea_candyeat.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to max MP candies ate"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour mettre les Bonbons PM mangés au maximum"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_candyeat_MouseLeave(sender As Object, e As EventArgs) Handles Fea_candyeat.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_chestsopen_Click(sender As Object, e As EventArgs) Handles Fea_chestsopen.Click, Icon_chestsopen.Click
        valu_chestsopen.Value = 9999
    End Sub

    Private Sub Fea_chestsopen_MouseMove(sender As Object, e As EventArgs) Handles Fea_chestsopen.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to max chests opened"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour mettre les coffres ouverts au maximum"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_chestsopen_MouseLeave(sender As Object, e As EventArgs) Handles Fea_chestsopen.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_questsucc_Click(sender As Object, e As EventArgs) Handles Fea_questsucc.Click, Icon_questsucc.Click
        valu_questsucc.Value = 9999
    End Sub

    Private Sub Fea_questsucc_MouseMove(sender As Object, e As EventArgs) Handles Fea_questsucc.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to max quests succeed"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour mettre les quêtes réussi au maximum"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_questsucc_MouseLeave(sender As Object, e As EventArgs) Handles Fea_questsucc.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_dragonclass_Click(sender As Object, e As EventArgs) Handles Fea_dragonclass.Click, Icon_dragonclass.Click
        valu_dragonclass.Value = 4294967295
        notification()
    End Sub

    Private Sub Fea_dragonclass_MouseMove(sender As Object, e As EventArgs) Handles Fea_dragonclass.MouseMove, Icon_dragonclass.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock the dragon and ability to switch class"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer le dragon et la possibilité de changer de classe"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_dragonclass_MouseLeave(sender As Object, e As EventArgs) Handles Fea_dragonclass.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_villa_Click(sender As Object, e As EventArgs) Handles Fea_villa.Click, Icon_villa.Click
        valu_villa.Value = 1
        notification()
    End Sub

    Private Sub Fea_villa_MouseMove(sender As Object, e As EventArgs) Handles Fea_villa.MouseMove, Icon_villa.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock the villa"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer la villa"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_villa_MouseLeave(sender As Object, e As EventArgs) Handles Fea_villa.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_catalog_Click(sender As Object, e As EventArgs) Handles Fea_catalog.Click, Icon_catalog.Click
        valu_catalog.Value = 1646149627
        notification()
    End Sub

    Private Sub Fea_catalog_MouseMove(sender As Object, e As EventArgs) Handles Fea_catalog.MouseMove, Icon_catalog.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock the catalog"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer le catalogue"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_catalog_MouseLeave(sender As Object, e As EventArgs) Handles Fea_catalog.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Text_open_quest_Click(sender As Object, e As EventArgs) Handles Text_open_quest.Click
        Dim open As New OpenFileDialog
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            fdialog.Title.Text = "Miitopia Save Editor"
            fdialog.Msg.Text = "Open quest.sav file" & vbNewLine & "Miitopia Save Editor will make a backup of your save file, check ''bak'' folder" & vbNewLine & "Make a backup of your entire save file folder in case"
            fdialog.ShowDialog()
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            fdialog.Title.Text = "Miitopia Save Editor"
            fdialog.Msg.Text = "Ouvrez le fichier quest.sav" & vbNewLine & "Miitopia Save Editor va faire une copie de votre sauvegarde, vérifiez le dossier ''bak''" & vbNewLine & "Faites une copie du dossier entier de sauvegarde au cas où"
            fdialog.ShowDialog()
        End If
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
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to open quest.sav"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour ouvrir quest.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub text_open_quest_MouseLeave(sender As Object, e As EventArgs) Handles Text_open_quest.MouseLeave, Button_save_quest.MouseLeave
        Button_open_quest.BackgroundImage = My.Resources.button_open
        Descrip_panel.Visible = False
    End Sub

    Private Sub Text_save_quest_Click(sender As Object, e As EventArgs) Handles Text_save_quest.Click
        writequest()
    End Sub

    Private Sub text_save_quest_MouseMove(sender As Object, e As EventArgs) Handles Text_save_quest.MouseMove, Button_save_quest.MouseMove
        Button_save_quest.BackgroundImage = My.Resources.button_open
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to save quest.sav"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour enregistrer quest.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub text_save_quest_MouseLeave(sender As Object, e As EventArgs) Handles Text_save_quest.MouseLeave, Button_save_quest.MouseLeave
        Button_save_quest.BackgroundImage = My.Resources.button_save
        Descrip_panel.Visible = False
    End Sub

    Private Sub Text_open_hero_Click(sender As Object, e As EventArgs) Handles Text_open_hero.Click
        Dim open As New OpenFileDialog
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            fdialog.Title.Text = "Miitopia Save Editor"
            fdialog.Msg.Text = "Open hero.sav file" & vbNewLine & "Miitopia Save Editor will make a backup of your save file, check ''bak'' folder" & vbNewLine & "Make a backup of your entire save file folder in case"
            fdialog.ShowDialog()
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            fdialog.Title.Text = "Miitopia Save Editor"
            fdialog.Msg.Text = "Ouvrez le fichier hero.sav" & vbNewLine & "Miitopia Save Editor va faire une copie de votre sauvegarde, vérifiez le dossier ''bak''" & vbNewLine & "Faites une copie du dossier entier de sauvegarde au cas où"
            fdialog.ShowDialog()
        End If
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
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to open hero.sav"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour ouvrir hero.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub text_open_hero_MouseLeave(sender As Object, e As EventArgs) Handles Text_open_hero.MouseLeave, Button_save_hero.MouseLeave
        Button_open_hero.BackgroundImage = My.Resources.button_open
        Descrip_panel.Visible = False
    End Sub

    Private Sub Text_save_hero_Click(sender As Object, e As EventArgs) Handles Text_save_hero.Click
        writehero()
        writeequipements()
        writeequipappearance()
    End Sub

    Private Sub text_save_hero_MouseMove(sender As Object, e As EventArgs) Handles Text_save_hero.MouseMove, Button_save_hero.MouseMove
        Button_save_hero.BackgroundImage = My.Resources.button_open
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to save hero.sav"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour enregistrer hero.sav"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub text_save_hero_MouseLeave(sender As Object, e As EventArgs) Handles Text_save_hero.MouseLeave, Button_save_hero.MouseLeave
        Button_save_hero.BackgroundImage = My.Resources.button_save
        Descrip_panel.Visible = False
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
        If valu_job.Value = 255 Then
            valu_equip_weapon.Value = 0
            valu_equip_hat.Value = 0
            valu_equip_clothe.Value = 0
            valu_equip_weapon.Enabled = False
            valu_equip_hat.Enabled = False
            valu_equip_clothe.Enabled = False
        Else
            valu_equip_weapon.Enabled = True
            valu_equip_hat.Enabled = True
            valu_equip_clothe.Enabled = True
            readequipements()
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

    Private Sub Icon_job_MouseMove(sender As Object, e As EventArgs) Handles Icon_job.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to change class"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour changer de classe"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Icon_job_MouseLeave(sender As Object, e As EventArgs) Handles Icon_job.MouseLeave
        Descrip_panel.Visible = False
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
            Panel_hero_equipments.Visible = False
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                Text_showstats.Text = "Hide stats"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                Text_showstats.Text = "Cacher stats"
            End If
        ElseIf Panel_hero_sw2.Visible = True Then
            Panel_hero_sw1.Visible = True
            Panel_hero_sw2.Visible = False
            Panel_hero_equipments.Visible = False
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                Text_showstats.Text = "Show stats"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                Text_showstats.Text = "Afficher stats"
            End If
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
                Text_Mii_name.MaxLength = 10
                Text_warcry.MaxLength = 26
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
                    Reader.Position = &H130
                    Relationship = Reader.Position
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
                    Reader.Position = &H130 + &H398
                    Relationship = Reader.Position
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
                    Reader.Position = &H130 + (&H398 * 2)
                    Relationship = Reader.Position
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
                    Reader.Position = &H130 + (&H398 * 3)
                    Relationship = Reader.Position
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
                    Reader.Position = &H130 + (&H398 * 4)
                    Relationship = Reader.Position
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
                    Reader.Position = &H130 + (&H398 * 5)
                    Relationship = Reader.Position
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
                    Reader.Position = &H130 + (&H398 * 6)
                    Relationship = Reader.Position
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
                    Reader.Position = &H130 + (&H398 * 7)
                    Relationship = Reader.Position
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
                    Reader.Position = &H130 + (&H398 * 8)
                    Relationship = Reader.Position
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
                    Reader.Position = &H130 + (&H398 * 9)
                    Relationship = Reader.Position
                End If
            End If
            If Filever_text.Text = "JP" Then
                Text_Mii_name.MaxLength = 6
                Text_warcry.MaxLength = 10
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
                    Reader.Position = &H110
                    Relationship = Reader.Position
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
                    Reader.Position = &H110 + &H378
                    Relationship = Reader.Position
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
                    Reader.Position = &H110 + (&H378 * 2)
                    Relationship = Reader.Position
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
                    Reader.Position = &H110 + (&H378 * 3)
                    Relationship = Reader.Position
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
                    Reader.Position = &H110 + (&H378 * 4)
                    Relationship = Reader.Position
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
                    Reader.Position = &H110 + (&H378 * 5)
                    Relationship = Reader.Position
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
                    Reader.Position = &H110 + (&H378 * 6)
                    Relationship = Reader.Position
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
                    Reader.Position = &H110 + (&H378 * 7)
                    Relationship = Reader.Position
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
                    Reader.Position = &H110 + (&H378 * 8)
                    Relationship = Reader.Position
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
                    Reader.Position = &H110 + (&H378 * 9)
                    Relationship = Reader.Position
                End If
            End If
            readequipements()
            readequipappearance()
            readrelationship()
        Catch ex As Exception
            Select_Mii.SelectedItem = Nothing
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : select Mii"
                fdialog.Msg.Text = "An error has occured, load a save file first"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : selection Mii"
                fdialog.Msg.Text = "Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.ShowDialog()
            End If
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

    Private Sub Icon_tummy_MouseMove(sender As Object, e As EventArgs) Handles Icon_tummy.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to edit Mii's tummy"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour éditer le ventre des Mii"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Icon_tummy_MouseLeave(sender As Object, e As EventArgs) Handles Icon_tummy.MouseLeave
        Descrip_panel.Visible = False
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
        If valu_interac_Mii.Value > 100 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(0)
        ElseIf valu_interac_Mii.Value = 0 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(1)
        ElseIf valu_interac_Mii.Value = 1 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(2)
        ElseIf valu_interac_Mii.Value = 2 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(3)
        ElseIf valu_interac_Mii.Value = 3 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(4)
        ElseIf valu_interac_Mii.Value = 4 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(5)
        ElseIf valu_interac_Mii.Value = 5 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(6)
        ElseIf valu_interac_Mii.Value = 6 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(7)
        ElseIf valu_interac_Mii.Value = 7 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(8)
        ElseIf valu_interac_Mii.Value = 8 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(9)
        ElseIf valu_interac_Mii.Value = 9 Then
            Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(10)
        End If
    End Sub

    Private Sub Select_interac_Mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_interac_Mii.SelectedIndexChanged
        If Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(0) Then
            valu_interac_Mii.Value = 255
        ElseIf Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(1) Then
            valu_interac_Mii.Value = 0
        ElseIf Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(2) Then
            valu_interac_Mii.Value = 1
        ElseIf Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(3) Then
            valu_interac_Mii.Value = 2
        ElseIf Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(4) Then
            valu_interac_Mii.Value = 3
        ElseIf Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(5) Then
            valu_interac_Mii.Value = 4
        ElseIf Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(6) Then
            valu_interac_Mii.Value = 5
        ElseIf Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(7) Then
            valu_interac_Mii.Value = 6
        ElseIf Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(8) Then
            valu_interac_Mii.Value = 7
        ElseIf Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(9) Then
            valu_interac_Mii.Value = 8
        ElseIf Select_interac_Mii.SelectedItem = Select_interac_Mii.Items.Item(10) Then
            valu_interac_Mii.Value = 9
        End If
    End Sub

    Private Sub Text_showequipments_Click(sender As Object, e As EventArgs) Handles Text_showequipments.Click
        If Panel_hero_sw1.Visible = True Then
            Panel_hero_sw2.Visible = False
            Panel_hero_sw1.Visible = False
            Panel_hero_equipments.Visible = True
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                Text_showequipments.Text = "Hide equipments"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                Text_showequipments.Text = "Cacher équipements"
            End If
        ElseIf Panel_hero_equipments.Visible = True Then
            Panel_hero_sw1.Visible = True
            Panel_hero_sw2.Visible = False
            Panel_hero_equipments.Visible = False
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                Text_showequipments.Text = "Show equipments"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                Text_showequipments.Text = "Afficher équipements"
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/Brionjv/Miitopia-Save-Editor")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://gbatemp.net/threads/release-miitopia-save-editor.476376/")
    End Sub

    Private Sub Select_interac_activity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_interac_activity.SelectedIndexChanged
        If Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(0) Then
            valu_interac_activity.Value = 0
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(1) Then
            valu_interac_activity.Value = 1
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(2) Then
            valu_interac_activity.Value = 2
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(3) Then
            valu_interac_activity.Value = 3
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(4) Then
            valu_interac_activity.Value = 4
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(5) Then
            valu_interac_activity.Value = 5
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(6) Then
            valu_interac_activity.Value = 6
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(7) Then
            valu_interac_activity.Value = 7
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(8) Then
            valu_interac_activity.Value = 8
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(9) Then
            valu_interac_activity.Value = 9
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(10) Then
            valu_interac_activity.Value = 10
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(11) Then
            valu_interac_activity.Value = 11
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(12) Then
            valu_interac_activity.Value = 12
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(13) Then
            valu_interac_activity.Value = 13
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(14) Then
            valu_interac_activity.Value = 14
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(15) Then
            valu_interac_activity.Value = 15
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(16) Then
            valu_interac_activity.Value = 16
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(17) Then
            valu_interac_activity.Value = 17
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(18) Then
            valu_interac_activity.Value = 18
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(19) Then
            valu_interac_activity.Value = 19
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(20) Then
            valu_interac_activity.Value = 20
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(21) Then
            valu_interac_activity.Value = 21
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(22) Then
            valu_interac_activity.Value = 22
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(23) Then
            valu_interac_activity.Value = 23
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(24) Then
            valu_interac_activity.Value = 24
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(25) Then
            valu_interac_activity.Value = 25
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(26) Then
            valu_interac_activity.Value = 26
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(27) Then
            valu_interac_activity.Value = 27
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(28) Then
            valu_interac_activity.Value = 28
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(29) Then
            valu_interac_activity.Value = 29
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(30) Then
            valu_interac_activity.Value = 30
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(31) Then
            valu_interac_activity.Value = 31
        ElseIf Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(32) Then
            valu_interac_activity.Value = 32
        End If
    End Sub

    Private Sub valu_interac_activity_ValueChanged(sender As Object, e As EventArgs) Handles valu_interac_activity.ValueChanged
        If valu_interac_activity.Value = 0 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(0)
        ElseIf valu_interac_activity.Value = 1 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(1)
        ElseIf valu_interac_activity.Value = 2 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(2)
        ElseIf valu_interac_activity.Value = 3 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(3)
        ElseIf valu_interac_activity.Value = 4 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(4)
        ElseIf valu_interac_activity.Value = 5 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(5)
        ElseIf valu_interac_activity.Value = 6 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(6)
        ElseIf valu_interac_activity.Value = 7 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(7)
        ElseIf valu_interac_activity.Value = 8 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(8)
        ElseIf valu_interac_activity.Value = 9 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(9)
        ElseIf valu_interac_activity.Value = 10 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(10)
        ElseIf valu_interac_activity.Value = 11 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(11)
        ElseIf valu_interac_activity.Value = 12 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(12)
        ElseIf valu_interac_activity.Value = 13 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(13)
        ElseIf valu_interac_activity.Value = 14 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(14)
        ElseIf valu_interac_activity.Value = 15 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(15)
        ElseIf valu_interac_activity.Value = 16 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(16)
        ElseIf valu_interac_activity.Value = 17 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(17)
        ElseIf valu_interac_activity.Value = 18 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(18)
        ElseIf valu_interac_activity.Value = 19 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(19)
        ElseIf valu_interac_activity.Value = 20 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(20)
        ElseIf valu_interac_activity.Value = 21 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(21)
        ElseIf valu_interac_activity.Value = 22 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(22)
        ElseIf valu_interac_activity.Value = 23 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(23)
        ElseIf valu_interac_activity.Value = 24 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(24)
        ElseIf valu_interac_activity.Value = 25 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(25)
        ElseIf valu_interac_activity.Value = 26 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(26)
        ElseIf valu_interac_activity.Value = 27 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(27)
        ElseIf valu_interac_activity.Value = 28 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(28)
        ElseIf valu_interac_activity.Value = 29 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(29)
        ElseIf valu_interac_activity.Value = 30 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(30)
        ElseIf valu_interac_activity.Value = 31 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(31)
        ElseIf valu_interac_activity.Value = 32 Then
            Select_interac_activity.SelectedItem = Select_interac_activity.Items.Item(32)
        End If
    End Sub

    Private Sub Button_dona_Click(sender As Object, e As EventArgs) Handles Button_dona.Click
        System.Diagnostics.Process.Start("https://www.paypal.me/Brionjv")
    End Sub

    Private Sub Select_language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_language.SelectedIndexChanged
        selectlanguage()
    End Sub

    Private Sub Timer_notification_Tick(sender As Object, e As EventArgs) Handles Timer_notification.Tick
        Timer_notification.Stop()
        Panel_notification.Visible = False
    End Sub

    Private Sub Fea_medal_Click(sender As Object, e As EventArgs) Handles Fea_medal.Click
        Try
            Dim Writer As New PackageIO.Writer(common, Endian.Little)
            If Check_medal_unlock.Checked = True Then
                Writer.Position = &H2DD0
                Writer.WriteHexString("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF07000000000000000000000000000000FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF07000000000000000000000000000000FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF07")
            ElseIf Check_medal_reset.Checked = True Then
                Writer.Position = &H2DD0
                Writer.WriteHexString("000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000")
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : unlock / reset medals"
                fdialog.Msg.Text = "All medals has been unlocked / reset"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : débloquer / réinitialiser médailles"
                fdialog.Msg.Text = "Toutes les médailles ont été débloqué / réinitialisé"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : unlock / reset medals"
                fdialog.Msg.Text = "An error has occured" & vbNewLine & "please report this issue"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : débloquer / réinitialiser médailles"
                fdialog.Msg.Text = "Une erreur est survenue" & vbNewLine & "veuillez signaler cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Fea_medal_MouseMove(sender As Object, e As EventArgs) Handles Fea_medal.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock or reset all medals"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer ou réinitialiser les médailles"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_medal_MouseLeave(sender As Object, e As EventArgs) Handles Fea_medal.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ency_music_Click(sender As Object, e As EventArgs) Handles Fea_ency_music.Click
        Try
            Dim Writer As New PackageIO.Writer(common, Endian.Little)
            If Check_music_unlock.Checked = True Then
                Writer.Position = &H7E0
                Writer.WriteHexString("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF0F")
            ElseIf Check_medal_reset.Checked = True Then
                Writer.Position = &H7E0
                Writer.WriteHexString("0000000000000000000000000000000000000000000000000000")
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : unlock / reset musics"
                fdialog.Msg.Text = "All musics in encyclopedia has been unlocked / reset"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : débloquer / réinitialiser musiques"
                fdialog.Msg.Text = "Toutes les musiques dans l'encyclopédie ont été débloqué / réinitialisé"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : unlock / reset musics"
                fdialog.Msg.Text = "An error has occured" & vbNewLine & "please report this issue"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : débloquer / réinitialiser musiques"
                fdialog.Msg.Text = "Une erreur est survenue" & vbNewLine & "veuillez signaler cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Fea_ency_music_MouseMove(sender As Object, e As EventArgs) Handles Fea_ency_music.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock or reset all musics in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer ou réinitialiser les musiques dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ency_music_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ency_music.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Select_rela_gMii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_rela_gMii.SelectedIndexChanged
        If Select_rela_gMii.SelectedItem = Select_rela_gMii.Items.Item(0) Then
            Group_relation_1.Text = "Mii 1"
            Group_relation_2.Text = "Mii 2"
            Group_relation_3.Text = "Mii 3"
            Group_relation_4.Text = "Mii 4"
            Group_relation_5.Text = "Mii 5"
            Group_relation_6.Text = "Mii 6"
            Group_relation_7.Text = "Mii 7"
            Group_relation_8.Text = "Mii 8"
            Group_relation_9.Text = "Mii 9"
            Group_relation_10.Text = "Mii 10"
            Group_relation_11.Text = "Mii 11"
            Group_relation_12.Text = "Mii 12"
            Group_relation_13.Text = "Mii 13"
            Group_relation_14.Text = "Mii 14"
            Group_relation_15.Text = "Mii 15"
            Group_relation_16.Text = "Mii 16"
            Group_relation_17.Text = "Mii 17"
            Group_relation_18.Text = "Mii 18"
            Group_relation_19.Text = "Mii 19"
            Group_relation_20.Text = "Mii 20"
            Group_relation_21.Text = "Mii 21"
            Group_relation_22.Text = "Mii 22"
            Group_relation_23.Text = "Mii 23"
            Group_relation_24.Text = "Mii 24"
            Group_relation_25.Text = "Mii 25"
        End If
        If Select_rela_gMii.SelectedItem = Select_rela_gMii.Items.Item(1) Then
            Group_relation_1.Text = "Mii 26"
            Group_relation_2.Text = "Mii 27"
            Group_relation_3.Text = "Mii 28"
            Group_relation_4.Text = "Mii 29"
            Group_relation_5.Text = "Mii 30"
            Group_relation_6.Text = "Mii 31"
            Group_relation_7.Text = "Mii 32"
            Group_relation_8.Text = "Mii 33"
            Group_relation_9.Text = "Mii 34"
            Group_relation_10.Text = "Mii 35"
            Group_relation_11.Text = "Mii 36"
            Group_relation_12.Text = "Mii 37"
            Group_relation_13.Text = "Mii 38"
            Group_relation_14.Text = "Mii 39"
            Group_relation_15.Text = "Mii 40"
            Group_relation_16.Text = "Mii 41"
            Group_relation_17.Text = "Mii 42"
            Group_relation_18.Text = "Mii 43"
            Group_relation_19.Text = "Mii 44"
            Group_relation_20.Text = "Mii 45"
            Group_relation_21.Text = "Mii 46"
            Group_relation_22.Text = "Mii 47"
            Group_relation_23.Text = "Mii 48"
            Group_relation_24.Text = "Mii 49"
            Group_relation_25.Text = "Mii 50"
        End If
        If Select_rela_gMii.SelectedItem = Select_rela_gMii.Items.Item(2) Then
            Group_relation_1.Text = "Mii 51"
            Group_relation_2.Text = "Mii 52"
            Group_relation_3.Text = "Mii 53"
            Group_relation_4.Text = "Mii 54"
            Group_relation_5.Text = "Mii 55"
            Group_relation_6.Text = "Mii 56"
            Group_relation_7.Text = "Mii 57"
            Group_relation_8.Text = "Mii 58"
            Group_relation_9.Text = "Mii 59"
            Group_relation_10.Text = "Mii 60"
            Group_relation_11.Text = "Mii 61"
            Group_relation_12.Text = "Mii 62"
            Group_relation_13.Text = "Mii 63"
            Group_relation_14.Text = "Mii 64"
            Group_relation_15.Text = "Mii 65"
            Group_relation_16.Text = "Mii 66"
            Group_relation_17.Text = "Mii 67"
            Group_relation_18.Text = "Mii 68"
            Group_relation_19.Text = "Mii 69"
            Group_relation_20.Text = "Mii 70"
            Group_relation_21.Text = "Mii 71"
            Group_relation_22.Text = "Mii 72"
            Group_relation_23.Text = "Mii 73"
            Group_relation_24.Text = "Mii 74"
            Group_relation_25.Text = "Mii 75"
        End If
        If Select_rela_gMii.SelectedItem = Select_rela_gMii.Items.Item(3) Then
            Group_relation_1.Text = "Mii 76"
            Group_relation_2.Text = "Mii 77"
            Group_relation_3.Text = "Mii 78"
            Group_relation_4.Text = "Mii 79"
            Group_relation_5.Text = "Mii 80"
            Group_relation_6.Text = "Mii 81"
            Group_relation_7.Text = "Mii 82"
            Group_relation_8.Text = "Mii 83"
            Group_relation_9.Text = "Mii 84"
            Group_relation_10.Text = "Mii 85"
            Group_relation_11.Text = "Mii 86"
            Group_relation_12.Text = "Mii 87"
            Group_relation_13.Text = "Mii 88"
            Group_relation_14.Text = "Mii 89"
            Group_relation_15.Text = "Mii 90"
            Group_relation_16.Text = "Mii 91"
            Group_relation_17.Text = "Mii 92"
            Group_relation_18.Text = "Mii 93"
            Group_relation_19.Text = "Mii 94"
            Group_relation_20.Text = "Mii 95"
            Group_relation_21.Text = "Mii 96"
            Group_relation_22.Text = "Mii 97"
            Group_relation_23.Text = "Mii 98"
            Group_relation_24.Text = "Mii 99"
            Group_relation_25.Text = "Mii 100"
        End If
        readrelationship()
    End Sub

    Private Sub Panel_hero_setall_Click(sender As Object, e As EventArgs) Handles Panel_hero_setall.Click, Text_hero_setall.Click
        valu_relation_1.Value = valu_hero_setall.Value
        valu_relation_2.Value = valu_hero_setall.Value
        valu_relation_3.Value = valu_hero_setall.Value
        valu_relation_4.Value = valu_hero_setall.Value
        valu_relation_5.Value = valu_hero_setall.Value
        valu_relation_6.Value = valu_hero_setall.Value
        valu_relation_7.Value = valu_hero_setall.Value
        valu_relation_8.Value = valu_hero_setall.Value
        valu_relation_9.Value = valu_hero_setall.Value
        valu_relation_10.Value = valu_hero_setall.Value
        valu_relation_11.Value = valu_hero_setall.Value
        valu_relation_12.Value = valu_hero_setall.Value
        valu_relation_13.Value = valu_hero_setall.Value
        valu_relation_14.Value = valu_hero_setall.Value
        valu_relation_15.Value = valu_hero_setall.Value
        valu_relation_16.Value = valu_hero_setall.Value
        valu_relation_17.Value = valu_hero_setall.Value
        valu_relation_18.Value = valu_hero_setall.Value
        valu_relation_19.Value = valu_hero_setall.Value
        valu_relation_20.Value = valu_hero_setall.Value
        valu_relation_21.Value = valu_hero_setall.Value
        valu_relation_22.Value = valu_hero_setall.Value
        valu_relation_23.Value = valu_hero_setall.Value
        valu_relation_24.Value = valu_hero_setall.Value
        valu_relation_25.Value = valu_hero_setall.Value
    End Sub

    Private Sub Fea_dailyquest_Click(sender As Object, e As EventArgs) Handles Fea_dailyquest.Click
        Try
            Dim writer As New PackageIO.Writer(common, PackageIO.Endian.Little)
            writer.Position = &H7D8
            writer.WriteInt64(0)
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : Daily questions"
                fdialog.Msg.Text = "Daily questions is available"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Questions du jour"
                fdialog.Msg.Text = "Les questions du jour sont disponibles"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : Daily questions"
                fdialog.Msg.Text = "An error has occured"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : Questions du jour"
                fdialog.Msg.Text = "Une erreur est survenue"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Fea_dailyquest_MouseMove(sender As Object, e As EventArgs) Handles Fea_dailyquest.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to active daily questions"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour activer les questions du jour"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_dailyquest_MouseLeave(sender As Object, e As EventArgs) Handles Fea_dailyquest.MouseLeave
        Descrip_panel.Visible = False
    End Sub

    Private Sub Fea_ency_foods_Click(sender As Object, e As EventArgs) Handles Fea_ency_foods.Click
        Try
            Dim Writer As New PackageIO.Writer(common, Endian.Little)
            If Check_foods_unlock.Checked = True Then
                Writer.Position = &H218
                Writer.WriteHexString("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF0F")
            ElseIf Check_foods_reset.Checked = True Then
                Writer.Position = &H218
                Writer.WriteHexString("00000000000000000000000000000000000000000000000000")
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : unlock / reset foods"
                fdialog.Msg.Text = "All foods in encyclopedia has been unlocked / reset"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : débloquer / réinitialiser vivres"
                fdialog.Msg.Text = "Tous les vivres dans l'encyclopédie ont été débloqué / réinitialisé"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Title.Text = "Miitopia Save Editor : unlock / reset foods"
                fdialog.Msg.Text = "An error has occured" & vbNewLine & "please report this issue"
                fdialog.ShowDialog()
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Title.Text = "Miitopia Save Editor : débloquer / réinitialiser vivres"
                fdialog.Msg.Text = "Une erreur est survenue" & vbNewLine & "veuillez signaler cet erreur s'il vous plait"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Fea_ency_foods_MouseMove(sender As Object, e As EventArgs) Handles Fea_ency_foods.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Descrip_text.Text = "Click to unlock or reset all foods in encyclopedia"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Descrip_text.Text = "Cliquez pour débloquer ou réinitialiser les vivres dans l'encyclopédie"
        End If
        Descrip_panel.Visible = True
    End Sub

    Private Sub Fea_ency_foods_MouseLeave(sender As Object, e As EventArgs) Handles Fea_ency_foods.MouseLeave
        Descrip_panel.Visible = False
    End Sub
End Class