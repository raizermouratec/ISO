Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class melhorias

#Region "NÃO CONFORMIDADE / MELHORIA"

    Public Function Add(ByVal TIPO As Integer, _
                        ByVal NORMA_PADRAO As Integer, _
                        ByVal CLIENTES As Integer, _
                        ByVal NORMAS As Integer, _
                        ByVal RESPONSAVEL As Integer, _
                        ByVal TITULO As String, _
                        ByVal NUMERO As String, _
                        ByVal DETALHAMENTO As String, _
                        ByVal SITUACAO_ORIGEM As Integer, _
                        ByVal OUTRO_DESCRICAO As String, _
                        ByVal DATA_DE_REGISTRO As Date, _
                        ByVal NOTIFICAR As Boolean, _
                        ByVal ACEITE_PROCEDENTE As Integer, _
                        ByVal NEGATIVO_JUSTIFIQUE As String, _
                        ByVal PRAZO_TRATAMENTO As Date, _
                        ByVal PRAZO_EFICACIA As Date, _
                        ByVal SETOR_RESPONSAVEL As Integer, _
                        ByVal RESPONSAVEL_SETOR As Integer, _
                        ByVal SITUACAO As Integer, _
                        Optional ByRef idregistroNCM As Integer = 0) As String


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_MELHORIAS"
        Dim id As String = String.Empty

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS_TIPO_SITUACAO", TIPO)
                .AddWithValue("@ID_NORMA_PADRAO", NORMA_PADRAO)
                .AddWithValue("@ID_CLIENTES", CLIENTES)
                .AddWithValue("@NORMAS", NORMAS)
                .AddWithValue("@RESPONSAVEL", RESPONSAVEL)
                .AddWithValue("@TITULO", TITULO)
                .AddWithValue("@NUMERO", NUMERO)
                .AddWithValue("@DETALHAMENTO", DETALHAMENTO)
                .AddWithValue("@SITUACAO_ORIGEM", SITUACAO_ORIGEM)
                .AddWithValue("@OUTRO_DESCRICAO", OUTRO_DESCRICAO)
                .AddWithValue("@DATA_DE_REGISTRO", DATA_DE_REGISTRO)
                .AddWithValue("@NOTIFICAR", NOTIFICAR)
                .AddWithValue("@ACEITE_PROCEDENTE", ACEITE_PROCEDENTE)
                .AddWithValue("@NEGATIVO_JUSTIFIQUE", NEGATIVO_JUSTIFIQUE)
                If PRAZO_TRATAMENTO = "1/1/1753" Then
                    .AddWithValue("@PRAZO_TRATAMENTO", DBNull.Value)
                Else
                    .AddWithValue("@PRAZO_TRATAMENTO", PRAZO_TRATAMENTO)
                End If
                If PRAZO_EFICACIA = "1/1/1753" Then
                    .AddWithValue("@PRAZO_EFICACIA", DBNull.Value)
                Else
                    .AddWithValue("@PRAZO_EFICACIA", PRAZO_EFICACIA)
                End If
                .AddWithValue("@SETOR_RESPONSAVEL", SETOR_RESPONSAVEL)
                .AddWithValue("@RESPONSAVEL_SETOR", RESPONSAVEL_SETOR)
                .AddWithValue("@SITUACAO", SITUACAO)
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

    Public Function Update(ByVal idregistroNCM As Integer, _
                        ByVal TIPO As Integer, _
                        ByVal NORMA_PADRAO As Integer, _
                        ByVal CLIENTES As Integer, _
                        ByVal NORMAS As Integer, _
                        ByVal RESPONSAVEL As Integer, _
                        ByVal TITULO As String, _
                        ByVal NUMERO As String, _
                        ByVal DETALHAMENTO As String, _
                        ByVal SITUACAO_ORIGEM As Integer, _
                        ByVal OUTRO_DESCRICAO As String, _
                        ByVal DATA_DE_REGISTRO As Date, _
                        ByVal NOTIFICAR As Boolean, _
                        ByVal ACEITE_PROCEDENTE As Integer, _
                        ByVal NEGATIVO_JUSTIFIQUE As String, _
                        ByVal PRAZO_TRATAMENTO As Date, _
                        ByVal PRAZO_EFICACIA As Date, _
                        ByVal SETOR_RESPONSAVEL As Integer, _
                        ByVal RESPONSAVEL_SETOR As Integer, _
                        ByVal SITUACAO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MELHORIAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS", idregistroNCM)
                .AddWithValue("@ID_MELHORIAS_TIPO_SITUACAO", TIPO)
                .AddWithValue("@ID_NORMA_PADRAO", NORMA_PADRAO)
                .AddWithValue("@ID_CLIENTES", CLIENTES)
                .AddWithValue("@NORMAS", NORMAS)
                .AddWithValue("@RESPONSAVEL", RESPONSAVEL)
                .AddWithValue("@TITULO", TITULO)
                .AddWithValue("@NUMERO", NUMERO)
                .AddWithValue("@DETALHAMENTO", DETALHAMENTO)
                .AddWithValue("@SITUACAO_ORIGEM", SITUACAO_ORIGEM)
                .AddWithValue("@OUTRO_DESCRICAO", OUTRO_DESCRICAO)
                .AddWithValue("@DATA_DE_REGISTRO", DATA_DE_REGISTRO)
                .AddWithValue("@NOTIFICAR", NOTIFICAR)
                .AddWithValue("@ACEITE_PROCEDENTE", ACEITE_PROCEDENTE)
                .AddWithValue("@NEGATIVO_JUSTIFIQUE", NEGATIVO_JUSTIFIQUE)
                If PRAZO_TRATAMENTO = "1/1/1753" Then
                    .AddWithValue("@PRAZO_TRATAMENTO", DBNull.Value)
                Else
                    .AddWithValue("@PRAZO_TRATAMENTO", PRAZO_TRATAMENTO)
                End If
                If PRAZO_EFICACIA = "1/1/1753" Then
                    .AddWithValue("@PRAZO_EFICACIA", DBNull.Value)
                Else
                    .AddWithValue("@PRAZO_EFICACIA", PRAZO_EFICACIA)
                End If
                '.AddWithValue("@PRAZO_TRATAMENTO", PRAZO_TRATAMENTO)
                '.AddWithValue("@PRAZO_EFICACIA", PRAZO_EFICACIA)
                .AddWithValue("@SETOR_RESPONSAVEL", SETOR_RESPONSAVEL)
                .AddWithValue("@RESPONSAVEL_SETOR", RESPONSAVEL_SETOR)
                .AddWithValue("@SITUACAO", SITUACAO)
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
        Dim _cmdText As String = "[DELETE_MELHORIAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_MELHORIAS", id)
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

#Region "SITUACAO"

    Public Function UpdateStatus(ByVal idmelhorias As Integer, _
                           ByVal SITUACAO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_MELHORIAS_SITUACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_MELHORIAS", idmelhorias)
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

End Class
