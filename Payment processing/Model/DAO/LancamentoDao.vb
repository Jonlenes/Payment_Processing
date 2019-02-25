Imports System.Data.OleDb

Public Class LancamentoDao
    Public Shared Sub insert(lancamento As Lancamento)
        Dim cmd As New OleDbCommand()

        cmd.CommandText = "INSERT INTO [Lancamento] ([Categoria], [Descricao], [Valor], [Data]) VALUES (@Categoria, @Descricao, @Valor, @Data)"

        If Not lancamento.Categoria Is Nothing Then
            cmd.Parameters.AddWithValue("Categoria", lancamento.Categoria)
        Else
            cmd.Parameters.AddWithValue("Categoria", DBNull.Value)
        End If

        cmd.Parameters.AddWithValue("Descricao", lancamento.Descrisao)
        cmd.Parameters.AddWithValue("Valor", lancamento.Valor)
        cmd.Parameters.AddWithValue("Data", lancamento.Data)

        ConnectBD.Instancia.executeNonQuery(cmd)

    End Sub

    Private Shared Function getSqlLancamentos() As String
        Return "SELECT id, Descricao, Valor, Data, idPgto, IIf(Status = 2, 'A pagar', " &
               "IIf(Status = 0, 'Boleto emitido', 'Pago')) AS StrStatus FROM (" & vbCrLf &
               "   SELECT Lancamento.id, Lancamento.Descricao, Lancamento.Valor, Lancamento.Data, " & vbCrLf &
               "VinculoPgtoLanc.idPgto, IIf(Pagamento.Status IS NULL, 2, Pagamento.Status) AS Status FROM Lancamento" & vbCrLf &
               "   LEFT JOIN ( VinculoPgtoLanc " & vbCrLf &
               "            LEFT JOIN Pagamento " & vbCrLf &
               "               ON VinculoPgtoLanc.idPgto = Pagamento.Id ) " & vbCrLf &
               "      On VinculoPgtoLanc.idLanc = Lancamento.Id) AS Lanc" & vbCrLf &
               "WHERE "
    End Function

    'Retorna todas os lançamentos dentro do periodo informado com o status passado
    Public Shared Function getLancamentos(dateIni As Date, dateFinal As Date, status As Lancamento.Status) As DataTable
        Dim strSql As String = getSqlLancamentos()
        Dim strInStatus As String = ""
        Dim haveClause As Boolean = False

        '-----------Filtrando o Status----------------
        'Status 2 - A pagar
        If status.aPagar Then
            strInStatus = "2"
        End If

        'Status 0 - Emitido
        If status.emitido Then
            If strInStatus <> "" Then strInStatus += ","
            strInStatus += "0"
        End If
        'Status 1 - Pago
        If status.pago Then
            If strInStatus <> "" Then strInStatus += ","
            strInStatus += "1"
        End If

        If strInStatus <> "" Then
            strSql += " Status IN (" & strInStatus & ") AND "
        End If
        '----------------------------------------------

        strSql += "Data BETWEEN #" & dateIni.ToString("MM/dd/yyyy") & "# And #" & dateFinal.ToString("MM/dd/yyyy") & "#" & vbCrLf &
            "ORDER BY Data" & vbCrLf

        Return ConnectBD.Instancia.executeQuery(strSql).Tables(0)
    End Function

    'Retorna todos os lançamentos pagos com determinado pgto
    Public Shared Function getLancamentos(idPgto As ULong) As DataTable

        Dim strSql As String = getSqlLancamentos()
        strSql += "idPgto = " & idPgto & vbCrLf & _
            "ORDER BY Data" & vbCrLf

        Return ConnectBD.Instancia.executeQuery(strSql).Tables(0)

    End Function


    'Retorna todas os lançamentos a pagar dentro do periodo informado ou pago com o pgto informado
    Public Shared Function getLancamentos(dateIni As Date, dateFinal As Date, idPgto As ULong) As DataTable

        Dim strSql As String = getSqlLancamentos()
        strSql += "idPgto = " & idPgto & vbCrLf & _
            "OR (Pago = 0 AND Data BETWEEN #" & dateIni.ToString("MM/dd/yyyy") & "# And #" & dateFinal.ToString("MM/dd/yyyy") & "#)" & vbCrLf & _
            "ORDER BY Data" & vbCrLf

        Return ConnectBD.Instancia.executeQuery(strSql).Tables(0)
    End Function

End Class
