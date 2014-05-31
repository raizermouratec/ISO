<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forCadRequisitos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forCadRequisitos))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblRequisitos = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRequisitos = New C1.Win.C1InputPanel.InputTextBox()
        Me.botAdd = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.gridRequisitos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.Erro = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        Me.TooltipErro = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRequisitos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Erro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.lblRequisitos)
        Me.C1InputPanel1.Items.Add(Me.txtRequisitos)
        Me.C1InputPanel1.Items.Add(Me.botAdd)
        Me.C1InputPanel1.Location = New System.Drawing.Point(-1, 1)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(593, 58)
        Me.C1InputPanel1.TabIndex = 31
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Adcionar Requisitos"
        '
        'lblRequisitos
        '
        Me.lblRequisitos.Name = "lblRequisitos"
        Me.lblRequisitos.Text = "Requisito"
        Me.lblRequisitos.Width = 80
        '
        'txtRequisitos
        '
        Me.txtRequisitos.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtRequisitos.Name = "txtRequisitos"
        Me.txtRequisitos.Width = 422
        '
        'botAdd
        '
        Me.botAdd.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botAdd.Image = CType(resources.GetObject("botAdd.Image"), System.Drawing.Image)
        Me.botAdd.ImageSize = New System.Drawing.Size(20, 20)
        Me.botAdd.Name = "botAdd"
        Me.botAdd.Text = "Incluir"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Location = New System.Drawing.Point(-1, 65)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(593, 278)
        Me.C1InputPanel2.TabIndex = 32
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Lista de Requisitos"
        '
        'gridRequisitos
        '
        Me.gridRequisitos.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridRequisitos.AllowEditing = False
        Me.gridRequisitos.ColumnInfo = "3,1,0,0,0,105,Columns:0{Width:0;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:0;Name:""CODIGO"";Caption:""Código"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Wi" & _
    "dth:540;Name:""DESCRICAO"";Caption:""Requisito"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.gridRequisitos.ExtendLastCol = True
        Me.gridRequisitos.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridRequisitos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridRequisitos.Location = New System.Drawing.Point(4, 95)
        Me.gridRequisitos.Name = "gridRequisitos"
        Me.gridRequisitos.Rows.Count = 1
        Me.gridRequisitos.Rows.DefaultSize = 21
        Me.gridRequisitos.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridRequisitos.Size = New System.Drawing.Size(577, 241)
        Me.gridRequisitos.StyleInfo = resources.GetString("gridRequisitos.StyleInfo")
        Me.gridRequisitos.TabIndex = 33
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel3.Items.Add(Me.botEditar)
        Me.C1InputPanel3.Items.Add(Me.botExcluir)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 342)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(593, 59)
        Me.C1InputPanel3.TabIndex = 34
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Opções"
        '
        'botEditar
        '
        Me.botEditar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botEditar.Image = CType(resources.GetObject("botEditar.Image"), System.Drawing.Image)
        Me.botEditar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botEditar.Name = "botEditar"
        Me.botEditar.Text = "Editar"
        Me.botEditar.Width = 70
        '
        'botExcluir
        '
        Me.botExcluir.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botExcluir.Image = CType(resources.GetObject("botExcluir.Image"), System.Drawing.Image)
        Me.botExcluir.ImageSize = New System.Drawing.Size(20, 20)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Text = "Excluir"
        Me.botExcluir.Width = 70
        '
        'Erro
        '
        Me.Erro.ContainerControl = Me
        Me.Erro.ToolTip = Me.TooltipErro
        '
        'TooltipErro
        '
        Me.TooltipErro.Font = New System.Drawing.Font("Tahoma", 8.0!)
        '
        'forCadRequisitos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 401)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.gridRequisitos)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "forCadRequisitos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Requisitos"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRequisitos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Erro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblRequisitos As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtRequisitos As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents botAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents gridRequisitos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents Erro As C1.Win.C1SuperTooltip.C1SuperErrorProvider
    Friend WithEvents TooltipErro As C1.Win.C1SuperTooltip.C1SuperTooltip
End Class
