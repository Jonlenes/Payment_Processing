<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLancamentos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLancamentos))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LerArquivoDeLançamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldosEPagamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.labelBar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripAction = New System.Windows.Forms.ToolStrip()
        Me.TSBtnProcessFile = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.CheckBoxPago = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAPagar = New System.Windows.Forms.CheckBox()
        Me.DateTimePickerLancFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerLancIni = New System.Windows.Forms.DateTimePicker()
        Me.DataGridLanc = New System.Windows.Forms.DataGridView()
        Me.CheckBoxEmitidos = New System.Windows.Forms.CheckBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_boleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStripAction.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridLanc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.PagamentoToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(675, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LerArquivoDeLançamentoToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ArquivoToolStripMenuItem.Text = "Lançamentos"
        '
        'LerArquivoDeLançamentoToolStripMenuItem
        '
        Me.LerArquivoDeLançamentoToolStripMenuItem.Image = Global.Processamento_de_pagamento.My.Resources.Resources.file_process
        Me.LerArquivoDeLançamentoToolStripMenuItem.Name = "LerArquivoDeLançamentoToolStripMenuItem"
        Me.LerArquivoDeLançamentoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.LerArquivoDeLançamentoToolStripMenuItem.Text = "Ler arquivo"
        '
        'PagamentoToolStripMenuItem
        '
        Me.PagamentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaldosEPagamentosToolStripMenuItem})
        Me.PagamentoToolStripMenuItem.Name = "PagamentoToolStripMenuItem"
        Me.PagamentoToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PagamentoToolStripMenuItem.Text = "Controle"
        '
        'SaldosEPagamentosToolStripMenuItem
        '
        Me.SaldosEPagamentosToolStripMenuItem.Name = "SaldosEPagamentosToolStripMenuItem"
        Me.SaldosEPagamentosToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SaldosEPagamentosToolStripMenuItem.Text = "Pagamentos"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 416)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(675, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'labelBar
        '
        Me.labelBar.Name = "labelBar"
        Me.labelBar.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripAction
        '
        Me.ToolStripAction.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStripAction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBtnProcessFile, Me.ToolStripButton2})
        Me.ToolStripAction.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripAction.Name = "ToolStripAction"
        Me.ToolStripAction.Size = New System.Drawing.Size(675, 51)
        Me.ToolStripAction.TabIndex = 3
        '
        'TSBtnProcessFile
        '
        Me.TSBtnProcessFile.AutoSize = False
        Me.TSBtnProcessFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBtnProcessFile.Image = Global.Processamento_de_pagamento.My.Resources.Resources.file_process
        Me.TSBtnProcessFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnProcessFile.Name = "TSBtnProcessFile"
        Me.TSBtnProcessFile.Size = New System.Drawing.Size(48, 48)
        Me.TSBtnProcessFile.Text = "Ler arquivo de lançamento"
        Me.TSBtnProcessFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Processamento_de_pagamento.My.Resources.Resources.pgto
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(34, 48)
        Me.ToolStripButton2.Text = "Pagamentos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxEmitidos)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.CheckBoxPago)
        Me.GroupBox1.Controls.Add(Me.CheckBoxAPagar)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerLancFinal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerLancIni)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 73)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(675, 67)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(575, 37)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(88, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'CheckBoxPago
        '
        Me.CheckBoxPago.AutoSize = True
        Me.CheckBoxPago.Location = New System.Drawing.Point(316, 43)
        Me.CheckBoxPago.Name = "CheckBoxPago"
        Me.CheckBoxPago.Size = New System.Drawing.Size(56, 17)
        Me.CheckBoxPago.TabIndex = 5
        Me.CheckBoxPago.Text = "Pagos"
        Me.CheckBoxPago.UseVisualStyleBackColor = True
        '
        'CheckBoxAPagar
        '
        Me.CheckBoxAPagar.AutoSize = True
        Me.CheckBoxAPagar.Checked = True
        Me.CheckBoxAPagar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxAPagar.Location = New System.Drawing.Point(6, 43)
        Me.CheckBoxAPagar.Name = "CheckBoxAPagar"
        Me.CheckBoxAPagar.Size = New System.Drawing.Size(161, 17)
        Me.CheckBoxAPagar.TabIndex = 4
        Me.CheckBoxAPagar.Text = "A pagar (Sem boleto gerado)"
        Me.CheckBoxAPagar.UseVisualStyleBackColor = True
        '
        'DateTimePickerLancFinal
        '
        Me.DateTimePickerLancFinal.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickerLancFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerLancFinal.Location = New System.Drawing.Point(248, 13)
        Me.DateTimePickerLancFinal.Name = "DateTimePickerLancFinal"
        Me.DateTimePickerLancFinal.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePickerLancFinal.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Até"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data do lançamento:"
        '
        'DateTimePickerLancIni
        '
        Me.DateTimePickerLancIni.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickerLancIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerLancIni.Location = New System.Drawing.Point(115, 13)
        Me.DateTimePickerLancIni.Name = "DateTimePickerLancIni"
        Me.DateTimePickerLancIni.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePickerLancIni.TabIndex = 0
        '
        'DataGridLanc
        '
        Me.DataGridLanc.AllowUserToAddRows = False
        Me.DataGridLanc.AllowUserToDeleteRows = False
        Me.DataGridLanc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridLanc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.descricao, Me.valor, Me.data, Me.pago, Me.cod_boleto})
        Me.DataGridLanc.Location = New System.Drawing.Point(0, 143)
        Me.DataGridLanc.Name = "DataGridLanc"
        Me.DataGridLanc.ReadOnly = True
        Me.DataGridLanc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridLanc.Size = New System.Drawing.Size(675, 270)
        Me.DataGridLanc.TabIndex = 5
        '
        'CheckBoxEmitidos
        '
        Me.CheckBoxEmitidos.AutoSize = True
        Me.CheckBoxEmitidos.Location = New System.Drawing.Point(173, 43)
        Me.CheckBoxEmitidos.Name = "CheckBoxEmitidos"
        Me.CheckBoxEmitidos.Size = New System.Drawing.Size(137, 17)
        Me.CheckBoxEmitidos.TabIndex = 7
        Me.CheckBoxEmitidos.Text = "Com boletos pendentes"
        Me.CheckBoxEmitidos.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "Id lançamento"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'descricao
        '
        Me.descricao.DataPropertyName = "descricao"
        Me.descricao.HeaderText = "Descrição"
        Me.descricao.Name = "descricao"
        Me.descricao.ReadOnly = True
        '
        'valor
        '
        Me.valor.DataPropertyName = "valor"
        Me.valor.HeaderText = "Valor"
        Me.valor.Name = "valor"
        Me.valor.ReadOnly = True
        '
        'data
        '
        Me.data.DataPropertyName = "data"
        Me.data.HeaderText = "Data"
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        '
        'pago
        '
        Me.pago.DataPropertyName = "StrStatus"
        Me.pago.HeaderText = "Status"
        Me.pago.Name = "pago"
        Me.pago.ReadOnly = True
        Me.pago.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cod_boleto
        '
        Me.cod_boleto.DataPropertyName = "idPgto"
        Me.cod_boleto.HeaderText = "Código do boleto"
        Me.cod_boleto.Name = "cod_boleto"
        Me.cod_boleto.ReadOnly = True
        Me.cod_boleto.Width = 110
        '
        'FormLancamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 438)
        Me.Controls.Add(Me.DataGridLanc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStripAction)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "FormLancamentos"
        Me.Text = "Controle de pagamento"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStripAction.ResumeLayout(False)
        Me.ToolStripAction.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridLanc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LerArquivoDeLançamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripAction As System.Windows.Forms.ToolStrip
    Friend WithEvents TSBtnProcessFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridLanc As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBoxPago As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAPagar As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePickerLancFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerLancIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents PagamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaldosEPagamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents labelBar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CheckBoxEmitidos As CheckBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents data As DataGridViewTextBoxColumn
    Friend WithEvents pago As DataGridViewTextBoxColumn
    Friend WithEvents cod_boleto As DataGridViewTextBoxColumn
End Class
