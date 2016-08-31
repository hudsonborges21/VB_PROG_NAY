Imports System.Data.SqlClient

Public Class ConteRec

#Region "Atributos"



    'declarando os atributos da classe produto
    Private Avenda As Integer
    Private ACliente As Integer
    Private AData As Date
    Private AVencimento As Date
    Private Avalor As Double
    Private ADataRec As Date
    Private Adesconto As Double
    Private AAcrescimo As Double
    Private AValorRec As Double
    Private AUsuario As Integer


    'criando a string de conexao com o banco de dados
    Private vStrConexao As String

    'objeto da classe conexao
    Dim CON As New Conexao

#End Region


#Region "Propriedades"
    Public Property venda() As Integer
        Get
            Return Avenda
        End Get
        Set(value As Integer)
            Avenda = value
        End Set
    End Property
    Public Property Cliente() As Integer
        Get
            Return ACliente
        End Get
        Set(value As Integer)
            ACliente = value
        End Set
    End Property

    Public Property emissao() As Date
        Get
            Return AData
        End Get
        Set(value As Date)
            AData = value
        End Set
    End Property
    Public Property dataRec() As Date
        Get
            Return ADataRec
        End Get
        Set(value As Date)
            ADataRec = value
        End Set
    End Property
    Public Property vencimento() As Date
        Get
            Return AVencimento
        End Get
        Set(value As Date)
            AVencimento = value
        End Set
    End Property

    Public Property Valor() As Double
        Get
            Return Avalor
        End Get
        Set(value As Double)
            Avalor = value
        End Set
    End Property
    Public Property desconto() As Double
        Get
            Return Adesconto
        End Get
        Set(value As Double)
            Adesconto = value
        End Set
    End Property
    Public Property acrescimo() As Double
        Get
            Return AAcrescimo
        End Get
        Set(value As Double)
            AAcrescimo = value
        End Set
    End Property
    Public Property ValorRec() As Double
        Get
            Return AValorRec

        End Get
        Set(value As Double)
            AValorRec = value
        End Set
    End Property
    Public Property operador() As Double
        Get
            Return AUsuario
        End Get
        Set(value As Double)
            AUsuario = value
        End Set
    End Property
#End Region


