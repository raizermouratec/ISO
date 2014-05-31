Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class auditores

#Region "AUDITORES"

#Region "ADD"

    Public Function Add(ByVal ORIGEM As Integer, _
                           ByVal ID_COLABORADORES As Integer, _
                           ByVal NOME As String, _
                           ByVal SITUACAO As Boolean, _
                           ByVal CLASSIFICACAO As Boolean, _
                           ByVal DATA_CADASTRO As Date, _
                           ByVal CERTIFICADOR As String, _
                           ByVal FOTO() As Byte, _
                           ByVal TELEFONE_FIXO As String, _
                           ByVal TELEFONE_CELULAR As String, _
                           ByVal TELEFONE_FAX As String, _
                           ByVal EMAIL As String, _
                           ByVal SKYPE As String, _
                        Optional ByRef idAuditores As Integer = 0) As String

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_AUDITORIAS_AUDITORES"
        Dim id As String = String.Empty

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ORIGEM", ORIGEM)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@SITUACAO", SITUACAO)
                .AddWithValue("@CLASSIFICACAO", CLASSIFICACAO)
                .AddWithValue("@DATA_CADASTRO", DATA_CADASTRO)
                .AddWithValue("@CERTIFICADOR", CERTIFICADOR)

                'Verifica se FOTO é Nothing
                If Not FOTO Is Nothing Then
                    .AddWithValue("@FOTO", FOTO)
                Else : FOTO = New Byte(Convert.ToString(1)) {}
                    .AddWithValue("@FOTO", FOTO)
                End If

                .AddWithValue("@TELEFONE_FIXO", TELEFONE_FIXO)
                .AddWithValue("@TELEFONE_CELULAR", TELEFONE_CELULAR)
                .AddWithValue("@TELEFONE_FAX", TELEFONE_FAX)
                .AddWithValue("@EMAIL", EMAIL)
                .AddWithValue("@SKYPE", SKYPE)
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

#Region "UPDATE"

    Public Function Update(ByVal idAuditores As Integer, _
                           ByVal ORIGEM As Integer, _
                           ByVal ID_COLABORADORES As Integer, _
                           ByVal NOME As String, _
                           ByVal SITUACAO As Boolean, _
                           ByVal CLASSIFICACAO As Boolean, _
                           ByVal DATA_CADASTRO As Date, _
                           ByVal CERTIFICADOR As String, _
                           ByVal FOTO() As Byte, _
                           ByVal TELEFONE_FIXO As String, _
                           ByVal TELEFONE_CELULAR As String, _
                           ByVal TELEFONE_FAX As String, _
                           ByVal EMAIL As String, _
                           ByVal SKYPE As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_AUDITORIAS_AUDITORES]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORES", idAuditores)
                .AddWithValue("@ORIGEM", ORIGEM)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@SITUACAO", SITUACAO)
                .AddWithValue("@CLASSIFICACAO", CLASSIFICACAO)
                .AddWithValue("@DATA_CADASTRO", DATA_CADASTRO)
                .AddWithValue("@CERTIFICADOR", CERTIFICADOR)
                '.AddWithValue("@FOTO", FOTO)

                'Verifica se FOTO é Nothing
                If Not FOTO Is Nothing Then
                    .AddWithValue("@FOTO", FOTO)
                Else : FOTO = New Byte(Convert.ToString(1)) {}
                    .AddWithValue("@FOTO", FOTO)
                End If

                .AddWithValue("@TELEFONE_FIXO", TELEFONE_FIXO)
                .AddWithValue("@TELEFONE_CELULAR", TELEFONE_CELULAR)
                .AddWithValue("@TELEFONE_FAX", TELEFONE_FAX)
                .AddWithValue("@EMAIL", EMAIL)
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

#Region "DELETE"

    Public Function Delete(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_AUDITORIAS_AUDITORES]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORES", id)
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

#Region "AUDITORES QUALIFICAÇÃO"

#Region "ADD QUALIFICAÇÃO"

    Public Function AddQLF(ByVal ID_AUDITORES As Integer, _
                           ByVal FORMACAO As String, _
                           ByVal DT_INI_FORMACAO As Date, _
                           ByVal DT_FIM_FORMACAO As Date, _
                           ByVal ENTIDADE As String, _
                           ByVal CH As String, _
                           ByVal HOMOLOGADO As Integer, _
                           ByVal DT_HOMOLOGADO As Date, _
                        Optional ByRef idAuditoresQLF As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_AUDITORIAS_AUDITORES_QUALIFICACAO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORES", ID_AUDITORES)
                .AddWithValue("@FORMACAO", FORMACAO)
                .AddWithValue("@DT_INI_FORMACAO", DT_INI_FORMACAO)
                .AddWithValue("@DT_FIM_FORMACAO", DT_FIM_FORMACAO)
                .AddWithValue("@ENTIDADE", ENTIDADE)
                .AddWithValue("@CH", CH)
                .AddWithValue("@HOMOLOGADO", HOMOLOGADO)
                .AddWithValue("@DT_HOMOLOGADO", DT_HOMOLOGADO)
            End With

            idAuditoresQLF = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE QUALIFICAÇÃO"

    Public Function UpdateQLF(ByVal idAuditoresQLF As Integer, _
                           ByVal ID_AUDITORES As Integer, _
                           ByVal FORMACAO As String, _
                           ByVal DT_INI_FORMACAO As Date, _
                           ByVal DT_FIM_FORMACAO As Date, _
                           ByVal ENTIDADE As String, _
                           ByVal CH As String, _
                           ByVal HOMOLOGADO As Integer, _
                           ByVal DT_HOMOLOGADO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_AUDITORIAS_AUDITORES_QUALIFICACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORES_QUALIFICACAO", idAuditoresQLF)
                .AddWithValue("@ID_AUDITORES", ID_AUDITORES)
                .AddWithValue("@FORMACAO", FORMACAO)
                .AddWithValue("@DT_INI_FORMACAO", DT_INI_FORMACAO)
                .AddWithValue("@DT_FIM_FORMACAO", DT_FIM_FORMACAO)
                .AddWithValue("@ENTIDADE", ENTIDADE)
                .AddWithValue("@CH", CH)
                .AddWithValue("@HOMOLOGADO", HOMOLOGADO)
                .AddWithValue("@DT_HOMOLOGADO", DT_HOMOLOGADO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "DELETE QUALIFICAÇÃO"

    Public Function DeleteQLF(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_AUDITORIAS_AUDITORES_QUALIFICACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AUDITORES_QUALIFICACAO", id)
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

End Class


