Public Class Departamentos

    Private Sub Departamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Diretores_de_Departamentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.Diretores_de_DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Diretores_de_Departamentos)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Departamentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Departamentos)

        Me.Width = Me.ClientSize.Width * 1.23

        DDCDateTimePicker.Format = DateTimePickerFormat.Custom
        DDCDateTimePicker.CustomFormat = "dd/MM/yyyy"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DepartamentosBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DepartamentosBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DepartamentosBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DepartamentosBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Confirm As MsgBoxResult
        Confirm = MsgBox("Tem certeza?" + vbCrLf + "O funcionario será notificado da demissão", MsgBoxStyle.YesNo, "Confirmação")

        If Confirm = MsgBoxResult.Yes Then
            Diretores_de_DepartamentosBindingSource.Current("DDF") = DateTime.Now
            MsgBox(Diretores_de_DepartamentosBindingSource.Current("DDF"))
            MsgBox(DateTime.Now.ToString()) ' Exibe a data atual no formato padrão
            Diretores_de_DepartamentosBindingSource.EndEdit()
            Diretores_de_DepartamentosTableAdapter.Update(Industries_DanDataSet.Diretores_de_Departamentos)
        End If

    End Sub

    Sub elegerDiretor()

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.FuncionariosTableAdapter.FillBy(Me.Industries_DanDataSet.Funcionarios)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.Text = "Remover" Then
            If MessageBox.Show("Tem certeza que deseja remover este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DepartamentosBindingSource.RemoveCurrent()
                DepartamentosTableAdapter.Update(Industries_DanDataSet.Departamentos)

                acabarAlteracoes()
            End If
        ElseIf Button8.Text = "Cancelar" Then
            TableAdapterManager.UpdateAll(Me.Industries_DanDataSet)
            DepartamentosBindingSource.CancelEdit()

            acabarAlteracoes()
        End If
    End Sub

    Sub iniciarAlteracoes()
        IDTextBox.ReadOnly = False
        NDDTextBox.ReadOnly = False
        DEDDTextBox.ReadOnly = False
        Button9.Text = "Salvar"
        Button8.Text = "Cancelar"
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub

    Sub acabarAlteracoes()
        IDTextBox.ReadOnly = True
        NDDTextBox.ReadOnly = True
        DEDDTextBox.ReadOnly = True
        Button9.Text = "Novo"
        Button8.Text = "Remover"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button9.Text = "Novo" Then
            DepartamentosBindingSource.AddNew()
            iniciarAlteracoes()
        ElseIf Button9.Text = "Salvar" Then
            Try
                DepartamentosBindingSource.EndEdit()
                DepartamentosTableAdapter.Update(Industries_DanDataSet.Departamentos)
                acabarAlteracoes()
                MessageBox.Show("Alterações salvas com sucesso.")
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro ao salvar as alterações: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub DepartamentosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles DepartamentosBindingSource.CurrentChanged
        'ACABAR QUANDO CHEGAR A CASA
    End Sub
End Class