Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ReqConta

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)
        FotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        Me.FuncionariosBindingSource.AddNew()
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
        Try
            If FuncionariosBindingSource.Find("Email", EmailTextBox.Text) = -1 Then
                Me.Validate()
                Me.FuncionariosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Industries_DanDataSet)
                MsgBox("Conta requesitada com sucesso!" & vbCrLf & "Espere para ser aceito", vbInformation, "Sucesso")
                Debug.WriteLine("Nova requesição feita")
            Else
                MsgBox("Já existe uma conta registada com esse mail, tente dar Login" & vbCrLf & "Se tiver problemas a dar Login entre em contacto com a equipa administrativa para lhe resetarem a palavra-pass", vbInformation, "Email já existente")
                Login.Show()
                Login.TextBox1.Text = EmailTextBox.Text
                Me.Close()
            End If
        Catch
            MsgBox("Houve um erro a fazer a requesição da sua conta por favor tente mais tarde ou entre em contacto com o suporte", vbCritical, "Erro")
            Debug.WriteLine("Erro ao fazer a requesição")
        Finally
            Me.Close()
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Close()
    End Sub
End Class
