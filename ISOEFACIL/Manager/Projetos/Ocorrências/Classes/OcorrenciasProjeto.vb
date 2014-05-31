Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class ocorrenciasprojeto

#Region "OCORRENCIAS"

    Public Function Add(ByVal ID_COLABORADORES As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal TITULO As String, _
                        ByVal DESCRICAO As String, _
                        ByVal DATA As Date,
                        Optional ByRef idocorrencias As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_OCORRENCIAS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@TITULO", TITULO)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@DATA", DATA)
            End With

            idocorrencias = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idocorrencias As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal TITULO As String, _
                        ByVal DESCRICAO As String, _
                        ByVal DATA As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_OCORRENCIAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_OCORRENCIAS", idocorrencias)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@TITULO", TITULO)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@DATA", DATA)
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
        Dim _cmdText As String = "[DELETE_PROJETOS_OCORRENCIAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_OCORRENCIAS", id)
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
