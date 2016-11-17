Imports DCSaigicLight
Public Class FrmDashCacao
    Dim Lespesees As New DCSaigicLight.BObject.Pesees
    Private Sub FrmDashCacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActivationCommande()
        Try
            spvEnattentePesee2()
        Catch ex As Exception

        End Try

        Try
            spvEnAttenteValidation()
        Catch ex As Exception

        End Try
        Try
            spvDonneesValidees()
        Catch ex As Exception

        End Try
        Try
            spvPoidsRecup()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub ActivationCommande()
        Select Case Moi.Profil
            Case "SUP"
                btnSupprimerItemAttenteP2.Visible = True
                btnSupprimerItemAttenteValidation.Visible = True
                btnSupprimerItemValide.Visible = True
            Case "PES"
                btnSupprimerItemAttenteP2.Visible = False
                btnSupprimerItemAttenteValidation.Visible = False
                btnSupprimerItemValide.Visible = False
        End Select
    End Sub
    Private Sub spvEnattentePesee2()
        Dim MonDA As SqlClient.SqlDataAdapter
        Dim MonDS As DataSet
        Dim Mystr As String

        Mystr = "SELECT CodePesee, DateP1, Immatriculation as Vehicule, poids1 , Mouvement FROM Pesee WHERE poids2=0 AND ProduitFamille ='CACAO' order by CodePesee DESC"
        MonDA = New SqlClient.SqlDataAdapter(Mystr, SaigicLocal_Cnx)

        MonDS = Nothing
        MonDS = New DataSet

        MonDA.Fill(MonDS, "AttenteP2")

        With dgdListeAttenteP2
            .DataSource = Nothing
            .Rows.Clear()
            .AutoGenerateColumns = True
            .ReadOnly = True
            .DataSource = MonDS
            .DataMember = "AttenteP2"
            .Refresh()
        End With
        txtNbPeseesImcompletes.Text = MonDS.Tables("AttenteP2").Rows.Count
    End Sub

    Private Sub SelectionPourPesee2()
        Dim ppvID As String = ""
        Dim ppvIdxLigne As Integer
        Dim tmpmvt As String
        If dgdListeAttenteP2.Rows.Count = 0 Then Exit Sub
        Try
            ppvIdxLigne = dgdListeAttenteP2.SelectedRows(0).Index
        Catch
            ppvIdxLigne = dgdListeAttenteP2.SelectedCells(0).RowIndex
        End Try

        ppvID = dgdListeAttenteP2.Item("CodePesee", ppvIdxLigne).Value()
        tmpmvt = dgdListeAttenteP2.Item("Mouvement", ppvIdxLigne).Value()
        spbAfficherPeseeCacao(ppvID, lstTypeOuverture.Modepesee2, tmpmvt)

        'Select Case 
        '    Case "ACHAT TOUT-VENANT"
        '        Dim ModifierReception As New FrmReceptionCacao(lstTypeOuverture.Modepesee2, ppvID)
        '        launchForm(ModifierReception, lstOpenOption.Dialog)
        '    Case "EXPEDITION"
        '        Dim ModifierExpedition As New FrmExpeditionCacao(lstTypeOuverture.Modepesee2, ppvID)
        '        launchForm(ModifierExpedition, lstOpenOption.Dialog)
        'End Select


        dgdListeAttenteP2.Refresh()
        dgdListeAttenteValidation.Refresh()
        Me.Refresh()

    End Sub

    Private Sub spvEnAttenteValidation()
        Dim MonDA As SqlClient.SqlDataAdapter
        Dim MonDS As DataSet
        MonDA = New SqlClient.SqlDataAdapter("SELECT * FROM Pesee WHERE poids2<>0 and ValiderSite=0  AND ProduitFamille='CACAO' order by DateP2 desc", SaigicLocal_Cnx)

        MonDS = Nothing
        MonDS = New DataSet

        MonDA.Fill(MonDS, "AttenteValidation")

        With dgdListeAttenteValidation
            .DataSource = Nothing
            .Rows.Clear()

            .AutoGenerateColumns = True
            .ReadOnly = True
            .DataSource = MonDS
            .DataMember = "AttenteValidation"

            .Refresh()
        End With
        txtNbPeseesCompletes.Text = MonDS.Tables("AttenteValidation").Rows.Count
    End Sub

    Private Sub spvDonneesValidees()
        Dim Mystr As String

        Dim MonDA As New SqlClient.SqlDataAdapter
        Dim MonDS As New DataSet

        'Mystr = "SELECT * From Pesee WHERE ValiderSite=1 AND ProduitFamille='CACAO' order by DateP2 desc"
        Mystr = "SELECT * From Pesee WHERE ValiderSite=1 AND TransfererAuServeur =0 AND ProduitFamille='CACAO' order by DateP2 desc"

        MonDA = New SqlClient.SqlDataAdapter(Mystr, SaigicLocal_Cnx)

        MonDS = New DataSet

        Try
            MonDA.Fill(MonDS, "PeseesValidees")
        Catch ex As Exception

        End Try

        'MsgBox(MonDS.Tables("PeseesValidees").Rows.Count)

        With dgdListeValidees
            .DataSource = Nothing
            .Rows.Clear()

            .AutoGenerateColumns = True
            .ReadOnly = True
            .DataSource = MonDS
            .DataMember = "PeseesValidees"

            .Refresh()
        End With
        txtNbPeseesValidees.Text = MonDS.Tables("PeseesValidees").Rows.Count
    End Sub

    Private Sub dgdListeAttenteP2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgdListeAttenteP2.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        SelectionPourPesee2()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SelectionConsultation()
        Dim ppvID As String = ""
        Dim ppvIdxLigne As Integer
        Dim tmpmvt As String = ""
        If dgdListeValidees.Rows.Count = 0 Then Exit Sub
        Try
            ppvIdxLigne = dgdListeValidees.SelectedRows(0).Index
        Catch
            ppvIdxLigne = dgdListeValidees.SelectedCells(0).RowIndex
        End Try

        ppvID = dgdListeValidees.Item("CodePesee", ppvIdxLigne).Value()
        tmpmvt = dgdListeValidees.Item("Mouvement", ppvIdxLigne).Value()
        spbAfficherPeseeCacao(ppvID, lstTypeOuverture.Modepesee2, tmpmvt)

    End Sub

    Private Sub SelectionModificationOuValidation()
        Dim ppvID As String = ""
        Dim ppvIdxLigne As Integer
        Dim tmpmvt As String

        If dgdListeAttenteValidation.Rows.Count = 0 Then Exit Sub
        Try
            ppvIdxLigne = dgdListeAttenteValidation.SelectedRows(0).Index
        Catch
            ppvIdxLigne = dgdListeAttenteValidation.SelectedCells(0).RowIndex
        End Try

        ppvID = dgdListeAttenteValidation.Item("CodePesee", ppvIdxLigne).Value()
        tmpmvt = dgdListeAttenteValidation.Item("Mouvement", ppvIdxLigne).Value()
        spbAfficherPeseeCacao(ppvID, lstTypeOuverture.Modepesee2, tmpmvt)

        dgdListeAttenteValidation.Refresh()
        dgdListeValidees.Refresh()
        Me.Refresh()

    End Sub

    Private Sub dgdListeAttenteValidation_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgdListeAttenteValidation.DoubleClick

        Me.Cursor = Cursors.WaitCursor
        SelectionModificationOuValidation()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRaffraichir.Click
        FrmDashCacao_Load(Nothing, Nothing)
    End Sub

    Private Sub btnImporter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImporter.Click
        spvPoidsRecup2()
        'FrmDashCacao_Load(Nothing, Nothing)
       
    End Sub
    Private Sub spvPoidsRecup2()

        Try
            Shell(Application.StartupPath & MonParametre.Original_CheminExecutableRecup)

            Dim proc = Process.GetProcessesByName("RECUPERATION")
            For i As Integer = 0 To proc.Length - 1
                While proc(i).HasExited = False

                End While
            Next
            FrmDashCacao_Load(Nothing, Nothing)
        Catch ex As Exception

        Finally
            spvPoidsRecup()
        End Try
    End Sub
    Private Sub spvPoidsRecup()
        Dim MonDA As SqlClient.SqlDataAdapter
        Dim MonDS As DataSet
        Try
            Dim Mystr As String
            Mystr = "SELECT IDPoidsRecup, LePoids,LaDate From PoidsRecup " 'and datep2 >=#" & DateTimePicker1.Value & "# AND datep2<=#" & DateTimePicker2.Value & "#"
            MonDA = New SqlClient.SqlDataAdapter(Mystr, SaigicLocal_Cnx)

            MonDS = Nothing
            MonDS = New DataSet

            Try
                MonDS.Tables("Recup").Clear()
            Catch ex As Exception
                'MsgBox(ex.Message)
            Finally
                MonDA.Fill(MonDS, "Recup")
            End Try

            With dgdListePoidsRecuperes
                .DataSource = Nothing
                .Rows.Clear()
                .AutoGenerateColumns = True
                .ReadOnly = True
                .DataSource = MonDS
                .DataMember = "Recup"
                txtPoidsEnAttente.Text = MonDS.Tables("Recup").Rows.Count
                .Refresh()
            End With
        Catch ex As Exception

        Finally

        End Try
       
    End Sub

    Private Sub dgdListePoidsRecuperes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgdListePoidsRecuperes.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        spvSelectionPourRecuperationPesee()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub spvSelectionPourRecuperationPesee()
        Dim ppvID As Integer = 0
        Dim ppvIdxLigne As Integer
        If dgdListePoidsRecuperes.Rows.Count = 0 Then Exit Sub
        Try
            ppvIdxLigne = dgdListePoidsRecuperes.SelectedRows(0).Index
        Catch
            ppvIdxLigne = dgdListePoidsRecuperes.SelectedCells(0).RowIndex
        End Try

        ppvID = dgdListePoidsRecuperes.Item(0, ppvIdxLigne).Value()

        Dim frmRecup As New DialogRecuperation(ppvID, "CACAO")
        launchForm(frmRecup, lstOpenOption.Dialog)


    End Sub

    Private Sub dgdListeTransmises_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgdListeValidees.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        SelectionConsultation()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSupprimerItemAttenteP2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimerItemAttenteP2.Click
        Dim ppvID As String = ""
        Dim ppvIdxLigne As Integer
        If dgdListeAttenteP2.Rows.Count = 0 Then Exit Sub
        Try
            ppvIdxLigne = dgdListeAttenteP2.SelectedRows(0).Index
        Catch
            ppvIdxLigne = dgdListeAttenteP2.SelectedCells(0).RowIndex
        End Try

        ppvID = dgdListeAttenteP2.Item("CodePesee", ppvIdxLigne).Value()
        If MsgBox("Confirmer la suppression de la pesee - " & ppvID, vbYesNo) = vbYes Then
            'Supression Pesee
            Dim LesPesee As New DCSaigicLight.BObject.Pesees
            LesPesee.LoadPesees()
            LesPesee.DeleteBObjectAndBDataPesee(ppvID)
            'Suppresion AnalyseCacao
            Dim LesAnalyseCacao As New DCSaigicLight.BObject.PeseeAnalyseCacaos
            LesAnalyseCacao.LoadPeseeAnalyseCacaos()
            LesAnalyseCacao.DeleteBObjectAndBDataPeseeAnalyseCacao(ppvID)
            'Suppression empotage
            Dim LesEmpotages As New DCSaigicLight.BObject.PeseeEmpotages
            LesEmpotages.LoadPeseeEmpotages()
            LesEmpotages.DeleteBObjectAndBDataPeseeEmpotage(ppvID)
            MsgBox("Enregistrement supprime!")
        End If
        btnRaffraichir.PerformClick()
    End Sub

    Private Sub btnSupprimerItemAttenteValidation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimerItemAttenteValidation.Click
        Dim ppvID As String = ""
        Dim ppvIdxLigne As Integer
        If dgdListeAttenteValidation.Rows.Count = 0 Then Exit Sub
        Try
            ppvIdxLigne = dgdListeAttenteValidation.SelectedRows(0).Index
        Catch
            ppvIdxLigne = dgdListeAttenteValidation.SelectedCells(0).RowIndex
        End Try

        ppvID = dgdListeAttenteValidation.Item("CodePesee", ppvIdxLigne).Value()
        If MsgBox("Confirmer la suppression de la pesee - " & ppvID, vbYesNo) = vbYes Then
            'Supression Pesee
            Dim LesPesee As New DCSaigicLight.BObject.Pesees
            LesPesee.LoadPesees()
            LesPesee.DeleteBObjectAndBDataPesee(ppvID)
            'Suppresion AnalyseCacao
            Dim LesAnalyseCacao As New DCSaigicLight.BObject.PeseeAnalyseCacaos
            LesAnalyseCacao.LoadPeseeAnalyseCacaos()
            LesAnalyseCacao.DeleteBObjectAndBDataPeseeAnalyseCacao(ppvID)
            'Suppression empotage
            Dim LesEmpotages As New DCSaigicLight.BObject.PeseeEmpotages
            LesEmpotages.LoadPeseeEmpotages()
            LesEmpotages.DeleteBObjectAndBDataPeseeEmpotage(ppvID)
            MsgBox("Enregistrement supprime!")
        End If
        btnRaffraichir.PerformClick()
    End Sub

    Private Sub btnSupprimerItemValide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimerItemValide.Click
        Dim ppvID As String = ""
        Dim ppvIdxLigne As Integer
        If dgdListeValidees.Rows.Count = 0 Then Exit Sub
        Try
            ppvIdxLigne = dgdListeValidees.SelectedRows(0).Index
        Catch
            ppvIdxLigne = dgdListeValidees.SelectedCells(0).RowIndex
        End Try

        ppvID = dgdListeValidees.Item("CodePesee", ppvIdxLigne).Value()
        If MsgBox("Confirmer la suppression de la pesee - " & ppvID, vbYesNo) = vbYes Then
            'Supression Pesee
            Dim LesPesee As New DCSaigicLight.BObject.Pesees
            LesPesee.LoadPesees()
            LesPesee.DeleteBObjectAndBDataPesee(ppvID)
            'Suppresion AnalyseCacao
            Dim LesAnalyseCacao As New DCSaigicLight.BObject.PeseeAnalyseCacaos
            LesAnalyseCacao.LoadPeseeAnalyseCacaos()
            LesAnalyseCacao.DeleteBObjectAndBDataPeseeAnalyseCacao(ppvID)
            'Suppression empotage
            Dim LesEmpotages As New DCSaigicLight.BObject.PeseeEmpotages
            LesEmpotages.LoadPeseeEmpotages()
            LesEmpotages.DeleteBObjectAndBDataPeseeEmpotage(ppvID)
            MsgBox("Enregistrement supprime!")
        End If
        btnRaffraichir.PerformClick()
    End Sub

    Private Sub Btn_correction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_correction.Click
        Try
            Shell(Application.StartupPath & "\Comm\CORRECTION.exe")

        Catch ex As Exception

        Finally

        End Try
    End Sub

 
End Class
