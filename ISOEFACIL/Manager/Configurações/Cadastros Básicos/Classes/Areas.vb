﻿Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class areas

    Public Function Add(ByVal CODIGO As String, _
                        ByVal DESCRICAO As String, _
                        ByVal CHECK As Boolean, _
                        Optional ByRef idAreas As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_AREAS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@CHECK", CHECK)
            End With

            idAreas = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idAreas As Integer, _
                        ByVal CODIGO As String, _
                        ByVal DESCRICAO As String, _
                        ByVal CHECK As Boolean) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_AREAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AREAS", idAreas)
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@CHECK", CHECK)
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
        Dim _cmdText As String = "[DELETE_AREAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AREAS", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
