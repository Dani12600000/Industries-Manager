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

        FornecimentosBindingSource.Current("ID_Fornecedor") = FornecedoresBindingSource.Current("ID")
        FornecimentosBindingSource.Current("ID_Produto") = ProdutosBindingSource.Current("ID")

        FornecimentosBindingSource.EndEdit()
        FornecimentosTableAdapter.Update(Industries_DanDataSet.Fornecimentos)
        Produtos.FornecimentosTableAdapter.Fill(Industries_DanDataSet.Fornecimentos)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class