<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mgListaControleManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mgListaControleManual))
        Me.gridControleManual = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.botNovo = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.botAprovar = New C1.Win.C1InputPanel.InputButton()
        Me.botCancelar = New C1.Win.C1InputPanel.InputButton()
        Me.botAlteracoes = New C1.Win.C1InputPanel.InputButton()
        Me.botAnexos = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.gridCopiasManual = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel15 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader14 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botNovoCopia = New C1.Win.C1InputPanel.InputButton()
        Me.botEditarCopia = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluirCopia = New C1.Win.C1InputPanel.InputButton()
        Me.botVisualizarCopia = New C1.Win.C1InputPanel.InputButton()
        CType(Me.gridControleManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCopiasManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControleManual
        '
        Me.gridControleManual.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridControleManual.AllowEditing = False
        Me.gridControleManual.AllowFiltering = True
        Me.gridControleManual.ColumnInfo = resources.GetString("gridControleManual.ColumnInfo")
        Me.gridControleManual.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridControleManual.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridControleManual.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridControleManual.Location = New System.Drawing.Point(0, 183)
        Me.gridControleManual.Name = "gridControleManual"
        Me.gridControleManual.Rows.DefaultSize = 21
        Me.gridControleManual.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridControleManual.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always
        Me.gridControleManual.ShowSortPosition = C1.Win.C1FlexGrid.ShowSortPositionEnum.None
        Me.gridControleManual.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridControleManual.Size = New System.Drawing.Size(1014, 188)
        Me.gridControleManual.StyleInfo = resources.GetString("gridControleManual.StyleInfo")
        Me.gridControleManual.TabIndex = 33
        Me.gridControleManual.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackgroundImage = CType(resources.GetObject("C1InputPanel1.BackgroundImage"), System.Drawing.Image)
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1InputPanel1.Items.Add(Me.botNovo)
        Me.C1InputPanel1.Items.Add(Me.botEditar)
        Me.C1InputPanel1.Items.Add(Me.botExcluir)
        Me.C1InputPanel1.Items.Add(Me.botAprovar)
        Me.C1InputPanel1.Items.Add(Me.botCancelar)
        Me.C1InputPanel1.Items.Add(Me.botAlteracoes)
        Me.C1InputPanel1.Items.Add(Me.botAnexos)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1014, 183)
        Me.C1InputPanel1.TabIndex = 32
        '
        'botNovo
        '
        Me.botNovo.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botNovo.Image = CType(resources.GetObject("botNovo.Image"), System.Drawing.Image)
        Me.botNovo.ImageSize = New System.Drawing.Size(32, 32)
        Me.botNovo.Name = "botNovo"
        Me.botNovo.Padding = New System.Windows.Forms.Padding(180, 130, 0, 0)
        Me.botNovo.Text = "Novo"
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
        'botAprovar
        '
        Me.botAprovar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botAprovar.Image = CType(resources.GetObject("botAprovar.Image"), System.Drawing.Image)
        Me.botAprovar.ImageSize = New System.Drawing.Size(32, 32)
        Me.botAprovar.Name = "botAprovar"
        Me.botAprovar.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botAprovar.Text = "Aprovar"
        Me.botAprovar.Width = 87
        '
        'botCancelar
        '
        Me.botCancelar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botCancelar.Height = 170
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Image)
        Me.botCancelar.ImageSize = New System.Drawing.Size(32, 23)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botCancelar.Text = "Cancelar"
        '
        'botAlteracoes
        '
        Me.botAlteracoes.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botAlteracoes.Image = CType(resources.GetObject("botAlteracoes.Image"), System.Drawing.Image)
        Me.botAlteracoes.ImageSize = New System.Drawing.Size(32, 32)
        Me.botAlteracoes.Name = "botAlteracoes"
        Me.botAlteracoes.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botAlteracoes.Text = "Alterações"
        '
        'botAnexos
        '
        Me.botAnexos.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botAnexos.Image = CType(resources.GetObject("botAnexos.Image"), System.Drawing.Image)
        Me.botAnexos.ImageSize = New System.Drawing.Size(32, 32)
        Me.botAnexos.Name = "botAnexos"
        Me.botAnexos.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botAnexos.Text = "Anexos"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 368)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(1014, 51)
        Me.C1InputPanel2.TabIndex = 34
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Cópias"
        '
        'gridCopiasManual
        '
        Me.gridCopiasManual.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridCopiasManual.AllowEditing = False
        Me.gridCopiasManual.AllowFiltering = True
        Me.gridCopiasManual.ColumnInfo = resources.GetString("gridCopiasManual.ColumnInfo")
        Me.gridCopiasManual.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gridCopiasManual.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridCopiasManual.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridCopiasManual.Location = New System.Drawing.Point(0, 436)
        Me.gridCopiasManual.Name = "gridCopiasManual"
        Me.gridCopiasManual.Rows.DefaultSize = 21
        Me.gridCopiasManual.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridCopiasManual.ShowSortPosition = C1.Win.C1FlexGrid.ShowSortPositionEnum.None
        Me.gridCopiasManual.Size = New System.Drawing.Size(1014, 128)
        Me.gridCopiasManual.StyleInfo = resources.GetString("gridCopiasManual.StyleInfo")
        Me.gridCopiasManual.TabIndex = 35
        '
        'C1InputPanel15
        '
        Me.C1InputPanel15.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel15.Items.Add(Me.InputGroupHeader14)
        Me.C1InputPanel15.Items.Add(Me.botNovoCopia)
        Me.C1InputPanel15.Items.Add(Me.botEditarCopia)
        Me.C1InputPanel15.Items.Add(Me.botExcluirCopia)
        Me.C1InputPanel15.Items.Add(Me.botVisualizarCopia)
        Me.C1InputPanel15.Location = New System.Drawing.Point(0, 368)
        Me.C1InputPanel15.Name = "C1InputPanel15"
        Me.C1InputPanel15.Size = New System.Drawing.Size(1300, 62)
        Me.C1InputPanel15.TabIndex = 36
        '
        'InputGroupHeader14
        '
        Me.InputGroupHeader14.Name = "InputGroupHeader14"
        Me.InputGroupHeader14.Text = "Cópias"
        '
        'botNovoCopia
        '
        Me.botNovoCopia.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botNovoCopia.Image = CType(resources.GetObject("botNovoCopia.Image"), System.Drawing.Image)
        Me.botNovoCopia.ImageSize = New System.Drawing.Size(20, 20)
        Me.botNovoCopia.Name = "botNovoCopia"
        Me.botNovoCopia.Text = "Novo"
        Me.botNovoCopia.Width = 70
        '
        'botEditarCopia
        '
        Me.botEditarCopia.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botEditarCopia.Image = CType(resources.GetObject("botEditarCopia.Image"), System.Drawing.Image)
        Me.botEditarCopia.ImageSize = New System.Drawing.Size(20, 20)
        Me.botEditarCopia.Name = "botEditarCopia"
        Me.botEditarCopia.Text = "Editar"
        Me.botEditarCopia.Width = 70
        '
        'botExcluirCopia
        '
        Me.botExcluirCopia.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botExcluirCopia.Image = CType(resources.GetObject("botExcluirCopia.Image"), System.Drawing.Image)
        Me.botExcluirCopia.ImageSize = New System.Drawing.Size(20, 20)
        Me.botExcluirCopia.Name = "botExcluirCopia"
        Me.botExcluirCopia.Text = "Excluir"
        Me.botExcluirCopia.Width = 70
        '
        'botVisualizarCopia
        '
        Me.botVisualizarCopia.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botVisualizarCopia.Image = CType(resources.GetObject("botVisualizarCopia.Image"), System.Drawing.Image)
        Me.botVisualizarCopia.ImageSize = New System.Drawing.Size(20, 20)
        Me.botVisualizarCopia.Name = "botVisualizarCopia"
        Me.botVisualizarCopia.Text = "Visualizar"
        '
        'mgListaControleManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(1014, 564)
        Me.Controls.Add(Me.C1InputPanel15)
        Me.Controls.Add(Me.gridCopiasManual)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.gridControleManual)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "mgListaControleManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridControleManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCopiasManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridControleManual As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents botNovo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botAlteracoes As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botAnexos As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botAprovar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botCancelar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridCopiasManual As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel15 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader14 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botNovoCopia As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditarCopia As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluirCopia As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botVisualizarCopia As C1.Win.C1InputPanel.InputButton
End Class
