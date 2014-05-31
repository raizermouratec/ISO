<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeralCadAnexo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeralCadAnexo))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblDescricao = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox1 = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblArquivo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtArquivo = New C1.Win.C1InputPanel.InputTextBox()
        Me.botLocalizarAnexo = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btoSalvar = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.lblDescricao)
        Me.C1InputPanel1.Items.Add(Me.InputTextBox1)
        Me.C1InputPanel1.Items.Add(Me.lblArquivo)
        Me.C1InputPanel1.Items.Add(Me.txtArquivo)
        Me.C1InputPanel1.Items.Add(Me.botLocalizarAnexo)
        Me.C1InputPanel1.Location = New System.Drawing.Point(1, 3)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(492, 165)
        Me.C1InputPanel1.TabIndex = 0
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Cadastrar Anexos"
        '
        'lblDescricao
        '
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Text = "Descrição"
        Me.lblDescricao.Width = 125
        '
        'InputTextBox1
        '
        Me.InputTextBox1.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.InputTextBox1.Height = 100
        Me.InputTextBox1.Multiline = True
        Me.InputTextBox1.Name = "InputTextBox1"
        Me.InputTextBox1.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.InputTextBox1.Width = 250
        '
        'lblArquivo
        '
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Text = "Arquivo"
        Me.lblArquivo.Width = 125
        '
        'txtArquivo
        '
        Me.txtArquivo.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.Width = 250
        '
        'botLocalizarAnexo
        '
        Me.botLocalizarAnexo.Image = CType(resources.GetObject("botLocalizarAnexo.Image"), System.Drawing.Image)
        Me.botLocalizarAnexo.ImageSize = New System.Drawing.Size(16, 16)
        Me.botLocalizarAnexo.Name = "botLocalizarAnexo"
        Me.botLocalizarAnexo.Text = "Localizar"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.btoSalvar)
        Me.C1InputPanel2.Location = New System.Drawing.Point(1, 171)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(492, 58)
        Me.C1InputPanel2.TabIndex = 1
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Opções"
        '
        'btoSalvar
        '
        Me.btoSalvar.Image = CType(resources.GetObject("btoSalvar.Image"), System.Drawing.Image)
        Me.btoSalvar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btoSalvar.Name = "btoSalvar"
        Me.btoSalvar.Text = "Salvar"
        Me.btoSalvar.Width = 70
        '
        'GeralCadAnexo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 229)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GeralCadAnexo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anexo"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents txtArquivo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents botLocalizarAnexo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblDescricao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox1 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblArquivo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btoSalvar As C1.Win.C1InputPanel.InputButton
End Class
