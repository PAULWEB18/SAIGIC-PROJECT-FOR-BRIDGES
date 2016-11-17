'A_VOIR_1: En mode ajouter, permettre d'ouvrir le formulaire répertoire afin d'effectuer une sélection
Imports DCSaigicLight
Public Class FrmLocalisations

#Region "Zone de réflexion "

    Dim frmParente As Form

    Public WriteOnly Property Parente() As Object
        Set(ByVal value As Object)
            frmParente = value
        End Set
    End Property

    Dim Libelle As String
    Dim CodeDepartement As String
    Public Property LibelleParent() As String
        Set(ByVal value As String)
            Libelle = value

        End Set

        Get
            Return Libelle
        End Get

    End Property

#End Region

#Region "Déclaration des variables "
    Dim ListesDepartements As New DCSaigicLight.BObject.Departements

    Private Cle As Integer
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

    Public Sub New(ByVal TypeOuverture As lstTypeOuverture, Optional ByVal bvlID As Integer = 0, Optional ByVal bvlDepartement As String = "")

        MyBase.New()
        InitializeComponent()

        intTypeOuverture = TypeOuverture
        Cle = bvlID
        CodeDepartement = bvlDepartement
    End Sub

    Private Sub FrmLocalisations_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmAjoModRepertoire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ListesDepartements.LoadDepartements()
            spbChargerDropDownList(ListesDepartements, cboDepartement, "Dept_ID", "LibelDepart")
            ' Charger le formulaire
            Select Case intTypeOuverture
                Case lstTypeOuverture.ModeAjouter   ' "Ajouter"
                    ' Paramétrage du formulaire
                    Me.Text = Me.Text & " - Nouveau"
                    Try
                        cboDepartement.SelectedValue = CodeDepartement
                        cboDepartement.Enabled = False
                    Catch ex As Exception

                    End Try
                Case lstTypeOuverture.ModeModifier  ' "Modifier"
                    ' Paramètrage du formulaire
                    'CheckBox1.Visible = False
                    'Me.Text = Me.Text & " - Modifier"
                    'spvAfficherLocalisation()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    'Private Sub spvAfficherLocalisation()
    '    Dim tmpLocalisations As New DCSaigicLight.BObject.Localisations
    '    tmpLocalisations.LoadLocalisations()
    '    Localisation = tmpLocalisations.FindLocalisation(Cle)

    '    With Localisation
    '        TextBox1.Text = .Loc_ID
    '        Try
    '            ComboBox1.SelectedValue = .Sprefecture
    '        Catch ex As Exception

    '        End Try

    '        TextBox2.Text = .LabelLocalistion
    '    End With
    'End Sub

    Private Sub cmdAjoMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnregistrer.Click

        Dim TmpOBJ As New DCSaigicLight.BObject.Localisations
        TmpOBJ.LoadLocalisations()

        Try

            ' Valider les saisies du formulaire
            If ValideSaisies() = False Then
                Exit Sub
            End If

            Select Case intTypeOuverture
                Case lstTypeOuverture.ModeAjouter   ' "Ajouter"
                    TmpOBJ.AddBObjectAndBDataLocalisation(0, cboDepartement.SelectedValue, txtSousPrefecture.Text, txtLocalite.Text)

                Case lstTypeOuverture.ModeModifier  ' "Modifier"
                    TmpOBJ.UpdateBOjectAndBDataLocalisation(0, cboDepartement.SelectedValue, txtSousPrefecture.Text, txtLocalite.Text)
            End Select
            TmpOBJ.UpdateAllBData()
            frmParente.Tag = txtSousPrefecture.Text & "\" & txtLocalite.Text

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

        If Me.txtSousPrefecture.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtSousPrefecture, "Veuillez saisir le nom de la sous-prefecture.")
            Me.txtSousPrefecture.Focus()
            ValideSaisies = False
        End If

        If Me.txtLocalite.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtLocalite, "Veuillez saisir le nom de la Localite.")
            Me.txtLocalite.Focus()
            ValideSaisies = False
        End If

    End Function

    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFermer.Click
        ' Fermer le formulaire
        Me.Close()

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub

End Class