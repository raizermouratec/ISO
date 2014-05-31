<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forCadAvaliacao
    Inherits C1.Win.C1Ribbon.C1RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forCadAvaliacao))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoCabecalho = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblFornecedor = New C1.Win.C1InputPanel.InputLabel()
        Me.cmb_Fornecedo = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblTipo = New C1.Win.C1InputPanel.InputLabel()
        Me.comboTipo = New C1.Win.C1InputPanel.InputComboBox()
        Me.Check_Nenhum = New C1.Win.C1InputPanel.InputRadioButton()
        Me.Check_Perfil = New C1.Win.C1InputPanel.InputRadioButton()
        Me.cmb_Perfil = New C1.Win.C1InputPanel.InputComboBox()
        Me.bot_Add_Perfil = New C1.Win.C1InputPanel.InputButton()
        Me.grupoRequisitos = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.doc_All = New C1.Win.C1Command.C1DockingTab()
        Me.Aba_Cadastro = New C1.Win.C1Command.C1DockingTabPage()
        Me.fg_pontos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.input_Pontuacao = New C1.Win.C1InputPanel.C1InputPanel()
        Me.group_Notas = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lbl_Requisito = New C1.Win.C1InputPanel.InputLabel()
        Me.txt_Requisito = New C1.Win.C1InputPanel.InputTextBox()
        Me.lbl_Pontuacao = New C1.Win.C1InputPanel.InputLabel()
        Me.txt_Pontos = New C1.Win.C1InputPanel.InputNumericBox()
        Me.bot_AddPonto = New C1.Win.C1InputPanel.InputButton()
        Me.input_voltar = New C1.Win.C1InputPanel.C1InputPanel()
        Me.bot_cancelar = New C1.Win.C1InputPanel.InputButton()
        Me.input_Notas = New C1.Win.C1InputPanel.C1InputPanel()
        Me.group_Nota = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lbl_NotaMinima = New C1.Win.C1InputPanel.InputLabel()
        Me.txt_NotaMinima = New C1.Win.C1InputPanel.InputNumericBox()
        Me.lbl_Notamaxima = New C1.Win.C1InputPanel.InputLabel()
        Me.txt_Notamaxima = New C1.Win.C1InputPanel.InputNumericBox()
        Me.lbl_Media = New C1.Win.C1InputPanel.InputLabel()
        Me.txt_Media = New C1.Win.C1InputPanel.InputNumericBox()
        Me.input_op = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btAvaliacao = New C1.Win.C1InputPanel.InputButton()
        Me.Esp = New C1.Win.C1InputPanel.InputLabel()
        Me.gridRequisito = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Aba_Avaliação = New C1.Win.C1Command.C1DockingTabPage()
        Me.AbaNotas = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblDescricaoN = New C1.Win.C1InputPanel.InputLabel()
        Me.txtDescricaoN = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblNota = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNota = New C1.Win.C1InputPanel.InputNumericBox()
        Me.lblMediaMinima = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNotaMedia = New C1.Win.C1InputPanel.InputNumericBox()
        Me.lbl_Nota_Maxima = New C1.Win.C1InputPanel.InputLabel()
        Me.txt_Nota_Maxima = New C1.Win.C1InputPanel.InputNumericBox()
        Me.lblResultado = New C1.Win.C1InputPanel.InputLabel()
        Me.txtResultado = New C1.Win.C1InputPanel.InputTextBox()
        Me.imgResult = New C1.Win.C1InputPanel.InputImage()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblComentariosNotas = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.bot_responder_Notas = New C1.Win.C1InputPanel.InputButton()
        Me.txt_Pendencia = New System.Windows.Forms.TextBox()
        Me.txt_Coment_Notas = New System.Windows.Forms.TextBox()
        Me.AbaPontuacao = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader7 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lbl_Descrição = New C1.Win.C1InputPanel.InputLabel()
        Me.txt_Descicao_Nota = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblPontuacaoP = New C1.Win.C1InputPanel.InputLabel()
        Me.txtPontuacaoP = New C1.Win.C1InputPanel.InputNumericBox()
        Me.lblMediaP = New C1.Win.C1InputPanel.InputLabel()
        Me.txt_media_Pnt = New C1.Win.C1InputPanel.InputMaskedTextBox()
        Me.lblResultP = New C1.Win.C1InputPanel.InputLabel()
        Me.txtResultP = New C1.Win.C1InputPanel.InputTextBox()
        Me.imgResultP = New C1.Win.C1InputPanel.InputImage()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.lbl_Comentarios = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.bot_Responder_Pontuacao = New C1.Win.C1InputPanel.InputButton()
        Me.AbaAtende = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblDescricao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtDescricao = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.optAtende = New C1.Win.C1InputPanel.InputRadioButton()
        Me.optNaoAtende = New C1.Win.C1InputPanel.InputRadioButton()
        Me.optParcialmente = New C1.Win.C1InputPanel.InputRadioButton()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblComentarios = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.bot_Resposta_Atende = New C1.Win.C1InputPanel.InputButton()
        Me.AbaNivel = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader8 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblDescricaoA = New C1.Win.C1InputPanel.InputLabel()
        Me.txtDescricaoA = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.checkOtimo = New C1.Win.C1InputPanel.InputRadioButton()
        Me.checkBom = New C1.Win.C1InputPanel.InputRadioButton()
        Me.checkRegular = New C1.Win.C1InputPanel.InputRadioButton()
        Me.checkRuim = New C1.Win.C1InputPanel.InputRadioButton()
        Me.InputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblComentarios_Nivel = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.Bot_Responder_Nivel = New C1.Win.C1InputPanel.InputButton()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarAvalia = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader10 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lbl_Resultado = New C1.Win.C1InputPanel.InputLabel()
        Me.txt_Resultado = New C1.Win.C1InputPanel.InputTextBox()
        Me.txt_Avaliacao = New C1.Win.C1InputPanel.InputLabel()
        Me.RadioQualificado = New C1.Win.C1InputPanel.InputRadioButton()
        Me.RadioNQualificado = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioQualificado_restrição = New C1.Win.C1InputPanel.InputRadioButton()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblAvaliador = New C1.Win.C1InputPanel.InputLabel()
        Me.Cmb_Avaliador = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dtAvaliacao = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblObs = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lbl_dt_pendencia = New C1.Win.C1InputPanel.InputLabel()
        Me.dt_Pendencia = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel20 = New C1.Win.C1InputPanel.InputLabel()
        Me.lbl_Pendencia = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.lbl_Situacao = New C1.Win.C1InputPanel.InputLabel()
        Me.Radio_Concluido = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radio_N_Concluida = New C1.Win.C1InputPanel.InputRadioButton()
        Me.gridSelecionados = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.group_requisitos = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.Icones = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doc_All, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.doc_All.SuspendLayout()
        Me.Aba_Cadastro.SuspendLayout()
        CType(Me.fg_pontos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input_Pontuacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input_Notas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input_op, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRequisito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Aba_Avaliação.SuspendLayout()
        CType(Me.AbaNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbaPontuacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbaAtende, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbaNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSelecionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.grupoCabecalho)
        Me.C1InputPanel1.Items.Add(Me.lblFornecedor)
        Me.C1InputPanel1.Items.Add(Me.cmb_Fornecedo)
        Me.C1InputPanel1.Items.Add(Me.lblTipo)
        Me.C1InputPanel1.Items.Add(Me.comboTipo)
        Me.C1InputPanel1.Items.Add(Me.Check_Nenhum)
        Me.C1InputPanel1.Items.Add(Me.Check_Perfil)
        Me.C1InputPanel1.Items.Add(Me.cmb_Perfil)
        Me.C1InputPanel1.Items.Add(Me.bot_Add_Perfil)
        Me.C1InputPanel1.Items.Add(Me.grupoRequisitos)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(693, 547)
        Me.C1InputPanel1.TabIndex = 3
        '
        'grupoCabecalho
        '
        Me.grupoCabecalho.Name = "grupoCabecalho"
        Me.grupoCabecalho.Text = "Identificação da Avaliação"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Text = "Fornecedor"
        Me.lblFornecedor.Width = 125
        '
        'cmb_Fornecedo
        '
        Me.cmb_Fornecedo.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmb_Fornecedo.Name = "cmb_Fornecedo"
        Me.cmb_Fornecedo.Width = 300
        '
        'lblTipo
        '
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Text = "Tipo"
        Me.lblTipo.Width = 125
        '
        'comboTipo
        '
        Me.comboTipo.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboTipo.Name = "comboTipo"
        Me.comboTipo.Width = 300
        '
        'Check_Nenhum
        '
        Me.Check_Nenhum.Height = 20
        Me.Check_Nenhum.Name = "Check_Nenhum"
        Me.Check_Nenhum.Text = "Nenhum "
        '
        'Check_Perfil
        '
        Me.Check_Perfil.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Check_Perfil.Name = "Check_Perfil"
        Me.Check_Perfil.Text = "Perfil"
        Me.Check_Perfil.Width = 66
        '
        'cmb_Perfil
        '
        Me.cmb_Perfil.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmb_Perfil.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmb_Perfil.Enabled = False
        Me.cmb_Perfil.Name = "cmb_Perfil"
        Me.cmb_Perfil.Width = 235
        '
        'bot_Add_Perfil
        '
        Me.bot_Add_Perfil.Image = CType(resources.GetObject("bot_Add_Perfil.Image"), System.Drawing.Image)
        Me.bot_Add_Perfil.ImageSize = New System.Drawing.Size(16, 16)
        Me.bot_Add_Perfil.Name = "bot_Add_Perfil"
        '
        'grupoRequisitos
        '
        Me.grupoRequisitos.Name = "grupoRequisitos"
        Me.grupoRequisitos.Text = "Requisitos"
        '
        'doc_All
        '
        Me.doc_All.Controls.Add(Me.Aba_Cadastro)
        Me.doc_All.Controls.Add(Me.Aba_Avaliação)
        Me.doc_All.Dock = System.Windows.Forms.DockStyle.Top
        Me.doc_All.Location = New System.Drawing.Point(0, 0)
        Me.doc_All.Name = "doc_All"
        Me.doc_All.SelectedIndex = 2
        Me.doc_All.Size = New System.Drawing.Size(695, 709)
        Me.doc_All.TabIndex = 4
        Me.doc_All.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.doc_All.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'Aba_Cadastro
        '
        Me.Aba_Cadastro.Controls.Add(Me.fg_pontos)
        Me.Aba_Cadastro.Controls.Add(Me.input_Pontuacao)
        Me.Aba_Cadastro.Controls.Add(Me.input_voltar)
        Me.Aba_Cadastro.Controls.Add(Me.input_Notas)
        Me.Aba_Cadastro.Controls.Add(Me.input_op)
        Me.Aba_Cadastro.Controls.Add(Me.gridRequisito)
        Me.Aba_Cadastro.Controls.Add(Me.C1InputPanel1)
        Me.Aba_Cadastro.Location = New System.Drawing.Point(1, 24)
        Me.Aba_Cadastro.Name = "Aba_Cadastro"
        Me.Aba_Cadastro.Size = New System.Drawing.Size(693, 684)
        Me.Aba_Cadastro.TabIndex = 0
        Me.Aba_Cadastro.Text = "Cadastro de Avaliação"
        '
        'fg_pontos
        '
        Me.fg_pontos.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg_pontos.AllowEditing = False
        Me.fg_pontos.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg_pontos.ColumnInfo = resources.GetString("fg_pontos.ColumnInfo")
        Me.fg_pontos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.fg_pontos.Location = New System.Drawing.Point(11, 150)
        Me.fg_pontos.Name = "fg_pontos"
        Me.fg_pontos.Rows.Count = 1
        Me.fg_pontos.Rows.DefaultSize = 21
        Me.fg_pontos.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg_pontos.Size = New System.Drawing.Size(141, 134)
        Me.fg_pontos.StyleInfo = resources.GetString("fg_pontos.StyleInfo")
        Me.fg_pontos.TabIndex = 10
        Me.fg_pontos.Visible = False
        Me.fg_pontos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'input_Pontuacao
        '
        Me.input_Pontuacao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.input_Pontuacao.Items.Add(Me.group_Notas)
        Me.input_Pontuacao.Items.Add(Me.lbl_Requisito)
        Me.input_Pontuacao.Items.Add(Me.txt_Requisito)
        Me.input_Pontuacao.Items.Add(Me.lbl_Pontuacao)
        Me.input_Pontuacao.Items.Add(Me.txt_Pontos)
        Me.input_Pontuacao.Items.Add(Me.bot_AddPonto)
        Me.input_Pontuacao.Location = New System.Drawing.Point(-1, 105)
        Me.input_Pontuacao.Name = "input_Pontuacao"
        Me.input_Pontuacao.Size = New System.Drawing.Size(183, 236)
        Me.input_Pontuacao.TabIndex = 7
        Me.input_Pontuacao.Visible = False
        '
        'group_Notas
        '
        Me.group_Notas.Name = "group_Notas"
        Me.group_Notas.Text = "Cadastrar Pontuação"
        '
        'lbl_Requisito
        '
        Me.lbl_Requisito.Name = "lbl_Requisito"
        Me.lbl_Requisito.Text = "Requisito:"
        Me.lbl_Requisito.Width = 100
        '
        'txt_Requisito
        '
        Me.txt_Requisito.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txt_Requisito.Enabled = False
        Me.txt_Requisito.Name = "txt_Requisito"
        Me.txt_Requisito.Width = 342
        '
        'lbl_Pontuacao
        '
        Me.lbl_Pontuacao.Name = "lbl_Pontuacao"
        Me.lbl_Pontuacao.Text = "Pontos:"
        Me.lbl_Pontuacao.Width = 100
        '
        'txt_Pontos
        '
        Me.txt_Pontos.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txt_Pontos.Enabled = False
        Me.txt_Pontos.Name = "txt_Pontos"
        Me.txt_Pontos.Width = 61
        '
        'bot_AddPonto
        '
        Me.bot_AddPonto.Image = CType(resources.GetObject("bot_AddPonto.Image"), System.Drawing.Image)
        Me.bot_AddPonto.ImageSize = New System.Drawing.Size(16, 16)
        Me.bot_AddPonto.Name = "bot_AddPonto"
        '
        'input_voltar
        '
        Me.input_voltar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.input_voltar.Items.Add(Me.bot_cancelar)
        Me.input_voltar.Location = New System.Drawing.Point(581, 566)
        Me.input_voltar.Name = "input_voltar"
        Me.input_voltar.Size = New System.Drawing.Size(101, 32)
        Me.input_voltar.TabIndex = 9
        Me.input_voltar.Visible = False
        '
        'bot_cancelar
        '
        Me.bot_cancelar.Image = CType(resources.GetObject("bot_cancelar.Image"), System.Drawing.Image)
        Me.bot_cancelar.ImageSize = New System.Drawing.Size(20, 20)
        Me.bot_cancelar.Name = "bot_cancelar"
        Me.bot_cancelar.Text = "Voltar"
        Me.bot_cancelar.Width = 82
        '
        'input_Notas
        '
        Me.input_Notas.BorderColor = System.Drawing.Color.White
        Me.input_Notas.BorderThickness = 2
        Me.input_Notas.Enabled = False
        Me.input_Notas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.input_Notas.Items.Add(Me.group_Nota)
        Me.input_Notas.Items.Add(Me.lbl_NotaMinima)
        Me.input_Notas.Items.Add(Me.txt_NotaMinima)
        Me.input_Notas.Items.Add(Me.lbl_Notamaxima)
        Me.input_Notas.Items.Add(Me.txt_Notamaxima)
        Me.input_Notas.Items.Add(Me.lbl_Media)
        Me.input_Notas.Items.Add(Me.txt_Media)
        Me.input_Notas.Location = New System.Drawing.Point(445, 25)
        Me.input_Notas.Name = "input_Notas"
        Me.input_Notas.Size = New System.Drawing.Size(247, 95)
        Me.input_Notas.TabIndex = 6
        Me.input_Notas.Visible = False
        '
        'group_Nota
        '
        Me.group_Nota.Name = "group_Nota"
        Me.group_Nota.Text = "Notas"
        '
        'lbl_NotaMinima
        '
        Me.lbl_NotaMinima.Name = "lbl_NotaMinima"
        Me.lbl_NotaMinima.Text = "Min:"
        Me.lbl_NotaMinima.Width = 60
        '
        'txt_NotaMinima
        '
        Me.txt_NotaMinima.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txt_NotaMinima.Name = "txt_NotaMinima"
        Me.txt_NotaMinima.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_NotaMinima.Width = 45
        '
        'lbl_Notamaxima
        '
        Me.lbl_Notamaxima.Name = "lbl_Notamaxima"
        Me.lbl_Notamaxima.Text = "Max:"
        Me.lbl_Notamaxima.Width = 60
        '
        'txt_Notamaxima
        '
        Me.txt_Notamaxima.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.txt_Notamaxima.Name = "txt_Notamaxima"
        Me.txt_Notamaxima.Value = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_Notamaxima.Width = 45
        '
        'lbl_Media
        '
        Me.lbl_Media.Name = "lbl_Media"
        Me.lbl_Media.Text = "Nota Minima de Aprovação:"
        Me.lbl_Media.Width = 181
        '
        'txt_Media
        '
        Me.txt_Media.Name = "txt_Media"
        Me.txt_Media.Value = New Decimal(New Integer() {7, 0, 0, 0})
        Me.txt_Media.Width = 45
        '
        'input_op
        '
        Me.input_op.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.input_op.Items.Add(Me.InputGroupHeader1)
        Me.input_op.Items.Add(Me.btAvaliacao)
        Me.input_op.Items.Add(Me.Esp)
        Me.input_op.Location = New System.Drawing.Point(-1, 542)
        Me.input_op.Name = "input_op"
        Me.input_op.Size = New System.Drawing.Size(697, 56)
        Me.input_op.TabIndex = 5
        Me.input_op.ToolTipSettings.Images.Add(New C1.Win.C1InputPanel.ImageEntry("Actions-go-next-icon.png", CType(resources.GetObject("input_op.ToolTipSettings.Images"), System.Drawing.Image)))
        Me.input_op.ToolTipSettings.Images.Add(New C1.Win.C1InputPanel.ImageEntry("Status-dialog-information-icon.png", CType(resources.GetObject("input_op.ToolTipSettings.Images1"), System.Drawing.Image)))
        Me.input_op.ToolTipSettings.Images.Add(New C1.Win.C1InputPanel.ImageEntry("Help_16x16.png", CType(resources.GetObject("input_op.ToolTipSettings.Images2"), System.Drawing.Image)))
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
        '
        'btAvaliacao
        '
        Me.btAvaliacao.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btAvaliacao.Image = CType(resources.GetObject("btAvaliacao.Image"), System.Drawing.Image)
        Me.btAvaliacao.ImageSize = New System.Drawing.Size(20, 20)
        Me.btAvaliacao.Name = "btAvaliacao"
        Me.btAvaliacao.Text = "Iniciar Avaliação"
        '
        'Esp
        '
        Me.Esp.Name = "Esp"
        Me.Esp.Width = 481
        '
        'gridRequisito
        '
        Me.gridRequisito.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridRequisito.AllowEditing = False
        Me.gridRequisito.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.gridRequisito.ColumnInfo = resources.GetString("gridRequisito.ColumnInfo")
        Me.gridRequisito.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridRequisito.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridRequisito.Location = New System.Drawing.Point(4, 150)
        Me.gridRequisito.Name = "gridRequisito"
        Me.gridRequisito.Rows.Count = 1
        Me.gridRequisito.Rows.DefaultSize = 21
        Me.gridRequisito.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridRequisito.Size = New System.Drawing.Size(679, 386)
        Me.gridRequisito.StyleInfo = resources.GetString("gridRequisito.StyleInfo")
        Me.gridRequisito.TabIndex = 4
        Me.gridRequisito.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'Aba_Avaliação
        '
        Me.Aba_Avaliação.Controls.Add(Me.AbaNotas)
        Me.Aba_Avaliação.Controls.Add(Me.txt_Pendencia)
        Me.Aba_Avaliação.Controls.Add(Me.txt_Coment_Notas)
        Me.Aba_Avaliação.Controls.Add(Me.AbaPontuacao)
        Me.Aba_Avaliação.Controls.Add(Me.AbaAtende)
        Me.Aba_Avaliação.Controls.Add(Me.AbaNivel)
        Me.Aba_Avaliação.Controls.Add(Me.txt_obs)
        Me.Aba_Avaliação.Controls.Add(Me.C1InputPanel5)
        Me.Aba_Avaliação.Controls.Add(Me.C1InputPanel6)
        Me.Aba_Avaliação.Controls.Add(Me.C1InputPanel3)
        Me.Aba_Avaliação.Controls.Add(Me.gridSelecionados)
        Me.Aba_Avaliação.Controls.Add(Me.C1InputPanel7)
        Me.Aba_Avaliação.Location = New System.Drawing.Point(1, 24)
        Me.Aba_Avaliação.Name = "Aba_Avaliação"
        Me.Aba_Avaliação.Size = New System.Drawing.Size(693, 684)
        Me.Aba_Avaliação.TabIndex = 1
        Me.Aba_Avaliação.Text = "Avaliação"
        '
        'AbaNotas
        '
        Me.AbaNotas.Enabled = False
        Me.AbaNotas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbaNotas.Items.Add(Me.InputGroupHeader5)
        Me.AbaNotas.Items.Add(Me.lblDescricaoN)
        Me.AbaNotas.Items.Add(Me.txtDescricaoN)
        Me.AbaNotas.Items.Add(Me.lblNota)
        Me.AbaNotas.Items.Add(Me.txtNota)
        Me.AbaNotas.Items.Add(Me.lblMediaMinima)
        Me.AbaNotas.Items.Add(Me.txtNotaMedia)
        Me.AbaNotas.Items.Add(Me.lbl_Nota_Maxima)
        Me.AbaNotas.Items.Add(Me.txt_Nota_Maxima)
        Me.AbaNotas.Items.Add(Me.lblResultado)
        Me.AbaNotas.Items.Add(Me.txtResultado)
        Me.AbaNotas.Items.Add(Me.imgResult)
        Me.AbaNotas.Items.Add(Me.InputLabel4)
        Me.AbaNotas.Items.Add(Me.lblComentariosNotas)
        Me.AbaNotas.Items.Add(Me.InputLabel11)
        Me.AbaNotas.Items.Add(Me.InputLabel12)
        Me.AbaNotas.Items.Add(Me.bot_responder_Notas)
        Me.AbaNotas.Location = New System.Drawing.Point(491, 0)
        Me.AbaNotas.Name = "AbaNotas"
        Me.AbaNotas.Size = New System.Drawing.Size(139, 195)
        Me.AbaNotas.TabIndex = 35
        Me.AbaNotas.Visible = False
        Me.AbaNotas.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader5
        '
        Me.InputGroupHeader5.Name = "InputGroupHeader5"
        Me.InputGroupHeader5.Text = "Notas"
        '
        'lblDescricaoN
        '
        Me.lblDescricaoN.Name = "lblDescricaoN"
        Me.lblDescricaoN.Text = "Descrição :"
        Me.lblDescricaoN.Width = 100
        '
        'txtDescricaoN
        '
        Me.txtDescricaoN.Enabled = False
        Me.txtDescricaoN.Name = "txtDescricaoN"
        Me.txtDescricaoN.Width = 569
        '
        'lblNota
        '
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Text = "Nota :"
        Me.lblNota.Width = 100
        '
        'txtNota
        '
        Me.txtNota.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNota.Width = 62
        '
        'lblMediaMinima
        '
        Me.lblMediaMinima.Name = "lblMediaMinima"
        Me.lblMediaMinima.Text = "Nota Média "
        Me.lblMediaMinima.Width = 100
        '
        'txtNotaMedia
        '
        Me.txtNotaMedia.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtNotaMedia.Enabled = False
        Me.txtNotaMedia.Name = "txtNotaMedia"
        Me.txtNotaMedia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNotaMedia.Width = 62
        '
        'lbl_Nota_Maxima
        '
        Me.lbl_Nota_Maxima.Name = "lbl_Nota_Maxima"
        Me.lbl_Nota_Maxima.Text = "Valor Da Pergunta"
        Me.lbl_Nota_Maxima.Width = 100
        '
        'txt_Nota_Maxima
        '
        Me.txt_Nota_Maxima.Enabled = False
        Me.txt_Nota_Maxima.Name = "txt_Nota_Maxima"
        Me.txt_Nota_Maxima.Width = 62
        '
        'lblResultado
        '
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Text = "Resultado :"
        Me.lblResultado.Width = 100
        '
        'txtResultado
        '
        Me.txtResultado.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtResultado.Enabled = False
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Width = 62
        '
        'imgResult
        '
        Me.imgResult.Image = CType(resources.GetObject("imgResult.Image"), System.Drawing.Image)
        Me.imgResult.Name = "imgResult"
        '
        'InputLabel4
        '
        Me.InputLabel4.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel4.Height = 23
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Width = 100
        '
        'lblComentariosNotas
        '
        Me.lblComentariosNotas.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblComentariosNotas.Name = "lblComentariosNotas"
        Me.lblComentariosNotas.Text = "Camentários :"
        Me.lblComentariosNotas.Width = 100
        '
        'InputLabel11
        '
        Me.InputLabel11.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel11.Height = 25
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Width = 55
        '
        'InputLabel12
        '
        Me.InputLabel12.Height = 16
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Width = 585
        '
        'bot_responder_Notas
        '
        Me.bot_responder_Notas.Image = CType(resources.GetObject("bot_responder_Notas.Image"), System.Drawing.Image)
        Me.bot_responder_Notas.ImageSize = New System.Drawing.Size(16, 16)
        Me.bot_responder_Notas.Name = "bot_responder_Notas"
        Me.bot_responder_Notas.Text = "Responder"
        '
        'txt_Pendencia
        '
        Me.txt_Pendencia.Enabled = False
        Me.txt_Pendencia.Location = New System.Drawing.Point(114, 459)
        Me.txt_Pendencia.Multiline = True
        Me.txt_Pendencia.Name = "txt_Pendencia"
        Me.txt_Pendencia.Size = New System.Drawing.Size(568, 40)
        Me.txt_Pendencia.TabIndex = 46
        '
        'txt_Coment_Notas
        '
        Me.txt_Coment_Notas.Enabled = False
        Me.txt_Coment_Notas.Location = New System.Drawing.Point(114, 97)
        Me.txt_Coment_Notas.Multiline = True
        Me.txt_Coment_Notas.Name = "txt_Coment_Notas"
        Me.txt_Coment_Notas.Size = New System.Drawing.Size(24, 60)
        Me.txt_Coment_Notas.TabIndex = 42
        Me.txt_Coment_Notas.Visible = False
        '
        'AbaPontuacao
        '
        Me.AbaPontuacao.Enabled = False
        Me.AbaPontuacao.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbaPontuacao.Items.Add(Me.InputGroupHeader7)
        Me.AbaPontuacao.Items.Add(Me.lbl_Descrição)
        Me.AbaPontuacao.Items.Add(Me.txt_Descicao_Nota)
        Me.AbaPontuacao.Items.Add(Me.lblPontuacaoP)
        Me.AbaPontuacao.Items.Add(Me.txtPontuacaoP)
        Me.AbaPontuacao.Items.Add(Me.lblMediaP)
        Me.AbaPontuacao.Items.Add(Me.txt_media_Pnt)
        Me.AbaPontuacao.Items.Add(Me.lblResultP)
        Me.AbaPontuacao.Items.Add(Me.txtResultP)
        Me.AbaPontuacao.Items.Add(Me.imgResultP)
        Me.AbaPontuacao.Items.Add(Me.InputLabel5)
        Me.AbaPontuacao.Items.Add(Me.lbl_Comentarios)
        Me.AbaPontuacao.Items.Add(Me.InputLabel6)
        Me.AbaPontuacao.Items.Add(Me.InputLabel7)
        Me.AbaPontuacao.Items.Add(Me.bot_Responder_Pontuacao)
        Me.AbaPontuacao.Location = New System.Drawing.Point(302, -4)
        Me.AbaPontuacao.Name = "AbaPontuacao"
        Me.AbaPontuacao.Size = New System.Drawing.Size(128, 198)
        Me.AbaPontuacao.TabIndex = 37
        Me.AbaPontuacao.Visible = False
        Me.AbaPontuacao.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader7
        '
        Me.InputGroupHeader7.Name = "InputGroupHeader7"
        Me.InputGroupHeader7.Text = "Pontuação"
        '
        'lbl_Descrição
        '
        Me.lbl_Descrição.Name = "lbl_Descrição"
        Me.lbl_Descrição.Text = "Descrição :"
        Me.lbl_Descrição.Width = 100
        '
        'txt_Descicao_Nota
        '
        Me.txt_Descicao_Nota.Enabled = False
        Me.txt_Descicao_Nota.Name = "txt_Descicao_Nota"
        Me.txt_Descicao_Nota.Width = 570
        '
        'lblPontuacaoP
        '
        Me.lblPontuacaoP.Name = "lblPontuacaoP"
        Me.lblPontuacaoP.Text = "Pontuação :"
        Me.lblPontuacaoP.Width = 100
        '
        'txtPontuacaoP
        '
        Me.txtPontuacaoP.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtPontuacaoP.Name = "txtPontuacaoP"
        Me.txtPontuacaoP.Width = 57
        '
        'lblMediaP
        '
        Me.lblMediaP.Name = "lblMediaP"
        Me.lblMediaP.Text = "Pontuação máxima do requisito."
        Me.lblMediaP.Width = 208
        '
        'txt_media_Pnt
        '
        Me.txt_media_Pnt.Enabled = False
        Me.txt_media_Pnt.Name = "txt_media_Pnt"
        Me.txt_media_Pnt.Width = 48
        '
        'lblResultP
        '
        Me.lblResultP.Name = "lblResultP"
        Me.lblResultP.Text = "Resultado :"
        Me.lblResultP.Width = 100
        '
        'txtResultP
        '
        Me.txtResultP.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtResultP.Enabled = False
        Me.txtResultP.Name = "txtResultP"
        Me.txtResultP.Width = 56
        '
        'imgResultP
        '
        Me.imgResultP.Image = CType(resources.GetObject("imgResultP.Image"), System.Drawing.Image)
        Me.imgResultP.Name = "imgResultP"
        '
        'InputLabel5
        '
        Me.InputLabel5.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel5.Height = 21
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Width = 52
        '
        'lbl_Comentarios
        '
        Me.lbl_Comentarios.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lbl_Comentarios.Name = "lbl_Comentarios"
        Me.lbl_Comentarios.Text = "Comentários :"
        Me.lbl_Comentarios.Width = 100
        '
        'InputLabel6
        '
        Me.InputLabel6.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel6.Height = 27
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Width = 57
        '
        'InputLabel7
        '
        Me.InputLabel7.Height = 16
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Width = 585
        '
        'bot_Responder_Pontuacao
        '
        Me.bot_Responder_Pontuacao.Image = CType(resources.GetObject("bot_Responder_Pontuacao.Image"), System.Drawing.Image)
        Me.bot_Responder_Pontuacao.ImageSize = New System.Drawing.Size(16, 16)
        Me.bot_Responder_Pontuacao.Name = "bot_Responder_Pontuacao"
        Me.bot_Responder_Pontuacao.Text = "Responder"
        '
        'AbaAtende
        '
        Me.AbaAtende.Enabled = False
        Me.AbaAtende.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbaAtende.Items.Add(Me.InputGroupHeader3)
        Me.AbaAtende.Items.Add(Me.lblDescricao)
        Me.AbaAtende.Items.Add(Me.txtDescricao)
        Me.AbaAtende.Items.Add(Me.InputLabel13)
        Me.AbaAtende.Items.Add(Me.optAtende)
        Me.AbaAtende.Items.Add(Me.optNaoAtende)
        Me.AbaAtende.Items.Add(Me.optParcialmente)
        Me.AbaAtende.Items.Add(Me.InputLabel14)
        Me.AbaAtende.Items.Add(Me.lblComentarios)
        Me.AbaAtende.Items.Add(Me.InputLabel15)
        Me.AbaAtende.Items.Add(Me.InputLabel16)
        Me.AbaAtende.Items.Add(Me.bot_Resposta_Atende)
        Me.AbaAtende.Location = New System.Drawing.Point(176, -4)
        Me.AbaAtende.Name = "AbaAtende"
        Me.AbaAtende.Size = New System.Drawing.Size(112, 195)
        Me.AbaAtende.TabIndex = 38
        Me.AbaAtende.ToolTipSettings.HitTestVisible = True
        Me.AbaAtende.Visible = False
        Me.AbaAtende.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Atende?"
        '
        'lblDescricao
        '
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Text = "Descrição :"
        Me.lblDescricao.Width = 100
        '
        'txtDescricao
        '
        Me.txtDescricao.Enabled = False
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Width = 569
        '
        'InputLabel13
        '
        Me.InputLabel13.Height = 42
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Width = 101
        '
        'optAtende
        '
        Me.optAtende.Break = C1.Win.C1InputPanel.BreakType.None
        Me.optAtende.Name = "optAtende"
        Me.optAtende.Text = "Atende"
        Me.optAtende.Width = 196
        '
        'optNaoAtende
        '
        Me.optNaoAtende.Break = C1.Win.C1InputPanel.BreakType.None
        Me.optNaoAtende.Name = "optNaoAtende"
        Me.optNaoAtende.Text = "Não Atende"
        Me.optNaoAtende.Width = 200
        '
        'optParcialmente
        '
        Me.optParcialmente.Name = "optParcialmente"
        Me.optParcialmente.Text = "Atende Parcialmente"
        Me.optParcialmente.Width = 138
        '
        'InputLabel14
        '
        Me.InputLabel14.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel14.Height = 16
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Width = 32
        '
        'lblComentarios
        '
        Me.lblComentarios.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblComentarios.Name = "lblComentarios"
        Me.lblComentarios.Text = "Comentários :"
        Me.lblComentarios.Width = 100
        '
        'InputLabel15
        '
        Me.InputLabel15.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel15.Height = 37
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Width = 65
        '
        'InputLabel16
        '
        Me.InputLabel16.Height = 19
        Me.InputLabel16.Name = "InputLabel16"
        Me.InputLabel16.Width = 587
        '
        'bot_Resposta_Atende
        '
        Me.bot_Resposta_Atende.Image = CType(resources.GetObject("bot_Resposta_Atende.Image"), System.Drawing.Image)
        Me.bot_Resposta_Atende.ImageSize = New System.Drawing.Size(16, 16)
        Me.bot_Resposta_Atende.Name = "bot_Resposta_Atende"
        Me.bot_Resposta_Atende.Text = "Responder"
        '
        'AbaNivel
        '
        Me.AbaNivel.Enabled = False
        Me.AbaNivel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbaNivel.Items.Add(Me.InputGroupHeader8)
        Me.AbaNivel.Items.Add(Me.lblDescricaoA)
        Me.AbaNivel.Items.Add(Me.txtDescricaoA)
        Me.AbaNivel.Items.Add(Me.InputLabel3)
        Me.AbaNivel.Items.Add(Me.InputLabel8)
        Me.AbaNivel.Items.Add(Me.checkOtimo)
        Me.AbaNivel.Items.Add(Me.checkBom)
        Me.AbaNivel.Items.Add(Me.checkRegular)
        Me.AbaNivel.Items.Add(Me.checkRuim)
        Me.AbaNivel.Items.Add(Me.InputLabel17)
        Me.AbaNivel.Items.Add(Me.lblComentarios_Nivel)
        Me.AbaNivel.Items.Add(Me.InputLabel9)
        Me.AbaNivel.Items.Add(Me.InputLabel10)
        Me.AbaNivel.Items.Add(Me.Bot_Responder_Nivel)
        Me.AbaNivel.Location = New System.Drawing.Point(0, -1)
        Me.AbaNivel.Name = "AbaNivel"
        Me.AbaNivel.Size = New System.Drawing.Size(144, 195)
        Me.AbaNivel.TabIndex = 34
        Me.AbaNivel.Visible = False
        Me.AbaNivel.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader8
        '
        Me.InputGroupHeader8.Name = "InputGroupHeader8"
        Me.InputGroupHeader8.Text = "Nível de atendimento com pontos"
        '
        'lblDescricaoA
        '
        Me.lblDescricaoA.Name = "lblDescricaoA"
        Me.lblDescricaoA.Text = "Descrição :"
        Me.lblDescricaoA.Width = 100
        '
        'txtDescricaoA
        '
        Me.txtDescricaoA.Enabled = False
        Me.txtDescricaoA.Name = "txtDescricaoA"
        Me.txtDescricaoA.Width = 571
        '
        'InputLabel3
        '
        Me.InputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel3.Height = 2
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Width = 60
        '
        'InputLabel8
        '
        Me.InputLabel8.Height = 38
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Width = 98
        '
        'checkOtimo
        '
        Me.checkOtimo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.checkOtimo.Name = "checkOtimo"
        Me.checkOtimo.Text = "Ótimo"
        Me.checkOtimo.Width = 100
        '
        'checkBom
        '
        Me.checkBom.Break = C1.Win.C1InputPanel.BreakType.None
        Me.checkBom.Name = "checkBom"
        Me.checkBom.Text = "Bom"
        Me.checkBom.Width = 100
        '
        'checkRegular
        '
        Me.checkRegular.Break = C1.Win.C1InputPanel.BreakType.None
        Me.checkRegular.Name = "checkRegular"
        Me.checkRegular.Text = "Regular"
        Me.checkRegular.Width = 100
        '
        'checkRuim
        '
        Me.checkRuim.Name = "checkRuim"
        Me.checkRuim.Text = "Ruim"
        Me.checkRuim.Width = 100
        '
        'InputLabel17
        '
        Me.InputLabel17.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel17.Height = 19
        Me.InputLabel17.Name = "InputLabel17"
        Me.InputLabel17.Width = 54
        '
        'lblComentarios_Nivel
        '
        Me.lblComentarios_Nivel.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblComentarios_Nivel.Name = "lblComentarios_Nivel"
        Me.lblComentarios_Nivel.Text = "Comentários :"
        '
        'InputLabel9
        '
        Me.InputLabel9.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel9.Height = 35
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Width = 55
        '
        'InputLabel10
        '
        Me.InputLabel10.Height = 15
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Width = 591
        '
        'Bot_Responder_Nivel
        '
        Me.Bot_Responder_Nivel.Image = CType(resources.GetObject("Bot_Responder_Nivel.Image"), System.Drawing.Image)
        Me.Bot_Responder_Nivel.ImageSize = New System.Drawing.Size(16, 16)
        Me.Bot_Responder_Nivel.Name = "Bot_Responder_Nivel"
        Me.Bot_Responder_Nivel.Text = "responder"
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(115, 364)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(567, 40)
        Me.txt_obs.TabIndex = 45
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel5.Items.Add(Me.botSalvarAvalia)
        Me.C1InputPanel5.Location = New System.Drawing.Point(-2, 538)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(696, 60)
        Me.C1InputPanel5.TabIndex = 28
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "Opções"
        '
        'botSalvarAvalia
        '
        Me.botSalvarAvalia.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botSalvarAvalia.Enabled = False
        Me.botSalvarAvalia.Image = CType(resources.GetObject("botSalvarAvalia.Image"), System.Drawing.Image)
        Me.botSalvarAvalia.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarAvalia.Name = "botSalvarAvalia"
        Me.botSalvarAvalia.Text = "Concluir Avaliação"
        Me.botSalvarAvalia.Width = 134
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader10)
        Me.C1InputPanel6.Items.Add(Me.lbl_Resultado)
        Me.C1InputPanel6.Items.Add(Me.txt_Resultado)
        Me.C1InputPanel6.Items.Add(Me.txt_Avaliacao)
        Me.C1InputPanel6.Items.Add(Me.RadioQualificado)
        Me.C1InputPanel6.Items.Add(Me.RadioNQualificado)
        Me.C1InputPanel6.Items.Add(Me.radioQualificado_restrição)
        Me.C1InputPanel6.Location = New System.Drawing.Point(0, 194)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(696, 93)
        Me.C1InputPanel6.TabIndex = 43
        '
        'InputGroupHeader10
        '
        Me.InputGroupHeader10.Name = "InputGroupHeader10"
        Me.InputGroupHeader10.Text = "Resultado"
        '
        'lbl_Resultado
        '
        Me.lbl_Resultado.Name = "lbl_Resultado"
        Me.lbl_Resultado.Text = "Resultado"
        Me.lbl_Resultado.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lbl_Resultado.Width = 100
        '
        'txt_Resultado
        '
        Me.txt_Resultado.Enabled = False
        Me.txt_Resultado.Height = 43
        Me.txt_Resultado.Multiline = True
        Me.txt_Resultado.Name = "txt_Resultado"
        Me.txt_Resultado.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txt_Resultado.Width = 569
        '
        'txt_Avaliacao
        '
        Me.txt_Avaliacao.Name = "txt_Avaliacao"
        Me.txt_Avaliacao.Text = "Resultado da Avaliação:"
        '
        'RadioQualificado
        '
        Me.RadioQualificado.Break = C1.Win.C1InputPanel.BreakType.None
        Me.RadioQualificado.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.RadioQualificado.Name = "RadioQualificado"
        Me.RadioQualificado.Text = "Qualificado"
        Me.RadioQualificado.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.RadioQualificado.Width = 100
        '
        'RadioNQualificado
        '
        Me.RadioNQualificado.AutoEllipsis = False
        Me.RadioNQualificado.Break = C1.Win.C1InputPanel.BreakType.None
        Me.RadioNQualificado.Name = "RadioNQualificado"
        Me.RadioNQualificado.Text = "Não Qualificado"
        Me.RadioNQualificado.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.RadioNQualificado.Width = 111
        '
        'radioQualificado_restrição
        '
        Me.radioQualificado_restrição.Name = "radioQualificado_restrição"
        Me.radioQualificado_restrição.Text = "Qualificado com restrição"
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel3.Items.Add(Me.lblAvaliador)
        Me.C1InputPanel3.Items.Add(Me.Cmb_Avaliador)
        Me.C1InputPanel3.Items.Add(Me.lblData)
        Me.C1InputPanel3.Items.Add(Me.dtAvaliacao)
        Me.C1InputPanel3.Items.Add(Me.InputLabel1)
        Me.C1InputPanel3.Items.Add(Me.lblObs)
        Me.C1InputPanel3.Items.Add(Me.InputLabel2)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel3.Items.Add(Me.lbl_dt_pendencia)
        Me.C1InputPanel3.Items.Add(Me.dt_Pendencia)
        Me.C1InputPanel3.Items.Add(Me.InputLabel20)
        Me.C1InputPanel3.Items.Add(Me.lbl_Pendencia)
        Me.C1InputPanel3.Items.Add(Me.InputLabel18)
        Me.C1InputPanel3.Items.Add(Me.lbl_Situacao)
        Me.C1InputPanel3.Items.Add(Me.Radio_Concluido)
        Me.C1InputPanel3.Items.Add(Me.radio_N_Concluida)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 287)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(696, 257)
        Me.C1InputPanel3.TabIndex = 44
        Me.C1InputPanel3.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Identificação"
        '
        'lblAvaliador
        '
        Me.lblAvaliador.Name = "lblAvaliador"
        Me.lblAvaliador.Text = "Avaliado por"
        Me.lblAvaliador.Width = 100
        '
        'Cmb_Avaliador
        '
        Me.Cmb_Avaliador.Name = "Cmb_Avaliador"
        Me.Cmb_Avaliador.Width = 568
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Text = "Data"
        Me.lblData.Width = 100
        '
        'dtAvaliacao
        '
        Me.dtAvaliacao.Name = "dtAvaliacao"
        Me.dtAvaliacao.Value = New Date(2014, 2, 18, 0, 0, 0, 0)
        Me.dtAvaliacao.Width = 111
        '
        'InputLabel1
        '
        Me.InputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel1.Height = 3
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Label"
        Me.InputLabel1.Width = 67
        '
        'lblObs
        '
        Me.lblObs.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Text = "Observações"
        Me.lblObs.Width = 100
        '
        'InputLabel2
        '
        Me.InputLabel2.Height = 22
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Width = 70
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Enabled = False
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "Restrição"
        '
        'lbl_dt_pendencia
        '
        Me.lbl_dt_pendencia.Name = "lbl_dt_pendencia"
        Me.lbl_dt_pendencia.Text = "Prazo Para Concluir Pendencia:"
        '
        'dt_Pendencia
        '
        Me.dt_Pendencia.Enabled = False
        Me.dt_Pendencia.Name = "dt_Pendencia"
        '
        'InputLabel20
        '
        Me.InputLabel20.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel20.Height = 11
        Me.InputLabel20.Name = "InputLabel20"
        Me.InputLabel20.Width = 20
        '
        'lbl_Pendencia
        '
        Me.lbl_Pendencia.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lbl_Pendencia.Name = "lbl_Pendencia"
        Me.lbl_Pendencia.Text = "Pendencia"
        Me.lbl_Pendencia.Width = 100
        '
        'InputLabel18
        '
        Me.InputLabel18.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel18.Height = 18
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Width = 20
        '
        'lbl_Situacao
        '
        Me.lbl_Situacao.Name = "lbl_Situacao"
        Me.lbl_Situacao.Text = "Situacão"
        Me.lbl_Situacao.Width = 100
        '
        'Radio_Concluido
        '
        Me.Radio_Concluido.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Radio_Concluido.Enabled = False
        Me.Radio_Concluido.Name = "Radio_Concluido"
        Me.Radio_Concluido.Text = "Restrição Concluida"
        '
        'radio_N_Concluida
        '
        Me.radio_N_Concluida.Enabled = False
        Me.radio_N_Concluida.Name = "radio_N_Concluida"
        Me.radio_N_Concluida.Text = "Restrição Não Concluida"
        '
        'gridSelecionados
        '
        Me.gridSelecionados.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridSelecionados.AllowEditing = False
        Me.gridSelecionados.ColumnInfo = resources.GetString("gridSelecionados.ColumnInfo")
        Me.gridSelecionados.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridSelecionados.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridSelecionados.Location = New System.Drawing.Point(6, 24)
        Me.gridSelecionados.Name = "gridSelecionados"
        Me.gridSelecionados.Rows.Count = 1
        Me.gridSelecionados.Rows.DefaultSize = 21
        Me.gridSelecionados.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridSelecionados.Size = New System.Drawing.Size(678, 167)
        Me.gridSelecionados.StyleInfo = resources.GetString("gridSelecionados.StyleInfo")
        Me.gridSelecionados.TabIndex = 31
        Me.gridSelecionados.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel7
        '
        Me.C1InputPanel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel7.Items.Add(Me.group_requisitos)
        Me.C1InputPanel7.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel7.Name = "C1InputPanel7"
        Me.C1InputPanel7.Size = New System.Drawing.Size(693, 194)
        Me.C1InputPanel7.TabIndex = 30
        Me.C1InputPanel7.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'group_requisitos
        '
        Me.group_requisitos.Name = "group_requisitos"
        Me.group_requisitos.Text = "Requisitos Selecionados"
        '
        'Icones
        '
        Me.Icones.ImageStream = CType(resources.GetObject("Icones.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Icones.TransparentColor = System.Drawing.Color.White
        Me.Icones.Images.SetKeyName(0, "Green.png")
        Me.Icones.Images.SetKeyName(1, "Red.png")
        Me.Icones.Images.SetKeyName(2, "Blue.png")
        Me.Icones.Images.SetKeyName(3, "Grey.png")
        '
        'forCadAvaliacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 622)
        Me.Controls.Add(Me.doc_All)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "forCadAvaliacao"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Escolha dos Requisitos para Avaliação"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doc_All, System.ComponentModel.ISupportInitialize).EndInit()
        Me.doc_All.ResumeLayout(False)
        Me.Aba_Cadastro.ResumeLayout(False)
        CType(Me.fg_pontos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input_Pontuacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input_Notas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input_op, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRequisito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Aba_Avaliação.ResumeLayout(False)
        Me.Aba_Avaliação.PerformLayout()
        CType(Me.AbaNotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbaPontuacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbaAtende, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbaNivel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSelecionados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoCabecalho As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblFornecedor As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTipo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboTipo As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents Check_Perfil As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents Check_Nenhum As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents cmb_Perfil As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents grupoRequisitos As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents doc_All As C1.Win.C1Command.C1DockingTab
    Friend WithEvents Aba_Cadastro As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents input_op As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btAvaliacao As C1.Win.C1InputPanel.InputButton
    Friend WithEvents Esp As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents gridRequisito As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Aba_Avaliação As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents group_requisitos As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridSelecionados As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents AbaNivel As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader8 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblDescricaoA As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtDescricaoA As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents AbaNotas As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblDescricaoN As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtDescricaoN As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblNota As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNota As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents lblMediaMinima As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNotaMedia As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents lblResultado As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtResultado As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents imgResult As C1.Win.C1InputPanel.InputImage
    Friend WithEvents AbaPontuacao As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader7 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblPontuacaoP As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblMediaP As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblResultP As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents imgResultP As C1.Win.C1InputPanel.InputImage
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvarAvalia As C1.Win.C1InputPanel.InputButton
    Friend WithEvents AbaAtende As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblDescricao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtDescricao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents optAtende As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents optNaoAtende As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents optParcialmente As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents lblComentarios As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblComentarios_Nivel As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txt_Coment_Notas As System.Windows.Forms.TextBox
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblComentariosNotas As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lbl_Comentarios As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader10 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lbl_Resultado As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents RadioNQualificado As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents RadioQualificado As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblAvaliador As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtAvaliacao As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblObs As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmb_Fornecedo As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lbl_Descrição As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txt_Descicao_Nota As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents bot_Responder_Pontuacao As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Bot_Responder_Nivel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents bot_responder_Notas As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel16 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents bot_Resposta_Atende As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel17 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents bot_Add_Perfil As C1.Win.C1InputPanel.InputButton
    Friend WithEvents checkOtimo As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents checkBom As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents checkRegular As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents checkRuim As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents Icones As System.Windows.Forms.ImageList
    Friend WithEvents input_Notas As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents group_Nota As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lbl_NotaMinima As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lbl_Notamaxima As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lbl_Media As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents radioQualificado_restrição As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents txt_media_Pnt As C1.Win.C1InputPanel.InputMaskedTextBox
    Friend WithEvents txtResultP As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtPontuacaoP As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents txt_Avaliacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txt_Resultado As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txt_NotaMinima As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents txt_Notamaxima As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents txt_Media As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents input_Pontuacao As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents group_Notas As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lbl_Requisito As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txt_Requisito As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lbl_Pontuacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txt_Pontos As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents input_voltar As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents bot_AddPonto As C1.Win.C1InputPanel.InputButton
    Friend WithEvents bot_cancelar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents fg_pontos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txt_Pendencia As System.Windows.Forms.TextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents dt_Pendencia As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lbl_Pendencia As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lbl_dt_pendencia As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel20 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lbl_Situacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Radio_Concluido As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radio_N_Concluida As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents Cmb_Avaliador As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lbl_Nota_Maxima As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txt_Nota_Maxima As C1.Win.C1InputPanel.InputNumericBox
End Class
