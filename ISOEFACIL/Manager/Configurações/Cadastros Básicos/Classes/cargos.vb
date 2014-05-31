Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms

Public Class cargos

#Region "ADICIONAR"

    Public Function Add(ByVal AREA As Integer, _
                        ByVal SUBSTITUTO As Integer, _
                        ByVal CHEFIA As Integer, _
                        ByVal COLABORADOR As Integer, _
                        ByVal CARGO_APROVADOR As Integer, _
                        ByVal NOME As String, _
                        ByVal APROVADOR As Boolean, _
                        ByVal DESCRICAO As String, _
                        ByVal EDUCACAO As String, _
                        ByVal TREINAMENTO As String, _
                        ByVal HABILIDADE As String, _
                        ByVal EXPERIENCIA As String, _
                        ByVal RESPONSABILIDADE As String, _
                        ByVal AUTORIDADE As String, _
                        ByVal DATA_ELABORACAO As Date, _
                        ByVal DATA_APROVACAO As Date, _
                        Optional ByRef idCargos As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_CARGOS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AREAS", AREA)
                .AddWithValue("@ID_CARGOS_SUBST", SUBSTITUTO)
                .AddWithValue("@ID_CARGOS_CHEF", CHEFIA)
                .AddWithValue("@ID_COLABORADOR", COLABORADOR)
                .AddWithValue("@ID_CARGO_APROVADOR", CARGO_APROVADOR)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@APROVADOR", APROVADOR)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@EDUCACAO", EDUCACAO)
                .AddWithValue("@TREINAMENTO", TREINAMENTO)
                .AddWithValue("@HABILIDADE", HABILIDADE)
                .AddWithValue("@EXPERIENCIA", EXPERIENCIA)
                .AddWithValue("@RESPONSABILIDADE", RESPONSABILIDADE)
                .AddWithValue("@AUTORIDADE", AUTORIDADE)
                .AddWithValue("@DATA_ELABORACAO", DATA_ELABORACAO)
                .AddWithValue("@DATA_APROVACAO", DATA_APROVACAO)
            End With

            idCargos = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "ATUALIZAR"

    Public Function Update(ByVal idAreas As Integer, _
                        ByVal CODIGO As String, _
                        ByVal DESCRICAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_AREAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AREAS", idAreas)
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@DESCRICAO", DESCRICAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "DELETAR"

    Public Function Delete(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_AREAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AREAS", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

End Class
