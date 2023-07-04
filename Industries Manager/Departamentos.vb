Public Class Departamentos

    Dim cargoDiretorVazio As Boolean
    Dim registoDiretorSelecionado As DataRowView = Nothing
    Dim FuncionariosDataGridViewWidth, DepartamentosFormsWidth As Integer

    Private Sub Departamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Profissões' table. You can move, or remove it, as needed.
        Me.ProfissõesTableAdapter.Fill(Me.Industries_DanDataSet.Profissões)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Diretores_de_Departamentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.Diretores_de_DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Diretores_de_Departamentos)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Departamentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Departamentos)

        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)

        Me.Width = Me.ClientSize.Width * 1.23

        FuncionariosDataGridViewWidth = FuncionariosDataGridView.Width
        DepartamentosFormsWidth = Me.Width

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

        DepartamentosBindingSource.Position = DepartamentosBindingSource.Find("ID", InfoUser.UserDepID)

        MostrarSalariosOuNao()

        If (InfoUser.UserDepID = 2) OrElse (InfoUser.UserDepID = 3) OrElse (InfoUser.UserAdm) Then
            ButtonF.Enabled = True
            ButtonP.Enabled = True
            ButtonN.Enabled = True
            ButtonL.Enabled = True
            Button7.Visible = True
        Else
            ButtonF.Enabled = False
            ButtonP.Enabled = False
            ButtonN.Enabled = False
            ButtonL.Enabled = False
            Button7.Visible = False
        End If

        AtualizarInfosDiretor()
        CenterOnScreenForm()
        CarregarPaletaDeCores()
    End Sub

    Sub MostrarSalariosOuNao()
        If (InfoUser.UserDepDirectorYN AndAlso InfoUser.UserDepID = DepartamentosBindingSource.Current("ID")) OrElse {5, 3}.Contains(InfoUser.UserDepID) Then
            FuncionariosDataGridView.Columns(4).Visible = True
            FuncionariosDataGridView.Width = FuncionariosDataGridViewWidth
            Me.Width = DepartamentosFormsWidth
        Else
            FuncionariosDataGridView.Columns(4).Visible = False
            FuncionariosDataGridView.Width = FuncionariosDataGridViewWidth - 95
            Me.Width = DepartamentosFormsWidth - 95 + 10
        End If
    End Sub

    Sub AtualizarBotoesDiretor()

        If InfoUser.UserDepID = 2 OrElse InfoUser.UserDepID = 3 OrElse InfoUser.UserDepDirectorYN OrElse InfoUser.UserAdm Then
            If registoDiretorSelecionado IsNot Nothing Then
                Try

                    If cargoDiretorVazio Then
                        Button7.Text = "Eleger diretor"
                    ElseIf IsDBNull(registoDiretorSelecionado("DDF")) OrElse registoDiretorSelecionado("DDF") >= Today Then
                        Button7.Text = "Despedir diretor"
                    End If

                    Button7.Visible = True

                    If InfoUser.UserDepDirectorYN And Not cargoDiretorVazio AndAlso InfoUser.UserDepID = DepartamentosBindingSource.Current("ID") Then
                        Button7.Text = "Demitir-me"
                    End If

                    Debug.WriteLine("UserDepDirectorID: " & InfoUser.UserDepDirectorID)
                    Debug.WriteLine("Diretores....Current(""ID""): " & Diretores_de_DepartamentosBindingSource.Current("ID"))
                    Debug.WriteLine("registoDiretorSelecionado(""ID""): " & registoDiretorSelecionado("ID"))
                    Debug.WriteLine("")

                    If InfoUser.UserDepID = DepartamentosBindingSource.Current("ID") OrElse InfoUser.UserDepID = 3 OrElse InfoUser.UserAdm Then
                        Button7.Enabled = True
                    Else
                        Button7.Enabled = False
                    End If
                Catch
                    Button7.Text = "Eleger diretor"
                End Try
            Else
                Button7.Text = "Eleger diretor"
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DepartamentosBindingSource.MoveFirst()
        AtualizarInfosDiretor()
        MostrarSalariosOuNao()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DepartamentosBindingSource.MovePrevious()
        AtualizarInfosDiretor()
        MostrarSalariosOuNao()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DepartamentosBindingSource.MoveNext()
        AtualizarInfosDiretor()
        MostrarSalariosOuNao()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DepartamentosBindingSource.MoveLast()
        AtualizarInfosDiretor()
        MostrarSalariosOuNao()
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
        Diretores_de_DepartamentosTableAdapter.Dispose()
        Diretores_de_DepartamentosTableAdapter.Fill(Industries_DanDataSet.Diretores_de_Departamentos)
        Dim idDepartamento As Integer = CInt(DepartamentosBindingSource.Current("ID"))

        Dim ultimoRegistro As DataRowView = Nothing
        Debug.WriteLine("")

        For Each item As DataRowView In Diretores_de_DepartamentosBindingSource

            Debug.WriteLine("1: " & (CInt(item("ID_Departamento")) = idDepartamento))
            Debug.WriteLine("2: " & (Not DBNull.Value.Equals(item("DDC")) AndAlso Date.Parse(item("DDC")) <= Now))
            Debug.WriteLine("3: " & (Not DBNull.Value.Equals(item("DDF")) AndAlso Date.Parse(item("DDF")) > Now))
            Debug.WriteLine("4: " & (DBNull.Value.Equals(item("DDF"))))
            Debug.WriteLine("DDF: " & item("DDF"))
            Diretores_de_DepartamentosBindingSource.Position = Diretores_de_DepartamentosBindingSource.Find("ID", item("ID_Departamento"))
            Debug.WriteLine("DDF: " & Diretores_de_DepartamentosBindingSource.Current("DDF"))
            Debug.WriteLine("1 e 2: " & (CInt(item("ID_Departamento")) = idDepartamento And Not DBNull.Value.Equals(item("DDC")) AndAlso Date.Parse(item("DDC")) <= Now))
            Debug.WriteLine("3 ou 4: " & (Not DBNull.Value.Equals(item("DDF")) AndAlso Date.Parse(item("DDF")) > Now Or DBNull.Value.Equals(item("DDF"))))
            Debug.WriteLine("(1 e 2) e (3 ou 4): " & ((CInt(item("ID_Departamento")) = idDepartamento And Not DBNull.Value.Equals(item("DDC")) AndAlso Date.Parse(item("DDC")) <= Now) And (Not DBNull.Value.Equals(item("DDF")) AndAlso Date.Parse(item("DDF")) > Now Or DBNull.Value.Equals(item("DDF")))))
            Debug.WriteLine("")

            If CInt(item("ID_Departamento")) = idDepartamento AndAlso
                (Not DBNull.Value.Equals(item("DDC")) AndAlso Date.Parse(item("DDC")) <= Now) AndAlso
                ((Not DBNull.Value.Equals(item("DDF")) AndAlso Date.Parse(item("DDF")) > Now) OrElse
                (DBNull.Value.Equals(item("DDF")))) Then
                ultimoRegistro = item
            End If
        Next

        If ultimoRegistro IsNot Nothing Then

            FuncionariosBindingSource1.Position = FuncionariosBindingSource1.Find("ID", ultimoRegistro("ID_Funcionario"))

            If FuncionariosBindingSource1.Position <> -1 Then
                Debug.WriteLine("ID: " & FuncionariosBindingSource1.Current("ID"))

                DDDTextBox.Text = ultimoRegistro("DDD")
                NomeDiretorTextBox.Text = FuncionariosBindingSource1.Current("Nome") & " " & FuncionariosBindingSource1.Current("Sobrenome")
                DDCDateTimePicker.Value = Date.Parse(ultimoRegistro("DDC"))


                Dim dataAtual As Date = Today()
                Dim dataAnterior As Date = CDate(ultimoRegistro("DDC"))

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

                If noCargoJaHaString = "" Then
                    TextBox1.Visible = False
                    Label3.Visible = False
                Else
                    TextBox1.Text = noCargoJaHaString
                    TextBox1.Visible = True
                    Label3.Visible = True
                End If



            End If
            cargoDiretorVazio = False

            registoDiretorSelecionado = ultimoRegistro

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.Text = "Eleger diretor" Then
            ElegerDiretor.Show()
            ElegerDiretor.DepIDLoc = DepartamentosBindingSource.Current("ID")
        ElseIf Button7.Text = "Despedir diretor" Then
            Diretores_de_DepartamentosBindingSource.Current("DDF") = Today

            If MsgBox("Enviar email de despedimento?", vbYesNo, "Informar funcionário") = MsgBoxResult.Yes Then
                Dim motivo As String
                If IsDBNull(registoDiretorSelecionado("DDF")) Then
                    motivo = InputBox("Qual o motivo do despedimento do Diretor? (Opcional)")
                Else
                    motivo = InputBox("Qual o motivo do despedimento antecipado do Diretor? (Opcional)")
                End If

                Dim registoDiretorFuncionarioDetalhesSelecionado As DataRowView

                For Each item In FuncionariosBindingSource1

                    If item("ID") = registoDiretorSelecionado("ID_Funcionario") Then

                        registoDiretorFuncionarioDetalhesSelecionado = item

                    End If

                Next


                EnviarMensagemAutomaticaDespedimento(InfoUser.UserFirstName, InfoUser.UserLastName, registoDiretorFuncionarioDetalhesSelecionado("Email"), registoDiretorFuncionarioDetalhesSelecionado("Nome"), registoDiretorFuncionarioDetalhesSelecionado("Sobrenome"), motivo)
            End If

            FuncionariosBindingSource1.RemoveFilter()
            Diretores_de_DepartamentosBindingSource.Filter = "ID = " & registoDiretorSelecionado("ID")

            Diretores_de_DepartamentosBindingSource.Current("DDF") = Today
            Diretores_de_DepartamentosBindingSource.EndEdit()
            Diretores_de_DepartamentosBindingSource.RemoveFilter()
            Me.Diretores_de_DepartamentosTableAdapter.Update(Me.Industries_DanDataSet)
            DepartamentosTableAdapter.Update(Industries_DanDataSet)

            AtualizarInfosDiretor()


        ElseIf Button7.Text = "Demitir-me" Then 'Antenção este e o outro de cima são diferentes

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

            Diretores_de_DepartamentosBindingSource.Position = Diretores_de_DepartamentosBindingSource.Find("ID", registoDiretorSelecionado("ID"))
            Diretores_de_DepartamentosBindingSource.Current("DDF") = Today
            Diretores_de_DepartamentosBindingSource.EndEdit()

            Dim departamentoAtual As Integer
            departamentoAtual = DepartamentosBindingSource.Position
            Diretores_de_DepartamentosTableAdapter.Update(Industries_DanDataSet)
            DepartamentosTableAdapter.Update(Industries_DanDataSet)
            InfoUser.UserDepDirectorYN = False
            InfoUser.UserDepDirectorID = 0

            If MsgBox("Deseja eleger um subsituto para o seu cargo?", vbYesNo, "Eleger novo diretor") = MsgBoxResult.Yes Then
                ElegerDiretor.Show()
                ElegerDiretor.DepIDLoc = DepartamentosBindingSource.Current("ID")
            End If

            AtualizarInfosDiretor()
        End If
    End Sub

    Private Sub Departamentos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        PMenu.Activate()
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        iniciarAlteracoes()
    End Sub

    Private Sub Departamentos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        PMenu.Activate()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        HistoricoDiretoresDepartamentos.Show()
        HistoricoDiretoresDepartamentos.DepIDLoc = DepartamentosBindingSource.Current("ID")
    End Sub
End Class