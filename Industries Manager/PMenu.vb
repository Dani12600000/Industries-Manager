Public Class PMenu
    Private Sub PMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim IG As String
        If Hour(Now) >= 5 And Hour(Now) < 12 Then
            IG = "Bom dia"
        ElseIf Hour(Now) >= 12 And Hour(Now) < 21 Then
            IG = "Boa tarde"
        ElseIf Hour(Now) >= 21 Or Hour(Now) < 5 Then
            IG = "Boa noite"
        End If
        Label1.Text = IG + ", " + Login.Nome
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
End Class
