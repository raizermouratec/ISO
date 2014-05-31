<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forCadCriterios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forCadCriterios))
        Me.gridCriterios = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botRelatorio = New C1.Win.C1InputPanel.InputButton()
        CType(Me.gridCriterios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridCriterios
        '
        Me.gridCriterios.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridCriterios.AllowEditing = False
        Me.gridCriterios.ColumnInfo = "4,1,0,0,0,105,Columns:0{Width:0;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:0;Name:""ID_CRITERIO_AVALIACAO"";Caption:" & _
    """Código"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:177;Name:""NOME"";Caption:""Nome"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Width:320;Name:""DESCRICAO""" & _
    ";Caption:""Descrição"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.gridCriterios.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridCriterios.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridCriterios.Location = New System.Drawing.Point(0, 27)
        Me.gridCriterios.Name = "gridCriterios"
        Me.gridCriterios.Rows.DefaultSize = 21
        Me.gridCriterios.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridCriterios.Size = New System.Drawing.Size(579, 194)
        Me.gridCriterios.StyleInfo = resources.GetString("gridCriterios.StyleInfo")
        Me.gridCriterios.TabIndex = 27
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 1)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(579, 237)
        Me.C1InputPanel3.TabIndex = 26
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Lista de Critérios"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.botRelatorio)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 244)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(579, 60)
        Me.C1InputPanel2.TabIndex = 25
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Opções"
        '
        'botRelatorio
        '
        Me.botRelatorio.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botRelatorio.Enabled = False
        Me.botRelatorio.Image = CType(resources.GetObject("botRelatorio.Image"), System.Drawing.Image)
        Me.botRelatorio.ImageSize = New System.Drawing.Size(20, 20)
        Me.botRelatorio.Name = "botRelatorio"
        Me.botRelatorio.Text = "Relatório"
        '
        'forCadCriterios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 299)
        Me.Controls.Add(Me.gridCriterios)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "forCadCriterios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Critérios"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.gridCriterios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridCriterios As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botRelatorio As C1.Win.C1InputPanel.InputButton
End Class
