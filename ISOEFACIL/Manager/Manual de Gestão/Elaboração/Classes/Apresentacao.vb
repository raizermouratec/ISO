Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class apresentacao

    Public Function Add(ByVal APRESENTACAO As String, _
                        ByVal REVISOES As String, _
                        ByVal CONTROLE As String, _
                        ByVal DISTRIBUICAO As String, _
                        ByVal RESPONSAVEL As String, _
                        Optional ByRef idApresentacao As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_MANUAL_APRESENTACAO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@APRESENTACAO", APRESENTACAO)
                .AddWithValue("@REVISOES", REVISOES)
                .AddWithValue("@CONTROLE", CONTROLE)
                .AddWithValue("@DISTRIBUICAO", DISTRIBUICAO)
                .AddWithValue("@RESPONSAVEL", RESPONSAVEL)
            End With

            idApresentacao = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal APRESENTACAO As String, _
                           ByVal REVISOES As String, _
                           ByVal CONTROLE As String, _
                           ByVal DISTRIBUICAO As String, _
                           ByVal RESPONSAVEL As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MANUAL_APRESENTACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@APRESENTACAO", APRESENTACAO)
                .AddWithValue("@REVISOES", REVISOES)
                .AddWithValue("@CONTROLE", CONTROLE)
                .AddWithValue("@DISTRIBUICAO", DISTRIBUICAO)
                .AddWithValue("@RESPONSAVEL", RESPONSAVEL)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
