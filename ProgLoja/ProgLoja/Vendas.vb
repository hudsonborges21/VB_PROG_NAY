Imports System.Data.SqlClient


Public Class Vendas

#Region "Atributos"



    '************ C A B E Ç A L H O *********
    Private Acodigo As String
    Private Adata As Date
    Private ACodCliente As Integer
    Private ADesconto As Double
    Private AValorProd As Double
    Private AvalorTotal As Double
    Private AUsuario As Integer
    ' Private AFormPagTipo As Integer
    Private AFormPagTipo As String
    Private ANatOp As String
    Private AStatus As String
    Private AP1 As Double
    Private AV1 As Date
    Private AP2 As Double
    Private AV2 As Date
    Private AP3 As Double
    Private AV3 As Date
    Private AP4 As Double
    Private AV4 As Date
    Private AP5 As Double
    Private AV5 As Date
    Private ANPag As Integer

    '########### I T E N S ################
    Private iCodVenda As Integer
    Private icodProd As Integer
    Private idescricao As String
    Private iQtde As Double
    Private iValorUnit As Double
    Private ivalorTot As Double
    ' Private iatualizado As Double


   

    'criando a string de conexao com o banco de dados
    Private vStrConexao As String

    'objeto da classe conexao
    Dim CON As New Conexao

#End Region


#Region "Propriedades vendas Cabeçalho"


    'criando propriedade para encapsular os atributos do classe
    Public Property Codigo() As String
        Get
            Return Acodigo
        End Get
        Set(ByVal value As String)
            Acodigo = value
        End Set
    End Property
    Public Property Data() As Date
        Get
            Return Adata
        End Get
        Set(value As Date)
            Adata = value
        End Set
    End Property

    Public Property Desconto() As Double
        Get
            Return ADesconto
        End Get
        Set(value As Double)
            ADesconto = value
        End Set
    End Property

    Public Property TotalProduto() As Double
        Get
            Return AValorProd
        End Get
        Set(value As Double)
            AValorProd = value
        End Set
    End Property
    Public Property TotalValor() As Double
        Get
            Return AvalorTotal
        End Get
        Set(value As Double)
            AvalorTotal = value
        End Set
    End Property


    Public Property CodCliente() As Integer
        Get
            Return ACodCliente
        End Get
        Set(value As Integer)
            ACodCliente = value
        End Set
    End Property

    Public Property codUsario() As Integer
        Get
            Return AUsuario
        End Get
        Set(value As Integer)
            AUsuario = value
        End Set
    End Property

    Public Property FormPag() As String
        Get
            Return AFormPagTipo
        End Get
        Set(value As String)
            AFormPagTipo = value
        End Set
    End Property

    Public Property Natureza() As String
        Get
            Return ANatOp
        End Get
        Set(value As String)
            ANatOp = value
        End Set
    End Property
    Public Property CodStatus() As String
        Get
            Return AStatus
        End Get
        Set(value As String)
            AStatus = value
        End Set
    End Property

    Public Property P1() As Double
        Get
            Return AP1
        End Get
        Set(value As Double)
            AP1 = value
        End Set
    End Property
    Public Property P2() As Double
        Get
            Return AP2
        End Get
        Set(value As Double)
            AP2 = value
        End Set
    End Property
    Public Property P3() As Double
        Get
            Return AP3
        End Get
        Set(value As Double)
            AP3 = value
        End Set
    End Property
    Public Property P4() As Double
        Get
            Return AP4
        End Get
        Set(value As Double)
            AP4 = value
        End Set
    End Property
    Public Property P5() As Double
        Get
            Return AP5
        End Get
        Set(value As Double)
            AP5 = value
        End Set
    End Property

    Public Property V1() As Date
        Get
            Return AV1
        End Get
        Set(value As Date)
            AV1 = value
        End Set
    End Property
    Public Property V2() As Date
        Get
            Return AV2
        End Get
        Set(value As Date)
            AV2 = value
        End Set
    End Property
    Public Property V3() As Date
        Get
            Return AV3
        End Get
        Set(value As Date)
            AV3 = value
        End Set
    End Property
    Public Property V4() As Date
        Get
            Return AV4
        End Get
        Set(value As Date)
            AV4 = value
        End Set
    End Property
    Public Property V5() As Date
        Get
            Return AV5
        End Get
        Set(value As Date)
            AV5 = value
        End Set
    End Property
    Public Property NPagamento() As Integer
        Get
            Return ANPag
        End Get
        Set(value As Integer)
            ANPag = value
        End Set
    End Property

