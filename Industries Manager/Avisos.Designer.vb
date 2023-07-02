<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Avisos
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
        Dim AvisoLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Avisos))
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.AvisosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AvisosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.AvisosTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.AvisoTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AvisosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DLDMDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DLDMAndFDFDPLabel = New System.Windows.Forms.Label()
        Me.DTLabel = New System.Windows.Forms.Label()
        Me.TituloTextBox = New System.Windows.Forms.TextBox()
        Me.FuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncionariosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FuncionariosTableAdapter()
        AvisoLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvisosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvisosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AvisoLabel
        '
        AvisoLabel.AutoSize = True
        AvisoLabel.Location = New System.Drawing.Point(16, 91)
        AvisoLabel.Name = "AvisoLabel"
        AvisoLabel.Size = New System.Drawing.Size(51, 20)
        AvisoLabel.TabIndex = 1
        AvisoLabel.Text = "Aviso:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(37, 24)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(813, 30)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(216, 20)
        Label2.TabIndex = 11
        Label2.Text = "Todos os avisos transmitidos:"
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
        'AvisoTextBox
        '
        Me.AvisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvisosBindingSource, "Aviso", True))
        Me.AvisoTextBox.Location = New System.Drawing.Point(73, 91)
        Me.AvisoTextBox.Multiline = True
        Me.AvisoTextBox.Name = "AvisoTextBox"
        Me.AvisoTextBox.ReadOnly = True
        Me.AvisoTextBox.Size = New System.Drawing.Size(629, 140)
        Me.AvisoTextBox.TabIndex = 2
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvisosBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(73, 21)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(114, 26)
        Me.IDTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Titulo:"
        '
        'AvisosDataGridView
        '
        Me.AvisosDataGridView.AllowUserToAddRows = False
        Me.AvisosDataGridView.AllowUserToDeleteRows = False
        Me.AvisosDataGridView.AllowUserToResizeColumns = False
        Me.AvisosDataGridView.AllowUserToResizeRows = False
        Me.AvisosDataGridView.AutoGenerateColumns = False
        Me.AvisosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.AvisosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvisosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AvisosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn2})
        Me.AvisosDataGridView.DataSource = Me.AvisosBindingSource
        Me.AvisosDataGridView.Location = New System.Drawing.Point(817, 53)
        Me.AvisosDataGridView.Name = "AvisosDataGridView"
        Me.AvisosDataGridView.ReadOnly = True
        Me.AvisosDataGridView.RowHeadersWidth = 62
        Me.AvisosDataGridView.RowTemplate.Height = 28
        Me.AvisosDataGridView.Size = New System.Drawing.Size(617, 461)
        Me.AvisosDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Data de envio do aviso"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 140
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DLDM"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Data limite do aviso"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 140
        '
        'DTDateTimePicker
        '
        Me.DTDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AvisosBindingSource, "DT", True))
        Me.DTDateTimePicker.Location = New System.Drawing.Point(73, 287)
        Me.DTDateTimePicker.Name = "DTDateTimePicker"
        Me.DTDateTimePicker.Size = New System.Drawing.Size(238, 26)
        Me.DTDateTimePicker.TabIndex = 8
        '
        'DLDMDateTimePicker
        '
        Me.DLDMDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AvisosBindingSource, "DLDM", True))
        Me.DLDMDateTimePicker.Location = New System.Drawing.Point(73, 348)
        Me.DLDMDateTimePicker.Name = "DLDMDateTimePicker"
        Me.DLDMDateTimePicker.Size = New System.Drawing.Size(238, 26)
        Me.DLDMDateTimePicker.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(641, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 32)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Terminar agora"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(482, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Receção do aviso:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(486, 286)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(149, 26)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.Text = "lido por [todos/alguns/ninguem]"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(486, 347)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(149, 26)
        Me.TextBox3.TabIndex = 16
        Me.TextBox3.Text = "[Transmitindo/Transmitido]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(482, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Estado do aviso:"
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button9.Location = New System.Drawing.Point(186, 408)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(107, 44)
        Me.Button9.TabIndex = 31
        Me.Button9.Text = "Novo"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(302, 408)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(107, 44)
        Me.Button8.TabIndex = 30
        Me.Button8.Text = "Editar"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button4.Location = New System.Drawing.Point(444, 458)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 62)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = ">|"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button3.Location = New System.Drawing.Point(358, 458)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 62)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button2.Location = New System.Drawing.Point(272, 458)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 62)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button5.Location = New System.Drawing.Point(186, 458)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 62)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "|<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button6.Location = New System.Drawing.Point(417, 408)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 44)
        Me.Button6.TabIndex = 32
        Me.Button6.Text = "Reenviar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(708, 93)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(86, 138)
        Me.Button7.TabIndex = 33
        Me.Button7.Text = "Copiar para a clipboard"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Enabled = False
        Me.Button10.Location = New System.Drawing.Point(641, 283)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(153, 32)
        Me.Button10.TabIndex = 34
        Me.Button10.Text = "Lista de quem lêu"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(313, 347)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(167, 26)
        Me.TextBox4.TabIndex = 38
        Me.TextBox4.Text = "[Transmitindo/Transmitido]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(309, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Faltam"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(313, 286)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(167, 26)
        Me.TextBox5.TabIndex = 36
        Me.TextBox5.Text = "lido por [todos/alguns/ninguem]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(309, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Transmitido há"
        '
        'DLDMAndFDFDPLabel
        '
        Me.DLDMAndFDFDPLabel.Location = New System.Drawing.Point(69, 324)
        Me.DLDMAndFDFDPLabel.Name = "DLDMAndFDFDPLabel"
        Me.DLDMAndFDFDPLabel.Size = New System.Drawing.Size(234, 20)
        Me.DLDMAndFDFDPLabel.TabIndex = 0
        Me.DLDMAndFDFDPLabel.Text = "Data final do aviso:"
        '
        'DTLabel
        '
        Me.DTLabel.AutoSize = True
        Me.DTLabel.Location = New System.Drawing.Point(69, 263)
        Me.DTLabel.Name = "DTLabel"
        Me.DTLabel.Size = New System.Drawing.Size(222, 20)
        Me.DTLabel.TabIndex = 39
        Me.DTLabel.Text = "Data de transmissão do aviso:"
        '
        'TituloTextBox
        '
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvisosBindingSource, "Titulo", True))
        Me.TituloTextBox.Location = New System.Drawing.Point(73, 56)
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.ReadOnly = True
        Me.TituloTextBox.Size = New System.Drawing.Size(629, 26)
        Me.TituloTextBox.TabIndex = 40
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
        'Avisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1454, 538)
        Me.Controls.Add(Me.TituloTextBox)
        Me.Controls.Add(Me.DTLabel)
        Me.Controls.Add(Me.DLDMAndFDFDPLabel)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.DLDMDateTimePicker)
        Me.Controls.Add(Me.DTDateTimePicker)
        Me.Controls.Add(Me.AvisosDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(AvisoLabel)
        Me.Controls.Add(Me.AvisoTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Avisos"
        Me.Text = "Avisos"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvisosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvisosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents AvisosBindingSource As BindingSource
    Friend WithEvents AvisosTableAdapter As Industries_DanDataSetTableAdapters.AvisosTableAdapter
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AvisoTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AvisosDataGridView As DataGridView
    Friend WithEvents DTDateTimePicker As DateTimePicker
    Friend WithEvents DLDMDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Button10 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DLDMAndFDFDPLabel As Label
    Friend WithEvents DTLabel As Label
    Friend WithEvents TituloTextBox As TextBox
    Friend WithEvents FuncionariosBindingSource As BindingSource
    Friend WithEvents FuncionariosTableAdapter As Industries_DanDataSetTableAdapters.FuncionariosTableAdapter
End Class
