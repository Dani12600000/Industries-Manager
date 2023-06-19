Public Class Fornecimentos

    Private Sub Fornecimentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Produtos' table. You can move, or remove it, as needed.
        Me.ProdutosTableAdapter.Fill(Me.Industries_DanDataSet.Produtos)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Fornecedores' table. You can move, or remove it, as needed.
        Me.FornecedoresTableAdapter.Fill(Me.Industries_DanDataSet.Fornecedores)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Fornecimentos' table. You can move, or remove it, as needed.
        Me.FornecimentosTableAdapter.Fill(Me.Industries_DanDataSet.Fornecimentos)

    End Sub
End Class