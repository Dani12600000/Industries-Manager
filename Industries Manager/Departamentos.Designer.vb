<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Departamentos
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
        Dim NDDLabel As System.Windows.Forms.Label
        Dim DEDDLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.NDDTextBox = New System.Windows.Forms.TextBox()
        Me.DEDDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Diretores_de_DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.DepartamentosTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.Diretores_de_DepartamentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.Diretores_de_DepartamentosTableAdapter()
        Me.FuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncionariosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FuncionariosTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DDCDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.FuncionariosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncionariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ID_FuncionarioTextBox = New System.Windows.Forms.TextBox()
        Me.DepartamentosDiretoresDeDepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        NDDLabel = New System.Windows.Forms.Label()
        DEDDLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diretores_de_DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosDiretoresDeDepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(184, 54)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NDDLabel
        '
        NDDLabel.AutoSize = True
        NDDLabel.Location = New System.Drawing.Point(27, 86)
        NDDLabel.Name = "NDDLabel"
        NDDLabel.Size = New System.Drawing.Size(187, 20)
        NDDLabel.TabIndex = 2
        NDDLabel.Text = "Nome Do Departamento:"
        '
        'DEDDLabel
        '
        DEDDLabel.AutoSize = True
        DEDDLabel.Location = New System.Drawing.Point(27, 134)
        DEDDLabel.Name = "DEDDLabel"
        DEDDLabel.Size = New System.Drawing.Size(288, 20)
        DEDDLabel.TabIndex = 4
        DEDDLabel.Text = "Descrição Extensiva Do Departamento:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(489, 51)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(119, 20)
        Label1.TabIndex = 11
        Label1.Text = "Diretor(a) atual:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentosBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(220, 51)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(124, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'DepartamentosBindingSource
        '
        Me.DepartamentosBindingSource.DataMember = "Departamentos"
        Me.DepartamentosBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'Industries_DanDataSet
        '
        Me.Industries_DanDataSet.DataSetName = "Industries_DanDataSet"
        Me.Industries_DanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NDDTextBox
        '
        Me.NDDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentosBindingSource, "NDD", True))
        Me.NDDTextBox.Location = New System.Drawing.Point(220, 83)
        Me.NDDTextBox.Name = "NDDTextBox"
        Me.NDDTextBox.ReadOnly = True
        Me.NDDTextBox.Size = New System.Drawing.Size(227, 26)
        Me.NDDTextBox.TabIndex = 3
        '
        'DEDDTextBox
        '
        Me.DEDDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentosBindingSource, "DEDD", True))
        Me.DEDDTextBox.Location = New System.Drawing.Point(31, 157)
        Me.DEDDTextBox.Multiline = True
        Me.DEDDTextBox.Name = "DEDDTextBox"
        Me.DEDDTextBox.ReadOnly = True
        Me.DEDDTextBox.Size = New System.Drawing.Size(416, 92)
        Me.DEDDTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 69)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "|<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(117, 369)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 69)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(203, 369)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 69)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(289, 369)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 69)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = ">|"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Diretores_de_DepartamentosBindingSource
        '
        Me.Diretores_de_DepartamentosBindingSource.DataMember = "DepartamentosDiretores de Departamentos"
        Me.Diretores_de_DepartamentosBindingSource.DataSource = Me.DepartamentosBindingSource
        '
        'DepartamentosTableAdapter
        '
        Me.DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvisosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentosTableAdapter = Me.DepartamentosTableAdapter
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
        'Diretores_de_DepartamentosTableAdapter
        '
        Me.Diretores_de_DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'FuncionariosTableAdapter
        '
        Me.FuncionariosTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(971, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Desde"
        '
        'DDCDateTimePicker
        '
        Me.DDCDateTimePicker.CustomFormat = ""
        Me.DDCDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Diretores_de_DepartamentosBindingSource, "DDC", True))
        Me.DDCDateTimePicker.Enabled = False
        Me.DDCDateTimePicker.Location = New System.Drawing.Point(975, 74)
        Me.DDCDateTimePicker.Name = "DDCDateTimePicker"
        Me.DDCDateTimePicker.Size = New System.Drawing.Size(128, 26)
        Me.DDCDateTimePicker.TabIndex = 14
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.RosyBrown
        Me.Button5.Location = New System.Drawing.Point(1166, 71)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(147, 32)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Despedir"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'FuncionariosBindingSource1
        '
        Me.FuncionariosBindingSource1.DataMember = "DepartamentosFuncionarios"
        Me.FuncionariosBindingSource1.DataSource = Me.DepartamentosBindingSource
        '
        'FuncionariosDataGridView
        '
        Me.FuncionariosDataGridView.AutoGenerateColumns = False
        Me.FuncionariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FuncionariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.FuncionariosDataGridView.DataSource = Me.FuncionariosBindingSource1
        Me.FuncionariosDataGridView.Location = New System.Drawing.Point(493, 134)
        Me.FuncionariosDataGridView.Name = "FuncionariosDataGridView"
        Me.FuncionariosDataGridView.RowHeadersWidth = 62
        Me.FuncionariosDataGridView.RowTemplate.Height = 28
        Me.FuncionariosDataGridView.Size = New System.Drawing.Size(1042, 304)
        Me.FuncionariosDataGridView.TabIndex = 15
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Sobrenome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sobrenome"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SI"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Salario"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DDEDE"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Entrada"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DDSDE"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Saida"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1363, 71)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(172, 32)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Historico"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(614, 49)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(146, 30)
        Me.Button7.TabIndex = 17
        Me.Button7.Text = "Eleger diretor"
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.IndianRed
        Me.Button8.Location = New System.Drawing.Point(203, 316)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(166, 47)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "Remover"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(31, 316)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(166, 47)
        Me.Button9.TabIndex = 19
        Me.Button9.Text = "Novo"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(766, 49)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(146, 30)
        Me.Button10.TabIndex = 20
        Me.Button10.Text = "Despedir diretor"
        Me.Button10.UseVisualStyleBackColor = True
        Me.Button10.Visible = False
        '
        'ID_FuncionarioTextBox
        '
        Me.ID_FuncionarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Diretores_de_DepartamentosBindingSource, "ID_Funcionario", True))
        Me.ID_FuncionarioTextBox.Location = New System.Drawing.Point(493, 74)
        Me.ID_FuncionarioTextBox.Name = "ID_FuncionarioTextBox"
        Me.ID_FuncionarioTextBox.ReadOnly = True
        Me.ID_FuncionarioTextBox.Size = New System.Drawing.Size(43, 26)
        Me.ID_FuncionarioTextBox.TabIndex = 21
        '
        'DepartamentosDiretoresDeDepartamentosBindingSource
        '
        Me.DepartamentosDiretoresDeDepartamentosBindingSource.DataMember = "DepartamentosDiretores de Departamentos"
        Me.DepartamentosDiretoresDeDepartamentosBindingSource.DataSource = Me.DepartamentosBindingSource
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(542, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(407, 26)
        Me.TextBox1.TabIndex = 22
        '
        'Departamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1555, 458)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.FuncionariosDataGridView)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DDCDateTimePicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DEDDLabel)
        Me.Controls.Add(Me.DEDDTextBox)
        Me.Controls.Add(NDDLabel)
        Me.Controls.Add(Me.NDDTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.ID_FuncionarioTextBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Departamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departamentos"
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diretores_de_DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosDiretoresDeDepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents DepartamentosBindingSource As BindingSource
    Friend WithEvents DepartamentosTableAdapter As Industries_DanDataSetTableAdapters.DepartamentosTableAdapter
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NDDTextBox As TextBox
    Friend WithEvents DEDDTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Diretores_de_DepartamentosTableAdapter As Industries_DanDataSetTableAdapters.Diretores_de_DepartamentosTableAdapter
    Friend WithEvents Diretores_de_DepartamentosBindingSource As BindingSource
    Friend WithEvents FuncionariosBindingSource As BindingSource
    Friend WithEvents FuncionariosTableAdapter As Industries_DanDataSetTableAdapters.FuncionariosTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents DDCDateTimePicker As DateTimePicker
    Friend WithEvents Button5 As Button
    Friend WithEvents FuncionariosBindingSource1 As BindingSource
    Friend WithEvents FuncionariosDataGridView As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Button10 As Button
    Friend WithEvents ID_FuncionarioTextBox As TextBox
    Friend WithEvents DepartamentosDiretoresDeDepartamentosBindingSource As BindingSource
    Friend WithEvents TextBox1 As TextBox
End Class
