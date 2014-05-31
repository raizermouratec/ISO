<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mgFolhadeRostoElaboracaoManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mgFolhadeRostoElaboracaoManual))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.botEdit = New C1.Win.C1InputPanel.InputButton()
        Me.txtApresentacao = New C1.Win.C1Input.C1TextBox()
        Me.txtObjetivo = New C1.Win.C1Input.C1TextBox()
        Me.txtNota = New C1.Win.C1Input.C1TextBox()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApresentacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObjetivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(662, 136)
        Me.C1InputPanel1.TabIndex = 5
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Apresentação"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 144)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(662, 136)
        Me.C1InputPanel2.TabIndex = 6
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Objetivo"
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 286)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(662, 136)
        Me.C1InputPanel3.TabIndex = 7
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Nota"
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel4.Items.Add(Me.botSalvar)
        Me.C1InputPanel4.Items.Add(Me.botEdit)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 428)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(662, 64)
        Me.C1InputPanel4.TabIndex = 8
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "Opções"
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
        'botEdit
        '
        Me.botEdit.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botEdit.Image = CType(resources.GetObject("botEdit.Image"), System.Drawing.Image)
        Me.botEdit.ImageSize = New System.Drawing.Size(20, 20)
        Me.botEdit.Name = "botEdit"
        Me.botEdit.Text = "Editar"
        Me.botEdit.Width = 70
        '
        'txtApresentacao
        '
        Me.txtApresentacao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtApresentacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApresentacao.Location = New System.Drawing.Point(0, 25)
        Me.txtApresentacao.Multiline = True
        Me.txtApresentacao.Name = "txtApresentacao"
        Me.txtApresentacao.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtApresentacao.Size = New System.Drawing.Size(662, 113)
        Me.txtApresentacao.TabIndex = 9
        Me.txtApresentacao.Tag = Nothing
        Me.txtApresentacao.TextDetached = True
        Me.txtApresentacao.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtApresentacao.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'txtObjetivo
        '
        Me.txtObjetivo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtObjetivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObjetivo.Location = New System.Drawing.Point(0, 167)
        Me.txtObjetivo.Multiline = True
        Me.txtObjetivo.Name = "txtObjetivo"
        Me.txtObjetivo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObjetivo.Size = New System.Drawing.Size(662, 113)
        Me.txtObjetivo.TabIndex = 10
        Me.txtObjetivo.Tag = Nothing
        Me.txtObjetivo.TextDetached = True
        Me.txtObjetivo.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtObjetivo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'txtNota
        '
        Me.txtNota.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNota.Location = New System.Drawing.Point(0, 309)
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNota.Size = New System.Drawing.Size(662, 113)
        Me.txtNota.TabIndex = 11
        Me.txtNota.Tag = Nothing
        Me.txtNota.TextDetached = True
        Me.txtNota.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtNota.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'mgFolhadeRosto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 492)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.txtObjetivo)
        Me.Controls.Add(Me.txtApresentacao)
        Me.Controls.Add(Me.C1InputPanel4)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "mgFolhadeRosto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Folha de Rosto"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApresentacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObjetivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEdit As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtApresentacao As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtObjetivo As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNota As C1.Win.C1Input.C1TextBox
End Class
