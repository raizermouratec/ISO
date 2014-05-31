Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class autorizacao

    Public Function Add(ByVal MELHORIAS As Integer, _
                        ByVal AUTORIZACAO_EMPRESA As Boolean, _
                        ByVal AUTORIZACAO_CLIENTE As Boolean, _
                        ByVal CLIENTE As Integer, _
                        ByVal IMPLEMENTADO As Boolean, _
                        Optional ByRef idautorizacao As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_MELHORIAS_AUTORIZACAO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure


            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS", MELHORIAS)
                .AddWithValue("@AUTORIZACAO_EMPRESA", AUTORIZACAO_EMPRESA)
                .AddWithValue("@AUTORIZACAO_CLIENTE", AUTORIZACAO_CLIENTE)
                .AddWithValue("@CLIENTE", CLIENTE)
                .AddWithValue("@IMPLEMENTADO", IMPLEMENTADO)
            End With

            idautorizacao = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idautorizacao As Integer, _
                           ByVal MELHORIAS As Integer, _
                           ByVal AUTORIZACAO_EMPRESA As Boolean, _
                           ByVal AUTORIZACAO_CLIENTE As Boolean, _
                           ByVal CLIENTE As Integer, _
                           ByVal IMPLEMENTADO As Boolean) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MELHORIAS_AUTORIZACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS_AUTORIZACAO", idautorizacao)
                .AddWithValue("@ID_MELHORIAS", MELHORIAS)
                .AddWithValue("@AUTORIZACAO_EMPRESA", AUTORIZACAO_EMPRESA)
                .AddWithValue("@AUTORIZACAO_CLIENTE", AUTORIZACAO_CLIENTE)
                .AddWithValue("@CLIENTE", CLIENTE)
                .AddWithValue("@IMPLEMENTADO", IMPLEMENTADO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
