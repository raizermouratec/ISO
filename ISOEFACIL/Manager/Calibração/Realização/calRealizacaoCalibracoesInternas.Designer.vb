<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calRealizacaoCalibracoesInternas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calRealizacaoCalibracoesInternas))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupCalibracaoInt = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblInstrumento = New C1.Win.C1InputPanel.InputLabel()
        Me.txtInstrumento = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblPadraoInt = New C1.Win.C1InputPanel.InputLabel()
        Me.comboPadraoInt = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblResultadoFinal = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResultadoFinal = New C1.Win.C1InputPanel.InputComboBox()
        Me.Opt1 = New C1.Win.C1InputPanel.InputOption()
        Me.Opt2 = New C1.Win.C1InputPanel.InputOption()
        Me.Opt3 = New C1.Win.C1InputPanel.InputOption()
        Me.lblObs = New C1.Win.C1InputPanel.InputLabel()
        Me.txtObsOutro = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblIdentificacao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtIdentificacao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dateData = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblValidade = New C1.Win.C1InputPanel.InputLabel()
        Me.dateValidade = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblResp = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResp = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblLaudo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtLaudo = New C1.Win.C1InputPanel.InputTextBox()
        Me.grupResultadosObt = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botAdd = New C1.Win.C1InputPanel.InputButton()
        Me.botRemove = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.botAnexos = New C1.Win.C1InputPanel.InputButton()
        Me.gridMedicao = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtObs = New C1.Win.C1Input.C1TextBox()
        Me._imgListLegenda = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.barra1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblStatus1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.picAnexo = New System.Windows.Forms.PictureBox()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMedicao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.picAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.grupCalibracaoInt)
        Me.C1InputPanel1.Items.Add(Me.lblInstrumento)
        Me.C1InputPanel1.Items.Add(Me.txtInstrumento)
        Me.C1InputPanel1.Items.Add(Me.lblPadraoInt)
        Me.C1InputPanel1.Items.Add(Me.comboPadraoInt)
        Me.C1InputPanel1.Items.Add(Me.lblResultadoFinal)
        Me.C1InputPanel1.Items.Add(Me.comboResultadoFinal)
        Me.C1InputPanel1.Items.Add(Me.lblObs)
        Me.C1InputPanel1.Items.Add(Me.txtObsOutro)
        Me.C1InputPanel1.Items.Add(Me.lblIdentificacao)
        Me.C1InputPanel1.Items.Add(Me.txtIdentificacao)
        Me.C1InputPanel1.Items.Add(Me.lblData)
        Me.C1InputPanel1.Items.Add(Me.dateData)
        Me.C1InputPanel1.Items.Add(Me.lblValidade)
        Me.C1InputPanel1.Items.Add(Me.dateValidade)
        Me.C1InputPanel1.Items.Add(Me.lblResp)
        Me.C1InputPanel1.Items.Add(Me.comboResp)
        Me.C1InputPanel1.Items.Add(Me.lblLaudo)
        Me.C1InputPanel1.Items.Add(Me.txtLaudo)
        Me.C1InputPanel1.Items.Add(Me.grupResultadosObt)
        Me.C1InputPanel1.Items.Add(Me.botAdd)
        Me.C1InputPanel1.Items.Add(Me.botRemove)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(700, 415)
        Me.C1InputPanel1.TabIndex = 0
        '
        'grupCalibracaoInt
        '
        Me.grupCalibracaoInt.Name = "grupCalibracaoInt"
        Me.grupCalibracaoInt.Text = "Realizar Calibração Interna"
        '
        'lblInstrumento
        '
        Me.lblInstrumento.Name = "lblInstrumento"
        Me.lblInstrumento.Padding = New System.Windows.Forms.Padding(0, 0, 16, 0)
        Me.lblInstrumento.Text = "Instrumento :"
        '
        'txtInstrumento
        '
        Me.txtInstrumento.Enabled = False
        Me.txtInstrumento.Name = "txtInstrumento"
        Me.txtInstrumento.Width = 250
        '
        'lblPadraoInt
        '
        Me.lblPadraoInt.Name = "lblPadraoInt"
        Me.lblPadraoInt.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblPadraoInt.Text = "Padrão Interno :"
        '
        'comboPadraoInt
        '
        Me.comboPadraoInt.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboPadraoInt.Name = "comboPadraoInt"
        Me.comboPadraoInt.Width = 250
        '
        'lblResultadoFinal
        '
        Me.lblResultadoFinal.Name = "lblResultadoFinal"
        Me.lblResultadoFinal.Padding = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.lblResultadoFinal.Text = "Resultado Final :"
        '
        'comboResultadoFinal
        '
        Me.comboResultadoFinal.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResultadoFinal.Items.Add(Me.Opt1)
        Me.comboResultadoFinal.Items.Add(Me.Opt2)
        Me.comboResultadoFinal.Items.Add(Me.Opt3)
        Me.comboResultadoFinal.Name = "comboResultadoFinal"
        Me.comboResultadoFinal.Width = 250
        '
        'Opt1
        '
        Me.Opt1.Name = "Opt1"
        Me.Opt1.Text = "Aprovado"
        '
        'Opt2
        '
        Me.Opt2.Name = "Opt2"
        Me.Opt2.Text = "Aprovado Parcialmente"
        '
        'Opt3
        '
        Me.Opt3.Name = "Opt3"
        Me.Opt3.Text = "Reprovado"
        '
        'lblObs
        '
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.lblObs.Text = "Observações :"
        '
        'txtObsOutro
        '
        Me.txtObsOutro.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtObsOutro.Height = 65
        Me.txtObsOutro.Multiline = True
        Me.txtObsOutro.Name = "txtObsOutro"
        Me.txtObsOutro.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtObsOutro.Width = 250
        '
        'lblIdentificacao
        '
        Me.lblIdentificacao.Name = "lblIdentificacao"
        Me.lblIdentificacao.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.lblIdentificacao.Text = "Identificação :"
        '
        'txtIdentificacao
        '
        Me.txtIdentificacao.Enabled = False
        Me.txtIdentificacao.Name = "txtIdentificacao"
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Text = "Data :"
        Me.lblData.Width = 80
        '
        'dateData
        '
        Me.dateData.Name = "dateData"
        '
        'lblValidade
        '
        Me.lblValidade.Name = "lblValidade"
        Me.lblValidade.Text = "Validade :"
        Me.lblValidade.Width = 80
        '
        'dateValidade
        '
        Me.dateValidade.Name = "dateValidade"
        '
        'lblResp
        '
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Text = "Responsável :"
        Me.lblResp.Width = 80
        '
        'comboResp
        '
        Me.comboResp.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResp.Name = "comboResp"
        Me.comboResp.Width = 250
        '
        'lblLaudo
        '
        Me.lblLaudo.Name = "lblLaudo"
        Me.lblLaudo.Text = "Laudo :"
        Me.lblLaudo.Width = 79
        '
        'txtLaudo
        '
        Me.txtLaudo.Name = "txtLaudo"
        Me.txtLaudo.Width = 250
        '
        'grupResultadosObt
        '
        Me.grupResultadosObt.Name = "grupResultadosObt"
        Me.grupResultadosObt.Text = "Resultados Obtidos"
        '
        'botAdd
        '
        Me.botAdd.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botAdd.Image = CType(resources.GetObject("botAdd.Image"), System.Drawing.Image)
        Me.botAdd.ImageSize = New System.Drawing.Size(20, 20)
        Me.botAdd.Name = "botAdd"
        Me.botAdd.Text = "Adicionar"
        '
        'botRemove
        '
        Me.botRemove.Image = CType(resources.GetObject("botRemove.Image"), System.Drawing.Image)
        Me.botRemove.ImageSize = New System.Drawing.Size(20, 20)
        Me.botRemove.Name = "botRemove"
        Me.botRemove.Text = "Remover"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Items.Add(Me.botAnexos)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 418)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(700, 64)
        Me.C1InputPanel2.TabIndex = 4
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
        'botAnexos
        '
        Me.botAnexos.Image = CType(resources.GetObject("botAnexos.Image"), System.Drawing.Image)
        Me.botAnexos.ImageSize = New System.Drawing.Size(20, 20)
        Me.botAnexos.Name = "botAnexos"
        Me.botAnexos.Text = "Anexos"
        Me.botAnexos.Width = 70
        '
        'gridMedicao
        '
        Me.gridMedicao.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridMedicao.AllowEditing = False
        Me.gridMedicao.AllowFiltering = True
        Me.gridMedicao.ColumnInfo = resources.GetString("gridMedicao.ColumnInfo")
        Me.gridMedicao.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridMedicao.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridMedicao.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.gridMedicao.Location = New System.Drawing.Point(0, 228)
        Me.gridMedicao.Name = "gridMedicao"
        Me.gridMedicao.Rows.DefaultSize = 21
        Me.gridMedicao.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridMedicao.ShowSortPosition = C1.Win.C1FlexGrid.ShowSortPositionEnum.None
        Me.gridMedicao.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridMedicao.Size = New System.Drawing.Size(700, 189)
        Me.gridMedicao.StyleInfo = resources.GetString("gridMedicao.StyleInfo")
        Me.gridMedicao.TabIndex = 0
        Me.gridMedicao.TabStop = False
        '
        'txtObs
        '
        Me.txtObs.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.Location = New System.Drawing.Point(102, 104)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(250, 65)
        Me.txtObs.TabIndex = 6
        Me.txtObs.Tag = Nothing
        Me.txtObs.TextDetached = True
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
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.barra1, Me.lblStatus1})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StatusStrip1.Location = New System.Drawing.Point(360, 463)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(340, 19)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        Me.StatusStrip1.Visible = False
        '
        'barra1
        '
        Me.barra1.Name = "barra1"
        Me.barra1.Size = New System.Drawing.Size(100, 13)
        '
        'lblStatus1
        '
        Me.lblStatus1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.lblStatus1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(0, 14)
        '
        'picAnexo
        '
        Me.picAnexo.Location = New System.Drawing.Point(672, 460)
        Me.picAnexo.Name = "picAnexo"
        Me.picAnexo.Size = New System.Drawing.Size(28, 22)
        Me.picAnexo.TabIndex = 18
        Me.picAnexo.TabStop = False
        Me.picAnexo.Visible = False
        '
        'calRealizacaoCalibracoesInternas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 481)
        Me.Controls.Add(Me.picAnexo)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.gridMedicao)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "calRealizacaoCalibracoesInternas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realização de Calibração Interna"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMedicao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.picAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents grupCalibracaoInt As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblInstrumento As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtInstrumento As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblPadraoInt As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboPadraoInt As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblResultadoFinal As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResultadoFinal As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblObs As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtObsOutro As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblIdentificacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtIdentificacao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateData As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblValidade As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateValidade As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblResp As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResp As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblLaudo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtLaudo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents grupResultadosObt As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botRemove As C1.Win.C1InputPanel.InputButton
    Friend WithEvents gridMedicao As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents botAnexos As C1.Win.C1InputPanel.InputButton
    Friend WithEvents Opt1 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents Opt2 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents Opt3 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents txtObs As C1.Win.C1Input.C1TextBox
    Private WithEvents _imgListLegenda As System.Windows.Forms.ImageList
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents barra1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblStatus1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents picAnexo As System.Windows.Forms.PictureBox
End Class
