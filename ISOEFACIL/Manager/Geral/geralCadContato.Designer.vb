<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeralCadContato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeralCadContato))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblNome = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNome = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblCargo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtCargo = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblTel = New C1.Win.C1InputPanel.InputLabel()
        Me.txtTel = New C1.Win.C1InputPanel.InputMaskedTextBox()
        Me.lblCel = New C1.Win.C1InputPanel.InputLabel()
        Me.txtCel = New C1.Win.C1InputPanel.InputMaskedTextBox()
        Me.lblFax = New C1.Win.C1InputPanel.InputLabel()
        Me.txtFax = New C1.Win.C1InputPanel.InputMaskedTextBox()
        Me.lblEmail = New C1.Win.C1InputPanel.InputLabel()
        Me.txtEmail = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblSkype = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSkype = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.lblNome)
        Me.C1InputPanel1.Items.Add(Me.txtNome)
        Me.C1InputPanel1.Items.Add(Me.lblCargo)
        Me.C1InputPanel1.Items.Add(Me.txtCargo)
        Me.C1InputPanel1.Items.Add(Me.lblTel)
        Me.C1InputPanel1.Items.Add(Me.txtTel)
        Me.C1InputPanel1.Items.Add(Me.lblCel)
        Me.C1InputPanel1.Items.Add(Me.txtCel)
        Me.C1InputPanel1.Items.Add(Me.lblFax)
        Me.C1InputPanel1.Items.Add(Me.txtFax)
        Me.C1InputPanel1.Items.Add(Me.lblEmail)
        Me.C1InputPanel1.Items.Add(Me.txtEmail)
        Me.C1InputPanel1.Items.Add(Me.lblSkype)
        Me.C1InputPanel1.Items.Add(Me.txtSkype)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 2)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(441, 199)
        Me.C1InputPanel1.TabIndex = 0
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Cadastrar"
        '
        'lblNome
        '
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Text = "Nome"
        Me.lblNome.Width = 120
        '
        'txtNome
        '
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Width = 300
        '
        'lblCargo
        '
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Text = "Cargo"
        Me.lblCargo.Width = 120
        '
        'txtCargo
        '
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Width = 300
        '
        'lblTel
        '
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Text = "Telefone Fixo"
        Me.lblTel.Width = 120
        '
        'txtTel
        '
        Me.txtTel.Mask = "(00) 00000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Text = "(  )      -"
        '
        'lblCel
        '
        Me.lblCel.Name = "lblCel"
        Me.lblCel.Text = "Telefone Celular"
        Me.lblCel.Width = 120
        '
        'txtCel
        '
        Me.txtCel.Mask = "(00) 00000-0000"
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Text = "(  )      -"
        '
        'lblFax
        '
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Text = "Telefone Fax"
        Me.lblFax.Width = 120
        '
        'txtFax
        '
        Me.txtFax.Mask = "(00) 00000-0000"
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Text = "(  )      -"
        '
        'lblEmail
        '
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Text = "E-mail"
        Me.lblEmail.Width = 120
        '
        'txtEmail
        '
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Width = 300
        '
        'lblSkype
        '
        Me.lblSkype.Name = "lblSkype"
        Me.lblSkype.Text = "Skype"
        Me.lblSkype.Width = 120
        '
        'txtSkype
        '
        Me.txtSkype.Name = "txtSkype"
        Me.txtSkype.Width = 300
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 197)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(441, 61)
        Me.C1InputPanel2.TabIndex = 1
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Opções"
        '
        'botSalvar
        '
        Me.botSalvar.Image = CType(resources.GetObject("botSalvar.Image"), System.Drawing.Image)
        Me.botSalvar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvar.Name = "botSalvar"
        Me.botSalvar.Text = "Salvar"
        Me.botSalvar.Width = 70
        '
        'GeralCadContato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 259)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GeralCadContato"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Contato"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents lblNome As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNome As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblCargo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCargo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblTel As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtTel As C1.Win.C1InputPanel.InputMaskedTextBox
    Friend WithEvents lblCel As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCel As C1.Win.C1InputPanel.InputMaskedTextBox
    Friend WithEvents lblFax As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtFax As C1.Win.C1InputPanel.InputMaskedTextBox
    Friend WithEvents lblEmail As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtEmail As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblSkype As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtSkype As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
End Class
