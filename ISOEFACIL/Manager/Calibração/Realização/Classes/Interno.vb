Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class interno

    Public Function Add(ByVal ID_CALIBRACOES_REALIZAR As Integer, _
                       ByVal ID_COLABORADORES As Integer, _
                       ByVal PADRAO_INTERNO As Integer, _
                       ByVal RESULTADO_FINAL As Integer, _
                       ByVal OBS As String, _
                       ByVal DATA As Date, _
                       ByVal VALIDADE As Date, _
                       ByVal LAUDO As String, _
                       Optional ByRef idInterno As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_CALIBRACOES_REALIZAR_INTERNA"


        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            'Limpar mascaras
            With _Command.Parameters

                .AddWithValue("@ID_CALIBRACOES_REALIZAR", ID_CALIBRACOES_REALIZAR)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@PADRAO_INTERNO", PADRAO_INTERNO)
                .AddWithValue("@RESULTADO_FINAL", RESULTADO_FINAL)
                .AddWithValue("@OBS", OBS)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@VALIDADE", VALIDADE)
                .AddWithValue("@LAUDO", LAUDO)

            End With

            idInterno = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False

        End Try

    End Function

    Public Function Update(
                       ByVal idInterno As Integer, _
                       ByVal ID_CALIBRACOES_REALIZAR As Integer, _
                       ByVal ID_COLABORADORES As Integer, _
                       ByVal PADRAO_INTERNO As String, _
                       ByVal RESULTADO_FINAL As String, _
                       ByVal OBS As String, _
                       ByVal DATA As Date, _
                       ByVal VALIDADE As Date, _
                       ByVal LAUDO As String) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CALIBRACOES_REALIZAR_INTERNA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_CALIBRACOES_REALIZAR", ID_CALIBRACOES_REALIZAR)
                .AddWithValue("@ID_CALIBRACOES_REALIZAR_INTERNA", idInterno)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@PADRAO_INTERNO", PADRAO_INTERNO)
                .AddWithValue("@RESULTADO_FINAL", RESULTADO_FINAL)
                .AddWithValue("@OBS", OBS)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@VALIDADE", VALIDADE)
                .AddWithValue("@LAUDO", LAUDO)

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
        Dim _cmdText As String = "[DELETE_CALIBRACOES_REALIZAR_INTERNA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_CALIBRACOES_REALIZAR_INTERNA", id)

            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#Region "UPDATE STATUS"

    Public Function UpdateRealizacaoStatus(ByVal ID_CALIBRACOES_PLANO As Integer, _
                           ByVal MES As String, _
                           ByVal SITUACAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CALIBRACOES_REALIZACAO_STATUS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
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

    Public Function UpdatePlanoStatus(ByVal ID_CALIBRACOES_PLANO As Integer, _
                           ByVal MES As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CALIBRACOES_PLANO_STATUS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
                .AddWithValue("@MES", MES)
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
