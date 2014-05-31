Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.acCadDecisoes
Imports ISOEFACIL.rptUnitarioDecisoes
Public Class acListaDecisoes

#Region "CARREGA LISTA"

    Public Sub CarregaDecisoes()

        'Carrega Lista Decisoes
        gridDecisoes.AutoGenerateColumns = False
        gridDecisoes.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_ANALISE_CRITICA_DECISOES")

    End Sub

#End Region

#Region "LOAD"

    Private Sub acPrincipalDecisoes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Alinhar o Grid
        MdiParent = principal

        'Carrega Lista de Decisões
        CarregaDecisoes()
    End Sub

#End Region

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click_1(sender As System.Object, e As System.EventArgs) Handles botNovo.Click

        Dim frm As New acCadDecisoes

        'Chama o Cadastro
        frm.NovaDecisao()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridDecisoes.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Decisões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim frm As New acCadDecisoes
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridDecisoes(gridDecisoes.RowSel, 1)
                frm.Registro = id
                frm.EditarDecisoes(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If gridDecisoes.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Decisões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim decisoes As New decisoes

            'Excluir o Registro
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Decisões", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    decisoes.Delete(gridDecisoes(gridDecisoes.RowSel, 1))
                    CarregaDecisoes()
                    MessageBox.Show("Registro excluído com sucesso", "Decisões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "VISUALIZAR"

    Private Sub botVisualizar_Click(sender As System.Object, e As System.EventArgs) Handles botVisualizar.Click

        If gridDecisoes.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Decisões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim rpt As New rptUnitarioDecisoes

            rpt.Show()
        End If

    End Sub

#End Region

#End Region

End Class