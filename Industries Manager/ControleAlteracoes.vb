Module ControleAlteracoes
    Public Formulario As Form
    Public ButtonNandG, ButtonRorEandC, ButtonF, ButtonP, ButtonN, ButtonL, ButtonE As Button
    Dim TextButNandG, TextButRorEandC As String
    Dim TorF As Boolean

    ' Para usar este metodo tenho que declarar as seguintes variaveis primeiro:
    ' Formulario - Fomulario atual
    ' ButtonNandG - Botão para Salar e Guardar
    ' ButtonRorEandC - Botão para Remover ou Editar e Cancelar 
    ' ButtonF - Botão First/Primeiro
    ' ButtonP - Botão Previous/Prévio
    ' ButtonN - Botão Next/Proximo
    ' ButtonL - Botão Last/Ultimo
    ' ButtonE - Botão Editar
    ' 
    ' Depois de definir todos os botões ás respetivas variaveis pode usar nos varios formularios os seguintes procedimentos
    ' iniciarAlteracoes() - Quando chamado utiliza as variaveis para defenir a propriedade Enabled dos botões de navegação como false, a propriedade ReadOnly das TextBox's tambem como false, o Enabled dos NumericUpDown como true e guarda os atributos Text's dos botões ButtonNG, ButtonRC e ButtonEC nas respetivas variaveis TextButNG, TextButRC e TextButEC fazendo depois alteração do texto nas propriades Text dos mesmo botões.
    ' acabarAlteracoes() - Quando chamado utiliza as variaveis para defenir o contrario do iniciar e depois buscar o texto guardado nas variaveis TextButNG, TextButRC e TextButEC para as colocar nas respetivas propriedades Text dos botões ButtonNG, ButtonRC, ButtonEC
    ' 
    ' Procedimentos internos
    ' trocarBooleans() - Este procedimento visa auxiliar o iniciarAlterações e o acabarAlterações a colocar as propriedade Enabled e ReadOnly em todos os botões e TextBox's respetivamente como verdadeiro/falso

    Sub iniciarAlteracoes()
        TorF = False
        Debug.WriteLine("iniciando alterações - começo")

        trocarBooleans()

        TextButNandG = ButtonNandG.Text

        TextButRorEandC = ButtonRorEandC.Text

        Debug.WriteLine("TextButNandG : " & TextButNandG)
        Debug.WriteLine("TextButRorEandC : " & TextButRorEandC)

        ButtonNandG.Text = "Guardar"

        ButtonRorEandC.Text = "Cancelar"

        Debug.WriteLine("iniciando alterações - fim")

    End Sub

    Sub acabarAlteracoes()

        Debug.WriteLine("acabando alterações - começo")

        TorF = True

        trocarBooleans()

        Debug.WriteLine("TextButNandG: " & TextButNandG)
        Debug.WriteLine("TextButRorEandC: " & TextButRorEandC)

        ButtonNandG.Text = TextButNandG

        ButtonRorEandC.Text = TextButRorEandC

        Debug.WriteLine("acabando alterações - fim")

    End Sub

    Private Sub trocarBooleans()
        For Each ctl As Control In Formulario.Controls

            If TypeOf ctl Is TextBox Then

                Dim textBox As TextBox = DirectCast(ctl, TextBox)
                textBox.ReadOnly = TorF
                Debug.WriteLine("Name: " & textBox.Name & "  Enabled: " & textBox.ReadOnly)

            ElseIf TypeOf ctl Is NumericUpDown Then

                Dim numericUpDown As NumericUpDown = DirectCast(ctl, NumericUpDown)
                numericUpDown.Enabled = Not TorF
                Debug.WriteLine("Name: " & numericUpDown.Name & "  Enabled: " & numericUpDown.Enabled)

            ElseIf TypeOf ctl Is DateTimePicker Then

                Dim dateTimePicker As DateTimePicker = DirectCast(ctl, DateTimePicker)
                dateTimePicker.Enabled = Not TorF
                Debug.WriteLine("Name: " & dateTimePicker.Name & "  Enabled: " & dateTimePicker.Enabled)

            ElseIf TypeOf ctl Is Button Then

                Dim button As Button = DirectCast(ctl, Button)
                button.Enabled = TorF
                Debug.WriteLine("Name: " & button.Name & "  Enabled: " & button.Enabled)

            End If

        Next

        ButtonNandG.Enabled = True

        ButtonRorEandC.Enabled = True

        ButtonF.Enabled = TorF
        ButtonP.Enabled = TorF
        ButtonN.Enabled = TorF
        ButtonL.Enabled = TorF

        Try
            If ButtonE IsNot Nothing Then
                ButtonE.Enabled = TorF
            End If
        Catch
        End Try
    End Sub
End Module