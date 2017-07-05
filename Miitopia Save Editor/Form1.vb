Public Class Form1
    Dim common As String
    Dim hero As String
    Dim fdialog As New Form2
    Dim Miiwarcry As String
    Dim Miishotg As String
    Dim Miiname As String
    Dim Miimoneysp As String
    Dim Miilosses As String
    Dim Miihteam As String
    Dim Miifoodeng As String
    Dim Miifight As String
    Dim Miiclass As String
    Dim Miibapv As String
    Dim Miibonpm As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
            fdialog.Label1.Text = "Miitopia Save Editor"
            fdialog.Label2.Text = "Open common.sav file" & vbNewLine & "Backup your save file before use" & vbNewLine & "Miitopia Save Editor"
            fdialog.ShowDialog()
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
            fdialog.Label1.Text = "Miitopia Save Editor"
            fdialog.Label2.Text = "Ouvrir le fichier common.sav" & vbNewLine & "Faites une copie de votre sauvegarde avant d'utiliser" & vbNewLine & "Miitopia Save Editor"
            fdialog.ShowDialog()
        End If
        open.Filter = "SAV files|*.sav"
        open.Title = "Open save common.sav"
        open.ShowDialog()
        common = open.FileName
        Readfilecommon()
    End Sub

    Private Sub Readfilecommon()
        Try
            Dim Reader As New PackageIO.Reader(common, PackageIO.Endian.Little)
            Reader.Position = &H28
            NumericUpDown3.Value = Reader.ReadUInt16
            Reader.Position = &H2A
            NumericUpDown4.Value = Reader.ReadUInt16
            Reader.Position = &H24
            NumericUpDown1.Value = Reader.ReadUInt32
            Reader.Position = &H83A
            NumericUpDown6.Value = Reader.ReadUInt16
            Reader.Position = &H130
            NumericUpDown5.Value = Reader.ReadUInt16
        Catch ex As Exception
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                fdialog.Label1.Text = "common.sav"
                fdialog.Label2.Text = "common.sav not load" & vbNewLine & "Save file can be corrupted or not Miitopia 'common.sav'"
                fdialog.ShowDialog()
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                fdialog.Label1.Text = "common.sav"
                fdialog.Label2.Text = "L'ouverture de common.sav a échoué" & vbNewLine & "La sauvegarde peut être corrompu ou n'est pas 'common.sav' de Miitopia"
                fdialog.ShowDialog()
            End If
            End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim open1 As New OpenFileDialog
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
            fdialog.Label1.Text = "Miitopia Save Editor"
            fdialog.Label2.Text = "Open hero.sav file" & vbNewLine & "Backup your save file before use" & vbNewLine & "Miitopia Save Editor"
            fdialog.ShowDialog()
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
            fdialog.Label1.Text = "Miitopia Save Editor"
            fdialog.Label2.Text = "Ouvrir le fichier hero.sav" & vbNewLine & "Faites une copie de votre sauvegarde avant d'utiliser" & vbNewLine & "Miitopia Save Editor"
            fdialog.ShowDialog()
        End If
        open1.Filter = "SAV files|*.sav"
        open1.Title = "Open save hero.sav"
        open1.ShowDialog()
        hero = open1.FileName
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim Reader As New PackageIO.Reader(hero, PackageIO.Endian.Little)
            If ComboBox4.SelectedItem = ComboBox4.Items.Item(0) Or ComboBox4.SelectedItem = ComboBox4.Items.Item(1) Then
                If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                    Reader.Position = &H70
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HC6
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H86
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H374
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H378
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H37C
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H380
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H384
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H388
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H38C
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H390
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                    Reader.Position = &H70 + &H398
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HC6 + &H398
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H86 + &H398
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H374 + &H398
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + &H398
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + &H398
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + &H398
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + &H398
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + &H398
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + &H398
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + &H398
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(2) Then
                    Reader.Position = &H70 + (&H398 * 2)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HC6 + (&H398 * 2)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H86 + (&H398 * 2)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H374 + (&H398 * 2)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 2)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 2)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 2)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 2)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 2)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 2)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 2)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(3) Then
                    Reader.Position = &H70 + (&H398 * 3)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HC6 + (&H398 * 3)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H86 + (&H398 * 3)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H374 + (&H398 * 3)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 3)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 3)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 3)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 3)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 3)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 3)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 3)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(4) Then
                    Reader.Position = &H70 + (&H398 * 4)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HC6 + (&H398 * 4)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H86 + (&H398 * 4)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H374 + (&H398 * 4)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 4)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 4)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 4)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 4)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 4)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 4)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 4)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(5) Then
                    Reader.Position = &H70 + (&H398 * 5)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HC6 + (&H398 * 5)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H86 + (&H398 * 5)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H374 + (&H398 * 5)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 5)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 5)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 5)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 5)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 5)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 5)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 5)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(6) Then
                    Reader.Position = &H70 + (&H398 * 6)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HC6 + (&H398 * 6)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H86 + (&H398 * 6)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H374 + (&H398 * 6)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 6)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 6)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 6)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 6)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 6)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 6)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 6)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(7) Then
                    Reader.Position = &H70 + (&H398 * 7)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HC6 + (&H398 * 7)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H86 + (&H398 * 7)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H374 + (&H398 * 7)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 7)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 7)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 7)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 7)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 7)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 7)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 7)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(8) Then
                    Reader.Position = &H70 + (&H398 * 8)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HC6 + (&H398 * 8)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H86 + (&H398 * 8)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H374 + (&H398 * 8)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 8)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 8)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 8)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 8)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 8)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 8)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 8)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(9) Then
                    Reader.Position = &H70 + (&H398 * 9)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HC6 + (&H398 * 9)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H86 + (&H398 * 9)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H374 + (&H398 * 9)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H378 + (&H398 * 9)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H37C + (&H398 * 9)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H380 + (&H398 * 9)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H384 + (&H398 * 9)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H388 + (&H398 * 9)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H38C + (&H398 * 9)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H390 + (&H398 * 9)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                End If
            End If

            If ComboBox4.SelectedItem = ComboBox4.Items.Item(2) Then
                If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                    Reader.Position = &H70
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HA6
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H8C
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H354
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H358
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H35C
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H360
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H364
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H368
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H36C
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H370
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                    Reader.Position = &H70 + &H378
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HA6 + &H378
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H8C + &H378
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H354 + &H378
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + &H378
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + &H378
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + &H378
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + &H378
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + &H378
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + &H378
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + &H378
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(2) Then
                    Reader.Position = &H70 + (&H378 * 2)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HA6 + (&H378 * 2)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H8C + (&H378 * 2)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H354 + (&H378 * 2)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 2)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 2)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 2)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 2)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 2)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 2)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 2)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(3) Then
                    Reader.Position = &H70 + (&H378 * 3)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HA6 + (&H378 * 3)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H8C + (&H378 * 3)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H354 + (&H378 * 3)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 3)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 3)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 3)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 3)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 3)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 3)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 3)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(4) Then
                    Reader.Position = &H70 + (&H378 * 4)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HA6 + (&H378 * 4)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H8C + (&H378 * 4)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H354 + (&H378 * 4)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 4)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 4)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 4)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 4)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 4)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 4)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 4)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(5) Then
                    Reader.Position = &H70 + (&H378 * 5)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HA6 + (&H378 * 5)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H8C + (&H378 * 5)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H354 + (&H378 * 5)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 5)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 5)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 5)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 5)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 5)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 5)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 5)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(6) Then
                    Reader.Position = &H70 + (&H378 * 6)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HA6 + (&H378 * 6)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H8C + (&H378 * 6)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H354 + (&H378 * 6)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 6)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 6)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 6)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 6)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 6)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 6)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 6)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(7) Then
                    Reader.Position = &H70 + (&H378 * 7)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HA6 + (&H378 * 7)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H8C + (&H378 * 7)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H354 + (&H378 * 7)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 7)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 7)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 7)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 7)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 7)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 7)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 7)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(8) Then
                    Reader.Position = &H70 + (&H378 * 8)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HA6 + (&H378 * 8)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H8C + (&H378 * 8)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H354 + (&H378 * 8)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 8)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 8)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 8)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 8)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 8)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 8)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 8)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(9) Then
                    Reader.Position = &H70 + (&H378 * 9)
                    Miiname = Reader.Position
                    TextBox2.Text = Reader.ReadUnicodeString(10)
                    Reader.Position = &HA6 + (&H378 * 9)
                    Miiclass = Reader.Position
                    NumericUpDown7.Value = Reader.ReadInt8
                    Reader.Position = &H8C + (&H378 * 9)
                    Miiwarcry = Reader.Position
                    TextBox1.Text = Reader.ReadUnicodeString(26)
                    Reader.Position = &H354 + (&H378 * 9)
                    Miifight = Reader.Position
                    NumericUpDown8.Value = Reader.ReadUInt32
                    Reader.Position = &H358 + (&H378 * 9)
                    Miishotg = Reader.Position
                    NumericUpDown9.Value = Reader.ReadUInt32
                    Reader.Position = &H35C + (&H378 * 9)
                    Miilosses = Reader.Position
                    NumericUpDown10.Value = Reader.ReadUInt32
                    Reader.Position = &H360 + (&H378 * 9)
                    Miihteam = Reader.Position
                    NumericUpDown11.Value = Reader.ReadUInt32
                    Reader.Position = &H364 + (&H378 * 9)
                    Miibapv = Reader.Position
                    NumericUpDown12.Value = Reader.ReadUInt32
                    Reader.Position = &H368 + (&H378 * 9)
                    Miibonpm = Reader.Position
                    NumericUpDown13.Value = Reader.ReadUInt32
                    Reader.Position = &H36C + (&H378 * 9)
                    Miifoodeng = Reader.Position
                    NumericUpDown14.Value = Reader.ReadUInt32
                    Reader.Position = &H370 + (&H378 * 9)
                    Miimoneysp = Reader.Position
                    NumericUpDown15.Value = Reader.ReadUInt32
                End If
            End If
            ComboBox4.Enabled = False
        Catch ex As Exception
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                fdialog.Label1.Text = "hero.sav : select Mii"
                fdialog.Label2.Text = "An error has occured, load hero.sav first"
                fdialog.ShowDialog()
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                fdialog.Label1.Text = "hero.sav : sélectionner Mii"
                fdialog.Label2.Text = "Une erreur est survenue, ouvrez hero.sav avant"
                fdialog.ShowDialog()
            End If
            ComboBox4.Enabled = True
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try
            Dim Writer As New PackageIO.Writer(common, PackageIO.Endian.Little)
            For i As Integer = 0 To 126
                Writer.Position = &H2C + i
                Writer.WriteInt8(NumericUpDown2.Value)
            Next
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                fdialog.Label1.Text = "common.sav : foods"
                fdialog.Label2.Text = "All foods has been unlocked"
                fdialog.ShowDialog()
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                fdialog.Label1.Text = "common.sav : nourritures"
                fdialog.Label2.Text = "Toutes les nourritures ont été débloquées"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                fdialog.Label1.Text = "common.sav : foods"
                fdialog.Label2.Text = "An error has occured, load common.sav first"
                fdialog.ShowDialog()
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                fdialog.Label1.Text = "common.sav : nourritures"
                fdialog.Label2.Text = "Une erreur est survenue, ouvrez common.sav avant"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As EventArgs) Handles PictureBox3.MouseMove
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        Label2.Visible = True
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
            Label2.Text = "Click to unlock all foods by numbers"
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
            Label2.Text = "Cliquez pour débloquer toutes les nourritures par nombres"
        End If
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BorderStyle = BorderStyle.None
        Label2.Visible = False
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Try
            Dim Writer As New PackageIO.Writer(common, PackageIO.Endian.Little)
            Writer.Position = &H100
            Writer.WriteUInt16(255)
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                fdialog.Label1.Text = "common.sav : salt shakers"
                fdialog.Label2.Text = "All salt shakers has been unlocked"
                fdialog.ShowDialog()
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                fdialog.Label1.Text = "common.sav : salières"
                fdialog.Label2.Text = "Toutes les salières ont été débloquées"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                fdialog.Label1.Text = "common.sav : salt shakers"
                fdialog.Label2.Text = "An error has occured, load common.sav first"
                fdialog.ShowDialog()
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                fdialog.Label1.Text = "common.sav : salières"
                fdialog.Label2.Text = "Une erreur est survenue, ouvrez common.sav avant"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub PictureBox7_MouseMove(sender As Object, e As EventArgs) Handles PictureBox7.MouseMove
        PictureBox7.BorderStyle = BorderStyle.None
        Label2.Visible = True
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
            Label2.Text = "Click to unlock all salt shakers"
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
            Label2.Text = "Cliquez pour débloquer toutes les salières"
        End If
    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave
        PictureBox7.BorderStyle = BorderStyle.FixedSingle
        Label2.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim Writer As New PackageIO.Writer(common, PackageIO.Endian.Little)
            Writer.Position = &H28
            Writer.WriteUInt16(NumericUpDown3.Value)
            Writer.Position = &H2A
            Writer.WriteUInt16(NumericUpDown4.Value)
            Writer.Position = &H24
            Writer.WriteUInt32(NumericUpDown1.Value)
            Writer.Position = &H83A
            Writer.WriteUInt16(NumericUpDown6.Value)
            Writer.Position = &H130
            Writer.WriteUInt16(NumericUpDown5.Value)
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                fdialog.Label1.Text = "Miitopia Save Editor : common.sav"
                fdialog.Label2.Text = "File save"
                fdialog.ShowDialog()
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                fdialog.Label1.Text = "Miitopia Save Editor : common.sav"
                fdialog.Label2.Text = "Fichier sauvegardé"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                fdialog.Label1.Text = "Miitopia Save Editor : common.sav"
                fdialog.Label2.Text = "An error has occured"
                fdialog.ShowDialog()
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                fdialog.Label1.Text = "Miitopia Save Editor : common.sav"
                fdialog.Label2.Text = "Une erreur est survenue"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub NumericUpDown7_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown7.ValueChanged
        If NumericUpDown7.Value = 0 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(1)
        ElseIf NumericUpDown7.Value = 1 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(2)
        ElseIf NumericUpDown7.Value = 2 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(3)
        ElseIf NumericUpDown7.Value = 3 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(4)
        ElseIf NumericUpDown7.Value = 4 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(5)
        ElseIf NumericUpDown7.Value = 5 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(6)
        ElseIf NumericUpDown7.Value = 6 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(7)
        ElseIf NumericUpDown7.Value = 7 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(8)
        ElseIf NumericUpDown7.Value = 8 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(9)
        ElseIf NumericUpDown7.Value = 9 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(10)
        ElseIf NumericUpDown7.Value = 10 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(11)
        ElseIf NumericUpDown7.Value = 11 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(12)
        ElseIf NumericUpDown7.Value = 12 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(13)
        ElseIf NumericUpDown7.Value = 13 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(14)
        ElseIf NumericUpDown7.Value = 14 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(15)
        ElseIf NumericUpDown7.Value = 255 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(0)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = ComboBox2.Items.Item(1) Then
            NumericUpDown7.Value = 0
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(2) Then
            NumericUpDown7.Value = 1
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(3) Then
            NumericUpDown7.Value = 2
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(4) Then
            NumericUpDown7.Value = 3
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(5) Then
            NumericUpDown7.Value = 4
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(6) Then
            NumericUpDown7.Value = 5
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(7) Then
            NumericUpDown7.Value = 6
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(8) Then
            NumericUpDown7.Value = 7
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(9) Then
            NumericUpDown7.Value = 8
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(10) Then
            NumericUpDown7.Value = 9
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(11) Then
            NumericUpDown7.Value = 10
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(12) Then
            NumericUpDown7.Value = 11
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(13) Then
            NumericUpDown7.Value = 12
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(14) Then
            NumericUpDown7.Value = 13
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(15) Then
            NumericUpDown7.Value = 14
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(0) Then
            NumericUpDown7.Value = 255
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.SelectedItem = ComboBox2.Items.Item(0)
        ComboBox3.SelectedItem = ComboBox3.Items.Item(0)
        ComboBox3.SelectedItem = My.Settings.langue
        ComboBox4.SelectedItem = ComboBox4.Items.Item(0)
        ComboBox4.SelectedItem = My.Settings.sauve
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        My.Settings.langue = ComboBox3.SelectedItem
        My.Settings.sauve = ComboBox4.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
            Label14.Text = TextBox2.Text & " Stats"
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
            Label14.Text = "Stats de " & TextBox2.Text
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim Writer As New PackageIO.Writer(hero, PackageIO.Endian.Little)
            If ComboBox4.SelectedItem = ComboBox4.Items.Item(0) Or ComboBox4.SelectedItem = ComboBox4.Items.Item(1) Then
                For i As Integer = 0 To 19
                    Writer.Position = Miiname + i
                    Writer.WriteInt8(0)
                Next
            ElseIf ComboBox4.SelectedItem = ComboBox4.Items.Item(2) Then
                For i As Integer = 0 To 11
                    Writer.Position = Miiname + i
                    Writer.WriteInt8(0)
                Next
            End If
            Writer.Position = Miiname
            Writer.WriteUnicodeString(TextBox2.Text)
            Writer.Position = Miiclass
            Writer.WriteInt8(NumericUpDown7.Value)
            If ComboBox4.SelectedItem = ComboBox4.Items.Item(0) Or ComboBox4.SelectedItem = ComboBox4.Items.Item(1) Then
                For i As Integer = 0 To 51
                    Writer.Position = Miiwarcry + i
                    Writer.WriteInt8(0)
                Next
            ElseIf ComboBox4.SelectedItem = ComboBox4.Items.Item(2) Then
                For i As Integer = 0 To 19
                    Writer.Position = Miiwarcry + i
                    Writer.WriteInt8(0)
                Next
            End If
            Writer.Position = Miiwarcry
            Writer.WriteUnicodeString(TextBox1.Text)
            Writer.Position = Miifight
            Writer.WriteUInt32(NumericUpDown8.Value)
            Writer.Position = Miishotg
            Writer.WriteUInt32(NumericUpDown9.Value)
            Writer.Position = Miilosses
            Writer.WriteUInt32(NumericUpDown10.Value)
            Writer.Position = Miihteam
            Writer.WriteUInt32(NumericUpDown11.Value)
            Writer.Position = Miibapv
            Writer.WriteUInt32(NumericUpDown12.Value)
            Writer.Position = Miibonpm
            Writer.WriteUInt32(NumericUpDown13.Value)
            Writer.Position = Miifoodeng
            Writer.WriteUInt32(NumericUpDown14.Value)
            Writer.Position = Miimoneysp
            Writer.WriteUInt32(NumericUpDown15.Value)
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                fdialog.Label1.Text = "Miitopia Save Editor : hero.sav"
                fdialog.Label2.Text = "File save"
                fdialog.ShowDialog()
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                fdialog.Label1.Text = "Miitopia Save Editor : hero.sav"
                fdialog.Label2.Text = "Fichier sauvegardé"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                fdialog.Label1.Text = "Miitopia Save Editor : hero.sav"
                fdialog.Label2.Text = "An error has occured, load hero.sav first"
                fdialog.ShowDialog()
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                fdialog.Label1.Text = "Miitopia Save Editor : hero.sav"
                fdialog.Label2.Text = "Une erreur est survenue, ouvrez hero.sav avant"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Form3.Show()
    End Sub

    Private Sub PictureBox8_MouseMove(sender As Object, e As EventArgs) Handles PictureBox8.MouseMove
        PictureBox8.BorderStyle = BorderStyle.FixedSingle
        Label2.Visible = True
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
            Label2.Text = "Click to see credits"
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
            Label2.Text = "Cliquez pour voir les crédits"
        End If
    End Sub

    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.BorderStyle = BorderStyle.None
        Label2.Visible = False
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
            TabPage3.Text = "Mii edit"
            TabPage4.Text = "Mii stats"
            Button1.Text = "Open"
            Button2.Text = "Save"
            Label16.Text = "Foods"
            Label15.Text = "Salt shakers"
            Label3.Text = "Rescued : "
            Button3.Text = "Open"
            Button4.Text = "Save"
            Label4.Text = "War cry :"
            Label5.Text = "Battles"
            Label6.Text = "Final blows"
            Label7.Text = "Defeats"
            Label8.Text = "Times left out of party"
            Label9.Text = "HP Bananas gobbled"
            Label10.Text = "MP Candies gulped"
            Label11.Text = "Grub grubbed"
            Label12.Text = "Gold grabbed"
            ComboBox2.Items.Item(0) = "(None)"
            ComboBox2.Items.Item(1) = "Warrior"
            ComboBox2.Items.Item(2) = "Mage"
            ComboBox2.Items.Item(3) = "Cleric"
            ComboBox2.Items.Item(4) = "Thief"
            ComboBox2.Items.Item(5) = "Pop Star B."
            ComboBox2.Items.Item(6) = "Pop Star G."
            ComboBox2.Items.Item(7) = "Vampire"
            ComboBox2.Items.Item(8) = "Chef"
            ComboBox2.Items.Item(9) = "Tank"
            ComboBox2.Items.Item(10) = "Imp"
            ComboBox2.Items.Item(11) = "Princess"
            ComboBox2.Items.Item(12) = "Flower"
            ComboBox2.Items.Item(13) = "Scientist"
            ComboBox2.Items.Item(14) = "Cat"
            ComboBox2.Items.Item(15) = "Elf"
            ComboBox4.Items.Item(0) = "EUR save file"
            ComboBox4.Items.Item(1) = "USA save file"
            ComboBox4.Items.Item(2) = "JPN save file"
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
            TabPage3.Text = "Edition Mii"
            TabPage4.Text = "Stats Mii"
            Button1.Text = "Ouvrir"
            Button2.Text = "Enregistrer"
            Label16.Text = "Nourritures"
            Label15.Text = "Salières"
            Label3.Text = "Sauvés : "
            Button3.Text = "Ouvrir"
            Button4.Text = "Enregistrer"
            Label4.Text = "Cri de guerre :"
            Label5.Text = "Combats"
            Label6.Text = "Coups de grâce"
            Label7.Text = "Défaites"
            Label8.Text = "Fois hors du groupe"
            Label9.Text = "Bananes PV dévorées"
            Label10.Text = "Bonbons PM avalés"
            Label11.Text = "Vivres englouties"
            Label12.Text = "Argent dépensé"
            ComboBox2.Items.Item(0) = "(Aucun)"
            ComboBox2.Items.Item(1) = "Guerrier"
            ComboBox2.Items.Item(2) = "Mage"
            ComboBox2.Items.Item(3) = "Prêtre"
            ComboBox2.Items.Item(4) = "Voleur"
            ComboBox2.Items.Item(5) = "Chanteur"
            ComboBox2.Items.Item(6) = "Chanteuse"
            ComboBox2.Items.Item(7) = "Vampire"
            ComboBox2.Items.Item(8) = "Cuisinier"
            ComboBox2.Items.Item(9) = "Tank"
            ComboBox2.Items.Item(10) = "Diablotin"
            ComboBox2.Items.Item(11) = "Princesse"
            ComboBox2.Items.Item(12) = "Fleur"
            ComboBox2.Items.Item(13) = "Scientifique"
            ComboBox2.Items.Item(14) = "Chat"
            ComboBox2.Items.Item(15) = "Elfe"
            ComboBox4.Items.Item(0) = "Sauvegarde EUR"
            ComboBox4.Items.Item(1) = "Sauvegarde USA"
            ComboBox4.Items.Item(2) = "Sauvegarde JPN"
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(0) Or ComboBox4.SelectedItem = ComboBox4.Items.Item(1) Then
            TextBox2.MaxLength = 10
            TextBox1.MaxLength = 26
        ElseIf ComboBox4.SelectedItem = ComboBox4.Items.Item(2) Then
            TextBox2.MaxLength = 6
            TextBox1.MaxLength = 10
        End If
    End Sub
End Class
