<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mgAprovControleManual
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mgAprovControleManual))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblDataEmissao = New C1.Win.C1InputPanel.InputLabel()
        Me.dateEmissao = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblRevisao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRevisao = New C1.Win.C1InputPanel.InputMaskedTextBox()
        Me.lblDataAprovacao = New C1.Win.C1InputPanel.InputLabel()
        Me.dateAprovacao = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblResp = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResp = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblCargo = New C1.Win.C1InputPanel.InputLabel()
        Me.comboCargo = New C1.Win.C1InputPanel.InputComboBox()
        Me.gridListaAprovacao = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botAprovar = New C1.Win.C1InputPanel.InputButton()
        Me.botEdit = New C1.Win.C1InputPanel.InputButton()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridListaAprovacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.lblDataEmissao)
        Me.C1InputPanel1.Items.Add(Me.dateEmissao)
        Me.C1InputPanel1.Items.Add(Me.lblRevisao)
        Me.C1InputPanel1.Items.Add(Me.txtRevisao)
        Me.C1InputPanel1.Items.Add(Me.lblDataAprovacao)
        Me.C1InputPanel1.Items.Add(Me.dateAprovacao)
        Me.C1InputPanel1.Items.Add(Me.lblResp)
        Me.C1InputPanel1.Items.Add(Me.comboResp)
        Me.C1InputPanel1.Items.Add(Me.lblCargo)
        Me.C1InputPanel1.Items.Add(Me.comboCargo)
        Me.C1InputPanel1.Location = New System.Drawing.Point(1, 4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(706, 82)
        Me.C1InputPanel1.TabIndex = 0
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Text = "Data de Emissão :"
        '
        'dateEmissao
        '
        Me.dateEmissao.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dateEmissao.Name = "dateEmissao"
        '
        'lblRevisao
        '
        Me.lblRevisao.Name = "lblRevisao"
        Me.lblRevisao.Text = "Revisão :"
        Me.lblRevisao.Width = 68
        '
        'txtRevisao
        '
        Me.txtRevisao.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtRevisao.Enabled = False
        Me.txtRevisao.Mask = "00"
        Me.txtRevisao.Name = "txtRevisao"
        Me.txtRevisao.Width = 38
        '
        'lblDataAprovacao
        '
        Me.lblDataAprovacao.Name = "lblDataAprovacao"
        Me.lblDataAprovacao.Text = "Data da Aprovação :"
        Me.lblDataAprovacao.Width = 142
        '
        'dateAprovacao
        '
        Me.dateAprovacao.Name = "dateAprovacao"
        '
        'lblResp
        '
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Text = "Responsável :"
        Me.lblResp.Width = 92
        '
        'comboResp
        '
        Me.comboResp.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResp.Name = "comboResp"
        Me.comboResp.Width = 465
        '
        'lblCargo
        '
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Text = "Cargo :"
        Me.lblCargo.Width = 92
        '
        'comboCargo
        '
        Me.comboCargo.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboCargo.Enabled = False
        Me.comboCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCargo.ForeColor = System.Drawing.Color.White
        Me.comboCargo.Name = "comboCargo"
        Me.comboCargo.Width = 465
        '
        'gridListaAprovacao
        '
        Me.gridListaAprovacao.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridListaAprovacao.AllowEditing = False
        Me.gridListaAprovacao.AllowFiltering = True
        Me.gridListaAprovacao.ColumnInfo = resources.GetString("gridListaAprovacao.ColumnInfo")
        Me.gridListaAprovacao.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridListaAprovacao.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridListaAprovacao.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.gridListaAprovacao.Location = New System.Drawing.Point(1, 83)
        Me.gridListaAprovacao.Name = "gridListaAprovacao"
        Me.gridListaAprovacao.Rows.DefaultSize = 21
        Me.gridListaAprovacao.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridListaAprovacao.ShowSortPosition = C1.Win.C1FlexGrid.ShowSortPositionEnum.None
        Me.gridListaAprovacao.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.gridListaAprovacao.Size = New System.Drawing.Size(706, 302)
        Me.gridListaAprovacao.StyleInfo = resources.GetString("gridListaAprovacao.StyleInfo")
        Me.gridListaAprovacao.TabIndex = 1
        Me.gridListaAprovacao.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel6.Items.Add(Me.botAprovar)
        Me.C1InputPanel6.Items.Add(Me.botEdit)
        Me.C1InputPanel6.Location = New System.Drawing.Point(1, 391)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(706, 64)
        Me.C1InputPanel6.TabIndex = 16
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "Opções"
        '
        'botAprovar
        '
        Me.botAprovar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botAprovar.Image = CType(resources.GetObject("botAprovar.Image"), System.Drawing.Image)
        Me.botAprovar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botAprovar.Name = "botAprovar"
        Me.botAprovar.Text = "Aprovar"
        Me.botAprovar.Width = 74
        '
        'botEdit
        '
        Me.botEdit.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botEdit.Image = CType(resources.GetObject("botEdit.Image"), System.Drawing.Image)
        Me.botEdit.ImageSize = New System.Drawing.Size(20, 20)
        Me.botEdit.Name = "botEdit"
        Me.botEdit.Text = "Editar"
        Me.botEdit.Width = 70
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "Save.ico")
        '
        'mgAprovControleManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 457)
        Me.Controls.Add(Me.C1InputPanel6)
        Me.Controls.Add(Me.gridListaAprovacao)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "mgAprovControleManual"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aprovação do Manual de Gestão"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridListaAprovacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents lblDataEmissao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateEmissao As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblRevisao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDataAprovacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateAprovacao As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblResp As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResp As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblCargo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboCargo As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents gridListaAprovacao As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botAprovar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEdit As C1.Win.C1InputPanel.InputButton
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents txtRevisao As C1.Win.C1InputPanel.InputMaskedTextBox
End Class
