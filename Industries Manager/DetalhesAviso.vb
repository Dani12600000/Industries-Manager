Imports System.IO
Imports System.Runtime.CompilerServices

Public Class DetalhesAviso
    Dim locGroupBox, locLabel2 As Point
    Dim tamanhoGroupBox1, tamanhoLabel2, diferencatamanhos As Integer
    Dim listaOpcoesParaQuemEnviar As List(Of String) = New List(Of String) From {
        "Meu departamento",
        "Funcionários do meu departamento",
        "Diretores de outro departamento"}
    Dim carregado As Boolean = False
    Dim FDFDP As String

    Private Sub DetalhesAviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Funcionarios' table. You can move, or remove it, as needed.
        Me.FuncionariosTableAdapter.Fill(Me.Industries_DanDataSet.Funcionarios)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Diretores_de_Departamentos' table. You can move, or remove it, as needed.
        Me.Diretores_de_DepartamentosTableAdapter.Fill(Me.Industries_DanDataSet.Diretores_de_Departamentos)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Avisos' table. You can move, or remove it, as needed.
        Me.AvisosTableAdapter.Fill(Me.Industries_DanDataSet.Avisos)

        For i = 0 To listaOpcoesParaQuemEnviar.Count - 1
            ComboBox1.Items.Add(listaOpcoesParaQuemEnviar(i))
        Next

        DateTimePicker1.MinDate = Today.AddDays(1)
        AlterarCoisasAMostrarTamanhosAndLocations()
        locGroupBox = GroupBox1.Location
        locLabel2 = Label2.Location
        GroupBox1.Location = locLabel2
        tamanhoGroupBox1 = GroupBox1.Height
        tamanhoLabel2 = Label2.Height
        diferencatamanhos = tamanhoGroupBox1 - tamanhoLabel2
        Me.Height = Me.ClientSize.Height + 7

        Formulario = Me

        CenterOnScreenForm()
        CarregarPaletaDeCores()
    End Sub

    Public Sub NovoAviso()
        AvisosBindingSource.AddNew()
        ComboBox1.SelectedIndex = 0
        AlterarCoisasAMostrarTamanhosAndLocations()
        Debug.WriteLine("NOVO!")
    End Sub

    Private Sub DataRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DataRadioButton.CheckedChanged
        AtualizarCoisasAAtualizar()
    End Sub

    Private Sub TodosLeramRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TodosLeramRadioButton.CheckedChanged
        AtualizarCoisasAAtualizar()
    End Sub

    Private Sub NuncaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles NuncaRadioButton.CheckedChanged
        AtualizarCoisasAAtualizar()
    End Sub

    Sub AtualizarCoisasAAtualizar()
        If carregado Then
            If AvisosBindingSource IsNot Nothing Then
                If DataRadioButton.Checked Then
                    FDFDP = "Data"
                ElseIf TodosLeramRadioButton.Checked Then
                    FDFDP = "Todos Leram"
                ElseIf NuncaRadioButton.Checked Then
                    FDFDP = "Nunca"
                End If
            End If
        End If
    End Sub

    Private Sub DetalhesAviso_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim currentPosition As Integer
        currentPosition = Avisos.AvisosBindingSource.Position
        Avisos.AvisosTableAdapter.Fill(Industries_DanDataSet.Avisos)
        Avisos.AvisosBindingSource.Position = currentPosition

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DataRadioButton.Checked = True


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        AlterarCoisasAMostrarTamanhosAndLocations()
    End Sub

    Private Sub DetalhesAviso_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        carregado = True
    End Sub

    Sub AlterarCoisasAMostrarTamanhosAndLocations()

        Debug.WriteLine("ComboBox1: " & ComboBox1.Text)

        If ComboBox1.Text = listaOpcoesParaQuemEnviar(1) Then
            Label2.Visible = True
            FuncionariosDiretoresComboBox.Visible = True
            Label2.Text = "Funcionário:"
            GroupBox1.Visible = False
            FuncionariosBindingSource.Filter = "ID_Departamento = " & InfoUser.UserDepID & " AND NOT ID = " & InfoUser.UserID
            If FuncionariosBindingSource.Count = 0 Then
                MsgBox("Não existem funcionarios alem de sí no departamento" & vbCrLf & "Por favor selecione outra opção", vbInformation)
                ComboBox1.SelectedIndex = 0
            End If

            FDFDP = "Todos Leram"
            carregado = False
            Debug.WriteLine("Meu departamento")

        ElseIf ComboBox1.Text = listaOpcoesParaQuemEnviar(0) Then
            Label2.Visible = False
            FuncionariosDiretoresComboBox.Visible = False
            GroupBox1.Visible = True
            FuncionariosBindingSource.RemoveFilter()
            carregado = True

        ElseIf ComboBox1.Text = listaOpcoesParaQuemEnviar(2) Then
            Label2.Visible = True
            FuncionariosDiretoresComboBox.Visible = True
            Label2.Text = "Diretor:"
            GroupBox1.Visible = False


            ' Aplica o filtro no Diretores_de_DepartamentosBindingSource
            Diretores_de_DepartamentosBindingSource.Filter = "DDC <= #" & Date.Today.ToString("MM/dd/yyyy") & "# AND (DDF IS NULL OR DDF > #" & Date.Today.AddDays(1).ToString("MM/dd/yyyy") & "#) And NOT ID = " & InfoUser.UserDepDirectorID

            ' Obtém os IDs de funcionários filtrados
            Dim filteredIDs As New List(Of Integer)()
            For Each row As DataRowView In Diretores_de_DepartamentosBindingSource.List
                Dim idFuncionario As Integer = CInt(row("ID_Funcionario"))
                filteredIDs.Add(idFuncionario)
            Next

            ' Verifica se há IDs filtrados
            If filteredIDs.Count > 0 Then
                ' Gera a expressão do filtro para a tabela Funcionarios
                Dim filterExpression As String = "ID IN (" & String.Join(",", filteredIDs) & ")"

                ' Aplica o filtro no FuncionariosBindingSource
                FuncionariosBindingSource.Filter = filterExpression
            Else
                MsgBox("Não existem mais diretores" & vbCrLf & "Por favor selecione outra opção", vbInformation)
                ComboBox1.SelectedIndex = 0
            End If

            carregado = False

        End If

        If (ComboBox1.Text = listaOpcoesParaQuemEnviar(1) Or ComboBox1.Text = listaOpcoesParaQuemEnviar(2)) Then
            Me.Height = Me.MinimumSize.Height
        ElseIf ComboBox1.Text = listaOpcoesParaQuemEnviar(0) And Not Me.ClientSize.Height >= Me.MinimumSize.Height + 75 Then
            Me.Height = Me.MinimumSize.Height + 75
        End If

    End Sub

    Private Sub FuncionariosDiretoresComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FuncionariosDiretoresComboBox.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AtualizarCoisasAAtualizar()

        AvisosBindingSource.Current("DT") = Today

        AvisosBindingSource.Current("ID_Diretor") = InfoUser.UserDepDirectorID
        AvisosBindingSource.Current("FDFDP") = FDFDP

        If ComboBox1.Text = listaOpcoesParaQuemEnviar(0) Then
            If FDFDP = "Data" Then
                AvisosBindingSource.Current("DLDM") = DateTimePicker1.Value
            ElseIf FDFDP = "Todos Leram" Then
                AvisosBindingSource.Current("ID_Departamento") = InfoUser.UserDepID
            End If
        End If

        If ComboBox1.Text = listaOpcoesParaQuemEnviar(1) Or ComboBox1.Text = listaOpcoesParaQuemEnviar(2) Then
            AvisosBindingSource.Current("ID_Funcionario") = FuncionariosDiretoresComboBox.SelectedValue
        End If

        AvisosBindingSource.EndEdit()
        AvisosTableAdapter.Update(Industries_DanDataSet)

        If Not Avisos.Visible Then
            Avisos.Show()
        End If
        Me.Close()
    End Sub
End Class