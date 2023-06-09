Public Class Produtos

    Private Sub Produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Venda_de_produto'. Você pode movê-la ou removê-la conforme necessário.
        Me.Venda_de_produtoTableAdapter.Fill(Me.Industries_DanDataSet.Venda_de_produto)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Fornecimentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.FornecimentosTableAdapter.Fill(Me.Industries_DanDataSet.Fornecimentos)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProdutosTableAdapter.Fill(Me.Industries_DanDataSet.Produtos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ProdutosBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ProdutosBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ProdutosBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        ProdutosBindingSource.MoveLast()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        ProdutosBindingSource.MoveLast()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ProdutosBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        ProdutosBindingSource.MovePrevious()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ProdutosBindingSource.MoveFirst()
    End Sub
End Class