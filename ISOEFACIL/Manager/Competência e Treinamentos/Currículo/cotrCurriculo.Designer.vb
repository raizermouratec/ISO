<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cotrCurriculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cotrCurriculo))
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.docFormacao = New C1.Win.C1Command.C1DockingTabPage()
        Me.gridFormacao = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.docCurso = New C1.Win.C1Command.C1DockingTabPage()
        Me.gridCurso = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.docExperiencia = New C1.Win.C1Command.C1DockingTabPage()
        Me.gridExperiencia = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.docProcInstr = New C1.Win.C1Command.C1DockingTabPage()
        Me.gridProcInstrExig = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.gridProcInstrTreina = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader8 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.docHabilidades = New C1.Win.C1Command.C1DockingTabPage()
        Me.ListaHabilidades = New C1.Win.C1List.C1List()
        Me.gridHabilidades = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader7 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.txtHabilidadesCargoS = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader9 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botNovo = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.botRelacao = New C1.Win.C1InputPanel.InputSplitButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblNome = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbNome = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblCargo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtCargo = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblArea = New C1.Win.C1InputPanel.InputLabel()
        Me.txtArea = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.docFormacao.SuspendLayout()
        CType(Me.gridFormacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.docCurso.SuspendLayout()
        CType(Me.gridCurso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.docExperiencia.SuspendLayout()
        CType(Me.gridExperiencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.docProcInstr.SuspendLayout()
        CType(Me.gridProcInstrExig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProcInstrTreina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.docHabilidades.SuspendLayout()
        CType(Me.ListaHabilidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridHabilidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.docFormacao)
        Me.C1DockingTab1.Controls.Add(Me.docCurso)
        Me.C1DockingTab1.Controls.Add(Me.docExperiencia)
        Me.C1DockingTab1.Controls.Add(Me.docProcInstr)
        Me.C1DockingTab1.Controls.Add(Me.docHabilidades)
        Me.C1DockingTab1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1DockingTab1.Location = New System.Drawing.Point(-3, 52)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.Size = New System.Drawing.Size(800, 395)
        Me.C1DockingTab1.TabIndex = 0
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'docFormacao
        '
        Me.docFormacao.Controls.Add(Me.gridFormacao)
        Me.docFormacao.Controls.Add(Me.C1InputPanel3)
        Me.docFormacao.Location = New System.Drawing.Point(1, 26)
        Me.docFormacao.Name = "docFormacao"
        Me.docFormacao.Size = New System.Drawing.Size(798, 368)
        Me.docFormacao.TabIndex = 0
        Me.docFormacao.Text = "Formação"
        '
        'gridFormacao
        '
        Me.gridFormacao.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridFormacao.AllowEditing = False
        Me.gridFormacao.AllowFiltering = True
        Me.gridFormacao.ColumnInfo = resources.GetString("gridFormacao.ColumnInfo")
        Me.gridFormacao.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridFormacao.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridFormacao.Location = New System.Drawing.Point(3, 27)
        Me.gridFormacao.Name = "gridFormacao"
        Me.gridFormacao.Rows.DefaultSize = 21
        Me.gridFormacao.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridFormacao.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridFormacao.Size = New System.Drawing.Size(791, 338)
        Me.gridFormacao.StyleInfo = resources.GetString("gridFormacao.StyleInfo")
        Me.gridFormacao.TabIndex = 2
        Me.gridFormacao.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel3.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(791, 329)
        Me.C1InputPanel3.TabIndex = 1
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Lista de Formação"
        '
        'docCurso
        '
        Me.docCurso.Controls.Add(Me.gridCurso)
        Me.docCurso.Controls.Add(Me.C1InputPanel4)
        Me.docCurso.Location = New System.Drawing.Point(1, 26)
        Me.docCurso.Name = "docCurso"
        Me.docCurso.Size = New System.Drawing.Size(798, 368)
        Me.docCurso.TabIndex = 1
        Me.docCurso.Text = "Cursos complementares"
        '
        'gridCurso
        '
        Me.gridCurso.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridCurso.AllowEditing = False
        Me.gridCurso.AllowFiltering = True
        Me.gridCurso.ColumnInfo = resources.GetString("gridCurso.ColumnInfo")
        Me.gridCurso.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridCurso.Location = New System.Drawing.Point(3, 27)
        Me.gridCurso.Name = "gridCurso"
        Me.gridCurso.Rows.DefaultSize = 21
        Me.gridCurso.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridCurso.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridCurso.Size = New System.Drawing.Size(791, 338)
        Me.gridCurso.StyleInfo = resources.GetString("gridCurso.StyleInfo")
        Me.gridCurso.TabIndex = 4
        Me.gridCurso.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel4.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(791, 329)
        Me.C1InputPanel4.TabIndex = 3
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "Lista de Cursos"
        '
        'docExperiencia
        '
        Me.docExperiencia.Controls.Add(Me.gridExperiencia)
        Me.docExperiencia.Controls.Add(Me.C1InputPanel5)
        Me.docExperiencia.Location = New System.Drawing.Point(1, 26)
        Me.docExperiencia.Name = "docExperiencia"
        Me.docExperiencia.Size = New System.Drawing.Size(798, 368)
        Me.docExperiencia.TabIndex = 2
        Me.docExperiencia.Text = "Experiência profissional"
        '
        'gridExperiencia
        '
        Me.gridExperiencia.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridExperiencia.AllowEditing = False
        Me.gridExperiencia.AllowFiltering = True
        Me.gridExperiencia.ColumnInfo = resources.GetString("gridExperiencia.ColumnInfo")
        Me.gridExperiencia.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridExperiencia.Location = New System.Drawing.Point(3, 27)
        Me.gridExperiencia.Name = "gridExperiencia"
        Me.gridExperiencia.Rows.DefaultSize = 21
        Me.gridExperiencia.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridExperiencia.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridExperiencia.Size = New System.Drawing.Size(791, 338)
        Me.gridExperiencia.StyleInfo = resources.GetString("gridExperiencia.StyleInfo")
        Me.gridExperiencia.TabIndex = 4
        Me.gridExperiencia.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader5)
        Me.C1InputPanel5.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(791, 329)
        Me.C1InputPanel5.TabIndex = 3
        '
        'InputGroupHeader5
        '
        Me.InputGroupHeader5.Name = "InputGroupHeader5"
        Me.InputGroupHeader5.Text = "Lista de Experiências"
        '
        'docProcInstr
        '
        Me.docProcInstr.Controls.Add(Me.gridProcInstrExig)
        Me.docProcInstr.Controls.Add(Me.gridProcInstrTreina)
        Me.docProcInstr.Controls.Add(Me.C1InputPanel6)
        Me.docProcInstr.Location = New System.Drawing.Point(1, 26)
        Me.docProcInstr.Name = "docProcInstr"
        Me.docProcInstr.Size = New System.Drawing.Size(798, 368)
        Me.docProcInstr.TabIndex = 3
        Me.docProcInstr.Text = "Procedimentos e instruções"
        '
        'gridProcInstrExig
        '
        Me.gridProcInstrExig.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridProcInstrExig.AllowEditing = False
        Me.gridProcInstrExig.AllowFiltering = True
        Me.gridProcInstrExig.ColumnInfo = resources.GetString("gridProcInstrExig.ColumnInfo")
        Me.gridProcInstrExig.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridProcInstrExig.Location = New System.Drawing.Point(3, 27)
        Me.gridProcInstrExig.Name = "gridProcInstrExig"
        Me.gridProcInstrExig.Rows.DefaultSize = 21
        Me.gridProcInstrExig.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridProcInstrExig.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridProcInstrExig.Size = New System.Drawing.Size(791, 173)
        Me.gridProcInstrExig.StyleInfo = resources.GetString("gridProcInstrExig.StyleInfo")
        Me.gridProcInstrExig.TabIndex = 6
        Me.gridProcInstrExig.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'gridProcInstrTreina
        '
        Me.gridProcInstrTreina.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridProcInstrTreina.AllowEditing = False
        Me.gridProcInstrTreina.AllowFiltering = True
        Me.gridProcInstrTreina.ColumnInfo = resources.GetString("gridProcInstrTreina.ColumnInfo")
        Me.gridProcInstrTreina.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridProcInstrTreina.Location = New System.Drawing.Point(3, 223)
        Me.gridProcInstrTreina.Name = "gridProcInstrTreina"
        Me.gridProcInstrTreina.Rows.DefaultSize = 21
        Me.gridProcInstrTreina.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridProcInstrTreina.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridProcInstrTreina.Size = New System.Drawing.Size(791, 145)
        Me.gridProcInstrTreina.StyleInfo = resources.GetString("gridProcInstrTreina.StyleInfo")
        Me.gridProcInstrTreina.TabIndex = 5
        Me.gridProcInstrTreina.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel6.Items.Add(Me.InputLabel1)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader8)
        Me.C1InputPanel6.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(791, 366)
        Me.C1InputPanel6.TabIndex = 3
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "Procedimentos/ Instruções Exigidas para o Cargo"
        '
        'InputLabel1
        '
        Me.InputLabel1.ElementHeight = 166
        Me.InputLabel1.Name = "InputLabel1"
        '
        'InputGroupHeader8
        '
        Me.InputGroupHeader8.Name = "InputGroupHeader8"
        Me.InputGroupHeader8.Text = "Procedimentos/Instruções Treinados"
        '
        'docHabilidades
        '
        Me.docHabilidades.Controls.Add(Me.ListaHabilidades)
        Me.docHabilidades.Controls.Add(Me.gridHabilidades)
        Me.docHabilidades.Controls.Add(Me.C1InputPanel7)
        Me.docHabilidades.Location = New System.Drawing.Point(1, 26)
        Me.docHabilidades.Name = "docHabilidades"
        Me.docHabilidades.Size = New System.Drawing.Size(798, 368)
        Me.docHabilidades.TabIndex = 4
        Me.docHabilidades.Text = "Habilidades"
        '
        'ListaHabilidades
        '
        Me.ListaHabilidades.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.ListaHabilidades.Caption = "Lista de Habilidades do Cargo"
        Me.ListaHabilidades.CaptionHeight = 17
        Me.ListaHabilidades.ColumnCaptionHeight = 17
        Me.ListaHabilidades.ColumnFooterHeight = 17
        Me.ListaHabilidades.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.ListaHabilidades.Images.Add(CType(resources.GetObject("ListaHabilidades.Images"), System.Drawing.Image))
        Me.ListaHabilidades.ItemHeight = 15
        Me.ListaHabilidades.Location = New System.Drawing.Point(3, 26)
        Me.ListaHabilidades.MatchEntryTimeout = CType(2000, Long)
        Me.ListaHabilidades.Name = "ListaHabilidades"
        Me.ListaHabilidades.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.ListaHabilidades.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.ListaHabilidades.Size = New System.Drawing.Size(792, 169)
        Me.ListaHabilidades.TabIndex = 6
        Me.ListaHabilidades.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.ListaHabilidades.PropBag = resources.GetString("ListaHabilidades.PropBag")
        '
        'gridHabilidades
        '
        Me.gridHabilidades.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridHabilidades.AllowEditing = False
        Me.gridHabilidades.AllowFiltering = True
        Me.gridHabilidades.ColumnInfo = resources.GetString("gridHabilidades.ColumnInfo")
        Me.gridHabilidades.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridHabilidades.Location = New System.Drawing.Point(3, 217)
        Me.gridHabilidades.Name = "gridHabilidades"
        Me.gridHabilidades.Rows.DefaultSize = 21
        Me.gridHabilidades.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridHabilidades.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridHabilidades.Size = New System.Drawing.Size(792, 152)
        Me.gridHabilidades.StyleInfo = resources.GetString("gridHabilidades.StyleInfo")
        Me.gridHabilidades.TabIndex = 5
        Me.gridHabilidades.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel7
        '
        Me.C1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel7.Items.Add(Me.InputGroupHeader7)
        Me.C1InputPanel7.Items.Add(Me.txtHabilidadesCargoS)
        Me.C1InputPanel7.Items.Add(Me.InputLabel2)
        Me.C1InputPanel7.Items.Add(Me.InputGroupHeader9)
        Me.C1InputPanel7.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel7.Name = "C1InputPanel7"
        Me.C1InputPanel7.Size = New System.Drawing.Size(792, 363)
        Me.C1InputPanel7.TabIndex = 3
        '
        'InputGroupHeader7
        '
        Me.InputGroupHeader7.Name = "InputGroupHeader7"
        Me.InputGroupHeader7.Text = "Lista de Habilidades"
        '
        'txtHabilidadesCargoS
        '
        Me.txtHabilidadesCargoS.Height = 151
        Me.txtHabilidadesCargoS.Multiline = True
        Me.txtHabilidadesCargoS.Name = "txtHabilidadesCargoS"
        Me.txtHabilidadesCargoS.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtHabilidadesCargoS.Width = 770
        '
        'InputLabel2
        '
        Me.InputLabel2.ElementHeight = 8
        Me.InputLabel2.Name = "InputLabel2"
        '
        'InputGroupHeader9
        '
        Me.InputGroupHeader9.Name = "InputGroupHeader9"
        Me.InputGroupHeader9.Text = "Habilidades Comprovadas"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Items.Add(Me.botNovo)
        Me.C1InputPanel2.Items.Add(Me.botEditar)
        Me.C1InputPanel2.Items.Add(Me.botExcluir)
        Me.C1InputPanel2.Items.Add(Me.botRelacao)
        Me.C1InputPanel2.Location = New System.Drawing.Point(1, 452)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(796, 66)
        Me.C1InputPanel2.TabIndex = 28
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
        '
        'botNovo
        '
        Me.botNovo.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botNovo.Image = CType(resources.GetObject("botNovo.Image"), System.Drawing.Image)
        Me.botNovo.ImageSize = New System.Drawing.Size(20, 20)
        Me.botNovo.Name = "botNovo"
        Me.botNovo.Text = "Novo"
        Me.botNovo.Width = 70
        '
        'botEditar
        '
        Me.botEditar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botEditar.Image = CType(resources.GetObject("botEditar.Image"), System.Drawing.Image)
        Me.botEditar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botEditar.Name = "botEditar"
        Me.botEditar.Text = "Editar"
        Me.botEditar.Width = 70
        '
        'botExcluir
        '
        Me.botExcluir.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botExcluir.Image = CType(resources.GetObject("botExcluir.Image"), System.Drawing.Image)
        Me.botExcluir.ImageSize = New System.Drawing.Size(20, 20)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Text = "Excluir"
        Me.botExcluir.Width = 70
        '
        'botRelacao
        '
        Me.botRelacao.Image = CType(resources.GetObject("botRelacao.Image"), System.Drawing.Image)
        Me.botRelacao.ImageSize = New System.Drawing.Size(20, 20)
        Me.botRelacao.Name = "botRelacao"
        Me.botRelacao.Text = "Relação"
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.lblNome)
        Me.C1InputPanel1.Items.Add(Me.cmbNome)
        Me.C1InputPanel1.Items.Add(Me.lblCargo)
        Me.C1InputPanel1.Items.Add(Me.txtCargo)
        Me.C1InputPanel1.Items.Add(Me.lblArea)
        Me.C1InputPanel1.Items.Add(Me.txtArea)
        Me.C1InputPanel1.Location = New System.Drawing.Point(-4, 12)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(801, 34)
        Me.C1InputPanel1.TabIndex = 29
        '
        'lblNome
        '
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Text = "Nome"
        '
        'cmbNome
        '
        Me.cmbNome.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbNome.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbNome.Name = "cmbNome"
        Me.cmbNome.Width = 316
        '
        'lblCargo
        '
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Text = "Cargo"
        '
        'txtCargo
        '
        Me.txtCargo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtCargo.Enabled = False
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Width = 287
        '
        'lblArea
        '
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Text = "Area"
        Me.lblArea.Width = 31
        '
        'txtArea
        '
        Me.txtArea.Enabled = False
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Width = 73
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Lista de Formação"
        '
        'cotrCurriculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 518)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "cotrCurriculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Curriculo"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.docFormacao.ResumeLayout(False)
        CType(Me.gridFormacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.docCurso.ResumeLayout(False)
        CType(Me.gridCurso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.docExperiencia.ResumeLayout(False)
        CType(Me.gridExperiencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.docProcInstr.ResumeLayout(False)
        CType(Me.gridProcInstrExig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProcInstrTreina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.docHabilidades.ResumeLayout(False)
        CType(Me.ListaHabilidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridHabilidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents docFormacao As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botNovo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botRelacao As C1.Win.C1InputPanel.InputSplitButton
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents lblNome As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbNome As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblCargo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCargo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblArea As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtArea As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents docCurso As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents docExperiencia As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents docProcInstr As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents docHabilidades As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents gridFormacao As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridCurso As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridExperiencia As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader7 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridProcInstrTreina As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader8 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridHabilidades As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader9 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents txtHabilidadesCargoS As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents gridProcInstrExig As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ListaHabilidades As C1.Win.C1List.C1List
End Class
