Imports System.Globalization
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
        Clientes.VendasTableAdapter.Fill(Clientes.Industries_DanDataSet.Vendas)
        Clientes.Venda_de_produtoTableAdapter.Fill(Clientes.Industries_DanDataSet.Venda_de_produto)
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
        Dim penultimoRegistro As DataRowView = VendasBindingSource(VendasBindingSource.Count - 2)
        Dim penultimoID As Integer = CInt(penultimoRegistro("ID"))

        Debug.Close()
        Debug.WriteLine("Saida para introdução de um novo produto")
        Debug.WriteLine("----------------------------------------")
        Debug.WriteLine("VendasBindingSource.Current(""ID"") : " & VendasBindingSource.Current("ID"))
        Debug.WriteLine("penultimoRegistro : " & penultimoID)

        ExIDVenda = penultimoID + 1

        Debug.WriteLine("Numer VendasBindingSource.Find(""ID"", ExIDVenda) : " & VendasBindingSource.Find("ID", ExIDVenda))
        Debug.WriteLine("Numero de linhas : " & Industries_DanDataSet.Vendas.Count)

        VendasTableAdapter.Update(Industries_DanDataSet.Vendas)

        If VendasBindingSource.Find("ID", ExIDVenda) < 0 Then
            While VendasBindingSource.Find("ID", ExIDVenda) < 0
                ExIDVenda += 1
                Debug.WriteLine("Subi!, ID_Venda atual : " & ExIDVenda)
                Debug.WriteLine("Numer VendasBindingSource.Find(""ID"", ExIDVenda) : " & VendasBindingSource.Find("ID", ExIDVenda))
            End While
        End If

        ExIDProd = ProdutosBindingSource.Current("ID")
        ExQuant = QuantidadeNumericUpDown.Value

        Dim culture As New CultureInfo("en-US") ' Define a cultura como inglês americano
        ExPC = Double.Parse(PCTextBox.Text.Replace("€", "").Replace(".", "").Replace(",", "."), culture)
        ExSubtotal = Double.Parse(SubtotalTextBox.Text.Replace("€", "").Replace(".", "").Replace(",", "."), culture)
        Debug.WriteLine("ExIDProd : " & ExIDProd)
        Debug.WriteLine("ExQuant : " & ExQuant)
        Debug.WriteLine("ExPC : " & ExPC)
        Debug.WriteLine("ExSubtotal : " & ExSubtotal)

        Venda_de_produtoBindingSource.AddNew()

        Venda_de_produtoBindingSource.Current("ID_Venda") = ExIDVenda
        Venda_de_produtoBindingSource.Current("ID_Produto") = ExIDProd
        Venda_de_produtoBindingSource.Current("Quantidade") = ExQuant
        Venda_de_produtoBindingSource.Current("PC") = ExPC
        Venda_de_produtoBindingSource.Current("Subtotal") = ExSubtotal

        Try
            Venda_de_produtoBindingSource.EndEdit()
            Venda_de_produtoTableAdapter.Update(Industries_DanDataSet.Venda_de_produto)
            Venda_de_produtoTableAdapter.Fill(Industries_DanDataSet.Venda_de_produto)

            VendasBindingSource.EndEdit()
            VendasTableAdapter.Update(Industries_DanDataSet.Vendas)

            VendasBindingSource.Find("ID", ExIDVenda)
        Catch
            Debug.WriteLine("ID_Venda : " & ExIDVenda)
        End Try

    End Sub
    Private Sub QuantidadeNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles QuantidadeNumericUpDown.ValueChanged
        If PCTextBox.Text <> "" Then
            SubTotal = PrecoTotalCadaProd * QuantidadeNumericUpDown.Value
            SubtotalTextBox.Text = SubTotal & "€"
        End If
    End Sub
End Class
