Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class equipe

#Region "INTERNO"

    Public Function AddInt(ByVal ID_PROJETOS As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal ID_CARGOS As Integer, _
                        ByVal ATRIBUICAO As String, _
                        ByVal TIPO As Boolean, _
                        Optional ByRef idequipeint As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_EQUIPE_INTERNO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_CARGOS", ID_CARGOS)
                .AddWithValue("@ATRIBUICAO", ATRIBUICAO)
                .AddWithValue("@TIPO", TIPO)
            End With

            idequipeint = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateInt(ByVal idequipeint As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal ID_CARGOS As Integer, _
                        ByVal ATRIBUICAO As String, _
                        ByVal TIPO As Boolean) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_EQUIPE_INTERNO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_EQUIPE_INTERNO", idequipeint)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_CARGOS", ID_CARGOS)
                .AddWithValue("@ATRIBUICAO", ATRIBUICAO)
                .AddWithValue("@TIPO", TIPO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteInt(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_PROJETOS_EQUIPE_INTERNO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_EQUIPE_INTERNO", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "EXTERNO"

    Public Function AddExt(ByVal ID_PROJETOS As Integer, _
                           ByVal NOME As String, _
                           ByVal CARGOS As String, _
                           ByVal ATRIBUICAO As String, _
                           ByVal TIPO As Boolean, _
                           Optional ByRef idequipeext As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_EQUIPE_EXTERNO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@CARGOS", CARGOS)
                .AddWithValue("@ATRIBUICAO", ATRIBUICAO)
                .AddWithValue("@TIPO", TIPO)
            End With

            idequipeext = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateExt(ByVal idequipeext As Integer, _
                              ByVal ID_PROJETOS As Integer, _
                              ByVal NOME As String, _
                              ByVal CARGOS As String, _
                              ByVal ATRIBUICAO As String, _
                              ByVal TIPO As Boolean) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_EQUIPE_EXTERNO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_EQUIPE_EXTERNO", idequipeext)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@CARGOS", CARGOS)
                .AddWithValue("@ATRIBUICAO", ATRIBUICAO)
                .AddWithValue("@TIPO", TIPO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteExt(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_PROJETOS_EQUIPE_EXTERNO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_EQUIPE_EXTERNO", id)
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
