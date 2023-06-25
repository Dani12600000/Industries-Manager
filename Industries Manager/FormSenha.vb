Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormSenha
    Dim corTextBox As Color
    Dim IPI As Boolean

    Sub ReceberDados(inseriuPassInvalida As Boolean)
        IPI = inseriuPassInvalida
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBoxSenha.PasswordChar = "" Then
            TextBoxSenha.PasswordChar = "●"
            Button3.BackgroundImage = My.Resources.show_password_eye
        Else
            TextBoxSenha.PasswordChar = ""
            Button3.BackgroundImage = My.Resources.hide_password_eye
        End If
    End Sub

    Private Sub FormSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Formulario = Me

        CenterOnScreenForm()

        Debug.WriteLine("IPI: " & IPI)
        corTextBox = TextBoxSenha.BackColor
        If IPI Then
            TextBoxSenha.BackColor = Color.LightCoral
            Debug.WriteLine("Devia tar vermelho")
        Else
            TextBoxSenha.BackColor = corTextBox
            Debug.WriteLine("Cinzento")
        End If
    End Sub

    Private Sub TextBoxSenha_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSenha.TextChanged
        TextBoxSenha.BackColor = corTextBox
    End Sub

    Private Sub TextBoxSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub FormSenha_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        PMenu.Activate()
    End Sub
End Class