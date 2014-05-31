Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class atividade

#Region "PROCESSOS ATIVIDADE"

    Public Function Add(ByVal ID_PROCESSOS As Integer, _
                        ByVal N_ATIVIDADE As Integer, _
                        ByVal O_QUE As String, _
                        ByVal QUEM As Integer, _
                        ByVal CAMPO_LIVRE As String, _
                        ByVal AREAS As Integer, _
                        ByVal CARGOS As Integer,
                        Optional ByRef idprocessosatividade As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROCESSOS_ATIVIDADE"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROCESSOS", ID_PROCESSOS)
                .AddWithValue("@N_ATIVIDADE", N_ATIVIDADE)
                .AddWithValue("@O_QUE", O_QUE)
                .AddWithValue("@QUEM", QUEM)
                .AddWithValue("@CAMPO_LIVRE", CAMPO_LIVRE)
                .AddWithValue("@AREAS", AREAS)
                .AddWithValue("@CARGOS", CARGOS)
            End With

            idprocessosatividade = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idprocessosatividade As Integer, _
                           ByVal ID_PROCESSOS As Integer, _
                           ByVal N_ATIVIDADE As Integer, _
                           ByVal O_QUE As String, _
                           ByVal QUEM As Integer, _
                           ByVal CAMPO_LIVRE As String, _
                           ByVal AREAS As Integer, _
                           ByVal CARGOS As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROCESSOS_ATIVIDADE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROCESSOS_ATIVIDADE", idprocessosatividade)
                .AddWithValue("@ID_PROCESSOS", ID_PROCESSOS)
                .AddWithValue("@N_ATIVIDADE", N_ATIVIDADE)
                .AddWithValue("@O_QUE", O_QUE)
                .AddWithValue("@QUEM", QUEM)
                .AddWithValue("@CAMPO_LIVRE", CAMPO_LIVRE)
                .AddWithValue("@AREAS", AREAS)
                .AddWithValue("@CARGOS", CARGOS)
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
        Dim _cmdText As String = "[DELETE_PROCESSOS_ATIVIDADE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROCESSOS_ATIVIDADE", id)
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
