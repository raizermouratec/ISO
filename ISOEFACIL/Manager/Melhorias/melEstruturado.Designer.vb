<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class melEstruturado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(melEstruturado))
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.Aba1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtOque = New C1.Win.C1Input.C1TextBox()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblOque = New C1.Win.C1InputPanel.InputLabel()
        Me.txtOqueOutro = New C1.Win.C1InputPanel.InputTextBox()
        Me.Aba2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtComo = New C1.Win.C1Input.C1TextBox()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblComo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtComoOutro = New C1.Win.C1InputPanel.InputTextBox()
        Me.Aba3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.inpultData = New C1.Win.C1InputPanel.C1InputPanel()
        Me.dateQuando = New C1.Win.C1InputPanel.InputDatePicker()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.checkData = New C1.Win.C1InputPanel.InputCheckBox()
        Me.lblQuando = New C1.Win.C1InputPanel.InputLabel()
        Me.txtQuando = New C1.Win.C1InputPanel.InputTextBox()
        Me.Aba4 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblQuem = New C1.Win.C1InputPanel.InputLabel()
        Me.comboQuem = New C1.Win.C1InputPanel.InputComboBox()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarEstruturado = New C1.Win.C1InputPanel.InputButton()
        Me.Aba5 = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtResultados = New C1.Win.C1Input.C1TextBox()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblResultados = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox1 = New C1.Win.C1InputPanel.InputTextBox()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.Aba1.SuspendLayout()
        CType(Me.txtOque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Aba2.SuspendLayout()
        CType(Me.txtComo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Aba3.SuspendLayout()
        CType(Me.inpultData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Aba4.SuspendLayout()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Aba5.SuspendLayout()
        CType(Me.txtResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.Aba1)
        Me.C1DockingTab1.Controls.Add(Me.Aba2)
        Me.C1DockingTab1.Controls.Add(Me.Aba3)
        Me.C1DockingTab1.Controls.Add(Me.Aba4)
        Me.C1DockingTab1.Controls.Add(Me.Aba5)
        Me.C1DockingTab1.Location = New System.Drawing.Point(3, 7)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.Padding = New System.Drawing.Point(30, 4)
        Me.C1DockingTab1.SelectedIndex = 3
        Me.C1DockingTab1.Size = New System.Drawing.Size(745, 123)
        Me.C1DockingTab1.TabIndex = 2
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'Aba1
        '
        Me.Aba1.Controls.Add(Me.txtOque)
        Me.Aba1.Controls.Add(Me.C1InputPanel2)
        Me.Aba1.Location = New System.Drawing.Point(1, 28)
        Me.Aba1.Name = "Aba1"
        Me.Aba1.Size = New System.Drawing.Size(743, 94)
        Me.Aba1.TabIndex = 0
        Me.Aba1.Text = "O que"
        '
        'txtOque
        '
        Me.txtOque.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtOque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOque.Location = New System.Drawing.Point(56, 5)
        Me.txtOque.Multiline = True
        Me.txtOque.Name = "txtOque"
        Me.txtOque.Size = New System.Drawing.Size(680, 84)
        Me.txtOque.TabIndex = 4
        Me.txtOque.Tag = Nothing
        Me.txtOque.TextDetached = True
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.lblOque)
        Me.C1InputPanel2.Items.Add(Me.txtOqueOutro)
        Me.C1InputPanel2.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(737, 89)
        Me.C1InputPanel2.TabIndex = 0
        '
        'lblOque
        '
        Me.lblOque.Name = "lblOque"
        Me.lblOque.Text = "O que :"
        '
        'txtOqueOutro
        '
        Me.txtOqueOutro.Height = 69
        Me.txtOqueOutro.Multiline = True
        Me.txtOqueOutro.Name = "txtOqueOutro"
        Me.txtOqueOutro.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtOqueOutro.Width = 680
        '
        'Aba2
        '
        Me.Aba2.Controls.Add(Me.txtComo)
        Me.Aba2.Controls.Add(Me.C1InputPanel3)
        Me.Aba2.Location = New System.Drawing.Point(1, 28)
        Me.Aba2.Name = "Aba2"
        Me.Aba2.Size = New System.Drawing.Size(743, 94)
        Me.Aba2.TabIndex = 1
        Me.Aba2.Text = "Como"
        '
        'txtComo
        '
        Me.txtComo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtComo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComo.Location = New System.Drawing.Point(56, 6)
        Me.txtComo.Multiline = True
        Me.txtComo.Name = "txtComo"
        Me.txtComo.Size = New System.Drawing.Size(680, 84)
        Me.txtComo.TabIndex = 4
        Me.txtComo.Tag = Nothing
        Me.txtComo.TextDetached = True
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.lblComo)
        Me.C1InputPanel3.Items.Add(Me.txtComoOutro)
        Me.C1InputPanel3.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(737, 89)
        Me.C1InputPanel3.TabIndex = 1
        '
        'lblComo
        '
        Me.lblComo.Name = "lblComo"
        Me.lblComo.Text = "Como :"
        '
        'txtComoOutro
        '
        Me.txtComoOutro.Height = 69
        Me.txtComoOutro.Multiline = True
        Me.txtComoOutro.Name = "txtComoOutro"
        Me.txtComoOutro.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtComoOutro.Width = 680
        '
        'Aba3
        '
        Me.Aba3.Controls.Add(Me.inpultData)
        Me.Aba3.Controls.Add(Me.C1InputPanel4)
        Me.Aba3.Location = New System.Drawing.Point(1, 28)
        Me.Aba3.Name = "Aba3"
        Me.Aba3.Size = New System.Drawing.Size(743, 94)
        Me.Aba3.TabIndex = 2
        Me.Aba3.Text = "Quando"
        '
        'inpultData
        '
        Me.inpultData.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.inpultData.Items.Add(Me.dateQuando)
        Me.inpultData.Location = New System.Drawing.Point(62, 45)
        Me.inpultData.Name = "inpultData"
        Me.inpultData.Size = New System.Drawing.Size(113, 30)
        Me.inpultData.TabIndex = 1
        Me.inpultData.Visible = False
        '
        'dateQuando
        '
        Me.dateQuando.Name = "dateQuando"
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel4.Items.Add(Me.checkData)
        Me.C1InputPanel4.Items.Add(Me.lblQuando)
        Me.C1InputPanel4.Items.Add(Me.txtQuando)
        Me.C1InputPanel4.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(737, 89)
        Me.C1InputPanel4.TabIndex = 1
        '
        'checkData
        '
        Me.checkData.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.checkData.Name = "checkData"
        Me.checkData.Padding = New System.Windows.Forms.Padding(2, 10, 2, 2)
        Me.checkData.Text = "Data"
        '
        'lblQuando
        '
        Me.lblQuando.Height = 50
        Me.lblQuando.Name = "lblQuando"
        Me.lblQuando.Text = "Quando :"
        Me.lblQuando.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblQuando.Width = 57
        '
        'txtQuando
        '
        Me.txtQuando.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtQuando.Height = 34
        Me.txtQuando.Multiline = True
        Me.txtQuando.Name = "txtQuando"
        Me.txtQuando.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.txtQuando.Width = 511
        '
        'Aba4
        '
        Me.Aba4.Controls.Add(Me.C1InputPanel5)
        Me.Aba4.Location = New System.Drawing.Point(1, 28)
        Me.Aba4.Name = "Aba4"
        Me.Aba4.Size = New System.Drawing.Size(743, 94)
        Me.Aba4.TabIndex = 3
        Me.Aba4.Text = "Quem"
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel5.Items.Add(Me.lblQuem)
        Me.C1InputPanel5.Items.Add(Me.comboQuem)
        Me.C1InputPanel5.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(737, 89)
        Me.C1InputPanel5.TabIndex = 1
        '
        'lblQuem
        '
        Me.lblQuem.Height = 70
        Me.lblQuem.Name = "lblQuem"
        Me.lblQuem.Text = "Quem :"
        Me.lblQuem.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        '
        'comboQuem
        '
        Me.comboQuem.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboQuem.Name = "comboQuem"
        Me.comboQuem.Width = 643
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel6.Items.Add(Me.botSalvarEstruturado)
        Me.C1InputPanel6.Location = New System.Drawing.Point(2, 130)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(745, 60)
        Me.C1InputPanel6.TabIndex = 3
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "Opções"
        '
        'botSalvarEstruturado
        '
        Me.botSalvarEstruturado.Image = CType(resources.GetObject("botSalvarEstruturado.Image"), System.Drawing.Image)
        Me.botSalvarEstruturado.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarEstruturado.Name = "botSalvarEstruturado"
        Me.botSalvarEstruturado.Text = "Salvar"
        Me.botSalvarEstruturado.Width = 70
        '
        'Aba5
        '
        Me.Aba5.Controls.Add(Me.txtResultados)
        Me.Aba5.Controls.Add(Me.C1InputPanel1)
        Me.Aba5.Location = New System.Drawing.Point(1, 28)
        Me.Aba5.Name = "Aba5"
        Me.Aba5.Size = New System.Drawing.Size(743, 94)
        Me.Aba5.TabIndex = 4
        Me.Aba5.Text = "Resultados"
        '
        'txtResultados
        '
        Me.txtResultados.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultados.Location = New System.Drawing.Point(80, 5)
        Me.txtResultados.Multiline = True
        Me.txtResultados.Name = "txtResultados"
        Me.txtResultados.Size = New System.Drawing.Size(654, 84)
        Me.txtResultados.TabIndex = 6
        Me.txtResultados.Tag = Nothing
        Me.txtResultados.TextDetached = True
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.lblResultados)
        Me.C1InputPanel1.Items.Add(Me.InputTextBox1)
        Me.C1InputPanel1.Location = New System.Drawing.Point(3, 3)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(737, 89)
        Me.C1InputPanel1.TabIndex = 5
        '
        'lblResultados
        '
        Me.lblResultados.Name = "lblResultados"
        Me.lblResultados.Text = "Resultados :"
        '
        'InputTextBox1
        '
        Me.InputTextBox1.Height = 69
        Me.InputTextBox1.Multiline = True
        Me.InputTextBox1.Name = "InputTextBox1"
        Me.InputTextBox1.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.InputTextBox1.Width = 600
        '
        'melEstruturado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 190)
        Me.Controls.Add(Me.C1InputPanel6)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "melEstruturado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Estruturado"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.Aba1.ResumeLayout(False)
        CType(Me.txtOque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Aba2.ResumeLayout(False)
        CType(Me.txtComo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Aba3.ResumeLayout(False)
        CType(Me.inpultData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Aba4.ResumeLayout(False)
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Aba5.ResumeLayout(False)
        CType(Me.txtResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents Aba1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents lblOque As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtOqueOutro As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents Aba2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents lblComo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtComoOutro As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents Aba3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents lblQuando As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtQuando As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents Aba4 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents lblQuem As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboQuem As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents botSalvarEstruturado As C1.Win.C1InputPanel.InputButton
    Friend WithEvents checkData As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents txtComo As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtOque As C1.Win.C1Input.C1TextBox
    Friend WithEvents inpultData As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents dateQuando As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents Aba5 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents txtResultados As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents lblResultados As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox1 As C1.Win.C1InputPanel.InputTextBox
End Class
