﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Funcionarios
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim SobrenomeLabel As System.Windows.Forms.Label
        Dim FotoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ID_ProfissãoLabel As System.Windows.Forms.Label
        Dim ID_DepartamentoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Funcionarios))
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.FuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncionariosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FuncionariosTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.Login_FuncionarioTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.Login_FuncionarioTableAdapter()
        Me.ProfissõesTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.ProfissõesTableAdapter()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.SobrenomeTextBox = New System.Windows.Forms.TextBox()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ProfissõesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DDEDEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Login_FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Login_FuncionarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DDSDEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DDEDELabel = New System.Windows.Forms.Label()
        Me.DDSDELabel = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ID_ProfissãoComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.DepartamentosTableAdapter()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Diretores_de_DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Diretores_de_DepartamentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.Diretores_de_DepartamentosTableAdapter()
        Me.ID_DepartamentoComboBox = New System.Windows.Forms.ComboBox()
        Me.SITextBox = New System.Windows.Forms.TextBox()
        Me.SINumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.SILabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        SobrenomeLabel = New System.Windows.Forms.Label()
        FotoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        ID_ProfissãoLabel = New System.Windows.Forms.Label()
        ID_DepartamentoLabel = New System.Windows.Forms.Label()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfissõesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Login_FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Login_FuncionarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diretores_de_DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SINumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(12, 28)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(55, 20)
        NomeLabel.TabIndex = 1
        NomeLabel.Text = "Nome:"
        '
        'SobrenomeLabel
        '
        SobrenomeLabel.AutoSize = True
        SobrenomeLabel.Location = New System.Drawing.Point(171, 28)
        SobrenomeLabel.Name = "SobrenomeLabel"
        SobrenomeLabel.Size = New System.Drawing.Size(96, 20)
        SobrenomeLabel.TabIndex = 2
        SobrenomeLabel.Text = "Sobrenome:"
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.Location = New System.Drawing.Point(12, 90)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(46, 20)
        FotoLabel.TabIndex = 4
        FotoLabel.Text = "Foto:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(12, 306)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(52, 20)
        EmailLabel.TabIndex = 6
        EmailLabel.Text = "Email:"
        '
        'ID_ProfissãoLabel
        '
        ID_ProfissãoLabel.AutoSize = True
        ID_ProfissãoLabel.Location = New System.Drawing.Point(12, 348)
        ID_ProfissãoLabel.Name = "ID_ProfissãoLabel"
        ID_ProfissãoLabel.Size = New System.Drawing.Size(79, 20)
        ID_ProfissãoLabel.TabIndex = 8
        ID_ProfissãoLabel.Text = "Profissão:"
        '
        'ID_DepartamentoLabel
        '
        ID_DepartamentoLabel.AutoSize = True
        ID_DepartamentoLabel.Location = New System.Drawing.Point(12, 387)
        ID_DepartamentoLabel.Name = "ID_DepartamentoLabel"
        ID_DepartamentoLabel.Size = New System.Drawing.Size(116, 20)
        ID_DepartamentoLabel.TabIndex = 34
        ID_DepartamentoLabel.Text = "Departamento:"
        '
        'Industries_DanDataSet
        '
        Me.Industries_DanDataSet.DataSetName = "Industries_DanDataSet"
        Me.Industries_DanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.Login_FuncionarioTableAdapter = Me.Login_FuncionarioTableAdapter
        Me.TableAdapterManager.ProdutosTableAdapter = Nothing
        Me.TableAdapterManager.ProfissõesTableAdapter = Me.ProfissõesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_de_produtoTableAdapter = Nothing
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'Login_FuncionarioTableAdapter
        '
        Me.Login_FuncionarioTableAdapter.ClearBeforeFill = True
        '
        'ProfissõesTableAdapter
        '
        Me.ProfissõesTableAdapter.ClearBeforeFill = True
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(16, 51)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.ReadOnly = True
        Me.NomeTextBox.Size = New System.Drawing.Size(153, 26)
        Me.NomeTextBox.TabIndex = 2
        '
        'SobrenomeTextBox
        '
        Me.SobrenomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "Sobrenome", True))
        Me.SobrenomeTextBox.Location = New System.Drawing.Point(175, 51)
        Me.SobrenomeTextBox.Name = "SobrenomeTextBox"
        Me.SobrenomeTextBox.ReadOnly = True
        Me.SobrenomeTextBox.Size = New System.Drawing.Size(250, 26)
        Me.SobrenomeTextBox.TabIndex = 3
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.FuncionariosBindingSource, "foto", True))
        Me.FotoPictureBox.Location = New System.Drawing.Point(64, 90)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(359, 187)
        Me.FotoPictureBox.TabIndex = 5
        Me.FotoPictureBox.TabStop = False
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(70, 303)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(353, 26)
        Me.EmailTextBox.TabIndex = 7
        '
        'ProfissõesBindingSource
        '
        Me.ProfissõesBindingSource.DataMember = "Profissões"
        Me.ProfissõesBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'DDEDEDateTimePicker
        '
        Me.DDEDEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FuncionariosBindingSource, "DDEDE", True))
        Me.DDEDEDateTimePicker.Enabled = False
        Me.DDEDEDateTimePicker.Location = New System.Drawing.Point(125, 478)
        Me.DDEDEDateTimePicker.Name = "DDEDEDateTimePicker"
        Me.DDEDEDateTimePicker.Size = New System.Drawing.Size(300, 26)
        Me.DDEDEDateTimePicker.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 434)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "€"
        '
        'Login_FuncionarioBindingSource
        '
        Me.Login_FuncionarioBindingSource.DataMember = "FuncionariosLogin_Funcionario"
        Me.Login_FuncionarioBindingSource.DataSource = Me.FuncionariosBindingSource
        '
        'Login_FuncionarioDataGridView
        '
        Me.Login_FuncionarioDataGridView.AllowUserToAddRows = False
        Me.Login_FuncionarioDataGridView.AllowUserToDeleteRows = False
        Me.Login_FuncionarioDataGridView.AllowUserToResizeColumns = False
        Me.Login_FuncionarioDataGridView.AllowUserToResizeRows = False
        Me.Login_FuncionarioDataGridView.AutoGenerateColumns = False
        Me.Login_FuncionarioDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.Login_FuncionarioDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Login_FuncionarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Login_FuncionarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Login_FuncionarioDataGridView.DataSource = Me.Login_FuncionarioBindingSource
        Me.Login_FuncionarioDataGridView.Location = New System.Drawing.Point(460, 51)
        Me.Login_FuncionarioDataGridView.Name = "Login_FuncionarioDataGridView"
        Me.Login_FuncionarioDataGridView.ReadOnly = True
        Me.Login_FuncionarioDataGridView.RowHeadersWidth = 62
        Me.Login_FuncionarioDataGridView.RowTemplate.Height = 28
        Me.Login_FuncionarioDataGridView.Size = New System.Drawing.Size(763, 592)
        Me.Login_FuncionarioDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn1.Width = 45
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DEH"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Data e hora"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IP"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IP"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn4.Width = 135
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "LiouLo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tipo de registo"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightGreen
        Me.Button5.Location = New System.Drawing.Point(97, 597)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 47)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Contratar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(292, 649)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(59, 57)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = ">|"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(227, 649)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 57)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(162, 649)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 57)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(97, 649)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 57)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "|<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DDSDEDateTimePicker
        '
        Me.DDSDEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FuncionariosBindingSource, "DDSDE", True))
        Me.DDSDEDateTimePicker.Enabled = False
        Me.DDSDEDateTimePicker.Location = New System.Drawing.Point(125, 510)
        Me.DDSDEDateTimePicker.Name = "DDSDEDateTimePicker"
        Me.DDSDEDateTimePicker.Size = New System.Drawing.Size(300, 26)
        Me.DDSDEDateTimePicker.TabIndex = 26
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.IndianRed
        Me.Button6.Location = New System.Drawing.Point(227, 597)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(124, 47)
        Me.Button6.TabIndex = 27
        Me.Button6.Text = "Resetar pass"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(320, 302)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(105, 34)
        Me.Button7.TabIndex = 28
        Me.Button7.Text = "Enviar mail"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(456, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Acessos ao sistema"
        '
        'DDEDELabel
        '
        Me.DDEDELabel.AutoSize = True
        Me.DDEDELabel.Location = New System.Drawing.Point(12, 483)
        Me.DDEDELabel.Name = "DDEDELabel"
        Me.DDEDELabel.Size = New System.Drawing.Size(107, 20)
        Me.DDEDELabel.TabIndex = 30
        Me.DDEDELabel.Text = "Data entrada:"
        '
        'DDSDELabel
        '
        Me.DDSDELabel.AutoSize = True
        Me.DDSDELabel.Location = New System.Drawing.Point(26, 515)
        Me.DDSDELabel.Name = "DDSDELabel"
        Me.DDSDELabel.Size = New System.Drawing.Size(90, 20)
        Me.DDSDELabel.TabIndex = 31
        Me.DDSDELabel.Text = "Data saída:"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(337, 423)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(89, 36)
        Me.Button8.TabIndex = 32
        Me.Button8.Text = "Editar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(598, 649)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(245, 57)
        Me.Button9.TabIndex = 33
        Me.Button9.Text = "Acessos hoje"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(849, 649)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(288, 57)
        Me.Button10.TabIndex = 34
        Me.Button10.Text = "Acessos numa data especifica"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'ID_ProfissãoComboBox
        '
        Me.ID_ProfissãoComboBox.DataSource = Me.ProfissõesBindingSource
        Me.ID_ProfissãoComboBox.DisplayMember = "Profissao"
        Me.ID_ProfissãoComboBox.Enabled = False
        Me.ID_ProfissãoComboBox.FormattingEnabled = True
        Me.ID_ProfissãoComboBox.Location = New System.Drawing.Point(97, 345)
        Me.ID_ProfissãoComboBox.Name = "ID_ProfissãoComboBox"
        Me.ID_ProfissãoComboBox.Size = New System.Drawing.Size(326, 28)
        Me.ID_ProfissãoComboBox.TabIndex = 36
        Me.ID_ProfissãoComboBox.ValueMember = "ID"
        '
        'DepartamentosBindingSource
        '
        Me.DepartamentosBindingSource.DataMember = "Departamentos"
        Me.DepartamentosBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'DepartamentosTableAdapter
        '
        Me.DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Firebrick
        Me.Button11.Location = New System.Drawing.Point(97, 552)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(254, 41)
        Me.Button11.TabIndex = 38
        Me.Button11.Text = "Apagar conta"
        Me.Button11.UseVisualStyleBackColor = False
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
        'ID_DepartamentoComboBox
        '
        Me.ID_DepartamentoComboBox.DataSource = Me.DepartamentosBindingSource
        Me.ID_DepartamentoComboBox.DisplayMember = "ADD"
        Me.ID_DepartamentoComboBox.FormattingEnabled = True
        Me.ID_DepartamentoComboBox.Location = New System.Drawing.Point(134, 384)
        Me.ID_DepartamentoComboBox.Name = "ID_DepartamentoComboBox"
        Me.ID_DepartamentoComboBox.Size = New System.Drawing.Size(291, 28)
        Me.ID_DepartamentoComboBox.TabIndex = 39
        Me.ID_DepartamentoComboBox.ValueMember = "ID"
        '
        'SITextBox
        '
        Me.SITextBox.Location = New System.Drawing.Point(160, 429)
        Me.SITextBox.Name = "SITextBox"
        Me.SITextBox.Size = New System.Drawing.Size(167, 26)
        Me.SITextBox.TabIndex = 41
        Me.SITextBox.Visible = False
        '
        'SINumericUpDown
        '
        Me.SINumericUpDown.DecimalPlaces = 2
        Me.SINumericUpDown.Location = New System.Drawing.Point(160, 428)
        Me.SINumericUpDown.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.SINumericUpDown.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SINumericUpDown.Name = "SINumericUpDown"
        Me.SINumericUpDown.Size = New System.Drawing.Size(151, 26)
        Me.SINumericUpDown.TabIndex = 42
        Me.SINumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SINumericUpDown.ThousandsSeparator = True
        Me.SINumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(337, 344)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(88, 32)
        Me.Button12.TabIndex = 43
        Me.Button12.Text = "Editar"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'SILabel
        '
        Me.SILabel.AutoSize = True
        Me.SILabel.Location = New System.Drawing.Point(12, 431)
        Me.SILabel.Name = "SILabel"
        Me.SILabel.Size = New System.Drawing.Size(103, 20)
        Me.SILabel.TabIndex = 44
        Me.SILabel.Text = "Salário Atual:"
        '
        'Funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 726)
        Me.Controls.Add(Me.SILabel)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.SINumericUpDown)
        Me.Controls.Add(Me.ID_DepartamentoComboBox)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.ID_ProfissãoComboBox)
        Me.Controls.Add(ID_DepartamentoLabel)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.DDSDELabel)
        Me.Controls.Add(Me.DDEDELabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.DDSDEDateTimePicker)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Login_FuncionarioDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DDEDEDateTimePicker)
        Me.Controls.Add(ID_ProfissãoLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(FotoLabel)
        Me.Controls.Add(Me.FotoPictureBox)
        Me.Controls.Add(SobrenomeLabel)
        Me.Controls.Add(Me.SobrenomeTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Me.SITextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionarios"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfissõesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Login_FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Login_FuncionarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diretores_de_DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SINumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents FuncionariosBindingSource As BindingSource
    Friend WithEvents FuncionariosTableAdapter As Industries_DanDataSetTableAdapters.FuncionariosTableAdapter
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents SobrenomeTextBox As TextBox
    Friend WithEvents FotoPictureBox As PictureBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents DDEDEDateTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Login_FuncionarioTableAdapter As Industries_DanDataSetTableAdapters.Login_FuncionarioTableAdapter
    Friend WithEvents Login_FuncionarioBindingSource As BindingSource
    Friend WithEvents Login_FuncionarioDataGridView As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DDSDEDateTimePicker As DateTimePicker
    Friend WithEvents Button6 As Button
    Friend WithEvents ProfissõesTableAdapter As Industries_DanDataSetTableAdapters.ProfissõesTableAdapter
    Friend WithEvents ProfissõesBindingSource As BindingSource
    Friend WithEvents Button7 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DDEDELabel As Label
    Friend WithEvents DDSDELabel As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ID_ProfissãoComboBox As ComboBox
    Friend WithEvents DepartamentosBindingSource As BindingSource
    Friend WithEvents DepartamentosTableAdapter As Industries_DanDataSetTableAdapters.DepartamentosTableAdapter
    Friend WithEvents Button11 As Button
    Friend WithEvents Diretores_de_DepartamentosBindingSource As BindingSource
    Friend WithEvents Diretores_de_DepartamentosTableAdapter As Industries_DanDataSetTableAdapters.Diretores_de_DepartamentosTableAdapter
    Friend WithEvents ID_DepartamentoComboBox As ComboBox
    Friend WithEvents SITextBox As TextBox
    Friend WithEvents SINumericUpDown As NumericUpDown
    Friend WithEvents Button12 As Button
    Friend WithEvents SILabel As Label
End Class
