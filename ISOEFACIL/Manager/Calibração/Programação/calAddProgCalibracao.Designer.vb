<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calAddProgCalibracao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calAddProgCalibracao))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grup01 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblRealizacao = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbRealizacao = New C1.Win.C1InputPanel.InputComboBox()
        Me.optInt = New C1.Win.C1InputPanel.InputOption()
        Me.optExt = New C1.Win.C1InputPanel.InputOption()
        Me.lblAno = New C1.Win.C1InputPanel.InputLabel()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.gridInst = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.dtAno = New System.Windows.Forms.DateTimePicker()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridInst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.grup01)
        Me.C1InputPanel2.Items.Add(Me.lblRealizacao)
        Me.C1InputPanel2.Items.Add(Me.cmbRealizacao)
        Me.C1InputPanel2.Items.Add(Me.lblAno)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 2)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(471, 56)
        Me.C1InputPanel2.TabIndex = 4
        '
        'grup01
        '
        Me.grup01.Name = "grup01"
        Me.grup01.Text = "Calibração"
        '
        'lblRealizacao
        '
        Me.lblRealizacao.Name = "lblRealizacao"
        Me.lblRealizacao.Text = "Realização"
        '
        'cmbRealizacao
        '
        Me.cmbRealizacao.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbRealizacao.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbRealizacao.Items.Add(Me.optInt)
        Me.cmbRealizacao.Items.Add(Me.optExt)
        Me.cmbRealizacao.Name = "cmbRealizacao"
        Me.cmbRealizacao.Width = 269
        '
        'optInt
        '
        Me.optInt.Name = "optInt"
        Me.optInt.Text = "Interna"
        '
        'optExt
        '
        Me.optExt.Name = "optExt"
        Me.optExt.Text = "Externa"
        '
        'lblAno
        '
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Text = "Ano"
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 55)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(471, 265)
        Me.C1InputPanel1.TabIndex = 5
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Lista de Instrumentos"
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel4.Items.Add(Me.botSalvar)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 321)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(471, 60)
        Me.C1InputPanel4.TabIndex = 21
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
        'gridInst
        '
        Me.gridInst.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridInst.AllowEditing = False
        Me.gridInst.ColumnInfo = "4,1,0,0,0,105,Columns:0{Width:0;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:1;Name:""ID"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:83;Name:""IDENTIFI" & _
    "CACAO"";Caption:""Identificação"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Width:344;Name:""NOME"";Caption:""Nome"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.gridInst.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridInst.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridInst.Location = New System.Drawing.Point(0, 80)
        Me.gridInst.Name = "gridInst"
        Me.gridInst.Rows.DefaultSize = 21
        Me.gridInst.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridInst.Size = New System.Drawing.Size(471, 240)
        Me.gridInst.StyleInfo = resources.GetString("gridInst.StyleInfo")
        Me.gridInst.TabIndex = 22
        '
        'dtAno
        '
        Me.dtAno.CustomFormat = "yyyy"
        Me.dtAno.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dtAno.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAno.Location = New System.Drawing.Point(372, 27)
        Me.dtAno.Name = "dtAno"
        Me.dtAno.ShowUpDown = True
        Me.dtAno.Size = New System.Drawing.Size(91, 22)
        Me.dtAno.TabIndex = 23
        '
        'calAddProgCalibracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 381)
        Me.Controls.Add(Me.dtAno)
        Me.Controls.Add(Me.gridInst)
        Me.Controls.Add(Me.C1InputPanel4)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "calAddProgCalibracao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Programação de Calibração"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridInst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grup01 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblRealizacao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbRealizacao As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblAno As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents gridInst As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents optInt As C1.Win.C1InputPanel.InputOption
    Friend WithEvents optExt As C1.Win.C1InputPanel.InputOption
    Friend WithEvents dtAno As System.Windows.Forms.DateTimePicker
End Class
