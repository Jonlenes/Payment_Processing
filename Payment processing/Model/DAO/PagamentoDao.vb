Imports System.Data.OleDb

Public Class PagamentoDao
    Public Shared Sub insert(pagamento As Pagamento)
        Dim cmd As New OleDbCommand()

        cmd.CommandText = "INSERT INTO [Pagamento] ([Descricao], [Data], [Valor]) VALUES (@Descricao, @Data, @Valor)"

        cmd.Parameters.AddWithValue("Descricao", pagamento.Descrisao)
        cmd.Parameters.AddWithValue("Data", New Date(pagamento.Data.Year, pagamento.Data.Month, pagamento.Data.Day))
        cmd.Parameters.AddWithValue("Valor", pagamento.Valor)

        ConnectBD.Instancia.executeNonQuery(cmd)

    End Sub

    Public Shared Function getPagamentos(dateIni As Date, dateFinal As Date) As DataTable
        Dim strSql As String

        strSql = "SELECT Pagamento.id, Pagamento.Valor, Pagamento.Descricao, Pagamento.Data, SUM(Lancamento.Valor) AS ValorVinculado FROM Pagamento" & vbCrLf & _
                 "LEFT JOIN ( VinculoPgtoLanc" & vbCrLf & _
                 "      LEFT JOIN Lancamento" & vbCrLf & _
                 "         ON Lancamento.id = VinculoPgtoLanc.idLanc)" & vbCrLf & _
                 "   ON VinculoPgtoLanc.idPgto = Pagamento.id" & vbCrLf & _
                 "WHERE Pagamento.Data BETWEEN #" & dateIni.ToString("MM/dd/yyyy") & "# And #" & dateFinal.ToString("MM/dd/yyyy") & "#" & vbCrLf & _
                 "GROUP BY Pagamento.id, Pagamento.Valor, Pagamento.Descricao, Pagamento.Data" & vbCrLf & _
                 "ORDER BY Pagamento.Data"

        Return ConnectBD.Instancia.executeQuery(strSql).Tables(0)
    End Function

End Class
