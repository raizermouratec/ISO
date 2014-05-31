Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing.Drawing2D
Imports System.Xml

Public Class docAddAtividade

#Region "VARIAVEIS"
    Public doc1 As String = String.Empty
    Public rev1 As Integer = 0
    Public doc As String = doc1
    Public rev As Integer = rev1

    '//TEXTO
    Private AdAt As String = String.Empty

    Private num As Integer

    '// doc
    Public WriteOnly Property Documento() As String
        Set(ByVal value As String)
            Me.doc1 = value
        End Set
    End Property
    '// rev
    Public WriteOnly Property Revisao() As Integer
        Set(ByVal value As Integer)
            Me.rev1 = value
        End Set
    End Property

#End Region

#Region "LOAD"
    Private Sub docAddAtividade_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '  gridHistorico.Styles.Normal.WordWrap = True
        Tab_Atividade.Show()
        CarregaDadosDoc(doc, rev)
        validarTexto()

        CarregaTextoDoc(doc, rev)

        controlatxtbox()

        '  gridHistorico.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        '  gridHistorico.DragMode = C1.Win.C1FlexGrid.DragModeEnum.Manual
        '  gridHistorico.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual

    End Sub
    Private Sub controlatxtbox()
        txtCodigoDocumento.ReadOnly = True
        txtTituloDocumento.ReadOnly = True
        txtRevisaoDocumento.ReadOnly = True
        txtSituacaoDocumento.ReadOnly = True
    End Sub
#End Region

#Region "NOVO"
    Public Sub Novo()
        doc = doc1
        rev = rev1
        Me.ShowDialog()
    End Sub
#End Region

#Region "METODOS"
    Private Sub CarregaDadosDoc(ByVal doc As String, ByVal rev As Integer)
        Try
            Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_DOCUMENTO WHERE CODIGO = '{0}' AND REVISAO = {1}", doc, rev)

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read
                Me.txtCodigoDocumento.Text = dr("CODIGO").ToString
                Me.txtRevisaoDocumento.Text = dr("REVISAO").ToString
                Me.txtTituloDocumento.Text = dr("TITULO").ToString
                Me.txtSituacaoDocumento.Text = dr("SITUACAO").ToString
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CarregaTextoDoc(ByVal doc As String, ByVal rev As Integer)
        Try
            Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_ELABORACAO_TEXTO WHERE CODIGO_DOCUMENTO = '{0}' AND REVISAO = {1}", doc, rev)

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read
                Dim str As String = dr("TEXTO")
                carregaHTMLTextoBd(str)
                C1Editor1.LoadXml("C:\ISOEFACIL\Formularios\temp\a.html")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub validarTexto()
        Try
            Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_ELABORACAO_TEXTO WHERE CODIGO_DOCUMENTO = '{0}' AND REVISAO = {1}", doc, rev)
            Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
            If dtb.Rows.Count <= 0 Then
                btSalvarTextoFolhaRosto.Text = "Salvar"
                AdAt = "Ad"
            Else
                btSalvarTextoFolhaRosto.Text = "Atualizar"
                AdAt = "At"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "CONTROLA TAB"
    Private Sub checkAtividade_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkAtividade.CheckedChanged
        If checkAtividade.Checked Then
            Tab_Atividade.Enabled = True
        Else
            Tab_Atividade.Enabled = False
        End If
    End Sub
    Private Sub checkTexto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkTexto.CheckedChanged
        If checkTexto.Checked Then
            Tab_Texto.Enabled = True
        Else
            Tab_Texto.Enabled = False
        End If
    End Sub
    Private Sub checkHistorico_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkHistorico.CheckedChanged
        If checkHistorico.Checked Then
            Tab_Historico.Enabled = True
        Else
            Tab_Historico.Enabled = False
        End If
    End Sub
    Private Sub checkRegistro_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkRegistro.CheckedChanged
        If checkRegistro.Checked Then
            Tab_Registro.Enabled = True
        Else
            Tab_Registro.Enabled = False
        End If
    End Sub
