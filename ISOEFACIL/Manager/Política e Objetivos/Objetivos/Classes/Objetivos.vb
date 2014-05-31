Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class objetivos

#Region "OBJETIVOS"

    Public Function Add(ByVal TIPO As Integer, _
                        ByVal ID_UNIDADE_MEDICAO As Integer, _
                        ByVal COLABORADORES As Integer, _
                        ByVal TITULO As String, _
                        ByVal IDENTIFICACAO As String, _
                        ByVal DESCRICAO As String, _
                        ByVal FORMA_CALCULO As String, _
                        ByVal METAS_OBJETIVO As Integer, _
                        ByVal PERIODO_X As Date, _
                        ByVal PERIODO_Y As Date, _
                        ByVal PERIODICIDADE_MEDICAO As Integer, _
                        ByVal DATA_CADASTRO As Date, _
                        Optional ByRef idobjetivos As Integer = 0) As String

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_OBJETIVOS"
        Dim id As String = String.Empty

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_NORMAS", TIPO)
                .AddWithValue("@ID_UNIDADE_MEDICAO", ID_UNIDADE_MEDICAO)
                .AddWithValue("@ID_COLABORADORES", COLABORADORES)
                .AddWithValue("@TITULO", TITULO)
                .AddWithValue("@IDENTIFICACAO", IDENTIFICACAO)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@FORMA_CALCULO", FORMA_CALCULO)
                .AddWithValue("@METAS_OBJETIVO", METAS_OBJETIVO)
                .AddWithValue("@PERIODO_X", PERIODO_X)
                .AddWithValue("@PERIODO_Y", PERIODO_Y)
                .AddWithValue("@PERIODICIDADE_MEDICAO", PERIODICIDADE_MEDICAO)
                .AddWithValue("@DATA_CADASTRO", DATA_CADASTRO)
                .AddWithValue("@MSG", "")
            End With

            Using sdr As SqlDataReader = _Command.ExecuteReader
                If sdr.Read Then
                    id = sdr("RESULTADO").ToString
                End If
            End Using

            Return id.ToString
            _Connection.Close()

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idobjetivos As Integer, _
                        ByVal TIPO As Integer, _
                        ByVal ID_UNIDADE_MEDICAO As Integer, _
                        ByVal COLABORADORES As Integer, _
                        ByVal TITULO As String, _
                        ByVal IDENTIFICACAO As String, _
                        ByVal DESCRICAO As String, _
                        ByVal FORMA_CALCULO As String, _
                        ByVal METAS_OBJETIVO As Integer, _
                        ByVal PERIODO_X As Date, _
                        ByVal PERIODO_Y As Date, _
                        ByVal PERIODICIDADE_MEDICAO As Integer, _
                        ByVal DATA_CADASTRO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_OBJETIVOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_OBJETIVOS", idobjetivos)
                .AddWithValue("@ID_NORMAS", TIPO)
                .AddWithValue("@ID_UNIDADE_MEDICAO", ID_UNIDADE_MEDICAO)
                .AddWithValue("@ID_COLABORADORES", COLABORADORES)
                .AddWithValue("@TITULO", TITULO)
                .AddWithValue("@IDENTIFICACAO", IDENTIFICACAO)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@FORMA_CALCULO", FORMA_CALCULO)
                .AddWithValue("@METAS_OBJETIVO", METAS_OBJETIVO)
                .AddWithValue("@PERIODO_X", PERIODO_X)
                .AddWithValue("@PERIODO_Y", PERIODO_Y)
                .AddWithValue("@PERIODICIDADE_MEDICAO", PERIODICIDADE_MEDICAO)
                .AddWithValue("@DATA_CADASTRO", DATA_CADASTRO)
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
        Dim _cmdText As String = "[DELETE_OBJETIVOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_OBJETIVOS", id)
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
