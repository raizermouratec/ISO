<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projCadRevisoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projCadRevisoes))
        Me.InputControle = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoRevisao = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblAba = New C1.Win.C1InputPanel.InputLabel()
        Me.comboTipo = New C1.Win.C1InputPanel.InputComboBox()
        Me.opObjetivos = New C1.Win.C1InputPanel.InputOption()
        Me.opEscopo = New C1.Win.C1InputPanel.InputOption()
        Me.opSaidas = New C1.Win.C1InputPanel.InputOption()
        Me.opEstagios = New C1.Win.C1InputPanel.InputOption()
        Me.opRecursos = New C1.Win.C1InputPanel.InputOption()
        Me.opControle = New C1.Win.C1InputPanel.InputOption()
        Me.opRisco = New C1.Win.C1InputPanel.InputOption()
        Me.lblRevisao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRevisao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblAlteracao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAlteracaox = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblResp = New C1.Win.C1InputPanel.InputLabel()
        Me.comboRespRevisao = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dateData = New C1.Win.C1InputPanel.InputDatePicker()
        Me.C1InputPanel14 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarRevisoes = New C1.Win.C1InputPanel.InputButton()
        Me.txtAlteracao = New C1.Win.C1Input.C1TextBox()
        CType(Me.InputControle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlteracao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputControle
        '
        Me.InputControle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InputControle.Items.Add(Me.grupoRevisao)
        Me.InputControle.Items.Add(Me.lblAba)
        Me.InputControle.Items.Add(Me.comboTipo)
        Me.InputControle.Items.Add(Me.lblRevisao)
        Me.InputControle.Items.Add(Me.txtRevisao)
        Me.InputControle.Items.Add(Me.lblAlteracao)
        Me.InputControle.Items.Add(Me.txtAlteracaox)
        Me.InputControle.Items.Add(Me.lblResp)
        Me.InputControle.Items.Add(Me.comboRespRevisao)
        Me.InputControle.Items.Add(Me.lblData)
        Me.InputControle.Items.Add(Me.dateData)
        Me.InputControle.Location = New System.Drawing.Point(0, 0)
        Me.InputControle.Name = "InputControle"
        Me.InputControle.Size = New System.Drawing.Size(363, 189)
        Me.InputControle.TabIndex = 0
        '
        'grupoRevisao
        '
        Me.grupoRevisao.Name = "grupoRevisao"
        Me.grupoRevisao.Text = "Controle de Revisões"
        '
        'lblAba
        '
        Me.lblAba.Name = "lblAba"
        Me.lblAba.Text = "Aba:"
        Me.lblAba.Width = 70
        '
        'comboTipo
        '
        Me.comboTipo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.comboTipo.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboTipo.Items.Add(Me.opObjetivos)
        Me.comboTipo.Items.Add(Me.opEscopo)
        Me.comboTipo.Items.Add(Me.opSaidas)
        Me.comboTipo.Items.Add(Me.opEstagios)
        Me.comboTipo.Items.Add(Me.opRecursos)
        Me.comboTipo.Items.Add(Me.opControle)
        Me.comboTipo.Items.Add(Me.opRisco)
        Me.comboTipo.Name = "comboTipo"
        Me.comboTipo.Width = 164
        '
        'opObjetivos
        '
        Me.opObjetivos.Name = "opObjetivos"
        Me.opObjetivos.Text = "Objetivos"
        '
        'opEscopo
        '
        Me.opEscopo.Name = "opEscopo"
        Me.opEscopo.Text = "Escopo"
        '
        'opSaidas
        '
        Me.opSaidas.Name = "opSaidas"
        Me.opSaidas.Text = "Saídas"
        '
        'opEstagios
        '
        Me.opEstagios.Name = "opEstagios"
        Me.opEstagios.Text = "Estágios"
        '
        'opRecursos
        '
        Me.opRecursos.Name = "opRecursos"
        Me.opRecursos.Text = "Recursos"
        '
        'opControle
        '
        Me.opControle.Name = "opControle"
        Me.opControle.Text = "Controle"
        '
        'opRisco
        '
        Me.opRisco.Name = "opRisco"
        Me.opRisco.Text = "Risco"
        '
        'lblRevisao
        '
        Me.lblRevisao.Name = "lblRevisao"
        Me.lblRevisao.Text = "Revisão:"
        Me.lblRevisao.Width = 70
        '
        'txtRevisao
        '
        Me.txtRevisao.Name = "txtRevisao"
        Me.txtRevisao.Width = 27
        '
        'lblAlteracao
        '
        Me.lblAlteracao.Name = "lblAlteracao"
        Me.lblAlteracao.Text = "Alteração:"
        Me.lblAlteracao.Width = 70
        '
        'txtAlteracaox
        '
        Me.txtAlteracaox.Height = 79
        Me.txtAlteracaox.Multiline = True
        Me.txtAlteracaox.Name = "txtAlteracaox"
        Me.txtAlteracaox.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtAlteracaox.Width = 269
        '
        'lblResp
        '
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Text = "Responsável:"
        Me.lblResp.Width = 70
        '
        'comboRespRevisao
        '
        Me.comboRespRevisao.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboRespRevisao.Name = "comboRespRevisao"
        Me.comboRespRevisao.Width = 269
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Text = "Data:"
        Me.lblData.Width = 70
        '
        'dateData
        '
        Me.dateData.Name = "dateData"
        '
        'C1InputPanel14
        '
        Me.C1InputPanel14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel14.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel14.Items.Add(Me.botSalvarRevisoes)
        Me.C1InputPanel14.Location = New System.Drawing.Point(0, 184)
        Me.C1InputPanel14.Name = "C1InputPanel14"
        Me.C1InputPanel14.Size = New System.Drawing.Size(363, 64)
        Me.C1InputPanel14.TabIndex = 2
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
        '
        'botSalvarRevisoes
        '
        Me.botSalvarRevisoes.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botSalvarRevisoes.Image = CType(resources.GetObject("botSalvarRevisoes.Image"), System.Drawing.Image)
        Me.botSalvarRevisoes.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarRevisoes.Name = "botSalvarRevisoes"
        Me.botSalvarRevisoes.Text = "Salvar"
        Me.botSalvarRevisoes.Width = 70
        '
        'txtAlteracao
        '
        Me.txtAlteracao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtAlteracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlteracao.Location = New System.Drawing.Point(84, 51)
        Me.txtAlteracao.Multiline = True
        Me.txtAlteracao.Name = "txtAlteracao"
        Me.txtAlteracao.Size = New System.Drawing.Size(269, 79)
        Me.txtAlteracao.TabIndex = 3
        Me.txtAlteracao.Tag = Nothing
        Me.txtAlteracao.TextDetached = True
        '
        'projCadRevisoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 248)
        Me.Controls.Add(Me.txtAlteracao)
        Me.Controls.Add(Me.C1InputPanel14)
        Me.Controls.Add(Me.InputControle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "projCadRevisoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Revisões"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.InputControle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlteracao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InputControle As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoRevisao As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblRevisao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtRevisao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblAlteracao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAlteracaox As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblResp As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboRespRevisao As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateData As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents C1InputPanel14 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvarRevisoes As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblAba As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboTipo As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents opObjetivos As C1.Win.C1InputPanel.InputOption
    Friend WithEvents opEscopo As C1.Win.C1InputPanel.InputOption
    Friend WithEvents opSaidas As C1.Win.C1InputPanel.InputOption
    Friend WithEvents opEstagios As C1.Win.C1InputPanel.InputOption
    Friend WithEvents opRecursos As C1.Win.C1InputPanel.InputOption
    Friend WithEvents opControle As C1.Win.C1InputPanel.InputOption
    Friend WithEvents opRisco As C1.Win.C1InputPanel.InputOption
    Friend WithEvents txtAlteracao As C1.Win.C1Input.C1TextBox
End Class
