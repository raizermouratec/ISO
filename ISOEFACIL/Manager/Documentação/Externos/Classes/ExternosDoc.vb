Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms

Public Class ExternosDoc

#Region "EXTERNOS"

#Region "ADD"

    Public Function AddDocExt(ByVal ID_ELABORADOR As Integer, _
                            ByVal ID_COLABORADORES As Integer, _
                            ByVal DATA_ULTIMA_ALTERACAO As Date, _
                            ByVal DOCUMENTO As String, _
                            ByVal VERSAO As String, _
                            ByVal FONTE_ORIGEM As String, _
                            ByVal LOCAL_GUARDA As String, _
                            ByVal FREQUENCIA_CONSULTA As String, _
                            ByVal DATA_ULTIMA_CONSULTA As Date, _
                        Optional ByRef idExtDoc As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_DOCUMENTO_EXTERNOS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_ELABORADOR", ID_ELABORADOR)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@DATA_ULTIMA_ALTERACAO", DATA_ULTIMA_ALTERACAO)
                .AddWithValue("@DOCUMENTO", DOCUMENTO)
                .AddWithValue("@VERSAO", VERSAO)
                .AddWithValue("@FONTE_ORIGEM", FONTE_ORIGEM)
                .AddWithValue("@LOCAL_GUARDA", LOCAL_GUARDA)
                .AddWithValue("@FREQUENCIA_CONSULTA", FREQUENCIA_CONSULTA)
                .AddWithValue("@DATA_ULTIMA_CONSULTA", DATA_ULTIMA_CONSULTA)
            End With

            idExtDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE"
    Public Function UpdateDocExt(ByVal idExtDoc As Integer, _
                            ByVal ID_ELABORADOR As Integer, _
                            ByVal ID_COLABORADORES As Integer, _
                            ByVal DATA_ULTIMA_ALTERACAO As Date, _
                            ByVal DOCUMENTO As String, _
                            ByVal VERSAO As String, _
                            ByVal FONTE_ORIGEM As String, _
                            ByVal LOCAL_GUARDA As String, _
                            ByVal FREQUENCIA_CONSULTA As String, _
                            ByVal DATA_ULTIMA_CONSULTA As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_EXTERNOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_DOCUMENTO_EXTERNOS", idExtDoc)
                .AddWithValue("@ID_ELABORADOR", ID_ELABORADOR)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@DATA_ULTIMA_ALTERACAO", DATA_ULTIMA_ALTERACAO)
                .AddWithValue("@DOCUMENTO", DOCUMENTO)
                .AddWithValue("@VERSAO", VERSAO)
                .AddWithValue("@FONTE_ORIGEM", FONTE_ORIGEM)
                .AddWithValue("@LOCAL_GUARDA", LOCAL_GUARDA)
                .AddWithValue("@FREQUENCIA_CONSULTA", FREQUENCIA_CONSULTA)
                .AddWithValue("@DATA_ULTIMA_CONSULTA", DATA_ULTIMA_CONSULTA)
            End With

            idExtDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "DELETE"
    Public Function DeleteDocExt(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_DOCUMENTO_EXTERNOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_DOCUMENTO_EXTERNOS", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#End Region


End Class
