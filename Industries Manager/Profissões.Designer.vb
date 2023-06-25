<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profissões
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim ProfissaoLabel As System.Windows.Forms.Label
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.ProfissõesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfissõesTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.ProfissõesTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.FuncionariosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FuncionariosTableAdapter()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.ProfissaoTextBox = New System.Windows.Forms.TextBox()
        Me.FuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncionariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.DepartamentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.DepartamentosTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        ProfissaoLabel = New System.Windows.Forms.Label()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfissõesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(76, 45)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'ProfissaoLabel
        '
        ProfissaoLabel.AutoSize = True
        ProfissaoLabel.Location = New System.Drawing.Point(27, 77)
        ProfissaoLabel.Name = "ProfissaoLabel"
        ProfissaoLabel.Size = New System.Drawing.Size(79, 20)
        ProfissaoLabel.TabIndex = 2
        ProfissaoLabel.Text = "Profissão:"
        '
        'Industries_DanDataSet
        '
        Me.Industries_DanDataSet.DataSetName = "Industries_DanDataSet"
        Me.Industries_DanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfissõesBindingSource
        '
        Me.ProfissõesBindingSource.DataMember = "Profissões"
        Me.ProfissõesBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'ProfissõesTableAdapter
        '
        Me.ProfissõesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.FuncionariosTableAdapter = Me.FuncionariosTableAdapter
        Me.TableAdapterManager.Leitura_de_avisosTableAdapter = Nothing
        Me.TableAdapterManager.Login_FuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.ProdutosTableAdapter = Nothing
        Me.TableAdapterManager.ProfissõesTableAdapter = Me.ProfissõesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_de_produtoTableAdapter = Nothing
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'FuncionariosTableAdapter
        '
        Me.FuncionariosTableAdapter.ClearBeforeFill = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissõesBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(112, 42)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'ProfissaoTextBox
        '
        Me.ProfissaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissõesBindingSource, "Profissao", True))
        Me.ProfissaoTextBox.Location = New System.Drawing.Point(112, 74)
        Me.ProfissaoTextBox.Name = "ProfissaoTextBox"
        Me.ProfissaoTextBox.ReadOnly = True
        Me.ProfissaoTextBox.Size = New System.Drawing.Size(238, 26)
        Me.ProfissaoTextBox.TabIndex = 3
        '
        'FuncionariosBindingSource
        '
        Me.FuncionariosBindingSource.DataMember = "ProfissõesFuncionarios"
        Me.FuncionariosBindingSource.DataSource = Me.ProfissõesBindingSource
        '
        'FuncionariosDataGridView
        '
        Me.FuncionariosDataGridView.AllowUserToAddRows = False
        Me.FuncionariosDataGridView.AllowUserToDeleteRows = False
        Me.FuncionariosDataGridView.AutoGenerateColumns = False
        Me.FuncionariosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.FuncionariosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FuncionariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FuncionariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Departamento, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.FuncionariosDataGridView.DataSource = Me.FuncionariosBindingSource
        Me.FuncionariosDataGridView.Location = New System.Drawing.Point(369, 65)
        Me.FuncionariosDataGridView.Name = "FuncionariosDataGridView"
        Me.FuncionariosDataGridView.ReadOnly = True
        Me.FuncionariosDataGridView.RowHeadersWidth = 62
        Me.FuncionariosDataGridView.RowTemplate.Height = 28
        Me.FuncionariosDataGridView.Size = New System.Drawing.Size(1341, 326)
        Me.FuncionariosDataGridView.TabIndex = 4
        '
        'DepartamentosBindingSource
        '
        Me.DepartamentosBindingSource.DataMember = "Departamentos"
        Me.DepartamentosBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(12, 322)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(166, 47)
        Me.Button9.TabIndex = 31
        Me.Button9.Text = "Nova profissão"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(270, 375)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 69)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = ">|"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(184, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 69)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(98, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 69)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 69)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "|<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(365, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Funcionarios com essa profissão"
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(552, 397)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(225, 47)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Todos com esta profissão"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(783, 397)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(225, 47)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "Apenas funcionarios"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(1014, 397)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(225, 47)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "Apenas novos candidatos"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(1245, 397)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(225, 47)
        Me.Button10.TabIndex = 36
        Me.Button10.Text = "Apenas ex-funcionarios"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(184, 322)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(166, 47)
        Me.Button11.TabIndex = 37
        Me.Button11.Text = "Editar profissão"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'DepartamentosTableAdapter
        '
        Me.DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 85
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Sobrenome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sobrenome"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.Width = 115
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'Departamento
        '
        Me.Departamento.DataPropertyName = "ID_Departamento"
        Me.Departamento.DataSource = Me.DepartamentosBindingSource
        Me.Departamento.DisplayMember = "ADD"
        Me.Departamento.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.MinimumWidth = 8
        Me.Departamento.Name = "Departamento"
        Me.Departamento.ReadOnly = True
        Me.Departamento.ValueMember = "ID"
        Me.Departamento.Width = 90
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SI"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Salário atual/pretendido"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn8.Width = 145
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DDEDE"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Data entrada"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn9.Width = 95
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DDSDE"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Data saída"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn10.Width = 90
        '
        'Profissões
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1722, 456)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FuncionariosDataGridView)
        Me.Controls.Add(ProfissaoLabel)
        Me.Controls.Add(Me.ProfissaoTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Name = "Profissões"
        Me.Text = "Profissões"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfissõesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents ProfissõesBindingSource As BindingSource
    Friend WithEvents ProfissõesTableAdapter As Industries_DanDataSetTableAdapters.ProfissõesTableAdapter
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents FuncionariosTableAdapter As Industries_DanDataSetTableAdapters.FuncionariosTableAdapter
    Friend WithEvents ProfissaoTextBox As TextBox
    Friend WithEvents FuncionariosBindingSource As BindingSource
    Friend WithEvents FuncionariosDataGridView As DataGridView
    Friend WithEvents Button9 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents DepartamentosBindingSource As BindingSource
    Friend WithEvents DepartamentosTableAdapter As Industries_DanDataSetTableAdapters.DepartamentosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Departamento As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
