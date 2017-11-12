Public Class Grub_editor
    Dim common As String
    Dim fdialog As New Form2
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
            Dim reader As New PackageIO.Reader(common, PackageIO.Endian.Little)
            reader.Position = &H2C
            valu_grub_1.Value = reader.ReadInt8
            reader.Position = &H2D
            valu_grub_2.Value = reader.ReadInt8
            reader.Position = &H2E
            valu_grub_3.Value = reader.ReadInt8
            reader.Position = &H2F
            valu_grub_4.Value = reader.ReadInt8
            reader.Position = &H30
            valu_grub_5.Value = reader.ReadInt8
            reader.Position = &H31
            valu_grub_6.Value = reader.ReadInt8
            reader.Position = &H32
            valu_grub_7.Value = reader.ReadInt8
            reader.Position = &H33
            valu_grub_8.Value = reader.ReadInt8
            reader.Position = &H34
            valu_grub_9.Value = reader.ReadInt8
            reader.Position = &H35
            valu_grub_10.Value = reader.ReadInt8
            reader.Position = &H36
            valu_grub_11.Value = reader.ReadInt8
            reader.Position = &H37
            valu_grub_12.Value = reader.ReadInt8
            reader.Position = &H38
            valu_grub_13.Value = reader.ReadInt8
            reader.Position = &H39
            valu_grub_14.Value = reader.ReadInt8
            reader.Position = &H3A
            valu_grub_15.Value = reader.ReadInt8
            reader.Position = &H3B
            valu_grub_16.Value = reader.ReadInt8
            reader.Position = &H3C
            valu_grub_17.Value = reader.ReadInt8
            reader.Position = &H3D
            valu_grub_18.Value = reader.ReadInt8
            reader.Position = &H3E
            valu_grub_19.Value = reader.ReadInt8
            reader.Position = &H3F
            valu_grub_20.Value = reader.ReadInt8
            reader.Position = &H40
            valu_grub_21.Value = reader.ReadInt8
            reader.Position = &H41
            valu_grub_22.Value = reader.ReadInt8
            reader.Position = &H42
            valu_grub_23.Value = reader.ReadInt8
            reader.Position = &H43
            valu_grub_24.Value = reader.ReadInt8
            reader.Position = &H44
            valu_grub_25.Value = reader.ReadInt8
            reader.Position = &H45
            valu_grub_26.Value = reader.ReadInt8
            reader.Position = &H46
            valu_grub_27.Value = reader.ReadInt8
            reader.Position = &H47
            valu_grub_28.Value = reader.ReadInt8
            reader.Position = &H48
            valu_grub_29.Value = reader.ReadInt8
            reader.Position = &H49
            valu_grub_30.Value = reader.ReadInt8
            reader.Position = &H4A
            valu_grub_31.Value = reader.ReadInt8
            reader.Position = &H4B
            valu_grub_32.Value = reader.ReadInt8
            reader.Position = &H4C
            valu_grub_33.Value = reader.ReadInt8
            reader.Position = &H4D
            valu_grub_34.Value = reader.ReadInt8
            reader.Position = &H4E
            valu_grub_35.Value = reader.ReadInt8
            reader.Position = &H4F
            valu_grub_36.Value = reader.ReadInt8
            reader.Position = &H50
            valu_grub_37.Value = reader.ReadInt8
            reader.Position = &H51
            valu_grub_38.Value = reader.ReadInt8
            reader.Position = &H52
            valu_grub_39.Value = reader.ReadInt8
            reader.Position = &H53
            valu_grub_40.Value = reader.ReadInt8
            reader.Position = &H54
            valu_grub_41.Value = reader.ReadInt8
            reader.Position = &H55
            valu_grub_42.Value = reader.ReadInt8
            reader.Position = &H56
            valu_grub_43.Value = reader.ReadInt8
            reader.Position = &H57
            valu_grub_44.Value = reader.ReadInt8
            reader.Position = &H58
            valu_grub_45.Value = reader.ReadInt8
            reader.Position = &H59
            valu_grub_46.Value = reader.ReadInt8
            reader.Position = &H5A
            valu_grub_47.Value = reader.ReadInt8
            reader.Position = &H5B
            valu_grub_48.Value = reader.ReadInt8
            reader.Position = &H5C
            valu_grub_49.Value = reader.ReadInt8
            reader.Position = &H5D
            valu_grub_50.Value = reader.ReadInt8
            reader.Position = &H5E
            valu_grub_51.Value = reader.ReadInt8
            reader.Position = &H5F
            valu_grub_52.Value = reader.ReadInt8
            reader.Position = &H60
            valu_grub_53.Value = reader.ReadInt8
            reader.Position = &H61
            valu_grub_54.Value = reader.ReadInt8
            reader.Position = &H62
            valu_grub_55.Value = reader.ReadInt8
            reader.Position = &H63
            valu_grub_56.Value = reader.ReadInt8
            reader.Position = &H64
            valu_grub_57.Value = reader.ReadInt8
            reader.Position = &H65
            valu_grub_58.Value = reader.ReadInt8
            reader.Position = &H66
            valu_grub_59.Value = reader.ReadInt8
            reader.Position = &H67
            valu_grub_60.Value = reader.ReadInt8
            reader.Position = &H68
            valu_grub_61.Value = reader.ReadInt8
            reader.Position = &H69
            valu_grub_62.Value = reader.ReadInt8
            reader.Position = &H6A
            valu_grub_63.Value = reader.ReadInt8
            reader.Position = &H6B
            valu_grub_64.Value = reader.ReadInt8
            reader.Position = &H6C
            valu_grub_65.Value = reader.ReadInt8
            reader.Position = &H6D
            valu_grub_66.Value = reader.ReadInt8
            reader.Position = &H6E
            valu_grub_67.Value = reader.ReadInt8
            reader.Position = &H6F
            valu_grub_68.Value = reader.ReadInt8
            reader.Position = &H70
            valu_grub_69.Value = reader.ReadInt8
            reader.Position = &H71
            valu_grub_70.Value = reader.ReadInt8
            reader.Position = &H72
            valu_grub_71.Value = reader.ReadInt8
            reader.Position = &H73
            valu_grub_72.Value = reader.ReadInt8
            reader.Position = &H74
            valu_grub_73.Value = reader.ReadInt8
            reader.Position = &H75
            valu_grub_74.Value = reader.ReadInt8
            reader.Position = &H76
            valu_grub_75.Value = reader.ReadInt8
            reader.Position = &H77
            valu_grub_76.Value = reader.ReadInt8
            reader.Position = &H78
            valu_grub_77.Value = reader.ReadInt8
            reader.Position = &H79
            valu_grub_78.Value = reader.ReadInt8
            reader.Position = &H7A
            valu_grub_79.Value = reader.ReadInt8
            reader.Position = &H7B
            valu_grub_80.Value = reader.ReadInt8
            reader.Position = &H7C
            valu_grub_81.Value = reader.ReadInt8
            reader.Position = &H7D
            valu_grub_82.Value = reader.ReadInt8
            reader.Position = &H7E
            valu_grub_83.Value = reader.ReadInt8
            reader.Position = &H7F
            valu_grub_84.Value = reader.ReadInt8
            reader.Position = &H80
            valu_grub_85.Value = reader.ReadInt8
            reader.Position = &H81
            valu_grub_86.Value = reader.ReadInt8
            reader.Position = &H82
            valu_grub_87.Value = reader.ReadInt8
            reader.Position = &H83
            valu_grub_88.Value = reader.ReadInt8
            reader.Position = &H84
            valu_grub_89.Value = reader.ReadInt8
            reader.Position = &H85
            valu_grub_90.Value = reader.ReadInt8
            reader.Position = &H86
            valu_grub_91.Value = reader.ReadInt8
            reader.Position = &H87
            valu_grub_92.Value = reader.ReadInt8
            reader.Position = &H88
            valu_grub_93.Value = reader.ReadInt8
            reader.Position = &H89
            valu_grub_94.Value = reader.ReadInt8
            reader.Position = &H8A
            valu_grub_95.Value = reader.ReadInt8
            reader.Position = &H8B
            valu_grub_96.Value = reader.ReadInt8
            reader.Position = &H8C
            valu_grub_97.Value = reader.ReadInt8
            reader.Position = &H8D
            valu_grub_98.Value = reader.ReadInt8
            reader.Position = &H8E
            valu_grub_99.Value = reader.ReadInt8
            reader.Position = &H8F
            valu_grub_100.Value = reader.ReadInt8
            reader.Position = &H90
            valu_grub_101.Value = reader.ReadInt8
            reader.Position = &H91
            valu_grub_102.Value = reader.ReadInt8
            reader.Position = &H92
            valu_grub_103.Value = reader.ReadInt8
            reader.Position = &H93
            valu_grub_104.Value = reader.ReadInt8
            reader.Position = &H94
            valu_grub_105.Value = reader.ReadInt8
            reader.Position = &H95
            valu_grub_106.Value = reader.ReadInt8
            reader.Position = &H96
            valu_grub_107.Value = reader.ReadInt8
            reader.Position = &H97
            valu_grub_108.Value = reader.ReadInt8
            reader.Position = &H98
            valu_grub_109.Value = reader.ReadInt8
            reader.Position = &H99
            valu_grub_110.Value = reader.ReadInt8
            reader.Position = &H9A
            valu_grub_111.Value = reader.ReadInt8
            reader.Position = &H9B
            valu_grub_112.Value = reader.ReadInt8
            reader.Position = &H9C
            valu_grub_113.Value = reader.ReadInt8
            reader.Position = &H9D
            valu_grub_114.Value = reader.ReadInt8
            reader.Position = &H9E
            valu_grub_115.Value = reader.ReadInt8
            reader.Position = &H9F
            valu_grub_116.Value = reader.ReadInt8
            reader.Position = &HA0
            valu_grub_117.Value = reader.ReadInt8
            reader.Position = &HA1
            valu_grub_118.Value = reader.ReadInt8
            reader.Position = &HA2
            valu_grub_119.Value = reader.ReadInt8
            reader.Position = &HA3
            valu_grub_120.Value = reader.ReadInt8
            reader.Position = &HA4
            valu_grub_121.Value = reader.ReadInt8
            reader.Position = &HA5
            valu_grub_122.Value = reader.ReadInt8
            reader.Position = &HA6
            valu_grub_123.Value = reader.ReadInt8
            reader.Position = &HA7
            valu_grub_124.Value = reader.ReadInt8
            reader.Position = &HA8
            valu_grub_125.Value = reader.ReadInt8
            reader.Position = &HA9
            valu_grub_126.Value = reader.ReadInt8
            reader.Position = &HAA
            valu_grub_127.Value = reader.ReadInt8
            reader.Position = &HAB
            valu_grub_128.Value = reader.ReadInt8
            reader.Position = &HAC
            valu_grub_129.Value = reader.ReadInt8
            reader.Position = &HAD
            valu_grub_130.Value = reader.ReadInt8
            reader.Position = &HAE
            valu_grub_131.Value = reader.ReadInt8
            reader.Position = &HAF
            valu_grub_132.Value = reader.ReadInt8
            reader.Position = &HB0
            valu_grub_133.Value = reader.ReadInt8
            reader.Position = &HB1
            valu_grub_134.Value = reader.ReadInt8
            reader.Position = &HB2
            valu_grub_135.Value = reader.ReadInt8
            reader.Position = &HB3
            valu_grub_136.Value = reader.ReadInt8
            reader.Position = &HB4
            valu_grub_137.Value = reader.ReadInt8
            reader.Position = &HB5
            valu_grub_138.Value = reader.ReadInt8
            reader.Position = &HB6
            valu_grub_139.Value = reader.ReadInt8
            reader.Position = &HB7
            valu_grub_140.Value = reader.ReadInt8
            reader.Position = &HB8
            valu_grub_141.Value = reader.ReadInt8
            reader.Position = &HB9
            valu_grub_142.Value = reader.ReadInt8
            reader.Position = &HBA
            valu_grub_143.Value = reader.ReadInt8
            reader.Position = &HBB
            valu_grub_144.Value = reader.ReadInt8
            reader.Position = &HBC
            valu_grub_145.Value = reader.ReadInt8
            reader.Position = &HBD
            valu_grub_146.Value = reader.ReadInt8
            reader.Position = &HBE
            valu_grub_147.Value = reader.ReadInt8
            reader.Position = &HBF
            valu_grub_148.Value = reader.ReadInt8
            reader.Position = &HC0
            valu_grub_149.Value = reader.ReadInt8
            reader.Position = &HC1
            valu_grub_150.Value = reader.ReadInt8
            reader.Position = &HC2
            valu_grub_151.Value = reader.ReadInt8
            reader.Position = &HC3
            valu_grub_152.Value = reader.ReadInt8
            reader.Position = &HC4
            valu_grub_153.Value = reader.ReadInt8
            reader.Position = &HC5
            valu_grub_154.Value = reader.ReadInt8
            reader.Position = &HC6
            valu_grub_155.Value = reader.ReadInt8
            reader.Position = &HC7
            valu_grub_156.Value = reader.ReadInt8
            reader.Position = &HC8
            valu_grub_157.Value = reader.ReadInt8
            reader.Position = &HC9
            valu_grub_158.Value = reader.ReadInt8
            reader.Position = &HCA
            valu_grub_159.Value = reader.ReadInt8
            reader.Position = &HCB
            valu_grub_160.Value = reader.ReadInt8
            reader.Position = &HCC
            valu_grub_161.Value = reader.ReadInt8
            reader.Position = &HCD
            valu_grub_162.Value = reader.ReadInt8
            reader.Position = &HCE
            valu_grub_163.Value = reader.ReadInt8
            reader.Position = &HCF
            valu_grub_164.Value = reader.ReadInt8
            reader.Position = &HD0
            valu_grub_165.Value = reader.ReadInt8
            reader.Position = &HD1
            valu_grub_166.Value = reader.ReadInt8
            reader.Position = &HD2
            valu_grub_167.Value = reader.ReadInt8
            reader.Position = &HD3
            valu_grub_168.Value = reader.ReadInt8
            reader.Position = &HD4
            valu_grub_169.Value = reader.ReadInt8
            reader.Position = &HD5
            valu_grub_170.Value = reader.ReadInt8
            reader.Position = &HD6
            valu_grub_171.Value = reader.ReadInt8
            reader.Position = &HD7
            valu_grub_172.Value = reader.ReadInt8
            reader.Position = &HD8
            valu_grub_173.Value = reader.ReadInt8
            reader.Position = &HD9
            valu_grub_174.Value = reader.ReadInt8
            reader.Position = &HDA
            valu_grub_175.Value = reader.ReadInt8
            reader.Position = &HDB
            valu_grub_176.Value = reader.ReadInt8
            reader.Position = &HDC
            valu_grub_177.Value = reader.ReadInt8
            reader.Position = &HDD
            valu_grub_178.Value = reader.ReadInt8
            reader.Position = &HDE
            valu_grub_179.Value = reader.ReadInt8
            reader.Position = &HDF
            valu_grub_180.Value = reader.ReadInt8
            reader.Position = &HE0
            valu_grub_181.Value = reader.ReadInt8
            reader.Position = &HE1
            valu_grub_182.Value = reader.ReadInt8
            reader.Position = &HE2
            valu_grub_183.Value = reader.ReadInt8
            reader.Position = &HE3
            valu_grub_184.Value = reader.ReadInt8
            reader.Position = &HE4
            valu_grub_185.Value = reader.ReadInt8
            reader.Position = &HE5
            valu_grub_186.Value = reader.ReadInt8
            reader.Position = &HE6
            valu_grub_187.Value = reader.ReadInt8
            reader.Position = &HE7
            valu_grub_188.Value = reader.ReadInt8
            reader.Position = &HE8
            valu_grub_189.Value = reader.ReadInt8
            reader.Position = &HE9
            valu_grub_190.Value = reader.ReadInt8
            reader.Position = &HEA
            valu_grub_191.Value = reader.ReadInt8
            reader.Position = &HEB
            valu_grub_192.Value = reader.ReadInt8
            reader.Position = &HEC
            valu_grub_193.Value = reader.ReadInt8
            reader.Position = &HED
            valu_grub_194.Value = reader.ReadInt8
            reader.Position = &HEE
            valu_grub_195.Value = reader.ReadInt8
            reader.Position = &HEF
            valu_grub_196.Value = reader.ReadInt8
        Catch ex As Exception
        End Try
    End Sub

    Public Sub savegrub()
        Try
            Dim writer As New PackageIO.Writer(common, PackageIO.Endian.Little)
            writer.Position = &H2C
            writer.WriteInt8(valu_grub_1.Value)
            writer.Position = &H2D
            writer.WriteInt8(valu_grub_2.Value)
            writer.Position = &H2E
            writer.WriteInt8(valu_grub_3.Value)
            writer.Position = &H2F
            writer.WriteInt8(valu_grub_4.Value)
            writer.Position = &H30
            writer.WriteInt8(valu_grub_5.Value)
            writer.Position = &H31
            writer.WriteInt8(valu_grub_6.Value)
            writer.Position = &H32
            writer.WriteInt8(valu_grub_7.Value)
            writer.Position = &H33
            writer.WriteInt8(valu_grub_8.Value)
            writer.Position = &H34
            writer.WriteInt8(valu_grub_9.Value)
            writer.Position = &H35
            writer.WriteInt8(valu_grub_10.Value)
            writer.Position = &H36
            writer.WriteInt8(valu_grub_11.Value)
            writer.Position = &H37
            writer.WriteInt8(valu_grub_12.Value)
            writer.Position = &H38
            writer.WriteInt8(valu_grub_13.Value)
            writer.Position = &H39
            writer.WriteInt8(valu_grub_14.Value)
            writer.Position = &H3A
            writer.WriteInt8(valu_grub_15.Value)
            writer.Position = &H3B
            writer.WriteInt8(valu_grub_16.Value)
            writer.Position = &H3C
            writer.WriteInt8(valu_grub_17.Value)
            writer.Position = &H3D
            writer.WriteInt8(valu_grub_18.Value)
            writer.Position = &H3E
            writer.WriteInt8(valu_grub_19.Value)
            writer.Position = &H3F
            writer.WriteInt8(valu_grub_20.Value)
            writer.Position = &H40
            writer.WriteInt8(valu_grub_21.Value)
            writer.Position = &H41
            writer.WriteInt8(valu_grub_22.Value)
            writer.Position = &H42
            writer.WriteInt8(valu_grub_23.Value)
            writer.Position = &H43
            writer.WriteInt8(valu_grub_24.Value)
            writer.Position = &H44
            writer.WriteInt8(valu_grub_25.Value)
            writer.Position = &H45
            writer.WriteInt8(valu_grub_26.Value)
            writer.Position = &H46
            writer.WriteInt8(valu_grub_27.Value)
            writer.Position = &H47
            writer.WriteInt8(valu_grub_28.Value)
            writer.Position = &H48
            writer.WriteInt8(valu_grub_29.Value)
            writer.Position = &H49
            writer.WriteInt8(valu_grub_30.Value)
            writer.Position = &H4A
            writer.WriteInt8(valu_grub_31.Value)
            writer.Position = &H4B
            writer.WriteInt8(valu_grub_32.Value)
            writer.Position = &H4C
            writer.WriteInt8(valu_grub_33.Value)
            writer.Position = &H4D
            writer.WriteInt8(valu_grub_34.Value)
            writer.Position = &H4E
            writer.WriteInt8(valu_grub_35.Value)
            writer.Position = &H4F
            writer.WriteInt8(valu_grub_36.Value)
            writer.Position = &H50
            writer.WriteInt8(valu_grub_37.Value)
            writer.Position = &H51
            writer.WriteInt8(valu_grub_38.Value)
            writer.Position = &H52
            writer.WriteInt8(valu_grub_39.Value)
            writer.Position = &H53
            writer.WriteInt8(valu_grub_40.Value)
            writer.Position = &H54
            writer.WriteInt8(valu_grub_41.Value)
            writer.Position = &H55
            writer.WriteInt8(valu_grub_42.Value)
            writer.Position = &H56
            writer.WriteInt8(valu_grub_43.Value)
            writer.Position = &H57
            writer.WriteInt8(valu_grub_44.Value)
            writer.Position = &H58
            writer.WriteInt8(valu_grub_45.Value)
            writer.Position = &H59
            writer.WriteInt8(valu_grub_46.Value)
            writer.Position = &H5A
            writer.WriteInt8(valu_grub_47.Value)
            writer.Position = &H5B
            writer.WriteInt8(valu_grub_48.Value)
            writer.Position = &H5C
            writer.WriteInt8(valu_grub_49.Value)
            writer.Position = &H5D
            writer.WriteInt8(valu_grub_50.Value)
            writer.Position = &H5E
            writer.WriteInt8(valu_grub_51.Value)
            writer.Position = &H5F
            writer.WriteInt8(valu_grub_52.Value)
            writer.Position = &H60
            writer.WriteInt8(valu_grub_53.Value)
            writer.Position = &H61
            writer.WriteInt8(valu_grub_54.Value)
            writer.Position = &H62
            writer.WriteInt8(valu_grub_55.Value)
            writer.Position = &H63
            writer.WriteInt8(valu_grub_56.Value)
            writer.Position = &H64
            writer.WriteInt8(valu_grub_57.Value)
            writer.Position = &H65
            writer.WriteInt8(valu_grub_58.Value)
            writer.Position = &H66
            writer.WriteInt8(valu_grub_59.Value)
            writer.Position = &H67
            writer.WriteInt8(valu_grub_60.Value)
            writer.Position = &H68
            writer.WriteInt8(valu_grub_61.Value)
            writer.Position = &H69
            writer.WriteInt8(valu_grub_62.Value)
            writer.Position = &H6A
            writer.WriteInt8(valu_grub_63.Value)
            writer.Position = &H6B
            writer.WriteInt8(valu_grub_64.Value)
            writer.Position = &H6C
            writer.WriteInt8(valu_grub_65.Value)
            writer.Position = &H6D
            writer.WriteInt8(valu_grub_66.Value)
            writer.Position = &H6E
            writer.WriteInt8(valu_grub_67.Value)
            writer.Position = &H6F
            writer.WriteInt8(valu_grub_68.Value)
            writer.Position = &H70
            writer.WriteInt8(valu_grub_69.Value)
            writer.Position = &H71
            writer.WriteInt8(valu_grub_70.Value)
            writer.Position = &H72
            writer.WriteInt8(valu_grub_71.Value)
            writer.Position = &H73
            writer.WriteInt8(valu_grub_72.Value)
            writer.Position = &H74
            writer.WriteInt8(valu_grub_73.Value)
            writer.Position = &H75
            writer.WriteInt8(valu_grub_74.Value)
            writer.Position = &H76
            writer.WriteInt8(valu_grub_75.Value)
            writer.Position = &H77
            writer.WriteInt8(valu_grub_76.Value)
            writer.Position = &H78
            writer.WriteInt8(valu_grub_77.Value)
            writer.Position = &H79
            writer.WriteInt8(valu_grub_78.Value)
            writer.Position = &H7A
            writer.WriteInt8(valu_grub_79.Value)
            writer.Position = &H7B
            writer.WriteInt8(valu_grub_80.Value)
            writer.Position = &H7C
            writer.WriteInt8(valu_grub_81.Value)
            writer.Position = &H7D
            writer.WriteInt8(valu_grub_82.Value)
            writer.Position = &H7E
            writer.WriteInt8(valu_grub_83.Value)
            writer.Position = &H7F
            writer.WriteInt8(valu_grub_84.Value)
            writer.Position = &H80
            writer.WriteInt8(valu_grub_85.Value)
            writer.Position = &H81
            writer.WriteInt8(valu_grub_86.Value)
            writer.Position = &H82
            writer.WriteInt8(valu_grub_87.Value)
            writer.Position = &H83
            writer.WriteInt8(valu_grub_88.Value)
            writer.Position = &H84
            writer.WriteInt8(valu_grub_89.Value)
            writer.Position = &H85
            writer.WriteInt8(valu_grub_90.Value)
            writer.Position = &H86
            writer.WriteInt8(valu_grub_91.Value)
            writer.Position = &H87
            writer.WriteInt8(valu_grub_92.Value)
            writer.Position = &H88
            writer.WriteInt8(valu_grub_93.Value)
            writer.Position = &H89
            writer.WriteInt8(valu_grub_94.Value)
            writer.Position = &H8A
            writer.WriteInt8(valu_grub_95.Value)
            writer.Position = &H8B
            writer.WriteInt8(valu_grub_96.Value)
            writer.Position = &H8C
            writer.WriteInt8(valu_grub_97.Value)
            writer.Position = &H8D
            writer.WriteInt8(valu_grub_98.Value)
            writer.Position = &H8E
            writer.WriteInt8(valu_grub_99.Value)
            writer.Position = &H8F
            writer.WriteInt8(valu_grub_100.Value)
            writer.Position = &H90
            writer.WriteInt8(valu_grub_101.Value)
            writer.Position = &H91
            writer.WriteInt8(valu_grub_102.Value)
            writer.Position = &H92
            writer.WriteInt8(valu_grub_103.Value)
            writer.Position = &H93
            writer.WriteInt8(valu_grub_104.Value)
            writer.Position = &H94
            writer.WriteInt8(valu_grub_105.Value)
            writer.Position = &H95
            writer.WriteInt8(valu_grub_106.Value)
            writer.Position = &H96
            writer.WriteInt8(valu_grub_107.Value)
            writer.Position = &H97
            writer.WriteInt8(valu_grub_108.Value)
            writer.Position = &H98
            writer.WriteInt8(valu_grub_109.Value)
            writer.Position = &H99
            writer.WriteInt8(valu_grub_110.Value)
            writer.Position = &H9A
            writer.WriteInt8(valu_grub_111.Value)
            writer.Position = &H9B
            writer.WriteInt8(valu_grub_112.Value)
            writer.Position = &H9C
            writer.WriteInt8(valu_grub_113.Value)
            writer.Position = &H9D
            writer.WriteInt8(valu_grub_114.Value)
            writer.Position = &H9E
            writer.WriteInt8(valu_grub_115.Value)
            writer.Position = &H9F
            writer.WriteInt8(valu_grub_116.Value)
            writer.Position = &HA0
            writer.WriteInt8(valu_grub_117.Value)
            writer.Position = &HA1
            writer.WriteInt8(valu_grub_118.Value)
            writer.Position = &HA2
            writer.WriteInt8(valu_grub_119.Value)
            writer.Position = &HA3
            writer.WriteInt8(valu_grub_120.Value)
            writer.Position = &HA4
            writer.WriteInt8(valu_grub_121.Value)
            writer.Position = &HA5
            writer.WriteInt8(valu_grub_122.Value)
            writer.Position = &HA6
            writer.WriteInt8(valu_grub_123.Value)
            writer.Position = &HA7
            writer.WriteInt8(valu_grub_124.Value)
            writer.Position = &HA8
            writer.WriteInt8(valu_grub_125.Value)
            writer.Position = &HA9
            writer.WriteInt8(valu_grub_126.Value)
            writer.Position = &HAA
            writer.WriteInt8(valu_grub_127.Value)
            writer.Position = &HAB
            writer.WriteInt8(valu_grub_128.Value)
            writer.Position = &HAC
            writer.WriteInt8(valu_grub_129.Value)
            writer.Position = &HAD
            writer.WriteInt8(valu_grub_130.Value)
            writer.Position = &HAE
            writer.WriteInt8(valu_grub_131.Value)
            writer.Position = &HAF
            writer.WriteInt8(valu_grub_132.Value)
            writer.Position = &HB0
            writer.WriteInt8(valu_grub_133.Value)
            writer.Position = &HB1
            writer.WriteInt8(valu_grub_134.Value)
            writer.Position = &HB2
            writer.WriteInt8(valu_grub_135.Value)
            writer.Position = &HB3
            writer.WriteInt8(valu_grub_136.Value)
            writer.Position = &HB4
            writer.WriteInt8(valu_grub_137.Value)
            writer.Position = &HB5
            writer.WriteInt8(valu_grub_138.Value)
            writer.Position = &HB6
            writer.WriteInt8(valu_grub_139.Value)
            writer.Position = &HB7
            writer.WriteInt8(valu_grub_140.Value)
            writer.Position = &HB8
            writer.WriteInt8(valu_grub_141.Value)
            writer.Position = &HB9
            writer.WriteInt8(valu_grub_142.Value)
            writer.Position = &HBA
            writer.WriteInt8(valu_grub_143.Value)
            writer.Position = &HBB
            writer.WriteInt8(valu_grub_144.Value)
            writer.Position = &HBC
            writer.WriteInt8(valu_grub_145.Value)
            writer.Position = &HBD
            writer.WriteInt8(valu_grub_146.Value)
            writer.Position = &HBE
            writer.WriteInt8(valu_grub_147.Value)
            writer.Position = &HBF
            writer.WriteInt8(valu_grub_148.Value)
            writer.Position = &HC0
            writer.WriteInt8(valu_grub_149.Value)
            writer.Position = &HC1
            writer.WriteInt8(valu_grub_150.Value)
            writer.Position = &HC2
            writer.WriteInt8(valu_grub_151.Value)
            writer.Position = &HC3
            writer.WriteInt8(valu_grub_152.Value)
            writer.Position = &HC4
            writer.WriteInt8(valu_grub_153.Value)
            writer.Position = &HC5
            writer.WriteInt8(valu_grub_154.Value)
            writer.Position = &HC6
            writer.WriteInt8(valu_grub_155.Value)
            writer.Position = &HC7
            writer.WriteInt8(valu_grub_156.Value)
            writer.Position = &HC8
            writer.WriteInt8(valu_grub_157.Value)
            writer.Position = &HC9
            writer.WriteInt8(valu_grub_158.Value)
            writer.Position = &HCA
            writer.WriteInt8(valu_grub_159.Value)
            writer.Position = &HCB
            writer.WriteInt8(valu_grub_160.Value)
            writer.Position = &HCC
            writer.WriteInt8(valu_grub_161.Value)
            writer.Position = &HCD
            writer.WriteInt8(valu_grub_162.Value)
            writer.Position = &HCE
            writer.WriteInt8(valu_grub_163.Value)
            writer.Position = &HCF
            writer.WriteInt8(valu_grub_164.Value)
            writer.Position = &HD0
            writer.WriteInt8(valu_grub_165.Value)
            writer.Position = &HD1
            writer.WriteInt8(valu_grub_166.Value)
            writer.Position = &HD2
            writer.WriteInt8(valu_grub_167.Value)
            writer.Position = &HD3
            writer.WriteInt8(valu_grub_168.Value)
            writer.Position = &HD4
            writer.WriteInt8(valu_grub_169.Value)
            writer.Position = &HD5
            writer.WriteInt8(valu_grub_170.Value)
            writer.Position = &HD6
            writer.WriteInt8(valu_grub_171.Value)
            writer.Position = &HD7
            writer.WriteInt8(valu_grub_172.Value)
            writer.Position = &HD8
            writer.WriteInt8(valu_grub_173.Value)
            writer.Position = &HD9
            writer.WriteInt8(valu_grub_174.Value)
            writer.Position = &HDA
            writer.WriteInt8(valu_grub_175.Value)
            writer.Position = &HDB
            writer.WriteInt8(valu_grub_176.Value)
            writer.Position = &HDC
            writer.WriteInt8(valu_grub_177.Value)
            writer.Position = &HDD
            writer.WriteInt8(valu_grub_178.Value)
            writer.Position = &HDE
            writer.WriteInt8(valu_grub_179.Value)
            writer.Position = &HDF
            writer.WriteInt8(valu_grub_180.Value)
            writer.Position = &HE0
            writer.WriteInt8(valu_grub_181.Value)
            writer.Position = &HE1
            writer.WriteInt8(valu_grub_182.Value)
            writer.Position = &HE2
            writer.WriteInt8(valu_grub_183.Value)
            writer.Position = &HE3
            writer.WriteInt8(valu_grub_184.Value)
            writer.Position = &HE4
            writer.WriteInt8(valu_grub_185.Value)
            writer.Position = &HE5
            writer.WriteInt8(valu_grub_186.Value)
            writer.Position = &HE6
            writer.WriteInt8(valu_grub_187.Value)
            writer.Position = &HE7
            writer.WriteInt8(valu_grub_188.Value)
            writer.Position = &HE8
            writer.WriteInt8(valu_grub_189.Value)
            writer.Position = &HE9
            writer.WriteInt8(valu_grub_190.Value)
            writer.Position = &HEA
            writer.WriteInt8(valu_grub_191.Value)
            writer.Position = &HEB
            writer.WriteInt8(valu_grub_192.Value)
            writer.Position = &HEC
            writer.WriteInt8(valu_grub_193.Value)
            writer.Position = &HED
            writer.WriteInt8(valu_grub_194.Value)
            writer.Position = &HEE
            writer.WriteInt8(valu_grub_195.Value)
            writer.Position = &HEF
            writer.WriteInt8(valu_grub_196.Value)
        Catch ex As Exception
            fdialog.Title.Text = "Miitopia Save Editor : write grubs"
            fdialog.Msg.Text = "An error has occured" & vbNewLine & "load a save file first or report this issue"
            fdialog.ShowDialog()
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
        savegrub()
        Me.Close()
    End Sub

    Private Sub Fds_save_text_MouseLeave(sender As Object, e As EventArgs) Handles Fds_save_text.MouseLeave
        Fds_button_save.BackgroundImage = My.Resources.buttonfoods_orange
    End Sub

    Private Sub Fds_save_text_MouseMove(sender As Object, e As MouseEventArgs) Handles Fds_save_text.MouseMove
        Fds_button_save.BackgroundImage = My.Resources.buttonfoods_blue
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
        common = Miitopia_SE.TextBox_fpath_common.Text
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

    Private Sub Panel_setall_Click(sender As Object, e As EventArgs) Handles Panel_setall.Click, Text_setall.Click
        valu_grub_1.Value = valu_allgrubs.Value
        valu_grub_2.Value = valu_allgrubs.Value
        valu_grub_3.Value = valu_allgrubs.Value
        valu_grub_4.Value = valu_allgrubs.Value
        valu_grub_5.Value = valu_allgrubs.Value
        valu_grub_6.Value = valu_allgrubs.Value
        valu_grub_7.Value = valu_allgrubs.Value
        valu_grub_8.Value = valu_allgrubs.Value
        valu_grub_9.Value = valu_allgrubs.Value
        valu_grub_10.Value = valu_allgrubs.Value
        valu_grub_11.Value = valu_allgrubs.Value
        valu_grub_12.Value = valu_allgrubs.Value
        valu_grub_13.Value = valu_allgrubs.Value
        valu_grub_14.Value = valu_allgrubs.Value
        valu_grub_15.Value = valu_allgrubs.Value
        valu_grub_16.Value = valu_allgrubs.Value
        valu_grub_17.Value = valu_allgrubs.Value
        valu_grub_18.Value = valu_allgrubs.Value
        valu_grub_19.Value = valu_allgrubs.Value
        valu_grub_20.Value = valu_allgrubs.Value
        valu_grub_21.Value = valu_allgrubs.Value
        valu_grub_22.Value = valu_allgrubs.Value
        valu_grub_23.Value = valu_allgrubs.Value
        valu_grub_24.Value = valu_allgrubs.Value
        valu_grub_25.Value = valu_allgrubs.Value
        valu_grub_26.Value = valu_allgrubs.Value
        valu_grub_27.Value = valu_allgrubs.Value
        valu_grub_28.Value = valu_allgrubs.Value
        valu_grub_29.Value = valu_allgrubs.Value
        valu_grub_30.Value = valu_allgrubs.Value
        valu_grub_31.Value = valu_allgrubs.Value
        valu_grub_32.Value = valu_allgrubs.Value
        valu_grub_33.Value = valu_allgrubs.Value
        valu_grub_34.Value = valu_allgrubs.Value
        valu_grub_35.Value = valu_allgrubs.Value
        valu_grub_36.Value = valu_allgrubs.Value
        valu_grub_37.Value = valu_allgrubs.Value
        valu_grub_38.Value = valu_allgrubs.Value
        valu_grub_39.Value = valu_allgrubs.Value
        valu_grub_40.Value = valu_allgrubs.Value
        valu_grub_41.Value = valu_allgrubs.Value
        valu_grub_42.Value = valu_allgrubs.Value
        valu_grub_43.Value = valu_allgrubs.Value
        valu_grub_44.Value = valu_allgrubs.Value
        valu_grub_45.Value = valu_allgrubs.Value
        valu_grub_46.Value = valu_allgrubs.Value
        valu_grub_47.Value = valu_allgrubs.Value
        valu_grub_48.Value = valu_allgrubs.Value
        valu_grub_49.Value = valu_allgrubs.Value
        valu_grub_50.Value = valu_allgrubs.Value
        valu_grub_51.Value = valu_allgrubs.Value
        valu_grub_52.Value = valu_allgrubs.Value
        valu_grub_53.Value = valu_allgrubs.Value
        valu_grub_54.Value = valu_allgrubs.Value
        valu_grub_55.Value = valu_allgrubs.Value
        valu_grub_56.Value = valu_allgrubs.Value
        valu_grub_57.Value = valu_allgrubs.Value
        valu_grub_58.Value = valu_allgrubs.Value
        valu_grub_59.Value = valu_allgrubs.Value
        valu_grub_60.Value = valu_allgrubs.Value
        valu_grub_61.Value = valu_allgrubs.Value
        valu_grub_62.Value = valu_allgrubs.Value
        valu_grub_63.Value = valu_allgrubs.Value
        valu_grub_64.Value = valu_allgrubs.Value
        valu_grub_65.Value = valu_allgrubs.Value
        valu_grub_66.Value = valu_allgrubs.Value
        valu_grub_67.Value = valu_allgrubs.Value
        valu_grub_68.Value = valu_allgrubs.Value
        valu_grub_69.Value = valu_allgrubs.Value
        valu_grub_70.Value = valu_allgrubs.Value
        valu_grub_71.Value = valu_allgrubs.Value
        valu_grub_72.Value = valu_allgrubs.Value
        valu_grub_73.Value = valu_allgrubs.Value
        valu_grub_74.Value = valu_allgrubs.Value
        valu_grub_75.Value = valu_allgrubs.Value
        valu_grub_76.Value = valu_allgrubs.Value
        valu_grub_77.Value = valu_allgrubs.Value
        valu_grub_78.Value = valu_allgrubs.Value
        valu_grub_79.Value = valu_allgrubs.Value
        valu_grub_80.Value = valu_allgrubs.Value
        valu_grub_81.Value = valu_allgrubs.Value
        valu_grub_82.Value = valu_allgrubs.Value
        valu_grub_83.Value = valu_allgrubs.Value
        valu_grub_84.Value = valu_allgrubs.Value
        valu_grub_85.Value = valu_allgrubs.Value
        valu_grub_86.Value = valu_allgrubs.Value
        valu_grub_87.Value = valu_allgrubs.Value
        valu_grub_88.Value = valu_allgrubs.Value
        valu_grub_89.Value = valu_allgrubs.Value
        valu_grub_90.Value = valu_allgrubs.Value
        valu_grub_91.Value = valu_allgrubs.Value
        valu_grub_92.Value = valu_allgrubs.Value
        valu_grub_93.Value = valu_allgrubs.Value
        valu_grub_94.Value = valu_allgrubs.Value
        valu_grub_95.Value = valu_allgrubs.Value
        valu_grub_96.Value = valu_allgrubs.Value
        valu_grub_97.Value = valu_allgrubs.Value
        valu_grub_98.Value = valu_allgrubs.Value
        valu_grub_99.Value = valu_allgrubs.Value
        valu_grub_100.Value = valu_allgrubs.Value
        valu_grub_101.Value = valu_allgrubs.Value
        valu_grub_102.Value = valu_allgrubs.Value
        valu_grub_103.Value = valu_allgrubs.Value
        valu_grub_104.Value = valu_allgrubs.Value
        valu_grub_105.Value = valu_allgrubs.Value
        valu_grub_106.Value = valu_allgrubs.Value
        valu_grub_107.Value = valu_allgrubs.Value
        valu_grub_108.Value = valu_allgrubs.Value
        valu_grub_109.Value = valu_allgrubs.Value
        valu_grub_110.Value = valu_allgrubs.Value
        valu_grub_111.Value = valu_allgrubs.Value
        valu_grub_112.Value = valu_allgrubs.Value
        valu_grub_113.Value = valu_allgrubs.Value
        valu_grub_114.Value = valu_allgrubs.Value
        valu_grub_115.Value = valu_allgrubs.Value
        valu_grub_116.Value = valu_allgrubs.Value
        valu_grub_117.Value = valu_allgrubs.Value
        valu_grub_118.Value = valu_allgrubs.Value
        valu_grub_119.Value = valu_allgrubs.Value
        valu_grub_120.Value = valu_allgrubs.Value
        valu_grub_121.Value = valu_allgrubs.Value
        valu_grub_122.Value = valu_allgrubs.Value
        valu_grub_123.Value = valu_allgrubs.Value
        valu_grub_124.Value = valu_allgrubs.Value
        valu_grub_125.Value = valu_allgrubs.Value
        valu_grub_126.Value = valu_allgrubs.Value
        valu_grub_127.Value = valu_allgrubs.Value
        valu_grub_128.Value = valu_allgrubs.Value
        valu_grub_129.Value = valu_allgrubs.Value
        valu_grub_130.Value = valu_allgrubs.Value
        valu_grub_131.Value = valu_allgrubs.Value
        valu_grub_132.Value = valu_allgrubs.Value
        valu_grub_133.Value = valu_allgrubs.Value
        valu_grub_134.Value = valu_allgrubs.Value
        valu_grub_135.Value = valu_allgrubs.Value
        valu_grub_136.Value = valu_allgrubs.Value
        valu_grub_137.Value = valu_allgrubs.Value
        valu_grub_138.Value = valu_allgrubs.Value
        valu_grub_139.Value = valu_allgrubs.Value
        valu_grub_140.Value = valu_allgrubs.Value
        valu_grub_141.Value = valu_allgrubs.Value
        valu_grub_142.Value = valu_allgrubs.Value
        valu_grub_143.Value = valu_allgrubs.Value
        valu_grub_144.Value = valu_allgrubs.Value
        valu_grub_145.Value = valu_allgrubs.Value
        valu_grub_146.Value = valu_allgrubs.Value
        valu_grub_147.Value = valu_allgrubs.Value
        valu_grub_148.Value = valu_allgrubs.Value
        valu_grub_149.Value = valu_allgrubs.Value
        valu_grub_150.Value = valu_allgrubs.Value
        valu_grub_151.Value = valu_allgrubs.Value
        valu_grub_152.Value = valu_allgrubs.Value
        valu_grub_153.Value = valu_allgrubs.Value
        valu_grub_154.Value = valu_allgrubs.Value
        valu_grub_155.Value = valu_allgrubs.Value
        valu_grub_156.Value = valu_allgrubs.Value
        valu_grub_157.Value = valu_allgrubs.Value
        valu_grub_158.Value = valu_allgrubs.Value
        valu_grub_159.Value = valu_allgrubs.Value
        valu_grub_160.Value = valu_allgrubs.Value
        valu_grub_161.Value = valu_allgrubs.Value
        valu_grub_162.Value = valu_allgrubs.Value
        valu_grub_163.Value = valu_allgrubs.Value
        valu_grub_164.Value = valu_allgrubs.Value
        valu_grub_165.Value = valu_allgrubs.Value
        valu_grub_166.Value = valu_allgrubs.Value
        valu_grub_167.Value = valu_allgrubs.Value
        valu_grub_168.Value = valu_allgrubs.Value
        valu_grub_169.Value = valu_allgrubs.Value
        valu_grub_170.Value = valu_allgrubs.Value
        valu_grub_171.Value = valu_allgrubs.Value
        valu_grub_172.Value = valu_allgrubs.Value
        valu_grub_173.Value = valu_allgrubs.Value
        valu_grub_174.Value = valu_allgrubs.Value
        valu_grub_175.Value = valu_allgrubs.Value
        valu_grub_176.Value = valu_allgrubs.Value
        valu_grub_177.Value = valu_allgrubs.Value
        valu_grub_178.Value = valu_allgrubs.Value
        valu_grub_179.Value = valu_allgrubs.Value
        valu_grub_180.Value = valu_allgrubs.Value
        valu_grub_181.Value = valu_allgrubs.Value
        valu_grub_182.Value = valu_allgrubs.Value
        valu_grub_183.Value = valu_allgrubs.Value
        valu_grub_184.Value = valu_allgrubs.Value
        valu_grub_185.Value = valu_allgrubs.Value
        valu_grub_186.Value = valu_allgrubs.Value
        valu_grub_187.Value = valu_allgrubs.Value
        valu_grub_188.Value = valu_allgrubs.Value
        valu_grub_189.Value = valu_allgrubs.Value
        valu_grub_190.Value = valu_allgrubs.Value
        valu_grub_191.Value = valu_allgrubs.Value
        valu_grub_192.Value = valu_allgrubs.Value
        valu_grub_193.Value = valu_allgrubs.Value
        valu_grub_194.Value = valu_allgrubs.Value
        valu_grub_195.Value = valu_allgrubs.Value
        valu_grub_196.Value = valu_allgrubs.Value
    End Sub
End Class