Imports System.Data.SqlClient

Public Class buscaProduto
    Public Sub formatarGrid()

        ' //define e realiza a formatação de cada coluna
        DataGridView1.Columns(0).HeaderText = "Codigo"
        DataGridView1.Columns(1).HeaderText = "Descrição"
        DataGridView1.Columns(2).HeaderText = "Estoque"
        DataGridView1.Columns(3).HeaderText = "Valor"

        DataGridView1.Columns(0).Width = 65
        DataGridView1.Columns(1).Width = 230
        DataGridView1.Columns(2).Width = 65
        DataGridView1.Columns(3).Width = 90

        DataGridView1.Columns(0).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.Columns(2).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(3).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


    End Sub


    Public Sub AtulizarGrid(ByVal TextoSql As String, ByVal Tabela As String)
        Dim con As New Conexao
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(con.StrConexao)
        'criando o comando sql
        Dim sql As String
        sql = TextoSql

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataadapter As SqlDataAdapter = New SqlDataAdapter(comando)

        'define o dataset
        Dim ds As DataSet = New DataSet()

        Try
            '---abre a conexao---
            conexao.Open()
            '---preenche o dataset---
            dataadapter.Fill(ds, Tabela)
            '---fecha a conexao---
            '---vincula o dataset ao DataGridView---
            DataGridView1.DataSource = ds           'ou ds.tables(0)
            '---define a tabela a ser exibida---
            DataGridView1.DataMember = Tabela

            conexao.Close()
            formatarGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        AtulizarGrid("Select id, descricao, estoque, precovenda From Produto where descricao like ('%" & txtConsulta.Text & "%') ", "Produto")
    End Sub

    Private Sub BuscaProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtulizarGrid("Select id, descricao, estoque, precovenda From Produto", "Produto")
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        'Me.Visible = False
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Visible = False
        End If
    End Sub
End Class
