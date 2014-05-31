<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forCadPerfil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forCadPerfil))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblPerfil = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNome = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.botAdd = New C1.Win.C1InputPanel.InputButton()
        Me.gridRequisitos = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRequisitos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.lblPerfil)
        Me.C1InputPanel1.Items.Add(Me.txtNome)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(593, 57)
        Me.C1InputPanel1.TabIndex = 32
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Adcionar Requisitos"
        '
        'lblPerfil
        '
        Me.lblPerfil.Name = "lblPerfil"
        Me.lblPerfil.Text = "Perfil"
        Me.lblPerfil.Width = 100
        Me.lblPerfil.WordWrap = False
        '
        'txtNome
        '
        Me.txtNome.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Width = 469
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 57)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(593, 284)
        Me.C1InputPanel2.TabIndex = 33
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Lista de Requisitos"
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel3.Items.Add(Me.botSalvar)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 341)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(593, 59)
        Me.C1InputPanel3.TabIndex = 35
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Opções"
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
        'botAdd
        '
        Me.botAdd.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botAdd.Image = CType(resources.GetObject("botAdd.Image"), System.Drawing.Image)
        Me.botAdd.ImageSize = New System.Drawing.Size(20, 20)
        Me.botAdd.Name = "botAdd"
        Me.botAdd.Text = "Incluir"
        Me.botAdd.Width = 80
        '
        'gridRequisitos
        '
        Me.gridRequisitos.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridRequisitos.AllowEditing = False
        Me.gridRequisitos.ColumnInfo = resources.GetString("gridRequisitos.ColumnInfo")
        Me.gridRequisitos.ExtendLastCol = True
        Me.gridRequisitos.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridRequisitos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridRequisitos.Location = New System.Drawing.Point(12, 87)
        Me.gridRequisitos.Name = "gridRequisitos"
        Me.gridRequisitos.Rows.DefaultSize = 21
        Me.gridRequisitos.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridRequisitos.Size = New System.Drawing.Size(569, 248)
        Me.gridRequisitos.StyleInfo = resources.GetString("gridRequisitos.StyleInfo")
        Me.gridRequisitos.TabIndex = 36
        Me.gridRequisitos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'forCadPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 401)
        Me.Controls.Add(Me.gridRequisitos)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "forCadPerfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Perfil"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRequisitos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblPerfil As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNome As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents gridRequisitos As C1.Win.C1FlexGrid.C1FlexGrid
End Class
