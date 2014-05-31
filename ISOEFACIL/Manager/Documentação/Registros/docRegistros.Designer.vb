<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class docRegistros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(docRegistros))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lbl1 = New C1.Win.C1InputPanel.InputLabel()
        Me.DthDataUltimaAlteracao = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lbl2 = New C1.Win.C1InputPanel.InputLabel()
        Me.comboElaboradopor = New C1.Win.C1InputPanel.InputComboBox()
        Me.lbl3 = New C1.Win.C1InputPanel.InputLabel()
        Me.comboFiltrarpor = New C1.Win.C1InputPanel.InputComboBox()
        Me.botFiltro = New C1.Win.C1InputPanel.InputButton()
        Me.lbl4 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtIdentificacao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lbl5 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtArmazenamento = New C1.Win.C1InputPanel.InputTextBox()
        Me.lbl6 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtProtecao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lbl7 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRecuperacao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lbl8 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRetencao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lbl9 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtDisposicao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lbl10 = New C1.Win.C1InputPanel.InputLabel()
        Me.comboAreaElaboracao = New C1.Win.C1InputPanel.InputComboBox()
        Me.gridRegistros = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel17 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botIncluir = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.botUltimaData = New C1.Win.C1InputPanel.InputButton()
        Me.botObservacoes = New C1.Win.C1InputPanel.InputButton()
        Me.botVisualizar = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton1 = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton2 = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.lbl1)
        Me.C1InputPanel1.Items.Add(Me.DthDataUltimaAlteracao)
        Me.C1InputPanel1.Items.Add(Me.lbl2)
        Me.C1InputPanel1.Items.Add(Me.comboElaboradopor)
        Me.C1InputPanel1.Items.Add(Me.lbl3)
        Me.C1InputPanel1.Items.Add(Me.comboFiltrarpor)
        Me.C1InputPanel1.Items.Add(Me.botFiltro)
        Me.C1InputPanel1.Items.Add(Me.lbl4)
        Me.C1InputPanel1.Items.Add(Me.txtIdentificacao)
        Me.C1InputPanel1.Items.Add(Me.lbl5)
        Me.C1InputPanel1.Items.Add(Me.txtArmazenamento)
        Me.C1InputPanel1.Items.Add(Me.lbl6)
        Me.C1InputPanel1.Items.Add(Me.txtProtecao)
        Me.C1InputPanel1.Items.Add(Me.lbl7)
        Me.C1InputPanel1.Items.Add(Me.txtRecuperacao)
        Me.C1InputPanel1.Items.Add(Me.lbl8)
        Me.C1InputPanel1.Items.Add(Me.txtRetencao)
        Me.C1InputPanel1.Items.Add(Me.lbl9)
        Me.C1InputPanel1.Items.Add(Me.txtDisposicao)
        Me.C1InputPanel1.Items.Add(Me.lbl10)
        Me.C1InputPanel1.Items.Add(Me.comboAreaElaboracao)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 1)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(662, 263)
        Me.C1InputPanel1.TabIndex = 0
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Registros"
        '
        'lbl1
        '
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Text = "Data da última alteração :"
        '
        'DthDataUltimaAlteracao
        '
        Me.DthDataUltimaAlteracao.Break = C1.Win.C1InputPanel.BreakType.None
        Me.DthDataUltimaAlteracao.Enabled = False
        Me.DthDataUltimaAlteracao.Name = "DthDataUltimaAlteracao"
        Me.DthDataUltimaAlteracao.Width = 96
        '
        'lbl2
        '
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Text = "Elaborado por :"
        Me.lbl2.Width = 92
        '
        'comboElaboradopor
        '
        Me.comboElaboradopor.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboElaboradopor.Name = "comboElaboradopor"
        Me.comboElaboradopor.Width = 312
        '
        'lbl3
        '
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Text = "Filtrar por :"
        Me.lbl3.Width = 107
        '
        'comboFiltrarpor
        '
        Me.comboFiltrarpor.Break = C1.Win.C1InputPanel.BreakType.None
        Me.comboFiltrarpor.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboFiltrarpor.Name = "comboFiltrarpor"
        Me.comboFiltrarpor.Width = 503
        '
        'botFiltro
        '
        Me.botFiltro.Image = CType(resources.GetObject("botFiltro.Image"), System.Drawing.Image)
        Me.botFiltro.ImageSize = New System.Drawing.Size(20, 17)
        Me.botFiltro.Name = "botFiltro"
        '
        'lbl4
        '
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Text = "Identificação :"
        Me.lbl4.Width = 107
        '
        'txtIdentificacao
        '
        Me.txtIdentificacao.Name = "txtIdentificacao"
        Me.txtIdentificacao.Width = 535
        '
        'lbl5
        '
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Text = "Armazenamanto :"
        Me.lbl5.Width = 107
        '
        'txtArmazenamento
        '
        Me.txtArmazenamento.Name = "txtArmazenamento"
        Me.txtArmazenamento.Width = 535
        '
        'lbl6
        '
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Text = "Proteção :"
        Me.lbl6.Width = 107
        '
        'txtProtecao
        '
        Me.txtProtecao.Name = "txtProtecao"
        Me.txtProtecao.Width = 535
        '
        'lbl7
        '
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Text = "Recuperação :"
        Me.lbl7.Width = 107
        '
        'txtRecuperacao
        '
        Me.txtRecuperacao.Name = "txtRecuperacao"
        Me.txtRecuperacao.Width = 535
        '
        'lbl8
        '
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Text = "Retenção :"
        Me.lbl8.Width = 107
        '
        'txtRetencao
        '
        Me.txtRetencao.Name = "txtRetencao"
        Me.txtRetencao.Width = 535
        '
        'lbl9
        '
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Text = "Disposição :"
        Me.lbl9.Width = 107
        '
        'txtDisposicao
        '
        Me.txtDisposicao.Name = "txtDisposicao"
        Me.txtDisposicao.Width = 535
        '
        'lbl10
        '
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Text = "Área de Elaboração :"
        '
        'comboAreaElaboracao
        '
        Me.comboAreaElaboracao.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboAreaElaboracao.Name = "comboAreaElaboracao"
        Me.comboAreaElaboracao.Width = 535
        '
        'gridRegistros
        '
        Me.gridRegistros.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridRegistros.AllowEditing = False
        Me.gridRegistros.AllowFiltering = True
        Me.gridRegistros.ColumnInfo = resources.GetString("gridRegistros.ColumnInfo")
        Me.gridRegistros.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridRegistros.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridRegistros.Location = New System.Drawing.Point(0, 266)
        Me.gridRegistros.Name = "gridRegistros"
        Me.gridRegistros.Rows.DefaultSize = 21
        Me.gridRegistros.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridRegistros.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridRegistros.Size = New System.Drawing.Size(660, 149)
        Me.gridRegistros.StyleInfo = resources.GetString("gridRegistros.StyleInfo")
        Me.gridRegistros.TabIndex = 1
        Me.gridRegistros.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel17
        '
        Me.C1InputPanel17.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel17.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel17.Items.Add(Me.botIncluir)
        Me.C1InputPanel17.Items.Add(Me.botEditar)
        Me.C1InputPanel17.Items.Add(Me.botExcluir)
        Me.C1InputPanel17.Items.Add(Me.botUltimaData)
        Me.C1InputPanel17.Items.Add(Me.botObservacoes)
        Me.C1InputPanel17.Items.Add(Me.botVisualizar)
        Me.C1InputPanel17.Location = New System.Drawing.Point(0, 419)
        Me.C1InputPanel17.Name = "C1InputPanel17"
        Me.C1InputPanel17.Size = New System.Drawing.Size(662, 64)
        Me.C1InputPanel17.TabIndex = 9
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "Opções"
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
        Me.botExcluir.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botExcluir.Image = CType(resources.GetObject("botExcluir.Image"), System.Drawing.Image)
        Me.botExcluir.ImageSize = New System.Drawing.Size(20, 20)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Text = "Excluir"
        Me.botExcluir.Width = 70
        '
        'botUltimaData
        '
        Me.botUltimaData.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botUltimaData.Image = CType(resources.GetObject("botUltimaData.Image"), System.Drawing.Image)
        Me.botUltimaData.ImageSize = New System.Drawing.Size(20, 20)
        Me.botUltimaData.Name = "botUltimaData"
        Me.botUltimaData.Text = "Última data"
        Me.botUltimaData.Width = 95
        '
        'botObservacoes
        '
        Me.botObservacoes.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botObservacoes.Image = CType(resources.GetObject("botObservacoes.Image"), System.Drawing.Image)
        Me.botObservacoes.ImageSize = New System.Drawing.Size(20, 20)
        Me.botObservacoes.Name = "botObservacoes"
        Me.botObservacoes.Text = "Observações"
        Me.botObservacoes.Width = 100
        '
        'botVisualizar
        '
        Me.botVisualizar.Image = CType(resources.GetObject("botVisualizar.Image"), System.Drawing.Image)
        Me.botVisualizar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botVisualizar.Name = "botVisualizar"
        Me.botVisualizar.Text = "Visualizar"
        Me.botVisualizar.Width = 87
        '
        'InputButton1
        '
        Me.InputButton1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputButton1.Image = CType(resources.GetObject("InputButton1.Image"), System.Drawing.Image)
        Me.InputButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.InputButton1.Name = "InputButton1"
        Me.InputButton1.Text = "Excluir"
        Me.InputButton1.Width = 70
        '
        'InputButton2
        '
        Me.InputButton2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputButton2.Image = CType(resources.GetObject("InputButton2.Image"), System.Drawing.Image)
        Me.InputButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.InputButton2.Name = "InputButton2"
        Me.InputButton2.Text = "Excluir"
        Me.InputButton2.Width = 70
        '
        'docRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 483)
        Me.Controls.Add(Me.C1InputPanel17)
        Me.Controls.Add(Me.gridRegistros)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "docRegistros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lbl1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lbl2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboElaboradopor As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lbl3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboFiltrarpor As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents botFiltro As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lbl4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtIdentificacao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lbl5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtArmazenamento As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lbl6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtProtecao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lbl7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtRecuperacao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lbl8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtRetencao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lbl9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtDisposicao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lbl10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboAreaElaboracao As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents gridRegistros As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel17 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botIncluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botUltimaData As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botObservacoes As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton1 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton2 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botVisualizar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DthDataUltimaAlteracao As C1.Win.C1InputPanel.InputDatePicker
End Class
