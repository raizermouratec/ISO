Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.melCadMelhorias
Public Class melListaMelhorias

#Region "CARREGA LISTA"

    Public Sub CarregaMelhorias()

        'Carrega Lista de Não Conformidades \ Melhorias
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_MELHORIAS")
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridNC_AC.AutoGenerateColumns = False

        'Cria a tabela
        gridNC_AC.DataSource = dt

        'Try

        '    'Função para validação de Imagem
        '    For Each dr As DataRow In dt.Rows

        '        If dr("PRAZO_TRATAMENTO") = Today Then
        '            'INATIVO
        '            gridNC_AC.Rows(i).StyleNew.BackColor = Color.FromArgb(252, 249, 169)
        '        ElseIf dr("PRAZO_TRATAMENTO") = dr("PRAZO_TRATAMENTO").DBNull.Value Then
        '            dr("PRAZO_TRATAMENTO") = ""
        '        End If
        '        i += 1

        '    Next

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        'End Try


    End Sub

#End Region

#Region "LOAD"

    Private Sub forPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal

        'Carrega Lista de Não Conformidades \ Melhorias
        CarregaMelhorias()

    End Sub

#End Region

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botNovo.Click

        Dim frm As New melCadMelhorias

        'Chama o Registro
        frm.NovoCadMelhoria()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles botEditar.Click

        If gridNC_AC.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Melhorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim frm As New melCadMelhorias
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridNC_AC(gridNC_AC.RowSel, 1)
                frm.Melhorias = id
                frm.AC = id
                frm.AP = id
                frm.AM = id
                frm.EF = id
                frm.EditarMelhorias(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If gridNC_AC.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Melhorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim registro As New melhorias

            'Excluir o Melhorias
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Melhorias", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    registro.Delete(gridNC_AC(gridNC_AC.RowSel, 1))
                    CarregaMelhorias()
                    MessageBox.Show("Ação excluída com sucesso", "Melhorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#End Region

End Class
