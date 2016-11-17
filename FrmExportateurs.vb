'A_VOIR_1: En mode ajouter, permettre d'ouvrir le formulaire répertoire afin d'effectuer une sélection
Imports DCSaigicLight
Imports System.Data
Imports System.Data.SqlClient
Public Class FrmExportateurs

#Region "Zone de réflexion "

    Dim frmParente As FrmExportateursListe
    Public WriteOnly Property Parente() As FrmExportateursListe
        Set(ByVal value As FrmExportateursListe)
            frmParente = value
        End Set
    End Property

#End Region

#Region "Déclaration des variables "
    Dim leslocalisations As New BObject.Localisations
    Dim MonDA As SqlClient.SqlDataAdapter
    Dim MonDataSet As New DataSet

    Private IntIDExport As String
    Private Cle As String

    Private strIDExp As String
    Private intTypeOuverture As Integer
    Dim MonExportateur As BObject.Exportateur


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

    Public Sub New(ByVal TypeOuverture As lstTypeOuverture, Optional ByVal bvlIDExp As String = "")

        MyBase.New()
        InitializeComponent()

        intTypeOuverture = TypeOuverture
        strIDExp = bvlIDExp

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
            'spvChargerCombo()
            leslocalisations.LoadLocalisations()
            spbChargerDropDownList(leslocalisations, ComboBox2, "Loc_ID", "LibelleLocalisation")
            spbChargerDropDownList(leslocalisations, ComboBox2, "LibelleLocalisation", "LibelleLocalisation")

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
                    spvAfficherExportateur()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub


    Private Sub spvChargerCombo()


        ''Localites
        'ComboBox2.Tag = "OQP"
        'MonDA = New SqlClient.SqlDataAdapter("SELECT * FROM localisation order by Loc_ID ASC", SaigicLocal_Cnx)

        'MonDA.Fill(MonDataSet, "Localisation")
        'ComboBox2.DataSource = MonDataSet.Tables("Localisation")
        'ComboBox2.ValueMember = "LabelLocalisation"
        'ComboBox2.DisplayMember = "LabelLocalisation"
        'ComboBox2.Tag = ""
        'ComboBox2.SelectedItem = Nothing
        'ComboBox2.Tag = ""
    End Sub

    Private Sub spvAfficherExportateur()

        Dim lesexportateurs As New BObject.Exportateurs
        lesexportateurs.LoadExportateurs()

        MonDA = New SqlClient.SqlDataAdapter("SELECT * FROM Exportateur WHERE Id_EXP=" & IntIDExport, SaigicLocal_Cnx)
        MonDA.Fill(MonDataSet, "Exportateur")

        With MonDataSet.Tables("Exportateur")
            If .Rows.Count <> 0 Then
                TextBox1.Text = .Rows(0)("Id_EXP").ToString()
                TextBox2.Text = .Rows(0)("Exportateur").ToString()
                CheckBox1.Checked = .Rows(0)("Transitaire").ToString()
                TextBox3.Text = .Rows(0)("Nom").ToString()
                ComboBox2.SelectedValue = .Rows(0)("Localisation").ToString()

                'MonExportateur = lesexportateurs.FindExportateur(strIDExp)
            End If
        End With
    End Sub

    Private Sub cmdAjoMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnregistrer.Click

        Dim ppvSQL As String
        Dim TmpOBJ As New BObject.Exportateurs
        TmpOBJ.LoadExportateurs()

        Try

            ' Valider les saisies du formulaire
            If ValideSaisies() = False Then
                Exit Sub
            End If

            Select Case intTypeOuverture
                Case lstTypeOuverture.ModeAjouter   ' "Ajouter"
                    MonDA = New SqlClient.SqlDataAdapter
                    ppvSQL = "INSERT INTO Exportateur (ID_EXP, Exportateur, Nom, Localisation) VALUES ('" & _
                    TextBox1.Text.Replace("'", "''") & "','" & TextBox2.Text.Replace("'", "''") & "','" & TextBox3.Text.Replace("'", "''") & "', '" & ComboBox2.SelectedValue.Replace("'", "''") & "')"
                    MonDA.InsertCommand = New SqlClient.SqlCommand(ppvSQL, SaigicLocal_Cnx)
                    MonDA.InsertCommand.ExecuteNonQuery()
                    Me.Close()

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


        If Me.TextBox1.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TextBox1, "Veuillez saisir le code du exportateur.")
            Me.TextBox1.Focus()
            ValideSaisies = False
        End If


        If Me.TextBox2.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TextBox2, "Veuillez saisir le code du exportateur.")
            Me.TextBox2.Focus()
            ValideSaisies = False
        End If

        If Me.TextBox3.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TextBox3, "Veuillez saisir le nom de l'exportateur.")
            Me.TextBox3.Focus()
            ValideSaisies = False
        End If


    End Function

    Private Sub cmdFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFermer.Click
        ' Fermer le formulaire
        Me.Close()

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        'Dim Permis As String = "0123456789." & Chr(8) & Chr(13)
        'If InStr(Permis, e.KeyChar) = 0 Then
        '    e.KeyChar = ""
        'End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If CheckBox1.Checked Then
        '    TextBox1.Text = "XXXXX"
        '    TextBox1.ReadOnly = True
        'Else
        '    TextBox1.ReadOnly = False
        'End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

End Class