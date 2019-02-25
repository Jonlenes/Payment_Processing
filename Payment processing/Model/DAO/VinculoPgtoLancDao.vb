Imports System.Data.OleDb

Public Class VinculoPgtoLancDao

    Public Shared Sub insert(vinculoPgtoLanc As VinculoPgtoLanc)
        Dim cmd As New OleDbCommand()

        cmd.CommandText = "INSERT INTO [VinculoPgtoLanc] ([idLanc], [idPgto]) VALUES (@idLanc, @idPgto)"

        cmd.Parameters.AddWithValue("idLanc", vinculoPgtoLanc.idLanc)
        cmd.Parameters.AddWithValue("idPgto", vinculoPgtoLanc.idPgto)

        ConnectBD.Instancia.executeNonQuery(cmd)

    End Sub

    Public Shared Sub deleteAll(idPgto As ULong)

        Dim cmd As New OleDbCommand()
        cmd.CommandText = "DELETE FROM [VinculoPgtoLanc] WHERE [idPgto] = " & idPgto
        ConnectBD.Instancia.executeNonQuery(cmd)

    End Sub

    Public Shared Function getVinculoPgtoLanc(idPgto As ULong) As DataTable
        Dim strSql As String

        strSql = "SELECT * FROM VinculoPgtoLanc" & vbCrLf & _
            "WHERE idPgto = " & idPgto

        Return ConnectBD.Instancia.executeQuery(strSql).Tables(0)
    End Function

End Class
