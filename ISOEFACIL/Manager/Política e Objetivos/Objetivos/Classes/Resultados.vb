Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class resultados

#Region "Resultados"

    Public Function Add(ByVal OBJETIVOS As Integer, _
                        ByVal COLABORADORES As Integer, _
                        ByVal RESULTADO_OBTIDO As String, _
                        ByVal DATA_MEDICAO As Date, _
                        Optional ByRef idresultados As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_OBJETIVOS_RESULTADOS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure


            With _Command.Parameters
                .AddWithValue("@ID_OBJETIVOS", OBJETIVOS)
                .AddWithValue("@ID_COLABORADORES", COLABORADORES)
                .AddWithValue("@RESULTADO_OBTIDO", RESULTADO_OBTIDO)
                .AddWithValue("@DATA_MEDICAO", DATA_MEDICAO)
            End With

            idresultados = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idresultados As Integer, _
                        ByVal OBJETIVOS As Integer, _
                        ByVal COLABORADORES As Integer, _
                        ByVal RESULTADO_OBTIDO As String, _
                        ByVal DATA_MEDICAO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_OBJETIVOS_RESULTADOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_OBJETIVOS_RESULTADOS", idresultados)
                .AddWithValue("@ID_OBJETIVOS", OBJETIVOS)
                .AddWithValue("@ID_COLABORADORES", COLABORADORES)
                .AddWithValue("@RESULTADO_OBTIDO", RESULTADO_OBTIDO)
                .AddWithValue("@DATA_MEDICAO", DATA_MEDICAO)
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
        Dim _cmdText As String = "[DELETE_OBJETIVOS_RESULTADOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_OBJETIVOS_RESULTADOS", id)
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
