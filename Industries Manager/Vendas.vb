Imports System.Globalization
Imports Industries_Manager.Industries_DanDataSetTableAdapters
Public Class Vendas

    Dim PrecoTotalCadaProd, SubTotal As Double
    Private Sub Vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProdutosTableAdapter.Fill(Me.Industries_DanDataSet.Produtos)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Venda_de_produto' table. You can move, or remove it, as needed.
        Me.Venda_de_produtoTableAdapter.Fill(Me.Industries_DanDataSet.Venda_de_produto)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Vendas' table. You can move, or remove it, as needed.
        Me.VendasTableAdapter.Fill(Me.Industries_DanDataSet.Vendas)
        QuantidadeNumericUpDown.Value = 1
        ProdutoComboBox.SelectedIndex = -1

        Formulario = Me

        PCTextBox.Text = ""
        SubtotalTextBox.Text = ""

        Me.Width = Me.Width * 1.025

        CenterOnScreenForm()
        CarregarPaletaDeCores()
    End Sub
    Sub Nova_Venda(email As String)
        Debug.WriteLine("Executando Nova_venda")
        VendasBindingSource.AddNew()
        Mail_ClienteTextBox.Text = email
        Debug.WriteLine("Email : " & email)
    End Sub

    Private Sub ProdutosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ProdutosBindingSource.CurrentChanged
        AtualizarProdutosBindingSource()
    End Sub

    Sub AtualizarProdutosBindingSource()
        ' Verifique se o ProdutosBindingSource.Current não é Nothing antes de acessá-lo
        If ProdutosBindingSource IsNot Nothing AndAlso ProdutosBindingSource.Current IsNot Nothing Then
            Try
                Debug.WriteLine("Current Produto ID: " & ProdutosBindingSource.Current("ID"))
                Debug.WriteLine("Current Produto Nome: " & ProdutosBindingSource.Current("Nome"))
                Debug.WriteLine("Current Produto Dinheiro Gasto: " & ProdutosBindingSource.Current("DG"))
                Debug.WriteLine("Current Produto Lucro: " & ProdutosBindingSource.Current("Lucro"))
                PrecoTotalCadaProd = ProdutosBindingSource.Current("DG") + ProdutosBindingSource.Current("Lucro")
                Debug.WriteLine("Current Produto soma Dinheiro Gasto e Lucro: " & PrecoTotalCadaProd & "€")
                PCTextBox.Text = PrecoTotalCadaProd & "€"
                SubTotal = PrecoTotalCadaProd * QuantidadeNumericUpDown.Value
                SubtotalTextBox.Text = SubTotal & "€"
            Catch
            End Try
        End If
    End Sub

    Private Sub Vendas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Not IsDBNull(VendasBindingSource.Current("ID")) Then
            VendasBindingSource.EndEdit()
            VendasTableAdapter.Update(Industries_DanDataSet.Vendas)
            Industries_DanDataSet.Vendas.AcceptChanges()

            ' Recarrega os dados da tabela Vendas
            Me.VendasTableAdapter.Fill(Me.Industries_DanDataSet.Vendas)

            VendasBindingSource.MoveLast()

            Debug.WriteLine("VendasBindingSource.Current(""ID"") : " & VendasBindingSource.Current("ID"))
            Debug.WriteLine("Passou o shown")


            Dim valor As Double

            If Double.TryParse(TotalTextBox.Text, valor) Then
                TotalTextBox.Text = valor.ToString("#,##0.00")
            End If

            Debug.WriteLine("Val(TotalTextBox.Text) : " & Val(TotalTextBox.Text))

            If Val(TotalTextBox.Text) = 0 Then
                TotalTextBox.Text = "0,00"
            End If
        End If
    End Sub

    Private Sub Vendas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Val(TotalTextBox.Text) = 0 Then
            VendasBindingSource.RemoveCurrent()
            VendasTableAdapter.Update(Industries_DanDataSet.Vendas)
        End If

        Clientes.VendasTableAdapter.Fill(Clientes.Industries_DanDataSet.Vendas)
        Clientes.Venda_de_produtoTableAdapter.Fill(Clientes.Industries_DanDataSet.Venda_de_produto)

        Clientes.Activate()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Venda_de_produtoBindingSource.MoveFirst()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Venda_de_produtoBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Venda_de_produtoBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Venda_de_produtoBindingSource.MoveLast()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProdutoComboBox.SelectedIndex = -1
        QuantidadeNumericUpDown.Value = 1
        PCTextBox.Text = ""
        SubtotalTextBox.Text = ""
    End Sub

    Private Sub ProdutoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProdutoComboBox.SelectedIndexChanged
        AtualizarProdutosBindingSource()
    End Sub

    Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Obter os valores dos campos para o novo produto
            Dim ExIDVenda As Integer = CInt(VendasBindingSource.Current("ID"))
            Dim ExIDProd As Integer = CInt(ProdutosBindingSource.Current("ID"))
            Dim ExQuant As Integer = CInt(QuantidadeNumericUpDown.Value)

            Dim culture As New CultureInfo("en-US") ' Define a cultura como inglês americano
            Dim ExPC As Double = Double.Parse(PCTextBox.Text.Replace("€", "").Replace(".", "").Replace(",", "."), culture)
            Dim ExSubtotal As Double = Double.Parse(SubtotalTextBox.Text.Replace("€", "").Replace(".", "").Replace(",", "."), culture)

            ' Verificar se já existe um registro com os mesmos IDs na tabela Venda_de_produto
            Dim registroExistente As DataRow = Industries_DanDataSet.Venda_de_produto.FirstOrDefault(Function(row) CInt(row("ID_Venda")) = ExIDVenda AndAlso CInt(row("ID_Produto")) = ExIDProd)

            If registroExistente IsNot Nothing Then
                ' Se existir, atualizar a quantidade e o subtotal do registro existente
                registroExistente("Quantidade") = CInt(registroExistente("Quantidade")) + ExQuant
                registroExistente("Subtotal") = CDbl(registroExistente("Subtotal")) + ExSubtotal
            Else
                ' Se não existir, adicionar um novo produto à tabela Venda_de_produto
                Dim novaLinha As DataRow = Industries_DanDataSet.Venda_de_produto.NewRow()
                novaLinha("ID_Venda") = ExIDVenda
                novaLinha("ID_Produto") = ExIDProd
                novaLinha("Quantidade") = ExQuant
                novaLinha("PC") = ExPC
                novaLinha("Subtotal") = ExSubtotal
                Industries_DanDataSet.Venda_de_produto.Rows.Add(novaLinha)
            End If

            ' Guardar as alterações no banco de dados
            Venda_de_produtoTableAdapter.Update(Industries_DanDataSet.Venda_de_produto)
            Venda_de_produtoTableAdapter.Fill(Industries_DanDataSet.Venda_de_produto)

            Debug.WriteLine("Adicionado Produto à Venda")
        Catch ex As Exception
            Debug.WriteLine("Falha ao adicionar Produto à Venda: " & ex.Message)
        End Try

        AtualizarValorTotalVenda()
    End Sub

    Private Sub QuantidadeNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles QuantidadeNumericUpDown.ValueChanged
        If PCTextBox.Text <> "" Then
            SubTotal = PrecoTotalCadaProd * QuantidadeNumericUpDown.Value
            SubtotalTextBox.Text = SubTotal & "€"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Venda_de_produtoBindingSource.RemoveCurrent()
        Venda_de_produtoTableAdapter.Update(Industries_DanDataSet.Venda_de_produto)

        AtualizarValorTotalVenda()
    End Sub

    Sub AtualizarValorTotalVenda()
        Try
            ' Obter o ID da venda atual do VendasBindingSource
            Dim vendaID As Integer = CInt(VendasBindingSource.Current("ID"))

            ' Variável para armazenar o valor total da venda
            Dim valorTotal As Double = 0

            ' Percorrer os registros da tabela Venda_de_produto
            For Each row As DataRowView In Venda_de_produtoBindingSource
                ' Verificar se o ID_Venda é igual ao vendaID
                If CInt(row("ID_Venda")) = vendaID Then
                    ' Somar o subtotal ao valor total da venda
                    valorTotal += CDbl(row("Subtotal"))
                End If
            Next

            ' Atualizar o valor total da venda no controle TotalTextBox
            TotalTextBox.Text = valorTotal.ToString("#,##0.00€")

            VendasBindingSource.EndEdit()
            VendasTableAdapter.Update(Industries_DanDataSet.Vendas)
        Catch ex As Exception
        End Try
    End Sub

End Class
