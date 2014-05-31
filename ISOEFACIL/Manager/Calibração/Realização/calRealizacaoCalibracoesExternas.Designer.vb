<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calRealizacaoCalibracoesExternas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calRealizacaoCalibracoesExternas))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.botAnexos = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupCalibracaoExt = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblInstrumento = New C1.Win.C1InputPanel.InputLabel()
        Me.txtInstrumento = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblOrgResp = New C1.Win.C1InputPanel.InputLabel()
        Me.txtOrgResp = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblLaudoEmitido = New C1.Win.C1InputPanel.InputLabel()
        Me.txtLaudoEmitido = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblObs = New C1.Win.C1InputPanel.InputLabel()
        Me.txtObsOutro = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblIdentificacao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtIdentificacao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dateData = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblValidade = New C1.Win.C1InputPanel.InputLabel()
        Me.dateValidade = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblResultLaudo = New C1.Win.C1InputPanel.InputLabel()
        Me.comboLaudoResult = New C1.Win.C1InputPanel.InputComboBox()
        Me.Op1 = New C1.Win.C1InputPanel.InputOption()
        Me.Op2 = New C1.Win.C1InputPanel.InputOption()
        Me.Op3 = New C1.Win.C1InputPanel.InputOption()
        Me.grupPadraoRefUsado = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblNLaudo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNlaudo = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblOrgRespRef = New C1.Win.C1InputPanel.InputLabel()
        Me.txtOrgRespRef = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblValidadeRef = New C1.Win.C1InputPanel.InputLabel()
        Me.dateValidadeRef = New C1.Win.C1InputPanel.InputDatePicker()
        Me.txtObs = New C1.Win.C1Input.C1TextBox()
        Me.gridAnexos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.inpultAnexos = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me._imgListLegenda = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.barra1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblStatus1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.picAnexo = New System.Windows.Forms.PictureBox()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inpultAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.picAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Items.Add(Me.botAnexos)
        Me.C1InputPanel2.Location = New System.Drawing.Point(-1, 298)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(700, 64)
        Me.C1InputPanel2.TabIndex = 6
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
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.grupCalibracaoExt)
        Me.C1InputPanel1.Items.Add(Me.lblInstrumento)
        Me.C1InputPanel1.Items.Add(Me.txtInstrumento)
        Me.C1InputPanel1.Items.Add(Me.lblOrgResp)
        Me.C1InputPanel1.Items.Add(Me.txtOrgResp)
        Me.C1InputPanel1.Items.Add(Me.lblLaudoEmitido)
        Me.C1InputPanel1.Items.Add(Me.txtLaudoEmitido)
        Me.C1InputPanel1.Items.Add(Me.lblObs)
        Me.C1InputPanel1.Items.Add(Me.txtObsOutro)
        Me.C1InputPanel1.Items.Add(Me.lblIdentificacao)
        Me.C1InputPanel1.Items.Add(Me.txtIdentificacao)
        Me.C1InputPanel1.Items.Add(Me.lblData)
        Me.C1InputPanel1.Items.Add(Me.dateData)
        Me.C1InputPanel1.Items.Add(Me.lblValidade)
        Me.C1InputPanel1.Items.Add(Me.dateValidade)
        Me.C1InputPanel1.Items.Add(Me.lblResultLaudo)
        Me.C1InputPanel1.Items.Add(Me.comboLaudoResult)
        Me.C1InputPanel1.Items.Add(Me.grupPadraoRefUsado)
        Me.C1InputPanel1.Items.Add(Me.lblNLaudo)
        Me.C1InputPanel1.Items.Add(Me.txtNlaudo)
        Me.C1InputPanel1.Items.Add(Me.lblOrgRespRef)
        Me.C1InputPanel1.Items.Add(Me.txtOrgRespRef)
        Me.C1InputPanel1.Items.Add(Me.lblValidadeRef)
        Me.C1InputPanel1.Items.Add(Me.dateValidadeRef)
        Me.C1InputPanel1.Location = New System.Drawing.Point(-1, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(700, 317)
        Me.C1InputPanel1.TabIndex = 5
        '
        'grupCalibracaoExt
        '
        Me.grupCalibracaoExt.Name = "grupCalibracaoExt"
        Me.grupCalibracaoExt.Text = "Resultado da Calibração Externa"
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
        'lblOrgResp
        '
        Me.lblOrgResp.Name = "lblOrgResp"
        Me.lblOrgResp.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblOrgResp.Text = "Organismo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Responsável :"
        Me.lblOrgResp.Width = 87
        '
        'txtOrgResp
        '
        Me.txtOrgResp.Name = "txtOrgResp"
        Me.txtOrgResp.Width = 250
        '
        'lblLaudoEmitido
        '
        Me.lblLaudoEmitido.Name = "lblLaudoEmitido"
        Me.lblLaudoEmitido.Padding = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.lblLaudoEmitido.Text = "Laudo Emitido :"
        Me.lblLaudoEmitido.Width = 87
        '
        'txtLaudoEmitido
        '
        Me.txtLaudoEmitido.Name = "txtLaudoEmitido"
        Me.txtLaudoEmitido.Width = 250
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
        'lblResultLaudo
        '
        Me.lblResultLaudo.Name = "lblResultLaudo"
        Me.lblResultLaudo.Text = "Resultado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Laudo :"
        Me.lblResultLaudo.Width = 80
        '
        'comboLaudoResult
        '
        Me.comboLaudoResult.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboLaudoResult.Items.Add(Me.Op1)
        Me.comboLaudoResult.Items.Add(Me.Op2)
        Me.comboLaudoResult.Items.Add(Me.Op3)
        Me.comboLaudoResult.Name = "comboLaudoResult"
        Me.comboLaudoResult.Width = 250
        '
        'Op1
        '
        Me.Op1.Name = "Op1"
        Me.Op1.Text = "Aprovado"
        '
        'Op2
        '
        Me.Op2.Name = "Op2"
        Me.Op2.Text = "Aprovado Parcialmente"
        '
        'Op3
        '
        Me.Op3.Name = "Op3"
        Me.Op3.Text = "Reprovado"
        '
        'grupPadraoRefUsado
        '
        Me.grupPadraoRefUsado.Name = "grupPadraoRefUsado"
        Me.grupPadraoRefUsado.Text = "Padrão de Referência usado"
        '
        'lblNLaudo
        '
        Me.lblNLaudo.Name = "lblNLaudo"
        Me.lblNLaudo.Text = "Número do " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Laudo :"
        Me.lblNLaudo.Width = 88
        '
        'txtNlaudo
        '
        Me.txtNlaudo.Name = "txtNlaudo"
        Me.txtNlaudo.Width = 250
        '
        'lblOrgRespRef
        '
        Me.lblOrgRespRef.Name = "lblOrgRespRef"
        Me.lblOrgRespRef.Text = "Organismo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Responsável :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblOrgRespRef.Width = 88
        '
        'txtOrgRespRef
        '
        Me.txtOrgRespRef.Name = "txtOrgRespRef"
        Me.txtOrgRespRef.Width = 250
        '
        'lblValidadeRef
        '
        Me.lblValidadeRef.Name = "lblValidadeRef"
        Me.lblValidadeRef.Text = "Validade :"
        Me.lblValidadeRef.Width = 88
        '
        'dateValidadeRef
        '
        Me.dateValidadeRef.Name = "dateValidadeRef"
        '
        'txtObs
        '
        Me.txtObs.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.Location = New System.Drawing.Point(100, 110)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(250, 65)
        Me.txtObs.TabIndex = 7
        Me.txtObs.Tag = Nothing
        Me.txtObs.TextDetached = True
        '
        'gridAnexos
        '
        Me.gridAnexos.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridAnexos.AllowEditing = False
        Me.gridAnexos.AllowFiltering = True
        Me.gridAnexos.ColumnInfo = resources.GetString("gridAnexos.ColumnInfo")
        Me.gridAnexos.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridAnexos.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.gridAnexos.Location = New System.Drawing.Point(359, 223)
        Me.gridAnexos.Name = "gridAnexos"
        Me.gridAnexos.Rows.DefaultSize = 21
        Me.gridAnexos.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridAnexos.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridAnexos.Size = New System.Drawing.Size(340, 57)
        Me.gridAnexos.StyleInfo = resources.GetString("gridAnexos.StyleInfo")
        Me.gridAnexos.TabIndex = 11
        Me.gridAnexos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'inpultAnexos
        '
        Me.inpultAnexos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.inpultAnexos.Items.Add(Me.InputGroupHeader6)
        Me.inpultAnexos.Location = New System.Drawing.Point(359, 200)
        Me.inpultAnexos.Name = "inpultAnexos"
        Me.inpultAnexos.Size = New System.Drawing.Size(340, 99)
        Me.inpultAnexos.TabIndex = 15
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "Lista de Anexos"
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
        Me.StatusStrip1.Location = New System.Drawing.Point(359, 280)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(340, 19)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
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
        Me.picAnexo.Location = New System.Drawing.Point(671, 340)
        Me.picAnexo.Name = "picAnexo"
        Me.picAnexo.Size = New System.Drawing.Size(28, 22)
        Me.picAnexo.TabIndex = 17
        Me.picAnexo.TabStop = False
        Me.picAnexo.Visible = False
        '
        'calRealizacaoCalibracoesExternas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(700, 363)
        Me.Controls.Add(Me.picAnexo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gridAnexos)
        Me.Controls.Add(Me.inpultAnexos)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "calRealizacaoCalibracoesExternas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realização de Calibração Externa"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inpultAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.picAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupCalibracaoExt As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblInstrumento As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtInstrumento As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblOrgResp As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLaudoEmitido As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblObs As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtObsOutro As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblIdentificacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtIdentificacao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateData As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblValidade As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateValidade As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblResultLaudo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboLaudoResult As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents grupPadraoRefUsado As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents txtOrgResp As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtLaudoEmitido As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblNLaudo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNlaudo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblOrgRespRef As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtOrgRespRef As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblValidadeRef As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateValidadeRef As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents botAnexos As C1.Win.C1InputPanel.InputButton
    Friend WithEvents Op1 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents Op2 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents Op3 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents txtObs As C1.Win.C1Input.C1TextBox
    Friend WithEvents gridAnexos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents inpultAnexos As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents _imgListLegenda As System.Windows.Forms.ImageList
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents barra1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblStatus1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents picAnexo As System.Windows.Forms.PictureBox
End Class
