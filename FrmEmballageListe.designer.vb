<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmballageListe
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmballageListe))
        Me.grpbxBase = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.NouveauToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EditerToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SupprimerToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FermerToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FiltreToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ImprimerToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ApercuToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btAjouter = New System.Windows.Forms.ToolStripButton()
        Me.btModifier = New System.Windows.Forms.ToolStripButton()
        Me.btSupprimer = New System.Windows.Forms.ToolStripButton()
        Me.btFiltre = New System.Windows.Forms.ToolStripButton()
        Me.btFermer = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grpbxBase.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbxBase
        '
        Me.grpbxBase.Controls.Add(Me.DataGridView1)
        Me.grpbxBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpbxBase.Location = New System.Drawing.Point(0, 0)
        Me.grpbxBase.Name = "grpbxBase"
        Me.grpbxBase.Padding = New System.Windows.Forms.Padding(10)
        Me.grpbxBase.Size = New System.Drawing.Size(964, 445)
        Me.grpbxBase.TabIndex = 25
        Me.grpbxBase.TabStop = False
        Me.grpbxBase.Text = "Liste des emballages"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(10, 23)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.Size = New System.Drawing.Size(944, 412)
        Me.DataGridView1.TabIndex = 9
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 544)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(964, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripSeparator
        '
        Me.ToolStripSeparator.Name = "ToolStripSeparator"
        Me.ToolStripSeparator.Size = New System.Drawing.Size(6, 39)
        '
        'NouveauToolStripButton
        '
        Me.NouveauToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NouveauToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NouveauToolStripButton.Name = "NouveauToolStripButton"
        Me.NouveauToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.NouveauToolStripButton.Text = "&Nouveau"
        '
        'EditerToolStripButton
        '
        Me.EditerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditerToolStripButton.Name = "EditerToolStripButton"
        Me.EditerToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.EditerToolStripButton.Text = "&Editer"
        '
        'SupprimerToolStripButton
        '
        Me.SupprimerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SupprimerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SupprimerToolStripButton.Name = "SupprimerToolStripButton"
        Me.SupprimerToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.SupprimerToolStripButton.Text = "&Supprimer"
        '
        'FermerToolStripButton
        '
        Me.FermerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FermerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FermerToolStripButton.Name = "FermerToolStripButton"
        Me.FermerToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.FermerToolStripButton.Text = "&Fermer"
        '
        'FiltreToolStripButton
        '
        Me.FiltreToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FiltreToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FiltreToolStripButton.Name = "FiltreToolStripButton"
        Me.FiltreToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.FiltreToolStripButton.Text = "Fil&tre"
        '
        'ImprimerToolStripButton
        '
        Me.ImprimerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimerToolStripButton.Name = "ImprimerToolStripButton"
        Me.ImprimerToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ImprimerToolStripButton.Text = "&Imprimer"
        '
        'ApercuToolStripButton
        '
        Me.ApercuToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ApercuToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ApercuToolStripButton.Name = "ApercuToolStripButton"
        Me.ApercuToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ApercuToolStripButton.Text = "ToolStripButton2"
        Me.ApercuToolStripButton.ToolTipText = "Aperçu avant impression"
        '
        'ToolStrip
        '
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btAjouter, Me.btModifier, Me.btSupprimer, Me.btFiltre, Me.btFermer})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(964, 39)
        Me.ToolStrip.Stretch = True
        Me.ToolStrip.TabIndex = 30
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 39)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpbxBase)
        Me.SplitContainer1.Size = New System.Drawing.Size(964, 505)
        Me.SplitContainer1.SplitterDistance = 56
        Me.SplitContainer1.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nom Immeuble"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(493, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 26)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "&R.A.Z."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(660, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 28)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "&Rechercher"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(277, 20)
        Me.TextBox1.TabIndex = 30
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(964, 56)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtre"
        '
        'FrmEmballageListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 566)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        'Me.Icon = My.Resources.Logo 'CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(970, 500)
        Me.Name = "FrmEmballageListe"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Titre du Formulaire de Base"
        Me.grpbxBase.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents NouveauToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditerToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SupprimerToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FermerToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FiltreToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimerToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ApercuToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents btAjouter As System.Windows.Forms.ToolStripButton
    Friend WithEvents btModifier As System.Windows.Forms.ToolStripButton
    Friend WithEvents btSupprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btFermer As System.Windows.Forms.ToolStripButton
    Friend WithEvents grpbxBase As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btFiltre As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
