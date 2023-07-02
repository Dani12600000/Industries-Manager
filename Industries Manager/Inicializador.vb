Imports System.IO
Public Class Inicializador
    Private Sub Inicializador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists("C:\Industries Dan_PAP\Industries Dan.mdb") Then
            'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)

            If FuncionariosBindingSource.Count = 0 Then
                ReqConta.Show()
                ReqConta.Alpha = True
            Else
                Login.Show()
            End If
            Me.Close()
        End If
    End Sub
End Class