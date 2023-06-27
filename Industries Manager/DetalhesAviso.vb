Imports System.IO

Public Class DetalhesAviso
    Dim locGroupBox, locLabel2 As Point


    Private Sub AvisosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AvisosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Industries_DanDataSet)
        Formulario = Me
    End Sub

    Private Sub NovoAviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Avisos' table. You can move, or remove it, as needed.
        Me.AvisosTableAdapter.Fill(Me.Industries_DanDataSet.Avisos)
        DateTimePicker1.MinDate = Today
    End Sub

    Public Sub NovoAviso()
        AvisosBindingSource.AddNew()
        ComboBox1.SelectedIndex = 0
        Debug.WriteLine("NOVO!")
    End Sub

    Private Sub DataRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DataRadioButton.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles TodosLeramRadioButton.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles NuncaRadioButton.CheckedChanged

    End Sub

    Sub AtualizarCoisasAAtualizar()
        If DataRadioButton.Checked Then
            AvisosBindingSource.Current("FDFDP") = "Data"
        ElseIf TodosLeramRadioButton.Checked Then
            AvisosBindingSource.Current("FDFDP") = "Todos leram"
        ElseIf NuncaRadioButton.Checked Then
            AvisosBindingSource.Current("FDFDP") = "Nunca"
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

    End Sub

    Sub AlterarCoisasAMostrarTamanhosAndLocations()
        If ComboBox1.SelectedItem.ToString = "Funcionário" Then
            Label2.Text = ComboBox1.SelectedItem.ToString
        ElseIf ComboBox1.SelectedItem.ToString = "Departamento" Then

        ElseIf ComboBox1.SelectedItem.ToString = "Diretor" Then
            Label2.Text = ComboBox1.SelectedItem.ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not Avisos.Visible Then
            Avisos.Show()
        End If
    End Sub
End Class