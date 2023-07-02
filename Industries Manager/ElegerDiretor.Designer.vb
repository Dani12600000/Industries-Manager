<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ElegerDiretor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ElegerDiretor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Diretores_de_DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Diretores_de_DepartamentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.Diretores_de_DepartamentosTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncionariosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FuncionariosTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diretores_de_DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escolha o novo Diretor do departamento de [departamento]"
        '
        'Industries_DanDataSet
        '
        Me.Industries_DanDataSet.DataSetName = "Industries_DanDataSet"
        Me.Industries_DanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvisosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Funcionario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Designação:"
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
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox1.Location = New System.Drawing.Point(218, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 26)
        Me.TextBox1.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.FuncionariosBindingSource
        Me.ComboBox1.DisplayMember = "Nome"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(218, 80)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(327, 28)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.ValueMember = "ID"
        '
        'FuncionariosBindingSource
        '
        Me.FuncionariosBindingSource.DataMember = "Funcionarios"
        Me.FuncionariosBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'FuncionariosTableAdapter
        '
        Me.FuncionariosTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(137, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Funções:"
        '
        'TextBox2
        '
        Me.TextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox2.Location = New System.Drawing.Point(218, 119)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(327, 110)
        Me.TextBox2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Data de termino:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(218, 280)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(147, 26)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(443, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 44)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(12, 245)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(229, 24)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Pretende terminar contrato:"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ElegerDiretor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 394)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ElegerDiretor"
        Me.Text = "Eleger Novo Diretor"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diretores_de_DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Diretores_de_DepartamentosBindingSource As BindingSource
    Friend WithEvents Diretores_de_DepartamentosTableAdapter As Industries_DanDataSetTableAdapters.Diretores_de_DepartamentosTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents FuncionariosBindingSource As BindingSource
    Friend WithEvents FuncionariosTableAdapter As Industries_DanDataSetTableAdapters.FuncionariosTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
