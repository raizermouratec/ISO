<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class audAddProgAuditorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(audAddProgAuditorias))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoAdicionar = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblArea_Setor = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbAreaSetor = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblAno = New C1.Win.C1InputPanel.InputLabel()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.dtAno = New System.Windows.Forms.DateTimePicker()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.grupoAdicionar)
        Me.C1InputPanel1.Items.Add(Me.lblArea_Setor)
        Me.C1InputPanel1.Items.Add(Me.cmbAreaSetor)
        Me.C1InputPanel1.Items.Add(Me.lblAno)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(392, 85)
        Me.C1InputPanel1.TabIndex = 0
        '
        'grupoAdicionar
        '
        Me.grupoAdicionar.Name = "grupoAdicionar"
        Me.grupoAdicionar.Text = "Adicionar Auditoria"
        '
        'lblArea_Setor
        '
        Me.lblArea_Setor.Height = 15
        Me.lblArea_Setor.Name = "lblArea_Setor"
        Me.lblArea_Setor.Text = "Área / Setor "
        '
        'cmbAreaSetor
        '
        Me.cmbAreaSetor.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbAreaSetor.Name = "cmbAreaSetor"
        Me.cmbAreaSetor.Width = 305
        '
        'lblAno
        '
        Me.lblAno.Height = 15
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Text = "Ano"
        Me.lblAno.Width = 62
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 93)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(392, 63)
        Me.C1InputPanel2.TabIndex = 22
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Opções"
        '
        'botSalvar
        '
        Me.botSalvar.Image = CType(resources.GetObject("botSalvar.Image"), System.Drawing.Image)
        Me.botSalvar.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvar.Name = "botSalvar"
        Me.botSalvar.Text = "Salvar"
        Me.botSalvar.Width = 70
        '
        'dtAno
        '
        Me.dtAno.CustomFormat = "yyyy"
        Me.dtAno.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dtAno.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAno.Location = New System.Drawing.Point(77, 52)
        Me.dtAno.Name = "dtAno"
        Me.dtAno.ShowUpDown = True
        Me.dtAno.Size = New System.Drawing.Size(91, 22)
        Me.dtAno.TabIndex = 24
        '
        'audAddProgAuditorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 159)
        Me.Controls.Add(Me.dtAno)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "audAddProgAuditorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Programação de Auditoria"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoAdicionar As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblArea_Setor As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAno As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents cmbAreaSetor As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents dtAno As System.Windows.Forms.DateTimePicker
End Class
