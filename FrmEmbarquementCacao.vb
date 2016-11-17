Imports DCSaigicLight
Imports System.IO
Imports Microsoft.Office.Interop
Public Class FrmEmbarquementCacao

#Region "Declaration"
    Dim MyDA As New SqlClient.SqlDataAdapter
    Dim MyDS As New DataSet
    'Dim ListeProvenances As New DCSaigicLight.BObject.Departements
    'Dim ListeDestinations As New DCSaigicLight.BObject.Localisations
    Dim ListeTransporteurs As New DCSaigicLight.BObject.Transporteurs

    Dim ListeExportateursFournisseur As New DCSaigicLight.BObject.Exportateurs
    Dim ListeExportateursClient As New DCSaigicLight.BObject.Exportateurs
    Dim listeProduits As New DCSaigicLight.BObject.Produits
    Dim ListeCCQs As New DCSaigicLight.BObject.CCQs
    Dim ListeEmballages As New DCSaigicLight.BObject.Emballagess
    Dim ListeVehicules As New DCSaigicLight.BObject.Vehicules
    Dim listeRemorques As New DCSaigicLight.BObject.Vehicules
    Dim ListeMagasins As New DCSaigicLight.BObject.Magasins
    Dim listeLots As New DCSaigicLight.BObject.Fabrications

    Private intTypeOuverture As lstTypeOuverture
    Private Cle As String
    Dim CalculEncour As Integer = 0

    Dim MaPesee As New DCSaigicLight.BObject.Pesee
    Dim MaPeseeAnalyse As New DCSaigicLight.BObject.PeseeAnalyseCacao
    Dim MaPeseeEmpotage As New DCSaigicLight.BObject.PeseeEmpotage

    'Dim MyExcelApplication As Microsoft.Office.Interop.Excel.Application
    'Dim MyExcelFile As Microsoft.Office.Interop.Excel.Workbook
    'Dim MyExcelSheetRefaction As Microsoft.Office.Interop.Excel.Worksheet
    Dim maRecup As DCSaigicLight.BObject.PoidsRecup
    Dim MonDA As New SqlClient.SqlDataAdapter
    Dim MonDS As New DataSet
#End Region


#Region "Zone de réflexion "

    Dim _Vehicule As String
    Dim _Poids1 As Integer
    Dim _Poids2 As Integer
    Dim _D1 As Date
    Dim _D2 As Date
    Dim _IDRecup As Integer

    Public Property IDRecup() As Integer
        Set(ByVal value As Integer)
            _IDRecup = value

        End Set

        Get
            Return _IDRecup
        End Get

    End Property
    Public Property Vehicule() As String
        Set(ByVal value As String)
            _Vehicule = value

        End Set

        Get
            Return _Vehicule
        End Get

    End Property

    Public Property Poids1() As Integer
        Set(ByVal value As Integer)
            _Poids1 = value

        End Set

        Get
            Return _Poids1
        End Get

    End Property

    Public Property Poids2() As Integer
        Set(ByVal value As Integer)
            _Poids2 = value

        End Set

        Get
            Return _Poids2
        End Get

    End Property

    Public Property Date1() As Date
        Set(ByVal value As Date)
            _D1 = value

        End Set

        Get
            Return _D1
        End Get

    End Property

    Public Property Date2() As Date
        Set(ByVal value As Date)
            _D2 = value

        End Set

        Get
            Return _D2
        End Get

    End Property

