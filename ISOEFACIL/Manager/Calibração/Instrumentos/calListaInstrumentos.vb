Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.calCadInstrumentos
Public Class calListaInstrumentos

#Region "CARREGA LISTA INSTRUMENTOS"

#Region "CARREGA LISTA"

    Public Sub carregaInstrumentos()

        'Monta Lista de Risco do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_INSTRUMENTOS")
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)


        'Não gera colunas automaticas
        gridInst.AutoGenerateColumns = False

        'Cria a tabela
        gridInst.DataSource = dt

        Try

            'Função para validação de Imagem
            For Each dr As DataRow In dt.Rows

                If dr("ATIVO") = "Inativo" Then
                    'INATIVO
                    gridInst.SetCellImage(i, 6, _imgListSituacao.Images.Item(0))
                ElseIf dr("ATIVO") = "Ativo" Then
                    'ATIVO
                    gridInst.SetCellImage(i, 6, _imgListSituacao.Images.Item(1))
                End If
                i += 1

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub instPrincipalnew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal

        'Carrega Lista de Politicas
        carregaInstrumentos()

    End Sub

#End Region

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As System.Object, e As System.EventArgs) Handles botNovo.Click

        Dim frm As New calCadInstrumentos

        'Chama 
        frm.NovoInstrumento()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridInst.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim frm As New calCadInstrumentos
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridInst(gridInst.RowSel, 1)
                frm.Registro = id
                frm.EditarInstrumentos(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If gridInst.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim instrumentos As New instrumentos

            'Condições para excluir
            If gridInst(gridInst.RowSel, 5) = "Calibrado" Then
                MessageBox.Show("Instrumento não pode ser excluído pois já foi realizado", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            ElseIf gridInst(gridInst.RowSel, 5) = "Calibração Vencida" Then
                MessageBox.Show("Instrumento não pode ser excluído pois já foi realizado apenas está vencido", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            'Excluir o Instrumento
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Instrumentos", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    instrumentos.Delete(gridInst(gridInst.RowSel, 1))
                    carregaInstrumentos()
                    MessageBox.Show("Registro excluído com sucesso", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#End Region

End Class
