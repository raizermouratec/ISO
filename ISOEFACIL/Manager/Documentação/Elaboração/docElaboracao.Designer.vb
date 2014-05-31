<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class docElaboracao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(docElaboracao))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.botElaborar = New C1.Win.C1InputPanel.InputButton()
        Me.botAnexar = New C1.Win.C1InputPanel.InputButton()
        Me.botRascunho = New C1.Win.C1InputPanel.InputButton()
        Me.botRelatorio = New C1.Win.C1InputPanel.InputButton()
        Me.filtroTodos = New C1.Win.C1InputPanel.InputRadioButton()
        Me.filtroTipo = New C1.Win.C1InputPanel.InputRadioButton()
        Me.filtroArea = New C1.Win.C1InputPanel.InputRadioButton()
        Me._imgListLegenda = New System.Windows.Forms.ImageList(Me.components)
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.gridProcedimentos = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProcedimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackgroundImage = CType(resources.GetObject("C1InputPanel1.BackgroundImage"), System.Drawing.Image)
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1InputPanel1.Items.Add(Me.botElaborar)
        Me.C1InputPanel1.Items.Add(Me.botAnexar)
        Me.C1InputPanel1.Items.Add(Me.botRascunho)
        Me.C1InputPanel1.Items.Add(Me.botRelatorio)
        Me.C1InputPanel1.Items.Add(Me.filtroTodos)
        Me.C1InputPanel1.Items.Add(Me.filtroTipo)
        Me.C1InputPanel1.Items.Add(Me.filtroArea)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1162, 183)
        Me.C1InputPanel1.TabIndex = 29
        '
        'botElaborar
        '
        Me.botElaborar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botElaborar.Image = CType(resources.GetObject("botElaborar.Image"), System.Drawing.Image)
        Me.botElaborar.ImageSize = New System.Drawing.Size(32, 32)
        Me.botElaborar.Name = "botElaborar"
        Me.botElaborar.Padding = New System.Windows.Forms.Padding(180, 130, 0, 0)
        Me.botElaborar.Text = "Elaborar"
        '
        'botAnexar
        '
        Me.botAnexar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botAnexar.Image = CType(resources.GetObject("botAnexar.Image"), System.Drawing.Image)
        Me.botAnexar.ImageSize = New System.Drawing.Size(32, 32)
        Me.botAnexar.Name = "botAnexar"
        Me.botAnexar.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botAnexar.Text = "Anexar"
        '
        'botRascunho
        '
        Me.botRascunho.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botRascunho.Image = CType(resources.GetObject("botRascunho.Image"), System.Drawing.Image)
        Me.botRascunho.ImageSize = New System.Drawing.Size(32, 32)
        Me.botRascunho.Name = "botRascunho"
        Me.botRascunho.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botRascunho.Text = "Rascunho"
        '
        'botRelatorio
        '
        Me.botRelatorio.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botRelatorio.Image = CType(resources.GetObject("botRelatorio.Image"), System.Drawing.Image)
        Me.botRelatorio.ImageSize = New System.Drawing.Size(32, 32)
        Me.botRelatorio.Name = "botRelatorio"
        Me.botRelatorio.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botRelatorio.Text = "Relatório"
        '
        'filtroTodos
        '
        Me.filtroTodos.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.filtroTodos.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.filtroTodos.Name = "filtroTodos"
        Me.filtroTodos.Padding = New System.Windows.Forms.Padding(0, 153, 0, 0)
        Me.filtroTodos.Text = "Todos"
        Me.filtroTodos.Width = 331
        '
        'filtroTipo
        '
        Me.filtroTipo.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.filtroTipo.Name = "filtroTipo"
        Me.filtroTipo.Padding = New System.Windows.Forms.Padding(0, 153, 0, 0)
        Me.filtroTipo.Text = "Tipo"
        '
        'filtroArea
        '
        Me.filtroArea.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.filtroArea.Name = "filtroArea"
        Me.filtroArea.Padding = New System.Windows.Forms.Padding(0, 153, 0, 0)
        Me.filtroArea.Text = "Área"
        '
        '_imgListLegenda
        '
        Me._imgListLegenda.ImageStream = CType(resources.GetObject("_imgListLegenda.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgListLegenda.TransparentColor = System.Drawing.Color.Transparent
        Me._imgListLegenda.Images.SetKeyName(0, "Prog_Branco.png")
        Me._imgListLegenda.Images.SetKeyName(1, "Charts-Flow-chart-icon.png")
        Me._imgListLegenda.Images.SetKeyName(2, "file-doc.png")
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Location = New System.Drawing.Point(1035, 152)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 32
        '
        'gridProcedimentos
        '
        Me.gridProcedimentos.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridProcedimentos.AllowEditing = False
        Me.gridProcedimentos.AllowFiltering = True
        Me.gridProcedimentos.ColumnInfo = resources.GetString("gridProcedimentos.ColumnInfo")
        Me.gridProcedimentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridProcedimentos.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridProcedimentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridProcedimentos.Location = New System.Drawing.Point(0, 183)
        Me.gridProcedimentos.Name = "gridProcedimentos"
        Me.gridProcedimentos.Rows.DefaultSize = 20
        Me.gridProcedimentos.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridProcedimentos.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridProcedimentos.Size = New System.Drawing.Size(1162, 381)
        Me.gridProcedimentos.StyleInfo = resources.GetString("gridProcedimentos.StyleInfo")
        Me.gridProcedimentos.TabIndex = 33
        Me.gridProcedimentos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'docElaboracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1162, 564)
        Me.Controls.Add(Me.gridProcedimentos)
        Me.Controls.Add(Me.cmbFiltro)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "docElaboracao"
        Me.Text = "Elaboração de Documentos"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProcedimentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents botElaborar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botAnexar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botRascunho As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botRelatorio As C1.Win.C1InputPanel.InputButton
    Friend WithEvents filtroTodos As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents filtroTipo As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents filtroArea As C1.Win.C1InputPanel.InputRadioButton
    Private WithEvents _imgListLegenda As System.Windows.Forms.ImageList
    Friend WithEvents cmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents gridProcedimentos As C1.Win.C1FlexGrid.C1FlexGrid
End Class
