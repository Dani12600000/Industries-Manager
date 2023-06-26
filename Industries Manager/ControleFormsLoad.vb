﻿Module ControleFormsLoad
    Public Class PermissoesDep
        Public Property OnlyNewDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property OnlyRemoveDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property OnlyEditDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property NewAndEditDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property NewAndRemoveDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property RemoveAndEditDepIDs As List(Of Integer) = New List(Of Integer)()
        Public Property RemoverNavegacaoDepIDs As List(Of Integer) = New List(Of Integer)()
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

            If permissoesDepComValores.OnlyNewDepIDs IsNot Nothing AndAlso permissoesDepComValores.OnlyNewDepIDs.Contains(InfoUser.UserDepID) Then AcoesDeCadaDepartamento = "Apenas novo"
            If permissoesDepComValores.OnlyRemoveDepIDs IsNot Nothing AndAlso permissoesDepComValores.OnlyRemoveDepIDs.Contains(InfoUser.UserDepID) Then AcoesDeCadaDepartamento = "Apenas remover"
            If permissoesDepComValores.OnlyEditDepIDs IsNot Nothing AndAlso permissoesDepComValores.OnlyEditDepIDs.Contains(InfoUser.UserDepID) Then AcoesDeCadaDepartamento = "Apenas editar"
            If permissoesDepComValores.NewAndEditDepIDs IsNot Nothing AndAlso permissoesDepComValores.NewAndEditDepIDs.Contains(InfoUser.UserDepID) Then AcoesDeCadaDepartamento = "Novo e Editar"
            If permissoesDepComValores.NewAndRemoveDepIDs IsNot Nothing AndAlso permissoesDepComValores.NewAndRemoveDepIDs.Contains(InfoUser.UserDepID) Then AcoesDeCadaDepartamento = "Novo e Remover"
            If permissoesDepComValores.RemoveAndEditDepIDs IsNot Nothing AndAlso permissoesDepComValores.RemoveAndEditDepIDs.Contains(InfoUser.UserDepID) Then AcoesDeCadaDepartamento = "Remover e Editar"

            If AcoesDeCadaDepartamento = "Apenas novo" Then
                ' @TODO : TERMINAR

            End If
            If AcoesDeCadaDepartamento = "Apenas remover" Then
                ' @TODO : COMEÇAR - TERMINAR
            End If
            If AcoesDeCadaDepartamento = "Apenas editar" Then
                ' @TODO : COMEÇAR - TERMINAR
            End If
            If AcoesDeCadaDepartamento = "Novo e Editar" Then
                ' @TODO : COMEÇAR - TERMINAR
            End If
            If AcoesDeCadaDepartamento = "Novo e Remover" Then
                ' @TODO : COMEÇAR - TERMINAR
            End If
            If AcoesDeCadaDepartamento = "Remover e Editar" Then
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
