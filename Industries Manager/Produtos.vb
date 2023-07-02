Public Class Produtos

    Private Sub Produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Fornecedores' table. You can move, or remove it, as needed.
        Me.FornecedoresTableAdapter.Fill(Me.Industries_DanDataSet.Fornecedores)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Venda_de_produto'. Você pode movê-la ou removê-la conforme necessário.
        Me.Venda_de_produtoTableAdapter.Fill(Me.Industries_DanDataSet.Venda_de_produto)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Fornecimentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.FornecimentosTableAdapter.Fill(Me.Industries_DanDataSet.Fornecimentos)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProdutosTableAdapter.Fill(Me.Industries_DanDataSet.Produtos)

        Formulario = Me
        ButtonNandG = Button9
        ButtonRorEandC = Button8
        ButtonF = Button1
        ButtonP = Button2
        ButtonN = Button3
        ButtonL = Button4

        Me.Width = Me.ClientSize.Width * 1.438

        CenterOnScreenForm()

        FornecimentosDataGridView.Columns(3).DefaultCellStyle.Format = "#,##0.00€"
        FornecimentosDataGridView.Columns(5).DefaultCellStyle.Format = "#,##0.00€"
        Venda_de_produtoDataGridView.Columns(3).DefaultCellStyle.Format = "#,##0.00€"
        Venda_de_produtoDataGridView.Columns(4).DefaultCellStyle.Format = "#,##0.00€"
        CarregarPaletaDeCores()
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

            DGTextBox.ReadOnly = True

        ElseIf Button9.Text = "Guardar" Then
            Try
                ProdutosBindingSource.Current("DG") = 0
                ProdutosBindingSource.EndEdit()
                ProdutosTableAdapter.Update(Industries_DanDataSet.Produtos)
                ProdutosTableAdapter.Fill(Industries_DanDataSet.Produtos)
                ProdutosBindingSource.MoveLast()
                acabarAlteracoes()
                MessageBox.Show("Alterações salvas com sucesso.")
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro ao Guardar as alterações: " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Fornecimentos.Show()
        Fornecimentos.FornecimentosBindingSource.AddNew()
        Fornecimentos.ProdutosBindingSource.Position = ProdutosBindingSource.Position
        Fornecimentos.ProdutoComboBox.Enabled = False
        Fornecimentos.DataDateTimePicker.Value = Today

        ' Cálculo da moda das quantidades
        Dim produtoID As Integer = ProdutosBindingSource.Current("ID")
        Dim quantidadeCounts As New Dictionary(Of Integer, Integer)()
        Dim maxCount As Integer = 0
        Dim modaQuantidade As Integer = 0

        ' Verifica se existem registros de fornecimentos para o produto selecionado
        Dim hasFornecimentos As Boolean = False
        For i As Integer = 0 To Industries_DanDataSet.Fornecimentos.Rows.Count - 1
            Dim fornecimentoIDProduto As Integer = Industries_DanDataSet.Fornecimentos.Rows(i)("ID_Produto")
            If fornecimentoIDProduto = produtoID Then
                hasFornecimentos = True
                Exit For
            End If
        Next

        If hasFornecimentos Then
            For i As Integer = 0 To Industries_DanDataSet.Fornecimentos.Rows.Count - 1
                Dim fornecimentoIDProduto As Integer = Industries_DanDataSet.Fornecimentos.Rows(i)("ID_Produto")
                If fornecimentoIDProduto = produtoID Then
                    Dim quantidade As Integer = Industries_DanDataSet.Fornecimentos.Rows(i)("Quantidade")
                    If quantidadeCounts.ContainsKey(quantidade) Then
                        quantidadeCounts(quantidade) += 1
                    Else
                        quantidadeCounts.Add(quantidade, 1)
                    End If

                    If quantidadeCounts(quantidade) > maxCount Then
                        maxCount = quantidadeCounts(quantidade)
                        modaQuantidade = quantidade
                    End If
                End If
            Next
        Else
            modaQuantidade = 1 ' Define a quantidade como 1 se não houver fornecimentos
        End If

        Fornecimentos.QuantidadeNumericUpDown.Value = modaQuantidade

        ' Cálculo da média dos PCP's
        Dim totalPCP As Double = 0.0
        Dim countPCP As Integer = 0

        ' Verifica se existem registros de fornecimentos para o produto selecionado
        If hasFornecimentos Then
            For i As Integer = 0 To Industries_DanDataSet.Fornecimentos.Rows.Count - 1
                Dim fornecimentoIDProduto As Integer = Industries_DanDataSet.Fornecimentos.Rows(i)("ID_Produto")
                If fornecimentoIDProduto = produtoID Then
                    Dim pcp As Double = Industries_DanDataSet.Fornecimentos.Rows(i)("PCP")
                    totalPCP += pcp
                    countPCP += 1
                End If
            Next
        Else
            totalPCP = 1.0 ' Define o preço como 1 se não houver fornecimentos
            countPCP = 1
        End If

        Dim mediaPCP As Double = totalPCP / countPCP
        Fornecimentos.PCPNumericUpDown.Value = CDec(mediaPCP)

        Fornecimentos.AtualizarTG()

    End Sub

    Private Sub Button8_TextChanged(sender As Object, e As EventArgs) Handles Button8.TextChanged
        If Button8.Text = "Remover" Then
            Button8.Enabled = False
        Else
            Button8.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.Text = "Editar" Then

            iniciarAlteracaoUnica(Button6, LucroNumericUpDown)

        ElseIf Button6.Text = "Guardar" Then

            Dim posicaoAtualProd As Integer

            Try
                posicaoAtualProd = ProdutosBindingSource.Position
                acabarAlteracaoUnica()
                ProdutosBindingSource.EndEdit()
                ProdutosTableAdapter.Update(Industries_DanDataSet.Produtos)
                ProdutosTableAdapter.Fill(Industries_DanDataSet.Produtos)
                ProdutosBindingSource.Position = posicaoAtualProd
                MsgBox("Guardado novo lucro pretendido com sucesso", vbInformation, "Guardado")
            Catch
            End Try

        End If
    End Sub

    Sub AtualizarProdutoAoMudarPosition() Handles ProdutosBindingSource.PositionChanged

        If ProdutosBindingSource.Current IsNot Nothing Then
            DGTextBox.Text = Double.Parse(ProdutosBindingSource.Current("DG")).ToString("#,##0.00€")
            PFTextBox.Text = (Double.Parse(ProdutosBindingSource.Current("DG")) + Double.Parse(ProdutosBindingSource.Current("Lucro"))).ToString("#,##0.00€")
        End If

    End Sub

    Private Sub Produtos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        PMenu.Activate()
    End Sub
End Class