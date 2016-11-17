<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLotsFabriquesCacao
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.cboNomFournisseur = New System.Windows.Forms.ComboBox()
        Me.cboCodeFournisseur = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboGrade = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtNumeroLigne = New System.Windows.Forms.TextBox()
        Me.txtMarque = New System.Windows.Forms.TextBox()
        Me.cboProduit = New System.Windows.Forms.ComboBox()
        Me.txtPoidsTheorique = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumeroLot = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtNombreSacs = New System.Windows.Forms.TextBox()
        Me.txtTypePont = New System.Windows.Forms.TextBox()
        Me.txtNomSite = New System.Windows.Forms.TextBox()
        Me.txtCampagne = New System.Windows.Forms.TextBox()
        Me.txtCodePont = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCodeSite = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCodeFabrication = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnFerner = New System.Windows.Forms.Button()
        Me.BtnEnregistrer = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mskAnneeRecolte = New System.Windows.Forms.MaskedTextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.mskDateFabrication = New System.Windows.Forms.MaskedTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.SAIGIC.My.Resources.Resources.Jaune_Fond
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label58)
        Me.Panel1.Controls.Add(Me.cboNomFournisseur)
        Me.Panel1.Controls.Add(Me.cboCodeFournisseur)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 59)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 113)
        Me.Panel1.TabIndex = 1
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Location = New System.Drawing.Point(10, 63)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(114, 16)
        Me.Label58.TabIndex = 32
        Me.Label58.Text = "Libelle exportateur"
        '
        'cboNomFournisseur
        '
        Me.cboNomFournisseur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboNomFournisseur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNomFournisseur.FormattingEnabled = True
        Me.cboNomFournisseur.Location = New System.Drawing.Point(128, 59)
        Me.cboNomFournisseur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboNomFournisseur.Name = "cboNomFournisseur"
        Me.cboNomFournisseur.Size = New System.Drawing.Size(379, 24)
        Me.cboNomFournisseur.TabIndex = 1
        '
        'cboCodeFournisseur
        '
        Me.cboCodeFournisseur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboCodeFournisseur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCodeFournisseur.FormattingEnabled = True
        Me.cboCodeFournisseur.Location = New System.Drawing.Point(128, 30)
        Me.cboCodeFournisseur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboCodeFournisseur.Name = "cboCodeFournisseur"
        Me.cboCodeFournisseur.Size = New System.Drawing.Size(106, 24)
        Me.cboCodeFournisseur.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(10, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FABRIQUANT"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(3, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(375, 13)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "LOTS FABRIQUES - CACAO"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cboGrade)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label61)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.txtNumeroLigne)
        Me.Panel3.Controls.Add(Me.txtMarque)
        Me.Panel3.Controls.Add(Me.cboProduit)
        Me.Panel3.Controls.Add(Me.txtPoidsTheorique)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtNumeroLot)
        Me.Panel3.Controls.Add(Me.Label62)
        Me.Panel3.Controls.Add(Me.Label34)
        Me.Panel3.Controls.Add(Me.txtNombreSacs)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 177)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(842, 306)
        Me.Panel3.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(332, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "X 65Kg"
        '
        'cboGrade
        '
        Me.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrade.FormattingEnabled = True
        Me.cboGrade.Items.AddRange(New Object() {"SG", "G2", "G1"})
        Me.cboGrade.Location = New System.Drawing.Point(186, 200)
        Me.cboGrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.Size = New System.Drawing.Size(140, 24)
        Me.cboGrade.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(56, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Nombre de sacs"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(56, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(56, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Numero de ligne"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.Location = New System.Drawing.Point(56, 127)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(51, 16)
        Me.Label61.TabIndex = 73
        Me.Label61.Text = "Marque"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(56, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 16)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "Produit"
        '
        'txtNumeroLigne
        '
        Me.txtNumeroLigne.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroLigne.Location = New System.Drawing.Point(188, 49)
        Me.txtNumeroLigne.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumeroLigne.Name = "txtNumeroLigne"
        Me.txtNumeroLigne.Size = New System.Drawing.Size(103, 23)
        Me.txtNumeroLigne.TabIndex = 0
        '
        'txtMarque
        '
        Me.txtMarque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarque.Location = New System.Drawing.Point(186, 124)
        Me.txtMarque.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMarque.Name = "txtMarque"
        Me.txtMarque.Size = New System.Drawing.Size(140, 23)
        Me.txtMarque.TabIndex = 2
        '
        'cboProduit
        '
        Me.cboProduit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboProduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProduit.FormattingEnabled = True
        Me.cboProduit.Location = New System.Drawing.Point(188, 85)
        Me.cboProduit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboProduit.Name = "cboProduit"
        Me.cboProduit.Size = New System.Drawing.Size(288, 24)
        Me.cboProduit.TabIndex = 1
        '
        'txtPoidsTheorique
        '
        Me.txtPoidsTheorique.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPoidsTheorique.Location = New System.Drawing.Point(186, 276)
        Me.txtPoidsTheorique.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPoidsTheorique.Name = "txtPoidsTheorique"
        Me.txtPoidsTheorique.ReadOnly = True
        Me.txtPoidsTheorique.Size = New System.Drawing.Size(140, 23)
        Me.txtPoidsTheorique.TabIndex = 6
        Me.txtPoidsTheorique.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(56, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Poids theorique"
        '
        'txtNumeroLot
        '
        Me.txtNumeroLot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroLot.Location = New System.Drawing.Point(186, 163)
        Me.txtNumeroLot.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumeroLot.Name = "txtNumeroLot"
        Me.txtNumeroLot.Size = New System.Drawing.Size(140, 23)
        Me.txtNumeroLot.TabIndex = 3
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Location = New System.Drawing.Point(56, 169)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(89, 16)
        Me.Label62.TabIndex = 75
        Me.Label62.Text = "Numero de lot"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(3, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(100, 23)
        Me.Label34.TabIndex = 22
        Me.Label34.Text = "PRODUIT"
        '
        'txtNombreSacs
        '
        Me.txtNombreSacs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreSacs.Location = New System.Drawing.Point(186, 236)
        Me.txtNombreSacs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreSacs.Name = "txtNombreSacs"
        Me.txtNombreSacs.Size = New System.Drawing.Size(140, 23)
        Me.txtNombreSacs.TabIndex = 5
        Me.txtNombreSacs.Text = "385"
        Me.txtNombreSacs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTypePont
        '
        Me.txtTypePont.Location = New System.Drawing.Point(630, 45)
        Me.txtTypePont.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTypePont.Name = "txtTypePont"
        Me.txtTypePont.ReadOnly = True
        Me.txtTypePont.Size = New System.Drawing.Size(204, 26)
        Me.txtTypePont.TabIndex = 6
        Me.txtTypePont.TabStop = False
        '
        'txtNomSite
        '
        Me.txtNomSite.Location = New System.Drawing.Point(628, 11)
        Me.txtNomSite.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNomSite.Name = "txtNomSite"
        Me.txtNomSite.ReadOnly = True
        Me.txtNomSite.Size = New System.Drawing.Size(204, 26)
        Me.txtNomSite.TabIndex = 4
        Me.txtNomSite.TabStop = False
        '
        'txtCampagne
        '
        Me.txtCampagne.Location = New System.Drawing.Point(628, 82)
        Me.txtCampagne.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCampagne.Name = "txtCampagne"
        Me.txtCampagne.ReadOnly = True
        Me.txtCampagne.Size = New System.Drawing.Size(150, 26)
        Me.txtCampagne.TabIndex = 7
        Me.txtCampagne.TabStop = False
        Me.txtCampagne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodePont
        '
        Me.txtCodePont.Location = New System.Drawing.Point(540, 45)
        Me.txtCodePont.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodePont.Name = "txtCodePont"
        Me.txtCodePont.ReadOnly = True
        Me.txtCodePont.Size = New System.Drawing.Size(84, 26)
        Me.txtCodePont.TabIndex = 5
        Me.txtCodePont.TabStop = False
        Me.txtCodePont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(460, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 18)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Pont"
        '
        'txtCodeSite
        '
        Me.txtCodeSite.Location = New System.Drawing.Point(540, 12)
        Me.txtCodeSite.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodeSite.Name = "txtCodeSite"
        Me.txtCodeSite.ReadOnly = True
        Me.txtCodeSite.Size = New System.Drawing.Size(84, 26)
        Me.txtCodeSite.TabIndex = 3
        Me.txtCodeSite.TabStop = False
        Me.txtCodeSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(460, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 18)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Site"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 18)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "# Fabrication"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCodeFabrication
        '
        Me.TxtCodeFabrication.Location = New System.Drawing.Point(187, 86)
        Me.TxtCodeFabrication.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCodeFabrication.Name = "TxtCodeFabrication"
        Me.TxtCodeFabrication.ReadOnly = True
        Me.TxtCodeFabrication.Size = New System.Drawing.Size(232, 26)
        Me.TxtCodeFabrication.TabIndex = 2
        Me.TxtCodeFabrication.TabStop = False
        Me.TxtCodeFabrication.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(460, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 18)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Campagne"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BtnFerner
        '
        Me.BtnFerner.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFerner.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFerner.Image = Global.SAIGIC.My.Resources.Resources.btSupprimer32
        Me.BtnFerner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFerner.Location = New System.Drawing.Point(595, 27)
        Me.BtnFerner.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFerner.Name = "BtnFerner"
        Me.BtnFerner.Size = New System.Drawing.Size(125, 37)
        Me.BtnFerner.TabIndex = 1
        Me.BtnFerner.Text = "Fermer"
        Me.BtnFerner.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFerner.UseVisualStyleBackColor = True
        '
        'BtnEnregistrer
        '
        Me.BtnEnregistrer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEnregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnregistrer.Image = Global.SAIGIC.My.Resources.Resources.btAjouter32
        Me.BtnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEnregistrer.Location = New System.Drawing.Point(85, 27)
        Me.BtnEnregistrer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEnregistrer.Name = "BtnEnregistrer"
        Me.BtnEnregistrer.Size = New System.Drawing.Size(145, 37)
        Me.BtnEnregistrer.TabIndex = 0
        Me.BtnEnregistrer.Text = "Enregistrer"
        Me.BtnEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEnregistrer.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.LightCyan
        Me.Panel9.BackgroundImage = Global.SAIGIC.My.Resources.Resources.Bg02_Halo
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.BtnEnregistrer)
        Me.Panel9.Controls.Add(Me.BtnFerner)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(3, 488)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(842, 92)
        Me.Panel9.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(22, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 18)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Annee de recolte"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mskAnneeRecolte
        '
        Me.mskAnneeRecolte.Location = New System.Drawing.Point(185, 44)
        Me.mskAnneeRecolte.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mskAnneeRecolte.Mask = "0000/0000"
        Me.mskAnneeRecolte.Name = "mskAnneeRecolte"
        Me.mskAnneeRecolte.Size = New System.Drawing.Size(140, 26)
        Me.mskAnneeRecolte.TabIndex = 1
        Me.mskAnneeRecolte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(20, 10)
        Me.Label54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(151, 18)
        Me.Label54.TabIndex = 57
        Me.Label54.Text = "Date de fabrication"
        '
        'mskDateFabrication
        '
        Me.mskDateFabrication.Location = New System.Drawing.Point(185, 7)
        Me.mskDateFabrication.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mskDateFabrication.Mask = "00/00/0000"
        Me.mskDateFabrication.Name = "mskDateFabrication"
        Me.mskDateFabrication.Size = New System.Drawing.Size(140, 26)
        Me.mskDateFabrication.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.mskDateFabrication)
        Me.Panel2.Controls.Add(Me.Label54)
        Me.Panel2.Controls.Add(Me.mskAnneeRecolte)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtTypePont)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TxtCodeFabrication)
        Me.Panel2.Controls.Add(Me.txtCampagne)
        Me.Panel2.Controls.Add(Me.txtCodeSite)
        Me.Panel2.Controls.Add(Me.txtNomSite)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtCodePont)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(3, 15)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(842, 40)
        Me.Panel2.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label29, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel9, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.10256!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.89744!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 312.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(848, 582)
        Me.TableLayoutPanel1.TabIndex = 78
        '
        'FrmLotsFabriquesCacao
        '
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 582)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmLotsFabriquesCacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lots fabriques Cacao"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboNomFournisseur As System.Windows.Forms.ComboBox
    Friend WithEvents cboCodeFournisseur As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodePont As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCodeSite As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtCodeFabrication As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCampagne As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtNomSite As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtTypePont As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtNumeroLot As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtMarque As System.Windows.Forms.TextBox
    Friend WithEvents cboProduit As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtNombreSacs As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cboGrade As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroLigne As System.Windows.Forms.TextBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents BtnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents BtnFerner As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents mskDateFabrication As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents mskAnneeRecolte As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPoidsTheorique As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
