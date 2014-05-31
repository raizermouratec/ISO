<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class docAnexosElaboracao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(docAnexosElaboracao))
        Me._imgListLegenda = New System.Windows.Forms.ImageList(Me.components)
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.gridAnexos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1StatusBar1 = New C1.Win.C1Ribbon.C1StatusBar()
        Me.barra = New C1.Win.C1Ribbon.RibbonProgressBar()
        Me.lblStatus = New C1.Win.C1Ribbon.RibbonLabel()
        Me.C1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader7 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botAnexos = New C1.Win.C1InputPanel.InputButton()
        Me.picAnexo = New System.Windows.Forms.PictureBox()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1StatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_imgListLegenda
        '
        Me._imgListLegenda.ImageStream = CType(resources.GetObject("_imgListLegenda.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgListLegenda.TransparentColor = System.Drawing.Color.Transparent
        Me._imgListLegenda.Images.SetKeyName(0, "Word-16.gif")
        Me._imgListLegenda.Images.SetKeyName(1, "Excel-16.gif")
        Me._imgListLegenda.Images.SetKeyName(2, "Acrobat-48.png")
        Me._imgListLegenda.Images.SetKeyName(3, "Mimetypes-txt-icon.png")
        Me._imgListLegenda.Images.SetKeyName(4, "PowerPoint-16.gif")
        Me._imgListLegenda.Images.SetKeyName(5, "Microsoft-Outlook-icon.png")
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel6.Location = New System.Drawing.Point(0, 2)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(684, 160)
        Me.C1InputPanel6.TabIndex = 16
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "Lista de Anexos"
        '
        'gridAnexos
        '
        Me.gridAnexos.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridAnexos.AllowEditing = False
        Me.gridAnexos.AllowFiltering = True
        Me.gridAnexos.ColumnInfo = resources.GetString("gridAnexos.ColumnInfo")
        Me.gridAnexos.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridAnexos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridAnexos.Location = New System.Drawing.Point(0, 24)
        Me.gridAnexos.Name = "gridAnexos"
        Me.gridAnexos.Rows.DefaultSize = 20
        Me.gridAnexos.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridAnexos.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridAnexos.Size = New System.Drawing.Size(683, 138)
        Me.gridAnexos.StyleInfo = resources.GetString("gridAnexos.StyleInfo")
        Me.gridAnexos.TabIndex = 17
        Me.gridAnexos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1StatusBar1
        '
        Me.C1StatusBar1.LeftPaneItems.Add(Me.barra)
        Me.C1StatusBar1.LeftPaneItems.Add(Me.lblStatus)
        Me.C1StatusBar1.Name = "C1StatusBar1"
        '
        'barra
        '
        Me.barra.Height = 20
        Me.barra.Name = "barra"
        Me.barra.Width = 200
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        '
        'C1InputPanel7
        '
        Me.C1InputPanel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1InputPanel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel7.Items.Add(Me.InputGroupHeader7)
        Me.C1InputPanel7.Items.Add(Me.botAnexos)
        Me.C1InputPanel7.Location = New System.Drawing.Point(0, 167)
        Me.C1InputPanel7.Name = "C1InputPanel7"
        Me.C1InputPanel7.Size = New System.Drawing.Size(682, 60)
        Me.C1InputPanel7.TabIndex = 36
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
        'picAnexo
        '
        Me.picAnexo.Location = New System.Drawing.Point(642, 199)
        Me.picAnexo.Name = "picAnexo"
        Me.picAnexo.Size = New System.Drawing.Size(28, 22)
        Me.picAnexo.TabIndex = 37
        Me.picAnexo.TabStop = False
        Me.picAnexo.Visible = False
        '
        'docAnexosElaboracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 250)
        Me.Controls.Add(Me.picAnexo)
        Me.Controls.Add(Me.C1InputPanel7)
        Me.Controls.Add(Me.C1StatusBar1)
        Me.Controls.Add(Me.gridAnexos)
        Me.Controls.Add(Me.C1InputPanel6)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "docAnexosElaboracao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anexos Elaboração de Documentos"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1StatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents _imgListLegenda As System.Windows.Forms.ImageList
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridAnexos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1StatusBar1 As C1.Win.C1Ribbon.C1StatusBar
    Friend WithEvents barra As C1.Win.C1Ribbon.RibbonProgressBar
    Friend WithEvents lblStatus As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents C1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader7 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botAnexos As C1.Win.C1InputPanel.InputButton
    Friend WithEvents picAnexo As System.Windows.Forms.PictureBox
End Class
