<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acCadAnaliseDados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acCadAnaliseDados))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.tabregistro = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtObejtivos = New C1.Win.C1Input.C1TextBox()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupRegistrar = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblIdentificacao = New C1.Win.C1InputPanel.InputLabel()
        Me.radioData = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioRelatorio = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioOutro = New C1.Win.C1InputPanel.InputRadioButton()
        Me.txtOutro = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblObjetivos = New C1.Win.C1InputPanel.InputLabel()
        Me.txtxObejtivos = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblPeriodoRef = New C1.Win.C1InputPanel.InputLabel()
        Me.dateInicio = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lbla = New C1.Win.C1InputPanel.InputLabel()
        Me.dateTermino = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblResp = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResp = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblDataElab = New C1.Win.C1InputPanel.InputLabel()
        Me.dateElab = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAnalisadoem = New C1.Win.C1InputPanel.InputLabel()
        Me.dateAnalisadoem = New C1.Win.C1InputPanel.InputDatePicker()
        Me.tabconteudo = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botAdicionar = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluirConteudo = New C1.Win.C1InputPanel.InputButton()
        Me.gridConteudo = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.tabregistro.SuspendLayout()
        CType(Me.txtObejtivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabconteudo.SuspendLayout()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridConteudo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Location = New System.Drawing.Point(4, 280)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(618, 64)
        Me.C1InputPanel2.TabIndex = 2
        '
        'grupoOpcoes
        '
        Me.grupoOpcoes.Name = "grupoOpcoes"
        Me.grupoOpcoes.Text = "Opções"
        '
        'botSalvar
        '
        Me.botSalvar.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botSalvar.Image = CType(resources.GetObject("botSalvar.Image"), System.Drawing.Image)
        Me.botSalvar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvar.Name = "botSalvar"
        Me.botSalvar.Text = "Salvar"
        Me.botSalvar.Width = 70
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.tabregistro)
        Me.C1DockingTab1.Controls.Add(Me.tabconteudo)
        Me.C1DockingTab1.Location = New System.Drawing.Point(2, 6)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedIndex = 1
        Me.C1DockingTab1.Size = New System.Drawing.Size(629, 377)
        Me.C1DockingTab1.TabIndex = 3
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'tabregistro
        '
        Me.tabregistro.Controls.Add(Me.txtObejtivos)
        Me.tabregistro.Controls.Add(Me.C1InputPanel2)
        Me.tabregistro.Controls.Add(Me.C1InputPanel3)
        Me.tabregistro.Location = New System.Drawing.Point(1, 26)
        Me.tabregistro.Name = "tabregistro"
        Me.tabregistro.Size = New System.Drawing.Size(627, 350)
        Me.tabregistro.TabIndex = 0
        Me.tabregistro.Text = "Registrar"
        '
        'txtObejtivos
        '
        Me.txtObejtivos.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtObejtivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObejtivos.Location = New System.Drawing.Point(169, 58)
        Me.txtObejtivos.Multiline = True
        Me.txtObejtivos.Name = "txtObejtivos"
        Me.txtObejtivos.Size = New System.Drawing.Size(434, 120)
        Me.txtObejtivos.TabIndex = 1
        Me.txtObejtivos.Tag = Nothing
        Me.txtObejtivos.TextDetached = True
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.grupRegistrar)
        Me.C1InputPanel3.Items.Add(Me.lblIdentificacao)
        Me.C1InputPanel3.Items.Add(Me.radioData)
        Me.C1InputPanel3.Items.Add(Me.radioRelatorio)
        Me.C1InputPanel3.Items.Add(Me.radioOutro)
        Me.C1InputPanel3.Items.Add(Me.txtOutro)
        Me.C1InputPanel3.Items.Add(Me.lblObjetivos)
        Me.C1InputPanel3.Items.Add(Me.txtxObejtivos)
        Me.C1InputPanel3.Items.Add(Me.lblPeriodoRef)
        Me.C1InputPanel3.Items.Add(Me.dateInicio)
        Me.C1InputPanel3.Items.Add(Me.lbla)
        Me.C1InputPanel3.Items.Add(Me.dateTermino)
        Me.C1InputPanel3.Items.Add(Me.lblResp)
        Me.C1InputPanel3.Items.Add(Me.comboResp)
        Me.C1InputPanel3.Items.Add(Me.lblDataElab)
        Me.C1InputPanel3.Items.Add(Me.dateElab)
        Me.C1InputPanel3.Items.Add(Me.InputLabel1)
        Me.C1InputPanel3.Items.Add(Me.lblAnalisadoem)
        Me.C1InputPanel3.Items.Add(Me.dateAnalisadoem)
        Me.C1InputPanel3.Location = New System.Drawing.Point(5, 6)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(617, 268)
        Me.C1InputPanel3.TabIndex = 0
        Me.C1InputPanel3.ToolTipSettings.Images.Add(New C1.Win.C1InputPanel.ImageEntry("Help_16x16.png", CType(resources.GetObject("C1InputPanel3.ToolTipSettings.Images"), System.Drawing.Image)))
        '
        'grupRegistrar
        '
        Me.grupRegistrar.Name = "grupRegistrar"
        Me.grupRegistrar.Text = "Registro de Relatório de Dados"
        '
        'lblIdentificacao
        '
        Me.lblIdentificacao.ElementWidth = 150
        Me.lblIdentificacao.Name = "lblIdentificacao"
        Me.lblIdentificacao.Text = "Identificação de Relatório : "
        '
        'radioData
        '
        Me.radioData.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioData.ElementWidth = 100
        Me.radioData.Name = "radioData"
        Me.radioData.Text = "nº/ano"
        Me.radioData.ToolTipText = resources.GetString("radioData.ToolTipText")
        '
        'radioRelatorio
        '
        Me.radioRelatorio.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioRelatorio.ElementWidth = 100
        Me.radioRelatorio.Name = "radioRelatorio"
        Me.radioRelatorio.Text = "Relatório nº"
        Me.radioRelatorio.ToolTipText = resources.GetString("radioRelatorio.ToolTipText")
        '
        'radioOutro
        '
        Me.radioOutro.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioOutro.ElementWidth = 110
        Me.radioOutro.Name = "radioOutro"
        Me.radioOutro.Text = "Outro"
        '
        'txtOutro
        '
        Me.txtOutro.Name = "txtOutro"
        '
        'lblObjetivos
        '
        Me.lblObjetivos.ElementWidth = 150
        Me.lblObjetivos.Name = "lblObjetivos"
        Me.lblObjetivos.Text = "Objetivos :"
        '
        'txtxObejtivos
        '
        Me.txtxObejtivos.Height = 120
        Me.txtxObejtivos.Multiline = True
        Me.txtxObejtivos.Name = "txtxObejtivos"
        Me.txtxObejtivos.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtxObejtivos.Width = 434
        '
        'lblPeriodoRef
        '
        Me.lblPeriodoRef.ElementWidth = 150
        Me.lblPeriodoRef.Name = "lblPeriodoRef"
        Me.lblPeriodoRef.Text = "Período de Referência :"
        '
        'dateInicio
        '
        Me.dateInicio.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dateInicio.Name = "dateInicio"
        '
        'lbla
        '
        Me.lbla.Name = "lbla"
        Me.lbla.Text = "à"
        '
        'dateTermino
        '
        Me.dateTermino.Name = "dateTermino"
        '
        'lblResp
        '
        Me.lblResp.ElementWidth = 150
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Text = "Responsável :"
        '
        'comboResp
        '
        Me.comboResp.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResp.Name = "comboResp"
        Me.comboResp.Width = 435
        '
        'lblDataElab
        '
        Me.lblDataElab.ElementWidth = 150
        Me.lblDataElab.Name = "lblDataElab"
        Me.lblDataElab.Text = "Data da Elaboração :"
        '
        'dateElab
        '
        Me.dateElab.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dateElab.Name = "dateElab"
        '
        'InputLabel1
        '
        Me.InputLabel1.ElementWidth = 123
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "   "
        '
        'lblAnalisadoem
        '
        Me.lblAnalisadoem.ElementWidth = 100
        Me.lblAnalisadoem.Name = "lblAnalisadoem"
        Me.lblAnalisadoem.Text = "Analisado em :"
        '
        'dateAnalisadoem
        '
        Me.dateAnalisadoem.Name = "dateAnalisadoem"
        '
        'tabconteudo
        '
        Me.tabconteudo.Controls.Add(Me.C1InputPanel4)
        Me.tabconteudo.Controls.Add(Me.gridConteudo)
        Me.tabconteudo.Controls.Add(Me.C1InputPanel1)
        Me.tabconteudo.Enabled = False
        Me.tabconteudo.Location = New System.Drawing.Point(1, 26)
        Me.tabconteudo.Name = "tabconteudo"
        Me.tabconteudo.Size = New System.Drawing.Size(627, 350)
        Me.tabconteudo.TabIndex = 1
        Me.tabconteudo.Text = "Conteúdo"
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel4.Items.Add(Me.botAdicionar)
        Me.C1InputPanel4.Items.Add(Me.botEditar)
        Me.C1InputPanel4.Items.Add(Me.botExcluirConteudo)
        Me.C1InputPanel4.Location = New System.Drawing.Point(5, 281)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(618, 64)
        Me.C1InputPanel4.TabIndex = 3
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
        '
        'botAdicionar
        '
        Me.botAdicionar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botAdicionar.Image = CType(resources.GetObject("botAdicionar.Image"), System.Drawing.Image)
        Me.botAdicionar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botAdicionar.Name = "botAdicionar"
        Me.botAdicionar.Text = "Adicionar"
        Me.botAdicionar.Width = 86
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
        'botExcluirConteudo
        '
        Me.botExcluirConteudo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botExcluirConteudo.Image = CType(resources.GetObject("botExcluirConteudo.Image"), System.Drawing.Image)
        Me.botExcluirConteudo.ImageSize = New System.Drawing.Size(20, 20)
        Me.botExcluirConteudo.Name = "botExcluirConteudo"
        Me.botExcluirConteudo.Text = "Excluir"
        Me.botExcluirConteudo.Width = 70
        '
        'gridConteudo
        '
        Me.gridConteudo.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridConteudo.AllowEditing = False
        Me.gridConteudo.AllowFiltering = True
        Me.gridConteudo.ColumnInfo = "3,1,0,0,0,105,Columns:0{Width:0;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:50;Name:""COD_ITEM"";Caption:""Número"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2" & _
    "{Width:510;Name:""ITEM"";Caption:""Conteúdo"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.gridConteudo.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridConteudo.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridConteudo.Location = New System.Drawing.Point(9, 10)
        Me.gridConteudo.Name = "gridConteudo"
        Me.gridConteudo.Rows.DefaultSize = 21
        Me.gridConteudo.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridConteudo.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridConteudo.Size = New System.Drawing.Size(610, 256)
        Me.gridConteudo.StyleInfo = resources.GetString("gridConteudo.StyleInfo")
        Me.gridConteudo.TabIndex = 1
        Me.gridConteudo.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Location = New System.Drawing.Point(5, 6)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(619, 270)
        Me.C1InputPanel1.TabIndex = 0
        '
        'acCadAnaliseDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 383)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "acCadAnaliseDados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análise de Dados"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.tabregistro.ResumeLayout(False)
        CType(Me.txtObejtivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabconteudo.ResumeLayout(False)
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridConteudo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents tabregistro As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents tabconteudo As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents gridConteudo As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupRegistrar As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblIdentificacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents radioData As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioRelatorio As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioOutro As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents txtOutro As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblObjetivos As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtxObejtivos As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblPeriodoRef As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateInicio As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lbla As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateTermino As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblResp As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResp As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblDataElab As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateElab As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblAnalisadoem As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateAnalisadoem As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtObejtivos As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botAdicionar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluirConteudo As C1.Win.C1InputPanel.InputButton
End Class
