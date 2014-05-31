<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class poliListaPolitica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(poliListaPolitica))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.botNovo = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.botRelacao = New C1.Win.C1InputPanel.InputButton()
        Me.botVisualizar = New C1.Win.C1InputPanel.InputButton()
        Me.gridPolitica = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPolitica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.C1InputPanel1.Items.Add(Me.botRelacao)
        Me.C1InputPanel1.Items.Add(Me.botVisualizar)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1008, 183)
        Me.C1InputPanel1.TabIndex = 28
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
        Me.botEditar.Text = "Revisar"
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
        'botVisualizar
        '
        Me.botVisualizar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botVisualizar.Image = CType(resources.GetObject("botVisualizar.Image"), System.Drawing.Image)
        Me.botVisualizar.ImageSize = New System.Drawing.Size(32, 32)
        Me.botVisualizar.Name = "botVisualizar"
        Me.botVisualizar.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botVisualizar.Text = "Visualizar"
        '
        'gridPolitica
        '
        Me.gridPolitica.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridPolitica.AllowEditing = False
        Me.gridPolitica.AllowFiltering = True
        Me.gridPolitica.ColumnInfo = resources.GetString("gridPolitica.ColumnInfo")
        Me.gridPolitica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPolitica.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridPolitica.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridPolitica.Location = New System.Drawing.Point(0, 183)
        Me.gridPolitica.Name = "gridPolitica"
        Me.gridPolitica.Rows.DefaultSize = 21
        Me.gridPolitica.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridPolitica.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridPolitica.Size = New System.Drawing.Size(1008, 381)
        Me.gridPolitica.StyleInfo = resources.GetString("gridPolitica.StyleInfo")
        Me.gridPolitica.TabIndex = 29
        '
        'poliListaPolitica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 564)
        Me.Controls.Add(Me.gridPolitica)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "poliListaPolitica"
        Me.Text = "Política"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPolitica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents botNovo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents gridPolitica As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents botRelacao As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botVisualizar As C1.Win.C1InputPanel.InputButton
End Class
