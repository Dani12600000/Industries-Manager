Public Class Avisos

    Private Sub Avisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Avisos' table. You can move, or remove it, as needed.
        Me.AvisosTableAdapter.Fill(Me.Industries_DanDataSet.Avisos)

        Me.Width = Me.ClientSize.Width * 1.09

        Formulario = Me
        ButtonNandG = Button9
        ButtonRorEandC = Button8
        ButtonF = Button5
        ButtonP = Button2
        ButtonN = Button3
        ButtonL = Button4

        IgnoreTextBoxs.Add(TextBox2)
        IgnoreTextBoxs.Add(TextBox3)
        IgnoreTextBoxs.Add(TextBox5)
        IgnoreTextBoxs.Add(TextBox4)
        IgnoreDateTimePickers.Add(DTDateTimePicker)
        IgnoreDateTimePickers.Add(DLDMDateTimePicker)

        AvisosBindingSource.Filter = "ID_Diretor = " & InfoUser.UserDepDirectorID
        AtualizarLabelsinTextBoxesAndButtons()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Clipboard.SetText(AvisoTextBox.Text)
        MsgBox("Texto copiado", vbInformation)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button9.Text = "Novo" Then
            ' Vou abrir outro form
        ElseIf Button9.Text = "Guardar" Then
            acabarAlteracoes()

            AvisosBindingSource.EndEdit()
            AvisosTableAdapter.Update(Industries_DanDataSet)

        End If
    End Sub

    Private Sub AtualizarLabelsinTextBoxesAndButtons()

        If AvisosBindingSource.Position >= 0 Then
            'Caso haja um aviso

            Dim FDFDP As String = "Data" ' Depois substituir isto com a variavel na base de dados

            Button1.Enabled = True
            If FDFDP = "Data" Then



                If DLDMDateTimePicker.Value > Today Then
                    Button1.Text = "Terminar agora"
                Else
                    Button1.Text = "Prolongar"
                End If
            ElseIf FDFDP = "Todos leram" Then

                DLDMDateTimePicker.Visible = False
                TextBox4.Visible = False
                Label5.Visible = False



                Button1.Text = "Terminar agora"
            ElseIf FDFDP = "Nunca" Then



                Button1.Text = "Terminar agora"
            End If


        Else
            'Caso não haja nenhum aviso

            If AvisoTextBox.Text = "" Then
                Button7.Enabled = False
            End If

            Button1.Visible = False

            TextBox2.Text = ""
            TextBox3.Text = ""

            MsgBox("Crie um aviso primeiro", vbOK)
            ' Abrir form para criar um aviso
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DLDMDateTimePicker.Value = Today
        AvisosBindingSource.EndEdit()
        AvisosTableAdapter.Update(Industries_DanDataSet)
        AtualizarLabelsinTextBoxesAndButtons()
    End Sub
End Class