<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acCadDecisoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acCadDecisoes))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupRegistroDecisoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblDecisao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtDecisao = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDetalhamentoDecisao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtDetal = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblSituacao = New C1.Win.C1InputPanel.InputLabel()
        Me.comboSituacao = New C1.Win.C1InputPanel.InputComboBox()
        Me.inpConcluido = New C1.Win.C1InputPanel.InputOption()
        Me.inpEmDesenvolvimento = New C1.Win.C1InputPanel.InputOption()
        Me.inpCancelado = New C1.Win.C1InputPanel.InputOption()
        Me.lblDataReuniao = New C1.Win.C1InputPanel.InputLabel()
        Me.dateDataReuniao = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblResponsavel = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResponsavel = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblPrazo = New C1.Win.C1InputPanel.InputLabel()
        Me.datePrazo = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblResultado = New C1.Win.C1InputPanel.InputLabel()
        Me.txtResult = New C1.Win.C1InputPanel.InputTextBox()
        Me.txtDetalhamento = New C1.Win.C1Input.C1TextBox()
        Me.txtResultados = New C1.Win.C1Input.C1TextBox()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarDecisoes = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetalhamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.grupRegistroDecisoes)
        Me.C1InputPanel1.Items.Add(Me.lblDecisao)
        Me.C1InputPanel1.Items.Add(Me.txtDecisao)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.lblDetalhamentoDecisao)
        Me.C1InputPanel1.Items.Add(Me.txtDetal)
        Me.C1InputPanel1.Items.Add(Me.lblSituacao)
        Me.C1InputPanel1.Items.Add(Me.comboSituacao)
        Me.C1InputPanel1.Items.Add(Me.lblDataReuniao)
        Me.C1InputPanel1.Items.Add(Me.dateDataReuniao)
        Me.C1InputPanel1.Items.Add(Me.lblResponsavel)
        Me.C1InputPanel1.Items.Add(Me.comboResponsavel)
        Me.C1InputPanel1.Items.Add(Me.lblPrazo)
        Me.C1InputPanel1.Items.Add(Me.datePrazo)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.lblResultado)
        Me.C1InputPanel1.Items.Add(Me.txtResult)
        Me.C1InputPanel1.Location = New System.Drawing.Point(-1, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(607, 267)
        Me.C1InputPanel1.TabIndex = 0
        '
        'grupRegistroDecisoes
        '
        Me.grupRegistroDecisoes.Name = "grupRegistroDecisoes"
        Me.grupRegistroDecisoes.Text = "Registrar Decisões"
        '
        'lblDecisao
        '
        Me.lblDecisao.Name = "lblDecisao"
        Me.lblDecisao.Padding = New System.Windows.Forms.Padding(0, 0, 45, 0)
        Me.lblDecisao.Text = "Decisão :"
        '
        'txtDecisao
        '
        Me.txtDecisao.Name = "txtDecisao"
        Me.txtDecisao.Width = 494
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Detalhamento da Decisão :"
        '
        'lblDetalhamentoDecisao
        '
        Me.lblDetalhamentoDecisao.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblDetalhamentoDecisao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblDetalhamentoDecisao.Name = "lblDetalhamentoDecisao"
        '
        'txtDetal
        '
        Me.txtDetal.Height = 62
        Me.txtDetal.Multiline = True
        Me.txtDetal.Name = "txtDetal"
        Me.txtDetal.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtDetal.Width = 591
        '
        'lblSituacao
        '
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Padding = New System.Windows.Forms.Padding(0, 0, 40, 0)
        Me.lblSituacao.Text = "Situação :"
        '
        'comboSituacao
        '
        Me.comboSituacao.Break = C1.Win.C1InputPanel.BreakType.None
        Me.comboSituacao.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboSituacao.Items.Add(Me.inpConcluido)
        Me.comboSituacao.Items.Add(Me.inpEmDesenvolvimento)
        Me.comboSituacao.Items.Add(Me.inpCancelado)
        Me.comboSituacao.Name = "comboSituacao"
        Me.comboSituacao.Width = 294
        '
        'inpConcluido
        '
        Me.inpConcluido.Name = "inpConcluido"
        Me.inpConcluido.Text = "Concluído"
        '
        'inpEmDesenvolvimento
        '
        Me.inpEmDesenvolvimento.Name = "inpEmDesenvolvimento"
        Me.inpEmDesenvolvimento.Text = "Em Desenvolvimento"
        '
        'inpCancelado
        '
        Me.inpCancelado.Name = "inpCancelado"
        Me.inpCancelado.Text = "Cancelado"
        '
        'lblDataReuniao
        '
        Me.lblDataReuniao.Name = "lblDataReuniao"
        Me.lblDataReuniao.Text = "Data da Reunião :"
        '
        'dateDataReuniao
        '
        Me.dateDataReuniao.Name = "dateDataReuniao"
        '
        'lblResponsavel
        '
        Me.lblResponsavel.Name = "lblResponsavel"
        Me.lblResponsavel.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.lblResponsavel.Text = "Responsável :"
        '
        'comboResponsavel
        '
        Me.comboResponsavel.Break = C1.Win.C1InputPanel.BreakType.None
        Me.comboResponsavel.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResponsavel.Name = "comboResponsavel"
        Me.comboResponsavel.Width = 294
        '
        'lblPrazo
        '
        Me.lblPrazo.Name = "lblPrazo"
        Me.lblPrazo.Text = "Prazo :"
        Me.lblPrazo.Width = 92
        '
        'datePrazo
        '
        Me.datePrazo.Name = "datePrazo"
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Resultados :"
        '
        'lblResultado
        '
        Me.lblResultado.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblResultado.Name = "lblResultado"
        '
        'txtResult
        '
        Me.txtResult.Height = 62
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtResult.Width = 591
        '
        'txtDetalhamento
        '
        Me.txtDetalhamento.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtDetalhamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalhamento.Location = New System.Drawing.Point(9, 70)
        Me.txtDetalhamento.Multiline = True
        Me.txtDetalhamento.Name = "txtDetalhamento"
        Me.txtDetalhamento.Size = New System.Drawing.Size(590, 62)
        Me.txtDetalhamento.TabIndex = 4
        Me.txtDetalhamento.Tag = Nothing
        Me.txtDetalhamento.TextDetached = True
        '
        'txtResultados
        '
        Me.txtResultados.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultados.Location = New System.Drawing.Point(9, 205)
        Me.txtResultados.Multiline = True
        Me.txtResultados.Name = "txtResultados"
        Me.txtResultados.Size = New System.Drawing.Size(590, 62)
        Me.txtResultados.TabIndex = 4
        Me.txtResultados.Tag = Nothing
        Me.txtResultados.TextDetached = True
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel6.Items.Add(Me.botSalvarDecisoes)
        Me.C1InputPanel6.Location = New System.Drawing.Point(-1, 275)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(607, 60)
        Me.C1InputPanel6.TabIndex = 5
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "Opções"
        '
        'botSalvarDecisoes
        '
        Me.botSalvarDecisoes.Image = CType(resources.GetObject("botSalvarDecisoes.Image"), System.Drawing.Image)
        Me.botSalvarDecisoes.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarDecisoes.Name = "botSalvarDecisoes"
        Me.botSalvarDecisoes.Text = "Salvar"
        Me.botSalvarDecisoes.Width = 70
        '
        'acCadDecisoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 336)
        Me.Controls.Add(Me.C1InputPanel6)
        Me.Controls.Add(Me.txtResultados)
        Me.Controls.Add(Me.txtDetalhamento)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "acCadDecisoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Decisões"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetalhamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupRegistroDecisoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblDecisao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtDecisao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtDetal As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblSituacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboSituacao As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblDataReuniao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateDataReuniao As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblResponsavel As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResponsavel As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblPrazo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents datePrazo As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblResultado As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtResult As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtDetalhamento As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtResultados As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents botSalvarDecisoes As C1.Win.C1InputPanel.InputButton
    Friend WithEvents inpConcluido As C1.Win.C1InputPanel.InputOption
    Friend WithEvents inpEmDesenvolvimento As C1.Win.C1InputPanel.InputOption
    Friend WithEvents inpCancelado As C1.Win.C1InputPanel.InputOption
    Friend WithEvents lblDetalhamentoDecisao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
End Class
