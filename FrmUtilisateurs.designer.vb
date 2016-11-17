<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtilisateurs
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
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.grpbxRepertoire = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.chkActif = New System.Windows.Forms.CheckBox()
        Me.txtMotPasse = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodeUser = New System.Windows.Forms.TextBox()
        Me.btnMotPasse = New System.Windows.Forms.Button()
        Me.cboProfil = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtNomComplet = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btEnregistrer = New System.Windows.Forms.ToolStripButton()
        Me.btFermer = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BGWDataSource = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CboModePesee = New System.Windows.Forms.ComboBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.grpbxRepertoire.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.grpbxRepertoire)
        Me.ToolStripContainer1.ContentPanel.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(741, 248)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(741, 287)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        '
        'grpbxRepertoire
        '
        Me.grpbxRepertoire.Controls.Add(Me.Label3)
        Me.grpbxRepertoire.Controls.Add(Me.CboModePesee)
        Me.grpbxRepertoire.Controls.Add(Me.Button1)
        Me.grpbxRepertoire.Controls.Add(Me.Label1)
        Me.grpbxRepertoire.Controls.Add(Me.txtEmail)
        Me.grpbxRepertoire.Controls.Add(Me.chkActif)
        Me.grpbxRepertoire.Controls.Add(Me.txtMotPasse)
        Me.grpbxRepertoire.Controls.Add(Me.Label2)
        Me.grpbxRepertoire.Controls.Add(Me.txtCodeUser)
        Me.grpbxRepertoire.Controls.Add(Me.btnMotPasse)
        Me.grpbxRepertoire.Controls.Add(Me.cboProfil)
        Me.grpbxRepertoire.Controls.Add(Me.Label7)
        Me.grpbxRepertoire.Controls.Add(Me.Label5)
        Me.grpbxRepertoire.Controls.Add(Me.txtContact)
        Me.grpbxRepertoire.Controls.Add(Me.txtNomComplet)
        Me.grpbxRepertoire.Controls.Add(Me.lblNom)
        Me.grpbxRepertoire.Controls.Add(Me.ShapeContainer1)
        Me.grpbxRepertoire.Location = New System.Drawing.Point(13, 13)
        Me.grpbxRepertoire.Name = "grpbxRepertoire"
        Me.grpbxRepertoire.Size = New System.Drawing.Size(715, 224)
        Me.grpbxRepertoire.TabIndex = 1
        Me.grpbxRepertoire.TabStop = False
        Me.grpbxRepertoire.Text = "Ajouter / Modifier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "E-mail"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Location = New System.Drawing.Point(113, 161)
        Me.txtEmail.MaxLength = 0
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(223, 20)
        Me.txtEmail.TabIndex = 5
        '
        'chkActif
        '
        Me.chkActif.AutoSize = True
        Me.chkActif.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActif.Checked = True
        Me.chkActif.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActif.Location = New System.Drawing.Point(24, 188)
        Me.chkActif.Name = "chkActif"
        Me.chkActif.Size = New System.Drawing.Size(53, 17)
        Me.chkActif.TabIndex = 5
        Me.chkActif.Text = "Actif?"
        Me.chkActif.UseVisualStyleBackColor = True
        '
        'txtMotPasse
        '
        Me.txtMotPasse.BackColor = System.Drawing.Color.White
        Me.txtMotPasse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMotPasse.Location = New System.Drawing.Point(113, 82)
        Me.txtMotPasse.MaxLength = 0
        Me.txtMotPasse.Name = "txtMotPasse"
        Me.txtMotPasse.Size = New System.Drawing.Size(223, 20)
        Me.txtMotPasse.TabIndex = 2
        Me.txtMotPasse.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Code "
        '
        'txtCodeUser
        '
        Me.txtCodeUser.BackColor = System.Drawing.Color.White
        Me.txtCodeUser.Location = New System.Drawing.Point(113, 30)
        Me.txtCodeUser.MaxLength = 0
        Me.txtCodeUser.Name = "txtCodeUser"
        Me.txtCodeUser.Size = New System.Drawing.Size(102, 20)
        Me.txtCodeUser.TabIndex = 0
        '
        'btnMotPasse
        '
        Me.btnMotPasse.Location = New System.Drawing.Point(402, 72)
        Me.btnMotPasse.Name = "btnMotPasse"
        Me.btnMotPasse.Size = New System.Drawing.Size(253, 30)
        Me.btnMotPasse.TabIndex = 6
        Me.btnMotPasse.Text = "Réinitialiser le mot de passe"
        Me.btnMotPasse.UseVisualStyleBackColor = True
        '
        'cboProfil
        '
        Me.cboProfil.FormattingEnabled = True
        Me.cboProfil.Items.AddRange(New Object() {"-", "SUP", "PES"})
        Me.cboProfil.Location = New System.Drawing.Point(113, 108)
        Me.cboProfil.Name = "cboProfil"
        Me.cboProfil.Size = New System.Drawing.Size(102, 21)
        Me.cboProfil.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Contact"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Profil"
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.White
        Me.txtContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContact.Location = New System.Drawing.Point(113, 135)
        Me.txtContact.MaxLength = 0
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(223, 20)
        Me.txtContact.TabIndex = 4
        '
        'txtNomComplet
        '
        Me.txtNomComplet.BackColor = System.Drawing.Color.White
        Me.txtNomComplet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomComplet.Location = New System.Drawing.Point(113, 56)
        Me.txtNomComplet.MaxLength = 0
        Me.txtNomComplet.Name = "txtNomComplet"
        Me.txtNomComplet.Size = New System.Drawing.Size(223, 20)
        Me.txtNomComplet.TabIndex = 1
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(21, 58)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(69, 13)
        Me.lblNom.TabIndex = 5
        Me.lblNom.Text = "Nom complet"
        '
        'ToolStrip
        '
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btEnregistrer, Me.btFermer})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(741, 39)
        Me.ToolStrip.Stretch = True
        Me.ToolStrip.TabIndex = 3
        '
        'btEnregistrer
        '
        Me.btEnregistrer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btEnregistrer.Image = Global.SAIGIC.My.Resources.Resources.btEnregistrer32
        Me.btEnregistrer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEnregistrer.Name = "btEnregistrer"
        Me.btEnregistrer.Size = New System.Drawing.Size(36, 36)
        '
        'btFermer
        '
        Me.btFermer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btFermer.Image = Global.SAIGIC.My.Resources.Resources.btFermer32
        Me.btFermer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btFermer.Name = "btFermer"
        Me.btFermer.Size = New System.Drawing.Size(36, 36)
        Me.btFermer.Text = "btFermer"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(631, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 26)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CboModePesee
        '
        Me.CboModePesee.FormattingEnabled = True
        Me.CboModePesee.Items.AddRange(New Object() {"AUTOMATIQUE", "MANUEL"})
        Me.CboModePesee.Location = New System.Drawing.Point(473, 157)
        Me.CboModePesee.Name = "CboModePesee"
        Me.CboModePesee.Size = New System.Drawing.Size(150, 21)
        Me.CboModePesee.TabIndex = 54
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(709, 205)
        Me.ShapeContainer1.TabIndex = 55
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(384, 125)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(302, 47)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(399, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Mode Pesee"
        '
        'FrmUtilisateurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 287)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Global.SAIGIC.My.Resources.Resources.Logo1
        Me.MaximizeBox = False
        Me.Name = "FrmUtilisateurs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter / Modifier un utilisateur"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.grpbxRepertoire.ResumeLayout(False)
        Me.grpbxRepertoire.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents grpbxRepertoire As System.Windows.Forms.GroupBox
    Friend WithEvents txtNomComplet As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents btEnregistrer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btFermer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BGWDataSource As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnMotPasse As System.Windows.Forms.Button
    Friend WithEvents cboProfil As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodeUser As System.Windows.Forms.TextBox
    Friend WithEvents chkActif As System.Windows.Forms.CheckBox
    Friend WithEvents txtMotPasse As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents CboModePesee As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
