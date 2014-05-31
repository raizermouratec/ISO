Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.projRegOcorrências
Public Class projListaOcorrencias

#Region "CARREGAR LISTA OCORRENCIAS"

    Public Sub CarregaListaOcorrencias()

        'Carrega Lista de Ocorrências
        gridOcorrencias.AutoGenerateColumns = False
        gridOcorrencias.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_PROJETOS_OCORRENCIAS")

    End Sub

#End Region

#Region "LOAD"

    Private Sub projListaOcorrencias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal

        'Carrega Lista de Ocorrências
        CarregaListaOcorrencias()

    End Sub

#End Region

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As System.Object, e As System.EventArgs) Handles botNovo.Click

        Dim frm As New projRegOcorrências

        If projRegOcorrências.comboTipoProjeto.SelectedValue = -1 Then
            MessageBox.Show("Nenhum Projeto foi criado", "Ocorrências", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            'Novo Ocorrências
            frm.NovaOcorrencia()
        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        Dim frm As New projRegOcorrências
        Dim id As Integer = 0

        If gridOcorrencias.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Ocorrências", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Passagem de parametros
            Try

                id = gridOcorrencias(gridOcorrencias.RowSel, 1)
                frm.Ocorrencias = id
                frm.EditarOcorrencias(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        Dim ocorrencias As New ocorrenciasprojeto

        If gridOcorrencias.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Ocorrências", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Excluir o Ocorrências
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Ocorrências", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    ocorrencias.Delete(gridOcorrencias(gridOcorrencias.RowSel, 1))
                    MessageBox.Show("Projeto excluído com sucesso", "Ocorrências", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregaListaOcorrencias()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#End Region

End Class
