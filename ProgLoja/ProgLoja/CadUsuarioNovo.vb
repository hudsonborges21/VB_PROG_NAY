Imports System.Data.SqlClient

Public Class CadUsuarioNovo
    Dim IncluirNovoUsuario As Boolean
    Public Sub atualizaGrid(ByVal sqltexto As String, ByVal tabela As String)
        Dim con As New Conexao
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(con.StrConexao)
        'criando o comando sql
        Dim sql As String
        sql = sqltexto
        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)
        Dim dataadapter As SqlDataAdapter = New SqlDataAdapter(comando)
        'define o dataset
        Dim ds As DataSet = New DataSet()
        Try
            '---abre a conexao---
            conexao.Open()
            '---preenche o dataset---
            dataadapter.Fill(ds, tabela)
            '---fecha a conexao---
            '---vincula o dataset ao DataGridView---
            DataGridView1.DataSource = ds           'ou ds.tables(0)
            '---define a tabela a ser exibida---
            DataGridView1.DataMember = tabela

            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        Try
            Dim us As New Usuario
            us.Codigo = TxtCodigo.Text
            us.Nome = txtNome.Text
            us.Senha = Convert.ToInt16(txtSenha.Text)
            us.CPF = txtCpf.Text
            us.Email = txtEmail.Text
            If (txtSenha.Text <> txtSenha2.Text) Then
                MsgBox("Senha diferente da informada anteriormente", MsgBoxStyle.ApplicationModal, "Senha")
                Exit Sub
            End If
            Select Case ComboBox1.SelectedIndex
                Case 0
                    us.Perfil = "Administrador"
                Case 1
                    us.Perfil = "Vendedor"
                Case 2
                    us.Perfil = "Financeiro"
                Case Else
                    us.Perfil = "Outros"
            End Select

            If IncluirNovoUsuario Then ' variavel para saber se ira editar ou incluir
                'CONDIÇÃO PARA SALVAR 
                ' AS SENHAS DEVEM SER IGUAL PARA GARANTIR QUE O USUARIO NAO INFORME A SENHA ERRADA

                us.Incluir()
                MsgBox("Novo Usuário cadastrado.", MsgBoxStyle.Information, "")
                'End If
            Else
                us.Alterar(us.Codigo)
            MsgBox("Registro alterado com sucesso.", MsgBoxStyle.Information, "")
            End If
            IncluirNovoUsuario = False
            'Apos Inserir o usuário   atualiza o componente datagridview
            'primero linha desliga o datasource da datagridview
            'depois carrega os dados novamente
            atualizaGrid("Select id,Nome, idPerfil From Usuario", "Usuario")
        Catch ex As Exception
            MsgBox("Erro ao Gravar dados..", MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim us As Usuario = New Usuario
        Dim cod As Integer
        cod = 0
        If us.Excluir(TxtCodigo.Text) = True Then
            MsgBox("Registro excluido.", MsgBoxStyle.Information, "")
            'Apos excluir o usuário   atualiza o componente datagridview

            cod = us.UltimoCodigo - 1
            MostarDados(cod)
            atualizaGrid("Select id,Nome, idPerfil From Usuario", "Usuario")
            'fecha o formulario
            TxtCodigo.Focus()
        End If
    End Sub

    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        Dim us As New Usuario
        Me.TxtCodigo.Text = us.UltimoCodigo
        Me.txtNome.Text = ""
        ' Me.txt.Text = us.Nivel
        Me.txtSenha.Text = ""
        Me.txtSenha2.Text = ""
        Me.txtCpf.Text = ""
        Me.txtEmail.Text = ""
        IncluirNovoUsuario = True    ' variavel para saber se esta incluir um novo usuario ou nao 
        Me.TxtCodigo.Focus()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = "0" Then
            MostarDados(DataGridView1.CurrentRow.Cells(0).Value)
            'Dim us As New Usuario
            'If us.Consultar(DataGridView1.CurrentRow.Cells(0).Value) Then
            '    Me.TxtCodigo.Text = us.Codigo
            '    Me.txtNome.Text = us.Nome
            '    ' Me.txt.Text = us.Nivel
            '    Me.txtSenha.Text = us.Senha
            '    Me.txtSenha2.Text = us.Senha
            '    Me.txtCpf.Text = us.CPF
            '    Me.txtEmail.Text = us.Email
            '    Select Case us.Perfil
            '        Case "Administrador"
            '            ComboBox1.SelectedIndex = 0
            '        Case "Vendedor"
            '            ComboBox1.SelectedIndex = 1
            '        Case "Financeiro"
            '            ComboBox1.SelectedIndex = 2
            '        Case Else
            '            ComboBox1.SelectedIndex = 3
            '    End Select
            'End If
        Else

        End If
    End Sub

    Private Sub CadUsuarioNovo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        atualizaGrid("Select id,Nome, idPerfil From Usuario", "Usuario")
    End Sub

    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        atualizaGrid("Select id,Nome, idPerfil From Usuario where nome like ('%" & txtConsulta.Text & "%') ", "Usuario")
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        MostarDados(TxtCodigo.Text)
    End Sub

    Public Sub MostarDados(ByVal codigo As Integer)
        Dim us As New Usuario
        If us.Consultar(Codigo) Then
            Me.TxtCodigo.Text = us.Codigo
            Me.txtNome.Text = us.Nome
            ' Me.txt.Text = us.Nivel
            Me.txtSenha.Text = us.Senha
            Me.txtSenha2.Text = us.Senha
            Me.txtCpf.Text = us.CPF
            Me.txtEmail.Text = us.Email
            Select Case us.Perfil
                Case "Administrador"
                    ComboBox1.SelectedIndex = 0
                Case "Vendedor"
                    ComboBox1.SelectedIndex = 1
                Case "Financeiro"
                    ComboBox1.SelectedIndex = 2
                Case Else
                    ComboBox1.SelectedIndex = 3
            End Select
        End If
    End Sub
End Class