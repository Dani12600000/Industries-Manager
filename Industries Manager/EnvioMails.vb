Module EnvioMails
    Sub EnviarMensagemAutomaticaContratacao(primeiroNomeRemetente As String, ultimoNomeRemetente As String, emailDestinatario As String, nomeDestinatario As String, sobrenomeDestinario As String, cargo As String, departamento As String, salario As Double)
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
            Dim mensagemPredefinida As String = "Prezado(a) " & nomeDestinatario & " " & sobrenomeDestinario & "," & vbCrLf & vbCrLf &
                                        "Temos o prazer de informar que você foi contratado(a) para o cargo de " & cargo & " no departamento de " & departamento & "." & vbCrLf &
                                        mensagemSalario & vbCrLf & vbCrLf &
                                        "Começa " & diaDaSemana & ", dia " & proximoDia.ToString("d") & "." & vbCrLf & vbCrLf &
                                        "Estamos ansiosos para tê-lo(a) em nossa equipe!" & vbCrLf & vbCrLf &
                                        "Atenciosamente," & vbCrLf & primeiroNomeRemetente

            ' Adicionar o destinatário, assunto e mensagem pré-definida aos argumentos de linha de comando
            outlookProcess.StartInfo.Arguments = "/c ipm.note /m """ & emailDestinatario & "?subject=" & assunto & "&body=" & mensagemPredefinida & """"

            ' Iniciar o processo
            outlookProcess.Start()
        Catch ex As Exception
            Console.WriteLine("Erro ao abrir o Outlook: " & ex.Message)
        End Try
    End Sub

    Sub EnviarMensagemAutomaticaRecontratacao(primeiroNomeRemetente As String, ultimoNomeRemetente As String, destinatario As String, cargo As String, departamento As String, salario As Double)
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
                                        "Temos o prazer de informar que você foi recontratado(a) para o cargo de " & cargo & " no departamento de " & departamento & "." & vbCrLf &
                                        mensagemSalario & vbCrLf & vbCrLf &
                                        "Começa " & diaDaSemana & ", dia " & proximoDia.ToString("d") & "." & vbCrLf & vbCrLf &
                                        "Bem-vindo(a) de volta à nossa equipe!" & vbCrLf & vbCrLf &
                                        "Atenciosamente," & vbCrLf & primeiroNomeRemetente & " " & ultimoNomeRemetente

            ' Adicionar o destinatário, assunto e mensagem pré-definida aos argumentos de linha de comando
            outlookProcess.StartInfo.Arguments = "/c ipm.note /m """ & destinatario & "?subject=" & assunto & "&body=" & mensagemPredefinida & """"

            ' Iniciar o processo
            outlookProcess.Start()
        Catch ex As Exception
            Console.WriteLine("Erro ao abrir o Outlook: " & ex.Message)
        End Try
    End Sub

    Sub EnviarMensagemAutomaticaAtualizacaoSalario(primeiroNomeRemetente As String, ultimoNomeRemetente As String, destinatario As String, nomeDestinatario As String, sobrenomeDestinatario As String, novoSalario As Double)
        Try

            Dim assunto As String = "Alteração salarial"

            ' Criar uma instância do processo do Outlook
            Dim outlookProcess As New Process()

            ' Definir o nome do processo como "Outlook"
            outlookProcess.StartInfo.FileName = "Outlook"

            ' Formatar a mensagem pré-definida
            Dim mensagemPredefinida As String = "Prezado(a) " & nomeDestinatario & " " & sobrenomeDestinatario & "," & vbCrLf & vbCrLf &
                                            "Gostaríamos de informar que seu salário foi atualizado." & vbCrLf &
                                            "O novo valor do seu salário é de " & novoSalario.ToString("#,##0.00") & " por mês." & vbCrLf & vbCrLf &
                                            "Se tiver alguma dúvida, por favor, entre em contato conosco." & vbCrLf & vbCrLf &
                                            "Atenciosamente," & vbCrLf & primeiroNomeRemetente & " " & ultimoNomeRemetente

            ' Adicionar o destinatário, assunto e mensagem pré-definida aos argumentos de linha de comando
            outlookProcess.StartInfo.Arguments = "/c ipm.note /m """ & destinatario & "?subject=" & assunto & "&body=" & mensagemPredefinida & """"

            ' Iniciar o processo
            outlookProcess.Start()
        Catch ex As Exception
            Console.WriteLine("Erro ao abrir o Outlook: " & ex.Message)
        End Try
    End Sub

    Sub EnviarMensagemAutomaticaDespedimento(primeiroNomeRemetente As String, ultimoNomeRemetente As String, destinatario As String, nomeDestinatario As String, sobrenomeDestinatario As String, motivo As String)
        Try
            Dim assunto As String = "Despedimento das Industries Dan"

            ' Criar uma instância do processo do Outlook
            Dim outlookProcess As New Process()

            ' Definir o nome do processo como "Outlook"
            outlookProcess.StartInfo.FileName = "Outlook"

            ' Formatar a mensagem pré-definida
            Dim mensagemPredefinida As String = "Prezado(a) " & nomeDestinatario & " " & sobrenomeDestinatario & "," & vbCrLf & vbCrLf &
                                            "É por este meio que o vimos informar que está a ser despedido com efeito imediato" & vbCrLf

            ' Adicionar o motivo à mensagem pré-definida, se não estiver vazio
            If Not String.IsNullOrEmpty(motivo) Then
                mensagemPredefinida &= "Motivo: " & motivo & vbCrLf
            End If

            mensagemPredefinida &= vbCrLf & vbCrLf & "Atenciosamente," & vbCrLf & primeiroNomeRemetente & " " & ultimoNomeRemetente

            ' Adicionar o destinatário, assunto e mensagem pré-definida aos argumentos de linha de comando
            outlookProcess.StartInfo.Arguments = "/c ipm.note /m """ & destinatario & "?subject=" & assunto & "&body=" & mensagemPredefinida & """"

            ' Iniciar o processo
            outlookProcess.Start()
        Catch ex As Exception
            Console.WriteLine("Erro ao abrir o Outlook: " & ex.Message)
        End Try
    End Sub

    Sub EnviarMensagemAutomaticaDemissao(primeiroNomeRemetente As String, ultimoNomeRemetente As String, destinatarios As List(Of String), nomeDestinatario As String, sobrenomeDestinatario As String)
        Try
            Dim assunto As String = "Demissão das Industries Dan"

            ' Criar uma instância do processo do Outlook
            Dim outlookProcess As New Process()

            ' Definir o nome do processo como "Outlook"
            outlookProcess.StartInfo.FileName = "Outlook"

            ' Formatar a mensagem pré-definida
            Dim mensagemPredefinida As String = "Prezado(a) " & nomeDestinatario & " " & sobrenomeDestinatario & "," & vbCrLf & vbCrLf &
                                            "É por este meio que o venho informar que estou a me despedir com efeito imediato" & vbCrLf

            mensagemPredefinida &= vbCrLf & vbCrLf & "Atenciosamente," & vbCrLf & primeiroNomeRemetente & " " & ultimoNomeRemetente

            ' Adicionar o destinatário, assunto e mensagem pré-definida aos argumentos de linha de comando
            Dim argumentosParaOutlook As String

            argumentosParaOutlook = "/c ipm.note /m """

            For i = 0 To argumentosParaOutlook.Count - 1
                argumentosParaOutlook &= destinatarios(i)
                If i + 1 = argumentosParaOutlook.Count - 1 Then
                    argumentosParaOutlook &= ";"
                End If
            Next

            argumentosParaOutlook &= "?subject=" & assunto & "&body=" & mensagemPredefinida & """"

            outlookProcess.StartInfo.Arguments = argumentosParaOutlook

            ' Iniciar o processo
            outlookProcess.Start()
        Catch ex As Exception
            Console.WriteLine("Erro ao abrir o Outlook: " & ex.Message)
        End Try
    End Sub
End Module
