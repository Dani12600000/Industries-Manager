Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO
Imports Newtonsoft.Json

Public Class Login
    Public Nome As String
    Dim ID As Integer
    Dim strHostName As String
    Dim strIPAddress As String
    Private Sub FuncionariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FuncionariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Industries_DanDataSet)

    End Sub

    <Obsolete>
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Diretores_de_Departamentos' table. You can move, or remove it, as needed.
        Me.Diretores_de_DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Diretores_de_Departamentos)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Departamentos' table. You can move, or remove it, as needed.
        Me.DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Departamentos)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Login_Funcionario'. Você pode movê-la ou removê-la conforme necessário.
        Me.Login_FuncionarioTableAdapter.Fill(Me.Industries_DanDataSet.Login_Funcionario)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)

        Formulario = Me

        CenterOnScreenForm()

        strHostName = System.Net.Dns.GetHostName()

        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()

        Debug.WriteLine("IP : " & strIPAddress)

        If FuncionariosBindingSource.Count = 0 Then
            ReqConta.Show()
            ReqConta.Alpha = True
            Me.Close()
        Else
            LerDadosMemorizadosEIniciarSessao()
        End If

        CarregarPaletaDeCores()
        Button3.BackColor = cores(Label1.GetType)
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim pen1 As New Pen(Color.Gray, 0.5)
        Dim posicaoMedia As Integer = (LinkLabel1.Location.Y - LinkLabel2.Location.Y + LinkLabel2.Height) / 2
        Dim startPoint As New Point(Button1.Location.X, LinkLabel2.Location.Y + posicaoMedia)
        Dim endPoint As New Point(Button1.Location.X + Button1.Width, LinkLabel2.Location.Y + posicaoMedia)

        Dim g As Graphics = CreateGraphics()
        g.DrawLine(pen1, startPoint, endPoint)
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ReqConta.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
        If e.KeyCode = Keys.Up Then
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VericarSeContaExisteEFazerLogin(TextBox1.Text, TextBox2.Text, False, 0, "")
    End Sub

    Private Sub VericarSeContaExisteEFazerLogin(Email As String, Password As String, Memorizado As Boolean, Last_ID_Funcionario_Memorizado As Integer, Last_IP_Memorizado As String)

        FuncionariosTableAdapter.Fill(Industries_DanDataSet.Funcionarios)

        If Memorizado Then
            Login_FuncionarioBindingSource.Filter = "ID_Funcionario = " & Last_ID_Funcionario_Memorizado
            Login_FuncionarioBindingSource.Sort = "DEH DESC"
            Login_FuncionarioBindingSource.MoveFirst()

            If Login_FuncionarioBindingSource.Position >= 0 Then
                FuncionariosBindingSource.Filter = "ID = " & Last_ID_Funcionario_Memorizado

                Debug.WriteLine("Login_FuncionarioBindingSource.Current(""IP""): " & Login_FuncionarioBindingSource.Current("IP"))
                Debug.WriteLine("Login_FuncionarioBindingSource.Current(""ID""): " & Login_FuncionarioBindingSource.Current("ID"))
                Debug.WriteLine("Login_FuncionarioBindingSource.Count: " & Login_FuncionarioBindingSource.Count)
                Debug.WriteLine("Last_IP_Memorizado: " & Last_IP_Memorizado)

                If Login_FuncionarioBindingSource.Current("IP") <> strIPAddress Then
                    Me.Hide()
                    MsgBox("Por favor dê novamente login, o seu IP mudou", vbInformation, "Mudou de internet")
                    TextBox1.Text = FuncionariosBindingSource.Current("Email")
                    Me.Show()
                    Dim caminhoArquivo As String = "C:\Industries Dan_PAP\DadosMemorizados.json"
                    File.Delete(caminhoArquivo)
                    Return
                Else
                    Email = FuncionariosBindingSource.Current("Email")
                    FuncionariosBindingSource.RemoveFilter()
                End If
                Login_FuncionarioBindingSource.RemoveFilter()
            Else
                MsgBox("A conta que está memorizada não tem acessos guardados ou foi apagada, por favor dê login novamente" & vbCrLf & "Se não conseguir entrar entre em contacto com o departamento de desenvolvimento", vbInformation, "Não foi possivel usar os dados memorizados")
                Return
            End If
        End If

        If FuncionariosBindingSource.Find("Email", Email) = -1 Then
            MsgBox("Email inválido")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
        Else
            FuncionariosBindingSource.Position = FuncionariosBindingSource.Find("Email", Email)

            If FuncionariosBindingSource.Current("Pass") = Password Then
                If FuncionariosBindingSource.Current("Aprovacao") Then
                    Nome = FuncionariosBindingSource.Current("Nome")
                    ID = FuncionariosBindingSource.Current("ID")
                    Login_FuncionarioBindingSource.AddNew()

                    DepartamentosBindingSource.Filter = "ID = " & FuncionariosBindingSource.Current("ID_Departamento")
                    Diretores_de_DepartamentosBindingSource.Filter = "ID_Funcionario = " & FuncionariosBindingSource.Current("ID") & " AND DDF Is NULL Or DDF > #" & Today.ToString("MM/dd/yyyy") & "#"
                    Diretores_de_DepartamentosBindingSource.MoveLast()

                    Login_FuncionarioBindingSource.Current("ID_Funcionario") = FuncionariosBindingSource.Current("ID")
                    Login_FuncionarioBindingSource.Current("LiOuLo") = "Login"
                    Login_FuncionarioBindingSource.Current("DeH") = Now()
                    Login_FuncionarioBindingSource.Current("Ip") = strIPAddress

                    InfoUser.UserID = FuncionariosBindingSource.Current("ID")
                    InfoUser.UserIp = strIPAddress
                    InfoUser.UserName = FuncionariosBindingSource.Current("Nome")
                    InfoUser.UserSurname = FuncionariosBindingSource.Current("Sobrenome")
                    InfoUser.UserEmail = FuncionariosBindingSource.Current("Email")
                    InfoUser.UserAdm = FuncionariosBindingSource.Current("Adm")
                    InfoUser.UserDepID = DepartamentosBindingSource.Current("ID")
                    InfoUser.UserDepName = DepartamentosBindingSource.Current("NDD")
                    If Diretores_de_DepartamentosBindingSource.Position >= 0 Then
                        InfoUser.UserDepDirectorYN = True
                        InfoUser.UserDepDirectorID = Diretores_de_DepartamentosBindingSource.Current("ID")
                    Else
                        InfoUser.UserDepDirectorYN = False
                    End If

                    InfoUser.getUserFirstAndLastName()

                    'For debug
                    Debug.WriteLine("Login form" & vbCrLf & "---------")
                    Debug.WriteLine("ID : " & InfoUser.UserID)
                    Debug.WriteLine("Ip : " & InfoUser.UserIp)
                    Debug.WriteLine("Name : " & InfoUser.UserName)
                    Debug.WriteLine("Surname : " & InfoUser.UserSurname)
                    Debug.WriteLine("First Name : " & InfoUser.UserFirstName)
                    Debug.WriteLine("Last Name : " & InfoUser.UserLastName)
                    Debug.WriteLine("Email : " & InfoUser.UserEmail)
                    Debug.WriteLine("Admin : " & InfoUser.UserAdm)
                    Debug.WriteLine("ID Departamento : " & InfoUser.UserDepID)
                    Debug.WriteLine("Departamento : " & InfoUser.UserDepName)
                    Debug.Write("Diretor (Sim/Não) : ")
                    Debug.WriteLineIf(Not InfoUser.UserDepDirectorYN, "Não")
                    Debug.WriteLineIf(InfoUser.UserDepDirectorYN, "Sim")
                    Debug.WriteLineIf(InfoUser.UserDepDirectorYN, "ID Diretor : " & InfoUser.UserDepDirectorID)
                    Debug.WriteLine("Estas são todas as infos do user carregadas")

                    Login_FuncionarioBindingSource.EndEdit()
                    Login_FuncionarioTableAdapter.Update(Industries_DanDataSet.Login_Funcionario)

                    If FuncionariosBindingSource.Current("Pass") = "123456Ab" Then
                        Dim senha As String = ""

                        While FuncionariosBindingSource.Current("Pass") = "123456Ab"
                            Dim bol As Boolean

                            Dim formSenha As New FormSenha()
                            If bol = True Then
                                formSenha.ReceberDados(bol)
                            End If
                            Dim resultado As DialogResult = formSenha.ShowDialog()

                            If resultado = DialogResult.OK Then
                                senha = formSenha.TextBoxSenha.Text
                            End If

                            ' Verificar se a senha está vazia ou se é igual à senha atual
                            If String.IsNullOrWhiteSpace(senha) OrElse senha = FuncionariosBindingSource.Current("Pass") Then
                                MessageBox.Show("A nova palavra-passe não é válida. Tente novamente.", "Erro de palavra-passe", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                bol = True
                            Else
                                ' Senha válida, sair do loop
                                Password = senha
                                FuncionariosBindingSource.Current("Pass") = senha
                                FuncionariosBindingSource.EndEdit()
                                FuncionariosTableAdapter.Update(Industries_DanDataSet)
                                Exit While
                            End If

                        End While



                        FuncionariosBindingSource.EndEdit()
                        FuncionariosTableAdapter.Update(Industries_DanDataSet.Funcionarios)
                    End If

                    If CheckBox1.Checked And Not Memorizado Then
                        GuardarDadosParaMemorizarAPalavraPasse(Password)
                    End If

                    PMenu.Show()
                    Me.Close()
                Else
                    If IsDBNull(FuncionariosBindingSource.Current("DDSDE")) Then
                        MsgBox("A conta ainda não foi confirmada" + vbCrLf + "Tente novamente mais tarde", vbInformation, "Espere verificação")
                    Else
                        MsgBox("Você foi despedido e como tal não tem mais acesso ao sistema", vbInformation, "Foi despedido")
                    End If
                End If
            Else
                If Memorizado Then
                    MsgBox("A palavra-passe foi atualizada desde o ultimo login" & vbCrLf & "Por favor introduza novamente a palavra-passe", vbInformation, "Reintroduza a palavra-passe")
                    TextBox1.Text = FuncionariosBindingSource.Current("Email")
                Else
                    MsgBox("A palavra-passe que introduziu está errada" & vbCrLf & "Por favor introduza novamente a palavra-passe", vbInformation, "Palavra-passe incorreta")
                End If

                TextBox2.Text = ""
                TextBox2.Focus()

                Debug.WriteLine("ID_Funcionario : " & FuncionariosBindingSource.Current("ID"))
                Debug.WriteLine("LiOuLo : " & "Tentativa de Login")

                Login_FuncionarioBindingSource.AddNew()
                Login_FuncionarioBindingSource.Current("ID_Funcionario") = FuncionariosBindingSource.Current("ID")
                Login_FuncionarioBindingSource.Current("LiOuLo") = "Tentativa de Login"
                Login_FuncionarioBindingSource.Current("DeH") = Now()
                Login_FuncionarioBindingSource.Current("Ip") = strIPAddress

                Login_FuncionarioBindingSource.EndEdit()
                Login_FuncionarioTableAdapter.Update(Industries_DanDataSet.Login_Funcionario)

            End If
        End If
    End Sub

    Private Sub GuardarDadosParaMemorizarAPalavraPasse(password As String)
        Dim valores As New Dictionary(Of String, String) From {
            {"ID_Funcionario", InfoUser.UserID},
            {"palavra_passe", password},
            {"ip", strIPAddress}
        }

        Debug.WriteLine("valores: " & valores.ToString)

        Dim caminhoArquivo As String = "C:\Industries Dan_PAP\DadosMemorizados.json"

        Try
            If File.Exists(caminhoArquivo) Then
                ' Ler o conteúdo atual do arquivo
                Dim json As String = File.ReadAllText(caminhoArquivo)

                ' Desserializar JSON para um dicionário existente
                Dim valoresExistentes As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(json)

                ' Atualizar os valores no dicionário existente
                For Each kvp As KeyValuePair(Of String, String) In valores
                    valoresExistentes(kvp.Key) = kvp.Value
                Next

                ' Serializar objeto atualizado para JSON
                json = JsonConvert.SerializeObject(valoresExistentes)

                ' Sobrescrever o arquivo com os novos dados
                File.WriteAllText(caminhoArquivo, json)

                Debug.WriteLine("Valores atualizados com sucesso!")
            Else
                ' Serializar objeto para JSON
                Dim json As String = JsonConvert.SerializeObject(valores)

                ' Escrever JSON no arquivo
                File.WriteAllText(caminhoArquivo, json)

                Debug.WriteLine("Valores salvos com sucesso!")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao salvar/atualizar os valores no arquivo: " & ex.Message)
        End Try
    End Sub

    Public Class Valores
        Public Property palavra_passe As String
        Public Property ID_Funcionario As String
        Public Property ip As String
    End Class

    Private Sub LerDadosMemorizadosEIniciarSessao()
        Dim caminhoArquivo As String = "C:\Industries Dan_PAP\DadosMemorizados.json"

        Try
            If File.Exists(caminhoArquivo) Then
                Dim json As String = File.ReadAllText(caminhoArquivo)
                Dim valores As Valores = JsonConvert.DeserializeObject(Of Valores)(json)
                Debug.WriteLine("ID_Funcionario: " & valores.ID_Funcionario)
                Debug.WriteLine("IP: " & valores.ip)

                VericarSeContaExisteEFazerLogin("", valores.palavra_passe, True, valores.ID_Funcionario, valores.ip)

                Debug.WriteLine("Valores lidos do arquivo com sucesso!")
                Else
                    Debug.WriteLine("Arquivo não encontrado.")
            End If
        Catch ex As FileNotFoundException
            Debug.WriteLine("Arquivo não encontrado.")
        Catch ex As Exception
            Debug.WriteLine("Ocorreu um erro ao ler o arquivo: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox2.PasswordChar = "" Then
            TextBox2.PasswordChar = "●"
            Button3.BackgroundImage = My.Resources.show_password_eye
        Else
            TextBox2.PasswordChar = ""
            Button3.BackgroundImage = My.Resources.hide_password_eye
        End If
    End Sub
End Class