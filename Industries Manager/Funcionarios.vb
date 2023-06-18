Public Class Funcionarios

    Dim DespColor, ContColor As Color

    Private Sub Funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Industries_DanDataSet.Login_Funcionario' table. You can move, or remove it, as needed.
        Me.Login_FuncionarioTableAdapter.Fill(Me.Industries_DanDataSet.Login_Funcionario)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Funcionarios' table. You can move, or remove it, as needed.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)

        FotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Sub VerificarContrartarDespedir()
        Debug.WriteLine("DDEDE : " & FuncionariosBindingSource.Current("DDEDE").ToString)
        Debug.WriteLine("DDSDE : " & FuncionariosBindingSource.Current("DDSDE").ToString)
        Debug.WriteLine("DDEDE Vazio : " & FuncionariosBindingSource.Current("DDEDE").ToString.Equals(""))
        Debug.WriteLine("DDSDE Vazio : " & FuncionariosBindingSource.Current("DDSDE").ToString.Equals(""))

        If FuncionariosBindingSource.Current("DDEDE").ToString.Equals("") Then
            Button5.Text = "Contratar"
            Button5.BackColor = ContColor
        ElseIf Not FuncionariosBindingSource.Current("DDEDE").ToString.Equals("") And FuncionariosBindingSource.Current("DDSDE").ToString.Equals("") Then
            Button5.Text = "Despedir"
            Button5.BackColor = DespColor
        ElseIf Not FuncionariosBindingSource.Current("DDEDE").ToString.Equals("") And Not FuncionariosBindingSource.Current("DDSDE").ToString.Equals("") Then
            Button5.Text = "Recontratar"
            Button5.BackColor = ContColor
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FuncionariosBindingSource.MoveNext()

        VerificarContrartarDespedir()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FuncionariosBindingSource.MoveLast()

        VerificarContrartarDespedir()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FuncionariosBindingSource.MovePrevious()

        VerificarContrartarDespedir()


    End Sub

    Private Sub Funcionarios_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        DespColor = Button6.BackColor
        ContColor = Button4.BackColor

        VerificarContrartarDespedir()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FuncionariosBindingSource.MoveFirst()

        VerificarContrartarDespedir()


    End Sub
End Class