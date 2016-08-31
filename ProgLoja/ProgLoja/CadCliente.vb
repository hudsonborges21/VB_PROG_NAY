Imports System.Data.SqlClient

Public Class CadCliente
    Dim incluindo As Boolean
    Public Sub LimparCampos()

        txtCod.Text = ""
        txtNome.Text = ""
        txtCNPJ.Text = ""
        txtInscr.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtCep.Text = ""
        txtUF.Text = ""
        txtTelefone.Text = ""

    End Sub
    Public Sub btn_desabilita()
        BtnConfirmar.Enabled = False
        btnCancelar.Enabled = False
        BtnIncluir.Enabled = False
        btnExcluir.Enabled = False
    End Sub
    Public Sub btn_habilita()
        BtnConfirmar.Enabled = True
        btnCancelar.Enabled = True
        BtnIncluir.Enabled = True
        btnExcluir.Enabled = True
    End Sub
    Public Sub formatarGrid()

        ' //define e realiza a formatação de cada coluna
        DataGridView1.Columns(0).HeaderText = "Código"
        DataGridView1.Columns(1).HeaderText = "Nome"
        DataGridView1.Columns(2).HeaderText = "CPF / CNPJ"
        DataGridView1.Columns(3).HeaderText = "Cidade"



        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 400
        DataGridView1.Columns(2).Width = 130
        DataGridView1.Columns(3).Width = 150


        DataGridView1.Columns(0).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.Columns(2).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        'For i = 4 To DataGridView1.Columns.Count - 1
        '    DataGridView1.Columns(i).Visible = False
        'Next




    End Sub

    Public Sub AtulizarGrid()
        Dim con As New Conexao
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(con.StrConexao)
        'criando o comando sql
        Dim sql As String
        sql = "SELECT id, nome, cnpj, cidade FROM Cliente"

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataadapter As SqlDataAdapter = New SqlDataAdapter(comando)

        'define o dataset
        Dim ds As DataSet = New DataSet()

        Try
            '---abre a conexao---
            conexao.Open()
            '---preenche o dataset---
            dataadapter.Fill(ds, "Cliente")
            '---fecha a conexao---
            '---vincula o dataset ao DataGridView---
            DataGridView1.DataSource = ds           'ou ds.tables(0)
            '---define a tabela a ser exibida---
            DataGridView1.DataMember = "Cliente"
            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        'Declarando e instanciando o obj da classe empresa
        Dim obj As Cliente = New Cliente

        Try


            'obj.Codigo = Convert.ToInt16(txtCod.Text)
            obj.Nome = txtNome.Text
            obj.CNPJ = txtCNPJ.Text
            obj.Inscricao = txtInscr.Text
            obj.Endereco = txtEndereco.Text
            obj.Bairro = txtBairro.Text
            obj.Cidade = txtCidade.Text
            obj.UF = txtUF.Text
            obj.CEP = txtCep.Text
            obj.Telefone = txtTelefone.Text


            If Not incluindo Then
                'chamando o metodo da classe responsavel por incluir os dados 
                obj.Alterar(txtCod.Text)
                MsgBox("Registro salvo com sucesso.", MsgBoxStyle.Information, "")
                
                incluindo = False

            Else

                'chamando o metodo da classe responsavel por incluir os dados 
                obj.Incluir()
                'btnSalvar.Enabled = False
                'btnEditar.Enabled = True
                txtCod.Text = obj.Ultimo - 1
                MsgBox("Registro salvo com sucesso.", MsgBoxStyle.Information, "")
                If obj.Consultar(txtCod.Text) Then

                    Me.txtCod.Text = obj.Codigo
                    Me.txtNome.Text = obj.Nome
                    Me.txtCNPJ.Text = obj.CNPJ
                    Me.txtInscr.Text = obj.Inscricao
                    Me.txtEndereco.Text = obj.Endereco
                    Me.txtCidade.Text = obj.Cidade
                    Me.txtBairro.Text = obj.Bairro
                    Me.txtCep.Text = obj.CEP
                    Me.txtUF.Text = obj.UF
                    Me.txtTelefone.Text = obj.Telefone

                    BtnConfirmar.Enabled = True
                    btnCancelar.Enabled = True
                    BtnIncluir.Enabled = True
                    btnExcluir.Enabled = True
                End If
                incluindo = False
            End If
            AtulizarGrid()
            formatarGrid()

        Catch ex As Exception
            MsgBox("Erro ao salvar, Por favor verificar os dados informado.", MsgBoxStyle.ApplicationModal, "")
        End Try
    End Sub

    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        'Dim cl As New Cliente
        txtNome.Text = " "
        txtCNPJ.Text = " "
        txtInscr.Text = " "
        txtEndereco.Text = " "
        txtBairro.Text = " "
        txtCidade.Text = " "
        txtCep.Text = " "
        txtUF.Text = " "
        txtTelefone.Text = " "
        txtCod.Text = ""
        incluindo = True
        BtnIncluir.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub CadCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtulizarGrid()
        formatarGrid()
        TabControl1.SelectedIndex = "1"
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim codigo As String
        If TabControl1.SelectedIndex = "0" Then
            Dim obj As Cliente = New Cliente

            codigo = DataGridView1.CurrentRow.Cells(0).Value
            If Not IsDBNull(codigo) Then
                If obj.Consultar(codigo) Then

                    Me.txtCod.Text = obj.Codigo
                    Me.txtNome.Text = obj.Nome
                    Me.txtCNPJ.Text = obj.CNPJ
                    Me.txtInscr.Text = obj.Inscricao
                    Me.txtEndereco.Text = obj.Endereco
                    Me.txtCidade.Text = obj.Cidade
                    Me.txtBairro.Text = obj.Bairro
                    Me.txtCep.Text = obj.CEP
                    Me.txtUF.Text = obj.UF
                    Me.txtTelefone.Text = obj.Telefone

                    BtnConfirmar.Enabled = True
                    btnCancelar.Enabled = True
                    BtnIncluir.Enabled = True
                    btnExcluir.Enabled = True
                End If
            Else
                AtulizarGrid()
                formatarGrid()
            
            End If
        ElseIf TabControl1.SelectedIndex = "0" Then
        Else
            DataGridView2.ClearSelection()
            DataGridView3.ClearSelection()
            AtulizarGridRebimentos()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If Not incluindo Then
                If Not IsDBNull(txtCod.Text) Then
                    Dim cli As Cliente = New Cliente
                    If cli.Excluir(txtCod.Text) Then
                        MsgBox("Registro Excluído", MsgBoxStyle.Information, "")
                        AtulizarGrid()
                        formatarGrid()
                        LimparCampos()
                        btn_desabilita()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao excluir o registro.", MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Dim con As New Conexao


        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(con.StrConexao)

        'abrindo a conexao com o banco
        'conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "SELECT id, nome, cnpj, cidade " & _
              "FROM Cliente where nome like ('%" & txtConsulta.Text & "%') "

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataadapter As SqlDataAdapter = New SqlDataAdapter(comando)

        'define o dataset
        Dim ds As DataSet = New DataSet()

        Try
            '---abre a conexao---
            conexao.Open()
            '---preenche o dataset---
            dataadapter.Fill(ds, "Cliente")
            '---fecha a conexao---

            '---vincula o dataset ao DataGridView---
            DataGridView1.DataSource = ds           'ou ds.tables(0)
            '---define a tabela a ser exibida---
            DataGridView1.DataMember = "Cliente"


            formatarGrid()

            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub formatarGridReceber()

        ' //define e realiza a formatação de cada coluna
        'DataGridView2.Columns(0).HeaderText = "Código"
        'DataGridView2.Columns(1).HeaderText = "Nome"
        'DataGridView2.Columns(2).HeaderText = "CPF / CNPJ"
        'DataGridView2.Columns(3).HeaderText = "Cidade"



        'DataGridView2.Columns(0).Width = 80
        'DataGridView2.Columns(1).Width = 400
        'DataGridView2.Columns(2).Width = 130
        'DataGridView2.Columns(3).Width = 150


        'DataGridView2.Columns(0).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DataGridView2.Columns(1).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'DataGridView2.Columns(2).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DataGridView2.Columns(3).DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        'For i = 4 To DataGridView1.Columns.Count - 1
        '    DataGridView1.Columns(i).Visible = False
        'Next




    End Sub

    Public Sub AtulizarGridRebimentos()
        Dim codigo As Integer

        Dim con As New Conexao
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(con.StrConexao)
        'criando o comando sql

        codigo = DataGridView1.CurrentRow.Cells(0).Value
        Dim sql As String
        sql = "SELECT id,emissao,vencimento,valor FROM Contrec where idcliente=" & codigo & " and valorRec = 0"

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataadapter As SqlDataAdapter = New SqlDataAdapter(comando)

        'define o dataset
        Dim ds As DataSet = New DataSet()

        Dim sql2 As String
        sql2 = "SELECT id,emissao,vencimento,valor, dataRec, ValorRec FROM Contrec where idcliente=" & codigo & " and valorRec <> 0"

        Dim comando2 As SqlCommand
        comando2 = New SqlCommand(sql2, conexao)

        Dim dataadapter2 As SqlDataAdapter = New SqlDataAdapter(comando2)

        'define o dataset
        Dim ds2 As DataSet = New DataSet()

        Try
            '---abre a conexao---
            conexao.Open()
            '---preenche o dataset---
            dataadapter.Fill(ds, "Contrec")
            dataadapter2.Fill(ds2, "Contrec")
            '---fecha a conexao---
            '---vincula o dataset ao DataGridView---
            DataGridView2.DataSource = ds           'ou ds.tables(0)
            DataGridView3.DataSource = ds2           'ou ds.tables(0)
            '---define a tabela a ser exibida---
            DataGridView2.DataMember = "Contrec"
            DataGridView3.DataMember = "Contrec"
            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        TxtVenda.Text = DataGridView2.CurrentRow.Cells(0).Value
        MtxtData.Text = DataGridView2.CurrentRow.Cells(1).Value
        MTvencimento.Text = DataGridView2.CurrentRow.Cells(2).Value
        Txtvalor.Text = DataGridView2.CurrentRow.Cells(3).Value
    End Sub
    Function calcularvalorRec(ByVal valor As Double, ByVal Desc As Double, ByVal Acr As Double) As Double
        Dim resp As Double
        resp = valor + Acr - Desc
        Return resp
    End Function

    Private Sub txtdesconto_Leave(sender As Object, e As EventArgs) Handles txtdesconto.Leave
        Try
            txtRecebido.Text = calcularvalorRec(Txtvalor.Text, txtdesconto.Text, TxtAcrescimo.Text)
            TxtAcrescimo.Focused().ToString()
            TxtAcrescimo.Focus()
        Catch ex As Exception
            MsgBox("Erro ao Calcular Valor recebido.", MsgBoxStyle.Critical, "Títulos a Receber")
        End Try
    End Sub

    Private Sub TxtAcrescimo_Leave(sender As Object, e As EventArgs) Handles TxtAcrescimo.Leave
        Try
            txtRecebido.Text = calcularvalorRec(Txtvalor.Text, txtdesconto.Text, TxtAcrescimo.Text)
            BtnBaixarTitulo.Focused().ToString()
            BtnBaixarTitulo.Focus()
        Catch ex As Exception
            MsgBox("Erro ao Calcular Valor recebido.", MsgBoxStyle.Critical, "Títulos a Receber")
        End Try
    End Sub

    Private Sub BtnBaixarTitulo_Click(sender As Object, e As EventArgs) Handles BtnBaixarTitulo.Click

        Try
            Dim bx As New ConteRec
            bx.Cliente = DataGridView1.CurrentRow.Cells(0).Value
            bx.Valor = Txtvalor.Text
            bx.venda = TxtVenda.Text
            bx.vencimento = FormatDateTime(MTvencimento.Text, DateFormat.ShortDate) 'Format(bx.vencimento, "yyyy") & "-" & Format(bx.vencimento, "MM") & "-" & Format(bx.vencimento, "dd") 'FormatDateTime(MTvencimento.Text, DateFormat.ShortDate)
            bx.emissao = FormatDateTime(MtxtData.Text, DateFormat.ShortDate)
            bx.dataRec = FormatDateTime(Today.Date, DateFormat.ShortDate)
            bx.desconto = txtdesconto.Text
            bx.acrescimo = TxtAcrescimo.Text
            txtRecebido.Text = calcularvalorRec(Txtvalor.Text, txtdesconto.Text, TxtAcrescimo.Text)
            bx.ValorRec = txtRecebido.Text
            If Not bx.BaixarTitulo(bx.Cliente, bx.venda, bx.vencimento) Then
                MsgBox("Erro em baixar título.", MsgBoxStyle.Critical, "Títulos a Receber")

            End If
            AtulizarGridRebimentos()
            TxtVenda.Text = ""
            MtxtData.Text = ""
            MTvencimento.Text = ""
            Txtvalor.Text = ""
            txtdesconto.Text = "0"
            TxtAcrescimo.Text = "0"
            txtRecebido.Text = "0"
        Catch ex As Exception
            MsgBox("Erro ao informar campos para Baixar Título.", MsgBoxStyle.Critical, "Títulos a Receber")
        End Try
    End Sub

    Private Sub btnExtornar_Click(sender As Object, e As EventArgs) Handles btnExtornar.Click
        Try
            Dim bx As New ConteRec
            bx.Cliente = DataGridView1.CurrentRow.Cells(0).Value
            bx.venda = DataGridView3.CurrentRow.Cells(0).Value
            bx.dataRec = Format(DataGridView3.CurrentRow.Cells(4).Value, "yyyy") & "-" & Format(DataGridView3.CurrentRow.Cells(4).Value, "MM") & "-" & Format(DataGridView3.CurrentRow.Cells(4).Value, "dd") 'FormatDateTime(MTvencimento.Text, DateFormat.ShortDate)
            bx.vencimento = Format(DataGridView3.CurrentRow.Cells(2).Value, "yyyy") & "-" & Format(DataGridView3.CurrentRow.Cells(2).Value, "MM") & "-" & Format(DataGridView3.CurrentRow.Cells(2).Value, "dd") 'FormatDateTime(MTvencimento.Text, DateFormat.ShortDate)
            'bx.dataRec = DataGridView3.CurrentRow.Cells(4).Value
            'bx.vencimento = DataGridView3.CurrentRow.Cells(2).Value

            If Not bx.CancelarBaixarTitulo(bx.Cliente, bx.venda, bx.vencimento, bx.dataRec) Then
                MsgBox("Erro em baixar título.", MsgBoxStyle.Critical, "Títulos a Receber")
            End If
            AtulizarGridRebimentos()
            TxtVenda.Text = ""
            MtxtData.Text = ""
            MTvencimento.Text = ""
            Txtvalor.Text = ""
            txtdesconto.Text = "0"
            TxtAcrescimo.Text = "0"
            txtRecebido.Text = "0"
        Catch ex As Exception
            MsgBox("Erro ao informar campos para Baixar Título.", MsgBoxStyle.Critical, "Títulos a Receber")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim OBJ As New Cliente
        If obj.Consultar(txtCod.Text) Then

            Me.txtCod.Text = obj.Codigo
            Me.txtNome.Text = obj.Nome
            Me.txtCNPJ.Text = obj.CNPJ
            Me.txtInscr.Text = obj.Inscricao
            Me.txtEndereco.Text = obj.Endereco
            Me.txtCidade.Text = obj.Cidade
            Me.txtBairro.Text = obj.Bairro
            Me.txtCep.Text = obj.CEP
            Me.txtUF.Text = obj.UF
            Me.txtTelefone.Text = obj.Telefone

            BtnConfirmar.Enabled = True
            btnCancelar.Enabled = True
            BtnIncluir.Enabled = True
            btnExcluir.Enabled = True
        End If
    End Sub
End Class