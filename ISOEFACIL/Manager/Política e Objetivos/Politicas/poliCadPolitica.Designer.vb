<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class poliCadPolitica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(poliCadPolitica))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoCadastro = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblNome = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNome = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblRevisao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRevisao = New C1.Win.C1InputPanel.InputMaskedTextBox()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox1 = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblAprov = New C1.Win.C1InputPanel.InputLabel()
        Me.comboAprov = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dateData = New C1.Win.C1InputPanel.InputDatePicker()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.editTextodaPolitica = New C1.Win.C1Editor.C1Editor()
        Me.C1EditorToolStripObjects1 = New C1.Win.C1Editor.ToolStrips.C1EditorToolStripObjects()
        Me.C1EditorToolStripStyle1 = New C1.Win.C1Editor.ToolStrips.C1EditorToolStripStyle()
        Me.C1EditorToolStripMain1 = New C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editTextodaPolitica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.grupoCadastro)
        Me.C1InputPanel1.Items.Add(Me.lblNome)
        Me.C1InputPanel1.Items.Add(Me.txtNome)
        Me.C1InputPanel1.Items.Add(Me.lblRevisao)
        Me.C1InputPanel1.Items.Add(Me.txtRevisao)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.InputTextBox1)
        Me.C1InputPanel1.Items.Add(Me.lblAprov)
        Me.C1InputPanel1.Items.Add(Me.comboAprov)
        Me.C1InputPanel1.Items.Add(Me.lblData)
        Me.C1InputPanel1.Items.Add(Me.dateData)
        Me.C1InputPanel1.Location = New System.Drawing.Point(1, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(707, 493)
        Me.C1InputPanel1.TabIndex = 0
        '
        'grupoCadastro
        '
        Me.grupoCadastro.Name = "grupoCadastro"
        Me.grupoCadastro.Text = "Cadastrar Política"
        '
        'lblNome
        '
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Text = "Nome:"
        Me.lblNome.Width = 140
        '
        'txtNome
        '
        Me.txtNome.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Width = 440
        '
        'lblRevisao
        '
        Me.lblRevisao.Name = "lblRevisao"
        Me.lblRevisao.Text = "Revisão:"
        Me.lblRevisao.Width = 59
        '
        'txtRevisao
        '
        Me.txtRevisao.Enabled = False
        Me.txtRevisao.Mask = "00"
        Me.txtRevisao.Name = "txtRevisao"
        Me.txtRevisao.Width = 38
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Texto da Política"
        '
        'InputLabel1
        '
        Me.InputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel1.Name = "InputLabel1"
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Name = "InputLabel2"
        '
        'InputLabel3
        '
        Me.InputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel3.Name = "InputLabel3"
        '
        'InputLabel4
        '
        Me.InputLabel4.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel4.Name = "InputLabel4"
        '
        'InputTextBox1
        '
        Me.InputTextBox1.Height = 300
        Me.InputTextBox1.Multiline = True
        Me.InputTextBox1.Name = "InputTextBox1"
        Me.InputTextBox1.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.InputTextBox1.Width = 545
        '
        'lblAprov
        '
        Me.lblAprov.Name = "lblAprov"
        Me.lblAprov.Text = "Aprovador:"
        Me.lblAprov.Width = 140
        '
        'comboAprov
        '
        Me.comboAprov.Break = C1.Win.C1InputPanel.BreakType.None
        Me.comboAprov.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboAprov.Name = "comboAprov"
        Me.comboAprov.Width = 331
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Text = "Data:"
        Me.lblData.Width = 106
        '
        'dateData
        '
        Me.dateData.Name = "dateData"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Location = New System.Drawing.Point(1, 492)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(707, 64)
        Me.C1InputPanel2.TabIndex = 1
        '
        'grupoOpcoes
        '
        Me.grupoOpcoes.Name = "grupoOpcoes"
        Me.grupoOpcoes.Text = "Opções"
        '
        'botSalvar
        '
        Me.botSalvar.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botSalvar.Image = CType(resources.GetObject("botSalvar.Image"), System.Drawing.Image)
        Me.botSalvar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvar.Name = "botSalvar"
        Me.botSalvar.Text = "Salvar"
        Me.botSalvar.Width = 70
        '
        'editTextodaPolitica
        '
        Me.editTextodaPolitica.Location = New System.Drawing.Point(10, 131)
        Me.editTextodaPolitica.MinimumSize = New System.Drawing.Size(167, 167)
        Me.editTextodaPolitica.Name = "editTextodaPolitica"
        Me.editTextodaPolitica.Size = New System.Drawing.Size(690, 318)
        Me.editTextodaPolitica.TabIndex = 12
        '
        'C1EditorToolStripObjects1
        '
        Me.C1EditorToolStripObjects1.Dock = System.Windows.Forms.DockStyle.None
        Me.C1EditorToolStripObjects1.Editor = Me.editTextodaPolitica
        Me.C1EditorToolStripObjects1.Location = New System.Drawing.Point(394, 105)
        Me.C1EditorToolStripObjects1.Name = "C1EditorToolStripObjects1"
        Me.C1EditorToolStripObjects1.Size = New System.Drawing.Size(127, 25)
        Me.C1EditorToolStripObjects1.TabIndex = 16
        Me.C1EditorToolStripObjects1.Text = "C1EditorToolStripObjects1"
        '
        'C1EditorToolStripStyle1
        '
        Me.C1EditorToolStripStyle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.C1EditorToolStripStyle1.Dock = System.Windows.Forms.DockStyle.None
        Me.C1EditorToolStripStyle1.Editor = Me.editTextodaPolitica
        Me.C1EditorToolStripStyle1.Location = New System.Drawing.Point(13, 80)
        Me.C1EditorToolStripStyle1.Name = "C1EditorToolStripStyle1"
        Me.C1EditorToolStripStyle1.Size = New System.Drawing.Size(687, 25)
        Me.C1EditorToolStripStyle1.TabIndex = 17
        '
        'C1EditorToolStripMain1
        '
        Me.C1EditorToolStripMain1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.C1EditorToolStripMain1.Dock = System.Windows.Forms.DockStyle.None
        Me.C1EditorToolStripMain1.Editor = Me.editTextodaPolitica
        Me.C1EditorToolStripMain1.Location = New System.Drawing.Point(13, 105)
        Me.C1EditorToolStripMain1.Name = "C1EditorToolStripMain1"
        Me.C1EditorToolStripMain1.Size = New System.Drawing.Size(381, 25)
        Me.C1EditorToolStripMain1.TabIndex = 18
        '
        'poliCadPolitica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 556)
        Me.Controls.Add(Me.C1EditorToolStripMain1)
        Me.Controls.Add(Me.C1EditorToolStripObjects1)
        Me.Controls.Add(Me.C1EditorToolStripStyle1)
        Me.Controls.Add(Me.editTextodaPolitica)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "poliCadPolitica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Política"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editTextodaPolitica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoCadastro As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblNome As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNome As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblAprov As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboAprov As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateData As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblRevisao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtRevisao As C1.Win.C1InputPanel.InputMaskedTextBox
    Friend WithEvents InputTextBox1 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents editTextodaPolitica As C1.Win.C1Editor.C1Editor
    Friend WithEvents C1EditorToolStripObjects1 As C1.Win.C1Editor.ToolStrips.C1EditorToolStripObjects
    Friend WithEvents C1EditorToolStripStyle1 As C1.Win.C1Editor.ToolStrips.C1EditorToolStripStyle
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1EditorToolStripMain1 As C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
End Class
