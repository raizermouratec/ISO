Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class realizacao

#Region "ADD REALIZACAO"

    Public Function Add(ByVal ID_AUDITORIAS_REALIZAR As Integer, _
                        ByVal DATA As Date, _
                        ByVal TEMPO1 As String, _
                        ByVal TEMPO2 As String, _
                        ByVal AUDITOR_LIDER As Integer, _
                        ByVal SEGUNDO_AUDITOR As Integer, _
                        ByVal COMENTARIOS_EQUIPE As String, _
                        Optional ByRef idAuditoriasRealizacao As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_AUDITORIAS_REALIZAR_REALIZACAO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_REALIZAR", ID_AUDITORIAS_REALIZAR)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@TEMPO1", TEMPO1)
                .AddWithValue("@TEMPO2", TEMPO2)
                .AddWithValue("@AUDITOR_LIDER", AUDITOR_LIDER)
                .AddWithValue("@SEGUNDO_AUDITOR", SEGUNDO_AUDITOR)
                .AddWithValue("@COMENTARIOS_EQUIPE", COMENTARIOS_EQUIPE)
            End With

            idAuditoriasRealizacao = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE REALIZACAO"

    Public Function Update(ByVal idAuditoriasRealizacao As Integer, _
                           ByVal ID_AUDITORIAS_REALIZAR As Integer, _
                           ByVal DATA As Date, _
                           ByVal TEMPO1 As String, _
                           ByVal TEMPO2 As String, _
                           ByVal AUDITOR_LIDER As Integer, _
                           ByVal SEGUNDO_AUDITOR As Integer, _
                           ByVal COMENTARIOS_EQUIPE As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_AUDITORIAS_REALIZAR_REALIZACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_REALIZAR_REALIZACAO", idAuditoriasRealizacao)
                .AddWithValue("@ID_AUDITORIAS_REALIZAR", ID_AUDITORIAS_REALIZAR)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@TEMPO1", TEMPO1)
                .AddWithValue("@TEMPO2", TEMPO2)
                .AddWithValue("@AUDITOR_LIDER", AUDITOR_LIDER)
                .AddWithValue("@SEGUNDO_AUDITOR", SEGUNDO_AUDITOR)
                .AddWithValue("@COMENTARIOS_EQUIPE", COMENTARIOS_EQUIPE)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE STATUS"

    Public Function UpdateRealizacaoStatus(ByVal ID_AUDITORIAS_PLANO As Integer, _
                           ByVal MES As String, _
                           ByVal SITUACAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_AUDITORIAS_REALIZACAO_STATUS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
                .AddWithValue("@MES", MES)
                .AddWithValue("@SITUACAO", SITUACAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdatePlanoStatus(ByVal ID_AUDITORIAS_PLANO As Integer, _
                           ByVal MES As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_AUDITORIAS_PLANO_STATUS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
                .AddWithValue("@MES", MES)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idrealizar As Integer, _
                           ByVal ID_COLABORADORES As Integer, _
                           ByVal INICIO As String, _
                           ByVal TERMINO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_AUDITORIAS_REALIZAR]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_REALIZAR", idrealizar)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@INICIO", INICIO)
                .AddWithValue("@TERMINO", TERMINO)
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
