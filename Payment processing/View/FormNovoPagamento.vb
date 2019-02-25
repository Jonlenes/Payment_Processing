Public Class FormNovoPagamento

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click

        PagamentoDao.insert(New Pagamento(tbDescricao.Text, DateTimePickerData.Value, Convert.ToDouble(tbValor.Text)))
        Close()

    End Sub

End Class