Module ControleFormsLoad
    Public Class PermissoesDep
        Public Property OnlySeeDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property OnlyNewDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property OnlyRemoveDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property OnlyEditDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property NewAndEditDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property NewAndRemoveDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property RemoveAndEditDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property EverythingDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property RemoverNavegacaoDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property ComponentesAModificarTamanho As List(Of Control) = New List(Of Control)()
        Public Property ButtonsNavegacaoLocations As List(Of Point) = New List(Of Point)()
        Public Property ButtonAddExtra As Button = New Button
        Public Property ButtonAddExtraLocation As Point = New Point
        Public Property ButtonEditExtra As Button = New Button
        Public Property ButtonEditExtraLocation As Point = New Point
        Public Property ButtonRemoverExtra As Button = New Button
        Public Property ButtonRemoverExtraLocation As Point = New Point
        Public Property ButtonsNavegacaoExtra As List(Of Button) = New List(Of Button)()
        Public Property ButtonsNavegacaoExtraLocations As List(Of Point) = New List(Of Point)()
        Public Property DataGridsAoNivelDosButtonsPrincipais As List(Of DataGridView) = New List(Of DataGridView)()
        ' Não cheguei a implementar
        ' Public Property CamposVisiveisDependendoDepartHorizontal As List(Of Control) = New List(Of Control)()
        ' Public Property CamposVisiveisDependendoDepartVeritical As List(Of Control) = New List(Of Control)()
        ' Public Property DepartamentoComPermissaoCVDH As List(Of Integer()) = New List(Of Integer())()
        ' Public Property DepartamentoComPermissaoCVDV As List(Of Integer()) = New List(Of Integer())()
    End Class

    Public coresTemplate As (Integer, String, Color)() = {
        (1, "Laranja Claro", ColorTranslator.FromHtml("#DF9A4A")),
        (2, "Bege claro", ColorTranslator.FromHtml("#F1D2A4")),
        (3, "Bege claro + Laranja claro", ColorTranslator.FromHtml("#E9B07E")),
        (4, "Cinza claro", ColorTranslator.FromHtml("#F5F5F4")),
        (5, "Castanho escuro", ColorTranslator.FromHtml("#54392A")),
        (6, "Laranja escuro", ColorTranslator.FromHtml("#A55721"))
    }


    Public cores As Dictionary(Of Type, Color) = New Dictionary(Of Type, Color) From {
            {GetType(Button), ObterCorPeloNumero(1)},
            {GetType(TextBox), ObterCorPeloNumero(4)},
            {GetType(NumericUpDown), ObterCorPeloNumero(4)},
            {GetType(DataGridView), ObterCorPeloNumero(3)},
            {GetType(ComboBox), ObterCorPeloNumero(4)},
            {GetType(CheckBox), ObterCorPeloNumero(2)},
            {GetType(RadioButton), ObterCorPeloNumero(6)},
            {GetType(ListBox), ObterCorPeloNumero(4)},
            {GetType(ProgressBar), ObterCorPeloNumero(5)},
            {GetType(Panel), ObterCorPeloNumero(4)},
            {GetType(Label), ObterCorPeloNumero(2)},
            {GetType(MenuStrip), ObterCorPeloNumero(3)},
            {GetType(ToolStrip), ObterCorPeloNumero(3)}
        }


    Public Formulario As Form
    Public tamanhobuttonadd As Integer
    Public tamanhobuttonedit As Integer
    Public somaTamanhosButtonFPAndSpaceBetween As Integer
    Public Locationbuttonadd, Locationbuttonedit As Point
    Public ControlesProtegidos As List(Of Control) = New List(Of Control)

    Sub CenterOnScreenForm()
        Formulario.StartPosition = FormStartPosition.Manual
        Formulario.Location = New Point((Screen.PrimaryScreen.Bounds.Width - Formulario.Width) \ 2, (Screen.PrimaryScreen.Bounds.Height - Formulario.Height) \ 2)
    End Sub

    Sub DepartamentosAndAcoesQuePodemRealizar(permissoesDepComValores As PermissoesDep)

        If Not InfoUser.UserAdm Then
            Dim AcoesDeCadaDepartamento As String = ""
            Dim RemoverNavegacao As Boolean = False

            If permissoesDepComValores.OnlySeeDepIDs IsNot Nothing AndAlso permissoesDepComValores.OnlySeeDepIDs.Contains(InfoUser.UserDepID) Then AcoesDeCadaDepartamento = "Apenas ver"
            If permissoesDepComValores.OnlyNewDepIDs IsNot Nothing AndAlso permissoesDepComValores.OnlyNewDepIDs.Contains(InfoUser.UserDepID) Then AcoesDeCadaDepartamento = "Apenas novo"
            If permissoesDepComValores.OnlyRemoveDepIDs IsNot Nothing AndAlso permissoesDepComValores.OnlyRemoveDepIDs.Contains(InfoUser.UserDepID) Then AcoesDeCadaDepartamento = "Apenas remover"
            If permissoesDepComValores.OnlyEditDepIDs IsNot Nothing AndAlso permissoesDepComValores.OnlyEditDepIDs.Contains(InfoUser.UserDepID) Then AcoesDeCadaDepartamento = "Apenas editar"
            If permissoesDepComValores.NewAndEditDepIDs IsNot Nothing AndAlso permissoesDepComValores.NewAndEditDepIDs.Contains(InfoUser.UserDepID) Then AcoesDeCadaDepartamento = "Novo e Editar"
            If permissoesDepComValores.NewAndRemoveDepIDs IsNot Nothing AndAlso permissoesDepComValores.NewAndRemoveDepIDs.Contains(InfoUser.UserDepID) Then AcoesDeCadaDepartamento = "Novo e Remover"
            If permissoesDepComValores.RemoveAndEditDepIDs IsNot Nothing AndAlso permissoesDepComValores.RemoveAndEditDepIDs.Contains(InfoUser.UserDepID) Then AcoesDeCadaDepartamento = "Remover e Editar"
            If permissoesDepComValores.EverythingDepIDs IsNot Nothing AndAlso permissoesDepComValores.EverythingDepIDs.Contains(InfoUser.UserDepID) Then AcoesDeCadaDepartamento = "Tudo"
            If permissoesDepComValores.RemoverNavegacaoDepIDs IsNot Nothing AndAlso permissoesDepComValores.RemoverNavegacaoDepIDs.Contains(InfoUser.UserDepID) Then RemoverNavegacao = True

            permissoesDepComValores.ButtonsNavegacaoLocations.Add(ButtonF.Location)
            permissoesDepComValores.ButtonsNavegacaoLocations.Add(ButtonP.Location)
            permissoesDepComValores.ButtonsNavegacaoLocations.Add(ButtonN.Location)
            permissoesDepComValores.ButtonsNavegacaoLocations.Add(ButtonL.Location)

            If AcoesDeCadaDepartamento = "Apenas ver" Then
                ' @TODO : TERMINAR

                ButtonNandG.Visible = False
                ButtonRorEandC.Visible = False
                If ButtonE IsNot Nothing Then ButtonE.Visible = False

                ButtonF.Location = New Point(ButtonNandG.Location)
                ButtonP.Location = New Point(ButtonP.Location.X, ButtonF.Location.Y)
                ButtonN.Location = New Point(ButtonN.Location.X, ButtonF.Location.Y)
                ButtonL.Location = New Point(ButtonL.Location.X, ButtonF.Location.Y)

                permissoesDepComValores.ButtonAddExtra.Visible = False
                permissoesDepComValores.ButtonRemoverExtra.Visible = False
                If permissoesDepComValores.ButtonEditExtra IsNot Nothing Then permissoesDepComValores.ButtonEditExtra.Visible = False

                For i = 0 To permissoesDepComValores.ButtonsNavegacaoExtra.Count - 1
                    permissoesDepComValores.ButtonsNavegacaoExtra(i).Location = New Point(permissoesDepComValores.ButtonsNavegacaoExtra(i).Location.X, permissoesDepComValores.ButtonAddExtra.Location.Y)
                Next

            ElseIf AcoesDeCadaDepartamento = "Apenas novo" Then
                ' @TODO : TERMINAR

                ButtonNandG.Visible = True
                ButtonRorEandC.Visible = False
                If ButtonE IsNot Nothing Then ButtonE.Visible = False

                permissoesDepComValores.ButtonAddExtra.Visible = True
                permissoesDepComValores.ButtonRemoverExtra.Visible = False
                If permissoesDepComValores.ButtonEditExtra IsNot Nothing Then permissoesDepComValores.ButtonEditExtra.Visible = False

                ButtonNandG.Width += ButtonRorEandC.Width
                ButtonNandG.Width += ButtonE.Width

            ElseIf AcoesDeCadaDepartamento = "Apenas remover" Then
                ' @TODO : COMEÇAR - TERMINAR
            ElseIf AcoesDeCadaDepartamento = "Apenas editar" Then
                ' @TODO : COMEÇAR - TERMINAR
            ElseIf AcoesDeCadaDepartamento = "Novo e Editar" Then
                ' @TODO : COMEÇAR - TERMINAR
            ElseIf AcoesDeCadaDepartamento = "Novo e Remover" Then
                ' @TODO : COMEÇAR - TERMINAR
            ElseIf AcoesDeCadaDepartamento = "Remover e Editar" Then
                ' @TODO : COMEÇAR - TERMINAR
            ElseIf AcoesDeCadaDepartamento = "Tudo" Then
                ' @TODO : COMEÇAR - TERMINAR
            End If

            If RemoverNavegacao Then
                ButtonF.Visible = False
                ButtonP.Visible = False
                ButtonN.Visible = False
                ButtonL.Visible = False
            Else
                ButtonF.Visible = True
                ButtonP.Visible = True
                ButtonN.Visible = True
                ButtonL.Visible = True
            End If

            For i As Integer = 0 To permissoesDepComValores.DataGridsAoNivelDosButtonsPrincipais.Count - 1
                permissoesDepComValores.DataGridsAoNivelDosButtonsPrincipais(i).Height = permissoesDepComValores.DataGridsAoNivelDosButtonsPrincipais(i).Height - ButtonF.Height
            Next

        End If
    End Sub

    Sub Desancorar(controles As Control, esquerda As Boolean, direita As Boolean, cima As Boolean, baixo As Boolean)
        For Each controle As Control In controles.Controls
            controle.Anchor = If(esquerda, AnchorStyles.Left, AnchorStyles.None) Or
                              If(direita, AnchorStyles.Right, AnchorStyles.None) Or
                              If(cima, AnchorStyles.Top, AnchorStyles.None) Or
                              If(baixo, AnchorStyles.Bottom, AnchorStyles.None)

            ' Recursivamente chama a função para lidar com controles filhos
            Desancorar(controle, esquerda, direita, cima, baixo)
        Next
    End Sub

    Sub CarregarPaletaDeCores()
        Formulario.BackColor = cores(GetType(Label))

        Dim toolStripGuardar As ToolStrip

        For Each control As Control In Formulario.Controls
            If Not ControlesProtegidos.Contains(control) AndAlso cores.ContainsKey(control.GetType()) AndAlso Not (TypeOf control Is Button And control.Text.ToLower.Contains("remover")) Then
                If TypeOf control Is DataGridView Then
                    Dim DataGridViewSelecionada As DataGridView = DirectCast(control, DataGridView)
                    DataGridViewSelecionada.BackgroundColor = cores(control.GetType())
                    Debug.WriteLine("Passou")
                Else
                    control.BackColor = cores(control.GetType())
                End If

                control.ForeColor = Color.Black ' Define a cor do texto para preto em todos os controles
            End If
        Next
    End Sub

    Public Function ObterCorPeloNome(nomeCor As String) As Color
        Dim corSelecionada As Color = coresTemplate.FirstOrDefault(Function(c) c.Item2 = nomeCor).Item3
        Return corSelecionada
    End Function
    Public Function ObterCorPeloNumero(numeroCor As Integer) As Color
        Dim corSelecionada As Color = coresTemplate.FirstOrDefault(Function(c) c.Item1 = numeroCor).Item3
        Return corSelecionada
    End Function

End Module
