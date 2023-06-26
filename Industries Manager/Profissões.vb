Public Class Profissões

    Private Sub Profissões_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Departamentos' table. You can move, or remove it, as needed.
        Me.DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Departamentos)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Profissões'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProfissõesTableAdapter.Fill(Me.Industries_DanDataSet.Profissões)

        Me.Width = Me.ClientSize.Width * 1.39

        FuncionariosDataGridView.Columns(5).DefaultCellStyle.Format = "#,##0.00€"

        Formulario = Me
        ButtonNandG = Button9
        ButtonRorEandC = Button11
        ButtonF = Button1
        ButtonP = Button2
        ButtonN = Button3
        ButtonL = Button4

        CenterOnScreenForm()

        ButtonsQPrecisamSerGuardados.Add(Button5)
        ButtonsQPrecisamSerGuardados.Add(Button6)
        ButtonsQPrecisamSerGuardados.Add(Button7)
        ButtonsQPrecisamSerGuardados.Add(Button10)
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
        If Button9.Text = "Novo profissão" Then
            ProfissõesBindingSource.AddNew()
            iniciarAlteracoes()
        ElseIf Button9.Text = "Guardar" Then
            acabarAlteracoes()
            ProfissõesBindingSource.EndEdit()
            ProfissõesTableAdapter.Update(Industries_DanDataSet)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FuncionariosBindingSource.RemoveFilter()
        ResetarBotões_DeixarApenasEste(Button5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FuncionariosBindingSource.Filter = "DDEDE <= #" & Date.Today.ToString("MM/dd/yyyy") & "# AND (DDSDE IS NULL OR DDSDE > #" & Date.Today.ToString("MM/dd/yyyy") & "#)"
        ResetarBotões_DeixarApenasEste(Button6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub ResetarBotões_DeixarApenasEste(botao As Button)
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button10.Enabled = True
        botao.Enabled = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If ButtonRorEandC.Text = "Editar profissão" Then
            iniciarAlteracoes()
        Else
            ProfissõesBindingSource.EndEdit()
            ProfissõesTableAdapter.Update(Industries_DanDataSet)
            acabarAlteracoes()
        End If
    End Sub

    Private Sub Profissões_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        PMenu.Activate()
    End Sub
End Class