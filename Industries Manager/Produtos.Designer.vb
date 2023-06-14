<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Produtos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim LucroLabel As System.Windows.Forms.Label
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.ProdutosTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.FornecimentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FornecimentosTableAdapter()
        Me.Venda_de_produtoTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.Venda_de_produtoTableAdapter()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.FornecimentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FornecimentosDataGridView = New System.Windows.Forms.DataGridView()
        Me.Venda_de_produtoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venda_de_produtoDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LucroNumericUpDown = New System.Windows.Forms.NumericUpDown()
        IDLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        LucroLabel = New System.Windows.Forms.Label()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecimentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecimentosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venda_de_produtoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venda_de_produtoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LucroNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(126, 34)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(101, 66)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(55, 20)
        NomeLabel.TabIndex = 2
        NomeLabel.Text = "Nome:"
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Location = New System.Drawing.Point(72, 98)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(84, 20)
        DescricaoLabel.TabIndex = 4
        DescricaoLabel.Text = "Descricao:"
        '
        'LucroLabel
        '
        LucroLabel.AutoSize = True
        LucroLabel.Location = New System.Drawing.Point(23, 179)
        LucroLabel.Name = "LucroLabel"
        LucroLabel.Size = New System.Drawing.Size(133, 20)
        LucroLabel.TabIndex = 6
        LucroLabel.Text = "Lucro pretendido:"
        '
        'Industries_DanDataSet
        '
        Me.Industries_DanDataSet.DataSetName = "Industries_DanDataSet"
        Me.Industries_DanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdutosBindingSource
        '
        Me.ProdutosBindingSource.DataMember = "Produtos"
        Me.ProdutosBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'ProdutosTableAdapter
        '
        Me.ProdutosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvisosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.Diretores_de_DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.FornecedoresTableAdapter = Nothing
        Me.TableAdapterManager.FornecimentosTableAdapter = Me.FornecimentosTableAdapter
        Me.TableAdapterManager.FuncionariosTableAdapter = Nothing
        Me.TableAdapterManager.Leitura_de_avisosTableAdapter = Nothing
        Me.TableAdapterManager.Login_FuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.ProdutosTableAdapter = Me.ProdutosTableAdapter
        Me.TableAdapterManager.ProfissõesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_de_produtoTableAdapter = Me.Venda_de_produtoTableAdapter
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'FornecimentosTableAdapter
        '
        Me.FornecimentosTableAdapter.ClearBeforeFill = True
        '
        'Venda_de_produtoTableAdapter
        '
        Me.Venda_de_produtoTableAdapter.ClearBeforeFill = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutosBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(162, 31)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutosBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(162, 63)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(276, 26)
        Me.NomeTextBox.TabIndex = 3
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutosBindingSource, "Descricao", True))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(162, 95)
        Me.DescricaoTextBox.Multiline = True
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.Size = New System.Drawing.Size(276, 75)
        Me.DescricaoTextBox.TabIndex = 5
        '
        'FornecimentosBindingSource
        '
        Me.FornecimentosBindingSource.DataMember = "ProdutosFornecimentos"
        Me.FornecimentosBindingSource.DataSource = Me.ProdutosBindingSource
        '
        'FornecimentosDataGridView
        '
        Me.FornecimentosDataGridView.AutoGenerateColumns = False
        Me.FornecimentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FornecimentosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.FornecimentosDataGridView.DataSource = Me.FornecimentosBindingSource
        Me.FornecimentosDataGridView.Location = New System.Drawing.Point(465, 31)
        Me.FornecimentosDataGridView.Name = "FornecimentosDataGridView"
        Me.FornecimentosDataGridView.ReadOnly = True
        Me.FornecimentosDataGridView.RowTemplate.Height = 28
        Me.FornecimentosDataGridView.Size = New System.Drawing.Size(582, 345)
        Me.FornecimentosDataGridView.TabIndex = 8
        '
        'Venda_de_produtoBindingSource
        '
        Me.Venda_de_produtoBindingSource.DataMember = "ProdutosVendas"
        Me.Venda_de_produtoBindingSource.DataSource = Me.ProdutosBindingSource
        '
        'Venda_de_produtoDataGridView
        '
        Me.Venda_de_produtoDataGridView.AutoGenerateColumns = False
        Me.Venda_de_produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Venda_de_produtoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.Venda_de_produtoDataGridView.DataSource = Me.Venda_de_produtoBindingSource
        Me.Venda_de_produtoDataGridView.Location = New System.Drawing.Point(1057, 31)
        Me.Venda_de_produtoDataGridView.Name = "Venda_de_produtoDataGridView"
        Me.Venda_de_produtoDataGridView.ReadOnly = True
        Me.Venda_de_produtoDataGridView.RowTemplate.Height = 28
        Me.Venda_de_produtoDataGridView.Size = New System.Drawing.Size(560, 345)
        Me.Venda_de_produtoDataGridView.TabIndex = 9
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(27, 254)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(166, 47)
        Me.Button9.TabIndex = 25
        Me.Button9.Text = "Novo"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(199, 254)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(166, 47)
        Me.Button8.TabIndex = 24
        Me.Button8.Text = "Remover"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(285, 307)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 69)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = ">|"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(199, 307)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 69)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(113, 307)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 69)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 69)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "|<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Data"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_Fornecedor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fornecedor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PCP"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Preço cada"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Quantidade"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Quant."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TG"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total Gasto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn4.Width = 25
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ID_Venda"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Venda"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn8.Width = 75
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Quantidade"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Quant."
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn10.Width = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PC"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Preço cada"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn11.Width = 85
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Subtotal"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn12.Width = 95
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(310, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "€"
        '
        'LucroNumericUpDown
        '
        Me.LucroNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProdutosBindingSource, "Lucro", True))
        Me.LucroNumericUpDown.DecimalPlaces = 2
        Me.LucroNumericUpDown.Increment = New Decimal(New Integer() {10, 0, 0, 131072})
        Me.LucroNumericUpDown.Location = New System.Drawing.Point(162, 178)
        Me.LucroNumericUpDown.Name = "LucroNumericUpDown"
        Me.LucroNumericUpDown.Size = New System.Drawing.Size(142, 26)
        Me.LucroNumericUpDown.TabIndex = 27
        Me.LucroNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1637, 396)
        Me.Controls.Add(Me.LucroNumericUpDown)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Venda_de_produtoDataGridView)
        Me.Controls.Add(Me.FornecimentosDataGridView)
        Me.Controls.Add(LucroLabel)
        Me.Controls.Add(DescricaoLabel)
        Me.Controls.Add(Me.DescricaoTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Name = "Produtos"
        Me.Text = "Produtos"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecimentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecimentosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venda_de_produtoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venda_de_produtoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LucroNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents ProdutosBindingSource As BindingSource
    Friend WithEvents ProdutosTableAdapter As Industries_DanDataSetTableAdapters.ProdutosTableAdapter
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents FornecimentosTableAdapter As Industries_DanDataSetTableAdapters.FornecimentosTableAdapter
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents DescricaoTextBox As TextBox
    Friend WithEvents FornecimentosBindingSource As BindingSource
    Friend WithEvents FornecimentosDataGridView As DataGridView
    Friend WithEvents Venda_de_produtoTableAdapter As Industries_DanDataSetTableAdapters.Venda_de_produtoTableAdapter
    Friend WithEvents Venda_de_produtoBindingSource As BindingSource
    Friend WithEvents Venda_de_produtoDataGridView As DataGridView
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents LucroNumericUpDown As NumericUpDown
End Class
