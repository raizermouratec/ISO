<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configCadColaboradores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configCadColaboradores))
        Me.C1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblColaborador = New C1.Win.C1InputPanel.InputLabel()
        Me.txtColaborador = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblEmail = New C1.Win.C1InputPanel.InputLabel()
        Me.txtEmail = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblAraColab = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbArea = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblCargo = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbCargo = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblSituacao = New C1.Win.C1InputPanel.InputLabel()
        Me.optAtivo = New C1.Win.C1InputPanel.InputRadioButton()
        Me.optInativo = New C1.Win.C1InputPanel.InputRadioButton()
        Me.lblAprovador = New C1.Win.C1InputPanel.InputLabel()
        Me.comboAprovador = New C1.Win.C1InputPanel.InputComboBox()
        Me.optSim = New C1.Win.C1InputPanel.InputOption()
        Me.optNao = New C1.Win.C1InputPanel.InputOption()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel7
        '
        Me.C1InputPanel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel7.Items.Add(Me.InputGroupHeader5)
        Me.C1InputPanel7.Items.Add(Me.botSalvar)
        Me.C1InputPanel7.Location = New System.Drawing.Point(-2, 170)
        Me.C1InputPanel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.C1InputPanel7.Name = "C1InputPanel7"
        Me.C1InputPanel7.Size = New System.Drawing.Size(720, 61)
        Me.C1InputPanel7.TabIndex = 43
        '
        'InputGroupHeader5
        '
        Me.InputGroupHeader5.Name = "InputGroupHeader5"
        Me.InputGroupHeader5.Text = "Opções"
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
        'C1InputPanel4
        '
        Me.C1InputPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel4.Items.Add(Me.lblColaborador)
        Me.C1InputPanel4.Items.Add(Me.txtColaborador)
        Me.C1InputPanel4.Items.Add(Me.lblEmail)
        Me.C1InputPanel4.Items.Add(Me.txtEmail)
        Me.C1InputPanel4.Items.Add(Me.lblAraColab)
        Me.C1InputPanel4.Items.Add(Me.cmbArea)
        Me.C1InputPanel4.Items.Add(Me.lblCargo)
        Me.C1InputPanel4.Items.Add(Me.cmbCargo)
        Me.C1InputPanel4.Items.Add(Me.lblSituacao)
        Me.C1InputPanel4.Items.Add(Me.optAtivo)
        Me.C1InputPanel4.Items.Add(Me.optInativo)
        Me.C1InputPanel4.Items.Add(Me.lblAprovador)
        Me.C1InputPanel4.Items.Add(Me.comboAprovador)
        Me.C1InputPanel4.Location = New System.Drawing.Point(-2, 1)
        Me.C1InputPanel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(720, 166)
        Me.C1InputPanel4.TabIndex = 42
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "Dados do Colaborador"
        '
        'lblColaborador
        '
        Me.lblColaborador.Name = "lblColaborador"
        Me.lblColaborador.Text = "Colaborador"
        Me.lblColaborador.Width = 70
        '
        'txtColaborador
        '
        Me.txtColaborador.Name = "txtColaborador"
        Me.txtColaborador.Width = 630
        '
        'lblEmail
        '
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Text = "Email"
        Me.lblEmail.Width = 70
        '
        'txtEmail
        '
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Width = 630
        '
        'lblAraColab
        '
        Me.lblAraColab.Name = "lblAraColab"
        Me.lblAraColab.Text = "Área"
        Me.lblAraColab.Width = 70
        '
        'cmbArea
        '
        Me.cmbArea.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Width = 200
        '
        'lblCargo
        '
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Text = "Cargo"
        Me.lblCargo.Width = 70
        '
        'cmbCargo
        '
        Me.cmbCargo.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbCargo.Name = "cmbCargo"
        Me.cmbCargo.Width = 200
        '
        'lblSituacao
        '
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Text = "Situação"
        Me.lblSituacao.Width = 70
        '
        'optAtivo
        '
        Me.optAtivo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.optAtivo.Name = "optAtivo"
        Me.optAtivo.Text = "Ativo"
        Me.optAtivo.Width = 80
        '
        'optInativo
        '
        Me.optInativo.Name = "optInativo"
        Me.optInativo.Text = "Inativo"
        '
        'lblAprovador
        '
        Me.lblAprovador.Name = "lblAprovador"
        Me.lblAprovador.Text = "Aprovador :"
        Me.lblAprovador.Width = 70
        '
        'comboAprovador
        '
        Me.comboAprovador.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboAprovador.Items.Add(Me.optSim)
        Me.comboAprovador.Items.Add(Me.optNao)
        Me.comboAprovador.Name = "comboAprovador"
        Me.comboAprovador.Width = 76
        '
        'optSim
        '
        Me.optSim.Name = "optSim"
        Me.optSim.Text = "Sim"
        '
        'optNao
        '
        Me.optNao.Name = "optNao"
        Me.optNao.Text = "Não"
        '
        'configCadColaboradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 232)
        Me.Controls.Add(Me.C1InputPanel7)
        Me.Controls.Add(Me.C1InputPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "configCadColaboradores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Colaboradores"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblColaborador As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtColaborador As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblEmail As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtEmail As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblAraColab As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbArea As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblCargo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbCargo As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblSituacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents optAtivo As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents optInativo As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents lblAprovador As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboAprovador As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents optSim As C1.Win.C1InputPanel.InputOption
    Friend WithEvents optNao As C1.Win.C1InputPanel.InputOption
End Class
