Public Class ElegerDiretor
    Public DepIDLoc As Integer

    Private Sub ElegerDiretor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Funcionarios' table. You can move, or remove it, as needed.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Diretores_de_Departamentos' table. You can move, or remove it, as needed.
        Me.Diretores_de_DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Diretores_de_Departamentos)

        Label1.Text = "Escolha o novo Diretor do departamento de " & DepIDLoc

        If InfoUser.UserAdm Then
            FuncionariosBindingSource.Filter = "Aprovacao = True AND ID_Departamento = " & DepIDLoc
        Else
            FuncionariosBindingSource.Filter = "Aprovacao = True AND ID_Departamento = " & DepIDLoc & " AND NOT ID = " & InfoUser.UserID
        End If

        Diretores_de_DepartamentosBindingSource.Filter = "ID_Departamento = " & InfoUser.UserDepID

        For Each row As DataRowView In Diretores_de_DepartamentosBindingSource
            Dim value As String = row("DDD").ToString()
            TextBox1.AutoCompleteCustomSource.Add(value)
            Debug.WriteLine("value: " & value)
        Next

        DateTimePicker1.MinDate = Today.AddDays(7)
        DateTimePicker1.Value = Today.AddYears(1)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class