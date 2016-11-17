Imports System
Imports System.Data.SqlClient

Public Class FrmEmballageListe
    Dim MonDA As SqlClient.SqlDataAdapter
    Dim MonDataSet As New DataSet

#Region "Déclaration des variables "
    'Private clRecherche As New ClasseRecherche
    Private intTypeOuverture As Integer
    Private mpvFiltre As String

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

    Public Sub New(ByVal TypeOuverture As lstTypeOuverture, Optional ByVal bvlFiltre As String = "")
        MyBase.New()
        InitializeComponent()
        intTypeOuverture = TypeOuverture
        mpvFiltre = bvlFiltre
    End Sub

    Public Enum lstTypeCptEnreg
        SansRecherche
        AvecRecherche
    End Enum

    Private Sub CptEnreg(ByVal TypeEnreg As lstTypeCptEnreg)

        'Dim intCptEnreg As String
        'intCptEnreg = Me.dgvLstBase.RowCount

        'If intCptEnreg = 0 Then
        '    Me.ToolStripStatusLblStatistique.Text = "Aucun Typelogement enregistré."
        '    Exit Sub
        'End If
    End Sub

    Private Sub FrmTypelogementListe_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        spbChargerGrille()
    End Sub

    Private Sub FrmTypelogementListe_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.MonDA = Nothing
        Me.MonDataSet = Nothing
    End Sub


    Private Sub FrmTypelogementListe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "Liste des emballages"
        '' Paramètrer le formulaire suivant le type d'ouverture
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


    Public Sub spbChargerGrille()
        Dim ppvSQL As String = ""
        Try
            MonDataSet.Tables("Emballage").Clear()
        Catch

        End Try

        If mpvFiltre = "" Then
            ppvSQL = "SELECT * FROM Emballages"
        Else
            'ppvSQL = "SELECT * FROM VueTypelogement1 WHERE CodeTypelogement like '%" & mpvFiltre & "%' ORDER BY NomTypelogement"
        End If

        MonDA = New SqlClient.SqlDataAdapter(ppvSQL, SaigicLocal_Cnx)
        MonDA.Fill(MonDataSet, "Emballage")

        With DataGridView1
            .Visible = False
            .AutoGenerateColumns = True
            .ReadOnly = True
            .DataSource = MonDataSet
            .DataMember = "Emballage"
            .Visible = True
            .Refresh()
        End With
    End Sub


    Private Sub btFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Fermer
        Me.Close()
    End Sub

    Private Sub btAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAjouter.Click
        Try

            Dim frmAjouter As New FrmEmballage(FrmEmballage.lstTypeOuverture.ModeAjouter)
            frmAjouter.Parente = Me
            frmAjouter.ShowDialog()
            spbChargerGrille()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Finally

        End Try
    End Sub


    Private Sub btModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModifier.Click, DataGridView1.DoubleClick
        Dim ppvIDEmb As Integer = 0
        Dim ppvIdxLigne As Integer
        If DataGridView1.Rows.Count = 0 Then Exit Sub
        Try
            ppvIdxLigne = DataGridView1.SelectedRows(0).Index
        Catch
            ppvIdxLigne = DataGridView1.SelectedCells(0).RowIndex
        End Try

        ppvIDEmb = DataGridView1.Item(0, ppvIdxLigne).Value()

        Dim frmAjouter As New FrmEmballage(FrmEmballage.lstTypeOuverture.ModeModifier, ppvIDEmb)
        frmAjouter.Parente = Me
        frmAjouter.ShowDialog()

        spbChargerGrille()

    End Sub


    Private Sub btFermer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFermer.Click
        Me.Close()
    End Sub

    Private Sub btSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSupprimer.Click
        Dim ppvIDEmballage As String = 0
        Dim ppvIdxLigne As Integer
        Dim ppvSQL As String
        Dim MyCommand2 As New SqlCommand
        Dim Tmp1 As Integer
        Try
            ppvIdxLigne = DataGridView1.SelectedRows(0).Index
        Catch
            ppvIdxLigne = DataGridView1.SelectedCells(0).RowIndex
        End Try

        ppvIDEmballage = DataGridView1.Item(0, ppvIdxLigne).Value()

        Try
            If MsgBox("Etes-vous sur de vouloir supprimer cet enregistrement?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ppvSQL = "DELETE FROM  Emballages WHERE IDEmballage=" & ppvIDEmballage

                'strSQL = "DELETE  FROM PoidsRecup "
                MyCommand2.CommandText = ppvSQL
                MyCommand2.Connection = SaigicLocal_Cnx
                Tmp1 = myCommand2.ExecuteNonQuery()

                'MonDA.DeleteCommand = SqlClient.SqlCommand(ppvSQL, SaigicLocal_Cnx)
                'MonDA.DeleteCommand.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            spbChargerGrille()
        End Try
    End Sub

    Private Sub btFiltre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFiltre.Click
        ' Afficher / Masquer la zone de recherche
        'If SplitContainer1.Panel1Collapsed = True Then
        '    SplitContainer1.Panel1Collapsed = False
        'Else
        '    SplitContainer1.Panel1Collapsed = True
        'End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        mpvFiltre = ""
        TextBox1.Text = ""
        spbChargerGrille()
    End Sub

    Private Sub Textbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        mpvFiltre = TextBox1.Text
        spbChargerGrille()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim monEtat As New EtatTypelogements
        'Dim MyDS As New DataSet
        'Dim MyView As New FrmVisionneuse


        'Me.Cursor = Cursors.WaitCursor
        ''Try
        'monEtat.Refresh() 'vider l'objet du CrystalReport..remarque..cry est déclarer dans le module par ce que je vais l'utiliser dans la form1
        ''monEtat.SetParameterValue("CodeEtablissement", ComboBox1.SelectedValue)
        ''monEtat.SetParameterValue("Periode", DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-01")


        'MyView.CrystalReportViewer1.ReportSource = monEtat
        'MyView.Text = monEtat.Name
        'Me.Cursor = Cursors.Default
        'MyView.ShowDialog()

        ''Catch ex As Exception
        ''    MsgBox(ex.Message)
        ''End Try
    End Sub
End Class