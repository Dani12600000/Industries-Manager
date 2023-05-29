﻿Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProdutosTableAdapter.Fill(Me.Industries_DanDataSet.Produtos)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Venda_de_produto'. Você pode movê-la ou removê-la conforme necessário.
        Me.Venda_de_produtoTableAdapter.Fill(Me.Industries_DanDataSet.Venda_de_produto)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Vendas'. Você pode movê-la ou removê-la conforme necessário.
        Me.VendasTableAdapter.Fill(Me.Industries_DanDataSet.Vendas)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClientesTableAdapter.Fill(Me.Industries_DanDataSet.Clientes)

        VendasDataGridView.Columns(2).DefaultCellStyle.Format = "#0.00€"
        Venda_de_produtoDataGridView.Columns(2).DefaultCellStyle.Format = "#0.00€"
        Venda_de_produtoDataGridView.Columns(3).DefaultCellStyle.Format = "#0.00€"

        Me.Width = Me.ClientSize.Width * 1.22


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
        VendasBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        VendasBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        VendasBindingSource.MoveLast()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Button10.Text = "Novo" Then
            ClientesBindingSource.AddNew()
            iniciarAlteracoes()
        ElseIf Button10.Text = "Salvar" Then
            Try
                ClientesBindingSource.EndEdit()
                ClientesTableAdapter.Update(Industries_DanDataSet.Clientes)
                acabarAlteracoes()
                MessageBox.Show("Alterações salvas com sucesso.")
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro ao salvar as alterações: " & ex.Message)
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


    Sub iniciarAlteracoes()
        MailTextBox.ReadOnly = False
        NIFTextBox.ReadOnly = False
        NIBTextBox.ReadOnly = False
        NomeTextBox.ReadOnly = False
        SobrenomeTextBox.ReadOnly = False
        DDNDateTimePicker.Enabled = True
        Button10.Text = "Salvar"
        Button11.Text = "Cancelar"
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub

    Sub acabarAlteracoes()
        MailTextBox.ReadOnly = True
        NIFTextBox.ReadOnly = True
        NIBTextBox.ReadOnly = True
        NomeTextBox.ReadOnly = True
        SobrenomeTextBox.ReadOnly = True
        DDNDateTimePicker.Enabled = False
        Button10.Text = "Novo"
        Button11.Text = "Remover"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub
End Class