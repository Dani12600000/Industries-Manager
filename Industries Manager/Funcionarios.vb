Public Class Funcionarios

    Dim DespColor, ContColor As Color

    Private Sub Funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Profissões' table. You can move, or remove it, as needed.
        Me.ProfissõesTableAdapter.Fill(Me.Industries_DanDataSet.Profissões)

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
        If Button5.Text = "Contratar" Then

        ElseIf Button5.Text = "Despedir" Then
            If MsgBox("Tem certeza que deseja despedir o funcionario nº" & FuncionariosBindingSource.Current("ID") & "?", vbYesNo, "Confirmação") = vbYes Then
                If MsgBox("Deseja enviar um mail a informa-lo?", vbYesNo, "Enviar mail") Then

                End If


            End If
        End If
    End Sub

    Sub EnviarMensagemAutomaticaDespedimento(nomeRemetente As String, destinatario As String, assunto As String, motivo As String)
        Try
            ' Criar uma instância do processo do Outlook
            Dim outlookProcess As New Process()

            ' Definir o nome do processo como "Outlook"
            outlookProcess.StartInfo.FileName = "Outlook"

            ' Formatar a mensagem pré-definida
            Dim mensagemPredefinida As String = "Prezado(a), " & NomeTextBox.Text & " " & SobrenomeTextBox.Text & vbCrLf &
                                            "É por este meio que o vimos informar que está a ser despedido com efeito imediato" & vbCrLf &
                                            "Motivo : " & motivo & vbCrLf & vbCrLf & vbCrLf &
                                            "Atenciosamente," & vbCrLf & nomeRemetente

            ' Adicionar o destinatário, assunto e mensagem pré-definida aos argumentos de linha de comando
            outlookProcess.StartInfo.Arguments = "/c ipm.note /m """ & destinatario & "?subject=" & assunto & "&body=" & mensagemPredefinida & """"

            ' Iniciar o processo
            outlookProcess.Start()
        Catch ex As Exception
            Console.WriteLine("Erro ao abrir o Outlook: " & ex.Message)
        End Try
    End Sub

    Sub EnviarMensagemAutomaticaContratacao(nomeRemetente As String, destinatario As String, assunto As String, cargo As String, salario As String)
        Try
            ' Criar uma instância do processo do Outlook
            Dim outlookProcess As New Process()

            ' Definir o nome do processo como "Outlook"
            outlookProcess.StartInfo.FileName = "Outlook"

            ' Formatar a mensagem pré-definida
            Dim mensagemPredefinida As String = "Prezado(a) " & destinatario & "," & vbCrLf & vbCrLf &
                                            "Temos o prazer de informar que você foi contratado(a) para o cargo de " & cargo & "." & vbCrLf &
                                            "Seu salário será de " & salario & " por mês." & vbCrLf & vbCrLf &
                                            "Estamos ansiosos para tê-lo(a) em nossa equipe!" & vbCrLf & vbCrLf &
                                            "Atenciosamente," & vbCrLf & nomeRemetente

            ' Adicionar o destinatário, assunto e mensagem pré-definida aos argumentos de linha de comando
            outlookProcess.StartInfo.Arguments = "/c ipm.note /m """ & destinatario & "?subject=" & assunto & "&body=" & mensagemPredefinida & """"

            ' Iniciar o processo
            outlookProcess.Start()
        Catch ex As Exception
            Console.WriteLine("Erro ao abrir o Outlook: " & ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FuncionariosBindingSource.MoveFirst()

        VerificarContrartarDespedir()


    End Sub
End Class