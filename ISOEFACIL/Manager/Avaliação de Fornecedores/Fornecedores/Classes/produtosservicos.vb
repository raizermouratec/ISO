Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Imports ISOEFACIL.forListaOcorrencias
Imports ISOEFACIL.forCadOcorrencias
Imports ISOEFACIL.GeralCadContato
Public Class produtosServicos

    Public Function Add(ByVal ID_FORNECEDOR As Integer, _
                       ByVal DESCRICAO As String, _
                       ByVal CRITICO As Integer, _
                      Optional ByRef idprodutosServicos As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_FORNECEDORES_PROD_SERV"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDOR", ID_FORNECEDOR)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@CRITICO", CRITICO)
            End With

            idprodutosServicos = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idprodutosServicos As Integer, _
                        ByVal DESCRICAO As String, _
                        ByVal CRITICO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_FORNECEDORES_PROD_SERV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROD_SERV", idprodutosServicos)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@CRITICO", CRITICO)
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
        Dim _cmdText As String = "[DELETE_FORNECEDORES_PROD_SERV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROD_SERV", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class