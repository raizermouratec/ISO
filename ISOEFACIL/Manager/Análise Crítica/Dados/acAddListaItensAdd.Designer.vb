<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acAddListaItensAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acAddListaItensAdd))
        Me.botRemover = New C1.Win.C1InputPanel.InputButton()
        Me.botAdicionar = New C1.Win.C1InputPanel.InputButton()
        Me.txtTitulo = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblTitulo = New C1.Win.C1InputPanel.InputLabel()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.gridItens = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'botRemover
        '
        Me.botRemover.Image = CType(resources.GetObject("botRemover.Image"), System.Drawing.Image)
        Me.botRemover.ImageSize = New System.Drawing.Size(18, 18)
        Me.botRemover.Name = "botRemover"
        '
        'botAdicionar
        '
        Me.botAdicionar.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botAdicionar.Image = CType(resources.GetObject("botAdicionar.Image"), System.Drawing.Image)
        Me.botAdicionar.ImageSize = New System.Drawing.Size(18, 18)
        Me.botAdicionar.Name = "botAdicionar"
        '
        'txtTitulo
        '
        Me.txtTitulo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Width = 311
        '
        'lblTitulo
        '
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Text = "Título :"
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.lblTitulo)
        Me.C1InputPanel1.Items.Add(Me.txtTitulo)
        Me.C1InputPanel1.Items.Add(Me.botAdicionar)
        Me.C1InputPanel1.Items.Add(Me.botRemover)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(431, 263)
        Me.C1InputPanel1.TabIndex = 0
        '
        'gridItens
        '
        Me.gridItens.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridItens.AllowEditing = False
        Me.gridItens.AllowFiltering = True
        Me.gridItens.ColumnInfo = resources.GetString("gridItens.ColumnInfo")
        Me.gridItens.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridItens.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridItens.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.gridItens.Location = New System.Drawing.Point(0, 31)
        Me.gridItens.Name = "gridItens"
        Me.gridItens.Rows.DefaultSize = 21
        Me.gridItens.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridItens.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridItens.Size = New System.Drawing.Size(427, 334)
        Me.gridItens.StyleInfo = resources.GetString("gridItens.StyleInfo")
        Me.gridItens.TabIndex = 5
        Me.gridItens.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'acAddListaItensAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 366)
        Me.Controls.Add(Me.gridItens)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "acAddListaItensAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Itens do Relatório de Dados"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents botRemover As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botAdicionar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtTitulo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblTitulo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents gridItens As C1.Win.C1FlexGrid.C1FlexGrid
End Class
