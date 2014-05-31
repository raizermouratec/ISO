<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cotrCadCursos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cotrCadCursos))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.botSalvar = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblCurso = New C1.Win.C1InputPanel.InputLabel()
        Me.txtCurso = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblInstituicao = New C1.Win.C1InputPanel.InputLabel()
        Me.txtInstituicao = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblCargaHoraria = New C1.Win.C1InputPanel.InputLabel()
        Me.NumCargaHoraria = New C1.Win.C1InputPanel.InputMaskedTextBox()
        Me.lblDtInicio = New C1.Win.C1InputPanel.InputLabel()
        Me.dtInicio = New C1.Win.C1InputPanel.InputDatePicker()
        Me.lblDtTermino = New C1.Win.C1InputPanel.InputLabel()
        Me.dtTermino = New C1.Win.C1InputPanel.InputDatePicker()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Items.Add(Me.botSalvar)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 126)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(598, 62)
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
        Me.C1InputPanel1.Items.Add(Me.lblCurso)
        Me.C1InputPanel1.Items.Add(Me.txtCurso)
        Me.C1InputPanel1.Items.Add(Me.lblInstituicao)
        Me.C1InputPanel1.Items.Add(Me.txtInstituicao)
        Me.C1InputPanel1.Items.Add(Me.lblCargaHoraria)
        Me.C1InputPanel1.Items.Add(Me.NumCargaHoraria)
        Me.C1InputPanel1.Items.Add(Me.lblDtInicio)
        Me.C1InputPanel1.Items.Add(Me.dtInicio)
        Me.C1InputPanel1.Items.Add(Me.lblDtTermino)
        Me.C1InputPanel1.Items.Add(Me.dtTermino)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 1)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(598, 124)
        Me.C1InputPanel1.TabIndex = 2
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Cadastrar Cursos Complementares"
        '
        'lblCurso
        '
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Text = "Curso"
        Me.lblCurso.Width = 75
        '
        'txtCurso
        '
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Width = 500
        '
        'lblInstituicao
        '
        Me.lblInstituicao.Name = "lblInstituicao"
        Me.lblInstituicao.Text = "Instituição"
        Me.lblInstituicao.Width = 75
        '
        'txtInstituicao
        '
        Me.txtInstituicao.Name = "txtInstituicao"
        Me.txtInstituicao.Width = 500
        '
        'lblCargaHoraria
        '
        Me.lblCargaHoraria.Name = "lblCargaHoraria"
        Me.lblCargaHoraria.Text = "Carga Horaria"
        Me.lblCargaHoraria.Width = 75
        '
        'NumCargaHoraria
        '
        Me.NumCargaHoraria.Mask = "000:00"
        Me.NumCargaHoraria.Name = "NumCargaHoraria"
        Me.NumCargaHoraria.Text = "   :"
        '
        'lblDtInicio
        '
        Me.lblDtInicio.Name = "lblDtInicio"
        Me.lblDtInicio.Text = "Data de Inicio"
        Me.lblDtInicio.Width = 75
        '
        'dtInicio
        '
        Me.dtInicio.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtInicio.Name = "dtInicio"
        '
        'lblDtTermino
        '
        Me.lblDtTermino.Name = "lblDtTermino"
        Me.lblDtTermino.Text = "Data de Término"
        Me.lblDtTermino.Width = 99
        '
        'dtTermino
        '
        Me.dtTermino.Name = "dtTermino"
        '
        'cotrCadCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 188)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "cotrCadCursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Cursos"
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
    Friend WithEvents lblCurso As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCurso As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblInstituicao As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtInstituicao As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblCargaHoraria As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDtInicio As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtInicio As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents lblDtTermino As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtTermino As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents NumCargaHoraria As C1.Win.C1InputPanel.InputMaskedTextBox
End Class
