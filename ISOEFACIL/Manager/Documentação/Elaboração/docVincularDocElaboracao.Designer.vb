<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class docVincularDocElaboracao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(docVincularDocElaboracao))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblDocumentos = New C1.Win.C1InputPanel.InputLabel()
        Me.comboDoc = New C1.Win.C1InputPanel.InputComboBox()
        Me.botAdd = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.lblDocumentos)
        Me.C1InputPanel1.Items.Add(Me.comboDoc)
        Me.C1InputPanel1.Items.Add(Me.botAdd)
        Me.C1InputPanel1.Location = New System.Drawing.Point(1, 1)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(635, 59)
        Me.C1InputPanel1.TabIndex = 18
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        '
        'lblDocumentos
        '
        Me.lblDocumentos.Name = "lblDocumentos"
        Me.lblDocumentos.Text = "Documentos :"
        '
        'comboDoc
        '
        Me.comboDoc.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.comboDoc.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.comboDoc.Name = "comboDoc"
        Me.comboDoc.Width = 504
        '
        'botAdd
        '
        Me.botAdd.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botAdd.Image = CType(resources.GetObject("botAdd.Image"), System.Drawing.Image)
        Me.botAdd.ImageSize = New System.Drawing.Size(15, 15)
        Me.botAdd.Name = "botAdd"
        '
        'docVincularDocElaboracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 61)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "docVincularDocElaboracao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vincular Documentos"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblDocumentos As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents comboDoc As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents botAdd As C1.Win.C1InputPanel.InputButton
End Class
