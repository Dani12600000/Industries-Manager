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
        Dim DGLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Produtos))
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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Fornecedor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FornecedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Venda_de_produtoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venda_de_produtoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LucroNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DGTextBox = New System.Windows.Forms.TextBox()
        Me.PFTextBox = New System.Windows.Forms.TextBox()
        Me.FornecedoresTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FornecedoresTableAdapter()
        IDLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        LucroLabel = New System.Windows.Forms.Label()
        DGLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecimentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecimentosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venda_de_produtoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venda_de_produtoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LucroNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(126, 34)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NomeLabel
        '
        NomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(101, 66)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(55, 20)
        NomeLabel.TabIndex = 2
        NomeLabel.Text = "Nome:"
        '
        'DescricaoLabel
        '
        DescricaoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Location = New System.Drawing.Point(72, 98)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(84, 20)
        DescricaoLabel.TabIndex = 4
        DescricaoLabel.Text = "Descricao:"
        '
        'LucroLabel
        '
        LucroLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        LucroLabel.AutoSize = True
        LucroLabel.Location = New System.Drawing.Point(23, 223)
        LucroLabel.Name = "LucroLabel"
        LucroLabel.Size = New System.Drawing.Size(133, 20)
        LucroLabel.TabIndex = 6
        LucroLabel.Text = "Lucro pretendido:"
        '
        'DGLabel
        '
        DGLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        DGLabel.AutoSize = True
        DGLabel.Location = New System.Drawing.Point(27, 188)
        DGLabel.Name = "DGLabel"
        DGLabel.Size = New System.Drawing.Size(129, 20)
        DGLabel.TabIndex = 31
        DGLabel.Text = "Dineheiro Gasto:"
        '
        'Label4
        '
        Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(69, 265)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(87, 20)
        Label4.TabIndex = 33
        Label4.Text = "Preço final:"
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
        Me.IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutosBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(162, 31)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'NomeTextBox
        '
        Me.NomeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutosBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(162, 63)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.ReadOnly = True
        Me.NomeTextBox.Size = New System.Drawing.Size(276, 26)
        Me.NomeTextBox.TabIndex = 3
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutosBindingSource, "Descricao", True))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(162, 95)
        Me.DescricaoTextBox.Multiline = True
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.ReadOnly = True
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
        Me.FornecimentosDataGridView.AllowUserToAddRows = False
        Me.FornecimentosDataGridView.AllowUserToDeleteRows = False
        Me.FornecimentosDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.FornecimentosDataGridView.AutoGenerateColumns = False
        Me.FornecimentosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.FornecimentosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FornecimentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FornecimentosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.ID_Fornecedor, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.FornecimentosDataGridView.DataSource = Me.FornecimentosBindingSource
        Me.FornecimentosDataGridView.Location = New System.Drawing.Point(455, 63)
        Me.FornecimentosDataGridView.Name = "FornecimentosDataGridView"
        Me.FornecimentosDataGridView.ReadOnly = True
        Me.FornecimentosDataGridView.RowHeadersWidth = 62
        Me.FornecimentosDataGridView.RowTemplate.Height = 28
        Me.FornecimentosDataGridView.Size = New System.Drawing.Size(725, 289)
        Me.FornecimentosDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Data"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'ID_Fornecedor
        '
        Me.ID_Fornecedor.DataPropertyName = "ID_Fornecedor"
        Me.ID_Fornecedor.DataSource = Me.FornecedoresBindingSource
        Me.ID_Fornecedor.DisplayMember = "NDE"
        Me.ID_Fornecedor.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ID_Fornecedor.HeaderText = "Fornecedor"
        Me.ID_Fornecedor.MinimumWidth = 8
        Me.ID_Fornecedor.Name = "ID_Fornecedor"
        Me.ID_Fornecedor.ReadOnly = True
        Me.ID_Fornecedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.ID_Fornecedor.ValueMember = "ID"
        Me.ID_Fornecedor.Width = 85
        '
        'FornecedoresBindingSource
        '
        Me.FornecedoresBindingSource.DataMember = "Fornecedores"
        Me.FornecedoresBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PCP"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Preço cada"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn5.Width = 85
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Quantidade"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Quant."
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TG"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total Gasto"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn7.Width = 90
        '
        'Venda_de_produtoBindingSource
        '
        Me.Venda_de_produtoBindingSource.DataMember = "ProdutosVendas"
        Me.Venda_de_produtoBindingSource.DataSource = Me.ProdutosBindingSource
        '
        'Venda_de_produtoDataGridView
        '
        Me.Venda_de_produtoDataGridView.AllowUserToAddRows = False
        Me.Venda_de_produtoDataGridView.AllowUserToDeleteRows = False
        Me.Venda_de_produtoDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Venda_de_produtoDataGridView.AutoGenerateColumns = False
        Me.Venda_de_produtoDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.Venda_de_produtoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Venda_de_produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Venda_de_produtoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.Venda_de_produtoDataGridView.DataSource = Me.Venda_de_produtoBindingSource
        Me.Venda_de_produtoDataGridView.Location = New System.Drawing.Point(1191, 63)
        Me.Venda_de_produtoDataGridView.Name = "Venda_de_produtoDataGridView"
        Me.Venda_de_produtoDataGridView.ReadOnly = True
        Me.Venda_de_produtoDataGridView.RowHeadersWidth = 62
        Me.Venda_de_produtoDataGridView.RowTemplate.Height = 28
        Me.Venda_de_produtoDataGridView.Size = New System.Drawing.Size(611, 353)
        Me.Venda_de_produtoDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn4.Width = 25
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ID_Venda"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Venda"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn8.Width = 75
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Quantidade"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Quant."
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn10.Width = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PC"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Preço cada"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn11.Width = 85
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Subtotal"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn12.Width = 95
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button9.Location = New System.Drawing.Point(56, 305)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(166, 47)
        Me.Button9.TabIndex = 25
        Me.Button9.Text = "Novo"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button8.BackColor = System.Drawing.Color.IndianRed
        Me.Button8.Location = New System.Drawing.Point(228, 305)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(166, 47)
        Me.Button8.TabIndex = 24
        Me.Button8.Text = "Remover"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button4.Location = New System.Drawing.Point(314, 358)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 69)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = ">|"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button3.Location = New System.Drawing.Point(228, 358)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 69)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button2.Location = New System.Drawing.Point(142, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 69)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.Location = New System.Drawing.Point(56, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 69)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "|<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(306, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "€"
        '
        'LucroNumericUpDown
        '
        Me.LucroNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LucroNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProdutosBindingSource, "Lucro", True))
        Me.LucroNumericUpDown.DecimalPlaces = 2
        Me.LucroNumericUpDown.Enabled = False
        Me.LucroNumericUpDown.Increment = New Decimal(New Integer() {10, 0, 0, 131072})
        Me.LucroNumericUpDown.Location = New System.Drawing.Point(162, 222)
        Me.LucroNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LucroNumericUpDown.Name = "LucroNumericUpDown"
        Me.LucroNumericUpDown.Size = New System.Drawing.Size(142, 26)
        Me.LucroNumericUpDown.TabIndex = 27
        Me.LucroNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LucroNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.Location = New System.Drawing.Point(451, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(729, 23)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Fornecimentos"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.Location = New System.Drawing.Point(1191, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(611, 23)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Vendas"
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button5.Location = New System.Drawing.Point(630, 369)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(368, 47)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "Novo fornecimento"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button6.Location = New System.Drawing.Point(343, 222)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(95, 31)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "Editar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DGTextBox
        '
        Me.DGTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DGTextBox.Location = New System.Drawing.Point(163, 186)
        Me.DGTextBox.Name = "DGTextBox"
        Me.DGTextBox.ReadOnly = True
        Me.DGTextBox.Size = New System.Drawing.Size(275, 26)
        Me.DGTextBox.TabIndex = 32
        '
        'PFTextBox
        '
        Me.PFTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PFTextBox.Location = New System.Drawing.Point(162, 262)
        Me.PFTextBox.Name = "PFTextBox"
        Me.PFTextBox.ReadOnly = True
        Me.PFTextBox.Size = New System.Drawing.Size(275, 26)
        Me.PFTextBox.TabIndex = 34
        '
        'FornecedoresTableAdapter
        '
        Me.FornecedoresTableAdapter.ClearBeforeFill = True
        '
        'Produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1814, 447)
        Me.Controls.Add(Me.PFTextBox)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.DGTextBox)
        Me.Controls.Add(DGLabel)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Produtos"
        Me.Text = "Produtos"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecimentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecimentosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents LucroNumericUpDown As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DGTextBox As TextBox
    Friend WithEvents PFTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents FornecedoresBindingSource As BindingSource
    Friend WithEvents FornecedoresTableAdapter As Industries_DanDataSetTableAdapters.FornecedoresTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ID_Fornecedor As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
