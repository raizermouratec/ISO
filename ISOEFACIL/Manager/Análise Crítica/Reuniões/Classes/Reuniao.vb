Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class reuniao

#Region "REVISOES"

    Public Function Add(ByVal ID_COLABORADORES As Integer, _
                        ByVal REUNIOES As String, _
                        ByVal TIPO As Boolean, _
                        ByVal DATA As Date,
                        Optional ByRef idAnaliseReunioes As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_ANALISE_CRITICA_REUNIOES"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@REUNIOES", REUNIOES)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@DATA", DATA)
            End With

            idAnaliseReunioes = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idAnaliseReunioes As Integer, _
                           ByVal ID_COLABORADORES As Integer, _
                           ByVal REUNIOES As String, _
                           ByVal TIPO As Boolean, _
                           ByVal DATA As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_ANALISE_CRITICA_REUNIOES]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_ANALISE_CRITICA_REUNIOES", idAnaliseReunioes)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@REUNIOES", REUNIOES)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@DATA", DATA)
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
        Dim _cmdText As String = "[DELETE_ANALISE_CRITICA_REUNIOES]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_ANALISE_CRITICA_REUNIOES", id)
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
