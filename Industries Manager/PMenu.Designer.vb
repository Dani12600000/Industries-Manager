<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.Login_FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Login_FuncionarioTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.Login_FuncionarioTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Login_FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "[Bom dia/Boa tarde], [Nome]"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 86)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(572, 60)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Clientes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 155)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(572, 60)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Departamentos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.AvisosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(636, 35)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(81, 29)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'AvisosToolStripMenuItem
        '
        Me.AvisosToolStripMenuItem.Name = "AvisosToolStripMenuItem"
        Me.AvisosToolStripMenuItem.Size = New System.Drawing.Size(76, 29)
        Me.AvisosToolStripMenuItem.Text = "Avisos"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(32, 225)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(572, 60)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Fornecedores"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(32, 363)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(572, 60)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Funcionarios"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(32, 432)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(572, 60)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Produtos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(32, 502)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(572, 60)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Profissões"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(32, 294)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(572, 60)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Fornecimentos"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Industries_DanDataSet
        '
        Me.Industries_DanDataSet.DataSetName = "Industries_DanDataSet"
        Me.Industries_DanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvisosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.Diretores_de_DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.FornecedoresTableAdapter = Nothing
        Me.TableAdapterManager.FornecimentosTableAdapter = Nothing
        Me.TableAdapterManager.FuncionariosTableAdapter = Nothing
        Me.TableAdapterManager.Leitura_de_avisosTableAdapter = Nothing
        Me.TableAdapterManager.Login_FuncionarioTableAdapter = Me.Login_FuncionarioTableAdapter
        Me.TableAdapterManager.ProdutosTableAdapter = Nothing
        Me.TableAdapterManager.ProfissõesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_de_produtoTableAdapter = Nothing
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'PMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 625)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PMenu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Login_FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AvisosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents Login_FuncionarioBindingSource As BindingSource
    Friend WithEvents Login_FuncionarioTableAdapter As Industries_DanDataSetTableAdapters.Login_FuncionarioTableAdapter
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Login_FuncionarioBindingNavigator As BindingNavigator
    Friend WithEvents Login_FuncionarioBindingNavigatorSaveItem As ToolStripButton
End Class
