Imports System.Data.SqlClient

Public Class Produto

#Region "Atributos"



    'declarando os atributos da classe produto
    Private Acodigo As String
    Private Adescricao As String
    Private ASecao As String
    Private AEstoque As Double
    Private ACusto As Double
    Private AMargem As Double
    Private Apreco As Double
    Private AidForn As Integer
    Private Aimagem As String
    Private AFornecedor As String
    Private AcodigoEan As String

    'criando a string de conexao com o banco de dados
    Private vStrConexao As String

    'objeto da classe conexao
    Dim CON As New Conexao

#End Region


#Region "Propriedades"


    'criando propriedade para encapsular os atributos do classe
    Public Property Codigo() As String
        Get
            Return Acodigo
        End Get
        Set(ByVal value As String)
            Acodigo = value
        End Set
    End Property
    Public Property CodigoEAN() As String
        Get
            Return AcodigoEan
        End Get
        Set(ByVal value As String)
            AcodigoEan = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return Adescricao
        End Get
        Set(ByVal value As String)
            Adescricao = value
        End Set
    End Property

    Public Property Secao() As String
        Get
            Return ASecao
        End Get
        Set(value As String)
            ASecao = value
        End Set
    End Property

    Public Property Estoque() As Double
        Get
            Return AEstoque
        End Get
        Set(value As Double)
            AEstoque = value
        End Set
    End Property
    Public Property Custo() As Double
        Get
            Return ACusto
        End Get
        Set(value As Double)
            ACusto = value
        End Set
    End Property
    Public Property Preco() As Double
        Get
            Return Apreco
        End Get
        Set(value As Double)
            Apreco = value
        End Set
    End Property
    Public Property Margem() As Double
        Get
            Return AMargem
        End Get
        Set(value As Double)
            AMargem = value
        End Set
    End Property
    Public Property codFornecedor() As Integer
        Get
            Return AidForn
        End Get
        Set(value As Integer)
            AidForn = value
        End Set
    End Property
    Public Property fornecedor() As String
        Get
            Return AFornecedor
        End Get
        Set(value As String)
            AFornecedor = value
        End Set
    End Property

#End Region


#Region "Metodos"

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
        Sql = "Insert Into Produto(descricao, secao, estoque, custo,precovenda,margem,idForn,fornNome,codigo) values (@descricao, @secao, @estoque, @custo, @precovenda, @margem, @idForn,@fornNome,@codigo)"

        Dim comando As SqlCommand
        comando = New SqlCommand(Sql, Conexao)

        comando.Parameters.Add("@descricao", Data.SqlDbType.VarChar).Value = Descricao
        comando.Parameters.Add("@secao", Data.SqlDbType.VarChar).Value = Secao
        comando.Parameters.Add("@estoque", Data.SqlDbType.Float).Value = Estoque
        comando.Parameters.Add("@custo", Data.SqlDbType.Float).Value = Custo
        comando.Parameters.Add("@precovenda", SqlDbType.Float).Value = Preco
        comando.Parameters.Add("@Margem", SqlDbType.Float).Value = Margem
        comando.Parameters.Add("@idForn", Data.SqlDbType.Int).Value = codFornecedor
        comando.Parameters.Add("@fornNome", Data.SqlDbType.VarChar).Value = fornecedor
        comando.Parameters.Add("@codigo", Data.SqlDbType.VarChar).Value = CodigoEAN

        'comando sql
        comando.ExecuteNonQuery()

        'fechando a conexao 
        Conexao.Close()

    End Sub

    'CONSULTAR 
    Public Function Consultar(ByVal codigo As Integer) As Boolean

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "SELECT * FROM Produto where id = " & codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataReader As SqlDataReader
        dataReader = comando.ExecuteReader

        'dataReader buscar uma linha 
        If dataReader.HasRows Then
            dataReader.Read()
            Acodigo = dataReader("ID")
            If Not IsDBNull(dataReader("descricao")) Then Adescricao = dataReader("descricao")
            If Not IsDBNull(dataReader("Secao")) Then ASecao = dataReader("Secao")
            If Not IsDBNull(dataReader("Estoque")) Then AEstoque = dataReader("Estoque")
            If Not IsDBNull(dataReader("Custo")) Then ACusto = dataReader("Custo")
            If Not IsDBNull(dataReader("precovenda")) Then Apreco = dataReader("precovenda")
            If Not IsDBNull(dataReader("margem")) Then AMargem = dataReader("margem")
            If Not IsDBNull(dataReader("idforn")) Then AidForn = dataReader("idforn")
            If Not IsDBNull(dataReader("fornNome")) Then AFornecedor = dataReader("fornNome")
            If Not IsDBNull(dataReader("codigo")) Then AcodigoEan = dataReader("codigo")
            Return True
        Else
            Return False
        End If

        'fechando o conexao 
        conexao.Close()

    End Function


    'ALTERAR  - UPDATE
    Public Function Alterar(ByVal Codigo As Integer) 'As Boolean
        'Dim dcusto, dpreco, dmargem, dee As Double

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao 
        conexao.Open()
        Dim sql As String
        sql = " UPDATE Produto SET  descricao = @DESCRICAO ,secao = @SECAO , estoque = @ESTOQUE , precovenda = @PRECOVENDA , margem = @margem , idforn = @idForn , fornNome = @FornNome , codigo = @codigo ,custo = @Custo WHERE id = " & Codigo
        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)
        comando.Parameters.Add("@descricao", Data.SqlDbType.VarChar).Value = Descricao
        comando.Parameters.Add("@secao", Data.SqlDbType.VarChar).Value = Secao
        comando.Parameters.Add("@estoque", Data.SqlDbType.Float).Value = Estoque
        comando.Parameters.Add("@custo", Data.SqlDbType.Decimal).Value = Custo
        comando.Parameters.Add("@precovenda", Data.SqlDbType.Float).Value = Preco
        comando.Parameters.Add("@Margem", Data.SqlDbType.Float).Value = Margem
        comando.Parameters.Add("@idForn", Data.SqlDbType.Int).Value = codFornecedor
        comando.Parameters.Add("@fornNome", Data.SqlDbType.VarChar).Value = fornecedor
        comando.Parameters.Add("@codigo", Data.SqlDbType.VarChar).Value = CodigoEAN
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
        sql = "DELETE FROM Produto WHERE id = " & Codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        comando.ExecuteNonQuery()

        'fechando 
        conexao.Close()

        Return True
    End Function

    Public Function CalcularMagemBruta(ByVal Custo As Double, ByVal Preco As Double) As Double
        Dim resp As Double
        resp = 0
        If Custo <> 0 Then resp = Format(((Preco - Custo) / Custo) * 100, "0.00")

        Return resp
    End Function

    Public Function BuscarFornecedor(ByVal codigo As Integer) As String
        Dim nome As String
        nome = ""
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "SELECT id, Nome FROM Fornecedor where id = " & codigo

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

    Public Function BaixarEstoque(ByVal Codigo As Integer, ByVal Qtde As Double) 'As Boolean
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao 
        conexao.Open()

        Dim sql As String
        sql = " UPDATE Produto SET estoque = @ESTOQUE WHERE id = " & Codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)
        comando.Parameters.Add("@estoque", SqlDbType.Float).Value = Qtde
        comando.ExecuteNonQuery()
        'fechando a conexao com o banco
        conexao.Close()
        Return False

    End Function
#End Region
End Class
