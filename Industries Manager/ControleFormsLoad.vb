Module ControleFormsLoad
    Public Formulario As Form
    Public tamanhobuttonadd As Integer
    Public tamanhobuttonedit As Integer
    Public somaTamanhosButtonFPAndSpaceBetween As Integer
    Public Locationbuttonadd, Locationbuttonedit As Point

    Sub CenterOnScreenForm()
        Formulario.StartPosition = FormStartPosition.Manual
        Formulario.Location = New Point((Screen.PrimaryScreen.Bounds.Width - Formulario.Width) \ 2, (Screen.PrimaryScreen.Bounds.Height - Formulario.Height) \ 2)
    End Sub

    Sub CarregamentoInicial()
        tamanhobuttonadd = ButtonNandG.Width
        tamanhobuttonedit = ButtonE.Width
        somaTamanhosButtonFPAndSpaceBetween = ButtonF.Width + ButtonP.Width + (ButtonP.Location.X - ButtonF.Location.X + ButtonF.Width)
    End Sub

    Sub DepartamentosAndAcoesQuePodemRealizar(AcoesDeCadaDepartamento As String)
        If AcoesDeCadaDepartamento Then
            '@TODO : TERMINAR
        End If

    End Sub

    Sub Desancorar(controles As Control, esquerda As Boolean, direita As Boolean, cima As Boolean, baixo As Boolean)
        For Each controle As Control In controles.Controls
            controle.Anchor = If(esquerda, AnchorStyles.Left, AnchorStyles.None) Or
                              If(direita, AnchorStyles.Right, AnchorStyles.None) Or
                              If(cima, AnchorStyles.Top, AnchorStyles.None) Or
                              If(baixo, AnchorStyles.Bottom, AnchorStyles.None)

            ' Recursivamente chama a função para lidar com controles filhos
            Desancorar(controle, esquerda, direita, cima, baixo)
        Next
    End Sub
End Module
