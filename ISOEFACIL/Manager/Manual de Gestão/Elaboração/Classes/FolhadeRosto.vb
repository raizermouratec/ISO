Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class folhaderosto

    Public Function Add(ByVal APRESENTACAO As String, _
                        ByVal OBJETIVO As String, _
                        ByVal NOTA As String, _
                        Optional ByRef idFolha As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_MANUAL_FOLHA"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@APRESENTACAO", APRESENTACAO)
                .AddWithValue("@OBJETIVO", OBJETIVO)
                .AddWithValue("@NOTA", NOTA)
            End With

            idFolha = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal APRESENTACAO As String, _
                            ByVal OBJETIVO As String, _
                            ByVal NOTA As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MANUAL_FOLHA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@APRESENTACAO", APRESENTACAO)
                .AddWithValue("@OBJETIVO", OBJETIVO)
                .AddWithValue("@NOTA", NOTA)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
