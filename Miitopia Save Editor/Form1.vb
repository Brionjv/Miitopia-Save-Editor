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
        fdialog.Label1.Text = "Miitopia Save Editor"
        fdialog.Label2.Text = "Open common.sav file" & vbNewLine & "Backup your save file before use" & vbNewLine & "Miitopia Save Editor"
        fdialog.ShowDialog()
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
            fdialog.Label1.Text = "common.sav"
            fdialog.Label2.Text = "common.sav not load" & vbNewLine & "Save file can be corrupted or not Miitopia 'common.sav'"
            fdialog.ShowDialog()
            End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim open1 As New OpenFileDialog
        fdialog.Label1.Text = "Miitopia Save Editor"
        fdialog.Label2.Text = "hero.sav not load" & vbNewLine & "Save file can be corrupted or not Miitopia 'hero.sav'"
        fdialog.ShowDialog()
        open1.Filter = "SAV files|*.sav"
        open1.Title = "Open save hero.sav"
        open1.ShowDialog()
        hero = open1.FileName
        Readfilehero()
    End Sub

    Private Sub Readfilehero()
        Try

        Catch ex As Exception
            fdialog.Label1.Text = "hero.sav"
            fdialog.Label2.Text = "hero.sav not load"
            fdialog.ShowDialog()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim Reader As New PackageIO.Reader(hero, PackageIO.Endian.Little)
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
            End If
        Catch ex As Exception
            fdialog.Label1.Text = "hero.sav : select Mii"
            fdialog.Label2.Text = "An error has occured, load hero.sav first"
            fdialog.ShowDialog()
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try
            Dim Writer As New PackageIO.Writer(common, PackageIO.Endian.Little)
            For i As Integer = 0 To 126
                Writer.Position = &H2C
                Writer.WriteInt8(NumericUpDown2.Value)
            Next
            fdialog.Label1.Text = "common.sav : foods"
            fdialog.Label2.Text = "All foods has been unlocked"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Label1.Text = "common.sav : foods"
            fdialog.Label2.Text = "An error has occured, load common.sav first"
            fdialog.ShowDialog()
        End Try
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As EventArgs) Handles PictureBox3.MouseMove
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        Label2.Visible = True
        Label2.Text = "Click to unlock all foods by numbers"
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
            fdialog.Label1.Text = "common.sav : salt shakers"
            fdialog.Label2.Text = "All salt shakers has been unlocked"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Label1.Text = "common.sav : salt shakers"
            fdialog.Label2.Text = "An error has occured, load common.sav first"
            fdialog.ShowDialog()
        End Try
    End Sub

    Private Sub PictureBox7_MouseMove(sender As Object, e As EventArgs) Handles PictureBox7.MouseMove
        PictureBox7.BorderStyle = BorderStyle.None
        Label2.Visible = True
        Label2.Text = "Click to unlock all salt shakers"
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
            fdialog.Label1.Text = "Miitopia Save Editor : common.sav"
            fdialog.Label2.Text = "File save"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Label1.Text = "Miitopia Save Editor : common.sav"
            fdialog.Label2.Text = "An error has occured"
            fdialog.ShowDialog()
        End Try
    End Sub

    Private Sub NumericUpDown7_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown7.ValueChanged
        If NumericUpDown7.Value = 0 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(0)
        ElseIf NumericUpDown7.Value = 1 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(1)
        ElseIf NumericUpDown7.Value = 2 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(2)
        ElseIf NumericUpDown7.Value = 3 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(3)
        ElseIf NumericUpDown7.Value = 4 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(4)
        ElseIf NumericUpDown7.Value = 5 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(5)
        ElseIf NumericUpDown7.Value = 6 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(6)
        ElseIf NumericUpDown7.Value = 7 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(7)
        ElseIf NumericUpDown7.Value = 8 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(8)
        ElseIf NumericUpDown7.Value = 9 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(9)
        ElseIf NumericUpDown7.Value = 10 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(10)
        ElseIf NumericUpDown7.Value = 11 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(11)
        ElseIf NumericUpDown7.Value = 12 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(12)
        ElseIf NumericUpDown7.Value = 13 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(13)
        ElseIf NumericUpDown7.Value = 14 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(14)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = ComboBox2.Items.Item(0) Then
            NumericUpDown7.Value = 0
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(1) Then
            NumericUpDown7.Value = 1
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(2) Then
            NumericUpDown7.Value = 2
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(3) Then
            NumericUpDown7.Value = 3
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(4) Then
            NumericUpDown7.Value = 4
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(5) Then
            NumericUpDown7.Value = 5
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(6) Then
            NumericUpDown7.Value = 6
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(7) Then
            NumericUpDown7.Value = 7
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(8) Then
            NumericUpDown7.Value = 8
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(9) Then
            NumericUpDown7.Value = 9
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(10) Then
            NumericUpDown7.Value = 10
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(11) Then
            NumericUpDown7.Value = 11
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(12) Then
            NumericUpDown7.Value = 12
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(13) Then
            NumericUpDown7.Value = 13
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(14) Then
            NumericUpDown7.Value = 14
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.SelectedItem = ComboBox2.Items.Item(0)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Label14.Text = TextBox2.Text & " Stats"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim Writer As New PackageIO.Writer(hero, PackageIO.Endian.Little)
            For i As Integer = 0 To 19
                Writer.Position = Miiname
                Writer.WriteInt8(0)
            Next
            Writer.Position = Miiname
            Writer.WriteUnicodeString(TextBox2.Text)
            Writer.Position = Miiclass
            Writer.WriteInt8(NumericUpDown7.Value)
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
            fdialog.Label1.Text = "Miitopia Save Editor : hero.sav"
            fdialog.Label2.Text = "File save"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Label1.Text = "Miitopia Save Editor : hero.sav"
            fdialog.Label2.Text = "An error has occured, load hero.sav first"
            fdialog.ShowDialog()
        End Try
    End Sub
End Class
