Public Class Login
    Dim us As Usuario = New Usuario
    Dim u, s As Integer
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        
        Try
            u = Convert.ToInt16(txtCodigo.Text)
            s = Convert.ToInt16(txtSenha.Text)

            If us.Consultar(txtCodigo.Text, txtSenha.Text) = True Then
                Form1.Label1.Text = "Usuário: " & us.Nome
                Form1.gUsuarioCodigo = us.Codigo
                Form1.gUsuarioNome = us.Nome
                Me.Visible = False
                Form1.Show()
            Else
                MessageBox.Show("Senha/Usuário Incorreto(s)", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch
            MessageBox.Show("Senha/Usuário Incorreto(s)", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSenha.Focus()
        End Try
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        'fechando app
        Dispose()
        Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class