#Region "Metodos"

    'criando o construtor
    Public Sub New()
        vStrConexao = CON.StrConexao
    End Sub

    'METODO INCLUIR 
    Public Function Incluir() As Boolean


        Dim Conexao As SqlConnection

        Conexao = New SqlConnection(vStrConexao)

        'abrindo conexao 
        Conexao.Open()

        'dados em na forma de string da sql
        Dim Sql As String
        Sql = "Insert Into ContRec(id,idCliente,emissao,valor, ValorRec,desconto,acrescimo,operador,vencimento) values (@id,@idCliente,@emissao,@valor,@ValorRec,@desconto,@acrescimo,@operador,@vencimento)"

        Dim comando As SqlCommand
        comando = New SqlCommand(Sql, Conexao)

        comando.Parameters.Add("@id", Data.SqlDbType.Int).Value = venda
        comando.Parameters.Add("@idCliente", Data.SqlDbType.Int).Value = Cliente
        comando.Parameters.Add("@emissao", Data.SqlDbType.Date).Value = emissao
        comando.Parameters.Add("@valor", Data.SqlDbType.Float).Value = Valor
        'comando.Parameters.Add("@DATAREC", Data.SqlDbType.Date).Value = ADataRec
        comando.Parameters.Add("@ValorRec", Data.SqlDbType.Float).Value = 0 'ValorRec
        comando.Parameters.Add("@desconto", Data.SqlDbType.Float).Value = 0 'desconto
        comando.Parameters.Add("@acrescimo", Data.SqlDbType.Float).Value = 0 'acrescimo
        comando.Parameters.Add("@operador", Data.SqlDbType.VarChar).Value = operador
        comando.Parameters.Add("@vencimento", Data.SqlDbType.Date).Value = vencimento

        'comando sql
        comando.ExecuteNonQuery()
        Return True
        'fechando a conexao 
        Conexao.Close()

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
        sql = "SELECT * FROM Contrec where idcliente = " & codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataReader As SqlDataReader
        dataReader = comando.ExecuteReader

        'dataReader buscar uma linha 
        If dataReader.HasRows Then
            dataReader.Read()
            Avenda = dataReader("ID")
            If Not IsDBNull(dataReader("idcliente")) Then ACliente = dataReader("idcliente")
            If Not IsDBNull(dataReader("emissao")) Then AData = dataReader("emissao")
            If Not IsDBNull(dataReader("valor")) Then Avalor = dataReader("valor")
            If Not IsDBNull(dataReader("DATAREC")) Then ADataRec = dataReader("DATAREC")
            If Not IsDBNull(dataReader("ValorRec")) Then AValorRec = dataReader("ValorRec")
            If Not IsDBNull(dataReader("desconto")) Then Adesconto = dataReader("desconto")
            If Not IsDBNull(dataReader("acrescimo")) Then AAcrescimo = dataReader("acrescimo")
            If Not IsDBNull(dataReader("operador")) Then AUsuario = dataReader("operador")
            If Not IsDBNull(dataReader("vencimento")) Then AVencimento = dataReader("vencimento")
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
        sql = " UPDATE Produto SET id=@id , idCliente= @idCliente, emissao=@emissao,valor=@valor,DATAREC=@DATAREC,ValorRec=@ValorRec,desconto=@desconto,acrescimo=@acrescimo, vencimento@vencimento WHERE idvenda = " & Codigo
        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)
        comando.Parameters.Add("@id", Data.SqlDbType.Int).Value = venda
        comando.Parameters.Add("@idCliente", Data.SqlDbType.Int).Value = Cliente
        comando.Parameters.Add("@emissao", Data.SqlDbType.Date).Value = emissao
        comando.Parameters.Add("@valor", Data.SqlDbType.Float).Value = Valor
        comando.Parameters.Add("@DATAREC", Data.SqlDbType.Date).Value = ADataRec
        comando.Parameters.Add("@ValorRec", Data.SqlDbType.Float).Value = ValorRec
        comando.Parameters.Add("@desconto", Data.SqlDbType.Float).Value = desconto
        comando.Parameters.Add("@acrescimo", Data.SqlDbType.Float).Value = acrescimo
        'comando.Parameters.Add("@operador", Data.SqlDbType.VarChar).Value = operador
        comando.Parameters.Add("@vencimento", Data.SqlDbType.Date).Value = vencimento
        comando.ExecuteNonQuery()
        'fechando a conexao com o banco
        conexao.Close()
        Return False

    End Function
    Public Function BaixarTitulo(ByVal cliente As Integer, ByVal vendas As Integer, ByVal vencimento As Date) As Boolean
        'Dim dcusto, dpreco, dmargem, dee As Double

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao 
        conexao.Open()
        Dim sql As String
        'sql = " UPDATE Produto SET id=@id , idCliente= @idCliente, emissao=@emissao,valor=@valor,DATAREC=@DATAREC,ValorRec=@ValorRec,desconto=@desconto,acrescimo=@acrescimo, vencimento@vencimento WHERE idvenda = " & Codigo
        sql = " UPDATE ContRec SET DATAREC=@DATAREC,ValorRec=@ValorRec,desconto=@desconto,acrescimo=@acrescimo WHERE id = " & venda & " and idcliente =" & cliente & " and vencimento='" & vencimento & "'"
        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)
        'comando.Parameters.Add("@id", Data.SqlDbType.Int).Value = venda
        'comando.Parameters.Add("@idCliente", Data.SqlDbType.Int).Value = Cliente
        'comando.Parameters.Add("@emissao", Data.SqlDbType.Date).Value = emissao
        'comando.Parameters.Add("@valor", Data.SqlDbType.Float).Value = Valor
        comando.Parameters.Add("@DATAREC", Data.SqlDbType.Date).Value = ADataRec
        comando.Parameters.Add("@ValorRec", Data.SqlDbType.Float).Value = ValorRec
        comando.Parameters.Add("@desconto", Data.SqlDbType.Float).Value = desconto
        comando.Parameters.Add("@acrescimo", Data.SqlDbType.Float).Value = acrescimo
        'comando.Parameters.Add("@operador", Data.SqlDbType.VarChar).Value = operador
        'comando.Parameters.Add("@vencimento", Data.SqlDbType.Date).Value = vencimento
        comando.ExecuteNonQuery()
        'fechando a conexao com o banco
        conexao.Close()
        Return True

    End Function

    Public Function CancelarBaixarTitulo(ByVal cliente As Integer, ByVal vendas As Integer, ByVal vencimento As Date, ByVal datarec As Date) As Boolean
        'Dim dcusto, dpreco, dmargem, dee As Double

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao 
        conexao.Open()
        Dim sql As String
        'sql = " UPDATE Produto SET id=@id , idCliente= @idCliente, emissao=@emissao,valor=@valor,DATAREC=@DATAREC,ValorRec=@ValorRec,desconto=@desconto,acrescimo=@acrescimo, vencimento@vencimento WHERE idvenda = " & Codigo
        sql = " UPDATE ContRec SET DATAREC=@DATAREC,ValorRec=@ValorRec,desconto=@desconto,acrescimo=@acrescimo WHERE id = " & venda & " and idcliente =" & cliente & "and datarec ='" & datarec & "' and vencimento='" & vencimento & "'"
        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)
        'comando.Parameters.Add("@id", Data.SqlDbType.Int).Value = venda
        'comando.Parameters.Add("@idCliente", Data.SqlDbType.Int).Value = Cliente
        'comando.Parameters.Add("@emissao", Data.SqlDbType.Date).Value = emissao
        'comando.Parameters.Add("@valor", Data.SqlDbType.Float).Value = Valor
        comando.Parameters.Add("@DATAREC", Data.SqlDbType.Date).Value = DBNull.Value
        comando.Parameters.Add("@ValorRec", Data.SqlDbType.Float).Value = 0
        comando.Parameters.Add("@desconto", Data.SqlDbType.Float).Value = 0
        comando.Parameters.Add("@acrescimo", Data.SqlDbType.Float).Value = 0
        'comando.Parameters.Add("@operador", Data.SqlDbType.VarChar).Value = operador
        'comando.Parameters.Add("@vencimento", Data.SqlDbType.Date).Value = vencimento
        comando.ExecuteNonQuery()
        'fechando a conexao com o banco
        conexao.Close()
        Return True

    End Function

    'EXCLUIR  - DELETE
    Public Function Excluir(ByVal cliente As Integer, ByVal vendas As Integer) As Boolean

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "DELETE FROM Contrec WHERE id = " & vendas & " and idcliente =" & cliente & " and ValorRec = 0"

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        comando.ExecuteNonQuery()

        'fechando 
        conexao.Close()

        Return True
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

#End Region
End Class
