<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acPlanoAnual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acPlanoAnual))
        Me.grupoProgramacaoAnual = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoLegenda = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.imageProgramada = New C1.Win.C1InputPanel.InputImage()
        Me.lblProgramada = New C1.Win.C1InputPanel.InputLabel()
        Me.imageCancelada = New C1.Win.C1InputPanel.InputImage()
        Me.lblCancelada = New C1.Win.C1InputPanel.InputLabel()
        Me.imageAtrasada = New C1.Win.C1InputPanel.InputImage()
        Me.lblAtrasada = New C1.Win.C1InputPanel.InputLabel()
        Me.imageRealizada = New C1.Win.C1InputPanel.InputImage()
        Me.lblRealizada = New C1.Win.C1InputPanel.InputLabel()
        Me.imageReprogramada = New C1.Win.C1InputPanel.InputImage()
        Me.lblReprogramada = New C1.Win.C1InputPanel.InputLabel()
        Me.gridPlanoDatas = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botNovo = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.botRelatorio = New C1.Win.C1InputPanel.InputSplitButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblAno = New C1.Win.C1InputPanel.InputLabel()
        Me.comboAno = New C1.Win.C1InputPanel.InputComboBox()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.Menu_01 = New C1.Win.C1Command.C1ContextMenu()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdProgramar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdReprogramar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdRemover = New C1.Win.C1Command.C1Command()
        Me.C1Command1 = New C1.Win.C1Command.C1Command()
        Me.MenuTeste = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.IT01 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IT02 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IT03 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.IT04 = New System.Windows.Forms.ToolStripMenuItem()
        Me._imgListLegenda = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPlanoDatas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuTeste.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoProgramacaoAnual
        '
        Me.grupoProgramacaoAnual.Name = "grupoProgramacaoAnual"
        Me.grupoProgramacaoAnual.Text = "Programação Anual"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.grupoLegenda)
        Me.C1InputPanel2.Items.Add(Me.imageProgramada)
        Me.C1InputPanel2.Items.Add(Me.lblProgramada)
        Me.C1InputPanel2.Items.Add(Me.imageCancelada)
        Me.C1InputPanel2.Items.Add(Me.lblCancelada)
        Me.C1InputPanel2.Items.Add(Me.imageAtrasada)
        Me.C1InputPanel2.Items.Add(Me.lblAtrasada)
        Me.C1InputPanel2.Items.Add(Me.imageRealizada)
        Me.C1InputPanel2.Items.Add(Me.lblRealizada)
        Me.C1InputPanel2.Items.Add(Me.imageReprogramada)
        Me.C1InputPanel2.Items.Add(Me.lblReprogramada)
        Me.C1InputPanel2.Location = New System.Drawing.Point(12, 381)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(717, 71)
        Me.C1InputPanel2.TabIndex = 23
        '
        'grupoLegenda
        '
        Me.grupoLegenda.Name = "grupoLegenda"
        Me.grupoLegenda.Text = "Legenda"
        '
        'imageProgramada
        '
        Me.imageProgramada.Break = C1.Win.C1InputPanel.BreakType.None
        Me.imageProgramada.Height = 20
        Me.imageProgramada.Image = CType(resources.GetObject("imageProgramada.Image"), System.Drawing.Image)
        Me.imageProgramada.Name = "imageProgramada"
        Me.imageProgramada.Width = 20
        '
        'lblProgramada
        '
        Me.lblProgramada.Name = "lblProgramada"
        Me.lblProgramada.Text = "Calibração Programada  "
        '
        'imageCancelada
        '
        Me.imageCancelada.Break = C1.Win.C1InputPanel.BreakType.None
        Me.imageCancelada.Height = 20
        Me.imageCancelada.Image = CType(resources.GetObject("imageCancelada.Image"), System.Drawing.Image)
        Me.imageCancelada.Name = "imageCancelada"
        Me.imageCancelada.Width = 20
        '
        'lblCancelada
        '
        Me.lblCancelada.Name = "lblCancelada"
        Me.lblCancelada.Text = "Calibração Cancelada      "
        Me.lblCancelada.Width = 126
        '
        'imageAtrasada
        '
        Me.imageAtrasada.Break = C1.Win.C1InputPanel.BreakType.None
        Me.imageAtrasada.Height = 20
        Me.imageAtrasada.Image = CType(resources.GetObject("imageAtrasada.Image"), System.Drawing.Image)
        Me.imageAtrasada.Name = "imageAtrasada"
        Me.imageAtrasada.Width = 20
        '
        'lblAtrasada
        '
        Me.lblAtrasada.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblAtrasada.Name = "lblAtrasada"
        Me.lblAtrasada.Text = "Calibração Atrasada"
        '
        'imageRealizada
        '
        Me.imageRealizada.Break = C1.Win.C1InputPanel.BreakType.None
        Me.imageRealizada.Height = 20
        Me.imageRealizada.Image = CType(resources.GetObject("imageRealizada.Image"), System.Drawing.Image)
        Me.imageRealizada.Name = "imageRealizada"
        Me.imageRealizada.Width = 20
        '
        'lblRealizada
        '
        Me.lblRealizada.Name = "lblRealizada"
        Me.lblRealizada.Text = "Calibração Realizada      "
        '
        'imageReprogramada
        '
        Me.imageReprogramada.Break = C1.Win.C1InputPanel.BreakType.None
        Me.imageReprogramada.Height = 20
        Me.imageReprogramada.Image = CType(resources.GetObject("imageReprogramada.Image"), System.Drawing.Image)
        Me.imageReprogramada.Name = "imageReprogramada"
        Me.imageReprogramada.Width = 20
        '
        'lblReprogramada
        '
        Me.lblReprogramada.Name = "lblReprogramada"
        Me.lblReprogramada.Text = "Calibração Reprogramada"
        '
        'gridPlanoDatas
        '
        Me.gridPlanoDatas.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridPlanoDatas.AllowEditing = False
        Me.gridPlanoDatas.ColumnInfo = resources.GetString("gridPlanoDatas.ColumnInfo")
        Me.gridPlanoDatas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gridPlanoDatas.Location = New System.Drawing.Point(12, 91)
        Me.gridPlanoDatas.Name = "gridPlanoDatas"
        Me.gridPlanoDatas.Rows.DefaultSize = 19
        Me.gridPlanoDatas.Size = New System.Drawing.Size(717, 276)
        Me.gridPlanoDatas.TabIndex = 22
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Lista de Calibrações"
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel4.Items.Add(Me.botNovo)
        Me.C1InputPanel4.Items.Add(Me.botExcluir)
        Me.C1InputPanel4.Items.Add(Me.botRelatorio)
        Me.C1InputPanel4.Location = New System.Drawing.Point(12, 458)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(717, 60)
        Me.C1InputPanel4.TabIndex = 24
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Opções"
        '
        'botNovo
        '
        Me.botNovo.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botNovo.Image = CType(resources.GetObject("botNovo.Image"), System.Drawing.Image)
        Me.botNovo.ImageSize = New System.Drawing.Size(20, 20)
        Me.botNovo.Name = "botNovo"
        Me.botNovo.Text = "Novo"
        Me.botNovo.Width = 70
        '
        'botExcluir
        '
        Me.botExcluir.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botExcluir.Image = CType(resources.GetObject("botExcluir.Image"), System.Drawing.Image)
        Me.botExcluir.ImageSize = New System.Drawing.Size(20, 20)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Text = "Excluir"
        Me.botExcluir.Width = 70
        '
        'botRelatorio
        '
        Me.botRelatorio.Image = CType(resources.GetObject("botRelatorio.Image"), System.Drawing.Image)
        Me.botRelatorio.ImageSize = New System.Drawing.Size(20, 20)
        Me.botRelatorio.Name = "botRelatorio"
        Me.botRelatorio.Text = "Relatório"
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.grupoProgramacaoAnual)
        Me.C1InputPanel1.Items.Add(Me.lblAno)
        Me.C1InputPanel1.Items.Add(Me.comboAno)
        Me.C1InputPanel1.Location = New System.Drawing.Point(12, 11)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(717, 55)
        Me.C1InputPanel1.TabIndex = 21
        '
        'lblAno
        '
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Text = "Ano"
        Me.lblAno.Width = 36
        '
        'comboAno
        '
        Me.comboAno.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.None
        Me.comboAno.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.comboAno.Name = "comboAno"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.Menu_01)
        Me.C1CommandHolder1.Commands.Add(Me.cmdProgramar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCancelar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdReprogramar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRemover)
        Me.C1CommandHolder1.Commands.Add(Me.C1Command1)
        Me.C1CommandHolder1.Owner = Me
        '
        'Menu_01
        '
        Me.Menu_01.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink2, Me.C1CommandLink1, Me.C1CommandLink3, Me.C1CommandLink4})
        Me.Menu_01.Name = "Menu_01"
        Me.Menu_01.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.Command = Me.cmdProgramar
        '
        'cmdProgramar
        '
        Me.cmdProgramar.Image = CType(resources.GetObject("cmdProgramar.Image"), System.Drawing.Image)
        Me.cmdProgramar.Name = "cmdProgramar"
        Me.cmdProgramar.Text = "Programar Calibração"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.Command = Me.cmdCancelar
        Me.C1CommandLink1.SortOrder = 1
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Text = "Cancelar Calibração"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.Command = Me.cmdReprogramar
        Me.C1CommandLink3.SortOrder = 2
        '
        'cmdReprogramar
        '
        Me.cmdReprogramar.Image = CType(resources.GetObject("cmdReprogramar.Image"), System.Drawing.Image)
        Me.cmdReprogramar.Name = "cmdReprogramar"
        Me.cmdReprogramar.Text = "Reprogramar Calibração"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.Command = Me.cmdRemover
        Me.C1CommandLink4.SortOrder = 3
        '
        'cmdRemover
        '
        Me.cmdRemover.Image = CType(resources.GetObject("cmdRemover.Image"), System.Drawing.Image)
        Me.cmdRemover.Name = "cmdRemover"
        Me.cmdRemover.Text = "Remover"
        Me.cmdRemover.ToolTipText = "Remova a Calibração"
        '
        'C1Command1
        '
        Me.C1Command1.Name = "C1Command1"
        Me.C1Command1.Text = "_______________________________"
        '
        'MenuTeste
        '
        Me.MenuTeste.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IT01, Me.IT02, Me.IT03, Me.ToolStripSeparator1, Me.IT04})
        Me.MenuTeste.Name = "MenuTeste"
        Me.MenuTeste.Size = New System.Drawing.Size(144, 98)
        '
        'IT01
        '
        Me.IT01.Image = CType(resources.GetObject("IT01.Image"), System.Drawing.Image)
        Me.IT01.Name = "IT01"
        Me.IT01.Size = New System.Drawing.Size(143, 22)
        Me.IT01.Text = "Programar"
        '
        'IT02
        '
        Me.IT02.Image = CType(resources.GetObject("IT02.Image"), System.Drawing.Image)
        Me.IT02.Name = "IT02"
        Me.IT02.Size = New System.Drawing.Size(143, 22)
        Me.IT02.Text = "Cancelar"
        '
        'IT03
        '
        Me.IT03.Image = CType(resources.GetObject("IT03.Image"), System.Drawing.Image)
        Me.IT03.Name = "IT03"
        Me.IT03.Size = New System.Drawing.Size(143, 22)
        Me.IT03.Text = "Reprogramar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(140, 6)
        '
        'IT04
        '
        Me.IT04.Image = CType(resources.GetObject("IT04.Image"), System.Drawing.Image)
        Me.IT04.Name = "IT04"
        Me.IT04.Size = New System.Drawing.Size(143, 22)
        Me.IT04.Text = "Remover"
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
        'acPlanoAnual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 529)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.gridPlanoDatas)
        Me.Controls.Add(Me.C1InputPanel4)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Name = "acPlanoAnual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plano Anual"
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPlanoDatas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuTeste.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents grupoProgramacaoAnual As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents grupoLegenda As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents imageProgramada As C1.Win.C1InputPanel.InputImage
    Private WithEvents lblProgramada As C1.Win.C1InputPanel.InputLabel
    Private WithEvents imageCancelada As C1.Win.C1InputPanel.InputImage
    Private WithEvents lblCancelada As C1.Win.C1InputPanel.InputLabel
    Private WithEvents imageAtrasada As C1.Win.C1InputPanel.InputImage
    Private WithEvents lblAtrasada As C1.Win.C1InputPanel.InputLabel
    Private WithEvents imageRealizada As C1.Win.C1InputPanel.InputImage
    Private WithEvents lblRealizada As C1.Win.C1InputPanel.InputLabel
    Private WithEvents imageReprogramada As C1.Win.C1InputPanel.InputImage
    Private WithEvents lblReprogramada As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents gridPlanoDatas As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents botNovo As C1.Win.C1InputPanel.InputButton
    Private WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Private WithEvents botRelatorio As C1.Win.C1InputPanel.InputSplitButton
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents lblAno As C1.Win.C1InputPanel.InputLabel
    Private WithEvents comboAno As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Private WithEvents Menu_01 As C1.Win.C1Command.C1ContextMenu
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdProgramar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdReprogramar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdRemover As C1.Win.C1Command.C1Command
    Friend WithEvents C1Command1 As C1.Win.C1Command.C1Command
    Friend WithEvents MenuTeste As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents IT01 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IT02 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IT03 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IT04 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _imgListLegenda As System.Windows.Forms.ImageList
End Class
