﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLocalisations
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLocalite = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboDepartement = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSousPrefecture = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btEnregistrer = New System.Windows.Forms.ToolStripButton()
        Me.btFermer = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BGWDataSource = New System.ComponentModel.BackgroundWorker()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(521, 251)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(521, 290)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        '
        'grpbxRepertoire
        '
        Me.grpbxRepertoire.Controls.Add(Me.Label4)
        Me.grpbxRepertoire.Controls.Add(Me.txtLocalite)
        Me.grpbxRepertoire.Controls.Add(Me.Label3)
        Me.grpbxRepertoire.Controls.Add(Me.cboDepartement)
        Me.grpbxRepertoire.Controls.Add(Me.Label1)
        Me.grpbxRepertoire.Controls.Add(Me.Label2)
        Me.grpbxRepertoire.Controls.Add(Me.txtSousPrefecture)
        Me.grpbxRepertoire.Controls.Add(Me.txtID)
        Me.grpbxRepertoire.Location = New System.Drawing.Point(13, 13)
        Me.grpbxRepertoire.Name = "grpbxRepertoire"
        Me.grpbxRepertoire.Size = New System.Drawing.Size(482, 197)
        Me.grpbxRepertoire.TabIndex = 0
        Me.grpbxRepertoire.TabStop = False
        Me.grpbxRepertoire.Text = "Ajouter / Modifier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Localités"
        '
        'txtLocalite
        '
        Me.txtLocalite.BackColor = System.Drawing.Color.White
        Me.txtLocalite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocalite.Location = New System.Drawing.Point(134, 131)
        Me.txtLocalite.MaxLength = 0
        Me.txtLocalite.Name = "txtLocalite"
        Me.txtLocalite.Size = New System.Drawing.Size(231, 20)
        Me.txtLocalite.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Sous-Prefecture"
        '
        'cboDepartement
        '
        Me.cboDepartement.FormattingEnabled = True
        Me.cboDepartement.Location = New System.Drawing.Point(134, 59)
        Me.cboDepartement.Name = "cboDepartement"
        Me.cboDepartement.Size = New System.Drawing.Size(231, 21)
        Me.cboDepartement.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Departement"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "ID"
        '
        'txtSousPrefecture
        '
        Me.txtSousPrefecture.BackColor = System.Drawing.Color.White
        Me.txtSousPrefecture.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSousPrefecture.Location = New System.Drawing.Point(134, 93)
        Me.txtSousPrefecture.MaxLength = 0
        Me.txtSousPrefecture.Name = "txtSousPrefecture"
        Me.txtSousPrefecture.Size = New System.Drawing.Size(231, 20)
        Me.txtSousPrefecture.TabIndex = 5
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Location = New System.Drawing.Point(134, 30)
        Me.txtID.MaxLength = 0
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(56, 20)
        Me.txtID.TabIndex = 3
        Me.txtID.TabStop = False
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
        Me.ToolStrip.Size = New System.Drawing.Size(521, 39)
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
        'FrmLocalisations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 290)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmLocalisations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter / Modifier une localité"
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
    Friend WithEvents btEnregistrer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btFermer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BGWDataSource As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSousPrefecture As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboDepartement As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLocalite As System.Windows.Forms.TextBox
End Class
