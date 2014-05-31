Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.audCadAuditores
Public Class audListaAuditores

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditAuditores As Boolean = False
    Public idAuditores As String

#End Region

#Region "CARREGAR LISTA"

    Public Sub carregaAuditores()

        'Carrega Lista
        gridAuditores.AutoGenerateColumns = False
        gridAuditores.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_AUDITORIAS_AUDITORES")

    End Sub

#End Region

#Region "LOAD"

    Private Sub audAuditores_Listagem_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal

        carregaAuditores()

    End Sub

#End Region

#Region "BOTÕES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As Object, e As EventArgs) Handles botNovo.Click

        Dim frm As New audCadAuditores

        'Chama Novo
        frm.NovoAuditor()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles botEditar.Click

        If gridAuditores.RowSel <= 0 Then
            MessageBox.Show("Não à nenhum Auditor cadastrado", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim frmAud As New audCadAuditores
            Dim id As Integer = 0

            'Muda o Label do botão Incluir
            frmAud.botSalvarId.Width = 80
            frmAud.botSalvarId.Text = "Atualizar"

            'Passagem de parametros
            Try

                id = gridAuditores(gridAuditores.RowSel, 1)
                frmAud.Auditor = id
                frmAud.EditarAuditores(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "EXLUIR"

    Private Sub botExcluir_Click(sender As Object, e As EventArgs) Handles botExcluir.Click

        If gridAuditores.RowSel <= 0 Then
            MessageBox.Show("Não à nenhum Auditor cadastrado", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim auditores As New auditores
            Dim modulo As String = "AUDITORES"

            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado ?", "Auditores", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    auditores.Delete(gridAuditores(gridAuditores.RowSel, 1))
                    MessageBox.Show("Dados do Auditor excluído com sucesso", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'EXCLUI ANEXOS DO AUDITOR
                    auditores.DeleteANEXOS(gridAuditores(gridAuditores.RowSel, 1), modulo)
                    carregaAuditores()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#End Region

End Class
