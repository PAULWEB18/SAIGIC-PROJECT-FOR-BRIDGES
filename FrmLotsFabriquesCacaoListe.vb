Imports DCSaigicLight
Public Class FrmLotsFabriquesCacaoListe

    Dim MonDA As New SqlClient.SqlDataAdapter
    Dim MonDS As New DataSet

#Region "Déclaration des variables "
    'Private clRecherche As New ClasseRecherche
    Private intTypeOuverture As Integer
    Private mpvFiltre As Integer

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
        Me.Text = "Liste des lots fabriques"
        'Me.WindowState = FormWindowState.Maximized
        '' Paramètrer le formulaire suivant le type d'ouverture
        'Me.SplitContainer1.Panel1Collapsed = True
        mskDateFabrication.Text = Now.Date.ToShortDateString
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

    End Sub


    Public Sub spbChargerGrille()
        Dim Jour As String = ""
        Dim Mois As String = ""
        Dim Annee As String = ""

        If Not IsDate(mskDateFabrication.Text) Then Exit Sub

        Try
            Jour = Format(CDate(mskDateFabrication.Text).Day, "00")
        Catch ex As Exception

        End Try

        Try
            Mois = Format(CDate(mskDateFabrication.Text).Month, "00")
        Catch ex As Exception

        End Try

        Try
            Annee = Format(CDate(mskDateFabrication.Text).Year, "0000")
        Catch ex As Exception

        End Try

        Dim ppvSQL As String = "Select * from Fabrication where CodeFabrication Like '%_" & Annee & Mois & Jour & "' and Produit Like 'CACAO%'"
        Try
            MonDS.Tables("Fabrication").Clear()
        Catch

        End Try


        MonDA = New SqlClient.SqlDataAdapter(ppvSQL, SaigicLocal_Cnx)
        MonDA.Fill(MonDS, "Fabrication")

        With dgvListeFabrication
            .Visible = False
            .AutoGenerateColumns = False
            .ReadOnly = True
            .DataSource = MonDS
            .DataMember = "Fabrication"
            .Visible = True
            .Refresh()
        End With
    End Sub

    Private Sub btAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAjouter.Click
        Try

            Dim frmAjouter As New FrmLotsFabriquesCacao(0)

            frmAjouter.ShowDialog()
            spbChargerGrille()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Finally

        End Try
    End Sub

    Private Sub btModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModifier.Click, dgvListeFabrication.DoubleClick
        Dim ppvID As String = 0
        Dim ppvIdxLigne As Integer
        Dim StrCodeFabrication As String = ""
        If dgvListeFabrication.Rows.Count = 0 Then Exit Sub
        Try
            ppvIdxLigne = dgvListeFabrication.SelectedRows(0).Index
        Catch
            ppvIdxLigne = dgvListeFabrication.SelectedCells(0).RowIndex
        End Try

        ppvID = dgvListeFabrication.Item(1, ppvIdxLigne).Value()
        StrCodeFabrication = dgvListeFabrication.Item(0, ppvIdxLigne).Value()

        Dim frmModifier As New FrmLotsFabriquesCacao(FrmLotsFabriquesCacao.lstTypeOuvertureFiche.ModeModifier, StrCodeFabrication, ppvID)

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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mpvFiltre = 0
        'TextBox1.Text = ""
        'TextBox2.Text = ""

        spbChargerGrille()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mpvFiltre = 1
        spbChargerGrille()
    End Sub

    Private Sub btFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFermer.Click
        Me.Close()
    End Sub

    Private Sub btSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSupprimer.Click
        Dim ppvID As Integer = 0
        Dim ppvIdxLigne As Integer
        Dim StrCodeFabrication As String = ""
        Dim tmpOBJ As New DCSaigicLight.BObject.Fabrications

        If dgvListeFabrication.Item("CodeFabrication", ppvIdxLigne).Value() = 1 Then
            MsgBox("Impossible de supprimer une enregistrement valide")
            Exit Sub
        End If

        Try
            ppvIdxLigne = dgvListeFabrication.SelectedRows(0).Index
        Catch
            ppvIdxLigne = dgvListeFabrication.SelectedCells(0).RowIndex
        End Try

        ppvID = dgvListeFabrication.Item(1, ppvIdxLigne).Value()
        StrCodeFabrication = dgvListeFabrication.Item(0, ppvIdxLigne).Value()

        Try
            If MsgBox("Etes-vous sur de vouloir supprimer cet enregistrement?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                tmpOBJ.LoadFabrications()
                tmpOBJ.DeleteBObjectAndBDataFabrication(ppvID, StrCodeFabrication)
                tmpOBJ.UpdateAllBData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            spbChargerGrille()
        End Try
    End Sub


    Private Sub mskDateFabrication_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskDateFabrication.MaskInputRejected

    End Sub

    Private Sub btnAfficher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfficher.Click
        spbChargerGrille()
    End Sub

    Private Sub dgvListeFabrication_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListeFabrication.CellContentClick

    End Sub
End Class