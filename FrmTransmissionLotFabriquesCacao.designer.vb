<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransmissionLotFabriquesCacao
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ltvPesee = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ligne = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Marque = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Transmission = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnValider = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdoTransmises = New System.Windows.Forms.RadioButton()
        Me.rdoNonTransmises = New System.Windows.Forms.RadioButton()
        Me.btnValidationInverse = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNbItems = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.35262!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.64738!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ltvPesee, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnValider, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnQuitter, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label29, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnValidationInverse, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLog, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(922, 556)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ltvPesee
        '
        Me.ltvPesee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Ligne, Me.Marque, Me.Transmission})
        Me.TableLayoutPanel1.SetColumnSpan(Me.ltvPesee, 4)
        Me.ltvPesee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ltvPesee.Location = New System.Drawing.Point(3, 113)
        Me.ltvPesee.Name = "ltvPesee"
        Me.ltvPesee.Size = New System.Drawing.Size(916, 272)
        Me.ltvPesee.TabIndex = 4
        Me.ltvPesee.UseCompatibleStateImageBehavior = False
        Me.ltvPesee.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 352
        '
        'Ligne
        '
        Me.Ligne.Text = "Ligne"
        '
        'Marque
        '
        Me.Marque.Text = "Marque"
        Me.Marque.Width = 156
        '
        'Transmission
        '
        Me.Transmission.Text = "Transmises ?"
        Me.Transmission.Width = 88
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(173, 391)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(207, 41)
        Me.btnValider.TabIndex = 5
        Me.btnValider.Text = "Transmision"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 3
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(638, 391)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(153, 41)
        Me.btnQuitter.TabIndex = 6
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label29, 4)
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(3, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(644, 33)
        Me.Label29.TabIndex = 9
        Me.Label29.Text = "TRANSMISSION DES LOTS FABRIQUES CACAO"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdoTransmises)
        Me.Panel1.Controls.Add(Me.rdoNonTransmises)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(173, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 49)
        Me.Panel1.TabIndex = 10
        '
        'rdoTransmises
        '
        Me.rdoTransmises.AutoSize = True
        Me.rdoTransmises.Location = New System.Drawing.Point(130, 7)
        Me.rdoTransmises.Name = "rdoTransmises"
        Me.rdoTransmises.Size = New System.Drawing.Size(78, 17)
        Me.rdoTransmises.TabIndex = 1
        Me.rdoTransmises.Text = "Transmises"
        Me.rdoTransmises.UseVisualStyleBackColor = True
        '
        'rdoNonTransmises
        '
        Me.rdoNonTransmises.AutoSize = True
        Me.rdoNonTransmises.Checked = True
        Me.rdoNonTransmises.Location = New System.Drawing.Point(3, 7)
        Me.rdoNonTransmises.Name = "rdoNonTransmises"
        Me.rdoNonTransmises.Size = New System.Drawing.Size(101, 17)
        Me.rdoNonTransmises.TabIndex = 0
        Me.rdoNonTransmises.TabStop = True
        Me.rdoNonTransmises.Text = "Non-Transmises"
        Me.rdoNonTransmises.UseVisualStyleBackColor = True
        '
        'btnValidationInverse
        '
        Me.btnValidationInverse.Location = New System.Drawing.Point(386, 391)
        Me.btnValidationInverse.Name = "btnValidationInverse"
        Me.btnValidationInverse.Size = New System.Drawing.Size(246, 41)
        Me.btnValidationInverse.TabIndex = 11
        Me.btnValidationInverse.Text = "Marquer comme non transmis"
        Me.btnValidationInverse.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel2, 2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtNbItems)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(386, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(533, 49)
        Me.Panel2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nombre d'items"
        '
        'txtNbItems
        '
        Me.txtNbItems.Location = New System.Drawing.Point(411, 4)
        Me.txtNbItems.Name = "txtNbItems"
        Me.txtNbItems.ReadOnly = True
        Me.txtNbItems.Size = New System.Drawing.Size(75, 20)
        Me.txtNbItems.TabIndex = 19
        Me.txtNbItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(131, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 27)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Deselectionner tout"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 27)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Selectionner tout"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtLog, 4)
        Me.txtLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLog.Location = New System.Drawing.Point(3, 446)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(916, 107)
        Me.txtLog.TabIndex = 13
        '
        'FrmTransmissionLotFabriquesCacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 556)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmTransmissionLotFabriquesCacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transmission des donnees cacao"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ltvPesee As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents Marque As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Transmission As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdoTransmises As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNonTransmises As System.Windows.Forms.RadioButton
    Friend WithEvents btnValidationInverse As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNbItems As System.Windows.Forms.TextBox
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents Ligne As System.Windows.Forms.ColumnHeader
End Class
