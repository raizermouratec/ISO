Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class planoAnualCalibracao

#Region "ADD"

    Public Function Add(ByVal CALIBRACOES_INSTRUMENTOS As Integer, _
                        ByVal TIPO As String, _
                        ByVal ANO As String, _
                        ByVal MES As Integer, _
                        Optional ByRef idPlanoAnual As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_CALIBRACOES_PLANO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_INSTRUMENTOS", CALIBRACOES_INSTRUMENTOS)
                .AddWithValue("@TIPO", TIPO)
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

    Public Function AddRealiza(ByVal CALIBRACOES_INSTRUMENTOS As Integer, _
                        ByVal ID_CALIBRACOES_PLANO As Integer, _
                        ByVal TIPO As String, _
                        ByVal ANO As String, _
                        ByVal MES As String, _
                        ByVal SITUACAO As String, _
                        Optional ByRef idPlanoAnual As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_CALIBRACOES_REALIZAR"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_INSTRUMENTOS", CALIBRACOES_INSTRUMENTOS)
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
                .AddWithValue("@TIPO", TIPO)
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
                                  ByVal CALIBRACOES_INSTRUMENTOS As Integer, _
                                  ByVal ANO As String, _
                                  ByVal MES As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_CALIBRACOES_REALIZAR]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", id)
                .AddWithValue("@ID_CALIBRACOES_INSTRUMENTOS", CALIBRACOES_INSTRUMENTOS)
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

#Region "PROGRAMADADA"

    Public Function Update(ByVal idCliente As Integer, _
                        ByVal NOME As String, _
                        ByVal CPF As String, _
                        ByVal RG As String, _
                        ByVal PROFISSAO As String, _
                        ByVal RAZAO_SOCIAL As String, _
                        ByVal NOME_FANTASIA As String, _
                        ByVal CNPJ As String, _
                        ByVal INSCRICAO_MUNIC As String, _
                        ByVal INSCRICAO_ESTAD As String, _
                        ByVal ENDERECO As String, _
                        ByVal COMPLEMENTO As String, _
                        ByVal BAIRRO As String, _
                        ByVal ESTADO As String, _
                        ByVal CIDADE As String, _
                        ByVal CEP As String, _
                        ByVal TELEFONE_01 As String, _
                        ByVal TELEFONE_02 As String, _
                        ByVal TELEFONE_03 As String, _
                        ByVal EMAIL As String, _
                        ByVal WEBSITE As String, _
                        ByVal SKYPE As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CLIENTES]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDOR", idCliente)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@CPF", CPF)
                .AddWithValue("@RG", RG)
                .AddWithValue("@PROFISSAO", PROFISSAO)
                .AddWithValue("@RAZAO_SOCIAL", RAZAO_SOCIAL)
                .AddWithValue("@NOME_FANTASIA", NOME_FANTASIA)
                .AddWithValue("@CNPJ", CNPJ)
                .AddWithValue("@INSCRICAO_MUNIC", INSCRICAO_MUNIC)
                .AddWithValue("@INSCRICAO_ESTAD", INSCRICAO_ESTAD)
                .AddWithValue("@ENDERECO", ENDERECO)
                .AddWithValue("@COMPLEMENTO", COMPLEMENTO)
                .AddWithValue("@BAIRRO", BAIRRO)
                .AddWithValue("@ESTADO", ESTADO)
                .AddWithValue("@CIDADE", CIDADE)
                .AddWithValue("@CEP", CEP)
                .AddWithValue("@TELEFONE_01", TELEFONE_01)
                .AddWithValue("@TELEFONE_02", TELEFONE_02)
                .AddWithValue("@TELEFONE_03", TELEFONE_03)
                .AddWithValue("@EMAIL", EMAIL)
                .AddWithValue("@WEBSITE", WEBSITE)
                .AddWithValue("@SKYPE", SKYPE)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "PLANO ANUAL"

#Region "JAN"

    Public Function Update_Plano_JAN(ByVal ID_CALIBRACOES_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_PLANO_JAN]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
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

    Public Function Update_Plano_FEV(ByVal ID_CALIBRACOES_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_PLANO_FEV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
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

    Public Function Update_Plano_MAR(ByVal ID_CALIBRACOES_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_PLANO_MAR]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
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

    Public Function Update_Plano_ABR(ByVal ID_CALIBRACOES_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_PLANO_ABR]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
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

    Public Function Update_Plano_MAI(ByVal ID_CALIBRACOES_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_PLANO_MAI]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
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

    Public Function Update_Plano_JUN(ByVal ID_CALIBRACOES_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_PLANO_JUN]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
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

    Public Function Update_Plano_JUL(ByVal ID_CALIBRACOES_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_PLANO_JUL]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
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

    Public Function Update_Plano_AGO(ByVal ID_CALIBRACOES_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_PLANO_AGO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
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

    Public Function Update_Plano_SET(ByVal ID_CALIBRACOES_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_PLANO_SET]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
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

    Public Function Update_Plano_OUT(ByVal ID_CALIBRACOES_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_PLANO_OUT]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
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

    Public Function Update_Plano_NOV(ByVal ID_CALIBRACOES_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_PLANO_NOV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
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

    Public Function Update_Plano_DEZ(ByVal ID_CALIBRACOES_PLANO As Integer, _
                     ByVal TIPO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CHECK_PLANO_DEZ]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", ID_CALIBRACOES_PLANO)
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

#Region "REALIZA PLANO"

    Public Function Update_RealizaPlano(ByVal ID_CALIBRACOES_PLANO As Integer, _
                                         ByVal MES As String, _
                                         ByVal SITUACAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CALIBRACOES_PLANO]"

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

#End Region

#Region "DELETAR PLANO"

    Public Function DeletePlano(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_CALIBRACOES_PLANO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CALIBRACOES_PLANO", id)
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
