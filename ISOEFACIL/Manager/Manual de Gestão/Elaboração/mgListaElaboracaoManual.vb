Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.mgTituloElaboracaoManual
Public Class mgListaElaboracaoManual

#Region "CARREGA LISTA"

    Public Sub CarregaLista()

        'Carrega Lista Texto do Manual
        gridItensManual.AutoGenerateColumns = False
        gridItensManual.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_MANUAL_ELABORACAO")

    End Sub

    Public Sub CarregaElaboracaoManual(ByVal id As String)

        'Carrega Lista
        gridItensManual.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT * FROM NORMAS_ITENS WHERE ID_NORMAS = {0}", id)
        Dim dtb As New DataTable

        dtb = Manager.Util.getDataTable(sql)
        gridItensManual.DataSource = dtb
        gridItensManual.RowSel = False

    End Sub

#Region "GRID DUPLO CLICK"

    Private Sub gridItensManual_DoubleClick(sender As Object, e As System.EventArgs) Handles gridItensManual.DoubleClick

        If gridItensManual.RowSel <= 0 Then
            Exit Sub
        Else
            'Caso selecionado Folha de Rosto
            If gridItensManual(gridItensManual.RowSel, 1) = 1 Then
                mgFolhadeRostoElaboracaoManual.ShowDialog()
                'Caso selecionado Apresentação do Manual
            ElseIf gridItensManual(gridItensManual.RowSel, 1) = 2 Then
                mgApresentacaoElaboracaoManual.ShowDialog()
                'Caso selecionado qualquer Item da Norma
            Else
                'Arquivos de fora do projeto devem ficar na pasta "Debug"...
                System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\RicherTextBoxDemo.exe")
                'mgTextoItensManual.ShowDialog()
            End If
        End If

    End Sub

#End Region

#End Region

#Region "POPULA COMBOS"

#Region "NORMA BASE"

    Sub CarregaNorma()

        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM MANUAL_CONTROLE")
        Dim dtr As DataRow = dtb.NewRow
        Dim id As Integer = 0
        dtr("TITULO") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboManual.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboManual.DataSource = dtb
        comboManual.DisplayMember = "TITULO"
        id = comboManual.ValueMember = "ID_NORMAS"
        CarregaElaboracaoManual(id)

    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub mgListaItensManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Alinhar o Grid
        MdiParent = principal

        CarregaLista()
        CarregaNorma()
    End Sub

#End Region

#Region "BOTOES"

#Region "COMBO LISTA"

    Private Sub comboManual_ChangeCommitted(sender As Object, e As System.EventArgs) Handles comboManual.ChangeCommitted

        CarregaNorma()

    End Sub

#End Region

#Region "TEXTO"

    Private Sub botTexto_Click(sender As System.Object, e As System.EventArgs) Handles botTexto.Click

        Try
            Dim mesrte As String = "EU"
            System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\RicherTextBoxDemo.exe", mesrte)

            'If gridItensManual.RowSel <= 0 Then
            '    MessageBox.Show("Não à nenhuma item selecioando", "Elaboração dos Itens do Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'Else
            '    'Caso selecionado Folha de Rosto
            '    If gridItensManual(gridItensManual.RowSel, 1) = 1 Then
            '        mgFolhadeRostoElaboracaoManual.ShowDialog()
            '        'Caso selecionado Apresentação do Manual
            '    ElseIf gridItensManual(gridItensManual.RowSel, 1) = 2 Then
            '        mgApresentacaoElaboracaoManual.ShowDialog()
            '        'Caso selecionado qualquer Item da Norma
            '    Else
            '        'Arquivos de fora do projeto devem ficar na pasta "Debug"...
            '        System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\RicherTextBoxDemo.exe")
            '        'mgTextoItensManual.ShowDialog()
            '    End If
            'End If
        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub

#End Region

#Region "PROCEDIMENTOS"

    Private Sub botProcVinculados_Click(sender As System.Object, e As System.EventArgs) Handles botVinculadosDoc.Click

        If gridItensManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecioando", "Elaboração dos Itens do Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

        End If

    End Sub

#End Region

#Region "TITULO"

    Private Sub botTitulo_Click(sender As System.Object, e As System.EventArgs) Handles botTitulo.Click

        If gridItensManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecioando", "Elaboração dos Itens do Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Dim frm As New mgTituloElaboracaoManual
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridItensManual(gridItensManual.RowSel, 1)
                frm.Titulo = id
                frm.EditarTitulo(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "APLICACAO"

    Private Sub botAplicacao_Click(sender As System.Object, e As System.EventArgs) Handles botAplicacao.Click

        If gridItensManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecioando", "Elaboração dos Itens do Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

        End If

    End Sub

#End Region

#Region "ALTERAÇÕES"

    Private Sub botAlteracoes_Click(sender As System.Object, e As System.EventArgs) Handles botAlteracoes.Click

        If gridItensManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecioando", "Elaboração dos Itens do Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

            Dim frm As New mgAlteracoesControleManual
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridItensManual(gridItensManual.RowSel, 1)
                frm.AlteracoesControleManuais = id
                frm.ShowDialog()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

#End Region

#Region "VISUALIZAR"

    Private Sub botVisualizar_Click(sender As System.Object, e As System.EventArgs) Handles botVisualizar.Click

        If gridItensManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecioando", "Elaboração dos Itens do Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

        End If

    End Sub

#End Region

#End Region
    
End Class
