<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configOpcoesPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configOpcoesPrincipal))
        Me.C1InputPanel14 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader12 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.PanelDefineNotas = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblMinimoNotaAva = New C1.Win.C1InputPanel.InputLabel()
        Me.txtMinimoNotaAva = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botDefineNotasOk = New C1.Win.C1InputPanel.InputButton()
        Me.botDefineNotasCancel = New C1.Win.C1InputPanel.InputButton()
        Me.PanelFornecedores = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputMenuFor = New C1.Win.C1InputPanel.InputMenu()
        Me.MenuAvalliacoes = New C1.Win.C1InputPanel.InputMenu()
        Me.botMenuNotas = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblSelecioneModulo = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbSelecioneModulo = New C1.Win.C1InputPanel.InputComboBox()
        CType(Me.C1InputPanel14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelDefineNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFornecedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel14
        '
        Me.C1InputPanel14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1InputPanel14.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel14.Items.Add(Me.InputGroupHeader12)
        Me.C1InputPanel14.Items.Add(Me.botSalvar)
        Me.C1InputPanel14.Location = New System.Drawing.Point(0, 503)
        Me.C1InputPanel14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.C1InputPanel14.Name = "C1InputPanel14"
        Me.C1InputPanel14.Size = New System.Drawing.Size(1008, 61)
        Me.C1InputPanel14.TabIndex = 36
        '
        'InputGroupHeader12
        '
        Me.InputGroupHeader12.Name = "InputGroupHeader12"
        Me.InputGroupHeader12.Text = "Opções"
        '
        'botSalvar
        '
        Me.botSalvar.Image = CType(resources.GetObject("botSalvar.Image"), System.Drawing.Image)
        Me.botSalvar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvar.Name = "botSalvar"
        Me.botSalvar.Text = "Salvar"
        Me.botSalvar.Width = 70
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BackgroundImage = CType(resources.GetObject("C1InputPanel2.BackgroundImage"), System.Drawing.Image)
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(1008, 183)
        Me.C1InputPanel2.TabIndex = 39
        '
        'PanelDefineNotas
        '
        Me.PanelDefineNotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDefineNotas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PanelDefineNotas.Items.Add(Me.InputGroupHeader3)
        Me.PanelDefineNotas.Items.Add(Me.lblMinimoNotaAva)
        Me.PanelDefineNotas.Items.Add(Me.txtMinimoNotaAva)
        Me.PanelDefineNotas.Items.Add(Me.InputGroupHeader4)
        Me.PanelDefineNotas.Items.Add(Me.botDefineNotasOk)
        Me.PanelDefineNotas.Items.Add(Me.botDefineNotasCancel)
        Me.PanelDefineNotas.Location = New System.Drawing.Point(48, 325)
        Me.PanelDefineNotas.Name = "PanelDefineNotas"
        Me.PanelDefineNotas.Size = New System.Drawing.Size(912, 119)
        Me.PanelDefineNotas.TabIndex = 42
        Me.PanelDefineNotas.Visible = False
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Definições de Notas"
        '
        'lblMinimoNotaAva
        '
        Me.lblMinimoNotaAva.Name = "lblMinimoNotaAva"
        Me.lblMinimoNotaAva.Text = "Defina o valor mínimo para a Nota da Avaliação"
        '
        'txtMinimoNotaAva
        '
        Me.txtMinimoNotaAva.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txtMinimoNotaAva.Name = "txtMinimoNotaAva"
        Me.txtMinimoNotaAva.Width = 50
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "Opções Notas"
        '
        'botDefineNotasOk
        '
        Me.botDefineNotasOk.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botDefineNotasOk.Image = CType(resources.GetObject("botDefineNotasOk.Image"), System.Drawing.Image)
        Me.botDefineNotasOk.ImageSize = New System.Drawing.Size(20, 20)
        Me.botDefineNotasOk.Name = "botDefineNotasOk"
        Me.botDefineNotasOk.Text = "Incluir"
        '
        'botDefineNotasCancel
        '
        Me.botDefineNotasCancel.Image = CType(resources.GetObject("botDefineNotasCancel.Image"), System.Drawing.Image)
        Me.botDefineNotasCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.botDefineNotasCancel.Name = "botDefineNotasCancel"
        Me.botDefineNotasCancel.Text = "Cancelar"
        '
        'PanelFornecedores
        '
        Me.PanelFornecedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFornecedores.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.PanelFornecedores.Items.Add(Me.InputGroupHeader2)
        Me.PanelFornecedores.Items.Add(Me.InputMenuFor)
        Me.PanelFornecedores.Location = New System.Drawing.Point(0, 237)
        Me.PanelFornecedores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelFornecedores.Name = "PanelFornecedores"
        Me.PanelFornecedores.Size = New System.Drawing.Size(1008, 266)
        Me.PanelFornecedores.TabIndex = 41
        Me.PanelFornecedores.Visible = False
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Fornecedores"
        '
        'InputMenuFor
        '
        Me.InputMenuFor.Image = CType(resources.GetObject("InputMenuFor.Image"), System.Drawing.Image)
        Me.InputMenuFor.ImageSize = New System.Drawing.Size(20, 20)
        Me.InputMenuFor.Items.Add(Me.MenuAvalliacoes)
        Me.InputMenuFor.Name = "InputMenuFor"
        Me.InputMenuFor.Text = "Menu"
        '
        'MenuAvalliacoes
        '
        Me.MenuAvalliacoes.Image = CType(resources.GetObject("MenuAvalliacoes.Image"), System.Drawing.Image)
        Me.MenuAvalliacoes.ImageSize = New System.Drawing.Size(20, 20)
        Me.MenuAvalliacoes.Items.Add(Me.botMenuNotas)
        Me.MenuAvalliacoes.Name = "MenuAvalliacoes"
        Me.MenuAvalliacoes.Text = "Menu Avaliações"
        '
        'botMenuNotas
        '
        Me.botMenuNotas.Image = CType(resources.GetObject("botMenuNotas.Image"), System.Drawing.Image)
        Me.botMenuNotas.ImageSize = New System.Drawing.Size(20, 20)
        Me.botMenuNotas.Name = "botMenuNotas"
        Me.botMenuNotas.Text = "Notas"
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.lblSelecioneModulo)
        Me.C1InputPanel1.Items.Add(Me.cmbSelecioneModulo)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 183)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1008, 54)
        Me.C1InputPanel1.TabIndex = 40
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Configurações do Iso é Fácil"
        '
        'lblSelecioneModulo
        '
        Me.lblSelecioneModulo.Name = "lblSelecioneModulo"
        Me.lblSelecioneModulo.Text = "Selecione o Módulo"
        '
        'cmbSelecioneModulo
        '
        Me.cmbSelecioneModulo.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbSelecioneModulo.Name = "cmbSelecioneModulo"
        Me.cmbSelecioneModulo.Width = 361
        '
        'configOpcoesPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1008, 564)
        Me.Controls.Add(Me.PanelDefineNotas)
        Me.Controls.Add(Me.PanelFornecedores)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel14)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.Name = "configOpcoesPrincipal"
        Me.Text = "Opções de Sistema"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1InputPanel14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelDefineNotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelFornecedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel14 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader12 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents PanelDefineNotas As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblMinimoNotaAva As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtMinimoNotaAva As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botDefineNotasOk As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botDefineNotasCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents PanelFornecedores As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputMenuFor As C1.Win.C1InputPanel.InputMenu
    Friend WithEvents MenuAvalliacoes As C1.Win.C1InputPanel.InputMenu
    Friend WithEvents botMenuNotas As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblSelecioneModulo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbSelecioneModulo As C1.Win.C1InputPanel.InputComboBox
End Class
