Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Net.Mail
Imports Microsoft.Office.Interop
Imports System.Net

Public Class docElaboracao

#Region "VARIAVEIS"
    'Variavel para verificar se a tela já esta aberta 
    Public idVerifivcar_open As Boolean = False
    Public strId As String = String.Empty
    Private allMail As String = String.Empty
    Private tipoDoc As String = String.Empty

    Private codigo As String = String.Empty
    Private revisao As Integer = 0
#End Region

#Region "LOAD"
    Private Sub docElaboracao_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Alinhar o Grid
        MdiParent = principal
        carregarLista()
        filtroTodos.Checked = True
    End Sub
#End Region

#Region "CARREGAR LISTA"

    'Carrega lista de documentos..
    Public Sub carregarLista()
        Dim dt As New DataTable
        Dim i As Integer = 1
        Try
            Dim sqlId As String = String.Format("SELECT * FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO")
            dt = Manager.Util.getDataTableById(sqlId)

            'Monta o Grid
            gridProcedimentos.AutoGenerateColumns = False
            gridProcedimentos.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO")

            'Função para validação de Imagem
            For Each dr As DataRow In dt.Rows
                If dr("ARQUIVO") = "docx" Then
                    gridProcedimentos.SetCellImage(i, 13, _imgListLegenda.Images.Item(1))
                Else
                    gridProcedimentos.SetCellImage(i, 13, _imgListLegenda.Images.Item(2))
                End If
                i += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub

    'Carrega lista de documentos por Tipo...
    Public Sub carregarListaTipo(ByVal tipo As String)
        Dim dt As New DataTable
        Dim i As Integer = 1
        Try
            Dim sqlId As String = String.Format("SELECT * FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO WHERE TIPO = '{0}'", tipo)
            dt = Manager.Util.getDataTableById(sqlId)

            'Monta o Grid
            gridProcedimentos.AutoGenerateColumns = False
            Dim sql As String = String.Format("SELECT * FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO WHERE TIPO = '{0}'", tipo)
            gridProcedimentos.DataSource = Manager.Util.getDataTable(sql)

            'Função para validação de Imagem
            For Each dr As DataRow In dt.Rows
                If dr("ARQUIVO") = "docx" Then
                    gridProcedimentos.SetCellImage(i, 12, _imgListLegenda.Images.Item(1))
                Else
                    gridProcedimentos.SetCellImage(i, 12, _imgListLegenda.Images.Item(2))
                End If
                i += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub

    'Carrega lista de documentos por Area...
    Public Sub carregarListaArea(ByVal area As String)
        Dim dt As New DataTable
        Dim i As Integer = 1
        Try
            Dim sqlId As String = String.Format("SELECT * FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO WHERE AREA = '{0}'", area)
            dt = Manager.Util.getDataTableById(sqlId)

            'Monta o Grid
            gridProcedimentos.AutoGenerateColumns = False
            Dim sql As String = String.Format("SELECT * FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO WHERE AREA = '{0}'", area)
            gridProcedimentos.DataSource = Manager.Util.getDataTable(sql)

            'Função para validação de Imagem
            For Each dr As DataRow In dt.Rows
                If dr("ARQUIVO") = "docx" Then
                    gridProcedimentos.SetCellImage(i, 12, _imgListLegenda.Images.Item(1))
                Else
                    gridProcedimentos.SetCellImage(i, 12, _imgListLegenda.Images.Item(2))
                End If
                i += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub

#End Region

#Region "FILTRO DO GRID"
    '// Combo Filtro...
    Private Sub cmbFiltro_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbFiltro.SelectionChangeCommitted
        If cmbFiltro.SelectedValue <> "" Then
            If filtroTipo.Checked Then
                carregarListaTipo(cmbFiltro.SelectedValue)
            ElseIf filtroArea.Checked Then
                carregarListaArea(cmbFiltro.SelectedValue)
            Else
                carregarLista()
            End If
        End If
    End Sub
    ''//TIPO...
    Private Sub filtroTipo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles filtroTipo.CheckedChanged
        Try
            'Responsavel Elaboração
            Dim dtb As DataTable = Manager.Util.getDataTable("SELECT DISTINCT TIPO FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO")
            Dim dtr As DataRow = dtb.NewRow
            dtr("TIPO") = ""

            dtb.Rows.InsertAt(dtr, 0)
            dtb.AcceptChanges()
            With cmbFiltro
                .DataSource = dtb
                .DisplayMember = "TIPO"
                .ValueMember = "TIPO"
            End With
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    ''//TODOS...
    Private Sub filtroTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles filtroTodos.CheckedChanged
        cmbFiltro.DataSource = Nothing
        carregarLista()
    End Sub
    ''//ÁREA...
    Private Sub filtroArea_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles filtroArea.CheckedChanged
        Try
            'Responsavel Elaboração
            Dim dtb As DataTable = Manager.Util.getDataTable("SELECT DISTINCT AREA FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO")
            Dim dtr As DataRow = dtb.NewRow
            dtr("AREA") = ""

            dtb.Rows.InsertAt(dtr, 0)
            dtb.AcceptChanges()
            With cmbFiltro
                .DataSource = dtb
                .DisplayMember = "AREA"
                .ValueMember = "AREA"
            End With
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
#End Region

    Private Sub botElaborar_Click(sender As System.Object, e As System.EventArgs) Handles botElaborar.Click
        Try
            If gridProcedimentos.RowSel < 0 Then
                MessageBox.Show("Não à nenhum Documento Selecionado", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                If tipoDoc = "Anexo" Then
                    MessageBox.Show("O Tipo do Documento não permite Elaboração. Verifique.", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim frm As New docAddAtividade
                    Dim doc As String = String.Empty
                    Dim rev As String = String.Empty

                    doc = gridProcedimentos(gridProcedimentos.RowSel, 2)
                    rev = gridProcedimentos(gridProcedimentos.RowSel, 6)
                    frm.Documento = doc
                    frm.Revisao = rev
                    frm.Novo()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub

    Private Sub botAnexar_Click(sender As System.Object, e As System.EventArgs) Handles botAnexar.Click
        Try
            If gridProcedimentos.RowSel < 0 Then
                MessageBox.Show("Não à nenhum Documento Selecionado", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                If tipoDoc = "Anexo" Then
                    Dim frm As New docAnexosElaboracao
                    Dim doc As String = String.Empty
                    Dim rev As String = String.Empty

                    doc = gridProcedimentos(gridProcedimentos.RowSel, 2)
                    rev = gridProcedimentos(gridProcedimentos.RowSel, 6)
                    frm.Documento = doc
                    frm.Revisao = rev
                    frm.Novo()
                Else
                    MessageBox.Show("O Tipo do Documento não permite Anexos. Verifique.", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub

    Private Sub gridProcedimentos_Click(sender As System.Object, e As System.EventArgs) Handles gridProcedimentos.Click
        '// pega o tipo de documento...
        tipoDoc = gridProcedimentos(gridProcedimentos.RowSel, 12)
    End Sub
End Class
