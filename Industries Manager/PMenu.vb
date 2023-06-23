Public Class PMenu
    Private Sub PMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Login_Funcionario'. Você pode movê-la ou removê-la conforme necessário.
        Me.Login_FuncionarioTableAdapter.Fill(Me.Industries_DanDataSet.Login_Funcionario)


        Dim IG As String = ""
        If Hour(Now) >= 5 And Hour(Now) < 12 Then
            IG = "Bom dia"
        ElseIf Hour(Now) >= 12 And Hour(Now) < 21 Then
            IG = "Boa tarde"
        ElseIf Hour(Now) >= 21 Or Hour(Now) < 5 Then
            IG = "Boa noite"
        End If
        Label1.Text = IG + ", " + InfoUser.UserName

        'For debug
        Debug.WriteLine(vbCrLf & "PMenu form" & vbCrLf & "---------")
        Debug.WriteLine("ID : " & InfoUser.UserID)
        Debug.WriteLine("Ip : " & InfoUser.UserIp)
        Debug.WriteLine("Name : " & InfoUser.UserName)
        Debug.WriteLine("Email : " & InfoUser.UserEmail)
        Debug.WriteLine("Admin : " & InfoUser.UserAdm)
        Debug.WriteLine("Departamento : " & InfoUser.UserDepName)
        Debug.Write("Diretor (Sim/Não) : ")
        Debug.WriteLineIf(Not InfoUser.UserDepDirectorYN, "Não")
        Debug.WriteLineIf(InfoUser.UserDepDirectorYN, "Sim")
        Debug.WriteLineIf(InfoUser.UserDepDirectorYN, "ID Diretor : " & InfoUser.UserDepDirectorID)
        Debug.WriteLine("Estas são todas as infos do user carregadas")


        If InfoUser.UserDepDirectorYN Then
            AvisosToolStripMenuItem.DropDownItems.Add(New ToolStripSeparator)

            Dim botaoVerAvisosMandados As New ToolStripButton("Ver Avisos Enviados")
            Dim botaoNovoAviso As New ToolStripButton("Enviar Novo Aviso")

            AddHandler botaoVerAvisosMandados.Click, AddressOf VerAvisosMandados_Click
            AddHandler botaoNovoAviso.Click, AddressOf NovoAviso_Click

            AvisosToolStripMenuItem.DropDownItems.Add(botaoVerAvisosMandados)
            AvisosToolStripMenuItem.DropDownItems.Add(botaoNovoAviso)

        End If

        Dim nenhumAvisoLabel As New ToolStripLabel("Nenhum aviso novo por agora") With {
            .ForeColor = Color.DimGray
        }
        nenhumAvisoLabel.Font = New Font(nenhumAvisoLabel.Font, FontStyle.Italic)
        AvisosToolStripMenuItem.DropDownItems.Insert(0, nenhumAvisoLabel)


    End Sub

    Private Sub VerAvisosMandados_Click(sender As Object, e As EventArgs)
        Avisos.Show()
    End Sub

    Private Sub NovoAviso_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub PMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login_FuncionarioBindingSource.AddNew()
        Login_FuncionarioBindingSource.Current("ID_Funcionario") = InfoUser.UserID
        Login_FuncionarioBindingSource.Current("LiOuLo") = "Logout"
        Login_FuncionarioBindingSource.Current("DeH") = Now()
        Login_FuncionarioBindingSource.Current("Ip") = InfoUser.UserIp

        Login_FuncionarioBindingSource.EndEdit()
        Login_FuncionarioTableAdapter.Update(Industries_DanDataSet.Login_Funcionario)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clientes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Departamentos.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Fornecedores.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Login_FuncionarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Login_FuncionarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Industries_DanDataSet)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Funcionarios.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Produtos.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Profissões.Show()
    End Sub
End Class
