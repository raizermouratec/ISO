Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class Contatos

    Public Function Add(ByVal ID_MODULO As Integer, _
                                   ByVal MODULO As String, _
                                   ByVal NOME As String, _
                                   ByVal CARGO As String, _
                                   ByVal TELEFONE_FIXO As String, _
                                   ByVal TELEFONE_CEL As String, _
                                   ByVal TELEFONE_FAX As String, _
                                   ByVal EMAIL As String, _
                                   ByVal SKYPE As String, _
                      Optional ByRef idContatos As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_CONTATOS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MODULO", ID_MODULO)
                .AddWithValue("@MODULO", MODULO)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@CARGO", CARGO)
                .AddWithValue("@TELEFONE_FIXO", TELEFONE_FIXO)
                .AddWithValue("@TELEFONE_CEL", TELEFONE_CEL)
                .AddWithValue("@TELEFONE_FAX", TELEFONE_FAX)
                .AddWithValue("@EMAIL", EMAIL)
                .AddWithValue("@SKYPE", SKYPE)
            End With

            idContatos = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idContatos As Integer, _
                                 ByVal NOME As String, _
                                 ByVal CARGO As String, _
                                 ByVal TELEFONE_FIXO As String, _
                                 ByVal TELEFONE_CELULAR As String, _
                                 ByVal TELEFONE_FAX As String, _
                                 ByVal EMAIL As String, _
                                 ByVal SKYPE As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CONTATOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CONTATOS", idContatos)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@CARGO", CARGO)
                .AddWithValue("@TELEFONE_FIXO", TELEFONE_FIXO)
                .AddWithValue("@TELEFONE_CELULAR", TELEFONE_CELULAR)
                .AddWithValue("@TELEFONE_FAX", TELEFONE_FAX)
                .AddWithValue("@EMAIL", EMAIL)
                .AddWithValue("@SKYPE", SKYPE)
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
        Dim _cmdText As String = "[DELETE_CONTATOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CONTATOS", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class