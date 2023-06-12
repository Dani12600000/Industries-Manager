Public Class Profissões

    Private Sub Profissões_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Profissões'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProfissõesTableAdapter.Fill(Me.Industries_DanDataSet.Profissões)

    End Sub
End Class