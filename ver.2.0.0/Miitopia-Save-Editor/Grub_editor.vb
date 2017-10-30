Public Class Grub_editor
    Dim common As String
    Public Sub hidepanelsfoods()
        Panel_foods_1.Visible = False
        Panel_foods_2.Visible = False
        Panel_foods_3.Visible = False
        Panel_foods_4.Visible = False
    End Sub

    Public Sub Hidearrows()
        Arrow_left_panel1.Visible = False
        Arrow_left_panel2.Visible = False
        Arrow_left_panel3.Visible = False
        Arrow_right_panel2.Visible = False
        Arrow_right_panel3.Visible = False
        Arrow_right_panel4.Visible = False
    End Sub

    Public Sub readgrub()
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Fds_close_text_Click(sender As Object, e As EventArgs) Handles Fds_close_text.Click
        Me.Close()
    End Sub

    Private Sub Fds_close_text_MouseLeave(sender As Object, e As EventArgs) Handles Fds_close_text.MouseLeave
        Fds_button_close.BackgroundImage = My.Resources.buttonfoods_orange
    End Sub

    Private Sub Fds_close_text_MouseMove(sender As Object, e As EventArgs) Handles Fds_close_text.MouseMove
        Fds_button_close.BackgroundImage = My.Resources.buttonfoods_blue
    End Sub

    Private Sub Fds_save_text_Click(sender As Object, e As EventArgs) Handles Fds_save_text.Click

    End Sub

    Private Sub Fds_save_text_MouseLeave(sender As Object, e As EventArgs) Handles Fds_save_text.MouseLeave
        Fds_button_save.BackgroundImage = My.Resources.buttonfoods_orange
    End Sub

    Private Sub Fds_save_text_MouseMove(sender As Object, e As MouseEventArgs) Handles Fds_save_text.MouseMove
        Fds_button_save.BackgroundImage = My.Resources.buttonfoods_blue
    End Sub

    Private Sub Panel_setall_Click(sender As Object, e As EventArgs) Handles Panel_setall.Click, Text_setall.Click

    End Sub

    Private Sub Arrow_right_panel2_Click(sender As Object, e As EventArgs) Handles Arrow_right_panel2.Click
        hidepanelsfoods()
        Hidearrows()
        Panel_foods_2.Visible = True
        Arrow_left_panel1.Visible = True
        Arrow_right_panel3.Visible = True
    End Sub

    Private Sub Arrow_left_panel1_Click(sender As Object, e As EventArgs) Handles Arrow_left_panel1.Click
        hidepanelsfoods()
        Hidearrows()
        Panel_foods_1.Visible = True
        Arrow_right_panel2.Visible = True
    End Sub

    Private Sub Arrow_right_panel3_Click(sender As Object, e As EventArgs) Handles Arrow_right_panel3.Click
        hidepanelsfoods()
        Hidearrows()
        Panel_foods_3.Visible = True
        Arrow_left_panel2.Visible = True
        Arrow_right_panel4.Visible = True
    End Sub

    Private Sub Arrow_left_panel2_Click(sender As Object, e As EventArgs) Handles Arrow_left_panel2.Click
        hidepanelsfoods()
        Hidearrows()
        Panel_foods_2.Visible = True
        Arrow_left_panel1.Visible = True
        Arrow_right_panel3.Visible = True
    End Sub

    Private Sub Grub_editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        common = Miitopia_SE.TextBox_fpath.Text
        readgrub()
    End Sub

    Private Sub Arrow_right_panel4_Click(sender As Object, e As EventArgs) Handles Arrow_right_panel4.Click
        hidepanelsfoods()
        Hidearrows()
        Panel_foods_4.Visible = True
        Arrow_left_panel3.Visible = True
    End Sub

    Private Sub Arrow_left_panel3_Click(sender As Object, e As EventArgs) Handles Arrow_left_panel3.Click
        hidepanelsfoods()
        Hidearrows()
        Panel_foods_3.Visible = True
        Arrow_left_panel2.Visible = True
        Arrow_right_panel4.Visible = True
    End Sub
End Class