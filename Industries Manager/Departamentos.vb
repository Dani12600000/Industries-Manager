Public Class Departamentos

    Dim cargoDiretorVazio As Boolean

    Private Sub Departamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Profissões' table. You can move, or remove it, as needed.
        Me.ProfissõesTableAdapter.Fill(Me.Industries_DanDataSet.Profissões)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Diretores_de_Departamentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.Diretores_de_DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Diretores_de_Departamentos)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Departamentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Departamentos)

        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)

        Me.Width = Me.ClientSize.Width * 1.24

        FuncionariosDataGridView.Columns(4).DefaultCellStyle.Format = "#,##0.00€"

        Formulario = Me
        ButtonNandG = Button9
        ButtonRorEandC = Button8
        ButtonF = Button1
        ButtonP = Button2
        ButtonN = Button3
        ButtonL = Button4
        ButtonE = Button10

        IgnoreTextBoxs.Add(DDDTextBox)
        IgnoreTextBoxs.Add(NomeDiretorTextBox)
        IgnoreTextBoxs.Add(IDTextBox)
        IgnoreTextBoxs.Add(TextBox1)
        IgnoreDateTimePickers.Add(DDCDateTimePicker)

        Debug.WriteLine("ID_Departamento : " & InfoUser.UserDepID)
        DepartamentosBindingSource.Position = DepartamentosBindingSource.Find("ID", InfoUser.UserDepID)

        MostrarSalariosOuNao()

        If InfoUser.UserDepID = 2 Then
            ButtonF.Enabled = True
            ButtonP.Enabled = True
            ButtonN.Enabled = True
            ButtonL.Enabled = True
        Else
            ButtonF.Enabled = False
            ButtonP.Enabled = False
            ButtonN.Enabled = False
            ButtonL.Enabled = False
        End If

        AtualizarInfosDiretor()
        CenterOnScreenForm()
    End Sub

    Sub MostrarSalariosOuNao()
        If InfoUser.UserDepDirectorYN OrElse {5, 3}.Contains(InfoUser.UserDepID) Then
            FuncionariosDataGridView.Columns(4).Visible = True
        Else
            FuncionariosDataGridView.Columns(4).Visible = False
            FuncionariosDataGridView.Width = FuncionariosDataGridView.Width - 95
            Me.Width = Me.ClientSize.Width - 95 + 10
        End If
    End Sub

    '@TODO: Acabar este sub
    Sub AtualizarBotoesDiretor()

        If InfoUser.UserDepID = 2 Or InfoUser.UserDepDirectorYN Then
            Debug.WriteLine("cargoDiretorVazio: " & cargoDiretorVazio)

            If cargoDiretorVazio OrElse Diretores_de_DepartamentosBindingSource.Current("DDC") <= Today Then
                Button7.Text = "Eleger diretor"
            ElseIf Diretores_de_DepartamentosBindingSource.Current("DDF") <= Today Then
                Button7.Text = "Despedir diretor"
            End If

            Button7.Visible = True

            If Not cargoDiretorVazio AndAlso InfoUser.UserDepDirectorID = Diretores_de_DepartamentosBindingSource.Current("ID") Then
                Button7.Text = "Demitir-me"
            End If

        Else

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DepartamentosBindingSource.MoveFirst()
        AtualizarInfosDiretor()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DepartamentosBindingSource.MovePrevious()
        AtualizarInfosDiretor()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DepartamentosBindingSource.MoveNext()
        AtualizarInfosDiretor()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DepartamentosBindingSource.MoveLast()
        AtualizarInfosDiretor()
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

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.Text = "Remover" Then
            If MessageBox.Show("Tem certeza que deseja remover este departamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DepartamentosBindingSource.RemoveCurrent()
                DepartamentosTableAdapter.Update(Industries_DanDataSet.Departamentos)
                AtualizarInfosDiretor()
            End If
        ElseIf Button8.Text = "Cancelar" Then
            TableAdapterManager.UpdateAll(Me.Industries_DanDataSet)
            DepartamentosBindingSource.CancelEdit()
            AtualizarInfosDiretor()
            acabarAlteracoes()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button9.Text = "Novo" Then
            DepartamentosBindingSource.AddNew()
            AtualizarInfosDiretor()
            iniciarAlteracoes()
        ElseIf Button9.Text = "Guardar" Then
            Try
                DepartamentosBindingSource.EndEdit()
                DepartamentosTableAdapter.Update(Industries_DanDataSet.Departamentos)
                acabarAlteracoes()
                MessageBox.Show("Departamento salvo com sucesso.")
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro ao salvar o departamentos: " & ex.Message)
            End Try
        End If
    End Sub

    Sub AtualizarInfosDiretor()
        Dim idDepartamento As Integer = CInt(DepartamentosBindingSource.Current("ID"))

        Dim ultimoRegistro As DataRowView = Nothing

        For Each item As DataRowView In Diretores_de_DepartamentosBindingSource



            If CInt(item("ID_Departamento")) = idDepartamento AndAlso
            (Not DBNull.Value.Equals(item("DDC")) AndAlso Date.Parse(item("DDC")) <= Now) AndAlso
            ((Not DBNull.Value.Equals(item("DDF")) AndAlso Date.Parse(item("DDF")) > Now) OrElse
            (DBNull.Value.Equals(item("DDF")))) Then

                ultimoRegistro = item
            End If
        Next

        If ultimoRegistro IsNot Nothing Then
            ' O último registro encontrado que atende ao critério
            Debug.WriteLine("ID do último registro: " & ultimoRegistro("ID"))
            Debug.WriteLine("ID_Funcionario do último registro: " & ultimoRegistro("ID_Funcionario"))

            Debug.WriteLine("ultimoRegistro : " & ultimoRegistro("ID"))

            FuncionariosBindingSource1.Find("ID", ultimoRegistro("ID_Funcionario"))

            If FuncionariosBindingSource1.Position <> -1 Then
                Debug.WriteLine("ID: " & FuncionariosBindingSource1.Current("ID"))

                DDDTextBox.Text = Diretores_de_DepartamentosBindingSource.Current("DDD")
                NomeDiretorTextBox.Text = FuncionariosBindingSource1.Current("Nome") & " " & FuncionariosBindingSource1.Current("Sobrenome")
                DDCDateTimePicker.Value = Date.Parse(Diretores_de_DepartamentosBindingSource.Current("DDC"))


                Dim dataAtual As Date = Today()
                Dim dataAnterior As Date = CDate(Diretores_de_DepartamentosBindingSource.Current("DDC"))

                Dim noCargoJaHaDateInterval As TimeSpan = dataAtual - dataAnterior

                Dim noCargoJaHaString As String = ""

                Dim anos As Integer = noCargoJaHaDateInterval.Days \ 365
                Dim meses As Integer = (noCargoJaHaDateInterval.Days Mod 365) \ 30
                Dim dias As Integer = (noCargoJaHaDateInterval.Days Mod 365) Mod 30

                If anos > 0 Then
                    noCargoJaHaString = anos.ToString() & " ano"
                    If anos > 1 Then
                        noCargoJaHaString &= "s"
                    End If
                End If

                If meses > 0 Then
                    If noCargoJaHaString <> "" Then
                        noCargoJaHaString &= ", "
                    End If
                    noCargoJaHaString &= meses.ToString() & " mês"
                    If meses > 1 Then
                        noCargoJaHaString &= "es"
                    End If
                End If

                If dias > 0 Then
                    Dim semanas As Integer = dias \ 7
                    Dim diasRestantes As Integer = dias Mod 7

                    If noCargoJaHaString <> "" Then
                        noCargoJaHaString &= " e "
                    End If

                    If semanas > 0 Then
                        noCargoJaHaString &= semanas.ToString() & " semana"
                        If semanas > 1 Then
                            noCargoJaHaString &= "s"
                        End If
                        If diasRestantes > 0 And meses = 0 Then
                            noCargoJaHaString &= " e " & diasRestantes.ToString() & " dia"
                            If diasRestantes > 1 Then
                                noCargoJaHaString &= "s"
                            End If
                        End If
                    Else
                        noCargoJaHaString &= dias.ToString() & " dia"
                        If dias > 1 Then
                            noCargoJaHaString &= "s"
                        End If
                    End If
                End If

                TextBox1.Text = noCargoJaHaString
                Debug.WriteLine("No cargo já há: " & noCargoJaHaString)



            End If
            cargoDiretorVazio = False

            Debug.WriteLine("Acabou")
        Else
            ' Nenhum registro encontrado que atenda ao critério
            Debug.WriteLine("Nenhum registro encontrado que atenda ao critério.")
            DDDTextBox.Text = ""
            NomeDiretorTextBox.Text = ""
            DDCDateTimePicker.Value = Today
            TextBox1.Text = ""
            cargoDiretorVazio = True
        End If

        AtualizarBotoesDiretor()
    End Sub

    Sub ElegerNovoDiretorDeNovoImediatamente()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.Text = "Eleger diretor" Then

        ElseIf Button7.Text = "Despedir diretor" Then
            Diretores_de_DepartamentosBindingSource.Current("DDF") = Today
            If MsgBox("Enviar email de despedimento?", vbYesNo, "Informar funcionário") = MsgBoxResult.Yes Then
                '@TODO: Depois meter o codigo
            End If
        ElseIf Button7.Text = "Demitir-me" Then 'Antenção este e o outro de cima são diferentes
            Diretores_de_DepartamentosBindingSource.Current("DDF") = Today



            Dim idFuncionario As Integer = Diretores_de_DepartamentosBindingSource.Current("ID_Funcionario")
            FuncionariosBindingSource1.Position = FuncionariosBindingSource1.Find("ID", idFuncionario)
            Dim nomeCompleto As String = FuncionariosBindingSource1.Current("Nome") & " " & FuncionariosBindingSource1.Current("Sobrenome")
            Dim partesNome() As String = nomeCompleto.Split(" "c)

            If MsgBox("Enviar email de demissão?", vbYesNo, "Informar empresa") = MsgBoxResult.Yes Then
                Dim departamentosANotificar As List(Of String) = New List(Of String)

                departamentosANotificar.Add(InfoEnterprise.EmailDiretorDepartamento(1)) ' Administração
                departamentosANotificar.Add(InfoEnterprise.EmailDiretorDepartamento(2)) ' Recursos Humanos

                EnviarMensagemAutomaticaDemissao(InfoUser.UserFirstName, InfoUser.UserLastName, departamentosANotificar, partesNome(0), partesNome(partesNome.Length - 1))
            End If
            If MsgBox("Deseja eleger um subsituto para o seu cargo?", vbYesNo, "Eleger novo diretor") Then
                ElegerDiretor.Show()
            End If
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Departamentos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        PMenu.Activate()
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        iniciarAlteracoes()
    End Sub
End Class