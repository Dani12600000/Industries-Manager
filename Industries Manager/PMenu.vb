Public Class PMenu
    Private Sub PMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Login_Funcionario'. Você pode movê-la ou removê-la conforme necessário.
        Me.Login_FuncionarioTableAdapter.Fill(Me.Industries_DanDataSet.Login_Funcionario)


        Dim IG As String
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

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub
End Class
