<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cotrCadHabilidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cotrCadHabilidades))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblHabilidade = New C1.Win.C1InputPanel.InputLabel()
        Me.txtHabilidade = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblMetodo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtMetodo = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblResultado = New C1.Win.C1InputPanel.InputLabel()
        Me.txtResultado = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblResponsavel = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbResponsavel = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblData = New C1.Win.C1InputPanel.InputLabel()
        Me.dtData = New C1.Win.C1InputPanel.InputDatePicker()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 151)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(599, 64)
        Me.C1InputPanel2.TabIndex = 3
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
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
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.lblHabilidade)
        Me.C1InputPanel1.Items.Add(Me.txtHabilidade)
        Me.C1InputPanel1.Items.Add(Me.lblMetodo)
        Me.C1InputPanel1.Items.Add(Me.txtMetodo)
        Me.C1InputPanel1.Items.Add(Me.lblResultado)
        Me.C1InputPanel1.Items.Add(Me.txtResultado)
        Me.C1InputPanel1.Items.Add(Me.lblResponsavel)
        Me.C1InputPanel1.Items.Add(Me.cmbResponsavel)
        Me.C1InputPanel1.Items.Add(Me.lblData)
        Me.C1InputPanel1.Items.Add(Me.dtData)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 3)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(598, 150)
        Me.C1InputPanel1.TabIndex = 2
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Cadastrar Habilidades"
        '
        'lblHabilidade
        '
        Me.lblHabilidade.Name = "lblHabilidade"
        Me.lblHabilidade.Text = "Habilidade"
        Me.lblHabilidade.Width = 109
        '
        'txtHabilidade
        '
        Me.txtHabilidade.Name = "txtHabilidade"
        Me.txtHabilidade.Width = 450
        '
        'lblMetodo
        '
        Me.lblMetodo.Name = "lblMetodo"
        Me.lblMetodo.Text = "Método"
        Me.lblMetodo.Width = 109
        '
        'txtMetodo
        '
        Me.txtMetodo.Name = "txtMetodo"
        Me.txtMetodo.Width = 450
        '
        'lblResultado
        '
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Text = "Resultado"
        Me.lblResultado.Width = 109
        '
        'txtResultado
        '
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Width = 450
        '
        'lblResponsavel
        '
        Me.lblResponsavel.Name = "lblResponsavel"
        Me.lblResponsavel.Text = "Responsável"
        Me.lblResponsavel.Width = 109
        '
        'cmbResponsavel
        '
        Me.cmbResponsavel.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbResponsavel.Name = "cmbResponsavel"
        Me.cmbResponsavel.Width = 450
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Text = "Data"
        Me.lblData.Width = 109
        '
        'dtData
        '
        Me.dtData.Name = "dtData"
        Me.dtData.Width = 109
        '
        'cotrCadHabilidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 213)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "cotrCadHabilidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Habilidades"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblHabilidade As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtHabilidade As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblMetodo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtMetodo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblResultado As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtResultado As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblResponsavel As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbResponsavel As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblData As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtData As C1.Win.C1InputPanel.InputDatePicker
End Class
