Module ControleAlteracoes
    Public Formulario As Form
    Public ButtonNG, ButtonEC, ButtonF, ButtonP, ButtonN, ButtonL, ButtonE As Button
    Dim TextButNG, TextButEC As String
    Dim TorF As Boolean

    Sub iniciarAlteracoes()
        TorF = False

        TrocarBooleans()

        TextButNG = ButtonNG.Text
        TextButEC = ButtonEC.Text

        Debug.WriteLine("TextButNG : " & TextButNG)
        Debug.WriteLine("TextButEC : " & TextButEC)

        ButtonNG.Text = "Guardar"
        ButtonEC.Text = "Cancelar"
    End Sub

    Sub acabarAlteracoes()
        TorF = True

        TrocarBooleans()

        Debug.WriteLine("TextButNG : " & TextButNG)
        Debug.WriteLine("TextButEC : " & TextButEC)

        ButtonNG.Text = TextButNG
        ButtonEC.Text = TextButEC
    End Sub

    Sub TrocarBooleans()
        For Each ctl As Control In Formulario.Controls
            If TypeOf ctl Is TextBox Then
                Dim textBox As TextBox = DirectCast(ctl, TextBox)
                textBox.ReadOnly = TorF
            End If
        Next

        ButtonF.Enabled = TorF
        ButtonP.Enabled = TorF
        ButtonN.Enabled = TorF
        ButtonL.Enabled = TorF
        Try
            ButtonE.Enabled = TorF
        Catch
        End Try
    End Sub
End Module
