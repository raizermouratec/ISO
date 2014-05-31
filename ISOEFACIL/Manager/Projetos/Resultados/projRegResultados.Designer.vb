<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projRegResultados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projRegResultados))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblResultado = New C1.Win.C1InputPanel.InputLabel()
        Me.txtResultadox = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblDescricao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtTipox = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblResp = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResp = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dateData = New C1.Win.C1InputPanel.InputDatePicker()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.botAnexo = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblProjeto = New C1.Win.C1InputPanel.InputLabel()
        Me.comboProjeto = New C1.Win.C1InputPanel.InputComboBox()
        Me.botOK = New C1.Win.C1InputPanel.InputButton()
        Me.InputEntradas = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupResultados = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputSaidas = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupSaidas = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.gridSaidas = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.gridObjetivosEstruturados = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtResultadosEsperados = New C1.Win.C1Input.C1TextBox()
        Me.txtResultado = New C1.Win.C1Input.C1TextBox()
        Me.txtDescricao = New C1.Win.C1Input.C1TextBox()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputSaidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSaidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridObjetivosEstruturados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResultadosEsperados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescricao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.lblResultado)
        Me.C1InputPanel1.Items.Add(Me.txtResultadox)
        Me.C1InputPanel1.Items.Add(Me.lblDescricao)
        Me.C1InputPanel1.Items.Add(Me.txtTipox)
        Me.C1InputPanel1.Items.Add(Me.lblResp)
        Me.C1InputPanel1.Items.Add(Me.comboResp)
        Me.C1InputPanel1.Items.Add(Me.lblData)
        Me.C1InputPanel1.Items.Add(Me.dateData)
        Me.C1InputPanel1.Location = New System.Drawing.Point(3, 354)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(670, 109)
        Me.C1InputPanel1.TabIndex = 0
        '
        'lblResultado
        '
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Text = "Resultado:"
        Me.lblResultado.Width = 80
        '
        'txtResultadox
        '
        Me.txtResultadox.Height = 38
        Me.txtResultadox.Multiline = True
        Me.txtResultadox.Name = "txtResultadox"
        Me.txtResultadox.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtResultadox.Width = 392
        '
        'lblDescricao
        '
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Text = "Descrição:"
        Me.lblDescricao.Width = 80
        '
        'txtTipox
        '
        Me.txtTipox.Height = 38
        Me.txtTipox.Multiline = True
        Me.txtTipox.Name = "txtTipox"
        Me.txtTipox.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtTipox.Width = 392
        '
        'lblResp
        '
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Text = "Responsável:"
        Me.lblResp.Width = 80
        '
        'comboResp
        '
        Me.comboResp.Break = C1.Win.C1InputPanel.BreakType.None
        Me.comboResp.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResp.Name = "comboResp"
        Me.comboResp.Width = 257
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Text = "Data:"
        '
        'dateData
        '
        Me.dateData.Name = "dateData"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Items.Add(Me.botAnexo)
        Me.C1InputPanel2.Location = New System.Drawing.Point(3, 465)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(670, 64)
        Me.C1InputPanel2.TabIndex = 3
        '
        'grupoOpcoes
        '
        Me.grupoOpcoes.Name = "grupoOpcoes"
        Me.grupoOpcoes.Text = "Opções"
        '
        'botSalvar
        '
        Me.botSalvar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botSalvar.Image = CType(resources.GetObject("botSalvar.Image"), System.Drawing.Image)
        Me.botSalvar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvar.Name = "botSalvar"
        Me.botSalvar.Text = "Salvar"
        Me.botSalvar.Width = 70
        '
        'botAnexo
        '
        Me.botAnexo.Image = CType(resources.GetObject("botAnexo.Image"), System.Drawing.Image)
        Me.botAnexo.ImageSize = New System.Drawing.Size(20, 20)
        Me.botAnexo.Name = "botAnexo"
        Me.botAnexo.Text = "Anexo"
        Me.botAnexo.Width = 70
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel3.Items.Add(Me.lblProjeto)
        Me.C1InputPanel3.Items.Add(Me.comboProjeto)
        Me.C1InputPanel3.Items.Add(Me.botOK)
        Me.C1InputPanel3.Location = New System.Drawing.Point(3, 0)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(670, 60)
        Me.C1InputPanel3.TabIndex = 0
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Registrar de Resultados"
        '
        'lblProjeto
        '
        Me.lblProjeto.Name = "lblProjeto"
        Me.lblProjeto.Text = "Projeto:"
        Me.lblProjeto.Width = 80
        '
        'comboProjeto
        '
        Me.comboProjeto.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.comboProjeto.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboProjeto.Name = "comboProjeto"
        Me.comboProjeto.Width = 257
        '
        'botOK
        '
        Me.botOK.Height = 25
        Me.botOK.Image = CType(resources.GetObject("botOK.Image"), System.Drawing.Image)
        Me.botOK.ImageSize = New System.Drawing.Size(20, 20)
        Me.botOK.Name = "botOK"
        Me.botOK.Width = 28
        '
        'InputEntradas
        '
        Me.InputEntradas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InputEntradas.Items.Add(Me.grupResultados)
        Me.InputEntradas.Location = New System.Drawing.Point(3, 57)
        Me.InputEntradas.Name = "InputEntradas"
        Me.InputEntradas.Size = New System.Drawing.Size(670, 150)
        Me.InputEntradas.TabIndex = 4
        '
        'grupResultados
        '
        Me.grupResultados.Name = "grupResultados"
        Me.grupResultados.Text = "Resultados esperados ( Plano de Projeto )"
        '
        'InputSaidas
        '
        Me.InputSaidas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InputSaidas.Items.Add(Me.grupSaidas)
        Me.InputSaidas.Location = New System.Drawing.Point(3, 205)
        Me.InputSaidas.Name = "InputSaidas"
        Me.InputSaidas.Size = New System.Drawing.Size(670, 150)
        Me.InputSaidas.TabIndex = 4
        '
        'grupSaidas
        '
        Me.grupSaidas.Name = "grupSaidas"
        Me.grupSaidas.Text = "Saídas ( Plano de Projeto )"
        '
        'gridSaidas
        '
        Me.gridSaidas.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridSaidas.AllowEditing = False
        Me.gridSaidas.ColumnInfo = "3,1,0,0,0,105,Columns:0{Width:0;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:589;Caption:""Saídas"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:33;Style" & _
    ":""DataType:System.Boolean;TextAlign:LeftCenter;ImageAlign:CenterCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.gridSaidas.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridSaidas.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridSaidas.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.gridSaidas.Location = New System.Drawing.Point(12, 230)
        Me.gridSaidas.Name = "gridSaidas"
        Me.gridSaidas.Rows.DefaultSize = 21
        Me.gridSaidas.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridSaidas.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridSaidas.Size = New System.Drawing.Size(654, 122)
        Me.gridSaidas.StyleInfo = resources.GetString("gridSaidas.StyleInfo")
        Me.gridSaidas.TabIndex = 5
        Me.gridSaidas.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'gridObjetivosEstruturados
        '
        Me.gridObjetivosEstruturados.ColumnInfo = resources.GetString("gridObjetivosEstruturados.ColumnInfo")
        Me.gridObjetivosEstruturados.Location = New System.Drawing.Point(12, 82)
        Me.gridObjetivosEstruturados.Name = "gridObjetivosEstruturados"
        Me.gridObjetivosEstruturados.Rows.DefaultSize = 19
        Me.gridObjetivosEstruturados.Size = New System.Drawing.Size(654, 122)
        Me.gridObjetivosEstruturados.TabIndex = 6
        Me.gridObjetivosEstruturados.Visible = False
        '
        'txtResultadosEsperados
        '
        Me.txtResultadosEsperados.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtResultadosEsperados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultadosEsperados.Location = New System.Drawing.Point(13, 83)
        Me.txtResultadosEsperados.Multiline = True
        Me.txtResultadosEsperados.Name = "txtResultadosEsperados"
        Me.txtResultadosEsperados.Size = New System.Drawing.Size(653, 121)
        Me.txtResultadosEsperados.TabIndex = 7
        Me.txtResultadosEsperados.Tag = Nothing
        Me.txtResultadosEsperados.TextDetached = True
        '
        'txtResultado
        '
        Me.txtResultado.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultado.Location = New System.Drawing.Point(98, 355)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(392, 38)
        Me.txtResultado.TabIndex = 8
        Me.txtResultado.Tag = Nothing
        Me.txtResultado.TextDetached = True
        '
        'txtDescricao
        '
        Me.txtDescricao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescricao.Location = New System.Drawing.Point(98, 395)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(392, 38)
        Me.txtDescricao.TabIndex = 8
        Me.txtDescricao.Tag = Nothing
        Me.txtDescricao.TextDetached = True
        '
        'projRegResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 529)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtResultadosEsperados)
        Me.Controls.Add(Me.gridObjetivosEstruturados)
        Me.Controls.Add(Me.gridSaidas)
        Me.Controls.Add(Me.InputSaidas)
        Me.Controls.Add(Me.InputEntradas)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "projRegResultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Resultados"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputSaidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSaidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridObjetivosEstruturados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResultadosEsperados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescricao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents lblResultado As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDescricao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblResp As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResp As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtResultadox As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtTipox As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents dateData As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botAnexo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblProjeto As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboProjeto As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputEntradas As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupResultados As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputSaidas As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupSaidas As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridSaidas As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents gridObjetivosEstruturados As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents botOK As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtResultadosEsperados As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtResultado As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtDescricao As C1.Win.C1Input.C1TextBox
End Class