#End Region

    '#Region "ABA ATIVIDADES OLD"

    '    Private Sub flex_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs)
    '        '   gridHistorico.AutoSizeRow(e.Row)
    '    End Sub
    '    'Private Sub flex_ChangeEdit(ByVal sender As Object, ByVal e As System.EventArgs)
    '    '    Dim g As Graphics = gridHistorico.CreateGraphics()
    '    '    Try
    '    '    Finally
    '    '        'measure text height
    '    '        Dim sf As StringFormat = New StringFormat()
    '    '        Dim wid As Integer = gridHistorico.Cols(gridHistorico.Col).WidthDisplay - 2
    '    '        Dim text As String = gridHistorico.Editor.Text
    '    '        Dim sz As SizeF = g.MeasureString(text, gridHistorico.Font, wid, sf)

    '    '        'adjust row height if necessary
    '    '        Dim row As C1.Win.C1FlexGrid.Row = gridHistorico.Rows(gridHistorico.Row)
    '    '        If sz.Height + 4 > row.HeightDisplay Then
    '    '            row.HeightDisplay = CType(sz.Height, Integer) + 4
    '    '        End If
    '    '    End Try
    '    'End Sub
    '    'Private Sub gridHistorico_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
    '    '    'Chama o Menu quando o mouse estiver em cima do grid
    '    '    If e.Button = Windows.Forms.MouseButtons.Right Then

    '    '        Menu_01.ShowContextMenu(gridHistorico, e.Location)

    '    '    End If
    '    'End Sub
    '    '// Ação...
    '    Private Sub cmdAcao_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAcao.Click
    '        With gridHistorico
    '            If .ColSel = 3 Then
    '                Dim _result As DialogResult = MessageBox.Show("Atividade Terminal ?", "Elaboração", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '                If _result = Windows.Forms.DialogResult.Yes Then
    '                    gridHistorico(.RowSel, 1) = num + 1
    '                    num = num + 1
    '                    gridHistorico.SetCellImage(.RowSel, .ColSel, _imgListLegenda.Images.Item(1))
    '                Else
    '                    gridHistorico(.RowSel, 1) = num + 1
    '                    num = num + 1
    '                    gridHistorico.SetCellImage(.RowSel, .ColSel, _imgListLegenda.Images.Item(2))
    '                End If
    '            End If
    '            ' gridHistorico.AutoSizeRow(.RowSel)
    '        End With
    '    End Sub
    '    ' // Execução...
    '    Private Sub cmdExecucao_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdExecucao.Click
    '        With gridHistorico
    '            If .ColSel = 3 Then
    '                gridHistorico(.RowSel, 1) = num + 1
    '                num = num + 1
    '                gridHistorico.SetCellImage(.RowSel, .ColSel, _imgListLegenda.Images.Item(5))
    '            End If
    '            ' gridHistorico.AutoSizeRow(.RowSel)
    '        End With
    '    End Sub
    '    '// Remover...
    '    Private Sub cmdRemover_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRemover.Click
    '        With gridHistorico
    '            If .ColSel = 3 Then
    '                gridHistorico.SetCellImage(.RowSel, .ColSel, _imgListLegenda.Images.Item(0))
    '            End If
    '            gridHistorico.AutoSizeRow(.RowSel)
    '        End With
    '    End Sub
    '    '//Seta direita
    '    Private Sub cmdSetaDireita_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdSetaDireita.Click
    '        With gridHistorico
    '            If .ColSel = 3 Then
    '                gridHistorico.SetCellImage(.RowSel, 2, _imgListLegenda.Images.Item(6))
    '            End If
    '            '  gridHistorico.AutoSizeRow(.RowSel)
    '        End With
    '    End Sub



    '#End Region '//codigos aantigos

    Private Sub btSalvarTextoFolhaRosto_Click(sender As System.Object, e As System.EventArgs) Handles btSalvarTextoFolhaRosto.Click
        Try
            Dim classe As New elaboracao
            If AdAt = "Ad" Then
                Dim texto As String = doc + rev.ToString
                classe.AddElabTexto(doc, rev, C1Editor1.SaveXml())
                MessageBox.Show("Texto salvo com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                '//Atualizar...
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub carregaHTMLTextoBd(ByVal textobd As String)
        Try
            Dim path As String = "C:\ISOEFACIL\Formularios\temp\a.html"
            If File.Exists(path) = False Then
                Using sw As StreamWriter = File.CreateText(path)
                    sw.WriteLine(textobd)
                    sw.Flush()
                End Using
            Else
                File.Delete(path)
                Using sw As StreamWriter = File.CreateText(path)
                    sw.WriteLine(textobd)
                    sw.Flush()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNovoAtv_Click(sender As System.Object, e As System.EventArgs) Handles btNovoAtv.Click
        Try
            Dim frm As New docAddAtividades
            frm.Documento = Me.txtCodigoDocumento.Text
            frm.Revisao = Me.txtRevisaoDocumento.Text
            frm.Novo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btIncluiAtv_Click(sender As System.Object, e As System.EventArgs) Handles btIncluiAtv.Click
        docElabIncluiAtv.ShowDialog()
    End Sub
End Class
