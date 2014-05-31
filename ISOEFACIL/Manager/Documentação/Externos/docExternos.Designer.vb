<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class docExternos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(docExternos))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.dthDataUltimaAlteracao = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.comboElaboradopor = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtDocumento = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtVersao = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtFonteorigem = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtLocalguarda = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtFrequenciaconsulta = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.dthDataUltimaConsulta = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResponsavel = New C1.Win.C1InputPanel.InputComboBox()
        Me.gridDocExterno = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel17 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botIncluir = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.botUltimaData = New C1.Win.C1InputPanel.InputButton()
        Me.botAnexo = New C1.Win.C1InputPanel.InputButton()
        Me.botVisualizar = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDocExterno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.dthDataUltimaAlteracao)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.comboElaboradopor)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.txtDocumento)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.txtVersao)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.txtFonteorigem)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.txtLocalguarda)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.txtFrequenciaconsulta)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.dthDataUltimaConsulta)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.comboResponsavel)
        Me.C1InputPanel1.Location = New System.Drawing.Point(1, 4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(649, 184)
        Me.C1InputPanel1.TabIndex = 0
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Documentos de Origem Externa"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Data da última alteração :"
        '
        'dthDataUltimaAlteracao
        '
        Me.dthDataUltimaAlteracao.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dthDataUltimaAlteracao.Enabled = False
        Me.dthDataUltimaAlteracao.Name = "dthDataUltimaAlteracao"
        Me.dthDataUltimaAlteracao.Width = 101
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Elaborador por :"
        '
        'comboElaboradopor
        '
        Me.comboElaboradopor.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboElaboradopor.Name = "comboElaboradopor"
        Me.comboElaboradopor.Width = 301
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Documento :"
        Me.InputLabel3.Width = 107
        '
        'txtDocumento
        '
        Me.txtDocumento.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Width = 349
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Versão :"
        Me.InputLabel4.Width = 64
        '
        'txtVersao
        '
        Me.txtVersao.Name = "txtVersao"
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Fonte de origem :"
        Me.InputLabel5.Width = 107
        '
        'txtFonteorigem
        '
        Me.txtFonteorigem.Name = "txtFonteorigem"
        Me.txtFonteorigem.Width = 521
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Local de guarda :"
        Me.InputLabel6.Width = 107
        '
        'txtLocalguarda
        '
        Me.txtLocalguarda.Name = "txtLocalguarda"
        Me.txtLocalguarda.Width = 521
        '
        'InputLabel7
        '
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Frequência de consulta à fonte :"
        '
        'txtFrequenciaconsulta
        '
        Me.txtFrequenciaconsulta.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtFrequenciaconsulta.Name = "txtFrequenciaconsulta"
        Me.txtFrequenciaconsulta.Width = 223
        '
        'InputLabel8
        '
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Última consulta à fonte :"
        '
        'dthDataUltimaConsulta
        '
        Me.dthDataUltimaConsulta.Name = "dthDataUltimaConsulta"
        Me.dthDataUltimaConsulta.Width = -1
        '
        'InputLabel9
        '
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Responsável :"
        Me.InputLabel9.Width = 107
        '
        'comboResponsavel
        '
        Me.comboResponsavel.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResponsavel.Name = "comboResponsavel"
        Me.comboResponsavel.Width = 521
        '
        'gridDocExterno
        '
        Me.gridDocExterno.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridDocExterno.AllowEditing = False
        Me.gridDocExterno.AllowFiltering = True
        Me.gridDocExterno.ColumnInfo = resources.GetString("gridDocExterno.ColumnInfo")
        Me.gridDocExterno.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridDocExterno.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridDocExterno.Location = New System.Drawing.Point(1, 187)
        Me.gridDocExterno.Name = "gridDocExterno"
        Me.gridDocExterno.Rows.DefaultSize = 21
        Me.gridDocExterno.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridDocExterno.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridDocExterno.Size = New System.Drawing.Size(649, 232)
        Me.gridDocExterno.StyleInfo = resources.GetString("gridDocExterno.StyleInfo")
        Me.gridDocExterno.TabIndex = 1
        Me.gridDocExterno.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel17
        '
        Me.C1InputPanel17.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel17.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel17.Items.Add(Me.botIncluir)
        Me.C1InputPanel17.Items.Add(Me.botEditar)
        Me.C1InputPanel17.Items.Add(Me.botExcluir)
        Me.C1InputPanel17.Items.Add(Me.botUltimaData)
        Me.C1InputPanel17.Items.Add(Me.botAnexo)
        Me.C1InputPanel17.Items.Add(Me.botVisualizar)
        Me.C1InputPanel17.Location = New System.Drawing.Point(1, 420)
        Me.C1InputPanel17.Name = "C1InputPanel17"
        Me.C1InputPanel17.Size = New System.Drawing.Size(649, 64)
        Me.C1InputPanel17.TabIndex = 10
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
        Me.botIncluir.Text = "Salvar"
        Me.botIncluir.Width = 71
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
        'botAnexo
        '
        Me.botAnexo.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botAnexo.Image = CType(resources.GetObject("botAnexo.Image"), System.Drawing.Image)
        Me.botAnexo.ImageSize = New System.Drawing.Size(20, 20)
        Me.botAnexo.Name = "botAnexo"
        Me.botAnexo.Text = "Anexo"
        Me.botAnexo.Width = 70
        '
        'botVisualizar
        '
        Me.botVisualizar.Image = CType(resources.GetObject("botVisualizar.Image"), System.Drawing.Image)
        Me.botVisualizar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botVisualizar.Name = "botVisualizar"
        Me.botVisualizar.Text = "Visualizar"
        Me.botVisualizar.Width = 87
        '
        'docExternos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 483)
        Me.Controls.Add(Me.C1InputPanel17)
        Me.Controls.Add(Me.gridDocExterno)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "docExternos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDocExterno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboElaboradopor As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtDocumento As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtVersao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtFonteorigem As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtLocalguarda As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtFrequenciaconsulta As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResponsavel As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents gridDocExterno As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel17 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botIncluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botUltimaData As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botAnexo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botVisualizar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents dthDataUltimaAlteracao As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents dthDataUltimaConsulta As C1.Win.C1InputPanel.InputDatePicker
End Class
