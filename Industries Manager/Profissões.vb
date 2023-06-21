Public Class Profissões

    Private Sub Profissões_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Profissões'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProfissõesTableAdapter.Fill(Me.Industries_DanDataSet.Profissões)

        ButtonNandG = Button9
        ButtonRorEandC = Button8
        ButtonF = Button1
        ButtonP = Button2
        ButtonN = Button3
        ButtonL = Button4
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProfissõesBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProfissõesBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ProfissõesBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ProfissõesBindingSource.MoveLast()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button9.Text = "Novo" Then
            ProfissõesBindingSource.AddNew()
            iniciarAlteracoes()
        ElseIf Button9.Text = "Guardar" Then
            acabarAlteracoes()

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.Text = "Eliminar" Then
            ProfissõesBindingSource.RemoveCurrent()
        Else
            acabarAlteracoes()
        End If
    End Sub
End Class