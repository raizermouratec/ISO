<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class docCadDocNovo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(docCadDocNovo))
        Me.InputNovoDoc = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbInputTipoDoc = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtInputTitudoDoc = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtInputCodDoc = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblArea = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbInputAreaDoc = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblTpImpre = New C1.Win.C1InputPanel.InputLabel()
        Me.radioRetrato = New C1.Win.C1InputPanel.InputRadioButton()
        Me.radioPaisagem = New C1.Win.C1InputPanel.InputRadioButton()
        Me.lblespaco = New C1.Win.C1InputPanel.InputLabel()
        Me.btInputSalvarDoc = New C1.Win.C1InputPanel.InputButton()
        Me.picDoc = New System.Windows.Forms.PictureBox()
        Me.C1StatusBar1 = New C1.Win.C1Ribbon.C1StatusBar()
        Me.barra = New C1.Win.C1Ribbon.RibbonProgressBar()
        Me.lblStatus = New C1.Win.C1Ribbon.RibbonLabel()
        CType(Me.InputNovoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1StatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputNovoDoc
        '
        Me.InputNovoDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InputNovoDoc.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.InputNovoDoc.Items.Add(Me.InputGroupHeader2)
        Me.InputNovoDoc.Items.Add(Me.InputLabel2)
        Me.InputNovoDoc.Items.Add(Me.cmbInputTipoDoc)
        Me.InputNovoDoc.Items.Add(Me.InputLabel1)
        Me.InputNovoDoc.Items.Add(Me.txtInputTitudoDoc)
        Me.InputNovoDoc.Items.Add(Me.InputLabel3)
        Me.InputNovoDoc.Items.Add(Me.txtInputCodDoc)
        Me.InputNovoDoc.Items.Add(Me.lblArea)
        Me.InputNovoDoc.Items.Add(Me.cmbInputAreaDoc)
        Me.InputNovoDoc.Items.Add(Me.lblTpImpre)
        Me.InputNovoDoc.Items.Add(Me.radioRetrato)
        Me.InputNovoDoc.Items.Add(Me.radioPaisagem)
        Me.InputNovoDoc.Items.Add(Me.lblespaco)
        Me.InputNovoDoc.Items.Add(Me.btInputSalvarDoc)
        Me.InputNovoDoc.Location = New System.Drawing.Point(0, 0)
        Me.InputNovoDoc.Name = "InputNovoDoc"
        Me.InputNovoDoc.Size = New System.Drawing.Size(485, 211)
        Me.InputNovoDoc.TabIndex = 29
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Novo Documento"
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Tipo"
        Me.InputLabel2.Width = 50
        '
        'cmbInputTipoDoc
        '
        Me.cmbInputTipoDoc.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbInputTipoDoc.Name = "cmbInputTipoDoc"
        Me.cmbInputTipoDoc.Width = 418
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Titulo"
        Me.InputLabel1.Width = 50
        '
        'txtInputTitudoDoc
        '
        Me.txtInputTitudoDoc.Name = "txtInputTitudoDoc"
        Me.txtInputTitudoDoc.Width = 417
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Código"
        Me.InputLabel3.Width = 50
        '
        'txtInputCodDoc
        '
        Me.txtInputCodDoc.Enabled = False
        Me.txtInputCodDoc.Name = "txtInputCodDoc"
        Me.txtInputCodDoc.Width = 200
        '
        'lblArea
        '
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Text = "Área"
        Me.lblArea.Width = 50
        '
        'cmbInputAreaDoc
        '
        Me.cmbInputAreaDoc.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbInputAreaDoc.Name = "cmbInputAreaDoc"
        Me.cmbInputAreaDoc.Width = 200
        '
        'lblTpImpre
        '
        Me.lblTpImpre.Name = "lblTpImpre"
        Me.lblTpImpre.Text = "Tipo Impressão"
        Me.lblTpImpre.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblTpImpre.Width = 90
        '
        'radioRetrato
        '
        Me.radioRetrato.Break = C1.Win.C1InputPanel.BreakType.None
        Me.radioRetrato.Name = "radioRetrato"
        Me.radioRetrato.Text = "Retrato   "
        Me.radioRetrato.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.radioRetrato.Width = 87
        '
        'radioPaisagem
        '
        Me.radioPaisagem.Name = "radioPaisagem"
        Me.radioPaisagem.Text = "Paisagem"
        Me.radioPaisagem.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        '
        'lblespaco
        '
        Me.lblespaco.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.lblespaco.Name = "lblespaco"
        '
        'btInputSalvarDoc
        '
        Me.btInputSalvarDoc.Image = CType(resources.GetObject("btInputSalvarDoc.Image"), System.Drawing.Image)
        Me.btInputSalvarDoc.ImageSize = New System.Drawing.Size(20, 20)
        Me.btInputSalvarDoc.Name = "btInputSalvarDoc"
        Me.btInputSalvarDoc.Text = "Salvar"
        Me.btInputSalvarDoc.Width = 70
        '
        'picDoc
        '
        Me.picDoc.Location = New System.Drawing.Point(445, 160)
        Me.picDoc.Name = "picDoc"
        Me.picDoc.Size = New System.Drawing.Size(28, 22)
        Me.picDoc.TabIndex = 30
        Me.picDoc.TabStop = False
        Me.picDoc.Visible = False
        '
        'C1StatusBar1
        '
        Me.C1StatusBar1.LeftPaneItems.Add(Me.barra)
        Me.C1StatusBar1.LeftPaneItems.Add(Me.lblStatus)
        Me.C1StatusBar1.Name = "C1StatusBar1"
        '
        'barra
        '
        Me.barra.Height = 20
        Me.barra.Name = "barra"
        Me.barra.Width = 200
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        '
        'docCadDocNovo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 211)
        Me.Controls.Add(Me.C1StatusBar1)
        Me.Controls.Add(Me.picDoc)
        Me.Controls.Add(Me.InputNovoDoc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "docCadDocNovo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Novo Documento"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.InputNovoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1StatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputNovoDoc As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbInputTipoDoc As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtInputTitudoDoc As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtInputCodDoc As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btInputSalvarDoc As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblespaco As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTpImpre As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents radioRetrato As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents radioPaisagem As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents picDoc As System.Windows.Forms.PictureBox
    Friend WithEvents lblArea As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbInputAreaDoc As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents C1StatusBar1 As C1.Win.C1Ribbon.C1StatusBar
    Friend WithEvents barra As C1.Win.C1Ribbon.RibbonProgressBar
    Friend WithEvents lblStatus As C1.Win.C1Ribbon.RibbonLabel
End Class
