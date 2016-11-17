Imports System.IO
Public Class FrmConfigurationConnexion
    Dim ModeOuverture As Integer = 0

    Private Sub FrmConfigurationConnexion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ModeOuverture = 1 Then End
    End Sub
    Private Sub FrmConfigServeur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim tmp As StreamReader
        If ModeOuverture = 1 Then

        Else
            btnValider.Enabled = False
            rtxChaineConnexionLocal.Enabled = False
            rtxChaineConnexionServeur.Enabled = False
        End If

        Try
            rtxChaineConnexionLocal.LoadFile("Local", RichTextBoxStreamType.PlainText)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            rtxChaineConnexionServeur.LoadFile("server", RichTextBoxStreamType.PlainText)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click
        Try
            rtxChaineConnexionLocal.SaveFile("local", RichTextBoxStreamType.PlainText)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            rtxChaineConnexionServeur.SaveFile("server", RichTextBoxStreamType.PlainText)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        MsgBox("Veuillez relancer l'application")
        End
    End Sub

    Public Sub New(Optional ByVal Admin As Int32 = 0)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        ModeOuverture = Admin
    End Sub
End Class