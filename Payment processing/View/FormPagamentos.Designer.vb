<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPagamentos))
        Me.gridViewPgto = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DateTimePickerPgtoFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerPgtoIni = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.labelBarValorBoletos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrisao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_pgto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_vinculado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripStatusLblDesTotalBoletos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLlbDesValorAVincular = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelValorVincular = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.gridViewPgto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridViewPgto
        '
        Me.gridViewPgto.AllowUserToAddRows = False
        Me.gridViewPgto.AllowUserToDeleteRows = False
        Me.gridViewPgto.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.gridViewPgto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridViewPgto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.descrisao, Me.data, Me.valor_pgto, Me.valor_vinculado})
        Me.gridViewPgto.Location = New System.Drawing.Point(6, 77)
        Me.gridViewPgto.Name = "gridViewPgto"
        Me.gridViewPgto.ReadOnly = True
        Me.gridViewPgto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridViewPgto.Size = New System.Drawing.Size(551, 224)
        Me.gridViewPgto.TabIndex = 8
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
        Me.GroupBox1.Size = New System.Drawing.Size(557, 49)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(466, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(88, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'DateTimePickerPgtoFinal
        '
        Me.DateTimePickerPgtoFinal.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickerPgtoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerPgtoFinal.Location = New System.Drawing.Point(247, 16)
        Me.DateTimePickerPgtoFinal.Name = "DateTimePickerPgtoFinal"
        Me.DateTimePickerPgtoFinal.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePickerPgtoFinal.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 19)
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
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data do pagamento:"
        '
        'DateTimePickerPgtoIni
        '
        Me.DateTimePickerPgtoIni.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickerPgtoIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerPgtoIni.Location = New System.Drawing.Point(115, 16)
        Me.DateTimePickerPgtoIni.Name = "DateTimePickerPgtoIni"
        Me.DateTimePickerPgtoIni.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePickerPgtoIni.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(569, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLblDesTotalBoletos, Me.labelBarValorBoletos, Me.ToolStripStatusLlbDesValorAVincular, Me.labelValorVincular})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 302)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(569, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'labelBarValorBoletos
        '
        Me.labelBarValorBoletos.Name = "labelBarValorBoletos"
        Me.labelBarValorBoletos.Size = New System.Drawing.Size(121, 17)
        Me.labelBarValorBoletos.Text = "ToolStripStatusLabel1"
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "Código"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'descrisao
        '
        Me.descrisao.DataPropertyName = "descricao"
        Me.descrisao.HeaderText = "Descrição"
        Me.descrisao.Name = "descrisao"
        Me.descrisao.ReadOnly = True
        '
        'data
        '
        Me.data.DataPropertyName = "data"
        Me.data.HeaderText = "Data Pgto"
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        '
        'valor_pgto
        '
        Me.valor_pgto.DataPropertyName = "valor"
        Me.valor_pgto.HeaderText = "Valor pgto"
        Me.valor_pgto.Name = "valor_pgto"
        Me.valor_pgto.ReadOnly = True
        '
        'valor_vinculado
        '
        Me.valor_vinculado.DataPropertyName = "valorVinculado"
        Me.valor_vinculado.HeaderText = "Valor vinculado"
        Me.valor_vinculado.Name = "valor_vinculado"
        Me.valor_vinculado.ReadOnly = True
        Me.valor_vinculado.Width = 105
        '
        'ToolStripStatusLblDesTotalBoletos
        '
        Me.ToolStripStatusLblDesTotalBoletos.Name = "ToolStripStatusLblDesTotalBoletos"
        Me.ToolStripStatusLblDesTotalBoletos.Size = New System.Drawing.Size(130, 17)
        Me.ToolStripStatusLblDesTotalBoletos.Text = "Valor totas dos boletos:"
        '
        'ToolStripStatusLlbDesValorAVincular
        '
        Me.ToolStripStatusLlbDesValorAVincular.Name = "ToolStripStatusLlbDesValorAVincular"
        Me.ToolStripStatusLlbDesValorAVincular.Size = New System.Drawing.Size(118, 17)
        Me.ToolStripStatusLlbDesValorAVincular.Text = "Valor total a vincular:"
        '
        'labelValorVincular
        '
        Me.labelValorVincular.Name = "labelValorVincular"
        Me.labelValorVincular.Size = New System.Drawing.Size(121, 17)
        Me.labelValorVincular.Text = "ToolStripStatusLabel3"
        '
        'FormPagamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gridViewPgto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormPagamentos"
        Me.Text = "Pagamentos"
        CType(Me.gridViewPgto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridViewPgto As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerPgtoFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerPgtoIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents labelBarValorBoletos As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descrisao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valor_pgto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valor_vinculado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripStatusLblDesTotalBoletos As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLlbDesValorAVincular As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents labelValorVincular As System.Windows.Forms.ToolStripStatusLabel
End Class
