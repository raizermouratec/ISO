<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configListaBasico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configListaBasico))
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.tabAreas = New C1.Win.C1Command.C1DockingTabPage()
        Me.gridArea = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.tabCargos = New C1.Win.C1Command.C1DockingTabPage()
        Me.gridCargos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel8 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader8 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.tabColaboradores = New C1.Win.C1Command.C1DockingTabPage()
        Me.gridColaboradores = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel9 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me._imgListSituacao = New System.Windows.Forms.ImageList(Me.components)
        Me.C1Report1 = New C1.C1Report.C1Report()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.botSalvar_Incluir = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.botRelacao = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.tabAreas.SuspendLayout()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCargos.SuspendLayout()
        CType(Me.gridCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabColaboradores.SuspendLayout()
        CType(Me.gridColaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.tabAreas)
        Me.C1DockingTab1.Controls.Add(Me.tabCargos)
        Me.C1DockingTab1.Controls.Add(Me.tabColaboradores)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DockingTab1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 183)
        Me.C1DockingTab1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedIndex = 5
        Me.C1DockingTab1.Size = New System.Drawing.Size(1008, 381)
        Me.C1DockingTab1.TabIndex = 6
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'tabAreas
        '
        Me.tabAreas.CaptionText = "Contatos"
        Me.tabAreas.Controls.Add(Me.gridArea)
        Me.tabAreas.Controls.Add(Me.C1InputPanel2)
        Me.tabAreas.Location = New System.Drawing.Point(1, 26)
        Me.tabAreas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabAreas.Name = "tabAreas"
        Me.tabAreas.Size = New System.Drawing.Size(1006, 354)
        Me.tabAreas.TabIndex = 2
        Me.tabAreas.Text = "Cadastro de Áreas"
        '
        'gridArea
        '
        Me.gridArea.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridArea.AllowEditing = False
        Me.gridArea.AllowFiltering = True
        Me.gridArea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridArea.AutoGenerateColumns = False
        Me.gridArea.ColumnInfo = resources.GetString("gridArea.ColumnInfo")
        Me.gridArea.ExtendLastCol = True
        Me.gridArea.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridArea.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.gridArea.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveDown
        Me.gridArea.Location = New System.Drawing.Point(3, 28)
        Me.gridArea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridArea.Name = "gridArea"
        Me.gridArea.Rows.Count = 13
        Me.gridArea.Rows.DefaultSize = 21
        Me.gridArea.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridArea.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridArea.Size = New System.Drawing.Size(1000, 277)
        Me.gridArea.StyleInfo = resources.GetString("gridArea.StyleInfo")
        Me.gridArea.TabIndex = 0
        Me.gridArea.TabStop = False
        Me.gridArea.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Location = New System.Drawing.Point(3, 2)
        Me.C1InputPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(1000, 350)
        Me.C1InputPanel2.TabIndex = 35
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Lista de Áreas"
        '
        'tabCargos
        '
        Me.tabCargos.Controls.Add(Me.gridCargos)
        Me.tabCargos.Controls.Add(Me.C1InputPanel8)
        Me.tabCargos.Location = New System.Drawing.Point(1, 26)
        Me.tabCargos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabCargos.Name = "tabCargos"
        Me.tabCargos.Size = New System.Drawing.Size(1006, 354)
        Me.tabCargos.TabIndex = 4
        Me.tabCargos.Text = "Cadastro de Cargos"
        '
        'gridCargos
        '
        Me.gridCargos.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridCargos.AllowEditing = False
        Me.gridCargos.AllowFiltering = True
        Me.gridCargos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridCargos.AutoGenerateColumns = False
        Me.gridCargos.ColumnInfo = resources.GetString("gridCargos.ColumnInfo")
        Me.gridCargos.ExtendLastCol = True
        Me.gridCargos.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridCargos.Location = New System.Drawing.Point(3, 28)
        Me.gridCargos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridCargos.Name = "gridCargos"
        Me.gridCargos.Rows.Count = 13
        Me.gridCargos.Rows.DefaultSize = 21
        Me.gridCargos.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridCargos.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridCargos.Size = New System.Drawing.Size(1000, 277)
        Me.gridCargos.StyleInfo = resources.GetString("gridCargos.StyleInfo")
        Me.gridCargos.TabIndex = 38
        Me.gridCargos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel8
        '
        Me.C1InputPanel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1InputPanel8.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel8.Items.Add(Me.InputGroupHeader8)
        Me.C1InputPanel8.Location = New System.Drawing.Point(3, 2)
        Me.C1InputPanel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.C1InputPanel8.Name = "C1InputPanel8"
        Me.C1InputPanel8.Size = New System.Drawing.Size(1000, 350)
        Me.C1InputPanel8.TabIndex = 39
        Me.C1InputPanel8.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader8
        '
        Me.InputGroupHeader8.Name = "InputGroupHeader8"
        Me.InputGroupHeader8.Text = "Lista de Cargos"
        '
        'tabColaboradores
        '
        Me.tabColaboradores.Controls.Add(Me.gridColaboradores)
        Me.tabColaboradores.Controls.Add(Me.C1InputPanel9)
        Me.tabColaboradores.Location = New System.Drawing.Point(1, 26)
        Me.tabColaboradores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabColaboradores.Name = "tabColaboradores"
        Me.tabColaboradores.Size = New System.Drawing.Size(1006, 354)
        Me.tabColaboradores.TabIndex = 3
        Me.tabColaboradores.Text = "Cadastro de Colaboradores"
        '
        'gridColaboradores
        '
        Me.gridColaboradores.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridColaboradores.AllowEditing = False
        Me.gridColaboradores.AllowFiltering = True
        Me.gridColaboradores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridColaboradores.AutoGenerateColumns = False
        Me.gridColaboradores.ColumnInfo = resources.GetString("gridColaboradores.ColumnInfo")
        Me.gridColaboradores.ExtendLastCol = True
        Me.gridColaboradores.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridColaboradores.Location = New System.Drawing.Point(3, 28)
        Me.gridColaboradores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridColaboradores.Name = "gridColaboradores"
        Me.gridColaboradores.Rows.Count = 13
        Me.gridColaboradores.Rows.DefaultSize = 21
        Me.gridColaboradores.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridColaboradores.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridColaboradores.Size = New System.Drawing.Size(1000, 277)
        Me.gridColaboradores.StyleInfo = resources.GetString("gridColaboradores.StyleInfo")
        Me.gridColaboradores.TabIndex = 37
        Me.gridColaboradores.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel9
        '
        Me.C1InputPanel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1InputPanel9.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel9.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel9.Location = New System.Drawing.Point(3, 2)
        Me.C1InputPanel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.C1InputPanel9.Name = "C1InputPanel9"
        Me.C1InputPanel9.Size = New System.Drawing.Size(1000, 350)
        Me.C1InputPanel9.TabIndex = 38
        Me.C1InputPanel9.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Lista de Colaboradores"
        '
        '_imgListSituacao
        '
        Me._imgListSituacao.ImageStream = CType(resources.GetObject("_imgListSituacao.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgListSituacao.TransparentColor = System.Drawing.Color.Transparent
        Me._imgListSituacao.Images.SetKeyName(0, "ativo.png")
        Me._imgListSituacao.Images.SetKeyName(1, "inativo.png")
        '
        'C1Report1
        '
        Me.C1Report1.ReportDefinition = resources.GetString("C1Report1.ReportDefinition")
        Me.C1Report1.ReportName = "C1Report1"
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackgroundImage = CType(resources.GetObject("C1InputPanel1.BackgroundImage"), System.Drawing.Image)
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.botSalvar_Incluir)
        Me.C1InputPanel1.Items.Add(Me.botEditar)
        Me.C1InputPanel1.Items.Add(Me.botExcluir)
        Me.C1InputPanel1.Items.Add(Me.botRelacao)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1008, 183)
        Me.C1InputPanel1.TabIndex = 0
        '
        'botSalvar_Incluir
        '
        Me.botSalvar_Incluir.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botSalvar_Incluir.Image = CType(resources.GetObject("botSalvar_Incluir.Image"), System.Drawing.Image)
        Me.botSalvar_Incluir.ImageSize = New System.Drawing.Size(32, 32)
        Me.botSalvar_Incluir.Name = "botSalvar_Incluir"
        Me.botSalvar_Incluir.Padding = New System.Windows.Forms.Padding(180, 130, 0, 0)
        Me.botSalvar_Incluir.Text = "Incluir"
        '
        'botEditar
        '
        Me.botEditar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botEditar.Image = CType(resources.GetObject("botEditar.Image"), System.Drawing.Image)
        Me.botEditar.ImageSize = New System.Drawing.Size(32, 32)
        Me.botEditar.Name = "botEditar"
        Me.botEditar.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botEditar.Text = "Editar"
        '
        'botExcluir
        '
        Me.botExcluir.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botExcluir.Image = CType(resources.GetObject("botExcluir.Image"), System.Drawing.Image)
        Me.botExcluir.ImageSize = New System.Drawing.Size(32, 32)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botExcluir.Text = "Excluir"
        '
        'botRelacao
        '
        Me.botRelacao.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botRelacao.Image = CType(resources.GetObject("botRelacao.Image"), System.Drawing.Image)
        Me.botRelacao.ImageSize = New System.Drawing.Size(32, 32)
        Me.botRelacao.Name = "botRelacao"
        Me.botRelacao.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botRelacao.Text = "Relação"
        '
        'configListaBasico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1008, 564)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "configListaBasico"
        Me.Text = "Cadastros Basicos"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.tabAreas.ResumeLayout(False)
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCargos.ResumeLayout(False)
        CType(Me.gridCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabColaboradores.ResumeLayout(False)
        CType(Me.gridColaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents tabAreas As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents gridArea As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents tabCargos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents gridCargos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel8 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader8 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents tabColaboradores As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents gridColaboradores As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel9 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar_Incluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Private WithEvents _imgListSituacao As System.Windows.Forms.ImageList
    Friend WithEvents C1Report1 As C1.C1Report.C1Report
    Friend WithEvents botRelacao As C1.Win.C1InputPanel.InputButton
End Class
