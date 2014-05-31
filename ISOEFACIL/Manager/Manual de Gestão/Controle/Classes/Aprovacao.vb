Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class aprovacao

#Region "APROVAÇÃO"

    Public Function Add(ByVal ID_MANUAL_CONTROLE As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal ID_CARGOS As Integer, _
                        ByVal DATA_EMISSAO As Date, _
                        ByVal REVISOES As String, _
                        ByVal DATA_APROVACAO As Date, _
                        Optional ByRef idaprovacao As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_MANUAL_CONTROLE_APROVACAO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MANUAL_CONTROLE", ID_MANUAL_CONTROLE)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_CARGOS", ID_CARGOS)
                .AddWithValue("@DATA_EMISSAO", DATA_EMISSAO)
                .AddWithValue("@REVISOES", REVISOES)
                .AddWithValue("@DATA_APROVACAO", DATA_APROVACAO)
            End With

            idaprovacao = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idaprovacao As Integer, _
                           ByVal ID_MANUAL_CONTROLE As Integer, _
                           ByVal ID_COLABORADORES As Integer, _
                           ByVal ID_CARGOS As Integer, _
                           ByVal DATA_EMISSAO As Date, _
                           ByVal REVISOES As String, _
                           ByVal DATA_APROVACAO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MANUAL_CONTROLE_APROVACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MANUAL_CONTROLE_APROVACAO", idaprovacao)
                .AddWithValue("@ID_MANUAL_CONTROLE", ID_MANUAL_CONTROLE)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_CARGOS", ID_CARGOS)
                .AddWithValue("@DATA_EMISSAO", DATA_EMISSAO)
                .AddWithValue("@REVISOES", REVISOES)
                .AddWithValue("@DATA_APROVACAO", DATA_APROVACAO)
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
        Dim _cmdText As String = "[DELETE_MANUAL_CONTROLE_APROVACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MANUAL_CONTROLE_APROVACAO", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "REVISAO"

    Public Function UpdateRevisao(ByVal id As Integer, _
                           ByVal REVISAO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MANUAL_CONTROLE_REVISAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_MANUAL_CONTROLE", id)
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

End Class
