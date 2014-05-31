<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cotrRealizacaoTreinamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cotrRealizacaoTreinamentos))
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botRealizar = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botRelatorio = New C1.Win.C1InputPanel.InputSplitButton()
        Me.gridPlanoDatas = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoProgramacaoAnual = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblAno = New C1.Win.C1InputPanel.InputLabel()
        Me.comboAno = New C1.Win.C1InputPanel.InputComboBox()
        Me._imgListLegenda = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPlanoDatas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel4
        '
        resources.ApplyResources(Me.C1InputPanel4, "C1InputPanel4")
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel4.Items.Add(Me.botRealizar)
        Me.C1InputPanel4.Items.Add(Me.botEditar)
        Me.C1InputPanel4.Items.Add(Me.botRelatorio)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        resources.ApplyResources(Me.InputGroupHeader2, "InputGroupHeader2")
        '
        'botRealizar
        '
        resources.ApplyResources(Me.botRealizar, "botRealizar")
        Me.botRealizar.Name = "botRealizar"
        '
        'botEditar
        '
        resources.ApplyResources(Me.botEditar, "botEditar")
        Me.botEditar.Name = "botEditar"
        '
        'botRelatorio
        '
        resources.ApplyResources(Me.botRelatorio, "botRelatorio")
        Me.botRelatorio.Name = "botRelatorio"
        '
        'gridPlanoDatas
        '
        Me.gridPlanoDatas.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridPlanoDatas.AllowEditing = False
        Me.gridPlanoDatas.AllowFiltering = True
        resources.ApplyResources(Me.gridPlanoDatas, "gridPlanoDatas")
        Me.gridPlanoDatas.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridPlanoDatas.Name = "gridPlanoDatas"
        Me.gridPlanoDatas.Rows.Count = 13
        Me.gridPlanoDatas.Rows.DefaultSize = 21
        Me.gridPlanoDatas.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridPlanoDatas.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridPlanoDatas.StyleInfo = resources.GetString("gridPlanoDatas.StyleInfo")
        '
        'C1InputPanel3
        '
        resources.ApplyResources(Me.C1InputPanel3, "C1InputPanel3")
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        resources.ApplyResources(Me.InputGroupHeader1, "InputGroupHeader1")
        '
        'C1InputPanel1
        '
        resources.ApplyResources(Me.C1InputPanel1, "C1InputPanel1")
        Me.C1InputPanel1.Items.Add(Me.grupoProgramacaoAnual)
        Me.C1InputPanel1.Items.Add(Me.lblAno)
        Me.C1InputPanel1.Items.Add(Me.comboAno)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        '
        'grupoProgramacaoAnual
        '
        Me.grupoProgramacaoAnual.Name = "grupoProgramacaoAnual"
        resources.ApplyResources(Me.grupoProgramacaoAnual, "grupoProgramacaoAnual")
        '
        'lblAno
        '
        Me.lblAno.Name = "lblAno"
        resources.ApplyResources(Me.lblAno, "lblAno")
        '
        'comboAno
        '
        Me.comboAno.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.None
        resources.ApplyResources(Me.comboAno, "comboAno")
        Me.comboAno.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboAno.Name = "comboAno"
        '
        '_imgListLegenda
        '
        Me._imgListLegenda.ImageStream = CType(resources.GetObject("_imgListLegenda.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgListLegenda.TransparentColor = System.Drawing.Color.Transparent
        Me._imgListLegenda.Images.SetKeyName(0, "Prog_Verde01.png")
        Me._imgListLegenda.Images.SetKeyName(1, "Prog_Azul01.png")
        Me._imgListLegenda.Images.SetKeyName(2, "Prog_Vermelho01.png")
        Me._imgListLegenda.Images.SetKeyName(3, "Prog_Amarelo01.png")
        Me._imgListLegenda.Images.SetKeyName(4, "Prog_Laranja01.png")
        Me._imgListLegenda.Images.SetKeyName(5, "Prog_Branco.png")
        '
        'cotrRealizacaoTreinamentos
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.C1InputPanel4)
        Me.Controls.Add(Me.gridPlanoDatas)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "cotrRealizacaoTreinamentos"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPlanoDatas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botRealizar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botRelatorio As C1.Win.C1InputPanel.InputSplitButton
    Friend WithEvents gridPlanoDatas As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoProgramacaoAnual As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblAno As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboAno As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents _imgListLegenda As System.Windows.Forms.ImageList
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
End Class
