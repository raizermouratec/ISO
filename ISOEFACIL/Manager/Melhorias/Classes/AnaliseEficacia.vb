Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class analiseeficacia

#Region "Análise de Eficácia"

    Public Function AddAEF(ByVal MELHORIAS As Integer, _
                           ByVal METODO_DE_ANALISE As String, _
                           ByVal RESULTADOS_OBTIDOS As String, _
                           ByVal ACAO_EFICAZ As Boolean, _
                           ByVal NEGATIVO_JUSTIFIQUE As String, _
                           ByVal O_QUE_FAZ As String, _
                           ByVal RESPONSAVEL As Integer, _
                           ByVal DATA_RESP As Date, _
                           Optional ByRef idregistroEF As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_MELHORIAS_ANALISE_EFICACIA"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure


            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS", MELHORIAS)
                .AddWithValue("@METODO_DE_ANALISE", METODO_DE_ANALISE)
                .AddWithValue("@RESULTADOS_OBTIDOS", RESULTADOS_OBTIDOS)
                .AddWithValue("@ACAO_EFICAZ", ACAO_EFICAZ)
                .AddWithValue("@NEGATIVO_JUSTIFIQUE", NEGATIVO_JUSTIFIQUE)
                .AddWithValue("@O_QUE_FAZ", O_QUE_FAZ)
                .AddWithValue("@RESPONSAVEL", RESPONSAVEL)
                .AddWithValue("@DATA_RESP", DATA_RESP)

            End With

            idregistroEF = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateEF(ByVal idregistroEF As Integer, _
                        ByVal MELHORIAS As Integer, _
                        ByVal METODO_DE_ANALISE As String, _
                        ByVal RESULTADOS_OBTIDOS As String, _
                        ByVal ACAO_EFICAZ As Boolean, _
                        ByVal NEGATIVO_JUSTIFIQUE As String, _
                        ByVal O_QUE_FAZ As String, _
                        ByVal RESPONSAVEL As Integer, _
                        ByVal DATA_RESP As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MELHORIAS_ANALISE_EFICACIA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS_ANALISE_EFICACIA", idregistroEF)
                .AddWithValue("@ID_MELHORIAS", MELHORIAS)
                .AddWithValue("@METODO_DE_ANALISE", METODO_DE_ANALISE)
                .AddWithValue("@RESULTADOS_OBTIDOS", RESULTADOS_OBTIDOS)
                .AddWithValue("@ACAO_EFICAZ", ACAO_EFICAZ)
                .AddWithValue("@NEGATIVO_JUSTIFIQUE", NEGATIVO_JUSTIFIQUE)
                .AddWithValue("@O_QUE_FAZ", O_QUE_FAZ)
                .AddWithValue("@RESPONSAVEL", RESPONSAVEL)
                .AddWithValue("@DATA_RESP", DATA_RESP)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteEF(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_MELHORIAS_ANALISE_EFICACIA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS_ANALISE_EFICACIA", id)
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
