'A_VOIR_1: En mode ajouter, permettre d'ouvrir le formulaire répertoire afin d'effectuer une sélection
Imports DCSaigicLight
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Windows.Forms
Public Class FrmUtilisateurs

#Region "Zone de réflexion "

    Dim frmParente As FrmUtilisateursListe
    Public WriteOnly Property Parente() As FrmUtilisateursListe
        Set(ByVal value As FrmUtilisateursListe)
            frmParente = value
        End Set
    End Property

#End Region

#Region "Déclaration des variables "
    Dim MonDA As OleDb.OleDbDataAdapter
    Dim MonDataSet As New DataSet

    Dim User As New BObject.Utilisateur

    Private strCodeUser As String
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

    Public Sub New(ByVal TypeOuverture As lstTypeOuverture, Optional ByVal bvlCodeUser As String = "")

        MyBase.New()
        InitializeComponent()

        intTypeOuverture = TypeOuverture
        strCodeUser = bvlCodeUser

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

        Try


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
                    spvAfficherUtilisateur()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub spvAfficherUtilisateur()
        Dim tmpUsers As New BObject.Utilisateurs
        tmpUsers.LoadUtilisateurs()
        User = tmpUsers.FindUtilisateur(strCodeUser)
        Dim tmpPont As New BObject.Ponts
        tmpPont.LoadPonts()
        With User
            txtCodeUser.Text = .CodeUser
            txtNomComplet.Text = .NomComplet
            txtMotPasse.Text = .MotPasse
            cboProfil.Text = .Profil
            txtContact.Text = .Contact
            txtEmail.Text = .email
            chkActif.Checked = .Actif
        End With
    End Sub



    Private Sub cmdAjoMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnregistrer.Click

        Dim TmpOBJ As New BObject.Utilisateurs
        TmpOBJ.LoadUtilisateurs()

        Try

            ' Valider les saisies du formulaire
            If ValideSaisies() = False Then
                Exit Sub
            End If

            Select Case intTypeOuverture
                Case lstTypeOuverture.ModeAjouter   ' "Ajouter"
                    txtMotPasse.Text = ToMD5(txtCodeUser.Text)
                    TmpOBJ.AddBObjectAndBDataUtilisateur(txtCodeUser.Text, txtNomComplet.Text, txtMotPasse.Text, cboProfil.Text, txtEmail.Text, txtContact.Text, chkActif.Checked, "")

                Case lstTypeOuverture.ModeModifier  ' "Modifier"
                    TmpOBJ.UpdateBOjectAndBDataUtilisateur(txtCodeUser.Text, txtNomComplet.Text, txtMotPasse.Text, cboProfil.Text, txtEmail.Text, txtContact.Text, chkActif.Checked, "")
            End Select
            TmpOBJ.UpdateAllBData()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Finally

        End Try

    End Sub


    Private Function ValideSaisies() As Boolean

        ' Valider la saisie
        ValideSaisies = True
        ' Effacer les icônes erreur
        Me.ErrorProvider1.Clear()

        If Me.txtCodeUser.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtCodeUser, "Veuillez saisir le code de l'utilisateur.")
            Me.txtCodeUser.Focus()
            ValideSaisies = False
        End If

        If Me.txtNomComplet.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtNomComplet, "Veuillez saisir le nom de l'utilisateur.")
            Me.txtNomComplet.Focus()
            ValideSaisies = False
        End If

    End Function

    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFermer.Click
        ' Fermer le formulaire
        Me.Close()

    End Sub


    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Permis As String = "0123456789" & Chr(8) & Chr(13)
        If InStr(Permis, e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProfil.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMotPasse.Click
        Dim TmpOBJ As New BObject.Utilisateurs
        TmpOBJ.LoadUtilisateurs()
        txtMotPasse.Text = ToMD5(txtCodeUser.Text)
        TmpOBJ.UpdateBObjectMotPasse(txtCodeUser.Text, txtMotPasse.Text)
        TmpOBJ.UpdateAllBData()

    End Sub

    Private Sub CboModePesee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboModePesee.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myCommand2 As New SqlCommand
        Dim myAdapter As New SqlDataAdapter
        Dim mydata As New DataTable
        Dim strSQL As String
        Dim tmpParam As New DCSaigicLight.BObject.Parametress
        

        strSQL = "UPDATE Parametres SET ModePesee='" & CboModePesee.Text & "'"
        myCommand2.CommandText = strSQL
        myCommand2.Connection = SaigicLocal_Cnx
        myAdapter.SelectCommand = myCommand2
        myAdapter.SelectCommand.ExecuteNonQuery()

        'cn.Close()
        tmpParam.LoadParametress()
        MonParametre = tmpParam.FindParametres("01")
        MsgBox(" MODE " & CboModePesee.SelectedItem & " ACTIVE !")

        Me.Close()
    End Sub
    

End Class
