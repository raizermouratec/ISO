<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projCadEquipe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projCadEquipe))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoEquipe = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblPessoal = New C1.Win.C1InputPanel.InputLabel()
        Me.radioInterno = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioExterno = New C1.Win.C1InputPanel.InputRadioButton()
        Me.grupoInterno = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblParticipanteInt = New C1.Win.C1InputPanel.InputLabel()
        Me.comboParticipanteInt = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblCargoInt = New C1.Win.C1InputPanel.InputLabel()
        Me.comboCargoInt = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblAtribuicaoInt = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAtribuicaoInt = New C1.Win.C1InputPanel.InputTextBox()
        Me.gridEquipe = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botIncluir = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.InputExterno = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblNomeExt = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNomeExt = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblCargoExt = New C1.Win.C1InputPanel.InputLabel()
        Me.txtCargoExt = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblAtribuicaoExt = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAtribuicaoExt = New C1.Win.C1InputPanel.InputTextBox()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridEquipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputExterno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.grupoEquipe)
        Me.C1InputPanel1.Items.Add(Me.lblPessoal)
        Me.C1InputPanel1.Items.Add(Me.radioInterno)
        Me.C1InputPanel1.Items.Add(Me.radioExterno)
        Me.C1InputPanel1.Items.Add(Me.grupoInterno)
        Me.C1InputPanel1.Items.Add(Me.lblParticipanteInt)
        Me.C1InputPanel1.Items.Add(Me.comboParticipanteInt)
        Me.C1InputPanel1.Items.Add(Me.lblCargoInt)
        Me.C1InputPanel1.Items.Add(Me.comboCargoInt)
        Me.C1InputPanel1.Items.Add(Me.lblAtribuicaoInt)
        Me.C1InputPanel1.Items.Add(Me.txtAtribuicaoInt)
        Me.C1InputPanel1.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(592, 160)
        Me.C1InputPanel1.TabIndex = 0
        '
        'grupoEquipe
        '
        Me.grupoEquipe.Name = "grupoEquipe"
        Me.grupoEquipe.Text = "Cadastrar Equipe"
        '
        'lblPessoal
        '
        Me.lblPessoal.Name = "lblPessoal"
        Me.lblPessoal.Text = "Pessoal:"
        Me.lblPessoal.Width = 140
        '
        'radioInterno
        '
        Me.radioInterno.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioInterno.Checked = True
        Me.radioInterno.Name = "radioInterno"
        Me.radioInterno.Text = "Interno"
        Me.radioInterno.Width = 100
        '
        'radioExterno
        '
        Me.radioExterno.Name = "radioExterno"
        Me.radioExterno.Text = "Externo"
        '
        'grupoInterno
        '
        Me.grupoInterno.Name = "grupoInterno"
        Me.grupoInterno.Text = "Pessoal Interno"
        '
        'lblParticipanteInt
        '
        Me.lblParticipanteInt.Name = "lblParticipanteInt"
        Me.lblParticipanteInt.Text = "Participante:"
        Me.lblParticipanteInt.Width = 140
        '
        'comboParticipanteInt
        '
        Me.comboParticipanteInt.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboParticipanteInt.Name = "comboParticipanteInt"
        Me.comboParticipanteInt.Width = 372
        '
        'lblCargoInt
        '
        Me.lblCargoInt.Name = "lblCargoInt"
        Me.lblCargoInt.Text = "Cargo:"
        Me.lblCargoInt.Width = 140
        '
        'comboCargoInt
        '
        Me.comboCargoInt.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboCargoInt.Name = "comboCargoInt"
        Me.comboCargoInt.Width = 372
        '
        'lblAtribuicaoInt
        '
        Me.lblAtribuicaoInt.Name = "lblAtribuicaoInt"
        Me.lblAtribuicaoInt.Text = "Atribuição:"
        Me.lblAtribuicaoInt.Width = 140
        '
        'txtAtribuicaoInt
        '
        Me.txtAtribuicaoInt.Name = "txtAtribuicaoInt"
        Me.txtAtribuicaoInt.Width = 372
        '
        'gridEquipe
        '
        Me.gridEquipe.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridEquipe.AllowEditing = False
        Me.gridEquipe.ColumnInfo = resources.GetString("gridEquipe.ColumnInfo")
        Me.gridEquipe.Location = New System.Drawing.Point(3, 170)
        Me.gridEquipe.Name = "gridEquipe"
        Me.gridEquipe.Rows.DefaultSize = 21
        Me.gridEquipe.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridEquipe.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridEquipe.Size = New System.Drawing.Size(592, 221)
        Me.gridEquipe.StyleInfo = resources.GetString("gridEquipe.StyleInfo")
        Me.gridEquipe.TabIndex = 1
        Me.gridEquipe.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.botIncluir)
        Me.C1InputPanel2.Items.Add(Me.botEditar)
        Me.C1InputPanel2.Items.Add(Me.botExcluir)
        Me.C1InputPanel2.Location = New System.Drawing.Point(3, 398)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(592, 64)
        Me.C1InputPanel2.TabIndex = 2
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
        Me.botExcluir.Image = CType(resources.GetObject("botExcluir.Image"), System.Drawing.Image)
        Me.botExcluir.ImageSize = New System.Drawing.Size(20, 20)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Text = "Excluir"
        Me.botExcluir.Width = 70
        '
        'InputExterno
        '
        Me.InputExterno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InputExterno.Items.Add(Me.InputGroupHeader1)
        Me.InputExterno.Items.Add(Me.lblNomeExt)
        Me.InputExterno.Items.Add(Me.txtNomeExt)
        Me.InputExterno.Items.Add(Me.lblCargoExt)
        Me.InputExterno.Items.Add(Me.txtCargoExt)
        Me.InputExterno.Items.Add(Me.lblAtribuicaoExt)
        Me.InputExterno.Items.Add(Me.txtAtribuicaoExt)
        Me.InputExterno.Location = New System.Drawing.Point(3, 53)
        Me.InputExterno.Name = "InputExterno"
        Me.InputExterno.Size = New System.Drawing.Size(592, 110)
        Me.InputExterno.TabIndex = 3
        Me.InputExterno.Visible = False
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Pessoal Externo"
        '
        'lblNomeExt
        '
        Me.lblNomeExt.Name = "lblNomeExt"
        Me.lblNomeExt.Text = "Nome:"
        Me.lblNomeExt.Width = 140
        '
        'txtNomeExt
        '
        Me.txtNomeExt.Name = "txtNomeExt"
        Me.txtNomeExt.Width = 372
        '
        'lblCargoExt
        '
        Me.lblCargoExt.Name = "lblCargoExt"
        Me.lblCargoExt.Text = "Cargo:"
        Me.lblCargoExt.Width = 140
        '
        'txtCargoExt
        '
        Me.txtCargoExt.Name = "txtCargoExt"
        Me.txtCargoExt.Width = 372
        '
        'lblAtribuicaoExt
        '
        Me.lblAtribuicaoExt.Name = "lblAtribuicaoExt"
        Me.lblAtribuicaoExt.Text = "Atribuição:"
        Me.lblAtribuicaoExt.Width = 140
        '
        'txtAtribuicaoExt
        '
        Me.txtAtribuicaoExt.Name = "txtAtribuicaoExt"
        Me.txtAtribuicaoExt.Width = 372
        '
        'projCadEquipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 465)
        Me.Controls.Add(Me.InputExterno)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.gridEquipe)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "projCadEquipe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Equipe"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridEquipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputExterno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoEquipe As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblPessoal As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents radioInterno As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioExterno As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents grupoInterno As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblParticipanteInt As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboParticipanteInt As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblCargoInt As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboCargoInt As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblAtribuicaoInt As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAtribuicaoInt As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents gridEquipe As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botIncluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputExterno As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblNomeExt As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNomeExt As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblCargoExt As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCargoExt As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblAtribuicaoExt As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAtribuicaoExt As C1.Win.C1InputPanel.InputTextBox
End Class
