Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.projRegResultados
Public Class projListaResultados

#Region "CARREGAR LISTA RESULTADOS"

    Public Sub CarregaListaResultados()

        'Carrega Lista de Resultados
        gridResultados.AutoGenerateColumns = False
        'gridResultados.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_PROJETOS_RESULTADOS")

    End Sub

#End Region

#Region "LOAD"

    Private Sub projListaResultados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal

        'Carrega Lista de Resultados
        CarregaListaResultados()

    End Sub

#End Region

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As System.Object, e As System.EventArgs) Handles botNovo.Click

        Dim frm As New projRegResultados

        If projRegResultados.comboProjeto.SelectedValue = -1 Then
            MessageBox.Show("Nenhum Projeto foi criado", "Ocorrências", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        Else
            'Novo Resultado
            frm.NovoResultado()

        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        Dim frm As New projRegResultados
        Dim id As Integer = 0

        If gridResultados.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Passagem de parametros
            Try

                id = gridResultados(gridResultados.RowSel, 1)
                frm.Resultados = id
                frm.EditarResultados(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        Dim resultados As New resultadosprojeto

        If gridResultados.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Excluir o Resultados
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Resultados", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    'resultados.Delete(gridResultados(gridResultados.RowSel, 1))
                    MessageBox.Show("Projeto excluído com sucesso", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregaListaResultados()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#End Region

End Class
