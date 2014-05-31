<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class audRealizarAuditorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(audRealizarAuditorias))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoRealizacaoAud = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblAno = New C1.Win.C1InputPanel.InputLabel()
        Me.comboAno = New C1.Win.C1InputPanel.InputComboBox()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.gridRealizaAuditoria = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botRealizar = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botCheck = New C1.Win.C1InputPanel.InputButton()
        Me.botVisualizar = New C1.Win.C1InputPanel.InputButton()
        Me._imgListLegenda = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRealizaAuditoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.grupoRealizacaoAud)
        Me.C1InputPanel1.Items.Add(Me.lblAno)
        Me.C1InputPanel1.Items.Add(Me.comboAno)
        Me.C1InputPanel1.Location = New System.Drawing.Point(-1, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(717, 57)
        Me.C1InputPanel1.TabIndex = 0
        '
        'grupoRealizacaoAud
        '
        Me.grupoRealizacaoAud.Name = "grupoRealizacaoAud"
        Me.grupoRealizacaoAud.Text = "Situação de Auditorias"
        '
        'lblAno
        '
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Text = "Ano"
        '
        'comboAno
        '
        Me.comboAno.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboAno.Name = "comboAno"
        Me.comboAno.Width = 70
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Location = New System.Drawing.Point(-1, 54)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(717, 252)
        Me.C1InputPanel2.TabIndex = 29
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Lista de Auditorias"
        '
        'gridRealizaAuditoria
        '
        Me.gridRealizaAuditoria.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridRealizaAuditoria.AllowEditing = False
        Me.gridRealizaAuditoria.AllowFiltering = True
        Me.gridRealizaAuditoria.ColumnInfo = resources.GetString("gridRealizaAuditoria.ColumnInfo")
        Me.gridRealizaAuditoria.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridRealizaAuditoria.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridRealizaAuditoria.Location = New System.Drawing.Point(-1, 79)
        Me.gridRealizaAuditoria.Name = "gridRealizaAuditoria"
        Me.gridRealizaAuditoria.Rows.DefaultSize = 21
        Me.gridRealizaAuditoria.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridRealizaAuditoria.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridRealizaAuditoria.Size = New System.Drawing.Size(717, 227)
        Me.gridRealizaAuditoria.StyleInfo = resources.GetString("gridRealizaAuditoria.StyleInfo")
        Me.gridRealizaAuditoria.TabIndex = 30
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel3.Items.Add(Me.botRealizar)
        Me.C1InputPanel3.Items.Add(Me.botEditar)
        Me.C1InputPanel3.Items.Add(Me.botCheck)
        Me.C1InputPanel3.Items.Add(Me.botVisualizar)
        Me.C1InputPanel3.Location = New System.Drawing.Point(-1, 309)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(717, 64)
        Me.C1InputPanel3.TabIndex = 31
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Opções"
        '
        'botRealizar
        '
        Me.botRealizar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botRealizar.Image = CType(resources.GetObject("botRealizar.Image"), System.Drawing.Image)
        Me.botRealizar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botRealizar.Name = "botRealizar"
        Me.botRealizar.Text = "Realizar"
        '
        'botEditar
        '
        Me.botEditar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botEditar.Image = CType(resources.GetObject("botEditar.Image"), System.Drawing.Image)
        Me.botEditar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botEditar.Name = "botEditar"
        Me.botEditar.Text = "Editar"
        Me.botEditar.Width = 70
        '
        'botCheck
        '
        Me.botCheck.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botCheck.Image = CType(resources.GetObject("botCheck.Image"), System.Drawing.Image)
        Me.botCheck.ImageSize = New System.Drawing.Size(20, 20)
        Me.botCheck.Name = "botCheck"
        Me.botCheck.Text = "Check List"
        '
        'botVisualizar
        '
        Me.botVisualizar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botVisualizar.Image = CType(resources.GetObject("botVisualizar.Image"), System.Drawing.Image)
        Me.botVisualizar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botVisualizar.Name = "botVisualizar"
        Me.botVisualizar.Text = "Visualizar"
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
        'audRealizarAuditorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 373)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.gridRealizaAuditoria)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "audRealizarAuditorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realização de Auditorias"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRealizaAuditoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoRealizacaoAud As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblAno As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboAno As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridRealizaAuditoria As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botCheck As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botRealizar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botVisualizar As C1.Win.C1InputPanel.InputButton
    Private WithEvents _imgListLegenda As System.Windows.Forms.ImageList
End Class
