<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class audChecklist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(audChecklist))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.gridCheck = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botPerguntas = New C1.Win.C1InputPanel.InputButton()
        Me.botRelacao = New C1.Win.C1InputPanel.InputSplitButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Location = New System.Drawing.Point(1, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(668, 343)
        Me.C1InputPanel1.TabIndex = 29
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Lista de CheckList"
        '
        'gridCheck
        '
        Me.gridCheck.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridCheck.AllowEditing = False
        Me.gridCheck.ColumnInfo = resources.GetString("gridCheck.ColumnInfo")
        Me.gridCheck.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridCheck.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridCheck.Location = New System.Drawing.Point(3, 28)
        Me.gridCheck.Name = "gridCheck"
        Me.gridCheck.Rows.DefaultSize = 21
        Me.gridCheck.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridCheck.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridCheck.Size = New System.Drawing.Size(666, 317)
        Me.gridCheck.StyleInfo = resources.GetString("gridCheck.StyleInfo")
        Me.gridCheck.TabIndex = 30
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.botPerguntas)
        Me.C1InputPanel2.Items.Add(Me.botRelacao)
        Me.C1InputPanel2.Location = New System.Drawing.Point(3, 347)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(666, 61)
        Me.C1InputPanel2.TabIndex = 31
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Opções"
        '
        'botPerguntas
        '
        Me.botPerguntas.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botPerguntas.Image = CType(resources.GetObject("botPerguntas.Image"), System.Drawing.Image)
        Me.botPerguntas.ImageSize = New System.Drawing.Size(20, 20)
        Me.botPerguntas.Name = "botPerguntas"
        Me.botPerguntas.Text = "Perguntas"
        '
        'botRelacao
        '
        Me.botRelacao.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botRelacao.Height = 28
        Me.botRelacao.Image = CType(resources.GetObject("botRelacao.Image"), System.Drawing.Image)
        Me.botRelacao.ImageSize = New System.Drawing.Size(20, 20)
        Me.botRelacao.Name = "botRelacao"
        Me.botRelacao.Text = "Relação"
        '
        'audChecklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 409)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.gridCheck)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "audChecklist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check List de Auditoria"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridCheck As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botPerguntas As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botRelacao As C1.Win.C1InputPanel.InputSplitButton
End Class
