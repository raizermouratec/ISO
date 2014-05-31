Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.objCadObjetivos
Public Class objListaObjetivos

#Region "CARREGA LISTA"

    Public Sub carregaObjetivos()

        'Carrega Lista Objetivos
        gridObjetivos.AutoGenerateColumns = False
        gridObjetivos.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_OBJETIVOS")

    End Sub

#End Region

#Region "LOAD"

    Private Sub PoliObjListaObjetivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal

        'Carrega Lista de Politicas
        carregaObjetivos()

    End Sub

#End Region

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As System.Object, e As System.EventArgs) Handles botNovo.Click

        Dim frm As New objCadObjetivos

        'Chama o forCadastro
        frm.NovoObjetivo()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridObjetivos.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim frm As New objCadObjetivos
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridObjetivos(gridObjetivos.RowSel, 1)
                frm.Objetivos = id
                frm.EditarObjetivos(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If gridObjetivos.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim objetivos As New objetivos

            'Excluir o Objetivos
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Objetivos", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    objetivos.Delete(gridObjetivos(gridObjetivos.RowSel, 1))
                    carregaObjetivos()
                    MessageBox.Show("Objetivos excluído com sucesso", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#End Region

End Class
