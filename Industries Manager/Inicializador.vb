Imports System.IO
Public Class Inicializador
    Private Sub Inicializador_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
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
        Else
            Instalador.Show()
        End If
    End Sub
End Class