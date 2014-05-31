Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.forCadOcorrencias
Public Class forListaOcorrencias

#Region "CARREGA LISTA"

    Public Sub carregaOcorrenciasFornecedor()

        'Carrega Lista de Ocorrencias
        'gridOcorrenciasFornecedores.AutoGenerateColumns = False
        Try
            Dim dr As SqlDataReader
            dr = Manager.Util.getDataReader("SELECT * FROM VW_LISTAGEM_FORNECEDORES_OCORRENCIAS")
            gridOcorrenciasFornecedores.Rows.Count = 1
            Dim i As Integer = 0
            Dim result As Integer = 0
            While dr.Read
                i = i + 1
                gridOcorrenciasFornecedores.Rows.Add()
                gridOcorrenciasFornecedores(gridOcorrenciasFornecedores.Rows.Count - 1, 0) = dr("Codigo")
                gridOcorrenciasFornecedores(gridOcorrenciasFornecedores.Rows.Count - 1, 1) = dr("ID_FORNECEDOR")
                result = dr("Situação")
                If result = 1 Then
                    gridOcorrenciasFornecedores.SetCellImage(i, 2, Icones.Images.Item(0))

                ElseIf result = 2 Then
                    gridOcorrenciasFornecedores.SetCellImage(i, 2, Icones.Images.Item(1))

                End If
                gridOcorrenciasFornecedores(gridOcorrenciasFornecedores.Rows.Count - 1, 3) = dr("Fornecedor").ToString
                gridOcorrenciasFornecedores(gridOcorrenciasFornecedores.Rows.Count - 1, 4) = dr("Data")
                gridOcorrenciasFornecedores(gridOcorrenciasFornecedores.Rows.Count - 1, 5) = dr("Descrição").ToString
            End While

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "LOAD"

    Private Sub forPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal

        'Carrega Lista de Ocorrencias de Fornecedores
        carregaOcorrenciasFornecedor()

    End Sub

#End Region

#Region "BOTÕES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As Object, e As EventArgs) Handles botNovo.Click

        'Chama o forCadastro
        forCadOcorrencias.NovoOcorrencias()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As Object, e As EventArgs) Handles botEditar.Click

        If gridOcorrenciasFornecedores.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Ocorrências", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim id As Integer = 0

            'Muda o Label do botão Incluir
            forCadOcorrencias.botSalvar.Width = 80
            forCadOcorrencias.botSalvar.Text = "Atualizar"

            'Passagem de parametros
            Try

                id = gridOcorrenciasFornecedores(gridOcorrenciasFornecedores.RowSel, 0)
                forCadOcorrencias.Ocorrencias = id
                forCadOcorrencias.EditarOcorrencias(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As Object, e As EventArgs) Handles botExcluir.Click

        If gridOcorrenciasFornecedores.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim ocorrencias As New Ocorrencias

            'Excluir o Fornecedor
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Fornecedor", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    Delete(gridOcorrenciasFornecedores(gridOcorrenciasFornecedores.RowSel, 0))
                    MessageBox.Show("Fornecedor excluído com sucesso", "Fornecedor", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    carregaOcorrenciasFornecedor()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Function Delete(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_FORNECEDORES_OCORRENCIAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDORES_OCORRENCIAS", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "VISUALIZAR"

    Private Sub botVisualizar_Click(sender As System.Object, e As System.EventArgs) Handles botVisualizar.Click

        If gridOcorrenciasFornecedores.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim rpt As New rptUnitarioFornecedores

            rpt.Show()
        End If

    End Sub

#End Region

#End Region
    
End Class
