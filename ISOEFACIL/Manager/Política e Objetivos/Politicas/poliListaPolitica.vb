Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.poliCadPolitica
Imports ISOEFACIL.rptListagemPolitica
Public Class poliListaPolitica

#Region "CARREGA LISTA POLITICAS"

    Public Sub carregaPoliticas()

        'Carrega Lista de Políticas
        gridPolitica.AutoGenerateColumns = False
        gridPolitica.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_POLITICA")

    End Sub

#End Region

#Region "LOAD"

    Private Sub forPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal

        'Carrega Lista de Politicas
        carregaPoliticas()

    End Sub

#End Region

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As System.Object, e As System.EventArgs) Handles botNovo.Click

        Dim frm As New poliCadPolitica

        'Chama o forCadastro
        frm.NovoRegistro()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridPolitica.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Política", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim frm As New poliCadPolitica
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridPolitica(gridPolitica.RowSel, 1)
                frm.Politica = id
                frm.EditarPolitica(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If gridPolitica.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Política", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim politica As New politica

            'Excluir o Politica
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Política", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    politica.Delete(gridPolitica(gridPolitica.RowSel, 1))
                    MessageBox.Show("Política excluído com sucesso", "Política", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    carregaPoliticas()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "RELACAO"

    Private Sub botRelacao_Click(sender As System.Object, e As System.EventArgs) Handles botRelacao.Click

        If gridPolitica.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Política", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim rpt As New rptListagemPolitica

            rpt.Show()
        End If

    End Sub

#End Region

#Region "VISUALIZAR"

    Private Sub botVisualizar_Click(sender As System.Object, e As System.EventArgs) Handles botVisualizar.Click

        If gridPolitica.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Política", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim rpt As New rptUnitarioPolitica

            rpt.Show()
        End If

    End Sub

#End Region

#End Region

End Class
