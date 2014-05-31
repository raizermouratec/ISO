Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.projCadProjeto
Imports ISOEFACIL.rptListagemProjetos
Public Class projListaProjetos

#Region "CARREGAR LISTA PROJETOS"

    Public Sub CarregaListaProjetos()

        'Carrega Lista de Projetos
        gridProjetos.AutoGenerateColumns = False
        gridProjetos.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_PROJETOS")

    End Sub

#End Region

#Region "LOAD"

    Private Sub projPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal

        'Carrega Lista de Projetos
        CarregaListaProjetos()

    End Sub

#End Region

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As Object, e As EventArgs) Handles botNovo.Click

        Dim frm As New projCadProjeto

        'Novo Projeto
        frm.NovoProjeto()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        Dim frm As New projCadProjeto
        Dim id As Integer = 0

        If gridProjetos.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Projetos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Passagem de parametros
            Try

                id = gridProjetos(gridProjetos.RowSel, 1)
                frm.Projetos = id
                frm.EditarProjeto(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        Dim projetoexcluir As New projeto

        If gridProjetos.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Projetos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Excluir o Projeto
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Projeto", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    projetoexcluir.Delete(gridProjetos(gridProjetos.RowSel, 1))
                    CarregaListaProjetos()
                    MessageBox.Show("Projeto excluído com sucesso", "Projeto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "PLANO"

    Private Sub botPlano_Click(sender As System.Object, e As System.EventArgs) Handles botPlano.Click

        'Novo Plano de Projeto
        Dim frm As New projPlanodeProjeto
        Dim id As Integer = 0
        If gridProjetos.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Projetos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Passagem de parametros
            Try

                id = gridProjetos(gridProjetos.RowSel, 1)
                frm.Projetos = id
                frm.NovoPlanoProjeto(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "RELACAO"

    Private Sub botRelacao_Click(sender As System.Object, e As System.EventArgs) Handles botRelacao.Click
        If gridProjetos.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Projetos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim rpt As New rptListagemProjetos

            rpt.Show()
        End If
    End Sub

#End Region

#Region "VISUALIZAR"

    Private Sub botVisualizar_Click(sender As System.Object, e As System.EventArgs) Handles botVisualizar.Click
        If gridProjetos.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Projetos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim rpt As New rptUnitarioProjetos

            rpt.Show()
        End If
    End Sub

#End Region

#End Region

End Class
