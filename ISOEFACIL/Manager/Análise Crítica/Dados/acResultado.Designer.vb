<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acResultado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acResultado))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarAnalise = New C1.Win.C1InputPanel.InputButton()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.tab1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarResultado = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.txtResultadoOutro = New C1.Win.C1InputPanel.InputTextBox()
        Me.tab2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtAnalise = New C1.Win.C1Input.C1TextBox()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.txtAnaliseOutro = New C1.Win.C1InputPanel.InputTextBox()
        Me.tab3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtProposicao = New C1.Win.C1Input.C1TextBox()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarProposicao = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.txtProposicaoOutro = New C1.Win.C1InputPanel.InputTextBox()
        Me.txtResultado = New C1.Win.C1Input.C1TextBox()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.tab1.SuspendLayout()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab2.SuspendLayout()
        CType(Me.txtAnalise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab3.SuspendLayout()
        CType(Me.txtProposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.botSalvarAnalise)
        Me.C1InputPanel2.Location = New System.Drawing.Point(13, 331)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(598, 64)
        Me.C1InputPanel2.TabIndex = 3
        '
        'grupoOpcoes
        '
        Me.grupoOpcoes.Name = "grupoOpcoes"
        Me.grupoOpcoes.Text = "Opções"
        '
        'botSalvarAnalise
        '
        Me.botSalvarAnalise.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botSalvarAnalise.Image = CType(resources.GetObject("botSalvarAnalise.Image"), System.Drawing.Image)
        Me.botSalvarAnalise.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarAnalise.Name = "botSalvarAnalise"
        Me.botSalvarAnalise.Text = "Salvar"
        Me.botSalvarAnalise.Width = 70
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.tab1)
        Me.C1DockingTab1.Controls.Add(Me.tab2)
        Me.C1DockingTab1.Controls.Add(Me.tab3)
        Me.C1DockingTab1.Location = New System.Drawing.Point(2, 2)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedIndex = 2
        Me.C1DockingTab1.Size = New System.Drawing.Size(626, 433)
        Me.C1DockingTab1.TabIndex = 4
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'tab1
        '
        Me.tab1.Controls.Add(Me.C1InputPanel6)
        Me.tab1.Controls.Add(Me.C1InputPanel1)
        Me.tab1.Location = New System.Drawing.Point(1, 26)
        Me.tab1.Name = "tab1"
        Me.tab1.Size = New System.Drawing.Size(624, 406)
        Me.tab1.TabIndex = 0
        Me.tab1.Text = "Resultado"
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel6.Items.Add(Me.botSalvarResultado)
        Me.C1InputPanel6.Location = New System.Drawing.Point(13, 331)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(598, 64)
        Me.C1InputPanel6.TabIndex = 6
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Opções"
        '
        'botSalvarResultado
        '
        Me.botSalvarResultado.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botSalvarResultado.Image = CType(resources.GetObject("botSalvarResultado.Image"), System.Drawing.Image)
        Me.botSalvarResultado.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarResultado.Name = "botSalvarResultado"
        Me.botSalvarResultado.Text = "Salvar"
        Me.botSalvarResultado.Width = 70
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.txtResultadoOutro)
        Me.C1InputPanel1.Location = New System.Drawing.Point(3, 7)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(618, 394)
        Me.C1InputPanel1.TabIndex = 0
        '
        'txtResultadoOutro
        '
        Me.txtResultadoOutro.Height = 318
        Me.txtResultadoOutro.Multiline = True
        Me.txtResultadoOutro.Name = "txtResultadoOutro"
        Me.txtResultadoOutro.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtResultadoOutro.Width = 598
        '
        'tab2
        '
        Me.tab2.Controls.Add(Me.txtAnalise)
        Me.tab2.Controls.Add(Me.C1InputPanel2)
        Me.tab2.Controls.Add(Me.C1InputPanel3)
        Me.tab2.Location = New System.Drawing.Point(1, 26)
        Me.tab2.Name = "tab2"
        Me.tab2.Size = New System.Drawing.Size(624, 406)
        Me.tab2.TabIndex = 1
        Me.tab2.Text = "Análise"
        '
        'txtAnalise
        '
        Me.txtAnalise.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtAnalise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnalise.Location = New System.Drawing.Point(13, 8)
        Me.txtAnalise.Multiline = True
        Me.txtAnalise.Name = "txtAnalise"
        Me.txtAnalise.Size = New System.Drawing.Size(598, 318)
        Me.txtAnalise.TabIndex = 5
        Me.txtAnalise.Tag = Nothing
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.txtAnaliseOutro)
        Me.C1InputPanel3.Location = New System.Drawing.Point(3, 7)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(618, 394)
        Me.C1InputPanel3.TabIndex = 1
        '
        'txtAnaliseOutro
        '
        Me.txtAnaliseOutro.Height = 318
        Me.txtAnaliseOutro.Multiline = True
        Me.txtAnaliseOutro.Name = "txtAnaliseOutro"
        Me.txtAnaliseOutro.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtAnaliseOutro.Width = 598
        '
        'tab3
        '
        Me.tab3.Controls.Add(Me.txtProposicao)
        Me.tab3.Controls.Add(Me.C1InputPanel5)
        Me.tab3.Controls.Add(Me.C1InputPanel4)
        Me.tab3.Location = New System.Drawing.Point(1, 26)
        Me.tab3.Name = "tab3"
        Me.tab3.Size = New System.Drawing.Size(624, 406)
        Me.tab3.TabIndex = 2
        Me.tab3.Text = "Proposições"
        '
        'txtProposicao
        '
        Me.txtProposicao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtProposicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProposicao.Location = New System.Drawing.Point(13, 8)
        Me.txtProposicao.Multiline = True
        Me.txtProposicao.Name = "txtProposicao"
        Me.txtProposicao.Size = New System.Drawing.Size(598, 318)
        Me.txtProposicao.TabIndex = 5
        Me.txtProposicao.Tag = Nothing
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel5.Items.Add(Me.botSalvarProposicao)
        Me.C1InputPanel5.Location = New System.Drawing.Point(13, 331)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(598, 64)
        Me.C1InputPanel5.TabIndex = 4
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
        '
        'botSalvarProposicao
        '
        Me.botSalvarProposicao.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botSalvarProposicao.Image = CType(resources.GetObject("botSalvarProposicao.Image"), System.Drawing.Image)
        Me.botSalvarProposicao.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarProposicao.Name = "botSalvarProposicao"
        Me.botSalvarProposicao.Text = "Salvar"
        Me.botSalvarProposicao.Width = 70
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel4.Items.Add(Me.txtProposicaoOutro)
        Me.C1InputPanel4.Location = New System.Drawing.Point(3, 7)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(618, 394)
        Me.C1InputPanel4.TabIndex = 2
        '
        'txtProposicaoOutro
        '
        Me.txtProposicaoOutro.Height = 318
        Me.txtProposicaoOutro.Multiline = True
        Me.txtProposicaoOutro.Name = "txtProposicaoOutro"
        Me.txtProposicaoOutro.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtProposicaoOutro.Width = 598
        '
        'txtResultado
        '
        Me.txtResultado.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultado.Location = New System.Drawing.Point(13, 10)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(598, 318)
        Me.txtResultado.TabIndex = 5
        Me.txtResultado.Tag = Nothing
        '
        'acResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 432)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "acResultado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Relatório de Dados"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.tab1.ResumeLayout(False)
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab2.ResumeLayout(False)
        CType(Me.txtAnalise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab3.ResumeLayout(False)
        CType(Me.txtProposicao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvarAnalise As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents tab2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents txtAnaliseOutro As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents tab3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvarProposicao As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents txtProposicaoOutro As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtAnalise As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtProposicao As C1.Win.C1Input.C1TextBox
    Friend WithEvents tab1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvarResultado As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents txtResultadoOutro As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtResultado As C1.Win.C1Input.C1TextBox
End Class
