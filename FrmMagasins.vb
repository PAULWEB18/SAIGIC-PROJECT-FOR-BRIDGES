'A_VOIR_1: En mode ajouter, permettre d'ouvrir le formulaire répertoire afin d'effectuer une sélection
Imports DCSaigicLight
Public Class FrmMagasins

#Region "Zone de réflexion "

    Dim frmParente As Form

    Public WriteOnly Property Parente() As Object
        Set(ByVal value As Object)
            frmParente = value
        End Set
    End Property

    Dim Libelle As String

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

    Public Sub New(ByVal TypeOuverture As lstTypeOuverture, Optional ByVal bvlID As Integer = 0)

        MyBase.New()
        InitializeComponent()

        intTypeOuverture = TypeOuverture
        Cle = bvlID
    End Sub

    Private Sub FrmLocalisations_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmAjoModRepertoire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            ' Charger le formulaire
            Select Case intTypeOuverture
                Case lstTypeOuverture.ModeAjouter   ' "Ajouter"
                    ' Paramétrage du formulaire
                    Me.Text = Me.Text & " - Nouveau"
                Case lstTypeOuverture.ModeModifier  ' "Modifier"

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub



    Private Sub cmdAjoMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnregistrer.Click

        Dim TmpOBJ As New DCSaigicLight.BObject.Magasins
        TmpOBJ.LoadMagasins()

        Try

            ' Valider les saisies du formulaire
            If ValideSaisies() = False Then
                Exit Sub
            End If

            Select Case intTypeOuverture
                Case lstTypeOuverture.ModeAjouter   ' "Ajouter"
                    TmpOBJ.AddBObjectAndBDataMagasin(txtNomMagasin.Text, cboType.Text, cboPort.Text, txtLocalisation.Text)

                Case lstTypeOuverture.ModeModifier  ' "Modifier"
                    TmpOBJ.AddBObjectAndBDataMagasin(txtNomMagasin.Text, cboType.Text, cboPort.Text, txtLocalisation.Text)
            End Select
            TmpOBJ.UpdateAllBData()
            frmParente.Tag = txtNomMagasin.Text & "\" & txtLocalisation.Text

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

        If Me.txtNomMagasin.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtNomMagasin, "Veuillez saisir le nom du magasin.")
            Me.txtNomMagasin.Focus()
            ValideSaisies = False
        End If

        If Me.cboType.Text = "" Then
            Me.ErrorProvider1.SetError(Me.cboType, "Veuillez selectionner le type.")
            Me.cboType.Focus()
            ValideSaisies = False
        End If

        If Me.cboPort.Text = "" Then
            Me.ErrorProvider1.SetError(Me.cboPort, "Veuillez selectionner le port.")
            Me.cboPort.Focus()
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

    Private Sub txtLocalisation_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNomMagasin.KeyPress, txtLocalisation.KeyPress
        If e.KeyChar = "\" Then e.KeyChar = ""
    End Sub
End Class