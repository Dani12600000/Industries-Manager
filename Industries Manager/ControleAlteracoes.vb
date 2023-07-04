Module ControleAlteracoes

    Public ButtonNandG, ButtonRorEandC, ButtonF, ButtonP, ButtonN, ButtonL, ButtonE As Button
    Public IgnoreTextBoxs As List(Of TextBox) = New List(Of TextBox)()
    Public IgnoreDateTimePickers As List(Of DateTimePicker) = New List(Of DateTimePicker)()
    Public IgnoreNumericUpDowns As List(Of NumericUpDown) = New List(Of NumericUpDown)()
    Public IgnoreButtons As List(Of Button) = New List(Of Button)()
    Public ButtonsQPrecisamSerGuardados As List(Of Button) = New List(Of Button)()
    Public ValoresGuardadosDosButtonsQPrecisamSerGuardados As List(Of Boolean) = New List(Of Boolean)()
    Dim TextButNandG, TextButRorEandC, TextButAltUnic As String
    Dim TorF As Boolean
    Dim buttonAltUnicTemp As Button
    Dim componenteAltUnicTemp As Control

    Sub iniciarAlteracoes()
        TorF = False
        Debug.WriteLine("iniciando alterações - começo")

        ValoresGuardadosDosButtonsQPrecisamSerGuardados.Clear()
        trocarBooleansParaAlteracoes()

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

        trocarBooleansParaAlteracoes()

        Debug.WriteLine("TextButNandG: " & TextButNandG)
        Debug.WriteLine("TextButRorEandC: " & TextButRorEandC)

        ButtonNandG.Text = TextButNandG

        ButtonRorEandC.Text = TextButRorEandC

        Debug.WriteLine("acabando alterações - fim")

    End Sub

    Private Sub trocarBooleansParaAlteracoes()
        Dim i As String = 0

        For Each ctl As Control In Formulario.Controls

            If TypeOf ctl Is TextBox Then

                Dim textBox As TextBox = DirectCast(ctl, TextBox)
                Debug.WriteLine("Name: " & textBox.Name & "  »Enabled: " & textBox.ReadOnly)
                If IgnoreTextBoxs.Contains(textBox) Then Continue For
                textBox.ReadOnly = TorF
                Debug.WriteLine("Name: " & textBox.Name & "  «Enabled: " & textBox.ReadOnly)

            ElseIf TypeOf ctl Is NumericUpDown Then

                Dim numericUpDown As NumericUpDown = DirectCast(ctl, NumericUpDown)
                Debug.WriteLine("Name: " & numericUpDown.Name & "  »Enabled: " & numericUpDown.Enabled)
                If IgnoreNumericUpDowns.Contains(numericUpDown) Then Continue For
                numericUpDown.Enabled = Not TorF
                Debug.WriteLine("Name: " & numericUpDown.Name & "  «Enabled: " & numericUpDown.Enabled)

            ElseIf TypeOf ctl Is DateTimePicker Then

                Dim dateTimePicker As DateTimePicker = DirectCast(ctl, DateTimePicker)
                Debug.WriteLine("Name: " & dateTimePicker.Name & "  »Enabled: " & dateTimePicker.Enabled)
                If IgnoreDateTimePickers.Contains(dateTimePicker) Then Continue For
                dateTimePicker.Enabled = Not TorF
                Debug.WriteLine("Name: " & dateTimePicker.Name & "  «Enabled: " & dateTimePicker.Enabled)

            ElseIf TypeOf ctl Is Button Then

                Dim button As Button = DirectCast(ctl, Button)
                Debug.WriteLine("Name: " & button.Name & "  »Enabled: " & button.Enabled)
                If IgnoreButtons.Contains(button) Then Continue For
                If ButtonsQPrecisamSerGuardados.Contains(button) And Not TorF Then ValoresGuardadosDosButtonsQPrecisamSerGuardados.Add(button.Enabled)
                button.Enabled = TorF
                If ButtonsQPrecisamSerGuardados.Contains(button) And TorF Then
                    button.Enabled = ValoresGuardadosDosButtonsQPrecisamSerGuardados(i)
                    i += 1
                End If
                Debug.WriteLine("Name: " & button.Name & "  «Enabled: " & button.Enabled)

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

    Sub iniciarAlteracaoUnica(buttonAltUnic As Button, componenteAltUnic As Control)
        TorF = False

        TextButAltUnic = buttonAltUnic.Text
        buttonAltUnic.Text = "Guardar"

        buttonAltUnicTemp = buttonAltUnic
        componenteAltUnicTemp = componenteAltUnic

        trocarBooleansParaAlteracaoUnica()
    End Sub

    Sub acabarAlteracaoUnica()
        TorF = True

        buttonAltUnicTemp.Text = TextButAltUnic

        trocarBooleansParaAlteracaoUnica()
    End Sub

    Sub trocarBooleansParaAlteracaoUnica()

        If TypeOf componenteAltUnicTemp Is TextBox Then
            Dim CTextBoxAltUnic As TextBox = DirectCast(componenteAltUnicTemp, TextBox)
            CTextBoxAltUnic.ReadOnly = TorF
        ElseIf TypeOf componenteAltUnicTemp Is NumericUpDown Then
            Dim CNumericUpDownAltUnic As NumericUpDown = DirectCast(componenteAltUnicTemp, NumericUpDown)
            CNumericUpDownAltUnic.Enabled = Not TorF
        ElseIf TypeOf componenteAltUnicTemp Is ComboBox Then
            Dim CComboBoxAltUnic As ComboBox = DirectCast(componenteAltUnicTemp, ComboBox)
            CComboBoxAltUnic.Enabled = Not TorF
            CComboBoxAltUnic.SelectionLength = 0
        ElseIf TypeOf componenteAltUnicTemp Is DateTimePicker Then
            Dim CComboBoxAltUnic As DateTimePicker = DirectCast(componenteAltUnicTemp, DateTimePicker)
            CComboBoxAltUnic.Enabled = Not TorF
        End If

        If ButtonNandG IsNot Nothing Then
            ButtonNandG.Enabled = TorF
        End If
        If ButtonRorEandC IsNot Nothing Then
            ButtonRorEandC.Enabled = TorF
        End If

        ButtonF.Enabled = TorF
        ButtonP.Enabled = TorF
        ButtonN.Enabled = TorF
        ButtonL.Enabled = TorF
    End Sub
End Module