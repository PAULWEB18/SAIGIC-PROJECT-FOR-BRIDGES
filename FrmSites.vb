'A_VOIR_1: En mode ajouter, permettre d'ouvrir le formulaire répertoire afin d'effectuer une sélection
Imports DCSaigicLight
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Windows.Forms
Public Class FrmSites

#Region "Zone de réflexion "

    Dim frmParente As FrmSitesListe
    Public WriteOnly Property Parente() As FrmSitesListe
        Set(ByVal value As FrmSitesListe)
            frmParente = value
        End Set
    End Property

#End Region

#Region "Déclaration des variables "
    Dim MonDA As SqlClient.SqlDataAdapter
    Dim MonDataSet As New DataSet


    Dim leslocalites As New BObject.Localisations

    Dim Site As New BObject.Site

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

#Region "Contrôle des saisies de l'Site "

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
            leslocalites.LoadLocalisations()

            spbChargerDropDownList(leslocalites, ComboBox1, "LibelleLocalisation", "LibelleLocalisation")

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
                    spvAfficherSite()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub


    Private Sub spvAfficherSite()
        Dim tmpsites As New BObject.Sites
        tmpsites.LoadSites()
        Site = tmpsites.FindSite(strCodeUser)

        With Site
            TextBox1.Text = .IDSite
            TextBox2.Text = .NomLong
            TextBox3.Text = .NomCourt
            ComboBox1.SelectedValue = .Localisation
            TextBox4.Text = .BoitePostale
            TextBox5.Text = .Telephone
            TextBox6.Text = .Fax
            TextBox7.Text = .Email
        End With
    End Sub



    Private Sub cmdAjoMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnregistrer.Click
        'Dim MonChemin As String = Application.StartupPath & "\Local.ini"
        'Dim FichierLocal As String
        'FichierLocal = LitDansFichierIni("Affichage", "BDD", MonChemin, 100)
        'JeniSoftLocal_Cnx.ConnectionString = FichierLocal
        Dim cmd As SqlCommand

        Try
            'SaigicLocal_Cnx.Open()
        Catch
            MsgBox(Err.Description)
        End Try

        Me.Hide()
        'Dim sql = "SELECT * FROM `Site` WHERE NomUt='" & TextBox1.Text & "' AND motpasse='" & TextBox2.Text & "'"
        'Dim sql = "update Site set idsite='"   ,NomLong ='" & TextBox2.Text & "',NomCourt='" & TextBox3.Text & "'"
        Dim sql = "insert into  Site (idsite ,NomLong ,NomCourt,Localisation) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.SelectedValue & "' )"

        Try
            Debug.Print(sql)
            cmd = New SqlClient.SqlCommand(sql, SaigicLocal_Cnx)
            'Dim dr As SqlClient.SqlDataReader = cmd.ExecuteReader
            ' MonDA = New SqlClient.SqlDataAdapter(cmd)
            cmd.ExecuteNonQuery()
            MsgBox("Site mis à jour")

            'ajout du code site
            Dim mycommand As New SqlCommand
            sql = "update  Parametres  set CodeSite='" & TextBox1.Text & "'"
            Debug.Print(sql)
            mycommand.Connection = SaigicLocal_Cnx
            mycommand.CommandText = sql
            'Dim drsql As SqlClient.SqlDataReader = cmd.ExecuteReader
            'MonDA = New SqlClient.SqlDataAdapter(cmd)

            mycommand.ExecuteNonQuery()
            MsgBox("Parametres CodeSite mis à jour")
        'If dr.Read = False Then
        '    MessageBox.Show("Authentication non effectuee...")
        '    dr.Close()
        '    Me.Show()
            'Else

            'End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        'Dim TmpOBJ As New BObject.Sites
        'TmpOBJ.LoadSites()

        'Try

        '    ' Valider les saisies du formulaire
        '    If ValideSaisies() = False Then
        '        Exit Sub
        '    End If

        '    Select Case intTypeOuverture
        '        Case lstTypeOuverture.ModeAjouter   ' "Ajouter"

        '            TmpOBJ.AddBObjectAndBDataSite(TextBox1.Text, TextBox2.Text, TextBox3.Text, ComboBox1.SelectedValue, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text)

        '        Case lstTypeOuverture.ModeModifier  ' "Modifier"
        '            TmpOBJ.UpdateBOjectAndBDataSite(TextBox1.Text, TextBox2.Text, TextBox3.Text, ComboBox1.SelectedValue, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text;)
        '    End Select
        '    TmpOBJ.UpdateAllBData()
        '    Me.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        'Finally

        'End Try

    End Sub


    Private Function ValideSaisies() As Boolean

        ' Valider la saisie
        ValideSaisies = True
        ' Effacer les icônes erreur
        Me.ErrorProvider1.Clear()

        If Me.TextBox1.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TextBox1, "Veuillez saisir le code du Site.")
            Me.TextBox1.Focus()
            ValideSaisies = False
        End If

        If Me.TextBox2.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TextBox2, "Veuillez saisir le nom du Site.")
            Me.TextBox2.Focus()
            ValideSaisies = False
        End If

        If IsNothing(Me.ComboBox1.SelectedValue) Then
            Me.ErrorProvider1.SetError(Me.ComboBox1, "Veuillez sélectionner la localité.")
            Me.ComboBox1.Focus()
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

End Class