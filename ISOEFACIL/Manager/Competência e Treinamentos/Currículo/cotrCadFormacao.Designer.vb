<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cotrCadFormacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cotrCadFormacao))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblFormacao = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbFormacao = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblSituacao = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbSituacao = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputOption1 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption2 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption3 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption4 = New C1.Win.C1InputPanel.InputOption()
        Me.lblCurso = New C1.Win.C1InputPanel.InputLabel()
        Me.txtCurso = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblInstituicao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtInstituicao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblDuracao = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAno = New C1.Win.C1InputPanel.InputLabel()
        Me.mskAno = New C1.Win.C1InputPanel.InputMaskedTextBox()
        Me.lblMes = New C1.Win.C1InputPanel.InputLabel()
        Me.mskMes = New C1.Win.C1InputPanel.InputMaskedTextBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dtCoclusao = New C1.Win.C1InputPanel.InputDatePicker()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.lblFormacao)
        Me.C1InputPanel1.Items.Add(Me.cmbFormacao)
        Me.C1InputPanel1.Items.Add(Me.lblSituacao)
        Me.C1InputPanel1.Items.Add(Me.cmbSituacao)
        Me.C1InputPanel1.Items.Add(Me.lblCurso)
        Me.C1InputPanel1.Items.Add(Me.txtCurso)
        Me.C1InputPanel1.Items.Add(Me.lblInstituicao)
        Me.C1InputPanel1.Items.Add(Me.txtInstituicao)
        Me.C1InputPanel1.Items.Add(Me.lblDuracao)
        Me.C1InputPanel1.Items.Add(Me.lblAno)
        Me.C1InputPanel1.Items.Add(Me.mskAno)
        Me.C1InputPanel1.Items.Add(Me.lblMes)
        Me.C1InputPanel1.Items.Add(Me.mskMes)
        Me.C1InputPanel1.Items.Add(Me.lblData)
        Me.C1InputPanel1.Items.Add(Me.dtCoclusao)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 1)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(580, 176)
        Me.C1InputPanel1.TabIndex = 0
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Cadastrar Formação"
        '
        'lblFormacao
        '
        Me.lblFormacao.Name = "lblFormacao"
        Me.lblFormacao.Text = "Tipo de Formação"
        Me.lblFormacao.Width = 109
        '
        'cmbFormacao
        '
        Me.cmbFormacao.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbFormacao.Name = "cmbFormacao"
        Me.cmbFormacao.Width = 442
        '
        'lblSituacao
        '
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Text = "Situcação"
        Me.lblSituacao.Width = 109
        '
        'cmbSituacao
        '
        Me.cmbSituacao.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbSituacao.Items.Add(Me.InputOption1)
        Me.cmbSituacao.Items.Add(Me.InputOption2)
        Me.cmbSituacao.Items.Add(Me.InputOption3)
        Me.cmbSituacao.Items.Add(Me.InputOption4)
        Me.cmbSituacao.Name = "cmbSituacao"
        Me.cmbSituacao.Width = 442
        '
        'InputOption1
        '
        Me.InputOption1.Name = "InputOption1"
        Me.InputOption1.Text = "Completo"
        '
        'InputOption2
        '
        Me.InputOption2.Name = "InputOption2"
        Me.InputOption2.Text = "Cursando"
        '
        'InputOption3
        '
        Me.InputOption3.Name = "InputOption3"
        Me.InputOption3.Text = "Incompleto"
        '
        'InputOption4
        '
        Me.InputOption4.Name = "InputOption4"
        Me.InputOption4.Text = "Em andamento"
        '
        'lblCurso
        '
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Text = "Curso"
        Me.lblCurso.Width = 109
        '
        'txtCurso
        '
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Width = 442
        '
        'lblInstituicao
        '
        Me.lblInstituicao.Name = "lblInstituicao"
        Me.lblInstituicao.Text = "Instituição de Ensino"
        '
        'txtInstituicao
        '
        Me.txtInstituicao.Name = "txtInstituicao"
        Me.txtInstituicao.Width = 442
        '
        'lblDuracao
        '
        Me.lblDuracao.Name = "lblDuracao"
        Me.lblDuracao.Text = "Duração do Curso"
        Me.lblDuracao.Width = 109
        '
        'lblAno
        '
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Text = "Ano"
        '
        'mskAno
        '
        Me.mskAno.Break = C1.Win.C1InputPanel.BreakType.None
        Me.mskAno.Mask = "00"
        Me.mskAno.Name = "mskAno"
        Me.mskAno.Width = 23
        '
        'lblMes
        '
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Text = "Mês"
        '
        'mskMes
        '
        Me.mskMes.Mask = "00"
        Me.mskMes.Name = "mskMes"
        Me.mskMes.Width = 22
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Text = "Data de Conclusão"
        Me.lblData.Width = 109
        '
        'dtCoclusao
        '
        Me.dtCoclusao.Name = "dtCoclusao"
        Me.dtCoclusao.Width = 99
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 174)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(580, 64)
        Me.C1InputPanel2.TabIndex = 1
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
        'cotrCadFormacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 236)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "cotrCadFormacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Formação"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblFormacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbFormacao As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblSituacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbSituacao As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblInstituicao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtInstituicao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblCurso As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCurso As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblDuracao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAno As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents mskAno As C1.Win.C1InputPanel.InputMaskedTextBox
    Friend WithEvents lblMes As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents mskMes As C1.Win.C1InputPanel.InputMaskedTextBox
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtCoclusao As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputOption1 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputOption2 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputOption3 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputOption4 As C1.Win.C1InputPanel.InputOption
End Class
