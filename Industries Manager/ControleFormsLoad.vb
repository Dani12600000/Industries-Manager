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


    Public Formulario As Form
    Public tamanhobuttonadd As Integer
    Public tamanhobuttonedit As Integer
    Public somaTamanhosButtonFPAndSpaceBetween As Integer
    Public Locationbuttonadd, Locationbuttonedit As Point

    Sub CenterOnScreenForm()
        Formulario.StartPosition = FormStartPosition.Manual
        Formulario.Location = New Point((Screen.PrimaryScreen.Bounds.Width - Formulario.Width) \ 2, (Screen.PrimaryScreen.Bounds.Height - Formulario.Height) \ 2)
    End Sub

    Sub CarregamentoInicial()
        tamanhobuttonadd = ButtonNandG.Width
        tamanhobuttonedit = ButtonE.Width
        somaTamanhosButtonFPAndSpaceBetween = ButtonF.Width + ButtonP.Width + (ButtonP.Location.X - ButtonF.Location.X + ButtonF.Width)
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
                ' @TODO : COMEÇAR - TERMINAR

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
End Module
