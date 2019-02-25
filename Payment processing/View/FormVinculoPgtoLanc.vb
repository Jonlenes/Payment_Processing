Imports System.Convert
Imports System.Globalization


Public Class FormVinculoPgtoLanc
    Private boleto As Pagamento
    Private valorAtual As Double


    Sub New(boleto As Pagamento)

        InitializeComponent()

        Me.boleto = boleto
        Me.Text = boleto.Descrisao & " - " & boleto.Data & " - R$ " & boleto.Valor

        valorAtual = 0

        atualizaValoresStatus()
        
    End Sub


    Private Sub FormVinculoPgtoLanc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Inicializando os filtros
        Dim firstDate As New Date(Today.Year, Today.Month, 1)
        DateTimePickerPgtoIni.Value = firstDate
        DateTimePickerPgtoFinal.Value = firstDate.AddMonths(1).AddDays(-1)

        Dim dataTable As DataTable = LancamentoDao.getLancamentos(boleto.Id)

        'Verifico se tem lançamentos pagos com esse boleto
        If dataTable.Rows.Count > 0 Then
            DataGridViewVinculoPgto.DataSource = dataTable
            somaSelecionados()
        Else
            buscar()
        End If

    End Sub

    Private Sub DataGridViewVinculoPgto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewVinculoPgto.CellClick
        'Checkbox 'Pago'
        If e.ColumnIndex = 4 Then

            'Pego os valores do grid
            Dim cellValue As Boolean = DataGridViewVinculoPgto.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            Dim valorPagamento As Double = DataGridViewVinculoPgto.Rows(e.RowIndex).Cells("Valor").Value
            Dim bytSinal As Integer = IIf(cellValue, -1, 1)

            'Verifico se o saldo do boleto é suficiente para adicionar este pagamento
            If ToDouble(valorAtual) + bytSinal * valorPagamento <= boleto.Valor Then

                'Atualizo a coluna 'Pago' do grid
                DataGridViewVinculoPgto.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not cellValue

                'Atualizando o valor dos lançamentos selecionados
                valorAtual += bytSinal * valorPagamento

                'Seto os valores nos lbs de status
                atualizaValoresStatus()

            Else
                MessageBox.Show("Valor utrapassou boleto")
                DataGridViewVinculoPgto.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = cellValue
            End If

            'Finalizo a alteração
            DataGridViewVinculoPgto.EndEdit()
        End If

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Dim dtable As DataTable = DataGridViewVinculoPgto.DataSource
        Dim listVinculo As New List(Of VinculoPgtoLanc)

        For i As Integer = 0 To dtable.Rows.Count - 1
            Dim drow As DataRow = dtable.Rows(i)

            If Convert.ToBoolean(drow("Pago")) Then
                listVinculo.Add(New VinculoPgtoLanc(Convert.ToUInt64(drow("id")), boleto.Id))
            End If
        Next i

        'Inserindo os vinculos
        VinculoPgtoLancBo.insert(boleto.Id, listVinculo)

        Close()

    End Sub

    'Atualiza os labes do statusBar com o valor dos lançamento selecionados e a selecionar
    Private Sub atualizaValoresStatus()

        labelBarValorSel.Text = valorAtual.ToString("C", CultureInfo.CurrentCulture)
        labelBarValorRestante.Text = (boleto.Valor - valorAtual).ToString("C", CultureInfo.CurrentCulture)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        buscar()

    End Sub

    Private Sub buscar()

        Dim dtable As DataTable = LancamentoDao.getLancamentos(DateTimePickerPgtoIni.Value, DateTimePickerPgtoFinal.Value, boleto.Id)
        DataGridViewVinculoPgto.DataSource = dtable

        somaSelecionados()

    End Sub

    Private Sub somaSelecionados()

        Dim dtable As DataTable = DataGridViewVinculoPgto.DataSource
        valorAtual = 0

        For i As Integer = 0 To dtable.Rows.Count - 1
            Dim drow As DataRow = dtable.Rows(i)

            If Convert.ToBoolean(drow("Pago")) Then
                valorAtual += Convert.ToDouble(drow("Valor"))
            End If
        Next i

        atualizaValoresStatus()

    End Sub

End Class