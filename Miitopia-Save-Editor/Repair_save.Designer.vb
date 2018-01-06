<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Repair_save
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Repair_save))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox_fpath_quest = New System.Windows.Forms.TextBox()
        Me.File_path_quest = New System.Windows.Forms.Panel()
        Me.TextBox_fpath_hero = New System.Windows.Forms.TextBox()
        Me.Descrip_panel = New System.Windows.Forms.Panel()
        Me.Descrip_text = New System.Windows.Forms.Label()
        Me.Closebutton = New System.Windows.Forms.PictureBox()
        Me.MSE_iconupdate = New System.Windows.Forms.PictureBox()
        Me.MSE_icon = New System.Windows.Forms.PictureBox()
        Me.MSE_logo = New System.Windows.Forms.PictureBox()
        Me.MSE_header = New System.Windows.Forms.Panel()
        Me.TextBox_fpath_common = New System.Windows.Forms.TextBox()
        Me.File_path_common = New System.Windows.Forms.Panel()
        Me.Filever_text = New System.Windows.Forms.Label()
        Me.Panel_slt_save = New System.Windows.Forms.Panel()
        Me.File_path_hero = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_Open = New System.Windows.Forms.Panel()
        Me.text_open = New System.Windows.Forms.Label()
        Me.Button_Save = New System.Windows.Forms.Panel()
        Me.text_save = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.File_path_quest.SuspendLayout()
        Me.Descrip_panel.SuspendLayout()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSE_iconupdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSE_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSE_header.SuspendLayout()
        Me.File_path_common.SuspendLayout()
        Me.Panel_slt_save.SuspendLayout()
        Me.File_path_hero.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Button_Open.SuspendLayout()
        Me.Button_Save.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.bg_panel_common
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Repair common.sav"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Miitopia_Save_Editor.My.Resources.Resources.file_repair
        Me.PictureBox1.Location = New System.Drawing.Point(46, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox_fpath_quest
        '
        Me.TextBox_fpath_quest.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox_fpath_quest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_fpath_quest.Location = New System.Drawing.Point(3, 6)
        Me.TextBox_fpath_quest.Name = "TextBox_fpath_quest"
        Me.TextBox_fpath_quest.ReadOnly = True
        Me.TextBox_fpath_quest.Size = New System.Drawing.Size(364, 13)
        Me.TextBox_fpath_quest.TabIndex = 0
        '
        'File_path_quest
        '
        Me.File_path_quest.BackColor = System.Drawing.Color.Transparent
        Me.File_path_quest.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.bg_menu
        Me.File_path_quest.Controls.Add(Me.TextBox_fpath_quest)
        Me.File_path_quest.Location = New System.Drawing.Point(112, 31)
        Me.File_path_quest.Name = "File_path_quest"
        Me.File_path_quest.Size = New System.Drawing.Size(370, 25)
        Me.File_path_quest.TabIndex = 30
        Me.File_path_quest.Visible = False
        '
        'TextBox_fpath_hero
        '
        Me.TextBox_fpath_hero.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox_fpath_hero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_fpath_hero.Location = New System.Drawing.Point(3, 6)
        Me.TextBox_fpath_hero.Name = "TextBox_fpath_hero"
        Me.TextBox_fpath_hero.ReadOnly = True
        Me.TextBox_fpath_hero.Size = New System.Drawing.Size(364, 13)
        Me.TextBox_fpath_hero.TabIndex = 0
        '
        'Descrip_panel
        '
        Me.Descrip_panel.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.bg_descrip
        Me.Descrip_panel.Controls.Add(Me.Descrip_text)
        Me.Descrip_panel.ForeColor = System.Drawing.Color.White
        Me.Descrip_panel.Location = New System.Drawing.Point(0, 469)
        Me.Descrip_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Descrip_panel.Name = "Descrip_panel"
        Me.Descrip_panel.Size = New System.Drawing.Size(550, 31)
        Me.Descrip_panel.TabIndex = 19
        Me.Descrip_panel.Visible = False
        '
        'Descrip_text
        '
        Me.Descrip_text.BackColor = System.Drawing.Color.Transparent
        Me.Descrip_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descrip_text.Location = New System.Drawing.Point(6, 0)
        Me.Descrip_text.Name = "Descrip_text"
        Me.Descrip_text.Size = New System.Drawing.Size(538, 31)
        Me.Descrip_text.TabIndex = 1
        Me.Descrip_text.Text = "Description here"
        Me.Descrip_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Closebutton
        '
        Me.Closebutton.BackColor = System.Drawing.Color.Transparent
        Me.Closebutton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Closebutton.Image = CType(resources.GetObject("Closebutton.Image"), System.Drawing.Image)
        Me.Closebutton.Location = New System.Drawing.Point(505, 0)
        Me.Closebutton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Closebutton.Name = "Closebutton"
        Me.Closebutton.Size = New System.Drawing.Size(45, 30)
        Me.Closebutton.TabIndex = 2
        Me.Closebutton.TabStop = False
        '
        'MSE_iconupdate
        '
        Me.MSE_iconupdate.BackColor = System.Drawing.Color.Transparent
        Me.MSE_iconupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MSE_iconupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MSE_iconupdate.Image = Global.Miitopia_Save_Editor.My.Resources.Resources.iconupdate
        Me.MSE_iconupdate.Location = New System.Drawing.Point(0, 0)
        Me.MSE_iconupdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MSE_iconupdate.Name = "MSE_iconupdate"
        Me.MSE_iconupdate.Size = New System.Drawing.Size(38, 30)
        Me.MSE_iconupdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MSE_iconupdate.TabIndex = 5
        Me.MSE_iconupdate.TabStop = False
        Me.MSE_iconupdate.Visible = False
        '
        'MSE_icon
        '
        Me.MSE_icon.BackColor = System.Drawing.Color.Transparent
        Me.MSE_icon.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.icon
        Me.MSE_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MSE_icon.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MSE_icon.Location = New System.Drawing.Point(0, 0)
        Me.MSE_icon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MSE_icon.Name = "MSE_icon"
        Me.MSE_icon.Size = New System.Drawing.Size(30, 30)
        Me.MSE_icon.TabIndex = 3
        Me.MSE_icon.TabStop = False
        '
        'MSE_logo
        '
        Me.MSE_logo.BackColor = System.Drawing.Color.Transparent
        Me.MSE_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MSE_logo.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.MSE_logo.Image = Global.Miitopia_Save_Editor.My.Resources.Resources.MSE_logo
        Me.MSE_logo.Location = New System.Drawing.Point(226, 0)
        Me.MSE_logo.Name = "MSE_logo"
        Me.MSE_logo.Size = New System.Drawing.Size(98, 30)
        Me.MSE_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MSE_logo.TabIndex = 2
        Me.MSE_logo.TabStop = False
        '
        'MSE_header
        '
        Me.MSE_header.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.bg_banner
        Me.MSE_header.Controls.Add(Me.MSE_icon)
        Me.MSE_header.Controls.Add(Me.MSE_logo)
        Me.MSE_header.Controls.Add(Me.Closebutton)
        Me.MSE_header.Controls.Add(Me.MSE_iconupdate)
        Me.MSE_header.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.MSE_header.Location = New System.Drawing.Point(0, 0)
        Me.MSE_header.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MSE_header.Name = "MSE_header"
        Me.MSE_header.Size = New System.Drawing.Size(550, 30)
        Me.MSE_header.TabIndex = 18
        '
        'TextBox_fpath_common
        '
        Me.TextBox_fpath_common.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox_fpath_common.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_fpath_common.Location = New System.Drawing.Point(3, 6)
        Me.TextBox_fpath_common.Name = "TextBox_fpath_common"
        Me.TextBox_fpath_common.ReadOnly = True
        Me.TextBox_fpath_common.Size = New System.Drawing.Size(364, 13)
        Me.TextBox_fpath_common.TabIndex = 0
        '
        'File_path_common
        '
        Me.File_path_common.BackColor = System.Drawing.Color.Transparent
        Me.File_path_common.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.bg_menu
        Me.File_path_common.Controls.Add(Me.TextBox_fpath_common)
        Me.File_path_common.Location = New System.Drawing.Point(112, 31)
        Me.File_path_common.Name = "File_path_common"
        Me.File_path_common.Size = New System.Drawing.Size(370, 25)
        Me.File_path_common.TabIndex = 26
        Me.File_path_common.Visible = False
        '
        'Filever_text
        '
        Me.Filever_text.BackColor = System.Drawing.Color.Transparent
        Me.Filever_text.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Filever_text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Filever_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filever_text.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Filever_text.Location = New System.Drawing.Point(0, 0)
        Me.Filever_text.Name = "Filever_text"
        Me.Filever_text.Size = New System.Drawing.Size(30, 25)
        Me.Filever_text.TabIndex = 0
        Me.Filever_text.Text = "US"
        Me.Filever_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_slt_save
        '
        Me.Panel_slt_save.BackColor = System.Drawing.Color.Transparent
        Me.Panel_slt_save.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.bg_menu
        Me.Panel_slt_save.Controls.Add(Me.Filever_text)
        Me.Panel_slt_save.Location = New System.Drawing.Point(488, 31)
        Me.Panel_slt_save.Name = "Panel_slt_save"
        Me.Panel_slt_save.Size = New System.Drawing.Size(30, 25)
        Me.Panel_slt_save.TabIndex = 25
        '
        'File_path_hero
        '
        Me.File_path_hero.BackColor = System.Drawing.Color.Transparent
        Me.File_path_hero.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.bg_menu
        Me.File_path_hero.Controls.Add(Me.TextBox_fpath_hero)
        Me.File_path_hero.Location = New System.Drawing.Point(112, 31)
        Me.File_path_hero.Name = "File_path_hero"
        Me.File_path_hero.Size = New System.Drawing.Size(370, 25)
        Me.File_path_hero.TabIndex = 32
        Me.File_path_hero.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.bg_panel_hero
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(150, 100)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Repair hero.sav"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Miitopia_Save_Editor.My.Resources.Resources.file_repair
        Me.PictureBox2.Location = New System.Drawing.Point(46, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.bg_panel_common
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 367)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 100)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Repair cottage.sav"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Miitopia_Save_Editor.My.Resources.Resources.file_repair
        Me.PictureBox3.Location = New System.Drawing.Point(46, 35)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.bg_panel_quest
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.PictureBox4)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 264)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(150, 100)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Repair quest.sav"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.Miitopia_Save_Editor.My.Resources.Resources.file_repair
        Me.PictureBox4.Location = New System.Drawing.Point(46, 35)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.bg_tabpage
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.Button_Open)
        Me.Panel1.Controls.Add(Me.Button_Save)
        Me.Panel1.Location = New System.Drawing.Point(163, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 407)
        Me.Panel1.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(94, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "C."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(94, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "H."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(94, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Q."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(94, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ct."
        '
        'Button_Open
        '
        Me.Button_Open.BackColor = System.Drawing.Color.Transparent
        Me.Button_Open.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.button_open
        Me.Button_Open.Controls.Add(Me.text_open)
        Me.Button_Open.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Open.Location = New System.Drawing.Point(254, 9)
        Me.Button_Open.Name = "Button_Open"
        Me.Button_Open.Size = New System.Drawing.Size(115, 47)
        Me.Button_Open.TabIndex = 3
        '
        'text_open
        '
        Me.text_open.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_open.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_open.ForeColor = System.Drawing.SystemColors.Info
        Me.text_open.Location = New System.Drawing.Point(0, 0)
        Me.text_open.Name = "text_open"
        Me.text_open.Size = New System.Drawing.Size(115, 47)
        Me.text_open.TabIndex = 0
        Me.text_open.Text = "Open"
        Me.text_open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_Save
        '
        Me.Button_Save.BackColor = System.Drawing.Color.Transparent
        Me.Button_Save.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.button_save
        Me.Button_Save.Controls.Add(Me.text_save)
        Me.Button_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Save.Location = New System.Drawing.Point(254, 9)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(115, 47)
        Me.Button_Save.TabIndex = 4
        '
        'text_save
        '
        Me.text_save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_save.ForeColor = System.Drawing.SystemColors.Info
        Me.text_save.Location = New System.Drawing.Point(0, 0)
        Me.text_save.Name = "text_save"
        Me.text_save.Size = New System.Drawing.Size(115, 47)
        Me.text_save.TabIndex = 0
        Me.text_save.Text = "Save"
        Me.text_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.bg_banner
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(43, 93)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(287, 36)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Header"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(17, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(253, 13)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Repair_save
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Miitopia_Save_Editor.My.Resources.Resources.bg_footer01
        Me.ClientSize = New System.Drawing.Size(550, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.File_path_quest)
        Me.Controls.Add(Me.Descrip_panel)
        Me.Controls.Add(Me.MSE_header)
        Me.Controls.Add(Me.File_path_common)
        Me.Controls.Add(Me.Panel_slt_save)
        Me.Controls.Add(Me.File_path_hero)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Repair_save"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repair_save"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.File_path_quest.ResumeLayout(False)
        Me.File_path_quest.PerformLayout()
        Me.Descrip_panel.ResumeLayout(False)
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSE_iconupdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSE_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSE_header.ResumeLayout(False)
        Me.File_path_common.ResumeLayout(False)
        Me.File_path_common.PerformLayout()
        Me.Panel_slt_save.ResumeLayout(False)
        Me.File_path_hero.ResumeLayout(False)
        Me.File_path_hero.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Button_Open.ResumeLayout(False)
        Me.Button_Save.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_fpath_quest As System.Windows.Forms.TextBox
    Friend WithEvents File_path_quest As System.Windows.Forms.Panel
    Friend WithEvents TextBox_fpath_hero As System.Windows.Forms.TextBox
    Friend WithEvents Descrip_panel As System.Windows.Forms.Panel
    Friend WithEvents Descrip_text As System.Windows.Forms.Label
    Friend WithEvents Closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents MSE_iconupdate As System.Windows.Forms.PictureBox
    Friend WithEvents MSE_icon As System.Windows.Forms.PictureBox
    Friend WithEvents MSE_logo As System.Windows.Forms.PictureBox
    Friend WithEvents MSE_header As System.Windows.Forms.Panel
    Friend WithEvents TextBox_fpath_common As System.Windows.Forms.TextBox
    Friend WithEvents File_path_common As System.Windows.Forms.Panel
    Friend WithEvents Filever_text As System.Windows.Forms.Label
    Friend WithEvents Panel_slt_save As System.Windows.Forms.Panel
    Friend WithEvents File_path_hero As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button_Open As System.Windows.Forms.Panel
    Friend WithEvents text_open As System.Windows.Forms.Label
    Friend WithEvents Button_Save As System.Windows.Forms.Panel
    Friend WithEvents text_save As System.Windows.Forms.Label
End Class
