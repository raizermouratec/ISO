<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projCadObjetivoEstruturado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projCadObjetivoEstruturado))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupEstruturado = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblResultado = New C1.Win.C1InputPanel.InputLabel()
        Me.txtResultadox = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblQuantidade = New C1.Win.C1InputPanel.InputLabel()
        Me.txtQuantidade = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblUnidade = New C1.Win.C1InputPanel.InputLabel()
        Me.txtUnidade = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblFormaAvaliacao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtFormaAvaliacaox = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblAlcancado = New C1.Win.C1InputPanel.InputLabel()
        Me.radioSim = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioNao = New C1.Win.C1InputPanel.InputRadioButton()
        Me.gridObjEstruturado = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botIncluir = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.txtFormaAvaliacao = New C1.Win.C1Input.C1TextBox()
        Me.txtResultado = New C1.Win.C1Input.C1TextBox()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridObjEstruturado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormaAvaliacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.grupEstruturado)
        Me.C1InputPanel1.Items.Add(Me.lblResultado)
        Me.C1InputPanel1.Items.Add(Me.txtResultadox)
        Me.C1InputPanel1.Items.Add(Me.lblQuantidade)
        Me.C1InputPanel1.Items.Add(Me.txtQuantidade)
        Me.C1InputPanel1.Items.Add(Me.lblUnidade)
        Me.C1InputPanel1.Items.Add(Me.txtUnidade)
        Me.C1InputPanel1.Items.Add(Me.lblFormaAvaliacao)
        Me.C1InputPanel1.Items.Add(Me.txtFormaAvaliacaox)
        Me.C1InputPanel1.Items.Add(Me.lblAlcancado)
        Me.C1InputPanel1.Items.Add(Me.radioSim)
        Me.C1InputPanel1.Items.Add(Me.radioNao)
        Me.C1InputPanel1.Location = New System.Drawing.Point(1, 3)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(516, 214)
        Me.C1InputPanel1.TabIndex = 0
        '
        'grupEstruturado
        '
        Me.grupEstruturado.Name = "grupEstruturado"
        Me.grupEstruturado.Text = "Objetivo Estruturado"
        '
        'lblResultado
        '
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Text = "Resultado:"
        Me.lblResultado.Width = 110
        '
        'txtResultadox
        '
        Me.txtResultadox.Height = 52
        Me.txtResultadox.Multiline = True
        Me.txtResultadox.Name = "txtResultadox"
        Me.txtResultadox.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtResultadox.Width = 380
        '
        'lblQuantidade
        '
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Text = "Quantidade:"
        Me.lblQuantidade.Width = 110
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Name = "txtQuantidade"
        '
        'lblUnidade
        '
        Me.lblUnidade.Name = "lblUnidade"
        Me.lblUnidade.Text = "Unidade:"
        Me.lblUnidade.Width = 110
        '
        'txtUnidade
        '
        Me.txtUnidade.Name = "txtUnidade"
        '
        'lblFormaAvaliacao
        '
        Me.lblFormaAvaliacao.Name = "lblFormaAvaliacao"
        Me.lblFormaAvaliacao.Text = "Forma de avaliação:"
        Me.lblFormaAvaliacao.Width = 110
        '
        'txtFormaAvaliacaox
        '
        Me.txtFormaAvaliacaox.Height = 52
        Me.txtFormaAvaliacaox.Multiline = True
        Me.txtFormaAvaliacaox.Name = "txtFormaAvaliacaox"
        Me.txtFormaAvaliacaox.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtFormaAvaliacaox.Width = 380
        '
        'lblAlcancado
        '
        Me.lblAlcancado.Name = "lblAlcancado"
        Me.lblAlcancado.Text = "Alcançado ?"
        Me.lblAlcancado.Width = 110
        '
        'radioSim
        '
        Me.radioSim.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioSim.Name = "radioSim"
        Me.radioSim.Text = "Sim"
        Me.radioSim.Width = 100
        '
        'radioNao
        '
        Me.radioNao.Name = "radioNao"
        Me.radioNao.Text = "Não"
        '
        'gridObjEstruturado
        '
        Me.gridObjEstruturado.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridObjEstruturado.AllowEditing = False
        Me.gridObjEstruturado.ColumnInfo = resources.GetString("gridObjEstruturado.ColumnInfo")
        Me.gridObjEstruturado.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridObjEstruturado.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridObjEstruturado.Location = New System.Drawing.Point(1, 210)
        Me.gridObjEstruturado.Name = "gridObjEstruturado"
        Me.gridObjEstruturado.Rows.DefaultSize = 21
        Me.gridObjEstruturado.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridObjEstruturado.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridObjEstruturado.Size = New System.Drawing.Size(516, 167)
        Me.gridObjEstruturado.StyleInfo = resources.GetString("gridObjEstruturado.StyleInfo")
        Me.gridObjEstruturado.TabIndex = 3
        Me.gridObjEstruturado.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.botIncluir)
        Me.C1InputPanel2.Items.Add(Me.botEditar)
        Me.C1InputPanel2.Items.Add(Me.botExcluir)
        Me.C1InputPanel2.Location = New System.Drawing.Point(1, 381)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(516, 64)
        Me.C1InputPanel2.TabIndex = 4
        '
        'grupoOpcoes
        '
        Me.grupoOpcoes.Name = "grupoOpcoes"
        Me.grupoOpcoes.Text = "Opções"
        '
        'botIncluir
        '
        Me.botIncluir.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botIncluir.Image = CType(resources.GetObject("botIncluir.Image"), System.Drawing.Image)
        Me.botIncluir.ImageSize = New System.Drawing.Size(20, 20)
        Me.botIncluir.Name = "botIncluir"
        Me.botIncluir.Text = "Incluir"
        Me.botIncluir.Width = 70
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
        Me.botExcluir.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botExcluir.Image = CType(resources.GetObject("botExcluir.Image"), System.Drawing.Image)
        Me.botExcluir.ImageSize = New System.Drawing.Size(20, 20)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Text = "Excluir"
        Me.botExcluir.Width = 70
        '
        'txtFormaAvaliacao
        '
        Me.txtFormaAvaliacao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtFormaAvaliacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFormaAvaliacao.Location = New System.Drawing.Point(125, 136)
        Me.txtFormaAvaliacao.Multiline = True
        Me.txtFormaAvaliacao.Name = "txtFormaAvaliacao"
        Me.txtFormaAvaliacao.Size = New System.Drawing.Size(380, 52)
        Me.txtFormaAvaliacao.TabIndex = 5
        Me.txtFormaAvaliacao.Tag = Nothing
        Me.txtFormaAvaliacao.TextDetached = True
        '
        'txtResultado
        '
        Me.txtResultado.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultado.Location = New System.Drawing.Point(125, 28)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(380, 52)
        Me.txtResultado.TabIndex = 5
        Me.txtResultado.Tag = Nothing
        Me.txtResultado.TextDetached = True
        '
        'projCadObjetivoEstruturado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 447)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtFormaAvaliacao)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.gridObjEstruturado)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "projCadObjetivoEstruturado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Objetivo Estruturado"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridObjEstruturado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormaAvaliacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents lblResultado As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtResultadox As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblQuantidade As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtQuantidade As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblUnidade As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtUnidade As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblFormaAvaliacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtFormaAvaliacaox As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblAlcancado As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents radioSim As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioNao As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents gridObjEstruturado As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botIncluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtFormaAvaliacao As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtResultado As C1.Win.C1Input.C1TextBox
    Friend WithEvents grupEstruturado As C1.Win.C1InputPanel.InputGroupHeader
End Class
