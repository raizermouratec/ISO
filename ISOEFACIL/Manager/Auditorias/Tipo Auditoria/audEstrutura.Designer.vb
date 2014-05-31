<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class audEstrutura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(audEstrutura))
        Me.C1InputPanel13 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupo = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblProjeto = New C1.Win.C1InputPanel.InputLabel()
        Me.txtTipoAuditoria = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupIncluir = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.radioI1 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioI2 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioI3 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.lblItem = New C1.Win.C1InputPanel.InputLabel()
        Me.txtItem = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblTitulo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtTitulo = New C1.Win.C1InputPanel.InputTextBox()
        Me.botIncluir = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel8 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.botVersao = New C1.Win.C1InputPanel.InputButton()
        Me.gridEstrutura = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupEstruturado = New C1.Win.C1InputPanel.InputGroupHeader()
        CType(Me.C1InputPanel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridEstrutura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel13
        '
        Me.C1InputPanel13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel13.Items.Add(Me.grupo)
        Me.C1InputPanel13.Items.Add(Me.lblProjeto)
        Me.C1InputPanel13.Items.Add(Me.txtTipoAuditoria)
        Me.C1InputPanel13.Location = New System.Drawing.Point(-1, 3)
        Me.C1InputPanel13.Name = "C1InputPanel13"
        Me.C1InputPanel13.Size = New System.Drawing.Size(783, 61)
        Me.C1InputPanel13.TabIndex = 4
        '
        'grupo
        '
        Me.grupo.Name = "grupo"
        Me.grupo.Text = "Nova Auditoria"
        '
        'lblProjeto
        '
        Me.lblProjeto.Name = "lblProjeto"
        Me.lblProjeto.Text = "Tipo de Auditoria:"
        Me.lblProjeto.Width = 103
        '
        'txtTipoAuditoria
        '
        Me.txtTipoAuditoria.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtTipoAuditoria.Enabled = False
        Me.txtTipoAuditoria.Name = "txtTipoAuditoria"
        Me.txtTipoAuditoria.Width = 631
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.grupIncluir)
        Me.C1InputPanel1.Items.Add(Me.radioI1)
        Me.C1InputPanel1.Items.Add(Me.radioI2)
        Me.C1InputPanel1.Items.Add(Me.radioI3)
        Me.C1InputPanel1.Items.Add(Me.lblItem)
        Me.C1InputPanel1.Items.Add(Me.txtItem)
        Me.C1InputPanel1.Items.Add(Me.lblTitulo)
        Me.C1InputPanel1.Items.Add(Me.txtTitulo)
        Me.C1InputPanel1.Items.Add(Me.botIncluir)
        Me.C1InputPanel1.Location = New System.Drawing.Point(-1, 58)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(783, 147)
        Me.C1InputPanel1.TabIndex = 4
        '
        'grupIncluir
        '
        Me.grupIncluir.Name = "grupIncluir"
        Me.grupIncluir.Text = "Nova Auditoria"
        '
        'radioI1
        '
        Me.radioI1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioI1.Name = "radioI1"
        Me.radioI1.Padding = New System.Windows.Forms.Padding(40, 2, 2, 2)
        Me.radioI1.Text = "Item - ( I )"
        '
        'radioI2
        '
        Me.radioI2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioI2.Name = "radioI2"
        Me.radioI2.Text = "Item - ( I.I )"
        '
        'radioI3
        '
        Me.radioI3.Name = "radioI3"
        Me.radioI3.Text = "Item - ( I.I.I )"
        '
        'lblItem
        '
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Text = "Item: "
        Me.lblItem.Width = 36
        '
        'txtItem
        '
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Width = 45
        '
        'lblTitulo
        '
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Text = "Título"
        Me.lblTitulo.Width = 36
        '
        'txtTitulo
        '
        Me.txtTitulo.Height = 39
        Me.txtTitulo.Multiline = True
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtTitulo.Width = 698
        '
        'botIncluir
        '
        Me.botIncluir.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botIncluir.Image = CType(resources.GetObject("botIncluir.Image"), System.Drawing.Image)
        Me.botIncluir.ImageSize = New System.Drawing.Size(20, 20)
        Me.botIncluir.Name = "botIncluir"
        Me.botIncluir.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.botIncluir.Text = "Incluir"
        Me.botIncluir.Width = 95
        '
        'C1InputPanel8
        '
        Me.C1InputPanel8.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel8.Items.Add(Me.grupOpcoes)
        Me.C1InputPanel8.Items.Add(Me.botEditar)
        Me.C1InputPanel8.Items.Add(Me.botExcluir)
        Me.C1InputPanel8.Items.Add(Me.botVersao)
        Me.C1InputPanel8.Location = New System.Drawing.Point(-1, 512)
        Me.C1InputPanel8.Name = "C1InputPanel8"
        Me.C1InputPanel8.Size = New System.Drawing.Size(783, 62)
        Me.C1InputPanel8.TabIndex = 5
        '
        'grupOpcoes
        '
        Me.grupOpcoes.Name = "grupOpcoes"
        Me.grupOpcoes.Text = "Opções"
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
        'botExcluir
        '
        Me.botExcluir.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botExcluir.Image = CType(resources.GetObject("botExcluir.Image"), System.Drawing.Image)
        Me.botExcluir.ImageSize = New System.Drawing.Size(20, 20)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Text = "Excluir"
        Me.botExcluir.Width = 70
        '
        'botVersao
        '
        Me.botVersao.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botVersao.Image = CType(resources.GetObject("botVersao.Image"), System.Drawing.Image)
        Me.botVersao.ImageSize = New System.Drawing.Size(20, 20)
        Me.botVersao.Name = "botVersao"
        Me.botVersao.Padding = New System.Windows.Forms.Padding(530, 0, 0, 0)
        Me.botVersao.Text = "Versão"
        Me.botVersao.Width = 602
        '
        'gridEstrutura
        '
        Me.gridEstrutura.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridEstrutura.AllowEditing = False
        Me.gridEstrutura.AllowFiltering = True
        Me.gridEstrutura.ColumnInfo = resources.GetString("gridEstrutura.ColumnInfo")
        Me.gridEstrutura.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridEstrutura.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridEstrutura.Location = New System.Drawing.Point(-1, 227)
        Me.gridEstrutura.Name = "gridEstrutura"
        Me.gridEstrutura.Rows.DefaultSize = 21
        Me.gridEstrutura.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridEstrutura.Size = New System.Drawing.Size(783, 284)
        Me.gridEstrutura.StyleInfo = resources.GetString("gridEstrutura.StyleInfo")
        Me.gridEstrutura.TabIndex = 6
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupEstruturado)
        Me.C1InputPanel2.Location = New System.Drawing.Point(-1, 204)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(783, 27)
        Me.C1InputPanel2.TabIndex = 4
        '
        'grupEstruturado
        '
        Me.grupEstruturado.Name = "grupEstruturado"
        Me.grupEstruturado.Text = "Estruturando Requisitos"
        '
        'audEstrutura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 573)
        Me.Controls.Add(Me.gridEstrutura)
        Me.Controls.Add(Me.C1InputPanel8)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel13)
        Me.MaximizeBox = False
        Me.Name = "audEstrutura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridEstrutura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel13 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupo As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblProjeto As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtTipoAuditoria As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupIncluir As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botIncluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtTitulo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents C1InputPanel8 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botVersao As C1.Win.C1InputPanel.InputButton
    Friend WithEvents gridEstrutura As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupEstruturado As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents radioI1 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioI2 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioI3 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents lblItem As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtItem As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblTitulo As C1.Win.C1InputPanel.InputLabel
End Class
