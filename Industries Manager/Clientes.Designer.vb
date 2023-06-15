<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
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
        Dim MailLabel As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim NIBLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim SobrenomeLabel As System.Windows.Forms.Label
        Dim DDNLabel As System.Windows.Forms.Label
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.NIFTextBox = New System.Windows.Forms.TextBox()
        Me.NIBTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.SobrenomeTextBox = New System.Windows.Forms.TextBox()
        Me.VendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendasDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.VendasTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.VendasTableAdapter()
        Me.Venda_de_produtoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venda_de_produtoTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.Venda_de_produtoTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Venda_de_produtoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.DDNDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IndustriesDanDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.ProdutosTableAdapter()
        Me.Venda_de_produtoDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        MailLabel = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        NIBLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        SobrenomeLabel = New System.Windows.Forms.Label()
        DDNLabel = New System.Windows.Forms.Label()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venda_de_produtoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venda_de_produtoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndustriesDanDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venda_de_produtoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(21, 20)
        MailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(41, 20)
        MailLabel.TabIndex = 1
        MailLabel.Text = "Mail:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.Location = New System.Drawing.Point(21, 60)
        NIFLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(39, 20)
        NIFLabel.TabIndex = 3
        NIFLabel.Text = "NIF:"
        '
        'NIBLabel
        '
        NIBLabel.AutoSize = True
        NIBLabel.Location = New System.Drawing.Point(21, 100)
        NIBLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NIBLabel.Name = "NIBLabel"
        NIBLabel.Size = New System.Drawing.Size(40, 20)
        NIBLabel.TabIndex = 5
        NIBLabel.Text = "NIB:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(21, 171)
        NomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(55, 20)
        NomeLabel.TabIndex = 7
        NomeLabel.Text = "Nome:"
        '
        'SobrenomeLabel
        '
        SobrenomeLabel.AutoSize = True
        SobrenomeLabel.Location = New System.Drawing.Point(225, 171)
        SobrenomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SobrenomeLabel.Name = "SobrenomeLabel"
        SobrenomeLabel.Size = New System.Drawing.Size(96, 20)
        SobrenomeLabel.TabIndex = 9
        SobrenomeLabel.Text = "Sobrenome:"
        AddHandler SobrenomeLabel.Click, AddressOf Me.SobrenomeLabel_Click
        '
        'DDNLabel
        '
        DDNLabel.AutoSize = True
        DDNLabel.Location = New System.Drawing.Point(21, 290)
        DDNLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DDNLabel.Name = "DDNLabel"
        DDNLabel.Size = New System.Drawing.Size(160, 20)
        DDNLabel.TabIndex = 23
        DDNLabel.Text = "Data de nascimento :"
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(70, 15)
        Me.MailTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.ReadOnly = True
        Me.MailTextBox.Size = New System.Drawing.Size(398, 26)
        Me.MailTextBox.TabIndex = 2
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'Industries_DanDataSet
        '
        Me.Industries_DanDataSet.DataSetName = "Industries_DanDataSet"
        Me.Industries_DanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NIFTextBox
        '
        Me.NIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "NIF", True))
        Me.NIFTextBox.Location = New System.Drawing.Point(70, 55)
        Me.NIFTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NIFTextBox.Name = "NIFTextBox"
        Me.NIFTextBox.ReadOnly = True
        Me.NIFTextBox.Size = New System.Drawing.Size(248, 26)
        Me.NIFTextBox.TabIndex = 4
        '
        'NIBTextBox
        '
        Me.NIBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "NIB", True))
        Me.NIBTextBox.Location = New System.Drawing.Point(70, 95)
        Me.NIBTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NIBTextBox.Name = "NIBTextBox"
        Me.NIBTextBox.ReadOnly = True
        Me.NIBTextBox.Size = New System.Drawing.Size(248, 26)
        Me.NIBTextBox.TabIndex = 6
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(26, 195)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.ReadOnly = True
        Me.NomeTextBox.Size = New System.Drawing.Size(194, 26)
        Me.NomeTextBox.TabIndex = 8
        '
        'SobrenomeTextBox
        '
        Me.SobrenomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Sobrenome", True))
        Me.SobrenomeTextBox.Location = New System.Drawing.Point(230, 195)
        Me.SobrenomeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SobrenomeTextBox.Name = "SobrenomeTextBox"
        Me.SobrenomeTextBox.ReadOnly = True
        Me.SobrenomeTextBox.Size = New System.Drawing.Size(240, 26)
        Me.SobrenomeTextBox.TabIndex = 10
        '
        'VendasBindingSource
        '
        Me.VendasBindingSource.DataMember = "ClientesVendas"
        Me.VendasBindingSource.DataSource = Me.ClientesBindingSource
        '
        'VendasDataGridView
        '
        Me.VendasDataGridView.AllowUserToAddRows = False
        Me.VendasDataGridView.AllowUserToDeleteRows = False
        Me.VendasDataGridView.AllowUserToResizeColumns = False
        Me.VendasDataGridView.AllowUserToResizeRows = False
        Me.VendasDataGridView.AutoGenerateColumns = False
        Me.VendasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VendasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.Total})
        Me.VendasDataGridView.DataSource = Me.VendasBindingSource
        Me.VendasDataGridView.Location = New System.Drawing.Point(542, 55)
        Me.VendasDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.VendasDataGridView.Name = "VendasDataGridView"
        Me.VendasDataGridView.ReadOnly = True
        Me.VendasDataGridView.RowHeadersWidth = 62
        Me.VendasDataGridView.Size = New System.Drawing.Size(446, 335)
        Me.VendasDataGridView.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 456)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 63)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "|<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(163, 456)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 63)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(239, 456)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 63)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(316, 456)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 63)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = ">|"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(537, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(450, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Compras realizadas"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvisosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
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
        Me.TableAdapterManager.Venda_de_produtoTableAdapter = Nothing
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'VendasTableAdapter
        '
        Me.VendasTableAdapter.ClearBeforeFill = True
        '
        'Venda_de_produtoBindingSource
        '
        Me.Venda_de_produtoBindingSource.DataMember = "Venda de produto"
        Me.Venda_de_produtoBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'Venda_de_produtoTableAdapter
        '
        Me.Venda_de_produtoTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(990, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(551, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Produtos na compra"
        '
        'Venda_de_produtoBindingSource1
        '
        Me.Venda_de_produtoBindingSource1.DataMember = "VendasVenda de produto"
        Me.Venda_de_produtoBindingSource1.DataSource = Me.VendasBindingSource
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(848, 456)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(68, 63)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = ">|"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(772, 456)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(68, 63)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = ">"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(696, 456)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(68, 63)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "<"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(619, 456)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(68, 63)
        Me.Button8.TabIndex = 20
        Me.Button8.Text = "|<"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'DDNDateTimePicker
        '
        Me.DDNDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientesBindingSource, "DDN", True))
        Me.DDNDateTimePicker.Enabled = False
        Me.DDNDateTimePicker.Location = New System.Drawing.Point(22, 315)
        Me.DDNDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DDNDateTimePicker.Name = "DDNDateTimePicker"
        Me.DDNDateTimePicker.Size = New System.Drawing.Size(446, 26)
        Me.DDNDateTimePicker.TabIndex = 24
        '
        'ProdutosBindingSource
        '
        Me.ProdutosBindingSource.DataMember = "Produtos"
        Me.ProdutosBindingSource.DataSource = Me.IndustriesDanDataSetBindingSource
        '
        'IndustriesDanDataSetBindingSource
        '
        Me.IndustriesDanDataSetBindingSource.DataSource = Me.Industries_DanDataSet
        Me.IndustriesDanDataSetBindingSource.Position = 0
        '
        'ProdutosTableAdapter
        '
        Me.ProdutosTableAdapter.ClearBeforeFill = True
        '
        'Venda_de_produtoDataGridView
        '
        Me.Venda_de_produtoDataGridView.AllowUserToAddRows = False
        Me.Venda_de_produtoDataGridView.AllowUserToDeleteRows = False
        Me.Venda_de_produtoDataGridView.AllowUserToResizeColumns = False
        Me.Venda_de_produtoDataGridView.AllowUserToResizeRows = False
        Me.Venda_de_produtoDataGridView.AutoGenerateColumns = False
        Me.Venda_de_produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Venda_de_produtoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn6, Me.PC, Me.Subtotal})
        Me.Venda_de_produtoDataGridView.DataSource = Me.Venda_de_produtoBindingSource1
        Me.Venda_de_produtoDataGridView.Location = New System.Drawing.Point(994, 55)
        Me.Venda_de_produtoDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Venda_de_produtoDataGridView.Name = "Venda_de_produtoDataGridView"
        Me.Venda_de_produtoDataGridView.RowHeadersVisible = False
        Me.Venda_de_produtoDataGridView.RowHeadersWidth = 62
        Me.Venda_de_produtoDataGridView.Size = New System.Drawing.Size(547, 464)
        Me.Venda_de_produtoDataGridView.TabIndex = 24
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID_Produto"
        Me.Column1.DataSource = Me.ProdutosBindingSource
        Me.Column1.DisplayMember = "Nome"
        Me.Column1.HeaderText = "Produtos"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.ValueMember = "ID"
        Me.Column1.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Quantidade"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Quant"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'PC
        '
        Me.PC.DataPropertyName = "PC"
        Me.PC.HeaderText = "Preço cada"
        Me.PC.MinimumWidth = 8
        Me.PC.Name = "PC"
        Me.PC.ReadOnly = True
        Me.PC.Width = 75
        '
        'Subtotal
        '
        Me.Subtotal.DataPropertyName = "Subtotal"
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.MinimumWidth = 8
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 85
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(86, 401)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(145, 47)
        Me.Button10.TabIndex = 26
        Me.Button10.Text = "Novo"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(240, 401)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(144, 47)
        Me.Button11.TabIndex = 27
        Me.Button11.Text = "Remover"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DDC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Data da compra"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 95
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 8
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 85
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(773, 401)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(144, 47)
        Me.Button9.TabIndex = 29
        Me.Button9.Text = "Remover"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(619, 401)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(145, 47)
        Me.Button12.TabIndex = 28
        Me.Button12.Text = "Novo"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1554, 534)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Venda_de_produtoDataGridView)
        Me.Controls.Add(DDNLabel)
        Me.Controls.Add(Me.DDNDateTimePicker)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VendasDataGridView)
        Me.Controls.Add(SobrenomeLabel)
        Me.Controls.Add(Me.SobrenomeTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(NIBLabel)
        Me.Controls.Add(Me.NIBTextBox)
        Me.Controls.Add(NIFLabel)
        Me.Controls.Add(Me.NIFTextBox)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venda_de_produtoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venda_de_produtoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndustriesDanDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venda_de_produtoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As Industries_DanDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents NIFTextBox As TextBox
    Friend WithEvents NIBTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents SobrenomeTextBox As TextBox
    Friend WithEvents VendasBindingSource As BindingSource
    Friend WithEvents VendasTableAdapter As Industries_DanDataSetTableAdapters.VendasTableAdapter
    Friend WithEvents VendasDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Venda_de_produtoBindingSource As BindingSource
    Friend WithEvents Venda_de_produtoTableAdapter As Industries_DanDataSetTableAdapters.Venda_de_produtoTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Venda_de_produtoBindingSource1 As BindingSource
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents DDNDateTimePicker As DateTimePicker
    Friend WithEvents IndustriesDanDataSetBindingSource As BindingSource
    Friend WithEvents ProdutosBindingSource As BindingSource
    Friend WithEvents ProdutosTableAdapter As Industries_DanDataSetTableAdapters.ProdutosTableAdapter
    Friend WithEvents Venda_de_produtoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents PC As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Button9 As Button
    Friend WithEvents Button12 As Button
End Class
