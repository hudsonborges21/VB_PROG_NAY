﻿Public Class Conexao
    'criando a string de conexao com o banco de dados
    Public vStrConexao As String


    'criando o construtor
    Public Sub New()

        'vStrConexao = "Data Source=DESENV-HUDSON\SQLEXPRESS;Initial Catalog=Loja;Integrated Security=True"
        vStrConexao = "Data Source=C:\Users\Zod\Desktop\nayara\ProgLoja\ProgLoja\BancoDeDados.sdf;Max Database Size=500;Integrated Security=false"

    End Sub


    Public Property StrConexao() As String
        Get
            Return vStrConexao
        End Get
        Set(ByVal value As String)
            vStrConexao = value
        End Set
    End Property
End Class
