Public Class Fornecimentos

    Private Sub Fornecimentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Produtos' table. You can move, or remove it, as needed.
        Me.ProdutosTableAdapter.Fill(Me.Industries_DanDataSet.Produtos)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Fornecedores' table. You can move, or remove it, as needed.
        Me.FornecedoresTableAdapter.Fill(Me.Industries_DanDataSet.Fornecedores)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Fornecimentos' table. You can move, or remove it, as needed.
        Me.FornecimentosTableAdapter.Fill(Me.Industries_DanDataSet.Fornecimentos)



    End Sub

    Private Sub Fornecimentos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown



    End Sub

    Private Sub PCPNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles PCPNumericUpDown.ValueChanged
        AtualizarTG()
    End Sub

    Private Sub QuantidadeNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles QuantidadeNumericUpDown.ValueChanged
        AtualizarTG()
    End Sub

    Sub AtualizarTG()
        TGTextBox.Text = (PCPNumericUpDown.Value * QuantidadeNumericUpDown.Value).ToString("#,##0.00€")
        Debug.WriteLine("PCPNumericUpDown.Value * QuantidadeNumericUpDown.Value = " & (PCPNumericUpDown.Value * QuantidadeNumericUpDown.Value))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Debug.WriteLine("FornecedoresBindingSource.Current(""ID"") : " & FornecedoresBindingSource.Current("ID"))
        Debug.WriteLine("ProdutosBindingSource.Current(""ID"") : " & ProdutosBindingSource.Current("ID"))

        FornecimentosBindingSource.Current("ID_Fornecedor") = FornecedoresBindingSource.Current("ID")
        FornecimentosBindingSource.Current("ID_Produto") = ProdutosBindingSource.Current("ID")

        Debug.WriteLine("FornecimentosBindingSource.Current(""ID_Fornecedor"") : " & FornecimentosBindingSource.Current("ID_Fornecedor"))
        Debug.WriteLine("FornecimentosBindingSource.Current(""ID_Produto"") : " & FornecimentosBindingSource.Current("ID_Produto"))

        Debug.WriteLine("PCPNumericUpDown.Value : " & PCPNumericUpDown.Value)
        Debug.WriteLine("TGTextBox.Text : " & TGTextBox.Text)

        FornecimentosBindingSource.Current("Quantidade") = QuantidadeNumericUpDown.Value
        FornecimentosBindingSource.Current("PCP") = PCPNumericUpDown.Value
        FornecimentosBindingSource.Current("TG") = Double.Parse(TGTextBox.Text.Replace("€", ""))

        Debug.WriteLine("FornecimentosBindingSource.Current(""PCP"") : " & FornecimentosBindingSource.Current("PCP"))
        Debug.WriteLine("FornecimentosBindingSource.Current(""TG"") : " & FornecimentosBindingSource.Current("TG"))

        FornecimentosBindingSource.EndEdit()
        FornecimentosTableAdapter.Update(Industries_DanDataSet.Fornecimentos)

        AtualizarTG()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Fornecimentos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Produtos.FornecimentosTableAdapter.Fill(Industries_DanDataSet.Fornecimentos)
    End Sub
End Class