'<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
'Partial Class CadFornecedor
'    Inherits System.Windows.Forms.Form

'    'Form overrides dispose to clean up the component list.
'    <System.Diagnostics.DebuggerNonUserCode()> _
'    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
'        Try
'            If disposing AndAlso components IsNot Nothing Then
'                components.Dispose()
'            End If
'        Finally
'            MyBase.Dispose(disposing)
'        End Try
'    End Sub

'    'Required by the Windows Form Designer
'    Private components As System.ComponentModel.IContainer

'    'NOTE: The following procedure is required by the Windows Form Designer
'    'It can be modified using the Windows Form Designer.  
'    'Do not modify it using the code editor.
'    <System.Diagnostics.DebuggerStepThrough()> _
'    Private Sub InitializeComponent()
'        Me.components = New System.ComponentModel.Container()
'        Dim IdLabel As System.Windows.Forms.Label
'        Dim NomeLabel As System.Windows.Forms.Label
'        Dim CNPJLabel As System.Windows.Forms.Label
'        Dim IELabel As System.Windows.Forms.Label
'        Dim EnderecoLabel As System.Windows.Forms.Label
'        Dim NumeroLabel As System.Windows.Forms.Label
'        Dim BairroLabel As System.Windows.Forms.Label
'        Dim CidadeLabel As System.Windows.Forms.Label
'        Dim UFLabel As System.Windows.Forms.Label
'        Dim CEPLabel As System.Windows.Forms.Label
'        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadFornecedor))
'        Me.TabPrin = New System.Windows.Forms.TabControl()
'        Me.TabPage1 = New System.Windows.Forms.TabPage()
'        Me.TabPage2 = New System.Windows.Forms.TabPage()
'        Me.LojaDataSetForn = New ProgLoja.LojaDataSetForn()
'        Me.FornecedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.FornecedorTableAdapter = New ProgLoja.LojaDataSetFornTableAdapters.FornecedorTableAdapter()
'        Me.TableAdapterManager = New ProgLoja.LojaDataSetFornTableAdapters.TableAdapterManager()
'        Me.FornecedorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
'        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
'        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
'        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
'        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
'        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
'        Me.FornecedorDataGridView = New System.Windows.Forms.DataGridView()
'        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
'        Me.IdTextBox = New System.Windows.Forms.TextBox()
'        Me.NomeTextBox = New System.Windows.Forms.TextBox()
'        Me.CNPJTextBox = New System.Windows.Forms.TextBox()
'        Me.IETextBox = New System.Windows.Forms.TextBox()
'        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
'        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
'        Me.BairroTextBox = New System.Windows.Forms.TextBox()
'        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
'        Me.UFTextBox = New System.Windows.Forms.TextBox()
'        Me.CEPTextBox = New System.Windows.Forms.TextBox()
'        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
'        Me.BtnConsulta = New System.Windows.Forms.Button()
'        Me.txtConsulta = New System.Windows.Forms.TextBox()
'        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
'        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
'        Me.FornecedorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
'        IdLabel = New System.Windows.Forms.Label()
'        NomeLabel = New System.Windows.Forms.Label()
'        CNPJLabel = New System.Windows.Forms.Label()
'        IELabel = New System.Windows.Forms.Label()
'        EnderecoLabel = New System.Windows.Forms.Label()
'        NumeroLabel = New System.Windows.Forms.Label()
'        BairroLabel = New System.Windows.Forms.Label()
'        CidadeLabel = New System.Windows.Forms.Label()
'        UFLabel = New System.Windows.Forms.Label()
'        CEPLabel = New System.Windows.Forms.Label()
'        Me.TabPrin.SuspendLayout()
'        Me.TabPage1.SuspendLayout()
'        Me.TabPage2.SuspendLayout()
'        CType(Me.LojaDataSetForn, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.FornecedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.FornecedorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.FornecedorBindingNavigator.SuspendLayout()
'        CType(Me.FornecedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.GroupBox1.SuspendLayout()
'        Me.GroupBox2.SuspendLayout()
'        Me.SuspendLayout()
'        '
'        'TabPrin
'        '
'        Me.TabPrin.Controls.Add(Me.TabPage1)
'        Me.TabPrin.Controls.Add(Me.TabPage2)
'        Me.TabPrin.Location = New System.Drawing.Point(1, 2)
'        Me.TabPrin.Name = "TabPrin"
'        Me.TabPrin.SelectedIndex = 0
'        Me.TabPrin.Size = New System.Drawing.Size(640, 438)
'        Me.TabPrin.TabIndex = 0
'        '
'        'TabPage1
'        '
'        Me.TabPage1.AutoScroll = True
'        Me.TabPage1.Controls.Add(Me.FornecedorBindingNavigator)
'        Me.TabPage1.Controls.Add(Me.GroupBox1)
'        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
'        Me.TabPage1.Name = "TabPage1"
'        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
'        Me.TabPage1.Size = New System.Drawing.Size(632, 409)
'        Me.TabPage1.TabIndex = 0
'        Me.TabPage1.Text = "Cadastro"
'        Me.TabPage1.UseVisualStyleBackColor = True
'        '
'        'TabPage2
'        '
'        Me.TabPage2.AutoScroll = True
'        Me.TabPage2.Controls.Add(Me.GroupBox2)
'        Me.TabPage2.Controls.Add(Me.FornecedorDataGridView)
'        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
'        Me.TabPage2.Name = "TabPage2"
'        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
'        Me.TabPage2.Size = New System.Drawing.Size(632, 409)
'        Me.TabPage2.TabIndex = 1
'        Me.TabPage2.Text = "Consulta"
'        Me.TabPage2.UseVisualStyleBackColor = True
'        '
'        'LojaDataSetForn
'        '
'        Me.LojaDataSetForn.DataSetName = "LojaDataSetForn"
'        Me.LojaDataSetForn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'        '
'        'FornecedorBindingSource
'        '
'        Me.FornecedorBindingSource.DataMember = "Fornecedor"
'        Me.FornecedorBindingSource.DataSource = Me.LojaDataSetForn
'        '
'        'FornecedorTableAdapter
'        '
'        Me.FornecedorTableAdapter.ClearBeforeFill = True
'        '
'        'TableAdapterManager
'        '
'        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
'        Me.TableAdapterManager.FornecedorTableAdapter = Me.FornecedorTableAdapter
'        Me.TableAdapterManager.UpdateOrder = ProgLoja.LojaDataSetFornTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
'        '
'        'FornecedorBindingNavigator
'        '
'        Me.FornecedorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
'        Me.FornecedorBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.None
'        Me.FornecedorBindingNavigator.BindingSource = Me.FornecedorBindingSource
'        Me.FornecedorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
'        Me.FornecedorBindingNavigator.CountItemFormat = "de {0}"
'        Me.FornecedorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
'        Me.FornecedorBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
'        Me.FornecedorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FornecedorBindingNavigatorSaveItem})
'        Me.FornecedorBindingNavigator.Location = New System.Drawing.Point(168, 293)
'        Me.FornecedorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
'        Me.FornecedorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
'        Me.FornecedorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
'        Me.FornecedorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
'        Me.FornecedorBindingNavigator.Name = "FornecedorBindingNavigator"
'        Me.FornecedorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
'        Me.FornecedorBindingNavigator.Size = New System.Drawing.Size(291, 27)
'        Me.FornecedorBindingNavigator.TabIndex = 1
'        Me.FornecedorBindingNavigator.Text = "BindingNavigator1"
'        '
'        'BindingNavigatorSeparator
'        '
'        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
'        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
'        '
'        'BindingNavigatorPositionItem
'        '
'        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
'        Me.BindingNavigatorPositionItem.AutoSize = False
'        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
'        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
'        Me.BindingNavigatorPositionItem.Text = "0"
'        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
'        '
'        'BindingNavigatorCountItem
'        '
'        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
'        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
'        Me.BindingNavigatorCountItem.Text = "de {0}"
'        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
'        '
'        'BindingNavigatorSeparator1
'        '
'        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
'        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
'        '
'        'BindingNavigatorSeparator2
'        '
'        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
'        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
'        '
'        'FornecedorDataGridView
'        '
'        Me.FornecedorDataGridView.AutoGenerateColumns = False
'        Me.FornecedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
'        Me.FornecedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn3})
'        Me.FornecedorDataGridView.DataSource = Me.FornecedorBindingSource
'        Me.FornecedorDataGridView.Location = New System.Drawing.Point(6, 92)
'        Me.FornecedorDataGridView.MultiSelect = False
'        Me.FornecedorDataGridView.Name = "FornecedorDataGridView"
'        Me.FornecedorDataGridView.ReadOnly = True
'        Me.FornecedorDataGridView.RowTemplate.Height = 24
'        Me.FornecedorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
'        Me.FornecedorDataGridView.Size = New System.Drawing.Size(620, 311)
'        Me.FornecedorDataGridView.TabIndex = 0
'        '
'        'GroupBox1
'        '
'        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
'        Me.GroupBox1.Controls.Add(CEPLabel)
'        Me.GroupBox1.Controls.Add(Me.CEPTextBox)
'        Me.GroupBox1.Controls.Add(UFLabel)
'        Me.GroupBox1.Controls.Add(Me.UFTextBox)
'        Me.GroupBox1.Controls.Add(CidadeLabel)
'        Me.GroupBox1.Controls.Add(Me.CidadeTextBox)
'        Me.GroupBox1.Controls.Add(BairroLabel)
'        Me.GroupBox1.Controls.Add(Me.BairroTextBox)
'        Me.GroupBox1.Controls.Add(NumeroLabel)
'        Me.GroupBox1.Controls.Add(Me.NumeroTextBox)
'        Me.GroupBox1.Controls.Add(EnderecoLabel)
'        Me.GroupBox1.Controls.Add(Me.EnderecoTextBox)
'        Me.GroupBox1.Controls.Add(IELabel)
'        Me.GroupBox1.Controls.Add(Me.IETextBox)
'        Me.GroupBox1.Controls.Add(CNPJLabel)
'        Me.GroupBox1.Controls.Add(Me.CNPJTextBox)
'        Me.GroupBox1.Controls.Add(NomeLabel)
'        Me.GroupBox1.Controls.Add(Me.NomeTextBox)
'        Me.GroupBox1.Controls.Add(IdLabel)
'        Me.GroupBox1.Controls.Add(Me.IdTextBox)
'        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
'        Me.GroupBox1.Name = "GroupBox1"
'        Me.GroupBox1.Size = New System.Drawing.Size(608, 262)
'        Me.GroupBox1.TabIndex = 0
'        Me.GroupBox1.TabStop = False
'        Me.GroupBox1.Text = "FORNECEDOR"
'        '
'        'IdLabel
'        '
'        IdLabel.AutoSize = True
'        IdLabel.Location = New System.Drawing.Point(30, 21)
'        IdLabel.Name = "IdLabel"
'        IdLabel.Size = New System.Drawing.Size(56, 17)
'        IdLabel.TabIndex = 0
'        IdLabel.Text = "Codigo:"
'        '
'        'IdTextBox
'        '
'        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "id", True))
'        Me.IdTextBox.Enabled = False
'        Me.IdTextBox.Location = New System.Drawing.Point(92, 21)
'        Me.IdTextBox.Name = "IdTextBox"
'        Me.IdTextBox.Size = New System.Drawing.Size(70, 22)
'        Me.IdTextBox.TabIndex = 1
'        '
'        'NomeLabel
'        '
'        NomeLabel.AutoSize = True
'        NomeLabel.Location = New System.Drawing.Point(184, 26)
'        NomeLabel.Name = "NomeLabel"
'        NomeLabel.Size = New System.Drawing.Size(49, 17)
'        NomeLabel.TabIndex = 2
'        NomeLabel.Text = "Nome:"
'        '
'        'NomeTextBox
'        '
'        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Nome", True))
'        Me.NomeTextBox.Location = New System.Drawing.Point(239, 21)
'        Me.NomeTextBox.Name = "NomeTextBox"
'        Me.NomeTextBox.Size = New System.Drawing.Size(338, 22)
'        Me.NomeTextBox.TabIndex = 3
'        '
'        'CNPJLabel
'        '
'        CNPJLabel.AutoSize = True
'        CNPJLabel.Location = New System.Drawing.Point(37, 59)
'        CNPJLabel.Name = "CNPJLabel"
'        CNPJLabel.Size = New System.Drawing.Size(47, 17)
'        CNPJLabel.TabIndex = 4
'        CNPJLabel.Text = "CNPJ:"
'        '
'        'CNPJTextBox
'        '
'        Me.CNPJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "CNPJ", True))
'        Me.CNPJTextBox.Location = New System.Drawing.Point(92, 56)
'        Me.CNPJTextBox.Name = "CNPJTextBox"
'        Me.CNPJTextBox.Size = New System.Drawing.Size(181, 22)
'        Me.CNPJTextBox.TabIndex = 5
'        '
'        'IELabel
'        '
'        IELabel.AutoSize = True
'        IELabel.Location = New System.Drawing.Point(344, 59)
'        IELabel.Name = "IELabel"
'        IELabel.Size = New System.Drawing.Size(24, 17)
'        IELabel.TabIndex = 6
'        IELabel.Text = "IE:"
'        '
'        'IETextBox
'        '
'        Me.IETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "IE", True))
'        Me.IETextBox.Location = New System.Drawing.Point(374, 56)
'        Me.IETextBox.Name = "IETextBox"
'        Me.IETextBox.Size = New System.Drawing.Size(203, 22)
'        Me.IETextBox.TabIndex = 7
'        '
'        'EnderecoLabel
'        '
'        EnderecoLabel.AutoSize = True
'        EnderecoLabel.Location = New System.Drawing.Point(14, 87)
'        EnderecoLabel.Name = "EnderecoLabel"
'        EnderecoLabel.Size = New System.Drawing.Size(72, 17)
'        EnderecoLabel.TabIndex = 8
'        EnderecoLabel.Text = "endereco:"
'        '
'        'EnderecoTextBox
'        '
'        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "endereco", True))
'        Me.EnderecoTextBox.Location = New System.Drawing.Point(92, 84)
'        Me.EnderecoTextBox.Name = "EnderecoTextBox"
'        Me.EnderecoTextBox.Size = New System.Drawing.Size(378, 22)
'        Me.EnderecoTextBox.TabIndex = 9
'        '
'        'NumeroLabel
'        '
'        NumeroLabel.AutoSize = True
'        NumeroLabel.Location = New System.Drawing.Point(476, 89)
'        NumeroLabel.Name = "NumeroLabel"
'        NumeroLabel.Size = New System.Drawing.Size(27, 17)
'        NumeroLabel.TabIndex = 10
'        NumeroLabel.Text = "Nº:"
'        '
'        'NumeroTextBox
'        '
'        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "numero", True))
'        Me.NumeroTextBox.Location = New System.Drawing.Point(509, 82)
'        Me.NumeroTextBox.Name = "NumeroTextBox"
'        Me.NumeroTextBox.Size = New System.Drawing.Size(68, 22)
'        Me.NumeroTextBox.TabIndex = 11
'        '
'        'BairroLabel
'        '
'        BairroLabel.AutoSize = True
'        BairroLabel.Location = New System.Drawing.Point(37, 127)
'        BairroLabel.Name = "BairroLabel"
'        BairroLabel.Size = New System.Drawing.Size(49, 17)
'        BairroLabel.TabIndex = 12
'        BairroLabel.Text = "bairro:"
'        '
'        'BairroTextBox
'        '
'        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "bairro", True))
'        Me.BairroTextBox.Location = New System.Drawing.Point(92, 126)
'        Me.BairroTextBox.Name = "BairroTextBox"
'        Me.BairroTextBox.Size = New System.Drawing.Size(125, 22)
'        Me.BairroTextBox.TabIndex = 13
'        '
'        'CidadeLabel
'        '
'        CidadeLabel.AutoSize = True
'        CidadeLabel.Location = New System.Drawing.Point(223, 129)
'        CidadeLabel.Name = "CidadeLabel"
'        CidadeLabel.Size = New System.Drawing.Size(54, 17)
'        CidadeLabel.TabIndex = 14
'        CidadeLabel.Text = "cidade:"
'        '
'        'CidadeTextBox
'        '
'        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "cidade", True))
'        Me.CidadeTextBox.Location = New System.Drawing.Point(283, 124)
'        Me.CidadeTextBox.Name = "CidadeTextBox"
'        Me.CidadeTextBox.Size = New System.Drawing.Size(151, 22)
'        Me.CidadeTextBox.TabIndex = 15
'        '
'        'UFLabel
'        '
'        UFLabel.AutoSize = True
'        UFLabel.Location = New System.Drawing.Point(440, 124)
'        UFLabel.Name = "UFLabel"
'        UFLabel.Size = New System.Drawing.Size(30, 17)
'        UFLabel.TabIndex = 16
'        UFLabel.Text = "UF:"
'        '
'        'UFTextBox
'        '
'        Me.UFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "UF", True))
'        Me.UFTextBox.Location = New System.Drawing.Point(477, 122)
'        Me.UFTextBox.Name = "UFTextBox"
'        Me.UFTextBox.Size = New System.Drawing.Size(100, 22)
'        Me.UFTextBox.TabIndex = 17
'        '
'        'CEPLabel
'        '
'        CEPLabel.AutoSize = True
'        CEPLabel.Location = New System.Drawing.Point(47, 172)
'        CEPLabel.Name = "CEPLabel"
'        CEPLabel.Size = New System.Drawing.Size(39, 17)
'        CEPLabel.TabIndex = 18
'        CEPLabel.Text = "CEP:"
'        '
'        'CEPTextBox
'        '
'        Me.CEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "CEP", True))
'        Me.CEPTextBox.Location = New System.Drawing.Point(92, 169)
'        Me.CEPTextBox.Name = "CEPTextBox"
'        Me.CEPTextBox.Size = New System.Drawing.Size(100, 22)
'        Me.CEPTextBox.TabIndex = 19
'        '
'        'DataGridViewTextBoxColumn1
'        '
'        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
'        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
'        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
'        Me.DataGridViewTextBoxColumn1.ReadOnly = True
'        Me.DataGridViewTextBoxColumn1.Width = 60
'        '
'        'DataGridViewTextBoxColumn2
'        '
'        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
'        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
'        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
'        Me.DataGridViewTextBoxColumn2.ReadOnly = True
'        Me.DataGridViewTextBoxColumn2.Width = 200
'        '
'        'DataGridViewTextBoxColumn5
'        '
'        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CNPJ"
'        Me.DataGridViewTextBoxColumn5.HeaderText = "CNPJ"
'        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
'        Me.DataGridViewTextBoxColumn5.ReadOnly = True
'        '
'        'DataGridViewTextBoxColumn8
'        '
'        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cidade"
'        Me.DataGridViewTextBoxColumn8.HeaderText = "Cidade"
'        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
'        Me.DataGridViewTextBoxColumn8.ReadOnly = True
'        '
'        'DataGridViewTextBoxColumn3
'        '
'        Me.DataGridViewTextBoxColumn3.DataPropertyName = "telefone"
'        Me.DataGridViewTextBoxColumn3.HeaderText = "Fone"
'        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
'        Me.DataGridViewTextBoxColumn3.ReadOnly = True
'        '
'        'GroupBox2
'        '
'        Me.GroupBox2.Controls.Add(Me.BtnConsulta)
'        Me.GroupBox2.Controls.Add(Me.txtConsulta)
'        Me.GroupBox2.Location = New System.Drawing.Point(8, 7)
'        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
'        Me.GroupBox2.Name = "GroupBox2"
'        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
'        Me.GroupBox2.Size = New System.Drawing.Size(519, 71)
'        Me.GroupBox2.TabIndex = 7
'        Me.GroupBox2.TabStop = False
'        Me.GroupBox2.Text = "Pesquisar"
'        '
'        'BtnConsulta
'        '
'        Me.BtnConsulta.Location = New System.Drawing.Point(367, 23)
'        Me.BtnConsulta.Margin = New System.Windows.Forms.Padding(4)
'        Me.BtnConsulta.Name = "BtnConsulta"
'        Me.BtnConsulta.Size = New System.Drawing.Size(100, 28)
'        Me.BtnConsulta.TabIndex = 1
'        Me.BtnConsulta.Text = "Pesquisar"
'        Me.BtnConsulta.UseVisualStyleBackColor = True
'        '
'        'txtConsulta
'        '
'        Me.txtConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
'        Me.txtConsulta.Location = New System.Drawing.Point(17, 23)
'        Me.txtConsulta.Margin = New System.Windows.Forms.Padding(4)
'        Me.txtConsulta.Name = "txtConsulta"
'        Me.txtConsulta.Size = New System.Drawing.Size(319, 22)
'        Me.txtConsulta.TabIndex = 0
'        '
'        'BindingNavigatorAddNewItem
'        '
'        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
'        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
'        Me.BindingNavigatorAddNewItem.Text = "Add new"
'        '
'        'BindingNavigatorDeleteItem
'        '
'        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
'        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
'        Me.BindingNavigatorDeleteItem.Text = "Delete"
'        '
'        'BindingNavigatorMoveFirstItem
'        '
'        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
'        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
'        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
'        '
'        'BindingNavigatorMovePreviousItem
'        '
'        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
'        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
'        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
'        '
'        'BindingNavigatorMoveNextItem
'        '
'        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
'        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
'        Me.BindingNavigatorMoveNextItem.Text = "Move next"
'        '
'        'BindingNavigatorMoveLastItem
'        '
'        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
'        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
'        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
'        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
'        Me.BindingNavigatorMoveLastItem.Text = "Move last"
'        '
'        'FornecedorBindingNavigatorSaveItem
'        '
'        Me.FornecedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'        Me.FornecedorBindingNavigatorSaveItem.Image = CType(resources.GetObject("FornecedorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
'        Me.FornecedorBindingNavigatorSaveItem.Name = "FornecedorBindingNavigatorSaveItem"
'        Me.FornecedorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
'        Me.FornecedorBindingNavigatorSaveItem.Text = "Save Data"
'        '
'        'CadFornecedor
'        '
'        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
'        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
'        Me.ClientSize = New System.Drawing.Size(643, 481)
'        Me.Controls.Add(Me.TabPrin)
'        Me.MaximizeBox = False
'        Me.Name = "CadFornecedor"
'        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
'        Me.Text = "Fornecedor"
'        Me.TabPrin.ResumeLayout(False)
'        Me.TabPage1.ResumeLayout(False)
'        Me.TabPage1.PerformLayout()
'        Me.TabPage2.ResumeLayout(False)
'        CType(Me.LojaDataSetForn, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.FornecedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.FornecedorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.FornecedorBindingNavigator.ResumeLayout(False)
'        Me.FornecedorBindingNavigator.PerformLayout()
'        CType(Me.FornecedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.GroupBox1.ResumeLayout(False)
'        Me.GroupBox1.PerformLayout()
'        Me.GroupBox2.ResumeLayout(False)
'        Me.GroupBox2.PerformLayout()
'        Me.ResumeLayout(False)

'    End Sub
'    Friend WithEvents TabPrin As System.Windows.Forms.TabControl
'    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
'    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
'    Friend WithEvents LojaDataSetForn As ProgLoja.LojaDataSetForn
'    Friend WithEvents FornecedorBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents FornecedorTableAdapter As ProgLoja.LojaDataSetFornTableAdapters.FornecedorTableAdapter
'    Friend WithEvents TableAdapterManager As ProgLoja.LojaDataSetFornTableAdapters.TableAdapterManager
'    Friend WithEvents FornecedorBindingNavigator As System.Windows.Forms.BindingNavigator
'    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
'    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
'    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents FornecedorBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
'    Friend WithEvents FornecedorDataGridView As System.Windows.Forms.DataGridView
'    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
'    Friend WithEvents CEPTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents UFTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents NumeroTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents EnderecoTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents IETextBox As System.Windows.Forms.TextBox
'    Friend WithEvents CNPJTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
'    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
'    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
'    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
'    Friend WithEvents txtConsulta As System.Windows.Forms.TextBox
'End Class
