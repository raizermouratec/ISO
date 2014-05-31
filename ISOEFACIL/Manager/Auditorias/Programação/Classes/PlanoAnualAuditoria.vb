Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class planoAnualAuditoria

#Region "ADD"

    Public Function AddAuditoria(ByVal AREAS As Integer, _
                        ByVal ANO As String, _
                        ByVal MES As Integer, _
                        Optional ByRef idPlanoAnual As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_AUDITORIAS_PLANO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AREAS", AREAS)
                .AddWithValue("@ANO", ANO)
                .AddWithValue("@MES", MES)
            End With


            idPlanoAnual = _Command.ExecuteScalar
            _Connection.Close()

            Return True


        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "ADD REALIZA"

    Public Function AddRealizaAuditoria(ByVal AREAS As Integer, _
                        ByVal ID_AUDITORIAS_PLANO As Integer, _
                        ByVal ANO As String, _
                        ByVal MES As String, _
                        ByVal SITUACAO As String, _
                        Optional ByRef idPlanoAnual As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_AUDITORIAS_REALIZAR"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AREAS", AREAS)
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
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
                                  ByVal AREAS As Integer, _
                                  ByVal ANO As String, _
                                  ByVal MES As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_AUDITORIAS_REALIZAR]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", id)
                .AddWithValue("@ID_AREAS", AREAS)
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

#Region "ADD ITEM"

    Public Function AddItemAud(ByVal ID_AUDITORIAS_PLANO As Integer, _
                               ByVal ID_ITEM As Integer, _
                        Optional ByRef idItemAud As Integer = 0) As Boolean



        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_AUDITORIAS_REALIZAR_ITEM"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
                .AddWithValue("@ID_ITEM", ID_ITEM)
            End With


            idItemAud = _Command.ExecuteScalar
            _Connection.Close()

            Return True


        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "PLANO ANUAL"

#Region "JAN"

    Public Function Update_Plano_JAN(ByVal ID_AUDITORIAS_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_AUD_JAN]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
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

    Public Function Update_Plano_FEV(ByVal ID_AUDITORIAS_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_AUD_FEV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
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

    Public Function Update_Plano_MAR(ByVal ID_AUDITORIAS_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_AUD_MAR]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
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

    Public Function Update_Plano_ABR(ByVal ID_AUDITORIAS_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_AUD_ABR]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
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

    Public Function Update_Plano_MAI(ByVal ID_AUDITORIAS_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_AUD_MAI]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
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

    Public Function Update_Plano_JUN(ByVal ID_AUDITORIAS_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_AUD_JUN]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
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

    Public Function Update_Plano_JUL(ByVal ID_AUDITORIAS_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_AUD_JUL]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
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

    Public Function Update_Plano_AGO(ByVal ID_AUDITORIAS_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_AUD_AGO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
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

    Public Function Update_Plano_SET(ByVal ID_AUDITORIAS_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_AUD_SET]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
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

    Public Function Update_Plano_OUT(ByVal ID_AUDITORIAS_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_AUD_OUT]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
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

    Public Function Update_Plano_NOV(ByVal ID_AUDITORIAS_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_AUD_NOV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
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

    Public Function Update_Plano_DEZ(ByVal ID_AUDITORIAS_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_AUD_DEZ]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", ID_AUDITORIAS_PLANO)
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

#Region "UPDATE MULTIPLO"

    Public Function UpdateMultiplo(ByVal idRequisito As Integer, _
                        ByVal CHECK As Boolean) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_ITEM_NORMA_MULTIPLOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_ITEM_NORMA", idRequisito)
                .AddWithValue("@CHECK", CHECK)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE NULL"

    Public Function UpdateNull(ByVal CHECK As Boolean) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_ITEM_NORMA_NULL]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CHECK", CHECK)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "DELETAR PLANO"

    Public Function DeletePlano(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_AUDITORIAS_PLANO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_PLANO", id)
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
