<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calCadInstrumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calCadInstrumentos))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.Tab = New C1.Win.C1Command.C1DockingTab()
        Me.Page1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.botInserirFoto = New C1.Win.C1Input.C1Button()
        Me.txtArmazenamento = New C1.Win.C1Input.C1TextBox()
        Me.photoFoto = New System.Windows.Forms.PictureBox()
        Me.inpultCad = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupIdentificacao = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblNome = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNome = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblIdentificacao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtIdentificacao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblSituacaoAtivo = New C1.Win.C1InputPanel.InputLabel()
        Me.radioAtivo = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioInativo = New C1.Win.C1InputPanel.InputRadioButton()
        Me.lblTipoUso = New C1.Win.C1InputPanel.InputLabel()
        Me.comboTipoUso = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputOption1 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption2 = New C1.Win.C1InputPanel.InputOption()
        Me.lblTipoMedicao = New C1.Win.C1InputPanel.InputLabel()
        Me.comboTipoMedicao = New C1.Win.C1InputPanel.InputComboBox()
        Me.botAdd = New C1.Win.C1InputPanel.InputButton()
        Me.lblFaixaMedicao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtFaixaMedicao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblPrecisao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtPrecisao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblFabricante = New C1.Win.C1InputPanel.InputLabel()
        Me.txtFabricante = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblLocalGuarda = New C1.Win.C1InputPanel.InputLabel()
        Me.txtLocalGuarda = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblArmazenamento = New C1.Win.C1InputPanel.InputLabel()
        Me.txtArmazenamentoOutro = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblSituacao = New C1.Win.C1InputPanel.InputLabel()
        Me.comboSituacao = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputNaoCalibrado = New C1.Win.C1InputPanel.InputOption()
        Me.InputCalibracaoVencida = New C1.Win.C1InputPanel.InputOption()
        Me.InputCalibrado = New C1.Win.C1InputPanel.InputOption()
        Me.lbl = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDataAquisicao = New C1.Win.C1InputPanel.InputLabel()
        Me.dateAquisicao = New C1.Win.C1InputPanel.InputDatePicker()
        Me.grupoResp = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblResp = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResp = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dateData = New C1.Win.C1InputPanel.InputDatePicker()
        Me.Page2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.gridCalibracoes = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Page3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.gridHistorico = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Page4 = New C1.Win.C1Command.C1DockingTabPage()
        Me.picAnexo = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.barra1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblStatus1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.C1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader7 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botAnexos = New C1.Win.C1InputPanel.InputButton()
        Me.gridAnexos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Erro = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        Me.TooltipErro = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.C1InputPanel13 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoInstrumentos = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblProjeto = New C1.Win.C1InputPanel.InputLabel()
        Me.txtInstrumento = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtIdent = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblStatus = New C1.Win.C1InputPanel.InputLabel()
        Me.imgStatus = New System.Windows.Forms.PictureBox()
        Me._imgListLegenda = New System.Windows.Forms.ImageList(Me.components)
        Me._imgListLegenda2 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab.SuspendLayout()
        Me.Page1.SuspendLayout()
        CType(Me.txtArmazenamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photoFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inpultCad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Page2.SuspendLayout()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCalibracoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Page3.SuspendLayout()
        CType(Me.gridHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Page4.SuspendLayout()
        CType(Me.picAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Erro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Location = New System.Drawing.Point(3, 414)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(661, 64)
        Me.C1InputPanel2.TabIndex = 3
        '
        'grupoOpcoes
        '
        Me.grupoOpcoes.Name = "grupoOpcoes"
        Me.grupoOpcoes.Text = "Opções"
        '
        'botSalvar
        '
        Me.botSalvar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botSalvar.Image = CType(resources.GetObject("botSalvar.Image"), System.Drawing.Image)
        Me.botSalvar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvar.Name = "botSalvar"
        Me.botSalvar.Text = "Salvar"
        Me.botSalvar.Width = 70
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.Page1)
        Me.Tab.Controls.Add(Me.Page2)
        Me.Tab.Controls.Add(Me.Page3)
        Me.Tab.Controls.Add(Me.Page4)
        Me.Tab.Location = New System.Drawing.Point(0, 60)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 2
        Me.Tab.Size = New System.Drawing.Size(669, 508)
        Me.Tab.TabIndex = 4
        Me.Tab.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.Tab.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'Page1
        '
        Me.Page1.Controls.Add(Me.botInserirFoto)
        Me.Page1.Controls.Add(Me.txtArmazenamento)
        Me.Page1.Controls.Add(Me.C1InputPanel2)
        Me.Page1.Controls.Add(Me.photoFoto)
        Me.Page1.Controls.Add(Me.inpultCad)
        Me.Page1.Location = New System.Drawing.Point(1, 26)
        Me.Page1.Name = "Page1"
        Me.Page1.Size = New System.Drawing.Size(667, 481)
        Me.Page1.TabIndex = 0
        Me.Page1.Text = "Identificação"
        '
        'botInserirFoto
        '
        Me.botInserirFoto.Image = CType(resources.GetObject("botInserirFoto.Image"), System.Drawing.Image)
        Me.botInserirFoto.Location = New System.Drawing.Point(526, 207)
        Me.botInserirFoto.Name = "botInserirFoto"
        Me.botInserirFoto.Size = New System.Drawing.Size(54, 28)
        Me.botInserirFoto.TabIndex = 11
        Me.botInserirFoto.UseVisualStyleBackColor = True
        '
        'txtArmazenamento
        '
        Me.txtArmazenamento.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtArmazenamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArmazenamento.Location = New System.Drawing.Point(145, 257)
        Me.txtArmazenamento.Multiline = True
        Me.txtArmazenamento.Name = "txtArmazenamento"
        Me.txtArmazenamento.Size = New System.Drawing.Size(300, 67)
        Me.txtArmazenamento.TabIndex = 2
        Me.txtArmazenamento.Tag = Nothing
        Me.txtArmazenamento.TextDetached = True
        '
        'photoFoto
        '
        Me.photoFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.photoFoto.Image = CType(resources.GetObject("photoFoto.Image"), System.Drawing.Image)
        Me.photoFoto.Location = New System.Drawing.Point(475, 38)
        Me.photoFoto.Name = "photoFoto"
        Me.photoFoto.Size = New System.Drawing.Size(162, 163)
        Me.photoFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.photoFoto.TabIndex = 1
        Me.photoFoto.TabStop = False
        '
        'inpultCad
        '
        Me.inpultCad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.inpultCad.Items.Add(Me.grupIdentificacao)
        Me.inpultCad.Items.Add(Me.lblNome)
        Me.inpultCad.Items.Add(Me.txtNome)
        Me.inpultCad.Items.Add(Me.lblIdentificacao)
        Me.inpultCad.Items.Add(Me.txtIdentificacao)
        Me.inpultCad.Items.Add(Me.lblSituacaoAtivo)
        Me.inpultCad.Items.Add(Me.radioAtivo)
        Me.inpultCad.Items.Add(Me.radioInativo)
        Me.inpultCad.Items.Add(Me.lblTipoUso)
        Me.inpultCad.Items.Add(Me.comboTipoUso)
        Me.inpultCad.Items.Add(Me.lblTipoMedicao)
        Me.inpultCad.Items.Add(Me.comboTipoMedicao)
        Me.inpultCad.Items.Add(Me.botAdd)
        Me.inpultCad.Items.Add(Me.lblFaixaMedicao)
        Me.inpultCad.Items.Add(Me.txtFaixaMedicao)
        Me.inpultCad.Items.Add(Me.lblPrecisao)
        Me.inpultCad.Items.Add(Me.txtPrecisao)
        Me.inpultCad.Items.Add(Me.lblFabricante)
        Me.inpultCad.Items.Add(Me.txtFabricante)
        Me.inpultCad.Items.Add(Me.lblLocalGuarda)
        Me.inpultCad.Items.Add(Me.txtLocalGuarda)
        Me.inpultCad.Items.Add(Me.lblArmazenamento)
        Me.inpultCad.Items.Add(Me.txtArmazenamentoOutro)
        Me.inpultCad.Items.Add(Me.lblSituacao)
        Me.inpultCad.Items.Add(Me.comboSituacao)
        Me.inpultCad.Items.Add(Me.lbl)
        Me.inpultCad.Items.Add(Me.lblDataAquisicao)
        Me.inpultCad.Items.Add(Me.dateAquisicao)
        Me.inpultCad.Items.Add(Me.grupoResp)
        Me.inpultCad.Items.Add(Me.lblResp)
        Me.inpultCad.Items.Add(Me.comboResp)
        Me.inpultCad.Items.Add(Me.lblData)
        Me.inpultCad.Items.Add(Me.dateData)
        Me.inpultCad.Location = New System.Drawing.Point(3, 3)
        Me.inpultCad.Name = "inpultCad"
        Me.inpultCad.Size = New System.Drawing.Size(661, 412)
        Me.inpultCad.TabIndex = 0
        Me.inpultCad.ToolTipSettings.Images.Add(New C1.Win.C1InputPanel.ImageEntry("Help_16x16.png", CType(resources.GetObject("inpultCad.ToolTipSettings.Images"), System.Drawing.Image)))
        '
        'grupIdentificacao
        '
        Me.grupIdentificacao.Name = "grupIdentificacao"
        Me.grupIdentificacao.Text = "Cadastrar Instrumento"
        '
        'lblNome
        '
        Me.lblNome.ElementWidth = 128
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Text = "Nome :"
        '
        'txtNome
        '
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Width = 300
        '
        'lblIdentificacao
        '
        Me.lblIdentificacao.ElementWidth = 128
        Me.lblIdentificacao.Name = "lblIdentificacao"
        Me.lblIdentificacao.Text = "Identificação :"
        '
        'txtIdentificacao
        '
        Me.txtIdentificacao.Name = "txtIdentificacao"
        Me.txtIdentificacao.ToolTipText = resources.GetString("txtIdentificacao.ToolTipText")
        Me.txtIdentificacao.Width = 93
        '
        'lblSituacaoAtivo
        '
        Me.lblSituacaoAtivo.Name = "lblSituacaoAtivo"
        Me.lblSituacaoAtivo.Text = "Instrumento :"
        Me.lblSituacaoAtivo.Width = 125
        '
        'radioAtivo
        '
        Me.radioAtivo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioAtivo.Name = "radioAtivo"
        Me.radioAtivo.Text = "Ativo"
        Me.radioAtivo.Width = 88
        '
        'radioInativo
        '
        Me.radioInativo.Name = "radioInativo"
        Me.radioInativo.Text = "Inativo"
        '
        'lblTipoUso
        '
        Me.lblTipoUso.ElementWidth = 128
        Me.lblTipoUso.Name = "lblTipoUso"
        Me.lblTipoUso.Text = "Tipo de Uso :"
        '
        'comboTipoUso
        '
        Me.comboTipoUso.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboTipoUso.Items.Add(Me.InputOption1)
        Me.comboTipoUso.Items.Add(Me.InputOption2)
        Me.comboTipoUso.Name = "comboTipoUso"
        Me.comboTipoUso.Width = 200
        '
        'InputOption1
        '
        Me.InputOption1.Name = "InputOption1"
        Me.InputOption1.Text = "Operacional"
        '
        'InputOption2
        '
        Me.InputOption2.Name = "InputOption2"
        Me.InputOption2.Text = "Padrão Interno"
        '
        'lblTipoMedicao
        '
        Me.lblTipoMedicao.ElementWidth = 128
        Me.lblTipoMedicao.Name = "lblTipoMedicao"
        Me.lblTipoMedicao.Text = "Tipo de Medição :"
        '
        'comboTipoMedicao
        '
        Me.comboTipoMedicao.Break = C1.Win.C1InputPanel.BreakType.None
        Me.comboTipoMedicao.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboTipoMedicao.Name = "comboTipoMedicao"
        Me.comboTipoMedicao.Width = 200
        '
        'botAdd
        '
        Me.botAdd.Image = CType(resources.GetObject("botAdd.Image"), System.Drawing.Image)
        Me.botAdd.ImageSize = New System.Drawing.Size(15, 15)
        Me.botAdd.Name = "botAdd"
        Me.botAdd.ToolTipText = "Clique aqui para<br>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "adicionar mais tipos<br>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de medição"
        '
        'lblFaixaMedicao
        '
        Me.lblFaixaMedicao.ElementWidth = 128
        Me.lblFaixaMedicao.Name = "lblFaixaMedicao"
        Me.lblFaixaMedicao.Text = "Faixa de Medição :"
        '
        'txtFaixaMedicao
        '
        Me.txtFaixaMedicao.Name = "txtFaixaMedicao"
        Me.txtFaixaMedicao.ToolTipText = resources.GetString("txtFaixaMedicao.ToolTipText")
        Me.txtFaixaMedicao.Width = 300
        '
        'lblPrecisao
        '
        Me.lblPrecisao.ElementWidth = 128
        Me.lblPrecisao.Name = "lblPrecisao"
        Me.lblPrecisao.Text = "Precisão :"
        '
        'txtPrecisao
        '
        Me.txtPrecisao.Name = "txtPrecisao"
        Me.txtPrecisao.ToolTipText = resources.GetString("txtPrecisao.ToolTipText")
        Me.txtPrecisao.Width = 300
        '
        'lblFabricante
        '
        Me.lblFabricante.ElementWidth = 128
        Me.lblFabricante.Name = "lblFabricante"
        Me.lblFabricante.Text = "Fabricante :"
        '
        'txtFabricante
        '
        Me.txtFabricante.Name = "txtFabricante"
        Me.txtFabricante.Width = 300
        '
        'lblLocalGuarda
        '
        Me.lblLocalGuarda.ElementWidth = 128
        Me.lblLocalGuarda.Name = "lblLocalGuarda"
        Me.lblLocalGuarda.Text = "Local de Guarda :"
        '
        'txtLocalGuarda
        '
        Me.txtLocalGuarda.Name = "txtLocalGuarda"
        Me.txtLocalGuarda.Width = 300
        '
        'lblArmazenamento
        '
        Me.lblArmazenamento.ElementWidth = 128
        Me.lblArmazenamento.Name = "lblArmazenamento"
        Me.lblArmazenamento.Text = "Condições de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Armazenamento :"
        '
        'txtArmazenamentoOutro
        '
        Me.txtArmazenamentoOutro.Height = 67
        Me.txtArmazenamentoOutro.Multiline = True
        Me.txtArmazenamentoOutro.Name = "txtArmazenamentoOutro"
        Me.txtArmazenamentoOutro.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtArmazenamentoOutro.Width = 300
        '
        'lblSituacao
        '
        Me.lblSituacao.ElementWidth = 128
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Text = "Situação da Calibração :"
        '
        'comboSituacao
        '
        Me.comboSituacao.Break = C1.Win.C1InputPanel.BreakType.None
        Me.comboSituacao.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboSituacao.Enabled = False
        Me.comboSituacao.ForeColor = System.Drawing.Color.Cyan
        Me.comboSituacao.Items.Add(Me.InputNaoCalibrado)
        Me.comboSituacao.Items.Add(Me.InputCalibracaoVencida)
        Me.comboSituacao.Items.Add(Me.InputCalibrado)
        Me.comboSituacao.Name = "comboSituacao"
        Me.comboSituacao.Width = 200
        '
        'InputNaoCalibrado
        '
        Me.InputNaoCalibrado.Name = "InputNaoCalibrado"
        Me.InputNaoCalibrado.Text = "Não Calibrado"
        '
        'InputCalibracaoVencida
        '
        Me.InputCalibracaoVencida.Name = "InputCalibracaoVencida"
        Me.InputCalibracaoVencida.Text = "Calibração Vencida"
        '
        'InputCalibrado
        '
        Me.InputCalibrado.Name = "InputCalibrado"
        Me.InputCalibrado.Text = "Calibrado"
        '
        'lbl
        '
        Me.lbl.ElementWidth = 95
        Me.lbl.Name = "lbl"
        '
        'lblDataAquisicao
        '
        Me.lblDataAquisicao.Name = "lblDataAquisicao"
        Me.lblDataAquisicao.Text = "Data da Aquisição :"
        '
        'dateAquisicao
        '
        Me.dateAquisicao.Name = "dateAquisicao"
        '
        'grupoResp
        '
        Me.grupoResp.Name = "grupoResp"
        Me.grupoResp.Text = "Responsável"
        '
        'lblResp
        '
        Me.lblResp.ElementWidth = 128
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Text = "Responsável :"
        '
        'comboResp
        '
        Me.comboResp.Break = C1.Win.C1InputPanel.BreakType.None
        Me.comboResp.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResp.Name = "comboResp"
        Me.comboResp.Width = 300
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Text = "Data :"
        Me.lblData.Width = 101
        '
        'dateData
        '
        Me.dateData.Name = "dateData"
        '
        'Page2
        '
        Me.Page2.Controls.Add(Me.C1InputPanel3)
        Me.Page2.Controls.Add(Me.gridCalibracoes)
        Me.Page2.Location = New System.Drawing.Point(1, 26)
        Me.Page2.Name = "Page2"
        Me.Page2.Size = New System.Drawing.Size(667, 481)
        Me.Page2.TabIndex = 1
        Me.Page2.Text = "Calibrações"
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel3.Items.Add(Me.botEditar)
        Me.C1InputPanel3.Location = New System.Drawing.Point(3, 414)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(661, 64)
        Me.C1InputPanel3.TabIndex = 4
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
        '
        'botEditar
        '
        Me.botEditar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botEditar.Image = CType(resources.GetObject("botEditar.Image"), System.Drawing.Image)
        Me.botEditar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botEditar.Name = "botEditar"
        Me.botEditar.Text = "Editar"
        Me.botEditar.Width = 70
        '
        'gridCalibracoes
        '
        Me.gridCalibracoes.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridCalibracoes.AllowEditing = False
        Me.gridCalibracoes.AllowFiltering = True
        Me.gridCalibracoes.ColumnInfo = resources.GetString("gridCalibracoes.ColumnInfo")
        Me.gridCalibracoes.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridCalibracoes.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridCalibracoes.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.gridCalibracoes.Location = New System.Drawing.Point(3, 3)
        Me.gridCalibracoes.Name = "gridCalibracoes"
        Me.gridCalibracoes.Rows.DefaultSize = 21
        Me.gridCalibracoes.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridCalibracoes.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridCalibracoes.Size = New System.Drawing.Size(661, 414)
        Me.gridCalibracoes.StyleInfo = resources.GetString("gridCalibracoes.StyleInfo")
        Me.gridCalibracoes.TabIndex = 1
        Me.gridCalibracoes.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'Page3
        '
        Me.Page3.Controls.Add(Me.gridHistorico)
        Me.Page3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Page3.Location = New System.Drawing.Point(1, 26)
        Me.Page3.Name = "Page3"
        Me.Page3.Size = New System.Drawing.Size(667, 481)
        Me.Page3.TabIndex = 2
        Me.Page3.Text = "Histórico"
        '
        'gridHistorico
        '
        Me.gridHistorico.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridHistorico.AllowEditing = False
        Me.gridHistorico.AllowFiltering = True
        Me.gridHistorico.ColumnInfo = resources.GetString("gridHistorico.ColumnInfo")
        Me.gridHistorico.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridHistorico.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridHistorico.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.gridHistorico.Location = New System.Drawing.Point(3, 3)
        Me.gridHistorico.Name = "gridHistorico"
        Me.gridHistorico.Rows.DefaultSize = 21
        Me.gridHistorico.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridHistorico.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridHistorico.Size = New System.Drawing.Size(661, 475)
        Me.gridHistorico.StyleInfo = resources.GetString("gridHistorico.StyleInfo")
        Me.gridHistorico.TabIndex = 0
        Me.gridHistorico.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'Page4
        '
        Me.Page4.Controls.Add(Me.picAnexo)
        Me.Page4.Controls.Add(Me.StatusStrip1)
        Me.Page4.Controls.Add(Me.C1InputPanel7)
        Me.Page4.Controls.Add(Me.gridAnexos)
        Me.Page4.Controls.Add(Me.C1InputPanel6)
        Me.Page4.Location = New System.Drawing.Point(1, 26)
        Me.Page4.Name = "Page4"
        Me.Page4.Size = New System.Drawing.Size(667, 481)
        Me.Page4.TabIndex = 3
        Me.Page4.Text = "Anexos"
        '
        'picAnexo
        '
        Me.picAnexo.Location = New System.Drawing.Point(626, 426)
        Me.picAnexo.Name = "picAnexo"
        Me.picAnexo.Size = New System.Drawing.Size(28, 22)
        Me.picAnexo.TabIndex = 16
        Me.picAnexo.TabStop = False
        Me.picAnexo.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.barra1, Me.lblStatus1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 459)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(667, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'barra1
        '
        Me.barra1.Name = "barra1"
        Me.barra1.Size = New System.Drawing.Size(100, 16)
        '
        'lblStatus1
        '
        Me.lblStatus1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.lblStatus1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(0, 17)
        '
        'C1InputPanel7
        '
        Me.C1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel7.Items.Add(Me.InputGroupHeader7)
        Me.C1InputPanel7.Items.Add(Me.botAnexos)
        Me.C1InputPanel7.Location = New System.Drawing.Point(3, 397)
        Me.C1InputPanel7.Name = "C1InputPanel7"
        Me.C1InputPanel7.Size = New System.Drawing.Size(661, 59)
        Me.C1InputPanel7.TabIndex = 14
        '
        'InputGroupHeader7
        '
        Me.InputGroupHeader7.Name = "InputGroupHeader7"
        Me.InputGroupHeader7.Text = "Opções"
        '
        'botAnexos
        '
        Me.botAnexos.Image = CType(resources.GetObject("botAnexos.Image"), System.Drawing.Image)
        Me.botAnexos.ImageSize = New System.Drawing.Size(20, 20)
        Me.botAnexos.Name = "botAnexos"
        Me.botAnexos.Text = "Anexos"
        Me.botAnexos.Width = 70
        '
        'gridAnexos
        '
        Me.gridAnexos.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridAnexos.AllowEditing = False
        Me.gridAnexos.AllowFiltering = True
        Me.gridAnexos.ColumnInfo = resources.GetString("gridAnexos.ColumnInfo")
        Me.gridAnexos.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridAnexos.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.gridAnexos.Location = New System.Drawing.Point(3, 27)
        Me.gridAnexos.Name = "gridAnexos"
        Me.gridAnexos.Rows.DefaultSize = 21
        Me.gridAnexos.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridAnexos.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridAnexos.Size = New System.Drawing.Size(661, 373)
        Me.gridAnexos.StyleInfo = resources.GetString("gridAnexos.StyleInfo")
        Me.gridAnexos.TabIndex = 11
        Me.gridAnexos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel6.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(661, 414)
        Me.C1InputPanel6.TabIndex = 10
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "Lista de Anexos"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Prog_Vermelho.png")
        Me.ImageList1.Images.SetKeyName(1, "Prog_Verde.png")
        '
        'Erro
        '
        Me.Erro.ContainerControl = Me
        Me.Erro.ToolTip = Me.TooltipErro
        '
        'TooltipErro
        '
        Me.TooltipErro.Font = New System.Drawing.Font("Tahoma", 8.0!)
        '
        'C1InputPanel13
        '
        Me.C1InputPanel13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel13.Items.Add(Me.grupoInstrumentos)
        Me.C1InputPanel13.Items.Add(Me.lblProjeto)
        Me.C1InputPanel13.Items.Add(Me.txtInstrumento)
        Me.C1InputPanel13.Items.Add(Me.InputLabel1)
        Me.C1InputPanel13.Items.Add(Me.txtIdent)
        Me.C1InputPanel13.Items.Add(Me.lblStatus)
        Me.C1InputPanel13.Location = New System.Drawing.Point(0, 2)
        Me.C1InputPanel13.Name = "C1InputPanel13"
        Me.C1InputPanel13.Size = New System.Drawing.Size(668, 61)
        Me.C1InputPanel13.TabIndex = 5
        '
        'grupoInstrumentos
        '
        Me.grupoInstrumentos.Name = "grupoInstrumentos"
        Me.grupoInstrumentos.Text = "Instrumento"
        '
        'lblProjeto
        '
        Me.lblProjeto.Name = "lblProjeto"
        Me.lblProjeto.Text = "Nome :"
        Me.lblProjeto.Width = 71
        '
        'txtInstrumento
        '
        Me.txtInstrumento.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtInstrumento.Enabled = False
        Me.txtInstrumento.Name = "txtInstrumento"
        Me.txtInstrumento.Width = 329
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Identificação:"
        '
        'txtIdent
        '
        Me.txtIdent.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtIdent.Enabled = False
        Me.txtIdent.Name = "txtIdent"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Text = "Ativo"
        '
        'imgStatus
        '
        Me.imgStatus.Location = New System.Drawing.Point(636, 29)
        Me.imgStatus.Name = "imgStatus"
        Me.imgStatus.Size = New System.Drawing.Size(24, 28)
        Me.imgStatus.TabIndex = 6
        Me.imgStatus.TabStop = False
        '
        '_imgListLegenda
        '
        Me._imgListLegenda.ImageStream = CType(resources.GetObject("_imgListLegenda.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgListLegenda.TransparentColor = System.Drawing.Color.Transparent
        Me._imgListLegenda.Images.SetKeyName(0, "ico_word.png")
        Me._imgListLegenda.Images.SetKeyName(1, "ico_excel.png")
        Me._imgListLegenda.Images.SetKeyName(2, "ico_pdf.png")
        Me._imgListLegenda.Images.SetKeyName(3, "ico_txt.png")
        Me._imgListLegenda.Images.SetKeyName(4, "ico_powerpoint.png")
        Me._imgListLegenda.Images.SetKeyName(5, "ico_outlook.png")
        Me._imgListLegenda.Images.SetKeyName(6, "ico_out.png")
        '
        '_imgListLegenda2
        '
        Me._imgListLegenda2.ImageStream = CType(resources.GetObject("_imgListLegenda2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgListLegenda2.TransparentColor = System.Drawing.Color.Transparent
        Me._imgListLegenda2.Images.SetKeyName(0, "Prog_Verde01.png")
        Me._imgListLegenda2.Images.SetKeyName(1, "Prog_Azul01.png")
        Me._imgListLegenda2.Images.SetKeyName(2, "Prog_Vermelho01.png")
        Me._imgListLegenda2.Images.SetKeyName(3, "Prog_Amarelo01.png")
        Me._imgListLegenda2.Images.SetKeyName(4, "Prog_Laranja01.png")
        Me._imgListLegenda2.Images.SetKeyName(5, "Prog_Branco.png")
        '
        'calCadInstrumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 567)
        Me.Controls.Add(Me.imgStatus)
        Me.Controls.Add(Me.C1InputPanel13)
        Me.Controls.Add(Me.Tab)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "calCadInstrumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instrumentos"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab.ResumeLayout(False)
        Me.Page1.ResumeLayout(False)
        CType(Me.txtArmazenamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photoFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inpultCad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Page2.ResumeLayout(False)
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCalibracoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Page3.ResumeLayout(False)
        CType(Me.gridHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Page4.ResumeLayout(False)
        Me.Page4.PerformLayout()
        CType(Me.picAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Erro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents Tab As C1.Win.C1Command.C1DockingTab
    Friend WithEvents Page1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents inpultCad As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupIdentificacao As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblNome As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNome As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblIdentificacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtIdentificacao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblTipoUso As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboTipoUso As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblTipoMedicao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboTipoMedicao As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents botAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblFaixaMedicao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtFaixaMedicao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblPrecisao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtPrecisao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblFabricante As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtFabricante As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblLocalGuarda As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtLocalGuarda As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblArmazenamento As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtArmazenamentoOutro As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblSituacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboSituacao As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents grupoResp As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblResp As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResp As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateData As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents Page2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents Page3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents gridHistorico As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents photoFoto As System.Windows.Forms.PictureBox
    Friend WithEvents lbl As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDataAquisicao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateAquisicao As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents gridCalibracoes As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents InputOption1 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputOption2 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputCalibrado As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputNaoCalibrado As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputCalibracaoVencida As C1.Win.C1InputPanel.InputOption
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Erro As C1.Win.C1SuperTooltip.C1SuperErrorProvider
    Friend WithEvents TooltipErro As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents txtArmazenamento As C1.Win.C1Input.C1TextBox
    Friend WithEvents botInserirFoto As C1.Win.C1Input.C1Button
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel13 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoInstrumentos As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblProjeto As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtInstrumento As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtIdent As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents imgStatus As System.Windows.Forms.PictureBox
    Friend WithEvents lblStatus As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSituacaoAtivo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents radioAtivo As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioInativo As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents Page4 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridAnexos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents picAnexo As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents barra1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblStatus1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents C1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader7 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botAnexos As C1.Win.C1InputPanel.InputButton
    Private WithEvents _imgListLegenda As System.Windows.Forms.ImageList
    Private WithEvents _imgListLegenda2 As System.Windows.Forms.ImageList
End Class
