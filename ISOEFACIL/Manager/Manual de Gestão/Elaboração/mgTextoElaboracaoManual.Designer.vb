<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mgTextoElaboracaoManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mgTextoElaboracaoManual))
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.botEdit = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1Editor1 = New C1.Win.C1Editor.C1Editor()
        Me.C1EditorToolStripMain1 = New C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain()
        Me.C1EditorToolStripObjects1 = New C1.Win.C1Editor.ToolStrips.C1EditorToolStripObjects()
        Me.C1EditorToolStripStyle1 = New C1.Win.C1Editor.ToolStrips.C1EditorToolStripStyle()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Editor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel4.Items.Add(Me.botSalvar)
        Me.C1InputPanel4.Items.Add(Me.botEdit)
        Me.C1InputPanel4.Location = New System.Drawing.Point(12, 420)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(878, 64)
        Me.C1InputPanel4.TabIndex = 9
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
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Location = New System.Drawing.Point(12, 53)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(878, 361)
        Me.C1InputPanel1.TabIndex = 10
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Editor de Texto"
        '
        'C1Editor1
        '
        Me.C1Editor1.Location = New System.Drawing.Point(12, 76)
        Me.C1Editor1.Name = "C1Editor1"
        Me.C1Editor1.Size = New System.Drawing.Size(878, 338)
        Me.C1Editor1.TabIndex = 11
        '
        'C1EditorToolStripMain1
        '
        Me.C1EditorToolStripMain1.Editor = Me.C1Editor1
        Me.C1EditorToolStripMain1.Location = New System.Drawing.Point(0, 0)
        Me.C1EditorToolStripMain1.Name = "C1EditorToolStripMain1"
        Me.C1EditorToolStripMain1.Size = New System.Drawing.Size(902, 25)
        Me.C1EditorToolStripMain1.TabIndex = 12
        Me.C1EditorToolStripMain1.Text = "C1EditorToolStripMain1"
        '
        'C1EditorToolStripObjects1
        '
        Me.C1EditorToolStripObjects1.Dock = System.Windows.Forms.DockStyle.None
        Me.C1EditorToolStripObjects1.Editor = Me.C1Editor1
        Me.C1EditorToolStripObjects1.Location = New System.Drawing.Point(687, 25)
        Me.C1EditorToolStripObjects1.Name = "C1EditorToolStripObjects1"
        Me.C1EditorToolStripObjects1.Size = New System.Drawing.Size(127, 25)
        Me.C1EditorToolStripObjects1.TabIndex = 13
        Me.C1EditorToolStripObjects1.Text = "C1EditorToolStripObjects1"
        '
        'C1EditorToolStripStyle1
        '
        Me.C1EditorToolStripStyle1.Dock = System.Windows.Forms.DockStyle.None
        Me.C1EditorToolStripStyle1.Editor = Me.C1Editor1
        Me.C1EditorToolStripStyle1.Location = New System.Drawing.Point(0, 25)
        Me.C1EditorToolStripStyle1.Name = "C1EditorToolStripStyle1"
        Me.C1EditorToolStripStyle1.Size = New System.Drawing.Size(687, 25)
        Me.C1EditorToolStripStyle1.TabIndex = 14
        Me.C1EditorToolStripStyle1.Text = "C1EditorToolStripStyle1"
        '
        'mgTextoItensManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 496)
        Me.Controls.Add(Me.C1EditorToolStripObjects1)
        Me.Controls.Add(Me.C1EditorToolStripMain1)
        Me.Controls.Add(Me.C1Editor1)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel4)
        Me.Controls.Add(Me.C1EditorToolStripStyle1)
        Me.Name = "mgTextoItensManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mgTextoItensManual"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Editor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEdit As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1Editor1 As C1.Win.C1Editor.C1Editor
    Friend WithEvents C1EditorToolStripMain1 As C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain
    Friend WithEvents C1EditorToolStripObjects1 As C1.Win.C1Editor.ToolStrips.C1EditorToolStripObjects
    Friend WithEvents C1EditorToolStripStyle1 As C1.Win.C1Editor.ToolStrips.C1EditorToolStripStyle
End Class
