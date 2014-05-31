<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forListaPerfil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forListaPerfil))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.botNovo = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.bot_Excluir = New C1.Win.C1InputPanel.InputButton()
        Me.grid_Perfil = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_Perfil, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.C1InputPanel1.Items.Add(Me.bot_Excluir)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1008, 183)
        Me.C1InputPanel1.TabIndex = 21
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
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
        'bot_Excluir
        '
        Me.bot_Excluir.Image = CType(resources.GetObject("bot_Excluir.Image"), System.Drawing.Image)
        Me.bot_Excluir.ImageSize = New System.Drawing.Size(32, 32)
        Me.bot_Excluir.Name = "bot_Excluir"
        Me.bot_Excluir.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.bot_Excluir.Text = "Excluir"
        '
        'grid_Perfil
        '
        Me.grid_Perfil.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.grid_Perfil.AllowEditing = False
        Me.grid_Perfil.ColumnInfo = resources.GetString("grid_Perfil.ColumnInfo")
        Me.grid_Perfil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Perfil.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.grid_Perfil.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.grid_Perfil.Location = New System.Drawing.Point(0, 183)
        Me.grid_Perfil.Name = "grid_Perfil"
        Me.grid_Perfil.Rows.Count = 1
        Me.grid_Perfil.Rows.DefaultSize = 21
        Me.grid_Perfil.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.grid_Perfil.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.WhenEditing
        Me.grid_Perfil.Size = New System.Drawing.Size(1008, 381)
        Me.grid_Perfil.StyleInfo = resources.GetString("grid_Perfil.StyleInfo")
        Me.grid_Perfil.TabIndex = 23
        Me.grid_Perfil.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'forListaPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 564)
        Me.Controls.Add(Me.grid_Perfil)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Name = "forListaPerfil"
        Me.Text = "Listagem Perfil"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_Perfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents botNovo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents bot_Excluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents grid_Perfil As C1.Win.C1FlexGrid.C1FlexGrid
End Class
