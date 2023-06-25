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
        Dim Label5 As System.Windows.Forms.Label
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.NDDTextBox = New System.Windows.Forms.TextBox()
        Me.DEDDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DepartamentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.DepartamentosTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.FuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncionariosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FuncionariosTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.NomeDiretorTextBox = New System.Windows.Forms.TextBox()
        Me.Diretores_de_DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Diretores_de_DepartamentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.Diretores_de_DepartamentosTableAdapter()
        Me.FuncionariosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DDCDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FuncionariosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncionariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProfissõesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfissõesTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.ProfissõesTableAdapter()
        Me.DDDTextBox = New System.Windows.Forms.TextBox()
        Me.ADDTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        NDDLabel = New System.Windows.Forms.Label()
        DEDDLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diretores_de_DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfissõesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(217, 49)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NDDLabel
        '
        NDDLabel.AutoSize = True
        NDDLabel.Location = New System.Drawing.Point(27, 117)
        NDDLabel.Name = "NDDLabel"
        NDDLabel.Size = New System.Drawing.Size(187, 20)
        NDDLabel.TabIndex = 2
        NDDLabel.Text = "Nome Do Departamento:"
        '
        'DEDDLabel
        '
        DEDDLabel.AutoSize = True
        DEDDLabel.Location = New System.Drawing.Point(27, 178)
        DEDDLabel.Name = "DEDDLabel"
        DEDDLabel.Size = New System.Drawing.Size(288, 20)
        DEDDLabel.TabIndex = 4
        DEDDLabel.Text = "Descrição Extensiva Do Departamento:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(489, 46)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(119, 20)
        Label1.TabIndex = 11
        Label1.Text = "Diretor(a) atual:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(489, 137)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(236, 20)
        Label5.TabIndex = 30
        Label5.Text = "Funcionarios Do Departamento:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentosBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(253, 46)
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
        Me.NDDTextBox.Location = New System.Drawing.Point(31, 140)
        Me.NDDTextBox.Name = "NDDTextBox"
        Me.NDDTextBox.ReadOnly = True
        Me.NDDTextBox.Size = New System.Drawing.Size(416, 26)
        Me.NDDTextBox.TabIndex = 3
        '
        'DEDDTextBox
        '
        Me.DEDDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentosBindingSource, "DEDD", True))
        Me.DEDDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DEDDTextBox.Location = New System.Drawing.Point(31, 201)
        Me.DEDDTextBox.Multiline = True
        Me.DEDDTextBox.Name = "DEDDTextBox"
        Me.DEDDTextBox.ReadOnly = True
        Me.DEDDTextBox.Size = New System.Drawing.Size(416, 146)
        Me.DEDDTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(72, 411)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 69)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "|<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(158, 411)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 69)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(244, 411)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 69)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(330, 411)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 69)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = ">|"
        Me.Button4.UseVisualStyleBackColor = True
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
        'FuncionariosTableAdapter
        '
        Me.FuncionariosTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(946, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "No cargo desde"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.RosyBrown
        Me.Button5.Location = New System.Drawing.Point(1265, 448)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(242, 32)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Despedir funcionario"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1350, 63)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(157, 32)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Historico"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(614, 40)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(146, 33)
        Me.Button7.TabIndex = 17
        Me.Button7.Text = "Eleger diretor / Despedir diretor"
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.IndianRed
        Me.Button8.Location = New System.Drawing.Point(244, 358)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(166, 47)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "Remover"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(72, 358)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(166, 47)
        Me.Button9.TabIndex = 19
        Me.Button9.Text = "Novo"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'NomeDiretorTextBox
        '
        Me.NomeDiretorTextBox.Location = New System.Drawing.Point(614, 69)
        Me.NomeDiretorTextBox.Name = "NomeDiretorTextBox"
        Me.NomeDiretorTextBox.ReadOnly = True
        Me.NomeDiretorTextBox.Size = New System.Drawing.Size(321, 26)
        Me.NomeDiretorTextBox.TabIndex = 22
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
        'FuncionariosBindingSource1
        '
        Me.FuncionariosBindingSource1.DataMember = "Funcionarios"
        Me.FuncionariosBindingSource1.DataSource = Me.Industries_DanDataSet
        '
        'DDCDateTimePicker
        '
        Me.DDCDateTimePicker.Enabled = False
        Me.DDCDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DDCDateTimePicker.Location = New System.Drawing.Point(950, 69)
        Me.DDCDateTimePicker.Name = "DDCDateTimePicker"
        Me.DDCDateTimePicker.Size = New System.Drawing.Size(153, 26)
        Me.DDCDateTimePicker.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1114, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "No cargo já há"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1118, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(215, 26)
        Me.TextBox1.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Abreviatura Do Departamento:"
        '
        'FuncionariosBindingSource2
        '
        Me.FuncionariosBindingSource2.DataMember = "DepartamentosFuncionarios"
        Me.FuncionariosBindingSource2.DataSource = Me.DepartamentosBindingSource
        '
        'FuncionariosDataGridView
        '
        Me.FuncionariosDataGridView.AllowUserToAddRows = False
        Me.FuncionariosDataGridView.AllowUserToDeleteRows = False
        Me.FuncionariosDataGridView.AllowUserToResizeRows = False
        Me.FuncionariosDataGridView.AutoGenerateColumns = False
        Me.FuncionariosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.FuncionariosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FuncionariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FuncionariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column1, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.FuncionariosDataGridView.DataSource = Me.FuncionariosBindingSource2
        Me.FuncionariosDataGridView.Location = New System.Drawing.Point(493, 160)
        Me.FuncionariosDataGridView.Name = "FuncionariosDataGridView"
        Me.FuncionariosDataGridView.RowHeadersWidth = 62
        Me.FuncionariosDataGridView.RowTemplate.Height = 28
        Me.FuncionariosDataGridView.Size = New System.Drawing.Size(1014, 282)
        Me.FuncionariosDataGridView.TabIndex = 27
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 45
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Sobrenome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sobrenome"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 180
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID_Profissão"
        Me.Column1.DataSource = Me.ProfissõesBindingSource
        Me.Column1.DisplayMember = "Profissao"
        Me.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column1.HeaderText = "Profissão"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.ValueMember = "ID"
        Me.Column1.Width = 105
        '
        'ProfissõesBindingSource
        '
        Me.ProfissõesBindingSource.DataMember = "Profissões"
        Me.ProfissõesBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SI"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Salário"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 95
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DDEDE"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Contratação"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 90
        '
        'ProfissõesTableAdapter
        '
        Me.ProfissõesTableAdapter.ClearBeforeFill = True
        '
        'DDDTextBox
        '
        Me.DDDTextBox.Location = New System.Drawing.Point(493, 69)
        Me.DDDTextBox.Name = "DDDTextBox"
        Me.DDDTextBox.ReadOnly = True
        Me.DDDTextBox.Size = New System.Drawing.Size(115, 26)
        Me.DDDTextBox.TabIndex = 28
        Me.DDDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ADDTextBox
        '
        Me.ADDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentosBindingSource, "ADD", True))
        Me.ADDTextBox.Location = New System.Drawing.Point(253, 78)
        Me.ADDTextBox.Name = "ADDTextBox"
        Me.ADDTextBox.ReadOnly = True
        Me.ADDTextBox.Size = New System.Drawing.Size(194, 26)
        Me.ADDTextBox.TabIndex = 29
        '
        'Departamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1555, 500)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.ADDTextBox)
        Me.Controls.Add(Me.DDDTextBox)
        Me.Controls.Add(Me.FuncionariosDataGridView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DDCDateTimePicker)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
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
        Me.Controls.Add(Me.NomeDiretorTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Departamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departamentos"
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diretores_de_DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfissõesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents FuncionariosBindingSource As BindingSource
    Friend WithEvents FuncionariosTableAdapter As Industries_DanDataSetTableAdapters.FuncionariosTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents NomeDiretorTextBox As TextBox
    Friend WithEvents Diretores_de_DepartamentosBindingSource As BindingSource
    Friend WithEvents Diretores_de_DepartamentosTableAdapter As Industries_DanDataSetTableAdapters.Diretores_de_DepartamentosTableAdapter
    Friend WithEvents FuncionariosBindingSource1 As BindingSource
    Friend WithEvents DDCDateTimePicker As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FuncionariosBindingSource2 As BindingSource
    Friend WithEvents FuncionariosDataGridView As DataGridView
    Friend WithEvents ProfissõesBindingSource As BindingSource
    Friend WithEvents ProfissõesTableAdapter As Industries_DanDataSetTableAdapters.ProfissõesTableAdapter
    Friend WithEvents DDDTextBox As TextBox
    Friend WithEvents ADDTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
