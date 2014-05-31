<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calResultadosObtidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calResultadosObtidos))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblMedidaPadrao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtMedidaPadrao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblMedidaVerificada = New C1.Win.C1InputPanel.InputLabel()
        Me.txtMedidaVerificada = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblUnidMedida = New C1.Win.C1InputPanel.InputLabel()
        Me.txtUnidMedida = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.lblMedidaPadrao)
        Me.C1InputPanel1.Items.Add(Me.txtMedidaPadrao)
        Me.C1InputPanel1.Items.Add(Me.lblMedidaVerificada)
        Me.C1InputPanel1.Items.Add(Me.txtMedidaVerificada)
        Me.C1InputPanel1.Items.Add(Me.lblUnidMedida)
        Me.C1InputPanel1.Items.Add(Me.txtUnidMedida)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(286, 85)
        Me.C1InputPanel1.TabIndex = 0
        '
        'lblMedidaPadrao
        '
        Me.lblMedidaPadrao.Name = "lblMedidaPadrao"
        Me.lblMedidaPadrao.Text = "Medida Padrão :"
        Me.lblMedidaPadrao.Width = 118
        '
        'txtMedidaPadrao
        '
        Me.txtMedidaPadrao.Name = "txtMedidaPadrao"
        '
        'lblMedidaVerificada
        '
        Me.lblMedidaVerificada.Name = "lblMedidaVerificada"
        Me.lblMedidaVerificada.Text = "Medida Verificada :"
        Me.lblMedidaVerificada.Width = 118
        '
        'txtMedidaVerificada
        '
        Me.txtMedidaVerificada.Name = "txtMedidaVerificada"
        '
        'lblUnidMedida
        '
        Me.lblUnidMedida.Name = "lblUnidMedida"
        Me.lblUnidMedida.Text = "Unidade de Medida :"
        Me.lblUnidMedida.Width = 118
        '
        'txtUnidMedida
        '
        Me.txtUnidMedida.Name = "txtUnidMedida"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 82)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(286, 64)
        Me.C1InputPanel2.TabIndex = 5
        '
        'grupoOpcoes
        '
        Me.grupoOpcoes.Name = "grupoOpcoes"
        Me.grupoOpcoes.Text = "Opções"
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
        'calResultadosObtidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 147)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "calResultadosObtidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultados Obtidos"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblMedidaPadrao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtMedidaPadrao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblMedidaVerificada As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtMedidaVerificada As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblUnidMedida As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtUnidMedida As C1.Win.C1InputPanel.InputTextBox
End Class
