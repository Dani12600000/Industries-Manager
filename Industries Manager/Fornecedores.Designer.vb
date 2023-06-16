<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fornecedores
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NDELabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim NDILabel As System.Windows.Forms.Label
        Dim TDPLabel As System.Windows.Forms.Label
        Dim HQALabel As System.Windows.Forms.Label
        Dim HQFLabel As System.Windows.Forms.Label
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.FornecedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FornecedoresTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FornecedoresTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.NDETextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NDITextBox = New System.Windows.Forms.TextBox()
        Me.TDPTextBox = New System.Windows.Forms.TextBox()
        Me.HQADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HQFDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FornecimentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FornecimentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FornecimentosTableAdapter()
        Me.FornecimentosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdutosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.ProdutosTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        NDELabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        NDILabel = New System.Windows.Forms.Label()
        TDPLabel = New System.Windows.Forms.Label()
        HQALabel = New System.Windows.Forms.Label()
        HQFLabel = New System.Windows.Forms.Label()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecimentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecimentosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NDELabel
        '
        NDELabel.AutoSize = True
        NDELabel.Location = New System.Drawing.Point(41, 64)
        NDELabel.Name = "NDELabel"
        NDELabel.Size = New System.Drawing.Size(143, 20)
        NDELabel.TabIndex = 1
        NDELabel.Text = "Nome da empresa:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(154, 32)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 3
        IDLabel.Text = "ID:"
        '
        'NDILabel
        '
        NDILabel.AutoSize = True
        NDILabel.Location = New System.Drawing.Point(12, 96)
        NDILabel.Name = "NDILabel"
        NDILabel.Size = New System.Drawing.Size(172, 20)
        NDILabel.TabIndex = 4
        NDILabel.Text = "Nome do intermediario:"
        '
        'TDPLabel
        '
        TDPLabel.AutoSize = True
        TDPLabel.Location = New System.Drawing.Point(186, 128)
        TDPLabel.Name = "TDPLabel"
        TDPLabel.Size = New System.Drawing.Size(210, 20)
        TDPLabel.TabIndex = 6
        TDPLabel.Text = "Tipo de produtos que vende:"
        '
        'HQALabel
        '
        HQALabel.AutoSize = True
        HQALabel.Location = New System.Drawing.Point(69, 280)
        HQALabel.Name = "HQALabel"
        HQALabel.Size = New System.Drawing.Size(115, 20)
        HQALabel.TabIndex = 8
        HQALabel.Text = "Hora que abre:"
        '
        'HQFLabel
        '
        HQFLabel.AutoSize = True
        HQFLabel.Location = New System.Drawing.Point(61, 313)
        HQFLabel.Name = "HQFLabel"
        HQFLabel.Size = New System.Drawing.Size(123, 20)
        HQFLabel.TabIndex = 10
        HQFLabel.Text = "Hora que fecha:"
        '
        'Industries_DanDataSet
        '
        Me.Industries_DanDataSet.DataSetName = "Industries_DanDataSet"
        Me.Industries_DanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FornecedoresBindingSource
        '
        Me.FornecedoresBindingSource.DataMember = "Fornecedores"
        Me.FornecedoresBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'FornecedoresTableAdapter
        '
        Me.FornecedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvisosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.Diretores_de_DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.FornecedoresTableAdapter = Me.FornecedoresTableAdapter
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
        'NDETextBox
        '
        Me.NDETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "NDE", True))
        Me.NDETextBox.Location = New System.Drawing.Point(190, 61)
        Me.NDETextBox.Name = "NDETextBox"
        Me.NDETextBox.ReadOnly = True
        Me.NDETextBox.Size = New System.Drawing.Size(293, 26)
        Me.NDETextBox.TabIndex = 2
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(190, 29)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IDTextBox.TabIndex = 4
        '
        'NDITextBox
        '
        Me.NDITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "NDI", True))
        Me.NDITextBox.Location = New System.Drawing.Point(190, 93)
        Me.NDITextBox.Name = "NDITextBox"
        Me.NDITextBox.ReadOnly = True
        Me.NDITextBox.Size = New System.Drawing.Size(293, 26)
        Me.NDITextBox.TabIndex = 5
        '
        'TDPTextBox
        '
        Me.TDPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "TDP", True))
        Me.TDPTextBox.Location = New System.Drawing.Point(190, 151)
        Me.TDPTextBox.Multiline = True
        Me.TDPTextBox.Name = "TDPTextBox"
        Me.TDPTextBox.ReadOnly = True
        Me.TDPTextBox.Size = New System.Drawing.Size(293, 101)
        Me.TDPTextBox.TabIndex = 7
        '
        'HQADateTimePicker
        '
        Me.HQADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FornecedoresBindingSource, "HQA", True))
        Me.HQADateTimePicker.Enabled = False
        Me.HQADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.HQADateTimePicker.Location = New System.Drawing.Point(190, 275)
        Me.HQADateTimePicker.Name = "HQADateTimePicker"
        Me.HQADateTimePicker.Size = New System.Drawing.Size(100, 26)
        Me.HQADateTimePicker.TabIndex = 9
        '
        'HQFDateTimePicker
        '
        Me.HQFDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FornecedoresBindingSource, "HQF", True))
        Me.HQFDateTimePicker.Enabled = False
        Me.HQFDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.HQFDateTimePicker.Location = New System.Drawing.Point(190, 307)
        Me.HQFDateTimePicker.Name = "HQFDateTimePicker"
        Me.HQFDateTimePicker.Size = New System.Drawing.Size(100, 26)
        Me.HQFDateTimePicker.TabIndex = 11
        '
        'FornecimentosBindingSource
        '
        Me.FornecimentosBindingSource.DataMember = "FornecedoresFornecimentos"
        Me.FornecimentosBindingSource.DataSource = Me.FornecedoresBindingSource
        '
        'FornecimentosTableAdapter
        '
        Me.FornecimentosTableAdapter.ClearBeforeFill = True
        '
        'FornecimentosDataGridView
        '
        Me.FornecimentosDataGridView.AllowUserToAddRows = False
        Me.FornecimentosDataGridView.AllowUserToDeleteRows = False
        Me.FornecimentosDataGridView.AllowUserToResizeColumns = False
        Me.FornecimentosDataGridView.AllowUserToResizeRows = False
        Me.FornecimentosDataGridView.AutoGenerateColumns = False
        Me.FornecimentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FornecimentosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.FornecimentosDataGridView.DataSource = Me.FornecimentosBindingSource
        Me.FornecimentosDataGridView.Location = New System.Drawing.Point(503, 61)
        Me.FornecimentosDataGridView.Name = "FornecimentosDataGridView"
        Me.FornecimentosDataGridView.RowHeadersWidth = 62
        Me.FornecimentosDataGridView.RowTemplate.Height = 28
        Me.FornecimentosDataGridView.Size = New System.Drawing.Size(774, 404)
        Me.FornecimentosDataGridView.TabIndex = 12
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Data"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID_Produto"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.ProdutosBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "Nome"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Produto"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "ID"
        Me.DataGridViewTextBoxColumn4.Width = 145
        '
        'ProdutosBindingSource
        '
        Me.ProdutosBindingSource.DataMember = "Produtos"
        Me.ProdutosBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PCP"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Preço un"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Quantidade"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Quantidade"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TG"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'ProdutosTableAdapter
        '
        Me.ProdutosTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 408)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 57)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "|<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(161, 408)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 57)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(226, 408)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 57)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(291, 408)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(59, 57)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = ">|"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(499, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Fornecimentos"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.IndianRed
        Me.Button5.Location = New System.Drawing.Point(226, 355)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 47)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Remover"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(96, 355)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(124, 47)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Novo"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Fornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 477)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FornecimentosDataGridView)
        Me.Controls.Add(HQFLabel)
        Me.Controls.Add(Me.HQFDateTimePicker)
        Me.Controls.Add(HQALabel)
        Me.Controls.Add(Me.HQADateTimePicker)
        Me.Controls.Add(TDPLabel)
        Me.Controls.Add(Me.TDPTextBox)
        Me.Controls.Add(NDILabel)
        Me.Controls.Add(Me.NDITextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NDELabel)
        Me.Controls.Add(Me.NDETextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Fornecedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fornecedores"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecimentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecimentosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents FornecedoresBindingSource As BindingSource
    Friend WithEvents FornecedoresTableAdapter As Industries_DanDataSetTableAdapters.FornecedoresTableAdapter
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NDETextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NDITextBox As TextBox
    Friend WithEvents TDPTextBox As TextBox
    Friend WithEvents HQADateTimePicker As DateTimePicker
    Friend WithEvents HQFDateTimePicker As DateTimePicker
    Friend WithEvents FornecimentosBindingSource As BindingSource
    Friend WithEvents FornecimentosTableAdapter As Industries_DanDataSetTableAdapters.FornecimentosTableAdapter
    Friend WithEvents FornecimentosDataGridView As DataGridView
    Friend WithEvents ProdutosBindingSource As BindingSource
    Friend WithEvents ProdutosTableAdapter As Industries_DanDataSetTableAdapters.ProdutosTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
