<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calRealizarCalibracoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calRealizarCalibracoes))
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.TabExt = New C1.Win.C1Command.C1DockingTabPage()
        Me.gridCalibExterna = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.groupExt = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblAnoExt = New C1.Win.C1InputPanel.InputLabel()
        Me.comboAnoExt = New C1.Win.C1InputPanel.InputComboBox()
        Me.TabInt = New C1.Win.C1Command.C1DockingTabPage()
        Me.gridCalibInterna = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.groupInt = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblAnoInt = New C1.Win.C1InputPanel.InputLabel()
        Me.comboAnoInt = New C1.Win.C1InputPanel.InputComboBox()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botRealizar = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me._imgListLegenda = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.TabExt.SuspendLayout()
        CType(Me.gridCalibExterna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabInt.SuspendLayout()
        CType(Me.gridCalibInterna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.TabExt)
        Me.C1DockingTab1.Controls.Add(Me.TabInt)
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 1)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedIndex = 1
        Me.C1DockingTab1.Size = New System.Drawing.Size(674, 314)
        Me.C1DockingTab1.TabIndex = 0
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'TabExt
        '
        Me.TabExt.Controls.Add(Me.gridCalibExterna)
        Me.TabExt.Controls.Add(Me.C1InputPanel1)
        Me.TabExt.Location = New System.Drawing.Point(1, 26)
        Me.TabExt.Name = "TabExt"
        Me.TabExt.Size = New System.Drawing.Size(672, 287)
        Me.TabExt.TabIndex = 0
        Me.TabExt.Text = "Calibrações Externas"
        '
        'gridCalibExterna
        '
        Me.gridCalibExterna.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridCalibExterna.AllowEditing = False
        Me.gridCalibExterna.AllowFiltering = True
        Me.gridCalibExterna.ColumnInfo = resources.GetString("gridCalibExterna.ColumnInfo")
        Me.gridCalibExterna.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridCalibExterna.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.gridCalibExterna.Location = New System.Drawing.Point(7, 58)
        Me.gridCalibExterna.Name = "gridCalibExterna"
        Me.gridCalibExterna.Rows.DefaultSize = 21
        Me.gridCalibExterna.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridCalibExterna.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.gridCalibExterna.Size = New System.Drawing.Size(662, 227)
        Me.gridCalibExterna.StyleInfo = resources.GetString("gridCalibExterna.StyleInfo")
        Me.gridCalibExterna.TabIndex = 19
        Me.gridCalibExterna.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.groupExt)
        Me.C1InputPanel1.Items.Add(Me.lblAnoExt)
        Me.C1InputPanel1.Items.Add(Me.comboAnoExt)
        Me.C1InputPanel1.Location = New System.Drawing.Point(4, 4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(665, 281)
        Me.C1InputPanel1.TabIndex = 0
        '
        'groupExt
        '
        Me.groupExt.Name = "groupExt"
        Me.groupExt.Text = "Calibrações Cadastradas"
        '
        'lblAnoExt
        '
        Me.lblAnoExt.Name = "lblAnoExt"
        Me.lblAnoExt.Padding = New System.Windows.Forms.Padding(515, 0, 0, 0)
        Me.lblAnoExt.Text = "Ano :"
        Me.lblAnoExt.Width = 555
        '
        'comboAnoExt
        '
        Me.comboAnoExt.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.None
        Me.comboAnoExt.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.comboAnoExt.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboAnoExt.Name = "comboAnoExt"
        Me.comboAnoExt.Width = 92
        '
        'TabInt
        '
        Me.TabInt.Controls.Add(Me.gridCalibInterna)
        Me.TabInt.Controls.Add(Me.C1InputPanel3)
        Me.TabInt.Location = New System.Drawing.Point(1, 26)
        Me.TabInt.Name = "TabInt"
        Me.TabInt.Size = New System.Drawing.Size(672, 287)
        Me.TabInt.TabIndex = 1
        Me.TabInt.Text = "Calibrações Internas"
        '
        'gridCalibInterna
        '
        Me.gridCalibInterna.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridCalibInterna.AllowEditing = False
        Me.gridCalibInterna.AllowFiltering = True
        Me.gridCalibInterna.ColumnInfo = resources.GetString("gridCalibInterna.ColumnInfo")
        Me.gridCalibInterna.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridCalibInterna.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.gridCalibInterna.Location = New System.Drawing.Point(7, 58)
        Me.gridCalibInterna.Name = "gridCalibInterna"
        Me.gridCalibInterna.Rows.DefaultSize = 21
        Me.gridCalibInterna.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridCalibInterna.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridCalibInterna.Size = New System.Drawing.Size(662, 227)
        Me.gridCalibInterna.StyleInfo = resources.GetString("gridCalibInterna.StyleInfo")
        Me.gridCalibInterna.TabIndex = 20
        Me.gridCalibInterna.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.groupInt)
        Me.C1InputPanel3.Items.Add(Me.lblAnoInt)
        Me.C1InputPanel3.Items.Add(Me.comboAnoInt)
        Me.C1InputPanel3.Location = New System.Drawing.Point(4, 4)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(665, 281)
        Me.C1InputPanel3.TabIndex = 1
        '
        'groupInt
        '
        Me.groupInt.Name = "groupInt"
        Me.groupInt.Text = "Calibrações Cadastradas"
        '
        'lblAnoInt
        '
        Me.lblAnoInt.Name = "lblAnoInt"
        Me.lblAnoInt.Padding = New System.Windows.Forms.Padding(515, 0, 0, 0)
        Me.lblAnoInt.Text = "Ano : "
        Me.lblAnoInt.Width = 555
        '
        'comboAnoInt
        '
        Me.comboAnoInt.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.None
        Me.comboAnoInt.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.comboAnoInt.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboAnoInt.Name = "comboAnoInt"
        Me.comboAnoInt.Width = 92
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.botRealizar)
        Me.C1InputPanel2.Items.Add(Me.botEditar)
        Me.C1InputPanel2.Location = New System.Drawing.Point(1, 314)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(673, 64)
        Me.C1InputPanel2.TabIndex = 4
        '
        'grupoOpcoes
        '
        Me.grupoOpcoes.Name = "grupoOpcoes"
        Me.grupoOpcoes.Text = "Opções"
        '
        'botRealizar
        '
        Me.botRealizar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botRealizar.Image = CType(resources.GetObject("botRealizar.Image"), System.Drawing.Image)
        Me.botRealizar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botRealizar.Name = "botRealizar"
        Me.botRealizar.Text = "Realizar"
        '
        'botEditar
        '
        Me.botEditar.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botEditar.Image = CType(resources.GetObject("botEditar.Image"), System.Drawing.Image)
        Me.botEditar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botEditar.Name = "botEditar"
        Me.botEditar.Text = "Editar"
        Me.botEditar.Width = 70
        '
        '_imgListLegenda
        '
        Me._imgListLegenda.ImageStream = CType(resources.GetObject("_imgListLegenda.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgListLegenda.TransparentColor = System.Drawing.Color.Transparent
        Me._imgListLegenda.Images.SetKeyName(0, "Prog_Verde01.png")
        Me._imgListLegenda.Images.SetKeyName(1, "Prog_Azul01.png")
        Me._imgListLegenda.Images.SetKeyName(2, "Prog_Vermelho01.png")
        Me._imgListLegenda.Images.SetKeyName(3, "Prog_Amarelo01.png")
        Me._imgListLegenda.Images.SetKeyName(4, "Prog_Laranja01.png")
        Me._imgListLegenda.Images.SetKeyName(5, "Prog_Branco.png")
        '
        'calRealizarCalibracoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 378)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "calRealizarCalibracoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realização de Calibrações"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.TabExt.ResumeLayout(False)
        CType(Me.gridCalibExterna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabInt.ResumeLayout(False)
        CType(Me.gridCalibInterna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents TabExt As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents groupExt As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblAnoExt As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents TabInt As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents groupInt As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblAnoInt As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botRealizar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents gridCalibExterna As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents gridCalibInterna As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents _imgListLegenda As System.Windows.Forms.ImageList
    Private WithEvents comboAnoExt As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents comboAnoInt As C1.Win.C1InputPanel.InputComboBox
End Class
