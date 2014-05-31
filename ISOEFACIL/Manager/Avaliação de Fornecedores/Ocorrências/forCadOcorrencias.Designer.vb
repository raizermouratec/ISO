<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forCadOcorrencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forCadOcorrencias))
        Me.PainelOcorrencia = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOcorrencia = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lbl_Fronecedor = New C1.Win.C1InputPanel.InputLabel()
        Me.cmb_Fornecedor = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dt_ocorencia = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblOcorrencia = New C1.Win.C1InputPanel.InputLabel()
        Me.lblResponsavel = New C1.Win.C1InputPanel.InputLabel()
        Me.comboResponsavel = New C1.Win.C1InputPanel.InputComboBox()
        Me.lbl_situacao = New C1.Win.C1InputPanel.InputLabel()
        Me.radio_NCocluido = New C1.Win.C1InputPanel.InputRadioButton()
        Me.Radio_Cocluido = New C1.Win.C1InputPanel.InputRadioButton()
        Me.lbl_Conclusao = New C1.Win.C1InputPanel.InputLabel()
        Me.lbl_dt_Conclusão = New C1.Win.C1InputPanel.InputLabel()
        Me.dt_Coclusao = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmb_Responsavel_Coclusao = New C1.Win.C1InputPanel.InputComboBox()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.txt_Ocorrencia = New System.Windows.Forms.TextBox()
        Me.txt_Conclusao = New System.Windows.Forms.TextBox()
        CType(Me.PainelOcorrencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PainelOcorrencia
        '
        Me.PainelOcorrencia.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.PainelOcorrencia.Items.Add(Me.grupoOcorrencia)
        Me.PainelOcorrencia.Items.Add(Me.lbl_Fronecedor)
        Me.PainelOcorrencia.Items.Add(Me.cmb_Fornecedor)
        Me.PainelOcorrencia.Items.Add(Me.lblData)
        Me.PainelOcorrencia.Items.Add(Me.dt_ocorencia)
        Me.PainelOcorrencia.Items.Add(Me.lblOcorrencia)
        Me.PainelOcorrencia.Items.Add(Me.lblResponsavel)
        Me.PainelOcorrencia.Items.Add(Me.comboResponsavel)
        Me.PainelOcorrencia.Items.Add(Me.lbl_situacao)
        Me.PainelOcorrencia.Items.Add(Me.radio_NCocluido)
        Me.PainelOcorrencia.Items.Add(Me.Radio_Cocluido)
        Me.PainelOcorrencia.Items.Add(Me.lbl_Conclusao)
        Me.PainelOcorrencia.Items.Add(Me.lbl_dt_Conclusão)
        Me.PainelOcorrencia.Items.Add(Me.dt_Coclusao)
        Me.PainelOcorrencia.Items.Add(Me.InputLabel3)
        Me.PainelOcorrencia.Items.Add(Me.cmb_Responsavel_Coclusao)
        Me.PainelOcorrencia.Location = New System.Drawing.Point(-2, 0)
        Me.PainelOcorrencia.Margin = New System.Windows.Forms.Padding(4)
        Me.PainelOcorrencia.Name = "PainelOcorrencia"
        Me.PainelOcorrencia.Size = New System.Drawing.Size(500, 387)
        Me.PainelOcorrencia.TabIndex = 2
        '
        'grupoOcorrencia
        '
        Me.grupoOcorrencia.Name = "grupoOcorrencia"
        Me.grupoOcorrencia.Text = "Dados da Ocorrência"
        '
        'lbl_Fronecedor
        '
        Me.lbl_Fronecedor.Name = "lbl_Fronecedor"
        Me.lbl_Fronecedor.Text = "Fornecedor:"
        Me.lbl_Fronecedor.Width = 125
        '
        'cmb_Fornecedor
        '
        Me.cmb_Fornecedor.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmb_Fornecedor.Name = "cmb_Fornecedor"
        Me.cmb_Fornecedor.Width = 349
        '
        'lblData
        '
        Me.lblData.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblData.Name = "lblData"
        Me.lblData.Text = "Data"
        Me.lblData.Width = 125
        '
        'dt_ocorencia
        '
        Me.dt_ocorencia.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dt_ocorencia.Name = "dt_ocorencia"
        Me.dt_ocorencia.Width = 125
        '
        'lblOcorrencia
        '
        Me.lblOcorrencia.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblOcorrencia.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblOcorrencia.Height = 108
        Me.lblOcorrencia.Name = "lblOcorrencia"
        Me.lblOcorrencia.Text = "Ocorrência :"
        Me.lblOcorrencia.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblOcorrencia.Width = 125
        '
        'lblResponsavel
        '
        Me.lblResponsavel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblResponsavel.Name = "lblResponsavel"
        Me.lblResponsavel.Text = "Responsável :"
        Me.lblResponsavel.Width = 125
        '
        'comboResponsavel
        '
        Me.comboResponsavel.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboResponsavel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.comboResponsavel.Name = "comboResponsavel"
        Me.comboResponsavel.Width = 350
        '
        'lbl_situacao
        '
        Me.lbl_situacao.Name = "lbl_situacao"
        Me.lbl_situacao.Text = "Situação :"
        Me.lbl_situacao.Width = 125
        '
        'radio_NCocluido
        '
        Me.radio_NCocluido.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radio_NCocluido.Name = "radio_NCocluido"
        Me.radio_NCocluido.Text = "Não Concluído"
        '
        'Radio_Cocluido
        '
        Me.Radio_Cocluido.Name = "Radio_Cocluido"
        Me.Radio_Cocluido.Text = "Concluído"
        '
        'lbl_Conclusao
        '
        Me.lbl_Conclusao.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lbl_Conclusao.Height = 108
        Me.lbl_Conclusao.Name = "lbl_Conclusao"
        Me.lbl_Conclusao.Text = "Conclusão :"
        Me.lbl_Conclusao.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lbl_Conclusao.Width = 125
        '
        'lbl_dt_Conclusão
        '
        Me.lbl_dt_Conclusão.Name = "lbl_dt_Conclusão"
        Me.lbl_dt_Conclusão.Text = "Data da Conclusão :"
        Me.lbl_dt_Conclusão.Width = 125
        '
        'dt_Coclusao
        '
        Me.dt_Coclusao.Enabled = False
        Me.dt_Coclusao.Name = "dt_Coclusao"
        Me.dt_Coclusao.Width = 125
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Resp. da Conclusão :"
        Me.InputLabel3.Width = 125
        '
        'cmb_Responsavel_Coclusao
        '
        Me.cmb_Responsavel_Coclusao.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmb_Responsavel_Coclusao.Enabled = False
        Me.cmb_Responsavel_Coclusao.Name = "cmb_Responsavel_Coclusao"
        Me.cmb_Responsavel_Coclusao.Width = 347
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.botSalvar)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 388)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(498, 59)
        Me.C1InputPanel1.TabIndex = 3
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
        '
        'botSalvar
        '
        Me.botSalvar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.botSalvar.Image = CType(resources.GetObject("botSalvar.Image"), System.Drawing.Image)
        Me.botSalvar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvar.Name = "botSalvar"
        Me.botSalvar.Text = "Salvar"
        Me.botSalvar.Width = 70
        '
        'txt_Ocorrencia
        '
        Me.txt_Ocorrencia.Location = New System.Drawing.Point(137, 75)
        Me.txt_Ocorrencia.Multiline = True
        Me.txt_Ocorrencia.Name = "txt_Ocorrencia"
        Me.txt_Ocorrencia.Size = New System.Drawing.Size(349, 107)
        Me.txt_Ocorrencia.TabIndex = 4
        '
        'txt_Conclusao
        '
        Me.txt_Conclusao.Enabled = False
        Me.txt_Conclusao.Location = New System.Drawing.Point(137, 226)
        Me.txt_Conclusao.Multiline = True
        Me.txt_Conclusao.Name = "txt_Conclusao"
        Me.txt_Conclusao.Size = New System.Drawing.Size(349, 107)
        Me.txt_Conclusao.TabIndex = 5
        '
        'forCadOcorrencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 444)
        Me.Controls.Add(Me.txt_Conclusao)
        Me.Controls.Add(Me.txt_Ocorrencia)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.PainelOcorrencia)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "forCadOcorrencias"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Ocorrências"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.PainelOcorrencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PainelOcorrencia As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOcorrencia As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dt_ocorencia As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblOcorrencia As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblResponsavel As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboResponsavel As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lbl_situacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents radio_NCocluido As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents Radio_Cocluido As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents lbl_Conclusao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lbl_dt_Conclusão As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dt_Coclusao As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmb_Responsavel_Coclusao As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents txt_Ocorrencia As System.Windows.Forms.TextBox
    Friend WithEvents txt_Conclusao As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Fronecedor As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmb_Fornecedor As C1.Win.C1InputPanel.InputComboBox
End Class
