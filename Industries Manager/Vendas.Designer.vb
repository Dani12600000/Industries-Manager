<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendas
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
        Me.components = New System.ComponentModel.Container()
        Dim Mail_ClienteLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim ID_ProdutoLabel As System.Windows.Forms.Label
        Dim QuantidadeLabel As System.Windows.Forms.Label
        Dim PCLabel As System.Windows.Forms.Label
        Dim SubtotalLabel As System.Windows.Forms.Label
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.VendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendasTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.VendasTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.Venda_de_produtoTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.Venda_de_produtoTableAdapter()
        Me.Mail_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Venda_de_produtoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venda_de_produtoDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID_ProdutoComboBox = New System.Windows.Forms.ComboBox()
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PCTextBox = New System.Windows.Forms.TextBox()
        Me.SubtotalTextBox = New System.Windows.Forms.TextBox()
        Me.ProdutosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.ProdutosTableAdapter()
        Me.QuantidadeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ProdAdGroupBox = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ID_Produto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Mail_ClienteLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        ID_ProdutoLabel = New System.Windows.Forms.Label()
        QuantidadeLabel = New System.Windows.Forms.Label()
        PCLabel = New System.Windows.Forms.Label()
        SubtotalLabel = New System.Windows.Forms.Label()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venda_de_produtoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venda_de_produtoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantidadeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProdAdGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Mail_ClienteLabel
        '
        Mail_ClienteLabel.AutoSize = True
        Mail_ClienteLabel.Location = New System.Drawing.Point(12, 16)
        Mail_ClienteLabel.Name = "Mail_ClienteLabel"
        Mail_ClienteLabel.Size = New System.Drawing.Size(105, 20)
        Mail_ClienteLabel.TabIndex = 2
        Mail_ClienteLabel.Text = "Email Cliente:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(69, 48)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(48, 20)
        TotalLabel.TabIndex = 4
        TotalLabel.Text = "Total:"
        '
        'ID_ProdutoLabel
        '
        ID_ProdutoLabel.AutoSize = True
        ID_ProdutoLabel.Location = New System.Drawing.Point(33, 36)
        ID_ProdutoLabel.Name = "ID_ProdutoLabel"
        ID_ProdutoLabel.Size = New System.Drawing.Size(69, 20)
        ID_ProdutoLabel.TabIndex = 6
        ID_ProdutoLabel.Text = "Produto:"
        '
        'QuantidadeLabel
        '
        QuantidadeLabel.AutoSize = True
        QuantidadeLabel.Location = New System.Drawing.Point(6, 70)
        QuantidadeLabel.Name = "QuantidadeLabel"
        QuantidadeLabel.Size = New System.Drawing.Size(96, 20)
        QuantidadeLabel.TabIndex = 7
        QuantidadeLabel.Text = "Quantidade:"
        '
        'PCLabel
        '
        PCLabel.AutoSize = True
        PCLabel.Location = New System.Drawing.Point(6, 102)
        PCLabel.Name = "PCLabel"
        PCLabel.Size = New System.Drawing.Size(96, 20)
        PCLabel.TabIndex = 9
        PCLabel.Text = "Preco Cada:"
        '
        'SubtotalLabel
        '
        SubtotalLabel.AutoSize = True
        SubtotalLabel.Location = New System.Drawing.Point(29, 134)
        SubtotalLabel.Name = "SubtotalLabel"
        SubtotalLabel.Size = New System.Drawing.Size(73, 20)
        SubtotalLabel.TabIndex = 11
        SubtotalLabel.Text = "Subtotal:"
        '
        'Industries_DanDataSet
        '
        Me.Industries_DanDataSet.DataSetName = "Industries_DanDataSet"
        Me.Industries_DanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendasBindingSource
        '
        Me.VendasBindingSource.DataMember = "Vendas"
        Me.VendasBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'VendasTableAdapter
        '
        Me.VendasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvisosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.Diretores_de_DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.FornecedoresTableAdapter = Nothing
        Me.TableAdapterManager.FornecimentosTableAdapter = Nothing
        Me.TableAdapterManager.FuncionariosTableAdapter = Nothing
        Me.TableAdapterManager.Leitura_de_avisosTableAdapter = Nothing
        Me.TableAdapterManager.Login_FuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.ProdutosTableAdapter = Nothing
        Me.TableAdapterManager.ProfissõesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_de_produtoTableAdapter = Me.Venda_de_produtoTableAdapter
        Me.TableAdapterManager.VendasTableAdapter = Me.VendasTableAdapter
        '
        'Venda_de_produtoTableAdapter
        '
        Me.Venda_de_produtoTableAdapter.ClearBeforeFill = True
        '
        'Mail_ClienteTextBox
        '
        Me.Mail_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Mail_Cliente", True))
        Me.Mail_ClienteTextBox.Enabled = False
        Me.Mail_ClienteTextBox.Location = New System.Drawing.Point(123, 13)
        Me.Mail_ClienteTextBox.Name = "Mail_ClienteTextBox"
        Me.Mail_ClienteTextBox.Size = New System.Drawing.Size(280, 26)
        Me.Mail_ClienteTextBox.TabIndex = 3
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(123, 45)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(260, 26)
        Me.TotalTextBox.TabIndex = 5
        '
        'Venda_de_produtoBindingSource
        '
        Me.Venda_de_produtoBindingSource.DataMember = "VendasVenda de produto"
        Me.Venda_de_produtoBindingSource.DataSource = Me.VendasBindingSource
        '
        'Venda_de_produtoDataGridView
        '
        Me.Venda_de_produtoDataGridView.AllowUserToAddRows = False
        Me.Venda_de_produtoDataGridView.AllowUserToDeleteRows = False
        Me.Venda_de_produtoDataGridView.AllowUserToResizeColumns = False
        Me.Venda_de_produtoDataGridView.AllowUserToResizeRows = False
        Me.Venda_de_produtoDataGridView.AutoGenerateColumns = False
        Me.Venda_de_produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Venda_de_produtoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Produto, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Venda_de_produtoDataGridView.DataSource = Me.Venda_de_produtoBindingSource
        Me.Venda_de_produtoDataGridView.Location = New System.Drawing.Point(417, 16)
        Me.Venda_de_produtoDataGridView.Name = "Venda_de_produtoDataGridView"
        Me.Venda_de_produtoDataGridView.RowHeadersWidth = 62
        Me.Venda_de_produtoDataGridView.RowTemplate.Height = 28
        Me.Venda_de_produtoDataGridView.Size = New System.Drawing.Size(876, 313)
        Me.Venda_de_produtoDataGridView.TabIndex = 6
        '
        'ID_ProdutoComboBox
        '
        Me.ID_ProdutoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.ID_ProdutoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Venda_de_produtoBindingSource, "ID_Produto", True))
        Me.ID_ProdutoComboBox.DataSource = Me.ProdutosBindingSource
        Me.ID_ProdutoComboBox.DisplayMember = "Nome"
        Me.ID_ProdutoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ID_ProdutoComboBox.FormattingEnabled = True
        Me.ID_ProdutoComboBox.Location = New System.Drawing.Point(108, 36)
        Me.ID_ProdutoComboBox.Name = "ID_ProdutoComboBox"
        Me.ID_ProdutoComboBox.Size = New System.Drawing.Size(269, 28)
        Me.ID_ProdutoComboBox.TabIndex = 7
        Me.ID_ProdutoComboBox.ValueMember = "ID"
        '
        'ProdutosBindingSource
        '
        Me.ProdutosBindingSource.DataMember = "Produtos"
        Me.ProdutosBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'PCTextBox
        '
        Me.PCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Venda_de_produtoBindingSource, "PC", True))
        Me.PCTextBox.Location = New System.Drawing.Point(107, 99)
        Me.PCTextBox.Name = "PCTextBox"
        Me.PCTextBox.ReadOnly = True
        Me.PCTextBox.Size = New System.Drawing.Size(135, 26)
        Me.PCTextBox.TabIndex = 10
        '
        'SubtotalTextBox
        '
        Me.SubtotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Venda_de_produtoBindingSource, "Subtotal", True))
        Me.SubtotalTextBox.Location = New System.Drawing.Point(108, 131)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.ReadOnly = True
        Me.SubtotalTextBox.Size = New System.Drawing.Size(135, 26)
        Me.SubtotalTextBox.TabIndex = 12
        '
        'ProdutosTableAdapter
        '
        Me.ProdutosTableAdapter.ClearBeforeFill = True
        '
        'QuantidadeNumericUpDown
        '
        Me.QuantidadeNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Venda_de_produtoBindingSource, "Quantidade", True))
        Me.QuantidadeNumericUpDown.Location = New System.Drawing.Point(108, 70)
        Me.QuantidadeNumericUpDown.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.QuantidadeNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantidadeNumericUpDown.Name = "QuantidadeNumericUpDown"
        Me.QuantidadeNumericUpDown.Size = New System.Drawing.Size(135, 26)
        Me.QuantidadeNumericUpDown.TabIndex = 13
        Me.QuantidadeNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ProdAdGroupBox
        '
        Me.ProdAdGroupBox.Controls.Add(Me.Button2)
        Me.ProdAdGroupBox.Controls.Add(Me.Button1)
        Me.ProdAdGroupBox.Controls.Add(ID_ProdutoLabel)
        Me.ProdAdGroupBox.Controls.Add(Me.SubtotalTextBox)
        Me.ProdAdGroupBox.Controls.Add(Me.QuantidadeNumericUpDown)
        Me.ProdAdGroupBox.Controls.Add(Me.PCTextBox)
        Me.ProdAdGroupBox.Controls.Add(QuantidadeLabel)
        Me.ProdAdGroupBox.Controls.Add(SubtotalLabel)
        Me.ProdAdGroupBox.Controls.Add(PCLabel)
        Me.ProdAdGroupBox.Controls.Add(Me.ID_ProdutoComboBox)
        Me.ProdAdGroupBox.Location = New System.Drawing.Point(16, 106)
        Me.ProdAdGroupBox.Name = "ProdAdGroupBox"
        Me.ProdAdGroupBox.Size = New System.Drawing.Size(387, 223)
        Me.ProdAdGroupBox.TabIndex = 14
        Me.ProdAdGroupBox.TabStop = False
        Me.ProdAdGroupBox.Text = "Adicionar Produtos a compra"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button2.Location = New System.Drawing.Point(196, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 37)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Limpar produto"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 37)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Adicionar produto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 65)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "A venda é guardada automaticamente sempre que adiciona ou remove um produto da ve" &
    "nda"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.Location = New System.Drawing.Point(417, 342)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(251, 51)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Remover produto selecionado"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(382, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "€"
        '
        'ID_Produto
        '
        Me.ID_Produto.DataPropertyName = "ID_Produto"
        Me.ID_Produto.DataSource = Me.ProdutosBindingSource
        Me.ID_Produto.DisplayMember = "Nome"
        Me.ID_Produto.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ID_Produto.HeaderText = "Produto"
        Me.ID_Produto.MinimumWidth = 8
        Me.ID_Produto.Name = "ID_Produto"
        Me.ID_Produto.ReadOnly = True
        Me.ID_Produto.ValueMember = "ID"
        Me.ID_Produto.Width = 175
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantidade"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quant"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 65
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Preço Cada"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 115
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Subtotal"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 115
        '
        'Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 416)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProdAdGroupBox)
        Me.Controls.Add(Me.Venda_de_produtoDataGridView)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Mail_ClienteLabel)
        Me.Controls.Add(Me.Mail_ClienteTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Vendas"
        Me.Text = "Vendas"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venda_de_produtoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venda_de_produtoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantidadeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProdAdGroupBox.ResumeLayout(False)
        Me.ProdAdGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents VendasBindingSource As BindingSource
    Friend WithEvents VendasTableAdapter As Industries_DanDataSetTableAdapters.VendasTableAdapter
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Mail_ClienteTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents Venda_de_produtoTableAdapter As Industries_DanDataSetTableAdapters.Venda_de_produtoTableAdapter
    Friend WithEvents Venda_de_produtoBindingSource As BindingSource
    Friend WithEvents Venda_de_produtoDataGridView As DataGridView
    Friend WithEvents ID_ProdutoComboBox As ComboBox
    Friend WithEvents PCTextBox As TextBox
    Friend WithEvents SubtotalTextBox As TextBox
    Friend WithEvents ProdutosBindingSource As BindingSource
    Friend WithEvents ProdutosTableAdapter As Industries_DanDataSetTableAdapters.ProdutosTableAdapter
    Friend WithEvents QuantidadeNumericUpDown As NumericUpDown
    Friend WithEvents ProdAdGroupBox As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ID_Produto As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
