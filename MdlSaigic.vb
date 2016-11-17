Imports DCSaigicLight
Imports System.Security
Imports System.Windows.Forms
Imports System.IO
Module MdlSaigic
    Public SaigicLocal_Cnx As SqlClient.SqlConnection
    Public SaigicServerSqlNatif_Cnx As SqlClient.SqlConnection
    Public SaigicServerODBC_Cnx As Odbc.OdbcConnection

    Public SaigicServerDB As String
    Public LinkedSrvName As String

    Public MonParametre As DCSaigicLight.BObject.Parametres

    Public Moi As New DCSaigicLight.BObject.Utilisateur
    Public MonSite As New DCSaigicLight.BObject.Site
    Public MonPont As New DCSaigicLight.BObject.Pont
    Public MaCampagne As String
    Public SigneVirgule As String
    'variable publi boolean
    Public bvlAlerte As Boolean



    ' Vérifier l'existence d'un formulaire
    Public Enum lstOptVerifSiFormOuverte
        Fermer
        Active
    End Enum

    Public Enum lstOpenOption
        Non_dialog
        Dialog
    End Enum

    Public Enum ModeOuverture
        Pesee
        Gestion
    End Enum

    Public Enum LesGradesCacao
        SG
        G2
        G1
    End Enum

    Public Enum lstTypeOuverture

        ModePesee1 ' Ajouter un nouvel enregistrement => Formulaire vierge

        Modepesee2 ' Modification avec possibilité d'ajouter la pesée 2

        ModeValidation 'Modification avec possibilité de valider

        ModeConsultation 'Lecture seule
    End Enum

    Public Sub main()
        Dim tmp As StreamReader
        Dim tmpSvr As StreamReader
        Dim tmp2 As String
        Dim MaConfConnexion As FrmConfigurationConnexion
        Try
            tmp = New StreamReader("Local")
        Catch ex As Exception
            tmp = Nothing
            MaConfConnexion = New FrmConfigurationConnexion(1)
            launchForm(MaConfConnexion, 1)
        End Try

        Try
            tmpSvr = New StreamReader("Server")
        Catch ex As Exception
            tmpSvr = Nothing

            MaConfConnexion = New FrmConfigurationConnexion(1)
            launchForm(MaConfConnexion, 1)
        End Try

        tmp2 = tmp.ReadLine()

        LinkedSrvName = tmpSvr.ReadLine()
        SaigicServerDB = tmpSvr.ReadLine()

        Try
            SaigicLocal_Cnx = New SqlClient.SqlConnection(tmp2)
            SaigicLocal_Cnx.Open()
            SaigicLocal_Cnx.Close()
        Catch ex As Exception
            MaConfConnexion = New FrmConfigurationConnexion(1)
            launchForm(MaConfConnexion, 1)
        Finally

        End Try
        Try
            DCSaigicLight.BData.SqlClientConnected.sConnectionString = tmp2
        Catch ex As Exception
            MaConfConnexion = New FrmConfigurationConnexion(1)
            launchForm(MaConfConnexion, 1)
        End Try

        spbChargerParametresBase()

    End Sub

    Public Sub spbChargerParametresBase()
        Dim tmpParam As New DCSaigicLight.BObject.Parametress
        tmpParam.LoadParametress()
        MonParametre = tmpParam.FindParametres("01")

        Dim tmpSite As New DCSaigicLight.BObject.Sites
        tmpSite.LoadSites()
        MonSite = tmpSite.FindSite(MonParametre.CodeSite)


        Dim tmpPont As New DCSaigicLight.BObject.Ponts
        tmpPont.LoadPonts()
        MonPont = tmpPont.FindPont(MonParametre.CodePont)

        If Month(Now.Date) >= 10 Then
            MaCampagne = Year(Now.Date) & "/" & Year(Now.Date) + 1
        Else
            MaCampagne = Year(Now.Date) - 1 & "/" & Year(Now.Date)
        End If

        'Signe de la virgule
        Dim Nombre As Single, tmp As String
        Nombre = 3 / 7
        tmp = CStr(Nombre)
        If InStr(tmp, ",") <> 0 Then
            SigneVirgule = ","
        Else
            SigneVirgule = "."
        End If
    End Sub

    Public Function fpbVerificationOperateur(ByVal bvlCode As String, ByVal bvlMotDepasse As String) As Boolean

        Dim MesUsers As New DCSaigicLight.BObject.Utilisateurs
        Dim MonUser As New DCSaigicLight.BObject.Utilisateur

        MesUsers.LoadUtilisateurs()

        MonUser = MesUsers.FindUtilisateur(bvlCode)
        If (MonUser.Profil <> "PES") And (MonUser.Profil <> "SUP") Then
            fpbVerificationOperateur = False
            Exit Function
        End If

        If MonUser.Actif = 0 Then
            fpbVerificationOperateur = False
            Exit Function
        End If

        If MonUser.MotPasse = ToMD5(bvlMotDepasse) Then
            fpbVerificationOperateur = True
            Moi = MonUser
        Else
            Moi = New DCSaigicLight.BObject.Utilisateur
            fpbVerificationOperateur = False
        End If
    End Function

    Public Function ToMD5(ByVal bvlChaine As String) As String
        Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(bvlChaine)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        strResult = UCase(strResult)
        ToMD5 = strResult
    End Function
    Public Function VerifSiFormOuverte(ByVal strTextForm As String, ByVal strOptVerifSiFormOuverte As lstOptVerifSiFormOuverte) As Boolean

        VerifSiFormOuverte = False

        For Each f As Form In My.Application.OpenForms

            If f.Text = strTextForm Then

                Select Case strOptVerifSiFormOuverte

                    Case lstOptVerifSiFormOuverte.Active
                        f.Activate()
                        VerifSiFormOuverte = True
                        Exit For

                    Case lstOptVerifSiFormOuverte.Fermer
                        f.Close()
                        Exit For

                End Select

            End If

        Next

    End Function

    Public Sub spbChargerDropDownList(ByVal Source As Object, ByRef MyDDL As ComboBox, ByVal Valeur As String, ByVal Texte As String)
        MyDDL.DataSource = Source
        MyDDL.DisplayMember = Texte
        MyDDL.ValueMember = Valeur
    End Sub

    Public Sub spbActivationMenu(ByRef brfInterface As ToolStripMenuItem, ByVal MonMode As String)
        Dim Tmp As Object
        On Error Resume Next
        For Each Tmp In brfInterface.DropDownItems
            If TypeOf (Tmp) Is ToolStripMenuItem Then
                If InStr(Tmp.Tag, MonMode) <> 0 Then
                    Tmp.visible = True
                    'spbActivationMenu(Tmp, MonMode)
                Else
                    Tmp.visible = False
                End If
            Else
                Tmp.visible = False
            End If
        Next
    End Sub

    Public Sub InitialiseSaisie(ByRef brfInterface As Object)
        '    Dim Idx As Integer, Max As Integer
        '    Dim MyPanel As Panel
        '    Dim MyTab As TabControl
        '    Dim MyGroup As GroupBox

        '    Max = brfInterface.Controls.Count() - 1

        '    For Idx = 0 To Max
        '        MsgBox(brfInterface.Controls(Idx).GetType().ToString)
        '        If TypeOf (brfInterface.Controls(Idx)) Is Panel Then
        '            Try
        '                MyPanel = DirectCast(brfInterface.Controls(Idx), Panel)
        '                InitialiseSaisie(MyPanel)
        '            Catch ex As Exception
        '                'MsgBox(ex.Message)
        '            End Try
        '        ElseIf TypeOf (brfInterface.Controls(Idx)) Is GroupBox Then
        '            Try
        '                MyGroup = DirectCast(brfInterface.Controls(Idx), GroupBox)
        '                InitialiseSaisie(MyGroup)
        '            Catch ex As Exception
        '                'MsgBox(ex.Message)
        '            End Try
        '        ElseIf TypeOf (brfInterface.Controls(Idx)) Is TabControl Then
        '            Try
        '                MyTab = DirectCast(brfInterface.Controls(Idx), TabControl)
        '                InitialiseSaisie(MyTab)
        '            Catch ex As Exception
        '                'MsgBox(ex.Message)
        '            End Try
        '        Else
        '            Try
        '                InitialiseSaisieField(brfInterface.Controls(Idx))
        '            Catch ex As Exception

        '            End Try

        '        End If
        '    Next
    End Sub

    Public Sub InitialiseSaisieGroupBox(ByVal brfInterface As GroupBox)

    End Sub

    Public Sub InitialiseSaisieTab(ByVal brfInterface As TabControl)

    End Sub

    Public Sub InitialiseSaisiePanel(ByVal brfInterface As Panel)

    End Sub

    Public Sub InitialiseSaisieField(ByVal brfInterface As Object)

        If TypeOf (brfInterface) Is TextBox Then
            If brfInterface.Tag = "Num" Then
                brfInterface.Text = ""
            Else
                brfInterface.ResetText()
            End If

        End If

        If TypeOf (brfInterface) Is MaskedTextBox Then
            brfInterface.Text = Now
        End If

        If TypeOf (brfInterface) Is ComboBox Then
            Try
                brfInterface.ResetText()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Public Function fpbNouveauNumero(ByVal bvlTable As String, Optional ByVal Sens As Integer = 1) As Integer
        Dim ppvDA As New SqlClient.SqlDataAdapter("Select DerniereValeur from Compteur where EntiteTable='" & bvlTable & "'", SaigicLocal_Cnx)
        Dim ppvDS As New DataSet
        ppvDA.Fill(ppvDS, "Compteur")
        fpbNouveauNumero = Convert.ToInt32(ppvDS.Tables("Compteur").Rows(0)("DerniereValeur")) + Sens
        If Sens = 1 Then
            ppvDA.UpdateCommand = New SqlClient.SqlCommand("Update Compteur Set DerniereValeur=DerniereValeur+1 Where EntiteTable='" & bvlTable & "'", SaigicLocal_Cnx)
        ElseIf Sens = -1 Then
            ppvDA.UpdateCommand = New SqlClient.SqlCommand("Update Compteur Set DerniereValeur=DerniereValeur-1 Where EntiteTable='" & bvlTable & "'", SaigicLocal_Cnx)
        End If
        ppvDA.UpdateCommand.ExecuteNonQuery()
        Return fpbNouveauNumero
        ppvDA = Nothing
        ppvDS = Nothing
    End Function

    Public Sub launchForm(ByRef brfMyform As Form, Optional ByVal bvlOption As lstOpenOption = 0)
        brfMyform.Icon = My.Resources.Logo1
        brfMyform.Hide()
        Select Case bvlOption
            Case 0
                brfMyform.Show()
            Case 1
                brfMyform.ShowDialog()
        End Select
    End Sub

    Public Function fpvNumeroAnalyseUniqueCacao(ByVal bvlCodePesee As String, ByVal bvlnumeroAnalyse As String, ByVal bvlCampagne As String) As Boolean
        Dim strSQL As String
        'strSQL = "Select Pesee.CodePesee, Pesee.Campagne, PeseeAnalyseCafe.NumeroAnalyse from PeseeAnalyseCafe, Pesee where Pesee.CodePesee=PeseeAnalyseCafe.CodePesee AND Pesee.Campagne='" & bvlCampagne & "' AND PeseeAnalyseCafe.NumeroAnalyse ='" & bvlnumeroAnalyse & "' AND Pesee.CodePesee<>'" & bvlCodePesee & "'"
        strSQL = "Select Pesee.CodePesee, Pesee.Campagne, PeseeAnalyseCacao.NumeroAnalyse from PeseeAnalyseCacao, Pesee where Pesee.CodePesee=PeseeAnalyseCacao.CodePesee AND Pesee.Campagne='" & bvlCampagne & "' AND PeseeAnalyseCacao.NumeroAnalyse ='" & bvlnumeroAnalyse & "' AND Pesee.CodePesee<>'" & bvlCodePesee & "'"

        Dim ppvDA As New SqlClient.SqlDataAdapter(strSQL, SaigicLocal_Cnx)
        Dim ppvDS As New DataSet
        ppvDA.Fill(ppvDS, "AnalyseCacao")
        If ppvDS.Tables("AnalyseCacao").Rows.Count = 0 Then
            fpvNumeroAnalyseUniqueCacao = True
        Else
            fpvNumeroAnalyseUniqueCacao = False
        End If
        ppvDA = Nothing
        ppvDS = Nothing
    End Function

    Public Function fpvNumeroAnalyseUniqueCafe(ByVal bvlCodePesee As String, ByVal bvlnumeroAnalyse As String, ByVal bvlCampagne As String) As Boolean
        Dim strSQL As String
        strSQL = "Select Pesee.CodePesee, Pesee.Campagne, PeseeAnalyseCafe.NumeroAnalyse from PeseeAnalyseCafe, Pesee where Pesee.CodePesee=PeseeAnalyseCafe.CodePesee AND Pesee.Campagne='" & bvlCampagne & "' AND PeseeAnalyseCafe.NumeroAnalyse ='" & bvlnumeroAnalyse & "' AND Pesee.CodePesee<>'" & bvlCodePesee & "'"
        Dim ppvDA As New SqlClient.SqlDataAdapter(strSQL, SaigicLocal_Cnx)
        Dim ppvDS As New DataSet
        ppvDA.Fill(ppvDS, "AnalyseCafe")
        If ppvDS.Tables("AnalyseCafe").Rows.Count = 0 Then
            fpvNumeroAnalyseUniqueCafe = True
        Else
            fpvNumeroAnalyseUniqueCafe = False
        End If
        ppvDA = Nothing
        ppvDS = Nothing
    End Function

    Public Sub spbAfficherPeseeCacao(ByVal bvlCodePesee As String, ByVal bvlModePesee As lstTypeOuverture, ByVal bvlMouvement As String)
        Select Case bvlMouvement
            Case "ACHAT TOUT-VENANT"
                Dim ModifierReception As New FrmReceptionCacao(bvlModePesee, bvlCodePesee)
                launchForm(ModifierReception, lstOpenOption.Dialog)
            Case "EXPEDITION"
                Dim ModifierExpedition As New FrmExpeditionCacao(bvlModePesee, bvlCodePesee)
                launchForm(ModifierExpedition, lstOpenOption.Dialog)
            Case "EMBARQUEMENT"
                Dim ModifierEmbarquement As New FrmEmbarquementCacao(bvlModePesee, bvlCodePesee)
                launchForm(ModifierEmbarquement, lstOpenOption.Dialog)
            Case "TRANSFERT"
                Dim ModifierTranfert As New FrmTransfertCacao(bvlModePesee, bvlCodePesee)
                launchForm(ModifierTranfert, lstOpenOption.Dialog)
        End Select
    End Sub

    Public Sub spbAfficherPeseeCafe(ByVal bvlCodePesee As String, ByVal bvlModePesee As lstTypeOuverture, ByVal bvlMouvement As String)
        Select Case bvlMouvement
            Case "ACHAT TOUT-VENANT"
                Dim ModifierReception As New FrmReceptionCafe(bvlModePesee, bvlCodePesee)
                launchForm(ModifierReception, lstOpenOption.Dialog)

            Case "CAFE HORS NORME"
                Dim ModifierReception As New FrmReceptionCafe(bvlModePesee, bvlCodePesee)
                launchForm(ModifierReception, lstOpenOption.Dialog)

            Case "EXPEDITION"
                Dim ModifierExpedition As New FrmExpeditionCafe(bvlModePesee, bvlCodePesee)
                launchForm(ModifierExpedition, lstOpenOption.Dialog)
            Case "EMBARQUEMENT"
                Dim ModifierEmbarquement As New FrmEmbarquementCafe(bvlModePesee, bvlCodePesee)
                launchForm(ModifierEmbarquement, lstOpenOption.Dialog)
            Case "TRANSFERT"
                Dim ModifierTranfert As New FrmTransfertCafe(bvlModePesee, bvlCodePesee)
                launchForm(ModifierTranfert, lstOpenOption.Dialog)
        End Select
    End Sub

    Public Sub spbAfficherPeseeCacaoRecuperationP1(ByVal bvlMouvement As String, ByVal bvlIdRecup As Integer, ByVal bvlVehicule As String)
        Select Case bvlMouvement
            Case "ACHAT TOUT-VENANT"
                Dim ModifierReception As New FrmReceptionCacao(lstTypeOuverture.ModePesee1)
                ModifierReception.IDRecup = bvlIdRecup
                ModifierReception.Vehicule = bvlVehicule
                launchForm(ModifierReception, lstOpenOption.Dialog)
            Case "EXPEDITION"
                Dim ModifierExpedition As New FrmExpeditionCacao(lstTypeOuverture.ModePesee1)
                ModifierExpedition.IDRecup = bvlIdRecup
                ModifierExpedition.Vehicule = bvlVehicule
                launchForm(ModifierExpedition, lstOpenOption.Dialog)
            Case "EMBARQUEMENT"
                Dim ModifierEmbarquement As New FrmEmbarquementCacao(lstTypeOuverture.ModePesee1)
                ModifierEmbarquement.IDRecup = bvlIdRecup
                ModifierEmbarquement.Vehicule = bvlVehicule
                launchForm(ModifierEmbarquement, lstOpenOption.Dialog)
            Case "TRANSFERT"
                Dim ModifierTranfert As New FrmTransfertCacao(lstTypeOuverture.ModePesee1)
                ModifierTranfert.IDRecup = bvlIdRecup
                ModifierTranfert.Vehicule = bvlVehicule
                launchForm(ModifierTranfert, lstOpenOption.Dialog)
        End Select
    End Sub
    Public Sub spbAfficherPeseeCafeRecuperationP1(ByVal bvlMouvement As String, ByVal bvlIdRecup As Integer, ByVal bvlVehicule As String)
        Select Case bvlMouvement
            Case "ACHAT TOUT-VENANT"
                Dim ModifierReception As New FrmReceptionCafe(lstTypeOuverture.ModePesee1)
                ModifierReception.IDRecup = bvlIdRecup
                ModifierReception.Vehicule = bvlVehicule
                launchForm(ModifierReception, lstOpenOption.Dialog)

            Case "CAFE HORS NORME"
                Dim ModifierReception As New FrmReceptionCafe(lstTypeOuverture.ModePesee1)
                ModifierReception.IDRecup = bvlIdRecup
                ModifierReception.Vehicule = bvlVehicule
                launchForm(ModifierReception, lstOpenOption.Dialog)

            Case "EXPEDITION"
                Dim ModifierExpedition As New FrmExpeditionCafe(lstTypeOuverture.ModePesee1)
                ModifierExpedition.IDRecup = bvlIdRecup
                ModifierExpedition.Vehicule = bvlVehicule
                launchForm(ModifierExpedition, lstOpenOption.Dialog)
            Case "EMBARQUEMENT"
                Dim ModifierEmbarquement As New FrmEmbarquementCafe(lstTypeOuverture.ModePesee1)
                ModifierEmbarquement.IDRecup = bvlIdRecup
                ModifierEmbarquement.Vehicule = bvlVehicule
                launchForm(ModifierEmbarquement, lstOpenOption.Dialog)
            Case "TRANSFERT"
                Dim ModifierTranfert As New FrmTransfertCafe(lstTypeOuverture.ModePesee1)
                ModifierTranfert.IDRecup = bvlIdRecup
                ModifierTranfert.Vehicule = bvlVehicule
                launchForm(ModifierTranfert, lstOpenOption.Dialog)
        End Select
    End Sub

    Public Sub spbAfficherPeseeCacaoRecuperationP2(ByVal bvlMouvement As String, ByVal bvlIdRecup As Integer, ByVal bvlCodePesee As String)
        Select Case bvlMouvement
            Case "ACHAT TOUT-VENANT"
                Dim ModifierReception As New FrmReceptionCacao(lstTypeOuverture.Modepesee2, bvlCodePesee)
                ModifierReception.IDRecup = bvlIdRecup
                launchForm(ModifierReception, lstOpenOption.Dialog)
            Case "EXPEDITION"
                Dim ModifierExpedition As New FrmExpeditionCacao(lstTypeOuverture.Modepesee2, bvlCodePesee)
                ModifierExpedition.IDRecup = bvlIdRecup
                launchForm(ModifierExpedition, lstOpenOption.Dialog)

            Case "EMBARQUEMENT"
                'Dim ModifierTranfert As New FrmTransfertCacao(lstTypeOuverture.Modepesee2, bvlCodePesee)
                'ModifierTranfert.IDRecup = bvlIdRecup
                Dim ModifierEmbarquement As New FrmEmbarquementCacao(lstTypeOuverture.Modepesee2, bvlCodePesee)
                ModifierEmbarquement.IDRecup = bvlIdRecup
                launchForm(ModifierEmbarquement, lstOpenOption.Dialog)
            Case "TRANSFERT"
                Dim ModifierTranfert As New FrmTransfertCacao(lstTypeOuverture.Modepesee2, bvlCodePesee)
                ModifierTranfert.IDRecup = bvlIdRecup
                launchForm(ModifierTranfert, lstOpenOption.Dialog)
        End Select
    End Sub
    Public Sub spbAfficherPeseeCafeRecuperationP2(ByVal bvlMouvement As String, ByVal bvlIdRecup As Integer, ByVal bvlCodePesee As String)
        Select Case bvlMouvement
            Case "ACHAT TOUT-VENANT"
                Dim ModifierReception As New FrmReceptionCafe(lstTypeOuverture.Modepesee2, bvlCodePesee)
                ModifierReception.IDRecup = bvlIdRecup
                launchForm(ModifierReception, lstOpenOption.Dialog)

            Case "CAFE HORS NORME"
                Dim ModifierReception As New FrmReceptionCafe(lstTypeOuverture.Modepesee2, bvlCodePesee)
                ModifierReception.IDRecup = bvlIdRecup
                launchForm(ModifierReception, lstOpenOption.Dialog)

            Case "EXPEDITION"
                Dim ModifierExpedition As New FrmExpeditionCafe(lstTypeOuverture.Modepesee2, bvlCodePesee)
                ModifierExpedition.IDRecup = bvlIdRecup
                launchForm(ModifierExpedition, lstOpenOption.Dialog)

            Case "EMBARQUEMENT"
                Dim ModifierEmbarquement As New FrmEmbarquementCafe(lstTypeOuverture.Modepesee2, bvlCodePesee)
                ModifierEmbarquement.IDRecup = bvlIdRecup
                launchForm(ModifierEmbarquement, lstOpenOption.Dialog)
            Case "TRANSFERT"
                Dim ModifierTranfert As New FrmTransfertCafe(lstTypeOuverture.Modepesee2, bvlCodePesee)
                ModifierTranfert.IDRecup = bvlIdRecup
                launchForm(ModifierTranfert, lstOpenOption.Dialog)
        End Select
    End Sub
End Module
