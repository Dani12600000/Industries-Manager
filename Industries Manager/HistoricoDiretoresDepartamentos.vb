Public Class HistoricoDiretoresDepartamentos
    Public DepIDLoc As Integer

    Private Sub HistoricoDiretoresDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Diretores_de_Departamentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.Diretores_de_DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Diretores_de_Departamentos)
        Formulario = Me

        Formulario.Width = Formulario.ClientSize.Width + 210

        CenterOnScreenForm()
        CarregarPaletaDeCores()
    End Sub

    Private Sub HistoricoDiretoresDepartamentos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Diretores_de_DepartamentosBindingSource.Filter = "ID_Departamento = " & DepIDLoc
        Diretores_de_DepartamentosBindingSource.Sort = "DDC DESC, ID DESC"
    End Sub
End Class