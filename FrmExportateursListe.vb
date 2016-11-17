Imports DCSaigicLight
Imports System.Data
Imports System.Data.SqlClient

Public Class FrmExportateursListe

    Dim MonDA As SqlClient.SqlDataAdapter
    Dim MonDataSet As New DataSet
#Region "Déclaration des variables "
    'Private clRecherche As New ClasseRecherche
    Private intTypeOuverture As Integer
    Private mpvFiltre As Integer
    Dim LesExportateurs As New BObject.Exportateurs

    Public Enum lstTypeOuverture
        AjouterModifier
        SelectionDans
    End Enum
#End Region

#Region "Liaison inter-formulaire"

    ' Formulaire Installation
    'Dim frmParenteInstallation As frmInstallationVehiculeAjout
    'Public WriteOnly Property ParenteInstallation() As frmInstallationVehiculeAjout
    '    Set(ByVal value As frmInstallationVehiculeAjout)
    '        frmParenteInstallation = value
    '    End Set
    'End Property


#End Region

    Public Sub New(ByVal TypeOuverture As lstTypeOuverture, Optional ByVal bvlFiltre As Integer = 0)
        MyBase.New()
        InitializeComponent()
        intTypeOuverture = TypeOuverture
        mpvFiltre = bvlFiltre
    End Sub

    Public Enum lstTypeCptEnreg
        SansRecherche
        AvecRecherche
    End Enum
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FrmFournisseurListe_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub FrmFournisseurListe_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick

    End Sub

    Private Sub FrmFournisseurListe_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub FrmFournisseurListe_HelpButtonClicked(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked

    End Sub

    Private Sub FrmFournisseurListe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Liste des exportateurs"
        'Me.WindowState = FormWindowState.Maximized
        '' Paramètrer le formulaire suivant le type d'ouverture
        InitialiseGrille()
        spbChargerGrille()
        Select Case intTypeOuverture

            Case lstTypeOuverture.AjouterModifier

            Case lstTypeOuverture.SelectionDans
                ' Masquer les boutons Ajouter, Modifier, Supprimer, Imprimer, Aperçu, et le séparateur
                'Me.btAjouter.Visible = False
                'Me.btModifier.Visible = False
                'Me.btSupprimer.Visible = False
                'Me.ToolStripSeparator2.Visible = False
        End Select
        SplitContainer1.Panel1Collapsed = True
    End Sub

    Public Sub InitialiseGrille()
        'Liste des Préjudices
        With Me.DataGridView1
            .Rows.Clear()
            '.ColumnCount = 6
            '.Columns(0).Name = "ID"
            '.Columns(1).Name = "Nom Long"
            '.Columns(2).Name = "Nom Court"
            '.Columns(3).Name = "Localité"
            '.Columns(4).Name = "Agrément"
            '.Columns(5).Name = "Gérant"
        End With
    End Sub

    Public Sub spbChargerGrille()
        Dim ppvSQL As String = ""
        Try
            MonDataSet.Tables("Exportateur").Clear()
        Catch

        End Try

        ppvSQL = "SELECT * FROM Exportateur"

        MonDA = New SqlClient.SqlDataAdapter(ppvSQL, SaigicLocal_Cnx)
        MonDA.Fill(MonDataSet, "Exportateur")

        Me.btSupprimer.Visible = False
        Me.btModifier.Visible = False

        With DataGridView1
            .Visible = False
            .AutoGenerateColumns = True
            .ReadOnly = True
            .DataSource = MonDataSet
            .DataMember = "Exportateur"
            .Visible = True
            .Refresh()
        End With
       
    End Sub

    Private Sub btAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAjouter.Click
        Try

            Dim frmAjouter As New FrmExportateurs(FrmExportateurs.lstTypeOuverture.ModeAjouter)

            frmAjouter.Parente = Me
            frmAjouter.ShowDialog()
            spbChargerGrille()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Finally

        End Try
    End Sub

    Private Sub btModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModifier.Click, DataGridView1.DoubleClick
        Dim ppvIDExp As String = 0
        Dim ppvIdxLigne As Integer
        If DataGridView1.Rows.Count = 0 Then Exit Sub
        Try
            ppvIdxLigne = DataGridView1.SelectedRows(0).Index
        Catch
            ppvIdxLigne = DataGridView1.SelectedCells(0).RowIndex
        End Try

        ppvIDExp = DataGridView1.Item(0, ppvIdxLigne).Value()

        Dim frmModifier As New FrmExportateurs(FrmExportateurs.lstTypeOuverture.ModeModifier, ppvIDExp)

        frmModifier.ShowDialog()

        spbChargerGrille()
    End Sub

    Private Sub btFiltre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFiltre.Click
        ' Afficher / Masquer la zone de recherche
        If SplitContainer1.Panel1Collapsed = True Then
            SplitContainer1.Panel1Collapsed = False
        Else
            SplitContainer1.Panel1Collapsed = True
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        mpvFiltre = 0
        TextBox1.Text = ""
        TextBox2.Text = ""

        'spbChargerGrille()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged
        mpvFiltre = 1
        'spbChargerGrille()
    End Sub

    Private Sub btFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFermer.Click
        Me.Close()
    End Sub

    Private Sub btSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSupprimer.Click
        Dim ppvID As Integer = 0
        Dim ppvIdxLigne As Integer

        Try
            ppvIdxLigne = DataGridView1.SelectedRows(0).Index
        Catch
            ppvIdxLigne = DataGridView1.SelectedCells(0).RowIndex
        End Try

        ppvID = DataGridView1.Item(0, ppvIdxLigne).Value()

        Try
            If MsgBox("Etes-vous sur de vouloir supprimer cet enregistrement?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                LesExportateurs.DeleteBObjectAndBDataExportateur(ppvID)
                LesExportateurs.UpdateAllBData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            spbChargerGrille()
        End Try
    End Sub
End Class