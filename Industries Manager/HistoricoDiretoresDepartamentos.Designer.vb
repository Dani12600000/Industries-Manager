<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoricoDiretoresDepartamentos
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
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.Diretores_de_DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Diretores_de_DepartamentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.Diretores_de_DepartamentosTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.Diretores_de_DepartamentosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Funcionario = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diretores_de_DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diretores_de_DepartamentosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Industries_DanDataSet
        '
        Me.Industries_DanDataSet.DataSetName = "Industries_DanDataSet"
        Me.Industries_DanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Diretores_de_DepartamentosBindingSource
        '
        Me.Diretores_de_DepartamentosBindingSource.DataMember = "Diretores de Departamentos"
        Me.Diretores_de_DepartamentosBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'Diretores_de_DepartamentosTableAdapter
        '
        Me.Diretores_de_DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvisosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.Diretores_de_DepartamentosTableAdapter = Me.Diretores_de_DepartamentosTableAdapter
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
        'Diretores_de_DepartamentosDataGridView
        '
        Me.Diretores_de_DepartamentosDataGridView.AutoGenerateColumns = False
        Me.Diretores_de_DepartamentosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.Diretores_de_DepartamentosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Diretores_de_DepartamentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Diretores_de_DepartamentosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.ID_Funcionario, Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Diretores_de_DepartamentosDataGridView.DataSource = Me.Diretores_de_DepartamentosBindingSource
        Me.Diretores_de_DepartamentosDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.Diretores_de_DepartamentosDataGridView.Name = "Diretores_de_DepartamentosDataGridView"
        Me.Diretores_de_DepartamentosDataGridView.RowHeadersWidth = 62
        Me.Diretores_de_DepartamentosDataGridView.RowTemplate.Height = 28
        Me.Diretores_de_DepartamentosDataGridView.Size = New System.Drawing.Size(1401, 466)
        Me.Diretores_de_DepartamentosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 45
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DDD"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DDD"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 65
        '
        'ID_Funcionario
        '
        Me.ID_Funcionario.DataPropertyName = "ID_Funcionario"
        Me.ID_Funcionario.HeaderText = "Nome"
        Me.ID_Funcionario.MinimumWidth = 8
        Me.ID_Funcionario.Name = "ID_Funcionario"
        Me.ID_Funcionario.ReadOnly = True
        Me.ID_Funcionario.Width = 150
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "ID_Funcionario"
        Me.DataGridViewComboBoxColumn1.HeaderText = "Sobrenome"
        Me.DataGridViewComboBoxColumn1.MinimumWidth = 8
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.ReadOnly = True
        Me.DataGridViewComboBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Funcoes"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Funcoes"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 250
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DDC"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Data de Começo"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DDF"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Data de Fim"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'HistoricoDiretoresDepartamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1425, 490)
        Me.Controls.Add(Me.Diretores_de_DepartamentosDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "HistoricoDiretoresDepartamentos"
        Me.Text = "Historico de Diretores do Departamento"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diretores_de_DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diretores_de_DepartamentosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents Diretores_de_DepartamentosBindingSource As BindingSource
    Friend WithEvents Diretores_de_DepartamentosTableAdapter As Industries_DanDataSetTableAdapters.Diretores_de_DepartamentosTableAdapter
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Diretores_de_DepartamentosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ID_Funcionario As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
