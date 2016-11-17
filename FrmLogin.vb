Imports DCSaigicLight
Imports System.Windows.Forms

Public Class FrmLogin

    Dim mpvDS As New DataSet
    Dim nbtentative As Integer



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Select Case fpbVerificationOperateur(UsernameTextBox.Text, PasswordTextBox.Text)
            Case True
                'Me.Hide()
                MDISagic.ShowDialog()
                Me.Close()

            Case False
                MessageBox.Show("login, mot de passe ou profil incorrect", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                UsernameTextBox.SelectAll()
                UsernameTextBox.Focus()
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If IsNothing(Moi.CodeUser) Then
            End
        Else
            Moi = New DCSaigicLight.BObject.Utilisateur
        End If
    End Sub


    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        main()
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
        UsernameTextBox.Focus()
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Si le titre de l'application est absent, utilisez le nom de l'application, sans l'extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        MDISagic.Text = MDISagic.Text & " - " & Version.Text
        Copyright.Text = My.Application.Info.Copyright

        Try
            SaigicLocal_Cnx.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub spvChargerInterface()

    End Sub
    Public Sub New()

        ' Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub


End Class
