Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class acoesnecessarias

#Region "Ações Necessárias"

#Region "Ação Corretiva"

    Public Function AddAC(ByVal MELHORIAS As Integer, _
                        ByVal DESCRICAO As String, _
                        ByVal CAUSAS As String, _
                        ByVal CORRECAO As String, _
                        ByVal ACOES_NECESSARIAS As Boolean, _
                        ByVal ACOES_NECESSARIAS_TEXTO As String, _
                        ByVal RESULTADOS As String, _
                        ByVal RESPONSAVEL As Integer, _
                        ByVal DATA_RESP As Date, _
                        ByVal APROVACAO As Boolean, _
                        ByVal RESPONSAVEL_APROVACAO As Integer, _
                        ByVal DATA_APROVACAO As Date, _
                        Optional ByRef idregistroAC As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_MELHORIAS_AC"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS", MELHORIAS)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@CAUSAS", CAUSAS)
                .AddWithValue("@CORRECAO", CORRECAO)
                .AddWithValue("@ACOES_NECESSARIAS", ACOES_NECESSARIAS)
                .AddWithValue("@ACOES_NECESSARIAS_TEXTO", ACOES_NECESSARIAS_TEXTO)
                .AddWithValue("@RESULTADOS", RESULTADOS)
                .AddWithValue("@RESPONSAVEL", RESPONSAVEL)
                .AddWithValue("@DATA_RESP", DATA_RESP)
                .AddWithValue("@APROVACAO", APROVACAO)
                .AddWithValue("@RESPONSAVEL_APROVACAO", RESPONSAVEL_APROVACAO)
                .AddWithValue("@DATA_APROVACAO", DATA_APROVACAO)
            End With

            idregistroAC = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateAC(ByVal idregistroAC As Integer, _
                             ByVal MELHORIAS As Integer, _
                        ByVal DESCRICAO As String, _
                        ByVal CAUSAS As String, _
                        ByVal CORRECAO As String, _
                        ByVal ACOES_NECESSARIAS As Boolean, _
                        ByVal ACOES_NECESSARIAS_TEXTO As String, _
                        ByVal RESULTADOS As String, _
                        ByVal RESPONSAVEL As Integer, _
                        ByVal DATA_RESP As Date, _
                        ByVal APROVACAO As Boolean, _
                        ByVal RESPONSAVEL_APROVACAO As Integer, _
                        ByVal DATA_APROVACAO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MELHORIAS_AC]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS_AC", idregistroAC)
                .AddWithValue("@ID_MELHORIAS", MELHORIAS)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@CAUSAS", CAUSAS)
                .AddWithValue("@CORRECAO", CORRECAO)
                .AddWithValue("@ACOES_NECESSARIAS", ACOES_NECESSARIAS)
                .AddWithValue("@ACOES_NECESSARIAS_TEXTO", ACOES_NECESSARIAS_TEXTO)
                .AddWithValue("@RESULTADOS", RESULTADOS)
                .AddWithValue("@RESPONSAVEL", RESPONSAVEL)
                .AddWithValue("@DATA_RESP", DATA_RESP)
                .AddWithValue("@APROVACAO", APROVACAO)
                .AddWithValue("@RESPONSAVEL_APROVACAO", RESPONSAVEL_APROVACAO)
                .AddWithValue("@DATA_APROVACAO", DATA_APROVACAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteAC(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_MELHORIAS_AC]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS_AC", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "Ação Preventiva"

    Public Function AddAP(ByVal MELHORIAS As Integer, _
                        ByVal DESCRICAO As String, _
                        ByVal CAUSAS As String, _
                        ByVal ACOES_NECESSARIAS As Boolean, _
                        ByVal ACOES_NECESSARIAS_TEXTO As String, _
                        ByVal RESULTADOS As String, _
                        ByVal RESPONSAVEL As Integer, _
                        ByVal DATA_RESP As Date, _
                        ByVal APROVACAO As Boolean, _
                        ByVal RESPONSAVEL_APROVACAO As Integer, _
                        ByVal DATA_APROVACAO As Date, _
                        Optional ByRef idregistroAP As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_MELHORIAS_AP"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS", MELHORIAS)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@CAUSAS", CAUSAS)
                .AddWithValue("@ACOES_NECESSARIAS", ACOES_NECESSARIAS)
                .AddWithValue("@ACOES_NECESSARIAS_TEXTO", ACOES_NECESSARIAS_TEXTO)
                .AddWithValue("@RESULTADOS", RESULTADOS)
                .AddWithValue("@RESPONSAVEL", RESPONSAVEL)
                .AddWithValue("@DATA_RESP", DATA_RESP)
                .AddWithValue("@APROVACAO", APROVACAO)
                .AddWithValue("@RESPONSAVEL_APROVACAO", RESPONSAVEL_APROVACAO)
                .AddWithValue("@DATA_APROVACAO", DATA_APROVACAO)
            End With

            idregistroAP = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateAP(ByVal idregistroAP As Integer, _
                        ByVal MELHORIAS As Integer, _
                        ByVal DESCRICAO As String, _
                        ByVal CAUSAS As String, _
                        ByVal ACOES_NECESSARIAS As Boolean, _
                        ByVal ACOES_NECESSARIAS_TEXTO As String, _
                        ByVal RESULTADOS As String, _
                        ByVal RESPONSAVEL As Integer, _
                        ByVal DATA_RESP As Date, _
                        ByVal APROVACAO As Boolean, _
                        ByVal RESPONSAVEL_APROVACAO As Integer, _
                        ByVal DATA_APROVACAO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MELHORIAS_AP]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure


            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS_AP", idregistroAP)
                .AddWithValue("@ID_MELHORIAS", MELHORIAS)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@CAUSAS", CAUSAS)
                .AddWithValue("@ACOES_NECESSARIAS", ACOES_NECESSARIAS)
                .AddWithValue("@ACOES_NECESSARIAS_TEXTO", ACOES_NECESSARIAS_TEXTO)
                .AddWithValue("@RESULTADOS", RESULTADOS)
                .AddWithValue("@RESPONSAVEL", RESPONSAVEL)
                .AddWithValue("@DATA_RESP", DATA_RESP)
                .AddWithValue("@APROVACAO", APROVACAO)
                .AddWithValue("@RESPONSAVEL_APROVACAO", RESPONSAVEL_APROVACAO)
                .AddWithValue("@DATA_APROVACAO", DATA_APROVACAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteAP(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_MELHORIAS_AP]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS_AP", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "Ação de Melhoria"

    Public Function AddAM(ByVal MELHORIAS As Integer, _
                        ByVal OBJETIVOS As String, _
                        ByVal JUSTIFICATIVAS As String, _
                        ByVal ACOES_NECESSARIAS As Boolean, _
                        ByVal ACOES_NECESSARIAS_TEXTO As String, _
                        ByVal RESULTADOS As String, _
                        ByVal RESPONSAVEL As Integer, _
                        ByVal DATA_RESP As Date, _
                        ByVal APROVACAO As Boolean, _
                        ByVal RESPONSAVEL_APROVACAO As Integer, _
                        ByVal DATA_APROVACAO As Date, _
                        Optional ByRef idregistroAM As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_MELHORIAS_AM"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS", MELHORIAS)
                .AddWithValue("@OBJETIVOS", OBJETIVOS)
                .AddWithValue("@JUSTIFICATIVAS", JUSTIFICATIVAS)
                .AddWithValue("@ACOES_NECESSARIAS", ACOES_NECESSARIAS)
                .AddWithValue("@ACOES_NECESSARIAS_TEXTO", ACOES_NECESSARIAS_TEXTO)
                .AddWithValue("@RESULTADOS", RESULTADOS)
                .AddWithValue("@RESPONSAVEL", RESPONSAVEL)
                .AddWithValue("@DATA_RESP", DATA_RESP)
                .AddWithValue("@APROVACAO", APROVACAO)
                .AddWithValue("@RESPONSAVEL_APROVACAO", RESPONSAVEL_APROVACAO)
                .AddWithValue("@DATA_APROVACAO", DATA_APROVACAO)

            End With

            idregistroAM = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateAM(ByVal idregistroAM As Integer, _
                        ByVal MELHORIAS As Integer, _
                        ByVal OBJETIVOS As String, _
                        ByVal JUSTIFICATIVAS As String, _
                        ByVal ACOES_NECESSARIAS As Boolean, _
                        ByVal ACOES_NECESSARIAS_TEXTO As String, _
                        ByVal RESULTADOS As String, _
                        ByVal RESPONSAVEL As Integer, _
                        ByVal DATA_RESP As Date, _
                        ByVal APROVACAO As Boolean, _
                        ByVal RESPONSAVEL_APROVACAO As Integer, _
                        ByVal DATA_APROVACAO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MELHORIAS_AM]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS_AM", idregistroAM)
                .AddWithValue("@ID_MELHORIAS", MELHORIAS)
                .AddWithValue("@OBJETIVOS", OBJETIVOS)
                .AddWithValue("@JUSTIFICATIVAS", JUSTIFICATIVAS)
                .AddWithValue("@ACOES_NECESSARIAS", ACOES_NECESSARIAS)
                .AddWithValue("@ACOES_NECESSARIAS_TEXTO", ACOES_NECESSARIAS_TEXTO)
                .AddWithValue("@RESULTADOS", RESULTADOS)
                .AddWithValue("@RESPONSAVEL", RESPONSAVEL)
                .AddWithValue("@DATA_RESP", DATA_RESP)
                .AddWithValue("@APROVACAO", APROVACAO)
                .AddWithValue("@RESPONSAVEL_APROVACAO", RESPONSAVEL_APROVACAO)
                .AddWithValue("@DATA_APROVACAO", DATA_APROVACAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteAM(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_MELHORIAS_AM]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS_AM", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#End Region

End Class
