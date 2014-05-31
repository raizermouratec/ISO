<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class audNaoConformidade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(audNaoConformidade))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblNaoConformidade = New C1.Win.C1InputPanel.InputLabel()
        Me.comboNaoConformidade = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.gridNCapontadas = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.botAdicionar = New C1.Win.C1InputPanel.InputButton()
        Me.botRemover = New C1.Win.C1InputPanel.InputButton()
        Me.botRegistrarNC = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridNCapontadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.lblNaoConformidade)
        Me.C1InputPanel1.Items.Add(Me.comboNaoConformidade)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Location = New System.Drawing.Point(-1, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(591, 273)
        Me.C1InputPanel1.TabIndex = 0
        '
        'lblNaoConformidade
        '
        Me.lblNaoConformidade.Name = "lblNaoConformidade"
        Me.lblNaoConformidade.Text = "Não Conformidade"
        Me.lblNaoConformidade.Width = 115
        '
        'comboNaoConformidade
        '
        Me.comboNaoConformidade.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboNaoConformidade.Height = 25
        Me.comboNaoConformidade.Name = "comboNaoConformidade"
        Me.comboNaoConformidade.Width = 458
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Lista de Não Conformidades"
        '
        'gridNCapontadas
        '
        Me.gridNCapontadas.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridNCapontadas.AllowEditing = False
        Me.gridNCapontadas.AllowFiltering = True
        Me.gridNCapontadas.ColumnInfo = resources.GetString("gridNCapontadas.ColumnInfo")
        Me.gridNCapontadas.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridNCapontadas.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridNCapontadas.Location = New System.Drawing.Point(-1, 57)
        Me.gridNCapontadas.Name = "gridNCapontadas"
        Me.gridNCapontadas.Rows.DefaultSize = 21
        Me.gridNCapontadas.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridNCapontadas.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridNCapontadas.Size = New System.Drawing.Size(591, 214)
        Me.gridNCapontadas.StyleInfo = resources.GetString("gridNCapontadas.StyleInfo")
        Me.gridNCapontadas.TabIndex = 1
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Items.Add(Me.botAdicionar)
        Me.C1InputPanel2.Items.Add(Me.botRemover)
        Me.C1InputPanel2.Items.Add(Me.botRegistrarNC)
        Me.C1InputPanel2.Location = New System.Drawing.Point(-1, 271)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(591, 62)
        Me.C1InputPanel2.TabIndex = 25
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Opções"
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
        'botAdicionar
        '
        Me.botAdicionar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botAdicionar.Image = CType(resources.GetObject("botAdicionar.Image"), System.Drawing.Image)
        Me.botAdicionar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botAdicionar.Name = "botAdicionar"
        Me.botAdicionar.Text = "Adicionar"
        '
        'botRemover
        '
        Me.botRemover.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botRemover.Image = CType(resources.GetObject("botRemover.Image"), System.Drawing.Image)
        Me.botRemover.ImageSize = New System.Drawing.Size(20, 20)
        Me.botRemover.Name = "botRemover"
        Me.botRemover.Text = "Remover"
        '
        'botRegistrarNC
        '
        Me.botRegistrarNC.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botRegistrarNC.Image = CType(resources.GetObject("botRegistrarNC.Image"), System.Drawing.Image)
        Me.botRegistrarNC.ImageSize = New System.Drawing.Size(20, 20)
        Me.botRegistrarNC.Name = "botRegistrarNC"
        Me.botRegistrarNC.Text = "Registrar NC"
        '
        'audNaoConformidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 333)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.gridNCapontadas)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "audNaoConformidade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Não Conformidades Apontadas"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridNCapontadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents lblNaoConformidade As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboNaoConformidade As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents gridNCapontadas As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botAdicionar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botRemover As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botRegistrarNC As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
End Class
