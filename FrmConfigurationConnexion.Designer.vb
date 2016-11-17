<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfigurationConnexion
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
        Me.btnValider = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.rtxChaineConnexionLocal = New System.Windows.Forms.RichTextBox()
        Me.rtxChaineConnexionServeur = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(365, 395)
        Me.btnValider.Margin = New System.Windows.Forms.Padding(4)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(165, 53)
        Me.btnValider.TabIndex = 10
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rtxChaineConnexionLocal)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 191)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connexion locale"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rtxChaineConnexionServeur)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 128)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parametres serveur central"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(458, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Exemple de chaine de connexion native SQL Server"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(452, 76)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(454, 59)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.Text = "Data Source=CI-SNGUESSAN\SQLEXP2005;Initial Catalog=SAIGICPONTDB;User ID=sa; PWD=" & _
            "azerty;"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(458, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(389, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Exemple paramettre de parametres pour le serveur central"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(452, 288)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(454, 59)
        Me.TextBox3.TabIndex = 14
        Me.TextBox3.Text = "NomServeurLie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NomBaseDeDonnees"
        '
        'rtxChaineConnexionLocal
        '
        Me.rtxChaineConnexionLocal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxChaineConnexionLocal.Location = New System.Drawing.Point(3, 20)
        Me.rtxChaineConnexionLocal.Name = "rtxChaineConnexionLocal"
        Me.rtxChaineConnexionLocal.Size = New System.Drawing.Size(428, 168)
        Me.rtxChaineConnexionLocal.TabIndex = 0
        Me.rtxChaineConnexionLocal.Text = ""
        '
        'rtxChaineConnexionServeur
        '
        Me.rtxChaineConnexionServeur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxChaineConnexionServeur.Location = New System.Drawing.Point(3, 20)
        Me.rtxChaineConnexionServeur.Name = "rtxChaineConnexionServeur"
        Me.rtxChaineConnexionServeur.Size = New System.Drawing.Size(431, 105)
        Me.rtxChaineConnexionServeur.TabIndex = 0
        Me.rtxChaineConnexionServeur.Text = ""
        '
        'FrmConfigurationConnexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 461)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnValider)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmConfigurationConnexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuration des connexions"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents rtxChaineConnexionLocal As System.Windows.Forms.RichTextBox
    Friend WithEvents rtxChaineConnexionServeur As System.Windows.Forms.RichTextBox
End Class
