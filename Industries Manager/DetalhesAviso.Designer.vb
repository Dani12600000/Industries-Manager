<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetalhesAviso
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
        Dim TituloLabel As System.Windows.Forms.Label
        Dim AvisoLabel As System.Windows.Forms.Label
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.AvisosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AvisosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.AvisosTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.TituloTextBox = New System.Windows.Forms.TextBox()
        Me.AvisoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FuncionariosDiretoresComboBox = New System.Windows.Forms.ComboBox()
        Me.FuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataRadioButton = New System.Windows.Forms.RadioButton()
        Me.TodosLeramRadioButton = New System.Windows.Forms.RadioButton()
        Me.NuncaRadioButton = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Diretores_de_DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Diretores_de_DepartamentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.Diretores_de_DepartamentosTableAdapter()
        Me.FuncionariosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FuncionariosTableAdapter()
        TituloLabel = New System.Windows.Forms.Label()
        AvisoLabel = New System.Windows.Forms.Label()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvisosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Diretores_de_DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloLabel
        '
        TituloLabel.AutoSize = True
        TituloLabel.Location = New System.Drawing.Point(24, 30)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(51, 20)
        TituloLabel.TabIndex = 1
        TituloLabel.Text = "Titulo:"
        '
        'AvisoLabel
        '
        AvisoLabel.AutoSize = True
        AvisoLabel.Location = New System.Drawing.Point(24, 65)
        AvisoLabel.Name = "AvisoLabel"
        AvisoLabel.Size = New System.Drawing.Size(51, 20)
        AvisoLabel.TabIndex = 3
        AvisoLabel.Text = "Aviso:"
        '
        'Industries_DanDataSet
        '
        Me.Industries_DanDataSet.DataSetName = "Industries_DanDataSet"
        Me.Industries_DanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AvisosBindingSource
        '
        Me.AvisosBindingSource.DataMember = "Avisos"
        Me.AvisosBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'AvisosTableAdapter
        '
        Me.AvisosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvisosTableAdapter = Me.AvisosTableAdapter
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
        Me.TableAdapterManager.Venda_de_produtoTableAdapter = Nothing
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'TituloTextBox
        '
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvisosBindingSource, "Titulo", True))
        Me.TituloTextBox.Location = New System.Drawing.Point(81, 27)
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(512, 26)
        Me.TituloTextBox.TabIndex = 2
        '
        'AvisoTextBox
        '
        Me.AvisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvisosBindingSource, "Aviso", True))
        Me.AvisoTextBox.Location = New System.Drawing.Point(81, 62)
        Me.AvisoTextBox.Multiline = True
        Me.AvisoTextBox.Name = "AvisoTextBox"
        Me.AvisoTextBox.Size = New System.Drawing.Size(512, 126)
        Me.AvisoTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enviar para: "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(127, 210)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(288, 28)
        Me.ComboBox1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(467, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 38)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Funcionario/Diretor:"
        '
        'FuncionariosDiretoresComboBox
        '
        Me.FuncionariosDiretoresComboBox.DataSource = Me.FuncionariosBindingSource
        Me.FuncionariosDiretoresComboBox.DisplayMember = "Nome"
        Me.FuncionariosDiretoresComboBox.FormattingEnabled = True
        Me.FuncionariosDiretoresComboBox.Location = New System.Drawing.Point(127, 254)
        Me.FuncionariosDiretoresComboBox.Name = "FuncionariosDiretoresComboBox"
        Me.FuncionariosDiretoresComboBox.Size = New System.Drawing.Size(288, 28)
        Me.FuncionariosDiretoresComboBox.TabIndex = 9
        Me.FuncionariosDiretoresComboBox.ValueMember = "ID_Funcionario"
        '
        'FuncionariosBindingSource
        '
        Me.FuncionariosBindingSource.DataMember = "Funcionarios"
        Me.FuncionariosBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'DataRadioButton
        '
        Me.DataRadioButton.AutoSize = True
        Me.DataRadioButton.Location = New System.Drawing.Point(17, 34)
        Me.DataRadioButton.Name = "DataRadioButton"
        Me.DataRadioButton.Size = New System.Drawing.Size(71, 24)
        Me.DataRadioButton.TabIndex = 2
        Me.DataRadioButton.TabStop = True
        Me.DataRadioButton.Text = "Dia - "
        Me.DataRadioButton.UseVisualStyleBackColor = True
        '
        'TodosLeramRadioButton
        '
        Me.TodosLeramRadioButton.AutoSize = True
        Me.TodosLeramRadioButton.Location = New System.Drawing.Point(17, 69)
        Me.TodosLeramRadioButton.Name = "TodosLeramRadioButton"
        Me.TodosLeramRadioButton.Size = New System.Drawing.Size(121, 24)
        Me.TodosLeramRadioButton.TabIndex = 3
        Me.TodosLeramRadioButton.TabStop = True
        Me.TodosLeramRadioButton.Text = "Todos leram"
        Me.TodosLeramRadioButton.UseVisualStyleBackColor = True
        '
        'NuncaRadioButton
        '
        Me.NuncaRadioButton.AutoSize = True
        Me.NuncaRadioButton.Location = New System.Drawing.Point(17, 105)
        Me.NuncaRadioButton.Name = "NuncaRadioButton"
        Me.NuncaRadioButton.Size = New System.Drawing.Size(80, 24)
        Me.NuncaRadioButton.TabIndex = 4
        Me.NuncaRadioButton.TabStop = True
        Me.NuncaRadioButton.Text = "Nunca"
        Me.NuncaRadioButton.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(83, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 26)
        Me.DateTimePicker1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.NuncaRadioButton)
        Me.GroupBox1.Controls.Add(Me.TodosLeramRadioButton)
        Me.GroupBox1.Controls.Add(Me.DataRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 299)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 143)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma de fim de prazo"
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
        'FuncionariosTableAdapter
        '
        Me.FuncionariosTableAdapter.ClearBeforeFill = True
        '
        'DetalhesAviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(626, 510)
        Me.Controls.Add(Me.FuncionariosDiretoresComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(AvisoLabel)
        Me.Controls.Add(Me.AvisoTextBox)
        Me.Controls.Add(TituloLabel)
        Me.Controls.Add(Me.TituloTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(648, 566)
        Me.MinimumSize = New System.Drawing.Size(648, 401)
        Me.Name = "DetalhesAviso"
        Me.Text = "Novo Aviso"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvisosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Diretores_de_DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents AvisosBindingSource As BindingSource
    Friend WithEvents AvisosTableAdapter As Industries_DanDataSetTableAdapters.AvisosTableAdapter
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TituloTextBox As TextBox
    Friend WithEvents AvisoTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FuncionariosDiretoresComboBox As ComboBox
    Friend WithEvents DataRadioButton As RadioButton
    Friend WithEvents TodosLeramRadioButton As RadioButton
    Friend WithEvents NuncaRadioButton As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Diretores_de_DepartamentosBindingSource As BindingSource
    Friend WithEvents Diretores_de_DepartamentosTableAdapter As Industries_DanDataSetTableAdapters.Diretores_de_DepartamentosTableAdapter
    Friend WithEvents FuncionariosBindingSource As BindingSource
    Friend WithEvents FuncionariosTableAdapter As Industries_DanDataSetTableAdapters.FuncionariosTableAdapter
End Class
