Imports DCSaigicLight
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Windows.Forms
Public Class FrmChangerMotPasse


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'verification de l'ancien mot de passe
        If ToMD5(TextBox2.Text) <> Moi.MotPasse Then
            MsgBox("Mot de passe incorrect !!!!")
        Else
            If TextBox3.Text <> TextBox4.Text Then
                MsgBox("Nouveau mot de passe incorrect !!!!")
            Else
                Dim tmpuser As New BObject.Utilisateurs
                tmpuser.LoadUtilisateurs()
                tmpuser.UpdateBObjectMotPasse(Moi.CodeUser, ToMD5(TextBox3.Text))
                tmpuser.UpdateAllBData()
                End
            End If

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FrmChangerMotPasse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Moi.CodeUser
    End Sub
End Class