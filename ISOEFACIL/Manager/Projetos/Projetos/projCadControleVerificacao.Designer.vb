<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projCadControleVerificacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projCadControleVerificacao))
        Me.txtMetodoVerif = New C1.Win.C1Input.C1TextBox()
        Me.txtProgVerif = New C1.Win.C1Input.C1TextBox()
        Me.InputVerif = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoVerificacao = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblMetodoVerif = New C1.Win.C1InputPanel.InputLabel()
        Me.txtMetodoVerifx = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblRespVerif = New C1.Win.C1InputPanel.InputLabel()
        Me.comboRespVerif = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblProgVerif = New C1.Win.C1InputPanel.InputLabel()
        Me.txtProgVerifx = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputGroupHeader11 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarVerif = New C1.Win.C1InputPanel.InputButton()
        CType(Me.txtMetodoVerif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProgVerif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputVerif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMetodoVerif
        '
        Me.txtMetodoVerif.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtMetodoVerif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMetodoVerif.Location = New System.Drawing.Point(155, 27)
        Me.txtMetodoVerif.Multiline = True
        Me.txtMetodoVerif.Name = "txtMetodoVerif"
        Me.txtMetodoVerif.Size = New System.Drawing.Size(378, 50)
        Me.txtMetodoVerif.TabIndex = 4
        Me.txtMetodoVerif.Tag = Nothing
        Me.txtMetodoVerif.TextDetached = True
        '
        'txtProgVerif
        '
        Me.txtProgVerif.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtProgVerif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProgVerif.Location = New System.Drawing.Point(155, 104)
        Me.txtProgVerif.Multiline = True
        Me.txtProgVerif.Name = "txtProgVerif"
        Me.txtProgVerif.Size = New System.Drawing.Size(378, 50)
        Me.txtProgVerif.TabIndex = 5
        Me.txtProgVerif.Tag = Nothing
        Me.txtProgVerif.TextDetached = True
        '
        'InputVerif
        '
        Me.InputVerif.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InputVerif.Items.Add(Me.grupoVerificacao)
        Me.InputVerif.Items.Add(Me.lblMetodoVerif)
        Me.InputVerif.Items.Add(Me.txtMetodoVerifx)
        Me.InputVerif.Items.Add(Me.lblRespVerif)
        Me.InputVerif.Items.Add(Me.comboRespVerif)
        Me.InputVerif.Items.Add(Me.lblProgVerif)
        Me.InputVerif.Items.Add(Me.txtProgVerifx)
        Me.InputVerif.Items.Add(Me.InputGroupHeader11)
        Me.InputVerif.Items.Add(Me.botSalvarVerif)
        Me.InputVerif.Location = New System.Drawing.Point(1, 1)
        Me.InputVerif.Name = "InputVerif"
        Me.InputVerif.Size = New System.Drawing.Size(546, 214)
        Me.InputVerif.TabIndex = 3
        '
        'grupoVerificacao
        '
        Me.grupoVerificacao.Name = "grupoVerificacao"
        Me.grupoVerificacao.Text = "Verificação"
        '
        'lblMetodoVerif
        '
        Me.lblMetodoVerif.Name = "lblMetodoVerif"
        Me.lblMetodoVerif.Text = "Método:"
        Me.lblMetodoVerif.Width = 140
        '
        'txtMetodoVerifx
        '
        Me.txtMetodoVerifx.Height = 50
        Me.txtMetodoVerifx.Multiline = True
        Me.txtMetodoVerifx.Name = "txtMetodoVerifx"
        Me.txtMetodoVerifx.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtMetodoVerifx.Width = 378
        '
        'lblRespVerif
        '
        Me.lblRespVerif.Name = "lblRespVerif"
        Me.lblRespVerif.Text = "Responsável:"
        Me.lblRespVerif.Width = 140
        '
        'comboRespVerif
        '
        Me.comboRespVerif.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboRespVerif.Name = "comboRespVerif"
        Me.comboRespVerif.Width = 378
        '
        'lblProgVerif
        '
        Me.lblProgVerif.Name = "lblProgVerif"
        Me.lblProgVerif.Text = "Programação:"
        Me.lblProgVerif.Width = 140
        '
        'txtProgVerifx
        '
        Me.txtProgVerifx.Height = 50
        Me.txtProgVerifx.Multiline = True
        Me.txtProgVerifx.Name = "txtProgVerifx"
        Me.txtProgVerifx.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtProgVerifx.Width = 378
        '
        'InputGroupHeader11
        '
        Me.InputGroupHeader11.Name = "InputGroupHeader11"
        Me.InputGroupHeader11.Text = "Opções"
        '
        'botSalvarVerif
        '
        Me.botSalvarVerif.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botSalvarVerif.Image = CType(resources.GetObject("botSalvarVerif.Image"), System.Drawing.Image)
        Me.botSalvarVerif.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarVerif.Name = "botSalvarVerif"
        Me.botSalvarVerif.Text = "Salvar"
        Me.botSalvarVerif.Width = 70
        '
        'projCadControleVerificacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 217)
        Me.Controls.Add(Me.txtMetodoVerif)
        Me.Controls.Add(Me.txtProgVerif)
        Me.Controls.Add(Me.InputVerif)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "projCadControleVerificacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.txtMetodoVerif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProgVerif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputVerif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtMetodoVerif As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtProgVerif As C1.Win.C1Input.C1TextBox
    Friend WithEvents InputVerif As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoVerificacao As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblMetodoVerif As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtMetodoVerifx As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblRespVerif As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboRespVerif As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblProgVerif As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtProgVerifx As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputGroupHeader11 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvarVerif As C1.Win.C1InputPanel.InputButton
End Class
