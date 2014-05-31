<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class audRealizacaoAuditorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(audRealizacaoAuditorias))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblAreaProcesso = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAreaProcesso = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dateData = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblInicio = New C1.Win.C1InputPanel.InputLabel()
        Me.maskInicio = New C1.Win.C1InputPanel.InputMaskedTextBox()
        Me.lblTérmino = New C1.Win.C1InputPanel.InputLabel()
        Me.maskTermino = New C1.Win.C1InputPanel.InputMaskedTextBox()
        Me.lblAuditorLider = New C1.Win.C1InputPanel.InputLabel()
        Me.comboAuditorLider = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblSegundoAuditor = New C1.Win.C1InputPanel.InputLabel()
        Me.comboSegundoAuditor = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblComentarioEquipe = New C1.Win.C1InputPanel.InputLabel()
        Me.txtComentarioEquipes = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.gridItem = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.radioTodos = New C1.Win.C1InputPanel.InputCheckBox()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.botConforme = New C1.Win.C1InputPanel.InputButton()
        Me.botNConforme = New C1.Win.C1InputPanel.InputButton()
        Me.botRelatorio = New C1.Win.C1InputPanel.InputSplitButton()
        Me.txtComentarioEquipe = New C1.Win.C1Input.C1TextBox()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentarioEquipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.lblAreaProcesso)
        Me.C1InputPanel1.Items.Add(Me.txtAreaProcesso)
        Me.C1InputPanel1.Items.Add(Me.lblData)
        Me.C1InputPanel1.Items.Add(Me.dateData)
        Me.C1InputPanel1.Items.Add(Me.lblInicio)
        Me.C1InputPanel1.Items.Add(Me.maskInicio)
        Me.C1InputPanel1.Items.Add(Me.lblTérmino)
        Me.C1InputPanel1.Items.Add(Me.maskTermino)
        Me.C1InputPanel1.Items.Add(Me.lblAuditorLider)
        Me.C1InputPanel1.Items.Add(Me.comboAuditorLider)
        Me.C1InputPanel1.Items.Add(Me.lblSegundoAuditor)
        Me.C1InputPanel1.Items.Add(Me.comboSegundoAuditor)
        Me.C1InputPanel1.Items.Add(Me.lblComentarioEquipe)
        Me.C1InputPanel1.Items.Add(Me.txtComentarioEquipes)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 3)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(572, 199)
        Me.C1InputPanel1.TabIndex = 0
        '
        'lblAreaProcesso
        '
        Me.lblAreaProcesso.Name = "lblAreaProcesso"
        Me.lblAreaProcesso.Text = "Área ou Processo"
        Me.lblAreaProcesso.Width = 130
        '
        'txtAreaProcesso
        '
        Me.txtAreaProcesso.Enabled = False
        Me.txtAreaProcesso.Name = "txtAreaProcesso"
        Me.txtAreaProcesso.Width = 356
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Text = "Data"
        Me.lblData.Width = 130
        '
        'dateData
        '
        Me.dateData.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dateData.Name = "dateData"
        '
        'lblInicio
        '
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Text = "Início"
        Me.lblInicio.Width = 50
        '
        'maskInicio
        '
        Me.maskInicio.Break = C1.Win.C1InputPanel.BreakType.None
        Me.maskInicio.Mask = "00:00"
        Me.maskInicio.Name = "maskInicio"
        Me.maskInicio.Text = "  :"
        Me.maskInicio.Width = 70
        '
        'lblTérmino
        '
        Me.lblTérmino.Name = "lblTérmino"
        Me.lblTérmino.Text = "Término"
        Me.lblTérmino.Width = 50
        '
        'maskTermino
        '
        Me.maskTermino.Mask = "00:00"
        Me.maskTermino.Name = "maskTermino"
        Me.maskTermino.Text = "  :"
        Me.maskTermino.Width = 70
        '
        'lblAuditorLider
        '
        Me.lblAuditorLider.Name = "lblAuditorLider"
        Me.lblAuditorLider.Text = "Auditor Líder"
        Me.lblAuditorLider.Width = 130
        '
        'comboAuditorLider
        '
        Me.comboAuditorLider.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboAuditorLider.Name = "comboAuditorLider"
        Me.comboAuditorLider.Width = 356
        '
        'lblSegundoAuditor
        '
        Me.lblSegundoAuditor.Name = "lblSegundoAuditor"
        Me.lblSegundoAuditor.Text = "Segundo Auditor"
        Me.lblSegundoAuditor.Width = 130
        '
        'comboSegundoAuditor
        '
        Me.comboSegundoAuditor.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboSegundoAuditor.Name = "comboSegundoAuditor"
        Me.comboSegundoAuditor.Width = 356
        '
        'lblComentarioEquipe
        '
        Me.lblComentarioEquipe.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblComentarioEquipe.Name = "lblComentarioEquipe"
        Me.lblComentarioEquipe.Text = "Comentários da equipe auditada"
        Me.lblComentarioEquipe.Width = 185
        '
        'txtComentarioEquipes
        '
        Me.txtComentarioEquipes.Height = 78
        Me.txtComentarioEquipes.Name = "txtComentarioEquipes"
        Me.txtComentarioEquipes.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtComentarioEquipes.Width = 461
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 203)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(572, 237)
        Me.C1InputPanel3.TabIndex = 27
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Itens Alditados"
        '
        'gridItem
        '
        Me.gridItem.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridItem.AllowEditing = False
        Me.gridItem.AllowFiltering = True
        Me.gridItem.ColumnInfo = resources.GetString("gridItem.ColumnInfo")
        Me.gridItem.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridItem.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridItem.Location = New System.Drawing.Point(0, 227)
        Me.gridItem.Name = "gridItem"
        Me.gridItem.Rows.DefaultSize = 21
        Me.gridItem.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridItem.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridItem.Size = New System.Drawing.Size(572, 213)
        Me.gridItem.StyleInfo = resources.GetString("gridItem.StyleInfo")
        Me.gridItem.TabIndex = 28
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel4.Items.Add(Me.radioTodos)
        Me.C1InputPanel4.Items.Add(Me.botSalvar)
        Me.C1InputPanel4.Items.Add(Me.botConforme)
        Me.C1InputPanel4.Items.Add(Me.botNConforme)
        Me.C1InputPanel4.Items.Add(Me.botRelatorio)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 441)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(572, 59)
        Me.C1InputPanel4.TabIndex = 29
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Opções"
        '
        'radioTodos
        '
        Me.radioTodos.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioTodos.CheckAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.radioTodos.Name = "radioTodos"
        Me.radioTodos.Text = "Selecionar todos"
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
        'botConforme
        '
        Me.botConforme.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botConforme.CheckOnClick = True
        Me.botConforme.Image = CType(resources.GetObject("botConforme.Image"), System.Drawing.Image)
        Me.botConforme.ImageSize = New System.Drawing.Size(20, 20)
        Me.botConforme.Name = "botConforme"
        Me.botConforme.Text = "Conformidade"
        '
        'botNConforme
        '
        Me.botNConforme.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botNConforme.Image = CType(resources.GetObject("botNConforme.Image"), System.Drawing.Image)
        Me.botNConforme.ImageSize = New System.Drawing.Size(20, 20)
        Me.botNConforme.Name = "botNConforme"
        Me.botNConforme.Text = "Não Conformidade"
        '
        'botRelatorio
        '
        Me.botRelatorio.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botRelatorio.Image = CType(resources.GetObject("botRelatorio.Image"), System.Drawing.Image)
        Me.botRelatorio.ImageSize = New System.Drawing.Size(20, 20)
        Me.botRelatorio.Name = "botRelatorio"
        Me.botRelatorio.Text = "Relatório"
        '
        'txtComentarioEquipe
        '
        Me.txtComentarioEquipe.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtComentarioEquipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComentarioEquipe.Location = New System.Drawing.Point(9, 114)
        Me.txtComentarioEquipe.Multiline = True
        Me.txtComentarioEquipe.Name = "txtComentarioEquipe"
        Me.txtComentarioEquipe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentarioEquipe.Size = New System.Drawing.Size(553, 81)
        Me.txtComentarioEquipe.TabIndex = 30
        Me.txtComentarioEquipe.Tag = Nothing
        Me.txtComentarioEquipe.TextDetached = True
        '
        'audRealizacaoAuditorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 500)
        Me.Controls.Add(Me.txtComentarioEquipe)
        Me.Controls.Add(Me.C1InputPanel4)
        Me.Controls.Add(Me.gridItem)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "audRealizacaoAuditorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realizar Auditoria"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentarioEquipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents lblAreaProcesso As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAreaProcesso As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateData As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblInicio As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTérmino As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAuditorLider As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboAuditorLider As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblSegundoAuditor As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboSegundoAuditor As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblComentarioEquipe As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtComentarioEquipes As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridItem As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents radioTodos As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents botConforme As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botNConforme As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botRelatorio As C1.Win.C1InputPanel.InputSplitButton
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtComentarioEquipe As C1.Win.C1Input.C1TextBox
    Friend WithEvents maskInicio As C1.Win.C1InputPanel.InputMaskedTextBox
    Friend WithEvents maskTermino As C1.Win.C1InputPanel.InputMaskedTextBox
End Class
