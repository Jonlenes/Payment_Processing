Imports System.IO
Imports System.Data.OleDb
Imports System.Globalization

Public Class FormLancamentos

    Private Sub LerArquivoDeLançamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LerArquivoDeLançamentoToolStripMenuItem.Click, TSBtnProcessFile.Click

        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.InitialDirectory = "c:\"
        openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                If Not openFileDialog.FileName.Equals("") Then

                    'Realiza o processamento aparti do arquivo
                    Processa.processLancOfFile(New StreamReader(openFileDialog.FileName))

                End If
            Catch Ex As Exception
                MessageBox.Show("Não foi possível ler o arquivo do disco. Erro: " & Ex.Message)
            End Try

        End If

        buscar()

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Inicializando as datas
        Dim firstDate As New Date(Today.Year, Today.Month, 1)
        DateTimePickerLancIni.Value = firstDate
        DateTimePickerLancFinal.Value = firstDate.AddMonths(1).AddDays(-1)

        buscar()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        buscar()

    End Sub

    Private Sub buscar()

        Dim status As New Lancamento.Status

        status.aPagar = CheckBoxAPagar.Checked
        status.emitido = CheckBoxEmitidos.Checked
        status.pago = CheckBoxPago.Checked

        Dim dtable As DataTable = LancamentoDao.getLancamentos(DateTimePickerLancIni.Value,
                                                               DateTimePickerLancFinal.Value,
                                                               status)
        DataGridLanc.DataSource = dtable

        somaLancamentos()

    End Sub

    Private Sub somaLancamentos()
        Dim dtable As DataTable = DataGridLanc.DataSource

        Dim soma As Double = 0
        For i As Integer = 0 To dtable.Rows.Count - 1
            Dim drow As DataRow = dtable.Rows(i)

            If drow.RowState <> DataRowState.Deleted Then
                soma += Convert.ToDouble(drow("Valor").ToString())
            End If
        Next i

        labelBar.Text = soma.ToString("C", CultureInfo.CurrentCulture)

    End Sub

    Private Sub PagamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldosEPagamentosToolStripMenuItem.Click, ToolStripButton2.Click
        FormPagamentos.Show()
    End Sub

End Class


