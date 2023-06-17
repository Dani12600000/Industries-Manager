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
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Login_Funcionario'. Você pode movê-la ou removê-la conforme necessário.
        Me.Login_FuncionarioTableAdapter.Fill(Me.Industries_DanDataSet.Login_Funcionario)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)



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
                    Login_FuncionarioBindingSource.AddNew()

                    Login_FuncionarioBindingSource.Current("ID_Funcionario") = FuncionariosBindingSource.Current("ID")
                    Login_FuncionarioBindingSource.Current("LiOuLo") = "Login"
                    Login_FuncionarioBindingSource.Current("DeH") = Now()
                    Login_FuncionarioBindingSource.Current("Ip") = strIPAddress
                    InfoUser.UserID = FuncionariosBindingSource.Current("ID")
                    InfoUser.UserIp = strIPAddress
                    InfoUser.UserName = FuncionariosBindingSource.Current("Nome")
                    InfoUser.UserEmail = FuncionariosBindingSource.Current("Email")
                    InfoUser.UserAdm = FuncionariosBindingSource.Current("Adm")

                    'For debug
                    Debug.WriteLine("Login form" & vbCrLf & "---------")
                    Debug.WriteLine("ID : " & InfoUser.UserID)
                    Debug.WriteLine("Ip : " & InfoUser.UserIp)
                    Debug.WriteLine("Name : " & InfoUser.UserName)
                    Debug.WriteLine("Email : " & InfoUser.UserEmail)
                    Debug.WriteLine("Admin : " & InfoUser.UserAdm)

                    Login_FuncionarioBindingSource.EndEdit()
                    Login_FuncionarioTableAdapter.Update(Industries_DanDataSet.Login_Funcionario)

                    PMenu.Show()
                    Me.Close()
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

        Login_FuncionarioBindingSource.AddNew()

        Login_FuncionarioBindingSource.Current("ID_Funcionario") = FuncionariosBindingSource.Current("ID")
        Login_FuncionarioBindingSource.Current("LiOuLo") = "Login"
        Login_FuncionarioBindingSource.Current("DeH") = Now()
        Login_FuncionarioBindingSource.Current("Ip") = strIPAddress
        InfoUser.UserID = FuncionariosBindingSource.Current("ID")
        InfoUser.UserIp = strIPAddress
        InfoUser.UserName = FuncionariosBindingSource.Current("Nome")
        InfoUser.UserEmail = FuncionariosBindingSource.Current("Email")
        InfoUser.UserAdm = FuncionariosBindingSource.Current("Adm")

        'For debug
        Debug.WriteLine("Login form" & vbCrLf & "---------")
        Debug.WriteLine("ID : " & InfoUser.UserID)
        Debug.WriteLine("Ip : " & InfoUser.UserIp)
        Debug.WriteLine("Name : " & InfoUser.UserName)
        Debug.WriteLine("Email : " & InfoUser.UserEmail)
        Debug.WriteLine("Admin : " & InfoUser.UserAdm)

        Login_FuncionarioBindingSource.EndEdit()
        Login_FuncionarioTableAdapter.Update(Industries_DanDataSet.Login_Funcionario)


        PMenu.Show()

        Me.Close()
    End Sub
End Class