Imports System.Data.SqlClient

Public Class CadVenda
    Dim incluindo As Boolean
    Dim ProdIncluindo As Boolean
    Public Sub LimparCampos()

        TxtSequencial.Text = ""
        txtClientecodigo.Text = ""
        TxtClienteNome.Text = ""
        TXTcnpj.Text = ""
        txtClientecodigo.Text = ""
        TxtEndereco.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtTelefone.Text = ""
        txtDesconto.Text = "0"
        txtTotal.Text = "0"
        TxtTotalProdutos.Text = "0"
        txtVendedor.Text = Form1.gUsuarioCodigo
        ComboBox1.SelectedItem = 0

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


    End Sub
    Public Sub formatarGrid_itens()


    End Sub

    Public Sub PainelFechamento_desabilitar()

        MDPag1.Enabled = True
        TxtPG1.Enabled = True
        MDPag2.Enabled = True
        TxtPG2.Enabled = True
        MDPag3.Enabled = True
        TxtPG3.Enabled = True
        MDPag4.Enabled = True
        TxtPG4.Enabled = True
        MDPag5.Enabled = True
        TxtPG5.Enabled = True
        BTN_Painel_confirmar.Enabled = True
    End Sub
    Public Sub PainelFechamento_Habilitar()
        MDPag1.Enabled = False
        TxtPG1.Enabled = False
        MDPag2.Enabled = False
        TxtPG2.Enabled = False
        MDPag3.Enabled = False
        TxtPG3.Enabled = False
        MDPag4.Enabled = False
        TxtPG4.Enabled = False
        MDPag5.Enabled = False
        TxtPG5.Enabled = False
        BTN_Painel_confirmar.Enabled = False
    End Sub

    Public Sub SomarProdutos(ByVal CODIGO As Integer)

        Dim vend As New Vendas
        'cod = Convert.ToInt16(CODIGO)
        If Not IsDBNull(CODIGO) Then
            If vend.itens_SomarProdutos(CODIGO) Then
                TxtTotalProdutos.Text = vend.TotalProduto
                'txtDesconto.Text = vend.Desconto
                txtTotal.Text = IIf(Not IsDBNull(txtDesconto.Text) And Trim(txtDesconto.Text) <> "", vend.TotalProduto - txtDesconto.Text, vend.TotalProduto)
                'txtTotal.Text = TxtTotalProdutos.Text - txtDesconto.Text
            End If
        End If

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
        formatarGrid()
    End Sub
    Public Sub AtulizarGrid_itens(ByVal TextoSql As String, ByVal Tabela As String)
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
            DataGridView2.DataSource = ds           'ou ds.tables(0)
            '---define a tabela a ser exibida---
            DataGridView2.DataMember = Tabela
            conexao.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        formatarGrid_itens()

    End Sub

    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        LimparCampos()
        AtulizarGrid_itens("Select idproduto,Descricao,qtde,preco,total From Itens where idvenda=" & 0, "Itens")

        Dim Vend As New Vendas
        TxtSequencial.Text = Vend.UltimaVenda
        TxtStatus.Text = "ABERTO"
        TxtFormPag.Text = "Avista"
        incluindo = True
        btnExcluir.Enabled = False
        BtnIncluir.Enabled = False
        MtxtData.Text = Date.Today.Date
        txtVendedor.Text = Form1.gUsuarioCodigo
        MtxtData.Focus()
    End Sub

    Private Sub CadVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedIndex = 1
        ComboBox1.SelectedItem = 0
        AtulizarGrid("select venda.id,Cliente.nome, Cliente.CNPJ,venda.data,venda.valorVenda from venda inner join cliente on Cliente.id = venda.idCliente", "Venda")
        formatarGrid()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim codigo As String
        If TabControl1.SelectedIndex = "0" Then
            Dim vend As Vendas = New Vendas
            codigo = DataGridView1.CurrentRow.Cells(0).Value
            If Not IsDBNull(codigo) Then
                If vend.Consultar(codigo) Then
                    TxtSequencial.Text = vend.Codigo
                    txtTotal.Text = vend.TotalValor
                    txtDesconto.Text = vend.Desconto
                    TxtTotalProdutos.Text = vend.TotalProduto
                    txtVendedor.Text = vend.codUsario
                    MtxtData.Text = FormatDateTime(vend.Data, DateFormat.ShortDate)
                    txtClientecodigo.Text = vend.CodCliente
                    TxtFormPag.Text = vend.FormPag
                    TxtStatus.Text = vend.CodStatus
                    If vend.Natureza = "Venda de Mercadoria" Then
                        ComboBox1.SelectedIndex = 0
                    Else
                        ComboBox1.SelectedIndex = 1
                    End If

                    Dim Cli As New Cliente
                    If Cli.Consultar(vend.CodCliente) Then
                        TXTcnpj.Text = Cli.CNPJ
                        TxtClienteNome.Text = Cli.Nome
                        TxtEndereco.Text = Cli.Endereco
                        txtBairro.Text = Cli.Bairro
                        txtCidade.Text = Cli.Cidade
                        txtTelefone.Text = Cli.Telefone
                    End If
                    formatarGrid_itens()
                    AtulizarGrid_itens("Select idproduto,Descricao,qtde,preco,total From Itens where idvenda=" & TxtSequencial.Text, "Itens")
                    SomarProdutos(vend.Codigo)
                    btn_habilita()
                End If
            Else
                AtulizarGrid("select venda.id,Cliente.nome, Cliente.CNPJ,venda.data,venda.valorVenda from venda inner join cliente on Cliente.id = venda.idCliente", "Venda")
                formatarGrid()

            End If
        End If
    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        Dim vend As New Vendas
        Try
            If Not IsDBNull(txtClientecodigo.Text) Then vend.CodCliente = txtClientecodigo.Text
            If Not IsDBNull(txtVendedor.Text) Then vend.codUsario = txtVendedor.Text
            If Not IsDBNull(MtxtData.Text) Then vend.Data = Convert.ToDateTime(MtxtData.Text)
            If Not IsDBNull(txtDesconto.Text) Then vend.Desconto = Convert.ToDouble(txtDesconto.Text)
            If Not IsDBNull(TxtTotalProdutos.Text) Then vend.TotalProduto = Convert.ToDouble(TxtTotalProdutos.Text)
            If Not IsDBNull(txtTotal.Text) Then vend.TotalValor = Convert.ToDouble(txtTotal.Text)
            vend.CodStatus = TxtStatus.Text
            vend.FormPag = TxtFormPag.Text
            vend.Natureza = ComboBox1.SelectedItem.ToString

            If incluindo Then ' variavel para saber se ira editar ou incluir
                'CONDIÇÃO PARA SALVAR 
                vend.Incluir()
                vend.Codigo = vend.UltimaVenda - 1
                AtualizarVenda(vend.Codigo)
                MsgBox("Venda incluida.", MsgBoxStyle.Information, "Venda de Mercadoria")
                incluindo = False
            Else
                vend.Alterar(TxtSequencial.Text)
                MsgBox("Registro alterado com sucesso.", MsgBoxStyle.Information, "")
            End If

            AtulizarGrid("select venda.id,Cliente.nome, Cliente.CNPJ,venda.data,venda.valorVenda from venda inner join cliente on Cliente.id = venda.idCliente", "Venda")

            BtnConfirmar.Enabled = False
            btnCancelar.Enabled = False
            BtnIncluir.Enabled = True
            btnExcluir.Enabled = True
        Catch ex As Exception
            MsgBox("Erro ao Gravar dados..", MsgBoxStyle.Critical, "Venda de Mercadoria")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ' MsgBox(ComboBox1.SelectedIndex().ToString)
        AtualizarVenda(TxtSequencial.Text)
    End Sub

    Private Sub TxtClienteNome_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtClienteNome.KeyDown
        If e.KeyValue = 113 Then

            BuscaCliente.ShowDialog()
            BuscaCliente.txtConsulta.Focus()
            If Not IsDBNull(DataGridView1.CurrentRow.Cells(0).Value) Then
                txtClientecodigo.Text = BuscaCliente.DataGridView1.CurrentRow.Cells(0).Value
            Else
                txtClientecodigo.Text = "0"
            End If
            BuscaForn.Close()
            txtClientecodigo.Focus()
            txtClientecodigo.Focused().ToString()
        End If
    End Sub

    Private Sub txtClientecodigo_Leave(sender As Object, e As EventArgs) Handles txtClientecodigo.Leave
        If Not IsDBNull(txtClientecodigo.Text) Then
            Dim Cli As New Cliente
            If Cli.Consultar(txtClientecodigo.Text) Then
                TXTcnpj.Text = Cli.CNPJ
                TxtClienteNome.Text = Cli.Nome
                TxtEndereco.Text = Cli.Endereco
                txtBairro.Text = Cli.Bairro
                txtCidade.Text = Cli.Cidade
                txtTelefone.Text = Cli.Telefone
            Else
                MsgBox("Cliente não localizado.", MsgBoxStyle.Information, "Validação...")
                txtClientecodigo.Focus()
            End If
        Else
            MsgBox("Codigo do cliente não informado.", MsgBoxStyle.Information, "Validação...")
            txtClientecodigo.Focus()
        End If

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtProdDescricao.KeyDown
        If e.KeyValue = 113 Then

            buscaProduto.ShowDialog()
            buscaProduto.txtConsulta.Focus()
            If Not IsDBNull(DataGridView1.CurrentRow.Cells(0).Value) Then
                TxtProdcodigo.Text = buscaProduto.DataGridView1.CurrentRow.Cells(0).Value
            Else
                TxtProdcodigo.Text = "0"
            End If
            BuscaForn.Close()
            TxtProdcodigo.Focus()
            TxtProdcodigo.Focused().ToString()
        End If
    End Sub

    Private Sub TxtProdcodigo_Leave(sender As Object, e As EventArgs) Handles TxtProdcodigo.Leave
        If Not IsDBNull(TxtProdcodigo.Text) And Trim(TxtProdcodigo.Text) <> "" Then
            Dim Prod As New Produto
            If Prod.Consultar(TxtProdcodigo.Text) Then
                ProdIncluindo = True '******* variaval para nao deixar enter pressiona e incluir varios itens
                TxtProdDescricao.Text = Prod.Descricao
                TxtProdQtde.Text = "1"
                TxtProdValorUnit.Text = IIf(Not IsDBNull(Prod.Preco), Prod.Preco, "0")
                TxtProdQtde.Focus()
                TxtProdQtde.Focused.ToString()
            End If
        End If
    End Sub

    Private Sub TxtProdQtde_Leave(sender As Object, e As EventArgs) Handles TxtProdQtde.Leave
        Dim Qtde, Unit As Double
        Qtde = 0
        Unit = 0
        Try
            If IsDBNull(TxtProdQtde.Text) Then
                TxtProdQtde.Text = "0"
            Else
                Qtde = Convert.ToDouble(TxtProdQtde.Text)
            End If
            If IsDBNull(TxtProdValorUnit.Text) Then
                TxtProdValorUnit.Text = "0"
            Else
                Unit = Convert.ToDouble(TxtProdValorUnit.Text)
            End If
            TxtProdTotal.Text = Qtde * Unit 'TxtProdValorUnit.Text * TxtProdQtde.Text
            TxtProdTotal.Focus()
            TxtProdTotal.Focused.ToString()
        Catch ex As Exception
            MsgBox("Valores informados errado.", MsgBoxStyle.Critical, "Erro ao calular Valor total do Produto")
        End Try

    End Sub

    Private Sub TxtProdTotal_Leave(sender As Object, e As EventArgs) Handles TxtProdTotal.Leave
        'Dim ESTOQUE As Double
        'ESTOQUE = 0
        'Try
        '    If IsDBNull(TxtProdcodigo.Text) And Trim(TxtProdcodigo.Text) = "" Then
        '        MsgBox("Código do Produto não informado.", MsgBoxStyle.Information, "Erro...")
        '        Exit Sub
        '    End If

        '    Dim item As New Vendas
        '    item.itensNumero = TxtSequencial.Text
        '    item.itensProduto = TxtProdcodigo.Text
        '    item.itensDescricao = TxtProdDescricao.Text
        '    item.itensQuantidade = TxtProdQtde.Text
        '    item.itensValorUnit = TxtProdValorUnit.Text
        '    item.itensValorTotal = TxtProdTotal.Text
        '    If item.itens_Incluir() Then
        '        AtulizarGrid_itens("Select idproduto, Descricao, qtde, preco,total From Itens where idvenda=" & item.itensNumero, "Itens")
        '        SomarProdutos(item.itensNumero)
        '        Dim PROD As New Produto
        '        If PROD.Consultar(TxtProdcodigo.Text) Then
        '            ESTOQUE = PROD.Estoque
        '            ESTOQUE = ESTOQUE - item.itensQuantidade
        '            PROD.BaixarEstoque(PROD.Codigo, ESTOQUE)
        '        End If
        '        TxtProdcodigo.Text = ""
        '        TxtProdDescricao.Text = ""
        '        TxtProdQtde.Text = ""
        '        TxtProdValorUnit.Text = ""
        '        TxtProdTotal.Text = ""
        '        TxtProdcodigo.Text = ""
        '    End If
        'Catch ex As Exception
        '    MsgBox("Não foi Possivel Inserir o item.", MsgBoxStyle.Critical, "Erro...")
        'End Try
        'TxtProdcodigo.Focus()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim CodigoUlt As Integer
        CodigoUlt = 0
        Try
            If TxtStatus.Text = "ABERTO" Then
                Dim vend As New Vendas
                If Not vend.itens_Excluir(TxtSequencial.Text) Then
                    MsgBox("Erro Excluir itens", MsgBoxStyle.Information, "Venda de Mercadoria")
                    Exit Sub
                End If
                If Not vend.Excluir(TxtSequencial.Text) Then
                    MsgBox("Erro Excluir cabeçalho", MsgBoxStyle.Information, "Venda de Mercadoria")
                    Exit Sub
                End If
                MsgBox("Venda Excluida.", MsgBoxStyle.Information, "Venda de Mercadoria")
                CodigoUlt = vend.UltimaVenda - 1
                If vend.Consultar(CodigoUlt) Then
                    TxtSequencial.Text = vend.Codigo
                    txtTotal.Text = vend.TotalValor
                    txtDesconto.Text = vend.Desconto
                    TxtTotalProdutos.Text = vend.TotalProduto
                    txtVendedor.Text = vend.codUsario
                    MtxtData.Text = FormatDateTime(vend.Data, DateFormat.ShortDate)
                    txtClientecodigo.Text = vend.CodCliente
                    TxtFormPag.Text = vend.FormPag
                    TxtStatus.Text = vend.CodStatus
                    If vend.Natureza = "Venda de Mercadoria" Then
                        ComboBox1.SelectedIndex = 0
                    Else
                        ComboBox1.SelectedIndex = 1
                    End If

                    Dim Cli As New Cliente
                    If Cli.Consultar(vend.CodCliente) Then
                        TXTcnpj.Text = Cli.CNPJ
                        TxtClienteNome.Text = Cli.Nome
                        TxtEndereco.Text = Cli.Endereco
                        txtBairro.Text = Cli.Bairro
                        txtCidade.Text = Cli.Cidade
                        txtTelefone.Text = Cli.Telefone
                    End If
                    AtulizarGrid("select venda.id,Cliente.nome, Cliente.CNPJ,venda.data,venda.valorVenda from venda inner join cliente on Cliente.id = venda.idCliente", "Venda")
                    formatarGrid_itens()
                    AtulizarGrid_itens("Select idproduto,Descricao,qtde,preco,total From Itens where idvenda=" & CodigoUlt, "Itens")
                    SomarProdutos(vend.Codigo)
                    btn_habilita()
                End If
            Else
                MsgBox("Somente venda em ABERTO pode se excluida", MsgBoxStyle.Information, "Venda de Mercadoria")
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel excluir a venda.", MsgBoxStyle.Critical, "Venda de Mercadoria")
        End Try
    End Sub

    Private Sub TXTcnpj_Leave(sender As Object, e As EventArgs) Handles TXTcnpj.Leave
        BtnConfirmar.Focus()
    End Sub


    Private Sub txtDesconto_Leave(sender As Object, e As EventArgs) Handles txtDesconto.Leave
        SomarProdutos(TxtSequencial.Text)
    End Sub

    Private Sub txtNumPag_Leave(sender As Object, e As EventArgs) Handles txtNumPag.Leave
        Dim numPag As Integer
        Try
            MDPag1.Enabled = True
            TxtPG1.Enabled = True
            MDPag2.Enabled = True
            TxtPG2.Enabled = True
            MDPag3.Enabled = True
            TxtPG3.Enabled = True
            MDPag4.Enabled = True
            TxtPG4.Enabled = True
            MDPag5.Enabled = True
            TxtPG5.Enabled = True
            BTN_Painel_confirmar.Enabled = True

            If Not IsDBNull(txtNumPag.Text) And Trim(txtNumPag.Text) <> "" Then
                numPag = Convert.ToInt16(txtNumPag.Text)
                Select Case numPag
                    Case 0
                        ComboPag.SelectedIndex = 0
                        MDPag1.Enabled = False
                        TxtPG1.Enabled = False
                        MDPag2.Enabled = False
                        TxtPG2.Enabled = False
                        MDPag3.Enabled = False
                        TxtPG3.Enabled = False
                        MDPag4.Enabled = False
                        TxtPG4.Enabled = False
                        MDPag5.Enabled = False
                        TxtPG5.Enabled = False
                        TxtPG1.Text = "0"
                        TxtPG2.Text = "0"
                        TxtPG3.Text = "0"
                        TxtPG4.Text = "0"
                        TxtPG5.Text = "0"

                        BTN_Painel_confirmar.Focus()
                    Case 1
                        ComboPag.SelectedIndex = 1
                        MDPag1.Text = DateAdd("d", 30, MtxtData.Text)
                        TxtPG1.Text = Format(txtTotal.Text / 1, "N")
                        MDPag2.Enabled = False
                        TxtPG2.Enabled = False
                        MDPag3.Enabled = False
                        TxtPG3.Enabled = False
                        MDPag4.Enabled = False
                        TxtPG4.Enabled = False
                        MDPag5.Enabled = False
                        TxtPG5.Enabled = False

                        TxtPG2.Text = "0"
                        TxtPG3.Text = "0"
                        TxtPG4.Text = "0"
                        TxtPG5.Text = "0"
                    Case 2
                        ComboPag.SelectedIndex = 1
                        MDPag1.Text = DateAdd("d", 30, MtxtData.Text)
                        TxtPG1.Text = Format(txtTotal.Text / 2, "N")
                        MDPag2.Text = DateAdd("d", 30, MDPag1.Text)
                        TxtPG2.Text = Format(txtTotal.Text / 2, "N")
                        MDPag3.Enabled = False
                        TxtPG3.Enabled = False
                        MDPag4.Enabled = False
                        TxtPG4.Enabled = False
                        MDPag5.Enabled = False
                        TxtPG5.Enabled = False

                        TxtPG3.Text = "0"
                        TxtPG4.Text = "0"
                        TxtPG5.Text = "0"
                    Case 3
                        ComboPag.SelectedIndex = 1
                        MDPag1.Text = DateAdd("d", 30, MtxtData.Text)
                        TxtPG1.Text = Format(txtTotal.Text / 3, "N")
                        MDPag2.Text = DateAdd("d", 30, MDPag1.Text)
                        TxtPG2.Text = Format(txtTotal.Text / 3, "N")
                        MDPag3.Text = DateAdd("d", 30, MDPag2.Text)
                        TxtPG3.Text = Format(txtTotal.Text / 3, "N")
                        MDPag4.Enabled = False
                        TxtPG4.Enabled = False
                        MDPag5.Enabled = False
                        TxtPG5.Enabled = False

                        TxtPG4.Text = "0"
                        TxtPG5.Text = "0"
                    Case 4
                        ComboPag.SelectedIndex = 1
                        MDPag1.Text = DateAdd("d", 30, MtxtData.Text)
                        TxtPG1.Text = Format(txtTotal.Text / 4, "N")
                        MDPag2.Text = DateAdd("d", 30, MDPag1.Text)
                        TxtPG2.Text = Format(txtTotal.Text / 4, "N")
                        MDPag3.Text = DateAdd("d", 30, MDPag2.Text)
                        TxtPG3.Text = Format(txtTotal.Text / 4, "N")
                        MDPag4.Text = DateAdd("d", 30, MDPag3.Text)
                        TxtPG4.Text = Format(txtTotal.Text / 4, "N")
                        MDPag5.Enabled = False
                        TxtPG5.Enabled = False

                        TxtPG5.Text = "0"
                    Case 5
                        ComboPag.SelectedIndex = 1
                        MDPag1.Text = DateAdd("d", 30, MtxtData.Text)
                        TxtPG1.Text = Format(txtTotal.Text / 5, "N")
                        MDPag2.Text = DateAdd("d", 30, MDPag1.Text)
                        TxtPG2.Text = Format(txtTotal.Text / 5, "N")
                        MDPag3.Text = DateAdd("d", 30, MDPag2.Text)
                        TxtPG3.Text = Format(txtTotal.Text / 5, "N")
                        MDPag4.Text = DateAdd("d", 30, MDPag3.Text)
                        TxtPG4.Text = Format(txtTotal.Text / 5, "N")
                        MDPag5.Text = DateAdd("d", 30, MDPag4.Text)
                        TxtPG5.Text = Format(txtTotal.Text / 5, "N")

                        TxtPG5.Text = "0"
                    Case Else
                        MsgBox("Quantidade de Parcelas invalido.", MsgBoxStyle.Critical, "Número de Pagamentos")
                        txtNumPag.Focus()
                        txtNumPag.Focused.ToString()

                End Select

            End If
        Catch ex As Exception
            MsgBox("Número de Pagamentos com formato incorreto", MsgBoxStyle.Critical, "Número de Pagamentos")
        End Try

    End Sub


    Private Sub Btn_painel_cancelar_Click(sender As Object, e As EventArgs) Handles Btn_painel_cancelar.Click
        PainelPrincipal.Visible = False
        BtnConfirmar.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim vend As New Vendas
        PainelPrincipal.Visible = True
        If vend.Venda_ConsultarFomr(TxtSequencial.Text) Then
            If vend.CodStatus = "FECHADO" Then
                'PainelFechamento_desabilitar()
                PainelFechamento_Habilitar()
                Btn_painel_cancelar.Focus()
            ElseIf vend.CodStatus = "CANCELADA" Then
                PainelFechamento_Habilitar()
                Btn_painel_cancelar.Focus()
            Else

                PainelFechamento_desabilitar()
                'PainelFechamento_Habilitar()
                txtNumPag.Focus()
            End If

            If vend.FormPag <> "Avista" Then
                Select Case vend.FormPag
                    Case "Prazo"
                        ComboPag.SelectedIndex = 1
                    Case "Cartão Debito"
                        ComboPag.SelectedIndex = 2
                    Case "Cartão Credito"
                        ComboPag.SelectedIndex = 3
                    Case Else
                        ComboPag.SelectedIndex = 4
                End Select
                txtNumPag.Text = vend.NPagamento
                TxtPG1.Text = vend.P1
                TxtPG2.Text = vend.P2
                TxtPG3.Text = vend.P3
                TxtPG4.Text = vend.P4
                TxtPG5.Text = vend.P5
                MDPag1.Text = IIf(vend.V1 <> "0001-01-01", FormatDateTime(vend.V1, DateFormat.ShortDate), "00/00/0000")
                MDPag2.Text = IIf(vend.V2 <> "0001-01-01", FormatDateTime(vend.V2, DateFormat.ShortDate), "00/00/0000") 'FormatDateTime(vend.V2, DateFormat.ShortDate) 'vend.V2
                MDPag3.Text = IIf(vend.V3 <> "0001-01-01", FormatDateTime(vend.V3, DateFormat.ShortDate), "00/00/0000") 'FormatDateTime(vend.V3, DateFormat.ShortDate) 'vend.V3
                MDPag4.Text = IIf(vend.V4 <> "0001-01-01", FormatDateTime(vend.V4, DateFormat.ShortDate), "00/00/0000") 'FormatDateTime(vend.V4, DateFormat.ShortDate) 'vend.V4
                MDPag5.Text = IIf(vend.V5 <> "0001-01-01", FormatDateTime(vend.V5, DateFormat.ShortDate), "00/00/0000") 'FormatDateTime(vend.V5, DateFormat.ShortDate) 'vend.V5

            Else
                TxtPG1.Text = "0"
                TxtPG2.Text = "0"
                TxtPG3.Text = "0"
                TxtPG4.Text = "0"
                TxtPG5.Text = "0"
                MDPag1.Text = "00/00/0000" '""
                MDPag2.Text = "00/00/0000" '""
                MDPag3.Text = "00/00/0000" 'DBNull.Value.ToString '""
                MDPag4.Text = "00/00/0000" 'DBNull.Value.ToString '""
                MDPag5.Text = "00/00/0000" 'DBNull.Value.ToString '""
                ComboPag.SelectedIndex = 0
                txtNumPag.Text = "0"
                txtNumPag.Focused().ToString()
                txtNumPag.Focus()
            End If

        End If
    End Sub

    Private Sub BTN_Painel_confirmar_Click(sender As Object, e As EventArgs) Handles BTN_Painel_confirmar.Click
        Try
            Dim vend As New Vendas
            vend.FormPag = ComboPag.SelectedItem.ToString
            vend.CodStatus = "FECHADO"
            vend.NPagamento = txtNumPag.Text
            vend.P1 = TxtPG1.Text 'Convert.ToDouble(TxtPG1.Text)
            vend.P2 = TxtPG2.Text 'Convert.ToDouble(TxtPG2.Text)
            vend.P3 = TxtPG3.Text 'Convert.ToDouble(TxtPG3.Text)
            vend.P4 = TxtPG4.Text 'Convert.ToDouble(TxtPG4.Text)
            vend.P5 = TxtPG5.Text 'Convert.ToDouble(TxtPG5.Text)
            vend.V1 = IIf(MDPag1.Text = "00/00/0000", "0001-01-01", MDPag1.Text) 'MDPag1.Text
            vend.V2 = IIf(MDPag2.Text = "00/00/0000", "0001-01-01", MDPag2.Text) 'MDPag2.Text
            vend.V3 = IIf(MDPag3.Text = "00/00/0000", "0001-01-01", MDPag3.Text) '
            vend.V4 = IIf(MDPag4.Text = "00/00/0000", "0001-01-01", MDPag4.Text) 'MDPag4.Text
            vend.V5 = IIf(MDPag5.Text = "00/00/0000", "0001-01-01", MDPag5.Text) 'MDPag5.Text
            If vend.Venda_AlterarFormPag(TxtSequencial.Text) Then
                AtualizarEstoque()
                If LancarTitulosAReceber(TxtSequencial.Text, txtClientecodigo.Text, MtxtData.Text, txtTotal.Text, txtNumPag.Text) Then
                    'MsgBox("Não foi possivel lançar os Titulos a Receber", MsgBoxStyle.Information, "Fechamento da Venda.")
                End If
                MsgBox("Venda Finalizada.", MsgBoxStyle.Information, "Fechamento da Venda.")
                If vend.Consultar(TxtSequencial.Text) Then
                    TxtFormPag.Text = vend.FormPag
                    TxtStatus.Text = vend.CodStatus
                End If
                PainelPrincipal.Visible = False
            End If

        Catch ex As Exception
            MsgBox("Erro ao Fechar Venda.", MsgBoxStyle.Critical, "Fechamento da Venda.")
            'MsgBox(Convert.ToString(ex), MsgBoxStyle.Critical, "Fechamento da Venda.")
        End Try
    End Sub

    Private Sub CadVenda_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If TabControl1.SelectedIndex = 0 Then
            If e.KeyCode = 113 Then 'F2
                Dim vend As New Vendas
                Try
                    If TxtStatus.Text <> "ABERTO" Then
                        vend.CodStatus = "ABERTO"
                        If Not vend.Venda_ReAbrir(TxtSequencial.Text) Then
                            MsgBox("Erro ao reabir venda.", MsgBoxStyle.Critical, "Reabrir Venda")
                        Else
                            AtualizarEstoqueEstorno()
                            If Not RemoverTitulosRecebidos(TxtSequencial.Text) Then
                                MsgBox("Erro ao Remover Titulos Lançados.", MsgBoxStyle.Information, "Cancelar Venda")
                                Exit Sub
                            End If
                            If vend.Consultar(TxtSequencial.Text) Then
                                'TxtFormPag.Text = vend.FormPag
                                TxtStatus.Text = vend.CodStatus
                            End If
                            MsgBox("Venda Reaberta.", MsgBoxStyle.Information, "Reabrir Venda")
                        End If

                    End If
                Catch ex As Exception
                    MsgBox("Não foi Possivel realizar operação.", MsgBoxStyle.Critical, "Reabrir Venda")
                End Try
            ElseIf e.KeyCode = Keys.F6 Then 'F6
                If TxtStatus.Text <> "ABERTO" Then
                    Exit Sub
                End If

                Dim vend As New Vendas
                vend.CodStatus = "CANCELADA"
                If Not vend.Venda_ReAbrir(TxtSequencial.Text) Then
                    MsgBox("Erro ao cancelar venda.", MsgBoxStyle.Critical, "Cancelar Venda")
                Else
                    If Not RemoverTitulosRecebidos(TxtSequencial.Text) Then
                        MsgBox("Erro ao Remover Titulos Lançados.", MsgBoxStyle.Information, "Cancelar Venda")
                        Exit Sub
                    End If
                    If vend.Consultar(TxtSequencial.Text) Then
                        'TxtFormPag.Text = vend.FormPag
                        TxtStatus.Text = vend.CodStatus
                    End If
                    MsgBox("Venda Cancelada.", MsgBoxStyle.Information, "Cancelar Venda")
                End If
            End If
        End If
    End Sub



    'Private Sub DataGridView2_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView2.UserDeletedRow
    'Try

    '    If TxtStatus.Text = "ABERTO" Then
    '        If MsgBox("Deseja remover o item selecionado?", MsgBoxStyle.YesNo, "Removendo item lançado.") = MsgBoxResult.Yes Then
    '            Dim vend As New Vendas
    '            If vend.itens_Excluir(TxtSequencial.Text, DataGridView2.CurrentRow.Cells(0).Value) Then
    '                AtulizarGrid_itens("Select idproduto,Descricao,qtde,preco,total From Itens where idvenda=" & TxtSequencial.Text, "Itens")
    '                SomarProdutos(TxtSequencial.Text)
    '            Else
    '                MsgBox("Erro ao excluir o item.", MsgBoxStyle.Critical, "Excluir item.")
    '            End If
    '        End If
    '    End If

    'Catch ex As Exception
    '    MsgBox("Não foi possível excluir o item.", MsgBoxStyle.Critical, "Excluir item.")
    'End Try
    'End Sub

    Private Sub TxtProdTotal_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtProdTotal.KeyDown
        If e.KeyCode = Keys.Enter And ProdIncluindo Then
            If TxtStatus.Text <> "ABERTO" Then
                MsgBox("Não é possivel incluir item.    Status diferente de ABERTO", MsgBoxStyle.Information, "Incluir Item.")
                Exit Sub
            End If
            ProdIncluindo = False
            Dim ESTOQUE As Double
            ESTOQUE = 0
            Try
                If IsDBNull(TxtProdcodigo.Text) And Trim(TxtProdcodigo.Text) = "" Then
                    MsgBox("Código do Produto não informado.", MsgBoxStyle.Information, "Erro...")
                    Exit Sub
                End If

                Dim item As New Vendas
                item.itensNumero = TxtSequencial.Text
                item.itensProduto = TxtProdcodigo.Text
                item.itensDescricao = TxtProdDescricao.Text
                item.itensQuantidade = TxtProdQtde.Text
                item.itensValorUnit = TxtProdValorUnit.Text
                item.itensValorTotal = TxtProdTotal.Text
                If item.itens_Incluir() Then
                    AtulizarGrid_itens("Select idproduto, Descricao, qtde, preco,total From Itens where idvenda=" & item.itensNumero, "Itens")
                    SomarProdutos(item.itensNumero)
                    'Dim PROD As New Produto
                    'If PROD.Consultar(TxtProdcodigo.Text) Then
                    '    ESTOQUE = PROD.Estoque
                    '    If ComboBox1.SelectedIndex = 0 Then
                    '        ESTOQUE = ESTOQUE - item.itensQuantidade
                    '    Else
                    '        ESTOQUE = ESTOQUE + item.itensQuantidade
                    '    End If
                    '    PROD.BaixarEstoque(PROD.Codigo, ESTOQUE)
                    'End If
                    GravarTotais() '********* gravando totais da venda
                    TxtProdcodigo.Text = ""
                    TxtProdDescricao.Text = ""
                    TxtProdQtde.Text = ""
                    TxtProdValorUnit.Text = ""
                    TxtProdTotal.Text = ""
                    TxtProdcodigo.Text = ""
                End If
                TxtProdcodigo.Focus()
            Catch ex As Exception
                MsgBox("Não foi Possivel Inserir o item.", MsgBoxStyle.Critical, "Erro...")
            End Try
        End If
    End Sub



    Public Function AtualizarEstoque() As Boolean
        Try
            Dim ESTOQUE As Double
            ESTOQUE = 0
            If DataGridView2.RowCount <> 0 Then
                For Each coluna As DataGridViewRow In DataGridView2.Rows

                    Dim prod As New Produto

                    If prod.Consultar(coluna.Cells(0).Value) Then
                        ESTOQUE = prod.Estoque
                        If ComboBox1.SelectedIndex = 0 Then
                            ESTOQUE = ESTOQUE - coluna.Cells(2).Value
                        Else
                            ESTOQUE = ESTOQUE + coluna.Cells(2).Value
                        End If
                        prod.BaixarEstoque(prod.Codigo, ESTOQUE)

                    End If
                Next

            End If
            Return True
        Catch ex As Exception
            MsgBox("Não foi Possivel atualizar o Estoque.", MsgBoxStyle.Critical, "Atualizando estoque")
            Return False
        End Try
    End Function
    Public Function AtualizarEstoqueEstorno() As Boolean
        Try
            Dim ESTOQUE As Double
            ESTOQUE = 0
            If DataGridView2.RowCount <> 0 Then
                For Each coluna As DataGridViewRow In DataGridView2.Rows

                    Dim prod As New Produto

                    If prod.Consultar(coluna.Cells(0).Value) Then
                        ESTOQUE = prod.Estoque
                        If ComboBox1.SelectedIndex = 0 Then
                            ESTOQUE = ESTOQUE + coluna.Cells(2).Value
                        Else
                            ESTOQUE = ESTOQUE - coluna.Cells(2).Value
                        End If
                        prod.BaixarEstoque(prod.Codigo, ESTOQUE)

                    End If
                Next

            End If
            Return True
        Catch ex As Exception
            MsgBox("Não foi Possivel atualizar o Estoque.", MsgBoxStyle.Critical, "Atualizando estoque")
            Return False
        End Try
    End Function
    Public Function LancarTitulosAReceber(ByVal Vendas As Integer, ByVal cliente As Integer, ByVal Emissao As Date, ByVal valor As Double, ByVal Npag As Integer) As Boolean
        Try
            Dim cl As New ConteRec
            Dim UltVencimento As Date
            UltVencimento = FormatDateTime(DateAndTime.Today, DateFormat.ShortDate)
            For i = 1 To Npag
                cl.venda = Vendas
                cl.Cliente = cliente
                cl.emissao = Emissao
                cl.Valor = Format(valor / Npag, "N")
                UltVencimento = DateAdd("d", 30 * i, Emissao)
                cl.vencimento = UltVencimento
                cl.operador = txtVendedor.Text
                If Not cl.Incluir() Then
                    MsgBox("Erro ao lançar Titulo a Receber", MsgBoxStyle.Critical, "Titulos a Receber")
                End If
            Next


            Return True
        Catch ex As Exception
            MsgBox("Erro ao Atualizar Títulos a Receber.", MsgBoxStyle.Critical, "Titulos a Receber")
            Return False
        End Try

    End Function

    Public Function RemoverTitulosRecebidos(ByVal Vendas As Integer) As Boolean
        Try

            Dim vend As New Vendas
            If vend.Consultar(TxtSequencial.Text) Then
                Dim cl As New ConteRec
                If Not cl.Excluir(vend.CodCliente, vend.Codigo) Then
                    MsgBox("Erro ao lançar Titulo a Receber", MsgBoxStyle.Critical, "Titulos a Receber")
                End If

            End If

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


    Private Sub CheckBoxAberto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxAberto.CheckedChanged

        If CheckBoxAberto.Checked = True Then

            CheckBoxTodos.Enabled = False
            CheckBoxFechado.Enabled = False

        Else
            CheckBoxTodos.Enabled = True
            CheckBoxFechado.Enabled = True

        End If
    End Sub

    Private Sub CheckBoxFechado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxFechado.CheckedChanged
        If CheckBoxFechado.Checked = True Then

            CheckBoxAberto.Enabled = False
            CheckBoxTodos.Enabled = False

        Else
            CheckBoxAberto.Enabled = True
            CheckBoxTodos.Enabled = True
        End If
    End Sub
    Private Sub CheckBoxTodos_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTodos.CheckedChanged
        If CheckBoxTodos.Checked = True Then

            CheckBoxAberto.Enabled = False
            CheckBoxFechado.Enabled = False
        Else
            CheckBoxAberto.Enabled = True
            CheckBoxFechado.Enabled = True

        End If
    End Sub

    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        '   Mostra todos
        If CheckBoxTodos.Checked = True Then
            AtulizarGrid("select venda.id,Cliente.nome, Cliente.CNPJ,venda.data,venda.valorVenda from venda inner join cliente on Cliente.id = venda.idCliente where nome like ('%" & txtConsulta.Text & "%') order by Data DESC", "Venda")
            formatarGrid()
            'abertos
        ElseIf CheckBoxAberto.Checked = True Then
            AtulizarGrid("select venda.id,Cliente.nome, Cliente.CNPJ,venda.data,venda.valorVenda from venda inner join cliente on Cliente.id = venda.idCliente where nome like ('%" & txtConsulta.Text & "%') AND status='" & "ABERTO" & "'", "Venda")
            formatarGrid()
        Else
            AtulizarGrid("select venda.id,Cliente.nome, Cliente.CNPJ,venda.data,venda.valorVenda from venda inner join cliente on Cliente.id = venda.idCliente where nome like ('%" & txtConsulta.Text & "%') AND status='" & "FECHADO" & "'", "Venda")
            formatarGrid()
            'fechados
        End If


    End Sub

    Public Sub AtualizarVenda(ByVal codigo As Integer)
        Dim vend As New Vendas
        If vend.Consultar(codigo) Then
            TxtSequencial.Text = vend.Codigo
            txtTotal.Text = vend.TotalValor
            txtDesconto.Text = vend.Desconto
            TxtTotalProdutos.Text = vend.TotalProduto
            txtVendedor.Text = vend.codUsario
            MtxtData.Text = FormatDateTime(vend.Data, DateFormat.ShortDate)
            txtClientecodigo.Text = vend.CodCliente
            TxtFormPag.Text = vend.FormPag
            TxtStatus.Text = vend.CodStatus
            If vend.Natureza = "Venda de Mercadoria" Then
                ComboBox1.SelectedIndex = 0
            Else
                ComboBox1.SelectedIndex = 1
            End If

            Dim Cli As New Cliente
            If Cli.Consultar(vend.CodCliente) Then
                TXTcnpj.Text = Cli.CNPJ
                TxtClienteNome.Text = Cli.Nome
                TxtEndereco.Text = Cli.Endereco
                txtBairro.Text = Cli.Bairro
                txtCidade.Text = Cli.Cidade
                txtTelefone.Text = Cli.Telefone
            End If
            formatarGrid_itens()
            AtulizarGrid_itens("Select idproduto,Descricao,qtde,preco,total From Itens where idvenda=" & TxtSequencial.Text, "Itens")
            SomarProdutos(vend.Codigo)
            btn_habilita()
        End If
    End Sub
    Public Sub GravarTotais()
        Dim vend As New Vendas
        Try
            If Not IsDBNull(txtClientecodigo.Text) Then vend.CodCliente = txtClientecodigo.Text
            If Not IsDBNull(txtVendedor.Text) Then vend.codUsario = txtVendedor.Text
            If Not IsDBNull(MtxtData.Text) Then vend.Data = Convert.ToDateTime(MtxtData.Text)
            If Not IsDBNull(txtDesconto.Text) Then vend.Desconto = Convert.ToDouble(txtDesconto.Text)
            If Not IsDBNull(TxtTotalProdutos.Text) Then vend.TotalProduto = Convert.ToDouble(TxtTotalProdutos.Text)
            If Not IsDBNull(txtTotal.Text) Then vend.TotalValor = Convert.ToDouble(txtTotal.Text)
            vend.CodStatus = TxtStatus.Text
            vend.FormPag = TxtFormPag.Text
            vend.Natureza = ComboBox1.SelectedItem.ToString

            incluindo = False
            vend.Alterar(TxtSequencial.Text)
            AtulizarGrid("select venda.id,Cliente.nome, Cliente.CNPJ,venda.data,venda.valorVenda from venda inner join cliente on Cliente.id = venda.idCliente", "Venda")
            BtnConfirmar.Enabled = False
            btnCancelar.Enabled = False
            BtnIncluir.Enabled = True
            btnExcluir.Enabled = True
        Catch ex As Exception
            MsgBox("Erro em GravarTotais..", MsgBoxStyle.Critical, "Venda de Mercadoria")
        End Try
    End Sub


    Private Sub DataGridView2_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridView2.UserDeletingRow
        Try
            If TxtStatus.Text = "ABERTO" Then
                If MsgBox("Deseja remover o item selecionado?", MsgBoxStyle.YesNo, "Removendo item lançado.") = MsgBoxResult.Yes Then
                    Dim vend As New Vendas
                    If vend.itens_Excluir(TxtSequencial.Text, DataGridView2.CurrentRow.Cells(0).Value) Then
                        AtulizarGrid_itens("Select idproduto,Descricao,qtde,preco,total From Itens where idvenda=" & TxtSequencial.Text, "Itens")
                        SomarProdutos(TxtSequencial.Text)
                        GravarTotais()
                    Else
                        MsgBox("Erro ao excluir o item.", MsgBoxStyle.Critical, "Excluir item.")
                    End If
                End If
            End If
            AtulizarGrid_itens("Select idproduto,Descricao,qtde,preco,total From Itens where idvenda=" & TxtSequencial.Text, "Itens")
        Catch ex As Exception
            MsgBox("Não foi possível excluir o item.", MsgBoxStyle.Critical, "Excluir item.")
        End Try
    End Sub

    Private Sub DataGridView2_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView2.KeyDown
        If e.KeyCode = Keys.F5 Then
            Try
                If TxtStatus.Text = "ABERTO" Then
                    If MsgBox("Deseja remover o item selecionado?", MsgBoxStyle.YesNo, "Removendo item lançado.") = MsgBoxResult.Yes Then
                        Dim vend As New Vendas
                        If vend.itens_Excluir(TxtSequencial.Text, DataGridView2.CurrentRow.Cells(0).Value) Then
                            AtulizarGrid_itens("Select idproduto,Descricao,qtde,preco,total From Itens where idvenda=" & TxtSequencial.Text, "Itens")
                            SomarProdutos(TxtSequencial.Text)
                            GravarTotais()
                        Else
                            MsgBox("Erro ao excluir o item.", MsgBoxStyle.Critical, "Excluir item.")
                        End If
                    End If
                End If
                AtulizarGrid_itens("Select idproduto,Descricao,qtde,preco,total From Itens where idvenda=" & TxtSequencial.Text, "Itens")
            Catch ex As Exception
                MsgBox("Não foi possível excluir o item.", MsgBoxStyle.Critical, "Excluir item.")
            End Try
        End If
    End Sub
End Class