Public Class CadEmpresa
    Dim tipo As Int16
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'HABILITANDO OS CAMPOS PARA INSERIR OS DADOS
        txtCod.Enabled = True
        txtNome.Enabled = True
        txtCNPJ.Enabled = True
        txtInscr.Enabled = True
        txtEndereco.Enabled = True
        txtBairro.Enabled = True
        txtCidade.Enabled = True
        txtCep.Enabled = True
        txtUF.Enabled = True
        txtTelefone.Enabled = True

        'habilitando botao salvar
        btnSalvar.Enabled = True
        btnEditar.Enabled = False
        tipo = -1
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        'Declarando e instanciando o obj da classe empresa
        Dim objempresa As Empresa = New Empresa


        objempresa.Codigo = Convert.ToInt16(txtCod.Text)
        objempresa.Nome = txtNome.Text
        objempresa.CNPJ = txtCNPJ.Text
        objempresa.Inscricao = txtInscr.Text
        objempresa.Endereco = txtEndereco.Text
        objempresa.Bairro = txtBairro.Text
        objempresa.Cidade = txtCidade.Text
        objempresa.UF = txtUF.Text
        objempresa.CEP = txtCep.Text
        objempresa.Telefone = txtTelefone.Text

        If tipo = -1 Then
            'chamando o metodo da classe responsavel por incluir os dados 
            objempresa.Alterar(txtCod.Text)
            MsgBox("Registro salvo com sucesso.", MsgBoxStyle.Information, "")


            'HABILITANDO OS CAMPOS PARA INSERIR OS DADOS
            txtCod.Enabled = False
            txtNome.Enabled = False
            txtCNPJ.Enabled = False
            txtInscr.Enabled = False
            txtEndereco.Enabled = False
            txtBairro.Enabled = False
            txtCidade.Enabled = False
            txtCep.Enabled = False
            txtUF.Enabled = False
            txtTelefone.Enabled = False

            'habilitando botao salvar
            btnSalvar.Enabled = False
            btnEditar.Enabled = True
            tipo = 0
            Me.btnSalvar.Focus()
        Else

            'chamando o metodo da classe responsavel por incluir os dados 
            objempresa.Incluir()
            MsgBox("Registro salvo com sucesso.", MsgBoxStyle.Information, "")
            Me.btnEditar.Focus()
        End If
    End Sub

    Private Sub Empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'BUSCANDO DADOS DA EMPRESA AO ABRIR O FORMULARIO
        Dim objempresa As Empresa = New Empresa

        Try
            'metodo consultar ira buscar os dados no banco
            'se existir algum cadastro irá preencher os campos do formulario
            If objempresa.Consultar() = True Then

                'CAMPOS DO FORMULAIO
                txtCod.Text = objempresa.Codigo
                txtNome.Text = objempresa.Nome
                txtCNPJ.Text = objempresa.CNPJ
                txtInscr.Text = objempresa.Inscricao
                txtEndereco.Text = objempresa.Endereco
                txtBairro.Text = objempresa.Bairro
                txtCidade.Text = objempresa.Cidade
                txtUF.Text = objempresa.UF
                txtCep.Text = objempresa.CEP
                txtTelefone.Text = objempresa.Telefone
                'deixa o botao habilitado caso necessite alterar alguma informação
                btnEditar.Enabled = True
            End If

        Catch
            MsgBox("Erro ao Carregar dados da empresa..", MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub
End Class