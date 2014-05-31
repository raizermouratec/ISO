<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class audItensProgAuditorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(audItensProgAuditorias))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoItens = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.gridItem = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.checkTodos = New C1.Win.C1InputPanel.InputCheckBox()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.grupoItens)
        Me.C1InputPanel1.Location = New System.Drawing.Point(-1, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(654, 332)
        Me.C1InputPanel1.TabIndex = 0
        '
        'grupoItens
        '
        Me.grupoItens.Name = "grupoItens"
        Me.grupoItens.Text = "Selecione os itens que deseja adicionar para a auditoria:"
        '
        'gridItem
        '
        Me.gridItem.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridItem.AllowEditing = False
        Me.gridItem.AllowFiltering = True
        Me.gridItem.ColumnInfo = resources.GetString("gridItem.ColumnInfo")
        Me.gridItem.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridItem.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridItem.Location = New System.Drawing.Point(-1, 28)
        Me.gridItem.Name = "gridItem"
        Me.gridItem.Rows.DefaultSize = 21
        Me.gridItem.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridItem.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridItem.Size = New System.Drawing.Size(654, 306)
        Me.gridItem.StyleInfo = resources.GetString("gridItem.StyleInfo")
        Me.gridItem.TabIndex = 1
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel3.Items.Add(Me.checkTodos)
        Me.C1InputPanel3.Items.Add(Me.botSalvar)
        Me.C1InputPanel3.Location = New System.Drawing.Point(-1, 335)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(654, 58)
        Me.C1InputPanel3.TabIndex = 22
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
        '
        'checkTodos
        '
        Me.checkTodos.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.checkTodos.CheckAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.checkTodos.Name = "checkTodos"
        Me.checkTodos.Text = "Selecionar Todos"
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
        'audItensProgAuditorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 390)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.gridItem)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "audItensProgAuditorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Itens Aplicáveis"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoItens As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridItem As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents checkTodos As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
End Class
