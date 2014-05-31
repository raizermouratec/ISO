Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class externo

    Public Function Add(ByVal ID_CALIBRACOES_REALIZAR As Integer, _
                        ByVal ORGANISMO_RESPONSAVEL As String, _
                        ByVal LAUDO_EMITIDO As String, _
                        ByVal OBS As String, _
                        ByVal DATA As Date, _
                        ByVal VALIDADE As Date, _
                        ByVal RESULTADO_LAUDO As Integer, _
                        ByVal NUMERO_LAUDO As String, _
                        ByVal ORGANISMO_RESPONSAVEL_PADRAO As String, _
                        ByVal VALIDADE_PADRAO As Date, _
                       Optional ByRef idExterno As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_CALIBRACOES_REALIZAR_EXTERNA"


        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            'Limpar mascaras
            With _Command.Parameters

                .AddWithValue("@ID_CALIBRACOES_REALIZAR", ID_CALIBRACOES_REALIZAR)
                .AddWithValue("@ORGANISMO_RESPONSAVEL", ORGANISMO_RESPONSAVEL)
                .AddWithValue("@LAUDO_EMITIDO", LAUDO_EMITIDO)
                .AddWithValue("@OBS", OBS)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@VALIDADE", VALIDADE)
                .AddWithValue("@RESULTADO_LAUDO", RESULTADO_LAUDO)
                .AddWithValue("@NUMERO_LAUDO", NUMERO_LAUDO)
                .AddWithValue("@ORGANISMO_RESPONSAVEL_PADRAO", ORGANISMO_RESPONSAVEL_PADRAO)
                .AddWithValue("@VALIDADE_PADRAO", VALIDADE_PADRAO)

            End With

            idExterno = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False

        End Try

    End Function

    Public Function Update(ByVal idExterno As Integer, _
                           ByVal ID_CALIBRACOES_REALIZAR As Integer, _
                           ByVal ORGANISMO_RESPONSAVEL As String, _
                           ByVal LAUDO_EMITIDO As String, _
                           ByVal OBS As String, _
                           ByVal DATA As Date, _
                           ByVal VALIDADE As Date, _
                           ByVal RESULTADO_LAUDO As Integer, _
                           ByVal NUMERO_LAUDO As String, _
                           ByVal ORGANISMO_RESPONSAVEL_PADRAO As String, _
                           ByVal VALIDADE_PADRAO As Date) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CALIBRACOES_REALIZAR_EXTERNA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_CALIBRACOES_REALIZAR_EXTERNA", idExterno)
                .AddWithValue("@ID_CALIBRACOES_REALIZAR", ID_CALIBRACOES_REALIZAR)
                .AddWithValue("@ORGANISMO_RESPONSAVEL", ORGANISMO_RESPONSAVEL)
                .AddWithValue("@LAUDO_EMITIDO", LAUDO_EMITIDO)
                .AddWithValue("@OBS", OBS)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@VALIDADE", VALIDADE)
                .AddWithValue("@RESULTADO_LAUDO", RESULTADO_LAUDO)
                .AddWithValue("@NUMERO_LAUDO", NUMERO_LAUDO)
                .AddWithValue("@ORGANISMO_RESPONSAVEL_PADRAO", ORGANISMO_RESPONSAVEL_PADRAO)
                .AddWithValue("@VALIDADE_PADRAO", VALIDADE_PADRAO)

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
        Dim _cmdText As String = "[DELETE_CALIBRACOES_REALIZAR_EXTERNA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_CALIBRACOES_REALIZAR_EXTERNA", id)

            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#Region "UPDATE STATUS"

    Public Function UpdateRealizacaoStatus(ByVal ID_CALIBRACOES_PLANO As Integer, _
                           ByVal MES As String, _
                           ByVal SITUACAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CALIBRACOES_REALIZACAO_STATUS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
                .AddWithValue("@MES", MES)
                .AddWithValue("@SITUACAO", SITUACAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdatePlanoStatus(ByVal ID_CALIBRACOES_PLANO As Integer, _
                           ByVal MES As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CALIBRACOES_PLANO_STATUS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
                .AddWithValue("@MES", MES)
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