#End Region

    Private Sub spvchargerInterfaces()
        spvChargerFournisseur()
        spvTypeSac()

        ListeTransporteurs.LoadTransporteurs()
        spbChargerDropDownList(ListeTransporteurs, cboTransporteur, "IDTransporteur", "NomTransporteur")
        cboTransporteur.SelectedIndex = -1

        ListeExportateursFournisseur.LoadExportateurs()
        spbChargerDropDownList(ListeExportateursFournisseur, cboCodeFournisseur, "Id_EXP", "Id_EXP")
        spbChargerDropDownList(ListeExportateursFournisseur, cboNomFournisseur, "Id_EXP", "Exportateur")
        cboNomFournisseur.SelectedIndex = -1
        cboCodeFournisseur.SelectedIndex = -1

        ListeMagasins.LoadMagasins()
        spbChargerDropDownList(ListeMagasins, cboMagasin, "NomMagasin", "NomMagasin")
        cboMagasin.SelectedIndex = -1

        ListeExportateursClient.LoadExportateurs()
        spbChargerDropDownList(ListeExportateursClient, cboCodeExportateur, "Id_EXP", "Id_EXP")
        spbChargerDropDownList(ListeExportateursClient, cboNomExportateur, "Id_EXP", "Exportateur")
        cboCodeExportateur.SelectedIndex = -1
        cboNomExportateur.SelectedIndex = -1

        listeProduits.LoadProduits()
        listeProduits = listeProduits.FindProduitsByFamille("CACAO")
        spbChargerDropDownList(listeProduits, cboProduit, "LibelleProduit", "LibelleProduit")
        cboProduit.SelectedIndex = -1

        ListeEmballages.LoadEmballagess()
        spbChargerDropDownList(ListeEmballages, cboEmballage, "IDemballage", "Emballage")
        spbChargerDropDownList(ListeEmballages, cboPoidsUnitaireEmballage, "IDemballage", "Pem")
        cboEmballage.SelectedIndex = -1

        ListeVehicules.LoadVehicules()
        spbChargerDropDownList(ListeVehicules, cboVehicule, "Immatriculation", "Immatriculation")
        cboVehicule.SelectedIndex = -1

        listeRemorques.LoadVehicules()
        spbChargerDropDownList(listeRemorques, cboRemorque, "Immatriculation", "Immatriculation")
        cboRemorque.SelectedIndex = -1

        listeLots.LoadFabrications()
        spbChargerDropDownList(listeLots, cboNumeroLot, "NumeroLot", "NumeroLot")
        cboNumeroLot.SelectedIndex = -1

    End Sub
    Private Sub spvChargerFournisseur()


        MyDA = New SqlClient.SqlDataAdapter("SELECT * FROM VueFournisseur Order by NomFournisseur ", SaigicLocal_Cnx)

        Try
            MyDS.Tables("Fournisseur").Clear()
        Catch ex As Exception

        Finally
            MyDA.Fill(MyDS, "Fournisseur")
        End Try
        spbChargerDropDownList(MyDS.Tables("Fournisseur"), cboNomFournisseur, "Fournisseur_ID", "NomFournisseur")
        spbChargerDropDownList(MyDS.Tables("Fournisseur"), cboCodeFournisseur, "Fournisseur_ID", "Fournisseur_ID")
        cboCodeFournisseur.SelectedIndex = -1
        cboNomFournisseur.SelectedIndex = -1
    End Sub
    Private Sub spvTypeSac()

        MyDA = New SqlClient.SqlDataAdapter("SELECT emballage FROM Emballages order by IDEmballage ASC ", SaigicLocal_Cnx)

        Try
            MyDS.Tables("Emballages").Clear()
        Catch ex As Exception

        Finally
            MyDA.Fill(MyDS, "Emballages")
        End Try

        cboSacRetournes.Items.Add("Sac Brousse Neuf")
        cboSacRetournes.Items.Add("Sac Brousse Utilisé")
        cboSacRetournes.SelectedIndex = -1

    End Sub

    Private Sub FrmReception_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'Try
        '    MyExcelFile.Saved = True

        '    MyExcelApplication.Quit()
        '    MyExcelApplication = Nothing
        '    MyExcelFile.Close()
        '    MyExcelFile = Nothing
        '    MyExcelSheetRefaction = Nothing
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub FrmReception_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDISagic.MonDashCacao.btnRaffraichir.PerformClick()
        'Try
        '    MyExcelFile.Saved = True

        '    MyExcelApplication.Quit()
        '    MyExcelApplication = Nothing
        '    MyExcelFile.Saved = True

        '    MyExcelFile.Close()
        '    MyExcelFile = Nothing
        '    MyExcelSheetRefaction = Nothing
        'Catch ex As Exception

        'End Try
        'FrmDashCacao.Refresh()
        'ActiveWorkbook.Saved = True
        'ActiveWorkbook.Close()
    End Sub

    Private Sub FrmEmbarquementCacao_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub FrmReception_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        spvchargerInterfaces()
        spvInitialiserCommandes()
        txtCodeSite.Text = MonSite.IDSite
        txtNomSite.Text = MonSite.NomCourt
        txtCodePont.Text = MonPont.CodePont
        txtCampagne.Text = MaCampagne
        'mskAnneeRecolte.Text = MaCampagne
        txtTypePont.Text = MonPont.Typepont
        txtLieuDepart.Text = UCase(MonSite.ZonePortuaire)


        Select Case intTypeOuverture
            Case lstTypeOuverture.ModePesee1
                TabAnalyses.Enabled = False
                lblModeOuverture.Text = "1ere pesée"
                txtOperateurPoids1.Text = Moi.CodeUser
                mskAnneeRecolte.Text = MaCampagne
                If Me.IDRecup <> 0 Then
                    Dim tmp As New DCSaigicLight.BObject.PoidsRecups
                    tmp.LoadPoidsRecups()
                    maRecup = tmp.FindPoidsRecup(IDRecup)
                    If Not IsNothing(maRecup) Then
                        txtPoids1.Text = maRecup.LePoids
                        mskDatePesee1.Text = maRecup.LaDate
                        mskDatePesee2.Text = maRecup.LaDate
                        cboVehicule.Text = Vehicule
                        btnCapture.Enabled = False
                    End If
                End If

            Case lstTypeOuverture.Modepesee2
                TabAnalyses.Enabled = True
                lblModeOuverture.Text = "2ème pesée"
                txtOperateurPoids2.Text = Moi.CodeUser
                spvChargerPesee(Cle)
                If txtPoids2.Text <> 0 Then btnCapture.Enabled = False

                If Me.IDRecup <> 0 Then
                    Dim tmp As New DCSaigicLight.BObject.PoidsRecups
                    tmp.LoadPoidsRecups()
                    maRecup = tmp.FindPoidsRecup(IDRecup)
                    If Not IsNothing(maRecup) Then
                        txtPoids2.Text = maRecup.LePoids
                        mskDatePesee2.Text = maRecup.LaDate
                        'mskDatePesee1.Text = maRecup.LaDate
                        btnCapture.Enabled = False
                    End If
                End If

            Case lstTypeOuverture.ModeValidation
                TabAnalyses.Enabled = True
                lblModeOuverture.Text = "Modification"
                spvChargerPesee(Cle)
                btnCapture.Enabled = False
            Case lstTypeOuverture.ModeConsultation
                TabAnalyses.Enabled = True
                lblModeOuverture.Text = "Consultation"
                spvChargerPesee(Cle)
                btnCapture.Enabled = False
        End Select

        ' -----------------------------------------------------
        'Impression du Ticket
        '------------------------------------------------------
        Dim Test As String

        Try
            MyDS.Tables("ValiderSite").Clear()

        Catch ex As Exception

        End Try

        Try
            MyDA = New SqlClient.SqlDataAdapter("select ValiderSite from Pesee where CodePesee='" & TxtNumeroPesee.Text & "'", SaigicLocal_Cnx)
            MyDA.Fill(MyDS, "ValiderSite")


            With MyDS.Tables("ValiderSite")
                Test = .Rows(0)("ValiderSite")
                If Test = 1 Then
                    Btn_Imprimer.Visible = True
                    Btn_Imprimer.Enabled = False
                Else
                    Btn_Imprimer.Visible = False
                End If
            End With
        Catch
            'Stop
        End Try


    End Sub

    Private Sub spvInitialiserCommandes()

        Select Case intTypeOuverture
            Case lstTypeOuverture.ModePesee1
                BtnEnregistrer.Enabled = True
                BtnFerner.Enabled = True
                'btnValiderTransferer.Enabled = False
            Case lstTypeOuverture.Modepesee2
                BtnEnregistrer.Enabled = True
                BtnFerner.Enabled = True
                'btnValiderTransferer.Enabled = False
            Case lstTypeOuverture.ModeValidation
                BtnEnregistrer.Enabled = True
                BtnFerner.Enabled = True
                'btnValiderTransferer.Enabled = False
            Case lstTypeOuverture.ModeConsultation
                BtnEnregistrer.Enabled = False
                BtnFerner.Enabled = False
                'btnValiderTransferer.Enabled = False
        End Select
    End Sub


    Private Sub SaisieNombreEntier(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTareEmballage.KeyPress, txtTareConteneur.KeyPress, txtPoidsRefaction.KeyPress, txtPoidsNetAccepte.KeyPress, txtPoidsNet.KeyPress, txtPoidsBrute.KeyPress, txtPoids2.KeyPress, txtPoids1.KeyPress, txtNbSacsDeclares.KeyPress, txtNbSacsAcceptes.KeyPress

        Dim Permis = "0123654789" & Chr(13) & Chr(8)
        If InStr(Permis, e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNbSacsAcceptes.TextChanged
        txtNbSacsDeclares.Text = txtNbSacsAcceptes.Text
    End Sub

    Private Sub TextBox31_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOperateurPoids1.TextChanged

    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNatureProduit.TextChanged

    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNatureProduit.SelectedIndexChanged
        If sender.text = "ORDINAIRE" Then
            txtNatureProduit.Enabled = False
            txtNatureProduit.Text = ""
        Else
            txtNatureProduit.Enabled = True
            txtNatureProduit.Text = ""
        End If
    End Sub

    Private Sub Label48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapture.Click
        'Code de capture dans le multiplexeur
        Dim tmpint As Integer = 0
        Dim tmp As StreamReader
        Dim tmpPoids As String
        Dim tmpDate As Date
        If MonParametre.ModePesee = "MANUEL" Then
            'input
            If intTypeOuverture = lstTypeOuverture.ModePesee1 Then
                'Me.mskDatePesee1.Text = Now
                'Me.mskDatePesee2.Text = Now

                Try
                    'tmpDate = CDate(InputBox("ENTRER LA DATE ET L'HEURE DE PESEE ex: jj/mm/aaaa hh:mm"))
                    'mskDatePesee1.Text = tmpDate
                    'mskDatePesee2.Text = tmpDate
                    FrmSaisiedate.ShowDialog()
                    mskDatePesee1.Text = FrmSaisiedate.Datesaisie
                    mskDatePesee2.Text = FrmSaisiedate.Datesaisie
                Catch ex As Exception
                    MsgBox("Saisie incorrecte")
                End Try

                Try
                    tmpint = CInt(InputBox("ENTRER LE POIDS!"))
                    txtPoids1.Text = tmpint
                Catch ex As Exception
                    MsgBox("Saisie incorrecte")
                End Try
                mskDatePesee1.Focus()
            ElseIf intTypeOuverture = lstTypeOuverture.Modepesee2 Then
                'Me.mskDatePesee2.Text = Now
                Try
                    'tmpDate = CDate(InputBox("ENTRER LA DATE ET L'HEURE DE PESEE ex: jj/mm/aaaa hh:mm"))
                    'mskDatePesee2.Text = tmpDate
                    FrmSaisiedate.ShowDialog()
                    mskDatePesee2.Text = FrmSaisiedate.Datesaisie
                Catch ex As Exception
                    MsgBox("Saisie incorrecte")
                End Try
                Try
                    tmpint = CInt(InputBox("ENTRER LE POIDS!"))
                    txtPoids2.Text = tmpint
                Catch ex As Exception
                    MsgBox("Saisie incorrecte")
                End Try
            End If
        ElseIf MonParametre.ModePesee = "AUTOMATIQUE" Then

            If intTypeOuverture = lstTypeOuverture.ModePesee1 Then
                Me.mskDatePesee1.Text = Now
                Me.mskDatePesee2.Text = Now
                Try
                    Shell(Application.StartupPath & MonParametre.CheminExecutableCapture)
                Catch ex As Exception

                End Try
                System.Threading.Thread.Sleep(1000)

                Try
                    'tmp = New StreamReader(Application.StartupPath & "\Comm\Poids.ini")
                    tmp = New StreamReader(Application.StartupPath & MonParametre.CheminTamponPoids)
                    tmp.ReadLine()
                    tmpPoids = tmp.ReadLine()
                    txtPoids1.Text = Mid(tmpPoids, InStr(tmpPoids, "=") + 1)
                    'TextBox2.Text = Int(5000 * Rnd())
                Catch ex As Exception

                Finally

                End Try

            ElseIf intTypeOuverture = lstTypeOuverture.Modepesee2 Then
                Me.mskDatePesee2.Text = Now
                Try
                    Shell(Application.StartupPath & MonParametre.CheminExecutableCapture)
                Catch ex As Exception

                End Try

                System.Threading.Thread.Sleep(1000)

                Try
                    'tmp = New StreamReader(Application.StartupPath & "\Comm\Poids.ini")
                    tmp = New StreamReader(Application.StartupPath & MonParametre.CheminTamponPoids)
                    tmp.ReadLine()
                    tmpPoids = tmp.ReadLine()
                    txtPoids2.Text = Mid(tmpPoids, InStr(tmpPoids, "=") + 1)
                    'TextBox3.Text = Int(5000 * Rnd())
                Catch ex As Exception

                Finally

                End Try
            End If


        End If
    End Sub

    Private Sub BtnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnregistrer.Click



        'Enregistrement Pesee

        Select Case intTypeOuverture
            Case lstTypeOuverture.ModePesee1

                'Controle des saisies
                If Not ValideSaisiesPesees() Then
                    MsgBox("Erreur de saisie !!!!")
                    Exit Sub
                End If


                If AjouterPesee() Then
                    If AjouterAnalysePesee() Then
                        'AjouterEmpotage
                        AjouterEmpotagePesee()
                        MsgBox("Operation effectuee avec succes")
                        Me.Close()
                    Else
                        MsgBox("Erreur d'enregistrement - Analyses")
                    End If
                Else
                    MsgBox("Erreur d'enregistrement - Pesee")
                End If

                'Supprimer la pesée recupéree correspondante
                If Not IsNothing(Me.IDRecup) And Me.IDRecup <> 0 Then
                    Dim lesrecup As New DCSaigicLight.BObject.PoidsRecups
                    lesrecup.LoadPoidsRecups()
                    lesrecup.UpdateBObjectNp(Me.IDRecup, -1)
                    lesrecup.UpdateAllBData()
                End If

            Case lstTypeOuverture.Modepesee2

                'Controle des saisies
                If Not ValideSaisiesPesees() Then
                    MsgBox("Erreur de saisie !!!!")
                    Exit Sub
                End If

                'Controle des saisies
                If Not ValideSaisiesAnalyse() Then
                    MsgBox("Erreur de saisie !!!!")
                    Exit Sub
                End If

                'Controle des saisies
                If Not ValideSaisiesEmpotage() Then
                    MsgBox("Erreur de saisie !!!!")
                    Exit Sub
                End If

                If ModifierPesee() Then
                    If ModifierAnalysePesee() Then
                        If ModifierEmpotage() Then
                            MsgBox("Operation effectue avec succes")
                        Else
                            MsgBox("Erreur d'enregistrement - Empotage")
                        End If
                        Me.Close()
                    Else
                        MsgBox("Erreur d'enregistrement - Analyses")
                    End If
                Else
                    MsgBox("Erreur d'enregistrement - Pesee")
                End If

                'Supprimer la pesée recupéree correspondante
                If Not IsNothing(Me.IDRecup) And Me.IDRecup <> 0 Then
                    Dim lesrecup As New DCSaigicLight.BObject.PoidsRecups
                    lesrecup.LoadPoidsRecups()
                    lesrecup.UpdateBObjectNp(Me.IDRecup, -1)
                    lesrecup.UpdateAllBData()
                End If


            Case lstTypeOuverture.ModeValidation

                'Controle des saisies
                If Not ValideSaisiesPesees() Then
                    MsgBox("Erreur de saisie !!!!")
                    Exit Sub
                End If

                'Controle des saisies
                If Not ValideSaisiesAnalyse() Then
                    MsgBox("Erreur de saisie !!!!")
                    Exit Sub
                End If

                If ModifierPesee() Then
                    If ModifierAnalysePesee() Then

                        MsgBox("Operation effectue avec succes")
                    Else
                        MsgBox("Erreur d'enregistrement - Analyses")
                    End If
                Else
                    MsgBox("Erreur d'enregistrement - Pesee")
                End If
                btnValiderTransferer.Enabled = True
            Case lstTypeOuverture.ModeConsultation

        End Select

    End Sub

    Private Sub spvChargerPesee(ByVal bvlCode As String)
        Dim tmp As New DCSaigicLight.BObject.Pesees
        tmp.LoadPesees()
        MaPesee = tmp.FindPesee(bvlCode)


        With MaPesee
            TxtNumeroPesee.Text = .CodePesee
            txtCampagne.Text = .Campagne
            cboVehicule.Text = .Immatriculation
            cboRemorque.Text = .Remorque
            TxtNomChauffeur.Text = .Chauffeur
            txtNumeroTicket.Text = .NumeroTicket
            mskAnneeRecolte.Text = .AnneeRecolte

            cboCodeFournisseur.SelectedValue = .Fournisseur

            cboCodeExportateur.SelectedValue = .Client

            cboMagasin.Text = .Magasin
            txtLieuArrivee.Text = .Destination

            cboProduit.Text = .Produit
            txtMarque.Text = .ProduitMarque
            cboEmballage.SelectedIndex = cboEmballage.FindString(.Emballage)

            cboTransporteur.Text = .Transporteur
            TxtConnaissement.Text = .cnsment
            txtNbSacsDeclares.Text = .NbSacsDeclares
            txtNbSacsAcceptes.Text = .NbSacsAcceptes

            mskDatePesee1.Text = .DateP1
            txtPoids1.Text = .Poids1
            mskDatePesee2.Text = .DateP2
            txtPoids2.Text = .Poids2
            txtOperateurPoids1.Text = .Peseur1
            If intTypeOuverture <> lstTypeOuverture.Modepesee2 Then
                txtOperateurPoids2.Text = .Peseur2
            End If
            mskDatePesee2.Text = .DateP2
            txtPoids2.Text = .Poids2
            txtTareEmballage.Text = .TareEmballage
            txtTareConteneur.Text = .TarePaletteConteneur
            txtPoidsRefaction.Text = .PoidsRefaction
            txtPoidsBrute.Text = .PoidsBrute
            txtPoidsNet.Text = .PoidsNet
            txtPoidsNetAccepte.Text = .PoidsNetAccepte

            cboNatureProduit.SelectedIndex = cboNatureProduit.FindString(Mid(.ProduitNature, 1, 4))
            If InStr(.ProduitNature, "+") <> 0 Then
                txtNatureProduit.Text = Replace(.ProduitNature, cboNatureProduit.Text & "+", "")
            Else
                txtNatureProduit.Text = ""
            End If
            cboNumeroLot.Text = Trim(.NumeroLot)
        End With

        Dim tmp2 As New DCSaigicLight.BObject.PeseeAnalyseCacaos
        tmp2.LoadPeseeAnalyseCacaos()
        MaPeseeAnalyse = tmp2.FindPeseeAnalyseCacao(bvlCode)

        With MaPeseeAnalyse
            cboGrade.Text = .Grade
        End With

        Dim tmp3 As New DCSaigicLight.BObject.PeseeEmpotages
        tmp3.LoadPeseeEmpotages()
        MaPeseeEmpotage = tmp3.FindPeseeEmpotage(bvlCode)

        With MaPeseeEmpotage
            cboPort.Text = Trim(.Port)
            txtAconier.Text = Trim(.Acconier)
            txtNavire.Text = Trim(.Navire)
            txtDestination.Text = Trim(.Destination)
            txtNumeroFO.Text = Trim(.NumeroFO)
            txtNumeroLivraison.Text = Trim(.NumeroLivraison)
            txtNumeroDossier.Text = Trim(.NumeroDossier)
            txtNumeroPlomb.Text = Trim(.NumeroPlomb)
            txtNumeroOT.Text = Trim(.NumeroOt)
            txtNumeroBooking.Text = Trim(.NumeroBooking)
        End With


    End Sub

    Protected Function AjouterPesee() As Boolean
        AjouterPesee = False
        Dim LesPesees As New DCSaigicLight.BObject.Pesees
        Dim tmpReponse As Integer = 0
        Dim intNumPesee As Integer



        LesPesees.LoadPesees()
        intNumPesee = fpbNouveauNumero("Pesee")
        TxtNumeroPesee.Text = txtCodePont.Text + "-" + CStr(intNumPesee)

        Try
            tmpReponse = LesPesees.AddBObjectAndBDataPesee(TxtNumeroPesee.Text, _
                                          txtCodePont.Text, _
                                          txtCampagne.Text, _
                                          TxtConnaissement.Text, _
                                          txtNumeroTicket.Text, _
                                          "", _
                                          "EMBARQUEMENT", _
                                          mskAnneeRecolte.Text, _
                                          txtLieuDepart.Text, _
                                          "", _
                                          cboCodeFournisseur.SelectedValue, _
                                          "", _
                                          "", _
                                          Replace(cboTransporteur.Text, "'", "''"), _
                                          Replace(TxtNomChauffeur.Text, "'", "''"), _
                                          cboVehicule.SelectedValue, _
                                          cboRemorque.SelectedValue, _
                                          CDec(txtNbSacsDeclares.Text), _
                                          CDec(txtNbSacsAcceptes.Text), _
                                          Replace(UCase(cboEmballage.Text), "'", "''"), _
                                          cboPoidsUnitaireEmballage.Text, _
                                          Date.FromOADate(CDate(mskDatePesee1.Text).ToOADate), _
                                          Date.FromOADate(CDate(mskDatePesee1.Text).ToOADate), _
                                          CDec(txtPoids1.Text), _
                                          Date.FromOADate(CDate(mskDatePesee2.Text).ToOADate), _
                                          Date.FromOADate(CDate(mskDatePesee2.Text).ToOADate), _
                                          CDec(txtPoids2.Text), _
                                          txtOperateurPoids1.Text, _
                                          txtOperateurPoids2.Text, _
                                          "CACAO", _
                                          cboProduit.Text, _
                                          Replace(Trim(cboNatureProduit.Text & "+" & txtNatureProduit.Text), "'", "''"), _
                                          txtMarque.Text, _
                                          CDec(txtPoidsBrute.Text), _
                                          CDec(txtTareEmballage.Text), _
                                          CDec(txtTareConteneur.Text), _
                                          CDec(txtPoidsNet.Text), _
                                          CDec(txtPoidsRefaction.Text), _
                                          CDec(txtPoidsNetAccepte.Text), _
                                          Trim(cboNumeroLot.Text), _
                                          "", _
                                          0, _
                                          "", _
                                          0, _
                                          Now.Date, _
                                          Now.Date, _
                                          Moi.CodeUser, _
                                          0, _
                                          Now.Date, _
                                          0, _
                                          "", _
                                          Now.Date, TxtPrixDuJour.Text, _
                                          txtNbSacsRetourne.Text, _
                                           txtNbSacsDecharges.Text, _
                                          CDec(txtNbSacsRefoules.Text)
                                          )
            If tmpReponse = 1 Then
                AjouterPesee = True
            Else
                fpbNouveauNumero("Pesee", -1)
                MsgBox("Erreur d'enregistrement")
            End If

            MaPesee = LesPesees.FindPesee(TxtNumeroPesee.Text)
        Catch ex As Exception
            fpbNouveauNumero("Pesee", -1)
            MsgBox("Erreur d'enregistrement")
        End Try
    End Function

    Protected Function ModifierPesee() As Boolean
        ModifierPesee = False
        Dim LesPesees As New DCSaigicLight.BObject.Pesees
        Dim tmpReponse As Integer = 0


        LesPesees.LoadPesees()
        Try
            LesPesees.UpdateBObjectNumeroTicket(TxtNumeroPesee.Text, txtNumeroTicket.Text)
            LesPesees.UpdateBObjectAnneeRecolte(TxtNumeroPesee.Text, mskAnneeRecolte.Text)
            LesPesees.UpdateBObjectProvenanceDepartement(TxtNumeroPesee.Text, txtLieuDepart.Text)

            LesPesees.UpdateBObjectFournisseur(TxtNumeroPesee.Text, cboCodeFournisseur.SelectedValue)
            LesPesees.UpdateBObjectNumeroTicket(TxtNumeroPesee.Text, txtNumeroTicket.Text)
            LesPesees.UpdateBObjectCodePeseeLien(TxtNumeroPesee.Text, "")

            LesPesees.UpdateBObjectProduitMarque(TxtNumeroPesee.Text, txtMarque.Text)
            LesPesees.UpdateBObjectNumeroLot(TxtNumeroPesee.Text, Trim(cboNumeroLot.Text))

            LesPesees.UpdateBObjectTransporteur(TxtNumeroPesee.Text, Replace(cboTransporteur.Text, "'", "''"))
            LesPesees.UpdateBObjectChauffeur(TxtNumeroPesee.Text, Replace(TxtNomChauffeur.Text, "'", "''"))
            LesPesees.UpdateBObjectImmatriculation(TxtNumeroPesee.Text, cboVehicule.SelectedValue)
            LesPesees.UpdateBObjectRemorque(TxtNumeroPesee.Text, cboRemorque.SelectedValue)
            LesPesees.UpdateBObjectNbSacsDeclares(TxtNumeroPesee.Text, CDec(txtNbSacsDeclares.Text))
            LesPesees.UpdateBObjectNbSacsAcceptes(TxtNumeroPesee.Text, CDec(txtNbSacsAcceptes.Text))
            LesPesees.UpdateBObjectEmballage(TxtNumeroPesee.Text, Replace(UCase(cboEmballage.Text), "'", "''"))
            LesPesees.UpdateBObjectPemd(TxtNumeroPesee.Text, cboPoidsUnitaireEmballage.Text)
            LesPesees.UpdateBObjectDateP1(TxtNumeroPesee.Text, Date.FromOADate(CDate(mskDatePesee1.Text).ToOADate))
            LesPesees.UpdateBObjectheureP1(TxtNumeroPesee.Text, Date.FromOADate(CDate(mskDatePesee1.Text).ToOADate))
            LesPesees.UpdateBObjectPoids1(TxtNumeroPesee.Text, CDec(txtPoids1.Text))
            LesPesees.UpdateBObjectDateP2(TxtNumeroPesee.Text, Date.FromOADate(CDate(mskDatePesee2.Text).ToOADate))
            LesPesees.UpdateBObjectheureP2(TxtNumeroPesee.Text, Date.FromOADate(CDate(mskDatePesee2.Text).ToOADate))
            LesPesees.UpdateBObjectPoids2(TxtNumeroPesee.Text, CDec(txtPoids2.Text))
            LesPesees.UpdateBObjectPeseur1(TxtNumeroPesee.Text, txtOperateurPoids1.Text)
            LesPesees.UpdateBObjectPeseur2(TxtNumeroPesee.Text, txtOperateurPoids2.Text)
            LesPesees.UpdateBObjectProduitNature(TxtNumeroPesee.Text, Replace(Trim(cboNatureProduit.Text & "+" & txtNatureProduit.Text), "'", "''"))
            LesPesees.UpdateBObjectPoidsBrute(TxtNumeroPesee.Text, CDec(txtPoidsBrute.Text))
            LesPesees.UpdateBObjectTareEmballage(TxtNumeroPesee.Text, CDec(txtTareEmballage.Text))
            LesPesees.UpdateBObjectTarePaletteConteneur(TxtNumeroPesee.Text, CDec(txtTareConteneur.Text))
            LesPesees.UpdateBObjectPoidsNet(TxtNumeroPesee.Text, CDec(txtPoidsNet.Text))
            LesPesees.UpdateBObjectPoidsRefaction(TxtNumeroPesee.Text, CDec(txtPoidsRefaction.Text))
            LesPesees.UpdateBObjectPoidsNetAccepte(TxtNumeroPesee.Text, CDec(txtPoidsNetAccepte.Text))
            LesPesees.UpdateBObjectDateModification(TxtNumeroPesee.Text, Now.Date)
            LesPesees.UpdateBObjectOperateurModification(TxtNumeroPesee.Text, Moi.CodeUser)
            LesPesees.UpdateBObjectTransfererAuServeur(TxtNumeroPesee.Text, 0)
            LesPesees.UpdateBObjectcnsment(TxtNumeroPesee.Text, TxtConnaissement.Text)
            tmpReponse = LesPesees.UpdateAllBData()

            If tmpReponse = 1 Then
                ModifierPesee = True
            Else
                ModifierPesee = False
            End If
            MaPesee = LesPesees.FindPesee(TxtNumeroPesee.Text)
        Catch ex As Exception
            ModifierPesee = False
        End Try
    End Function

    Protected Function AjouterAnalysePesee() As Boolean
        Dim tmpReponse As Integer = 0
        AjouterAnalysePesee = False
        Dim LesAnalyses As New DCSaigicLight.BObject.PeseeAnalyseCacaos

        LesAnalyses.LoadPeseeAnalyseCacaos()
        Try
            tmpReponse = LesAnalyses.AddBObjectAndBDataPeseeAnalyseCacao(TxtNumeroPesee.Text, _
                                                                         "", _
                                                                         Now.Date, _
                                                                         "", _
                                                                         "", _
                                                                         0, _
                                                                         0, _
                                                                         0, _
                                                                        0, _
                                                                        0, _
                                                                        0, _
                                                                        0, _
                                                                        0, _
                                                                        0, _
                                                                        0, _
                                                                        0, _
                                                                        0, _
                                                                        cboGrade.Text, _
                                                                        "", _
                                                                        "NON-REFOULE", _
                                                                        0, _
                                                                        Now.Date, _
                                                                        0)

            If tmpReponse = 1 Then
                AjouterAnalysePesee = True
            Else
                AjouterAnalysePesee = False
                MsgBox("Erreur d'enregistrement")
            End If
        Catch ex As Exception
            AjouterAnalysePesee = False
        End Try

    End Function

    Protected Function AjouterEmpotagePesee() As Boolean
        Dim tmpReponse As Integer = 0
        AjouterEmpotagePesee = False
        Dim LesEmpotages As New DCSaigicLight.BObject.PeseeEmpotages

        LesEmpotages.LoadPeseeEmpotages()
        Try
            tmpReponse = LesEmpotages.AddBObjectAndBDataPeseeEmpotage(TxtNumeroPesee.Text, "", "", "", "", "", "", "", "", "", "", 0, Now.Date)
            If tmpReponse = 1 Then
                AjouterEmpotagePesee = True
            Else
                AjouterEmpotagePesee = False
                MsgBox("Erreur d'enregistrement")
            End If
        Catch ex As Exception
            AjouterEmpotagePesee = False
        End Try

    End Function

    Protected Function ModifierAnalysePesee() As Boolean
        Dim tmpReponse As Integer = 0
        ModifierAnalysePesee = False


        Dim LesAnalyses As New DCSaigicLight.BObject.PeseeAnalyseCacaos

        LesAnalyses.LoadPeseeAnalyseCacaos()
        Try


            LesAnalyses.UpdateBObjectGrade(TxtNumeroPesee.Text, cboGrade.Text)


            tmpReponse = LesAnalyses.UpdateAllBData
            If tmpReponse = 1 Then
                ModifierAnalysePesee = True
            Else
                ModifierAnalysePesee = False
            End If
        Catch ex As Exception
            ModifierAnalysePesee = False
        End Try

    End Function

    Protected Function ModifierEmpotage() As Boolean
        Dim tmpReponse As Integer = 0
        ModifierEmpotage = False


        Dim LesEmpotages As New DCSaigicLight.BObject.PeseeEmpotages

        LesEmpotages.LoadPeseeEmpotages()
        Try


            LesEmpotages.UpdateBObjectAcconier(TxtNumeroPesee.Text, txtAconier.Text)
            LesEmpotages.UpdateBObjectPort(TxtNumeroPesee.Text, cboPort.Text)
            LesEmpotages.UpdateBObjectNavire(TxtNumeroPesee.Text, txtNavire.Text)
            LesEmpotages.UpdateBObjectDestination(TxtNumeroPesee.Text, txtDestination.Text)
            LesEmpotages.UpdateBObjectNumeroFO(TxtNumeroPesee.Text, txtNumeroFO.Text)
            LesEmpotages.UpdateBObjectNumeroLivraison(TxtNumeroPesee.Text, txtNumeroLivraison.Text)
            LesEmpotages.UpdateBObjectNumeroDossier(TxtNumeroPesee.Text, txtNumeroDossier.Text)
            LesEmpotages.UpdateBObjectNumeroBooking(TxtNumeroPesee.Text, txtNumeroBooking.Text)
            LesEmpotages.UpdateBObjectNumeroPlomb(TxtNumeroPesee.Text, txtNumeroPlomb.Text)
            LesEmpotages.UpdateBObjectNumeroOt(TxtNumeroPesee.Text, txtNumeroOT.Text)

            tmpReponse = LesEmpotages.UpdateAllBData
            If tmpReponse = 1 Then
                ModifierEmpotage = True
            Else
                ModifierEmpotage = False
            End If
        Catch ex As Exception
            ModifierEmpotage = False
        End Try

    End Function

    Protected Function MAJ_Stock() As Boolean
        'Dim tmpReponse As Integer = 0
        'MAJ_Stock = False
        'Dim Idx As Integer
        'Dim Elt As Integer
        'Dim RechercheFructuese As Boolean = False
        'Dim lesStocks As New DCSaigicLight.BObject.StockSites
        'lesStocks.LoadStockSites()
        'For Idx = 0 To lesStocks.Count - 1
        '    If lesStocks.Item(Idx).NumeroLot = "BROUSSE" And lesStocks.Item(Idx).ProduitFamille = "CACAO" Then
        '        RechercheFructuese = True
        '        'LesAnalyses.UpdateBObjectHumidite(TxtNumeroPesee.Text, Convert.ToDouble(txtHumidite.Text))
        '        'LesAnalyses.UpdateBObjectGrainnage(TxtNumeroPesee.Text, Convert.ToDouble(txtGrainage.Text))
        '        'LesAnalyses.UpdateBObjectMat_Etrangeres(TxtNumeroPesee.Text, Convert.ToDouble(txtMatieresEtrangeres.Text))
        '        'LesAnalyses.UpdateBObjectBrisures(TxtNumeroPesee.Text, Convert.ToDouble(txtBrisures.Text))
        '        'LesAnalyses.UpdateBObjectMoisies(TxtNumeroPesee.Text, Convert.ToDouble(txtMoisies.Text))
        '        'LesAnalyses.UpdateBObjectArdoises(TxtNumeroPesee.Text, Convert.ToDouble(txtArdoisees.Text))
        '        'LesAnalyses.UpdateBObjectMitees(TxtNumeroPesee.Text, Convert.ToDouble(txtMitees.Text))
        '        'LesAnalyses.UpdateBObjectGermees(TxtNumeroPesee.Text, Convert.ToDouble(txtGermees.Text))
        '        'tmpReponse = LesAnalyses.UpdateAllBData
        '        If tmpReponse = 1 Then
        '            AjouterEmpotagePesee = True
        '        Else
        '            AjouterEmpotagePesee = False
        '            MsgBox("Erreur d'enregistrement")
        '        End If
        '        Exit For
        '    End If
        'Next
        'If Not RechercheFructuese Then
        '    Try
        '        tmpReponse = lesStocks.AddBObjectAndBDataStockSite(0, MonSite.NomCourt, "", "", "", "", "", "", "", "", "", 0, Now.Date)
        '        If tmpReponse = 1 Then
        '            AjouterEmpotagePesee = True
        '        Else
        '            AjouterEmpotagePesee = False
        '            MsgBox("Erreur d'enregistrement")
        '        End If
        '    Catch ex As Exception

        '    End Try

        'End If
        'Try


        '    If tmpReponse = 1 Then
        '        ModifierAnalysePesee = True
        '    Else
        '        ModifierAnalysePesee = False
        '    End If
        'Catch ex As Exception
        '    ModifierAnalysePesee = False
        'End Try

    End Function

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPoidsUnitaireEmballage.SelectedIndexChanged
        Try
            txtTareEmballage.Text = Math.Round(CDec(txtNbSacsAcceptes.Text) * CDec(cboPoidsUnitaireEmballage.Text))
        Catch ex As Exception

        End Try
    End Sub


    Private Sub BtnFerner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFerner.Click
        Me.Close()

    End Sub

    Public Sub New(ByVal Ouverture As Integer, Optional ByVal ID As String = "")

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Cle = ID
        intTypeOuverture = Ouverture
    End Sub

    Private Sub SelectionContenu(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTareEmballage.MouseClick, txtTareConteneur.MouseClick, txtPoidsRefaction.MouseClick, txtPoidsNetAccepte.MouseClick, txtPoidsNet.MouseClick, txtPoidsBrute.MouseClick, txtPoids2.MouseClick, txtPoids1.MouseClick, txtNbSacsDeclares.MouseClick, txtNbSacsAcceptes.MouseClick
        sender.SelectionStart = 0
        sender.SelectionLength = Len(sender.Text)
    End Sub

    Private Sub SaisieNombreReel(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Permis = "0123654789,." & Chr(13) & Chr(8)
        If InStr(Permis, e.KeyChar) <> 0 Then
            If e.KeyChar = "," Or e.KeyChar = "." Then

                If InStr(sender.text, SigneVirgule) = 0 Then
                    e.KeyChar = SigneVirgule
                Else
                    e.KeyChar = ""
                End If

            End If
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Function ValideSaisiesPesees() As Boolean

        ' Valider la saisie
        ValideSaisiesPesees = True
        ' Effacer les icônes erreur
        Me.ErrorProvider1.Clear()

        If Me.TxtConnaissement.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TxtConnaissement, "Champs obligatoire.")
            Me.TxtConnaissement.Focus()
            ValideSaisiesPesees = False
        End If

        If Me.txtNumeroTicket.Text = "" And intTypeOuverture = lstTypeOuverture.Modepesee2 Then
            Me.ErrorProvider1.SetError(Me.txtNumeroTicket, "Champs obligatoire.")
            Me.txtNumeroTicket.Focus()
            ValideSaisiesPesees = False
        End If

        If Me.cboCodeFournisseur.SelectedValue = Nothing Then
            Me.ErrorProvider1.SetError(Me.cboCodeFournisseur, "Champs obligatoire.")
            Me.cboCodeFournisseur.Focus()
            ValideSaisiesPesees = False
        End If

        If Me.txtTareConteneur.Text = "0" Then
            Me.ErrorProvider1.SetError(Me.txtTareConteneur, "Champs obligatoire.")
            Me.txtTareConteneur.Focus()
            ValideSaisiesPesees = False
        End If

        If Me.cboNomFournisseur.SelectedValue = Nothing Then
            Me.ErrorProvider1.SetError(Me.cboNomFournisseur, "Champs obligatoire.")
            Me.cboNomFournisseur.Focus()
            ValideSaisiesPesees = False
        End If

        If Me.cboNatureProduit.Text = "" Then
            Me.ErrorProvider1.SetError(Me.cboNatureProduit, "Champs obligatoire.")
            Me.cboNatureProduit.Focus()
            ValideSaisiesPesees = False
        End If
        If Me.cboNatureProduit.Text <> "ORDINAIRE" Then
            If Me.txtNatureProduit.Text = "" Then
                Me.ErrorProvider1.SetError(Me.txtNatureProduit, "Champs obligatoire.")
                Me.txtNatureProduit.Focus()
                ValideSaisiesPesees = False
            End If
        End If


        If Len(Me.mskAnneeRecolte.Text) < 9 Then
            Me.ErrorProvider1.SetError(Me.mskAnneeRecolte, "Saisie incorrect.")
            Me.mskAnneeRecolte.Focus()
            ValideSaisiesPesees = False
        End If



        If Me.cboTransporteur.SelectedValue = Nothing Then
            Me.ErrorProvider1.SetError(Me.cboTransporteur, "Champs obligatoire.")
            Me.cboTransporteur.Focus()
            ValideSaisiesPesees = False
        End If

        If Me.cboVehicule.SelectedValue = Nothing Then
            Me.ErrorProvider1.SetError(Me.cboVehicule, "Champs obligatoire.")
            Me.cboVehicule.Focus()
            ValideSaisiesPesees = False
        End If

        If Me.cboRemorque.SelectedValue = Nothing Then
            Me.ErrorProvider1.SetError(Me.cboRemorque, "Champs obligatoire.")
            Me.cboRemorque.Focus()
            ValideSaisiesPesees = False
        End If

        If Trim(Me.TxtNomChauffeur.Text) = "" Then
            Me.ErrorProvider1.SetError(Me.TxtNomChauffeur, "Champs obligatoire.")
            Me.TxtNomChauffeur.Focus()
            ValideSaisiesPesees = False
        End If

        If Me.txtPoids1.Text = "0" And intTypeOuverture = lstTypeOuverture.ModePesee1 Then
            Me.ErrorProvider1.SetError(Me.txtPoids1, "Champs obligatoire.")
            Me.txtPoids1.Focus()
            ValideSaisiesPesees = False
        End If

        If Me.txtPoids2.Text = "0" And intTypeOuverture = lstTypeOuverture.Modepesee2 Then
            Me.ErrorProvider1.SetError(Me.txtPoids2, "Champs obligatoire.")
            Me.txtPoids2.Focus()
            ValideSaisiesPesees = False
        End If

        If Me.cboEmballage.SelectedValue = Nothing Then
            Me.ErrorProvider1.SetError(Me.cboEmballage, "Champs obligatoire.")
            Me.cboEmballage.Focus()
            ValideSaisiesPesees = False
        End If


        If Me.txtNbSacsDeclares.Text = "0" And intTypeOuverture = lstTypeOuverture.ModePesee1 Then
            Me.ErrorProvider1.SetError(Me.txtNbSacsDeclares, "Champs obligatoire.")
            Me.txtNbSacsDeclares.Focus()
            ValideSaisiesPesees = False
        End If



        If Me.cboProduit.SelectedValue = Nothing Then
            Me.ErrorProvider1.SetError(Me.cboProduit, "Champs obligatoire.")
            Me.cboProduit.Focus()
            ValideSaisiesPesees = False
        End If

        If Me.txtMarque.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtMarque, "Champs obligatoire.")
            Me.txtMarque.Focus()
            ValideSaisiesPesees = False
        End If
        If Me.TxtPrixDuJour.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TxtPrixDuJour, "Champs obligatoire.")
            Me.TxtPrixDuJour.Focus()
            ValideSaisiesPesees = False
        End If
    End Function
    Private Function ValideSaisiesEmpotage() As Boolean
        ValideSaisiesEmpotage = True
        If Trim(Me.cboPort.Text) = "" Then
            Me.ErrorProvider1.SetError(Me.cboPort, "Champs obligatoire.")
            Me.cboPort.Focus()
            ValideSaisiesEmpotage = False
        End If

        'If Trim(Me.txtAconier.Text) = "" Then
        '    Me.ErrorProvider1.SetError(Me.txtAconier, "Champs obligatoire.")
        '    Me.txtAconier.Focus()
        '    ValideSaisiesEmpotage = False
        'End If

        'If Trim(Me.txtNavire.Text) = "" Then
        '    Me.ErrorProvider1.SetError(Me.txtNavire, "Champs obligatoire.")
        '    Me.txtNavire.Focus()
        '    ValideSaisiesEmpotage = False
        'End If

        'If Trim(Me.txtDestination.Text) = "" Then
        '    Me.ErrorProvider1.SetError(Me.txtDestination, "Champs obligatoire.")
        '    Me.txtDestination.Focus()
        '    ValideSaisiesEmpotage = False
        'End If

        'If Trim(Me.txtNumeroFO.Text) = "" Then
        '    Me.ErrorProvider1.SetError(Me.txtNumeroFO, "Champs obligatoire.")
        '    Me.txtNumeroFO.Focus()
        '    ValideSaisiesEmpotage = False
        'End If

        'If Trim(Me.txtNumeroDossier.Text) = "" Then
        '    Me.ErrorProvider1.SetError(Me.txtNumeroDossier, "Champs obligatoire.")
        '    Me.txtNumeroDossier.Focus()
        '    ValideSaisiesEmpotage = False
        'End If

        'If Trim(Me.txtNumeroOT.Text) = "" Then
        '    Me.ErrorProvider1.SetError(Me.txtNumeroOT, "Champs obligatoire.")
        '    Me.txtNumeroOT.Focus()
        '    ValideSaisiesEmpotage = False
        'End If

        'If Trim(Me.txtNumeroPlomb.Text) = "" Then
        '    Me.ErrorProvider1.SetError(Me.txtNumeroPlomb, "Champs obligatoire.")
        '    Me.txtNumeroPlomb.Focus()
        '    ValideSaisiesEmpotage = False
        'End If

        'If Trim(Me.txtNumeroBooking.Text) = "" Then
        '    Me.ErrorProvider1.SetError(Me.txtNumeroBooking, "Champs obligatoire.")
        '    Me.txtNumeroBooking.Focus()
        '    ValideSaisiesEmpotage = False
        'End If

        'If Trim(Me.txtNumeroLivraison.Text) = "" Then
        '    Me.ErrorProvider1.SetError(Me.txtNumeroLivraison, "Champs obligatoire.")
        '    Me.txtNumeroLivraison.Focus()
        '    ValideSaisiesEmpotage = False
        'End If
    End Function
    Private Function ValideSaisiesAnalyse() As Boolean
        ValideSaisiesAnalyse = True
        If Trim(Me.cboGrade.Text) = "" Then
            Me.ErrorProvider1.SetError(Me.cboGrade, "Champs obligatoire.")
            Me.cboGrade.Focus()
            ValideSaisiesAnalyse = False
        End If

    End Function

    Private Sub SortiedeChampNumerique(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTareConteneur.Leave, txtPoids2.Leave, txtPoids1.Leave, txtNbSacsDeclares.Leave, txtNbSacsAcceptes.Leave
        If sender.text = "" Or sender.text = "." Then
            sender.text = 0
        End If
    End Sub

    Private Sub CalculTauxRefactionConformite(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim idx As Integer
        'If CalculEncour = 1 Then Exit Sub
        'CalculEncour = 1
        'Try
        '    txtDefectueuses.Text = CDec(txtMitees.Text) + CDec(txtPlates.Text) + CDec(txtGermees.Text)
        'Catch ex As Exception

        'End Try

        'Try
        '    MyExcelSheetRefaction.Cells(3)(2).value = txtHumidite.Text
        '    MyExcelSheetRefaction.Cells(3)(3).value = txtGrainage.Text
        '    MyExcelSheetRefaction.Cells(3)(4).value = txtMatieresEtrangeres.Text
        '    MyExcelSheetRefaction.Cells(3)(5).value = txtBrisures.Text
        '    MyExcelSheetRefaction.Cells(3)(6).value = txtMoisies.Text
        '    MyExcelSheetRefaction.Cells(3)(7).value = txtArdoisees.Text
        '    MyExcelSheetRefaction.Cells(3)(8).value = txtMitees.Text
        '    MyExcelSheetRefaction.Cells(3)(9).value = txtGermees.Text
        '    MyExcelSheetRefaction.Cells(3)(10).value = txtPlates.Text
        '    MyExcelSheetRefaction.Cells(3)(11).value = txtDefectueuses.Text
        '    MyExcelSheetRefaction.Cells(3)(12).value = txtViolettes.Text

        '    txtTauxRefaction.Text = MyExcelSheetRefaction.Cells(4)(13).value
        '    txtConformite.Text = MyExcelSheetRefaction.Cells(4)(15).value
        '    txtGrade.Text = MyExcelSheetRefaction.Cells(4)(17).value

        '    txtPoidsRefaction.Text = Math.Round((CDec(txtPoidsNet.Text) * CDec(txtTauxRefaction.Text)) / 100)
        'Catch ex As Exception
        '    'MsgBox(ex.Message)
        'Finally

        'End Try
        CalculEncour = 0
    End Sub

    Private Sub txtNumeroAnalyse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboEmballage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmballage.SelectedIndexChanged

    End Sub

    Private Sub txtPoids1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPoids2.TextChanged, txtPoids1.TextChanged, txtNbSacsAcceptes.TextChanged, txtTareConteneur.TextChanged
        Try
            txtPoidsBrute.Text = Math.Abs(CDec(txtPoids1.Text) - CDec(txtPoids2.Text))
            txtTareEmballage.Text = Math.Round(CDec(txtNbSacsAcceptes.Text) * CDec(cboPoidsUnitaireEmballage.Text))
            txtPoidsNet.Text = Math.Round(CDec(txtPoidsBrute.Text) - CDec(txtTareEmballage.Text) - CDec(txtTareConteneur.Text))
            'txtPoidsNetAccepte.Text = Math.Round(CDec(txtPoidsNet.Text) - CDec(txtPoidsRefaction.Text))
            txtPoidsNetAccepte.Text = txtPoidsNet.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTareEmballage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTareEmballage.TextChanged
        Try

            txtPoidsNet.Text = Math.Round(CDec(txtPoidsBrute.Text) - CDec(txtTareEmballage.Text) - CDec(txtTareConteneur.Text))
            'txtPoidsNetAccepte.Text = Math.Round(CDec(txtPoidsNet.Text) - CDec(txtPoidsRefaction.Text))
            txtPoidsNetAccepte.Text = txtPoidsNet.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPoidsRefaction_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPoidsRefaction.TextChanged, txtPoidsNet.TextChanged
        Try
            txtPoidsRefaction.Text = Math.Round((CDec(txtPoidsNet.Text) * 0) / 100)
            'txtPoidsNetAccepte.Text = Math.Round(CDec(txtPoidsNet.Text) - CDec(txtPoidsRefaction.Text))
            txtPoidsNetAccepte.Text = txtPoidsNet.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtConnaissement_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroTicket.KeyPress, TxtConnaissement.KeyPress

        If e.KeyChar = "'" Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub txtNumeroAnalyse_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Permis = "QWERTYUIOPASDFGHJKLZXCVBNMmnbvcxzlkjhgfdsapoiuytrewq0123654789.-_/" & Chr(13) & Chr(8)
        If InStr(Permis, e.KeyChar) <> 0 Then
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub cboVehicule_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVehicule.Leave
        Dim tmp As String = UCase(cboVehicule.Text)
        Dim tmp2 As String = UCase(cboRemorque.Text)
        If cboVehicule.FindString(cboVehicule.Text) = -1 Then
            ListeVehicules.AddBObjectAndBDataVehicule(tmp)
            ListeVehicules = New DCSaigicLight.BObject.Vehicules
            ListeVehicules.LoadVehicules()
            spbChargerDropDownList(ListeVehicules, cboVehicule, "Immatriculation", "Immatriculation")
            cboVehicule.SelectedIndex = cboVehicule.FindString(tmp)

            listeRemorques = New DCSaigicLight.BObject.Vehicules
            listeRemorques.LoadVehicules()
            spbChargerDropDownList(listeRemorques, cboRemorque, "Immatriculation", "Immatriculation")
            cboRemorque.SelectedIndex = cboRemorque.FindString(tmp2)
        End If
    End Sub

    Private Sub cboRemorque_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRemorque.Leave
        Dim tmp As String = UCase(cboRemorque.Text)
        Dim tmp2 As String = UCase(cboVehicule.Text)
        If cboRemorque.FindString(cboRemorque.Text) = -1 Then
            listeRemorques.AddBObjectAndBDataVehicule(tmp)
            listeRemorques = New DCSaigicLight.BObject.Vehicules
            listeRemorques.LoadVehicules()
            spbChargerDropDownList(listeRemorques, cboRemorque, "Immatriculation", "Immatriculation")
            cboRemorque.SelectedIndex = cboRemorque.FindString(tmp)

            ListeVehicules = New DCSaigicLight.BObject.Vehicules
            ListeVehicules.LoadVehicules()
            spbChargerDropDownList(ListeVehicules, cboVehicule, "Immatriculation", "Immatriculation")
            cboVehicule.SelectedIndex = cboVehicule.FindString(tmp2)

        End If
    End Sub


    Private Sub cboRemorque_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRemorque.SelectedIndexChanged

    End Sub

    Private Sub cboTransporteur_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTransporteur.Leave
        Dim tmp As String = UCase(cboTransporteur.Text)
        If cboTransporteur.FindString(cboTransporteur.Text) = -1 Then
            ListeTransporteurs.AddBObjectAndBDataTransporteur(0, UCase(tmp))
            ListeTransporteurs = New DCSaigicLight.BObject.Transporteurs
            ListeTransporteurs.LoadTransporteurs()
            spbChargerDropDownList(ListeTransporteurs, cboTransporteur, "IDTransporteur", "Transporteur")
            cboTransporteur.SelectedIndex = cboTransporteur.FindString(tmp)
        End If
    End Sub

    Private Sub btnValiderTransferer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValiderTransferer.Click
        Dim MaCommande As New SqlClient.SqlCommand

        Try
            SaigicLocal_Cnx.Open()
        Catch ex As Exception

        End Try

        ' Transmission Pesee
        MaCommande.CommandText = "EXEC PESEE_VERS_SERVEUR '" & MaPesee.CodePesee & "','" & LinkedSrvName & "','" & SaigicServerDB & "'"
        MaCommande.Connection = SaigicLocal_Cnx

        Try
            MaCommande.ExecuteNonQuery()
            MsgBox("Transmission de Pesee effectuee avec succes")
        Catch ex As Exception
            MsgBox("Echec de transmission de pesee", vbCritical)
        End Try

        ' Transmission analyse
        MaCommande.CommandText = "EXEC PESEE_ANALYSE_CACAO_VERS_SERVEUR '" & MaPesee.CodePesee & "','" & LinkedSrvName & "','" & SaigicServerDB & "'"
        MaCommande.Connection = SaigicLocal_Cnx

        Try
            MaCommande.ExecuteNonQuery()
            MsgBox("Transmission de l'analyse effectuee avec succes")
        Catch ex As Exception
            MsgBox("Echec de transmission de l'analyse", vbCritical)
        End Try

        ' Transmission Empotage
        MaCommande.CommandText = "EXEC PESEE_EMPOTAGE_VERS_SERVEUR '" & MaPesee.CodePesee & "','" & LinkedSrvName & "','" & SaigicServerDB & "'"
        MaCommande.Connection = SaigicLocal_Cnx

        Try
            MaCommande.ExecuteNonQuery()
            MsgBox("Transmission des donnees de l'empotage effectuee avec succes")
        Catch ex As Exception
            MsgBox("Echec de transmission des donnees de l'empotage ", vbCritical)
        End Try
    End Sub




    Private Sub spvChargerLocalite()


    End Sub

    Private Sub cboProvenanceLocalisation_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim tmp As String = UCase(cboProvenanceLocalisation.Text)
        'If (cboProvenanceLocalisation.FindString(cboProvenanceLocalisation.Text) = -1) Then

        '    MsgBox("existe")
        '    'ListeTransporteurs.AddBObjectAndBDataTransporteur(0, UCase(tmp))
        '    'ListeTransporteurs = New DCSaigicLight.BObject.Transporteurs
        '    'ListeTransporteurs.LoadTransporteurs()
        '    'spbChargerDropDownList(ListeTransporteurs, cboTransporteur, "IDTransporteur", "Transporteur")
        '    'cboTransporteur.SelectedIndex = cboTransporteur.FindString(tmp)
        'Else
        '    MsgBox("Nouveau")
        'End If
    End Sub



    Private Sub btnNewMagasin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewMagasin.Click
        'Dim AjoutMagasin As FrmMagasins
        'AjoutMagasin = New FrmMagasins(FrmMagasins.lstTypeOuverture.ModeAjouter)
        'AjoutMagasin.Parente = Me
        'AjoutMagasin.ShowDialog()
        'ListeMagasins = New DCSaigicLight.BObject.Magasins
        'ListeMagasins.LoadMagasins()
        'spbChargerDropDownList(ListeMagasins, cboMagasin, "NomMagasin", "NomMagasin")
        'Try
        '    cboMagasin.SelectedIndex = cboMagasin.FindString(Mid(Me.Tag, 1, InStr(Me.Tag, "\") - 1))
        '    txtLieuArrivee.Text = Mid(Me.Tag, InStr(Me.Tag, "\") + 1)
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub cboProduit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduit.SelectedIndexChanged
        If cboProduit.Text = "CACAO BROUSSE" Then
            cboNumeroLot.Text = "BROUSSE"
            'cboNumeroLot.Enabled = False
        Else
            cboNumeroLot.Text = ""
            'cboNumeroLot.Enabled = True
            'Chargement des lots usines
        End If
    End Sub

    Private Sub cboMagasin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMagasin.SelectedIndexChanged
        Dim tmp As New DCSaigicLight.BObject.Magasin
        tmp = ListeMagasins.FindMagasin(cboMagasin.Text)
        txtLieuArrivee.Text = tmp.Localisation
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub FrmEmbarquementCacao_MaximizedBoundsChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MaximizedBoundsChanged

    End Sub
    Private Sub cboCodeFournisseur_Leave(sender As Object, e As EventArgs) Handles cboCodeFournisseur.Leave
        'Dim tmp As String = UCase(cboCodeFournisseur.Text)
        'Dim tmp2 As String = UCase(cboNomFournisseur.Text)
        'Dim strsql As String = ""
        'Dim tmpResponse As Integer = 0
        'Dim MaCommande As New SqlClient.SqlCommand
        'If cboCodeFournisseur.FindString(cboCodeFournisseur.Text) = -1 Then
        '    Dim result As DialogResult = MessageBox.Show("Ce Fournisseur n'est pas dans la liste,voulez-vous mettre à jour la base locale?", "SAIGIC", MessageBoxButtons.YesNo)

        '    ' Me.Cursor = Cursors.WaitCursor
        '    DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))

        '    If result = DialogResult.No Then
        '        MessageBox.Show("Pas de mise à jour à faire")

        '    ElseIf result = DialogResult.Yes Then

        '        Try
        '            MaCommande = New SqlClient.SqlCommand("UPDATE_SERVEUR_VERS_SITE ", SaigicLocal_Cnx)
        '            MaCommande.CommandTimeout = 1200
        '            tmpResponse = MaCommande.ExecuteNonQuery
        '        Catch ex As Exception

        '        End Try


        '        If tmpResponse <> 0 Then
        '            MessageBox.Show("Mise à jour terminée")
        '            spvChargerFournisseur()
        '            cboCodeFournisseur.Focus()
        '        Else
        '            MessageBox.Show("Erreur mise à jour, veuillez vérifier votre connexion Internet")
        '        End If

        '    End If
        '    DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
        '    ' Me.Cursor = Cursors.Default

        'End If

        '' ************************* Test de Validite Agrment *********************

        ''Dim MonDA As New SqlClient.SqlDataAdapter
        ''Dim MonDS As New DataSet

        'MonDA = New SqlClient.SqlDataAdapter("SELECT * FROM vueFournisseur WHERE Fournisseur_ID='" & cboCodeFournisseur.Text & "'", SaigicLocal_Cnx)
        'Try
        '    MonDS.Tables("PeseeN2").Clear()
        'Catch ex As Exception

        'Finally
        '    MonDA.Fill(MonDS, "PeseeN2")
        'End Try

        'With MonDS.Tables("PeseeN2")
        '    Try
        '        Dim motif As String
        '        TxtValider.Text = .Rows(0)("ValiditeAgrement")
        '        motif = .Rows(0)("MotifRetrait")

        '        If TxtValider.Text <> "Valide" Then
        '            MsgBox("L'AGREMENT DE CE FOURNISSEUR " + vbCrLf + cboNomFournisseur.Text + " EST " + UCase(TxtValider.Text) + vbCrLf + vbCrLf + _
        '            "MOTIF : " + UCase(motif) + vbCrLf + vbCrLf + _
        '            "LA PESEE NE PEUT SE POURSUIVRE et NE PEUT ETRE ENREGISTREE", MsgBoxStyle.Information)
        '            cboCodeFournisseur.Text = "" : TxtValider.Text = ""
        '            BtnEnregistrer.Enabled = False
        '            btnCapture.Enabled = False
        '        Else
        '            BtnEnregistrer.Enabled = True
        '            btnCapture.Enabled = True
        '        End If
        '    Catch ex As Exception

        '    End Try

        'End With


        '' **************************** Fin Test **************************************

        'Dim tmp As String = UCase(cboCodeFournisseur.Text)
        'Dim tmp2 As String = UCase(cboNomFournisseur.Text)
        'Dim strsql As String = ""
        'Dim tmpResponse As Integer = 0
        'Dim MaCommande As New SqlClient.SqlCommand
        'Dim motif As String = ""

        'If cboCodeFournisseur.FindString(cboCodeFournisseur.Text) = -1 Then
        '    Dim result As DialogResult = MessageBox.Show("Ce Fournisseur n'est pas dans la liste,voulez-vous mettre à jour la base locale?", "SAIGIC", MessageBoxButtons.YesNo)

        '    ' Me.Cursor = Cursors.WaitCursor
        '    DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))

        '    If result = DialogResult.No Then
        '        MessageBox.Show("Pas de mise à jour à faire")

        '    ElseIf result = DialogResult.Yes Then

        '        Try
        '            MaCommande = New SqlClient.SqlCommand("vider_LesTables_Fournisseur ", SaigicLocal_Cnx)
        '            MaCommande.CommandTimeout = 1200
        '            tmpResponse = MaCommande.ExecuteNonQuery

        '            MaCommande = New SqlClient.SqlCommand("UPDATE_SERVEUR_VERS_SITE ", SaigicLocal_Cnx)
        '            MaCommande.CommandTimeout = 1200
        '            tmpResponse = MaCommande.ExecuteNonQuery
        '        Catch ex As Exception

        '        End Try

        '        If tmpResponse <> 0 Then
        '            MessageBox.Show("Mise à jour terminée")
        '            spvChargerFournisseur()
        '            cboCodeFournisseur.Focus()
        '        Else
        '            MessageBox.Show("Probleme de connexion Internet, Reessayer pkus tard")
        '        End If

        '    End If
        '    DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
        '    ' Me.Cursor = Cursors.Default
        'End If

        '' ************************* Test de Validite Agrment *********************

        ''Dim MonDA As New SqlClient.SqlDataAdapter
        ''Dim MonDS As New DataSet

        'MonDA = New SqlClient.SqlDataAdapter("SELECT * FROM Exportateur WHERE Id_EXP='" & cboCodeExportateur.Text & "'", SaigicLocal_Cnx)
        'Try
        '    MonDS.Tables("PeseeN2").Clear()
        'Catch ex As Exception

        'Finally
        '    MonDA.Fill(MonDS, "PeseeN2")
        'End Try

        'With MonDS.Tables("PeseeN2")
        '    Try

        '        TxtValider.Text = .Rows(0)("ValiditeAgrement")

        '        Try
        '            motif = .Rows(0)("MotifRetrait")
        '        Catch ex As Exception

        '        End Try

        '        If TxtValider.Text <> "Valide" Then
        '            MsgBox("L'AGREMENT DE CET EXPORTATEUR " + vbCrLf + cboNomFournisseur.Text + " EST " + UCase(TxtValider.Text) + vbCrLf + vbCrLf + _
        '            "MOTIF : " + UCase(motif) + vbCrLf + vbCrLf + _
        '            "LA PESEE NE PEUT SE POURSUIVRE et NE PEUT ETRE ENREGISTREE", MsgBoxStyle.Information)
        '            cboCodeFournisseur.Text = "" : TxtValider.Text = ""
        '            BtnEnregistrer.Enabled = False
        '            btnCapture.Enabled = False
        '        Else
        '            BtnEnregistrer.Enabled = True
        '            btnCapture.Enabled = True
        '        End If
        '    Catch ex As Exception

        '    End Try

        'End With


        '' **************************** Fin Test **************************************

        Dim tmp As String = UCase(cboCodeFournisseur.Text)
        Dim tmp2 As String = UCase(cboCodeFournisseur.Text)
        Dim strsql As String = ""

        Dim tmpResponse As Integer = 0
        Dim MaCommande As New SqlClient.SqlCommand
        Dim Motif As String = "" : Dim Valider As String

        If cboCodeExportateur.FindString(cboCodeExportateur.Text) = -1 Then
            Dim result As DialogResult = MessageBox.Show("Cet Exportateur n'est pas dans la liste,voulez-vous mettre à jour la base locale?", "SAIGIC", MessageBoxButtons.YesNo)

            ' Me.Cursor = Cursors.WaitCursor
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))

            If result = DialogResult.No Then
                MessageBox.Show("Pas de mise à jour à faire")

            ElseIf result = DialogResult.Yes Then

                '        Try
                '            MaCommande = New SqlClient.SqlCommand("vider_LesTables_Fournisseur ", SaigicLocal_Cnx)
                '            MaCommande.CommandTimeout = 1200
                '            tmpResponse = MaCommande.ExecuteNonQuery

                '            MaCommande = New SqlClient.SqlCommand("UPDATE_SERVEUR_VERS_SITE ", SaigicLocal_Cnx)
                '            MaCommande.CommandTimeout = 1200
                '            tmpResponse = MaCommande.ExecuteNonQuery
                '        Catch ex As Exception

                '        End Try


                '        If tmpResponse <> 0 Then
                '            MessageBox.Show("Mise à jour terminée")
                '            spvChargerFournisseur()
                '            cboCodeExportateur.Focus()
                '        Else
                '            MessageBox.Show("Erreur mise à jour, veuillez vérifier votre connexion Internet")
                '        End If

                '    End If
                '    DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
                '    ' Me.Cursor = Cursors.Default

                'End If

                '' ************************* Test de Validite Agrment *********************

                ''Dim MonDA As New SqlClient.SqlDataAdapter
                ''Dim MonDS As New DataSet

                'MonDA = New SqlClient.SqlDataAdapter("SELECT * FROM vueFournisseur WHERE Fournisseur_ID='" & cboCodeExportateur.Text & "'", SaigicLocal_Cnx)
                'Try
                '    MonDS.Tables("PeseeN2").Clear()
                'Catch ex As Exception

                'Finally
                '    MonDA.Fill(MonDS, "PeseeN2")
                'End Try

                'With MonDS.Tables("PeseeN2")
                '    Try
                '        'Dim motif, valider As String
                '        valider = .Rows(0)("ValiditeAgrement")
                '        motif = .Rows(0)("MotifRetrait")

                '        If valider <> "Valide" Then
                '            MsgBox("L'AGREMENT DE CET EXPORTATEUR " + vbCrLf + cboNomExportateur.Text + " EST " + UCase(valider) + vbCrLf + vbCrLf + _
                '            "MOTIF : " + UCase(motif) + vbCrLf + vbCrLf + _
                '            "LA PESEE NE PEUT SE POURSUIVRE et NE PEUT ETRE ENREGISTREE", MsgBoxStyle.Information)
                '            cboCodeExportateur.Text = ""
                '            BtnEnregistrer.Enabled = False
                '            btnCapture.Enabled = False
                '        Else
                '            BtnEnregistrer.Enabled = True
                '            btnCapture.Enabled = True
                '        End If
                '    Catch ex As Exception

                '    End Try

                'End With


                ' **************************** Fin Test **************************************

                Try
                    MaCommande = New SqlClient.SqlCommand("vider_LesTables_Fournisseur ", SaigicLocal_Cnx)
                    MaCommande.CommandTimeout = 1200
                    tmpResponse = MaCommande.ExecuteNonQuery

                    MaCommande = New SqlClient.SqlCommand("UPDATE_SERVEUR_VERS_SITE ", SaigicLocal_Cnx)
                    MaCommande.CommandTimeout = 1200
                    tmpResponse = MaCommande.ExecuteNonQuery
                Catch ex As Exception

                End Try

                If tmpResponse <> 0 Then
                    MessageBox.Show("Mise à jour terminée")
                    spvChargerFournisseur()
                    cboCodeFournisseur.Focus()
                Else
                    MessageBox.Show("Probleme de connexion Internet, Reessayer pkus tard")
                End If

            End If
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
            ' Me.Cursor = Cursors.Default
        End If

        ' ************************* Test de Validite Agrment *********************

        'Dim MonDA As New SqlClient.SqlDataAdapter
        'Dim MonDS As New DataSet

        MonDA = New SqlClient.SqlDataAdapter("SELECT * FROM Exportateur WHERE Id_EXP=" & cboCodeFournisseur.Text, SaigicLocal_Cnx)
        Try
            MonDS.Tables("PeseeN2").Clear()
        Catch ex As Exception

        Finally
            MonDA.Fill(MonDS, "PeseeN2")
        End Try

        With MonDS.Tables("PeseeN2")
            Try

                Valider = .Rows(0)("ValiditeAgrement")

                Try
                    Motif = .Rows(0)("MotifRetrait")
                Catch ex As Exception

                End Try

                If Valider <> "Valide" Then
                    MsgBox("CET EXPORTATEUR " + cboNomFournisseur.Text + " est " + UCase(Valider) + vbCrLf + vbCrLf + _
                    "MOTIF : " + UCase(Motif) + vbCrLf + vbCrLf + _
                    "LA PESEE NE PEUT SE POURSUIVRE et NE PEUT ETRE ENREGISTREE", MsgBoxStyle.Information)
                    cboCodeFournisseur.Text = "" ' TxtValider.Text = ""
                    BtnEnregistrer.Enabled = False
                    btnCapture.Enabled = False
                Else
                    BtnEnregistrer.Enabled = True
                    btnCapture.Enabled = True
                End If
            Catch ex As Exception

            End Try

        End With


        ' **************************** Fin Test **************************************

    End Sub
    Private Sub cboCodeExportateur_Leave(sender As Object, e As EventArgs) Handles cboCodeExportateur.Leave
        Dim tmp As String = UCase(cboCodeExportateur.Text)
        Dim tmp2 As String = UCase(cboCodeExportateur.Text)
        Dim strsql As String = ""
        Dim tmpResponse As Integer = 0
        Dim MaCommande As New SqlClient.SqlCommand
        If cboCodeExportateur.FindString(cboCodeExportateur.Text) = -1 Then
            Dim result As DialogResult = MessageBox.Show("Cet Exportateur n'est pas dans la liste,voulez-vous mettre à jour la base locale?", "SAIGIC", MessageBoxButtons.YesNo)

            ' Me.Cursor = Cursors.WaitCursor
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))

            If result = DialogResult.No Then
                MessageBox.Show("Pas de mise à jour à faire")

            ElseIf result = DialogResult.Yes Then

                Try
                    MaCommande = New SqlClient.SqlCommand("UPDATE_SERVEUR_VERS_SITE ", SaigicLocal_Cnx)
                    MaCommande.CommandTimeout = 1200
                    tmpResponse = MaCommande.ExecuteNonQuery
                Catch ex As Exception

                End Try


                If tmpResponse <> 0 Then
                    MessageBox.Show("Mise à jour terminée")
                    spvChargerFournisseur()
                    cboCodeExportateur.Focus()
                Else
                    MessageBox.Show("Erreur mise à jour, veuillez vérifier votre connexion Internet")
                End If

            End If
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
            ' Me.Cursor = Cursors.Default

        End If

        ' ************************* Test de Validite Agrment *********************

        'Dim MonDA As New SqlClient.SqlDataAdapter
        'Dim MonDS As New DataSet

        MonDA = New SqlClient.SqlDataAdapter("SELECT * FROM vueFournisseur WHERE Fournisseur_ID='" & cboCodeFournisseur.Text & "'", SaigicLocal_Cnx)
        Try
            MonDS.Tables("PeseeN2").Clear()
        Catch ex As Exception

        Finally
            MonDA.Fill(MonDS, "PeseeN2")
        End Try

        With MonDS.Tables("PeseeN2")
            Try
                Dim motif, valider As String
                valider = .Rows(0)("ValiditeAgrement")
                motif = .Rows(0)("MotifRetrait")

                If valider <> "Valide" Then
                    MsgBox("L'AGREMENT DE CE FOURNISSEUR " + vbCrLf + cboNomExportateur.Text + " EST " + UCase(valider) + vbCrLf + vbCrLf + _
                    "MOTIF : " + UCase(motif) + vbCrLf + vbCrLf + _
                    "LA PESEE NE PEUT SE POURSUIVRE et NE PEUT ETRE ENREGISTREE", MsgBoxStyle.Information)
                    cboCodeExportateur.Text = ""
                    BtnEnregistrer.Enabled = False
                    btnCapture.Enabled = False
                Else
                    BtnEnregistrer.Enabled = True
                    btnCapture.Enabled = True
                End If
            Catch ex As Exception

            End Try

        End With


        ' **************************** Fin Test **************************************

    End Sub

    Private Sub Btn_Imprimer_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Imprimer.Click

        'Dim MyDA As New SqlClient.SqlDataAdapter
        'Dim MyDS As New DataSet

        '********************************************************************
        Dim ppvSQL As String = ""
        Dim MonMax As Integer
        'Dim prefix As String = Mid(TextBox7.Text, 6, 3)
        MyDA = New SqlClient.SqlDataAdapter

        MyDA = New SqlClient.SqlDataAdapter("Select Max(NumeroTicket) as LeMax from Pesee", SaigicLocal_Cnx)
        MyDA.Fill(MyDS, "LastOne")
        MonMax = MyDS.Tables("lastOne").Rows(0)("LeMax").ToString
        MonMax = MonMax + 1

        'TextBox8.Text = MonMax & " " & prefix & " " & TextBox4.Text

        'ppvSQL = "UPDATE pesée SET codesaco=" & MonMax & ",barcode='" & TextBox8.Text & "' WHERE codepesée = " & TxtNumeroPesee.Text
        'MyDA.UpdateCommand = New SqlClient.SqlCommand(ppvSQL, SaigicLocal_Cnx)
        'MyDA.UpdateCommand.ExecuteNonQuery()

        MyDS.Tables("lastone").Clear()

        '****************************** Code  impression  *****************************************************

        Dim MyView As New FrmVisionneuse        'Dim Report As New Etat_Ticket
        Dim MonRapport As New TicketCacao
        'Dim MonRapport As New Etat_Ticket_Cacao

        ' ''Dim cmd As OleDb.OleDbCommand
        ''Dim paramCmd As OleDb.OleDbParameter
        ''Dim DataSetTicket As New DataSet_Etat_Ticket

        Me.Cursor = Cursors.WaitCursor

        ' Code ancien

        MyDA = New SqlClient.SqlDataAdapter("SELECT * FROM VueTicketCacao WHERE codepesee ='" & TxtNumeroPesee.Text & "'", SaigicLocal_Cnx)
        'MyDA = New SqlClient.SqlDataAdapter("SELECT * FROM VuePeseesCompletesCAcao WHERE codepesee ='" & TxtNumeroPesee.Text & "'", SaigicLocal_Cnx)
        MyDA.Fill(MyDS, "R_Recherches")

        MonRapport.SetDataSource(MyDS.Tables("R_Recherches"))
        MonRapport.SetParameterValue("ParamCode", TxtNumeroPesee.Text)
        MyView.CrystalReportViewer1.ReportSource = MonRapport
        MyView.Text = MonRapport.Name

        'Fin code ancien

        '' '' Utlisation d'undataset avec crystal report
        ' ''paramCmd = New OleDb.OleDbParameter("@NumTicket", TextBoxPesee.Text)
        ' ''MonDA = New OleDb.OleDbDataAdapter("SELECT * FROM R_Recherches WHERE codepesée = @NumTicket", SAIGIC_Cnx)
        ' ''MonDA.Fill(DataSetTicket, "R_Recherches")
        ' ''MonRapport.SetDataSource(MonDataSet.Tables("R_Recherches"))
        ' ''MyView.CrystalReportViewer1.ReportSource = MonRapport
        ' ''MyView.Text = MonRapport.Name




        'todo: Code d'impression directe à inserer

        'Dim ImprimanteLocale As System.Drawing.Printing.PrintDocument = New Printing.PrintDocument()
        'MonRapport.PrintOptions.PrinterName = ImprimanteLocale.PrinterSettings.PrinterName
        'MonRapport.PrintToPrinter(PrintDialog.PrinterSettings.Copies, PrintDialog.PrinterSettings.Collate, PrintDialog.PrinterSettings.FromPage, PrintDialog.PrinterSettings.ToPage)
        'MonRapport.Close()
        'PrintDialog.Dispose()

        ' ce code affiche une boite de dialogue d'impression, pas necessaire ds mon cas
        '************************************************************************************************
        'If PrintDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
        'MonRapport.PrintOptions.PaperSource = PaperSource.Auto
        'MonRapport.PrintOptions.PrinterName = PrintDialog.PrinterSettings.PrinterName
        'MonRapport.PrintToPrinter(PrintDialog.PrinterSettings.Copies, PrintDialog.PrinterSettings.Collate, PrintDialog.PrinterSettings.FromPage, PrintDialog.PrinterSettings.ToPage)
        'MonRapport.Close()
        'End If
        'PrintDialog.Dispose()
        '*************************************************************************************************
        Me.Cursor = Cursors.Default

        MyView.ShowDialog()
        MyDS.Tables("R_Recherches").Clear()

        '********************************************************************
        'ppvSQL = "UPDATE Pesee SET imprime=true WHERE codepesee = " & TxtNumeroPesee.Text

        'MyDA.UpdateCommand = New SqlClient.SqlCommand(ppvSQL, SaigicLocal_Cnx)
        'MyDA.UpdateCommand.ExecuteNonQuery()
        'spvChargerListeAttente()
        'InitialiseSaisie(Me)
        'spvInitialiserCommandes()
        'Me.Label1.Text = "1ere pesée"
        'Me.Label1.BackColor = Color.Green
        Me.Refresh()

        'todo : enregistrement de la pesée ds le fichier xml

        'Calcul()
        'End If
    End Sub

    Private Sub cboCodeFournisseur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodeFournisseur.SelectedIndexChanged

    End Sub

    Private Sub cboCodeExportateur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodeExportateur.SelectedIndexChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class