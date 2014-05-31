Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms

Public Class realizacaoTreinamentos


#Region "ADD PROGRAMAÇÃO"

    Public Function AddProgramacao(ByVal ID_TREINAMENTO_REALIZAR As Integer, _
                                   ByVal ID_COLABORADORES As Integer, _
                                   ByVal LOCAL As String, _
                                   ByVal INSTRUTOR As String, _
                                   ByVal TIPO As String, _
                                   ByVal NIVEL As String, _
                                   ByVal CH As String, _
                                   ByVal CHT As String, _
                                   ByVal TOTAL_DIAS As String, _
                                   ByVal DT_INICIO As Date, _
                                   ByVal DT_TERMINO As Date, _
                                   ByVal REALIZACAO As String, _
                                   ByVal OBSERVACAO As String, _
                                  Optional ByRef idProgramcaoTreinamento As Integer = 0) As String

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_TREINAMENTO_PROGRAMACAO"
        Dim id As String = String.Empty

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_TREINAMENTO_REALIZAR", ID_TREINAMENTO_REALIZAR)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@LOCAL", LOCAL)
                .AddWithValue("@INSTRUTOR", INSTRUTOR)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@NIVEL", NIVEL)
                .AddWithValue("@CH", CH)
                .AddWithValue("@CHT", CHT)
                .AddWithValue("@TOTAL_DIAS", TOTAL_DIAS)
                .AddWithValue("@DT_INICIO", DT_INICIO)
                .AddWithValue("@DT_TERMINO", DT_TERMINO)
                .AddWithValue("@REALIZACAO", REALIZACAO)
                .AddWithValue("@OBSERVACAO", OBSERVACAO)
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

#End Region

#Region "ADD OBJETIVOS"
    Public Function AddObjetivos(ByVal ID_TREINAMENTO_REALIZAR As Integer, _
                                       ByVal OBJETIVOS As String, _
                                       ByVal JUSTIFICATIVAS As String, _
                                       ByVal RECURSOS As String, _
                                       ByVal PLANEJAMENTO As String, _
                                       ByVal DT_ELABORACAO As Date, _
                                       ByVal PRAZO_EFICACIA As Date, _
                                      Optional ByRef idProgramcaoTreinamento As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_TREINAMENTO_OBJETIVOS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_TREINAMENTO_REALIZAR", ID_TREINAMENTO_REALIZAR)
                .AddWithValue("@OBJETIVOS", OBJETIVOS)
                .AddWithValue("@JUSTIFICATIVAS", JUSTIFICATIVAS)
                .AddWithValue("@RECURSOS", RECURSOS)
                .AddWithValue("@PLANEJAMENTO", PLANEJAMENTO)
                .AddWithValue("@DT_ELABORACAO", DT_ELABORACAO)
                .AddWithValue("@PRAZO_EFICACIA", PRAZO_EFICACIA)
            End With

            idProgramcaoTreinamento = _Command.ExecuteScalar
            _Connection.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "ADD EFICÁCIA"
    Public Function AddEficacia(ByVal ID_TREINAMENTO_REALIZAR As Integer, _
                                       ByVal ID_COLABORADORES As Integer, _
                                       ByVal METODOS_ANALISE As String, _
                                       ByVal RESULTADOS_OBTIDOS As String, _
                                       ByVal ACAO_EFICAZ As Boolean, _
                                       ByVal JUSTIFICATIVA As String, _
                                       ByVal OQUE_FAZER As String, _
                                       ByVal DATA As Date, _
                                      Optional ByRef idProgramcaoTreinamento As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_TREINAMENTO_EFICACIA"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_TREINAMENTO_REALIZAR", ID_TREINAMENTO_REALIZAR)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@METODOS_ANALISE", METODOS_ANALISE)
                .AddWithValue("@RESULTADOS_OBTIDOS", RESULTADOS_OBTIDOS)
                .AddWithValue("@ACAO_EFICAZ", ACAO_EFICAZ)
                .AddWithValue("@JUSTIFICATIVA", JUSTIFICATIVA)
                .AddWithValue("@OQUE_FAZER", OQUE_FAZER)
                .AddWithValue("@DATA", DATA)
            End With

            idProgramcaoTreinamento = _Command.ExecuteScalar
            _Connection.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "ADD FREQUENCIA"
    Public Function AddFrequencia(ByVal ID_TREINAMENTO_REALIZAR As Integer, _
                                       ByVal ID_COLABORADORES As Integer, _
                                       ByVal STATUS As Integer, _
                                       ByVal SITUACAO As String, _
                                      Optional ByRef idProgramcaoTreinamento As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_TREINAMENTO_FREQUENCIA"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_TREINAMENTO_REALIZAR", ID_TREINAMENTO_REALIZAR)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@STATUS", STATUS)
                .AddWithValue("@SITUACAO", SITUACAO)
            End With

            idProgramcaoTreinamento = _Command.ExecuteScalar
            _Connection.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "UPDATE FREQUENCIA - PRESENTE"
    Public Function Update_Frequencia_Dia(ByVal ID_TREINAMENTO_FREQUENCIA As Integer, _
                                          ByVal TIPO As Integer, _
                                          ByVal DIA As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_FREQUENCIA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_TREINAMENTO_FREQUENCIA", ID_TREINAMENTO_FREQUENCIA)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@DIA", DIA)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "UPDATE STATUS"

    Public Function UpdateRealizacaoStatus(ByVal ID_TREINAMENTO_REALIZAR As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_TREINAMENTOS_REALIZACAO_STATUS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_TREINAMENTO_REALIZAR", ID_TREINAMENTO_REALIZAR)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdatePlanoStatus(ByVal ID_TREINAMETO_PLANO As Integer, _
                           ByVal MES As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_TREINAMENTOS_PLANO_STATUS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_TREINAMETO_PLANO", ID_TREINAMETO_PLANO)
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

#Region "UPDATE MULTIPLO"

    Public Function UpdateMultiploParticipantes(ByVal idColaborador As Integer, _
                        ByVal CHECKS As Boolean) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_TREINAMENTOS_MULTIPLOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", idColaborador)
                .AddWithValue("@CHECKS", CHECKS)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE TUDO"

    Public Function UpdateTudo(ByVal CHECKS As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_TREINAMENTOS_TUDO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CHECKS", CHECKS)
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
