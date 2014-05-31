Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class registrosdoc

    Public Function Add(ByVal DATA_ULTIMA_ALTERACAO As Date, _
                    ByVal ELABORADOR_POR As Integer, _
                    ByVal FILTRAR_POR As Integer, _
                    ByVal IDENTIFICACAO As String, _
                    ByVal ARMAZENAMENTO As String, _
                    ByVal PROTECAO As String, _
                    ByVal RECUPERACAO As String, _
                    ByVal RETENCAO As String, _
                    ByVal DISPOSICAO As String, _
                    ByVal DATA_ULTIMA_CONSULTA As Date, _
                    ByVal AREA_ELABORACAO As Integer,
                    Optional ByRef idregistros As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_DOCUMENTO_REGISTROS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@DATA_ULTIMA_ALTERACAO", DATA_ULTIMA_ALTERACAO)
                .AddWithValue("@ELABORADOR_POR", ELABORADOR_POR)
                .AddWithValue("@FILTRAR_POR", FILTRAR_POR)
                .AddWithValue("@IDENTIFICACAO", IDENTIFICACAO)
                .AddWithValue("@ARMAZENAMENTO", ARMAZENAMENTO)
                .AddWithValue("@PROTECAO", PROTECAO)
                .AddWithValue("@RECUPERACAO", RECUPERACAO)
                .AddWithValue("@RETENCAO", RETENCAO)
                .AddWithValue("@DISPOSICAO", DISPOSICAO)
                .AddWithValue("@DATA_ULTIMA_CONSULTA", DATA_ULTIMA_CONSULTA)
                .AddWithValue("@AREA_ELABORACAO", AREA_ELABORACAO)
            End With

            idregistros = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idregistros As Integer, _
                           ByVal DATA_ULTIMA_ALTERACAO As Date, _
                           ByVal ELABORADOR_POR As Integer, _
                           ByVal FILTRAR_POR As Integer, _
                           ByVal IDENTIFICACAO As String, _
                           ByVal ARMAZENAMENTO As String, _
                           ByVal PROTECAO As String, _
                           ByVal RECUPERACAO As String, _
                           ByVal RETENCAO As String, _
                           ByVal DISPOSICAO As String, _
                           ByVal DATA_ULTIMA_CONSULTA As Date, _
                           ByVal AREA_ELABORACAO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_REGISTROS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_DOCUMENTO_REGISTROS", idregistros)
                .AddWithValue("@DATA_ULTIMA_ALTERACAO", DATA_ULTIMA_ALTERACAO)
                .AddWithValue("@ELABORADOR_POR", ELABORADOR_POR)
                .AddWithValue("@FILTRAR_POR", FILTRAR_POR)
                .AddWithValue("@IDENTIFICACAO", IDENTIFICACAO)
                .AddWithValue("@ARMAZENAMENTO", ARMAZENAMENTO)
                .AddWithValue("@PROTECAO", PROTECAO)
                .AddWithValue("@RECUPERACAO", RECUPERACAO)
                .AddWithValue("@RETENCAO", RETENCAO)
                .AddWithValue("@DISPOSICAO", DISPOSICAO)
                .AddWithValue("@DATA_ULTIMA_CONSULTA", DATA_ULTIMA_CONSULTA)
                .AddWithValue("@AREA_ELABORACAO", AREA_ELABORACAO)
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
        Dim _cmdText As String = "[DELETE_DOCUMENTO_REGISTROS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_DOCUMENTO_REGISTROS", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
