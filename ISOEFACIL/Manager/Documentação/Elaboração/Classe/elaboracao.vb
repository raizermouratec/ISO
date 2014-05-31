Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms

Public Class elaboracao

#Region "ANEXO"
    '//ADD
    Public Function Add(ByVal CODIGO_DOCUMENTO As String, _
                        ByVal REVISAO As Integer, _
                        ByVal DESCRICAO As String, _
                        ByVal ANEXO() As Byte, _
                        ByVal TIPO As String, _
                        Optional ByRef id As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_ELABORACAO_ANEXOS]"

        Try
            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO_DOCUMENTO", CODIGO_DOCUMENTO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@ANEXO", ANEXO)
                .AddWithValue("@TIPO", TIPO)
            End With

            id = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
    '//DELETE
    Public Function Delete(ByVal CODIGO_DOCUMENTO As String, _
                            ByVal REVISAO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_DOCUMENTO_ELABORACAO_ANEXOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO_DOCUMENTO", CODIGO_DOCUMENTO)
                .AddWithValue("@REVISAO", REVISAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "ELABORAÇÃO TEXTO"
    '//ADD
    Public Function AddElabTexto(ByVal CODIGO_DOCUMENTO As String, _
                                 ByVal REVISAO As Integer, _
                                 ByVal TEXTO As String, _
                                 Optional ByRef id As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_ELABORACAO_TEXTO]"

        Try
            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO_DOCUMENTO", CODIGO_DOCUMENTO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@TEXTO", TEXTO)
            End With

            id = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function




#End Region

#Region "ELABORAÇÃO VINCULADOS"
    '//ADD
    Public Function AddElabVinc(ByVal CODIGO_DOCUMENTO As String, _
                                 ByVal REVISAO As Integer, _
                                 ByVal ITEM As Integer, _
                                 ByVal TIPO_ATIVIDADE As String, _
                                 ByVal CODIGO_DOCUMENTO_VINC As String, _
                                 Optional ByRef id As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_ELABORACAO_VICULADOS]"

        Try
            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO_DOCUMENTO", CODIGO_DOCUMENTO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@ITEM", ITEM)
                .AddWithValue("@TIPO_ATIVIDADE", TIPO_ATIVIDADE)
                .AddWithValue("@CODIGO_DOCUMENTO_VINC", CODIGO_DOCUMENTO_VINC)
            End With

            id = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region



End Class
