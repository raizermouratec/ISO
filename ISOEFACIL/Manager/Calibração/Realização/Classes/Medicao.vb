Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class medicao

    Public Function Add(ByVal ID_CALIBRACOES_REALIZAR_INTERNA As Integer, _
                       ByVal MEDIDA_PADRAO As Double, _
                       ByVal MEDIDA_VERIFICADA As Double, _
                       ByVal ERRO_ABSOLUTO As Double, _
                       ByVal ERRO_RELATIVO As String, _
                       ByVal UNIDADE_MEDIDA As String, _
                       Optional ByRef idMedicao As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_CALIBRACOES_REALIZAR_INTERNA_MEDICAO"


        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            'Limpar mascaras
            With _Command.Parameters

                .AddWithValue("@ID_CALIBRACOES_REALIZAR_INTERNA", ID_CALIBRACOES_REALIZAR_INTERNA)
                .AddWithValue("@MEDIDA_PADRAO", MEDIDA_PADRAO)
                .AddWithValue("@MEDIDA_VERIFICADA", MEDIDA_VERIFICADA)
                .AddWithValue("@ERRO_ABSOLUTO", ERRO_ABSOLUTO)
                .AddWithValue("@ERRO_RELATIVO", ERRO_RELATIVO)
                .AddWithValue("@UNIDADE_MEDIDA", UNIDADE_MEDIDA)

            End With

            idMedicao = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False

        End Try

    End Function

    Public Function Update(
                       ByVal idMedicao As Integer, _
                       ByVal ID_CALIBRACOES_REALIZAR_INTERNA As Integer, _
                       ByVal MEDIDA_PADRAO As Double, _
                       ByVal MEDIDA_VERIFICADA As Double, _
                       ByVal ERRO_ABSOLUTO As Double, _
                       ByVal ERRO_RELATIVO As String, _
                       ByVal UNIDADE_MEDIDA As String) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CALIBRACOES_REALIZAR_INTERNA_MEDICAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_CALIBRACOES_REALIZAR_INTERNA_MEDICAO", idMedicao)
                .AddWithValue("@ID_CALIBRACOES_REALIZAR_INTERNA", ID_CALIBRACOES_REALIZAR_INTERNA)
                .AddWithValue("@MEDIDA_PADRAO", MEDIDA_PADRAO)
                .AddWithValue("@MEDIDA_VERIFICADA", MEDIDA_VERIFICADA)
                .AddWithValue("@ERRO_ABSOLUTO", ERRO_ABSOLUTO)
                .AddWithValue("@ERRO_RELATIVO", ERRO_RELATIVO)
                .AddWithValue("@UNIDADE_MEDIDA", UNIDADE_MEDIDA)

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
        Dim _cmdText As String = "[DELETE_CALIBRACOES_REALIZAR_INTERNA_MEDICAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_CALIBRACOES_REALIZAR_INTERNA_MEDICAO", id)

            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
