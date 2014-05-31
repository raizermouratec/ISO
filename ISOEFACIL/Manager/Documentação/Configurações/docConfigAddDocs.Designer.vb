<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class docConfigAddDocs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(docConfigAddDocs))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoOpcoes = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtId = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNome = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbFormato = New C1.Win.C1InputPanel.InputComboBox()
        Me.optAnexar = New C1.Win.C1InputPanel.InputOption()
        Me.optGerar = New C1.Win.C1InputPanel.InputOption()
        Me.btAdd = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.grupoOpcoes)
        Me.C1InputPanel2.Items.Add(Me.InputLabel1)
        Me.C1InputPanel2.Items.Add(Me.txtId)
        Me.C1InputPanel2.Items.Add(Me.InputLabel2)
        Me.C1InputPanel2.Items.Add(Me.txtNome)
        Me.C1InputPanel2.Items.Add(Me.InputLabel3)
        Me.C1InputPanel2.Items.Add(Me.cmbFormato)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 1)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(444, 114)
        Me.C1InputPanel2.TabIndex = 13
        '
        'grupoOpcoes
        '
        Me.grupoOpcoes.Name = "grupoOpcoes"
        Me.grupoOpcoes.Text = "Opções"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Identificação"
        Me.InputLabel1.Width = 70
        '
        'txtId
        '
        Me.txtId.Name = "txtId"
        Me.txtId.Width = 122
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Nome"
        Me.InputLabel2.Width = 70
        '
        'txtNome
        '
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Width = 350
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Formato"
        Me.InputLabel3.Width = 70
        '
        'cmbFormato
        '
        Me.cmbFormato.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbFormato.Items.Add(Me.optAnexar)
        Me.cmbFormato.Items.Add(Me.optGerar)
        Me.cmbFormato.Name = "cmbFormato"
        Me.cmbFormato.Width = 122
        '
        'optAnexar
        '
        Me.optAnexar.Name = "optAnexar"
        Me.optAnexar.Text = "Anexar"
        '
        'optGerar
        '
        Me.optGerar.Name = "optGerar"
        Me.optGerar.Text = "Gerar pelo ISO"
        '
        'btAdd
        '
        Me.btAdd.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.ImageSize = New System.Drawing.Size(20, 20)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Text = "Salvar"
        Me.btAdd.Width = 70
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.btAdd)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 121)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(444, 58)
        Me.C1InputPanel1.TabIndex = 14
        '
        'docConfigAddDocs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 183)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "docConfigAddDocs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Tipo de Documento"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoOpcoes As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtId As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNome As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbFormato As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents optAnexar As C1.Win.C1InputPanel.InputOption
    Friend WithEvents optGerar As C1.Win.C1InputPanel.InputOption
End Class
