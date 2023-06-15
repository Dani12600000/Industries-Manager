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
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.VendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendasTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.VendasTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.Mail_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Venda_de_produtoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venda_de_produtoTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.Venda_de_produtoTableAdapter()
        Me.Venda_de_produtoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Mail_ClienteLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venda_de_produtoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venda_de_produtoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Mail_ClienteLabel
        '
        Mail_ClienteLabel.AutoSize = True
        Mail_ClienteLabel.Location = New System.Drawing.Point(12, 16)
        Mail_ClienteLabel.Name = "Mail_ClienteLabel"
        Mail_ClienteLabel.Size = New System.Drawing.Size(105, 20)
        Mail_ClienteLabel.TabIndex = 2
        Mail_ClienteLabel.Text = "Email Cliente:"
        '
        'Mail_ClienteTextBox
        '
        Me.Mail_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Mail_Cliente", True))
        Me.Mail_ClienteTextBox.Location = New System.Drawing.Point(123, 13)
        Me.Mail_ClienteTextBox.Name = "Mail_ClienteTextBox"
        Me.Mail_ClienteTextBox.Size = New System.Drawing.Size(253, 26)
        Me.Mail_ClienteTextBox.TabIndex = 3
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
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(123, 45)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(125, 26)
        Me.TotalTextBox.TabIndex = 5
        '
        'Venda_de_produtoBindingSource
        '
        Me.Venda_de_produtoBindingSource.DataMember = "VendasVenda de produto"
        Me.Venda_de_produtoBindingSource.DataSource = Me.VendasBindingSource
        '
        'Venda_de_produtoTableAdapter
        '
        Me.Venda_de_produtoTableAdapter.ClearBeforeFill = True
        '
        'Venda_de_produtoDataGridView
        '
        Me.Venda_de_produtoDataGridView.AutoGenerateColumns = False
        Me.Venda_de_produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Venda_de_produtoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Venda_de_produtoDataGridView.DataSource = Me.Venda_de_produtoBindingSource
        Me.Venda_de_produtoDataGridView.Location = New System.Drawing.Point(410, 16)
        Me.Venda_de_produtoDataGridView.Name = "Venda_de_produtoDataGridView"
        Me.Venda_de_produtoDataGridView.RowHeadersWidth = 62
        Me.Venda_de_produtoDataGridView.RowTemplate.Height = 28
        Me.Venda_de_produtoDataGridView.Size = New System.Drawing.Size(850, 220)
        Me.Venda_de_produtoDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_Produto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Produto"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 185
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
        Me.ClientSize = New System.Drawing.Size(1272, 356)
        Me.Controls.Add(Me.Venda_de_produtoDataGridView)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Mail_ClienteLabel)
        Me.Controls.Add(Me.Mail_ClienteTextBox)
        Me.Name = "Vendas"
        Me.Text = "Vendas"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venda_de_produtoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venda_de_produtoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
