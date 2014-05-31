<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acAdicionarPlanoAnual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acAdicionarPlanoAnual))
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.radioOrdinaria = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioExtraordinaria = New C1.Win.C1InputPanel.InputRadioButton()
        Me.lblTipodeReuniao = New C1.Win.C1InputPanel.InputLabel()
        Me.lblResp = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResp = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dateData = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Lista de Instrumentos"
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel4.Items.Add(Me.botSalvar)
        Me.C1InputPanel4.Location = New System.Drawing.Point(2, 104)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(449, 60)
        Me.C1InputPanel4.TabIndex = 24
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Opções"
        '
        'botSalvar
        '
        Me.botSalvar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botSalvar.Image = CType(resources.GetObject("botSalvar.Image"), System.Drawing.Image)
        Me.botSalvar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvar.Name = "botSalvar"
        Me.botSalvar.Text = "Salvar"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel2.Items.Add(Me.lblTipodeReuniao)
        Me.C1InputPanel2.Items.Add(Me.radioOrdinaria)
        Me.C1InputPanel2.Items.Add(Me.radioExtraordinaria)
        Me.C1InputPanel2.Items.Add(Me.lblResp)
        Me.C1InputPanel2.Items.Add(Me.comboResp)
        Me.C1InputPanel2.Items.Add(Me.lblData)
        Me.C1InputPanel2.Items.Add(Me.dateData)
        Me.C1InputPanel2.Location = New System.Drawing.Point(2, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(449, 98)
        Me.C1InputPanel2.TabIndex = 23
        '
        'radioOrdinaria
        '
        Me.radioOrdinaria.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioOrdinaria.Name = "radioOrdinaria"
        Me.radioOrdinaria.Padding = New System.Windows.Forms.Padding(2, 2, 50, 2)
        Me.radioOrdinaria.Text = "Ordinária"
        '
        'radioExtraordinaria
        '
        Me.radioExtraordinaria.Name = "radioExtraordinaria"
        Me.radioExtraordinaria.Text = "Extraordinária"
        '
        'lblTipodeReuniao
        '
        Me.lblTipodeReuniao.Name = "lblTipodeReuniao"
        Me.lblTipodeReuniao.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.lblTipodeReuniao.Text = "Tipo de Reunião :"
        '
        'lblResp
        '
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Text = "Responsável :"
        '
        'comboResp
        '
        Me.comboResp.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResp.Name = "comboResp"
        Me.comboResp.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.comboResp.Width = 357
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Text = "Data :"
        '
        'dateData
        '
        Me.dateData.Name = "dateData"
        Me.dateData.Padding = New System.Windows.Forms.Padding(110, 0, 0, 0)
        Me.dateData.Width = 224
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Nova Reunião"
        '
        'RibbonForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 166)
        Me.Controls.Add(Me.C1InputPanel4)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "RibbonForm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Reunião Anual"
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents radioOrdinaria As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioExtraordinaria As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblTipodeReuniao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblResp As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResp As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dateData As C1.Win.C1InputPanel.InputDatePicker
End Class
