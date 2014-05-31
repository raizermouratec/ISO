<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class docElabIncluiAtv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(docElabIncluiAtv))
        Me.C1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader7 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblIncluiAtv = New C1.Win.C1InputPanel.InputLabel()
        Me.mskIncluiAtv = New C1.Win.C1InputPanel.InputMaskedTextBox()
        Me.lblSparator = New C1.Win.C1InputPanel.InputLabel()
        Me.botIncluirAtv = New C1.Win.C1InputPanel.InputButton()
        Me.botCancelAtv = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton1 = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel7
        '
        Me.C1InputPanel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel7.Items.Add(Me.InputGroupHeader7)
        Me.C1InputPanel7.Items.Add(Me.lblIncluiAtv)
        Me.C1InputPanel7.Items.Add(Me.mskIncluiAtv)
        Me.C1InputPanel7.Items.Add(Me.lblSparator)
        Me.C1InputPanel7.Items.Add(Me.botIncluirAtv)
        Me.C1InputPanel7.Items.Add(Me.botCancelAtv)
        Me.C1InputPanel7.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel7.Name = "C1InputPanel7"
        Me.C1InputPanel7.Size = New System.Drawing.Size(235, 90)
        Me.C1InputPanel7.TabIndex = 37
        '
        'InputGroupHeader7
        '
        Me.InputGroupHeader7.Name = "InputGroupHeader7"
        Me.InputGroupHeader7.Text = "Opções"
        '
        'lblIncluiAtv
        '
        Me.lblIncluiAtv.Height = 18
        Me.lblIncluiAtv.Name = "lblIncluiAtv"
        Me.lblIncluiAtv.Text = "Incluir Atividade na posição nº"
        '
        'mskIncluiAtv
        '
        Me.mskIncluiAtv.Height = 27
        Me.mskIncluiAtv.Mask = "0000"
        Me.mskIncluiAtv.Name = "mskIncluiAtv"
        Me.mskIncluiAtv.ValidatingType = GetType(Integer)
        Me.mskIncluiAtv.Width = 50
        '
        'lblSparator
        '
        Me.lblSparator.Height = 12
        Me.lblSparator.Name = "lblSparator"
        Me.lblSparator.Width = 150
        '
        'botIncluirAtv
        '
        Me.botIncluirAtv.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botIncluirAtv.Image = CType(resources.GetObject("botIncluirAtv.Image"), System.Drawing.Image)
        Me.botIncluirAtv.ImageSize = New System.Drawing.Size(20, 20)
        Me.botIncluirAtv.Name = "botIncluirAtv"
        '
        'botCancelAtv
        '
        Me.botCancelAtv.Image = CType(resources.GetObject("botCancelAtv.Image"), System.Drawing.Image)
        Me.botCancelAtv.ImageSize = New System.Drawing.Size(20, 20)
        Me.botCancelAtv.Name = "botCancelAtv"
        '
        'InputButton1
        '
        Me.InputButton1.Image = CType(resources.GetObject("InputButton1.Image"), System.Drawing.Image)
        Me.InputButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.InputButton1.Name = "InputButton1"
        Me.InputButton1.Text = "Anexos"
        '
        'docElabIncluiAtv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 90)
        Me.Controls.Add(Me.C1InputPanel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "docElabIncluiAtv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incluir Atividade"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader7 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botIncluirAtv As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botCancelAtv As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton1 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblIncluiAtv As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents mskIncluiAtv As C1.Win.C1InputPanel.InputMaskedTextBox
    Friend WithEvents lblSparator As C1.Win.C1InputPanel.InputLabel
End Class
