<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cotrCadExperiencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cotrCadExperiencia))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.botSemExp = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblEmpresa = New C1.Win.C1InputPanel.InputLabel()
        Me.txtEmpresa = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblCargo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtCargo = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblAtividades = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAtividade = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblAdmissao = New C1.Win.C1InputPanel.InputLabel()
        Me.dtAdmissao = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblDesligamento = New C1.Win.C1InputPanel.InputLabel()
        Me.dtDesligamento = New C1.Win.C1InputPanel.InputDatePicker()
        Me.txtAtividades = New C1.Win.C1Input.C1TextBox()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAtividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Items.Add(Me.botSemExp)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 201)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(598, 64)
        Me.C1InputPanel2.TabIndex = 3
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
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
        'botSemExp
        '
        Me.botSemExp.Image = CType(resources.GetObject("botSemExp.Image"), System.Drawing.Image)
        Me.botSemExp.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSemExp.Name = "botSemExp"
        Me.botSemExp.Text = "Sem Experinência"
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.lblEmpresa)
        Me.C1InputPanel1.Items.Add(Me.txtEmpresa)
        Me.C1InputPanel1.Items.Add(Me.lblCargo)
        Me.C1InputPanel1.Items.Add(Me.txtCargo)
        Me.C1InputPanel1.Items.Add(Me.lblAtividades)
        Me.C1InputPanel1.Items.Add(Me.txtAtividade)
        Me.C1InputPanel1.Items.Add(Me.lblAdmissao)
        Me.C1InputPanel1.Items.Add(Me.dtAdmissao)
        Me.C1InputPanel1.Items.Add(Me.lblDesligamento)
        Me.C1InputPanel1.Items.Add(Me.dtDesligamento)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(598, 201)
        Me.C1InputPanel1.TabIndex = 2
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Experiência Profissional"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Text = "Empresa"
        Me.lblEmpresa.Width = 109
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Width = 455
        '
        'lblCargo
        '
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Text = "Cargo"
        Me.lblCargo.Width = 109
        '
        'txtCargo
        '
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Width = 455
        '
        'lblAtividades
        '
        Me.lblAtividades.Name = "lblAtividades"
        Me.lblAtividades.Text = "Atividades"
        Me.lblAtividades.Width = 109
        '
        'txtAtividade
        '
        Me.txtAtividade.Height = 97
        Me.txtAtividade.Multiline = True
        Me.txtAtividade.Name = "txtAtividade"
        Me.txtAtividade.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtAtividade.Width = 455
        '
        'lblAdmissao
        '
        Me.lblAdmissao.Name = "lblAdmissao"
        Me.lblAdmissao.Text = "Admissão"
        Me.lblAdmissao.Width = 109
        '
        'dtAdmissao
        '
        Me.dtAdmissao.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtAdmissao.Name = "dtAdmissao"
        Me.dtAdmissao.Width = 109
        '
        'lblDesligamento
        '
        Me.lblDesligamento.Name = "lblDesligamento"
        Me.lblDesligamento.Text = "Desligamento"
        '
        'dtDesligamento
        '
        Me.dtDesligamento.Name = "dtDesligamento"
        Me.dtDesligamento.Width = 109
        '
        'txtAtividades
        '
        Me.txtAtividades.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtAtividades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAtividades.Location = New System.Drawing.Point(123, 75)
        Me.txtAtividades.Multiline = True
        Me.txtAtividades.Name = "txtAtividades"
        Me.txtAtividades.Size = New System.Drawing.Size(454, 95)
        Me.txtAtividades.TabIndex = 4
        Me.txtAtividades.Tag = Nothing
        Me.txtAtividades.TextDetached = True
        '
        'cotrCadExperiencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 264)
        Me.Controls.Add(Me.txtAtividades)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cotrCadExperiencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Experiências"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAtividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botSemExp As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblEmpresa As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtEmpresa As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblCargo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCargo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblAtividades As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAtividade As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblAdmissao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtAdmissao As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblDesligamento As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtDesligamento As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents txtAtividades As C1.Win.C1Input.C1TextBox
End Class
