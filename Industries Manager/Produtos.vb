Public Class Produtos

    Private Sub Produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Venda_de_produto'. Você pode movê-la ou removê-la conforme necessário.
        Me.Venda_de_produtoTableAdapter.Fill(Me.Industries_DanDataSet.Venda_de_produto)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Fornecimentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.FornecimentosTableAdapter.Fill(Me.Industries_DanDataSet.Fornecimentos)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProdutosTableAdapter.Fill(Me.Industries_DanDataSet.Produtos)

        Formulario = Me
        ButtonNG = Button9
        ButtonEC = Button8
        ButtonF = Button1
        ButtonP = Button2
        ButtonN = Button3
        ButtonL = Button4
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.Text = "Remover" Then
            If MessageBox.Show("Tem certeza que deseja remover este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ProdutosBindingSource.RemoveCurrent()
                ProdutosTableAdapter.Update(Industries_DanDataSet.Produtos)
            End If
        ElseIf Button8.Text = "Cancelar" Then
            TableAdapterManager.UpdateAll(Me.Industries_DanDataSet)
            ProdutosBindingSource.CancelEdit()
            acabarAlteracoes()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button9.Text = "Novo" Then
            ProdutosBindingSource.AddNew()

            Dim maxValue As Integer

            If Industries_DanDataSet.Produtos.Rows.Count > 0 Then
                maxValue = Industries_DanDataSet.Produtos.Compute("MAX(id)", "")
            Else
                ' Não há registros na tabela Produtos
                ' Defina um valor padrão para maxValue ou trate a situação de acordo com sua lógica
                maxValue = 0
            End If

            Debug.WriteLine(maxValue)

            'IDTextBox.Text = maxValue  'Vai ter que ficar comentado por enquanto, quando for voltar a meter tirar a primeira apostrofe (')

            iniciarAlteracoes()

        ElseIf Button9.Text = "Guardar" Then
            Try
                ProdutosBindingSource.EndEdit()
                ProdutosTableAdapter.Update(Industries_DanDataSet.Produtos)
                acabarAlteracoes()
                MessageBox.Show("Alterações salvas com sucesso.")
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro ao Guardar as alterações: " & ex.Message)
            End Try

        End If
    End Sub
End Class