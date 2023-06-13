Module ControleAlteracoes
    Public Formulario As Form
    Public ButtonNG, ButtonEC, ButtonF, ButtonP, ButtonN, ButtonL As Button
    Dim TextButNG, TextButEC As String
    Dim TorF As Boolean

    Sub iniciarAlteracoes()
        TorF = False

        TrocarBooleans()

        ButtonNG.Text = "Guardar"
        ButtonEC.Text = "Cancelar"
    End Sub

    Sub acabarAlteracoes()
        TorF = True

        TrocarBooleans()

        ButtonNG.Text = "Novo"
        ButtonEC.Text = "Eliminar"
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
    End Sub
End Module