#End Region



#Region "Propriedades vendas Itens"

    Public Property itensNumero() As Integer
        Get
            Return iCodVenda
        End Get
        Set(value As Integer)
            iCodVenda = value
        End Set
    End Property

    Public Property itensProduto() As Integer
        Get
            Return icodProd
        End Get
        Set(value As Integer)
            icodProd = value
        End Set
    End Property

    Public Property itensDescricao() As String
        Get
            Return idescricao
        End Get
        Set(value As String)
            idescricao = value
        End Set
    End Property
    Public Property itensQuantidade() As Double
        Get
            Return iQtde
        End Get
        Set(value As Double)
            iQtde = value
        End Set
    End Property
    Public Property itensValorUnit() As Double
        Get
            Return iValorUnit
        End Get
        Set(value As Double)
            iValorUnit = value
        End Set
    End Property
    Public Property itensValorTotal() As Double
        Get
            Return ivalorTot
        End Get
        Set(value As Double)
            ivalorTot = value
        End Set
    End Property
    'Public Property Atualizado() As Integer
    '    Get
    '        Return iatualizado
    '    End Get
    '    Set(value As Integer)
    '        iatualizado = value
    '    End Set
    'End Property

#End Region

#Region "Metodos Vendas cabeçalho"

    'criando o construtor
    Public Sub New()
        vStrConexao = CON.StrConexao
    End Sub

    'METODO INCLUIR 
    Public Sub Incluir()
        Dim Conexao As SqlConnection
        Conexao = New SqlConnection(vStrConexao)
        'abrindo conexao 
        Conexao.Open()
        'dados em na forma de string da sql
        Dim Sql As String
        Sql = "Insert Into venda (data,idCliente,desconto,valorProdutos,valorVenda,idFormaPag,idUsuario,NatOp,Status,NPag) values (@data,@idCliente,@desconto,@valorProdutos,@valorVenda,@idFormaPag,@idUsuario,@NatOp,@Status,@NPag)"
        Dim comando As SqlCommand
        comando = New SqlCommand(Sql, Conexao)
        comando.Parameters.Add("@data", SqlDbType.Date).Value = Data
        comando.Parameters.Add("@idCliente", SqlDbType.Int).Value = CodCliente
        comando.Parameters.Add("@desconto", SqlDbType.Float).Value = Desconto
        comando.Parameters.Add("@valorProdutos", SqlDbType.Float).Value = TotalProduto
        comando.Parameters.Add("@valorVenda", SqlDbType.Float).Value = TotalValor
        comando.Parameters.Add("@idFormaPag", SqlDbType.VarChar).Value = "Avista" 'FormPag
        comando.Parameters.Add("@NPag", SqlDbType.Int).Value = 0
        comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = codUsario
        comando.Parameters.Add("@NatOp", SqlDbType.VarChar).Value = Natureza
        comando.Parameters.Add("@Status", SqlDbType.VarChar).Value = "ABERTO"
        'comando sql
        comando.ExecuteNonQuery()
        'fechando a conexao 
        Conexao.Close()

    End Sub
    Public Sub Vendas_gravarFormaPag(ByVal codigo As Integer)
        Dim Conexao As SqlConnection
        Conexao = New SqlConnection(vStrConexao)
        'abrindo conexao 
        Conexao.Open()
        'dados em na forma de string da sql
        Dim Sql As String
        Sql = "Insert Into venda (P1,v1,P2,v2,P3,v3,P4,v4,P5,v5,Npag) values (@P1,@v1,@P2,@v2,@P3,@v3,@P4,@v4,@P5,@v5,@Npag) where id=" & codigo
        Dim comando As SqlCommand
        comando = New SqlCommand(Sql, Conexao)
        comando.Parameters.Add("@Npag", SqlDbType.Date).Value = NPagamento
        comando.Parameters.Add("@V1", SqlDbType.Date).Value = V1
        comando.Parameters.Add("@V2", SqlDbType.Date).Value = V2
        comando.Parameters.Add("@V3", SqlDbType.Date).Value = V3
        comando.Parameters.Add("@V4", SqlDbType.Date).Value = V4
        comando.Parameters.Add("@V5", SqlDbType.Date).Value = V5
        comando.Parameters.Add("@P1", SqlDbType.Float).Value = P1
        comando.Parameters.Add("@P2", SqlDbType.Float).Value = P2
        comando.Parameters.Add("@P3", SqlDbType.Float).Value = P3
        comando.Parameters.Add("@P4", SqlDbType.Float).Value = P4
        comando.Parameters.Add("@P5", SqlDbType.Float).Value = P5

        'comando sql
        comando.ExecuteNonQuery()
        'fechando a conexao 
        Conexao.Close()

    End Sub
    Public Function Venda_AlterarFormPag(ByVal Codigo As Integer) As Boolean
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao 
        conexao.Open()

        Dim sql As String

        sql = " UPDATE VENDA SET  idFormaPag = @idFormaPag, Npag = @Npag,P1=@P1,V1=@V1,P2=@P2,V2=@V2, P3=@P3,V3=@V3,P4=@P4,V4=@V4,P5=@P5,V5=@V5,status=@Status WHERE id = " & Codigo
        'sql = " UPDATE VENDA SET  idFormaPag = @idFormaPag, Npag = @Npag,P1=@P1,P2=@P2,P3=@P3,P4=@P4,P5=@P5, status=@Status WHERE id = " & Codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)
        comando.Parameters.Add("@idFormaPag", SqlDbType.VarChar).Value = AFormPagTipo
        comando.Parameters.Add("@Status", SqlDbType.VarChar).Value = CodStatus
        comando.Parameters.Add("@Npag", SqlDbType.Int).Value = NPagamento
        comando.Parameters.Add("@V1", SqlDbType.Date).Value = V1
        comando.Parameters.Add("@V2", SqlDbType.Date).Value = V2
        comando.Parameters.Add("@V3", SqlDbType.Date).Value = V3
        comando.Parameters.Add("@V4", SqlDbType.Date).Value = V4
        comando.Parameters.Add("@V5", SqlDbType.Date).Value = V5
        comando.Parameters.Add("@P1", SqlDbType.Float).Value = P1
        comando.Parameters.Add("@P2", SqlDbType.Float).Value = P2
        comando.Parameters.Add("@P3", SqlDbType.Float).Value = P3
        comando.Parameters.Add("@P4", SqlDbType.Float).Value = P4
        comando.Parameters.Add("@P5", SqlDbType.Float).Value = P5
        comando.ExecuteNonQuery()
        'fechando a conexao com o banco
        conexao.Close()
        Return True

    End Function
    Public Function Venda_ReAbrir(ByVal Codigo As Integer) As Boolean
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao 
        conexao.Open()

        Dim sql As String

        sql = " UPDATE VENDA SET status=@Status WHERE id = " & Codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)
        'comando.Parameters.Add("@idFormaPag", SqlDbType.VarChar).Value = AFormPagTipo
        comando.Parameters.Add("@Status", SqlDbType.VarChar).Value = CodStatus
        comando.ExecuteNonQuery()
        'fechando a conexao com o banco
        conexao.Close()
        Return True

    End Function
    'CONSULTAR 
    Public Function Venda_ConsultarFomr(ByVal codigo As Integer) As Boolean

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "SELECT * FROM VENDA where id = " & codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataReader As SqlDataReader
        dataReader = comando.ExecuteReader

        'dataReader buscar uma linha 
        If dataReader.HasRows Then
            dataReader.Read()
            Acodigo = dataReader("ID")
            'If Not IsDBNull(dataReader("idCliente")) Then ACodCliente = dataReader("idCliente")
            'If Not IsDBNull(dataReader("idUsuario")) Then AUsuario = dataReader("idUsuario")
            If Not IsDBNull(dataReader("idFormaPag")) Then AFormPagTipo = dataReader("idFormaPag")
            'If Not IsDBNull(dataReader("desconto")) Then ADesconto = dataReader("desconto")
            'If Not IsDBNull(dataReader("valorProdutos")) Then AValorProd = dataReader("valorProdutos")
            'If Not IsDBNull(dataReader("valorVenda")) Then AvalorTotal = dataReader("valorVenda")
            'If Not IsDBNull(dataReader("data")) Then Adata = dataReader("data")
            If Not IsDBNull(dataReader("Npag")) Then ANPag = dataReader("Npag")
            If Not IsDBNull(dataReader("status")) Then CodStatus = dataReader("status")
            If Not IsDBNull(dataReader("P1")) Then AP1 = dataReader("P1")
            If Not IsDBNull(dataReader("P2")) Then AP2 = dataReader("P2")
            If Not IsDBNull(dataReader("P3")) Then AP3 = dataReader("P3")
            If Not IsDBNull(dataReader("P4")) Then AP4 = dataReader("P4")
            If Not IsDBNull(dataReader("P5")) Then AP5 = dataReader("P5")
            If Not IsDBNull(dataReader("V1")) Then AV1 = dataReader("V1")
            If Not IsDBNull(dataReader("V2")) Then AV2 = dataReader("V2")
            If Not IsDBNull(dataReader("V3")) Then AV3 = dataReader("V3")
            If Not IsDBNull(dataReader("V4")) Then AV4 = dataReader("V4")
            If Not IsDBNull(dataReader("V5")) Then AV5 = dataReader("V5")

            Return True
        Else
            Return False
        End If

        'fechando o conexao 
        conexao.Close()

    End Function

    'CONSULTAR 
    Public Function Consultar(ByVal codigo As Integer) As Boolean

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "SELECT * FROM VENDA where id = " & codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataReader As SqlDataReader
        dataReader = comando.ExecuteReader

        'dataReader buscar uma linha 
        If dataReader.HasRows Then
            dataReader.Read()
            Acodigo = dataReader("ID")
            If Not IsDBNull(dataReader("idCliente")) Then ACodCliente = dataReader("idCliente")
            If Not IsDBNull(dataReader("idUsuario")) Then AUsuario = dataReader("idUsuario")
            If Not IsDBNull(dataReader("idFormaPag")) Then AFormPagTipo = dataReader("idFormaPag")
            If Not IsDBNull(dataReader("desconto")) Then ADesconto = dataReader("desconto")
            If Not IsDBNull(dataReader("valorProdutos")) Then AValorProd = dataReader("valorProdutos")
            If Not IsDBNull(dataReader("valorVenda")) Then AvalorTotal = dataReader("valorVenda")
            If Not IsDBNull(dataReader("data")) Then Adata = dataReader("data")
            If Not IsDBNull(dataReader("NatOp")) Then ANatOp = dataReader("NatOp")
            If Not IsDBNull(dataReader("status")) Then AStatus = dataReader("status")
            If Not IsDBNull(dataReader("Npag")) Then ANPag = dataReader("Npag")
            Return True
        Else
            Return False
        End If

        'fechando o conexao 
        conexao.Close()

    End Function


    'ALTERAR  - UPDATE
    Public Function Alterar(ByVal Codigo As Integer) 'As Boolean
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao 
        conexao.Open()

        Dim sql As String

        sql = " UPDATE VENDA SET  data =@data,idCliente=@idCliente,desconto=@desconto,valorProdutos=@valorProdutos,valorVenda=@valorVenda,idFormaPag=@idFormaPag,idUsuario=@idUsuario, status=@status WHERE id = " & Codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        comando.Parameters.Add("@data", SqlDbType.Date).Value = Data
        comando.Parameters.Add("@idCliente", SqlDbType.Int).Value = CodCliente
        comando.Parameters.Add("@desconto", SqlDbType.Float).Value = Desconto
        comando.Parameters.Add("@valorProdutos", SqlDbType.Float).Value = TotalProduto
        comando.Parameters.Add("@valorVenda", SqlDbType.Float).Value = TotalValor
        comando.Parameters.Add("@idFormaPag", SqlDbType.VarChar).Value = FormPag
        comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = codUsario
        comando.Parameters.Add("@NatOp", SqlDbType.VarChar).Value = Natureza
        comando.Parameters.Add("@Status", SqlDbType.VarChar).Value = CodStatus
        comando.ExecuteNonQuery()
        'fechando a conexao com o banco
        conexao.Close()
        Return False

    End Function


    'EXCLUIR  - DELETE
    Public Function Excluir(ByVal Codigo As Integer) As Boolean

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "DELETE FROM Venda WHERE id = " & Codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        comando.ExecuteNonQuery()

        'fechando 
        conexao.Close()

        Return True
    End Function



    Public Function BuscarCliente(ByVal codigo As Integer) As String
        Dim nome As String
        nome = ""
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "SELECT id, Nome FROM Cliente where id = " & codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataReader As SqlDataReader
        dataReader = comando.ExecuteReader

        'dataReader buscar uma linha 
        If dataReader.HasRows Then
            dataReader.Read()
            If Not IsDBNull(dataReader("Nome")) Then nome = dataReader("Nome")
            Return nome
        Else
            Return nome
        End If

        'fechando o conexao 
        conexao.Close()

    End Function

    Public Function UltimaVenda() As String
        Dim resp As String
        resp = ""
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)
        'abrindo a conexao com o banco
        conexao.Open()
        'criando o comando sql
        Dim sql As String
        sql = "SELECT max(id) as ultima FROM Venda"
        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)
        Dim dataReader As SqlDataReader
        dataReader = comando.ExecuteReader
        'dataReader buscar uma linha 
        If dataReader.HasRows Then
            dataReader.Read()
            If Not IsDBNull(dataReader("ultima")) Then
                resp = dataReader("ultima") + 1
            Else
                resp = 1
            End If

            Return resp
        Else
            Return resp
        End If

        'fechando o conexao 
        conexao.Close()

    End Function
