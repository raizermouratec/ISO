Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class colaboradores

#Region "Colaboradores"

    Public Function Add(ByVal ID_AREAS As Integer, _
                        ByVal ID_CARGOS As Integer, _
                        ByVal COLABORADOR As String, _
                        ByVal EMAIL As String, _
                        ByVal SITUACAO As Boolean, _
                        ByVal APROVADOR As Boolean,
                        ByVal CHECK As Boolean,
                        Optional ByRef idcolaboradores As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_COLABORADORES"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AREAS", ID_AREAS)
                .AddWithValue("@ID_CARGOS", ID_CARGOS)
                .AddWithValue("@COLABORADOR", COLABORADOR)
                .AddWithValue("@EMAIL", EMAIL)
                .AddWithValue("@SITUACAO", SITUACAO)
                .AddWithValue("@APROVADOR", APROVADOR)
                .AddWithValue("@CHECKS", CHECK)
            End With

            idcolaboradores = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idcolaboradores As Integer, _
                           ByVal ID_AREAS As Integer, _
                           ByVal ID_CARGOS As Integer, _
                           ByVal COLABORADOR As String, _
                           ByVal EMAIL As String, _
                           ByVal SITUACAO As Boolean, _
                           ByVal APROVADOR As Boolean, _
                           ByVal CHECK As Boolean) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_COLABORADORES]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", idcolaboradores)
                .AddWithValue("@ID_AREAS", ID_AREAS)
                .AddWithValue("@ID_CARGOS", ID_CARGOS)
                .AddWithValue("@COLABORADOR", COLABORADOR)
                .AddWithValue("@EMAIL", EMAIL)
                .AddWithValue("@SITUACAO", SITUACAO)
                .AddWithValue("@APROVADOR", APROVADOR)
                .AddWithValue("@CHECKS", CHECK)
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
        Dim _cmdText As String = "[DELETE_COLABORADORES]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", id)
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
