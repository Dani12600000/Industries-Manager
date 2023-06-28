Public Class HistoricoDiretoresDepartamentos
    Private Sub Diretores_de_DepartamentosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Diretores_de_DepartamentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Industries_DanDataSet)

    End Sub

    Private Sub HistoricoDiretoresDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Diretores_de_Departamentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.Diretores_de_DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Diretores_de_Departamentos)
        Formulario = Me
        CenterOnScreenForm()
        Formulario.Width = Formulario.ClientSize.Width + 120
    End Sub
End Class