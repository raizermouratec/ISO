<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class docAnexosExternos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(docAnexosExternos))
        Me.picAnexo = New System.Windows.Forms.PictureBox()
        Me.C1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader7 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botAnexos = New C1.Win.C1InputPanel.InputButton()
        Me.gridAnexos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.barra = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me._imgListLegenda = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.picAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picAnexo
        '
        Me.picAnexo.Location = New System.Drawing.Point(641, 305)
        Me.picAnexo.Name = "picAnexo"
        Me.picAnexo.Size = New System.Drawing.Size(28, 22)
        Me.picAnexo.TabIndex = 11
        Me.picAnexo.TabStop = False
        Me.picAnexo.Visible = False
        '
        'C1InputPanel7
        '
        Me.C1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel7.Items.Add(Me.InputGroupHeader7)
        Me.C1InputPanel7.Items.Add(Me.botAnexos)
        Me.C1InputPanel7.Location = New System.Drawing.Point(3, 277)
        Me.C1InputPanel7.Name = "C1InputPanel7"
        Me.C1InputPanel7.Size = New System.Drawing.Size(676, 60)
        Me.C1InputPanel7.TabIndex = 10
        '
        'InputGroupHeader7
        '
        Me.InputGroupHeader7.Name = "InputGroupHeader7"
        Me.InputGroupHeader7.Text = "Opções"
        '
        'botAnexos
        '
        Me.botAnexos.Image = CType(resources.GetObject("botAnexos.Image"), System.Drawing.Image)
        Me.botAnexos.ImageSize = New System.Drawing.Size(20, 20)
        Me.botAnexos.Name = "botAnexos"
        Me.botAnexos.Text = "Anexos"
        '
        'gridAnexos
        '
        Me.gridAnexos.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridAnexos.AllowEditing = False
        Me.gridAnexos.AllowFiltering = True
        Me.gridAnexos.ColumnInfo = resources.GetString("gridAnexos.ColumnInfo")
        Me.gridAnexos.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridAnexos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridAnexos.Location = New System.Drawing.Point(3, 37)
        Me.gridAnexos.Name = "gridAnexos"
        Me.gridAnexos.Rows.DefaultSize = 21
        Me.gridAnexos.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridAnexos.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridAnexos.Size = New System.Drawing.Size(676, 234)
        Me.gridAnexos.StyleInfo = resources.GetString("gridAnexos.StyleInfo")
        Me.gridAnexos.TabIndex = 9
        Me.gridAnexos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel6.Location = New System.Drawing.Point(3, 12)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(676, 259)
        Me.C1InputPanel6.TabIndex = 8
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "Lista de Anexos"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.barra, Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 338)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(684, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'barra
        '
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(100, 16)
        '
        'lblStatus
        '
        Me.lblStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        '_imgListLegenda
        '
        Me._imgListLegenda.ImageStream = CType(resources.GetObject("_imgListLegenda.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgListLegenda.TransparentColor = System.Drawing.Color.Transparent
        Me._imgListLegenda.Images.SetKeyName(0, "ico_word.png")
        Me._imgListLegenda.Images.SetKeyName(1, "ico_excel.png")
        Me._imgListLegenda.Images.SetKeyName(2, "ico_pdf.png")
        Me._imgListLegenda.Images.SetKeyName(3, "ico_txt.png")
        Me._imgListLegenda.Images.SetKeyName(4, "ico_powerpoint.png")
        Me._imgListLegenda.Images.SetKeyName(5, "ico_outlook.png")
        Me._imgListLegenda.Images.SetKeyName(6, "ico_out.png")
        '
        'docAnexosExternos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 360)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.picAnexo)
        Me.Controls.Add(Me.C1InputPanel7)
        Me.Controls.Add(Me.gridAnexos)
        Me.Controls.Add(Me.C1InputPanel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "docAnexosExternos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anexos documentos externos"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.picAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picAnexo As System.Windows.Forms.PictureBox
    Friend WithEvents C1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader7 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botAnexos As C1.Win.C1InputPanel.InputButton
    Friend WithEvents gridAnexos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents barra As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents _imgListLegenda As System.Windows.Forms.ImageList
End Class
