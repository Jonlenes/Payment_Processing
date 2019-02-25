Imports System.Convert
Imports System.Globalization

Public Class FormPagamentos

    Private Sub FormPagamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Inicializando os filtros
        Dim firstDate As New Date(Today.Year, Today.Month, 1)
        DateTimePickerPgtoIni.Value = firstDate
        DateTimePickerPgtoFinal.Value = firstDate.AddMonths(1).AddDays(-1)

        buscar()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        buscar()

    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        FormNovoPagamento.ShowDialog()
        buscar()
    End Sub

    Private Sub buscar()

        Dim dtable As DataTable = PagamentoDao.getPagamentos(DateTimePickerPgtoIni.Value, DateTimePickerPgtoFinal.Value)
        gridViewPgto.DataSource = dtable

        Dim soma1, soma2 As Double
        soma1 = 0
        soma2 = 0
        For i As Integer = 0 To dtable.Rows.Count - 1
            Dim drow As DataRow = dtable.Rows(i)

            If drow.RowState <> DataRowState.Deleted Then
                soma1 += Convert.ToDouble(drow("Valor"))
                If drow("ValorVinculado").ToString() <> "" Then
                    soma2 += Convert.ToDouble(drow("ValorVinculado"))
                End If
            End If
        Next i

        labelBarValorBoletos.Text = soma1.ToString("C", CultureInfo.CurrentCulture)
        labelValorVincular.Text = (soma1 - soma2).ToString("C", CultureInfo.CurrentCulture)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridViewPgto.CellDoubleClick
        Dim row As Integer = gridViewPgto.CurrentRow.Index
        
        Dim frmVinculo As FormVinculoPgtoLanc = New FormVinculoPgtoLanc(New Pagamento(ToUInt64(gridViewPgto.Item("id", row).Value),
                                                                                      gridViewPgto.Item("descrisao", row).Value.ToString(),
                                                                                      ToDateTime(gridViewPgto.Item("data", row).Value),
                                                                                      ToDouble(gridViewPgto.Item("valor_pgto", row).Value)))
        frmVinculo.ShowDialog()
        buscar()

    End Sub
End Class