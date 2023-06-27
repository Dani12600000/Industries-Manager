<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovoAviso
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
        Dim TituloLabel As System.Windows.Forms.Label
        Dim AvisoLabel As System.Windows.Forms.Label
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.AvisosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AvisosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.AvisosTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DataRadioButton = New System.Windows.Forms.RadioButton()
        Me.TituloTextBox = New System.Windows.Forms.TextBox()
        Me.AvisoTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        TituloLabel = New System.Windows.Forms.Label()
        AvisoLabel = New System.Windows.Forms.Label()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvisosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.DataRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 152)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma de fim de prazo"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(17, 113)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(80, 24)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Nunca"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(17, 73)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(121, 24)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Todos leram"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DataRadioButton
        '
        Me.DataRadioButton.AutoSize = True
        Me.DataRadioButton.Location = New System.Drawing.Point(17, 34)
        Me.DataRadioButton.Name = "DataRadioButton"
        Me.DataRadioButton.Size = New System.Drawing.Size(69, 24)
        Me.DataRadioButton.TabIndex = 2
        Me.DataRadioButton.TabStop = True
        Me.DataRadioButton.Text = "Data"
        Me.DataRadioButton.UseVisualStyleBackColor = True
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
        'TituloTextBox
        '
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvisosBindingSource, "Titulo", True))
        Me.TituloTextBox.Location = New System.Drawing.Point(81, 27)
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(512, 26)
        Me.TituloTextBox.TabIndex = 2
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
        'AvisoTextBox
        '
        Me.AvisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvisosBindingSource, "Aviso", True))
        Me.AvisoTextBox.Location = New System.Drawing.Point(81, 62)
        Me.AvisoTextBox.Multiline = True
        Me.AvisoTextBox.Name = "AvisoTextBox"
        Me.AvisoTextBox.Size = New System.Drawing.Size(512, 126)
        Me.AvisoTextBox.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(318, 296)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(148, 26)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(314, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Data limite:"
        '
        'NovoAviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 469)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(AvisoLabel)
        Me.Controls.Add(Me.AvisoTextBox)
        Me.Controls.Add(TituloLabel)
        Me.Controls.Add(Me.TituloTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "NovoAviso"
        Me.Text = "Novo Aviso"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvisosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents AvisosBindingSource As BindingSource
    Friend WithEvents AvisosTableAdapter As Industries_DanDataSetTableAdapters.AvisosTableAdapter
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DataRadioButton As RadioButton
    Friend WithEvents TituloTextBox As TextBox
    Friend WithEvents AvisoTextBox As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
