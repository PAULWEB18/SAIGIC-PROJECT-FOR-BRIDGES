Imports System.Windows.Forms
Imports System
Imports System.IO
' Vérifier l'existence d'un formulaire
Public Enum lstOptVerifSiFormOuverte
    Fermer
    Active
End Enum

Public Class MDISagic
    Public MonDashCacao As New FrmDashCacao
    Public MonDashCafe As New FrmDashCafe

    Dim MyDA As New SqlClient.SqlDataAdapter
    Dim MyDS As New DataSet
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Créez une nouvelle instance du formulaire enfant.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Configurez-la en tant qu'enfant de ce formulaire MDI avant de l'afficher.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Fenêtre " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: ajoutez le code ici pour ouvrir le fichier.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*" 

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: ajoutez le code ici pour enregistrer le contenu actuel du formulaire dans un fichier.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilisez My.Computer.Clipboard pour insérer les images ou le texte sélectionné dans le Presse-papiers
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilisez My.Computer.Clipboard pour insérer les images ou le texte sélectionné dans le Presse-papiers
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilisez My.Computer.Clipboard.GetText() ou My.Computer.Clipboard.GetData pour extraire les informations du Presse-papiers.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Fermez tous les formulaires enfants du parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub RibbonControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonControl1.Click
        Select Case RibbonControl1.SelectedPage.Name
            Case "RibPageCacao"
                ' Vérifier si le formulaire est ouvert et l'activer, autrement l'ouvrir
                If VerifSiFormOuverte("Pesées cacao", lstOptVerifSiFormOuverte.Active) = False Then
                    ' Ouvrir le formulaire
                    MonDashCafe.Hide()
                    MonDashCacao.MdiParent = Me
                    MonDashCacao.Show()
                End If

            Case "RibPageCafe"
                ' Vérifier si le formulaire est ouvert et l'activer, autrement l'ouvrir
                If VerifSiFormOuverte("Pesées café", lstOptVerifSiFormOuverte.Active) = False Then
                    ' Ouvrir le formulaire
                    MonDashCacao.Hide()

                    MonDashcafe.MdiParent = Me
                    MonDashcafe.Show()
                End If
        End Select
    End Sub

    Private Sub btnReception_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReceptionCacao.ItemClick
        Dim MaReception As New FrmReceptionCacao(lstTypeOuverture.ModePesee1)
        launchForm(MaReception, lstOpenOption.Dialog)
    End Sub



    Private Sub MDISagic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = ""
        ToolStripStatusLabel2.Text = ""
        'main()
        'Me.Visible = False
        'FrmLogin.ShowDialog()
        ToolStripStatusLabel1.Text = Moi.NomComplet & " | "
        ToolStripStatusLabel2.Text = "Site :" & MonSite.NomLong & " | Pont :" & MonPont.nomPont
        ActivationCommande()
        'FrmLogin.Close()
        'FrmLogin.Visible = False

        ChargerAlerte()
    End Sub
    Private Sub ActivationCommande()
        Select Case Moi.Profil
            Case "SUP"
                rpgAdmin.Visible = True
                RibbonParam.Visible = True
            Case "PES"
                rpgAdmin.Visible = False
                RibbonParam.Visible = False
                'ParamActeur.Visible = True
                'Paramètres.Visible = False
                Fournisseurs.Visible = False

        End Select
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim MaConfig As New FrmConfigurationConnexion(0)
        MaConfig.ShowDialog()
    End Sub

    Private Sub btnExpedition_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExpeditionCacao.ItemClick
        Dim MonExpedition As New FrmExpeditionCacao(lstTypeOuverture.ModePesee1)
        launchForm(MonExpedition, lstOpenOption.Dialog)
    End Sub

    Private Sub btnEmbarquement_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmbarquementCacao.ItemClick
        Dim MonEmbarquement As New FrmEmbarquementCacao(lstTypeOuverture.ModePesee1)
        launchForm(MonEmbarquement, lstOpenOption.Dialog)
    End Sub

    Private Sub BtnTransfert_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnTransfertCacao.ItemClick
        Dim MonTransfert As New FrmTransfertCacao(lstTypeOuverture.ModePesee1)
        launchForm(MonTransfert, lstOpenOption.Dialog)
    End Sub

    Private Sub btnSaisieLotUsine_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaisieLotUsineCacao.ItemClick
        Dim MaListeLots As New FrmLotsFabriquesCacaoListe(0)
        launchForm(MalisteLots, lstOpenOption.Dialog)
    End Sub

    Private Sub btnValidation_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidationPeseesCacao.ItemClick
        Dim MaValidation As New FrmValidationPeseesCacao
        launchForm(MaValidation, lstOpenOption.Dialog)
    End Sub

    Private Sub btnTransmission_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTransmissionPeseeCacao.ItemClick
        Dim MaTransmissionPesee As New FrmTransmissionPeseesCacao
        launchForm(MaTransmissionPesee, lstOpenOption.Dialog)
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTransmissionLotsFabriquesCacao.ItemClick
        Dim MaTransmissionFabrication As New FrmTransmissionLotFabriquesCacao
        launchForm(MaTransmissionFabrication, lstOpenOption.Dialog)
    End Sub

    Private Sub btnValidationLotFabriques_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidationLotFabriquesCacao.ItemClick
        Dim MaValidationLotFabriques As New FrmValidationLotFabriquesCacao
        launchForm(MaValidationLotFabriques, lstOpenOption.Dialog)
    End Sub

    Private Sub btnReceptionCafe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReceptionCafe.ItemClick
        Dim MaReceptionCafe As New FrmReceptionCafe(0)
        launchForm(MaReceptionCafe, lstOpenOption.Dialog)
    End Sub

    Private Sub btnTransfertCafe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTransfertCafe.ItemClick
        Dim MontransfertCafe As New FrmTransfertCafe(0)
        launchForm(MontransfertCafe, lstOpenOption.Dialog)
    End Sub

    Private Sub btnExpeditionCafe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExpeditionCafe.ItemClick
        Dim MonExpeditionCafe As New FrmExpeditionCafe(0)
        launchForm(MonExpeditionCafe, lstOpenOption.Dialog)
    End Sub

    Private Sub btnEmbarquementCafe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmbarquementCafe.ItemClick
        Dim MonEmbarquementCafe As New FrmEmbarquementCafe(0)
        launchForm(MonEmbarquementCafe, lstOpenOption.Dialog)
    End Sub

    Private Sub btnSaisieLotUsineCafe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaisieLotUsineCafe.ItemClick
        Dim MaListeLots As New FrmLotsFabriquesCafeListe(0)
        launchForm(MaListeLots, lstOpenOption.Dialog)
    End Sub

    Private Sub btnValidationPeseesCafe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidationPeseesCafe.ItemClick
        Dim MaValidationPeseeCafe As New FrmValidationPeseesCafe
        launchForm(MaValidationPeseeCafe, lstOpenOption.Dialog)
    End Sub

    Private Sub btnValidationLotFabriquesCafe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidationLotFabriquesCafe.ItemClick
        Dim MaValidationLotFabriqueCafe As New FrmValidationLotFabriquesCafe
        launchForm(MaValidationLotFabriqueCafe, lstOpenOption.Dialog)
    End Sub

    Private Sub btnTransmissionLotsFabriquesCafe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTransmissionLotsFabriquesCafe.ItemClick
        Dim MaTransmissionLotFabriqueCafe As New FrmTransmissionLotFabriquesCafe
        launchForm(MaTransmissionLotFabriqueCafe, lstOpenOption.Dialog)
    End Sub

    Private Sub btnTransmissionPeseeCafe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTransmissionPeseeCafe.ItemClick
        Dim MaTransmissionPeseeCafe As New FrmTransmissionPeseesCafe
        launchForm(MaTransmissionPeseeCafe, lstOpenOption.Dialog)
    End Sub

    Private Sub btnUtilisateurs_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUtilisateurs.ItemClick
        Dim MaListeUsers As New FrmUtilisateursListe(0)
        launchForm(MaListeUsers, lstOpenOption.Dialog)
    End Sub

    Private Sub btnDeconnexion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeconnexion.ItemClick
        Moi = New DCSaigicLight.BObject.Utilisateur
        'MonOuverture = Nothing

        MonSite = New DCSaigicLight.BObject.Site
        MonPont = New DCSaigicLight.BObject.Pont

        MDISagic_Load(Nothing, Nothing)
    End Sub

    Private Sub btnQuitter_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuitter.ItemClick
        End
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGWTransPeseeJob.DoWork
        Dim MaCommande As New SqlClient.SqlCommand

        Dim Nb As Integer

        Nb = spvNbPeseeNonTransmises()
        If Nb = 0 Then GoTo FIN
        Try
            SaigicLocal_Cnx.Open()
        Catch ex As Exception

        End Try
        Do

            MaCommande = New SqlClient.SqlCommand("TRANS_BLOC_PESEES_SITE_VERS_SERVEUR '" & LinkedSrvName & "','" & SaigicServerDB & "',10 ", SaigicLocal_Cnx)
            MaCommande.CommandTimeout = 3000
            Try
                MaCommande.ExecuteNonQuery()
            Catch ex As Exception

            End Try
            Nb = spvNbPeseeNonTransmises()
        Loop Until Nb = 0
        Try
            SaigicLocal_Cnx.Close()
        Catch ex As Exception

        End Try
        MaCommande.Dispose()
        MaCommande = Nothing
