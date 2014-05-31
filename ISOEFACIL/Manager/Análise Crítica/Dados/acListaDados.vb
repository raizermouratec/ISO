Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.acCadAnaliseDados
Imports ISOEFACIL.rptUnitarioDados
Public Class acListaDados

#Region "CARREGA LISTA DADOS"

    Public Sub CarregaDados()

        'Carrega Lista Dados
        gridDados.AutoGenerateColumns = False
        gridDados.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_ANALISE_CRITICA_DADOS")

    End Sub

#End Region

#Region "LOAD"

    Private Sub acPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Alinhar o Grid
        MdiParent = principal

        'Carrega Lista de Não Conformidades \ Melhorias
        CarregaDados()
    End Sub

#End Region

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botNovo.Click

        Dim frm As New acCadAnaliseDados

        'Chama o Cadastro
        frm.NovaAnaliseDados()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridDados.RowSel <= 0 Then
            MessageBox.Show("Não à nenhum item selecionado", "Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim frm As New acCadAnaliseDados
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridDados(gridDados.RowSel, 1)
                frm.Dados = id
                frm.EditarAnaliseDados(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If gridDados.RowSel <= 0 Then
            MessageBox.Show("Não à nenhum item selecionado", "Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim dados As New dados

            'Excluir o Registro
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Dados", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    dados.Delete(gridDados(gridDados.RowSel, 1))
                    CarregaDados()
                    MessageBox.Show("Registro excluído com sucesso", "Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "ITENS"

    Private Sub botItens_Click_1(sender As System.Object, e As System.EventArgs) Handles botItens.Click

        acAddListaItensAdd.Show()

    End Sub

#End Region

#Region "VISUALIZAR"

    Private Sub botVisualizar_Click(sender As System.Object, e As System.EventArgs) Handles botVisualizar.Click

        If gridDados.RowSel <= 0 Then
            MessageBox.Show("Não à nenhum item selecionado", "Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim rpt As New rptUnitarioDados

            rpt.Show()
        End If
    End Sub

#End Region

#End Region

End Class
