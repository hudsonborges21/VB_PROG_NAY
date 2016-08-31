Imports System.Data.SqlClient

Public Class Usuario


#Region "Atributos"



    'declarando os atributos da classe produto
    Private acodigo As Integer
    Private anome As String
    Private asenha As Integer
    Private aperfil As String
    Private acpf As String
    Private aemail As String

    Dim CON As New Conexao

    'criando a string de conexao com o banco de dados
    Private vStrConexao As String

#End Region

    '
#Region "Propriedades"


    'criando propriedade para encapsular os atributos do classe
    Public Property Codigo() As Integer
        Get
            Return acodigo
        End Get
        Set(ByVal value As Integer)
            acodigo = value
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return anome
        End Get
        Set(ByVal value As String)
            anome = value
        End Set
    End Property

    Public Property Senha() As Integer
        Get
            Return asenha
        End Get
        Set(ByVal value As Integer)
            asenha = value
        End Set
    End Property


    Public Property Perfil() As String
        Get
            Return aperfil
        End Get
        Set(ByVal value As String)
            aperfil = value
        End Set
    End Property

    Public Property CPF() As String
        Get
            Return acpf
        End Get
        Set(ByVal value As String)
            acpf = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return aemail
        End Get
        Set(ByVal value As String)
            aemail = value
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
        Sql = "Insert Into USUARIO(id, nome, senha, idPerfil, cpf,email) values (@id, @nome, @senha, @idPerfil, @cpf,@email)"

        Dim comando As SqlCommand
        comando = New SqlCommand(Sql, Conexao)

        'parametro recebe  valores 
        comando.Parameters.Add("@id", Data.SqlDbType.VarChar).Value = Codigo
        comando.Parameters.Add("@nome", Data.SqlDbType.VarChar).Value = Nome
        comando.Parameters.Add("@senha", Data.SqlDbType.VarChar).Value = Senha
        comando.Parameters.Add("@idPerfil", Data.SqlDbType.VarChar).Value = Perfil
        comando.Parameters.Add("@CPf", Data.SqlDbType.VarChar).Value = CPF
        comando.Parameters.Add("@Email", Data.SqlDbType.VarChar).Value = Email
        'comando sql
        comando.ExecuteNonQuery()

        'fechando a conexao 
        Conexao.Close()

    End Sub

    'criando uma funcao para buscar um codigo cadastrado
    'passando um codigo como parametro e retornando true se o codigo existe
    Public Function Consultar(ByVal codigo As Integer, ByVal senha As Integer) As Boolean

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "SELECT * FROM Usuario WHERE id = " & codigo & " and Senha = " & senha

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        'o dataReadar vai trazar registro da tabela
        'tipo uma linha da tabela com todos os campos.. mas obdecendo a condicao do comando sql
        Dim dataReader As SqlDataReader
        dataReader = comando.ExecuteReader

        'se o dataReader buscar uma linha .. o codigo procura do existe no banco
        If dataReader.HasRows Then

            'antes de dar a reposta se existe ou nao a linha na tabela
            'caso exista pega os valores delejados
            'DEPOIS DA O RETORNO  CASO EXISTA
            'enviado a resposta da funcao caso o codigo exista
            dataReader.Read()
            acodigo = dataReader("id")
            anome = dataReader("Nome")
            aperfil = dataReader("idPerfil")
            CPF = dataReader("CPF")
            Email = dataReader("email")
            Return True


        Else
            Return False
        End If

        'fechando o conexao com o banco
        conexao.Close()

    End Function


    'Funcao para excluir um produto cadastrado
    Public Function Excluir(ByVal parmCodigo As Integer) As Boolean

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "DELETE FROM usuario WHERE id = " & parmCodigo


        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        'execuntao o comando sql
        comando.ExecuteNonQuery()

        'fechando a conexao com o banco
        conexao.Close()

        Return True
    End Function




    'METODO INCLUIR 
    Public Sub Alterar(ByVal CodigoParam As Integer)


        Dim Conexao As SqlConnection

        Conexao = New SqlConnection(vStrConexao)

        'abrindo conexao 
        Conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = " UPDATE Usuario  SET id=@id, nome=nome, senha=@senha, idPerfil=@idPerfil,cpf=@cpf  WHERE id= " & CodigoParam

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, Conexao)

        'parametro recebe  valores 
        comando.Parameters.Add("@id", Data.SqlDbType.VarChar).Value = Codigo
        comando.Parameters.Add("@nome", Data.SqlDbType.VarChar).Value = Nome
        comando.Parameters.Add("@senha", Data.SqlDbType.VarChar).Value = Senha
        comando.Parameters.Add("@idPerfil", Data.SqlDbType.VarChar).Value = Perfil
        comando.Parameters.Add("@CPf", Data.SqlDbType.VarChar).Value = CPF
        'comando sql
        comando.ExecuteNonQuery()

        'fechando a conexao 
        Conexao.Close()

    End Sub


    'criando uma funcao para buscar um codigo cadastrado
    'passando um codigo como parametro e retornando true se o codigo existe
    Public Function Consultar(ByVal codigo As Integer) As Boolean

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "SELECT * " & _
              "FROM Usuario WHERE id = " & codigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        'o dataReadar vai trazar registro da tabela
        'tipo uma linha da tabela com todos os campos.. mas obdecendo a condicao do comando sql
        Dim dataReader As SqlDataReader
        dataReader = comando.ExecuteReader

        'se o dataReader buscar uma linha .. o codigo procura do existe no banco
        If dataReader.HasRows Then

            dataReader.Read()

            acodigo = dataReader("id")
            anome = dataReader("Nome")
            aperfil = dataReader("idPerfil")
            CPF = dataReader("CPF")
            Email = dataReader("email")

            Return True


        Else
            Return False
        End If

        'fechando o conexao com o banco
        conexao.Close()

    End Function
    Public Function UltimoCodigo() As Integer
        Dim cod As Integer
        cod = 0
        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "SELECT id FROM Usuario where id = (SELECT top 1 id FROM usuario order by id desc)"

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        'o dataReadar vai trazar registro da tabela
        'tipo uma linha da tabela com todos os campos.. mas obdecendo a condicao do comando sql
        Dim dataReader As SqlDataReader
        dataReader = comando.ExecuteReader

        'se o dataReader buscar uma linha .. o codigo procura do existe no banco
        If dataReader.HasRows Then
            dataReader.Read()
            cod = dataReader("id")
            Return cod + 1
        Else
            Return cod
        End If

        'fechando o conexao com o banco
        conexao.Close()

    End Function

#End Region
End Class
