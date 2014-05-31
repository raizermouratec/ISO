Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.acCadAnaliseReuniao
Imports ISOEFACIL.rptUnitarioReunioes
Public Class acListaReuniao

#Region "CARREGA LISTA"

    Public Sub CarregaReunioes()

        'Carrega Lista Reuniões
        gridReunioes.AutoGenerateColumns = False
        gridReunioes.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_ANALISE_CRITICA_REUNIOES")

    End Sub

#End Region

#Region "LOAD"

    Private Sub acPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Alinhar o Grid
        MdiParent = principal

        'Carrega Lista de Reuniões
        CarregaReunioes()

    End Sub

#End Region

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As System.Object, e As System.EventArgs) Handles botNovo.Click

        Dim frm As New acCadAnaliseReuniao

        'Chama o Cadastro
        frm.NovaAnaliseReunioes()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridReunioes.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Reuniões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim frm As New acCadAnaliseReuniao
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridReunioes(gridReunioes.RowSel, 1)
                frm.Registro = id
                frm.EditarAnaliseReunioes(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click_1(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If gridReunioes.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Reuniões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim reuniao As New reuniao

            'Excluir o Registro
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Dados", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    reuniao.Delete(gridReunioes(gridReunioes.RowSel, 1))
                    CarregaReunioes()
                    MessageBox.Show("Registro excluído com sucesso", "Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "VISUALIZAR"

    Private Sub botVisualizar_Click(sender As System.Object, e As System.EventArgs) Handles botVisualizar.Click

        If gridReunioes.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Reuniões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim rpt As New rptUnitarioReunioes

            rpt.Show()
        End If

    End Sub

#End Region

#End Region

End Class
