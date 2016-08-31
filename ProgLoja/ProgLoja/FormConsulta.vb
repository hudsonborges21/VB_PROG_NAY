Imports System.Data.SqlClient

Public Class FormConsulta

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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click

    End Sub
End Class