Imports System.Globalization
Imports System.Reflection
Imports Industries_Manager.Industries_DanDataSetTableAdapters

Public Class Funcionarios

    Dim DespColor, ContColor As Color
    Dim SM As Double 'Salario Minimo
    Dim botaoEnabledArray As Boolean()

    Private Sub Funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Diretores_de_Departamentos' table. You can move, or remove it, as needed.
        Me.Diretores_de_DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Diretores_de_Departamentos)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Departamentos' table. You can move, or remove it, as needed.
        Me.DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Departamentos)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Profissões' table. You can move, or remove it, as needed.
        Me.ProfissõesTableAdapter.Fill(Me.Industries_DanDataSet.Profissões)

        'TODO: This line of code loads data into the 'Industries_DanDataSet.Login_Funcionario' table. You can move, or remove it, as needed.
        Me.Login_FuncionarioTableAdapter.Fill(Me.Industries_DanDataSet.Login_Funcionario)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Funcionarios' table. You can move, or remove it, as needed.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)

        FotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom

        SortLogins()

        If UserAdm Then
            Button11.Visible = True
        Else
            Button11.Visible = False
        End If

        ButtonF = Button1
        ButtonP = Button2
        ButtonN = Button3
        ButtonL = Button4
    End Sub

    Sub SortLogins()
        Login_FuncionarioDataGridView.Sort(Login_FuncionarioDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Sub VerificarContrartarDespedir()

        Debug.WriteLine("FuncionariosBindingSource.Current(""ID_Departamento""): " & FuncionariosBindingSource.Current("ID_Departamento"))
        Debug.WriteLine("FuncionariosBindingSource.Current(""ID_Profissão""): " & FuncionariosBindingSource.Current("ID_Profissão"))

        DepartamentosBindingSource.Position = DepartamentosBindingSource.Find("ID", FuncionariosBindingSource.Current("ID_Departamento"))
        ProfissõesBindingSource.Position = ProfissõesBindingSource.Find("ID", FuncionariosBindingSource.Current("ID_Profissão"))

        Debug.WriteLine("DepartamentosBindingSource.Position: " & DepartamentosBindingSource.Position)
        Debug.WriteLine("ProfissõesBindingSource.Position: " & ProfissõesBindingSource.Position)

        ID_DepartamentoComboBox.SelectedIndex = DepartamentosBindingSource.Position
        ID_ProfissãoComboBox.SelectedIndex = ProfissõesBindingSource.Position

        Debug.WriteLine("FuncionariosBindingSource.Current(""SI""): " & FuncionariosBindingSource.Current("SI"))
        If IsDBNull(FuncionariosBindingSource.Current("SI")) OrElse FuncionariosBindingSource.Current("SI") < 10 Then
            SINumericUpDown.Value = Double.Parse(740.83)
            Debug.WriteLine("Teste")
        End If


        Debug.WriteLine("DDEDE : " & FuncionariosBindingSource.Current("DDEDE").ToString)
        Debug.WriteLine("DDSDE : " & FuncionariosBindingSource.Current("DDSDE").ToString)
        Debug.WriteLine("DDEDE Vazio : " & FuncionariosBindingSource.Current("DDEDE").ToString.Equals(""))
        Debug.WriteLine("DDSDE Vazio : " & FuncionariosBindingSource.Current("DDSDE").ToString.Equals(""))

        If FuncionariosBindingSource.Current("DDEDE").ToString.Equals("") Then
            Button5.Text = "Contratar"
            Button5.BackColor = ContColor
            ID_ProfissãoComboBox.Enabled = True
            ID_DepartamentoComboBox.Enabled = True
            SINumericUpDown.Enabled = True
            Button8.Enabled = False
        ElseIf Not FuncionariosBindingSource.Current("DDEDE").ToString.Equals("") And FuncionariosBindingSource.Current("DDSDE").ToString.Equals("") Then
            Button5.Text = "Despedir"
            Button5.BackColor = DespColor
            ID_ProfissãoComboBox.Enabled = False
            ID_DepartamentoComboBox.Enabled = False
            SINumericUpDown.Enabled = False
            Button8.Enabled = True
        ElseIf Not FuncionariosBindingSource.Current("DDEDE").ToString.Equals("") And Not FuncionariosBindingSource.Current("DDSDE").ToString.Equals("") Then
            Button5.Text = "Recontratar"
            Button5.BackColor = ContColor
            ID_ProfissãoComboBox.Enabled = True
            ID_DepartamentoComboBox.Enabled = True
            SINumericUpDown.Enabled = True
            Button8.Enabled = False
        End If

        If FuncionariosBindingSource.Current("DDEDE").ToString.Equals("") Then
            DDEDEDateTimePicker.Visible = False
            DDEDELabel.Visible = False
        Else
            DDEDEDateTimePicker.Visible = True
            DDEDELabel.Visible = True
        End If
        If FuncionariosBindingSource.Current("DDSDE").ToString.Equals("") Then
            DDSDEDateTimePicker.Visible = False
            DDSDELabel.Visible = False
        Else
            DDSDEDateTimePicker.Visible = True
            DDSDELabel.Visible = True
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FuncionariosBindingSource.MoveNext()

        VerificarContrartarDespedir()
        SortLogins()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FuncionariosBindingSource.MoveLast()

        VerificarContrartarDespedir()
        SortLogins()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FuncionariosBindingSource.MovePrevious()

        VerificarContrartarDespedir()
        SortLogins()

    End Sub

    Private Sub Funcionarios_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        DespColor = Button6.BackColor
        ContColor = Button5.BackColor

        VerificarContrartarDespedir()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AbrirOutlook(EmailTextBox.Text, InfoUser.UserName)
    End Sub

    Sub AbrirOutlook(destinatario As String, nomeRemetente As String)
        Try
            ' Criar uma instância do processo do Outlook
            Dim outlookProcess As New Process()

            ' Definir o nome do processo como "Outlook"
            outlookProcess.StartInfo.FileName = "Outlook"

            ' Adicionar a assinatura ao corpo do e-mail
            Dim assinatura As String = vbCrLf & vbCrLf & vbCrLf & "Atenciosamente," & vbCrLf & nomeRemetente

            ' Adicionar o destinatário e a assinatura aos argumentos de linha de comando
            outlookProcess.StartInfo.Arguments = "/c ipm.note /m """ & destinatario & "?body=" & assinatura & """"

            ' Iniciar o processo
            outlookProcess.Start()
        Catch ex As Exception
            Console.WriteLine("Erro ao abrir o Outlook: " & ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Debug.WriteLine("SINumericUpDown.Value : " & SINumericUpDown.Value)

        If Button5.Text = "Contratar" Then
            If MsgBox("Deseja enviar um e-mail a informa-lo?", vbYesNo, "Enviar e-mail") = vbYes Then
                EnviarMensagemAutomaticaContratacao(InfoUser.UserName, EmailTextBox.Text, NomeTextBox.Text, SobrenomeTextBox.Text, ProfissõesBindingSource.Current("Profissao"), SINumericUpDown.Value)
            End If

            FuncionariosBindingSource.Current("ID_Profissão") = ProfissõesBindingSource.Current("ID")
            FuncionariosBindingSource.Current("ID_Departamento") = DepartamentosBindingSource.Current("ID")
            FuncionariosBindingSource.Current("Aprovacao") = True
            FuncionariosBindingSource.Current("DDEDE") = Today()

            FuncionariosBindingSource.EndEdit()
            FuncionariosTableAdapter.Update(Industries_DanDataSet.Funcionarios)

            MsgBox("Contradado", vbInformation)

        ElseIf Button5.Text = "Despedir" Then
            If MsgBox("Tem certeza que deseja despedir o funcionario nº" & FuncionariosBindingSource.Current("ID") & "?", vbYesNo, "Confirmação") = vbYes Then
                If MsgBox("Deseja enviar um e-mail a informa-lo?", vbYesNo, "Enviar e-mail") = vbYes Then
                    EnviarMensagemAutomaticaDespedimento(InfoUser.UserName, EmailTextBox.Text, InputBox("Qual o motivo para o despedimento do mesmo? (opcional)"))
                End If

                FuncionariosBindingSource.Current("Aprovacao") = False
                FuncionariosBindingSource.Current("DDSDE") = Today()

                FuncionariosBindingSource.EndEdit()
                FuncionariosTableAdapter.Update(Industries_DanDataSet.Funcionarios)

                MsgBox("Despedido", vbInformation)

            End If

        ElseIf Button5.Text = "Recontratar" Then

            If MsgBox("Deseja enviar um e-mail a informa-lo?", vbYesNo, "Enviar e-mail") = vbYes Then
                EnviarMensagemAutomaticaRecontratacao(InfoUser.UserName, EmailTextBox.Text, ID_ProfissãoComboBox.Text, SINumericUpDown.Value)
            End If

            FuncionariosBindingSource.Current("Aprovacao") = True
            FuncionariosBindingSource.Current("DDEDE") = Today()
            FuncionariosBindingSource.Current("DDSDE") = DBNull.Value

            FuncionariosBindingSource.EndEdit()
            FuncionariosTableAdapter.Update(Industries_DanDataSet.Funcionarios)

            MsgBox("Recontratado", vbInformation)

        End If

        VerificarContrartarDespedir()
    End Sub

    Sub EnviarMensagemAutomaticaDespedimento(nomeRemetente As String, destinatario As String, motivo As String)
        Try
            Dim assunto As String = "Despedimento das Industries Dan"

            ' Criar uma instância do processo do Outlook
            Dim outlookProcess As New Process()

            ' Definir o nome do processo como "Outlook"
            outlookProcess.StartInfo.FileName = "Outlook"

            ' Formatar a mensagem pré-definida
            Dim mensagemPredefinida As String = "Prezado(a) " & NomeTextBox.Text & " " & SobrenomeTextBox.Text & "," & vbCrLf & vbCrLf &
                                            "É por este meio que o vimos informar que está a ser despedido com efeito imediato" & vbCrLf

            ' Adicionar o motivo à mensagem pré-definida, se não estiver vazio
            If Not String.IsNullOrEmpty(motivo) Then
                mensagemPredefinida &= "Motivo: " & motivo & vbCrLf
            End If

            mensagemPredefinida &= vbCrLf & vbCrLf & "Atenciosamente," & vbCrLf & nomeRemetente

            ' Adicionar o destinatário, assunto e mensagem pré-definida aos argumentos de linha de comando
            outlookProcess.StartInfo.Arguments = "/c ipm.note /m """ & destinatario & "?subject=" & assunto & "&body=" & mensagemPredefinida & """"

            ' Iniciar o processo
            outlookProcess.Start()
        Catch ex As Exception
            Console.WriteLine("Erro ao abrir o Outlook: " & ex.Message)
        End Try
    End Sub

    Sub EnviarMensagemAutomaticaContratacao(nomeRemetente As String, emailDestinatario As String, nomeDestinatario As String, sobrenomeDestinario As String, cargo As String, salario As Double)
        Try
            Dim assunto As String = "Contratação nas Industries Dan"

            ' Criar uma instância do processo do Outlook
            Dim outlookProcess As New Process()

            ' Definir o nome do processo como "Outlook"
            outlookProcess.StartInfo.FileName = "Outlook"

            ' Verificar se o salário é igual a zero
            Dim mensagemSalario As String
            If salario = 0 Then
                mensagemSalario = "Ainda estamos a ajustar o seu salário."
            Else
                mensagemSalario = "Seu salário será de " & salario.ToString("#,##0.00") & "€ por mês."
            End If

            ' Obter o dia da semana próximo
            Dim hoje As DateTime = DateTime.Today
            Dim proximoDia As DateTime = hoje.AddDays(1)

            While proximoDia.DayOfWeek = DayOfWeek.Saturday Or proximoDia.DayOfWeek = DayOfWeek.Sunday
                proximoDia = proximoDia.AddDays(1)
            End While

            Dim diaDaSemana As String

            If proximoDia = hoje.AddDays(1) Then
                diaDaSemana = "amanhã"
            Else
                diaDaSemana = "próxima " & proximoDia.ToString("dddd")
            End If

            ' Formatar a mensagem pré-definida
            Dim mensagemPredefinida As String = "Prezado(a) " & nomeDestinatario & " " & sobrenomeDestinario.Text & "," & vbCrLf & vbCrLf &
                                        "Temos o prazer de informar que você foi contratado(a) para o cargo de " & cargo & "." & vbCrLf &
                                        mensagemSalario & vbCrLf & vbCrLf &
                                        "Começa " & diaDaSemana & ", dia " & proximoDia.ToString("d") & "." & vbCrLf & vbCrLf &
                                        "Estamos ansiosos para tê-lo(a) em nossa equipe!" & vbCrLf & vbCrLf &
                                        "Atenciosamente," & vbCrLf & nomeRemetente

            ' Adicionar o destinatário, assunto e mensagem pré-definida aos argumentos de linha de comando
            outlookProcess.StartInfo.Arguments = "/c ipm.note /m """ & emailDestinatario & "?subject=" & assunto & "&body=" & mensagemPredefinida & """"

            ' Iniciar o processo
            outlookProcess.Start()
        Catch ex As Exception
            Console.WriteLine("Erro ao abrir o Outlook: " & ex.Message)
        End Try
    End Sub

    Sub EnviarMensagemAutomaticaRecontratacao(nomeRemetente As String, destinatario As String, cargo As String, salario As Double)
        Try
            Dim assunto As String = "Recontratação nas Industries Dan"

            ' Criar uma instância do processo do Outlook
            Dim outlookProcess As New Process()

            ' Definir o nome do processo como "Outlook"
            outlookProcess.StartInfo.FileName = "Outlook"

            ' Verificar se o salário é igual a zero
            Dim mensagemSalario As String
            If salario = 0 Then
                mensagemSalario = "Ainda estamos a ajustar o seu salário."
            Else
                mensagemSalario = "Seu salário será de " & salario.ToString("#,##0.00") & "€ por mês."
            End If

            ' Obter o dia da semana próximo
            Dim hoje As DateTime = DateTime.Today
            Dim proximoDia As DateTime = hoje.AddDays(1)

            While proximoDia.DayOfWeek = DayOfWeek.Saturday Or proximoDia.DayOfWeek = DayOfWeek.Sunday
                proximoDia = proximoDia.AddDays(1)
            End While

            Dim diaDaSemana As String

            If proximoDia = hoje.AddDays(1) Then
                diaDaSemana = "amanhã"
            Else
                diaDaSemana = "próxima " & proximoDia.ToString("dddd")
            End If

            ' Formatar a mensagem pré-definida
            Dim mensagemPredefinida As String = "Prezado(a) " & destinatario & "," & vbCrLf & vbCrLf &
                                        "Temos o prazer de informar que você foi recontratado(a) para o cargo de " & cargo & "." & vbCrLf &
                                        mensagemSalario & vbCrLf & vbCrLf &
                                        "Começa " & diaDaSemana & ", dia " & proximoDia.ToString("d") & "." & vbCrLf & vbCrLf &
                                        "Bem-vindo(a) de volta à nossa equipe!" & vbCrLf & vbCrLf &
                                        "Atenciosamente," & vbCrLf & nomeRemetente

            ' Adicionar o destinatário, assunto e mensagem pré-definida aos argumentos de linha de comando
            outlookProcess.StartInfo.Arguments = "/c ipm.note /m """ & destinatario & "?subject=" & assunto & "&body=" & mensagemPredefinida & """"

            ' Iniciar o processo
            outlookProcess.Start()
        Catch ex As Exception
            Console.WriteLine("Erro ao abrir o Outlook: " & ex.Message)
        End Try
    End Sub

    Sub EnviarMensagemAutomaticaAtualizacaoSalario(nomeRemetente As String, destinatario As String, novoSalario As Double)
        Try

            Dim assunto As String = "Alteração salarial"

            ' Criar uma instância do processo do Outlook
            Dim outlookProcess As New Process()

            ' Definir o nome do processo como "Outlook"
            outlookProcess.StartInfo.FileName = "Outlook"

            ' Formatar a mensagem pré-definida
            Dim mensagemPredefinida As String = "Prezado(a) " & destinatario & "," & vbCrLf & vbCrLf &
                                            "Gostaríamos de informar que seu salário foi atualizado." & vbCrLf &
                                            "O novo valor do seu salário é de " & novoSalario.ToString("#,##0.00") & " por mês." & vbCrLf & vbCrLf &
                                            "Se tiver alguma dúvida, por favor, entre em contato conosco." & vbCrLf & vbCrLf &
                                            "Atenciosamente," & vbCrLf & nomeRemetente

            ' Adicionar o destinatário, assunto e mensagem pré-definida aos argumentos de linha de comando
            outlookProcess.StartInfo.Arguments = "/c ipm.note /m """ & destinatario & "?subject=" & assunto & "&body=" & mensagemPredefinida & """"

            ' Iniciar o processo
            outlookProcess.Start()
        Catch ex As Exception
            Console.WriteLine("Erro ao abrir o Outlook: " & ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MsgBox("Deseja mesmo resetar a palavra-passe desse funcionario?", vbYesNo, "Tem a certeza?") = vbYes Then

            FuncionariosBindingSource.Current("Pass") = "123456Ab"
            Clipboard.SetText(FuncionariosBindingSource.Current("Pass"))

            MsgBox("Palavra-passe foi restaurada e copiada para a sua clipboard" & vbCrLf & "Pode entrar num chat com essa pessoa e clicar 'Ctrl+V' para colar a nova passe temporaria")

            FuncionariosBindingSource.EndEdit()
            FuncionariosTableAdapter.Update(Industries_DanDataSet.Funcionarios)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.Text = "Editar" Then

            iniciarAlteracaoUnica(Button8, SINumericUpDown)

        ElseIf Button8.Text = "Guardar" Then

            FuncionariosBindingSource.EndEdit()
            FuncionariosTableAdapter.Update(Industries_DanDataSet.Funcionarios)

            If MsgBox("Deseja enviar um e-mail a informa-lo?", vbYesNo, "Enviar e-mail") = vbYes Then
                EnviarMensagemAutomaticaAtualizacaoSalario(InfoUser.UserName, FuncionariosBindingSource.Current("Email"), SINumericUpDown.Value.ToString("#,##0.00€"))
            End If

            MsgBox("Salário atualizado", vbInformation, "Atualização")
            acabarAlteracaoUnica()

            SortLogins()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FuncionariosBindingSource.MoveFirst()

        VerificarContrartarDespedir()
        SortLogins()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If String.IsNullOrEmpty(Login_FuncionarioBindingSource.Filter) Then
            Dim filtro As String = "DEH >= #" & DateTime.Today.ToString("MM/dd/yyyy") & " 00:00:00# AND DEH <= #" & DateTime.Today.ToString("MM/dd/yyyy") & " 23:59:59#"
            Login_FuncionarioBindingSource.Filter = filtro
            Button9.Text = "Todos os acessos"
        ElseIf Button9.Text = "Todos os acessos" Then
            Login_FuncionarioBindingSource.RemoveFilter()
            Button9.Text = "Acessos hoje"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ' Solicitar a data ao usuário
        Dim dataSelecionada As String = InputBox("Insira a data:")

        ' Verificar se apenas o número do dia foi fornecido
        Dim dataCompleta As Date
        If DateTime.TryParseExact(dataSelecionada, "d/M", CultureInfo.InvariantCulture, DateTimeStyles.None, dataCompleta) Then
            ' Dia e mês foram fornecidos
            dataSelecionada = dataCompleta.ToString("dd/MM/yyyy")
        ElseIf DateTime.TryParseExact(dataSelecionada, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, dataCompleta) Then
            ' Dia, mês e ano foram fornecidos
            dataSelecionada = dataCompleta.ToString("dd/MM/yyyy")
        End If

        Debug.WriteLine("dataCompleta: " & dataCompleta)

        ' Verificar se a data foi inserida corretamente
        If Not String.IsNullOrEmpty(dataCompleta) Then
            Dim data As Date
            If Date.TryParseExact(dataCompleta, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, data) Then
                ' Data inserida corretamente

                ' Verificar se o intervalo de horas foi selecionado
                Dim intervaloHoras As MsgBoxResult = MsgBox("Deseja especificar um intervalo de horas?", vbYesNo)
                If intervaloHoras = vbYes Then
                    ' Solicitar a hora inicial ao usuário
                    Dim horaInicial As String = InputBox("Insira a hora inicial (formato: HH:mm):")

                    ' Solicitar a hora final ao usuário
                    Dim horaFinal As String = InputBox("Insira a hora final (formato: HH:mm):")

                    ' Verificar se as horas foram inseridas corretamente
                    Dim horaInicialValida As DateTime
                    Dim horaFinalValida As DateTime
                    If DateTime.TryParseExact(horaInicial, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, horaInicialValida) AndAlso
                       DateTime.TryParseExact(horaFinal, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, horaFinalValida) Then
                        ' Horas inseridas corretamente

                        Dim filtro As String = "DEH >= #" & data.ToString("MM/dd/yyyy") & " " & horaInicialValida.ToString("HH:mm:ss") & "# AND DEH <= #" & data.ToString("MM/dd/yyyy") & " " & horaFinalValida.ToString("HH:mm:ss") & "#"
                        Login_FuncionarioBindingSource.Filter = filtro
                        Button9.Text = "Todos os acessos"
                    Else
                        MessageBox.Show("Horas inválidas.")
                    End If
                Else
                    ' Intervalo de horas não selecionado (considerar o dia todo)
                    Dim filtro As String = "DEH >= #" & data.ToString("MM/dd/yyyy") & " 00:00:00# AND DEH <= #" & data.ToString("MM/dd/yyyy") & " 23:59:59#"
                    Login_FuncionarioBindingSource.Filter = filtro
                    Button9.Text = "Todos os acessos"
                End If

            Else
                MessageBox.Show("Data inválida.")
            End If
        Else
            MessageBox.Show("Data não inserida.")
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If MsgBox("Tem certeza que deseja apagar esta conta?", vbYesNo, "Confirmação") = vbYes Then
            Try
                If Login_FuncionarioBindingSource.Position >= 0 Then
                    While Login_FuncionarioBindingSource.Position >= 0
                        Login_FuncionarioBindingSource.RemoveCurrent()
                    End While

                    Login_FuncionarioTableAdapter.Update(Industries_DanDataSet)

                End If

                If Diretores_de_DepartamentosBindingSource.Find("ID_Funcionario", FuncionariosBindingSource.Current("ID")) >= 0 Then
                    Debug.WriteLine("É/Foi Diretor")

                    While Diretores_de_DepartamentosBindingSource.Find("ID_Funcionario", FuncionariosBindingSource.Current("ID")) >= 0
                        Diretores_de_DepartamentosBindingSource.RemoveAt(Diretores_de_DepartamentosBindingSource.Find("ID_Funcionario", FuncionariosBindingSource.Current("ID")))
                    End While

                    Diretores_de_DepartamentosTableAdapter.Update(Industries_DanDataSet)
                End If

                FuncionariosBindingSource.RemoveCurrent()
                FuncionariosTableAdapter.Update(Industries_DanDataSet.Funcionarios)
                MsgBox("A conta foi apagada com sucesso!", vbInformation, "Apagado com sucesso")
            Catch erro As Exception
                MsgBox("Ocorreu o erro: " & erro.ToString & vbCrLf & "Tente novamente mais tarde, se o erro presistir entre em contacto com o administrador", vbCritical, "Erro")
                Debug.WriteLine(erro)
            End Try
        End If
    End Sub

    ' Função para restaurar os valores Enabled originais dos botões
    Private Sub RestaurarValoresEnabled()
        Dim botoes As New List(Of Button)()

        For Each control As Control In Me.Controls
            If TypeOf control Is Button Then
                Dim botao As Button = DirectCast(control, Button)
                botoes.Add(botao)
            End If
        Next

        For i As Integer = 0 To botoes.Count - 1
            botoes(i).Enabled = botaoEnabledArray(i)
        Next
    End Sub

End Class