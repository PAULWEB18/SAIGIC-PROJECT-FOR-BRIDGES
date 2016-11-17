Public Class FrmSynchronisation
    Dim MySQLDBCom As SqlClient.SqlCommand
    Dim MonDataServer As New DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ppvSQL As String
        Dim MonDA As SqlClient.SqlDataAdapter
        'Suppression des enregistrements
        Try
            SaigicLocal_Cnx.Open()
        Catch ex As Exception

        End Try
        MonDA = New SqlClient.SqlDataAdapter
        'MonDA.InsertCommand = New SqlClient.SqlCommand("update * from Acheteur", SaigicLocal_Cnx)
        ppvSQL = ("update * from Acheteur")
        MonDA.UpdateCommand = New SqlClient.SqlCommand(ppvSQL, SaigicLocal_Cnx)
        MonDA.UpdateCommand.ExecuteNonQuery()
        Me.Cursor = Cursors.Default
        MsgBox("Mise à jour")
        Label9.Visible = True


        'Mise a jour a partir des donnees du serveur
        Me.Cursor = Cursors.WaitCursor
        Dim Idx As Integer

        For Idx = 0 To MonDataServer.Tables("Acheteur").Rows.Count - 1
            MySQLDBCom = New SqlClient.SqlCommand
            ppvSQL = "INSERT INTO Acheteur (NomAcheteur, UniteAchat, CodeUniteAchat, ZoneActivite, CodeAcheteur, Type, Statut) VALUES ('" & _
            MonDataServer.Tables("Acheteur").Rows(Idx)("NomAcheteur").ToString & "','" & MonDataServer.Tables("Acheteur").Rows(Idx)("UniteAchat").ToString & "','" & _
            MonDataServer.Tables("Acheteur").Rows(Idx)("CodeUniteAchat").ToString & "','" & MonDataServer.Tables("Acheteur").Rows(Idx)("ZoneActivite").ToString & "','" & _
            MonDataServer.Tables("Acheteur").Rows(Idx)("CodeAcheteur").ToString & "','" & MonDataServer.Tables("Acheteur").Rows(Idx)("Type").ToString & "','" & _
            MonDataServer.Tables("Acheteur").Rows(Idx)("statut").Replace("'", "'") & "')"
            MySQLDBCom = New SqlClient.SqlCommand(ppvSQL, SaigicLocal_Cnx)
            MySQLDBCom.ExecuteNonQuery()
        Next

        MsgBox("Mise a Jour Terminee")

        Label10.Visible = True
        Try
            SaigicLocal_Cnx.Close()
        Catch ex As Exception

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Suppression des enregistrements
        ' Dim MySQLDBCom As SqlClient.SqlCommand
        Try
            SaigicLocal_Cnx.Open()
        Catch ex As Exception

        End Try
        MySQLDBCom = New SqlClient.SqlCommand("delete * from Cooperative", SaigicLocal_Cnx)
        MySQLDBCom.ExecuteNonQuery()
        Me.Cursor = Cursors.Default
        MsgBox("Suppression Terminee")
        Label9.Visible = True


        'Mise a jour a partir des donnees du serveur
        Me.Cursor = Cursors.WaitCursor
        Dim Idx As Integer

        For Idx = 0 To MonDataServer.Tables("Cooperative").Rows.Count - 1
            MySQLDBCom = New SqlClient.SqlCommand("insert into Cooperative (ID_Coop, Cooperative) VALUES ('" & MonDataServer.Tables("Cooperative").Rows(Idx)("ID_Coop").ToString & "','" & MonDataServer.Tables("Cooperative").Rows(Idx)("Cooperative").ToString.Replace("'", "''") & "')", SaigicLocal_Cnx)
            MySQLDBCom.ExecuteNonQuery()
        Next

        MsgBox("Mise a Jour Terminee")

        Label10.Visible = True
        Try
            SaigicLocal_Cnx.Close()
        Catch ex As Exception

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class