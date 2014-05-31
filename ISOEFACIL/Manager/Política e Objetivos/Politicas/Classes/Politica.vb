Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class politica

#Region "POLITICA"

    Public Function Add(ByVal COLABORADORES As Integer, _
                        ByVal ID As Integer, _
                        ByVal NOME As String, _
                        ByVal REVISAO As String, _
                        ByVal TEXTO_POLITICA As String, _
                        ByVal DATA As Date, _
                        Optional ByRef idregistroPO As Integer = 0) As String


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_POLITICA"


        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_COLABORADORES", COLABORADORES)
                .AddWithValue("@ID", ID)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@TEXTO_POLITICA", TEXTO_POLITICA)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@MSG", "")

            End With

            Using sdr As SqlDataReader = _Command.ExecuteReader
                If sdr.Read Then
                    ID = sdr("RESULTADO").ToString
                End If
            End Using
            Return ID.ToString
            _Connection.Close()

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idregistroPO As Integer, _
                           ByVal COLABORADORES As Integer, _
                           ByVal ID As Integer, _
                           ByVal NOME As String, _
                           ByVal REVISAO As String, _
                           ByVal TEXTO_POLITICA As String, _
                           ByVal DATA As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_POLITICA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_POLITICA", idregistroPO)
                .AddWithValue("@ID_COLABORADORES", COLABORADORES)
                .AddWithValue("@ID", ID)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@TEXTO_POLITICA", TEXTO_POLITICA)
                .AddWithValue("@DATA", DATA)

            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateID(ByVal idID As Integer, _
                           ByVal ID As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_POLITICA_ID]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_POLITICA", idID)
                .AddWithValue("@ID", ID)

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
        Dim _cmdText As String = "[DELETE_POLITICA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_POLITICA", id)
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
