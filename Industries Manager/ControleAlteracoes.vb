Module ControleAlteracoes
    Dim Formulario As Form
    Dim TorF As Boolean

    Sub iniciarAlteracoes()
        TorF = True

        For Each ctl As Control In Formulario.Controls
            If TypeOf ctl Is TextBox Then
                Dim textBox As TextBox = DirectCast(ctl, TextBox)
                textBox.ReadOnly = TorF
            End If
        Next
        Try
            Formulario.ButtonNG.Text = "Guardar"
            Formulario.ButtonEC.Text = "Cancelar"
            Formulario.Button1.Enabled = TorF
            Formulario.Button2.Enabled = TorF
            Formulario.Button3.Enabled = TorF
            Formulario.Button4.Enabled = TorF
        Catch
        End Try
    End Sub

    Sub acabarAlteracoes()
        TorF = True

        For Each ctl As Control In Formulario.Controls
            If TypeOf ctl Is TextBox Then
                Dim textBox As TextBox = DirectCast(ctl, TextBox)
                textBox.ReadOnly = TorF
            End If
        Next
        Formulario.ButtonNG.Text = "Novo"
        Formulario.ButtonEC.Text = "Eliminar"
        Formulario.Button1.Enabled = TorF
        Formulario.Button2.Enabled = TorF
        Formulario.Button3.Enabled = TorF
        Formulario.Button4.Enabled = TorF
    End Sub
End Module
