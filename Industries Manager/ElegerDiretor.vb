Public Class ElegerDiretor
    Public DepIDLoc As Integer

    Private Sub ElegerDiretor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Funcionarios' table. You can move, or remove it, as needed.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Diretores_de_Departamentos' table. You can move, or remove it, as needed.
        Me.Diretores_de_DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Diretores_de_Departamentos)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Diretores_de_DepartamentosBindingSource.AddNew()
        Diretores_de_DepartamentosBindingSource.Current("ID_Departamento") = DepIDLoc
        Diretores_de_DepartamentosBindingSource.Current("DDD") = TextBox1.Text
        Diretores_de_DepartamentosBindingSource.Current("ID_Funcionario") = DepIDLoc
        Diretores_de_DepartamentosBindingSource.Current("Funcoes") = DepIDLoc
        Diretores_de_DepartamentosBindingSource.Current("DDC") = Today
        If CheckBox1.Checked Then
            Diretores_de_DepartamentosBindingSource.Current("DDF") = DateTimePicker1.Value
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            DateTimePicker1.Enabled = True
        Else
            DateTimePicker1.Enabled = False
        End If
    End Sub

    Private Sub ElegerDiretor_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Label1.Text = "Escolha o novo Diretor do departamento de " & InfoEnterprise.NomeDepartamento(InfoEnterprise.IDDepartamento.IndexOf(DepIDLoc))

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

        Diretores_de_DepartamentosBindingSource.RemoveFilter()

        DateTimePicker1.MinDate = Today.AddDays(7)
        DateTimePicker1.Value = Today.AddYears(1)
    End Sub
End Class