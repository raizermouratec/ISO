Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class processo

#Region "PROCESSOS"

    Public Function Add(ByVal ID_AREAS As Integer, _
                        ByVal NOME As String, _
                        ByVal OBJETIVOS As String, _
                        ByVal ENTRADAS As String, _
                        ByVal FORNECEDORES As String, _
                        ByVal SAIDAS As String, _
                        ByVal CLIENTES As String,
                        Optional ByRef idprocessos As Integer = 0) As String

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROCESSOS"
        Dim id As String = String.Empty

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AREAS", ID_AREAS)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@OBJETIVOS", OBJETIVOS)
                .AddWithValue("@ENTRADAS", ENTRADAS)
                .AddWithValue("@FORNECEDORES", FORNECEDORES)
                .AddWithValue("@SAIDAS", SAIDAS)
                .AddWithValue("@CLIENTES", CLIENTES)
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

    Public Function Update(ByVal idprocessos As Integer, _
                        ByVal ID_AREAS As Integer, _
                        ByVal NOME As String, _
                        ByVal OBJETIVOS As String, _
                        ByVal ENTRADAS As String, _
                        ByVal FORNECEDORES As String, _
                        ByVal SAIDAS As String, _
                        ByVal CLIENTES As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROCESSOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROCESSOS", idprocessos)
                .AddWithValue("@ID_AREAS", ID_AREAS)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@OBJETIVOS", OBJETIVOS)
                .AddWithValue("@ENTRADAS", ENTRADAS)
                .AddWithValue("@FORNECEDORES", FORNECEDORES)
                .AddWithValue("@SAIDAS", SAIDAS)
                .AddWithValue("@CLIENTES", CLIENTES)
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
        Dim _cmdText As String = "[DELETE_PROCESSOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROCESSOS", id)
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
