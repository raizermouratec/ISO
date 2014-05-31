<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prodCadClassificacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prodCadClassificacao))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblGrupo = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbGrupos = New C1.Win.C1InputPanel.InputComboBox()
        Me.radioNovoGrupo = New C1.Win.C1InputPanel.InputRadioButton()
        Me.lblSubGrupo = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbSubGrupos = New C1.Win.C1InputPanel.InputComboBox()
        Me.radioNovoSubgrupo = New C1.Win.C1InputPanel.InputRadioButton()
        Me.lblNovoGrupo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNovoGrupo = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblNovoSubGrupo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNovoSubGrupo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botIncluir = New C1.Win.C1InputPanel.InputButton()
        Me.gridClassificacao = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridClassificacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.lblGrupo)
        Me.C1InputPanel1.Items.Add(Me.cmbGrupos)
        Me.C1InputPanel1.Items.Add(Me.radioNovoGrupo)
        Me.C1InputPanel1.Items.Add(Me.lblSubGrupo)
        Me.C1InputPanel1.Items.Add(Me.cmbSubGrupos)
        Me.C1InputPanel1.Items.Add(Me.radioNovoSubgrupo)
        Me.C1InputPanel1.Items.Add(Me.lblNovoGrupo)
        Me.C1InputPanel1.Items.Add(Me.txtNovoGrupo)
        Me.C1InputPanel1.Items.Add(Me.lblNovoSubGrupo)
        Me.C1InputPanel1.Items.Add(Me.txtNovoSubGrupo)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(598, 460)
        Me.C1InputPanel1.TabIndex = 0
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Cadastrar Grupos"
        '
        'lblGrupo
        '
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Text = "Grupos"
        Me.lblGrupo.Width = 92
        '
        'cmbGrupos
        '
        Me.cmbGrupos.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbGrupos.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbGrupos.MaxDropDownItems = 100
        Me.cmbGrupos.Name = "cmbGrupos"
        Me.cmbGrupos.Width = 230
        '
        'radioNovoGrupo
        '
        Me.radioNovoGrupo.Name = "radioNovoGrupo"
        Me.radioNovoGrupo.Text = "Cadastrar Novo Grupo"
        '
        'lblSubGrupo
        '
        Me.lblSubGrupo.Name = "lblSubGrupo"
        Me.lblSubGrupo.Text = "SubGrupos"
        Me.lblSubGrupo.Width = 92
        '
        'cmbSubGrupos
        '
        Me.cmbSubGrupos.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbSubGrupos.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbSubGrupos.Name = "cmbSubGrupos"
        Me.cmbSubGrupos.Width = 230
        '
        'radioNovoSubgrupo
        '
        Me.radioNovoSubgrupo.Name = "radioNovoSubgrupo"
        Me.radioNovoSubgrupo.Text = "Cadastrar Novo Sub Grupo"
        '
        'lblNovoGrupo
        '
        Me.lblNovoGrupo.Height = 16
        Me.lblNovoGrupo.Name = "lblNovoGrupo"
        Me.lblNovoGrupo.Text = "Novo Grupo"
        Me.lblNovoGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblNovoGrupo.Width = 92
        '
        'txtNovoGrupo
        '
        Me.txtNovoGrupo.Name = "txtNovoGrupo"
        Me.txtNovoGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.txtNovoGrupo.Width = 230
        '
        'lblNovoSubGrupo
        '
        Me.lblNovoSubGrupo.Name = "lblNovoSubGrupo"
        Me.lblNovoSubGrupo.Text = "Novo Subgrupo"
        Me.lblNovoSubGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblNovoSubGrupo.Width = 92
        '
        'txtNovoSubGrupo
        '
        Me.txtNovoSubGrupo.Name = "txtNovoSubGrupo"
        Me.txtNovoSubGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.txtNovoSubGrupo.Width = 230
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Lista de Grupos / Sub-Grupos"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.botIncluir)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 401)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(598, 59)
        Me.C1InputPanel2.TabIndex = 29
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Opções"
        '
        'botIncluir
        '
        Me.botIncluir.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botIncluir.Image = CType(resources.GetObject("botIncluir.Image"), System.Drawing.Image)
        Me.botIncluir.ImageSize = New System.Drawing.Size(20, 20)
        Me.botIncluir.Name = "botIncluir"
        Me.botIncluir.Text = "Incluir"
        Me.botIncluir.Width = 70
        '
        'gridClassificacao
        '
        Me.gridClassificacao.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridClassificacao.AllowEditing = False
        Me.gridClassificacao.AllowFiltering = True
        Me.gridClassificacao.ColumnInfo = resources.GetString("gridClassificacao.ColumnInfo")
        Me.gridClassificacao.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridClassificacao.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridClassificacao.Location = New System.Drawing.Point(11, 155)
        Me.gridClassificacao.Name = "gridClassificacao"
        Me.gridClassificacao.Rows.DefaultSize = 21
        Me.gridClassificacao.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridClassificacao.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridClassificacao.Size = New System.Drawing.Size(575, 230)
        Me.gridClassificacao.StyleInfo = resources.GetString("gridClassificacao.StyleInfo")
        Me.gridClassificacao.TabIndex = 30
        Me.gridClassificacao.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'prodCadClassificacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 460)
        Me.Controls.Add(Me.gridClassificacao)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "prodCadClassificacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Grupos e Sub-Grupos"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridClassificacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblGrupo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbGrupos As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblSubGrupo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbSubGrupos As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblNovoGrupo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNovoGrupo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblNovoSubGrupo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNovoSubGrupo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botIncluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridClassificacao As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents radioNovoGrupo As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioNovoSubgrupo As C1.Win.C1InputPanel.InputRadioButton
End Class
