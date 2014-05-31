<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projCadRisco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projCadRisco))
        Me.InputRisco = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoRisco = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblDesc = New C1.Win.C1InputPanel.InputLabel()
        Me.txtDescx = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblImpacto = New C1.Win.C1InputPanel.InputLabel()
        Me.txtImpactox = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblConsequencias = New C1.Win.C1InputPanel.InputLabel()
        Me.txtConsequenciasx = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblProbabilidade = New C1.Win.C1InputPanel.InputLabel()
        Me.comboProbabilidade = New C1.Win.C1InputPanel.InputComboBox()
        Me.opP1 = New C1.Win.C1InputPanel.InputOption()
        Me.opP2 = New C1.Win.C1InputPanel.InputOption()
        Me.opP3 = New C1.Win.C1InputPanel.InputOption()
        Me.opP4 = New C1.Win.C1InputPanel.InputOption()
        Me.opP5 = New C1.Win.C1InputPanel.InputOption()
        Me.lblSeveridade = New C1.Win.C1InputPanel.InputLabel()
        Me.comboSeveridade = New C1.Win.C1InputPanel.InputComboBox()
        Me.opS1 = New C1.Win.C1InputPanel.InputOption()
        Me.opS2 = New C1.Win.C1InputPanel.InputOption()
        Me.opS3 = New C1.Win.C1InputPanel.InputOption()
        Me.opS4 = New C1.Win.C1InputPanel.InputOption()
        Me.opS5 = New C1.Win.C1InputPanel.InputOption()
        Me.lblAcaoTomada = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAcaoTomadax = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblResp = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResp = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblPrazo = New C1.Win.C1InputPanel.InputLabel()
        Me.datePrazo = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblAcompanhamento = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAcompanhamentox = New C1.Win.C1InputPanel.InputTextBox()
        Me.grupOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarRisco = New C1.Win.C1InputPanel.InputButton()
        Me.txtAcompanhamento = New C1.Win.C1Input.C1TextBox()
        Me.txtAcaoTomada = New C1.Win.C1Input.C1TextBox()
        Me.txtConsequencias = New C1.Win.C1Input.C1TextBox()
        Me.txtImpacto = New C1.Win.C1Input.C1TextBox()
        Me.txtDesc = New C1.Win.C1Input.C1TextBox()
        CType(Me.InputRisco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAcompanhamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAcaoTomada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConsequencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputRisco
        '
        Me.InputRisco.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InputRisco.Items.Add(Me.grupoRisco)
        Me.InputRisco.Items.Add(Me.lblDesc)
        Me.InputRisco.Items.Add(Me.txtDescx)
        Me.InputRisco.Items.Add(Me.lblImpacto)
        Me.InputRisco.Items.Add(Me.txtImpactox)
        Me.InputRisco.Items.Add(Me.lblConsequencias)
        Me.InputRisco.Items.Add(Me.txtConsequenciasx)
        Me.InputRisco.Items.Add(Me.lblProbabilidade)
        Me.InputRisco.Items.Add(Me.comboProbabilidade)
        Me.InputRisco.Items.Add(Me.lblSeveridade)
        Me.InputRisco.Items.Add(Me.comboSeveridade)
        Me.InputRisco.Items.Add(Me.lblAcaoTomada)
        Me.InputRisco.Items.Add(Me.txtAcaoTomadax)
        Me.InputRisco.Items.Add(Me.lblResp)
        Me.InputRisco.Items.Add(Me.comboResp)
        Me.InputRisco.Items.Add(Me.lblPrazo)
        Me.InputRisco.Items.Add(Me.datePrazo)
        Me.InputRisco.Items.Add(Me.lblAcompanhamento)
        Me.InputRisco.Items.Add(Me.txtAcompanhamentox)
        Me.InputRisco.Items.Add(Me.grupOpcoes)
        Me.InputRisco.Items.Add(Me.botSalvarRisco)
        Me.InputRisco.Location = New System.Drawing.Point(1, 3)
        Me.InputRisco.Name = "InputRisco"
        Me.InputRisco.Size = New System.Drawing.Size(567, 325)
        Me.InputRisco.TabIndex = 2
        '
        'grupoRisco
        '
        Me.grupoRisco.Name = "grupoRisco"
        Me.grupoRisco.Text = "Análise de Riscos"
        '
        'lblDesc
        '
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Text = "Descrição:"
        Me.lblDesc.Width = 103
        '
        'txtDescx
        '
        Me.txtDescx.Height = 35
        Me.txtDescx.Multiline = True
        Me.txtDescx.Name = "txtDescx"
        Me.txtDescx.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtDescx.Width = 443
        '
        'lblImpacto
        '
        Me.lblImpacto.Name = "lblImpacto"
        Me.lblImpacto.Text = "Impacto:"
        Me.lblImpacto.Width = 103
        '
        'txtImpactox
        '
        Me.txtImpactox.Height = 35
        Me.txtImpactox.Multiline = True
        Me.txtImpactox.Name = "txtImpactox"
        Me.txtImpactox.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtImpactox.Width = 443
        '
        'lblConsequencias
        '
        Me.lblConsequencias.Name = "lblConsequencias"
        Me.lblConsequencias.Text = "Consequências:"
        Me.lblConsequencias.Width = 103
        '
        'txtConsequenciasx
        '
        Me.txtConsequenciasx.Height = 35
        Me.txtConsequenciasx.Multiline = True
        Me.txtConsequenciasx.Name = "txtConsequenciasx"
        Me.txtConsequenciasx.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtConsequenciasx.Width = 443
        '
        'lblProbabilidade
        '
        Me.lblProbabilidade.Name = "lblProbabilidade"
        Me.lblProbabilidade.Text = "Probabilidade:"
        Me.lblProbabilidade.Width = 103
        '
        'comboProbabilidade
        '
        Me.comboProbabilidade.Break = C1.Win.C1InputPanel.BreakType.None
        Me.comboProbabilidade.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboProbabilidade.Items.Add(Me.opP1)
        Me.comboProbabilidade.Items.Add(Me.opP2)
        Me.comboProbabilidade.Items.Add(Me.opP3)
        Me.comboProbabilidade.Items.Add(Me.opP4)
        Me.comboProbabilidade.Items.Add(Me.opP5)
        Me.comboProbabilidade.Name = "comboProbabilidade"
        Me.comboProbabilidade.ToolTipText = resources.GetString("comboProbabilidade.ToolTipText")
        Me.comboProbabilidade.Width = 40
        '
        'opP1
        '
        Me.opP1.Name = "opP1"
        Me.opP1.Text = "1"
        '
        'opP2
        '
        Me.opP2.Name = "opP2"
        Me.opP2.Text = "2"
        '
        'opP3
        '
        Me.opP3.Name = "opP3"
        Me.opP3.Text = "3"
        '
        'opP4
        '
        Me.opP4.Name = "opP4"
        Me.opP4.Text = "4"
        '
        'opP5
        '
        Me.opP5.Name = "opP5"
        Me.opP5.Text = "5"
        '
        'lblSeveridade
        '
        Me.lblSeveridade.Name = "lblSeveridade"
        Me.lblSeveridade.Text = "Severidade:"
        Me.lblSeveridade.Width = 100
        '
        'comboSeveridade
        '
        Me.comboSeveridade.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboSeveridade.Items.Add(Me.opS1)
        Me.comboSeveridade.Items.Add(Me.opS2)
        Me.comboSeveridade.Items.Add(Me.opS3)
        Me.comboSeveridade.Items.Add(Me.opS4)
        Me.comboSeveridade.Items.Add(Me.opS5)
        Me.comboSeveridade.Name = "comboSeveridade"
        Me.comboSeveridade.ToolTipText = resources.GetString("comboSeveridade.ToolTipText")
        Me.comboSeveridade.Width = 40
        '
        'opS1
        '
        Me.opS1.Name = "opS1"
        Me.opS1.Text = "1"
        '
        'opS2
        '
        Me.opS2.Name = "opS2"
        Me.opS2.Text = "2"
        '
        'opS3
        '
        Me.opS3.Name = "opS3"
        Me.opS3.Text = "3"
        '
        'opS4
        '
        Me.opS4.Name = "opS4"
        Me.opS4.Text = "4"
        '
        'opS5
        '
        Me.opS5.Name = "opS5"
        Me.opS5.Text = "5"
        '
        'lblAcaoTomada
        '
        Me.lblAcaoTomada.Name = "lblAcaoTomada"
        Me.lblAcaoTomada.Text = "Ação a ser tomada:"
        Me.lblAcaoTomada.Width = 103
        '
        'txtAcaoTomadax
        '
        Me.txtAcaoTomadax.Height = 35
        Me.txtAcaoTomadax.Multiline = True
        Me.txtAcaoTomadax.Name = "txtAcaoTomadax"
        Me.txtAcaoTomadax.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtAcaoTomadax.Width = 443
        '
        'lblResp
        '
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Text = "Responsável:"
        Me.lblResp.Width = 103
        '
        'comboResp
        '
        Me.comboResp.Break = C1.Win.C1InputPanel.BreakType.None
        Me.comboResp.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResp.Name = "comboResp"
        Me.comboResp.Width = 256
        '
        'lblPrazo
        '
        Me.lblPrazo.Name = "lblPrazo"
        Me.lblPrazo.Text = "Prazo:"
        Me.lblPrazo.Width = 79
        '
        'datePrazo
        '
        Me.datePrazo.Name = "datePrazo"
        '
        'lblAcompanhamento
        '
        Me.lblAcompanhamento.Name = "lblAcompanhamento"
        Me.lblAcompanhamento.Text = "Acompanhamento:"
        Me.lblAcompanhamento.Width = 103
        '
        'txtAcompanhamentox
        '
        Me.txtAcompanhamentox.Height = 35
        Me.txtAcompanhamentox.Multiline = True
        Me.txtAcompanhamentox.Name = "txtAcompanhamentox"
        Me.txtAcompanhamentox.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtAcompanhamentox.Width = 443
        '
        'grupOpcoes
        '
        Me.grupOpcoes.Name = "grupOpcoes"
        Me.grupOpcoes.Text = "Opções"
        '
        'botSalvarRisco
        '
        Me.botSalvarRisco.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botSalvarRisco.Image = CType(resources.GetObject("botSalvarRisco.Image"), System.Drawing.Image)
        Me.botSalvarRisco.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarRisco.Name = "botSalvarRisco"
        Me.botSalvarRisco.Text = "Salvar"
        Me.botSalvarRisco.Width = 70
        '
        'txtAcompanhamento
        '
        Me.txtAcompanhamento.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtAcompanhamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAcompanhamento.Location = New System.Drawing.Point(117, 229)
        Me.txtAcompanhamento.Multiline = True
        Me.txtAcompanhamento.Name = "txtAcompanhamento"
        Me.txtAcompanhamento.Size = New System.Drawing.Size(443, 35)
        Me.txtAcompanhamento.TabIndex = 14
        Me.txtAcompanhamento.Tag = Nothing
        Me.txtAcompanhamento.TextDetached = True
        '
        'txtAcaoTomada
        '
        Me.txtAcaoTomada.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtAcaoTomada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAcaoTomada.Location = New System.Drawing.Point(117, 165)
        Me.txtAcaoTomada.Multiline = True
        Me.txtAcaoTomada.Name = "txtAcaoTomada"
        Me.txtAcaoTomada.Size = New System.Drawing.Size(443, 35)
        Me.txtAcaoTomada.TabIndex = 15
        Me.txtAcaoTomada.Tag = Nothing
        Me.txtAcaoTomada.TextDetached = True
        '
        'txtConsequencias
        '
        Me.txtConsequencias.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtConsequencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsequencias.Location = New System.Drawing.Point(117, 103)
        Me.txtConsequencias.Multiline = True
        Me.txtConsequencias.Name = "txtConsequencias"
        Me.txtConsequencias.Size = New System.Drawing.Size(443, 35)
        Me.txtConsequencias.TabIndex = 13
        Me.txtConsequencias.Tag = Nothing
        Me.txtConsequencias.TextDetached = True
        '
        'txtImpacto
        '
        Me.txtImpacto.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtImpacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImpacto.Location = New System.Drawing.Point(117, 66)
        Me.txtImpacto.Multiline = True
        Me.txtImpacto.Name = "txtImpacto"
        Me.txtImpacto.Size = New System.Drawing.Size(443, 35)
        Me.txtImpacto.TabIndex = 11
        Me.txtImpacto.Tag = Nothing
        Me.txtImpacto.TextDetached = True
        '
        'txtDesc
        '
        Me.txtDesc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Location = New System.Drawing.Point(117, 29)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(443, 35)
        Me.txtDesc.TabIndex = 12
        Me.txtDesc.Tag = Nothing
        Me.txtDesc.TextDetached = True
        '
        'projCadRisco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 328)
        Me.Controls.Add(Me.txtAcompanhamento)
        Me.Controls.Add(Me.txtAcaoTomada)
        Me.Controls.Add(Me.txtConsequencias)
        Me.Controls.Add(Me.txtImpacto)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.InputRisco)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "projCadRisco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.InputRisco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAcompanhamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAcaoTomada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConsequencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InputRisco As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoRisco As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblDesc As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtDescx As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblImpacto As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtImpactox As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblConsequencias As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtConsequenciasx As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblProbabilidade As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboProbabilidade As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents opP1 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents opP2 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents opP3 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents opP4 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents opP5 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents lblSeveridade As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboSeveridade As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents opS1 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents opS2 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents opS3 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents opS4 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents opS5 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents lblAcaoTomada As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAcaoTomadax As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblResp As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResp As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblPrazo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents datePrazo As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblAcompanhamento As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAcompanhamentox As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents grupOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvarRisco As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtAcompanhamento As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtAcaoTomada As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtConsequencias As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtImpacto As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtDesc As C1.Win.C1Input.C1TextBox
End Class
