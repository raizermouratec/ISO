﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projListaResultados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projListaResultados))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.botNovo = New C1.Win.C1InputPanel.InputButton()
        Me.botEditar = New C1.Win.C1InputPanel.InputButton()
        Me.botExcluir = New C1.Win.C1InputPanel.InputButton()
        Me.gridResultados = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackgroundImage = CType(resources.GetObject("C1InputPanel1.BackgroundImage"), System.Drawing.Image)
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.C1InputPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1InputPanel1.Items.Add(Me.botNovo)
        Me.C1InputPanel1.Items.Add(Me.botEditar)
        Me.C1InputPanel1.Items.Add(Me.botExcluir)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1008, 183)
        Me.C1InputPanel1.TabIndex = 28
        '
        'botNovo
        '
        Me.botNovo.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botNovo.Image = CType(resources.GetObject("botNovo.Image"), System.Drawing.Image)
        Me.botNovo.ImageSize = New System.Drawing.Size(32, 32)
        Me.botNovo.Name = "botNovo"
        Me.botNovo.Padding = New System.Windows.Forms.Padding(180, 130, 0, 0)
        Me.botNovo.Text = "Novo"
        '
        'botEditar
        '
        Me.botEditar.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botEditar.Image = CType(resources.GetObject("botEditar.Image"), System.Drawing.Image)
        Me.botEditar.ImageSize = New System.Drawing.Size(32, 32)
        Me.botEditar.Name = "botEditar"
        Me.botEditar.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botEditar.Text = "Editar"
        '
        'botExcluir
        '
        Me.botExcluir.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.botExcluir.Image = CType(resources.GetObject("botExcluir.Image"), System.Drawing.Image)
        Me.botExcluir.ImageSize = New System.Drawing.Size(32, 32)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Padding = New System.Windows.Forms.Padding(0, 130, 0, 0)
        Me.botExcluir.Text = "Excluir"
        '
        'gridResultados
        '
        Me.gridResultados.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gridResultados.AllowEditing = False
        Me.gridResultados.ColumnInfo = resources.GetString("gridResultados.ColumnInfo")
        Me.gridResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridResultados.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridResultados.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridResultados.Location = New System.Drawing.Point(0, 183)
        Me.gridResultados.Name = "gridResultados"
        Me.gridResultados.Rows.DefaultSize = 21
        Me.gridResultados.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.gridResultados.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.gridResultados.Size = New System.Drawing.Size(1008, 381)
        Me.gridResultados.StyleInfo = resources.GetString("gridResultados.StyleInfo")
        Me.gridResultados.TabIndex = 29
        '
        'projListaResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 564)
        Me.Controls.Add(Me.gridResultados)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "projListaResultados"
        Me.Text = "Resultados dos Projetos"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents botNovo As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botEditar As C1.Win.C1InputPanel.InputButton
    Friend WithEvents botExcluir As C1.Win.C1InputPanel.InputButton
    Friend WithEvents gridResultados As C1.Win.C1FlexGrid.C1FlexGrid
End Class
