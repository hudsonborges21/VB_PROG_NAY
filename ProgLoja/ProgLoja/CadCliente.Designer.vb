<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.BtnIncluir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtInscr = New System.Windows.Forms.TextBox()
        Me.txtCNPJ = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.txtConsulta = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnExtornar = New System.Windows.Forms.Button()
        Me.txtRecebido = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MTvencimento = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtData = New System.Windows.Forms.MaskedTextBox()
        Me.BtnBaixarTitulo = New System.Windows.Forms.Button()
        Me.TxtAcrescimo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtdesconto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txtvalor = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtVenda = New System.Windows.Forms.TextBox()
        Me.lvenda = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.VendaRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmissaoRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorIni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VencimentoRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Venda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emissão = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vencimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(1, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(870, 437)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnCancelar)
        Me.TabPage1.Controls.Add(Me.BtnConfirmar)
        Me.TabPage1.Controls.Add(Me.btnExcluir)
        Me.TabPage1.Controls.Add(Me.BtnIncluir)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(862, 408)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(580, 334)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 25)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.Location = New System.Drawing.Point(494, 334)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(80, 25)
        Me.BtnConfirmar.TabIndex = 17
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(242, 335)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(80, 25)
        Me.btnExcluir.TabIndex = 16
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'BtnIncluir
        '
        Me.BtnIncluir.Location = New System.Drawing.Point(156, 334)
        Me.BtnIncluir.Name = "BtnIncluir"
        Me.BtnIncluir.Size = New System.Drawing.Size(80, 25)
        Me.BtnIncluir.TabIndex = 15
        Me.BtnIncluir.Text = "Incluir"
        Me.BtnIncluir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTelefone)
        Me.GroupBox1.Controls.Add(Me.txtUF)
        Me.GroupBox1.Controls.Add(Me.txtCep)
        Me.GroupBox1.Controls.Add(Me.txtCidade)
        Me.GroupBox1.Controls.Add(Me.txtBairro)
        Me.GroupBox1.Controls.Add(Me.txtEndereco)
        Me.GroupBox1.Controls.Add(Me.txtInscr)
        Me.GroupBox1.Controls.Add(Me.txtCNPJ)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.txtCod)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(82, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(652, 320)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'txtTelefone
        '
        Me.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefone.Location = New System.Drawing.Point(33, 286)
        Me.txtTelefone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefone.MaxLength = 15
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(132, 22)
        Me.txtTelefone.TabIndex = 14
        '
        'txtUF
        '
        Me.txtUF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUF.Location = New System.Drawing.Point(545, 223)
        Me.txtUF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUF.MaxLength = 2
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(60, 22)
        Me.txtUF.TabIndex = 13
        '
        'txtCep
        '
        Me.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCep.Location = New System.Drawing.Point(384, 223)
        Me.txtCep.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCep.MaxLength = 8
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(141, 22)
        Me.txtCep.TabIndex = 12
        '
        'txtCidade
        '
        Me.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCidade.Location = New System.Drawing.Point(191, 223)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCidade.MaxLength = 50
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(172, 22)
        Me.txtCidade.TabIndex = 11
        '
        'txtBairro
        '
        Me.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBairro.Location = New System.Drawing.Point(33, 223)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBairro.MaxLength = 50
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(132, 22)
        Me.txtBairro.TabIndex = 10
        '
        'txtEndereco
        '
        Me.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEndereco.Location = New System.Drawing.Point(33, 164)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(572, 22)
        Me.txtEndereco.TabIndex = 9
        '
        'txtInscr
        '
        Me.txtInscr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInscr.Location = New System.Drawing.Point(332, 103)
        Me.txtInscr.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInscr.MaxLength = 20
        Me.txtInscr.Name = "txtInscr"
        Me.txtInscr.Size = New System.Drawing.Size(273, 22)
        Me.txtInscr.TabIndex = 8
        '
        'txtCNPJ
        '
        Me.txtCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCNPJ.Location = New System.Drawing.Point(33, 105)
        Me.txtCNPJ.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCNPJ.MaxLength = 18
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(276, 22)
        Me.txtCNPJ.TabIndex = 7
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.Location = New System.Drawing.Point(145, 43)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNome.MaxLength = 80
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(460, 22)
        Me.txtNome.TabIndex = 6
        '
        'txtCod
        '
        Me.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCod.Enabled = False
        Me.txtCod.Location = New System.Drawing.Point(33, 43)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCod.MaxLength = 6
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(81, 22)
        Me.txtCod.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 266)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Telefone / Celular"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(541, 203)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "UF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 203)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "CEP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(187, 203)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cidade"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 203)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Bairro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 144)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Endereço"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(328, 84)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "RG / Inscr.Estd"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CPF / CNPJ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(862, 408)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consulta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 65)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(856, 340)
        Me.DataGridView1.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnConsulta)
        Me.GroupBox2.Controls.Add(Me.txtConsulta)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(519, 59)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pesquisar"
        '
        'BtnConsulta
        '
        Me.BtnConsulta.Location = New System.Drawing.Point(353, 19)
        Me.BtnConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(100, 28)
        Me.BtnConsulta.TabIndex = 1
        Me.BtnConsulta.Text = "Pesquisar"
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'txtConsulta
        '
        Me.txtConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsulta.Location = New System.Drawing.Point(17, 23)
        Me.txtConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(319, 22)
        Me.txtConsulta.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnExtornar)
        Me.TabPage3.Controls.Add(Me.txtRecebido)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.MTvencimento)
        Me.TabPage3.Controls.Add(Me.MtxtData)
        Me.TabPage3.Controls.Add(Me.BtnBaixarTitulo)
        Me.TabPage3.Controls.Add(Me.TxtAcrescimo)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.txtdesconto)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Txtvalor)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.TxtVenda)
        Me.TabPage3.Controls.Add(Me.lvenda)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(862, 408)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Contas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnExtornar
        '
        Me.btnExtornar.Location = New System.Drawing.Point(598, 369)
        Me.btnExtornar.Name = "btnExtornar"
        Me.btnExtornar.Size = New System.Drawing.Size(119, 31)
        Me.btnExtornar.TabIndex = 21
        Me.btnExtornar.Text = "Cancelar Baixa"
        Me.btnExtornar.UseVisualStyleBackColor = True
        '
        'txtRecebido
        '
        Me.txtRecebido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecebido.Location = New System.Drawing.Point(264, 343)
        Me.txtRecebido.Name = "txtRecebido"
        Me.txtRecebido.Size = New System.Drawing.Size(71, 22)
        Me.txtRecebido.TabIndex = 20
        Me.txtRecebido.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(261, 323)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 17)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Valor Rec."
        '
        'MTvencimento
        '
        Me.MTvencimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MTvencimento.Enabled = False
        Me.MTvencimento.Location = New System.Drawing.Point(174, 298)
        Me.MTvencimento.Mask = "00/00/0000"
        Me.MTvencimento.Name = "MTvencimento"
        Me.MTvencimento.Size = New System.Drawing.Size(84, 22)
        Me.MTvencimento.TabIndex = 18
        Me.MTvencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MTvencimento.ValidatingType = GetType(Date)
        '
        'MtxtData
        '
        Me.MtxtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MtxtData.Enabled = False
        Me.MtxtData.Location = New System.Drawing.Point(84, 298)
        Me.MtxtData.Mask = "00/00/0000"
        Me.MtxtData.Name = "MtxtData"
        Me.MtxtData.Size = New System.Drawing.Size(84, 22)
        Me.MtxtData.TabIndex = 17
        Me.MtxtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MtxtData.ValidatingType = GetType(Date)
        '
        'BtnBaixarTitulo
        '
        Me.BtnBaixarTitulo.Location = New System.Drawing.Point(87, 371)
        Me.BtnBaixarTitulo.Name = "BtnBaixarTitulo"
        Me.BtnBaixarTitulo.Size = New System.Drawing.Size(119, 31)
        Me.BtnBaixarTitulo.TabIndex = 16
        Me.BtnBaixarTitulo.Text = "Baixar"
        Me.BtnBaixarTitulo.UseVisualStyleBackColor = True
        '
        'TxtAcrescimo
        '
        Me.TxtAcrescimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAcrescimo.Location = New System.Drawing.Point(174, 343)
        Me.TxtAcrescimo.Name = "TxtAcrescimo"
        Me.TxtAcrescimo.Size = New System.Drawing.Size(80, 22)
        Me.TxtAcrescimo.TabIndex = 15
        Me.TxtAcrescimo.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(172, 323)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 17)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Acrescimo"
        '
        'txtdesconto
        '
        Me.txtdesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdesconto.Location = New System.Drawing.Point(87, 343)
        Me.txtdesconto.Name = "txtdesconto"
        Me.txtdesconto.Size = New System.Drawing.Size(81, 22)
        Me.txtdesconto.TabIndex = 13
        Me.txtdesconto.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(84, 323)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 17)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Desconto"
        '
        'Txtvalor
        '
        Me.Txtvalor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtvalor.Enabled = False
        Me.Txtvalor.Location = New System.Drawing.Point(7, 343)
        Me.Txtvalor.Name = "Txtvalor"
        Me.Txtvalor.Size = New System.Drawing.Size(71, 22)
        Me.Txtvalor.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 323)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 17)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Valor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(172, 278)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 17)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Vencimento"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(81, 278)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 17)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Emissão"
        '
        'TxtVenda
        '
        Me.TxtVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVenda.Enabled = False
        Me.TxtVenda.Location = New System.Drawing.Point(10, 298)
        Me.TxtVenda.Name = "TxtVenda"
        Me.TxtVenda.Size = New System.Drawing.Size(68, 22)
        Me.TxtVenda.TabIndex = 5
        '
        'lvenda
        '
        Me.lvenda.AutoSize = True
        Me.lvenda.Location = New System.Drawing.Point(7, 278)
        Me.lvenda.Name = "lvenda"
        Me.lvenda.Size = New System.Drawing.Size(49, 17)
        Me.lvenda.TabIndex = 4
        Me.lvenda.Text = "Venda"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(354, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Recebidas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "A Receber"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VendaRec, Me.EmissaoRec, Me.ValorIni, Me.VencimentoRec, Me.DataRec, Me.ValorRec})
        Me.DataGridView3.Location = New System.Drawing.Point(357, 20)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(489, 255)
        Me.DataGridView3.TabIndex = 1
        '
        'VendaRec
        '
        Me.VendaRec.DataPropertyName = "id"
        Me.VendaRec.HeaderText = "Venda"
        Me.VendaRec.Name = "VendaRec"
        Me.VendaRec.Width = 70
        '
        'EmissaoRec
        '
        Me.EmissaoRec.DataPropertyName = "emissao"
        Me.EmissaoRec.HeaderText = "Emissão"
        Me.EmissaoRec.Name = "EmissaoRec"
        Me.EmissaoRec.Width = 70
        '
        'ValorIni
        '
        Me.ValorIni.DataPropertyName = "Valor"
        Me.ValorIni.HeaderText = "Valor"
        Me.ValorIni.Name = "ValorIni"
        Me.ValorIni.Width = 70
        '
        'VencimentoRec
        '
        Me.VencimentoRec.DataPropertyName = "vencimento"
        Me.VencimentoRec.HeaderText = "VencimentoRec"
        Me.VencimentoRec.Name = "VencimentoRec"
        Me.VencimentoRec.Width = 70
        '
        'DataRec
        '
        Me.DataRec.DataPropertyName = "DATAREC"
        Me.DataRec.HeaderText = "DataRec"
        Me.DataRec.Name = "DataRec"
        Me.DataRec.Width = 70
        '
        'ValorRec
        '
        Me.ValorRec.DataPropertyName = "valorRec"
        Me.ValorRec.HeaderText = "ValorRec"
        Me.ValorRec.Name = "ValorRec"
        Me.ValorRec.Width = 70
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Venda, Me.Emissão, Me.Vencimento, Me.Valor})
        Me.DataGridView2.Location = New System.Drawing.Point(0, 20)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(335, 255)
        Me.DataGridView2.TabIndex = 0
        '
        'Venda
        '
        Me.Venda.DataPropertyName = "id"
        Me.Venda.HeaderText = "Venda"
        Me.Venda.Name = "Venda"
        Me.Venda.ReadOnly = True
        Me.Venda.Width = 70
        '
        'Emissão
        '
        Me.Emissão.DataPropertyName = "emissao"
        Me.Emissão.HeaderText = "Emissão"
        Me.Emissão.Name = "Emissão"
        Me.Emissão.ReadOnly = True
        Me.Emissão.Width = 70
        '
        'Vencimento
        '
        Me.Vencimento.DataPropertyName = "Vencimento"
        Me.Vencimento.HeaderText = "Vecimento"
        Me.Vencimento.Name = "Vencimento"
        Me.Vencimento.ReadOnly = True
        Me.Vencimento.Width = 75
        '
        'Valor
        '
        Me.Valor.DataPropertyName = "Valor"
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        Me.Valor.Width = 70
        '
        'CadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 449)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CadCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents txtUF As System.Windows.Forms.TextBox
    Friend WithEvents txtCep As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtInscr As System.Windows.Forms.TextBox
    Friend WithEvents txtCNPJ As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents BtnIncluir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
    Friend WithEvents txtConsulta As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Venda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Emissão As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vencimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnBaixarTitulo As System.Windows.Forms.Button
    Friend WithEvents TxtAcrescimo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtdesconto As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtVenda As System.Windows.Forms.TextBox
    Friend WithEvents lvenda As System.Windows.Forms.Label
    Friend WithEvents MTvencimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtRecebido As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents VendaRec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmissaoRec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorIni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VencimentoRec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataRec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorRec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExtornar As System.Windows.Forms.Button
End Class
