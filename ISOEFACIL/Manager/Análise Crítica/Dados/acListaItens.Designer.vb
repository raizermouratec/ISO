<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acListaItens
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acListaItens))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.lblespaco = New C1.Win.C1InputPanel.InputLabel()
        Me.checkTodos = New C1.Win.C1InputPanel.InputCheckBox()
        Me.gridItenS = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItenS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Items.Add(Me.botExcluir)
        Me.C1InputPanel2.Items.Add(Me.lblespaco)
        Me.C1InputPanel2.Items.Add(Me.checkTodos)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 351)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(427, 64)
        Me.C1InputPanel2.TabIndex = 3
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
        'botExcluir
        '
        Me.botExcluir.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botExcluir.Image = CType(resources.GetObject("botExcluir.Image"), System.Drawing.Image)
        Me.botExcluir.ImageSize = New System.Drawing.Size(20, 20)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Text = "Excluir"
        Me.botExcluir.Width = 70
        '
        'lblespaco
        '
        Me.lblespaco.ElementWidth = 200
        Me.lblespaco.Name = "lblespaco"
        '
        'checkTodos
        '
        Me.checkTodos.Name = "checkTodos"
        Me.checkTodos.Text = "Todos"
        '
        'gridItenS
        '
        Me.gridItenS.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridItenS.AllowEditing = False
        Me.gridItenS.AllowFiltering = True
        Me.gridItenS.ColumnInfo = resources.GetString("gridItenS.ColumnInfo")
        Me.gridItenS.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridItenS.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridItenS.Location = New System.Drawing.Point(0, 1)
        Me.gridItenS.Name = "gridItenS"
        Me.gridItenS.Rows.DefaultSize = 21
        Me.gridItenS.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridItenS.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridItenS.Size = New System.Drawing.Size(427, 349)
        Me.gridItenS.StyleInfo = resources.GetString("gridItenS.StyleInfo")
        Me.gridItenS.TabIndex = 4
        Me.gridItenS.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'acListaItens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 415)
        Me.Controls.Add(Me.gridItenS)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "acListaItens"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Itens do Relatório de Dados"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItenS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblespaco As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents checkTodos As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents gridItenS As C1.Win.C1FlexGrid.C1FlexGrid
End Class
