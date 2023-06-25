Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProdutosTableAdapter.Fill(Me.Industries_DanDataSet.Produtos)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Venda_de_produto'. Você pode movê-la ou removê-la conforme necessário.
        Me.Venda_de_produtoTableAdapter.Fill(Me.Industries_DanDataSet.Venda_de_produto)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Vendas'. Você pode movê-la ou removê-la conforme necessário.
        Me.VendasTableAdapter.Fill(Me.Industries_DanDataSet.Vendas)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClientesTableAdapter.Fill(Me.Industries_DanDataSet.Clientes)

        VendasDataGridView.Columns(2).DefaultCellStyle.Format = "#,##0.00€"
        Venda_de_produtoDataGridView.Columns(2).DefaultCellStyle.Format = "#,##0.00€"
        Venda_de_produtoDataGridView.Columns(3).DefaultCellStyle.Format = "#,##0.00€"

        Me.Width = Me.ClientSize.Width * 1.24

        Formulario = Me
        ButtonNandG = Button10
        ButtonRorEandC = Button11
        ButtonF = Button1
        ButtonP = Button2
        ButtonN = Button3
        ButtonL = Button4

        CenterOnScreenForm()
    End Sub

    Private Sub SobrenomeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SobrenomeTextBox_TextChanged(sender As Object, e As EventArgs) Handles SobrenomeTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClientesBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClientesBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClientesBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClientesBindingSource.MoveLast()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        VendasBindingSource.MoveFirst()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        VendasBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        VendasBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        VendasBindingSource.MoveLast()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Button10.Text = "Novo" Then
            ClientesBindingSource.AddNew()
            iniciarAlteracoes()
        ElseIf Button10.Text = "Guardar" Then
            Try
                ClientesBindingSource.EndEdit()
                ClientesTableAdapter.Update(Industries_DanDataSet.Clientes)
                acabarAlteracoes()
                MessageBox.Show("Alterações salvas com sucesso.")
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro ao Guardar as alterações: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Button11.Text = "Remover" Then
            If MessageBox.Show("Tem certeza que deseja remover este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ClientesBindingSource.RemoveCurrent()
                ClientesTableAdapter.Update(Industries_DanDataSet.Clientes)

                acabarAlteracoes()
            End If
        ElseIf Button11.Text = "Cancelar" Then
            TableAdapterManager.UpdateAll(Me.Industries_DanDataSet)
            ClientesBindingSource.CancelEdit()

            acabarAlteracoes()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Vendas.Show()
        Vendas.Nova_Venda(MailTextBox.Text)
        Vendas.VendasBindingSource.Current("DDC") = Today()
        Vendas.VendasBindingSource.Current("Total") = 0
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If MsgBox("Tem certeza que deseja remover essa venda?", vbYesNo, "Confirmação") = vbYes Then
            Try
                While Venda_de_produtoBindingSource.Find("ID_Venda", VendasBindingSource.Current("ID")) >= 0
                    Venda_de_produtoBindingSource.RemoveAt(Venda_de_produtoBindingSource.Find("ID_Venda", VendasBindingSource.Current("ID")))
                End While
                Venda_de_produtoTableAdapter.Update(Industries_DanDataSet.Venda_de_produto)
                VendasBindingSource.RemoveCurrent()
                VendasTableAdapter.Update(Industries_DanDataSet.Vendas)
                MsgBox("A venda foi removida com sucesso!", vbInformation, "Removido com sucesso")
            Catch
                MsgBox("Ocorreu um erro ao remover essa venda" & vbCrLf & "Tente novamente mais tarde, se o erro presistir entre em contacto com o administrador", vbCritical, "Erro")
            End Try
        End If
    End Sub
End Class