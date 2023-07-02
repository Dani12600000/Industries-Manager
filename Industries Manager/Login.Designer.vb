<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PassLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.FuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncionariosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FuncionariosTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Login_FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Login_FuncionarioTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.Login_FuncionarioTableAdapter()
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.DepartamentosTableAdapter()
        Me.Diretores_de_DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Diretores_de_DepartamentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.Diretores_de_DepartamentosTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        EmailLabel = New System.Windows.Forms.Label()
        PassLabel = New System.Windows.Forms.Label()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Login_FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diretores_de_DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        EmailLabel.Location = New System.Drawing.Point(71, 63)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(60, 22)
        EmailLabel.TabIndex = 1
        EmailLabel.Text = "E-mail"
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(75, 253)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(422, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LinkLabel1.Location = New System.Drawing.Point(279, 384)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(218, 22)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Requesite uma conta aqui"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TextBox1.Location = New System.Drawing.Point(75, 90)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(422, 28)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TextBox2.Location = New System.Drawing.Point(75, 155)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TextBox2.Size = New System.Drawing.Size(388, 28)
        Me.TextBox2.TabIndex = 7
        '
        'Login_FuncionarioBindingSource
        '
        Me.Login_FuncionarioBindingSource.DataMember = "Login_Funcionario"
        Me.Login_FuncionarioBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'Login_FuncionarioTableAdapter
        '
        Me.Login_FuncionarioTableAdapter.ClearBeforeFill = True
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
        'Diretores_de_DepartamentosBindingSource
        '
        Me.Diretores_de_DepartamentosBindingSource.DataMember = "Diretores de Departamentos"
        Me.Diretores_de_DepartamentosBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'Diretores_de_DepartamentosTableAdapter
        '
        Me.Diretores_de_DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.BackgroundImage = Global.Industries_Manager.My.Resources.Resources.show_password_eye
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(465, 155)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 31)
        Me.Button3.TabIndex = 9
        Me.Button3.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(75, 191)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(136, 24)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Memorizar-me"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 386)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ainda não tem uma conta?"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LinkLabel2.Location = New System.Drawing.Point(138, 296)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(300, 22)
        Me.LinkLabel2.TabIndex = 12
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Esqueci-me da minha palavra-passe"
        Me.LinkLabel2.Visible = False
        '
        'PassLabel
        '
        PassLabel.AutoSize = True
        PassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        PassLabel.Location = New System.Drawing.Point(71, 128)
        PassLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PassLabel.Name = "PassLabel"
        PassLabel.Size = New System.Drawing.Size(127, 22)
        PassLabel.TabIndex = 13
        PassLabel.Text = "Palavra-Passe"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 465)
        Me.Controls.Add(PassLabel)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(EmailLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Login_FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diretores_de_DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents FuncionariosBindingSource As BindingSource
    Friend WithEvents FuncionariosTableAdapter As Industries_DanDataSetTableAdapters.FuncionariosTableAdapter
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Login_FuncionarioBindingSource As BindingSource
    Friend WithEvents Login_FuncionarioTableAdapter As Industries_DanDataSetTableAdapters.Login_FuncionarioTableAdapter
    Friend WithEvents DepartamentosBindingSource As BindingSource
    Friend WithEvents DepartamentosTableAdapter As Industries_DanDataSetTableAdapters.DepartamentosTableAdapter
    Friend WithEvents Diretores_de_DepartamentosBindingSource As BindingSource
    Friend WithEvents Diretores_de_DepartamentosTableAdapter As Industries_DanDataSetTableAdapters.Diretores_de_DepartamentosTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
