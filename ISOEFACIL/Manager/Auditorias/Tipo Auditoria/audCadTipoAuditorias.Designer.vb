<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class audCadTipoAuditorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(audCadTipoAuditorias))
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.radioSim = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioNao = New C1.Win.C1InputPanel.InputRadioButton()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.TabCadastro = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoIdentificacao = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblTipoAuditoria = New C1.Win.C1InputPanel.InputLabel()
        Me.comboTipoAud = New C1.Win.C1InputPanel.InputComboBox()
        Me.botaddNovoTipo = New C1.Win.C1InputPanel.InputButton()
        Me.botNovoTipo = New C1.Win.C1InputPanel.InputButton()
        Me.txtTipoNovo = New C1.Win.C1InputPanel.InputTextBox()
        Me.grupoFormaVerifica = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.radioAtendeSN = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioAtendeAPN = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioPorcento = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioNota = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioDados = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioTexto = New C1.Win.C1InputPanel.InputRadioButton()
        Me.grupoEvidencia = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblEvidencia = New C1.Win.C1InputPanel.InputLabel()
        Me.h = New C1.Win.C1InputPanel.InputLabel()
        Me.radioSim2 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioNao2 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblFormatoListaVerifica = New C1.Win.C1InputPanel.InputLabel()
        Me.h1 = New C1.Win.C1InputPanel.InputLabel()
        Me.radioRetrato = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioPaisagem = New C1.Win.C1InputPanel.InputRadioButton()
        Me.lblDataCadastro = New C1.Win.C1InputPanel.InputLabel()
        Me.dateCadastro = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblResponsavelCadastro = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResponsavelCadastro = New C1.Win.C1InputPanel.InputComboBox()
        Me.TabAnexos = New C1.Win.C1Command.C1DockingTabPage()
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
        Me.barra = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me._imgListLegenda = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.TabCadastro.SuspendLayout()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAnexos.SuspendLayout()
        CType(Me.picAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.radioSim)
        Me.C1InputPanel3.Items.Add(Me.radioNao)
        Me.C1InputPanel3.Location = New System.Drawing.Point(175, 280)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(236, 24)
        Me.C1InputPanel3.TabIndex = 27
        '
        'radioSim
        '
        Me.radioSim.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioSim.Height = 20
        Me.radioSim.Name = "radioSim"
        Me.radioSim.Text = "Sim"
        Me.radioSim.Width = 54
        '
        'radioNao
        '
        Me.radioNao.Name = "radioNao"
        Me.radioNao.Text = "Não"
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.TabCadastro)
        Me.C1DockingTab1.Controls.Add(Me.TabAnexos)
        Me.C1DockingTab1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 0)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedIndex = 1
        Me.C1DockingTab1.Size = New System.Drawing.Size(630, 465)
        Me.C1DockingTab1.TabIndex = 28
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'TabCadastro
        '
        Me.TabCadastro.Controls.Add(Me.C1InputPanel2)
        Me.TabCadastro.Controls.Add(Me.C1InputPanel1)
        Me.TabCadastro.Location = New System.Drawing.Point(1, 26)
        Me.TabCadastro.Name = "TabCadastro"
        Me.TabCadastro.Size = New System.Drawing.Size(628, 438)
        Me.TabCadastro.TabIndex = 0
        Me.TabCadastro.Text = "Cadastro"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Location = New System.Drawing.Point(3, 376)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(622, 59)
        Me.C1InputPanel2.TabIndex = 28
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
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
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.grupoIdentificacao)
        Me.C1InputPanel1.Items.Add(Me.lblTipoAuditoria)
        Me.C1InputPanel1.Items.Add(Me.comboTipoAud)
        Me.C1InputPanel1.Items.Add(Me.botaddNovoTipo)
        Me.C1InputPanel1.Items.Add(Me.botNovoTipo)
        Me.C1InputPanel1.Items.Add(Me.txtTipoNovo)
        Me.C1InputPanel1.Items.Add(Me.grupoFormaVerifica)
        Me.C1InputPanel1.Items.Add(Me.radioAtendeSN)
        Me.C1InputPanel1.Items.Add(Me.radioAtendeAPN)
        Me.C1InputPanel1.Items.Add(Me.radioPorcento)
        Me.C1InputPanel1.Items.Add(Me.radioNota)
        Me.C1InputPanel1.Items.Add(Me.radioDados)
        Me.C1InputPanel1.Items.Add(Me.radioTexto)
        Me.C1InputPanel1.Items.Add(Me.grupoEvidencia)
        Me.C1InputPanel1.Items.Add(Me.lblEvidencia)
        Me.C1InputPanel1.Items.Add(Me.h)
        Me.C1InputPanel1.Items.Add(Me.radioSim2)
        Me.C1InputPanel1.Items.Add(Me.radioNao2)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.lblFormatoListaVerifica)
        Me.C1InputPanel1.Items.Add(Me.h1)
        Me.C1InputPanel1.Items.Add(Me.radioRetrato)
        Me.C1InputPanel1.Items.Add(Me.radioPaisagem)
        Me.C1InputPanel1.Items.Add(Me.lblDataCadastro)
        Me.C1InputPanel1.Items.Add(Me.dateCadastro)
        Me.C1InputPanel1.Items.Add(Me.lblResponsavelCadastro)
        Me.C1InputPanel1.Items.Add(Me.comboResponsavelCadastro)
        Me.C1InputPanel1.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(622, 371)
        Me.C1InputPanel1.TabIndex = 27
        Me.C1InputPanel1.ToolTipSettings.Images.Add(New C1.Win.C1InputPanel.ImageEntry("add.png", CType(resources.GetObject("C1InputPanel1.ToolTipSettings.Images"), System.Drawing.Image)))
        Me.C1InputPanel1.ToolTipSettings.Images.Add(New C1.Win.C1InputPanel.ImageEntry("Alterar_32x32.png", CType(resources.GetObject("C1InputPanel1.ToolTipSettings.Images1"), System.Drawing.Image)))
        Me.C1InputPanel1.ToolTipSettings.Images.Add(New C1.Win.C1InputPanel.ImageEntry("add_32x32.png", CType(resources.GetObject("C1InputPanel1.ToolTipSettings.Images2"), System.Drawing.Image)))
        Me.C1InputPanel1.ToolTipSettings.Images.Add(New C1.Win.C1InputPanel.ImageEntry("Add_16x16.png", CType(resources.GetObject("C1InputPanel1.ToolTipSettings.Images3"), System.Drawing.Image)))
        '
        'grupoIdentificacao
        '
        Me.grupoIdentificacao.Name = "grupoIdentificacao"
        Me.grupoIdentificacao.Text = "Identificação"
        '
        'lblTipoAuditoria
        '
        Me.lblTipoAuditoria.Name = "lblTipoAuditoria"
        Me.lblTipoAuditoria.Text = "Tipo da Auditoria"
        Me.lblTipoAuditoria.Width = 90
        '
        'comboTipoAud
        '
        Me.comboTipoAud.Break = C1.Win.C1InputPanel.BreakType.None
        Me.comboTipoAud.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboTipoAud.Name = "comboTipoAud"
        Me.comboTipoAud.Width = 480
        '
        'botaddNovoTipo
        '
        Me.botaddNovoTipo.Image = CType(resources.GetObject("botaddNovoTipo.Image"), System.Drawing.Image)
        Me.botaddNovoTipo.ImageSize = New System.Drawing.Size(15, 15)
        Me.botaddNovoTipo.Name = "botaddNovoTipo"
        Me.botaddNovoTipo.ToolTipText = resources.GetString("botaddNovoTipo.ToolTipText")
        '
        'botNovoTipo
        '
        Me.botNovoTipo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botNovoTipo.Image = CType(resources.GetObject("botNovoTipo.Image"), System.Drawing.Image)
        Me.botNovoTipo.ImageAlign = C1.Win.C1InputPanel.InputImageAlignment.BottomCenter
        Me.botNovoTipo.ImageSize = New System.Drawing.Size(16, 16)
        Me.botNovoTipo.Name = "botNovoTipo"
        Me.botNovoTipo.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.botNovoTipo.Text = "Adicionar"
        Me.botNovoTipo.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.botNovoTipo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.botNovoTipo.Width = 90
        '
        'txtTipoNovo
        '
        Me.txtTipoNovo.Name = "txtTipoNovo"
        Me.txtTipoNovo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.txtTipoNovo.Width = 318
        '
        'grupoFormaVerifica
        '
        Me.grupoFormaVerifica.Name = "grupoFormaVerifica"
        Me.grupoFormaVerifica.Text = "Forma de Verificação"
        '
        'radioAtendeSN
        '
        Me.radioAtendeSN.Name = "radioAtendeSN"
        Me.radioAtendeSN.Text = "Atende ou não? Sim ou Não"
        '
        'radioAtendeAPN
        '
        Me.radioAtendeAPN.Name = "radioAtendeAPN"
        Me.radioAtendeAPN.Text = "Atende/ parcial / não atende"
        '
        'radioPorcento
        '
        Me.radioPorcento.Name = "radioPorcento"
        Me.radioPorcento.Text = "% de atendimento – 0 a 100%"
        '
        'radioNota
        '
        Me.radioNota.Name = "radioNota"
        Me.radioNota.Text = "Nota de 0 a ___"
        '
        'radioDados
        '
        Me.radioDados.Name = "radioDados"
        Me.radioDados.Text = "Dado numérico a ser registrado e comparado com o valor do critério: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Valor esper" & _
    "ado – Valor apontado – Diferença"
        Me.radioDados.Width = 567
        '
        'radioTexto
        '
        Me.radioTexto.Name = "radioTexto"
        Me.radioTexto.Text = "Resultado textual – a ser digitado pelo avaliador"
        '
        'grupoEvidencia
        '
        Me.grupoEvidencia.Height = 20
        Me.grupoEvidencia.Name = "grupoEvidencia"
        Me.grupoEvidencia.Text = "Evidência"
        '
        'lblEvidencia
        '
        Me.lblEvidencia.Name = "lblEvidencia"
        Me.lblEvidencia.Text = "Campo para Evidências"
        Me.lblEvidencia.Width = 163
        '
        'h
        '
        Me.h.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.h.ElementHeight = 20
        Me.h.Name = "h"
        '
        'radioSim2
        '
        Me.radioSim2.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.radioSim2.Name = "radioSim2"
        Me.radioSim2.Text = "Sim"
        Me.radioSim2.Width = 61
        '
        'radioNao2
        '
        Me.radioNao2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioNao2.Name = "radioNao2"
        Me.radioNao2.Text = "Não"
        Me.radioNao2.Width = 59
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Formato"
        '
        'lblFormatoListaVerifica
        '
        Me.lblFormatoListaVerifica.Name = "lblFormatoListaVerifica"
        Me.lblFormatoListaVerifica.Text = "Formato da Lista de Verificação"
        Me.lblFormatoListaVerifica.Width = 162
        '
        'h1
        '
        Me.h1.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.h1.Name = "h1"
        '
        'radioRetrato
        '
        Me.radioRetrato.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.radioRetrato.Height = 17
        Me.radioRetrato.Name = "radioRetrato"
        Me.radioRetrato.Text = "Retrato"
        Me.radioRetrato.Width = 62
        '
        'radioPaisagem
        '
        Me.radioPaisagem.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.radioPaisagem.Name = "radioPaisagem"
        Me.radioPaisagem.Text = "Paisagem"
        '
        'lblDataCadastro
        '
        Me.lblDataCadastro.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblDataCadastro.Name = "lblDataCadastro"
        Me.lblDataCadastro.Text = "Data do Cadastro"
        Me.lblDataCadastro.Width = 163
        '
        'dateCadastro
        '
        Me.dateCadastro.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.dateCadastro.Height = 24
        Me.dateCadastro.Name = "dateCadastro"
        Me.dateCadastro.Width = 125
        '
        'lblResponsavelCadastro
        '
        Me.lblResponsavelCadastro.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblResponsavelCadastro.Name = "lblResponsavelCadastro"
        Me.lblResponsavelCadastro.Text = "Responsável pelo Cadastro"
        Me.lblResponsavelCadastro.Width = 163
        '
        'comboResponsavelCadastro
        '
        Me.comboResponsavelCadastro.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.comboResponsavelCadastro.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResponsavelCadastro.Name = "comboResponsavelCadastro"
        Me.comboResponsavelCadastro.Width = 308
        '
        'TabAnexos
        '
        Me.TabAnexos.Controls.Add(Me.picAnexo)
        Me.TabAnexos.Controls.Add(Me.StatusStrip1)
        Me.TabAnexos.Controls.Add(Me.C1InputPanel7)
        Me.TabAnexos.Controls.Add(Me.gridAnexos)
        Me.TabAnexos.Controls.Add(Me.C1InputPanel6)
        Me.TabAnexos.Enabled = False
        Me.TabAnexos.Location = New System.Drawing.Point(1, 26)
        Me.TabAnexos.Name = "TabAnexos"
        Me.TabAnexos.Size = New System.Drawing.Size(628, 438)
        Me.TabAnexos.TabIndex = 1
        Me.TabAnexos.Text = "Anexos"
        '
        'picAnexo
        '
        Me.picAnexo.Location = New System.Drawing.Point(597, 391)
        Me.picAnexo.Name = "picAnexo"
        Me.picAnexo.Size = New System.Drawing.Size(28, 22)
        Me.picAnexo.TabIndex = 13
        Me.picAnexo.TabStop = False
        Me.picAnexo.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.barra1, Me.lblStatus1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 416)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(628, 22)
        Me.StatusStrip1.TabIndex = 12
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
        Me.C1InputPanel7.Location = New System.Drawing.Point(6, 359)
        Me.C1InputPanel7.Name = "C1InputPanel7"
        Me.C1InputPanel7.Size = New System.Drawing.Size(619, 59)
        Me.C1InputPanel7.TabIndex = 11
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
        Me.gridAnexos.AllowEditing = False
        Me.gridAnexos.ColumnInfo = resources.GetString("gridAnexos.ColumnInfo")
        Me.gridAnexos.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridAnexos.Location = New System.Drawing.Point(6, 28)
        Me.gridAnexos.Name = "gridAnexos"
        Me.gridAnexos.Rows.DefaultSize = 21
        Me.gridAnexos.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridAnexos.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridAnexos.Size = New System.Drawing.Size(619, 336)
        Me.gridAnexos.StyleInfo = resources.GetString("gridAnexos.StyleInfo")
        Me.gridAnexos.TabIndex = 10
        Me.gridAnexos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel6.Location = New System.Drawing.Point(6, 3)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(619, 361)
        Me.C1InputPanel6.TabIndex = 14
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "Lista de Anexos"
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
        'audCadTipoAuditorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 468)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "audCadTipoAuditorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Tipo Auditoria"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.TabCadastro.ResumeLayout(False)
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAnexos.ResumeLayout(False)
        Me.TabAnexos.PerformLayout()
        CType(Me.picAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents radioSim As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioNao As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents TabCadastro As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoIdentificacao As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblTipoAuditoria As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboTipoAud As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents botaddNovoTipo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botNovoTipo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtTipoNovo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents grupoFormaVerifica As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents radioAtendeSN As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioAtendeAPN As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioPorcento As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioNota As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioDados As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioTexto As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents lblEvidencia As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents h As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents radioNao2 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents lblFormatoListaVerifica As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents radioRetrato As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioPaisagem As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents lblDataCadastro As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateCadastro As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblResponsavelCadastro As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResponsavelCadastro As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents TabAnexos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents barra As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents C1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader7 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botAnexos As C1.Win.C1InputPanel.InputButton
    Friend WithEvents gridAnexos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents grupoEvidencia As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents radioSim2 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents h1 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents _imgListLegenda As System.Windows.Forms.ImageList
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents barra1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblStatus1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents picAnexo As System.Windows.Forms.PictureBox
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
End Class
