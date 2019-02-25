Public Class Processa
    Public Shared Function processLancOfFile(streamReader As IO.StreamReader) As List(Of Lancamento)
        Dim listLanc As New List(Of Lancamento)

        Try
            While Not streamReader.EndOfStream
                Dim lanc As New Lancamento

                lanc.Data = Util.convertDate(streamReader.ReadLine())
                lanc.Descrisao = streamReader.ReadLine()
                lanc.Valor = Convert.ToDouble(streamReader.ReadLine())

                If lanc.Valor > 0 Then
                    LancamentoDao.insert(lanc)
                End If

            End While
        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try

        Return listLanc
    End Function

End Class
