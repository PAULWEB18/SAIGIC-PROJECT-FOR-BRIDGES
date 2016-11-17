'A_VOIR_1: En mode ajouter, permettre d'ouvrir le formulaire répertoire afin d'effectuer une sélection
Imports DCSaigicLight
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Windows.Forms

Public Class FrmPonts

#Region "Zone de réflexion "

    Dim frmParente As FrmPontsListe
    Public WriteOnly Property Parente() As FrmPontsListe
        Set(ByVal value As FrmPontsListe)
            frmParente = value
        End Set
    End Property

#End Region

#Region "Déclaration des variables "
    Dim MonDA As SqlClient.SqlDataAdapter
    Dim MonDataSet As New DataSet

    Dim lessites As New BObject.Sites

    Dim Pont As New BObject.Pont

    Private Cle As String
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

    Public Sub New(ByVal TypeOuverture As lstTypeOuverture, Optional ByVal bvlCodePont As String = "")

        MyBase.New()
        InitializeComponent()

        intTypeOuverture = TypeOuverture
        Cle = bvlCodePont

    End Sub

#Region "Contrôle des saisies de l'Pont "

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
            lessites.LoadSites()
            spbChargerDropDownList(lessites, ComboBox1, "IDSite", "NomLong")

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
                    spvAfficherPont()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub




    Private Sub spvAfficherPont()
        Dim tmpPonts As New BObject.Ponts
        tmpPonts.LoadPonts()
        Pont = tmpPonts.FindPont(Cle)

        With Pont
            TextBox1.Text = .CodePont
            TextBox3.Text = .nomPont
            ComboBox1.SelectedValue = .Site
            ComboBox2.SelectedIndex = ComboBox2.FindString(.Typepont)
            'TextBox4.Text = .ODBCDSN
        End With
    End Sub



    Private Sub cmdAjoMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnregistrer.Click

        'Dim TmpOBJ As New BObject.Ponts
        'TmpOBJ.LoadPonts()
        Dim cmd As SqlCommand
        Try

            ' Valider les saisies du formulaire
            If ValideSaisies() = False Then
                Exit Sub
            End If
            Me.Hide()
            'Dim sql = "SELECT * FROM `Site` WHERE NomUt='" & TextBox1.Text & "' AND motpasse='" & TextBox2.Text & "'"
            'Dim sql = "update Site set idsite='"   ,NomLong ='" & TextBox2.Text & "',NomCourt='" & TextBox3.Text & "'"
            Dim sql = "insert into  Pont (CodePont ,Site ,nomPont,Typepont) values ('" & TextBox1.Text & "','" & ComboBox1.SelectedValue & "','" & TextBox3.Text & "','" & ComboBox2.Text & "')"

            Debug.Print(sql)
            cmd = New SqlClient.SqlCommand(sql, SaigicLocal_Cnx)
            'Dim dr As SqlClient.SqlDataReader = cmd.ExecuteReader
            ' MonDA = New SqlClient.SqlDataAdapter(cmd)
            cmd.ExecuteNonQuery()
            MsgBox("Pont mis à jour")

            'ajout du code pont
            'Dim mycommand As New SqlCommand
            'sql = "update  Parametres  set CodePont='" & TextBox1.Text & "'"
            '    Debug.Print(sql)
            'mycommand.Connection = SaigicLocal_Cnx
            'mycommand.CommandText = sql
            ''Dim drsql As SqlClient.SqlDataReader = cmd.ExecuteReader
            ''MonDA = New SqlClient.SqlDataAdapter(cmd)

            'mycommand.ExecuteNonQuery()
            'MsgBox("Parametres CodePont mis à jour")

            'Select Case intTypeOuverture
            '    Case lstTypeOuverture.ModeAjouter   ' "Ajouter"

            '        TmpOBJ.AddBObjectAndBDataPont(TextBox1.Text, ComboBox1.SelectedValue, TextBox3.Text, ComboBox2.Text, TextBox4.Text)

            '    Case lstTypeOuverture.ModeModifier  ' "Modifier"
            '        TmpOBJ.UpdateBOjectAndBDataPont(TextBox1.Text, ComboBox1.SelectedValue, TextBox3.Text, ComboBox2.Text, TextBox4.Text)
            'End Select
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
            Me.ErrorProvider1.SetError(Me.TextBox1, "Veuillez saisir le code du Pont.")
            Me.TextBox1.Focus()
            ValideSaisies = False
        End If

        If Me.TextBox3.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TextBox3, "Veuillez saisir le nom du Pont.")
            Me.TextBox3.Focus()
            ValideSaisies = False
        End If

        If IsNothing(Me.ComboBox1.SelectedValue) Then
            Me.ErrorProvider1.SetError(Me.ComboBox1, "Veuillez sélectionner le site.")
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mycommand As New SqlCommand
        Dim MonDA As New SqlClient.SqlDataAdapter
        Dim MonDS As DataSet
        Dim sql = "update Pont set CodePont= '" & TextBox1.Text & "',Site= '" & ComboBox1.SelectedValue & "',nomPont= '" & TextBox3.Text & "',Typepont= '" & ComboBox2.Text & "' "

        'Dim cmd As SqlCommand

        Debug.Print(Sql)
        'cmd = New SqlClient.SqlCommand(sql, SaigicLocal_Cnx)
        'cmd.ExecuteNonQuery()
        'mycommand.Connection = SaigicLocal_Cnx
        'mycommand.CommandText = sql
        MonDA = New SqlClient.SqlDataAdapter(sql, SaigicLocal_Cnx)
        'mycommand.ExecuteNonQuery()

        MonDS = Nothing
        MonDS = New DataSet
        MonDA.Fill(MonDS, "Pont")
        With DataGridView1
            .DataSource = Nothing
            .Rows.Clear()

            .AutoGenerateColumns = True
            .ReadOnly = True
            .DataSource = MonDS
            .DataMember = "Pont"

            .Refresh()
        End With
        MsgBox("Pont ajouté")

        sql = "update  Parametres  set CodePont='" & TextBox1.Text & "'"
        Debug.Print(sql)
        mycommand.Connection = SaigicLocal_Cnx
        mycommand.CommandText = sql

        mycommand.ExecuteNonQuery()
        MsgBox("Parametres CodePont mis à jour")
        Me.Close()

        'Dim MonDA As OleDb.OleDbDataAdapter
        'Dim MonDS As DataSet
        'Dim Mystr As String

        'Mystr = "SELECT CodePesee, DateP1, Immatriculation as Vehicule,poids1 FROM Pesee WHERE poids2=0 and codePont='" & MonPont.CodePont & "' order by CodePesee DESC"
        'MonDA = New OleDb.OleDbDataAdapter(Mystr, SAIGIC_Cnx)

        'MonDS = Nothing
        'MonDS = New DataSet

        'MonDA.Fill(MonDS, "AttenteP2")

        'With DataGridView3
        '    .DataSource = Nothing
        '    .Rows.Clear()

        '    .AutoGenerateColumns = True
        '    .ReadOnly = True
        '    .DataSource = MonDS
        '    .DataMember = "AttenteP2"

        '    .Refresh()
        'End With
    End Sub
End Class