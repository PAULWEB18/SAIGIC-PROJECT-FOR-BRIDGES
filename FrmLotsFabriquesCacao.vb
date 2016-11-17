Imports DCSaigicLight
Imports System.IO
Imports Microsoft.Office.Interop
Public Class FrmLotsFabriquesCacao

#Region "Declaration"

    Dim MonLot As New DCSaigicLight.BObject.Fabrication
    Dim ListeExportateursFournisseur As New DCSaigicLight.BObject.Exportateurs

    Dim listeProduits As New DCSaigicLight.BObject.Produits


    Dim listeSites As New DCSaigicLight.BObject.Sites

    Private intTypeOuverture As lstTypeOuverture
    Private Cle As String
    Dim CodeFabrication As String
    Dim MonDA As New SqlClient.SqlDataAdapter
    Dim MonDS As New DataSet

#End Region

    Public Enum lstTypeOuvertureFiche
        ' Ajouter un nouvel enregistrement => Formulaire vierge
        ModeAjouter
        ' Modifier un enregistrement (Argument ID_Filtre obligatoire) => Formulaire chargé avec l'enregistrement correspondant
        ModeModifier
    End Enum

#Region "Zone de réflexion "

    Dim frmParente As FrmLotsFabriquesCacaoListe
    Public WriteOnly Property Parente() As FrmLotsFabriquesCacaoListe
        Set(ByVal value As FrmLotsFabriquesCacaoListe)
            frmParente = value
        End Set
    End Property

