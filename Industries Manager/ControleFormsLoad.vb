Module ControleFormsLoad
    Public Formulario As Form
    Sub CenterOnScreenForm()
        Formulario.StartPosition = FormStartPosition.Manual
        Formulario.Location = New Point((Screen.PrimaryScreen.Bounds.Width - Formulario.Width) \ 2, (Screen.PrimaryScreen.Bounds.Height - Formulario.Height) \ 2)
    End Sub
End Module
