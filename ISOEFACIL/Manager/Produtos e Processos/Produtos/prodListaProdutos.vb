Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.prodCadProdutos
Imports ISOEFACIL.prodCadClassificacao
Public Class prodListaProdutos

#Region "CARREGAR LISTA"

    Public Sub CarregaProdutos()

        'Carrega Lista de Produtos
        gridProdutos.AutoGenerateColumns = False
        gridProdutos.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_PRODUTOS")

    End Sub

#End Region

#Region "LOAD"

    Private Sub FormListaProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal

        'Carrega Lista de Produtos
        CarregaProdutos()

    End Sub

#End Region

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As Object, e As EventArgs) Handles botNovo.Click

        Dim frm As New prodCadProdutos

        'Chama o formCadastroProduto
        frm.NovoProduto()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridProdutos.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Produtos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim frm As New prodCadProdutos
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridProdutos(gridProdutos.RowSel, 1)
                frm.Produto = id
                frm.EditarProduto(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If gridProdutos.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Produtos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim produto As New produto

            'Excluir o Produto
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Produto", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    produto.Delete(gridProdutos(gridProdutos.RowSel, 1))
                    CarregaProdutos()
                    MessageBox.Show("Produto excluído com sucesso", "Produto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#End Region

#Region "CLASSIFICACAO"

    Private Sub botClassificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botClassificacao.Click
        prodCadClassificacao.ShowDialog()
    End Sub

#End Region

End Class