﻿Public Class Fornecedores

    Private Sub Fornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProdutosTableAdapter.Fill(Me.Industries_DanDataSet.Produtos)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Fornecimentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.FornecimentosTableAdapter.Fill(Me.Industries_DanDataSet.Fornecimentos)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
        Me.FornecedoresTableAdapter.Fill(Me.Industries_DanDataSet.Fornecedores)

        HQADateTimePicker.CustomFormat = "HH:mm"
        HQFDateTimePicker.CustomFormat = "HH:mm"

        FornecimentosDataGridView.Columns(3).DefaultCellStyle.Format = "#0.00€"
        FornecimentosDataGridView.Columns(5).DefaultCellStyle.Format = "#0.00€"

        Me.Width = Me.ClientSize.Width * 1.046


        Formulario = Me
        ButtonNandG = Button6
        ButtonRorEandC = Button5
        ButtonF = Button1
        ButtonP = Button2
        ButtonN = Button3
        ButtonL = Button4

        CenterOnScreenForm()
        CarregarPaletaDeCores()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FornecedoresBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.FornecedoresBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.FornecedoresBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.FornecedoresBindingSource.MoveLast()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.Text = "Novo" Then
            FornecedoresBindingSource.AddNew()
            iniciarAlteracoes()
        ElseIf Button6.Text = "Guardar" Then
            Try
                FornecedoresBindingSource.EndEdit()
                FornecedoresTableAdapter.Update(Industries_DanDataSet.Fornecedores)
                acabarAlteracoes()
                MessageBox.Show("Alterações salvas com sucesso.")
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro ao salvar as alterações: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = "Editar" Then
            iniciarAlteracoes()
        ElseIf Button5.Text = "Cancelar" Then
            TableAdapterManager.UpdateAll(Me.Industries_DanDataSet)
            FornecedoresBindingSource.CancelEdit()

            acabarAlteracoes()
        End If
    End Sub

    Private Sub Fornecedores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        PMenu.Activate()
    End Sub
End Class