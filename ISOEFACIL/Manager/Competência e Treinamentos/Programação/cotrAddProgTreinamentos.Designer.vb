<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cotrAddProgTreinamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cotrAddProgTreinamentos))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblAcao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAcao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblAno = New C1.Win.C1InputPanel.InputLabel()
        Me.InputDatePicker1 = New C1.Win.C1InputPanel.InputDatePicker()
        Me.dtAno = New System.Windows.Forms.DateTimePicker()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 81)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(384, 65)
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
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.lblAcao)
        Me.C1InputPanel1.Items.Add(Me.txtAcao)
        Me.C1InputPanel1.Items.Add(Me.lblAno)
        Me.C1InputPanel1.Items.Add(Me.InputDatePicker1)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 3)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(384, 80)
        Me.C1InputPanel1.TabIndex = 2
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Cadastrar Ação de Capacitação"
        '
        'lblAcao
        '
        Me.lblAcao.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblAcao.Name = "lblAcao"
        Me.lblAcao.Text = "Ação"
        '
        'txtAcao
        '
        Me.txtAcao.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.txtAcao.Name = "txtAcao"
        Me.txtAcao.Width = 321
        '
        'lblAno
        '
        Me.lblAno.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Text = "Ano"
        Me.lblAno.Width = 27
        '
        'InputDatePicker1
        '
        Me.InputDatePicker1.Name = "InputDatePicker1"
        '
        'dtAno
        '
        Me.dtAno.CustomFormat = "yyyy"
        Me.dtAno.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dtAno.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAno.Location = New System.Drawing.Point(49, 54)
        Me.dtAno.Name = "dtAno"
        Me.dtAno.ShowUpDown = True
        Me.dtAno.Size = New System.Drawing.Size(99, 22)
        Me.dtAno.TabIndex = 25
        '
        'cotrAddProgTreinamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 146)
        Me.Controls.Add(Me.dtAno)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cotrAddProgTreinamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Programação de Treinamentos"
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
    Friend WithEvents lblAcao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAcao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblAno As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputDatePicker1 As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents dtAno As System.Windows.Forms.DateTimePicker
End Class
