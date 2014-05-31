<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projCadControleValidacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projCadControleValidacao))
        Me.txtProgValidacao = New C1.Win.C1Input.C1TextBox()
        Me.txtMetodoValidacao = New C1.Win.C1Input.C1TextBox()
        Me.InputValid = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoValidacao = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblMetodoValidacao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtMetodoValidacaox = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblRespValidacao = New C1.Win.C1InputPanel.InputLabel()
        Me.comboRespValidacao = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblProgValidacao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtProgValidacaox = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputGroupHeader12 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarValid = New C1.Win.C1InputPanel.InputButton()
        CType(Me.txtProgValidacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMetodoValidacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputValid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProgValidacao
        '
        Me.txtProgValidacao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtProgValidacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProgValidacao.Location = New System.Drawing.Point(155, 104)
        Me.txtProgValidacao.Multiline = True
        Me.txtProgValidacao.Name = "txtProgValidacao"
        Me.txtProgValidacao.Size = New System.Drawing.Size(378, 50)
        Me.txtProgValidacao.TabIndex = 5
        Me.txtProgValidacao.Tag = Nothing
        Me.txtProgValidacao.TextDetached = True
        '
        'txtMetodoValidacao
        '
        Me.txtMetodoValidacao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtMetodoValidacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMetodoValidacao.Location = New System.Drawing.Point(155, 27)
        Me.txtMetodoValidacao.Multiline = True
        Me.txtMetodoValidacao.Name = "txtMetodoValidacao"
        Me.txtMetodoValidacao.Size = New System.Drawing.Size(378, 50)
        Me.txtMetodoValidacao.TabIndex = 6
        Me.txtMetodoValidacao.Tag = Nothing
        Me.txtMetodoValidacao.TextDetached = True
        '
        'InputValid
        '
        Me.InputValid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InputValid.Items.Add(Me.grupoValidacao)
        Me.InputValid.Items.Add(Me.lblMetodoValidacao)
        Me.InputValid.Items.Add(Me.txtMetodoValidacaox)
        Me.InputValid.Items.Add(Me.lblRespValidacao)
        Me.InputValid.Items.Add(Me.comboRespValidacao)
        Me.InputValid.Items.Add(Me.lblProgValidacao)
        Me.InputValid.Items.Add(Me.txtProgValidacaox)
        Me.InputValid.Items.Add(Me.InputGroupHeader12)
        Me.InputValid.Items.Add(Me.botSalvarValid)
        Me.InputValid.Location = New System.Drawing.Point(1, 1)
        Me.InputValid.Name = "InputValid"
        Me.InputValid.Size = New System.Drawing.Size(546, 214)
        Me.InputValid.TabIndex = 4
        '
        'grupoValidacao
        '
        Me.grupoValidacao.Name = "grupoValidacao"
        Me.grupoValidacao.Text = "Validação"
        '
        'lblMetodoValidacao
        '
        Me.lblMetodoValidacao.Name = "lblMetodoValidacao"
        Me.lblMetodoValidacao.Text = "Método:"
        Me.lblMetodoValidacao.Width = 140
        '
        'txtMetodoValidacaox
        '
        Me.txtMetodoValidacaox.Height = 50
        Me.txtMetodoValidacaox.Multiline = True
        Me.txtMetodoValidacaox.Name = "txtMetodoValidacaox"
        Me.txtMetodoValidacaox.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtMetodoValidacaox.Width = 378
        '
        'lblRespValidacao
        '
        Me.lblRespValidacao.Name = "lblRespValidacao"
        Me.lblRespValidacao.Text = "Responsável:"
        Me.lblRespValidacao.Width = 140
        '
        'comboRespValidacao
        '
        Me.comboRespValidacao.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboRespValidacao.Name = "comboRespValidacao"
        Me.comboRespValidacao.Width = 378
        '
        'lblProgValidacao
        '
        Me.lblProgValidacao.Name = "lblProgValidacao"
        Me.lblProgValidacao.Text = "Programação:"
        Me.lblProgValidacao.Width = 140
        '
        'txtProgValidacaox
        '
        Me.txtProgValidacaox.Height = 50
        Me.txtProgValidacaox.Multiline = True
        Me.txtProgValidacaox.Name = "txtProgValidacaox"
        Me.txtProgValidacaox.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtProgValidacaox.Width = 378
        '
        'InputGroupHeader12
        '
        Me.InputGroupHeader12.Name = "InputGroupHeader12"
        Me.InputGroupHeader12.Text = "Opções"
        '
        'botSalvarValid
        '
        Me.botSalvarValid.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botSalvarValid.Image = CType(resources.GetObject("botSalvarValid.Image"), System.Drawing.Image)
        Me.botSalvarValid.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarValid.Name = "botSalvarValid"
        Me.botSalvarValid.Text = "Salvar"
        Me.botSalvarValid.Width = 70
        '
        'projCadControleValidacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 217)
        Me.Controls.Add(Me.txtProgValidacao)
        Me.Controls.Add(Me.txtMetodoValidacao)
        Me.Controls.Add(Me.InputValid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "projCadControleValidacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.txtProgValidacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMetodoValidacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputValid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtProgValidacao As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtMetodoValidacao As C1.Win.C1Input.C1TextBox
    Friend WithEvents InputValid As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoValidacao As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblMetodoValidacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtMetodoValidacaox As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblRespValidacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboRespValidacao As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblProgValidacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtProgValidacaox As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputGroupHeader12 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvarValid As C1.Win.C1InputPanel.InputButton
End Class
