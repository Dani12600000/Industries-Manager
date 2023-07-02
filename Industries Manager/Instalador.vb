Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Threading

Public Class Instalador
    Dim vezesNecessariasAumentarProgressBar As Integer = 13
    Dim valorASubir As Double = 100 / vezesNecessariasAumentarProgressBar
    Dim NumeroDeFicheirosTransferidos As Integer
    Dim colocarAtalhoNoAmbienteTrabalho As Boolean
    Dim subtituirPorAtalhoAqui As Boolean

    Private Sub Instalador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializador.Close()
        colocarAtalhoNoAmbienteTrabalho = MsgBox("Deseja inserir um atalho no ambiente de trabalho?", vbYesNo, "Atalho no ambiente de trabalho") = MsgBoxResult.Yes

        If colocarAtalhoNoAmbienteTrabalho = False Then
            subtituirPorAtalhoAqui = True
        Else
            subtituirPorAtalhoAqui = MsgBox("Deseja manter o aplicativo aqui?", vbYesNo, "Manter aqui") = MsgBoxResult.Yes
        End If
    End Sub

    Private Async Sub Instalador_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        AumentarProgressBarAndAlterarLabels("Iniciando conexão a internet...", False)
        ' Crie uma instância de HttpClient
        Dim httpClient As New HttpClient()
        AumentarProgressBarAndAlterarLabels("Conectado com sucesso!", False)

        Dim destino As String = "C:\Industries Dan_PAP\"

        AumentarProgressBarAndAlterarLabels("Iniciando transferencia da base de dados...", False)
        Await DownloadArquivoAsync("https://github.com/Dani12600000/Industries-Manager/raw/master/Industries%20Dan.mdb", destino & "Industries Dan.mdb")
        AumentarProgressBarAndAlterarLabels("Transferido com sucesso a base de dados!", True)

        AumentarProgressBarAndAlterarLabels("Iniciando transferencia do ficheiro Newtonsoft.Json.dll...", False)
        Await DownloadArquivoAsync("https://github.com/Dani12600000/Industries-Manager/raw/master/Newtonsoft.Json.dll", destino & "Newtonsoft.Json.dll")
        AumentarProgressBarAndAlterarLabels("Transferido com sucesso o ficheiro Newtonsoft.Json.dll!", True)

        AumentarProgressBarAndAlterarLabels("Iniciando transferencia do ficheiro Newtonsoft.Json.xml...", False)
        Await DownloadArquivoAsync("https://github.com/Dani12600000/Industries-Manager/raw/master/Newtonsoft.Json.xml", destino & "Newtonsoft.Json.xml")
        AumentarProgressBarAndAlterarLabels("Transferido com sucesso o ficheiro Newtonsoft.Json.xml!", True)

        AumentarProgressBarAndAlterarLabels("Terminando a conexão a internet...", False)
        httpClient.Dispose()
        AumentarProgressBarAndAlterarLabels("Terminado com sucesso!", False)

        CriarAtalhoDoExecutavelAndMove(destino)
    End Sub

    Sub AumentarProgressBarAndAlterarLabels(TarefaAExecutar As String, AumentarNumeroDeFicheirosTransferidos As Boolean)
        If ProgressBar1.Value + valorASubir > 100 Then
            ProgressBar1.Value = 100
        Else
            ProgressBar1.Value += valorASubir
        End If

        Label1.Text = TarefaAExecutar
        If AumentarNumeroDeFicheirosTransferidos Then NumeroDeFicheirosTransferidos += 1
        Label2.Text = "Transferidos " & NumeroDeFicheirosTransferidos & " de 3 ficheiros"
    End Sub

    ' Função assíncrona para fazer o download de um arquivo
    Private Async Function DownloadArquivoAsync(url As String, destino As String) As Task
        ' Crie um objeto HttpClient para fazer o download do arquivo
        Using httpClient As New HttpClient()
            ' Faça o download do arquivo e salve-o no destino
            Using response As HttpResponseMessage = Await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead)
                Using content As HttpContent = response.Content
                    Using stream As Stream = Await content.ReadAsStreamAsync()
                        Using fileStream As FileStream = File.Create(destino)
                            ' Defina o tamanho do buffer para controlar a leitura do stream
                            Dim buffer As Byte() = New Byte(8192) {}
                            Dim bytesRead As Integer

                            ' Obtenha o tamanho total do conteúdo do arquivo
                            Dim contentLength As Long = content.Headers.ContentLength.GetValueOrDefault()

                            ' Leia o stream e grave os dados no arquivo
                            Do
                                bytesRead = Await stream.ReadAsync(buffer, 0, buffer.Length)
                                Await fileStream.WriteAsync(buffer, 0, bytesRead)

                            Loop While bytesRead > 0
                        End Using
                    End Using
                End Using
            End Using
        End Using
    End Function

    Private Sub WebClient_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        ' Atualize o valor da ProgressBar com base no progresso do download
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub CriarAtalhoDoExecutavelAndMove(destino As String)
        Dim caminhoExecutavel As String = System.Reflection.Assembly.GetExecutingAssembly().Location
        Dim novoCaminhoExecutavel As String = Path.Combine(destino, Path.GetFileName(caminhoExecutavel))

        ' Mover o executável para o novo destino
        File.Move(caminhoExecutavel, novoCaminhoExecutavel)

        AumentarProgressBarAndAlterarLabels("Criando atalho(s)...", False)

        If colocarAtalhoNoAmbienteTrabalho Then
            ' Criação do atalho na área de trabalho
            Dim atalhoDesktop As Object = CreateObject("WScript.Shell").CreateShortcut(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Industries Manager.lnk"))
            atalhoDesktop.TargetPath = novoCaminhoExecutavel
            atalhoDesktop.Save()
        End If

        If subtituirPorAtalhoAqui Then
            ' Criação do atalho na antiga localização do executável
            Dim atalhoAntigo As Object = CreateObject("WScript.Shell").CreateShortcut(Path.Combine(Path.GetDirectoryName(caminhoExecutavel), "Industries Manager.lnk"))
            atalhoAntigo.TargetPath = novoCaminhoExecutavel
            atalhoAntigo.Save()
        End If

        AumentarProgressBarAndAlterarLabels("Atalho(s) criado(s) com sucesso!", False)

        Process.Start(novoCaminhoExecutavel)

        AumentarProgressBarAndAlterarLabels("Reiniciando o aplicativo", False)
        Process.GetCurrentProcess().Kill()
    End Sub
End Class