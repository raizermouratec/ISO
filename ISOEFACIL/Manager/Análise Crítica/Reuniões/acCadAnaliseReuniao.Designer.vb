<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acCadAnaliseReuniao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acCadAnaliseReuniao))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarAnalise = New C1.Win.C1InputPanel.InputButton()
        Me.botParticipantes = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupRegistrarReuniao = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblConteudoReuniao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtReuniaoOutro = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblResp = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResp = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblTipoReuniao = New C1.Win.C1InputPanel.InputLabel()
        Me.radioOrdinaria = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioExtraordinaria = New C1.Win.C1InputPanel.InputRadioButton()
        Me.lblReuniao = New C1.Win.C1InputPanel.InputLabel()
        Me.dateReuniao = New C1.Win.C1InputPanel.InputDatePicker()
        Me.txtReuniao = New C1.Win.C1Input.C1TextBox()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReuniao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.botSalvarAnalise)
        Me.C1InputPanel2.Items.Add(Me.botParticipantes)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 350)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(592, 64)
        Me.C1InputPanel2.TabIndex = 4
        '
        'grupoOpcoes
        '
        Me.grupoOpcoes.Name = "grupoOpcoes"
        Me.grupoOpcoes.Text = "Opções"
        '
        'botSalvarAnalise
        '
        Me.botSalvarAnalise.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botSalvarAnalise.Image = CType(resources.GetObject("botSalvarAnalise.Image"), System.Drawing.Image)
        Me.botSalvarAnalise.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarAnalise.Name = "botSalvarAnalise"
        Me.botSalvarAnalise.Text = "Salvar"
        Me.botSalvarAnalise.Width = 70
        '
        'botParticipantes
        '
        Me.botParticipantes.Image = CType(resources.GetObject("botParticipantes.Image"), System.Drawing.Image)
        Me.botParticipantes.ImageSize = New System.Drawing.Size(20, 20)
        Me.botParticipantes.Name = "botParticipantes"
        Me.botParticipantes.Text = "Participantes"
        Me.botParticipantes.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.grupRegistrarReuniao)
        Me.C1InputPanel1.Items.Add(Me.lblConteudoReuniao)
        Me.C1InputPanel1.Items.Add(Me.txtReuniaoOutro)
        Me.C1InputPanel1.Items.Add(Me.lblResp)
        Me.C1InputPanel1.Items.Add(Me.comboResp)
        Me.C1InputPanel1.Items.Add(Me.lblTipoReuniao)
        Me.C1InputPanel1.Items.Add(Me.radioOrdinaria)
        Me.C1InputPanel1.Items.Add(Me.radioExtraordinaria)
        Me.C1InputPanel1.Items.Add(Me.lblReuniao)
        Me.C1InputPanel1.Items.Add(Me.dateReuniao)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(592, 355)
        Me.C1InputPanel1.TabIndex = 5
        '
        'grupRegistrarReuniao
        '
        Me.grupRegistrarReuniao.Name = "grupRegistrarReuniao"
        Me.grupRegistrarReuniao.Text = "Registrar Reunião"
        '
        'lblConteudoReuniao
        '
        Me.lblConteudoReuniao.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblConteudoReuniao.Name = "lblConteudoReuniao"
        Me.lblConteudoReuniao.Text = "Conteúdo da Reunião :"
        '
        'txtReuniaoOutro
        '
        Me.txtReuniaoOutro.Height = 231
        Me.txtReuniaoOutro.Multiline = True
        Me.txtReuniaoOutro.Name = "txtReuniaoOutro"
        Me.txtReuniaoOutro.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtReuniaoOutro.Width = 571
        '
        'lblResp
        '
        Me.lblResp.ElementWidth = 121
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Text = "Responsável :"
        '
        'comboResp
        '
        Me.comboResp.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResp.Name = "comboResp"
        Me.comboResp.Width = 374
        '
        'lblTipoReuniao
        '
        Me.lblTipoReuniao.ElementWidth = 121
        Me.lblTipoReuniao.Name = "lblTipoReuniao"
        Me.lblTipoReuniao.Text = "Tipo de Reunião :"
        '
        'radioOrdinaria
        '
        Me.radioOrdinaria.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioOrdinaria.Name = "radioOrdinaria"
        Me.radioOrdinaria.Text = "Ordinária"
        Me.radioOrdinaria.Width = 144
        '
        'radioExtraordinaria
        '
        Me.radioExtraordinaria.ElementWidth = 121
        Me.radioExtraordinaria.Name = "radioExtraordinaria"
        Me.radioExtraordinaria.Text = "Extraordinária"
        '
        'lblReuniao
        '
        Me.lblReuniao.ElementWidth = 121
        Me.lblReuniao.Name = "lblReuniao"
        Me.lblReuniao.Text = "Data de Reunião :"
        '
        'dateReuniao
        '
        Me.dateReuniao.Name = "dateReuniao"
        '
        'txtReuniao
        '
        Me.txtReuniao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtReuniao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReuniao.Location = New System.Drawing.Point(10, 44)
        Me.txtReuniao.Multiline = True
        Me.txtReuniao.Name = "txtReuniao"
        Me.txtReuniao.Size = New System.Drawing.Size(571, 231)
        Me.txtReuniao.TabIndex = 6
        Me.txtReuniao.Tag = Nothing
        Me.txtReuniao.TextDetached = True
        '
        'acCadAnaliseReuniao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 415)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.txtReuniao)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "acCadAnaliseReuniao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Reunião de Análise Crítica"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReuniao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvarAnalise As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupRegistrarReuniao As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblConteudoReuniao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtReuniaoOutro As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblResp As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResp As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblTipoReuniao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents radioOrdinaria As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioExtraordinaria As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents lblReuniao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateReuniao As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents botParticipantes As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtReuniao As C1.Win.C1Input.C1TextBox
End Class
