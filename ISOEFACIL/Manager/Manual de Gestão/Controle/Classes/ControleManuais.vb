Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class ControleManuais

#Region "CONTROLE DE MANUAIS"

#Region "CONTROLE NOVO"

    Public Function AddCreate(ByVal ID_DOCUMENTO_CONFIG_TP_DOCUMENTO As Integer, _
                              ByVal ID_NORMAS As Integer, _
                              ByVal ID_COLABORADORES As Integer, _
                              ByVal CHECK_NORMAS_COMPLEMENTARES As Boolean, _
                              ByVal CODIGO As String, _
                              ByVal TITULO As String, _
                              ByVal REVISAO As Integer, _
                              ByVal SITUACAO As Integer, _
                              ByVal DATA As Date, _
                              Optional ByRef idControleManuais As Integer = 0) As String

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_MANUAL_CONTROLE"
        Dim id As String = String.Empty

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_DOCUMENTO_CONFIG_TP_DOCUMENTO", ID_DOCUMENTO_CONFIG_TP_DOCUMENTO)
                .AddWithValue("@ID_NORMAS", ID_NORMAS)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@CHECK_NORMAS_COMPLEMENTARES", CHECK_NORMAS_COMPLEMENTARES)
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@TITULO", TITULO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@SITUACAO", SITUACAO)
                .AddWithValue("@DATA", DATA)
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

    Public Function UpdateCreate(ByVal idControleManuais As Integer, _
                                 ByVal ID_DOCUMENTO_CONFIG_TP_DOCUMENTO As Integer, _
                                 ByVal ID_NORMAS As Integer, _
                                 ByVal ID_COLABORADORES As Integer, _
                                 ByVal CHECK_NORMAS_COMPLEMENTARES As Boolean, _
                                 ByVal CODIGO As String, _
                                 ByVal TITULO As String, _
                                 ByVal REVISAO As Integer, _
                                 ByVal SITUACAO As Integer, _
                                 ByVal DATA As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MANUAL_CONTROLE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MANUAL_CONTROLE", idControleManuais)
                .AddWithValue("@ID_DOCUMENTO_CONFIG_TP_DOCUMENTO", ID_DOCUMENTO_CONFIG_TP_DOCUMENTO)
                .AddWithValue("@ID_NORMAS", ID_NORMAS)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@CHECK_NORMAS_COMPLEMENTARES", CHECK_NORMAS_COMPLEMENTARES)
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@TITULO", TITULO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@SITUACAO", SITUACAO)
                .AddWithValue("@DATA", DATA)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteCreate(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_MANUAL_CONTROLE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MANUAL_CONTROLE", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "APROVACAO"

    Public Function Add(ByVal ID_COLABORADORES As Integer, _
                            ByVal ID_CARGOS As Integer, _
                            ByVal DATA_EMISSAO As Date, _
                            ByVal REVISOES As String, _
                            ByVal DATA_APROVACAO As Date, _
                            Optional ByRef idaprovacao As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_MANUAL_APROVACAO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_CARGOS", ID_CARGOS)
                .AddWithValue("@DATA_EMISSAO", DATA_EMISSAO)
                .AddWithValue("@REVISOES", REVISOES)
                .AddWithValue("@DATA_APROVACAO", DATA_APROVACAO)
            End With

            idaprovacao = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idaprovacao As Integer, _
                           ByVal ID_COLABORADORES As Integer, _
                           ByVal ID_CARGOS As Integer, _
                           ByVal DATA_EMISSAO As Date, _
                           ByVal REVISOES As String, _
                           ByVal DATA_APROVACAO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MANUAL_APROVACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MANUAL_APROVACAO", idaprovacao)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_CARGOS", ID_CARGOS)
                .AddWithValue("@DATA_EMISSAO", DATA_EMISSAO)
                .AddWithValue("@REVISOES", REVISOES)
                .AddWithValue("@DATA_APROVACAO", DATA_APROVACAO)
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
        Dim _cmdText As String = "[DELETE_MANUAL_APROVACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MANUAL_APROVACAO", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "SITUACAO"

    Public Function UpdateStatus(ByVal idControleManuais As Integer, _
                                 ByVal SITUACAO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MANUAL_CONTROLE_SITUACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_MANUAL_CONTROLE", idControleManuais)
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

#Region "ADD CONTROLE DOCUMENTO"

    Public Function AddCdoc(ByVal CODIGO As String, _
                            ByVal ID_DOCUMENTO_CONFIG_TP_DOCUMENTO As Integer, _
                            ByVal TITULO As String, _
                            ByVal ID_AREAS As Integer, _
                            ByVal REVISAO As Integer, _
                            ByVal SITUACAO As String, _
                            ByVal E As Integer, _
                            ByVal C As Integer, _
                            ByVal A As Integer, _
                            ByVal P As Integer, _
                            ByVal FORMATO As Integer, _
                            ByVal CHECK As Boolean, _
                            ByVal ARQUIVO As String, _
          Optional ByRef idDoc As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_CONTROLE]"

        Try
            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@ID_DOCUMENTO_CONFIG_TP_DOCUMENTO", ID_DOCUMENTO_CONFIG_TP_DOCUMENTO)
                .AddWithValue("@TITULO", TITULO)
                .AddWithValue("@ID_AREAS", ID_AREAS)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@SITUACAO", SITUACAO)
                .AddWithValue("@E", E)
                .AddWithValue("@C", C)
                .AddWithValue("@A", A)
                .AddWithValue("@P", P)
                .AddWithValue("@FORMATO", FORMATO)
                .AddWithValue("@CHECK", CHECK)
                .AddWithValue("@ARQUIVO", ARQUIVO)
            End With

            idDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function AddComp(ByVal NOME As String, _
                            ByVal CHECKS As Boolean, _
                  Optional ByRef idComp As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_NORMAS_COMPLEMENTARES_CHECK]"

        Try
            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@CHECKS", CHECKS)

            End With

            idComp = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateComp(ByVal idControleManuais As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_NORMAS_COMPLEMENTARES_CHECK]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MANUAL_CONTROLE", idControleManuais)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteComp(ByVal NOME As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_NORMAS_COMPLEMENTARES_CHECK]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@NOME", NOME)
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
