Imports System.Data.SqlClient

Public Class Empresa


#Region "Atributos"

    'declarando os atributos da classe produto
    Private vCodigo As Integer
    Private vNome As String
    Private vEndereco As String
    Private vCidade As String
    Private vBairro As String
    Private vNumero As String
    Private vUF As String
    Private vTelefone As String
    Private vCEP As String
    Private vCNPJ As String
    Private vInscr As String

    'criando a string de conexao com o banco de dados
    Private vStrConexao As String
    'objeto da classe conexao
    Dim CON As New Conexao

#End Region


#Region "Propriedades"


    'criando propriedade para encapsular os atributos do classe
    Public Property Codigo() As Integer
        Get
            Return vCodigo
        End Get
        Set(ByVal value As Integer)
            vCodigo = value
        End Set
    End Property


    Public Property Nome() As String
        Get
            Return vNome
        End Get
        Set(ByVal value As String)
            vNome = value
        End Set
    End Property

    Public Property Endereco() As String
        Get
            Return vEndereco
        End Get
        Set(ByVal value As String)
            vEndereco = value
        End Set
    End Property

    Public Property Numero() As String
        Get
            Return vNumero
        End Get
        Set(ByVal value As String)
            vNumero = value
        End Set
    End Property


    Public Property Cidade() As String
        Get
            Return vCidade
        End Get
        Set(ByVal value As String)
            vCidade = value
        End Set
    End Property

    Public Property Bairro() As String
        Get
            Return vBairro
        End Get
        Set(ByVal value As String)
            vBairro = value
        End Set
    End Property

    Public Property UF() As String
        Get
            Return vUF
        End Get
        Set(ByVal value As String)
            vUF = value
        End Set
    End Property

    Public Property Telefone() As String
        Get
            Return vTelefone
        End Get
        Set(ByVal value As String)
            vTelefone = value
        End Set
    End Property

    Public Property CEP() As String
        Get
            Return vCEP
        End Get
        Set(ByVal value As String)
            vCEP = value
        End Set
    End Property

    Public Property CNPJ() As String
        Get
            Return vCNPJ
        End Get
        Set(ByVal value As String)
            vCNPJ = value
        End Set
    End Property

    Public Property Inscricao() As String
        Get
            Return vInscr
        End Get
        Set(ByVal value As String)
            vInscr = value
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
        Sql = "Insert Into Empresa" & _
            " (nome, endereco, cidade, bairro, UF, telefone, CEP, CNPJ, inscrEstadual) " & _
            "values (@codigoEmpresa, @nome, @endereco, @cidade, @bairro, @UF, @telefone, @CEP, @CNPJ, @inscrEstadual)"

        Dim comando As SqlCommand
        comando = New SqlCommand(Sql, Conexao)

        'parametro recebe  valores 

        comando.Parameters.Add("@nome", Data.SqlDbType.VarChar).Value = Nome
        comando.Parameters.Add("@endereco", Data.SqlDbType.VarChar).Value = Endereco
        comando.Parameters.Add("@cidade", Data.SqlDbType.VarChar).Value = Cidade
        comando.Parameters.Add("@bairro", Data.SqlDbType.VarChar).Value = Bairro
        comando.Parameters.Add("@UF", Data.SqlDbType.VarChar).Value = UF
        comando.Parameters.Add("@telefone", Data.SqlDbType.VarChar).Value = Telefone
        comando.Parameters.Add("@CEP", Data.SqlDbType.VarChar).Value = CEP
        comando.Parameters.Add("@CNPJ", Data.SqlDbType.VarChar).Value = CNPJ
        comando.Parameters.Add("@inscrEstadual", Data.SqlDbType.VarChar).Value = Inscricao

        'comando sql
        comando.ExecuteNonQuery()

        'fechando a conexao 
        Conexao.Close()

    End Sub

    'CONSULTAR 
    Public Function Consultar() As Boolean

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "SELECT * FROM Empresa "


        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        Dim dataReader As SqlDataReader
        dataReader = comando.ExecuteReader

        'dataReader buscar uma linha 
        If dataReader.HasRows Then

            dataReader.Read()
            vCodigo = dataReader("id")
            vNome = dataReader("nome")
            vEndereco = dataReader("endereco")
            vCidade = dataReader("cidade")
            vBairro = dataReader("bairro")
            vUF = dataReader("UF")
            vTelefone = dataReader("telefone")
            vCEP = dataReader("CEP")
            vCNPJ = dataReader("CNPJ")
            vInscr = dataReader("inscrEstadual")

            Return True


        Else
            Return False
        End If

        'fechando o conexao 
        conexao.Close()

    End Function


    'ALTERAR  - UPDATE
    Public Function Alterar(ByVal parmCodigo As Integer) 'As Boolean


        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao 
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = " UPDATE Empresa SET nome = '" & vNome & "', endereco = '" & vEndereco & _
                "', cidade = '" & vCidade & "', bairro = '" & vBairro & _
                "', UF = '" & vUF & "', telefone = '" & vTelefone & "', CEP = '" & vCEP & _
                "', inscrEstadual = '" & vInscr & "', CNPJ = '" & vCNPJ & _
                "' WHERE id = " & parmCodigo

        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        'comando.Parameters.Add("@id", Data.SqlDbType.Int).Value = Codigo
        comando.Parameters.Add("@nome", Data.SqlDbType.VarChar).Value = Nome
        comando.Parameters.Add("@endereco", Data.SqlDbType.VarChar).Value = Endereco
        comando.Parameters.Add("@cidade", Data.SqlDbType.VarChar).Value = Cidade
        comando.Parameters.Add("@bairro", Data.SqlDbType.VarChar).Value = Bairro
        comando.Parameters.Add("@UF", Data.SqlDbType.VarChar).Value = UF
        comando.Parameters.Add("@telefone", Data.SqlDbType.VarChar).Value = Telefone
        comando.Parameters.Add("@CEP", Data.SqlDbType.VarChar).Value = CEP
        comando.Parameters.Add("@CNPJ", Data.SqlDbType.VarChar).Value = CNPJ
        comando.Parameters.Add("@inscrEstadual", Data.SqlDbType.VarChar).Value = Inscricao

        comando.ExecuteNonQuery()

        'fechando a conexao com o banco
        conexao.Close()
        Return False
    End Function


    'EXCLUIR  - DELETE
    Public Function Excluir(ByVal parmCodigo As Integer) As Boolean

        'criando a conexao com o banco de dados
        Dim conexao As SqlConnection
        conexao = New SqlConnection(vStrConexao)

        'abrindo a conexao com o banco
        conexao.Open()

        'criando o comando sql
        Dim sql As String
        sql = "DELETE FROM EMPRESA WHERE id = " & parmCodigo


        Dim comando As SqlCommand
        comando = New SqlCommand(sql, conexao)

        comando.ExecuteNonQuery()

        'fechando 
        conexao.Close()

        Return True
    End Function

#End Region

End Class
