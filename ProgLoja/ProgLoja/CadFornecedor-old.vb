'Imports System.Data.SqlClient

'Public Class CadFornecedor

'    Private Sub FornecedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
'        Me.Validate()
'        Me.FornecedorBindingSource.EndEdit()
'        Me.TableAdapterManager.UpdateAll(Me.LojaDataSetForn)

'    End Sub


'    Private Sub FornecedorBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
'        Me.Validate()
'        Me.FornecedorBindingSource.EndEdit()
'        Me.TableAdapterManager.UpdateAll(Me.LojaDataSetForn)

'    End Sub


'    Private Sub FornecedorBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) Handles FornecedorBindingNavigatorSaveItem.Click
'        Me.Validate()
'        Me.FornecedorBindingSource.EndEdit()
'        Me.TableAdapterManager.UpdateAll(Me.LojaDataSetForn)

'    End Sub

'    Private Sub CadFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        'TODO: This line of code loads data into the 'LojaDataSetForn.Fornecedor' table. You can move, or remove it, as needed.
'        Me.FornecedorTableAdapter.Fill(Me.LojaDataSetForn.Fornecedor)
'        Me.TabPrin.SelectedIndex = 1
'    End Sub

'    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
'        Dim con As New Conexao
'        'criando a conexao com o banco de dados
'        Dim conexao As SqlConnection
'        conexao = New SqlConnection(con.StrConexao)
'        'criando o comando sql
'        Dim sql As String
'        sql = "SELECT * FROM Fornecedor where nome like ('%" & txtConsulta.Text & "%') "

'        Dim comando As SqlCommand
'        comando = New SqlCommand(sql, conexao)

'        Dim dataadapter As SqlDataAdapter = New SqlDataAdapter(comando)


'        'define o dataset
'        Dim ds As DataSet = New DataSet()

'        Try
'            '---abre a conexao---
'            conexao.Open()
'            '---preenche o dataset---
'            dataadapter.Fill(ds, "Fornecedor")
'            '---fecha a conexao---

'            '---vincula o dataset ao DataGridView---
'            FornecedorDataGridView.DataSource = ds           'ou ds.tables(0)
'            '---define a tabela a ser exibida---
'            FornecedorDataGridView.DataMember = "Fornecedor"


'            conexao.Close()
'        Catch ex As Exception
'            MsgBox(ex.Message)
'        End Try

'    End Sub

'    Private Sub TabPrin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabPrin.SelectedIndexChanged
'        If TabPrin.SelectedIndex = "0" Then
'            FornecedorBindingNavigator.Visible = True
'        Else
'            FornecedorBindingNavigator.Visible = False
'        End If
'    End Sub

'    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

'    End Sub
'End Class