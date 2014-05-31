Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.procCadProcessos
Public Class procListaProcessos

#Region "CARREGAR LISTA"

    Public Sub CarregaProcessos()

        'Carrega Lista de Processos
        gridProcessos.AutoGenerateColumns = False
        gridProcessos.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_PROCESSOS")

    End Sub

#End Region

#Region "LOAD"

    Private Sub Processos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal

        'Carrega Lista de Produtos
        CarregaProcessos()

    End Sub

#End Region

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As Object, e As EventArgs) Handles botNovo.Click

        Dim frm As New procCadProcessos

        'Novo Processo
        frm.NovoProcesso()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridProcessos.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Processos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim frm As New procCadProcessos
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridProcessos(gridProcessos.RowSel, 1)
                frm.Processos = id
                frm.EditarProcessos(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If gridProcessos.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Processos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim processo As New processo

            'Excluir o Processo
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Processo", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    processo.Delete(gridProcessos(gridProcessos.RowSel, 1))
                    CarregaProcessos()
                    MessageBox.Show("Processo excluído com sucesso", "Processo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#End Region

End Class
