<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVinculoPgtoLanc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVinculoPgtoLanc))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.labelBarSelecionado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelBarValorSel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelBarRestante = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelBarValorRestante = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DateTimePickerPgtoFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerPgtoIni = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewVinculoPgto = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pago = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cod_pgto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridViewVinculoPgto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelBarSelecionado, Me.labelBarValorSel, Me.labelBarRestante, Me.labelBarValorRestante})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 422)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(661, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'labelBarSelecionado
        '
        Me.labelBarSelecionado.Name = "labelBarSelecionado"
        Me.labelBarSelecionado.Size = New System.Drawing.Size(156, 17)
        Me.labelBarSelecionado.Text = "Lançametos selecionado: R$"
        '
        'labelBarValorSel
        '
        Me.labelBarValorSel.Name = "labelBarValorSel"
        Me.labelBarValorSel.Size = New System.Drawing.Size(121, 17)
        Me.labelBarValorSel.Text = "ToolStripStatusLabel2"
        '
        'labelBarRestante
        '
        Me.labelBarRestante.Name = "labelBarRestante"
        Me.labelBarRestante.Size = New System.Drawing.Size(71, 17)
        Me.labelBarRestante.Text = "Restante: R$"
        '
        'labelBarValorRestante
        '
        Me.labelBarValorRestante.Name = "labelBarValorRestante"
        Me.labelBarValorRestante.Size = New System.Drawing.Size(121, 17)
        Me.labelBarValorRestante.Text = "ToolStripStatusLabel1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerPgtoFinal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerPgtoIni)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(653, 49)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(562, 14)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(88, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'DateTimePickerPgtoFinal
        '
        Me.DateTimePickerPgtoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerPgtoFinal.Location = New System.Drawing.Point(196, 15)
        Me.DateTimePickerPgtoFinal.Name = "DateTimePickerPgtoFinal"
        Me.DateTimePickerPgtoFinal.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePickerPgtoFinal.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Até"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dt. lanc.:"
        '
        'DateTimePickerPgtoIni
        '
        Me.DateTimePickerPgtoIni.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickerPgtoIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerPgtoIni.Location = New System.Drawing.Point(59, 14)
        Me.DateTimePickerPgtoIni.Name = "DateTimePickerPgtoIni"
        Me.DateTimePickerPgtoIni.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePickerPgtoIni.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(661, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'DataGridViewVinculoPgto
        '
        Me.DataGridViewVinculoPgto.AllowUserToAddRows = False
        Me.DataGridViewVinculoPgto.AllowUserToDeleteRows = False
        Me.DataGridViewVinculoPgto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVinculoPgto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.descricao, Me.valor, Me.data, Me.pago, Me.cod_pgto})
        Me.DataGridViewVinculoPgto.Location = New System.Drawing.Point(4, 87)
        Me.DataGridViewVinculoPgto.Name = "DataGridViewVinculoPgto"
        Me.DataGridViewVinculoPgto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVinculoPgto.Size = New System.Drawing.Size(649, 332)
        Me.DataGridViewVinculoPgto.TabIndex = 14
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
        Me.pago.DataPropertyName = "Pago"
        Me.pago.HeaderText = "Pago"
        Me.pago.Name = "pago"
        '
        'cod_pgto
        '
        Me.cod_pgto.DataPropertyName = "idPgto"
        Me.cod_pgto.HeaderText = "cod_pgto"
        Me.cod_pgto.Name = "cod_pgto"
        Me.cod_pgto.Visible = False
        '
        'FormVinculoPgtoLanc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 444)
        Me.Controls.Add(Me.DataGridViewVinculoPgto)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormVinculoPgtoLanc"
        Me.Text = "Vínculo de boleto com pagamento"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridViewVinculoPgto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents labelBarSelecionado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerPgtoFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerPgtoIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents labelBarRestante As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents labelBarValorSel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents labelBarValorRestante As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataGridViewVinculoPgto As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descricao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pago As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cod_pgto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
