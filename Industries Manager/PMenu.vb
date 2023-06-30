Imports System.IO
Imports System.Windows.Forms.VisualStyles
Imports System.Drawing.Drawing2D
Imports Industries_Manager.Industries_DanDataSetTableAdapters
Imports Industries_Manager.Industries_DanDataSet

Public Class PMenu
    Dim TextOfFormButtonsPermitidos As List(Of String) = New List(Of String)()
    Dim novosAvisosBooleanExterior As Boolean


    Private Class LogoutAndAvisosRenderer : Inherits ToolStripProfessionalRenderer
        Private ReadOnly logoutMenuItem As ToolStripMenuItem
        Private ReadOnly avisosMenuItem As ToolStripMenuItem
        Public novosAvisos As Boolean

        Public Sub New(logoutMenuItem As ToolStripMenuItem, avisosMenuItem As ToolStripMenuItem, novosAvisosBoolean As Boolean)
            Me.logoutMenuItem = logoutMenuItem
            Me.avisosMenuItem = avisosMenuItem
            novosAvisos = novosAvisosBoolean
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
                    ' e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    ' e.Graphics.DrawRectangle(Pens.Gray, 0, 0, rc.Width - 1, rc.Height - 1)
                End If
            ElseIf e.Item Is avisosMenuItem And novosAvisos Then
                Dim rc As New Rectangle(Point.Empty, e.Item.Size)
                If novosAvisos Then
                    e.Graphics.FillRectangle(Brushes.IndianRed, rc)
                Else
                    MyBase.OnRenderMenuItemBackground(e)
                End If
            End If
        End Sub
    End Class


    Private Sub PMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Industries_DanDataSet.Departamentos' table. You can move, or remove it, as needed.
        Me.DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Departamentos)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Diretores_de_Departamentos' table. You can move, or remove it, as needed.
        Me.Diretores_de_DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Diretores_de_Departamentos)

        'TODO: This line of code loads data into the 'Industries_DanDataSet.Funcionarios' table. You can move, or remove it, as needed.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)
        CarragamentoInicialProprio()
        MenuStrip1.Renderer = New LogoutAndAvisosRenderer(LogoutToolStripMenuItem, AvisosToolStripMenuItem, novosAvisosBooleanExterior)
    End Sub

    Sub CarragamentoInicialProprio()
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Leitura_de_avisos' table. You can move, or remove it, as needed.
        Me.Leitura_de_avisosTableAdapter.Fill(Me.Industries_DanDataSet.Leitura_de_avisos)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Avisos' table. You can move, or remove it, as needed.
        Me.AvisosTableAdapter.Fill(Me.Industries_DanDataSet.Avisos)
        'TODO: esta linha de código carrega dados na tabela 'Industries_DanDataSet.Login_Funcionario'. Você pode movê-la ou removê-la conforme necessário.
        Me.Login_FuncionarioTableAdapter.Fill(Me.Industries_DanDataSet.Login_Funcionario)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Diretores_de_Departamentos' table. You can move, or remove it, as needed.
        Me.Diretores_de_DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Diretores_de_Departamentos)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Departamentos' table. You can move, or remove it, as needed.
        Me.DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Departamentos)


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
        Debug.WriteLine("Surname : " & InfoUser.UserSurname)
        Debug.WriteLine("First Name : " & InfoUser.UserFirstName)
        Debug.WriteLine("Last Name : " & InfoUser.UserLastName)
        Debug.WriteLine("Email : " & InfoUser.UserEmail)
        Debug.WriteLine("Admin : " & InfoUser.UserAdm)
        Debug.WriteLine("ID Departamento : " & InfoUser.UserDepID)
        Debug.WriteLine("Departamento : " & InfoUser.UserDepName)
        Debug.Write("Diretor (Sim/Não) : ")
        Debug.WriteLineIf(Not InfoUser.UserDepDirectorYN, "Não")
        Debug.WriteLineIf(InfoUser.UserDepDirectorYN, "Sim")
        Debug.WriteLineIf(InfoUser.UserDepDirectorYN, "ID Diretor : " & InfoUser.UserDepDirectorID)
        Debug.WriteLine("Estas são todas as infos do user carregadas")

        Formulario = Me

        CenterOnScreenForm()

        AtualizarInfosAvisos()

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

        For i = 0 To DepartamentosBindingSource.Count - 1

            DepartamentosBindingSource.Position = i

            Debug.WriteLine(DepartamentosBindingSource.Current("ID"))

            InfoEnterprise.IDDepartamento.Add(DepartamentosBindingSource.Current("ID"))
            InfoEnterprise.AbreviaturaDepartamento.Add(DepartamentosBindingSource.Current("ADD"))
            InfoEnterprise.NomeDepartamento.Add(DepartamentosBindingSource.Current("NDD"))

            Diretores_de_DepartamentosBindingSource.Filter = "ID_Departamento = " & DepartamentosBindingSource.Current("ID") & " AND DDC <= #" & DateTime.Today.ToString("MM/dd/yyyy") & "# AND (DDF IS NULL OR DDF > #" & DateTime.Today.ToString("MM/dd/yyyy") & "#)"
            Diretores_de_DepartamentosBindingSource.Sort = "DDC DESC"
            Diretores_de_DepartamentosBindingSource.MoveFirst()

            If Diretores_de_DepartamentosBindingSource.Current IsNot Nothing Then

                InfoEnterprise.IDDiretorDepartamento.Add(Diretores_de_DepartamentosBindingSource.Current("ID_Funcionario"))

                FuncionariosBindingSource.Filter = "ID = " & Diretores_de_DepartamentosBindingSource.Current("ID_Funcionario")

                Dim nomeDiretorCompleto As String
                nomeDiretorCompleto = FuncionariosBindingSource.Current("Nome") & " " & FuncionariosBindingSource.Current("Sobrenome")

                InfoEnterprise.NomeCompletoDiretorDepartamento.Add(nomeDiretorCompleto)
                Dim nomeSeparado() As String = InfoEnterprise.NomeCompletoDiretorDepartamento(i).Split(" "c)
                InfoEnterprise.PrimeiroNomeDiretorDepartamento.Add(nomeSeparado(0))
                InfoEnterprise.UltimoNomeDiretorDepartamento.Add(nomeSeparado(nomeSeparado.Count - 1))

                InfoEnterprise.EmailDiretorDepartamento.Add(FuncionariosBindingSource.Current("Email"))


            Else

                InfoEnterprise.IDDiretorDepartamento.Add(0)
                InfoEnterprise.NomeCompletoDiretorDepartamento.Add("")
                InfoEnterprise.PrimeiroNomeDiretorDepartamento.Add("")
                InfoEnterprise.UltimoNomeDiretorDepartamento.Add("")
                InfoEnterprise.EmailDiretorDepartamento.Add("")

            End If




            Debug.WriteLine("ID Departamento: " & InfoEnterprise.IDDepartamento(i))
            Debug.WriteLine("Abreviatura Departamento: " & InfoEnterprise.AbreviaturaDepartamento(i))
            Debug.WriteLine("Nome Departamento: " & InfoEnterprise.NomeDepartamento(i))

            'Se houver diretor
            Debug.WriteLineIf(InfoEnterprise.IDDiretorDepartamento(i) > 0, "ID Diretor Departamento: " & InfoEnterprise.IDDiretorDepartamento(i))
            Debug.WriteLineIf(InfoEnterprise.IDDiretorDepartamento(i) > 0, "Nome Completo Diretor Departamento: " & InfoEnterprise.NomeCompletoDiretorDepartamento(i))

            Debug.WriteLineIf(InfoEnterprise.IDDiretorDepartamento(i) > 0, "Primeiro Nome Diretor Departamento: " & InfoEnterprise.PrimeiroNomeDiretorDepartamento(i))
            Debug.WriteLineIf(InfoEnterprise.IDDiretorDepartamento(i) > 0, "Primeiro Nome Diretor Departamento: " & InfoEnterprise.UltimoNomeDiretorDepartamento(i))
            Debug.WriteLineIf(InfoEnterprise.IDDiretorDepartamento(i) > 0, "Email Diretor Departamento: " & InfoEnterprise.EmailDiretorDepartamento(i))


            'Se não houver diretor
            Debug.WriteLineIf(InfoEnterprise.IDDiretorDepartamento(i) = 0, "Não existe diretor para este departamento")

        Next

    End Sub

    Private Sub avisosRecentes_MouseLeave(sender As Object, e As EventArgs)
        Dim label As ToolStripLabel = DirectCast(sender, ToolStripLabel)
        label.BackColor = SystemColors.Control
        label.ForeColor = SystemColors.ControlText
    End Sub

    Private Sub avisosRecentes_Click(sender As Object, e As EventArgs)
        Dim label As ToolStripLabel = DirectCast(sender, ToolStripLabel)
        DetalhesAviso.Show()

        DetalhesAviso.GroupBox1.Visible = False
        DetalhesAviso.Label1.Visible = False
        DetalhesAviso.FuncionariosDiretoresComboBox.Visible = False
        DetalhesAviso.Label2.Visible = False
        DetalhesAviso.ComboBox1.Visible = False
        DetalhesAviso.AvisoTextBox.Height = 170
        DetalhesAviso.Button1.Visible = False
        DetalhesAviso.AvisoTextBox.ReadOnly = True
        DetalhesAviso.TituloTextBox.ReadOnly = True
        DetalhesAviso.Text = "Detalhe Aviso"

        DetalhesAviso.Height = 25
        DetalhesAviso.AvisosBindingSource.Filter = "ID = " & label.Tag

        Leitura_de_avisosBindingSource.AddNew()
        Leitura_de_avisosBindingSource.Current("ID_Aviso") = label.Tag
        Leitura_de_avisosBindingSource.Current("DeH") = Now
        Leitura_de_avisosBindingSource.Current("ID_Funcionarios") = InfoUser.UserID

        Leitura_de_avisosBindingSource.EndEdit()
        Leitura_de_avisosTableAdapter.Update(Industries_DanDataSet)
        AtualizarInfosAvisos()
    End Sub

    Private Sub avisosLidos_Click(sender As Object, e As EventArgs)
        Dim label As ToolStripLabel = DirectCast(sender, ToolStripLabel)
        DetalhesAviso.Show()

        DetalhesAviso.GroupBox1.Visible = False
        DetalhesAviso.Label1.Visible = False
        DetalhesAviso.FuncionariosDiretoresComboBox.Visible = False
        DetalhesAviso.Label2.Visible = False
        DetalhesAviso.ComboBox1.Visible = False
        DetalhesAviso.AvisoTextBox.Height = 170
        DetalhesAviso.Button1.Visible = False
        DetalhesAviso.AvisoTextBox.ReadOnly = True
        DetalhesAviso.TituloTextBox.ReadOnly = True
        DetalhesAviso.Text = "Detalhe Aviso"

        DetalhesAviso.Height = 25
        DetalhesAviso.AvisosBindingSource.Filter = "ID = " & label.Tag
    End Sub

    Sub AtualizarInfosAvisos()
        AvisosToolStripMenuItem.DropDownItems.Clear()
        If InfoUser.UserDepDirectorYN Then
            AvisosToolStripMenuItem.DropDownItems.Add(New ToolStripSeparator)

            Dim botaoVerAvisosMandados As New ToolStripButton("Ver Avisos Enviados")
            Dim botaoNovoAviso As New ToolStripButton("Enviar Novo Aviso")

            AddHandler botaoVerAvisosMandados.Click, AddressOf VerAvisosMandados_Click
            AddHandler botaoNovoAviso.Click, AddressOf NovoAviso_Click

            AvisosToolStripMenuItem.DropDownItems.Add(botaoVerAvisosMandados)
            AvisosToolStripMenuItem.DropDownItems.Add(botaoNovoAviso)

        End If



        Dim listaID As New List(Of Integer)()
        Dim listaDeH As New List(Of DateTime)()
        Dim listaIDAviso As New List(Of Integer)()
        Dim listaIDFuncionarios As New List(Of Integer)()

        For Each row As DataRowView In Leitura_de_avisosBindingSource
            ' Obter os valores das colunas
            Dim id As Integer = CInt(row("ID"))
            Dim deh As DateTime = CDate(row("DeH"))
            Dim idAviso As Integer = CInt(row("ID_Aviso"))
            Dim idFuncionarios As Integer = CInt(row("ID_Funcionarios"))

            ' Adicionar os valores às listas correspondentes
            listaID.Add(id)
            listaDeH.Add(deh)
            listaIDAviso.Add(idAviso)
            listaIDFuncionarios.Add(idFuncionarios)
        Next

        Dim nenhumAvisoLabel As New ToolStripLabel("Nenhum aviso novo por agora") With {
            .ForeColor = Color.DimGray,
            .AutoSize = False,
            .Size = New Size(Me.Width / 2 + 30, 40)
        }
        nenhumAvisoLabel.Font = New Font(nenhumAvisoLabel.Font, FontStyle.Italic)

        Dim avisosRecentes, avisosLidos As New List(Of ToolStripLabel)

        AvisosBindingSource.Filter = "(DLDM IS NULL OR DLDM > #" & Today.ToString("MM/dd/yyyy") & "#) AND (ID_Departamento IS NULL OR ID_Departamento = " & InfoUser.UserDepID & ") AND (ID_Funcionario IS NULL OR ID_Funcionario = " & InfoUser.UserID & ")"

        For Each row As DataRowView In AvisosBindingSource
            ' Obtenha os dados relevantes da linha
            Dim DesignacaoDiretor, NomeDiretor, NomeDepartamento As String

            Diretores_de_DepartamentosBindingSource.Filter = "ID = " & AvisosBindingSource.Current("ID_Diretor")
            FuncionariosBindingSource.Filter = "ID = " & Diretores_de_DepartamentosBindingSource.Current("ID_Funcionario")
            DepartamentosBindingSource.Filter = "ID = " & Diretores_de_DepartamentosBindingSource.Current("ID_Departamento")

            DesignacaoDiretor = Diretores_de_DepartamentosBindingSource.Current("DDD")
            NomeDepartamento = DepartamentosBindingSource.Current("NDD")
            NomeDiretor = FuncionariosBindingSource.Current("Nome")

            Dim titulo As String

            titulo = DesignacaoDiretor & " "
            If DesignacaoDiretor.ToLower = "diretor" Or DesignacaoDiretor.ToLower = "director" Then titulo &= "do departamento de " & NomeDepartamento
            titulo &= NomeDiretor & ": " & row("Titulo").ToString()

            Dim id As Integer = CInt(row("ID"))

            Dim label As New ToolStripLabel()

            label.Text = titulo
            label.Tag = id
            label.Alignment = ToolStripItemAlignment.Right

            If Not listaIDAviso.Contains(id) Then
                avisosRecentes.Add(label)
            Else
                avisosLidos.Add(label)
            End If
        Next

        Dim avisosNaoLidosLabel As New ToolStripLabel("Avisos não lidos")
        avisosNaoLidosLabel.DisplayStyle = ToolStripItemDisplayStyle.Text
        avisosNaoLidosLabel.Margin = New Padding(Me.Width / 2 - 55, avisosNaoLidosLabel.Margin.Top, avisosNaoLidosLabel.Margin.Right, avisosNaoLidosLabel.Margin.Bottom)
        avisosNaoLidosLabel.Size = New Size(Me.Width / 2 + 30, 40)

        Dim avisosLidosLabel As New ToolStripLabel("Avisos lidos recentemente")
        avisosLidosLabel.DisplayStyle = ToolStripItemDisplayStyle.Text
        avisosLidosLabel.Margin = New Padding(Me.Width / 2 - 62 - 55, avisosLidosLabel.Margin.Top, avisosLidosLabel.Margin.Right, avisosLidosLabel.Margin.Bottom)
        avisosLidosLabel.Size = New Size(Me.Width / 2 + 30, 40)

        If avisosLidos.Count <> 0 Then
            For Each label As ToolStripLabel In avisosLidos
                Dim novoLabel As New ToolStripLabel(label.Text)
                novoLabel.Tag = label.Tag
                novoLabel.BackColor = Color.LightGray
                novoLabel.ForeColor = Color.Black
                novoLabel.Size = New Size(Me.Width / 2 + 30, 40)

                AddHandler novoLabel.Click, AddressOf avisosLidos_Click

                AvisosToolStripMenuItem.DropDownItems.Insert(0, novoLabel)
            Next

            novosAvisosBooleanExterior = True
            AvisosToolStripMenuItem.DropDownItems.Insert(0, avisosLidosLabel)
            AvisosToolStripMenuItem.DropDownItems.Insert(0, New ToolStripSeparator)
        End If

        If avisosRecentes.Count = 0 Then
            AvisosToolStripMenuItem.DropDownItems.Insert(0, nenhumAvisoLabel)
        Else
            For Each label As ToolStripLabel In avisosRecentes
                Dim novoLabel As New ToolStripLabel(label.Text)
                novoLabel.Tag = label.Tag
                novoLabel.BackColor = Color.LightGray
                novoLabel.ForeColor = Color.Black
                novoLabel.Size = New Size(Me.Width / 2 + 30, 40)

                AddHandler novoLabel.MouseLeave, AddressOf avisosRecentes_MouseLeave
                AddHandler novoLabel.Click, AddressOf avisosRecentes_Click

                AvisosToolStripMenuItem.DropDownItems.Insert(0, novoLabel)
            Next

            AvisosToolStripMenuItem.DropDownItems.Insert(0, avisosNaoLidosLabel)
        End If

        If avisosLidos.Count <> 0 And avisosRecentes.Count = 0 Then
            AvisosToolStripMenuItem.DropDownItems.Insert(0, avisosNaoLidosLabel)
        End If

        If avisosRecentes.Count > 0 Then
            novosAvisosBooleanExterior = True
        Else
            novosAvisosBooleanExterior = False
        End If

        MenuStrip1.AutoSize = False

        MenuStrip1.Invalidate()
        MenuStrip1.PerformLayout()



        MenuStrip1.Renderer = New LogoutAndAvisosRenderer(LogoutToolStripMenuItem, AvisosToolStripMenuItem, novosAvisosBooleanExterior)
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

    Private Sub PMenu_ClientSizeChanged(sender As Object, e As EventArgs) Handles MyBase.ClientSizeChanged
        AtualizarInfosAvisos()
    End Sub
End Class
