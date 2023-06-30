Imports System.IO
Imports System.Windows.Forms.VisualStyles
Imports System.Drawing.Drawing2D
Imports Industries_Manager.Industries_DanDataSetTableAdapters
Imports Industries_Manager.Industries_DanDataSet

Public Class PMenu
    Dim TextOfFormButtonsPermitidos As List(Of String) = New List(Of String)()


    Private Class LogoutRenderer : Inherits ToolStripProfessionalRenderer
        Private ReadOnly logoutMenuItem As ToolStripMenuItem

        Public Sub New(logoutMenuItem As ToolStripMenuItem)
            Me.logoutMenuItem = logoutMenuItem
        End Sub

        Protected Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
            If e.Item.Selected Then
                Dim rc As New Rectangle(Point.Empty, e.Item.Size)
                If e.Item Is logoutMenuItem Then
                    ' Define a cor de destaque para o LogoutToolStripMenuItem
                    e.Graphics.FillRectangle(Brushes.LightCoral, rc)
                    e.Graphics.DrawRectangle(Pens.Red, 0, 0, rc.Width - 1, rc.Height - 1)
                Else
                    MyBase.OnRenderMenuItemBackground(e)
                    ' @TODO : Depois escolher cores melhores
                    ' Define a cor de destaque para o LogoutToolStripMenuItem
                    ' e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    ' e.Graphics.DrawRectangle(Pens.Gray, 0, 0, rc.Width - 1, rc.Height - 1)
                End If
            End If
        End Sub
    End Class


    Private Sub PMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarragamentoInicialProprio()
        MenuStrip1.Renderer = New LogoutRenderer(LogoutToolStripMenuItem)
    End Sub

    Sub CarragamentoInicialProprio()
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Leitura_de_avisos' table. You can move, or remove it, as needed.
        Me.Leitura_de_avisosTableAdapter.Fill(Me.Industries_DanDataSet.Leitura_de_avisos)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Avisos' table. You can move, or remove it, as needed.
        Me.AvisosTableAdapter.Fill(Me.Industries_DanDataSet.Avisos)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Login_Funcionario'. Você pode movê-la ou removê-la conforme necessário.
        Me.Login_FuncionarioTableAdapter.Fill(Me.Industries_DanDataSet.Login_Funcionario)


        Dim IG As String = ""
        If Hour(Now) >= 5 And Hour(Now) < 12 Then
            IG = "Bom dia"
        ElseIf Hour(Now) >= 12 And Hour(Now) < 21 Then
            IG = "Boa tarde"
        ElseIf Hour(Now) >= 21 Or Hour(Now) < 5 Then
            IG = "Boa noite"
        End If

        Label1.Text = IG + ", " + InfoUser.UserName

        'For debug
        Debug.WriteLine(vbCrLf & "PMenu form" & vbCrLf & "---------")
        Debug.WriteLine("ID : " & InfoUser.UserID)
        Debug.WriteLine("Ip : " & InfoUser.UserIp)
        Debug.WriteLine("Name : " & InfoUser.UserName)
        Debug.WriteLine("Email : " & InfoUser.UserEmail)
        Debug.WriteLine("Admin : " & InfoUser.UserAdm)
        Debug.WriteLine("ID Departamento : " & InfoUser.UserDepID)
        Debug.WriteLine("Departamento : " & InfoUser.UserDepName)
        Debug.Write("Diretor (Sim/Não) : ")
        Debug.WriteLineIf(Not InfoUser.UserDepDirectorYN, "Não")
        Debug.WriteLineIf(InfoUser.UserDepDirectorYN, "Sim")
        Debug.WriteLineIf(InfoUser.UserDepDirectorYN, "ID Diretor : " & InfoUser.UserDepDirectorID)
        Debug.WriteLine("Estas são todas as infos do user carregadas")


        If InfoUser.UserDepDirectorYN Then
            AvisosToolStripMenuItem.DropDownItems.Add(New ToolStripSeparator)

            Dim botaoVerAvisosMandados As New ToolStripButton("Ver Avisos Enviados")
            Dim botaoNovoAviso As New ToolStripButton("Enviar Novo Aviso")

            AddHandler botaoVerAvisosMandados.Click, AddressOf VerAvisosMandados_Click
            AddHandler botaoNovoAviso.Click, AddressOf NovoAviso_Click

            AvisosToolStripMenuItem.DropDownItems.Add(botaoVerAvisosMandados)
            AvisosToolStripMenuItem.DropDownItems.Add(botaoNovoAviso)

        End If



        ' AvisosBindingSource.Filter = "ID_Funcionario = " & InfoUser.UserID

        ' Fazer loop para buscar todos os Avisos não lidos e lidos pelo diretor do departamento

        ' AvisosBindingSource.Filter = "ID_Departamento = " & InfoUser.UserDepID

        ' Fazer loop para buscar todos os Avisos não lidos e lidos do Departamento

        Dim nenhumAvisoLabel As New ToolStripLabel("Nenhum aviso novo por agora") With {
            .ForeColor = Color.DimGray,
            .AutoSize = False,
            .Size = New Size(200, 30)
        }
        nenhumAvisoLabel.Font = New Font(nenhumAvisoLabel.Font, FontStyle.Italic)

        Dim avisosRecentes As New List(Of ToolStripLabel)

        AvisosBindingSource.Filter = "(DLDM IS NULL OR DLDM > #" & Today.ToString("MM/dd/yyyy") & "#) AND (ID_Departamento IS NULL OR ID_Departamento = " & InfoUser.UserDepID & ") AND (ID_Funcionario IS NULL OR ID_Funcionario = " & InfoUser.UserID & ")"


        For Each row As DataRowView In AvisosBindingSource
            ' Obtenha os dados relevantes da linha
            Dim titulo As String = row("Titulo").ToString()
            Dim id As Integer = CInt(row("ID"))

            ' Crie um ToolStripLabel para a linha
            Dim label As New ToolStripLabel()
            label.Text = titulo
            label.Tag = id

            ' Adicione o ToolStripLabel à lista
            avisosRecentes.Add(label)
        Next

        If avisosRecentes.Count = 0 Then
            AvisosToolStripMenuItem.DropDownItems.Insert(0, nenhumAvisoLabel)
        Else
            For Each label As ToolStripLabel In avisosRecentes
                Dim novoLabel As New ToolStripLabel(label.Text)
                novoLabel.BackColor = Color.LightGray
                novoLabel.ForeColor = Color.Black
                novoLabel.Size = New Size(200, 30)

                AddHandler novoLabel.MouseLeave, AddressOf avisosRecentes_MouseLeave
                AddHandler novoLabel.Click, AddressOf avisosRecentes_Click

                AvisosToolStripMenuItem.DropDownItems.Insert(0, novoLabel)
            Next
        End If



        Formulario = Me

        CenterOnScreenForm()

        Dim DepartamentosComPermissao As List(Of Integer) = New List(Of Integer)()

        ' depois fazer duas tabelas novas, uma que tenha todos os tipos de permissões existentes e outra que junte as permissões e os departamentos pois 1 departamento pode ter varias permissões e 1 permissão pode estar em varios departamentos 
        ' devido a isso depois vou ter que alterar isto

        Debug.WriteLine("")

        ' Inserção destes valores na lista

        ' Lista de departamentos com permissões para abrir
        DepartamentosComPermissao = New List(Of Integer) From { ' Clientes
            1, ' DSI
            2, ' ADM
            4, ' MKTG
            5, ' CONT
            10 ' VDS
        }
        Debug.WriteLine("ID_Departamentos permitidos para abrir o menu Clientes: " & String.Join(", ", DepartamentosComPermissao))

        If DepartamentosComPermissao.Contains(InfoUser.UserDepID) OrElse InfoUser.UserAdm Then TextOfFormButtonsPermitidos.Add("Clientes")

        ' Lista de departamentos com permissões para abrir
        DepartamentosComPermissao = New List(Of Integer) From { ' Departamentos
            1, ' DSI
            2, ' ADM
            3, ' RH
            5 ' CONT
        }
        Debug.WriteLine("ID_Departamentos permitidos para abrir o menu Departamentos: " & String.Join(", ", DepartamentosComPermissao))

        If DepartamentosComPermissao.Contains(InfoUser.UserDepID) OrElse InfoUser.UserAdm Then TextOfFormButtonsPermitidos.Add("Departamentos")

        ' Lista de departamentos com permissões para abrir
        DepartamentosComPermissao = New List(Of Integer) From { ' Fornecedores
            5, ' CONT
            9 ' COMP
        }
        Debug.WriteLine("ID_Departamentos permitidos para abrir o menu Fornecedores: " & String.Join(", ", DepartamentosComPermissao))

        If DepartamentosComPermissao.Contains(InfoUser.UserDepID) OrElse InfoUser.UserAdm Then TextOfFormButtonsPermitidos.Add("Fornecedores")

        ' Lista de departamentos com permissões para abrir
        DepartamentosComPermissao = New List(Of Integer) From { ' Funcionarios
            1, ' DSI
            2, ' ADM
            3, ' RH
            5 ' CONT
        }
        Debug.WriteLine("ID_Departamentos permitidos para abrir o menu Funcionarios: " & String.Join(", ", DepartamentosComPermissao))

        If DepartamentosComPermissao.Contains(InfoUser.UserDepID) OrElse InfoUser.UserAdm Then TextOfFormButtonsPermitidos.Add("Funcionarios")

        ' Lista de departamentos com permissões para abrir
        DepartamentosComPermissao = New List(Of Integer) From { ' Produtos
            4, ' MKTG
            8, ' DP
            10 ' VDS
        }
        Debug.WriteLine("ID_Departamentos permitidos para abrir o menu Produtos: " & String.Join(", ", DepartamentosComPermissao))

        If DepartamentosComPermissao.Contains(InfoUser.UserDepID) OrElse InfoUser.UserAdm Then TextOfFormButtonsPermitidos.Add("Produtos")

        ' Lista de departamentos com permissões para abrir
        DepartamentosComPermissao = New List(Of Integer) From { ' Profissões
            3 ' RH
        }
        Debug.WriteLine("ID_Departamentos permitidos para abrir o menu Profissões: " & String.Join(", ", DepartamentosComPermissao))

        If DepartamentosComPermissao.Contains(InfoUser.UserDepID) OrElse InfoUser.UserAdm Then TextOfFormButtonsPermitidos.Add("Profissões")

        Debug.WriteLine("")

        Debug.WriteLine("Menus a mostrar:")
        Dim separador As String = Environment.NewLine
        Debug.WriteLine(String.Join(separador, TextOfFormButtonsPermitidos))

        Dim botoesNaoUsados As List(Of Button) = New List(Of Button)()

        For i As Integer = 1 To 6
            Dim buttonName As String = "Button" & i
            Debug.WriteLine("Button name: " & buttonName)
            Dim button As Button = Me.Controls.OfType(Of Button)().FirstOrDefault(Function(btn) btn.Name = buttonName)

            If i <= TextOfFormButtonsPermitidos.Count Then
                button.Text = TextOfFormButtonsPermitidos(i - 1)
            Else
                button.Visible = False
                botoesNaoUsados.Add(button)
            End If
        Next

        Dim espacoNaoNecessario As Integer

        If botoesNaoUsados.Count > 0 Then
            espacoNaoNecessario = botoesNaoUsados(botoesNaoUsados.Count - 1).Location.Y - botoesNaoUsados(0).Location.Y

            Me.Height = Me.ClientSize.Height - espacoNaoNecessario

            For Each button As Button In Me.Controls.OfType(Of Button)()
                Desancorar(button, True, True, False, False)
            Next
        End If

    End Sub

    Private Sub avisosRecentes_MouseLeave(sender As Object, e As EventArgs)
        Dim label As ToolStripLabel = DirectCast(sender, ToolStripLabel)
        label.BackColor = SystemColors.Control
        label.ForeColor = SystemColors.ControlText
    End Sub

    Private Sub avisosRecentes_Click(sender As Object, e As EventArgs)
        Dim label As ToolStripLabel = DirectCast(sender, ToolStripLabel)
        Debug.WriteLine("Clicou no item: " & label.Text)
    End Sub



    Private Sub VerAvisosMandados_Click(sender As Object, e As EventArgs)
        Avisos.Show()
    End Sub

    Private Sub NovoAviso_Click(sender As Object, e As EventArgs)
        DetalhesAviso.Show()
        DetalhesAviso.NovoAviso()
    End Sub


    Private Sub PMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login_FuncionarioBindingSource.AddNew()
        Login_FuncionarioBindingSource.Current("ID_Funcionario") = InfoUser.UserID
        Login_FuncionarioBindingSource.Current("LiOuLo") = "Logout"
        Login_FuncionarioBindingSource.Current("DeH") = Now()
        Login_FuncionarioBindingSource.Current("Ip") = InfoUser.UserIp

        Login_FuncionarioBindingSource.EndEdit()
        Login_FuncionarioTableAdapter.Update(Industries_DanDataSet.Login_Funcionario)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RedirecionarParaFormCorrespondente(Button1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RedirecionarParaFormCorrespondente(Button2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RedirecionarParaFormCorrespondente(Button3.Text)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ApagarArquivo()
        Login.Show()
        Me.Close()
    End Sub

    Private Sub ApagarArquivo()
        Dim caminhoArquivo As String = "C:\Industries Dan_PAP\DadosMemorizados.json"

        If File.Exists(caminhoArquivo) Then
            File.Delete(caminhoArquivo)
            Debug.WriteLine("Arquivo apagado com sucesso!")
        Else
            Debug.WriteLine("Arquivo não encontrado.")
        End If
    End Sub

    Private Sub Login_FuncionarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Login_FuncionarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Industries_DanDataSet)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RedirecionarParaFormCorrespondente(Button4.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RedirecionarParaFormCorrespondente(Button5.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RedirecionarParaFormCorrespondente(Button6.Text)
    End Sub

    Sub RedirecionarParaFormCorrespondente(TextOnButton As String)
        If TextOnButton = "Clientes" Then
            Clientes.Show()
        ElseIf TextOnButton = "Departamentos" Then
            Departamentos.Show()
        ElseIf TextOnButton = "Fornecedores" Then
            Fornecedores.Show()
        ElseIf TextOnButton = "Funcionarios" Then
            Funcionarios.Show()
        ElseIf TextOnButton = "Produtos" Then
            Produtos.Show()
        ElseIf TextOnButton = "Profissões" Then
            Profissões.Show()
        End If
    End Sub
End Class
