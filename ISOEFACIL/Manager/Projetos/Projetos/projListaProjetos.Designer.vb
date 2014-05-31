<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projListaProjetos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projListaProjetos))
        Me.gridProjetos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.botNovo = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.botPlano = New C1.Win.C1InputPanel.InputButton()
        Me.botRelacao = New C1.Win.C1InputPanel.InputButton()
        Me.botVisualizar = New C1.Win.C1InputPanel.InputButton()
        CType(Me.gridProjetos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridProjetos
        '
        Me.gridProjetos.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridProjetos.AllowEditing = False
        Me.gridProjetos.ColumnInfo = resources.GetString("gridProjetos.ColumnInfo")
        Me.gridProjetos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridProjetos.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridProjetos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridProjetos.Location = New System.Drawing.Point(0, 183)
        Me.gridProjetos.Name = "gridProjetos"
        Me.gridProjetos.Rows.DefaultSize = 21
        Me.gridProjetos.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridProjetos.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.gridProjetos.Size = New System.Drawing.Size(1008, 381)
        Me.gridProjetos.StyleInfo = resources.GetString("gridProjetos.StyleInfo")
        Me.gridProjetos.TabIndex = 27
        Me.gridProjetos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackgroundImage = CType(resources.GetObject("C1InputPanel1.BackgroundImage"), System.Drawing.Image)
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1InputPanel1.Items.Add(Me.botNovo)
        Me.C1InputPanel1.Items.Add(Me.botEditar)
        Me.C1InputPanel1.Items.Add(Me.botExcluir)
        Me.C1InputPanel1.Items.Add(Me.botPlano)
        Me.C1InputPanel1.Items.Add(Me.botRelacao)
        Me.C1InputPanel1.Items.Add(Me.botVisualizar)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1008, 183)
        Me.C1InputPanel1.TabIndex = 26
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
        'botPlano
        '
        Me.botPlano.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botPlano.Image = CType(resources.GetObject("botPlano.Image"), System.Drawing.Image)
        Me.botPlano.ImageSize = New System.Drawing.Size(32, 32)
        Me.botPlano.Name = "botPlano"
        Me.botPlano.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botPlano.Text = "Plano"
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
        'botVisualizar
        '
        Me.botVisualizar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botVisualizar.Image = CType(resources.GetObject("botVisualizar.Image"), System.Drawing.Image)
        Me.botVisualizar.ImageSize = New System.Drawing.Size(32, 32)
        Me.botVisualizar.Name = "botVisualizar"
        Me.botVisualizar.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botVisualizar.Text = "Visualizar"
        '
        'projListaProjetos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 564)
        Me.Controls.Add(Me.gridProjetos)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "projListaProjetos"
        Me.Text = "Projetos"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridProjetos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents botNovo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents gridProjetos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents botPlano As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botRelacao As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botVisualizar As C1.Win.C1InputPanel.InputButton
End Class
