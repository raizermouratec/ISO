<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projCadRecursos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projCadRecursos))
        Me.InputRecursos = New C1.Win.C1InputPanel.C1InputPanel()
        Me.grupoRecursos = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblRecurso = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRecurso = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblRecursoTipo = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRecursoTipo = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblQuantidade = New C1.Win.C1InputPanel.InputLabel()
        Me.txtQuantidade = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblUnidade = New C1.Win.C1InputPanel.InputLabel()
        Me.txtUnidade = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblValorUnitario = New C1.Win.C1InputPanel.InputLabel()
        Me.txtValorUnitario = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblValorTotal = New C1.Win.C1InputPanel.InputLabel()
        Me.txtValorTotal = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputGroupHeader13 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvarRecursos = New C1.Win.C1InputPanel.InputButton()
        CType(Me.InputRecursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputRecursos
        '
        Me.InputRecursos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InputRecursos.Items.Add(Me.grupoRecursos)
        Me.InputRecursos.Items.Add(Me.lblRecurso)
        Me.InputRecursos.Items.Add(Me.txtRecurso)
        Me.InputRecursos.Items.Add(Me.lblRecursoTipo)
        Me.InputRecursos.Items.Add(Me.txtRecursoTipo)
        Me.InputRecursos.Items.Add(Me.lblQuantidade)
        Me.InputRecursos.Items.Add(Me.txtQuantidade)
        Me.InputRecursos.Items.Add(Me.lblUnidade)
        Me.InputRecursos.Items.Add(Me.txtUnidade)
        Me.InputRecursos.Items.Add(Me.lblValorUnitario)
        Me.InputRecursos.Items.Add(Me.txtValorUnitario)
        Me.InputRecursos.Items.Add(Me.lblValorTotal)
        Me.InputRecursos.Items.Add(Me.txtValorTotal)
        Me.InputRecursos.Items.Add(Me.InputGroupHeader13)
        Me.InputRecursos.Items.Add(Me.botSalvarRecursos)
        Me.InputRecursos.Location = New System.Drawing.Point(1, 1)
        Me.InputRecursos.Name = "InputRecursos"
        Me.InputRecursos.Size = New System.Drawing.Size(569, 244)
        Me.InputRecursos.TabIndex = 2
        '
        'grupoRecursos
        '
        Me.grupoRecursos.Name = "grupoRecursos"
        Me.grupoRecursos.Text = "Registrar Recursos"
        '
        'lblRecurso
        '
        Me.lblRecurso.Name = "lblRecurso"
        Me.lblRecurso.Text = "Recurso:"
        Me.lblRecurso.Width = 140
        '
        'txtRecurso
        '
        Me.txtRecurso.Name = "txtRecurso"
        Me.txtRecurso.Width = 400
        '
        'lblRecursoTipo
        '
        Me.lblRecursoTipo.Name = "lblRecursoTipo"
        Me.lblRecursoTipo.Text = "Tipo:"
        Me.lblRecursoTipo.Width = 140
        '
        'txtRecursoTipo
        '
        Me.txtRecursoTipo.Name = "txtRecursoTipo"
        Me.txtRecursoTipo.Width = 400
        '
        'lblQuantidade
        '
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Text = "Quantidade:"
        Me.lblQuantidade.Width = 140
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Width = 400
        '
        'lblUnidade
        '
        Me.lblUnidade.Name = "lblUnidade"
        Me.lblUnidade.Text = "Unidade:"
        Me.lblUnidade.Width = 140
        '
        'txtUnidade
        '
        Me.txtUnidade.Name = "txtUnidade"
        '
        'lblValorUnitario
        '
        Me.lblValorUnitario.Name = "lblValorUnitario"
        Me.lblValorUnitario.Text = "Valor Unitáro:"
        Me.lblValorUnitario.Width = 140
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.Name = "txtValorUnitario"
        '
        'lblValorTotal
        '
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Text = "Valor Total:"
        Me.lblValorTotal.Width = 140
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Name = "txtValorTotal"
        '
        'InputGroupHeader13
        '
        Me.InputGroupHeader13.Name = "InputGroupHeader13"
        Me.InputGroupHeader13.Text = "Opções"
        '
        'botSalvarRecursos
        '
        Me.botSalvarRecursos.Break = C1.Win.C1InputPanel.BreakType.None
        Me.botSalvarRecursos.Image = CType(resources.GetObject("botSalvarRecursos.Image"), System.Drawing.Image)
        Me.botSalvarRecursos.ImageSize = New System.Drawing.Size(20, 20)
        Me.botSalvarRecursos.Name = "botSalvarRecursos"
        Me.botSalvarRecursos.Text = "Salvar"
        Me.botSalvarRecursos.Width = 70
        '
        'projCadRecursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 246)
        Me.Controls.Add(Me.InputRecursos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "projCadRecursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        CType(Me.InputRecursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InputRecursos As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents grupoRecursos As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblRecurso As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtRecurso As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblRecursoTipo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtRecursoTipo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblQuantidade As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtQuantidade As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblUnidade As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtUnidade As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblValorUnitario As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtValorUnitario As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblValorTotal As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtValorTotal As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputGroupHeader13 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents botSalvarRecursos As C1.Win.C1InputPanel.InputButton
End Class
