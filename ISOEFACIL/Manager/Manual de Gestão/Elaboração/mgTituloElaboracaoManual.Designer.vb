<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mgTituloElaboracaoManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mgTituloElaboracaoManual))
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.botCancelar = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoTitulo = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.txtTitulo = New C1.Win.C1InputPanel.InputTextBox()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel4.Items.Add(Me.botSalvar)
        Me.C1InputPanel4.Items.Add(Me.botCancelar)
        Me.C1InputPanel4.Location = New System.Drawing.Point(1, 57)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(450, 64)
        Me.C1InputPanel4.TabIndex = 10
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
        'botCancelar
        '
        Me.botCancelar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Image)
        Me.botCancelar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Text = "Cancelar"
        Me.botCancelar.Width = 85
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.grupoTitulo)
        Me.C1InputPanel1.Items.Add(Me.txtTitulo)
        Me.C1InputPanel1.Location = New System.Drawing.Point(1, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(450, 60)
        Me.C1InputPanel1.TabIndex = 11
        '
        'grupoTitulo
        '
        Me.grupoTitulo.Name = "grupoTitulo"
        Me.grupoTitulo.Text = "Título"
        '
        'txtTitulo
        '
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Width = 432
        '
        'mgTituloItensManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 121)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "mgTituloItensManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botCancelar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoTitulo As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents txtTitulo As C1.Win.C1InputPanel.InputTextBox
End Class
