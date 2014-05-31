Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class estruturado

#Region "Adicionar Ações Estruturadas"

    Public Function Add(ByVal ID_MELHORIAS As Integer, _
                        ByVal ACAO As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal NUMERO As String, _
                        ByVal O_QUE As String, _
                        ByVal COMO As String, _
                        ByVal QUANDO_CHECK As Boolean, _
                        ByVal QUANDO As String, _
                        ByVal QUANDO_DATA As Date, _
                        ByVal RESULTADOS As String, _
                        Optional ByRef idEstruturado As Integer = 0) As Integer


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_MELHORIAS_ESTRUTURADO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure


            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS", ID_MELHORIAS)
                .AddWithValue("@ACAO", ACAO)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@NUMERO", NUMERO)
                .AddWithValue("@O_QUE", O_QUE)
                .AddWithValue("@COMO", COMO)
                .AddWithValue("@QUANDO_CHECK", QUANDO_CHECK)
                .AddWithValue("@QUANDO", QUANDO)
                .AddWithValue("@QUANDO_DATA", QUANDO_DATA)
                .AddWithValue("@RESULTADOS", RESULTADOS)
            End With

            idEstruturado = _Command.ExecuteScalar

            Return idEstruturado
            _Connection.Close()

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idEstruturado As Integer, _
                           ByVal ID_MELHORIAS As Integer, _
                           ByVal ACAO As Integer, _
                           ByVal ID_COLABORADORES As Integer, _
                           ByVal NUMERO As String, _
                           ByVal O_QUE As String, _
                           ByVal COMO As String, _
                           ByVal QUANDO_CHECK As Boolean, _
                           ByVal QUANDO As String, _
                           ByVal QUANDO_DATA As Date, _
                           ByVal RESULTADOS As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MELHORIAS_ESTRUTURADO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS_ESTRUTURADO", idEstruturado)
                .AddWithValue("@ID_MELHORIAS", ID_MELHORIAS)
                .AddWithValue("@ACAO", ACAO)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@NUMERO", NUMERO)
                .AddWithValue("@O_QUE", O_QUE)
                .AddWithValue("@COMO", COMO)
                .AddWithValue("@QUANDO_CHECK", QUANDO_CHECK)
                .AddWithValue("@QUANDO", QUANDO)
                .AddWithValue("@QUANDO_DATA", QUANDO_DATA)
                .AddWithValue("@RESULTADOS", RESULTADOS)
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
        Dim _cmdText As String = "[DELETE_MELHORIAS_ESTRUTURADO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS_ESTRUTURADO", id)
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
