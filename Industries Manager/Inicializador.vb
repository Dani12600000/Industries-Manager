Imports System.IO
Imports System.Net
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
        Else
            ' Crie uma instância de WebClient
            Dim webClient As New WebClient()

            ' Especifique o local de destino para o arquivo
            Dim destino As String = "C:\Industries Dan_PAP\Industries Dan.mdb"

            ' Faça o download dos arquivos usando o link direto
            webClient.DownloadFile("https://github.com/Dani12600000/Industries-Manager/raw/master/Industries%20Dan.mdb", destino)
            webClient.DownloadFile("", destino)

            ' Libere os recursos do WebClient
            webClient.Dispose()
        End If
    End Sub
End Class