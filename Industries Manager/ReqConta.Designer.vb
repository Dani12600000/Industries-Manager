<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReqConta
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim SobrenomeLabel As System.Windows.Forms.Label
        Dim FotoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PassLabel As System.Windows.Forms.Label
        Dim ID_ProfissãoLabel As System.Windows.Forms.Label
        Dim ID_DepartamentoLabel As System.Windows.Forms.Label
        Dim DDEDELabel As System.Windows.Forms.Label
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.FuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncionariosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FuncionariosTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.SobrenomeTextBox = New System.Windows.Forms.TextBox()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ProfissãoTextBox = New System.Windows.Forms.TextBox()
        Me.ID_DepartamentoTextBox = New System.Windows.Forms.TextBox()
        Me.DDEDEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        SobrenomeLabel = New System.Windows.Forms.Label()
        FotoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PassLabel = New System.Windows.Forms.Label()
        ID_ProfissãoLabel = New System.Windows.Forms.Label()
        ID_DepartamentoLabel = New System.Windows.Forms.Label()
        DDEDELabel = New System.Windows.Forms.Label()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(117, 63)
        NomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(55, 20)
        NomeLabel.TabIndex = 1
        NomeLabel.Text = "Nome:"
        '
        'SobrenomeLabel
        '
        SobrenomeLabel.AutoSize = True
        SobrenomeLabel.Location = New System.Drawing.Point(78, 103)
        SobrenomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SobrenomeLabel.Name = "SobrenomeLabel"
        SobrenomeLabel.Size = New System.Drawing.Size(96, 20)
        SobrenomeLabel.TabIndex = 2
        SobrenomeLabel.Text = "Sobrenome:"
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.Location = New System.Drawing.Point(132, 138)
        FotoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(46, 20)
        FotoLabel.TabIndex = 4
        FotoLabel.Text = "Foto:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(122, 391)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(52, 20)
        EmailLabel.TabIndex = 6
        EmailLabel.Text = "Email:"
        '
        'PassLabel
        '
        PassLabel.AutoSize = True
        PassLabel.Location = New System.Drawing.Point(124, 431)
        PassLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PassLabel.Name = "PassLabel"
        PassLabel.Size = New System.Drawing.Size(48, 20)
        PassLabel.TabIndex = 8
        PassLabel.Text = "Pass:"
        '
        'ID_ProfissãoLabel
        '
        ID_ProfissãoLabel.AutoSize = True
        ID_ProfissãoLabel.Location = New System.Drawing.Point(74, 471)
        ID_ProfissãoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ID_ProfissãoLabel.Name = "ID_ProfissãoLabel"
        ID_ProfissãoLabel.Size = New System.Drawing.Size(100, 20)
        ID_ProfissãoLabel.TabIndex = 10
        ID_ProfissãoLabel.Text = "ID Profissão:"
        '
        'ID_DepartamentoLabel
        '
        ID_DepartamentoLabel.AutoSize = True
        ID_DepartamentoLabel.Location = New System.Drawing.Point(38, 511)
        ID_DepartamentoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ID_DepartamentoLabel.Name = "ID_DepartamentoLabel"
        ID_DepartamentoLabel.Size = New System.Drawing.Size(137, 20)
        ID_DepartamentoLabel.TabIndex = 12
        ID_DepartamentoLabel.Text = "ID Departamento:"
        '
        'DDEDELabel
        '
        DDEDELabel.AutoSize = True
        DDEDELabel.Location = New System.Drawing.Point(102, 559)
        DDEDELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DDEDELabel.Name = "DDEDELabel"
        DDEDELabel.Size = New System.Drawing.Size(71, 20)
        DDEDELabel.TabIndex = 16
        DDEDELabel.Text = "DDEDE:"
        DDEDELabel.Visible = False
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
        Me.TableAdapterManager.Login_FuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.ProdutosTableAdapter = Nothing
        Me.TableAdapterManager.ProfissõesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_de_produtoTableAdapter = Nothing
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(183, 58)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(230, 26)
        Me.NomeTextBox.TabIndex = 2
        '
        'SobrenomeTextBox
        '
        Me.SobrenomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "Sobrenome", True))
        Me.SobrenomeTextBox.Location = New System.Drawing.Point(183, 98)
        Me.SobrenomeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SobrenomeTextBox.Name = "SobrenomeTextBox"
        Me.SobrenomeTextBox.Size = New System.Drawing.Size(230, 26)
        Me.SobrenomeTextBox.TabIndex = 3
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.FuncionariosBindingSource, "foto", True))
        Me.FotoPictureBox.Location = New System.Drawing.Point(183, 138)
        Me.FotoPictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(232, 238)
        Me.FotoPictureBox.TabIndex = 5
        Me.FotoPictureBox.TabStop = False
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(183, 386)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(230, 26)
        Me.EmailTextBox.TabIndex = 7
        '
        'PassTextBox
        '
        Me.PassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "Pass", True))
        Me.PassTextBox.Location = New System.Drawing.Point(183, 426)
        Me.PassTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PassTextBox.Size = New System.Drawing.Size(230, 26)
        Me.PassTextBox.TabIndex = 9
        '
        'ID_ProfissãoTextBox
        '
        Me.ID_ProfissãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "ID_Profissão", True))
        Me.ID_ProfissãoTextBox.Location = New System.Drawing.Point(183, 466)
        Me.ID_ProfissãoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ID_ProfissãoTextBox.Name = "ID_ProfissãoTextBox"
        Me.ID_ProfissãoTextBox.Size = New System.Drawing.Size(230, 26)
        Me.ID_ProfissãoTextBox.TabIndex = 11
        '
        'ID_DepartamentoTextBox
        '
        Me.ID_DepartamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "ID_Departamento", True))
        Me.ID_DepartamentoTextBox.Location = New System.Drawing.Point(183, 506)
        Me.ID_DepartamentoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ID_DepartamentoTextBox.Name = "ID_DepartamentoTextBox"
        Me.ID_DepartamentoTextBox.Size = New System.Drawing.Size(230, 26)
        Me.ID_DepartamentoTextBox.TabIndex = 13
        '
        'DDEDEDateTimePicker
        '
        Me.DDEDEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FuncionariosBindingSource, "DDEDE", True))
        Me.DDEDEDateTimePicker.Location = New System.Drawing.Point(183, 553)
        Me.DDEDEDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DDEDEDateTimePicker.Name = "DDEDEDateTimePicker"
        Me.DDEDEDateTimePicker.Size = New System.Drawing.Size(230, 26)
        Me.DDEDEDateTimePicker.TabIndex = 17
        Me.DDEDEDateTimePicker.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 138)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 238)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Selecionar Imagem"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(303, 559)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Criar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(144, 567)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(110, 20)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Já tem conta?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(414, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(414, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 386)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(414, 426)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(414, 469)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(414, 511)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(477, 566)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "(*) - Campos obrigatorios"
        '
        'ReqConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 593)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DDEDELabel)
        Me.Controls.Add(Me.DDEDEDateTimePicker)
        Me.Controls.Add(ID_DepartamentoLabel)
        Me.Controls.Add(Me.ID_DepartamentoTextBox)
        Me.Controls.Add(ID_ProfissãoLabel)
        Me.Controls.Add(Me.ID_ProfissãoTextBox)
        Me.Controls.Add(PassLabel)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(FotoLabel)
        Me.Controls.Add(Me.FotoPictureBox)
        Me.Controls.Add(SobrenomeLabel)
        Me.Controls.Add(Me.SobrenomeTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ReqConta"
        Me.Text = "Requesitar Conta"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents ID_ProfissãoTextBox As TextBox
    Friend WithEvents ID_DepartamentoTextBox As TextBox
    Friend WithEvents DDEDEDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
