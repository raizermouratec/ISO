Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class decisoes

#Region "DECISOES"

    Public Function Add(ByVal ID_COLABORADORES As Integer, _
                        ByVal NUMERO As String, _
                        ByVal DECISAO As String, _
                        ByVal DETALHAMENTO As String, _
                        ByVal SITUACAO As Integer, _
                        ByVal DATA_REUNIAO As Date, _
                        ByVal PRAZO As Date, _
                        ByVal RESULTADO As String,
                        Optional ByRef idDecisoes As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_ANALISE_CRITICA_DECISOES"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@NUMERO", NUMERO)
                .AddWithValue("@DECISAO", DECISAO)
                .AddWithValue("@DETALHAMENTO", DETALHAMENTO)
                .AddWithValue("@SITUACAO", SITUACAO)
                .AddWithValue("@DATA_REUNIAO", DATA_REUNIAO)
                .AddWithValue("@PRAZO", PRAZO)
                .AddWithValue("@RESULTADO", RESULTADO)
            End With

            idDecisoes = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idDecisoes As Integer, _
                           ByVal ID_COLABORADORES As Integer, _
                           ByVal NUMERO As String, _
                           ByVal DECISAO As String, _
                           ByVal DETALHAMENTO As String, _
                           ByVal SITUACAO As Integer, _
                           ByVal DATA_REUNIAO As Date, _
                           ByVal PRAZO As Date, _
                           ByVal RESULTADO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_ANALISE_CRITICA_DECISOES]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_ANALISE_CRITICA_DECISOES", idDecisoes)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@NUMERO", NUMERO)
                .AddWithValue("@DECISAO", DECISAO)
                .AddWithValue("@DETALHAMENTO", DETALHAMENTO)
                .AddWithValue("@SITUACAO", SITUACAO)
                .AddWithValue("@DATA_REUNIAO", DATA_REUNIAO)
                .AddWithValue("@PRAZO", PRAZO)
                .AddWithValue("@RESULTADO", RESULTADO)
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
        Dim _cmdText As String = "[DELETE_ANALISE_CRITICA_DECISOES]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_ANALISE_CRITICA_DECISOES", id)
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
