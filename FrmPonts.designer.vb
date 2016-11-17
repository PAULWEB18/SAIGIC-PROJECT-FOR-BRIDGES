<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPonts
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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btEnregistrer = New System.Windows.Forms.ToolStripButton()
        Me.btFermer = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BGWDataSource = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(728, 288)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(728, 327)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        '
        'grpbxRepertoire
        '
        Me.grpbxRepertoire.Controls.Add(Me.Button1)
        Me.grpbxRepertoire.Controls.Add(Me.ComboBox2)
        Me.grpbxRepertoire.Controls.Add(Me.TextBox4)
        Me.grpbxRepertoire.Controls.Add(Me.Label2)
        Me.grpbxRepertoire.Controls.Add(Me.TextBox1)
        Me.grpbxRepertoire.Controls.Add(Me.ComboBox1)
        Me.grpbxRepertoire.Controls.Add(Me.Label6)
        Me.grpbxRepertoire.Controls.Add(Me.Label4)
        Me.grpbxRepertoire.Controls.Add(Me.Label1)
        Me.grpbxRepertoire.Controls.Add(Me.TextBox3)
        Me.grpbxRepertoire.Controls.Add(Me.lblNom)
        Me.grpbxRepertoire.Location = New System.Drawing.Point(13, 13)
        Me.grpbxRepertoire.Name = "grpbxRepertoire"
        Me.grpbxRepertoire.Size = New System.Drawing.Size(715, 324)
        Me.grpbxRepertoire.TabIndex = 1
        Me.grpbxRepertoire.TabStop = False
        Me.grpbxRepertoire.Text = "Ajouter / Modifier"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"BROUSSE", "EXPORT", "BROUSSE/EXPORT", "IMPORT"})
        Me.ComboBox2.Location = New System.Drawing.Point(113, 108)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(223, 21)
        Me.ComboBox2.TabIndex = 50
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Location = New System.Drawing.Point(113, 135)
        Me.TextBox4.MaxLength = 0
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(223, 60)
        Me.TextBox4.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Code pont"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(113, 30)
        Me.TextBox1.MaxLength = 0
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(102, 20)
        Me.TextBox1.TabIndex = 44
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(113, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(223, 21)
        Me.ComboBox1.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Type pont"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(18, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 60)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Chemin de la base de données"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Nom pont"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Location = New System.Drawing.Point(113, 82)
        Me.TextBox3.MaxLength = 0
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(223, 20)
        Me.TextBox3.TabIndex = 21
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(18, 58)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(25, 13)
        Me.lblNom.TabIndex = 5
        Me.lblNom.Text = "Site"
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
        Me.ToolStrip.Size = New System.Drawing.Size(728, 39)
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
        Me.Button1.Location = New System.Drawing.Point(432, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "MISE A JOUR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmPonts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 327)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPonts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter / Modifier un pont"
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
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents btEnregistrer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btFermer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BGWDataSource As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