#End Region

    Private Sub spvchargerInterfaces()

        txtNumeroLigne.Text = ""
        cboProduit.Text = ""
        txtMarque.Text = ""
        txtNumeroLot.Text = ""
        cboGrade.SelectedIndex = -1

        ListeExportateursFournisseur.LoadExportateurs()
        spbChargerDropDownList(ListeExportateursFournisseur, cboCodeFournisseur, "Id_EXP", "Id_EXP")
        spbChargerDropDownList(ListeExportateursFournisseur, cboNomFournisseur, "Id_EXP", "Exportateur")
        cboNomFournisseur.SelectedIndex = -1
        cboCodeFournisseur.SelectedIndex = -1


        listeProduits.LoadProduits()
        listeProduits = listeProduits.FindProduitsByFamille("CACAO")
        spbChargerDropDownList(listeProduits, cboProduit, "LibelleProduit", "LibelleProduit")
        cboProduit.SelectedIndex = -1


    End Sub

    Private Sub spvAfficherLot()
        Dim tmpOBj As New DCSaigicLight.BObject.Fabrications
        tmpOBj.LoadFabrications()
        MonLot = tmpOBj.FindFabrication(Cle, CodeFabrication)

        With MonLot
            cboCodeFournisseur.SelectedValue = .Exportateur
            mskDateFabrication.Text = .DateFabrication
            TxtCodeFabrication.Text = .CodeFabrication
            txtNumeroLigne.Text = Cle
            cboProduit.SelectedIndex = cboProduit.FindString(.Produit)
            txtMarque.Text = .ProduitMarque
            txtNumeroLot.Text = .NumeroLot
            cboGrade.SelectedIndex = cboGrade.FindString(.Grade)
            txtNombreSacs.Text = .NbSacs
            txtPoidsTheorique.Text = .PoidsTheorique
        End With

    End Sub


    Private Sub FrmReception_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        spvchargerInterfaces()
        txtCodeSite.Text = MonSite.IDSite
        txtNomSite.Text = MonSite.NomCourt
        txtCodePont.Text = MonPont.CodePont
        txtCampagne.Text = MaCampagne
        'mskAnneeRecolte.Text = MaCampagne
        txtTypePont.Text = MonPont.Typepont
        txtPoidsTheorique.Text = CDec(txtNombreSacs.Text) * 65

        Try
            ' Charger le formulaire
            Select Case intTypeOuverture
                Case lstTypeOuvertureFiche.ModeAjouter   ' "Ajouter"
                    ' Paramétrage du formulaire
                    Me.Text = Me.Text & " - Nouveau"
                    mskDateFabrication.ReadOnly = False
                    txtNumeroLigne.ReadOnly = False
                    mskAnneeRecolte.Text = MaCampagne

                Case lstTypeOuvertureFiche.ModeModifier  ' "Modifier"
                    ' Paramètrage du formulaire
                    'CheckBox1.Visible = False
                    mskDateFabrication.ReadOnly = True
                    txtNumeroLigne.ReadOnly = True
                    Me.Text = Me.Text & " - Modifier"
                    spvAfficherLot()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try




    End Sub

    Private Sub SaisieNombreEntier(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroLigne.KeyPress, txtPoidsTheorique.KeyPress, txtNombreSacs.KeyPress

        Dim Permis = "0123654789" & Chr(13) & Chr(8)
        If InStr(Permis, e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub



    Private Sub TextBox31_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Label48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub BtnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnregistrer.Click

        Dim tmpReponse As Integer = 0

        Dim TmpOBJ As New DCSaigicLight.BObject.Fabrications
        TmpOBJ.LoadFabrications()

        'Controle des saisies
        If Not ValideSaisiesLot() Then
            MsgBox("Erreur de saisie !!!!")
            Exit Sub
        End If


        Try

            Select Case intTypeOuverture
                Case lstTypeOuvertureFiche.ModeAjouter   ' "Ajouter"
                    TmpOBJ.AddBObjectFabrication(txtNumeroLigne.Text, TxtCodeFabrication.Text, txtCampagne.Text, txtCodeSite.Text, cboCodeFournisseur.SelectedValue, mskDateFabrication.Text, mskAnneeRecolte.Text, cboProduit.Text, txtMarque.Text, cboGrade.Text, txtNumeroLot.Text, txtNombreSacs.Text, txtPoidsTheorique.Text, 0, 0, Now.Date, Now.Date, Now.Date, Moi.CodeUser)


                Case lstTypeOuvertureFiche.ModeModifier  ' "Modifier"
                    TmpOBJ.UpdateBObjectAnneeRecolte(txtNumeroLigne.Text, TxtCodeFabrication.Text, mskAnneeRecolte.Text)
                    TmpOBJ.UpdateBObjectExportateur(txtNumeroLigne.Text, TxtCodeFabrication.Text, cboCodeFournisseur.SelectedValue)

                    TmpOBJ.UpdateBObjectProduit(txtNumeroLigne.Text, TxtCodeFabrication.Text, cboProduit.Text)
                    TmpOBJ.UpdateBObjectProduitMarque(txtNumeroLigne.Text, TxtCodeFabrication.Text, txtMarque.Text)
                    TmpOBJ.UpdateBObjectNumeroLot(txtNumeroLigne.Text, TxtCodeFabrication.Text, txtNumeroLot.Text)

                    TmpOBJ.UpdateBObjectGrade(txtNumeroLigne.Text, TxtCodeFabrication.Text, cboGrade.Text)
                    TmpOBJ.UpdateBObjectNbSacs(txtNumeroLigne.Text, TxtCodeFabrication.Text, txtNombreSacs.Text)
                    TmpOBJ.UpdateBObjectPoidsTheorique(txtNumeroLigne.Text, TxtCodeFabrication.Text, txtPoidsTheorique.Text)

                    TmpOBJ.UpdateBObjectDateModification(txtNumeroLigne.Text, TxtCodeFabrication.Text, Now.Date)
                    TmpOBJ.UpdateBObjectOperateurModification(txtNumeroLigne.Text, TxtCodeFabrication.Text, Moi.CodeUser)
            End Select
            tmpReponse = TmpOBJ.UpdateAllBData()
            If tmpReponse = 1 Then
                MsgBox("Enregistrement effectue avec succes")
            Else
                MsgBox("Erreur d'enregistrement", vbCritical)
            End If
            'Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Finally

        End Try


        Try
            Select Case intTypeOuverture
                Case lstTypeOuvertureFiche.ModeAjouter
                    FrmReception_Load(Nothing, Nothing)
                    txtNumeroLigne.Focus()
                Case lstTypeOuvertureFiche.ModeModifier
                    Me.Close()
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Function ValideSaisiesLot() As Boolean

        ' Valider la saisie
        ValideSaisiesLot = True
        ' Effacer les icônes erreur
        Me.ErrorProvider1.Clear()

        If Me.cboCodeFournisseur.SelectedValue = Nothing Then
            Me.ErrorProvider1.SetError(Me.cboCodeFournisseur, "Champs obligatoire.")
            Me.cboCodeFournisseur.Focus()
            ValideSaisiesLot = False
        End If

        If Me.cboNomFournisseur.SelectedValue = Nothing Then
            Me.ErrorProvider1.SetError(Me.cboNomFournisseur, "Champs obligatoire.")
            Me.cboNomFournisseur.Focus()
            ValideSaisiesLot = False
        End If

        If Me.cboGrade.Text = "" Then
            Me.ErrorProvider1.SetError(Me.cboGrade, "Champs obligatoire.")
            Me.cboGrade.Focus()
            ValideSaisiesLot = False
        End If

        If Me.cboProduit.SelectedValue = Nothing Then
            Me.ErrorProvider1.SetError(Me.cboProduit, "Champs obligatoire.")
            Me.cboProduit.Focus()
            ValideSaisiesLot = False
        End If

        If Not IsNumeric(Me.txtNumeroLigne.Text) Then
            Me.ErrorProvider1.SetError(Me.txtNumeroLigne, "Champs obligatoire.")
            Me.txtNumeroLigne.Focus()
            ValideSaisiesLot = False
        End If

        If Not IsNumeric(Me.txtNombreSacs.Text) Then
            Me.ErrorProvider1.SetError(Me.txtNombreSacs, "Champs obligatoire.")
            Me.txtNombreSacs.Focus()
            ValideSaisiesLot = False
        End If

        If Not IsNumeric(Me.txtPoidsTheorique.Text) Then
            Me.ErrorProvider1.SetError(Me.txtPoidsTheorique, "Champs obligatoire.")
            Me.txtPoidsTheorique.Focus()
            ValideSaisiesLot = False
        End If

        If Me.txtNumeroLot.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtNumeroLot, "Champs obligatoire.")
            Me.txtNumeroLot.Focus()
            ValideSaisiesLot = False
        End If

        If Me.txtMarque.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtMarque, "Champs obligatoire.")
            Me.txtMarque.Focus()
            ValideSaisiesLot = False
        End If

        If Not IsDate(Me.mskDateFabrication.Text) Then
            Me.ErrorProvider1.SetError(Me.mskDateFabrication, "Champs obligatoire.")
            Me.mskDateFabrication.Focus()
            ValideSaisiesLot = False
        End If

        If InStr(Me.mskAnneeRecolte.Text, "_") <> 0 Then
            Me.ErrorProvider1.SetError(Me.mskAnneeRecolte, "Champs obligatoire.")
            Me.mskAnneeRecolte.Focus()
            ValideSaisiesLot = False
        End If

        If TxtCodeFabrication.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TxtCodeFabrication, "Champs obligatoire.")
            Me.TxtCodeFabrication.Focus()
            ValideSaisiesLot = False
        End If
    End Function


    Private Sub BtnFerner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFerner.Click
        Me.Close()

    End Sub

    Public Sub New(ByVal Ouverture As Integer, Optional ByVal bvlCodeFabrication As String = "", Optional ByVal ID As Integer = -1)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        If ID <> -1 Then
            Cle = ID
        End If
        intTypeOuverture = Ouverture
        CodeFabrication = bvlCodeFabrication
    End Sub

    Private Sub SelectionContenu(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
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

    



    Private Sub SortiedeChampNumerique(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender.text = "" Or sender.text = "." Then
            sender.text = 0
        End If
    End Sub



    Private Sub txtNumeroAnalyse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboEmballage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub TxtConnaissement_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = "'" Then
            e.KeyChar = ""
        End If

    End Sub


    Private Sub cboRemorque_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    





    Private Sub TxtCodeFabrication_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodeFabrication.TextChanged

    End Sub
    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub mskDateFabrication_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskDateFabrication.Leave
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

        TxtCodeFabrication.Text = MonPont.CodePont & "_" & Annee & Mois & Jour
    End Sub

    Private Sub mskDateAnalyse_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskDateFabrication.MaskInputRejected

    End Sub

    Private Sub mskDateFabrication_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskDateFabrication.MouseLeave

    End Sub

    Private Sub NumeroLigne_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroLigne.KeyPress

    End Sub

    Private Sub txtNombreSacs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreSacs.TextChanged
        'txtPoidsTheorique.Text = CDec(txtNombreSacs.Text) * 65
        txtPoidsTheorique.Text = Val(txtNombreSacs.Text) * 65
    End Sub

    Private Sub txtNumeroLigne_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumeroLigne.Leave
        If txtNombreSacs.Text = "" Then txtNombreSacs.Text = "0"
    End Sub

    Private Sub cboCodeFournisseur_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCodeFournisseur.Leave
        Dim tmp As String = UCase(cboCodeFournisseur.Text)
        Dim tmp2 As String = UCase(cboCodeFournisseur.Text)
        Dim strsql As String = ""

        Dim tmpResponse As Integer = 0
        Dim MaCommande As New SqlClient.SqlCommand
        Dim Motif As String = "" : Dim Valider As String

        If cboCodeFournisseur.FindString(cboCodeFournisseur.Text) = -1 Then
            Dim result As DialogResult = MessageBox.Show("Cet Exportateur n'est pas dans la liste,voulez-vous mettre à jour la base locale?", "SAIGIC", MessageBoxButtons.YesNo)

            ' Me.Cursor = Cursors.WaitCursor
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))

            If result = DialogResult.No Then
                MessageBox.Show("Pas de mise à jour à faire")

            ElseIf result = DialogResult.Yes Then

           
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
                    ' spvChargerFournisseur()
                    ' cboCodeFournisseur.Focus()
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
                    'btnCapture.Enabled = False
                Else
                    BtnEnregistrer.Enabled = True
                    ' btnCapture.Enabled = True
                End If
            Catch ex As Exception

            End Try

        End With


        ' **************************** Fin Test **************************************
    End Sub

    Private Sub cboCodeFournisseur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodeFournisseur.SelectedIndexChanged

    End Sub
End Class