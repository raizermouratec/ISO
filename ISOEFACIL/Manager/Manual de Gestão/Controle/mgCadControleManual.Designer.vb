<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mgCadControleManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mgCadControleManual))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblTipo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtTipo = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblCodigo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtCodigo = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblRevisao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRevisao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblTítulo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtTítulo = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblSituacao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSituacao = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblNorma = New C1.Win.C1InputPanel.InputLabel()
        Me.comboNormaBase = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblNormasComplementar = New C1.Win.C1InputPanel.InputLabel()
        Me.checkComplementar = New C1.Win.C1InputPanel.InputCheckBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dateData = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblResp = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResp = New C1.Win.C1InputPanel.InputComboBox()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.gridNormasComplementares = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridNormasComplementares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.lblTipo)
        Me.C1InputPanel1.Items.Add(Me.txtTipo)
        Me.C1InputPanel1.Items.Add(Me.lblCodigo)
        Me.C1InputPanel1.Items.Add(Me.txtCodigo)
        Me.C1InputPanel1.Items.Add(Me.lblRevisao)
        Me.C1InputPanel1.Items.Add(Me.txtRevisao)
        Me.C1InputPanel1.Items.Add(Me.lblTítulo)
        Me.C1InputPanel1.Items.Add(Me.txtTítulo)
        Me.C1InputPanel1.Items.Add(Me.lblSituacao)
        Me.C1InputPanel1.Items.Add(Me.txtSituacao)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.lblNorma)
        Me.C1InputPanel1.Items.Add(Me.comboNormaBase)
        Me.C1InputPanel1.Items.Add(Me.lblNormasComplementar)
        Me.C1InputPanel1.Items.Add(Me.checkComplementar)
        Me.C1InputPanel1.Items.Add(Me.lblData)
        Me.C1InputPanel1.Items.Add(Me.dateData)
        Me.C1InputPanel1.Items.Add(Me.lblResp)
        Me.C1InputPanel1.Items.Add(Me.comboResp)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(572, 327)
        Me.C1InputPanel1.TabIndex = 0
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Cadastar Novo Manual de Gestão"
        '
        'lblTipo
        '
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Text = "Tipo :"
        Me.lblTipo.Width = 69
        '
        'txtTipo
        '
        Me.txtTipo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtTipo.Enabled = False
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Width = 145
        '
        'lblCodigo
        '
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.lblCodigo.Text = "Código :"
        Me.lblCodigo.Width = 99
        '
        'txtCodigo
        '
        Me.txtCodigo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Width = 66
        '
        'lblRevisao
        '
        Me.lblRevisao.Name = "lblRevisao"
        Me.lblRevisao.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.lblRevisao.Text = "Revisão :"
        Me.lblRevisao.Width = 122
        '
        'txtRevisao
        '
        Me.txtRevisao.Enabled = False
        Me.txtRevisao.Name = "txtRevisao"
        Me.txtRevisao.Width = 31
        '
        'lblTítulo
        '
        Me.lblTítulo.Name = "lblTítulo"
        Me.lblTítulo.Text = "Título :"
        Me.lblTítulo.Width = 69
        '
        'txtTítulo
        '
        Me.txtTítulo.Name = "txtTítulo"
        Me.txtTítulo.Width = 479
        '
        'lblSituacao
        '
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Text = "Situação :"
        Me.lblSituacao.Width = 69
        '
        'txtSituacao
        '
        Me.txtSituacao.Enabled = False
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Width = 149
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Referência"
        '
        'lblNorma
        '
        Me.lblNorma.Name = "lblNorma"
        Me.lblNorma.Text = "Norma Base :"
        '
        'comboNormaBase
        '
        Me.comboNormaBase.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboNormaBase.Name = "comboNormaBase"
        Me.comboNormaBase.Width = 478
        '
        'lblNormasComplementar
        '
        Me.lblNormasComplementar.Name = "lblNormasComplementar"
        Me.lblNormasComplementar.Text = "Normas Complementares :"
        '
        'checkComplementar
        '
        Me.checkComplementar.Name = "checkComplementar"
        Me.checkComplementar.Width = 18
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Padding = New System.Windows.Forms.Padding(0, 90, 0, 0)
        Me.lblData.Text = "Data de Cadastro :"
        '
        'dateData
        '
        Me.dateData.Name = "dateData"
        Me.dateData.Padding = New System.Windows.Forms.Padding(0, 90, 0, 0)
        '
        'lblResp
        '
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Text = "Responsável :"
        Me.lblResp.Width = 96
        '
        'comboResp
        '
        Me.comboResp.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResp.Name = "comboResp"
        Me.comboResp.Width = 341
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel6.Items.Add(Me.botSalvar)
        Me.C1InputPanel6.Location = New System.Drawing.Point(0, 327)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(572, 64)
        Me.C1InputPanel6.TabIndex = 17
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "Opções"
        '
        'botSalvar
        '
        Me.botSalvar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botSalvar.Image = CType(resources.GetObject("botSalvar.Image"), System.Drawing.Image)
        Me.botSalvar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvar.Name = "botSalvar"
        Me.botSalvar.Text = "Salvar"
        Me.botSalvar.Width = 74
        '
        'gridNormasComplementares
        '
        Me.gridNormasComplementares.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridNormasComplementares.AllowEditing = False
        Me.gridNormasComplementares.AllowFiltering = True
        Me.gridNormasComplementares.ColumnInfo = resources.GetString("gridNormasComplementares.ColumnInfo")
        Me.gridNormasComplementares.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridNormasComplementares.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridNormasComplementares.Location = New System.Drawing.Point(12, 177)
        Me.gridNormasComplementares.Name = "gridNormasComplementares"
        Me.gridNormasComplementares.Rows.DefaultSize = 21
        Me.gridNormasComplementares.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridNormasComplementares.Size = New System.Drawing.Size(550, 87)
        Me.gridNormasComplementares.StyleInfo = resources.GetString("gridNormasComplementares.StyleInfo")
        Me.gridNormasComplementares.TabIndex = 18
        Me.gridNormasComplementares.Visible = False
        '
        'mgCadControleManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 391)
        Me.Controls.Add(Me.gridNormasComplementares)
        Me.Controls.Add(Me.C1InputPanel6)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "mgCadControleManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Manuais"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridNormasComplementares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblTipo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblCodigo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCodigo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblTítulo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtTítulo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblRevisao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtRevisao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblSituacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtSituacao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtTipo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblNorma As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboNormaBase As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblNormasComplementar As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents checkComplementar As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents gridNormasComplementares As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateData As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblResp As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResp As C1.Win.C1InputPanel.InputComboBox
End Class
