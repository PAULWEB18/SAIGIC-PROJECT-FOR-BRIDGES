<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLotsFabriquesCacaoListe
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAfficher = New System.Windows.Forms.Button()
        Me.mskDateFabrication = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvListeFabrication = New System.Windows.Forms.DataGridView()
        Me.CodeFabrication = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDLigneFabrication = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Produit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProduitMarque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroLot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NbSacs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoidsTheorique = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btAjouter = New System.Windows.Forms.ToolStripButton()
        Me.btModifier = New System.Windows.Forms.ToolStripButton()
        Me.btSupprimer = New System.Windows.Forms.ToolStripButton()
        Me.btFiltre = New System.Windows.Forms.ToolStripButton()
        Me.btFermer = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListeFabrication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 51)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(861, 409)
        Me.SplitContainer1.SplitterDistance = 64
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAfficher)
        Me.GroupBox1.Controls.Add(Me.mskDateFabrication)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(861, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtre"
        '
        'btnAfficher
        '
        Me.btnAfficher.Location = New System.Drawing.Point(363, 23)
        Me.btnAfficher.Name = "btnAfficher"
        Me.btnAfficher.Size = New System.Drawing.Size(75, 23)
        Me.btnAfficher.TabIndex = 59
        Me.btnAfficher.Text = "Afficher"
        Me.btnAfficher.UseVisualStyleBackColor = True
        '
        'mskDateFabrication
        '
        Me.mskDateFabrication.Location = New System.Drawing.Point(137, 23)
        Me.mskDateFabrication.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mskDateFabrication.Mask = "00/00/0000"
        Me.mskDateFabrication.Name = "mskDateFabrication"
        Me.mskDateFabrication.Size = New System.Drawing.Size(140, 20)
        Me.mskDateFabrication.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Date de fabrication"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvListeFabrication)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(861, 341)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'dgvListeFabrication
        '
        Me.dgvListeFabrication.AllowUserToAddRows = False
        Me.dgvListeFabrication.AllowUserToDeleteRows = False
        Me.dgvListeFabrication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListeFabrication.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeFabrication, Me.IDLigneFabrication, Me.Produit, Me.ProduitMarque, Me.Grade, Me.NumeroLot, Me.NbSacs, Me.PoidsTheorique})
        Me.dgvListeFabrication.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListeFabrication.Location = New System.Drawing.Point(3, 16)
        Me.dgvListeFabrication.Name = "dgvListeFabrication"
        Me.dgvListeFabrication.ReadOnly = True
        Me.dgvListeFabrication.Size = New System.Drawing.Size(855, 322)
        Me.dgvListeFabrication.TabIndex = 79
        '
        'CodeFabrication
        '
        Me.CodeFabrication.DataPropertyName = "CodeFabrication"
        Me.CodeFabrication.HeaderText = "Code Fabrication"
        Me.CodeFabrication.Name = "CodeFabrication"
        Me.CodeFabrication.ReadOnly = True
        '
        'IDLigneFabrication
        '
        Me.IDLigneFabrication.DataPropertyName = "IDLigneFabrication"
        Me.IDLigneFabrication.HeaderText = "Numero Ligne"
        Me.IDLigneFabrication.Name = "IDLigneFabrication"
        Me.IDLigneFabrication.ReadOnly = True
        '
        'Produit
        '
        Me.Produit.DataPropertyName = "Produit"
        Me.Produit.HeaderText = "Produit"
        Me.Produit.Name = "Produit"
        Me.Produit.ReadOnly = True
        '
        'ProduitMarque
        '
        Me.ProduitMarque.DataPropertyName = "ProduitMarque"
        Me.ProduitMarque.HeaderText = "Marque"
        Me.ProduitMarque.Name = "ProduitMarque"
        Me.ProduitMarque.ReadOnly = True
        '
        'Grade
        '
        Me.Grade.DataPropertyName = "Grade"
        Me.Grade.HeaderText = "Grade"
        Me.Grade.Name = "Grade"
        Me.Grade.ReadOnly = True
        '
        'NumeroLot
        '
        Me.NumeroLot.DataPropertyName = "NumeroLot"
        Me.NumeroLot.HeaderText = "Numrero de lot"
        Me.NumeroLot.Name = "NumeroLot"
        Me.NumeroLot.ReadOnly = True
        '
        'NbSacs
        '
        Me.NbSacs.DataPropertyName = "NbSacs"
        Me.NbSacs.HeaderText = "Nombre de Sacs"
        Me.NbSacs.Name = "NbSacs"
        Me.NbSacs.ReadOnly = True
        '
        'PoidsTheorique
        '
        Me.PoidsTheorique.DataPropertyName = "PoidsTheorique"
        Me.PoidsTheorique.HeaderText = "Poids Theorique"
        Me.PoidsTheorique.Name = "PoidsTheorique"
        Me.PoidsTheorique.ReadOnly = True
        '
        'ToolStrip
        '
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btAjouter, Me.btModifier, Me.btSupprimer, Me.btFiltre, Me.btFermer})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(869, 39)
        Me.ToolStrip.Stretch = True
        Me.ToolStrip.TabIndex = 31
        '
        'btAjouter
        '
        Me.btAjouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btAjouter.Image = Global.SAIGIC.My.Resources.Resources.btAjouter32
        Me.btAjouter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btAjouter.Name = "btAjouter"
        Me.btAjouter.Size = New System.Drawing.Size(36, 36)
        Me.btAjouter.Text = "Ajouter"
        '
        'btModifier
        '
        Me.btModifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btModifier.Image = Global.SAIGIC.My.Resources.Resources.btModifier32
        Me.btModifier.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btModifier.Name = "btModifier"
        Me.btModifier.Size = New System.Drawing.Size(36, 36)
        Me.btModifier.Text = "Modifier"
        '
        'btSupprimer
        '
        Me.btSupprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btSupprimer.Image = Global.SAIGIC.My.Resources.Resources.btSupprimer32
        Me.btSupprimer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSupprimer.Name = "btSupprimer"
        Me.btSupprimer.Size = New System.Drawing.Size(36, 36)
        Me.btSupprimer.Text = "Supprimer"
        '
        'btFiltre
        '
        Me.btFiltre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btFiltre.Image = Global.SAIGIC.My.Resources.Resources.btFiltre32
        Me.btFiltre.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btFiltre.Name = "btFiltre"
        Me.btFiltre.Size = New System.Drawing.Size(36, 36)
        Me.btFiltre.Text = "Filtre"
        Me.btFiltre.Visible = False
        '
        'btFermer
        '
        Me.btFermer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btFermer.Image = Global.SAIGIC.My.Resources.Resources.btFermer32
        Me.btFermer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btFermer.Name = "btFermer"
        Me.btFermer.Size = New System.Drawing.Size(36, 36)
        Me.btFermer.Text = "Fermer"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label29, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 39)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(869, 464)
        Me.TableLayoutPanel1.TabIndex = 32
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(4, 1)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(524, 33)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "LISTE DES LOTS FABRIQUES - CACAO"
        '
        'FrmLotsFabriquesCacaoListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 503)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmLotsFabriquesCacaoListe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Titre du Formulaire de Base"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvListeFabrication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents btAjouter As System.Windows.Forms.ToolStripButton
    Friend WithEvents btModifier As System.Windows.Forms.ToolStripButton
    Friend WithEvents btSupprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btFiltre As System.Windows.Forms.ToolStripButton
    Friend WithEvents btFermer As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvListeFabrication As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents mskDateFabrication As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnAfficher As System.Windows.Forms.Button
    Friend WithEvents CodeFabrication As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDLigneFabrication As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Produit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProduitMarque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroLot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NbSacs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PoidsTheorique As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