FIN:
    End Sub

    Private Sub btnBgTrans_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBgTrans.ItemClick

        'If Not BGWTransPeseeJob.IsBusy Then
        '    BGWTransPeseeJob.RunWorkerAsync()
        'End If

    End Sub

    Private Sub BGWTransJob_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGWTransPeseeJob.RunWorkerCompleted
        lblMessagePesee.Text = "Transmission de pesees complete"
        tmPesee.Enabled = True
        ppMessagePesee.Show()

        If Not BGWTransLotJob.IsBusy Then
            BGWTransLotJob.RunWorkerAsync()
        End If
    End Sub
    Private Function spvNbPeseeNonTransmises() As Integer
        Dim DAPesee As New SqlClient.SqlDataAdapter
        Dim DSPesee As DataSet
        DSPesee = Nothing
        DSPesee = New DataSet
        DAPesee = New SqlClient.SqlDataAdapter("Select CodePesee from Pesee where  TransfererAuServeur=0", SaigicLocal_Cnx)
        Try
            DAPesee.Fill(DSPesee, "P")
        Catch ex As Exception

        End Try

        spvNbPeseeNonTransmises = DSPesee.Tables("P").Rows.Count
        DAPesee.Dispose()
        DSPesee.Dispose()
        DAPesee = Nothing
        DSPesee = Nothing
    End Function

    Private Function spvNbLotNonTransmises() As Integer
        Dim DALot As New SqlClient.SqlDataAdapter("Select * from Fabrication where  TransfererAuServeur=0", SaigicLocal_Cnx)
        Dim DSLot As DataSet
        DSLot = Nothing
        DALot = New SqlClient.SqlDataAdapter("Select * from Fabrication where  TransfererAuServeur=0", SaigicLocal_Cnx)
        DSLot = New DataSet

        Try
            DALot.Fill(DSLot, "L")
        Catch ex As Exception

        End Try

        spvNbLotNonTransmises = DSLot.Tables("L").Rows.Count
        DALot.Dispose()
        DSLot.Dispose()
        DALot = Nothing
        DSLot = Nothing
    End Function

    Private Sub tmPesee_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmPesee.Tick
        ppMessagePesee.Hide()
        tmPesee.Enabled = False
    End Sub

    Private Sub BGWTransLotJob_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGWTransLotJob.DoWork
        Dim MaCommande As New SqlClient.SqlCommand

        Dim Nb As Integer

        Nb = spvNbLotNonTransmises()
        If Nb = 0 Then GoTo FIN

        Try
            SaigicLocal_Cnx.Open()
        Catch ex As Exception

        End Try

        Do

            MaCommande = New SqlClient.SqlCommand("TRANS_BLOC_LOTS_SITE_VERS_SERVEUR '" & LinkedSrvName & "','" & SaigicServerDB & "',10 ", SaigicLocal_Cnx)
            MaCommande.CommandTimeout = 3000
            Try
                MaCommande.ExecuteNonQuery()
            Catch ex As Exception

            End Try
            Nb = spvNbLotNonTransmises()
        Loop Until Nb = 0

        Try
            SaigicLocal_Cnx.Close()
        Catch ex As Exception

        End Try

        MaCommande.Dispose()
        MaCommande = Nothing