#End Region


#Region "Metodos Vendas Itens"

    'METODO INCLUIR 
    Public Function itens_Incluir() As Boolean

        Dim Conexao As SqlConnection
        Conexao = New SqlConnection(vStrConexao)
        'abrindo conexao 
        Conexao.Open()
        'dados em na forma de string da sql
        Dim Sql As String
        Sql = "Insert Into ITENS(idVenda,idProduto,Descricao,qtde,preco,total) values (@idVenda,@idProduto,@Descricao,@qtde,@preco,@total)"
        Dim comando As SqlCommand
        comando = New SqlCommand(Sql, Conexao)
        comando.Parameters.Add("@idVenda", SqlDbType.Int).Value = itensNumero
        comando.Parameters.Add("@idProduto", SqlDbType.Int).Value = itensProduto
        comando.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = itensDescricao
        comando.Parameters.Add("@qtde", SqlDbType.Float).Value = itensQuantidade
        comando.Parameters.Add("@preco", SqlDbType.Float).Value = itensValorUnit
        comando.Parameters.Add("@total", SqlDbType.Int).Value = itensValorTotal
        'comando.Parameters.Add("@Atualizado", SqlDbType.Int).Value = 0

        'comando sql
        comando.ExecuteNonQuery()
        'fechando a conexao 
        Conexao.Close()
        Return True
    End Function

    'CONSULTAR 
    Public Function itens_Consultar(ByVal codigo As Integer) As Boolean

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "SELECT * FROM itens where idVenda = " & codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataReader As SqlDataReader
        dataReader = comando.ExecuteReader

        'dataReader buscar uma linha 
        If dataReader.HasRows Then
            dataReader.Read()
            iCodVenda = dataReader("idVenda")
            If Not IsDBNull(dataReader("idProduto")) Then icodProd = dataReader("idProduto")
            If Not IsDBNull(dataReader("Descricao")) Then idescricao = dataReader("Descricao")
            If Not IsDBNull(dataReader("qtde")) Then iQtde = dataReader("qtde")
            If Not IsDBNull(dataReader("preco")) Then iValorUnit = dataReader("preco")
            If Not IsDBNull(dataReader("total")) Then ivalorTot = dataReader("total")
            'If Not IsDBNull(dataReader("Atualizado")) Then Atualizado = dataReader("Atualizado")
            
            Return True
        Else
            Return False
        End If

        'fechando o conexao 
        conexao.Close()

    End Function
    Public Function itens_SomarProdutos(ByVal codigo As Integer) As Boolean
        Dim resp As Double
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "select sum(Itens.total) as tot, sum(venda.desconto) as d from venda inner join Itens on Itens.idVenda = venda.id where itens.idVenda = " & codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataReader As SqlDataReader
        dataReader = comando.ExecuteReader
        resp = 0

        'dataReader buscar uma linha 
        If dataReader.HasRows Then
            dataReader.Read()
            If Not IsDBNull(dataReader("tot")) Then AValorProd = dataReader("tot")
            If Not IsDBNull(dataReader("d")) Then ADesconto = dataReader("d")

            Return True
        Else
            Return True
        End If

        'fechando o conexao 
        conexao.Close()

    End Function

    'ALTERAR  - UPDATE
    Public Function itens_Alterar(ByVal Codigo As Integer) 'As Boolean
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao 
        conexao.Open()

        Dim sql As String

        sql = " UPDATE itens SET  idVenda =@idVenda,idProduto=@idProduto,Descricao=@Descricao,qtde=@qtde,preco=@preco,total=@total WHERE idVenda = " & Codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)
        comando.Parameters.Add("@idVenda", SqlDbType.Int).Value = itensNumero
        comando.Parameters.Add("@idProduto", SqlDbType.Int).Value = itensProduto
        comando.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = itensDescricao
        comando.Parameters.Add("@qtde", SqlDbType.Float).Value = itensQuantidade
        comando.Parameters.Add("@preco", SqlDbType.Float).Value = itensValorUnit
        comando.Parameters.Add("@total", SqlDbType.Int).Value = itensValorTotal
        comando.ExecuteNonQuery()
        'fechando a conexao com o banco
        conexao.Close()
        Return False

    End Function


    'EXCLUIR  - DELETE
    Public Function itens_Excluir(ByVal CodigoVenda As Integer, ByVal codigo As Integer) As Boolean

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "DELETE FROM ITENS WHERE idVenda = " & CodigoVenda & " and idProduto= " & codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        comando.ExecuteNonQuery()

        'fechando 
        conexao.Close()

        Return True
    End Function
    Public Function itens_Excluir(ByVal CodigoVenda As Integer) As Boolean

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "DELETE FROM ITENS WHERE idVenda = " & CodigoVenda

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        comando.ExecuteNonQuery()

        'fechando 
        conexao.Close()

        Return True
    End Function
    Public Function BaixarEstoque(ByVal Codigo As Integer, ByVal Qtde As Double) 'As Boolean
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao 
        conexao.Open()

        Dim sql As String
        sql = "UPDATE Produto SET estoque = @ESTOQUE WHERE id = " & Codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)
        comando.Parameters.Add("@estoque", SqlDbType.Float).Value = Qtde
        comando.ExecuteNonQuery()

        Dim sql2 As String
        sql2 = " UPDATE itens SET Atualizado = @Atualizado WHERE id = " & Codigo

        Dim comando2 As SqlCommand
        comando2 = New SqlCommand(sql2, conexao)
        comando2.Parameters.Add("@Atualizado", SqlDbType.Int).Value = 1
        comando2.ExecuteNonQuery()

        'fechando a conexao com o banco
        conexao.Close()
        Return False

    End Function
#End Region


End Class
