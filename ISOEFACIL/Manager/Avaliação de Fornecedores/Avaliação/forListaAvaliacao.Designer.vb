<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forListaAvaliacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forListaAvaliacao))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.botNovo = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.botRequisito = New C1.Win.C1InputPanel.InputButton()
        Me.fg_Avaliacao = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg_Avaliacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackgroundImage = CType(resources.GetObject("C1InputPanel1.BackgroundImage"), System.Drawing.Image)
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1InputPanel1.Items.Add(Me.botNovo)
        Me.C1InputPanel1.Items.Add(Me.botEditar)
        Me.C1InputPanel1.Items.Add(Me.botExcluir)
        Me.C1InputPanel1.Items.Add(Me.botRequisito)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1008, 183)
        Me.C1InputPanel1.TabIndex = 20
        '
        'botNovo
        '
        Me.botNovo.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botNovo.Image = CType(resources.GetObject("botNovo.Image"), System.Drawing.Image)
        Me.botNovo.ImageSize = New System.Drawing.Size(32, 32)
        Me.botNovo.Name = "botNovo"
        Me.botNovo.Padding = New System.Windows.Forms.Padding(180, 130, 0, 0)
        Me.botNovo.Text = "Novo"
        '
        'botEditar
        '
        Me.botEditar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botEditar.Image = CType(resources.GetObject("botEditar.Image"), System.Drawing.Image)
        Me.botEditar.ImageSize = New System.Drawing.Size(32, 32)
        Me.botEditar.Name = "botEditar"
        Me.botEditar.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botEditar.Text = "Editar"
        '
        'botExcluir
        '
        Me.botExcluir.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botExcluir.Image = CType(resources.GetObject("botExcluir.Image"), System.Drawing.Image)
        Me.botExcluir.ImageSize = New System.Drawing.Size(32, 32)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botExcluir.Text = "Excluir"
        '
        'botRequisito
        '
        Me.botRequisito.Image = CType(resources.GetObject("botRequisito.Image"), System.Drawing.Image)
        Me.botRequisito.ImageSize = New System.Drawing.Size(32, 32)
        Me.botRequisito.Name = "botRequisito"
        Me.botRequisito.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botRequisito.Text = "Adicionar Requisito"
        '
        'fg_Avaliacao
        '
        Me.fg_Avaliacao.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg_Avaliacao.AllowEditing = False
        Me.fg_Avaliacao.ColumnInfo = resources.GetString("fg_Avaliacao.ColumnInfo")
        Me.fg_Avaliacao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fg_Avaliacao.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg_Avaliacao.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.fg_Avaliacao.Location = New System.Drawing.Point(0, 183)
        Me.fg_Avaliacao.Name = "fg_Avaliacao"
        Me.fg_Avaliacao.Rows.Count = 1
        Me.fg_Avaliacao.Rows.DefaultSize = 21
        Me.fg_Avaliacao.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg_Avaliacao.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.WhenEditing
        Me.fg_Avaliacao.Size = New System.Drawing.Size(1008, 381)
        Me.fg_Avaliacao.StyleInfo = resources.GetString("fg_Avaliacao.StyleInfo")
        Me.fg_Avaliacao.TabIndex = 22
        '
        'forListaAvaliacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 564)
        Me.Controls.Add(Me.fg_Avaliacao)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Name = "forListaAvaliacao"
        Me.Text = "ForListaAvaliação"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg_Avaliacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents botNovo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents fg_Avaliacao As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents botRequisito As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
End Class
