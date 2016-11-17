<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashCacao
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Btn_correction = New System.Windows.Forms.Button()
        Me.txtPoidsEnAttente = New System.Windows.Forms.TextBox()
        Me.btnImporter = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgdListePoidsRecuperes = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSupprimerItemAttenteValidation = New System.Windows.Forms.Button()
        Me.txtNbPeseesCompletes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgdListeAttenteValidation = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSupprimerItemValide = New System.Windows.Forms.Button()
        Me.txtNbPeseesValidees = New System.Windows.Forms.TextBox()
        Me.dgdListeValidees = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSupprimerItemAttenteP2 = New System.Windows.Forms.Button()
        Me.txtNbPeseesImcompletes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgdListeAttenteP2 = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnRaffraichir = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgdListePoidsRecuperes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgdListeAttenteValidation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgdListeValidees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgdListeAttenteP2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.56615!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.07393!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.40467!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 37)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.51335!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.48665!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1028, 487)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Btn_correction)
        Me.Panel4.Controls.Add(Me.txtPoidsEnAttente)
        Me.Panel4.Controls.Add(Me.btnImporter)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.dgdListePoidsRecuperes)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(142, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(333, 240)
        Me.Panel4.TabIndex = 8
        '
        'Btn_correction
        '
        Me.Btn_correction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_correction.Image = Global.SAIGIC.My.Resources.Resources.btModifier32
        Me.Btn_correction.Location = New System.Drawing.Point(343, 6)
        Me.Btn_correction.Name = "Btn_correction"
        Me.Btn_correction.Size = New System.Drawing.Size(87, 33)
        Me.Btn_correction.TabIndex = 20
        Me.Btn_correction.Text = "Exporter"
        Me.Btn_correction.UseVisualStyleBackColor = True
        '
        'txtPoidsEnAttente
        '
        Me.txtPoidsEnAttente.Location = New System.Drawing.Point(190, 11)
        Me.txtPoidsEnAttente.Name = "txtPoidsEnAttente"
        Me.txtPoidsEnAttente.ReadOnly = True
        Me.txtPoidsEnAttente.Size = New System.Drawing.Size(52, 20)
        Me.txtPoidsEnAttente.TabIndex = 18
        Me.txtPoidsEnAttente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnImporter
        '
        Me.btnImporter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImporter.Image = Global.SAIGIC.My.Resources.Resources.btInfo32
        Me.btnImporter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImporter.Location = New System.Drawing.Point(245, 5)
        Me.btnImporter.Name = "btnImporter"
        Me.btnImporter.Size = New System.Drawing.Size(95, 33)
        Me.btnImporter.TabIndex = 17
        Me.btnImporter.Text = "Importer"
        Me.btnImporter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImporter.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Poids recuperes"
        '
        'dgdListePoidsRecuperes
        '
        Me.dgdListePoidsRecuperes.AllowUserToAddRows = False
        Me.dgdListePoidsRecuperes.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgdListePoidsRecuperes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgdListePoidsRecuperes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdListePoidsRecuperes.BackgroundColor = System.Drawing.Color.White
        Me.dgdListePoidsRecuperes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdListePoidsRecuperes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgdListePoidsRecuperes.ColumnHeadersHeight = 40
        Me.dgdListePoidsRecuperes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdListePoidsRecuperes.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgdListePoidsRecuperes.Location = New System.Drawing.Point(3, 41)
        Me.dgdListePoidsRecuperes.MultiSelect = False
        Me.dgdListePoidsRecuperes.Name = "dgdListePoidsRecuperes"
        Me.dgdListePoidsRecuperes.ReadOnly = True
        Me.dgdListePoidsRecuperes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgdListePoidsRecuperes.Size = New System.Drawing.Size(325, 193)
        Me.dgdListePoidsRecuperes.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.SAIGIC.My.Resources.Resources.Jaune_Fond
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSupprimerItemAttenteValidation)
        Me.Panel1.Controls.Add(Me.txtNbPeseesCompletes)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgdListeAttenteValidation)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(481, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 240)
        Me.Panel1.TabIndex = 0
        '
        'btnSupprimerItemAttenteValidation
        '
        Me.btnSupprimerItemAttenteValidation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimerItemAttenteValidation.Image = Global.SAIGIC.My.Resources.Resources.btSupprimer32
        Me.btnSupprimerItemAttenteValidation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSupprimerItemAttenteValidation.Location = New System.Drawing.Point(303, 4)
        Me.btnSupprimerItemAttenteValidation.Name = "btnSupprimerItemAttenteValidation"
        Me.btnSupprimerItemAttenteValidation.Size = New System.Drawing.Size(98, 33)
        Me.btnSupprimerItemAttenteValidation.TabIndex = 19
        Me.btnSupprimerItemAttenteValidation.Text = "Supprimer"
        Me.btnSupprimerItemAttenteValidation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSupprimerItemAttenteValidation.UseVisualStyleBackColor = True
        '
        'txtNbPeseesCompletes
        '
        Me.txtNbPeseesCompletes.Location = New System.Drawing.Point(213, 11)
        Me.txtNbPeseesCompletes.Name = "txtNbPeseesCompletes"
        Me.txtNbPeseesCompletes.ReadOnly = True
        Me.txtNbPeseesCompletes.Size = New System.Drawing.Size(75, 20)
        Me.txtNbPeseesCompletes.TabIndex = 16
        Me.txtNbPeseesCompletes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Pesees completes"
        '
        'dgdListeAttenteValidation
        '
        Me.dgdListeAttenteValidation.AllowUserToAddRows = False
        Me.dgdListeAttenteValidation.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgdListeAttenteValidation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgdListeAttenteValidation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdListeAttenteValidation.BackgroundColor = System.Drawing.Color.White
        Me.dgdListeAttenteValidation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdListeAttenteValidation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgdListeAttenteValidation.ColumnHeadersHeight = 40
        Me.dgdListeAttenteValidation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdListeAttenteValidation.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgdListeAttenteValidation.Location = New System.Drawing.Point(4, 41)
        Me.dgdListeAttenteValidation.MultiSelect = False
        Me.dgdListeAttenteValidation.Name = "dgdListeAttenteValidation"
        Me.dgdListeAttenteValidation.ReadOnly = True
        Me.dgdListeAttenteValidation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgdListeAttenteValidation.Size = New System.Drawing.Size(534, 193)
        Me.dgdListeAttenteValidation.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.BackgroundImage = Global.SAIGIC.My.Resources.Resources.Jaune_Fond
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnSupprimerItemValide)
        Me.Panel3.Controls.Add(Me.txtNbPeseesValidees)
        Me.Panel3.Controls.Add(Me.dgdListeValidees)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(481, 249)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(544, 235)
        Me.Panel3.TabIndex = 5
        '
        'btnSupprimerItemValide
        '
        Me.btnSupprimerItemValide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimerItemValide.Image = Global.SAIGIC.My.Resources.Resources.btSupprimer32
        Me.btnSupprimerItemValide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSupprimerItemValide.Location = New System.Drawing.Point(303, 3)
        Me.btnSupprimerItemValide.Name = "btnSupprimerItemValide"
        Me.btnSupprimerItemValide.Size = New System.Drawing.Size(98, 33)
        Me.btnSupprimerItemValide.TabIndex = 20
        Me.btnSupprimerItemValide.Text = "Supprimer"
        Me.btnSupprimerItemValide.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSupprimerItemValide.UseVisualStyleBackColor = True
        '
        'txtNbPeseesValidees
        '
        Me.txtNbPeseesValidees.Location = New System.Drawing.Point(112, 14)
        Me.txtNbPeseesValidees.Name = "txtNbPeseesValidees"
        Me.txtNbPeseesValidees.ReadOnly = True
        Me.txtNbPeseesValidees.Size = New System.Drawing.Size(75, 20)
        Me.txtNbPeseesValidees.TabIndex = 18
        Me.txtNbPeseesValidees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgdListeValidees
        '
        Me.dgdListeValidees.AllowUserToAddRows = False
        Me.dgdListeValidees.AllowUserToOrderColumns = True
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgdListeValidees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgdListeValidees.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdListeValidees.BackgroundColor = System.Drawing.Color.White
        Me.dgdListeValidees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdListeValidees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgdListeValidees.ColumnHeadersHeight = 40
        Me.dgdListeValidees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdListeValidees.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgdListeValidees.Location = New System.Drawing.Point(3, 41)
        Me.dgdListeValidees.MultiSelect = False
        Me.dgdListeValidees.Name = "dgdListeValidees"
        Me.dgdListeValidees.ReadOnly = True
        Me.dgdListeValidees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgdListeValidees.Size = New System.Drawing.Size(534, 188)
        Me.dgdListeValidees.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Validées"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSupprimerItemAttenteP2)
        Me.Panel2.Controls.Add(Me.txtNbPeseesImcompletes)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dgdListeAttenteP2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(142, 249)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(333, 235)
        Me.Panel2.TabIndex = 4
        '
        'btnSupprimerItemAttenteP2
        '
        Me.btnSupprimerItemAttenteP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimerItemAttenteP2.Image = Global.SAIGIC.My.Resources.Resources.btSupprimer32
        Me.btnSupprimerItemAttenteP2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSupprimerItemAttenteP2.Location = New System.Drawing.Point(353, 3)
        Me.btnSupprimerItemAttenteP2.Name = "btnSupprimerItemAttenteP2"
        Me.btnSupprimerItemAttenteP2.Size = New System.Drawing.Size(98, 33)
        Me.btnSupprimerItemAttenteP2.TabIndex = 18
        Me.btnSupprimerItemAttenteP2.Text = "Supprimer"
        Me.btnSupprimerItemAttenteP2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSupprimerItemAttenteP2.UseVisualStyleBackColor = True
        '
        'txtNbPeseesImcompletes
        '
        Me.txtNbPeseesImcompletes.Location = New System.Drawing.Point(295, 14)
        Me.txtNbPeseesImcompletes.Name = "txtNbPeseesImcompletes"
        Me.txtNbPeseesImcompletes.ReadOnly = True
        Me.txtNbPeseesImcompletes.Size = New System.Drawing.Size(51, 20)
        Me.txtNbPeseesImcompletes.TabIndex = 17
        Me.txtNbPeseesImcompletes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(8, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "En attente de 2ème pesée"
        '
        'dgdListeAttenteP2
        '
        Me.dgdListeAttenteP2.AllowUserToAddRows = False
        Me.dgdListeAttenteP2.AllowUserToOrderColumns = True
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgdListeAttenteP2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgdListeAttenteP2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdListeAttenteP2.BackgroundColor = System.Drawing.Color.White
        Me.dgdListeAttenteP2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdListeAttenteP2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgdListeAttenteP2.ColumnHeadersHeight = 40
        Me.dgdListeAttenteP2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdListeAttenteP2.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgdListeAttenteP2.Location = New System.Drawing.Point(3, 42)
        Me.dgdListeAttenteP2.MultiSelect = False
        Me.dgdListeAttenteP2.Name = "dgdListeAttenteP2"
        Me.dgdListeAttenteP2.ReadOnly = True
        Me.dgdListeAttenteP2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgdListeAttenteP2.Size = New System.Drawing.Size(323, 187)
        Me.dgdListeAttenteP2.TabIndex = 13
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel5, 2)
        Me.Panel5.Size = New System.Drawing.Size(133, 481)
        Me.Panel5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(-1, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 55)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CACAO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.SAIGIC.My.Resources.Resources.RTEmagicC_chocolat_031_jpg
        Me.PictureBox1.Location = New System.Drawing.Point(2, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 396)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip
        '
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRaffraichir})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1028, 39)
        Me.ToolStrip.Stretch = True
        Me.ToolStrip.TabIndex = 32
        '
        'btnRaffraichir
        '
        Me.btnRaffraichir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaffraichir.Image = Global.SAIGIC.My.Resources.Resources.i
        Me.btnRaffraichir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRaffraichir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRaffraichir.Name = "btnRaffraichir"
        Me.btnRaffraichir.Size = New System.Drawing.Size(108, 36)
        Me.btnRaffraichir.Text = "Raffraichir"
        Me.btnRaffraichir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmDashCacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmDashCacao"
        Me.Text = "Pesées cacao"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgdListePoidsRecuperes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgdListeAttenteValidation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgdListeValidees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgdListeAttenteP2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgdListeAttenteP2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgdListeAttenteValidation As System.Windows.Forms.DataGridView
    Friend WithEvents dgdListeValidees As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents btnRaffraichir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgdListePoidsRecuperes As System.Windows.Forms.DataGridView
    Friend WithEvents btnImporter As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtNbPeseesCompletes As System.Windows.Forms.TextBox
    Friend WithEvents txtNbPeseesValidees As System.Windows.Forms.TextBox
    Friend WithEvents txtPoidsEnAttente As System.Windows.Forms.TextBox
    Friend WithEvents txtNbPeseesImcompletes As System.Windows.Forms.TextBox
    Friend WithEvents btnSupprimerItemAttenteValidation As System.Windows.Forms.Button
    Friend WithEvents btnSupprimerItemValide As System.Windows.Forms.Button
    Friend WithEvents btnSupprimerItemAttenteP2 As System.Windows.Forms.Button
    Friend WithEvents Btn_correction As System.Windows.Forms.Button

End Class
