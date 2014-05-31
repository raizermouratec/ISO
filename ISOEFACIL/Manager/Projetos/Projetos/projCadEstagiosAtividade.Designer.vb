<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projCadEstagiosAtividade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projCadEstagiosAtividade))
        Me.txtObservacoes = New C1.Win.C1Input.C1TextBox()
        Me.InputAtiv = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoEstagio = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblAtividade = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAtividade = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblNumSequencial = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNumSequencial = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblEstagioResponsavel = New C1.Win.C1InputPanel.InputLabel()
        Me.comboEstagioResponsavel = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblInicio = New C1.Win.C1InputPanel.InputLabel()
        Me.dateInicio = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblTermino = New C1.Win.C1InputPanel.InputLabel()
        Me.dateTermino = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblObservacoes = New C1.Win.C1InputPanel.InputLabel()
        Me.txtObservacoesx = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputGroupHeader17 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarEstAtiv = New C1.Win.C1InputPanel.InputButton()
        CType(Me.txtObservacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputAtiv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtObservacoes
        '
        Me.txtObservacoes.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtObservacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacoes.Location = New System.Drawing.Point(156, 132)
        Me.txtObservacoes.Multiline = True
        Me.txtObservacoes.Name = "txtObservacoes"
        Me.txtObservacoes.Size = New System.Drawing.Size(408, 48)
        Me.txtObservacoes.TabIndex = 10
        Me.txtObservacoes.Tag = Nothing
        Me.txtObservacoes.TextDetached = True
        '
        'InputAtiv
        '
        Me.InputAtiv.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InputAtiv.Items.Add(Me.grupoEstagio)
        Me.InputAtiv.Items.Add(Me.lblAtividade)
        Me.InputAtiv.Items.Add(Me.txtAtividade)
        Me.InputAtiv.Items.Add(Me.lblNumSequencial)
        Me.InputAtiv.Items.Add(Me.txtNumSequencial)
        Me.InputAtiv.Items.Add(Me.lblEstagioResponsavel)
        Me.InputAtiv.Items.Add(Me.comboEstagioResponsavel)
        Me.InputAtiv.Items.Add(Me.lblInicio)
        Me.InputAtiv.Items.Add(Me.dateInicio)
        Me.InputAtiv.Items.Add(Me.lblTermino)
        Me.InputAtiv.Items.Add(Me.dateTermino)
        Me.InputAtiv.Items.Add(Me.lblObservacoes)
        Me.InputAtiv.Items.Add(Me.txtObservacoesx)
        Me.InputAtiv.Items.Add(Me.InputGroupHeader17)
        Me.InputAtiv.Items.Add(Me.botSalvarEstAtiv)
        Me.InputAtiv.Location = New System.Drawing.Point(2, 3)
        Me.InputAtiv.Name = "InputAtiv"
        Me.InputAtiv.Size = New System.Drawing.Size(569, 238)
        Me.InputAtiv.TabIndex = 9
        '
        'grupoEstagio
        '
        Me.grupoEstagio.Name = "grupoEstagio"
        Me.grupoEstagio.Text = "Atividades"
        '
        'lblAtividade
        '
        Me.lblAtividade.Name = "lblAtividade"
        Me.lblAtividade.Text = "Atividade:"
        Me.lblAtividade.Width = 140
        '
        'txtAtividade
        '
        Me.txtAtividade.Name = "txtAtividade"
        Me.txtAtividade.Width = 408
        '
        'lblNumSequencial
        '
        Me.lblNumSequencial.Name = "lblNumSequencial"
        Me.lblNumSequencial.Text = "Número Seqüencial:"
        Me.lblNumSequencial.Width = 140
        '
        'txtNumSequencial
        '
        Me.txtNumSequencial.Enabled = False
        Me.txtNumSequencial.Name = "txtNumSequencial"
        Me.txtNumSequencial.Width = 33
        '
        'lblEstagioResponsavel
        '
        Me.lblEstagioResponsavel.Name = "lblEstagioResponsavel"
        Me.lblEstagioResponsavel.Text = "Responsável:"
        Me.lblEstagioResponsavel.Width = 140
        '
        'comboEstagioResponsavel
        '
        Me.comboEstagioResponsavel.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboEstagioResponsavel.Name = "comboEstagioResponsavel"
        Me.comboEstagioResponsavel.Width = 408
        '
        'lblInicio
        '
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Text = "Início:"
        Me.lblInicio.Width = 140
        '
        'dateInicio
        '
        Me.dateInicio.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dateInicio.Name = "dateInicio"
        '
        'lblTermino
        '
        Me.lblTermino.Name = "lblTermino"
        Me.lblTermino.Text = "Término:"
        Me.lblTermino.Width = 140
        '
        'dateTermino
        '
        Me.dateTermino.Name = "dateTermino"
        '
        'lblObservacoes
        '
        Me.lblObservacoes.Name = "lblObservacoes"
        Me.lblObservacoes.Text = "Observações:"
        Me.lblObservacoes.Width = 140
        '
        'txtObservacoesx
        '
        Me.txtObservacoesx.Height = 48
        Me.txtObservacoesx.Multiline = True
        Me.txtObservacoesx.Name = "txtObservacoesx"
        Me.txtObservacoesx.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtObservacoesx.Width = 408
        '
        'InputGroupHeader17
        '
        Me.InputGroupHeader17.Name = "InputGroupHeader17"
        Me.InputGroupHeader17.Text = "Opções"
        '
        'botSalvarEstAtiv
        '
        Me.botSalvarEstAtiv.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botSalvarEstAtiv.Image = CType(resources.GetObject("botSalvarEstAtiv.Image"), System.Drawing.Image)
        Me.botSalvarEstAtiv.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarEstAtiv.Name = "botSalvarEstAtiv"
        Me.botSalvarEstAtiv.Text = "Salvar"
        Me.botSalvarEstAtiv.Width = 70
        '
        'projCadEstagiosAtividade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 242)
        Me.Controls.Add(Me.txtObservacoes)
        Me.Controls.Add(Me.InputAtiv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "projCadEstagiosAtividade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.txtObservacoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputAtiv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtObservacoes As C1.Win.C1Input.C1TextBox
    Friend WithEvents InputAtiv As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoEstagio As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblAtividade As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAtividade As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblNumSequencial As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNumSequencial As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblEstagioResponsavel As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboEstagioResponsavel As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblInicio As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateInicio As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblTermino As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateTermino As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblObservacoes As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtObservacoesx As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputGroupHeader17 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvarEstAtiv As C1.Win.C1InputPanel.InputButton
End Class
