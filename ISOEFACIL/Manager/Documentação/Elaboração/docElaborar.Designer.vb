<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class docElaborar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(docElaborar))
        Me.C1InputPanel15 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader14 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botNovo = New C1.Win.C1InputPanel.InputButton()
        Me.botEdit = New C1.Win.C1InputPanel.InputButton()
        Me.botRevisao = New C1.Win.C1InputPanel.InputButton()
        Me.botCancelar = New C1.Win.C1InputPanel.InputButton()
        Me.botRelacao = New C1.Win.C1InputPanel.InputButton()
        Me.botFiltro = New C1.Win.C1InputPanel.InputButton()
        Me.botSalvarEm = New C1.Win.C1InputPanel.InputButton()
        Me.botAprovar = New C1.Win.C1InputPanel.InputButton()
        Me.gridProcedimentos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel14 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader13 = New C1.Win.C1InputPanel.InputGroupHeader()
        CType(Me.C1InputPanel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProcedimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel15
        '
        Me.C1InputPanel15.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel15.Items.Add(Me.InputGroupHeader14)
        Me.C1InputPanel15.Items.Add(Me.botNovo)
        Me.C1InputPanel15.Items.Add(Me.botEdit)
        Me.C1InputPanel15.Items.Add(Me.botRevisao)
        Me.C1InputPanel15.Items.Add(Me.botCancelar)
        Me.C1InputPanel15.Items.Add(Me.botRelacao)
        Me.C1InputPanel15.Items.Add(Me.botFiltro)
        Me.C1InputPanel15.Items.Add(Me.botSalvarEm)
        Me.C1InputPanel15.Items.Add(Me.botAprovar)
        Me.C1InputPanel15.Location = New System.Drawing.Point(0, 385)
        Me.C1InputPanel15.Name = "C1InputPanel15"
        Me.C1InputPanel15.Size = New System.Drawing.Size(924, 64)
        Me.C1InputPanel15.TabIndex = 31
        '
        'InputGroupHeader14
        '
        Me.InputGroupHeader14.Name = "InputGroupHeader14"
        Me.InputGroupHeader14.Text = "Cadastro de Documentos"
        '
        'botNovo
        '
        Me.botNovo.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botNovo.Image = CType(resources.GetObject("botNovo.Image"), System.Drawing.Image)
        Me.botNovo.ImageSize = New System.Drawing.Size(20, 20)
        Me.botNovo.Name = "botNovo"
        Me.botNovo.Text = "Novo"
        Me.botNovo.Width = 70
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
        'botRevisao
        '
        Me.botRevisao.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botRevisao.Image = CType(resources.GetObject("botRevisao.Image"), System.Drawing.Image)
        Me.botRevisao.ImageSize = New System.Drawing.Size(20, 20)
        Me.botRevisao.Name = "botRevisao"
        Me.botRevisao.Text = "Revisar"
        Me.botRevisao.Width = 70
        '
        'botCancelar
        '
        Me.botCancelar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Image)
        Me.botCancelar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Text = "Cancelar"
        '
        'botRelacao
        '
        Me.botRelacao.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botRelacao.Enabled = False
        Me.botRelacao.Image = CType(resources.GetObject("botRelacao.Image"), System.Drawing.Image)
        Me.botRelacao.ImageSize = New System.Drawing.Size(20, 20)
        Me.botRelacao.Name = "botRelacao"
        Me.botRelacao.Text = "Relação"
        '
        'botFiltro
        '
        Me.botFiltro.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botFiltro.Enabled = False
        Me.botFiltro.Image = CType(resources.GetObject("botFiltro.Image"), System.Drawing.Image)
        Me.botFiltro.ImageSize = New System.Drawing.Size(20, 20)
        Me.botFiltro.Name = "botFiltro"
        Me.botFiltro.Text = "Filtro"
        Me.botFiltro.Width = 70
        '
        'botSalvarEm
        '
        Me.botSalvarEm.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botSalvarEm.Image = CType(resources.GetObject("botSalvarEm.Image"), System.Drawing.Image)
        Me.botSalvarEm.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarEm.Name = "botSalvarEm"
        Me.botSalvarEm.Text = "Salvar em"
        '
        'botAprovar
        '
        Me.botAprovar.Image = CType(resources.GetObject("botAprovar.Image"), System.Drawing.Image)
        Me.botAprovar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botAprovar.Name = "botAprovar"
        Me.botAprovar.Text = "Aprovar"
        '
        'gridProcedimentos
        '
        Me.gridProcedimentos.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridProcedimentos.AllowEditing = False
        Me.gridProcedimentos.AllowFiltering = True
        Me.gridProcedimentos.ColumnInfo = resources.GetString("gridProcedimentos.ColumnInfo")
        Me.gridProcedimentos.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridProcedimentos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridProcedimentos.Location = New System.Drawing.Point(0, 24)
        Me.gridProcedimentos.Name = "gridProcedimentos"
        Me.gridProcedimentos.Rows.DefaultSize = 21
        Me.gridProcedimentos.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridProcedimentos.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridProcedimentos.Size = New System.Drawing.Size(920, 355)
        Me.gridProcedimentos.StyleInfo = resources.GetString("gridProcedimentos.StyleInfo")
        Me.gridProcedimentos.TabIndex = 30
        Me.gridProcedimentos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel14
        '
        Me.C1InputPanel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel14.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel14.Items.Add(Me.InputGroupHeader13)
        Me.C1InputPanel14.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel14.Name = "C1InputPanel14"
        Me.C1InputPanel14.Size = New System.Drawing.Size(924, 379)
        Me.C1InputPanel14.TabIndex = 29
        '
        'InputGroupHeader13
        '
        Me.InputGroupHeader13.Name = "InputGroupHeader13"
        Me.InputGroupHeader13.Text = "Relação de Documentos                                                            " & _
    "                                                                                " & _
    "       Filtrar por:"
        '
        'docElaborar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 451)
        Me.Controls.Add(Me.C1InputPanel15)
        Me.Controls.Add(Me.gridProcedimentos)
        Me.Controls.Add(Me.C1InputPanel14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "docElaborar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elaborar Documento"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProcedimentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel15 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader14 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botNovo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEdit As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botRevisao As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botCancelar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botRelacao As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botFiltro As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botSalvarEm As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botAprovar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents gridProcedimentos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel14 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader13 As C1.Win.C1InputPanel.InputGroupHeader
End Class
