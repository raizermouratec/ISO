Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class projeto

#Region "PROJETOS"

    Public Function Add(ByVal RESPONSAVEL As Integer, _
                        ByVal APROVADOR As Integer, _
                        ByVal TITULO As String, _
                        ByVal REVISAO As String, _
                        ByVal IDENTIFICACAO As String, _
                        ByVal TIPO As String, _
                        ByVal INICIO As Date, _
                        ByVal TERMINO As Date, _
                        ByVal DATA_APROVADOR As Date, _
                        ByVal DURACAO As String, _
                        Optional ByRef idprojetos As Integer = 0) As String

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS"
        Dim id As String = String.Empty

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@RESPONSAVEL", RESPONSAVEL)
                .AddWithValue("@APROVADOR", APROVADOR)
                .AddWithValue("@TITULO", TITULO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@IDENTIFICACAO", IDENTIFICACAO)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@INICIO", INICIO)
                .AddWithValue("@TERMINO", TERMINO)
                .AddWithValue("@DATA_APROVADOR", DATA_APROVADOR)
                .AddWithValue("@DURACAO", DURACAO)
                .AddWithValue("@MSG", "")
            End With

            Using sdr As SqlDataReader = _Command.ExecuteReader
                If sdr.Read Then
                    id = sdr("RESULTADO").ToString
                End If
            End Using

            Return id.ToString
            _Connection.Close()

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idprojetos As Integer, _
                        ByVal RESPONSAVEL As Integer, _
                        ByVal APROVADOR As Integer, _
                        ByVal TITULO As String, _
                        ByVal REVISAO As String, _
                        ByVal IDENTIFICACAO As String, _
                        ByVal TIPO As String, _
                        ByVal INICIO As Date, _
                        ByVal TERMINO As Date, _
                        ByVal DATA_APROVADOR As Date, _
                        ByVal DURACAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS", idprojetos)
                .AddWithValue("@RESPONSAVEL", RESPONSAVEL)
                .AddWithValue("@APROVADOR", APROVADOR)
                .AddWithValue("@TITULO", TITULO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@IDENTIFICACAO", IDENTIFICACAO)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@INICIO", INICIO)
                .AddWithValue("@TERMINO", TERMINO)
                .AddWithValue("@DATA_APROVADOR", DATA_APROVADOR)
                .AddWithValue("@DURACAO", DURACAO)
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
        Dim _cmdText As String = "[DELETE_PROJETOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS", id)
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
