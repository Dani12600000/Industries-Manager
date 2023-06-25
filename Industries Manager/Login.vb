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

        Dim index As Integer = Login_FuncionarioBindingSource.Find("Ip", strIPAddress)
        If index >= 0 Then
            Login_FuncionarioBindingSource.Position = index
            Debug.WriteLine("Posição login : " & index)
            Dim ID_Funcionario = Login_FuncionarioBindingSource.Current("ID_Funcionario")
            index = FuncionariosBindingSource.Find("ID", ID_Funcionario)
            FuncionariosBindingSource.Position = index
            Debug.WriteLine("Posição utilizador : " & index)
            If FuncionariosBindingSource.Current("Adm") Then
                Button2.Visible = True
            End If
            Debug.WriteLine("Admin : " & FuncionariosBindingSource.Current("Adm"))
        End If

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
        FuncionariosTableAdapter.Fill(Industries_DanDataSet.Funcionarios)

        If FuncionariosBindingSource.Find("Email", TextBox1.Text) = -1 Then
            MsgBox("Email inválido")
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            FuncionariosBindingSource.Position = FuncionariosBindingSource.Find("Email", TextBox1.Text)
            If FuncionariosBindingSource.Current("Pass") = TextBox2.Text Then
                If FuncionariosBindingSource.Current("Aprovacao") Then
                    Nome = FuncionariosBindingSource.Current("Nome")
                    ID = FuncionariosBindingSource.Current("ID")

                    FazerLogin()
                Else
                    MsgBox("A conta ainda não foi confirmada" + vbCrLf + "Tente novamente mais tarde")
                End If
            Else
                MsgBox("Password errada")
                TextBox2.Text = ""

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

    Private Sub FazerLogin()
        Login_FuncionarioBindingSource.AddNew()

        DepartamentosBindingSource.Filter = "ID = " & FuncionariosBindingSource.Current("ID_Departamento")
        Diretores_de_DepartamentosBindingSource.Filter = "ID_Funcionario = " & FuncionariosBindingSource.Current("ID")
        Diretores_de_DepartamentosBindingSource.MoveLast()

        Login_FuncionarioBindingSource.Current("ID_Funcionario") = FuncionariosBindingSource.Current("ID")
        Login_FuncionarioBindingSource.Current("LiOuLo") = "Login"
        Login_FuncionarioBindingSource.Current("DeH") = Now()
        Login_FuncionarioBindingSource.Current("Ip") = strIPAddress

        InfoUser.UserID = FuncionariosBindingSource.Current("ID")
        InfoUser.UserIp = strIPAddress
        InfoUser.UserName = FuncionariosBindingSource.Current("Nome")
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

        'For debug
        Debug.WriteLine("Login form" & vbCrLf & "---------")
        Debug.WriteLine("ID : " & InfoUser.UserID)
        Debug.WriteLine("Ip : " & InfoUser.UserIp)
        Debug.WriteLine("Name : " & InfoUser.UserName)
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
                Dim resultado As DialogResult = FormSenha.ShowDialog()

                If resultado = DialogResult.OK Then
                    senha = formSenha.TextBoxSenha.Text
                End If

                ' Verificar se a senha está vazia ou se é igual à senha atual
                If String.IsNullOrWhiteSpace(senha) OrElse senha = FuncionariosBindingSource.Current("Pass") Then
                    MessageBox.Show("A nova palavra-passe não é válida. Tente novamente.", "Erro de palavra-passe", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    bol = True
                Else
                    ' Senha válida, sair do loop
                    Exit While
                End If

            End While


            FuncionariosBindingSource.EndEdit()
            FuncionariosTableAdapter.Update(Industries_DanDataSet.Funcionarios)
        End If


        PMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Este bloco de codigo a seguir serve apenas para dar os previlegios de admin ao Debbuger
        ' Localizar a linha com o ID igual a 6
        Dim index As Integer = FuncionariosBindingSource.Find("ID", 6)

        ' Verificar se a linha foi encontrada
        If index >= 0 Then
            ' Definir os valores dos booleanos Adm e Aprovacao para true
            FuncionariosBindingSource.Position = index
            FuncionariosBindingSource.Current("Adm") = True
            FuncionariosBindingSource.Current("Aprovacao") = True

            FuncionariosBindingSource.EndEdit()
            FuncionariosTableAdapter.Update(Industries_DanDataSet.Funcionarios)
        End If

        FazerLogin()
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