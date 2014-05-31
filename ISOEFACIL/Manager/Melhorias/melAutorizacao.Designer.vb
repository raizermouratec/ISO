<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class melAutorizacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(melAutorizacao))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grup = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblText1 = New C1.Win.C1InputPanel.InputLabel()
        Me.radioViavel1 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioInviavel1 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputSeparator3 = New C1.Win.C1InputPanel.InputSeparator()
        Me.lblText2 = New C1.Win.C1InputPanel.InputLabel()
        Me.comboCliente = New C1.Win.C1InputPanel.InputComboBox()
        Me.botCliente = New C1.Win.C1InputPanel.InputButton()
        Me.radioViavel2 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioInviavel2 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputSeparator5 = New C1.Win.C1InputPanel.InputSeparator()
        Me.lblText3 = New C1.Win.C1InputPanel.InputLabel()
        Me.radioSim = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioNao = New C1.Win.C1InputPanel.InputRadioButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.grup)
        Me.C1InputPanel1.Items.Add(Me.lblText1)
        Me.C1InputPanel1.Items.Add(Me.radioViavel1)
        Me.C1InputPanel1.Items.Add(Me.radioInviavel1)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 1)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(318, 68)
        Me.C1InputPanel1.TabIndex = 0
        '
        'grup
        '
        Me.grup.Name = "grup"
        Me.grup.Text = "Autorização para Implementação da Ação"
        '
        'lblText1
        '
        Me.lblText1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblText1.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblText1.Name = "lblText1"
        Me.lblText1.Text = "Avaliação ou resposta da diretoria da Empresa"
        '
        'radioViavel1
        '
        Me.radioViavel1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioViavel1.Name = "radioViavel1"
        Me.radioViavel1.Text = "Viável"
        Me.radioViavel1.Width = 116
        '
        'radioInviavel1
        '
        Me.radioInviavel1.Name = "radioInviavel1"
        Me.radioInviavel1.Text = "Inviável"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 176)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(318, 64)
        Me.C1InputPanel2.TabIndex = 2
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Opções"
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
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.InputSeparator3)
        Me.C1InputPanel3.Items.Add(Me.lblText2)
        Me.C1InputPanel3.Items.Add(Me.comboCliente)
        Me.C1InputPanel3.Items.Add(Me.botCliente)
        Me.C1InputPanel3.Items.Add(Me.radioViavel2)
        Me.C1InputPanel3.Items.Add(Me.radioInviavel2)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 62)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(318, 82)
        Me.C1InputPanel3.TabIndex = 0
        '
        'InputSeparator3
        '
        Me.InputSeparator3.Name = "InputSeparator3"
        '
        'lblText2
        '
        Me.lblText2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblText2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Text = "Avaliação ou resposta da diretoria do Cliente"
        '
        'comboCliente
        '
        Me.comboCliente.Break = C1.Win.C1InputPanel.BreakType.None
        Me.comboCliente.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboCliente.Name = "comboCliente"
        Me.comboCliente.Width = 270
        '
        'botCliente
        '
        Me.botCliente.Image = CType(resources.GetObject("botCliente.Image"), System.Drawing.Image)
        Me.botCliente.ImageSize = New System.Drawing.Size(20, 20)
        Me.botCliente.Name = "botCliente"
        '
        'radioViavel2
        '
        Me.radioViavel2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioViavel2.Name = "radioViavel2"
        Me.radioViavel2.Text = "Viável"
        Me.radioViavel2.Width = 115
        '
        'radioInviavel2
        '
        Me.radioInviavel2.Name = "radioInviavel2"
        Me.radioInviavel2.Text = "Inviável"
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel4.Items.Add(Me.InputSeparator5)
        Me.C1InputPanel4.Items.Add(Me.lblText3)
        Me.C1InputPanel4.Items.Add(Me.radioSim)
        Me.C1InputPanel4.Items.Add(Me.radioNao)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 141)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(318, 33)
        Me.C1InputPanel4.TabIndex = 0
        '
        'InputSeparator5
        '
        Me.InputSeparator5.Name = "InputSeparator5"
        '
        'lblText3
        '
        Me.lblText3.Name = "lblText3"
        Me.lblText3.Text = "Implementado :"
        '
        'radioSim
        '
        Me.radioSim.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioSim.Name = "radioSim"
        Me.radioSim.Text = "Sim"
        Me.radioSim.Width = 95
        '
        'radioNao
        '
        Me.radioNao.Name = "radioNao"
        Me.radioNao.Text = "Não"
        '
        'melAutorizacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 237)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.C1InputPanel4)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "melAutorizacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorização para Implementação"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grup As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblText1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents radioViavel1 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioInviavel1 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputSeparator3 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents lblText2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboCliente As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents botCliente As C1.Win.C1InputPanel.InputButton
    Friend WithEvents radioViavel2 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioInviavel2 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputSeparator5 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents lblText3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents radioSim As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioNao As C1.Win.C1InputPanel.InputRadioButton
End Class
