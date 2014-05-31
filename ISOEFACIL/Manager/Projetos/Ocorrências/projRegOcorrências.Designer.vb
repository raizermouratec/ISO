<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projRegOcorrências
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projRegOcorrências))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOcorrencias = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblProjeto = New C1.Win.C1InputPanel.InputLabel()
        Me.comboTipoProjeto = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblTituloOcorrencia = New C1.Win.C1InputPanel.InputLabel()
        Me.txtTituloOcorrencia = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblDescOcorrencia = New C1.Win.C1InputPanel.InputLabel()
        Me.txtDescOcorrenciax = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblResp = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResp = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dateData = New C1.Win.C1InputPanel.InputDatePicker()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.txtDescOcorrencia = New C1.Win.C1Input.C1TextBox()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescOcorrencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.grupoOcorrencias)
        Me.C1InputPanel1.Items.Add(Me.lblProjeto)
        Me.C1InputPanel1.Items.Add(Me.comboTipoProjeto)
        Me.C1InputPanel1.Items.Add(Me.lblTituloOcorrencia)
        Me.C1InputPanel1.Items.Add(Me.txtTituloOcorrencia)
        Me.C1InputPanel1.Items.Add(Me.lblDescOcorrencia)
        Me.C1InputPanel1.Items.Add(Me.txtDescOcorrenciax)
        Me.C1InputPanel1.Items.Add(Me.lblResp)
        Me.C1InputPanel1.Items.Add(Me.comboResp)
        Me.C1InputPanel1.Items.Add(Me.lblData)
        Me.C1InputPanel1.Items.Add(Me.dateData)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(599, 180)
        Me.C1InputPanel1.TabIndex = 1
        '
        'grupoOcorrencias
        '
        Me.grupoOcorrencias.Name = "grupoOcorrencias"
        Me.grupoOcorrencias.Text = "Registro de Ocorrências"
        '
        'lblProjeto
        '
        Me.lblProjeto.Name = "lblProjeto"
        Me.lblProjeto.Text = "Projeto:"
        Me.lblProjeto.Width = 103
        '
        'comboTipoProjeto
        '
        Me.comboTipoProjeto.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboTipoProjeto.Name = "comboTipoProjeto"
        Me.comboTipoProjeto.Width = 269
        '
        'lblTituloOcorrencia
        '
        Me.lblTituloOcorrencia.Name = "lblTituloOcorrencia"
        Me.lblTituloOcorrencia.Text = "Título da Atividade:"
        '
        'txtTituloOcorrencia
        '
        Me.txtTituloOcorrencia.Name = "txtTituloOcorrencia"
        Me.txtTituloOcorrencia.Width = 477
        '
        'lblDescOcorrencia
        '
        Me.lblDescOcorrencia.Name = "lblDescOcorrencia"
        Me.lblDescOcorrencia.Text = "Descrição:"
        Me.lblDescOcorrencia.Width = 103
        '
        'txtDescOcorrenciax
        '
        Me.txtDescOcorrenciax.Height = 66
        Me.txtDescOcorrenciax.Multiline = True
        Me.txtDescOcorrenciax.Name = "txtDescOcorrenciax"
        Me.txtDescOcorrenciax.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtDescOcorrenciax.Width = 477
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
        Me.comboResp.Width = 269
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Text = "Data:"
        Me.lblData.Width = 100
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
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 183)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(599, 64)
        Me.C1InputPanel2.TabIndex = 2
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
        'txtDescOcorrencia
        '
        Me.txtDescOcorrencia.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtDescOcorrencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescOcorrencia.Location = New System.Drawing.Point(117, 79)
        Me.txtDescOcorrencia.Multiline = True
        Me.txtDescOcorrencia.Name = "txtDescOcorrencia"
        Me.txtDescOcorrencia.Size = New System.Drawing.Size(477, 66)
        Me.txtDescOcorrencia.TabIndex = 3
        Me.txtDescOcorrencia.Tag = Nothing
        Me.txtDescOcorrencia.TextDetached = True
        '
        'projRegOcorrências
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 247)
        Me.Controls.Add(Me.txtDescOcorrencia)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "projRegOcorrências"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Ocorrências"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescOcorrencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOcorrencias As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblProjeto As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboTipoProjeto As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblTituloOcorrencia As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtTituloOcorrencia As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblDescOcorrencia As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtDescOcorrenciax As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblResp As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResp As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateData As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtDescOcorrencia As C1.Win.C1Input.C1TextBox
End Class
