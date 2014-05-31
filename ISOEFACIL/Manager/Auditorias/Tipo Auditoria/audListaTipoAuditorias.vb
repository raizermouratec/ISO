Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.audCadTipoAuditorias
Public Class audListaTipoAuditorias

#Region "CARREGAR LISTA"

    Public Sub carregaAuditorias()

        'Carrega Lista
        gridAuditorias.AutoGenerateColumns = False
        gridAuditorias.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_AUDITORIAS_TIPO")

    End Sub

#End Region

#Region "LOAD"

    Private Sub audAuditorias_Listagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal
        carregaAuditorias()
    End Sub

#End Region

#Region "BOTÕES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As System.Object, e As System.EventArgs) Handles botNovo.Click

        Dim frm As New audCadTipoAuditorias

        frm.NovoTipoAuditorias()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridAuditorias.RowSel <= 0 Then
            MessageBox.Show("Não à nenhum Tipo de Auditoria cadastrada", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim frmAud As New audCadTipoAuditorias
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridAuditorias(gridAuditorias.RowSel, 1)
                frmAud.Auditoria = id
                frmAud.EditarAuditorias(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If gridAuditorias.RowSel <= 0 Then
            MessageBox.Show("Não à nenhum Tipo de Auditoria cadastrada", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim tpaud As New TipoAuditorias
            Dim modulo As String = "AUDITORES"

            'Excluir
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado ?", "Tipos de Auditorias", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    tpaud.Delete(gridAuditorias(gridAuditorias.RowSel, 1))
                    MessageBox.Show("Dados da Tipos de Auditorias excluídos com sucesso", "Tipos de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'EXCLUI ANEXOS DO AUDITOR
                    tpaud.DeleteANEXOS(gridAuditorias(gridAuditorias.RowSel, 1), modulo)
                    carregaAuditorias()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "ESTRUTURA"

    Private Sub botEstrutura_Click(sender As System.Object, e As System.EventArgs) Handles botEstrutura.Click

        If gridAuditorias.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Tipo de Auditoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            'Nova Estrutura
            Dim frm As New audEstrutura
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridAuditorias(gridAuditorias.RowSel, 1)
                frm.TipoAuditoria = id
                frm.NovaEstrutura(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "RELATÓRIO"

    Private Sub botRelatorio_Click(sender As System.Object, e As System.EventArgs) Handles botRelatorio.Click

        If gridAuditorias.RowSel <= 0 Then
            MessageBox.Show("Não à nenhum Tipo de Auditoria cadastrada", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

        End If

    End Sub

#End Region

#End Region

End Class
