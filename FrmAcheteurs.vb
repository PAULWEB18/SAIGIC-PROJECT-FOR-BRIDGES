'A_VOIR_1: En mode ajouter, permettre d'ouvrir le formulaire répertoire afin d'effectuer une sélection
Imports DCSaigicLight
Imports System.Data
Imports System.Data.SqlClient
Public Class FrmAcheteurs
    
#Region "Zone de réflexion "

    Dim frmParente As FrmAcheteursListe
    Public WriteOnly Property Parente() As FrmAcheteursListe
        Set(ByVal value As FrmAcheteursListe)
            frmParente = value
        End Set
    End Property

#End Region

#Region "Déclaration des variables "
    Dim leslocalisations As New BObject.Localisations
    Dim Acheteur As New BObject.Acheteur

    Dim MonDA As SqlClient.SqlDataAdapter
    Dim MonDataSet As New DataSet

    Private Cle As String
    Private intTypeOuverture As Integer
    Private intAch As String


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

    Public Sub New(ByVal TypeOuverture As lstTypeOuverture, Optional ByVal bvlID As String = "0")

        MyBase.New()
        InitializeComponent()

        intTypeOuverture = TypeOuverture
        Cle = bvlID

    End Sub

#Region "Contrôle des saisies de l'Acheteur "

    'Private Sub txtNumeric_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    ' Contrôle de la saisie
    '    'txtCodePostal
    '    'MdlGeneral.TextboxControl(sender, e, True, False, True, False)
    'End Sub

#End Region

    Private Sub frmCarteSIMAjout_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub FrmTypeaccessoire_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmAjoModRepertoire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try
            leslocalisations.LoadLocalisations()
            spbChargerDropDownList(leslocalisations, ComboBox1, "Loc_ID", "LibelleLocalisation")
            spbChargerDropDownList(leslocalisations, ComboBox1, "LibelleLocalisation", "LibelleLocalisation")
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
                    spvAfficherAcheteur()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub spvAfficherAcheteur()
        MonDA = New SqlClient.SqlDataAdapter("SELECT * FROM Acheteur WHERE CodeAcheteur=" & intAch, SaigicLocal_Cnx)
        MonDA.Fill(MonDataSet, "Acheteur")

        With MonDataSet.Tables("Acheteur")
            If .Rows.Count <> 0 Then
                TextBox1.Text = .Rows(0)("CodeAcheteur").ToString()
                TextBox2.Text = .Rows(0)("NomAcheteur").ToString()
                ComboBox1.SelectedValue = .Rows(0)("ZoneActivite").ToString()
                'TextBox2.Text = CDec(.Rows(0)("pem").ToString())
                'TextBox3.Text = CDec(.Rows(0)("IDemballage").ToString())
            Else

            End If
        End With
        'Dim tmpAcheteurs As New BObject.Acheteurs
        'tmpAcheteurs.LoadAcheteurs()
        'Acheteur = tmpAcheteurs.FindAcheteur(Cle)

        'With Acheteur
        '    TextBox1.Text = .Ach_ID

        '    TextBox2.Text = .Acheteur
        '    Try
        '        ComboBox1.SelectedValue = .Localisation
        '    Catch ex As Exception

        '    End Try

        'End With
    End Sub



    Private Sub cmdAjoMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnregistrer.Click

        'Dim TmpOBJ As New BObject.Acheteurs
        'TmpOBJ.LoadAcheteurs()
        Dim ppvSQL As String

        Try

            ' Valider les saisies du formulaire
            If ValideSaisies() = False Then
                Exit Sub
            End If

            Select Case intTypeOuverture
                'Case lstTypeOuverture.ModeAjouter   ' "Ajouter"
                '    TmpOBJ.AddBObjectAndBDataAcheteur(TextBox1.Text, TextBox2.Text, ComboBox1.SelectedValue)

                'Case lstTypeOuverture.ModeModifier  ' "Modifier"
                '    TmpOBJ.UpdateBOjectAndBDataAcheteur(TextBox1.Text, TextBox2.Text, ComboBox1.SelectedValue)

                Case lstTypeOuverture.ModeAjouter   ' "Ajouter"
                    MonDA = New SqlClient.SqlDataAdapter
                    ppvSQL = "INSERT INTO Acheteur (CodeAcheteur, NomAcheteur, ZoneActivite) VALUES ('" & _
                    TextBox1.Text.Replace("'", "'") & "','" & TextBox2.Text.Replace("'", "'") & "', '" & ComboBox1.SelectedValue.Replace("'", "'") & "')"
                    MonDA.InsertCommand = New SqlClient.SqlCommand(ppvSQL, SaigicLocal_Cnx)
                    MonDA.InsertCommand.ExecuteNonQuery()
                    Me.Close()
            End Select
            'TmpOBJ.UpdateAllBData()
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

        If Me.TextBox1.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TextBox1, "Veuillez saisir le code de l'acheteur.")
            Me.TextBox1.Focus()
            ValideSaisies = False
        End If

        If Me.TextBox2.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TextBox2, "Veuillez saisir le nom de l'Acheteur.")
            Me.TextBox2.Focus()
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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class