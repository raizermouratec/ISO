<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projCadControleAC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projCadControleAC))
        Me.txtProgramacaoAC = New C1.Win.C1Input.C1TextBox()
        Me.txtMetodoAC = New C1.Win.C1Input.C1TextBox()
        Me.InputAC = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoAnaliseCritica = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblMetodoAC = New C1.Win.C1InputPanel.InputLabel()
        Me.txtMetodoACx = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblRespAC = New C1.Win.C1InputPanel.InputLabel()
        Me.comboRespAC = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblProgramacaoAC = New C1.Win.C1InputPanel.InputLabel()
        Me.txtProgramacaoACx = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputGroupHeader10 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarAC = New C1.Win.C1InputPanel.InputButton()
        CType(Me.txtProgramacaoAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMetodoAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputAC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProgramacaoAC
        '
        Me.txtProgramacaoAC.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtProgramacaoAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProgramacaoAC.Location = New System.Drawing.Point(155, 105)
        Me.txtProgramacaoAC.Multiline = True
        Me.txtProgramacaoAC.Name = "txtProgramacaoAC"
        Me.txtProgramacaoAC.Size = New System.Drawing.Size(378, 50)
        Me.txtProgramacaoAC.TabIndex = 3
        Me.txtProgramacaoAC.Tag = Nothing
        Me.txtProgramacaoAC.TextDetached = True
        '
        'txtMetodoAC
        '
        Me.txtMetodoAC.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtMetodoAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMetodoAC.Location = New System.Drawing.Point(155, 28)
        Me.txtMetodoAC.Multiline = True
        Me.txtMetodoAC.Name = "txtMetodoAC"
        Me.txtMetodoAC.Size = New System.Drawing.Size(378, 50)
        Me.txtMetodoAC.TabIndex = 4
        Me.txtMetodoAC.Tag = Nothing
        Me.txtMetodoAC.TextDetached = True
        '
        'InputAC
        '
        Me.InputAC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InputAC.Items.Add(Me.grupoAnaliseCritica)
        Me.InputAC.Items.Add(Me.lblMetodoAC)
        Me.InputAC.Items.Add(Me.txtMetodoACx)
        Me.InputAC.Items.Add(Me.lblRespAC)
        Me.InputAC.Items.Add(Me.comboRespAC)
        Me.InputAC.Items.Add(Me.lblProgramacaoAC)
        Me.InputAC.Items.Add(Me.txtProgramacaoACx)
        Me.InputAC.Items.Add(Me.InputGroupHeader10)
        Me.InputAC.Items.Add(Me.botSalvarAC)
        Me.InputAC.Location = New System.Drawing.Point(1, 2)
        Me.InputAC.Name = "InputAC"
        Me.InputAC.Size = New System.Drawing.Size(546, 214)
        Me.InputAC.TabIndex = 2
        '
        'grupoAnaliseCritica
        '
        Me.grupoAnaliseCritica.Name = "grupoAnaliseCritica"
        Me.grupoAnaliseCritica.Text = "Análise Crítica"
        '
        'lblMetodoAC
        '
        Me.lblMetodoAC.Name = "lblMetodoAC"
        Me.lblMetodoAC.Text = "Método:"
        Me.lblMetodoAC.Width = 140
        '
        'txtMetodoACx
        '
        Me.txtMetodoACx.Height = 50
        Me.txtMetodoACx.Multiline = True
        Me.txtMetodoACx.Name = "txtMetodoACx"
        Me.txtMetodoACx.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtMetodoACx.Width = 378
        '
        'lblRespAC
        '
        Me.lblRespAC.Name = "lblRespAC"
        Me.lblRespAC.Text = "Responsável:"
        Me.lblRespAC.Width = 140
        '
        'comboRespAC
        '
        Me.comboRespAC.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboRespAC.Name = "comboRespAC"
        Me.comboRespAC.Width = 378
        '
        'lblProgramacaoAC
        '
        Me.lblProgramacaoAC.Name = "lblProgramacaoAC"
        Me.lblProgramacaoAC.Text = "Programação:"
        Me.lblProgramacaoAC.Width = 140
        '
        'txtProgramacaoACx
        '
        Me.txtProgramacaoACx.Height = 50
        Me.txtProgramacaoACx.Multiline = True
        Me.txtProgramacaoACx.Name = "txtProgramacaoACx"
        Me.txtProgramacaoACx.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtProgramacaoACx.Width = 378
        '
        'InputGroupHeader10
        '
        Me.InputGroupHeader10.Name = "InputGroupHeader10"
        Me.InputGroupHeader10.Text = "Opções"
        '
        'botSalvarAC
        '
        Me.botSalvarAC.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botSalvarAC.Image = CType(resources.GetObject("botSalvarAC.Image"), System.Drawing.Image)
        Me.botSalvarAC.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarAC.Name = "botSalvarAC"
        Me.botSalvarAC.Text = "Salvar"
        Me.botSalvarAC.Width = 70
        '
        'projCadControleAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 217)
        Me.Controls.Add(Me.txtProgramacaoAC)
        Me.Controls.Add(Me.txtMetodoAC)
        Me.Controls.Add(Me.InputAC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "projCadControleAC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.txtProgramacaoAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMetodoAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputAC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtProgramacaoAC As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtMetodoAC As C1.Win.C1Input.C1TextBox
    Friend WithEvents InputAC As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoAnaliseCritica As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblMetodoAC As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtMetodoACx As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblRespAC As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboRespAC As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblProgramacaoAC As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtProgramacaoACx As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputGroupHeader10 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvarAC As C1.Win.C1InputPanel.InputButton
End Class
