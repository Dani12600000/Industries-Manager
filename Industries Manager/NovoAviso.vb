Public Class NovoAviso
    Private Sub AvisosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AvisosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Industries_DanDataSet)

    End Sub

    Private Sub NovoAviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Avisos' table. You can move, or remove it, as needed.
        Me.AvisosTableAdapter.Fill(Me.Industries_DanDataSet.Avisos)

    End Sub
End Class