﻿Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class resultado

#Region "Conteudo"

    Public Function Add(ByVal NUMERO As Integer,
                        ByVal CONTEUDO As String,
                        Optional ByRef idConteudo As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_ANALISE_CRITICA_DADOS_ITENS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@NUMERO", NUMERO)
                .AddWithValue("@CONTEUDO", CONTEUDO)
            End With

            idConteudo = _Command.ExecuteScalar
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
        Dim _cmdText As String = "[DELETE_ANALISE_CRITICA_DADOS_ITENS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_ANALISE_CRITICA_DADOS_ITENS", id)
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
