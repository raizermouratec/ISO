Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class estrutura

#Region "ADD"

    Public Function Add(ByVal ID_AUDITORIAS_TIPO As Integer, _
                        ByVal ITEM As Integer, _
                        ByVal TITULO As Integer, _
                        ByVal VERSAO As Boolean, _
                        ByVal CHECK As Boolean,
                        Optional ByRef idestrutura As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_AUDITORIAS_TIPO_ESTRUTURA"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_TIPO", ID_AUDITORIAS_TIPO)
                .AddWithValue("@ITEM", ITEM)
                .AddWithValue("@TITULO", TITULO)
                .AddWithValue("@VERSAO", VERSAO)
                .AddWithValue("@CHECK", CHECK)
            End With

            idestrutura = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE"

    Public Function Update(ByVal idestrutura As Integer, _
                           ByVal ID_AUDITORIAS_TIPO As Integer, _
                           ByVal ITEM As Integer, _
                           ByVal TITULO As Integer, _
                           ByVal VERSAO As Boolean, _
                           ByVal CHECK As Boolean) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_AUDITORIAS_TIPO_ESTRUTURA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_TIPO_ESTRUTURA", idestrutura)
                .AddWithValue("@ID_AUDITORIAS_TIPO", ID_AUDITORIAS_TIPO)
                .AddWithValue("@ITEM", ITEM)
                .AddWithValue("@TITULO", TITULO)
                .AddWithValue("@VERSAO", VERSAO)
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

#Region "DELETE"

    Public Function Delete(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_AUDITORIAS_TIPO_ESTRUTURA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("ID_AUDITORIAS_TIPO_ESTRUTURA", id)
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
