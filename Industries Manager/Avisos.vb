Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Avisos

    Private Sub Avisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Leitura_de_avisos'. Você pode movê-la ou removê-la conforme necessário.
        Me.Leitura_de_avisosTableAdapter.Fill(Me.Industries_DanDataSet.Leitura_de_avisos)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Funcionarios' table. You can move, or remove it, as needed.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Avisos' table. You can move, or remove it, as needed.
        Me.AvisosTableAdapter.Fill(Me.Industries_DanDataSet.Avisos)

        Formulario = Me

        Me.Width = Me.ClientSize.Width * 1.15

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
        AvisosDataGridView.Sort(AvisosDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        CenterOnScreenForm()
        CarregarPaletaDeCores()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Clipboard.SetText(AvisoTextBox.Text)
        MsgBox("Texto copiado", vbInformation)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button9.Text = "Novo" Then
            DetalhesAviso.Show()
            DetalhesAviso.NovoAviso()
        ElseIf Button9.Text = "Guardar" Then
            acabarAlteracoes()

            AvisosBindingSource.EndEdit()
            AvisosTableAdapter.Update(Industries_DanDataSet)

        End If
    End Sub

    Private Sub AtualizarLabelsinTextBoxesAndButtons()

        Dim quantidadeGeralDeFuncionariosQueLeram As String
        Dim dataAtual As Date = Today()

        If AvisosBindingSource.Position >= 0 Then
            'Caso haja um aviso

            Dim FDFDP As String = AvisosBindingSource.Current("FDFDP") ' Forma de fim de prazo
            Dim FDE As String ' Forma de envio

            If Not IsDBNull(AvisosBindingSource.Current("ID_Funcionario")) Then
                FuncionariosBindingSource.Filter = "ID = " & AvisosBindingSource.Current("ID_Funcionario")
                If FuncionariosBindingSource.Current("ID_Departamento") = InfoUser.UserDepID Then
                    FDE = "Funcionario"
                Else
                    FDE = "Diretor"
                End If
            Else
                FDE = "Departamento"
            End If

            Button1.Enabled = True
            If FDFDP = "Data" Then

                DLDMAndFDFDPLabel.Visible = True
                DLDMDateTimePicker.Visible = True
                TextBox4.Visible = True
                Label5.Visible = True

                Button1.Enabled = True
                If AvisosBindingSource.Current("DLDM") > Today Then
                    Button1.Text = "Terminar agora"
                    If DiferencaEntreHojeAndDataNumero(AvisosBindingSource.Current("DLDM")) > 0 Then
                        Label5.Text = "Faltam"
                    Else
                        Label5.Text = "Falta"
                    End If
                    Label5.Visible = True
                    TextBox4.Visible = True
                    TextBox4.Text = FuncoesRepetitivas.DiferencaEntreHojeAndDataTexto(AvisosBindingSource.Current("DLDM"))
                End If
                Button10.Visible = False
            ElseIf FDFDP = "Todos leram" Then

                DLDMAndFDFDPLabel.Visible = False
                DLDMDateTimePicker.Visible = False
                TextBox4.Visible = True
                Label5.Visible = True
                Button10.Enabled = False

                Leitura_de_avisosBindingSource.Filter = "ID_Aviso = " & IDTextBox.Text
                FuncionariosBindingSource.Filter = "ID_Departamento = " & InfoUser.UserDepID

                Dim numeroDeFuncionariosQueFaltamLerParaFechar As Integer = FuncionariosBindingSource.Count - Leitura_de_avisosBindingSource.Count - 1

                Label5.Text = "Falta"
                TextBox4.Text = numeroDeFuncionariosQueFaltamLerParaFechar

                TextBox4.Text &= " "
                If numeroDeFuncionariosQueFaltamLerParaFechar > 1 Then
                    TextBox4.Text &= "funcionários"
                Else
                    TextBox4.Text &= "funcionário"
                End If

                Button1.Text = "Terminar agora"
                Button10.Visible = True
                Button10.Enabled = True
            ElseIf FDFDP = "Nunca" Then

                DLDMDateTimePicker.Visible = False
                TextBox4.Visible = False
                Label5.Visible = False


                Button1.Text = "Terminar agora"
                Button10.Visible = False
                Button10.Enabled = True
            End If

            Dim dataTransmissao As Date = CDate(AvisosBindingSource.Current("DT"))

            If dataAtual = dataTransmissao Then
                Label6.Text = "Transmitido"
                TextBox5.Text = "Hoje"
            Else
                Label6.Text = "Transmitido há"
                TextBox5.Text = DiferencaEntreDataAndHojeTexto(dataTransmissao)
                TextBox3.Text = "Transmitindo"
            End If

            TextBox2.Text = "lido por "

            ' Depois fazer o codigo para mudar o que está aqui escrito dependo o numero de funcionarios que leram
            quantidadeGeralDeFuncionariosQueLeram = "ninguem"



            TextBox2.Text &= quantidadeGeralDeFuncionariosQueLeram

            If Not quantidadeGeralDeFuncionariosQueLeram = "ninguem" OrElse FDFDP = "Departamento" Then
                Button10.Enabled = True
            Else
                Button10.Enabled = False
            End If

            If (Not IsDBNull(AvisosBindingSource.Current("DLDM"))) AndAlso AvisosBindingSource.Current("DLDM") = Today Then
                Button1.Text = "Prolongar"
                Label5.Text = "Terminou"
                Label5.Visible = True
                TextBox4.Visible = True
                TextBox4.Text = "Hoje"
                TextBox3.Text = "Transmitido"
                DLDMDateTimePicker.Visible = True
                DLDMAndFDFDPLabel.Visible = True

            ElseIf (Not IsDBNull(AvisosBindingSource.Current("DLDM"))) AndAlso AvisosBindingSource.Current("DLDM") < Today Then
                Button1.Text = "Prolongar"
                Label5.Text = "Passou"
                Label5.Visible = True
                TextBox4.Visible = True
                TextBox4.Text = FuncoesRepetitivas.DiferencaEntreDataAndHojeTexto(DLDMDateTimePicker.Value)
                TextBox3.Text = "Transmitido"
                DLDMDateTimePicker.Visible = True
                DLDMAndFDFDPLabel.Visible = True

            End If
        Else
            'Caso não haja nenhum aviso

            If AvisoTextBox.Text = "" Then
                Button7.Enabled = False
            End If

            Button1.Visible = False

            TextBox2.Text = ""
            TextBox3.Text = ""

            MsgBox("Crie um aviso primeiro", vbOKOnly)
            ' Abrir form para criar um aviso
            DetalhesAviso.Show()

            DetalhesAviso.NovoAviso()

            Me.Close()

            DetalhesAviso.Activate()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Terminar agora" Then
            DLDMDateTimePicker.Value = Today
            AvisosBindingSource.EndEdit()
            AvisosTableAdapter.Update(Industries_DanDataSet)
            AtualizarLabelsinTextBoxesAndButtons()
        ElseIf Button1.Text = "Prolongar" Then

            Dim dataString As String
            Dim data As Date

            While data = Nothing OrElse data < Today
                Try
                    While dataString = Nothing OrElse dataString.Length < 5
                        dataString = InputBox("Digite uma data no formato dd/MM ou dd/MM/yyyy:")
                    End While


                    ' Verifica se a data possui apenas dia e mês (dd/MM)
                    If dataString.Length = 5 Then
                        ' Obtém o dia e o mês atual
                        Dim diaAtual As Integer = Date.Now.Day
                        Dim mesAtual As Integer = Date.Now.Month

                        ' Obtém o dia e o mês da data fornecida
                        Dim dia As Integer = Integer.Parse(dataString.Substring(0, 2))
                        Dim mes As Integer = Integer.Parse(dataString.Substring(3, 2))

                        ' Verifica se a data fornecida é posterior à data atual
                        If mes > mesAtual OrElse (mes = mesAtual AndAlso dia >= diaAtual) Then
                            ' Usa o ano atual
                            data = New Date(Date.Now.Year, mes, dia)
                        Else
                            ' Usa o próximo ano
                            data = New Date(Date.Now.Year + 1, mes, dia)
                        End If

                    Else



                        ' A data possui dia, mês e ano (dd/MM/yyyy)
                        data = Date.ParseExact(dataString, "dd/MM/yyyy", Nothing)
                    End If
                Catch
                    dataString = Nothing
                End Try

        Debug.WriteLine("Data: " & data)
            End While

            AvisosBindingSource.Current("DLDM") = data
            AvisosBindingSource.EndEdit()
            AvisosTableAdapter.Update(Industries_DanDataSet)
            AvisosDataGridView.Refresh()
            AtualizarLabelsinTextBoxesAndButtons()
        End If
    End Sub

    Private Sub Avisos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        PMenu.Activate()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ' Update Futuro
        MsgBox("Será implementado num futuro update")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        iniciarAlteracoes()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DetalhesAviso.Show()
        DetalhesAviso.NovoAviso()
        DetalhesAviso.TituloTextBox.Text = TituloTextBox.Text
        DetalhesAviso.AvisoTextBox.Text = AvisoTextBox.Text
        Dim ID_FuncionarioLoc As String
        Dim ID_DepartamentoLoc As String

        If Not IsDBNull(AvisosBindingSource.Current("ID_Funcionario")) Then ID_FuncionarioLoc = AvisosBindingSource.Current("ID_Funcionario")
        If Not IsDBNull(AvisosBindingSource.Current("ID_Departamento")) Then ID_DepartamentoLoc = AvisosBindingSource.Current("ID_Departamento")

        DetalhesAviso.CarregarAvisoParaReenviar(ID_FuncionarioLoc, ID_DepartamentoLoc, AvisosBindingSource.Current("FDFDP"))

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AvisosBindingSource.MoveFirst()
        AtualizarLabelsinTextBoxesAndButtons()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AvisosBindingSource.MovePrevious()
        AtualizarLabelsinTextBoxesAndButtons()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AvisosBindingSource.MoveNext()
        AtualizarLabelsinTextBoxesAndButtons()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AvisosBindingSource.MoveLast()
        AtualizarLabelsinTextBoxesAndButtons()
    End Sub

    Private Sub Avisos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        AtualizarLabelsinTextBoxesAndButtons()
    End Sub
End Class