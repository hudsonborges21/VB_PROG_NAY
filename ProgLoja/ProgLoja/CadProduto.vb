Imports System.Data.SqlClient

Public Class CadProduto

    Dim Incluindo As Boolean

    Public Sub formatarGrid()

        ' //define e realiza a formatação de cada coluna
        DataGridView1.Columns(0).HeaderText = "Codigo"
        DataGridView1.Columns(1).HeaderText = "Descrição"
        DataGridView1.Columns(2).HeaderText = "Seção"
        DataGridView1.Columns(3).HeaderText = "Valor Unit."

        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 350
        DataGridView1.Columns(2).Width = 130
        DataGridView1.Columns(3).Width = 80

        DataGridView1.Columns(0).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.Columns(2).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        For i = 4 To DataGridView1.Columns.Count - 1
            DataGridView1.Columns(i).Visible = False
        Next

    End Sub

    Public Sub LimparCampos()
        Me.txtcodigo.Text = ""
        Me.txtdescricao.Text = ""
        Me.txtID.Text = ""
        Me.txtmargem.Text = ""
        Me.TxtCusto.Text = ""
        Me.TxtPreco.Text = ""
        Me.txtCodForn.Text = ""
        Me.txtFornecedor.Text = ""
        Me.txtestoque.Text = ""
        Me.Txtsecao.Text = ""
    End Sub

    Public Sub AtulizarGrid()
        Dim con As New Conexao
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(con.StrConexao)
        'criando o comando sql
        Dim sql As String
        sql = "SELECT * FROM Produto"

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataadapter As SqlDataAdapter = New SqlDataAdapter(comando)

        'define o dataset
        Dim ds As DataSet = New DataSet()

        Try
            '---abre a conexao---
            conexao.Open()
            '---preenche o dataset---
            dataadapter.Fill(ds, "Produto")
            '---fecha a conexao---
            '---vincula o dataset ao DataGridView---
            DataGridView1.DataSource = ds           'ou ds.tables(0)
            '---define a tabela a ser exibida---
            DataGridView1.DataMember = "Produto"
            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CadProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New Conexao
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(con.StrConexao)
        'criando o comando sql
        Dim sql As String
        sql = "SELECT id, descricao, secao, precoVenda FROM Produto"

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataadapter As SqlDataAdapter = New SqlDataAdapter(comando)

        'define o dataset
        Dim ds As DataSet = New DataSet()

        Try
            '---abre a conexao---
            conexao.Open()
            '---preenche o dataset---
            dataadapter.Fill(ds, "Produto")
            '---fecha a conexao---

            '---vincula o dataset ao DataGridView---
            DataGridView1.DataSource = ds           'ou ds.tables(0)
            '---define a tabela a ser exibida---
            DataGridView1.DataMember = "Produto"

            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        formatarGrid() 'arrumando os campos na gridview
        TabControl1.SelectedIndex = "1"
    End Sub

    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        consultarProduto("SELECT id, descricao, secao, precoVenda FROM Produto where descricao like ('%" & txtConsulta.Text & "%') ", "Produto")
        txtConsulta.Text = ""
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim codigo As String
        If TabControl1.SelectedIndex = "0" Then
            Dim Prod As Produto = New Produto
            codigo = DataGridView1.CurrentRow.Cells(0).Value
            If Not IsDBNull(codigo) Then
                If Prod.Consultar(codigo) Then
                    Me.txtcodigo.Text = Prod.CodigoEAN
                    Me.txtdescricao.Text = Prod.Descricao
                    Me.txtID.Text = Prod.Codigo
                    'Me.txtmargem.Text = String.Format("{0:N2}", Convert.ToString(Prod.Margem))
                    'Me.TxtCusto.Text = String.Format("{0:N2}", Convert.ToString(Prod.Custo))
                    'Me.TxtPreco.Text = String.Format("{0:N2}", Convert.ToString(Prod.Preco))
                    'Me.txtCodForn.Text = String.Format("{0:N2}", Convert.ToString(Prod.codFornecedor))
                    Me.txtmargem.Text = Prod.Margem
                    Me.TxtCusto.Text = Prod.Custo
                    Me.TxtPreco.Text = Prod.Preco
                    Me.txtCodForn.Text = Prod.codFornecedor
                    Me.txtFornecedor.Text = Prod.fornecedor
                    Me.Txtsecao.Text = Prod.Secao
                    Me.txtestoque.Text = Prod.Estoque
                    BtnConfirmar.Enabled = True
                    btnCancelar.Enabled = True
                    BtnIncluir.Enabled = True
                    btnExcluir.Enabled = True
                End If
            Else
                AtulizarGrid()
                formatarGrid()

            End If
        End If
    End Sub

    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        LimparCampos()
        Incluindo = True
        BtnIncluir.Enabled = False
        btnExcluir.Enabled = False

    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        Dim prod As Produto = New Produto
        Try
            'prod.Codigo = txtcodigo.Text
            prod.CodigoEAN = Me.txtcodigo.Text
            prod.Descricao = Me.txtdescricao.Text
            prod.Codigo = Me.txtID.Text
            prod.Margem = Convert.ToDecimal(Me.txtmargem.Text)
            prod.Custo = Convert.ToDouble(Me.TxtCusto.Text)
            prod.Preco = Convert.ToDecimal(Me.TxtPreco.Text)
            prod.codFornecedor = Me.txtCodForn.Text
            prod.fornecedor = Me.txtFornecedor.Text
            prod.Estoque = Convert.ToDecimal(Me.txtestoque.Text)
            prod.Secao = Me.Txtsecao.Text

            If Incluindo Then ' variavel para saber se ira editar ou incluir
                'CONDIÇÃO PARA SALVAR 
                ' AS SENHAS DEVEM SER IGUAL PARA GARANTIR QUE O USUARIO NAO INFORME A SENHA ERRADA
                prod.Incluir()
                MsgBox("Novo Produto cadastrado.", MsgBoxStyle.Information, "")

            Else
                prod.Alterar(prod.Codigo)
                MsgBox("Registro alterado com sucesso.", MsgBoxStyle.Information, "")
            End If
            Incluindo = False
            AtulizarGrid()
            formatarGrid()
            BtnConfirmar.Enabled = False
            btnCancelar.Enabled = False
            BtnIncluir.Enabled = True
            btnExcluir.Enabled = True
        Catch ex As Exception
            MsgBox("Erro ao Gravar dados..", MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If Not Incluindo Then
                If Not IsDBNull(txtID.Text) Then
                    Dim Prod As Produto = New Produto
                    If Prod.Excluir(txtID.Text) Then
                        MsgBox("Registro Excluído", MsgBoxStyle.Information, "")
                        LimparCampos()
                        AtulizarGrid()
                        formatarGrid()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao excluir o registro.", MsgBoxStyle.Critical, "")
        End Try
        
    End Sub

    Private Sub txtFornecedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFornecedor.KeyDown
        If e.KeyValue = 113 Then

            BuscaForn.ShowDialog()
            BuscaForn.txtConsulta.Focus()
            If Not IsDBNull(DataGridView1.CurrentRow.Cells(0).Value) Then
                txtCodForn.Text = BuscaForn.DataGridView1.CurrentRow.Cells(0).Value
            Else
                txtCodForn.Text = "0"
            End If
            BuscaForn.Close()
            Me.txtCodForn.Focus()
            Me.txtCodForn.Focused().ToString()
        End If
    End Sub

   
    Private Sub txtCodForn_Leave(sender As Object, e As EventArgs) Handles txtCodForn.Leave
        Dim Prod As Produto = New Produto
        txtFornecedor.Text = Prod.BuscarFornecedor(txtCodForn.Text)
        txtFornecedor.Focus()
    End Sub

    Private Sub TxtPreco_Leave(sender As Object, e As EventArgs) Handles TxtPreco.Leave
        Dim Prod As Produto = New Produto
        Dim Preco As Double
        Try
            If Not IsDBNull(TxtPreco.Text) And Trim(TxtPreco.Text) <> "" Then
                Preco = TxtPreco.Text
            Else
                Preco = 0
            End If
            txtmargem.Text = Prod.CalcularMagemBruta(TxtCusto.Text, Preco)
        Catch ex As Exception
            MsgBox("Valores com Formato incorreto.", MsgBoxStyle.Critical, "Erro...")
        End Try

    End Sub

    Private Sub TxtCusto_Leave(sender As Object, e As EventArgs) Handles TxtCusto.Leave
        If IsDBNull(TxtCusto.Text) And Trim(TxtCusto.Text) = "" Then
            TxtCusto.Text = 0
        End If
    End Sub

    Private Sub txtFornecedor_TextChanged(sender As Object, e As EventArgs) Handles txtFornecedor.TextChanged

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Dim PROD As New Produto
            If PROD.Consultar(txtID.Text) Then
                Me.txtcodigo.Text = PROD.CodigoEAN
                Me.txtdescricao.Text = PROD.Descricao
                Me.txtID.Text = PROD.Codigo
                'Me.txtmargem.Text = String.Format("{0:N2}", Convert.ToString(Prod.Margem))
                'Me.TxtCusto.Text = String.Format("{0:N2}", Convert.ToString(Prod.Custo))
                'Me.TxtPreco.Text = String.Format("{0:N2}", Convert.ToString(Prod.Preco))
                'Me.txtCodForn.Text = String.Format("{0:N2}", Convert.ToString(Prod.codFornecedor))
                Me.txtmargem.Text = PROD.Margem
                Me.TxtCusto.Text = PROD.Custo
                Me.TxtPreco.Text = PROD.Preco
                Me.txtCodForn.Text = PROD.codFornecedor
                Me.txtFornecedor.Text = PROD.fornecedor
                Me.Txtsecao.Text = PROD.Secao
                Me.txtestoque.Text = PROD.Estoque
                BtnConfirmar.Enabled = True
                btnCancelar.Enabled = True
                BtnIncluir.Enabled = True
                btnExcluir.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Erro ao Cancelar Operação", MsgBoxStyle.Critical, "Cancelando")
        End Try
        
    End Sub

    Private Sub txtestoque_Leave(sender As Object, e As EventArgs) Handles txtestoque.Leave
        BtnConfirmar.Focused().ToString()
        BtnConfirmar.Focus()
    End Sub

    Public Sub consultarProduto(ByVal txtSql As String, ByVal tabela As String)
        Dim con As New Conexao
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(con.StrConexao)
        'criando o comando sql
        Dim sql As String
        sql = txtSql

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
        formatarGrid() 'arrumando os campos na gridview
        TabControl1.SelectedIndex = "1"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        consultarProduto("SELECT id, descricao, secao, precoVenda FROM Produto where id like ('%" & TextBox1.Text & "%') ", "Produto")
        TextBox1.Text = ""
    End Sub
End Class