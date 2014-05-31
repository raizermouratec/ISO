<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class audListaTipoAuditorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(audListaTipoAuditorias))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.botNovo = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.botEstrutura = New C1.Win.C1InputPanel.InputButton()
        Me.botRelatorio = New C1.Win.C1InputPanel.InputButton()
        Me.gridAuditorias = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAuditorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.C1InputPanel1.Items.Add(Me.botEstrutura)
        Me.C1InputPanel1.Items.Add(Me.botRelatorio)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1008, 183)
        Me.C1InputPanel1.TabIndex = 27
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
        'botEstrutura
        '
        Me.botEstrutura.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botEstrutura.Image = CType(resources.GetObject("botEstrutura.Image"), System.Drawing.Image)
        Me.botEstrutura.ImageSize = New System.Drawing.Size(32, 32)
        Me.botEstrutura.Name = "botEstrutura"
        Me.botEstrutura.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botEstrutura.Text = "Estrutura"
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
        'gridAuditorias
        '
        Me.gridAuditorias.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridAuditorias.AllowEditing = False
        Me.gridAuditorias.AllowFiltering = True
        Me.gridAuditorias.ColumnInfo = resources.GetString("gridAuditorias.ColumnInfo")
        Me.gridAuditorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridAuditorias.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridAuditorias.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridAuditorias.Location = New System.Drawing.Point(0, 183)
        Me.gridAuditorias.Name = "gridAuditorias"
        Me.gridAuditorias.Rows.DefaultSize = 21
        Me.gridAuditorias.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridAuditorias.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridAuditorias.Size = New System.Drawing.Size(1008, 381)
        Me.gridAuditorias.StyleInfo = resources.GetString("gridAuditorias.StyleInfo")
        Me.gridAuditorias.TabIndex = 28
        '
        'audListaTipoAuditorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1008, 564)
        Me.Controls.Add(Me.gridAuditorias)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "audListaTipoAuditorias"
        Me.Text = "Cadastro de Tipos de Auditorias"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAuditorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents botNovo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botRelatorio As C1.Win.C1InputPanel.InputButton
    Friend WithEvents gridAuditorias As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEstrutura As C1.Win.C1InputPanel.InputButton
End Class
