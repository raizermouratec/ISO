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

    Public Function Add(ByVal ID_CARGOS As Integer, _
                        ByVal SETOR As Integer, _
                        ByVal SUBSTITUTO As Integer, _
                        ByVal CHEFIA_IMEDIATA As Integer, _
                        ByVal DESCRICAO As String, _
                        ByVal EDUCACAO As String, _
                        ByVal TREINAMENTO As String, _
                        ByVal HABILIDADE As String, _
                        ByVal EXPERIENCIA As String, _
                        ByVal ELABORADOR As Integer, _
                        ByVal DATA_ELABORADOR As Date, _
                        ByVal APROVADOR As Integer, _
                        ByVal DATA_APROVADOR As Date, _
                        Optional ByRef idCargosDetalhados As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_CARGOS_COMPETENCIAS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CARGOS", ID_CARGOS)
                .AddWithValue("@SETOR", SETOR)
                .AddWithValue("@SUBSTITUTO", SUBSTITUTO)
                .AddWithValue("@CHEFIA_IMEDIATA", CHEFIA_IMEDIATA)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@EDUCACAO", EDUCACAO)
                .AddWithValue("@TREINAMENTO", TREINAMENTO)
                .AddWithValue("@HABILIDADE", HABILIDADE)
                .AddWithValue("@EXPERIENCIA", EXPERIENCIA)
                .AddWithValue("@ELABORADOR", ELABORADOR)
                .AddWithValue("@DATA_ELABORADOR", DATA_ELABORADOR)
                .AddWithValue("@APROVADOR", APROVADOR)
                .AddWithValue("@DATA_APROVADOR", DATA_APROVADOR)
            End With

            idCargosDetalhados = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idCargosDetalhados As Integer, _
                        ByVal ID_CARGOS As Integer, _
                        ByVal SETOR As Integer, _
                        ByVal SUBSTITUTO As Integer, _
                        ByVal CHEFIA_IMEDIATA As Integer, _
                        ByVal DESCRICAO As String, _
                        ByVal EDUCACAO As String, _
                        ByVal TREINAMENTO As String, _
                        ByVal HABILIDADE As String, _
                        ByVal EXPERIENCIA As String, _
                        ByVal ELABORADOR As Integer, _
                        ByVal DATA_ELABORADOR As Date, _
                        ByVal APROVADOR As Integer, _
                        ByVal DATA_APROVADOR As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CARGOS_COMPETENCIAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CARGOS_COMPETENCIAS", idCargosDetalhados)
                .AddWithValue("@ID_CARGOS", ID_CARGOS)
                .AddWithValue("@SETOR", SETOR)
                .AddWithValue("@SUBSTITUTO", SUBSTITUTO)
                .AddWithValue("@CHEFIA_IMEDIATA", CHEFIA_IMEDIATA)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@EDUCACAO", EDUCACAO)
                .AddWithValue("@TREINAMENTO", TREINAMENTO)
                .AddWithValue("@HABILIDADE", HABILIDADE)
                .AddWithValue("@EXPERIENCIA", EXPERIENCIA)
                .AddWithValue("@ELABORADOR", ELABORADOR)
                .AddWithValue("@DATA_ELABORADOR", DATA_ELABORADOR)
                .AddWithValue("@APROVADOR", APROVADOR)
                .AddWithValue("@DATA_APROVADOR", DATA_APROVADOR)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Delete(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_CARGOS_COMPETENCIAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CARGOS", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
