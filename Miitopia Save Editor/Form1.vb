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
    Dim applicationpath = Application.StartupPath
    Dim Tummy As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
            fdialog.Label1.Text = "Miitopia Save Editor"
            fdialog.Label2.Text = "Open common.sav file" & vbNewLine & "Miitopia Save Editor will make a backup of your save file" & vbNewLine & "Check ''bak'' folder"
            fdialog.ShowDialog()
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
            fdialog.Label1.Text = "Miitopia Save Editor"
            fdialog.Label2.Text = "Ouvrir le fichier common.sav" & vbNewLine & "Miitopia Save Editor va faire une copie de votre sauvegarde" & vbNewLine & "Vérifiez le dossier ''bak''"
            fdialog.ShowDialog()
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
            fdialog.Label1.Text = "Miitopia Save Editor"
            fdialog.Label2.Text = "Abre el archivo common.sav" & vbNewLine & "Miitopia Save Editor hará una copia de seguridad de su archivo de guardado" & vbNewLine & "Revisa la carpeta ''bak''"
            fdialog.ShowDialog()
        End If
        open.Filter = "SAV files|*common.sav"
        open.Title = "Open save common.sav"
        open.ShowDialog()
        common = open.FileName
        makebakcommon()
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
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
                fdialog.Label1.Text = "common.sav"
                fdialog.Label2.Text = "common.sav no ha sido cargado" & vbNewLine & "El archivo de guardado podría estar dañado o no es 'common.sav' de Miitopia"
                fdialog.ShowDialog()
            End If
            End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim open1 As New OpenFileDialog
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
            fdialog.Label1.Text = "Miitopia Save Editor"
            fdialog.Label2.Text = "Open hero.sav file" & vbNewLine & "Miitopia Save Editor will make a backup of your save file" & vbNewLine & "Check ''bak'' folder"
            fdialog.ShowDialog()
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
            fdialog.Label1.Text = "Miitopia Save Editor"
            fdialog.Label2.Text = "Abre el archivo hero.sav" & vbNewLine & "Miitopia Save Editor hará una copia de seguridad de su archivo de guardado" & vbNewLine & "Revisa la carpeta ''bak''"
            fdialog.ShowDialog()
        End If
        open1.Filter = "SAV files|*hero.sav"
        open1.Title = "Open save hero.sav"
        open1.ShowDialog()
        hero = open1.FileName
        makebakhero()
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
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
                fdialog.Label1.Text = "hero.sav: seleccione Mii"
                fdialog.Label2.Text = "Ha ocurrido un error, Abre primero el archivo common.sav"
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
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
                fdialog.Label1.Text = "common.sav : Papeos"
                fdialog.Label2.Text = "Todos los papeos han sido desbloqueados"
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
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
                fdialog.Label1.Text = "common.sav : Papeos"
                fdialog.Label2.Text = "Ha ocurrido un error, Abre primero el archivo common.sav"
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
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
            Label2.Text = "Haz clic para desbloquear todos los Papeos por números"
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
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
                fdialog.Label1.Text = "common.sav : Saleros"
                fdialog.Label2.Text = "Todos los Saleros han sido desbloqueados"
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
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
                fdialog.Label1.Text = "common.sav : Saleros"
                fdialog.Label2.Text = "Ha ocurrido un error, Abre primero el archivo common.sav"
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
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
            Label2.Text = "Haz clic para desbloquear todos los Saleros"
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
                fdialog.Label2.Text = "File saved"
                fdialog.ShowDialog()
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                fdialog.Label1.Text = "Miitopia Save Editor : common.sav"
                fdialog.Label2.Text = "Fichier sauvegardé"
                fdialog.ShowDialog()
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
                fdialog.Label1.Text = "Miitopia Save Editor : common.sav"
                fdialog.Label2.Text = "Archivo guardado"
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
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
                fdialog.Label1.Text = "Miitopia Save Editor : common.sav"
                fdialog.Label2.Text = "Ha ocurrido un error"
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
        ComboBox11.SelectedItem = ComboBox11.Items.Item(0)
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
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
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
            If CheckBox1.Checked = True Then
                Writer.Position = Tummy
                Writer.WriteInt8(NumericUpDown23.Value)
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                fdialog.Label1.Text = "Miitopia Save Editor : hero.sav"
                fdialog.Label2.Text = "File saved"
                fdialog.ShowDialog()
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                fdialog.Label1.Text = "Miitopia Save Editor : hero.sav"
                fdialog.Label2.Text = "Fichier sauvegardé"
                fdialog.ShowDialog()
            End If
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
                fdialog.Label1.Text = "Miitopia Save Editor : hero.sav"
                fdialog.Label2.Text = "Archivo guardado"
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
            If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
                fdialog.Label1.Text = "Miitopia Save Editor : hero.sav"
                fdialog.Label2.Text = "Ha ocurrido un error, Abre primero el archivo hero.sav"
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
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
            Label2.Text = "Haz clic para ver los créditos"
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
            TabPage5.Text = "Food boost"
            TabPage6.Text = "Main"
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
            Label17.Text = "Tickets"
            Label14.Text = "Stats"
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
            ComboBox4.Items.Item(0) = "EU save file"
            ComboBox4.Items.Item(1) = "US save file"
            ComboBox4.Items.Item(2) = "JP save file"
            Label23.Text = "Lv."
            Label13.Text = "HP"
            Label18.Text = "MP"
            Label19.Text = "Attack"
            Label22.Text = "Magic"
            Label21.Text = "Defense"
            Label20.Text = "Speed"
            Label24.Text = "Food boost"
            Label25.Text = "Tummy"
            CheckBox1.Text = "Set as :"
            ComboBox11.Items.Item(0) = "Empty"
            ComboBox11.Items.Item(1) = "Full"
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
            TabPage3.Text = "Édition Mii"
            TabPage4.Text = "Stats Mii"
            TabPage5.Text = "Boost nourriture"
            TabPage6.Text = "Principal"
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
            Label17.Text = "Tickets"
            Label14.Text = "Stats"
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
            ComboBox4.Items.Item(0) = "Sauvegarde EU"
            ComboBox4.Items.Item(1) = "Sauvegarde US"
            ComboBox4.Items.Item(2) = "Sauvegarde JP"
            Label23.Text = "Niv."
            Label13.Text = "PV"
            Label18.Text = "PM"
            Label19.Text = "Attaque"
            Label22.Text = "Magie"
            Label21.Text = "Défense"
            Label20.Text = "Vitesse"
            Label24.Text = "Boost nourriture"
            Label25.Text = "Ventre"
            CheckBox1.Text = "Définir comme :"
            ComboBox11.Items.Item(0) = "Vide"
            ComboBox11.Items.Item(1) = "Plein"
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
            TabPage3.Text = "Editar Mii"
            TabPage4.Text = "Estadísticas Mii"
            Button1.Text = "Abrir"
            Button2.Text = "Guardar"
            Label16.Text = "Papeos"
            Label15.Text = "Saleros"
            Label3.Text = "Rescates : "
            Button3.Text = "Abrir"
            Button4.Text = "Guardar"
            Label4.Text = "Grito de gerra :"
            Label5.Text = "Combates"
            Label6.Text = "Golpes de gracia"
            Label7.Text = "Derrotas"
            Label8.Text = "Veces fuera de la pandi"
            Label9.Text = "Plátanos PV zampados"
            Label10.Text = "Caramelos PM jalados"
            Label11.Text = "Papeo englutido"
            Label12.Text = "Gracmas recibidos"
            Label17.Text = "Boletos"
            Label14.Text = "Estadísticas"
            ComboBox2.Items.Item(0) = "(Ninguno)"
            ComboBox2.Items.Item(1) = "Guerrero"
            ComboBox2.Items.Item(2) = "Hechicero"
            ComboBox2.Items.Item(3) = "Clérigo"
            ComboBox2.Items.Item(4) = "Ladrón"
            ComboBox2.Items.Item(5) = "Cantante Chico"
            ComboBox2.Items.Item(6) = "Cantante Chica"
            ComboBox2.Items.Item(8) = "Chef"
            ComboBox2.Items.Item(9) = "Tanque"
            ComboBox2.Items.Item(10) = "Diablillo"
            ComboBox2.Items.Item(11) = "Princesa"
            ComboBox2.Items.Item(12) = "Flor"
            ComboBox2.Items.Item(13) = "Científico"
            ComboBox2.Items.Item(14) = "Gato"
            ComboBox2.Items.Item(7) = "Vampiro"
            ComboBox2.Items.Item(15) = "Elfo"
            ComboBox4.Items.Item(0) = "Archivo de guard. EU"
            ComboBox4.Items.Item(1) = "Archivo de guard. US"
            ComboBox4.Items.Item(2) = "Archivo de guard. JP"
            Label23.Text = "Niv."
            Label13.Text = "PV"
            Label18.Text = "PM"
            Label19.Text = "Ataque"
            Label22.Text = "Magia"
            Label21.Text = "Defensa"
            Label20.Text = "Velocidad"
            Label24.Text = "Alimentos impulso"
            Label25.Text = "Vientre"
            CheckBox1.Text = "Definir como :"
            ComboBox11.Items.Item(0) = "Vacío"
            ComboBox11.Items.Item(1) = "Pleno"
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If NumericUpDown16.Visible = False Then
            NumericUpDown16.Visible = True
            NumericUpDown17.Visible = True
            NumericUpDown18.Visible = True
            NumericUpDown19.Visible = True
            NumericUpDown20.Visible = True
            NumericUpDown21.Visible = True
            NumericUpDown22.Visible = True
        ElseIf NumericUpDown16.Visible = True Then
            NumericUpDown16.Visible = False
            NumericUpDown17.Visible = False
            NumericUpDown18.Visible = False
            NumericUpDown19.Visible = False
            NumericUpDown20.Visible = False
            NumericUpDown21.Visible = False
            NumericUpDown22.Visible = False
        End If
    End Sub

    Private Sub NumericUpDown16_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown16.ValueChanged
        Select Case NumericUpDown16.Value
            Case 0 To 79
                ComboBox5.SelectedItem = ComboBox5.Items.Item(0)
            Case 80 To 159
                ComboBox5.SelectedItem = ComboBox5.Items.Item(1)
            Case 160 To 239
                ComboBox5.SelectedItem = ComboBox5.Items.Item(2)
            Case 240 To 319
                ComboBox5.SelectedItem = ComboBox5.Items.Item(3)
            Case 320 To 399
                ComboBox5.SelectedItem = ComboBox5.Items.Item(4)
            Case 400 To 479
                ComboBox5.SelectedItem = ComboBox5.Items.Item(5)
            Case 480 To 559
                ComboBox5.SelectedItem = ComboBox5.Items.Item(6)
            Case 560 To 639
                ComboBox5.SelectedItem = ComboBox5.Items.Item(7)
            Case 640 To 719
                ComboBox5.SelectedItem = ComboBox5.Items.Item(8)
            Case 720 To 799
                ComboBox5.SelectedItem = ComboBox5.Items.Item(9)
            Case 800 To 879
                ComboBox5.SelectedItem = ComboBox5.Items.Item(10)
            Case 880 To 959
                ComboBox5.SelectedItem = ComboBox5.Items.Item(11)
            Case 960 To 1039
                ComboBox5.SelectedItem = ComboBox5.Items.Item(12)
            Case 1040 To 1119
                ComboBox5.SelectedItem = ComboBox5.Items.Item(13)
            Case 1120 To 1199
                ComboBox5.SelectedItem = ComboBox5.Items.Item(14)
            Case 1200 To 1279
                ComboBox5.SelectedItem = ComboBox5.Items.Item(15)
            Case 1280 To 1359
                ComboBox5.SelectedItem = ComboBox5.Items.Item(16)
            Case 1360 To 1439
                ComboBox5.SelectedItem = ComboBox5.Items.Item(17)
            Case 1440 To 1519
                ComboBox5.SelectedItem = ComboBox5.Items.Item(18)
            Case 1520 To 1599
                ComboBox5.SelectedItem = ComboBox5.Items.Item(19)
            Case 1600 To 1679
                ComboBox5.SelectedItem = ComboBox5.Items.Item(20)
            Case 1680 To 1759
                ComboBox5.SelectedItem = ComboBox5.Items.Item(21)
            Case 1760 To 1839
                ComboBox5.SelectedItem = ComboBox5.Items.Item(22)
            Case 1840 To 1919
                ComboBox5.SelectedItem = ComboBox5.Items.Item(23)
            Case 1920 To 1999
                ComboBox5.SelectedItem = ComboBox5.Items.Item(24)
            Case 2000 To 2079
                ComboBox5.SelectedItem = ComboBox5.Items.Item(25)
            Case 2080 To 2159
                ComboBox5.SelectedItem = ComboBox5.Items.Item(26)
            Case 2160 To 2239
                ComboBox5.SelectedItem = ComboBox5.Items.Item(27)
            Case 2240 To 2319
                ComboBox5.SelectedItem = ComboBox5.Items.Item(28)
            Case 2320 To 2399
                ComboBox5.SelectedItem = ComboBox5.Items.Item(29)
            Case 2400 To 2479
                ComboBox5.SelectedItem = ComboBox5.Items.Item(30)
            Case 2480 To 2559
                ComboBox5.SelectedItem = ComboBox5.Items.Item(31)
            Case 2560 To 2639
                ComboBox5.SelectedItem = ComboBox5.Items.Item(32)
            Case 2640 To 2719
                ComboBox5.SelectedItem = ComboBox5.Items.Item(33)
            Case 2720 To 2799
                ComboBox5.SelectedItem = ComboBox5.Items.Item(34)
            Case 2800 To 2879
                ComboBox5.SelectedItem = ComboBox5.Items.Item(35)
            Case 2880 To 2959
                ComboBox5.SelectedItem = ComboBox5.Items.Item(36)
            Case 2960 To 3039
                ComboBox5.SelectedItem = ComboBox5.Items.Item(37)
            Case 3040 To 3119
                ComboBox5.SelectedItem = ComboBox5.Items.Item(38)
            Case 3120 To 3199
                ComboBox5.SelectedItem = ComboBox5.Items.Item(39)
            Case 3200 To 3279
                ComboBox5.SelectedItem = ComboBox5.Items.Item(40)
            Case 3280 To 3359
                ComboBox5.SelectedItem = ComboBox5.Items.Item(41)
            Case 3360 To 3439
                ComboBox5.SelectedItem = ComboBox5.Items.Item(42)
            Case 3440 To 3519
                ComboBox5.SelectedItem = ComboBox5.Items.Item(43)
            Case 3520 To 3599
                ComboBox5.SelectedItem = ComboBox5.Items.Item(44)
            Case 3600 To 3679
                ComboBox5.SelectedItem = ComboBox5.Items.Item(45)
            Case 3680 To 3759
                ComboBox5.SelectedItem = ComboBox5.Items.Item(46)
            Case 3760 To 3839
                ComboBox5.SelectedItem = ComboBox5.Items.Item(47)
            Case 3840 To 3919
                ComboBox5.SelectedItem = ComboBox5.Items.Item(48)
            Case 3920 To 3999
                ComboBox5.SelectedItem = ComboBox5.Items.Item(49)
            Case 4000 To 4079
                ComboBox5.SelectedItem = ComboBox5.Items.Item(50)
            Case 4080 To 4159
                ComboBox5.SelectedItem = ComboBox5.Items.Item(51)
            Case 4160 To 4239
                ComboBox5.SelectedItem = ComboBox5.Items.Item(52)
            Case 4240 To 4319
                ComboBox5.SelectedItem = ComboBox5.Items.Item(53)
            Case 4320 To 4399
                ComboBox5.SelectedItem = ComboBox5.Items.Item(54)
            Case 4400 To 4479
                ComboBox5.SelectedItem = ComboBox5.Items.Item(55)
            Case 4480 To 4559
                ComboBox5.SelectedItem = ComboBox5.Items.Item(56)
            Case 4560 To 4639
                ComboBox5.SelectedItem = ComboBox5.Items.Item(57)
            Case 4640 To 4719
                ComboBox5.SelectedItem = ComboBox5.Items.Item(58)
            Case 4720 To 4799
                ComboBox5.SelectedItem = ComboBox5.Items.Item(59)
            Case 4800 To 4879
                ComboBox5.SelectedItem = ComboBox5.Items.Item(60)
            Case 4880 To 4959
                ComboBox5.SelectedItem = ComboBox5.Items.Item(61)
            Case 4960 To 5039
                ComboBox5.SelectedItem = ComboBox5.Items.Item(62)
            Case 5040 To 5119
                ComboBox5.SelectedItem = ComboBox5.Items.Item(63)
            Case 5120 To 5199
                ComboBox5.SelectedItem = ComboBox5.Items.Item(64)
            Case 5200 To 5279
                ComboBox5.SelectedItem = ComboBox5.Items.Item(65)
            Case 5280 To 5359
                ComboBox5.SelectedItem = ComboBox5.Items.Item(66)
            Case 5360 To 5439
                ComboBox5.SelectedItem = ComboBox5.Items.Item(67)
            Case 5440 To 5519
                ComboBox5.SelectedItem = ComboBox5.Items.Item(68)
            Case 5520 To 5599
                ComboBox5.SelectedItem = ComboBox5.Items.Item(69)
            Case 5600 To 5679
                ComboBox5.SelectedItem = ComboBox5.Items.Item(70)
            Case 5680 To 5759
                ComboBox5.SelectedItem = ComboBox5.Items.Item(71)
            Case 5760 To 5839
                ComboBox5.SelectedItem = ComboBox5.Items.Item(72)
            Case 5840 To 5919
                ComboBox5.SelectedItem = ComboBox5.Items.Item(73)
            Case 5920 To 5999
                ComboBox5.SelectedItem = ComboBox5.Items.Item(74)
            Case 6000 To 6079
                ComboBox5.SelectedItem = ComboBox5.Items.Item(75)
            Case 6080 To 6159
                ComboBox5.SelectedItem = ComboBox5.Items.Item(76)
            Case 6160 To 6239
                ComboBox5.SelectedItem = ComboBox5.Items.Item(77)
            Case 6240 To 6319
                ComboBox5.SelectedItem = ComboBox5.Items.Item(78)
            Case 6320 To 6399
                ComboBox5.SelectedItem = ComboBox5.Items.Item(79)
            Case 6400 To 6479
                ComboBox5.SelectedItem = ComboBox5.Items.Item(80)
            Case 6480 To 6559
                ComboBox5.SelectedItem = ComboBox5.Items.Item(81)
            Case 6560 To 6639
                ComboBox5.SelectedItem = ComboBox5.Items.Item(82)
            Case 6640 To 6719
                ComboBox5.SelectedItem = ComboBox5.Items.Item(83)
            Case 6720 To 6799
                ComboBox5.SelectedItem = ComboBox5.Items.Item(84)
            Case 6800 To 6879
                ComboBox5.SelectedItem = ComboBox5.Items.Item(85)
            Case 6880 To 6959
                ComboBox5.SelectedItem = ComboBox5.Items.Item(86)
            Case 6960 To 7039
                ComboBox5.SelectedItem = ComboBox5.Items.Item(87)
            Case 7040 To 7119
                ComboBox5.SelectedItem = ComboBox5.Items.Item(88)
            Case 7120 To 7199
                ComboBox5.SelectedItem = ComboBox5.Items.Item(89)
            Case 7200 To 7279
                ComboBox5.SelectedItem = ComboBox5.Items.Item(90)
            Case 7280 To 7359
                ComboBox5.SelectedItem = ComboBox5.Items.Item(91)
            Case 7360 To 7439
                ComboBox5.SelectedItem = ComboBox5.Items.Item(92)
            Case 7440 To 7519
                ComboBox5.SelectedItem = ComboBox5.Items.Item(93)
            Case 7520 To 7599
                ComboBox5.SelectedItem = ComboBox5.Items.Item(94)
            Case 7600 To 7679
                ComboBox5.SelectedItem = ComboBox5.Items.Item(95)
            Case 7680 To 7759
                ComboBox5.SelectedItem = ComboBox5.Items.Item(96)
            Case 7760 To 7839
                ComboBox5.SelectedItem = ComboBox5.Items.Item(97)
            Case 7840 To 7919
                ComboBox5.SelectedItem = ComboBox5.Items.Item(98)
            Case 7920 To 8000
                ComboBox5.SelectedItem = ComboBox5.Items.Item(99)
        End Select
    End Sub

    Private Sub NumericUpDown17_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown17.ValueChanged
        Select Case NumericUpDown17.Value
            Case 0 To 79
                ComboBox6.SelectedItem = ComboBox6.Items.Item(0)
            Case 80 To 159
                ComboBox6.SelectedItem = ComboBox6.Items.Item(1)
            Case 160 To 239
                ComboBox6.SelectedItem = ComboBox6.Items.Item(2)
            Case 240 To 319
                ComboBox6.SelectedItem = ComboBox6.Items.Item(3)
            Case 320 To 399
                ComboBox6.SelectedItem = ComboBox6.Items.Item(4)
            Case 400 To 479
                ComboBox6.SelectedItem = ComboBox6.Items.Item(5)
            Case 480 To 559
                ComboBox6.SelectedItem = ComboBox6.Items.Item(6)
            Case 560 To 639
                ComboBox6.SelectedItem = ComboBox6.Items.Item(7)
            Case 640 To 719
                ComboBox6.SelectedItem = ComboBox6.Items.Item(8)
            Case 720 To 799
                ComboBox6.SelectedItem = ComboBox6.Items.Item(9)
            Case 800 To 879
                ComboBox6.SelectedItem = ComboBox6.Items.Item(10)
            Case 880 To 959
                ComboBox6.SelectedItem = ComboBox6.Items.Item(11)
            Case 960 To 1039
                ComboBox6.SelectedItem = ComboBox6.Items.Item(12)
            Case 1040 To 1119
                ComboBox6.SelectedItem = ComboBox6.Items.Item(13)
            Case 1120 To 1199
                ComboBox6.SelectedItem = ComboBox6.Items.Item(14)
            Case 1200 To 1279
                ComboBox6.SelectedItem = ComboBox6.Items.Item(15)
            Case 1280 To 1359
                ComboBox6.SelectedItem = ComboBox6.Items.Item(16)
            Case 1360 To 1439
                ComboBox6.SelectedItem = ComboBox6.Items.Item(17)
            Case 1440 To 1519
                ComboBox6.SelectedItem = ComboBox6.Items.Item(18)
            Case 1520 To 1599
                ComboBox6.SelectedItem = ComboBox6.Items.Item(19)
            Case 1600 To 1679
                ComboBox6.SelectedItem = ComboBox6.Items.Item(20)
            Case 1680 To 1759
                ComboBox6.SelectedItem = ComboBox6.Items.Item(21)
            Case 1760 To 1839
                ComboBox6.SelectedItem = ComboBox6.Items.Item(22)
            Case 1840 To 1919
                ComboBox6.SelectedItem = ComboBox6.Items.Item(23)
            Case 1920 To 1999
                ComboBox6.SelectedItem = ComboBox6.Items.Item(24)
            Case 2000 To 2079
                ComboBox6.SelectedItem = ComboBox6.Items.Item(25)
            Case 2080 To 2159
                ComboBox6.SelectedItem = ComboBox6.Items.Item(26)
            Case 2160 To 2239
                ComboBox6.SelectedItem = ComboBox6.Items.Item(27)
            Case 2240 To 2319
                ComboBox6.SelectedItem = ComboBox6.Items.Item(28)
            Case 2320 To 2399
                ComboBox6.SelectedItem = ComboBox6.Items.Item(29)
            Case 2400 To 2479
                ComboBox6.SelectedItem = ComboBox6.Items.Item(30)
            Case 2480 To 2559
                ComboBox6.SelectedItem = ComboBox6.Items.Item(31)
            Case 2560 To 2639
                ComboBox6.SelectedItem = ComboBox6.Items.Item(32)
            Case 2640 To 2719
                ComboBox6.SelectedItem = ComboBox6.Items.Item(33)
            Case 2720 To 2799
                ComboBox6.SelectedItem = ComboBox6.Items.Item(34)
            Case 2800 To 2879
                ComboBox6.SelectedItem = ComboBox6.Items.Item(35)
            Case 2880 To 2959
                ComboBox6.SelectedItem = ComboBox6.Items.Item(36)
            Case 2960 To 3039
                ComboBox6.SelectedItem = ComboBox6.Items.Item(37)
            Case 3040 To 3119
                ComboBox6.SelectedItem = ComboBox6.Items.Item(38)
            Case 3120 To 3199
                ComboBox6.SelectedItem = ComboBox6.Items.Item(39)
            Case 3200 To 3279
                ComboBox6.SelectedItem = ComboBox6.Items.Item(40)
            Case 3280 To 3359
                ComboBox6.SelectedItem = ComboBox6.Items.Item(41)
            Case 3360 To 3439
                ComboBox6.SelectedItem = ComboBox6.Items.Item(42)
            Case 3440 To 3519
                ComboBox6.SelectedItem = ComboBox6.Items.Item(43)
            Case 3520 To 3599
                ComboBox6.SelectedItem = ComboBox6.Items.Item(44)
            Case 3600 To 3679
                ComboBox6.SelectedItem = ComboBox6.Items.Item(45)
            Case 3680 To 3759
                ComboBox6.SelectedItem = ComboBox6.Items.Item(46)
            Case 3760 To 3839
                ComboBox6.SelectedItem = ComboBox6.Items.Item(47)
            Case 3840 To 3919
                ComboBox6.SelectedItem = ComboBox6.Items.Item(48)
            Case 3920 To 3999
                ComboBox6.SelectedItem = ComboBox6.Items.Item(49)
            Case 4000 To 4079
                ComboBox6.SelectedItem = ComboBox6.Items.Item(50)
            Case 4080 To 4159
                ComboBox6.SelectedItem = ComboBox6.Items.Item(51)
            Case 4160 To 4239
                ComboBox6.SelectedItem = ComboBox6.Items.Item(52)
            Case 4240 To 4319
                ComboBox6.SelectedItem = ComboBox6.Items.Item(53)
            Case 4320 To 4399
                ComboBox6.SelectedItem = ComboBox6.Items.Item(54)
            Case 4400 To 4479
                ComboBox6.SelectedItem = ComboBox6.Items.Item(55)
            Case 4480 To 4559
                ComboBox6.SelectedItem = ComboBox6.Items.Item(56)
            Case 4560 To 4639
                ComboBox6.SelectedItem = ComboBox6.Items.Item(57)
            Case 4640 To 4719
                ComboBox6.SelectedItem = ComboBox6.Items.Item(58)
            Case 4720 To 4799
                ComboBox6.SelectedItem = ComboBox6.Items.Item(59)
            Case 4800 To 4879
                ComboBox6.SelectedItem = ComboBox6.Items.Item(60)
            Case 4880 To 4959
                ComboBox6.SelectedItem = ComboBox6.Items.Item(61)
            Case 4960 To 5039
                ComboBox6.SelectedItem = ComboBox6.Items.Item(62)
            Case 5040 To 5119
                ComboBox6.SelectedItem = ComboBox6.Items.Item(63)
            Case 5120 To 5199
                ComboBox6.SelectedItem = ComboBox6.Items.Item(64)
            Case 5200 To 5279
                ComboBox6.SelectedItem = ComboBox6.Items.Item(65)
            Case 5280 To 5359
                ComboBox6.SelectedItem = ComboBox6.Items.Item(66)
            Case 5360 To 5439
                ComboBox6.SelectedItem = ComboBox6.Items.Item(67)
            Case 5440 To 5519
                ComboBox6.SelectedItem = ComboBox6.Items.Item(68)
            Case 5520 To 5599
                ComboBox6.SelectedItem = ComboBox6.Items.Item(69)
            Case 5600 To 5679
                ComboBox6.SelectedItem = ComboBox6.Items.Item(70)
            Case 5680 To 5759
                ComboBox6.SelectedItem = ComboBox6.Items.Item(71)
            Case 5760 To 5839
                ComboBox6.SelectedItem = ComboBox6.Items.Item(72)
            Case 5840 To 5919
                ComboBox6.SelectedItem = ComboBox6.Items.Item(73)
            Case 5920 To 5999
                ComboBox6.SelectedItem = ComboBox6.Items.Item(74)
            Case 6000 To 6079
                ComboBox6.SelectedItem = ComboBox6.Items.Item(75)
            Case 6080 To 6159
                ComboBox6.SelectedItem = ComboBox6.Items.Item(76)
            Case 6160 To 6239
                ComboBox6.SelectedItem = ComboBox6.Items.Item(77)
            Case 6240 To 6319
                ComboBox6.SelectedItem = ComboBox6.Items.Item(78)
            Case 6320 To 6399
                ComboBox6.SelectedItem = ComboBox6.Items.Item(79)
            Case 6400 To 6479
                ComboBox6.SelectedItem = ComboBox6.Items.Item(80)
            Case 6480 To 6559
                ComboBox6.SelectedItem = ComboBox6.Items.Item(81)
            Case 6560 To 6639
                ComboBox6.SelectedItem = ComboBox6.Items.Item(82)
            Case 6640 To 6719
                ComboBox6.SelectedItem = ComboBox6.Items.Item(83)
            Case 6720 To 6799
                ComboBox6.SelectedItem = ComboBox6.Items.Item(84)
            Case 6800 To 6879
                ComboBox6.SelectedItem = ComboBox6.Items.Item(85)
            Case 6880 To 6959
                ComboBox6.SelectedItem = ComboBox6.Items.Item(86)
            Case 6960 To 7039
                ComboBox6.SelectedItem = ComboBox6.Items.Item(87)
            Case 7040 To 7119
                ComboBox6.SelectedItem = ComboBox6.Items.Item(88)
            Case 7120 To 7199
                ComboBox6.SelectedItem = ComboBox6.Items.Item(89)
            Case 7200 To 7279
                ComboBox6.SelectedItem = ComboBox6.Items.Item(90)
            Case 7280 To 7359
                ComboBox6.SelectedItem = ComboBox6.Items.Item(91)
            Case 7360 To 7439
                ComboBox6.SelectedItem = ComboBox6.Items.Item(92)
            Case 7440 To 7519
                ComboBox6.SelectedItem = ComboBox6.Items.Item(93)
            Case 7520 To 7599
                ComboBox6.SelectedItem = ComboBox6.Items.Item(94)
            Case 7600 To 7679
                ComboBox6.SelectedItem = ComboBox6.Items.Item(95)
            Case 7680 To 7759
                ComboBox6.SelectedItem = ComboBox6.Items.Item(96)
            Case 7760 To 7839
                ComboBox6.SelectedItem = ComboBox6.Items.Item(97)
            Case 7840 To 7919
                ComboBox6.SelectedItem = ComboBox6.Items.Item(98)
            Case 7920 To 8000
                ComboBox6.SelectedItem = ComboBox6.Items.Item(99)
        End Select
    End Sub

    Private Sub NumericUpDown18_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown18.ValueChanged
        Select Case NumericUpDown18.Value
            Case 0 To 79
                ComboBox7.SelectedItem = ComboBox7.Items.Item(0)
            Case 80 To 159
                ComboBox7.SelectedItem = ComboBox7.Items.Item(1)
            Case 160 To 239
                ComboBox7.SelectedItem = ComboBox7.Items.Item(2)
            Case 240 To 319
                ComboBox7.SelectedItem = ComboBox7.Items.Item(3)
            Case 320 To 399
                ComboBox7.SelectedItem = ComboBox7.Items.Item(4)
            Case 400 To 479
                ComboBox7.SelectedItem = ComboBox7.Items.Item(5)
            Case 480 To 559
                ComboBox7.SelectedItem = ComboBox7.Items.Item(6)
            Case 560 To 639
                ComboBox7.SelectedItem = ComboBox7.Items.Item(7)
            Case 640 To 719
                ComboBox7.SelectedItem = ComboBox7.Items.Item(8)
            Case 720 To 799
                ComboBox7.SelectedItem = ComboBox7.Items.Item(9)
            Case 800 To 879
                ComboBox7.SelectedItem = ComboBox7.Items.Item(10)
            Case 880 To 959
                ComboBox7.SelectedItem = ComboBox7.Items.Item(11)
            Case 960 To 1039
                ComboBox7.SelectedItem = ComboBox7.Items.Item(12)
            Case 1040 To 1119
                ComboBox7.SelectedItem = ComboBox7.Items.Item(13)
            Case 1120 To 1199
                ComboBox7.SelectedItem = ComboBox7.Items.Item(14)
            Case 1200 To 1279
                ComboBox7.SelectedItem = ComboBox7.Items.Item(15)
            Case 1280 To 1359
                ComboBox7.SelectedItem = ComboBox7.Items.Item(16)
            Case 1360 To 1439
                ComboBox7.SelectedItem = ComboBox7.Items.Item(17)
            Case 1440 To 1519
                ComboBox7.SelectedItem = ComboBox7.Items.Item(18)
            Case 1520 To 1599
                ComboBox7.SelectedItem = ComboBox7.Items.Item(19)
            Case 1600 To 1679
                ComboBox7.SelectedItem = ComboBox7.Items.Item(20)
            Case 1680 To 1759
                ComboBox7.SelectedItem = ComboBox7.Items.Item(21)
            Case 1760 To 1839
                ComboBox7.SelectedItem = ComboBox7.Items.Item(22)
            Case 1840 To 1919
                ComboBox7.SelectedItem = ComboBox7.Items.Item(23)
            Case 1920 To 1999
                ComboBox7.SelectedItem = ComboBox7.Items.Item(24)
            Case 2000 To 2079
                ComboBox7.SelectedItem = ComboBox7.Items.Item(25)
            Case 2080 To 2159
                ComboBox7.SelectedItem = ComboBox7.Items.Item(26)
            Case 2160 To 2239
                ComboBox7.SelectedItem = ComboBox7.Items.Item(27)
            Case 2240 To 2319
                ComboBox7.SelectedItem = ComboBox7.Items.Item(28)
            Case 2320 To 2399
                ComboBox7.SelectedItem = ComboBox7.Items.Item(29)
            Case 2400 To 2479
                ComboBox7.SelectedItem = ComboBox7.Items.Item(30)
            Case 2480 To 2559
                ComboBox7.SelectedItem = ComboBox7.Items.Item(31)
            Case 2560 To 2639
                ComboBox7.SelectedItem = ComboBox7.Items.Item(32)
            Case 2640 To 2719
                ComboBox7.SelectedItem = ComboBox7.Items.Item(33)
            Case 2720 To 2799
                ComboBox7.SelectedItem = ComboBox7.Items.Item(34)
            Case 2800 To 2879
                ComboBox7.SelectedItem = ComboBox7.Items.Item(35)
            Case 2880 To 2959
                ComboBox7.SelectedItem = ComboBox7.Items.Item(36)
            Case 2960 To 3039
                ComboBox7.SelectedItem = ComboBox7.Items.Item(37)
            Case 3040 To 3119
                ComboBox7.SelectedItem = ComboBox7.Items.Item(38)
            Case 3120 To 3199
                ComboBox7.SelectedItem = ComboBox7.Items.Item(39)
            Case 3200 To 3279
                ComboBox7.SelectedItem = ComboBox7.Items.Item(40)
            Case 3280 To 3359
                ComboBox7.SelectedItem = ComboBox7.Items.Item(41)
            Case 3360 To 3439
                ComboBox7.SelectedItem = ComboBox7.Items.Item(42)
            Case 3440 To 3519
                ComboBox7.SelectedItem = ComboBox7.Items.Item(43)
            Case 3520 To 3599
                ComboBox7.SelectedItem = ComboBox7.Items.Item(44)
            Case 3600 To 3679
                ComboBox7.SelectedItem = ComboBox7.Items.Item(45)
            Case 3680 To 3759
                ComboBox7.SelectedItem = ComboBox7.Items.Item(46)
            Case 3760 To 3839
                ComboBox7.SelectedItem = ComboBox7.Items.Item(47)
            Case 3840 To 3919
                ComboBox7.SelectedItem = ComboBox7.Items.Item(48)
            Case 3920 To 3999
                ComboBox7.SelectedItem = ComboBox7.Items.Item(49)
            Case 4000 To 4079
                ComboBox7.SelectedItem = ComboBox7.Items.Item(50)
            Case 4080 To 4159
                ComboBox7.SelectedItem = ComboBox7.Items.Item(51)
            Case 4160 To 4239
                ComboBox7.SelectedItem = ComboBox7.Items.Item(52)
            Case 4240 To 4319
                ComboBox7.SelectedItem = ComboBox7.Items.Item(53)
            Case 4320 To 4399
                ComboBox7.SelectedItem = ComboBox7.Items.Item(54)
            Case 4400 To 4479
                ComboBox7.SelectedItem = ComboBox7.Items.Item(55)
            Case 4480 To 4559
                ComboBox7.SelectedItem = ComboBox7.Items.Item(56)
            Case 4560 To 4639
                ComboBox7.SelectedItem = ComboBox7.Items.Item(57)
            Case 4640 To 4719
                ComboBox7.SelectedItem = ComboBox7.Items.Item(58)
            Case 4720 To 4799
                ComboBox7.SelectedItem = ComboBox7.Items.Item(59)
            Case 4800 To 4879
                ComboBox7.SelectedItem = ComboBox7.Items.Item(60)
            Case 4880 To 4959
                ComboBox7.SelectedItem = ComboBox7.Items.Item(61)
            Case 4960 To 5039
                ComboBox7.SelectedItem = ComboBox7.Items.Item(62)
            Case 5040 To 5119
                ComboBox7.SelectedItem = ComboBox7.Items.Item(63)
            Case 5120 To 5199
                ComboBox7.SelectedItem = ComboBox7.Items.Item(64)
            Case 5200 To 5279
                ComboBox7.SelectedItem = ComboBox7.Items.Item(65)
            Case 5280 To 5359
                ComboBox7.SelectedItem = ComboBox7.Items.Item(66)
            Case 5360 To 5439
                ComboBox7.SelectedItem = ComboBox7.Items.Item(67)
            Case 5440 To 5519
                ComboBox7.SelectedItem = ComboBox7.Items.Item(68)
            Case 5520 To 5599
                ComboBox7.SelectedItem = ComboBox7.Items.Item(69)
            Case 5600 To 5679
                ComboBox7.SelectedItem = ComboBox7.Items.Item(70)
            Case 5680 To 5759
                ComboBox7.SelectedItem = ComboBox7.Items.Item(71)
            Case 5760 To 5839
                ComboBox7.SelectedItem = ComboBox7.Items.Item(72)
            Case 5840 To 5919
                ComboBox7.SelectedItem = ComboBox7.Items.Item(73)
            Case 5920 To 5999
                ComboBox7.SelectedItem = ComboBox7.Items.Item(74)
            Case 6000 To 6079
                ComboBox7.SelectedItem = ComboBox7.Items.Item(75)
            Case 6080 To 6159
                ComboBox7.SelectedItem = ComboBox7.Items.Item(76)
            Case 6160 To 6239
                ComboBox7.SelectedItem = ComboBox7.Items.Item(77)
            Case 6240 To 6319
                ComboBox7.SelectedItem = ComboBox7.Items.Item(78)
            Case 6320 To 6399
                ComboBox7.SelectedItem = ComboBox7.Items.Item(79)
            Case 6400 To 6479
                ComboBox7.SelectedItem = ComboBox7.Items.Item(80)
            Case 6480 To 6559
                ComboBox7.SelectedItem = ComboBox7.Items.Item(81)
            Case 6560 To 6639
                ComboBox7.SelectedItem = ComboBox7.Items.Item(82)
            Case 6640 To 6719
                ComboBox7.SelectedItem = ComboBox7.Items.Item(83)
            Case 6720 To 6799
                ComboBox7.SelectedItem = ComboBox7.Items.Item(84)
            Case 6800 To 6879
                ComboBox7.SelectedItem = ComboBox7.Items.Item(85)
            Case 6880 To 6959
                ComboBox7.SelectedItem = ComboBox7.Items.Item(86)
            Case 6960 To 7039
                ComboBox7.SelectedItem = ComboBox7.Items.Item(87)
            Case 7040 To 7119
                ComboBox7.SelectedItem = ComboBox7.Items.Item(88)
            Case 7120 To 7199
                ComboBox7.SelectedItem = ComboBox7.Items.Item(89)
            Case 7200 To 7279
                ComboBox7.SelectedItem = ComboBox7.Items.Item(90)
            Case 7280 To 7359
                ComboBox7.SelectedItem = ComboBox7.Items.Item(91)
            Case 7360 To 7439
                ComboBox7.SelectedItem = ComboBox7.Items.Item(92)
            Case 7440 To 7519
                ComboBox7.SelectedItem = ComboBox7.Items.Item(93)
            Case 7520 To 7599
                ComboBox7.SelectedItem = ComboBox7.Items.Item(94)
            Case 7600 To 7679
                ComboBox7.SelectedItem = ComboBox7.Items.Item(95)
            Case 7680 To 7759
                ComboBox7.SelectedItem = ComboBox7.Items.Item(96)
            Case 7760 To 7839
                ComboBox7.SelectedItem = ComboBox7.Items.Item(97)
            Case 7840 To 7919
                ComboBox7.SelectedItem = ComboBox7.Items.Item(98)
            Case 7920 To 8000
                ComboBox7.SelectedItem = ComboBox7.Items.Item(99)
        End Select
    End Sub

    Private Sub NumericUpDown21_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown21.ValueChanged
        Select Case NumericUpDown21.Value
            Case 0 To 79
                ComboBox8.SelectedItem = ComboBox8.Items.Item(0)
            Case 80 To 159
                ComboBox8.SelectedItem = ComboBox8.Items.Item(1)
            Case 160 To 239
                ComboBox8.SelectedItem = ComboBox8.Items.Item(2)
            Case 240 To 319
                ComboBox8.SelectedItem = ComboBox8.Items.Item(3)
            Case 320 To 399
                ComboBox8.SelectedItem = ComboBox8.Items.Item(4)
            Case 400 To 479
                ComboBox8.SelectedItem = ComboBox8.Items.Item(5)
            Case 480 To 559
                ComboBox8.SelectedItem = ComboBox8.Items.Item(6)
            Case 560 To 639
                ComboBox8.SelectedItem = ComboBox8.Items.Item(7)
            Case 640 To 719
                ComboBox8.SelectedItem = ComboBox8.Items.Item(8)
            Case 720 To 799
                ComboBox8.SelectedItem = ComboBox8.Items.Item(9)
            Case 800 To 879
                ComboBox8.SelectedItem = ComboBox8.Items.Item(10)
            Case 880 To 959
                ComboBox8.SelectedItem = ComboBox8.Items.Item(11)
            Case 960 To 1039
                ComboBox8.SelectedItem = ComboBox8.Items.Item(12)
            Case 1040 To 1119
                ComboBox8.SelectedItem = ComboBox8.Items.Item(13)
            Case 1120 To 1199
                ComboBox8.SelectedItem = ComboBox8.Items.Item(14)
            Case 1200 To 1279
                ComboBox8.SelectedItem = ComboBox8.Items.Item(15)
            Case 1280 To 1359
                ComboBox8.SelectedItem = ComboBox8.Items.Item(16)
            Case 1360 To 1439
                ComboBox8.SelectedItem = ComboBox8.Items.Item(17)
            Case 1440 To 1519
                ComboBox8.SelectedItem = ComboBox8.Items.Item(18)
            Case 1520 To 1599
                ComboBox8.SelectedItem = ComboBox8.Items.Item(19)
            Case 1600 To 1679
                ComboBox8.SelectedItem = ComboBox8.Items.Item(20)
            Case 1680 To 1759
                ComboBox8.SelectedItem = ComboBox8.Items.Item(21)
            Case 1760 To 1839
                ComboBox8.SelectedItem = ComboBox8.Items.Item(22)
            Case 1840 To 1919
                ComboBox8.SelectedItem = ComboBox8.Items.Item(23)
            Case 1920 To 1999
                ComboBox8.SelectedItem = ComboBox8.Items.Item(24)
            Case 2000 To 2079
                ComboBox8.SelectedItem = ComboBox8.Items.Item(25)
            Case 2080 To 2159
                ComboBox8.SelectedItem = ComboBox8.Items.Item(26)
            Case 2160 To 2239
                ComboBox8.SelectedItem = ComboBox8.Items.Item(27)
            Case 2240 To 2319
                ComboBox8.SelectedItem = ComboBox8.Items.Item(28)
            Case 2320 To 2399
                ComboBox8.SelectedItem = ComboBox8.Items.Item(29)
            Case 2400 To 2479
                ComboBox8.SelectedItem = ComboBox8.Items.Item(30)
            Case 2480 To 2559
                ComboBox8.SelectedItem = ComboBox8.Items.Item(31)
            Case 2560 To 2639
                ComboBox8.SelectedItem = ComboBox8.Items.Item(32)
            Case 2640 To 2719
                ComboBox8.SelectedItem = ComboBox8.Items.Item(33)
            Case 2720 To 2799
                ComboBox8.SelectedItem = ComboBox8.Items.Item(34)
            Case 2800 To 2879
                ComboBox8.SelectedItem = ComboBox8.Items.Item(35)
            Case 2880 To 2959
                ComboBox8.SelectedItem = ComboBox8.Items.Item(36)
            Case 2960 To 3039
                ComboBox8.SelectedItem = ComboBox8.Items.Item(37)
            Case 3040 To 3119
                ComboBox8.SelectedItem = ComboBox8.Items.Item(38)
            Case 3120 To 3199
                ComboBox8.SelectedItem = ComboBox8.Items.Item(39)
            Case 3200 To 3279
                ComboBox8.SelectedItem = ComboBox8.Items.Item(40)
            Case 3280 To 3359
                ComboBox8.SelectedItem = ComboBox8.Items.Item(41)
            Case 3360 To 3439
                ComboBox8.SelectedItem = ComboBox8.Items.Item(42)
            Case 3440 To 3519
                ComboBox8.SelectedItem = ComboBox8.Items.Item(43)
            Case 3520 To 3599
                ComboBox8.SelectedItem = ComboBox8.Items.Item(44)
            Case 3600 To 3679
                ComboBox8.SelectedItem = ComboBox8.Items.Item(45)
            Case 3680 To 3759
                ComboBox8.SelectedItem = ComboBox8.Items.Item(46)
            Case 3760 To 3839
                ComboBox8.SelectedItem = ComboBox8.Items.Item(47)
            Case 3840 To 3919
                ComboBox8.SelectedItem = ComboBox8.Items.Item(48)
            Case 3920 To 3999
                ComboBox8.SelectedItem = ComboBox8.Items.Item(49)
            Case 4000 To 4079
                ComboBox8.SelectedItem = ComboBox8.Items.Item(50)
            Case 4080 To 4159
                ComboBox8.SelectedItem = ComboBox8.Items.Item(51)
            Case 4160 To 4239
                ComboBox8.SelectedItem = ComboBox8.Items.Item(52)
            Case 4240 To 4319
                ComboBox8.SelectedItem = ComboBox8.Items.Item(53)
            Case 4320 To 4399
                ComboBox8.SelectedItem = ComboBox8.Items.Item(54)
            Case 4400 To 4479
                ComboBox8.SelectedItem = ComboBox8.Items.Item(55)
            Case 4480 To 4559
                ComboBox8.SelectedItem = ComboBox8.Items.Item(56)
            Case 4560 To 4639
                ComboBox8.SelectedItem = ComboBox8.Items.Item(57)
            Case 4640 To 4719
                ComboBox8.SelectedItem = ComboBox8.Items.Item(58)
            Case 4720 To 4799
                ComboBox8.SelectedItem = ComboBox8.Items.Item(59)
            Case 4800 To 4879
                ComboBox8.SelectedItem = ComboBox8.Items.Item(60)
            Case 4880 To 4959
                ComboBox8.SelectedItem = ComboBox8.Items.Item(61)
            Case 4960 To 5039
                ComboBox8.SelectedItem = ComboBox8.Items.Item(62)
            Case 5040 To 5119
                ComboBox8.SelectedItem = ComboBox8.Items.Item(63)
            Case 5120 To 5199
                ComboBox8.SelectedItem = ComboBox8.Items.Item(64)
            Case 5200 To 5279
                ComboBox8.SelectedItem = ComboBox8.Items.Item(65)
            Case 5280 To 5359
                ComboBox8.SelectedItem = ComboBox8.Items.Item(66)
            Case 5360 To 5439
                ComboBox8.SelectedItem = ComboBox8.Items.Item(67)
            Case 5440 To 5519
                ComboBox8.SelectedItem = ComboBox8.Items.Item(68)
            Case 5520 To 5599
                ComboBox8.SelectedItem = ComboBox8.Items.Item(69)
            Case 5600 To 5679
                ComboBox8.SelectedItem = ComboBox8.Items.Item(70)
            Case 5680 To 5759
                ComboBox8.SelectedItem = ComboBox8.Items.Item(71)
            Case 5760 To 5839
                ComboBox8.SelectedItem = ComboBox8.Items.Item(72)
            Case 5840 To 5919
                ComboBox8.SelectedItem = ComboBox8.Items.Item(73)
            Case 5920 To 5999
                ComboBox8.SelectedItem = ComboBox8.Items.Item(74)
            Case 6000 To 6079
                ComboBox8.SelectedItem = ComboBox8.Items.Item(75)
            Case 6080 To 6159
                ComboBox8.SelectedItem = ComboBox8.Items.Item(76)
            Case 6160 To 6239
                ComboBox8.SelectedItem = ComboBox8.Items.Item(77)
            Case 6240 To 6319
                ComboBox8.SelectedItem = ComboBox8.Items.Item(78)
            Case 6320 To 6399
                ComboBox8.SelectedItem = ComboBox8.Items.Item(79)
            Case 6400 To 6479
                ComboBox8.SelectedItem = ComboBox8.Items.Item(80)
            Case 6480 To 6559
                ComboBox8.SelectedItem = ComboBox8.Items.Item(81)
            Case 6560 To 6639
                ComboBox8.SelectedItem = ComboBox8.Items.Item(82)
            Case 6640 To 6719
                ComboBox8.SelectedItem = ComboBox8.Items.Item(83)
            Case 6720 To 6799
                ComboBox8.SelectedItem = ComboBox8.Items.Item(84)
            Case 6800 To 6879
                ComboBox8.SelectedItem = ComboBox8.Items.Item(85)
            Case 6880 To 6959
                ComboBox8.SelectedItem = ComboBox8.Items.Item(86)
            Case 6960 To 7039
                ComboBox8.SelectedItem = ComboBox8.Items.Item(87)
            Case 7040 To 7119
                ComboBox8.SelectedItem = ComboBox8.Items.Item(88)
            Case 7120 To 7199
                ComboBox8.SelectedItem = ComboBox8.Items.Item(89)
            Case 7200 To 7279
                ComboBox8.SelectedItem = ComboBox8.Items.Item(90)
            Case 7280 To 7359
                ComboBox8.SelectedItem = ComboBox8.Items.Item(91)
            Case 7360 To 7439
                ComboBox8.SelectedItem = ComboBox8.Items.Item(92)
            Case 7440 To 7519
                ComboBox8.SelectedItem = ComboBox8.Items.Item(93)
            Case 7520 To 7599
                ComboBox8.SelectedItem = ComboBox8.Items.Item(94)
            Case 7600 To 7679
                ComboBox8.SelectedItem = ComboBox8.Items.Item(95)
            Case 7680 To 7759
                ComboBox8.SelectedItem = ComboBox8.Items.Item(96)
            Case 7760 To 7839
                ComboBox8.SelectedItem = ComboBox8.Items.Item(97)
            Case 7840 To 7919
                ComboBox8.SelectedItem = ComboBox8.Items.Item(98)
            Case 7920 To 8000
                ComboBox8.SelectedItem = ComboBox8.Items.Item(99)
        End Select
    End Sub

    Private Sub NumericUpDown20_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown20.ValueChanged
        Select Case NumericUpDown20.Value
            Case 0 To 79
                ComboBox9.SelectedItem = ComboBox9.Items.Item(0)
            Case 80 To 159
                ComboBox9.SelectedItem = ComboBox9.Items.Item(1)
            Case 160 To 239
                ComboBox9.SelectedItem = ComboBox9.Items.Item(2)
            Case 240 To 319
                ComboBox9.SelectedItem = ComboBox9.Items.Item(3)
            Case 320 To 399
                ComboBox9.SelectedItem = ComboBox9.Items.Item(4)
            Case 400 To 479
                ComboBox9.SelectedItem = ComboBox9.Items.Item(5)
            Case 480 To 559
                ComboBox9.SelectedItem = ComboBox9.Items.Item(6)
            Case 560 To 639
                ComboBox9.SelectedItem = ComboBox9.Items.Item(7)
            Case 640 To 719
                ComboBox9.SelectedItem = ComboBox9.Items.Item(8)
            Case 720 To 799
                ComboBox9.SelectedItem = ComboBox9.Items.Item(9)
            Case 800 To 879
                ComboBox9.SelectedItem = ComboBox9.Items.Item(10)
            Case 880 To 959
                ComboBox9.SelectedItem = ComboBox9.Items.Item(11)
            Case 960 To 1039
                ComboBox9.SelectedItem = ComboBox9.Items.Item(12)
            Case 1040 To 1119
                ComboBox9.SelectedItem = ComboBox9.Items.Item(13)
            Case 1120 To 1199
                ComboBox9.SelectedItem = ComboBox9.Items.Item(14)
            Case 1200 To 1279
                ComboBox9.SelectedItem = ComboBox9.Items.Item(15)
            Case 1280 To 1359
                ComboBox9.SelectedItem = ComboBox9.Items.Item(16)
            Case 1360 To 1439
                ComboBox9.SelectedItem = ComboBox9.Items.Item(17)
            Case 1440 To 1519
                ComboBox9.SelectedItem = ComboBox9.Items.Item(18)
            Case 1520 To 1599
                ComboBox9.SelectedItem = ComboBox9.Items.Item(19)
            Case 1600 To 1679
                ComboBox9.SelectedItem = ComboBox9.Items.Item(20)
            Case 1680 To 1759
                ComboBox9.SelectedItem = ComboBox9.Items.Item(21)
            Case 1760 To 1839
                ComboBox9.SelectedItem = ComboBox9.Items.Item(22)
            Case 1840 To 1919
                ComboBox9.SelectedItem = ComboBox9.Items.Item(23)
            Case 1920 To 1999
                ComboBox9.SelectedItem = ComboBox9.Items.Item(24)
            Case 2000 To 2079
                ComboBox9.SelectedItem = ComboBox9.Items.Item(25)
            Case 2080 To 2159
                ComboBox9.SelectedItem = ComboBox9.Items.Item(26)
            Case 2160 To 2239
                ComboBox9.SelectedItem = ComboBox9.Items.Item(27)
            Case 2240 To 2319
                ComboBox9.SelectedItem = ComboBox9.Items.Item(28)
            Case 2320 To 2399
                ComboBox9.SelectedItem = ComboBox9.Items.Item(29)
            Case 2400 To 2479
                ComboBox9.SelectedItem = ComboBox9.Items.Item(30)
            Case 2480 To 2559
                ComboBox9.SelectedItem = ComboBox9.Items.Item(31)
            Case 2560 To 2639
                ComboBox9.SelectedItem = ComboBox9.Items.Item(32)
            Case 2640 To 2719
                ComboBox9.SelectedItem = ComboBox9.Items.Item(33)
            Case 2720 To 2799
                ComboBox9.SelectedItem = ComboBox9.Items.Item(34)
            Case 2800 To 2879
                ComboBox9.SelectedItem = ComboBox9.Items.Item(35)
            Case 2880 To 2959
                ComboBox9.SelectedItem = ComboBox9.Items.Item(36)
            Case 2960 To 3039
                ComboBox9.SelectedItem = ComboBox9.Items.Item(37)
            Case 3040 To 3119
                ComboBox9.SelectedItem = ComboBox9.Items.Item(38)
            Case 3120 To 3199
                ComboBox9.SelectedItem = ComboBox9.Items.Item(39)
            Case 3200 To 3279
                ComboBox9.SelectedItem = ComboBox9.Items.Item(40)
            Case 3280 To 3359
                ComboBox9.SelectedItem = ComboBox9.Items.Item(41)
            Case 3360 To 3439
                ComboBox9.SelectedItem = ComboBox9.Items.Item(42)
            Case 3440 To 3519
                ComboBox9.SelectedItem = ComboBox9.Items.Item(43)
            Case 3520 To 3599
                ComboBox9.SelectedItem = ComboBox9.Items.Item(44)
            Case 3600 To 3679
                ComboBox9.SelectedItem = ComboBox9.Items.Item(45)
            Case 3680 To 3759
                ComboBox9.SelectedItem = ComboBox9.Items.Item(46)
            Case 3760 To 3839
                ComboBox9.SelectedItem = ComboBox9.Items.Item(47)
            Case 3840 To 3919
                ComboBox9.SelectedItem = ComboBox9.Items.Item(48)
            Case 3920 To 3999
                ComboBox9.SelectedItem = ComboBox9.Items.Item(49)
            Case 4000 To 4079
                ComboBox9.SelectedItem = ComboBox9.Items.Item(50)
            Case 4080 To 4159
                ComboBox9.SelectedItem = ComboBox9.Items.Item(51)
            Case 4160 To 4239
                ComboBox9.SelectedItem = ComboBox9.Items.Item(52)
            Case 4240 To 4319
                ComboBox9.SelectedItem = ComboBox9.Items.Item(53)
            Case 4320 To 4399
                ComboBox9.SelectedItem = ComboBox9.Items.Item(54)
            Case 4400 To 4479
                ComboBox9.SelectedItem = ComboBox9.Items.Item(55)
            Case 4480 To 4559
                ComboBox9.SelectedItem = ComboBox9.Items.Item(56)
            Case 4560 To 4639
                ComboBox9.SelectedItem = ComboBox9.Items.Item(57)
            Case 4640 To 4719
                ComboBox9.SelectedItem = ComboBox9.Items.Item(58)
            Case 4720 To 4799
                ComboBox9.SelectedItem = ComboBox9.Items.Item(59)
            Case 4800 To 4879
                ComboBox9.SelectedItem = ComboBox9.Items.Item(60)
            Case 4880 To 4959
                ComboBox9.SelectedItem = ComboBox9.Items.Item(61)
            Case 4960 To 5039
                ComboBox9.SelectedItem = ComboBox9.Items.Item(62)
            Case 5040 To 5119
                ComboBox9.SelectedItem = ComboBox9.Items.Item(63)
            Case 5120 To 5199
                ComboBox9.SelectedItem = ComboBox9.Items.Item(64)
            Case 5200 To 5279
                ComboBox9.SelectedItem = ComboBox9.Items.Item(65)
            Case 5280 To 5359
                ComboBox9.SelectedItem = ComboBox9.Items.Item(66)
            Case 5360 To 5439
                ComboBox9.SelectedItem = ComboBox9.Items.Item(67)
            Case 5440 To 5519
                ComboBox9.SelectedItem = ComboBox9.Items.Item(68)
            Case 5520 To 5599
                ComboBox9.SelectedItem = ComboBox9.Items.Item(69)
            Case 5600 To 5679
                ComboBox9.SelectedItem = ComboBox9.Items.Item(70)
            Case 5680 To 5759
                ComboBox9.SelectedItem = ComboBox9.Items.Item(71)
            Case 5760 To 5839
                ComboBox9.SelectedItem = ComboBox9.Items.Item(72)
            Case 5840 To 5919
                ComboBox9.SelectedItem = ComboBox9.Items.Item(73)
            Case 5920 To 5999
                ComboBox9.SelectedItem = ComboBox9.Items.Item(74)
            Case 6000 To 6079
                ComboBox9.SelectedItem = ComboBox9.Items.Item(75)
            Case 6080 To 6159
                ComboBox9.SelectedItem = ComboBox9.Items.Item(76)
            Case 6160 To 6239
                ComboBox9.SelectedItem = ComboBox9.Items.Item(77)
            Case 6240 To 6319
                ComboBox9.SelectedItem = ComboBox9.Items.Item(78)
            Case 6320 To 6399
                ComboBox9.SelectedItem = ComboBox9.Items.Item(79)
            Case 6400 To 6479
                ComboBox9.SelectedItem = ComboBox9.Items.Item(80)
            Case 6480 To 6559
                ComboBox9.SelectedItem = ComboBox9.Items.Item(81)
            Case 6560 To 6639
                ComboBox9.SelectedItem = ComboBox9.Items.Item(82)
            Case 6640 To 6719
                ComboBox9.SelectedItem = ComboBox9.Items.Item(83)
            Case 6720 To 6799
                ComboBox9.SelectedItem = ComboBox9.Items.Item(84)
            Case 6800 To 6879
                ComboBox9.SelectedItem = ComboBox9.Items.Item(85)
            Case 6880 To 6959
                ComboBox9.SelectedItem = ComboBox9.Items.Item(86)
            Case 6960 To 7039
                ComboBox9.SelectedItem = ComboBox9.Items.Item(87)
            Case 7040 To 7119
                ComboBox9.SelectedItem = ComboBox9.Items.Item(88)
            Case 7120 To 7199
                ComboBox9.SelectedItem = ComboBox9.Items.Item(89)
            Case 7200 To 7279
                ComboBox9.SelectedItem = ComboBox9.Items.Item(90)
            Case 7280 To 7359
                ComboBox9.SelectedItem = ComboBox9.Items.Item(91)
            Case 7360 To 7439
                ComboBox9.SelectedItem = ComboBox9.Items.Item(92)
            Case 7440 To 7519
                ComboBox9.SelectedItem = ComboBox9.Items.Item(93)
            Case 7520 To 7599
                ComboBox9.SelectedItem = ComboBox9.Items.Item(94)
            Case 7600 To 7679
                ComboBox9.SelectedItem = ComboBox9.Items.Item(95)
            Case 7680 To 7759
                ComboBox9.SelectedItem = ComboBox9.Items.Item(96)
            Case 7760 To 7839
                ComboBox9.SelectedItem = ComboBox9.Items.Item(97)
            Case 7840 To 7919
                ComboBox9.SelectedItem = ComboBox9.Items.Item(98)
            Case 7920 To 8000
                ComboBox9.SelectedItem = ComboBox9.Items.Item(99)
        End Select
    End Sub

    Private Sub NumericUpDown19_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown19.ValueChanged
        Select Case NumericUpDown19.Value
            Case 0 To 79
                ComboBox10.SelectedItem = ComboBox10.Items.Item(0)
            Case 80 To 159
                ComboBox10.SelectedItem = ComboBox10.Items.Item(1)
            Case 160 To 239
                ComboBox10.SelectedItem = ComboBox10.Items.Item(2)
            Case 240 To 319
                ComboBox10.SelectedItem = ComboBox10.Items.Item(3)
            Case 320 To 399
                ComboBox10.SelectedItem = ComboBox10.Items.Item(4)
            Case 400 To 479
                ComboBox10.SelectedItem = ComboBox10.Items.Item(5)
            Case 480 To 559
                ComboBox10.SelectedItem = ComboBox10.Items.Item(6)
            Case 560 To 639
                ComboBox10.SelectedItem = ComboBox10.Items.Item(7)
            Case 640 To 719
                ComboBox10.SelectedItem = ComboBox10.Items.Item(8)
            Case 720 To 799
                ComboBox10.SelectedItem = ComboBox10.Items.Item(9)
            Case 800 To 879
                ComboBox10.SelectedItem = ComboBox10.Items.Item(10)
            Case 880 To 959
                ComboBox10.SelectedItem = ComboBox10.Items.Item(11)
            Case 960 To 1039
                ComboBox10.SelectedItem = ComboBox10.Items.Item(12)
            Case 1040 To 1119
                ComboBox10.SelectedItem = ComboBox10.Items.Item(13)
            Case 1120 To 1199
                ComboBox10.SelectedItem = ComboBox10.Items.Item(14)
            Case 1200 To 1279
                ComboBox10.SelectedItem = ComboBox10.Items.Item(15)
            Case 1280 To 1359
                ComboBox10.SelectedItem = ComboBox10.Items.Item(16)
            Case 1360 To 1439
                ComboBox10.SelectedItem = ComboBox10.Items.Item(17)
            Case 1440 To 1519
                ComboBox10.SelectedItem = ComboBox10.Items.Item(18)
            Case 1520 To 1599
                ComboBox10.SelectedItem = ComboBox10.Items.Item(19)
            Case 1600 To 1679
                ComboBox10.SelectedItem = ComboBox10.Items.Item(20)
            Case 1680 To 1759
                ComboBox10.SelectedItem = ComboBox10.Items.Item(21)
            Case 1760 To 1839
                ComboBox10.SelectedItem = ComboBox10.Items.Item(22)
            Case 1840 To 1919
                ComboBox10.SelectedItem = ComboBox10.Items.Item(23)
            Case 1920 To 1999
                ComboBox10.SelectedItem = ComboBox10.Items.Item(24)
            Case 2000 To 2079
                ComboBox10.SelectedItem = ComboBox10.Items.Item(25)
            Case 2080 To 2159
                ComboBox10.SelectedItem = ComboBox10.Items.Item(26)
            Case 2160 To 2239
                ComboBox10.SelectedItem = ComboBox10.Items.Item(27)
            Case 2240 To 2319
                ComboBox10.SelectedItem = ComboBox10.Items.Item(28)
            Case 2320 To 2399
                ComboBox10.SelectedItem = ComboBox10.Items.Item(29)
            Case 2400 To 2479
                ComboBox10.SelectedItem = ComboBox10.Items.Item(30)
            Case 2480 To 2559
                ComboBox10.SelectedItem = ComboBox10.Items.Item(31)
            Case 2560 To 2639
                ComboBox10.SelectedItem = ComboBox10.Items.Item(32)
            Case 2640 To 2719
                ComboBox10.SelectedItem = ComboBox10.Items.Item(33)
            Case 2720 To 2799
                ComboBox10.SelectedItem = ComboBox10.Items.Item(34)
            Case 2800 To 2879
                ComboBox10.SelectedItem = ComboBox10.Items.Item(35)
            Case 2880 To 2959
                ComboBox10.SelectedItem = ComboBox10.Items.Item(36)
            Case 2960 To 3039
                ComboBox10.SelectedItem = ComboBox10.Items.Item(37)
            Case 3040 To 3119
                ComboBox10.SelectedItem = ComboBox10.Items.Item(38)
            Case 3120 To 3199
                ComboBox10.SelectedItem = ComboBox10.Items.Item(39)
            Case 3200 To 3279
                ComboBox10.SelectedItem = ComboBox10.Items.Item(40)
            Case 3280 To 3359
                ComboBox10.SelectedItem = ComboBox10.Items.Item(41)
            Case 3360 To 3439
                ComboBox10.SelectedItem = ComboBox10.Items.Item(42)
            Case 3440 To 3519
                ComboBox10.SelectedItem = ComboBox10.Items.Item(43)
            Case 3520 To 3599
                ComboBox10.SelectedItem = ComboBox10.Items.Item(44)
            Case 3600 To 3679
                ComboBox10.SelectedItem = ComboBox10.Items.Item(45)
            Case 3680 To 3759
                ComboBox10.SelectedItem = ComboBox10.Items.Item(46)
            Case 3760 To 3839
                ComboBox10.SelectedItem = ComboBox10.Items.Item(47)
            Case 3840 To 3919
                ComboBox10.SelectedItem = ComboBox10.Items.Item(48)
            Case 3920 To 3999
                ComboBox10.SelectedItem = ComboBox10.Items.Item(49)
            Case 4000 To 4079
                ComboBox10.SelectedItem = ComboBox10.Items.Item(50)
            Case 4080 To 4159
                ComboBox10.SelectedItem = ComboBox10.Items.Item(51)
            Case 4160 To 4239
                ComboBox10.SelectedItem = ComboBox10.Items.Item(52)
            Case 4240 To 4319
                ComboBox10.SelectedItem = ComboBox10.Items.Item(53)
            Case 4320 To 4399
                ComboBox10.SelectedItem = ComboBox10.Items.Item(54)
            Case 4400 To 4479
                ComboBox10.SelectedItem = ComboBox10.Items.Item(55)
            Case 4480 To 4559
                ComboBox10.SelectedItem = ComboBox10.Items.Item(56)
            Case 4560 To 4639
                ComboBox10.SelectedItem = ComboBox10.Items.Item(57)
            Case 4640 To 4719
                ComboBox10.SelectedItem = ComboBox10.Items.Item(58)
            Case 4720 To 4799
                ComboBox10.SelectedItem = ComboBox10.Items.Item(59)
            Case 4800 To 4879
                ComboBox10.SelectedItem = ComboBox10.Items.Item(60)
            Case 4880 To 4959
                ComboBox10.SelectedItem = ComboBox10.Items.Item(61)
            Case 4960 To 5039
                ComboBox10.SelectedItem = ComboBox10.Items.Item(62)
            Case 5040 To 5119
                ComboBox10.SelectedItem = ComboBox10.Items.Item(63)
            Case 5120 To 5199
                ComboBox10.SelectedItem = ComboBox10.Items.Item(64)
            Case 5200 To 5279
                ComboBox10.SelectedItem = ComboBox10.Items.Item(65)
            Case 5280 To 5359
                ComboBox10.SelectedItem = ComboBox10.Items.Item(66)
            Case 5360 To 5439
                ComboBox10.SelectedItem = ComboBox10.Items.Item(67)
            Case 5440 To 5519
                ComboBox10.SelectedItem = ComboBox10.Items.Item(68)
            Case 5520 To 5599
                ComboBox10.SelectedItem = ComboBox10.Items.Item(69)
            Case 5600 To 5679
                ComboBox10.SelectedItem = ComboBox10.Items.Item(70)
            Case 5680 To 5759
                ComboBox10.SelectedItem = ComboBox10.Items.Item(71)
            Case 5760 To 5839
                ComboBox10.SelectedItem = ComboBox10.Items.Item(72)
            Case 5840 To 5919
                ComboBox10.SelectedItem = ComboBox10.Items.Item(73)
            Case 5920 To 5999
                ComboBox10.SelectedItem = ComboBox10.Items.Item(74)
            Case 6000 To 6079
                ComboBox10.SelectedItem = ComboBox10.Items.Item(75)
            Case 6080 To 6159
                ComboBox10.SelectedItem = ComboBox10.Items.Item(76)
            Case 6160 To 6239
                ComboBox10.SelectedItem = ComboBox10.Items.Item(77)
            Case 6240 To 6319
                ComboBox10.SelectedItem = ComboBox10.Items.Item(78)
            Case 6320 To 6399
                ComboBox10.SelectedItem = ComboBox10.Items.Item(79)
            Case 6400 To 6479
                ComboBox10.SelectedItem = ComboBox10.Items.Item(80)
            Case 6480 To 6559
                ComboBox10.SelectedItem = ComboBox10.Items.Item(81)
            Case 6560 To 6639
                ComboBox10.SelectedItem = ComboBox10.Items.Item(82)
            Case 6640 To 6719
                ComboBox10.SelectedItem = ComboBox10.Items.Item(83)
            Case 6720 To 6799
                ComboBox10.SelectedItem = ComboBox10.Items.Item(84)
            Case 6800 To 6879
                ComboBox10.SelectedItem = ComboBox10.Items.Item(85)
            Case 6880 To 6959
                ComboBox10.SelectedItem = ComboBox10.Items.Item(86)
            Case 6960 To 7039
                ComboBox10.SelectedItem = ComboBox10.Items.Item(87)
            Case 7040 To 7119
                ComboBox10.SelectedItem = ComboBox10.Items.Item(88)
            Case 7120 To 7199
                ComboBox10.SelectedItem = ComboBox10.Items.Item(89)
            Case 7200 To 7279
                ComboBox10.SelectedItem = ComboBox10.Items.Item(90)
            Case 7280 To 7359
                ComboBox10.SelectedItem = ComboBox10.Items.Item(91)
            Case 7360 To 7439
                ComboBox10.SelectedItem = ComboBox10.Items.Item(92)
            Case 7440 To 7519
                ComboBox10.SelectedItem = ComboBox10.Items.Item(93)
            Case 7520 To 7599
                ComboBox10.SelectedItem = ComboBox10.Items.Item(94)
            Case 7600 To 7679
                ComboBox10.SelectedItem = ComboBox10.Items.Item(95)
            Case 7680 To 7759
                ComboBox10.SelectedItem = ComboBox10.Items.Item(96)
            Case 7760 To 7839
                ComboBox10.SelectedItem = ComboBox10.Items.Item(97)
            Case 7840 To 7919
                ComboBox10.SelectedItem = ComboBox10.Items.Item(98)
            Case 7920 To 8000
                ComboBox10.SelectedItem = ComboBox10.Items.Item(99)
        End Select
    End Sub

    Public Sub makebakcommon()
        Try
            If ComboBox4.SelectedItem = ComboBox4.Items.Item(0) Then
                My.Computer.FileSystem.CopyFile(
                          common,
                        applicationpath & "\bak\common.sav\EUR\common.sav")
            End If
            If ComboBox4.SelectedItem = ComboBox4.Items.Item(1) Then
                My.Computer.FileSystem.CopyFile(
                          common,
                        applicationpath & "\bak\common.sav\USA\common.sav")
            End If
            If ComboBox4.SelectedItem = ComboBox4.Items.Item(2) Then
                My.Computer.FileSystem.CopyFile(
                          common,
                        applicationpath & "\bak\common.sav\JPN\common.sav")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub makebakhero()
        Try
            If ComboBox4.SelectedItem = ComboBox4.Items.Item(0) Then
                My.Computer.FileSystem.CopyFile(
                          hero,
                        applicationpath & "\bak\hero.sav\EUR\common.sav")
            End If
            If ComboBox4.SelectedItem = ComboBox4.Items.Item(1) Then
                My.Computer.FileSystem.CopyFile(
                          hero,
                        applicationpath & "\bak\hero.sav\USA\common.sav")
            End If
            If ComboBox4.SelectedItem = ComboBox4.Items.Item(2) Then
                My.Computer.FileSystem.CopyFile(
                          hero,
                        applicationpath & "\bak\hero.sav\JPN\common.sav")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(0) Then
            NumericUpDown16.Value = 0
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(1) Then
            NumericUpDown16.Value = 80
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(2) Then
            NumericUpDown16.Value = 160
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(3) Then
            NumericUpDown16.Value = 240
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(4) Then
            NumericUpDown16.Value = 320
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(5) Then
            NumericUpDown16.Value = 400
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(6) Then
            NumericUpDown16.Value = 480
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(7) Then
            NumericUpDown16.Value = 560
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(8) Then
            NumericUpDown16.Value = 640
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(9) Then
            NumericUpDown16.Value = 720
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(10) Then
            NumericUpDown16.Value = 800
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(11) Then
            NumericUpDown16.Value = 880
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(12) Then
            NumericUpDown16.Value = 960
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(13) Then
            NumericUpDown16.Value = 1040
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(14) Then
            NumericUpDown16.Value = 1120
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(15) Then
            NumericUpDown16.Value = 1200
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(16) Then
            NumericUpDown16.Value = 1280
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(17) Then
            NumericUpDown16.Value = 1360
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(18) Then
            NumericUpDown16.Value = 1440
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(19) Then
            NumericUpDown16.Value = 1520
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(20) Then
            NumericUpDown16.Value = 1600
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(21) Then
            NumericUpDown16.Value = 1680
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(22) Then
            NumericUpDown16.Value = 1760
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(23) Then
            NumericUpDown16.Value = 1840
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(24) Then
            NumericUpDown16.Value = 1920
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(25) Then
            NumericUpDown16.Value = 2000
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(26) Then
            NumericUpDown16.Value = 2080
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(27) Then
            NumericUpDown16.Value = 2160
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(28) Then
            NumericUpDown16.Value = 2240
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(29) Then
            NumericUpDown16.Value = 2320
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(30) Then
            NumericUpDown16.Value = 2400
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(31) Then
            NumericUpDown16.Value = 2480
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(32) Then
            NumericUpDown16.Value = 2560
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(33) Then
            NumericUpDown16.Value = 2640
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(34) Then
            NumericUpDown16.Value = 2720
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(35) Then
            NumericUpDown16.Value = 2800
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(36) Then
            NumericUpDown16.Value = 2880
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(37) Then
            NumericUpDown16.Value = 2960
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(38) Then
            NumericUpDown16.Value = 3040
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(39) Then
            NumericUpDown16.Value = 3120
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(40) Then
            NumericUpDown16.Value = 3200
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(41) Then
            NumericUpDown16.Value = 3280
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(42) Then
            NumericUpDown16.Value = 3360
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(43) Then
            NumericUpDown16.Value = 3440
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(44) Then
            NumericUpDown16.Value = 3520
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(45) Then
            NumericUpDown16.Value = 3600
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(46) Then
            NumericUpDown16.Value = 3680
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(47) Then
            NumericUpDown16.Value = 3760
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(48) Then
            NumericUpDown16.Value = 3840
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(49) Then
            NumericUpDown16.Value = 3920
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(50) Then
            NumericUpDown16.Value = 4000
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(51) Then
            NumericUpDown16.Value = 4080
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(52) Then
            NumericUpDown16.Value = 4160
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(53) Then
            NumericUpDown16.Value = 4240
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(54) Then
            NumericUpDown16.Value = 4320
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(55) Then
            NumericUpDown16.Value = 4400
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(56) Then
            NumericUpDown16.Value = 4480
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(57) Then
            NumericUpDown16.Value = 4560
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(58) Then
            NumericUpDown16.Value = 4640
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(59) Then
            NumericUpDown16.Value = 4720
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(60) Then
            NumericUpDown16.Value = 4800
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(61) Then
            NumericUpDown16.Value = 4880
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(62) Then
            NumericUpDown16.Value = 4960
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(63) Then
            NumericUpDown16.Value = 5040
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(64) Then
            NumericUpDown16.Value = 5120
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(65) Then
            NumericUpDown16.Value = 5200
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(66) Then
            NumericUpDown16.Value = 5280
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(67) Then
            NumericUpDown16.Value = 5360
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(68) Then
            NumericUpDown16.Value = 5440
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(69) Then
            NumericUpDown16.Value = 5520
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(70) Then
            NumericUpDown16.Value = 5600
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(71) Then
            NumericUpDown16.Value = 5680
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(72) Then
            NumericUpDown16.Value = 5760
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(73) Then
            NumericUpDown16.Value = 5840
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(74) Then
            NumericUpDown16.Value = 5920
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(75) Then
            NumericUpDown16.Value = 6000
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(76) Then
            NumericUpDown16.Value = 6080
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(77) Then
            NumericUpDown16.Value = 6160
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(78) Then
            NumericUpDown16.Value = 6240
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(79) Then
            NumericUpDown16.Value = 6320
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(80) Then
            NumericUpDown16.Value = 6400
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(81) Then
            NumericUpDown16.Value = 6480
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(82) Then
            NumericUpDown16.Value = 6560
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(83) Then
            NumericUpDown16.Value = 6640
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(84) Then
            NumericUpDown16.Value = 6720
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(85) Then
            NumericUpDown16.Value = 6800
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(86) Then
            NumericUpDown16.Value = 6880
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(87) Then
            NumericUpDown16.Value = 6960
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(88) Then
            NumericUpDown16.Value = 7040
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(89) Then
            NumericUpDown16.Value = 7120
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(90) Then
            NumericUpDown16.Value = 7200
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(91) Then
            NumericUpDown16.Value = 7280
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(92) Then
            NumericUpDown16.Value = 7360
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(93) Then
            NumericUpDown16.Value = 7440
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(94) Then
            NumericUpDown16.Value = 7520
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(95) Then
            NumericUpDown16.Value = 7600
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(96) Then
            NumericUpDown16.Value = 7680
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(97) Then
            NumericUpDown16.Value = 7760
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(98) Then
            NumericUpDown16.Value = 7840
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(99) Then
            NumericUpDown16.Value = 7920
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(0) Then
            NumericUpDown17.Value = 0
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(1) Then
            NumericUpDown17.Value = 80
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(2) Then
            NumericUpDown17.Value = 160
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(3) Then
            NumericUpDown17.Value = 240
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(4) Then
            NumericUpDown17.Value = 320
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(5) Then
            NumericUpDown17.Value = 400
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(6) Then
            NumericUpDown17.Value = 480
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(7) Then
            NumericUpDown17.Value = 560
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(8) Then
            NumericUpDown17.Value = 640
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(9) Then
            NumericUpDown17.Value = 720
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(10) Then
            NumericUpDown17.Value = 800
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(11) Then
            NumericUpDown17.Value = 880
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(12) Then
            NumericUpDown17.Value = 960
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(13) Then
            NumericUpDown17.Value = 1040
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(14) Then
            NumericUpDown17.Value = 1120
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(15) Then
            NumericUpDown17.Value = 1200
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(16) Then
            NumericUpDown17.Value = 1280
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(17) Then
            NumericUpDown17.Value = 1360
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(18) Then
            NumericUpDown17.Value = 1440
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(19) Then
            NumericUpDown17.Value = 1520
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(20) Then
            NumericUpDown17.Value = 1600
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(21) Then
            NumericUpDown17.Value = 1680
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(22) Then
            NumericUpDown17.Value = 1760
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(23) Then
            NumericUpDown17.Value = 1840
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(24) Then
            NumericUpDown17.Value = 1920
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(25) Then
            NumericUpDown17.Value = 2000
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(26) Then
            NumericUpDown17.Value = 2080
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(27) Then
            NumericUpDown17.Value = 2160
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(28) Then
            NumericUpDown17.Value = 2240
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(29) Then
            NumericUpDown17.Value = 2320
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(30) Then
            NumericUpDown17.Value = 2400
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(31) Then
            NumericUpDown17.Value = 2480
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(32) Then
            NumericUpDown17.Value = 2560
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(33) Then
            NumericUpDown17.Value = 2640
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(34) Then
            NumericUpDown17.Value = 2720
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(35) Then
            NumericUpDown17.Value = 2800
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(36) Then
            NumericUpDown17.Value = 2880
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(37) Then
            NumericUpDown17.Value = 2960
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(38) Then
            NumericUpDown17.Value = 3040
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(39) Then
            NumericUpDown17.Value = 3120
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(40) Then
            NumericUpDown17.Value = 3200
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(41) Then
            NumericUpDown17.Value = 3280
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(42) Then
            NumericUpDown17.Value = 3360
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(43) Then
            NumericUpDown17.Value = 3440
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(44) Then
            NumericUpDown17.Value = 3520
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(45) Then
            NumericUpDown17.Value = 3600
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(46) Then
            NumericUpDown17.Value = 3680
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(47) Then
            NumericUpDown17.Value = 3760
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(48) Then
            NumericUpDown17.Value = 3840
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(49) Then
            NumericUpDown17.Value = 3920
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(50) Then
            NumericUpDown17.Value = 4000
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(51) Then
            NumericUpDown17.Value = 4080
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(52) Then
            NumericUpDown17.Value = 4160
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(53) Then
            NumericUpDown17.Value = 4240
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(54) Then
            NumericUpDown17.Value = 4320
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(55) Then
            NumericUpDown17.Value = 4400
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(56) Then
            NumericUpDown17.Value = 4480
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(57) Then
            NumericUpDown17.Value = 4560
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(58) Then
            NumericUpDown17.Value = 4640
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(59) Then
            NumericUpDown17.Value = 4720
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(60) Then
            NumericUpDown17.Value = 4800
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(61) Then
            NumericUpDown17.Value = 4880
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(62) Then
            NumericUpDown17.Value = 4960
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(63) Then
            NumericUpDown17.Value = 5040
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(64) Then
            NumericUpDown17.Value = 5120
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(65) Then
            NumericUpDown17.Value = 5200
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(66) Then
            NumericUpDown17.Value = 5280
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(67) Then
            NumericUpDown17.Value = 5360
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(68) Then
            NumericUpDown17.Value = 5440
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(69) Then
            NumericUpDown17.Value = 5520
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(70) Then
            NumericUpDown17.Value = 5600
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(71) Then
            NumericUpDown17.Value = 5680
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(72) Then
            NumericUpDown17.Value = 5760
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(73) Then
            NumericUpDown17.Value = 5840
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(74) Then
            NumericUpDown17.Value = 5920
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(75) Then
            NumericUpDown17.Value = 6000
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(76) Then
            NumericUpDown17.Value = 6080
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(77) Then
            NumericUpDown17.Value = 6160
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(78) Then
            NumericUpDown17.Value = 6240
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(79) Then
            NumericUpDown17.Value = 6320
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(80) Then
            NumericUpDown17.Value = 6400
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(81) Then
            NumericUpDown17.Value = 6480
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(82) Then
            NumericUpDown17.Value = 6560
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(83) Then
            NumericUpDown17.Value = 6640
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(84) Then
            NumericUpDown17.Value = 6720
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(85) Then
            NumericUpDown17.Value = 6800
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(86) Then
            NumericUpDown17.Value = 6880
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(87) Then
            NumericUpDown17.Value = 6960
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(88) Then
            NumericUpDown17.Value = 7040
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(89) Then
            NumericUpDown17.Value = 7120
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(90) Then
            NumericUpDown17.Value = 7200
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(91) Then
            NumericUpDown17.Value = 7280
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(92) Then
            NumericUpDown17.Value = 7360
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(93) Then
            NumericUpDown17.Value = 7440
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(94) Then
            NumericUpDown17.Value = 7520
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(95) Then
            NumericUpDown17.Value = 7600
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(96) Then
            NumericUpDown17.Value = 7680
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(97) Then
            NumericUpDown17.Value = 7760
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(98) Then
            NumericUpDown17.Value = 7840
        ElseIf ComboBox6.SelectedItem = ComboBox6.Items.Item(99) Then
            NumericUpDown17.Value = 7920
        End If
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(0) Then
            NumericUpDown18.Value = 0
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(1) Then
            NumericUpDown18.Value = 80
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(2) Then
            NumericUpDown18.Value = 160
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(3) Then
            NumericUpDown18.Value = 240
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(4) Then
            NumericUpDown18.Value = 320
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(5) Then
            NumericUpDown18.Value = 400
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(6) Then
            NumericUpDown18.Value = 480
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(7) Then
            NumericUpDown18.Value = 560
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(8) Then
            NumericUpDown18.Value = 640
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(9) Then
            NumericUpDown18.Value = 720
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(10) Then
            NumericUpDown18.Value = 800
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(11) Then
            NumericUpDown18.Value = 880
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(12) Then
            NumericUpDown18.Value = 960
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(13) Then
            NumericUpDown18.Value = 1040
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(14) Then
            NumericUpDown18.Value = 1120
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(15) Then
            NumericUpDown18.Value = 1200
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(16) Then
            NumericUpDown18.Value = 1280
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(17) Then
            NumericUpDown18.Value = 1360
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(18) Then
            NumericUpDown18.Value = 1440
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(19) Then
            NumericUpDown18.Value = 1520
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(20) Then
            NumericUpDown18.Value = 1600
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(21) Then
            NumericUpDown18.Value = 1680
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(22) Then
            NumericUpDown18.Value = 1760
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(23) Then
            NumericUpDown18.Value = 1840
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(24) Then
            NumericUpDown18.Value = 1920
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(25) Then
            NumericUpDown18.Value = 2000
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(26) Then
            NumericUpDown18.Value = 2080
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(27) Then
            NumericUpDown18.Value = 2160
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(28) Then
            NumericUpDown18.Value = 2240
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(29) Then
            NumericUpDown18.Value = 2320
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(30) Then
            NumericUpDown18.Value = 2400
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(31) Then
            NumericUpDown18.Value = 2480
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(32) Then
            NumericUpDown18.Value = 2560
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(33) Then
            NumericUpDown18.Value = 2640
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(34) Then
            NumericUpDown18.Value = 2720
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(35) Then
            NumericUpDown18.Value = 2800
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(36) Then
            NumericUpDown18.Value = 2880
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(37) Then
            NumericUpDown18.Value = 2960
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(38) Then
            NumericUpDown18.Value = 3040
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(39) Then
            NumericUpDown18.Value = 3120
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(40) Then
            NumericUpDown18.Value = 3200
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(41) Then
            NumericUpDown18.Value = 3280
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(42) Then
            NumericUpDown18.Value = 3360
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(43) Then
            NumericUpDown18.Value = 3440
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(44) Then
            NumericUpDown18.Value = 3520
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(45) Then
            NumericUpDown18.Value = 3600
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(46) Then
            NumericUpDown18.Value = 3680
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(47) Then
            NumericUpDown18.Value = 3760
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(48) Then
            NumericUpDown18.Value = 3840
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(49) Then
            NumericUpDown18.Value = 3920
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(50) Then
            NumericUpDown18.Value = 4000
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(51) Then
            NumericUpDown18.Value = 4080
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(52) Then
            NumericUpDown18.Value = 4160
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(53) Then
            NumericUpDown18.Value = 4240
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(54) Then
            NumericUpDown18.Value = 4320
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(55) Then
            NumericUpDown18.Value = 4400
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(56) Then
            NumericUpDown18.Value = 4480
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(57) Then
            NumericUpDown18.Value = 4560
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(58) Then
            NumericUpDown18.Value = 4640
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(59) Then
            NumericUpDown18.Value = 4720
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(60) Then
            NumericUpDown18.Value = 4800
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(61) Then
            NumericUpDown18.Value = 4880
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(62) Then
            NumericUpDown18.Value = 4960
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(63) Then
            NumericUpDown18.Value = 5040
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(64) Then
            NumericUpDown18.Value = 5120
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(65) Then
            NumericUpDown18.Value = 5200
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(66) Then
            NumericUpDown18.Value = 5280
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(67) Then
            NumericUpDown18.Value = 5360
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(68) Then
            NumericUpDown18.Value = 5440
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(69) Then
            NumericUpDown18.Value = 5520
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(70) Then
            NumericUpDown18.Value = 5600
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(71) Then
            NumericUpDown18.Value = 5680
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(72) Then
            NumericUpDown18.Value = 5760
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(73) Then
            NumericUpDown18.Value = 5840
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(74) Then
            NumericUpDown18.Value = 5920
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(75) Then
            NumericUpDown18.Value = 6000
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(76) Then
            NumericUpDown18.Value = 6080
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(77) Then
            NumericUpDown18.Value = 6160
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(78) Then
            NumericUpDown18.Value = 6240
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(79) Then
            NumericUpDown18.Value = 6320
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(80) Then
            NumericUpDown18.Value = 6400
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(81) Then
            NumericUpDown18.Value = 6480
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(82) Then
            NumericUpDown18.Value = 6560
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(83) Then
            NumericUpDown18.Value = 6640
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(84) Then
            NumericUpDown18.Value = 6720
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(85) Then
            NumericUpDown18.Value = 6800
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(86) Then
            NumericUpDown18.Value = 6880
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(87) Then
            NumericUpDown18.Value = 6960
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(88) Then
            NumericUpDown18.Value = 7040
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(89) Then
            NumericUpDown18.Value = 7120
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(90) Then
            NumericUpDown18.Value = 7200
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(91) Then
            NumericUpDown18.Value = 7280
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(92) Then
            NumericUpDown18.Value = 7360
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(93) Then
            NumericUpDown18.Value = 7440
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(94) Then
            NumericUpDown18.Value = 7520
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(95) Then
            NumericUpDown18.Value = 7600
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(96) Then
            NumericUpDown18.Value = 7680
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(97) Then
            NumericUpDown18.Value = 7760
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(98) Then
            NumericUpDown18.Value = 7840
        ElseIf ComboBox7.SelectedItem = ComboBox7.Items.Item(99) Then
            NumericUpDown18.Value = 7920
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(0) Then
            NumericUpDown21.Value = 0
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(1) Then
            NumericUpDown21.Value = 80
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(2) Then
            NumericUpDown21.Value = 160
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(3) Then
            NumericUpDown21.Value = 240
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(4) Then
            NumericUpDown21.Value = 320
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(5) Then
            NumericUpDown21.Value = 400
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(6) Then
            NumericUpDown21.Value = 480
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(7) Then
            NumericUpDown21.Value = 560
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(8) Then
            NumericUpDown21.Value = 640
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(9) Then
            NumericUpDown21.Value = 720
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(10) Then
            NumericUpDown21.Value = 800
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(11) Then
            NumericUpDown21.Value = 880
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(12) Then
            NumericUpDown21.Value = 960
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(13) Then
            NumericUpDown21.Value = 1040
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(14) Then
            NumericUpDown21.Value = 1120
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(15) Then
            NumericUpDown21.Value = 1200
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(16) Then
            NumericUpDown21.Value = 1280
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(17) Then
            NumericUpDown21.Value = 1360
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(18) Then
            NumericUpDown21.Value = 1440
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(19) Then
            NumericUpDown21.Value = 1520
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(20) Then
            NumericUpDown21.Value = 1600
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(21) Then
            NumericUpDown21.Value = 1680
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(22) Then
            NumericUpDown21.Value = 1760
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(23) Then
            NumericUpDown21.Value = 1840
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(24) Then
            NumericUpDown21.Value = 1920
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(25) Then
            NumericUpDown21.Value = 2000
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(26) Then
            NumericUpDown21.Value = 2080
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(27) Then
            NumericUpDown21.Value = 2160
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(28) Then
            NumericUpDown21.Value = 2240
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(29) Then
            NumericUpDown21.Value = 2320
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(30) Then
            NumericUpDown21.Value = 2400
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(31) Then
            NumericUpDown21.Value = 2480
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(32) Then
            NumericUpDown21.Value = 2560
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(33) Then
            NumericUpDown21.Value = 2640
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(34) Then
            NumericUpDown21.Value = 2720
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(35) Then
            NumericUpDown21.Value = 2800
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(36) Then
            NumericUpDown21.Value = 2880
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(37) Then
            NumericUpDown21.Value = 2960
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(38) Then
            NumericUpDown21.Value = 3040
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(39) Then
            NumericUpDown21.Value = 3120
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(40) Then
            NumericUpDown21.Value = 3200
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(41) Then
            NumericUpDown21.Value = 3280
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(42) Then
            NumericUpDown21.Value = 3360
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(43) Then
            NumericUpDown21.Value = 3440
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(44) Then
            NumericUpDown21.Value = 3520
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(45) Then
            NumericUpDown21.Value = 3600
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(46) Then
            NumericUpDown21.Value = 3680
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(47) Then
            NumericUpDown21.Value = 3760
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(48) Then
            NumericUpDown21.Value = 3840
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(49) Then
            NumericUpDown21.Value = 3920
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(50) Then
            NumericUpDown21.Value = 4000
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(51) Then
            NumericUpDown21.Value = 4080
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(52) Then
            NumericUpDown21.Value = 4160
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(53) Then
            NumericUpDown21.Value = 4240
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(54) Then
            NumericUpDown21.Value = 4320
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(55) Then
            NumericUpDown21.Value = 4400
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(56) Then
            NumericUpDown21.Value = 4480
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(57) Then
            NumericUpDown21.Value = 4560
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(58) Then
            NumericUpDown21.Value = 4640
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(59) Then
            NumericUpDown21.Value = 4720
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(60) Then
            NumericUpDown21.Value = 4800
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(61) Then
            NumericUpDown21.Value = 4880
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(62) Then
            NumericUpDown21.Value = 4960
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(63) Then
            NumericUpDown21.Value = 5040
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(64) Then
            NumericUpDown21.Value = 5120
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(65) Then
            NumericUpDown21.Value = 5200
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(66) Then
            NumericUpDown21.Value = 5280
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(67) Then
            NumericUpDown21.Value = 5360
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(68) Then
            NumericUpDown21.Value = 5440
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(69) Then
            NumericUpDown21.Value = 5520
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(70) Then
            NumericUpDown21.Value = 5600
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(71) Then
            NumericUpDown21.Value = 5680
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(72) Then
            NumericUpDown21.Value = 5760
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(73) Then
            NumericUpDown21.Value = 5840
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(74) Then
            NumericUpDown21.Value = 5920
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(75) Then
            NumericUpDown21.Value = 6000
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(76) Then
            NumericUpDown21.Value = 6080
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(77) Then
            NumericUpDown21.Value = 6160
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(78) Then
            NumericUpDown21.Value = 6240
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(79) Then
            NumericUpDown21.Value = 6320
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(80) Then
            NumericUpDown21.Value = 6400
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(81) Then
            NumericUpDown21.Value = 6480
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(82) Then
            NumericUpDown21.Value = 6560
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(83) Then
            NumericUpDown21.Value = 6640
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(84) Then
            NumericUpDown21.Value = 6720
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(85) Then
            NumericUpDown21.Value = 6800
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(86) Then
            NumericUpDown21.Value = 6880
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(87) Then
            NumericUpDown21.Value = 6960
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(88) Then
            NumericUpDown21.Value = 7040
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(89) Then
            NumericUpDown21.Value = 7120
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(90) Then
            NumericUpDown21.Value = 7200
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(91) Then
            NumericUpDown21.Value = 7280
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(92) Then
            NumericUpDown21.Value = 7360
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(93) Then
            NumericUpDown21.Value = 7440
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(94) Then
            NumericUpDown21.Value = 7520
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(95) Then
            NumericUpDown21.Value = 7600
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(96) Then
            NumericUpDown21.Value = 7680
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(97) Then
            NumericUpDown21.Value = 7760
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(98) Then
            NumericUpDown21.Value = 7840
        ElseIf ComboBox8.SelectedItem = ComboBox8.Items.Item(99) Then
            NumericUpDown21.Value = 7920
        End If
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(0) Then
            NumericUpDown20.Value = 0
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(1) Then
            NumericUpDown20.Value = 80
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(2) Then
            NumericUpDown20.Value = 160
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(3) Then
            NumericUpDown20.Value = 240
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(4) Then
            NumericUpDown20.Value = 320
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(5) Then
            NumericUpDown20.Value = 400
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(6) Then
            NumericUpDown20.Value = 480
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(7) Then
            NumericUpDown20.Value = 560
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(8) Then
            NumericUpDown20.Value = 640
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(9) Then
            NumericUpDown20.Value = 720
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(10) Then
            NumericUpDown20.Value = 800
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(11) Then
            NumericUpDown20.Value = 880
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(12) Then
            NumericUpDown20.Value = 960
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(13) Then
            NumericUpDown20.Value = 1040
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(14) Then
            NumericUpDown20.Value = 1120
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(15) Then
            NumericUpDown20.Value = 1200
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(16) Then
            NumericUpDown20.Value = 1280
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(17) Then
            NumericUpDown20.Value = 1360
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(18) Then
            NumericUpDown20.Value = 1440
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(19) Then
            NumericUpDown20.Value = 1520
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(20) Then
            NumericUpDown20.Value = 1600
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(21) Then
            NumericUpDown20.Value = 1680
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(22) Then
            NumericUpDown20.Value = 1760
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(23) Then
            NumericUpDown20.Value = 1840
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(24) Then
            NumericUpDown20.Value = 1920
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(25) Then
            NumericUpDown20.Value = 2000
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(26) Then
            NumericUpDown20.Value = 2080
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(27) Then
            NumericUpDown20.Value = 2160
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(28) Then
            NumericUpDown20.Value = 2240
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(29) Then
            NumericUpDown20.Value = 2320
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(30) Then
            NumericUpDown20.Value = 2400
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(31) Then
            NumericUpDown20.Value = 2480
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(32) Then
            NumericUpDown20.Value = 2560
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(33) Then
            NumericUpDown20.Value = 2640
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(34) Then
            NumericUpDown20.Value = 2720
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(35) Then
            NumericUpDown20.Value = 2800
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(36) Then
            NumericUpDown20.Value = 2880
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(37) Then
            NumericUpDown20.Value = 2960
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(38) Then
            NumericUpDown20.Value = 3040
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(39) Then
            NumericUpDown20.Value = 3120
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(40) Then
            NumericUpDown20.Value = 3200
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(41) Then
            NumericUpDown20.Value = 3280
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(42) Then
            NumericUpDown20.Value = 3360
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(43) Then
            NumericUpDown20.Value = 3440
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(44) Then
            NumericUpDown20.Value = 3520
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(45) Then
            NumericUpDown20.Value = 3600
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(46) Then
            NumericUpDown20.Value = 3680
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(47) Then
            NumericUpDown20.Value = 3760
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(48) Then
            NumericUpDown20.Value = 3840
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(49) Then
            NumericUpDown20.Value = 3920
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(50) Then
            NumericUpDown20.Value = 4000
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(51) Then
            NumericUpDown20.Value = 4080
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(52) Then
            NumericUpDown20.Value = 4160
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(53) Then
            NumericUpDown20.Value = 4240
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(54) Then
            NumericUpDown20.Value = 4320
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(55) Then
            NumericUpDown20.Value = 4400
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(56) Then
            NumericUpDown20.Value = 4480
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(57) Then
            NumericUpDown20.Value = 4560
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(58) Then
            NumericUpDown20.Value = 4640
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(59) Then
            NumericUpDown20.Value = 4720
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(60) Then
            NumericUpDown20.Value = 4800
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(61) Then
            NumericUpDown20.Value = 4880
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(62) Then
            NumericUpDown20.Value = 4960
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(63) Then
            NumericUpDown20.Value = 5040
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(64) Then
            NumericUpDown20.Value = 5120
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(65) Then
            NumericUpDown20.Value = 5200
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(66) Then
            NumericUpDown20.Value = 5280
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(67) Then
            NumericUpDown20.Value = 5360
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(68) Then
            NumericUpDown20.Value = 5440
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(69) Then
            NumericUpDown20.Value = 5520
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(70) Then
            NumericUpDown20.Value = 5600
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(71) Then
            NumericUpDown20.Value = 5680
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(72) Then
            NumericUpDown20.Value = 5760
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(73) Then
            NumericUpDown20.Value = 5840
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(74) Then
            NumericUpDown20.Value = 5920
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(75) Then
            NumericUpDown20.Value = 6000
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(76) Then
            NumericUpDown20.Value = 6080
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(77) Then
            NumericUpDown20.Value = 6160
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(78) Then
            NumericUpDown20.Value = 6240
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(79) Then
            NumericUpDown20.Value = 6320
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(80) Then
            NumericUpDown20.Value = 6400
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(81) Then
            NumericUpDown20.Value = 6480
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(82) Then
            NumericUpDown20.Value = 6560
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(83) Then
            NumericUpDown20.Value = 6640
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(84) Then
            NumericUpDown20.Value = 6720
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(85) Then
            NumericUpDown20.Value = 6800
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(86) Then
            NumericUpDown20.Value = 6880
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(87) Then
            NumericUpDown20.Value = 6960
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(88) Then
            NumericUpDown20.Value = 7040
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(89) Then
            NumericUpDown20.Value = 7120
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(90) Then
            NumericUpDown20.Value = 7200
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(91) Then
            NumericUpDown20.Value = 7280
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(92) Then
            NumericUpDown20.Value = 7360
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(93) Then
            NumericUpDown20.Value = 7440
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(94) Then
            NumericUpDown20.Value = 7520
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(95) Then
            NumericUpDown20.Value = 7600
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(96) Then
            NumericUpDown20.Value = 7680
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(97) Then
            NumericUpDown20.Value = 7760
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(98) Then
            NumericUpDown20.Value = 7840
        ElseIf ComboBox9.SelectedItem = ComboBox9.Items.Item(99) Then
            NumericUpDown20.Value = 7920
        End If
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox10.SelectedIndexChanged
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(0) Then
            NumericUpDown19.Value = 0
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(1) Then
            NumericUpDown19.Value = 80
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(2) Then
            NumericUpDown19.Value = 160
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(3) Then
            NumericUpDown19.Value = 240
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(4) Then
            NumericUpDown19.Value = 320
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(5) Then
            NumericUpDown19.Value = 400
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(6) Then
            NumericUpDown19.Value = 480
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(7) Then
            NumericUpDown19.Value = 560
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(8) Then
            NumericUpDown19.Value = 640
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(9) Then
            NumericUpDown19.Value = 720
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(10) Then
            NumericUpDown19.Value = 800
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(11) Then
            NumericUpDown19.Value = 880
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(12) Then
            NumericUpDown19.Value = 960
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(13) Then
            NumericUpDown19.Value = 1040
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(14) Then
            NumericUpDown19.Value = 1120
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(15) Then
            NumericUpDown19.Value = 1200
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(16) Then
            NumericUpDown19.Value = 1280
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(17) Then
            NumericUpDown19.Value = 1360
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(18) Then
            NumericUpDown19.Value = 1440
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(19) Then
            NumericUpDown19.Value = 1520
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(20) Then
            NumericUpDown19.Value = 1600
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(21) Then
            NumericUpDown19.Value = 1680
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(22) Then
            NumericUpDown19.Value = 1760
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(23) Then
            NumericUpDown19.Value = 1840
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(24) Then
            NumericUpDown19.Value = 1920
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(25) Then
            NumericUpDown19.Value = 2000
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(26) Then
            NumericUpDown19.Value = 2080
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(27) Then
            NumericUpDown19.Value = 2160
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(28) Then
            NumericUpDown19.Value = 2240
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(29) Then
            NumericUpDown19.Value = 2320
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(30) Then
            NumericUpDown19.Value = 2400
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(31) Then
            NumericUpDown19.Value = 2480
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(32) Then
            NumericUpDown19.Value = 2560
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(33) Then
            NumericUpDown19.Value = 2640
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(34) Then
            NumericUpDown19.Value = 2720
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(35) Then
            NumericUpDown19.Value = 2800
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(36) Then
            NumericUpDown19.Value = 2880
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(37) Then
            NumericUpDown19.Value = 2960
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(38) Then
            NumericUpDown19.Value = 3040
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(39) Then
            NumericUpDown19.Value = 3120
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(40) Then
            NumericUpDown19.Value = 3200
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(41) Then
            NumericUpDown19.Value = 3280
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(42) Then
            NumericUpDown19.Value = 3360
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(43) Then
            NumericUpDown19.Value = 3440
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(44) Then
            NumericUpDown19.Value = 3520
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(45) Then
            NumericUpDown19.Value = 3600
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(46) Then
            NumericUpDown19.Value = 3680
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(47) Then
            NumericUpDown19.Value = 3760
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(48) Then
            NumericUpDown19.Value = 3840
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(49) Then
            NumericUpDown19.Value = 3920
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(50) Then
            NumericUpDown19.Value = 4000
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(51) Then
            NumericUpDown19.Value = 4080
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(52) Then
            NumericUpDown19.Value = 4160
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(53) Then
            NumericUpDown19.Value = 4240
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(54) Then
            NumericUpDown19.Value = 4320
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(55) Then
            NumericUpDown19.Value = 4400
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(56) Then
            NumericUpDown19.Value = 4480
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(57) Then
            NumericUpDown19.Value = 4560
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(58) Then
            NumericUpDown19.Value = 4640
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(59) Then
            NumericUpDown19.Value = 4720
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(60) Then
            NumericUpDown19.Value = 4800
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(61) Then
            NumericUpDown19.Value = 4880
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(62) Then
            NumericUpDown19.Value = 4960
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(63) Then
            NumericUpDown19.Value = 5040
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(64) Then
            NumericUpDown19.Value = 5120
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(65) Then
            NumericUpDown19.Value = 5200
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(66) Then
            NumericUpDown19.Value = 5280
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(67) Then
            NumericUpDown19.Value = 5360
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(68) Then
            NumericUpDown19.Value = 5440
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(69) Then
            NumericUpDown19.Value = 5520
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(70) Then
            NumericUpDown19.Value = 5600
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(71) Then
            NumericUpDown19.Value = 5680
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(72) Then
            NumericUpDown19.Value = 5760
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(73) Then
            NumericUpDown19.Value = 5840
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(74) Then
            NumericUpDown19.Value = 5920
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(75) Then
            NumericUpDown19.Value = 6000
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(76) Then
            NumericUpDown19.Value = 6080
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(77) Then
            NumericUpDown19.Value = 6160
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(78) Then
            NumericUpDown19.Value = 6240
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(79) Then
            NumericUpDown19.Value = 6320
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(80) Then
            NumericUpDown19.Value = 6400
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(81) Then
            NumericUpDown19.Value = 6480
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(82) Then
            NumericUpDown19.Value = 6560
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(83) Then
            NumericUpDown19.Value = 6640
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(84) Then
            NumericUpDown19.Value = 6720
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(85) Then
            NumericUpDown19.Value = 6800
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(86) Then
            NumericUpDown19.Value = 6880
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(87) Then
            NumericUpDown19.Value = 6960
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(88) Then
            NumericUpDown19.Value = 7040
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(89) Then
            NumericUpDown19.Value = 7120
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(90) Then
            NumericUpDown19.Value = 7200
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(91) Then
            NumericUpDown19.Value = 7280
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(92) Then
            NumericUpDown19.Value = 7360
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(93) Then
            NumericUpDown19.Value = 7440
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(94) Then
            NumericUpDown19.Value = 7520
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(95) Then
            NumericUpDown19.Value = 7600
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(96) Then
            NumericUpDown19.Value = 7680
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(97) Then
            NumericUpDown19.Value = 7760
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(98) Then
            NumericUpDown19.Value = 7840
        ElseIf ComboBox10.SelectedItem = ComboBox10.Items.Item(99) Then
            NumericUpDown19.Value = 7920
        End If
    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox11.SelectedIndexChanged
        If ComboBox11.SelectedItem = ComboBox11.Items.Item(0) Then
            PictureBox11.Image = My.Resources.Tumempty
        ElseIf ComboBox11.SelectedItem = ComboBox11.Items.Item(1) Then
            PictureBox11.Image = My.Resources.Tumfull
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True And ComboBox11.SelectedItem = ComboBox11.Items.Item(0) Then
            NumericUpDown23.Value = 0
        ElseIf CheckBox1.Checked = True And ComboBox11.SelectedItem = ComboBox11.Items.Item(1) Then
            NumericUpDown23.Value = 100
        End If
    End Sub
End Class
