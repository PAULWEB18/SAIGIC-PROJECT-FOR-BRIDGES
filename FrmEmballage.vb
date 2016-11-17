'A_VOIR_1: En mode ajouter, permettre d'ouvrir le formulaire répertoire afin d'effectuer une sélection
'Imports DCSaigicLight
'Imports System.IO
'Imports Microsoft.Office.Interop

Public Class FrmEmballage

#Region "Zone de réflexion "

    Dim frmParente As FrmEmballageListe
    Public WriteOnly Property Parente() As FrmEmballageListe
        Set(ByVal value As FrmEmballageListe)
            frmParente = value
        End Set
    End Property

#End Region

#Region "Déclaration des variables "
    Dim MonDA As SqlClient.SqlDataAdapter
    Dim MonDataSet As New DataSet

    Private intIDEmb As String
    Private intTypeOuverture As Integer


#End Region

    ''' <summary>
    ''' Liste permettant d'indiquer le type d'argument du constructeur
    ''' </summary>
    ''' <remarks></remarks>

    Public Enum lstTypeOuverture
        ' Ajouter un nouvel enregistrement => Formulaire vierge
        ModeAjouter
        ' Modifier un enregistrement (Argument ID_Filtre obligatoire) => Formulaire chargé avec l'enregistrement correspondant
        ModeModifier
    End Enum

    Public Sub New(ByVal TypeOuverture As lstTypeOuverture, Optional ByVal bvlIDEmb As Integer = 0)

        MyBase.New()
        InitializeComponent()

        intTypeOuverture = TypeOuverture
        intIDEmb = bvlIDEmb

    End Sub

#Region "Contrôle des saisies de l'utilisateur "

    'Private Sub txtNumeric_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    ' Contrôle de la saisie
    '    'txtCodePostal
    '    'MdlGeneral.TextboxControl(sender, e, True, False, True, False)
    'End Sub

#End Region

    Private Sub frmCarteSIMAjout_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub FrmTypeaccessoire_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.MonDA = Nothing
        Me.MonDataSet = Nothing
    End Sub

    Private Sub frmAjoModRepertoire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Try

        ' Charger le formulaire
        Select Case intTypeOuverture

            Case lstTypeOuverture.ModeAjouter   ' "Ajouter"
                ' Paramétrage du formulaire
                Me.Text = Me.Text & " - Nouveau"
                'CheckBox1.Visible = True
            Case lstTypeOuverture.ModeModifier  ' "Modifier"
                ' Paramètrage du formulaire
                'CheckBox1.Visible = False
                Me.Text = Me.Text & " - Modifier"
                spvAfficherEmballage()
        End Select

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'End Try
        TextBox1.Focus()
    End Sub

    Private Sub spvAfficherEmballage()
        MonDA = New SqlClient.SqlDataAdapter("SELECT * FROM Emballages WHERE idemballage=" & intIDEmb, SaigicLocal_Cnx)
        MonDA.Fill(MonDataSet, "Emballage")

        With MonDataSet.Tables("Emballage")
            If .Rows.Count <> 0 Then
                TextBox1.Text = .Rows(0)("Emballage").ToString()
                TextBox2.Text = CDec(.Rows(0)("pem").ToString())
                TextBox3.Text = CDec(.Rows(0)("IDemballage").ToString())
            Else

            End If
        End With


    End Sub

    Private Sub cmdAjoMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnregistrer.Click

        Dim ppvSQL As String = ""

        Try

            ' Valider les saisies du formulaire
            If ValideSaisies() = False Then
                Exit Sub
            End If

            Select Case intTypeOuverture
                Case lstTypeOuverture.ModeAjouter   ' "Ajouter"
                    MonDA = New SqlClient.SqlDataAdapter
                    ppvSQL = "INSERT INTO Emballages (IDemballage, emballage, pem) VALUES (" & _
                    TextBox3.Text.Replace("'", "''") & ",'" & TextBox1.Text.Replace("'", "''") & "', " & TextBox2.Text & ")"
                    MonDA.InsertCommand = New SqlClient.SqlCommand(ppvSQL, SaigicLocal_Cnx)
                    MonDA.InsertCommand.ExecuteNonQuery()
                    Me.Close()
                Case lstTypeOuverture.ModeModifier  ' "Modifier"
                    ppvSQL = "UPDATE  Emballages SET emballage='" & TextBox1.Text.Replace("'", "''") & _
                    "', pem=" & TextBox2.Text.Replace(",", ".") & " WHERE  idemballage=" & intIDEmb
                    MonDA.UpdateCommand = New SqlClient.SqlCommand(ppvSQL, SaigicLocal_Cnx)
                    MonDA.UpdateCommand.ExecuteNonQuery()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally

        End Try

    End Sub

    Private Sub UpdateCode()
        MonDA.UpdateCommand = New SqlClient.SqlCommand("UPDATE Compteur SET DernierNumero=DernierNumero+1 WHERE _Table='Typeaccessoire'", SaigicLocal_Cnx)
        MonDA.UpdateCommand.ExecuteNonQuery()
    End Sub

    Private Function ValideSaisies() As Boolean

        ' Valider la saisie
        ValideSaisies = True
        ' Effacer les icônes erreur
        Me.ErrorProvider1.Clear()


        If Me.TextBox1.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TextBox1, "Veuillez saisir l'emballage.")
            Me.TextBox2.Focus()
            ValideSaisies = False
        End If

        If Not IsNumeric(Me.TextBox2.Text) Then
            Me.ErrorProvider1.SetError(Me.TextBox2, "Veuillez saisir une donnée numérique")
            Me.TextBox2.Focus()
            ValideSaisies = False
        End If

    End Function

    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFermer.Click
        ' Fermer le formulaire
        Me.Close()

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim Permis As String = "0123456789." & Chr(8) & Chr(13)
        If InStr(Permis, e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If CheckBox1.Checked Then
        '    TextBox1.Text = "XXXXX"
        '    TextBox1.ReadOnly = True
        'Else
        '    TextBox1.ReadOnly = False
        'End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim Permis As String = "0123456789" & Chr(8) & Chr(13)
        If InStr(Permis, e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class