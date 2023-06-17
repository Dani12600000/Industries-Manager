Imports Industries_Manager.Industries_DanDataSetTableAdapters

Public Class Vendas
    Dim ExIDVenda, ExIDProd, ExQuant As Integer
    Dim ExPC, ExSubtotal As Double


    Dim PrecoTotalCadaProd, SubTotal As Double

    Private Sub Vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProdutosTableAdapter.Fill(Me.Industries_DanDataSet.Produtos)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Venda_de_produto' table. You can move, or remove it, as needed.
        Me.Venda_de_produtoTableAdapter.Fill(Me.Industries_DanDataSet.Venda_de_produto)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Vendas' table. You can move, or remove it, as needed.
        Me.VendasTableAdapter.Fill(Me.Industries_DanDataSet.Vendas)

        QuantidadeNumericUpDown.Value = 1


    End Sub

    Sub Nova_Venda(email As String)
        Debug.WriteLine("Executando Nova_venda")
        VendasBindingSource.AddNew()
        Mail_ClienteTextBox.Text = email
        Debug.WriteLine("Email : " & email)
    End Sub

    Private Sub ID_ProdutoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ID_ProdutoComboBox.SelectedIndexChanged

        Try

            Debug.WriteLine("ID_ProdutoComboBox.Text: " & ID_ProdutoComboBox.Text)

            ProdutosBindingSource.Position = ProdutosBindingSource.Find("Nome", ID_ProdutoComboBox.Text)

            Debug.WriteLine("Current Produto ID : " & ProdutosBindingSource.Current("ID"))
            Debug.WriteLine("Current Produto Nome : " & ProdutosBindingSource.Current("Nome"))
            Debug.WriteLine("Current Produto Dinheiro Gasto : " & ProdutosBindingSource.Current("DG"))
            Debug.WriteLine("Current Produto Lucro : " & ProdutosBindingSource.Current("Lucro"))

            PrecoTotalCadaProd = ProdutosBindingSource.Current("DG") + ProdutosBindingSource.Current("Lucro")

            Debug.WriteLine("Current Produto soma Dinheiro Gasto e Lucro : " & PrecoTotalCadaProd & "€")



            PCTextBox.Text = PrecoTotalCadaProd & "€"

            SubTotal = PrecoTotalCadaProd * QuantidadeNumericUpDown.Value
            SubtotalTextBox.Text = SubTotal & "€"
        Catch

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ID_ProdutoComboBox.SelectedIndex = -1
        QuantidadeNumericUpDown.Value = 1
        PCTextBox.Text = ""
        SubtotalTextBox.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'If VendasBindingSource.Current("ID") <= -1 Then
        'VendasBindingSource.
        'End If

        Debug.Close()
        Debug.WriteLine("Saida para introdução de um novo produto")
        Debug.WriteLine("----------------------------------------")
        Debug.WriteLine("VendasBindingSource.Current(""ID"") : " & VendasBindingSource.Current("ID"))


        ExIDVenda = VendasBindingSource.Current("ID")
        'CONTINUAR AQUI
        'ExIDProd = ID_ProdutoComboBox.Text
        'ExQuant =
        'ExPC =
        'ExSubtotal = 


        Venda_de_produtoBindingSource.AddNew()


        VendasBindingSource.EndEdit()
        VendasTableAdapter.Update(Industries_DanDataSet.Vendas)
    End Sub

    Private Sub QuantidadeNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles QuantidadeNumericUpDown.ValueChanged
        If PCTextBox.Text <> "" Then
            SubTotal = PrecoTotalCadaProd * QuantidadeNumericUpDown.Value
            SubtotalTextBox.Text = SubTotal & "€"
        End If
    End Sub
End Class