Public Class Vendas

    Private Sub Vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Venda_de_produto' table. You can move, or remove it, as needed.
        Me.Venda_de_produtoTableAdapter.Fill(Me.Industries_DanDataSet.Venda_de_produto)
        'TODO: This line of code loads data into the 'Industries_DanDataSet.Vendas' table. You can move, or remove it, as needed.
        Me.VendasTableAdapter.Fill(Me.Industries_DanDataSet.Vendas)

        Mail_ClienteTextBox.Enabled = False
        TotalTextBox.ReadOnly = True
    End Sub

    Sub Nova_Venda(email As String)
        Debug.WriteLine("Executando Nova_venda")
        VendasBindingSource.AddNew()
        Mail_ClienteTextBox.Text = email
        Debug.WriteLine("Email : " & email)
    End Sub
End Class