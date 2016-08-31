Public Class Form1
    Public gUsuarioCodigo As String
    Public gUsuarioNome As String
    Private Sub UsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuáriosToolStripMenuItem.Click
        'dialog - para nao deixar chamar outro form
        'show -  permitem chamar outros form equando tiver o foco
        'CadUsuario.ShowDialog()
        CadUsuarioNovo.ShowDialog()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'fechando o formulario de login que nao esta visivel ao usuario
        Login.Close()

    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        CadEmpresa.Show()
    End Sub

    Private Sub FornecedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedorToolStripMenuItem.Click
        CadFornecedor.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        CadCliente.Show()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        CadProduto.Show()
    End Sub

    Private Sub VendasDeMercToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasDeMercToolStripMenuItem.Click
        CadVenda.ShowDialog()
    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click

    End Sub
End Class
