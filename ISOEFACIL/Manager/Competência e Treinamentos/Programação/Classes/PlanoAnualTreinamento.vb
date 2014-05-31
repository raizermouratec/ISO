Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class planoAnualTreinamento

#Region "ADD"

    Public Function AddTreinamento(ByVal ACAO As String, _
                                   ByVal NUMERO As String, _
                                   ByVal ANO As String, _
                                   ByVal MES As Integer, _
                        Optional ByRef idPlanoTreinamento As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_TREINAMENTO_PLANO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ACAO", ACAO)
                .AddWithValue("@NUMERO", NUMERO)
                .AddWithValue("@ANO", ANO)
                .AddWithValue("@MES", MES)
            End With

            idPlanoTreinamento = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "PLANO ANUAL"

#Region "JAN"

    Public Function Update_Plano_JAN(ByVal ID_TREINAMETO_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_TRE_JAN]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PLANO_TREINAMETO", ID_TREINAMETO_PLANO)
                .AddWithValue("@TIPO", TIPO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "FEV"

    Public Function Update_Plano_FEV(ByVal ID_TREINAMETO_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_TRE_FEV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PLANO_TREINAMETO", ID_TREINAMETO_PLANO)
                .AddWithValue("@TIPO", TIPO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "MAR"

    Public Function Update_Plano_MAR(ByVal ID_TREINAMETO_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_TRE_MAR]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PLANO_TREINAMETO", ID_TREINAMETO_PLANO)
                .AddWithValue("@TIPO", TIPO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "ABR"

    Public Function Update_Plano_ABR(ByVal ID_TREINAMETO_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_TRE_ABR]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PLANO_TREINAMETO", ID_TREINAMETO_PLANO)
                .AddWithValue("@TIPO", TIPO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "MAI"

    Public Function Update_Plano_MAI(ByVal ID_TREINAMETO_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_TRE_MAI]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PLANO_TREINAMETO", ID_TREINAMETO_PLANO)
                .AddWithValue("@TIPO", TIPO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "JUN"

    Public Function Update_Plano_JUN(ByVal ID_TREINAMETO_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_TRE_JUN]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PLANO_TREINAMETO", ID_TREINAMETO_PLANO)
                .AddWithValue("@TIPO", TIPO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "JUL"

    Public Function Update_Plano_JUL(ByVal ID_TREINAMETO_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_TRE_JUL]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PLANO_TREINAMETO", ID_TREINAMETO_PLANO)
                .AddWithValue("@TIPO", TIPO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "AGO"

    Public Function Update_Plano_AGO(ByVal ID_TREINAMETO_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_TRE_AGO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PLANO_TREINAMETO", ID_TREINAMETO_PLANO)
                .AddWithValue("@TIPO", TIPO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "SET"

    Public Function Update_Plano_SET(ByVal ID_TREINAMETO_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_TRE_SET]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PLANO_TREINAMETO", ID_TREINAMETO_PLANO)
                .AddWithValue("@TIPO", TIPO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "OUT"

    Public Function Update_Plano_OUT(ByVal ID_TREINAMETO_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_TRE_OUT]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PLANO_TREINAMETO", ID_TREINAMETO_PLANO)
                .AddWithValue("@TIPO", TIPO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "NOV"

    Public Function Update_Plano_NOV(ByVal ID_TREINAMETO_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_TRE_NOV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PLANO_TREINAMETO", ID_TREINAMETO_PLANO)
                .AddWithValue("@TIPO", TIPO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "DEZ"

    Public Function Update_Plano_DEZ(ByVal ID_TREINAMETO_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_TRE_DEZ]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PLANO_TREINAMETO", ID_TREINAMETO_PLANO)
                .AddWithValue("@TIPO", TIPO)
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

#Region "ADD REALIZA"

    Public Function AddRealiza(ByVal ID_TREINAMETO_PLANO As Integer, _
                               ByVal ACAO As String, _
                               ByVal NUMERO As String, _
                        ByVal ANO As String, _
                        ByVal MES As String, _
                        ByVal SITUACAO As String, _
                        Optional ByRef idPlanoAnual As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_TREINAMENTO_REALIZAR]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_TREINAMETO_PLANO", ID_TREINAMETO_PLANO)
                .AddWithValue("@ACAO", ACAO)
                .AddWithValue("@NUMERO", NUMERO)
                .AddWithValue("@ANO", ANO)
                .AddWithValue("@MES", MES)
                .AddWithValue("@SITUACAO", SITUACAO)
            End With

            idPlanoAnual = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "DELETAR REALIZA"

    Public Function DeleteRealiza(ByVal id As Integer, _
                                  ByVal ACAO As String, _
                                  ByVal ANO As String, _
                                  ByVal MES As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_TREINAMENTO_REALIZAR]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_TREINAMETO_PLANO", id)
                .AddWithValue("@ACAO", ACAO)
                .AddWithValue("@ANO", ANO)
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
