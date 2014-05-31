Imports System.Data
Imports System.Data.SqlClient
Public Class forListaAvaliacao

#Region "CARREGA LISTA"

    Sub Carregar_grid()
        fg_Avaliacao.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_FORNECEDORES_AVALIACOES_CADASTRO")
    End Sub

#End Region

#Region "LOAD"

    Private Sub ForListaAvaliação_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = principal

        Carregar_grid()

    End Sub

#End Region

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As System.Object, e As System.EventArgs) Handles botNovo.Click

        'Chama nova avaliacao
        forCadAvaliacao.Close()
        forCadAvaliacao.isEditAvalicoes = False
        forCadAvaliacao.ShowDialog()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If fg_Avaliacao.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma Avaliação selecionada", "", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            forCadAvaliacao.Close()
            ' Dim novo As New forCadAvaliacao 
            'Chama nova avaliacao
            forCadAvaliacao.ID = fg_Avaliacao(fg_Avaliacao.RowSel, 1)
            forCadAvaliacao.isEditAvalicoes = True
            forCadAvaliacao.ShowDialog()
        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If fg_Avaliacao.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma Avaliação selecionada", "", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim id As Integer
            id = fg_Avaliacao(fg_Avaliacao.RowSel, 1)
            Dim dr1 As SqlDataReader
            dr1 = Manager.Util.getDataReader("SELECT * FROM  VW_LISTAGEM_FORNECEDOR_AVALIACAO WHERE ID =" & id)
            Dim Resultado_Ocorrencia As String = ""
            dr1.Read()
            Resultado_Ocorrencia = dr1("Situacão")
            If Resultado_Ocorrencia = "Em avaliação" Then
                DeleteAvaliação(id)
                MsgBox("Avaliação Excluida com Sucesso")
            Else
                MsgBox("Não é possivel exculir uma avaliação Concluida")
            End If
        End If

    End Sub

    Public Function DeleteAvaliação(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_FORNECEDORES_AVALIACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AVALIACAO", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "ADICIONAR REQUISITO"

    Private Sub botRequisito_Click(sender As System.Object, e As System.EventArgs) Handles botRequisito.Click

        Dim frm As New forCadRequisitos
        frm.NovoRequisito()

    End Sub

#End Region

#End Region

End Class
