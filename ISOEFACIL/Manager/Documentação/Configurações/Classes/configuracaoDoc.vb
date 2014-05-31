Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms

Public Class ConfiguracaoDoc

#Region "TIPOS"

#Region "ADD TIPO DA AUDITORIA"

    Public Function AddTp(ByVal NOME As String, _
                        Optional ByRef idTipoAuditorias As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_TIPO_AUDITORIA"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@NOME", NOME)
            End With

            idTipoAuditorias = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#End Region

#Region "FORMATOS"

#Region "ADD"

    Public Function Addfm(ByVal IDENTIFICACAO As String, _
                         ByVal NOME As String, _
                         ByVal FORMATO As Integer, _
                         ByVal CHECK As Integer, _
                        Optional ByRef idTipoDoc As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_DOCUMENTO_CONFIG_TP_DOCUMENTO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@IDENTIFICACAO", IDENTIFICACAO)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@FORMATO", FORMATO)
                .AddWithValue("@CHECK", CHECK)
            End With

            idTipoDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE"
    Public Function Updatefm(ByVal idTipoDoc As Integer, _
                                ByVal IDENTIFICACAO As String, _
                                ByVal NOME As String, _
                                ByVal FORMATO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_CONFIG_TP_DOCUMENTO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_DOCUMENTO_CONFIG_TP_DOCUMENTO", idTipoDoc)
                .AddWithValue("@IDENTIFICACAO", IDENTIFICACAO)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@FORMATO", FORMATO)
            End With

            idTipoDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "DELETE"
    Public Function Deletefm(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_DOCUMENTO_CONFIG_TP_DOCUMENTO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_DOCUMENTO_CONFIG_TP_DOCUMENTO", id)
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

#Region "COMPOSIÇÃO"

#Region "ADD"

    Public Function AddCp(ByVal ID_CONFIG_TP_DOC As Integer, _
                          ByVal SEQUENCIA_01 As String, _
                          ByVal SEQUENCIA_02 As String, _
                          ByVal SEQUENCIA_03 As String, _
                        Optional ByRef idCompDoc As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_DOCUMENTO_COMP_TP_DOCUMENTO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CONFIG_TP_DOC", ID_CONFIG_TP_DOC)
                .AddWithValue("@SEQUENCIA_01", SEQUENCIA_01)
                .AddWithValue("@SEQUENCIA_02", SEQUENCIA_02)
                .AddWithValue("@SEQUENCIA_03", SEQUENCIA_03)
            End With

            idCompDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#Region "UPDATE"
    Public Function UpdateCp(ByVal idCompDoc As Integer, _
                                  ByVal SEQUENCIA_01 As String, _
                                  ByVal SEQUENCIA_02 As String, _
                                  ByVal SEQUENCIA_03 As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_COMP_TP_DOCUMENTO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CONFIG_TP_DOC", idCompDoc)
                .AddWithValue("@SEQUENCIA_01", SEQUENCIA_01)
                .AddWithValue("@SEQUENCIA_02", SEQUENCIA_02)
                .AddWithValue("@SEQUENCIA_03", SEQUENCIA_03)
            End With

            idCompDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#End Region

#End Region

#Region "APROVADORES"
    Public Function UpdateMultiploAprovador(ByVal idColaborador As Integer, _
                        ByVal CHECK As Boolean) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_COLABORADORES_MULTIPLOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", idColaborador)
                .AddWithValue("@CHECKS", CHECK)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "ATIVIDADES"
    Public Function UpdateMultiploAtividade(ByVal idAtividades As Integer, _
                            ByVal CHECK As Boolean) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_ATIVIDADES_MULTIPLOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_DOCUMENTO_ATIVIDADE_TP_DOCUMENTO", idAtividades)
                .AddWithValue("@CHECK", CHECK)
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
