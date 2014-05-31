<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cotrListaCargos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cotrListaCargos))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.gridCargos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me._imgListSituacao = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackgroundImage = CType(resources.GetObject("C1InputPanel1.BackgroundImage"), System.Drawing.Image)
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1InputPanel1.Items.Add(Me.botEditar)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1008, 183)
        Me.C1InputPanel1.TabIndex = 14
        '
        'botEditar
        '
        Me.botEditar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botEditar.Image = CType(resources.GetObject("botEditar.Image"), System.Drawing.Image)
        Me.botEditar.ImageSize = New System.Drawing.Size(32, 32)
        Me.botEditar.Name = "botEditar"
        Me.botEditar.Padding = New System.Windows.Forms.Padding(180, 130, 0, 0)
        Me.botEditar.Text = "Editar"
        '
        'gridCargos
        '
        Me.gridCargos.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridCargos.AllowEditing = False
        Me.gridCargos.AllowFiltering = True
        Me.gridCargos.AutoGenerateColumns = False
        Me.gridCargos.ColumnInfo = resources.GetString("gridCargos.ColumnInfo")
        Me.gridCargos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCargos.ExtendLastCol = True
        Me.gridCargos.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridCargos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridCargos.Location = New System.Drawing.Point(0, 183)
        Me.gridCargos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridCargos.Name = "gridCargos"
        Me.gridCargos.Rows.Count = 13
        Me.gridCargos.Rows.DefaultSize = 21
        Me.gridCargos.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridCargos.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridCargos.Size = New System.Drawing.Size(1008, 381)
        Me.gridCargos.StyleInfo = resources.GetString("gridCargos.StyleInfo")
        Me.gridCargos.TabIndex = 39
        Me.gridCargos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        '_imgListSituacao
        '
        Me._imgListSituacao.ImageStream = CType(resources.GetObject("_imgListSituacao.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgListSituacao.TransparentColor = System.Drawing.Color.Transparent
        Me._imgListSituacao.Images.SetKeyName(0, "ativo.png")
        Me._imgListSituacao.Images.SetKeyName(1, "inativo.png")
        '
        'cotrListaCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 564)
        Me.Controls.Add(Me.gridCargos)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cotrListaCargos"
        Me.Text = "Cargos"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCargos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents gridCargos As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents _imgListSituacao As System.Windows.Forms.ImageList
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
End Class
