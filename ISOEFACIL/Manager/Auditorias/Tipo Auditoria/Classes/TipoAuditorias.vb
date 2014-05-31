Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class TipoAuditorias

#Region "TIPO AUDITORIAS"

#Region "ADD TIPO DA AUDITORIA"

    Public Function AddTp(ByVal NOME As String, _
                        Optional ByRef idTipoAuditorias As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_NORMAS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@NOME", NOME)
            End With

            idTipoAuditorias = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "ADD"

    Public Function Add(ByVal ID_AUDITORIA As Integer, _
                        ByVal ID_TIPO_VERIFICACAO As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal EVIDENCIA As Boolean, _
                        ByVal FORMATO As Boolean, _
                        ByVal DATA_CADASTRO As Date, _
                        Optional ByRef idTipoAuditorias As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_AUDITORIAS_TIPO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIA", ID_AUDITORIA)
                .AddWithValue("@ID_TIPO_VERIFICACAO", ID_TIPO_VERIFICACAO)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@EVIDENCIA", EVIDENCIA)
                .AddWithValue("@FORMATO", FORMATO)
                .AddWithValue("@DATA_CADASTRO", DATA_CADASTRO)
            End With

            idTipoAuditorias = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE"

    Public Function Update(ByVal idTipoAuditorias As Integer, _
                           ByVal ID_AUDITORIA As Integer, _
                           ByVal ID_TIPO_VERIFICACAO As Integer, _
                           ByVal ID_COLABORADORES As Integer, _
                           ByVal EVIDENCIA As Boolean, _
                           ByVal FORMATO As Boolean, _
                            ByVal DATA_CADASTRO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_AUDITORIAS_TIPO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORIAS_TIPO", idTipoAuditorias)
                .AddWithValue("@ID_AUDITORIA", ID_AUDITORIA)
                .AddWithValue("@ID_TIPO_VERIFICACAO", ID_TIPO_VERIFICACAO)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@EVIDENCIA", EVIDENCIA)
                .AddWithValue("@FORMATO", FORMATO)
                .AddWithValue("@DATA_CADASTRO", DATA_CADASTRO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "DELETE"

    Public Function Delete(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_AUDITORIAS_TIPO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("ID_AUDITORIAS_TIPO", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "ANEXOS"

#Region "ADD ANEXO"

    Public Function AddQANEXOS(ByVal MODULO As String, _
                           ByVal ID_MODULO As Integer, _
                           ByVal DESCRICAO As String, _
                           ByVal ANEXO() As Byte, _
                           ByVal TIPO As String, _
                        Optional ByRef idAnexo As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_ANEXOS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@MODULO", MODULO)
                .AddWithValue("@ID_MODULO", ID_MODULO)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@ANEXO", ANEXO)
                .AddWithValue("@TIPO", TIPO)
            End With

            idAnexo = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function


#End Region

#Region "DELETE ANEXO"

    Public Function DeleteANEXOS(ByVal ID_MODULO As Integer, _
                                 ByVal MODULO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_ANEXOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MODULO", ID_MODULO)
                .AddWithValue("@MODULO", MODULO)
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

#End Region

End Class