FIN:
    End Sub

    Private Sub BGWTransLotJob_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGWTransLotJob.RunWorkerCompleted
        lblMessageLot.Text = "Transmission des lots complete"
        tmLot.Enabled = True
        ppMessagelot.Show()
    End Sub

    Private Sub tmLot_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmLot.Tick
        ppMessagelot.Hide()
        tmLot.Enabled = False
    End Sub

    Private Sub btnPassWord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPassWord.ItemClick

        Try
            Dim FrmChangerMotPasse As New FrmChangerMotPasse()

            FrmChangerMotPasse.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Finally

        End Try
    End Sub

    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarEmballage.ItemClick
        Try

            Dim FrmEmballageListe As New FrmEmballageListe(FrmEmballageListe.lstTypeOuverture.AjouterModifier)

            FrmEmballageListe.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Finally

        End Try

    End Sub

    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Try
            Dim FrmSites As New FrmSites(FrmSites.lstTypeOuverture.ModeAjouter)

            FrmSites.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Finally

        End Try
    End Sub

    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        'Try
        '    Dim FrmSites As New FrmPonts(FrmPonts.lstTypeOuverture.ModeAjouter)

        '    FrmSites.ShowDialog()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        'Finally

        'End Try
        Try
            Dim FrmSites As New FrmPontsListe(FrmPontsListe.lstTypeOuverture.AjouterModifier)

            FrmSites.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Finally

        End Try

    End Sub

    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCooperatives.ItemClick
        Try

            Dim FrmCooperative As New FrmCooperativesListe(FrmCooperativesListe.lstTypeOuverture.AjouterModifier)

            FrmCooperative.ShowDialog()
            'Dim FrmCooperative As New FrmCooperativesListe(0)
            'launchForm(FrmCooperative, lstOpenOption.Dialog)

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Finally

        End Try
    End Sub

    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarExportateur.ItemClick
        Try

            Dim FrmExportateur As New FrmExportateursListe(FrmExportateursListe.lstTypeOuverture.AjouterModifier)

            FrmExportateur.ShowDialog()
            'Dim FrmCooperative As New FrmCooperativesListe(0)
            'launchForm(FrmCooperative, lstOpenOption.Dialog)

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Finally

        End Try
    End Sub

    Private Sub BarAcheteurs_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarAcheteurs.ItemClick

        Dim FrmAcheteur As New FrmAcheteursListe(FrmAcheteursListe.lstTypeOuverture.AjouterModifier)

        FrmAcheteur.ShowDialog()
    End Sub

    Private Sub rpgUserTools_CaptionButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs) Handles rpgUserTools.CaptionButtonClick

    End Sub

    Private Sub BarButtonItem15_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Dim MaCommande As New SqlClient.SqlCommand

        'Dim Idx As Integer
        Dim tmpResponse As Integer
        Me.Cursor = Cursors.WaitCursor

        Try

            'Vider Tampon Pesee

            MaCommande = New SqlClient.SqlCommand("vider_tampon ", SaigicLocal_Cnx)
            MaCommande.CommandTimeout = 1200
            tmpResponse = MaCommande.ExecuteNonQuery

            'Pesee Tampon Local

            MaCommande = New SqlClient.SqlCommand("PS_VERS_TAMPON_LOCAL ", SaigicLocal_Cnx)
            MaCommande.CommandTimeout = 1200
            tmpResponse = MaCommande.ExecuteNonQuery

            If tmpResponse > 0 Then
                'MsgBox("Pesee Tampon Chargee #")
            Else
                MsgBox("Erreur Pesee Tampon Chargee #")
                'Exit For
            End If

            'Pesee Tampon Local vers Tampon Serveur

            MaCommande = New SqlClient.SqlCommand("PS_VERS_TAMPON_LOCAL_VERS_TAMPON_SERVEUR " & "','SERVEUR_CCC','SAIGICSVRDB' ", SaigicLocal_Cnx)
            MaCommande.CommandTimeout = 1200
            tmpResponse = MaCommande.ExecuteNonQuery

            If tmpResponse > 0 Then
                MsgBox("Pesees Transmises")
            Else
                MsgBox("Erreur!!! Transmission Pesees #")
                'Exit For
            End If
            'End If

            'Next Idx
            MsgBox("... Fin de la transmission!!!")
            'spbChargerListe()
        Catch ex As Exception
            MsgBox("Erreur de transmission !!!")
        Finally
            'frmSynchroPesee_Load(Nothing, Nothing)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MDISagic_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        '' Retrieve the working rectangle from the Screen class using the PrimaryScreen and the WorkingArea properties. 
        'Dim RedimForm As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
        'Try
        '    ' Set the size of the form slightly less than size of working rectangle.
        '    Me.Size = New System.Drawing.Size(RedimForm.Width, RedimForm.Height)

        '    ' Set the location so the entire form is visible.
        '    Me.Location = New System.Drawing.Point(0, 0)
        'Catch ex As Exception
        '    MessageBox.Show("Une exception du type '" + ex.GetType().ToString() _
        '    + "' a été générée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick

        'Dim tmp As String = UCase(cboCodeFournisseur.Text)
        'Dim tmp2 As String = UCase(cboNomFournisseur.Text)
        Dim strsql As String = ""
        Dim tmpResponse As Integer = 0
        Dim MaCommande As New SqlClient.SqlCommand

        Try
            '' Me.Cursor = Cursors.WaitCursor
            'DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))

            'appel de la fonction de connectivité
            If IsConnectionAvailable() = True Then
                MaCommande = New SqlClient.SqlCommand("vider_LesTables_Fournisseur ", SaigicLocal_Cnx)
                MaCommande.CommandTimeout = 1200
                tmpResponse = MaCommande.ExecuteNonQuery

                ' Me.Cursor = Cursors.WaitCursor
                DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))


                MaCommande = New SqlClient.SqlCommand("UPDATE_SERVEUR_VERS_SITE ", SaigicLocal_Cnx)
                MaCommande.CommandTimeout = 1200
                tmpResponse = MaCommande.ExecuteNonQuery
            Else
                tmpResponse = 0

            End If
           
           
        Catch ex As Exception

        End Try

        If tmpResponse <> 0 Then
            MsgBox("Mise à jour terminée", vbInformation)
            'spvChargerFournisseur()
            'cboCodeFournisseur.Focus()
        Else
            MessageBox.Show("Probleme de connexion Internet, Réessayer plus tard")
        End If

        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
    End Sub

    'Test de  connectivité Internet, fonction de variable vrai ou faux
    Public Function IsConnectionAvailable() As Boolean
        Dim Tmp2, tmp3 As String
        Dim lignes As String() = File.ReadAllLines(Application.StartupPath & "\Server")

        Tmp2 = lignes(2)
        'tmp3 = lignes(1)


        Dim objUrl As New System.Uri(Tmp2)
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objresp As System.Net.WebResponse

        Try
            objresp = objWebReq.GetResponse
            objresp.Close()
            objresp = Nothing
            Return True

        Catch ex As Exception
            objresp = Nothing
            objWebReq = Nothing
            Return False
        End Try
    End Function

    Private Sub ChargerAlerte()
        Dim tmpResponse As Integer = 0
        Dim MaCommande As New SqlClient.SqlCommand

        Try
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm3))

            MaCommande = New SqlClient.SqlCommand("CHARGER_ALERTES", SaigicLocal_Cnx)
            MaCommande.CommandTimeout = 1200
            tmpResponse = MaCommande.ExecuteNonQuery
        Catch ex As Exception

        End Try

        If tmpResponse <> 0 Then
            MessageBox.Show("ALERTES chargées avec succès")
        Else
            MsgBox("Erreur de connection!, Reconnectez-vous", vbInformation, "CHARGEMENT DES ALERTES")
   
        End if

        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()

    End Sub


End Class
