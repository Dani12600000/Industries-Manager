Public Class Profissões

    Private Sub Profissões_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Profissões'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProfissõesTableAdapter.Fill(Me.Industries_DanDataSet.Profissões)

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
End Class