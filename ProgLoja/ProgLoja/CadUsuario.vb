Imports System.Data.SqlClient

Public Class CadUsuario
    Dim us As Usuario = New Usuario
    Dim IncluirNovoUsuario As Boolean
    Private Sub CadUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LojaDataSet.Usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.LojaDataSet.Usuario)
        TabControl1.SelectTab("2")
        IncluirNovoUsuario = False

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.UsuarioTableAdapter.Fill(Me.LojaDataSet.Usuario)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = "0" Then
            If us.Consultar(DataGridView1.CurrentRow.Cells(0).Value) Then
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
        Else

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim us As Usuario = New Usuario
        If us.Excluir(TxtCodigo.Text) = True Then
            MsgBox("Registro excluido.", MsgBoxStyle.Information, "")
            'Apos excluir o usuário   atualiza o componente datagridview
            'primero linha desliga o datasource da datagridview
            'depois carrega os dados novamente
            Me.DataGridView1.DataSource = DBNull.Value
            Me.DataGridView1.DataSource = Me.UsuarioTableAdapter.GetData
            'fecha o formulario
            TxtCodigo.Focus()
        End If
    End Sub


    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
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


    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        'Dim us As Usuario = New Usuario

        Try
            us.Codigo = TxtCodigo.Text
            us.Nome = txtNome.Text
            us.Senha = Convert.ToInt16(txtSenha.Text)
            us.CPF = txtCpf.Text
            us.Email = txtEmail.Text
            Select Case ComboBox1.SelectedIndex
                Case 1
                    us.Perfil = "Administrador"
                Case 2
                    us.Perfil = "Vendedor"
                Case 3
                    us.Perfil = "Financeiro"
                Case Else
                    us.Perfil = "Outros"

            End Select

            If IncluirNovoUsuario Then ' variavel para saber se ira editar ou incluir
                'CONDIÇÃO PARA SALVAR 
                ' AS SENHAS DEVEM SER IGUAL PARA GARANTIR QUE O USUARIO NAO INFORME A SENHA ERRADA
                If (txtSenha.Text = txtSenha2.Text) Then
                    us.Incluir()
                    MsgBox("Novo Usuário cadastrado.", MsgBoxStyle.Information, "")
                End If
            Else
                us.Alterar(us.Codigo)
                MsgBox("Registro alterado com sucesso.", MsgBoxStyle.Information, "")
            End If

            'Apos Inserir o usuário   atualiza o componente datagridview
            'primero linha desliga o datasource da datagridview
            'depois carrega os dados novamente
            Me.DataGridView1.DataSource = DBNull.Value
            Me.DataGridView1.DataSource = Me.UsuarioTableAdapter.GetData
        Catch ex As Exception
            MsgBox("Erro ao Gravar dados..", MsgBoxStyle.Critical, "")
        End Try

    End Sub


    Private Sub PegarPerfilToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            'Me.UsuarioTableAdapter.PegarPerfil(Me.LojaDataSet.Usuario)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Dim con As New Conexao
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(con.StrConexao)
        'criando o comando sql
        Dim sql As String
        sql = "SELECT * FROM Usuario where nome like ('%" & txtConsulta.Text & "%') "

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataadapter As SqlDataAdapter = New SqlDataAdapter(comando)


        'define o dataset
        Dim ds As DataSet = New DataSet()

        Try
            '---abre a conexao---
            conexao.Open()
            '---preenche o dataset---
            dataadapter.Fill(ds, "Usuario")
            '---fecha a conexao---

            '---vincula o dataset ao DataGridView---
            DataGridView1.DataSource = ds           'ou ds.tables(0)
            '---define a tabela a ser exibida---
            DataGridView1.DataMember = "Usuario"


            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub
End Class