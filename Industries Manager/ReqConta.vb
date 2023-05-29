﻿Public Class ReqConta

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)
        FotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        Me.FuncionariosBindingSource.AddNew()
        DDEDEDateTimePicker.Value = Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim img As String

        OpenFileDialog1.Filter = "jpg png jfif| *.jpg; *.png; *.jfif"

        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            img = OpenFileDialog1.FileName
            FotoPictureBox.Image = System.Drawing.Bitmap.FromFile(img)
        End If

        FotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Validate()
            Me.FuncionariosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Industries_DanDataSet)
            MsgBox("Conta requesitada com sucesso!" & vbCrLf & "Espere para ser aceito", vbInformation, "Sucesso")
        Catch

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Close()
    End Sub
End Class
