﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fornecimentos
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim ID_FornecedorLabel As System.Windows.Forms.Label
        Dim ID_ProdutoLabel As System.Windows.Forms.Label
        Dim PCPLabel As System.Windows.Forms.Label
        Dim QuantidadeLabel As System.Windows.Forms.Label
        Dim TGLabel As System.Windows.Forms.Label
        Me.Industries_DanDataSet = New Industries_Manager.Industries_DanDataSet()
        Me.FornecimentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FornecimentosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FornecimentosTableAdapter()
        Me.TableAdapterManager = New Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PCPNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.QuantidadeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TGTextBox = New System.Windows.Forms.TextBox()
        Me.FornecedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FornecedoresTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.FornecedoresTableAdapter()
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosTableAdapter = New Industries_Manager.Industries_DanDataSetTableAdapters.ProdutosTableAdapter()
        Me.ID_FornecedorComboBox = New System.Windows.Forms.ComboBox()
        Me.ID_ProdutoComboBox = New System.Windows.Forms.ComboBox()
        IDLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        ID_FornecedorLabel = New System.Windows.Forms.Label()
        ID_ProdutoLabel = New System.Windows.Forms.Label()
        PCPLabel = New System.Windows.Forms.Label()
        QuantidadeLabel = New System.Windows.Forms.Label()
        TGLabel = New System.Windows.Forms.Label()
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecimentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCPNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantidadeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Industries_DanDataSet
        '
        Me.Industries_DanDataSet.DataSetName = "Industries_DanDataSet"
        Me.Industries_DanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FornecimentosBindingSource
        '
        Me.FornecimentosBindingSource.DataMember = "Fornecimentos"
        Me.FornecimentosBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'FornecimentosTableAdapter
        '
        Me.FornecimentosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvisosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.Diretores_de_DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.FornecedoresTableAdapter = Me.FornecedoresTableAdapter
        Me.TableAdapterManager.FornecimentosTableAdapter = Me.FornecimentosTableAdapter
        Me.TableAdapterManager.FuncionariosTableAdapter = Nothing
        Me.TableAdapterManager.Leitura_de_avisosTableAdapter = Nothing
        Me.TableAdapterManager.Login_FuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.ProdutosTableAdapter = Me.ProdutosTableAdapter
        Me.TableAdapterManager.ProfissõesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Industries_Manager.Industries_DanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_de_produtoTableAdapter = Nothing
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(98, 42)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecimentosBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(134, 39)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(80, 75)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(48, 20)
        DataLabel.TabIndex = 2
        DataLabel.Text = "Data:"
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FornecimentosBindingSource, "Data", True))
        Me.DataDateTimePicker.Location = New System.Drawing.Point(134, 71)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(265, 26)
        Me.DataDateTimePicker.TabIndex = 3
        '
        'ID_FornecedorLabel
        '
        ID_FornecedorLabel.AutoSize = True
        ID_FornecedorLabel.Location = New System.Drawing.Point(33, 106)
        ID_FornecedorLabel.Name = "ID_FornecedorLabel"
        ID_FornecedorLabel.Size = New System.Drawing.Size(95, 20)
        ID_FornecedorLabel.TabIndex = 4
        ID_FornecedorLabel.Text = "Fornecedor:"
        '
        'ID_ProdutoLabel
        '
        ID_ProdutoLabel.AutoSize = True
        ID_ProdutoLabel.Location = New System.Drawing.Point(59, 140)
        ID_ProdutoLabel.Name = "ID_ProdutoLabel"
        ID_ProdutoLabel.Size = New System.Drawing.Size(69, 20)
        ID_ProdutoLabel.TabIndex = 6
        ID_ProdutoLabel.Text = "Produto:"
        '
        'PCPLabel
        '
        PCPLabel.AutoSize = True
        PCPLabel.Location = New System.Drawing.Point(38, 173)
        PCPLabel.Name = "PCPLabel"
        PCPLabel.Size = New System.Drawing.Size(93, 20)
        PCPLabel.TabIndex = 8
        PCPLabel.Text = "Preço cada:"
        '
        'PCPNumericUpDown
        '
        Me.PCPNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FornecimentosBindingSource, "PCP", True))
        Me.PCPNumericUpDown.DecimalPlaces = 2
        Me.PCPNumericUpDown.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.PCPNumericUpDown.Location = New System.Drawing.Point(134, 171)
        Me.PCPNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.PCPNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PCPNumericUpDown.Name = "PCPNumericUpDown"
        Me.PCPNumericUpDown.Size = New System.Drawing.Size(207, 26)
        Me.PCPNumericUpDown.TabIndex = 9
        Me.PCPNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'QuantidadeLabel
        '
        QuantidadeLabel.AutoSize = True
        QuantidadeLabel.Location = New System.Drawing.Point(32, 203)
        QuantidadeLabel.Name = "QuantidadeLabel"
        QuantidadeLabel.Size = New System.Drawing.Size(96, 20)
        QuantidadeLabel.TabIndex = 10
        QuantidadeLabel.Text = "Quantidade:"
        '
        'QuantidadeNumericUpDown
        '
        Me.QuantidadeNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FornecimentosBindingSource, "Quantidade", True))
        Me.QuantidadeNumericUpDown.Location = New System.Drawing.Point(134, 203)
        Me.QuantidadeNumericUpDown.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.QuantidadeNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantidadeNumericUpDown.Name = "QuantidadeNumericUpDown"
        Me.QuantidadeNumericUpDown.Size = New System.Drawing.Size(207, 26)
        Me.QuantidadeNumericUpDown.TabIndex = 11
        Me.QuantidadeNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(341, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "€"
        '
        'TGLabel
        '
        TGLabel.AutoSize = True
        TGLabel.Location = New System.Drawing.Point(36, 238)
        TGLabel.Name = "TGLabel"
        TGLabel.Size = New System.Drawing.Size(92, 20)
        TGLabel.TabIndex = 13
        TGLabel.Text = "Total gasto:"
        '
        'TGTextBox
        '
        Me.TGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecimentosBindingSource, "TG", True))
        Me.TGTextBox.Location = New System.Drawing.Point(134, 235)
        Me.TGTextBox.Name = "TGTextBox"
        Me.TGTextBox.Size = New System.Drawing.Size(207, 26)
        Me.TGTextBox.TabIndex = 14
        '
        'FornecedoresBindingSource
        '
        Me.FornecedoresBindingSource.DataMember = "Fornecedores"
        Me.FornecedoresBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'FornecedoresTableAdapter
        '
        Me.FornecedoresTableAdapter.ClearBeforeFill = True
        '
        'ProdutosBindingSource
        '
        Me.ProdutosBindingSource.DataMember = "Produtos"
        Me.ProdutosBindingSource.DataSource = Me.Industries_DanDataSet
        '
        'ProdutosTableAdapter
        '
        Me.ProdutosTableAdapter.ClearBeforeFill = True
        '
        'ID_FornecedorComboBox
        '
        Me.ID_FornecedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecimentosBindingSource, "ID_Fornecedor", True))
        Me.ID_FornecedorComboBox.DataSource = Me.FornecedoresBindingSource
        Me.ID_FornecedorComboBox.DisplayMember = "NDE"
        Me.ID_FornecedorComboBox.FormattingEnabled = True
        Me.ID_FornecedorComboBox.Location = New System.Drawing.Point(134, 103)
        Me.ID_FornecedorComboBox.Name = "ID_FornecedorComboBox"
        Me.ID_FornecedorComboBox.Size = New System.Drawing.Size(265, 28)
        Me.ID_FornecedorComboBox.TabIndex = 15
        '
        'ID_ProdutoComboBox
        '
        Me.ID_ProdutoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecimentosBindingSource, "ID_Produto", True))
        Me.ID_ProdutoComboBox.FormattingEnabled = True
        Me.ID_ProdutoComboBox.Location = New System.Drawing.Point(134, 137)
        Me.ID_ProdutoComboBox.Name = "ID_ProdutoComboBox"
        Me.ID_ProdutoComboBox.Size = New System.Drawing.Size(265, 28)
        Me.ID_ProdutoComboBox.TabIndex = 16
        '
        'Fornecimentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 374)
        Me.Controls.Add(Me.ID_ProdutoComboBox)
        Me.Controls.Add(Me.ID_FornecedorComboBox)
        Me.Controls.Add(TGLabel)
        Me.Controls.Add(Me.TGTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(QuantidadeLabel)
        Me.Controls.Add(Me.QuantidadeNumericUpDown)
        Me.Controls.Add(PCPLabel)
        Me.Controls.Add(Me.PCPNumericUpDown)
        Me.Controls.Add(ID_ProdutoLabel)
        Me.Controls.Add(ID_FornecedorLabel)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Name = "Fornecimentos"
        Me.Text = "Fornecimentos"
        CType(Me.Industries_DanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecimentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCPNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantidadeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Industries_DanDataSet As Industries_DanDataSet
    Friend WithEvents FornecimentosBindingSource As BindingSource
    Friend WithEvents FornecimentosTableAdapter As Industries_DanDataSetTableAdapters.FornecimentosTableAdapter
    Friend WithEvents TableAdapterManager As Industries_DanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents DataDateTimePicker As DateTimePicker
    Friend WithEvents PCPNumericUpDown As NumericUpDown
    Friend WithEvents QuantidadeNumericUpDown As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents TGTextBox As TextBox
    Friend WithEvents FornecedoresTableAdapter As Industries_DanDataSetTableAdapters.FornecedoresTableAdapter
    Friend WithEvents FornecedoresBindingSource As BindingSource
    Friend WithEvents ProdutosTableAdapter As Industries_DanDataSetTableAdapters.ProdutosTableAdapter
    Friend WithEvents ProdutosBindingSource As BindingSource
    Friend WithEvents ID_FornecedorComboBox As ComboBox
    Friend WithEvents ID_ProdutoComboBox As ComboBox
End Class
