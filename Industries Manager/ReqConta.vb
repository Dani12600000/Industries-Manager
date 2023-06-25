Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ReqConta
    Dim DefaultColor As Color
    Dim Alpha As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Profissões' table. You can move, or remove it, as needed.
        Me.ProfissõesTableAdapter.Fill(Me.Industries_DanDataSet.Profissões)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)
        FotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        Me.FuncionariosBindingSource.AddNew()

        Formulario = Me

        CenterOnScreenForm()

        DefaultColor = NomeTextBox.BackColor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim img As String

        OpenFileDialog1.Filter = "jpg png jfif| *.jpg; *.png; *.jfif"

        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            img = OpenFileDialog1.FileName
            FotoPictureBox.Image = System.Drawing.Bitmap.FromFile(img)
        End If

        FotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim todosCamposObrigatoriosPreenchidos, deuErro As Boolean
        Try
            todosCamposObrigatoriosPreenchidos = True

            If FuncionariosBindingSource.Find("Email", EmailTextBox.Text) = -1 Then

                Debug.WriteLine("Numero de caracteres NomeTextBox: " & NomeTextBox.Text.Length)

                If NomeTextBox.Text.Length < 2 Then
                    NomeTextBox.BackColor = Color.LightCoral
                    todosCamposObrigatoriosPreenchidos = False
                    Debug.WriteLine("Numero de caracteres no nome insuficiente")
                End If

                If SobrenomeTextBox.Text.Length < 2 Then
                    SobrenomeTextBox.BackColor = Color.LightCoral
                    todosCamposObrigatoriosPreenchidos = False
                    Debug.WriteLine("Numero de caracteres no sobrenome insuficiente")
                End If

                If Not Regex.IsMatch(EmailTextBox.Text, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") Then
                    EmailTextBox.BackColor = Color.LightCoral
                    todosCamposObrigatoriosPreenchidos = False
                    Debug.WriteLine("Email inválido")
                End If

                If PassTextBox.Text.Length < 7 Then
                    PassTextBox.BackColor = Color.LightCoral
                    todosCamposObrigatoriosPreenchidos = False
                    Debug.WriteLine("Palavra passe muito curta")
                End If

                If ProfissãoComboBox.SelectedIndex < 0 Then
                    ProfissãoComboBox.BackColor = Color.LightCoral
                    todosCamposObrigatoriosPreenchidos = False
                    Debug.WriteLine("Profissão não selecionada")
                End If

                If todosCamposObrigatoriosPreenchidos Then
                    Me.FuncionariosBindingSource.Current("ID_Profissão") = Me.ProfissõesBindingSource.Current("ID")
                    Me.FuncionariosBindingSource.Current("SI") = SINumericUpDown.Value
                    Me.Validate()
                    Me.FuncionariosBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.Industries_DanDataSet)
                    MsgBox("Conta requesitada com sucesso!" & vbCrLf & "Espere para ser aceito", vbInformation, "Sucesso")
                    Debug.WriteLine("Nova requesição feita")

                Else
                    MsgBox("Tem que preencher os campos obrigatorios" & vbCrLf & "(Os que se encontram agora a vermelho)", vbCritical, "Campos não preenchidos")
                    Return
                End If
            Else

                MsgBox("Já existe uma conta registada com esse mail, tente dar Login" & vbCrLf & "Se tiver problemas a dar Login entre em contacto com a equipa administrativa para lhe resetarem a palavra-pass", vbInformation, "Email já existente")
                Login.Show()
                Login.TextBox1.Text = EmailTextBox.Text
            End If
        Catch ex1 As Exception
            deuErro = True
            MsgBox("Houve um erro a fazer a requesição da sua conta por favor tente mais tarde ou entre em contacto com o suporte", vbCritical, "Erro")
            Debug.WriteLine("Erro ao fazer a requesição")
        Finally
            If deuErro Or todosCamposObrigatoriosPreenchidos Then
                Me.Close()
            End If
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Close()
    End Sub

    Private Sub NomeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NomeTextBox.KeyPress
        NomeTextBox.BackColor = DefaultColor
    End Sub

    Private Sub SobrenomeTextBox_KeyPress(sender As Object, e As EventArgs) Handles SobrenomeTextBox.KeyPress
        SobrenomeTextBox.BackColor = DefaultColor
    End Sub

    Private Sub EmailTextBox_KeyPress(sender As Object, e As EventArgs) Handles EmailTextBox.KeyPress
        EmailTextBox.BackColor = DefaultColor
    End Sub

    Private Sub PassTextBox_KeyPress(sender As Object, e As EventArgs) Handles PassTextBox.KeyPress
        PassTextBox.BackColor = DefaultColor
    End Sub

    Private Sub ProfissãoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProfissãoComboBox.SelectedIndexChanged
        ProfissãoComboBox.BackColor = DefaultColor
        Debug.WriteLine("Profissão position: " & ProfissõesBindingSource.Position)
        Debug.WriteLine("Profissão combobox: " & ProfissãoComboBox.SelectedIndex)
    End Sub

    Private Sub ReqConta_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ProfissãoComboBox.SelectedIndex = -1
        Debug.WriteLine("Profissão position: " & ProfissõesBindingSource.Position)
        Debug.WriteLine("Profissão combobox: " & ProfissãoComboBox.SelectedIndex)
    End Sub
End Class
