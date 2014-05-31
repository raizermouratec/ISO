<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cotrRealizarTreinamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cotrRealizarTreinamentos))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblAcaoCapacitacao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAcaoCapacitacao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblNumero = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNumero = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.TabProgramacao = New C1.Win.C1Command.C1DockingTabPage()
        Me.InputPanel_Procedimentos = New C1.Win.C1InputPanel.C1InputPanel()
        Me.botProcedimentos = New C1.Win.C1InputPanel.InputButton()
        Me.InputPanel_Nivel = New C1.Win.C1InputPanel.C1InputPanel()
        Me.cmbNivel = New C1.Win.C1InputPanel.InputComboBox()
        Me.optNivel_Medio = New C1.Win.C1InputPanel.InputOption()
        Me.optNivel_Tecnico = New C1.Win.C1InputPanel.InputOption()
        Me.optNivel_Superior = New C1.Win.C1InputPanel.InputOption()
        Me.optNivel_POS = New C1.Win.C1InputPanel.InputOption()
        Me.optNivel_Mestrado = New C1.Win.C1InputPanel.InputOption()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarProgramacao = New C1.Win.C1InputPanel.InputButton()
        Me.botEditarProgramacao = New C1.Win.C1InputPanel.InputButton()
        Me.lblSelecionaParticipa = New C1.Win.C1InputPanel.InputLabel()
        Me.checkTodos = New C1.Win.C1InputPanel.InputCheckBox()
        Me.gridParticipantes = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtObs = New C1.Win.C1Input.C1TextBox()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblespaco1 = New C1.Win.C1InputPanel.InputLabel()
        Me.optColaboradores = New C1.Win.C1InputPanel.InputRadioButton()
        Me.optAreas = New C1.Win.C1InputPanel.InputRadioButton()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader9 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblLocal = New C1.Win.C1InputPanel.InputLabel()
        Me.txtLocal = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblResponsavel = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbResponsavel = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblInstrutor = New C1.Win.C1InputPanel.InputLabel()
        Me.txtInstrutor = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblTipo = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbTipo = New C1.Win.C1InputPanel.InputComboBox()
        Me.OptTipo_CursoFormcao = New C1.Win.C1InputPanel.InputOption()
        Me.OptTipo_CursoComplementar = New C1.Win.C1InputPanel.InputOption()
        Me.OptTipo_TreinaProc = New C1.Win.C1InputPanel.InputOption()
        Me.lblSeparador = New C1.Win.C1InputPanel.InputLabel()
        Me.lblCargaHoraria = New C1.Win.C1InputPanel.InputLabel()
        Me.mskCargaHoraria = New C1.Win.C1InputPanel.InputMaskedTextBox()
        Me.lblTotalDias = New C1.Win.C1InputPanel.InputLabel()
        Me.txtTotalDias = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblDataInicio = New C1.Win.C1InputPanel.InputLabel()
        Me.dtInicio = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblDataTermino = New C1.Win.C1InputPanel.InputLabel()
        Me.dtTermino = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblRealizacao = New C1.Win.C1InputPanel.InputLabel()
        Me.OptInterna = New C1.Win.C1InputPanel.InputRadioButton()
        Me.optExterna = New C1.Win.C1InputPanel.InputRadioButton()
        Me.lblObservacao = New C1.Win.C1InputPanel.InputLabel()
        Me.TabObjetivos = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel8 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarObjetivos = New C1.Win.C1InputPanel.InputButton()
        Me.botEditarObjetivos = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblObjetivos = New C1.Win.C1InputPanel.InputLabel()
        Me.txtObjetivos = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblJustificativas = New C1.Win.C1InputPanel.InputLabel()
        Me.txtJustificativas = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblRecursosN = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRecursosN = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblPlanejamento = New C1.Win.C1InputPanel.InputLabel()
        Me.txtPlanejamento = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblDataElaboracao = New C1.Win.C1InputPanel.InputLabel()
        Me.dtDataElaboracao = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblDataEficiencia = New C1.Win.C1InputPanel.InputLabel()
        Me.dtDataEficiencia = New C1.Win.C1InputPanel.InputDatePicker()
        Me.TabFrequencia = New C1.Win.C1Command.C1DockingTabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.barra = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.picAnexo = New System.Windows.Forms.PictureBox()
        Me.C1InputPanel9 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader7 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botAnexosFrequencia = New C1.Win.C1InputPanel.InputButton()
        Me.botImprimirFrequencia = New C1.Win.C1InputPanel.InputSplitButton()
        Me.botFinalizarFrequencia = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoLegenda = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.imageRealizada = New C1.Win.C1InputPanel.InputImage()
        Me.lblCancelada = New C1.Win.C1InputPanel.InputLabel()
        Me.imageCancelada = New C1.Win.C1InputPanel.InputImage()
        Me.lblRealizada = New C1.Win.C1InputPanel.InputLabel()
        Me.gridFrequencia = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.TabEficacia = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel11 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader8 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarEficiencia = New C1.Win.C1InputPanel.InputButton()
        Me.botEditarEficiencia = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel10 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblMetodoAnalise = New C1.Win.C1InputPanel.InputLabel()
        Me.txtMetodoAnalise = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblResultadosObtidos = New C1.Win.C1InputPanel.InputLabel()
        Me.txtResultadosObtidos = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblAcaoEficaz = New C1.Win.C1InputPanel.InputLabel()
        Me.optAcaoEficazSim = New C1.Win.C1InputPanel.InputRadioButton()
        Me.optAcaoEficazNao = New C1.Win.C1InputPanel.InputRadioButton()
        Me.lblSeNegativo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSeNegativo = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblOqueFazer = New C1.Win.C1InputPanel.InputLabel()
        Me.txtOqueFazer = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblResponsavelEficiencia = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbResponsavelEficiencia = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblDataEficacia = New C1.Win.C1InputPanel.InputLabel()
        Me.dtDataEficacia = New C1.Win.C1InputPanel.InputDatePicker()
        Me.botAnexos = New C1.Win.C1InputPanel.InputButton()
        Me._imgListLegenda = New System.Windows.Forms.ImageList(Me.components)
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.Menu_01 = New C1.Win.C1Command.C1ContextMenu()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdPresente = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdAusente = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdRemover = New C1.Win.C1Command.C1Command()
        Me.MenuTeste = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.IT01 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IT02 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.IT04 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.TabProgramacao.SuspendLayout()
        CType(Me.InputPanel_Procedimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputPanel_Nivel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridParticipantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabObjetivos.SuspendLayout()
        CType(Me.C1InputPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFrequencia.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.picAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFrequencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEficacia.SuspendLayout()
        CType(Me.C1InputPanel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuTeste.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.lblAcaoCapacitacao)
        Me.C1InputPanel1.Items.Add(Me.txtAcaoCapacitacao)
        Me.C1InputPanel1.Items.Add(Me.lblNumero)
        Me.C1InputPanel1.Items.Add(Me.txtNumero)
        Me.C1InputPanel1.Location = New System.Drawing.Point(12, 12)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(662, 27)
        Me.C1InputPanel1.TabIndex = 30
        '
        'lblAcaoCapacitacao
        '
        Me.lblAcaoCapacitacao.Name = "lblAcaoCapacitacao"
        Me.lblAcaoCapacitacao.Text = "Ação de Capacitação"
        '
        'txtAcaoCapacitacao
        '
        Me.txtAcaoCapacitacao.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtAcaoCapacitacao.Enabled = False
        Me.txtAcaoCapacitacao.Name = "txtAcaoCapacitacao"
        Me.txtAcaoCapacitacao.Width = 388
        '
        'lblNumero
        '
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Text = "Número"
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Name = "txtNumero"
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.TabProgramacao)
        Me.C1DockingTab1.Controls.Add(Me.TabObjetivos)
        Me.C1DockingTab1.Controls.Add(Me.TabFrequencia)
        Me.C1DockingTab1.Controls.Add(Me.TabEficacia)
        Me.C1DockingTab1.Location = New System.Drawing.Point(12, 46)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedIndex = 3
        Me.C1DockingTab1.Size = New System.Drawing.Size(662, 491)
        Me.C1DockingTab1.TabIndex = 31
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'TabProgramacao
        '
        Me.TabProgramacao.Controls.Add(Me.InputPanel_Procedimentos)
        Me.TabProgramacao.Controls.Add(Me.InputPanel_Nivel)
        Me.TabProgramacao.Controls.Add(Me.C1InputPanel2)
        Me.TabProgramacao.Controls.Add(Me.gridParticipantes)
        Me.TabProgramacao.Controls.Add(Me.txtObs)
        Me.TabProgramacao.Controls.Add(Me.C1InputPanel4)
        Me.TabProgramacao.Controls.Add(Me.C1InputPanel3)
        Me.TabProgramacao.Location = New System.Drawing.Point(1, 24)
        Me.TabProgramacao.Name = "TabProgramacao"
        Me.TabProgramacao.Size = New System.Drawing.Size(660, 466)
        Me.TabProgramacao.TabIndex = 0
        Me.TabProgramacao.Text = "Programação"
        '
        'InputPanel_Procedimentos
        '
        Me.InputPanel_Procedimentos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.InputPanel_Procedimentos.Items.Add(Me.botProcedimentos)
        Me.InputPanel_Procedimentos.Location = New System.Drawing.Point(81, 124)
        Me.InputPanel_Procedimentos.Name = "InputPanel_Procedimentos"
        Me.InputPanel_Procedimentos.Size = New System.Drawing.Size(306, 28)
        Me.InputPanel_Procedimentos.TabIndex = 38
        Me.InputPanel_Procedimentos.Visible = False
        '
        'botProcedimentos
        '
        Me.botProcedimentos.Image = CType(resources.GetObject("botProcedimentos.Image"), System.Drawing.Image)
        Me.botProcedimentos.ImageSize = New System.Drawing.Size(16, 16)
        Me.botProcedimentos.Name = "botProcedimentos"
        Me.botProcedimentos.Text = "Procedimentos"
        Me.botProcedimentos.Width = 107
        '
        'InputPanel_Nivel
        '
        Me.InputPanel_Nivel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.InputPanel_Nivel.Items.Add(Me.cmbNivel)
        Me.InputPanel_Nivel.Location = New System.Drawing.Point(81, 124)
        Me.InputPanel_Nivel.Name = "InputPanel_Nivel"
        Me.InputPanel_Nivel.Size = New System.Drawing.Size(306, 26)
        Me.InputPanel_Nivel.TabIndex = 37
        Me.InputPanel_Nivel.Visible = False
        '
        'cmbNivel
        '
        Me.cmbNivel.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbNivel.Items.Add(Me.optNivel_Medio)
        Me.cmbNivel.Items.Add(Me.optNivel_Tecnico)
        Me.cmbNivel.Items.Add(Me.optNivel_Superior)
        Me.cmbNivel.Items.Add(Me.optNivel_POS)
        Me.cmbNivel.Items.Add(Me.optNivel_Mestrado)
        Me.cmbNivel.Name = "cmbNivel"
        Me.cmbNivel.Width = 292
        '
        'optNivel_Medio
        '
        Me.optNivel_Medio.Name = "optNivel_Medio"
        Me.optNivel_Medio.Text = "Nível Médio"
        '
        'optNivel_Tecnico
        '
        Me.optNivel_Tecnico.Name = "optNivel_Tecnico"
        Me.optNivel_Tecnico.Text = "Nível Técnico"
        '
        'optNivel_Superior
        '
        Me.optNivel_Superior.Name = "optNivel_Superior"
        Me.optNivel_Superior.Text = "Nível Superior"
        '
        'optNivel_POS
        '
        Me.optNivel_POS.Name = "optNivel_POS"
        Me.optNivel_POS.Text = "Nível PÓS"
        '
        'optNivel_Mestrado
        '
        Me.optNivel_Mestrado.Name = "optNivel_Mestrado"
        Me.optNivel_Mestrado.Text = "Nível Mestrado"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Items.Add(Me.botSalvarProgramacao)
        Me.C1InputPanel2.Items.Add(Me.botEditarProgramacao)
        Me.C1InputPanel2.Items.Add(Me.lblSelecionaParticipa)
        Me.C1InputPanel2.Items.Add(Me.checkTodos)
        Me.C1InputPanel2.Location = New System.Drawing.Point(3, 397)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(654, 66)
        Me.C1InputPanel2.TabIndex = 36
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
        '
        'botSalvarProgramacao
        '
        Me.botSalvarProgramacao.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botSalvarProgramacao.Image = CType(resources.GetObject("botSalvarProgramacao.Image"), System.Drawing.Image)
        Me.botSalvarProgramacao.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarProgramacao.Name = "botSalvarProgramacao"
        Me.botSalvarProgramacao.Text = "Salvar"
        Me.botSalvarProgramacao.Width = 70
        '
        'botEditarProgramacao
        '
        Me.botEditarProgramacao.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botEditarProgramacao.Image = CType(resources.GetObject("botEditarProgramacao.Image"), System.Drawing.Image)
        Me.botEditarProgramacao.ImageSize = New System.Drawing.Size(20, 20)
        Me.botEditarProgramacao.Name = "botEditarProgramacao"
        Me.botEditarProgramacao.Text = "Editar"
        Me.botEditarProgramacao.Width = 70
        '
        'lblSelecionaParticipa
        '
        Me.lblSelecionaParticipa.Name = "lblSelecionaParticipa"
        Me.lblSelecionaParticipa.Width = 418
        '
        'checkTodos
        '
        Me.checkTodos.Name = "checkTodos"
        Me.checkTodos.Text = "Todos"
        '
        'gridParticipantes
        '
        Me.gridParticipantes.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridParticipantes.AllowEditing = False
        Me.gridParticipantes.AllowFiltering = True
        Me.gridParticipantes.ColumnInfo = resources.GetString("gridParticipantes.ColumnInfo")
        Me.gridParticipantes.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridParticipantes.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridParticipantes.Location = New System.Drawing.Point(3, 274)
        Me.gridParticipantes.Name = "gridParticipantes"
        Me.gridParticipantes.Rows.DefaultSize = 21
        Me.gridParticipantes.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridParticipantes.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridParticipantes.Size = New System.Drawing.Size(654, 117)
        Me.gridParticipantes.StyleInfo = resources.GetString("gridParticipantes.StyleInfo")
        Me.gridParticipantes.TabIndex = 35
        Me.gridParticipantes.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'txtObs
        '
        Me.txtObs.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.Location = New System.Drawing.Point(13, 169)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(635, 50)
        Me.txtObs.TabIndex = 34
        Me.txtObs.Tag = Nothing
        Me.txtObs.TextDetached = True
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel4.Items.Add(Me.lblespaco1)
        Me.C1InputPanel4.Items.Add(Me.optColaboradores)
        Me.C1InputPanel4.Items.Add(Me.optAreas)
        Me.C1InputPanel4.Location = New System.Drawing.Point(3, 231)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(654, 160)
        Me.C1InputPanel4.TabIndex = 33
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Participantes"
        '
        'lblespaco1
        '
        Me.lblespaco1.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblespaco1.Name = "lblespaco1"
        Me.lblespaco1.Text = "Selecionar Participantes por"
        Me.lblespaco1.Width = 477
        '
        'optColaboradores
        '
        Me.optColaboradores.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.optColaboradores.Name = "optColaboradores"
        Me.optColaboradores.Text = "Colaboradores"
        '
        'optAreas
        '
        Me.optAreas.Name = "optAreas"
        Me.optAreas.Text = "Áreas"
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader9)
        Me.C1InputPanel3.Items.Add(Me.lblLocal)
        Me.C1InputPanel3.Items.Add(Me.txtLocal)
        Me.C1InputPanel3.Items.Add(Me.lblResponsavel)
        Me.C1InputPanel3.Items.Add(Me.cmbResponsavel)
        Me.C1InputPanel3.Items.Add(Me.lblInstrutor)
        Me.C1InputPanel3.Items.Add(Me.txtInstrutor)
        Me.C1InputPanel3.Items.Add(Me.lblTipo)
        Me.C1InputPanel3.Items.Add(Me.cmbTipo)
        Me.C1InputPanel3.Items.Add(Me.lblSeparador)
        Me.C1InputPanel3.Items.Add(Me.lblCargaHoraria)
        Me.C1InputPanel3.Items.Add(Me.mskCargaHoraria)
        Me.C1InputPanel3.Items.Add(Me.lblTotalDias)
        Me.C1InputPanel3.Items.Add(Me.txtTotalDias)
        Me.C1InputPanel3.Items.Add(Me.lblDataInicio)
        Me.C1InputPanel3.Items.Add(Me.dtInicio)
        Me.C1InputPanel3.Items.Add(Me.lblDataTermino)
        Me.C1InputPanel3.Items.Add(Me.dtTermino)
        Me.C1InputPanel3.Items.Add(Me.lblRealizacao)
        Me.C1InputPanel3.Items.Add(Me.OptInterna)
        Me.C1InputPanel3.Items.Add(Me.optExterna)
        Me.C1InputPanel3.Items.Add(Me.lblObservacao)
        Me.C1InputPanel3.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(654, 222)
        Me.C1InputPanel3.TabIndex = 32
        '
        'InputGroupHeader9
        '
        Me.InputGroupHeader9.Name = "InputGroupHeader9"
        Me.InputGroupHeader9.Text = "Dados"
        '
        'lblLocal
        '
        Me.lblLocal.Name = "lblLocal"
        Me.lblLocal.Text = "Local"
        Me.lblLocal.Width = 64
        '
        'txtLocal
        '
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Width = 307
        '
        'lblResponsavel
        '
        Me.lblResponsavel.Name = "lblResponsavel"
        Me.lblResponsavel.Text = "Responsável"
        '
        'cmbResponsavel
        '
        Me.cmbResponsavel.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbResponsavel.Name = "cmbResponsavel"
        Me.cmbResponsavel.Width = 307
        '
        'lblInstrutor
        '
        Me.lblInstrutor.Name = "lblInstrutor"
        Me.lblInstrutor.Text = "Instrutor"
        Me.lblInstrutor.Width = 64
        '
        'txtInstrutor
        '
        Me.txtInstrutor.Name = "txtInstrutor"
        Me.txtInstrutor.Width = 307
        '
        'lblTipo
        '
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Text = "Tipo"
        Me.lblTipo.Width = 64
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbTipo.Items.Add(Me.OptTipo_CursoFormcao)
        Me.cmbTipo.Items.Add(Me.OptTipo_CursoComplementar)
        Me.cmbTipo.Items.Add(Me.OptTipo_TreinaProc)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Width = 307
        '
        'OptTipo_CursoFormcao
        '
        Me.OptTipo_CursoFormcao.Name = "OptTipo_CursoFormcao"
        Me.OptTipo_CursoFormcao.Text = "Curso de Formação"
        '
        'OptTipo_CursoComplementar
        '
        Me.OptTipo_CursoComplementar.Name = "OptTipo_CursoComplementar"
        Me.OptTipo_CursoComplementar.Text = "Curso Complementar"
        '
        'OptTipo_TreinaProc
        '
        Me.OptTipo_TreinaProc.Name = "OptTipo_TreinaProc"
        Me.OptTipo_TreinaProc.Text = "Treinamento em Procedimentos"
        '
        'lblSeparador
        '
        Me.lblSeparador.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblSeparador.Height = 30
        Me.lblSeparador.Name = "lblSeparador"
        Me.lblSeparador.Width = 64
        '
        'lblCargaHoraria
        '
        Me.lblCargaHoraria.Name = "lblCargaHoraria"
        Me.lblCargaHoraria.Text = "Carga Horária"
        '
        'mskCargaHoraria
        '
        Me.mskCargaHoraria.Name = "mskCargaHoraria"
        '
        'lblTotalDias
        '
        Me.lblTotalDias.Name = "lblTotalDias"
        Me.lblTotalDias.Text = "Total de dias"
        Me.lblTotalDias.Width = 71
        '
        'txtTotalDias
        '
        Me.txtTotalDias.Name = "txtTotalDias"
        '
        'lblDataInicio
        '
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Text = "Início"
        Me.lblDataInicio.Width = 71
        '
        'dtInicio
        '
        Me.dtInicio.Name = "dtInicio"
        '
        'lblDataTermino
        '
        Me.lblDataTermino.Name = "lblDataTermino"
        Me.lblDataTermino.Text = "Término"
        Me.lblDataTermino.Width = 71
        '
        'dtTermino
        '
        Me.dtTermino.Name = "dtTermino"
        '
        'lblRealizacao
        '
        Me.lblRealizacao.Name = "lblRealizacao"
        Me.lblRealizacao.Text = "Realização"
        Me.lblRealizacao.Width = 71
        '
        'OptInterna
        '
        Me.OptInterna.Break = C1.Win.C1InputPanel.BreakType.None
        Me.OptInterna.Name = "OptInterna"
        Me.OptInterna.Text = "Interna"
        Me.OptInterna.Width = 73
        '
        'optExterna
        '
        Me.optExterna.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.optExterna.Name = "optExterna"
        Me.optExterna.Text = "Externa"
        Me.optExterna.Width = 83
        '
        'lblObservacao
        '
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Text = "Observações"
        '
        'TabObjetivos
        '
        Me.TabObjetivos.Controls.Add(Me.C1InputPanel8)
        Me.TabObjetivos.Controls.Add(Me.C1InputPanel5)
        Me.TabObjetivos.Location = New System.Drawing.Point(1, 24)
        Me.TabObjetivos.Name = "TabObjetivos"
        Me.TabObjetivos.Size = New System.Drawing.Size(660, 466)
        Me.TabObjetivos.TabIndex = 1
        Me.TabObjetivos.Text = "Objetivos"
        '
        'C1InputPanel8
        '
        Me.C1InputPanel8.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel8.Items.Add(Me.InputGroupHeader5)
        Me.C1InputPanel8.Items.Add(Me.botSalvarObjetivos)
        Me.C1InputPanel8.Items.Add(Me.botEditarObjetivos)
        Me.C1InputPanel8.Location = New System.Drawing.Point(3, 397)
        Me.C1InputPanel8.Name = "C1InputPanel8"
        Me.C1InputPanel8.Size = New System.Drawing.Size(654, 66)
        Me.C1InputPanel8.TabIndex = 37
        '
        'InputGroupHeader5
        '
        Me.InputGroupHeader5.Name = "InputGroupHeader5"
        Me.InputGroupHeader5.Text = "Opções"
        '
        'botSalvarObjetivos
        '
        Me.botSalvarObjetivos.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botSalvarObjetivos.Image = CType(resources.GetObject("botSalvarObjetivos.Image"), System.Drawing.Image)
        Me.botSalvarObjetivos.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarObjetivos.Name = "botSalvarObjetivos"
        Me.botSalvarObjetivos.Text = "Salvar"
        Me.botSalvarObjetivos.Width = 70
        '
        'botEditarObjetivos
        '
        Me.botEditarObjetivos.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botEditarObjetivos.Image = CType(resources.GetObject("botEditarObjetivos.Image"), System.Drawing.Image)
        Me.botEditarObjetivos.ImageSize = New System.Drawing.Size(20, 20)
        Me.botEditarObjetivos.Name = "botEditarObjetivos"
        Me.botEditarObjetivos.Text = "Editar"
        Me.botEditarObjetivos.Width = 70
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel5.Items.Add(Me.lblObjetivos)
        Me.C1InputPanel5.Items.Add(Me.txtObjetivos)
        Me.C1InputPanel5.Items.Add(Me.lblJustificativas)
        Me.C1InputPanel5.Items.Add(Me.txtJustificativas)
        Me.C1InputPanel5.Items.Add(Me.lblRecursosN)
        Me.C1InputPanel5.Items.Add(Me.txtRecursosN)
        Me.C1InputPanel5.Items.Add(Me.lblPlanejamento)
        Me.C1InputPanel5.Items.Add(Me.txtPlanejamento)
        Me.C1InputPanel5.Items.Add(Me.lblDataElaboracao)
        Me.C1InputPanel5.Items.Add(Me.dtDataElaboracao)
        Me.C1InputPanel5.Items.Add(Me.lblDataEficiencia)
        Me.C1InputPanel5.Items.Add(Me.dtDataEficiencia)
        Me.C1InputPanel5.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(654, 388)
        Me.C1InputPanel5.TabIndex = 34
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Objetivos"
        '
        'lblObjetivos
        '
        Me.lblObjetivos.Name = "lblObjetivos"
        Me.lblObjetivos.Text = "Objetivos"
        Me.lblObjetivos.Width = 115
        '
        'txtObjetivos
        '
        Me.txtObjetivos.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.txtObjetivos.Height = 70
        Me.txtObjetivos.Multiline = True
        Me.txtObjetivos.Name = "txtObjetivos"
        Me.txtObjetivos.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtObjetivos.Width = 508
        '
        'lblJustificativas
        '
        Me.lblJustificativas.Name = "lblJustificativas"
        Me.lblJustificativas.Text = "Justificativas"
        Me.lblJustificativas.Width = 115
        '
        'txtJustificativas
        '
        Me.txtJustificativas.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.txtJustificativas.Height = 70
        Me.txtJustificativas.Multiline = True
        Me.txtJustificativas.Name = "txtJustificativas"
        Me.txtJustificativas.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtJustificativas.Width = 508
        '
        'lblRecursosN
        '
        Me.lblRecursosN.Name = "lblRecursosN"
        Me.lblRecursosN.Text = "Recursos Nescessários"
        Me.lblRecursosN.Width = 115
        '
        'txtRecursosN
        '
        Me.txtRecursosN.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.txtRecursosN.Height = 70
        Me.txtRecursosN.Multiline = True
        Me.txtRecursosN.Name = "txtRecursosN"
        Me.txtRecursosN.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtRecursosN.Width = 508
        '
        'lblPlanejamento
        '
        Me.lblPlanejamento.Name = "lblPlanejamento"
        Me.lblPlanejamento.Text = "Planejamento"
        Me.lblPlanejamento.Width = 115
        '
        'txtPlanejamento
        '
        Me.txtPlanejamento.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.txtPlanejamento.Height = 70
        Me.txtPlanejamento.Multiline = True
        Me.txtPlanejamento.Name = "txtPlanejamento"
        Me.txtPlanejamento.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtPlanejamento.Width = 508
        '
        'lblDataElaboracao
        '
        Me.lblDataElaboracao.Name = "lblDataElaboracao"
        Me.lblDataElaboracao.Text = "Data da Elaboração"
        Me.lblDataElaboracao.Width = 115
        '
        'dtDataElaboracao
        '
        Me.dtDataElaboracao.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtDataElaboracao.Name = "dtDataElaboracao"
        '
        'lblDataEficiencia
        '
        Me.lblDataEficiencia.Name = "lblDataEficiencia"
        Me.lblDataEficiencia.Text = "Prazo para Eficiência"
        '
        'dtDataEficiencia
        '
        Me.dtDataEficiencia.Name = "dtDataEficiencia"
        '
        'TabFrequencia
        '
        Me.TabFrequencia.Controls.Add(Me.StatusStrip1)
        Me.TabFrequencia.Controls.Add(Me.picAnexo)
        Me.TabFrequencia.Controls.Add(Me.C1InputPanel9)
        Me.TabFrequencia.Controls.Add(Me.C1InputPanel7)
        Me.TabFrequencia.Controls.Add(Me.gridFrequencia)
        Me.TabFrequencia.Controls.Add(Me.C1InputPanel6)
        Me.TabFrequencia.Location = New System.Drawing.Point(1, 24)
        Me.TabFrequencia.Name = "TabFrequencia"
        Me.TabFrequencia.Size = New System.Drawing.Size(660, 466)
        Me.TabFrequencia.TabIndex = 2
        Me.TabFrequencia.Text = "Frequência"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.barra, Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 444)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(660, 22)
        Me.StatusStrip1.TabIndex = 40
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'barra
        '
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(100, 16)
        '
        'lblStatus
        '
        Me.lblStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'picAnexo
        '
        Me.picAnexo.Location = New System.Drawing.Point(619, 408)
        Me.picAnexo.Name = "picAnexo"
        Me.picAnexo.Size = New System.Drawing.Size(28, 22)
        Me.picAnexo.TabIndex = 39
        Me.picAnexo.TabStop = False
        Me.picAnexo.Visible = False
        '
        'C1InputPanel9
        '
        Me.C1InputPanel9.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel9.Items.Add(Me.InputGroupHeader7)
        Me.C1InputPanel9.Items.Add(Me.botAnexosFrequencia)
        Me.C1InputPanel9.Items.Add(Me.botImprimirFrequencia)
        Me.C1InputPanel9.Items.Add(Me.botFinalizarFrequencia)
        Me.C1InputPanel9.Location = New System.Drawing.Point(3, 378)
        Me.C1InputPanel9.Name = "C1InputPanel9"
        Me.C1InputPanel9.Size = New System.Drawing.Size(654, 63)
        Me.C1InputPanel9.TabIndex = 38
        '
        'InputGroupHeader7
        '
        Me.InputGroupHeader7.Name = "InputGroupHeader7"
        Me.InputGroupHeader7.Text = "Opções"
        '
        'botAnexosFrequencia
        '
        Me.botAnexosFrequencia.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botAnexosFrequencia.Image = CType(resources.GetObject("botAnexosFrequencia.Image"), System.Drawing.Image)
        Me.botAnexosFrequencia.ImageSize = New System.Drawing.Size(20, 20)
        Me.botAnexosFrequencia.Name = "botAnexosFrequencia"
        Me.botAnexosFrequencia.Text = "Anexos"
        Me.botAnexosFrequencia.Width = 70
        '
        'botImprimirFrequencia
        '
        Me.botImprimirFrequencia.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botImprimirFrequencia.Image = CType(resources.GetObject("botImprimirFrequencia.Image"), System.Drawing.Image)
        Me.botImprimirFrequencia.ImageSize = New System.Drawing.Size(20, 20)
        Me.botImprimirFrequencia.Name = "botImprimirFrequencia"
        Me.botImprimirFrequencia.Text = "Imprimir"
        '
        'botFinalizarFrequencia
        '
        Me.botFinalizarFrequencia.Image = CType(resources.GetObject("botFinalizarFrequencia.Image"), System.Drawing.Image)
        Me.botFinalizarFrequencia.ImageSize = New System.Drawing.Size(20, 20)
        Me.botFinalizarFrequencia.Name = "botFinalizarFrequencia"
        Me.botFinalizarFrequencia.Text = "Finalizar"
        '
        'C1InputPanel7
        '
        Me.C1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel7.Items.Add(Me.grupoLegenda)
        Me.C1InputPanel7.Items.Add(Me.imageRealizada)
        Me.C1InputPanel7.Items.Add(Me.lblCancelada)
        Me.C1InputPanel7.Items.Add(Me.imageCancelada)
        Me.C1InputPanel7.Items.Add(Me.lblRealizada)
        Me.C1InputPanel7.Location = New System.Drawing.Point(3, 322)
        Me.C1InputPanel7.Name = "C1InputPanel7"
        Me.C1InputPanel7.Size = New System.Drawing.Size(654, 50)
        Me.C1InputPanel7.TabIndex = 36
        '
        'grupoLegenda
        '
        Me.grupoLegenda.Name = "grupoLegenda"
        Me.grupoLegenda.Text = "Legenda"
        '
        'imageRealizada
        '
        Me.imageRealizada.Break = C1.Win.C1InputPanel.BreakType.None
        Me.imageRealizada.Height = 20
        Me.imageRealizada.Image = CType(resources.GetObject("imageRealizada.Image"), System.Drawing.Image)
        Me.imageRealizada.Name = "imageRealizada"
        Me.imageRealizada.Width = 20
        '
        'lblCancelada
        '
        Me.lblCancelada.Name = "lblCancelada"
        Me.lblCancelada.Text = "Presente      "
        Me.lblCancelada.Width = 59
        '
        'imageCancelada
        '
        Me.imageCancelada.Break = C1.Win.C1InputPanel.BreakType.None
        Me.imageCancelada.Height = 20
        Me.imageCancelada.Image = CType(resources.GetObject("imageCancelada.Image"), System.Drawing.Image)
        Me.imageCancelada.Name = "imageCancelada"
        Me.imageCancelada.Width = 20
        '
        'lblRealizada
        '
        Me.lblRealizada.Name = "lblRealizada"
        Me.lblRealizada.Text = "Ausente"
        Me.lblRealizada.Width = 59
        '
        'gridFrequencia
        '
        Me.gridFrequencia.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridFrequencia.AllowEditing = False
        Me.gridFrequencia.ColumnInfo = resources.GetString("gridFrequencia.ColumnInfo")
        Me.gridFrequencia.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridFrequencia.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridFrequencia.Location = New System.Drawing.Point(3, 27)
        Me.gridFrequencia.Name = "gridFrequencia"
        Me.gridFrequencia.Rows.DefaultSize = 21
        Me.gridFrequencia.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridFrequencia.Size = New System.Drawing.Size(654, 289)
        Me.gridFrequencia.StyleInfo = resources.GetString("gridFrequencia.StyleInfo")
        Me.gridFrequencia.TabIndex = 35
        Me.gridFrequencia.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel6.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(654, 289)
        Me.C1InputPanel6.TabIndex = 34
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "Participantes"
        '
        'TabEficacia
        '
        Me.TabEficacia.Controls.Add(Me.C1InputPanel11)
        Me.TabEficacia.Controls.Add(Me.C1InputPanel10)
        Me.TabEficacia.Location = New System.Drawing.Point(1, 24)
        Me.TabEficacia.Name = "TabEficacia"
        Me.TabEficacia.Size = New System.Drawing.Size(660, 466)
        Me.TabEficacia.TabIndex = 3
        Me.TabEficacia.Text = "Eficácia"
        '
        'C1InputPanel11
        '
        Me.C1InputPanel11.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel11.Items.Add(Me.InputGroupHeader8)
        Me.C1InputPanel11.Items.Add(Me.botSalvarEficiencia)
        Me.C1InputPanel11.Items.Add(Me.botEditarEficiencia)
        Me.C1InputPanel11.Location = New System.Drawing.Point(3, 397)
        Me.C1InputPanel11.Name = "C1InputPanel11"
        Me.C1InputPanel11.Size = New System.Drawing.Size(654, 66)
        Me.C1InputPanel11.TabIndex = 38
        '
        'InputGroupHeader8
        '
        Me.InputGroupHeader8.Name = "InputGroupHeader8"
        Me.InputGroupHeader8.Text = "Opções"
        '
        'botSalvarEficiencia
        '
        Me.botSalvarEficiencia.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botSalvarEficiencia.Image = CType(resources.GetObject("botSalvarEficiencia.Image"), System.Drawing.Image)
        Me.botSalvarEficiencia.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarEficiencia.Name = "botSalvarEficiencia"
        Me.botSalvarEficiencia.Text = "Salvar"
        Me.botSalvarEficiencia.Width = 70
        '
        'botEditarEficiencia
        '
        Me.botEditarEficiencia.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botEditarEficiencia.Image = CType(resources.GetObject("botEditarEficiencia.Image"), System.Drawing.Image)
        Me.botEditarEficiencia.ImageSize = New System.Drawing.Size(20, 20)
        Me.botEditarEficiencia.Name = "botEditarEficiencia"
        Me.botEditarEficiencia.Text = "Editar"
        Me.botEditarEficiencia.Width = 70
        '
        'C1InputPanel10
        '
        Me.C1InputPanel10.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel10.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel10.Items.Add(Me.lblMetodoAnalise)
        Me.C1InputPanel10.Items.Add(Me.txtMetodoAnalise)
        Me.C1InputPanel10.Items.Add(Me.lblResultadosObtidos)
        Me.C1InputPanel10.Items.Add(Me.txtResultadosObtidos)
        Me.C1InputPanel10.Items.Add(Me.lblAcaoEficaz)
        Me.C1InputPanel10.Items.Add(Me.optAcaoEficazSim)
        Me.C1InputPanel10.Items.Add(Me.optAcaoEficazNao)
        Me.C1InputPanel10.Items.Add(Me.lblSeNegativo)
        Me.C1InputPanel10.Items.Add(Me.txtSeNegativo)
        Me.C1InputPanel10.Items.Add(Me.lblOqueFazer)
        Me.C1InputPanel10.Items.Add(Me.txtOqueFazer)
        Me.C1InputPanel10.Items.Add(Me.lblResponsavelEficiencia)
        Me.C1InputPanel10.Items.Add(Me.cmbResponsavelEficiencia)
        Me.C1InputPanel10.Items.Add(Me.lblDataEficacia)
        Me.C1InputPanel10.Items.Add(Me.dtDataEficacia)
        Me.C1InputPanel10.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel10.Name = "C1InputPanel10"
        Me.C1InputPanel10.Size = New System.Drawing.Size(654, 388)
        Me.C1InputPanel10.TabIndex = 35
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "Eficácia"
        '
        'lblMetodoAnalise
        '
        Me.lblMetodoAnalise.Name = "lblMetodoAnalise"
        Me.lblMetodoAnalise.Text = "Método de Análise"
        Me.lblMetodoAnalise.Width = 120
        '
        'txtMetodoAnalise
        '
        Me.txtMetodoAnalise.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.txtMetodoAnalise.Height = 70
        Me.txtMetodoAnalise.Multiline = True
        Me.txtMetodoAnalise.Name = "txtMetodoAnalise"
        Me.txtMetodoAnalise.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtMetodoAnalise.Width = 508
        '
        'lblResultadosObtidos
        '
        Me.lblResultadosObtidos.Name = "lblResultadosObtidos"
        Me.lblResultadosObtidos.Text = "Resultados obtidos"
        Me.lblResultadosObtidos.Width = 120
        '
        'txtResultadosObtidos
        '
        Me.txtResultadosObtidos.Height = 70
        Me.txtResultadosObtidos.Multiline = True
        Me.txtResultadosObtidos.Name = "txtResultadosObtidos"
        Me.txtResultadosObtidos.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtResultadosObtidos.Width = 508
        '
        'lblAcaoEficaz
        '
        Me.lblAcaoEficaz.Name = "lblAcaoEficaz"
        Me.lblAcaoEficaz.Text = "A ação foi eficaz ?"
        Me.lblAcaoEficaz.Width = 120
        '
        'optAcaoEficazSim
        '
        Me.optAcaoEficazSim.Break = C1.Win.C1InputPanel.BreakType.None
        Me.optAcaoEficazSim.Name = "optAcaoEficazSim"
        Me.optAcaoEficazSim.Text = "Sim"
        Me.optAcaoEficazSim.Width = 60
        '
        'optAcaoEficazNao
        '
        Me.optAcaoEficazNao.Name = "optAcaoEficazNao"
        Me.optAcaoEficazNao.Text = "Não"
        '
        'lblSeNegativo
        '
        Me.lblSeNegativo.Name = "lblSeNegativo"
        Me.lblSeNegativo.Text = "Se negativo, Justifique"
        Me.lblSeNegativo.Width = 120
        '
        'txtSeNegativo
        '
        Me.txtSeNegativo.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.txtSeNegativo.Enabled = False
        Me.txtSeNegativo.Height = 70
        Me.txtSeNegativo.Multiline = True
        Me.txtSeNegativo.Name = "txtSeNegativo"
        Me.txtSeNegativo.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtSeNegativo.Width = 508
        '
        'lblOqueFazer
        '
        Me.lblOqueFazer.Name = "lblOqueFazer"
        Me.lblOqueFazer.Text = "O que fazer"
        Me.lblOqueFazer.Width = 120
        '
        'txtOqueFazer
        '
        Me.txtOqueFazer.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.txtOqueFazer.Enabled = False
        Me.txtOqueFazer.Height = 70
        Me.txtOqueFazer.Multiline = True
        Me.txtOqueFazer.Name = "txtOqueFazer"
        Me.txtOqueFazer.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtOqueFazer.Width = 508
        '
        'lblResponsavelEficiencia
        '
        Me.lblResponsavelEficiencia.Name = "lblResponsavelEficiencia"
        Me.lblResponsavelEficiencia.Text = "Responsavel"
        Me.lblResponsavelEficiencia.Width = 120
        '
        'cmbResponsavelEficiencia
        '
        Me.cmbResponsavelEficiencia.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.cmbResponsavelEficiencia.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbResponsavelEficiencia.Name = "cmbResponsavelEficiencia"
        Me.cmbResponsavelEficiencia.Width = 238
        '
        'lblDataEficacia
        '
        Me.lblDataEficacia.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDataEficacia.Name = "lblDataEficacia"
        Me.lblDataEficacia.Text = "Data"
        Me.lblDataEficacia.Width = 154
        '
        'dtDataEficacia
        '
        Me.dtDataEficacia.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.dtDataEficacia.Name = "dtDataEficacia"
        '
        'botAnexos
        '
        Me.botAnexos.Image = CType(resources.GetObject("botAnexos.Image"), System.Drawing.Image)
        Me.botAnexos.ImageSize = New System.Drawing.Size(20, 20)
        Me.botAnexos.Name = "botAnexos"
        Me.botAnexos.Text = "Anexos"
        '
        '_imgListLegenda
        '
        Me._imgListLegenda.ImageStream = CType(resources.GetObject("_imgListLegenda.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgListLegenda.TransparentColor = System.Drawing.Color.Transparent
        Me._imgListLegenda.Images.SetKeyName(0, "Prog_Verde01.png")
        Me._imgListLegenda.Images.SetKeyName(1, "Prog_Azul01.png")
        Me._imgListLegenda.Images.SetKeyName(2, "Prog_Vermelho01.png")
        Me._imgListLegenda.Images.SetKeyName(3, "Prog_Amarelo01.png")
        Me._imgListLegenda.Images.SetKeyName(4, "Prog_Laranja01.png")
        Me._imgListLegenda.Images.SetKeyName(5, "Prog_Branco.png")
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.Menu_01)
        Me.C1CommandHolder1.Commands.Add(Me.cmdPresente)
        Me.C1CommandHolder1.Commands.Add(Me.cmdAusente)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRemover)
        Me.C1CommandHolder1.Owner = Me
        '
        'Menu_01
        '
        Me.Menu_01.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink2, Me.C1CommandLink1, Me.C1CommandLink4})
        Me.Menu_01.Name = "Menu_01"
        Me.Menu_01.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.Command = Me.cmdPresente
        Me.C1CommandLink2.Text = "Presente"
        '
        'cmdPresente
        '
        Me.cmdPresente.Image = CType(resources.GetObject("cmdPresente.Image"), System.Drawing.Image)
        Me.cmdPresente.Name = "cmdPresente"
        Me.cmdPresente.Text = "Presente Ação"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.Command = Me.cmdAusente
        Me.C1CommandLink1.SortOrder = 1
        Me.C1CommandLink1.Text = "Ausente"
        '
        'cmdAusente
        '
        Me.cmdAusente.Image = CType(resources.GetObject("cmdAusente.Image"), System.Drawing.Image)
        Me.cmdAusente.Name = "cmdAusente"
        Me.cmdAusente.Text = "Ausente Ação"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.Command = Me.cmdRemover
        Me.C1CommandLink4.SortOrder = 2
        '
        'cmdRemover
        '
        Me.cmdRemover.Image = CType(resources.GetObject("cmdRemover.Image"), System.Drawing.Image)
        Me.cmdRemover.Name = "cmdRemover"
        Me.cmdRemover.Text = "Remover"
        '
        'MenuTeste
        '
        Me.MenuTeste.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IT01, Me.IT02, Me.ToolStripSeparator1, Me.IT04})
        Me.MenuTeste.Name = "MenuTeste"
        Me.MenuTeste.Size = New System.Drawing.Size(122, 76)
        '
        'IT01
        '
        Me.IT01.Image = CType(resources.GetObject("IT01.Image"), System.Drawing.Image)
        Me.IT01.Name = "IT01"
        Me.IT01.Size = New System.Drawing.Size(121, 22)
        Me.IT01.Text = "Presente"
        '
        'IT02
        '
        Me.IT02.Image = CType(resources.GetObject("IT02.Image"), System.Drawing.Image)
        Me.IT02.Name = "IT02"
        Me.IT02.Size = New System.Drawing.Size(121, 22)
        Me.IT02.Text = "Ausente"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(118, 6)
        '
        'IT04
        '
        Me.IT04.Image = CType(resources.GetObject("IT04.Image"), System.Drawing.Image)
        Me.IT04.Name = "IT04"
        Me.IT04.Size = New System.Drawing.Size(121, 22)
        Me.IT04.Text = "Remover"
        '
        'cotrRealizarTreinamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 540)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "cotrRealizarTreinamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realiza Capacitação"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.TabProgramacao.ResumeLayout(False)
        CType(Me.InputPanel_Procedimentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputPanel_Nivel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridParticipantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabObjetivos.ResumeLayout(False)
        CType(Me.C1InputPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFrequencia.ResumeLayout(False)
        Me.TabFrequencia.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.picAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFrequencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEficacia.ResumeLayout(False)
        CType(Me.C1InputPanel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuTeste.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents TabProgramacao As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents TabObjetivos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents TabFrequencia As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents TabEficacia As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents txtObs As C1.Win.C1Input.C1TextBox
    Friend WithEvents gridParticipantes As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents gridFrequencia As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents grupoLegenda As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents imageCancelada As C1.Win.C1InputPanel.InputImage
    Private WithEvents lblCancelada As C1.Win.C1InputPanel.InputLabel
    Private WithEvents imageRealizada As C1.Win.C1InputPanel.InputImage
    Private WithEvents lblRealizada As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1InputPanel8 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1InputPanel9 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents picAnexo As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents barra As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents C1InputPanel11 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1InputPanel10 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputPanel_Procedimentos As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputPanel_Nivel As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents _imgListLegenda As System.Windows.Forms.ImageList
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Private WithEvents Menu_01 As C1.Win.C1Command.C1ContextMenu
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Private WithEvents cmdPresente As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Private WithEvents cmdAusente As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Private WithEvents cmdRemover As C1.Win.C1Command.C1Command
    Friend WithEvents MenuTeste As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents IT01 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IT02 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IT04 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents lblAcaoCapacitacao As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtAcaoCapacitacao As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents lblNumero As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtNumero As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents lblLocal As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtLocal As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents lblResponsavel As C1.Win.C1InputPanel.InputLabel
    Private WithEvents cmbResponsavel As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents lblInstrutor As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtInstrutor As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents lblTipo As C1.Win.C1InputPanel.InputLabel
    Private WithEvents cmbTipo As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents lblSeparador As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblCargaHoraria As C1.Win.C1InputPanel.InputLabel
    Private WithEvents mskCargaHoraria As C1.Win.C1InputPanel.InputMaskedTextBox
    Private WithEvents lblTotalDias As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtTotalDias As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents lblDataInicio As C1.Win.C1InputPanel.InputLabel
    Private WithEvents dtInicio As C1.Win.C1InputPanel.InputDatePicker
    Private WithEvents lblDataTermino As C1.Win.C1InputPanel.InputLabel
    Private WithEvents dtTermino As C1.Win.C1InputPanel.InputDatePicker
    Private WithEvents lblObservacao As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents lblObjetivos As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtObjetivos As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents lblJustificativas As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtJustificativas As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents lblRecursosN As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtRecursosN As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents lblPlanejamento As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtPlanejamento As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents lblDataElaboracao As C1.Win.C1InputPanel.InputLabel
    Private WithEvents dtDataElaboracao As C1.Win.C1InputPanel.InputDatePicker
    Private WithEvents lblDataEficiencia As C1.Win.C1InputPanel.InputLabel
    Private WithEvents dtDataEficiencia As C1.Win.C1InputPanel.InputDatePicker
    Private WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents botSalvarProgramacao As C1.Win.C1InputPanel.InputButton
    Private WithEvents botEditarProgramacao As C1.Win.C1InputPanel.InputButton
    Private WithEvents lblSelecionaParticipa As C1.Win.C1InputPanel.InputLabel
    Private WithEvents checkTodos As C1.Win.C1InputPanel.InputCheckBox
    Private WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents botSalvarObjetivos As C1.Win.C1InputPanel.InputButton
    Private WithEvents botEditarObjetivos As C1.Win.C1InputPanel.InputButton
    Private WithEvents botAnexos As C1.Win.C1InputPanel.InputButton
    Private WithEvents InputGroupHeader7 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents botAnexosFrequencia As C1.Win.C1InputPanel.InputButton
    Private WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents botImprimirFrequencia As C1.Win.C1InputPanel.InputSplitButton
    Private WithEvents botFinalizarFrequencia As C1.Win.C1InputPanel.InputButton
    Private WithEvents InputGroupHeader8 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents botSalvarEficiencia As C1.Win.C1InputPanel.InputButton
    Private WithEvents botEditarEficiencia As C1.Win.C1InputPanel.InputButton
    Private WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents lblMetodoAnalise As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtMetodoAnalise As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents lblResultadosObtidos As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtResultadosObtidos As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents lblAcaoEficaz As C1.Win.C1InputPanel.InputLabel
    Private WithEvents optAcaoEficazSim As C1.Win.C1InputPanel.InputRadioButton
    Private WithEvents optAcaoEficazNao As C1.Win.C1InputPanel.InputRadioButton
    Private WithEvents lblSeNegativo As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtSeNegativo As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents lblOqueFazer As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtOqueFazer As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents lblResponsavelEficiencia As C1.Win.C1InputPanel.InputLabel
    Private WithEvents cmbResponsavelEficiencia As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents lblDataEficacia As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputGroupHeader9 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents dtDataEficacia As C1.Win.C1InputPanel.InputDatePicker
    Private WithEvents OptTipo_CursoFormcao As C1.Win.C1InputPanel.InputOption
    Private WithEvents OptTipo_CursoComplementar As C1.Win.C1InputPanel.InputOption
    Private WithEvents OptTipo_TreinaProc As C1.Win.C1InputPanel.InputOption
    Private WithEvents lblespaco1 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents optColaboradores As C1.Win.C1InputPanel.InputRadioButton
    Private WithEvents optAreas As C1.Win.C1InputPanel.InputRadioButton
    Private WithEvents botProcedimentos As C1.Win.C1InputPanel.InputButton
    Private WithEvents cmbNivel As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents OptInterna As C1.Win.C1InputPanel.InputRadioButton
    Private WithEvents optExterna As C1.Win.C1InputPanel.InputRadioButton
    Private WithEvents lblRealizacao As C1.Win.C1InputPanel.InputLabel
    Private WithEvents optNivel_Medio As C1.Win.C1InputPanel.InputOption
    Private WithEvents optNivel_Tecnico As C1.Win.C1InputPanel.InputOption
    Private WithEvents optNivel_Superior As C1.Win.C1InputPanel.InputOption
    Private WithEvents optNivel_POS As C1.Win.C1InputPanel.InputOption
    Private WithEvents optNivel_Mestrado As C1.Win.C1InputPanel.InputOption
End Class
