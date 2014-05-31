Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class objestruturado

#Region "OBJETIVO ESTRUTURADO"

    Public Function Add(ByVal ID_OBJETIVOS As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal RESULTADO As String, _
                        ByVal QUANTIDADE As Integer, _
                        ByVal UNIDADE As Integer, _
                        ByVal AVALIACAO As String, _
                        ByVal ALCANCADO As Boolean, _
                        Optional ByRef idestruturado As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_PLANO_OBJETIVOS_ESTRUTURADO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_OBJETIVOS", ID_OBJETIVOS)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@RESULTADO", RESULTADO)
                .AddWithValue("@QUANTIDADE", QUANTIDADE)
                .AddWithValue("@UNIDADE", UNIDADE)
                .AddWithValue("@AVALIACAO", AVALIACAO)
                .AddWithValue("@ALCANCADO", ALCANCADO)
            End With

            idestruturado = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idestruturado As Integer, _
                        ByVal ID_OBJETIVOS As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal RESULTADO As String, _
                        ByVal QUANTIDADE As Integer, _
                        ByVal UNIDADE As Integer, _
                        ByVal AVALIACAO As String, _
                        ByVal ALCANCADO As Boolean) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_PLANO_OBJETIVOS_ESTRUTURADO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_EQUIPE_INTERNO", idestruturado)
                .AddWithValue("@ID_OBJETIVOS", ID_OBJETIVOS)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@RESULTADO", RESULTADO)
                .AddWithValue("@QUANTIDADE", QUANTIDADE)
                .AddWithValue("@UNIDADE", UNIDADE)
                .AddWithValue("@AVALIACAO", avaliacao)
                .AddWithValue("@ALCANCADO", ALCANCADO)
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
        Dim _cmdText As String = "[DELETE_PROJETOS_PLANO_OBJETIVOS_ESTRUTURADO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_OBJETIVOS_ESTRUTURADO", id)
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
