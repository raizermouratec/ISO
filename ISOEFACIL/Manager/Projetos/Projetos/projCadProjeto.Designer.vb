<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projCadProjeto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projCadProjeto))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoCadastrarProjetos = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblTituloProjeto = New C1.Win.C1InputPanel.InputLabel()
        Me.txtTituloProjeto = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblRevisao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRevisao = New C1.Win.C1InputPanel.InputMaskedTextBox()
        Me.lblIdentiticacao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtIdentificacao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblResponsavel = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResp = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblTipo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtTipo = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblInicioEm = New C1.Win.C1InputPanel.InputLabel()
        Me.dateInicioEm = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblPrevisaoTermino = New C1.Win.C1InputPanel.InputLabel()
        Me.datePrevisaoTermino = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblDuracao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtDuracao = New C1.Win.C1InputPanel.InputTextBox()
        Me.grupAprovacao = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblAprovador = New C1.Win.C1InputPanel.InputLabel()
        Me.comboAprovador = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dateData = New C1.Win.C1InputPanel.InputDatePicker()
        Me.botEquipe = New C1.Win.C1InputPanel.InputButton()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.grupoCadastrarProjetos)
        Me.C1InputPanel1.Items.Add(Me.lblTituloProjeto)
        Me.C1InputPanel1.Items.Add(Me.txtTituloProjeto)
        Me.C1InputPanel1.Items.Add(Me.lblRevisao)
        Me.C1InputPanel1.Items.Add(Me.txtRevisao)
        Me.C1InputPanel1.Items.Add(Me.lblIdentiticacao)
        Me.C1InputPanel1.Items.Add(Me.txtIdentificacao)
        Me.C1InputPanel1.Items.Add(Me.lblResponsavel)
        Me.C1InputPanel1.Items.Add(Me.comboResp)
        Me.C1InputPanel1.Items.Add(Me.lblTipo)
        Me.C1InputPanel1.Items.Add(Me.txtTipo)
        Me.C1InputPanel1.Items.Add(Me.lblInicioEm)
        Me.C1InputPanel1.Items.Add(Me.dateInicioEm)
        Me.C1InputPanel1.Items.Add(Me.lblPrevisaoTermino)
        Me.C1InputPanel1.Items.Add(Me.datePrevisaoTermino)
        Me.C1InputPanel1.Items.Add(Me.lblDuracao)
        Me.C1InputPanel1.Items.Add(Me.txtDuracao)
        Me.C1InputPanel1.Items.Add(Me.grupAprovacao)
        Me.C1InputPanel1.Items.Add(Me.lblAprovador)
        Me.C1InputPanel1.Items.Add(Me.comboAprovador)
        Me.C1InputPanel1.Items.Add(Me.lblData)
        Me.C1InputPanel1.Items.Add(Me.dateData)
        Me.C1InputPanel1.Location = New System.Drawing.Point(1, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(597, 242)
        Me.C1InputPanel1.TabIndex = 0
        '
        'grupoCadastrarProjetos
        '
        Me.grupoCadastrarProjetos.Name = "grupoCadastrarProjetos"
        Me.grupoCadastrarProjetos.Text = "Cadastrar Projeto"
        '
        'lblTituloProjeto
        '
        Me.lblTituloProjeto.Name = "lblTituloProjeto"
        Me.lblTituloProjeto.Text = "Título:"
        Me.lblTituloProjeto.Width = 140
        '
        'txtTituloProjeto
        '
        Me.txtTituloProjeto.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtTituloProjeto.Name = "txtTituloProjeto"
        Me.txtTituloProjeto.Width = 333
        '
        'lblRevisao
        '
        Me.lblRevisao.Name = "lblRevisao"
        Me.lblRevisao.Text = "Revisão:"
        Me.lblRevisao.Width = 59
        '
        'txtRevisao
        '
        Me.txtRevisao.Enabled = False
        Me.txtRevisao.Mask = "00"
        Me.txtRevisao.Name = "txtRevisao"
        Me.txtRevisao.Width = 38
        '
        'lblIdentiticacao
        '
        Me.lblIdentiticacao.Name = "lblIdentiticacao"
        Me.lblIdentiticacao.Text = "Identificação:"
        Me.lblIdentiticacao.Width = 140
        '
        'txtIdentificacao
        '
        Me.txtIdentificacao.Name = "txtIdentificacao"
        '
        'lblResponsavel
        '
        Me.lblResponsavel.Name = "lblResponsavel"
        Me.lblResponsavel.Text = "Responsável:"
        Me.lblResponsavel.Width = 140
        '
        'comboResp
        '
        Me.comboResp.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResp.Name = "comboResp"
        Me.comboResp.Width = 300
        '
        'lblTipo
        '
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Text = "Tipo:"
        Me.lblTipo.Width = 140
        '
        'txtTipo
        '
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Width = 438
        '
        'lblInicioEm
        '
        Me.lblInicioEm.Name = "lblInicioEm"
        Me.lblInicioEm.Text = "Início em"
        Me.lblInicioEm.Width = 140
        '
        'dateInicioEm
        '
        Me.dateInicioEm.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dateInicioEm.Name = "dateInicioEm"
        '
        'lblPrevisaoTermino
        '
        Me.lblPrevisaoTermino.Name = "lblPrevisaoTermino"
        Me.lblPrevisaoTermino.Text = "Previsão de término"
        Me.lblPrevisaoTermino.Width = 124
        '
        'datePrevisaoTermino
        '
        Me.datePrevisaoTermino.Name = "datePrevisaoTermino"
        '
        'lblDuracao
        '
        Me.lblDuracao.Name = "lblDuracao"
        Me.lblDuracao.Text = "Duração:"
        Me.lblDuracao.Width = 140
        '
        'txtDuracao
        '
        Me.txtDuracao.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtDuracao.Name = "txtDuracao"
        '
        'grupAprovacao
        '
        Me.grupAprovacao.Name = "grupAprovacao"
        Me.grupAprovacao.Text = "Aprovação"
        '
        'lblAprovador
        '
        Me.lblAprovador.Name = "lblAprovador"
        Me.lblAprovador.Text = "Aprovador:"
        Me.lblAprovador.Width = 140
        '
        'comboAprovador
        '
        Me.comboAprovador.Break = C1.Win.C1InputPanel.BreakType.None
        Me.comboAprovador.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboAprovador.Name = "comboAprovador"
        Me.comboAprovador.Width = 300
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Text = "Data:"
        Me.lblData.Width = 31
        '
        'dateData
        '
        Me.dateData.Name = "dateData"
        '
        'botEquipe
        '
        Me.botEquipe.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botEquipe.Image = CType(resources.GetObject("botEquipe.Image"), System.Drawing.Image)
        Me.botEquipe.ImageSize = New System.Drawing.Size(20, 20)
        Me.botEquipe.Name = "botEquipe"
        Me.botEquipe.Text = "Equipe"
        Me.botEquipe.Width = 70
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
        'grupoOpcoes
        '
        Me.grupoOpcoes.Name = "grupoOpcoes"
        Me.grupoOpcoes.Text = "Opções"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Items.Add(Me.botEquipe)
        Me.C1InputPanel2.Location = New System.Drawing.Point(1, 241)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(597, 64)
        Me.C1InputPanel2.TabIndex = 1
        '
        'projCadProjeto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 306)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "projCadProjeto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Projeto"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoCadastrarProjetos As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblTituloProjeto As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtTituloProjeto As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblRevisao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblIdentiticacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtIdentificacao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblResponsavel As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResp As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblTipo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtTipo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblInicioEm As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateInicioEm As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblPrevisaoTermino As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents datePrevisaoTermino As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblDuracao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtDuracao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents grupAprovacao As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblAprovador As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboAprovador As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateData As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents botEquipe As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents txtRevisao As C1.Win.C1InputPanel.InputMaskedTextBox
End Class
