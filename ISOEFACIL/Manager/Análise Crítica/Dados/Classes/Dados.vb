Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class dados

#Region "Dados"

    Public Function Add(ByVal COLABORADORES As Integer, _
                        ByVal TIPO_IDENTIFICACAO As String, _
                        ByVal IDENTIFICACAO As String, _
                        ByVal OBJETIVOS As String, _
                        ByVal PERIODO_REF1 As Date, _
                        ByVal PERIODO_REF2 As Date, _
                        ByVal DATA_ELABORACAO As Date, _
                        ByVal DATA_ANALISE As Date,
                        Optional ByRef idAnaliseDados As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_ANALISE_CRITICA_DADOS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", COLABORADORES)
                .AddWithValue("@TIPO_IDENTIFICACAO", TIPO_IDENTIFICACAO)
                .AddWithValue("@IDENTIFICACAO", IDENTIFICACAO)
                .AddWithValue("@OBJETIVOS", OBJETIVOS)
                .AddWithValue("@PERIODO_REF1", PERIODO_REF1)
                .AddWithValue("@PERIODO_REF2", PERIODO_REF2)
                .AddWithValue("@DATA_ELABORACAO", DATA_ELABORACAO)
                .AddWithValue("@DATA_ANALISE", DATA_ANALISE)
            End With

            idAnaliseDados = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idAnaliseDados As Integer, _
                           ByVal COLABORADORES As Integer, _
                           ByVal TIPO_IDENTIFICACAO As String, _
                           ByVal IDENTIFICACAO As String, _
                           ByVal OBJETIVOS As String, _
                           ByVal PERIODO_REF1 As Date, _
                           ByVal PERIODO_REF2 As Date, _
                           ByVal DATA_ELABORACAO As Date, _
                           ByVal DATA_ANALISE As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_ANALISE_CRITICA_DADOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_ANALISE_CRITICA_DADOS", idAnaliseDados)
                .AddWithValue("@ID_COLABORADORES", COLABORADORES)
                .AddWithValue("@TIPO_IDENTIFICACAO", TIPO_IDENTIFICACAO)
                .AddWithValue("@IDENTIFICACAO", IDENTIFICACAO)
                .AddWithValue("@OBJETIVOS", OBJETIVOS)
                .AddWithValue("@PERIODO_REF1", PERIODO_REF1)
                .AddWithValue("@PERIODO_REF2", PERIODO_REF2)
                .AddWithValue("@DATA_ELABORACAO", DATA_ELABORACAO)
                .AddWithValue("@DATA_ANALISE", DATA_ANALISE)
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
        Dim _cmdText As String = "[DELETE_ANALISE_CRITICA_DADOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_ANALISE_CRITICA_DADOS", id)
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
