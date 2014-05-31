<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class docContRevisar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(docContRevisar))
        Me.InputNovoDoc = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.botCancelar = New C1.Win.C1InputPanel.InputButton()
        Me.txtResumoAlteracao = New C1.Win.C1Input.C1TextBox()
        CType(Me.InputNovoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResumoAlteracao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputNovoDoc
        '
        Me.InputNovoDoc.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.InputNovoDoc.Items.Add(Me.InputGroupHeader2)
        Me.InputNovoDoc.Location = New System.Drawing.Point(12, 12)
        Me.InputNovoDoc.Name = "InputNovoDoc"
        Me.InputNovoDoc.Size = New System.Drawing.Size(576, 190)
        Me.InputNovoDoc.TabIndex = 30
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Resumo da Alteração"
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.botSalvar)
        Me.C1InputPanel1.Items.Add(Me.botCancelar)
        Me.C1InputPanel1.Location = New System.Drawing.Point(12, 208)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(576, 59)
        Me.C1InputPanel1.TabIndex = 31
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
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
        'botCancelar
        '
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Image)
        Me.botCancelar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Text = "Cancelar"
        '
        'txtResumoAlteracao
        '
        Me.txtResumoAlteracao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtResumoAlteracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResumoAlteracao.Location = New System.Drawing.Point(12, 36)
        Me.txtResumoAlteracao.Multiline = True
        Me.txtResumoAlteracao.Name = "txtResumoAlteracao"
        Me.txtResumoAlteracao.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResumoAlteracao.Size = New System.Drawing.Size(576, 166)
        Me.txtResumoAlteracao.TabIndex = 32
        Me.txtResumoAlteracao.Tag = Nothing
        Me.txtResumoAlteracao.TextDetached = True
        '
        'docContRevisar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 279)
        Me.Controls.Add(Me.txtResumoAlteracao)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.InputNovoDoc)
        Me.MaximizeBox = False
        Me.Name = "docContRevisar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revisar Documento"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.InputNovoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResumoAlteracao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InputNovoDoc As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtResumoAlteracao As C1.Win.C1Input.C1TextBox
    Friend WithEvents botCancelar As C1.Win.C1InputPanel.InputButton
End Class
