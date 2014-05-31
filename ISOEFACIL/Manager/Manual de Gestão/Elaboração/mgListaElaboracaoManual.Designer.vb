<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mgListaElaboracaoManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mgListaElaboracaoManual))
        Me.gridItensManual = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.comboManual = New C1.Win.C1InputPanel.InputComboBox()
        Me.botTexto = New C1.Win.C1InputPanel.InputButton()
        Me.botVinculadosDoc = New C1.Win.C1InputPanel.InputButton()
        Me.botTitulo = New C1.Win.C1InputPanel.InputButton()
        Me.botAplicacao = New C1.Win.C1InputPanel.InputButton()
        Me.botAlteracoes = New C1.Win.C1InputPanel.InputButton()
        Me.botVisualizar = New C1.Win.C1InputPanel.InputButton()
        CType(Me.gridItensManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridItensManual
        '
        Me.gridItensManual.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridItensManual.AllowEditing = False
        Me.gridItensManual.AllowFiltering = True
        Me.gridItensManual.ColumnInfo = resources.GetString("gridItensManual.ColumnInfo")
        Me.gridItensManual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItensManual.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridItensManual.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridItensManual.Location = New System.Drawing.Point(0, 282)
        Me.gridItensManual.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gridItensManual.Name = "gridItensManual"
        Me.gridItensManual.Rows.DefaultSize = 21
        Me.gridItensManual.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridItensManual.ShowSortPosition = C1.Win.C1FlexGrid.ShowSortPositionEnum.None
        Me.gridItensManual.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridItensManual.Size = New System.Drawing.Size(1362, 459)
        Me.gridItensManual.StyleInfo = resources.GetString("gridItensManual.StyleInfo")
        Me.gridItensManual.TabIndex = 31
        Me.gridItensManual.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackgroundImage = CType(resources.GetObject("C1InputPanel1.BackgroundImage"), System.Drawing.Image)
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1InputPanel1.Items.Add(Me.comboManual)
        Me.C1InputPanel1.Items.Add(Me.botTexto)
        Me.C1InputPanel1.Items.Add(Me.botVinculadosDoc)
        Me.C1InputPanel1.Items.Add(Me.botTitulo)
        Me.C1InputPanel1.Items.Add(Me.botAplicacao)
        Me.C1InputPanel1.Items.Add(Me.botAlteracoes)
        Me.C1InputPanel1.Items.Add(Me.botVisualizar)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1362, 282)
        Me.C1InputPanel1.TabIndex = 30
        '
        'comboManual
        '
        Me.comboManual.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.comboManual.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboManual.Height = 170
        Me.comboManual.Name = "comboManual"
        Me.comboManual.Padding = New System.Windows.Forms.Padding(20, 147, 0, 0)
        Me.comboManual.Width = 326
        '
        'botTexto
        '
        Me.botTexto.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botTexto.Image = CType(resources.GetObject("botTexto.Image"), System.Drawing.Image)
        Me.botTexto.ImageSize = New System.Drawing.Size(32, 32)
        Me.botTexto.Name = "botTexto"
        Me.botTexto.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botTexto.Text = "Texto"
        '
        'botVinculadosDoc
        '
        Me.botVinculadosDoc.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botVinculadosDoc.Image = CType(resources.GetObject("botVinculadosDoc.Image"), System.Drawing.Image)
        Me.botVinculadosDoc.ImageSize = New System.Drawing.Size(32, 32)
        Me.botVinculadosDoc.Name = "botVinculadosDoc"
        Me.botVinculadosDoc.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botVinculadosDoc.Text = "    Vincular " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Documentos"
        '
        'botTitulo
        '
        Me.botTitulo.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botTitulo.Image = CType(resources.GetObject("botTitulo.Image"), System.Drawing.Image)
        Me.botTitulo.ImageSize = New System.Drawing.Size(32, 32)
        Me.botTitulo.Name = "botTitulo"
        Me.botTitulo.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botTitulo.Text = "Titulo"
        '
        'botAplicacao
        '
        Me.botAplicacao.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botAplicacao.Image = CType(resources.GetObject("botAplicacao.Image"), System.Drawing.Image)
        Me.botAplicacao.ImageSize = New System.Drawing.Size(32, 32)
        Me.botAplicacao.Name = "botAplicacao"
        Me.botAplicacao.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botAplicacao.Text = "Aplicação"
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
        'botVisualizar
        '
        Me.botVisualizar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botVisualizar.Image = CType(resources.GetObject("botVisualizar.Image"), System.Drawing.Image)
        Me.botVisualizar.ImageSize = New System.Drawing.Size(32, 32)
        Me.botVisualizar.Name = "botVisualizar"
        Me.botVisualizar.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botVisualizar.Text = "Visualizar"
        '
        'mgListaElaboracaoManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.gridItensManual)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mgListaElaboracaoManual"
        Me.Text = "Itens do Manual de Gestão"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridItensManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridItensManual As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents botTexto As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botVinculadosDoc As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botTitulo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botAplicacao As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botVisualizar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents comboManual As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents botAlteracoes As C1.Win.C1InputPanel.InputButton
End Class
