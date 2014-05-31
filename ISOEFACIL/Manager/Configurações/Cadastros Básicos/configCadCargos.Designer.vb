<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configCadCargos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configCadCargos))
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblCargo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtCargo = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblAprovador = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbAprovador = New C1.Win.C1InputPanel.InputComboBox()
        Me.optSim = New C1.Win.C1InputPanel.InputOption()
        Me.optNao = New C1.Win.C1InputPanel.InputOption()
        Me.lblSetor = New C1.Win.C1InputPanel.InputLabel()
        Me.optAtivo = New C1.Win.C1InputPanel.InputRadioButton()
        Me.optInativo = New C1.Win.C1InputPanel.InputRadioButton()
        Me.C1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel6.Items.Add(Me.lblCargo)
        Me.C1InputPanel6.Items.Add(Me.txtCargo)
        Me.C1InputPanel6.Items.Add(Me.lblAprovador)
        Me.C1InputPanel6.Items.Add(Me.cmbAprovador)
        Me.C1InputPanel6.Items.Add(Me.lblSetor)
        Me.C1InputPanel6.Items.Add(Me.optAtivo)
        Me.C1InputPanel6.Items.Add(Me.optInativo)
        Me.C1InputPanel6.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(759, 74)
        Me.C1InputPanel6.TabIndex = 33
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "Cadastro de Cargos"
        '
        'lblCargo
        '
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Text = "Cargo"
        Me.lblCargo.Width = 80
        '
        'txtCargo
        '
        Me.txtCargo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Width = 500
        '
        'lblAprovador
        '
        Me.lblAprovador.Name = "lblAprovador"
        Me.lblAprovador.Text = "Aprovador"
        Me.lblAprovador.Width = 72
        '
        'cmbAprovador
        '
        Me.cmbAprovador.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbAprovador.Items.Add(Me.optSim)
        Me.cmbAprovador.Items.Add(Me.optNao)
        Me.cmbAprovador.Name = "cmbAprovador"
        Me.cmbAprovador.Width = 76
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
        'lblSetor
        '
        Me.lblSetor.Name = "lblSetor"
        Me.lblSetor.Text = "Situação"
        Me.lblSetor.Width = 80
        '
        'optAtivo
        '
        Me.optAtivo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.optAtivo.Name = "optAtivo"
        Me.optAtivo.Text = "Ativo"
        '
        'optInativo
        '
        Me.optInativo.Name = "optInativo"
        Me.optInativo.Text = "Inativo"
        '
        'C1InputPanel7
        '
        Me.C1InputPanel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel7.Items.Add(Me.InputGroupHeader5)
        Me.C1InputPanel7.Items.Add(Me.botSalvar)
        Me.C1InputPanel7.Location = New System.Drawing.Point(0, 69)
        Me.C1InputPanel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.C1InputPanel7.Name = "C1InputPanel7"
        Me.C1InputPanel7.Size = New System.Drawing.Size(759, 61)
        Me.C1InputPanel7.TabIndex = 40
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
        'configCadCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 130)
        Me.Controls.Add(Me.C1InputPanel7)
        Me.Controls.Add(Me.C1InputPanel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "configCadCargos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Cargos"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblCargo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCargo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblAprovador As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbAprovador As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents optSim As C1.Win.C1InputPanel.InputOption
    Friend WithEvents optNao As C1.Win.C1InputPanel.InputOption
    Friend WithEvents lblSetor As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents optAtivo As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents optInativo As C1.Win.C1InputPanel.InputRadioButton
End Class
