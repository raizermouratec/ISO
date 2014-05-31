Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms

Public Class documentos

#Region "CADASTRO"

#Region "ADD DOCUMENTO"

    Public Function Add(ByVal PROCEDIMENTO As String, _
                         ByVal DESCRICAO As String, _
                         ByVal STATUS As Integer, _
                         ByVal REVISAO As Integer, _
                         ByVal SISTEMA As Integer, _
                         ByVal HABILITADO As Integer, _
                         ByVal VALIDADE As Date, _
                         ByVal OPCAO_TXT As Integer, _
                         ByVal OPCAO_ATV As Integer, _
                         ByVal OPCAO_HIT As Integer, _
                         ByVal OPCAO_REG As Integer, _
                         ByVal TIPO As Integer, _
          Optional ByRef idDoc As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@PROCEDIMENTO", PROCEDIMENTO)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@STATUS", STATUS)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@SISTEMA", SISTEMA)
                .AddWithValue("@HABILITADO", HABILITADO)
                .AddWithValue("@VALIDADE", VALIDADE)
                .AddWithValue("@OPCAO_TXT", OPCAO_TXT)
                .AddWithValue("@OPCAO_ATV", OPCAO_ATV)
                .AddWithValue("@OPCAO_HIT", OPCAO_HIT)
                .AddWithValue("@OPCAO_REG", OPCAO_REG)
                .AddWithValue("@TIPO", TIPO)
            End With

            idDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE DOCUMENTO"

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

            ''Limpar mascaras
            'CNPJ = Regex.Replace(CNPJ, "[^0-9]", "")
            'CEP = Regex.Replace(CEP, "[^0-9]", "")
            'telefone1 = Regex.Replace(telefone1, "[^0-9]", "")
            'telefone2 = Regex.Replace(telefone2, "[^0-9]", "")
            'fax = Regex.Replace(fax, "[^0-9]", "")

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

#Region "DELETE DOCUMENTO"

    Public Function Delete(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_CLIENTES]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CLIENTES", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

    '////////////[DOCUMENTOS]//////////////////

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

    Public Function AddCdocBD(ByVal CODIGO As String, _
                         ByVal REVISAO As Integer, _
                         ByVal DOCUMENTO() As Byte, _
                         ByVal DOCUMENTO_FISICO As String, _
          Optional ByRef idDocBD As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_BD]"

        Try
            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@DOCUMENTO", DOCUMENTO)
                .AddWithValue("@DOCUMENTO_FISICO", DOCUMENTO_FISICO)
            End With

            idDocBD = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

    '////////////[REVISAO]/////////////////

#Region "ADD RESUMO REVISAO"

    Public Function AddResumoRevisao(ByVal ID_DOCUMENTO_CONTROLE_DOCUMENTO As Integer, _
                                     ByVal REVISAO As Integer, _
                                      ByVal TEXTO As String, _
          Optional ByRef idDoc As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_CONTROLE_RESUMO_REVISAO]"

        Try
            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_DOCUMENTO_CONTROLE_DOCUMENTO", ID_DOCUMENTO_CONTROLE_DOCUMENTO)
                .AddWithValue("@TEXTO", TEXTO)
                .AddWithValue("@REVISAO", REVISAO)
            End With

            idDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE RESUMO REVISAO"

    Public Function UpdateResumoRevisao(ByVal ID As Integer, _
                                        ByVal REVISAO As Integer, _
                                        ByVal SITUACAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_CONTROLE_DOCUMENTO_SITUACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID", ID)
                .AddWithValue("@REVISAO", REVISAO)
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

    '////////////[CANCELAMENTO]/////////////////

#Region "ADD CANCELAMENTO"

    Public Function AddCancelamento(ByVal ID_DOCUMENTO_CONTROLE_DOCUMENTO As Integer, _
                                   ByVal TEXTO As String, _
          Optional ByRef idDoc As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_CONTROLE_CANCELAMENTO]"

        Try
            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_DOCUMENTO_CONTROLE_DOCUMENTO", ID_DOCUMENTO_CONTROLE_DOCUMENTO)
                .AddWithValue("@TEXTO", TEXTO)
            End With

            idDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE CANCELAMENTO"

    Public Function UpdateCancelamento(ByVal ID_DOCUMENTO_CONTROLE_DOCUMENTO As Integer, _
                        ByVal SITUACAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_CONTROLE_CANCELAMENTO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_DOCUMENTO_CONTROLE_DOCUMENTO", ID_DOCUMENTO_CONTROLE_DOCUMENTO)
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

#End Region

#Region "CONTROLE"

#Region "ELABORAÇÃO"

    Public Function AddControleElab(ByVal ID_COLABORADORES As Integer, _
                                    ByVal CODIGO As String, _
                                    ByVal REVISAO As Integer, _
                                    ByVal DATA_CONCLUSAO As Date, _
                                    ByVal DATA_MENSAGEM As Date, _
                                    Optional ByRef idDoc As Integer = 0) As String

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_CONTROLE_ELAB]"
        Dim id As String = String.Empty

        Try
            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@REVISAO", REVISAO)
                If DATA_CONCLUSAO = "#12:00:00 AM#" Then
                    .AddWithValue("@DATA_CONCLUSAO", DBNull.Value)
                Else
                    .AddWithValue("@DATA_CONCLUSAO", DATA_CONCLUSAO)
                End If
                If DATA_MENSAGEM = "#12:00:00 AM#" Then
                    .AddWithValue("@DATA_MENSAGEM", DBNull.Value)
                Else
                    .AddWithValue("@DATA_MENSAGEM", DATA_MENSAGEM)
                End If
                .AddWithValue("@MSG", "")
            End With

            Using sdr As SqlDataReader = _Command.ExecuteReader
                If sdr.Read Then
                    id = sdr("RESULTADO").ToString
                End If
            End Using

            Return id.ToString
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateControleElab(ByVal ID_COLABORADORES As Integer, _
                                        ByVal CODIGO As String, _
                                        ByVal REVISAO As Integer, _
                                        ByVal DATA_CONCLUSAO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_CONTROLE_ELAB]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@REVISAO", REVISAO)
                If DATA_CONCLUSAO = "#12:00:00 AM#" Then
                    .AddWithValue("@DATA_CONCLUSAO", DBNull.Value)
                Else
                    .AddWithValue("@DATA_CONCLUSAO", DATA_CONCLUSAO)
                End If
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "CONSENSO"

    Public Function AddControleConsenso(ByVal CODIGO As String, _
                                        ByVal REVISAO As Integer, _
                                        ByVal DATA_CONCLUSAO As Date, _
                                        ByVal DATA_MENSAGEM As Date, _
                                        Optional ByRef idDoc As Integer = 0) As String


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_CONTROLE_CONSENC]"
        Dim id As String = String.Empty

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@REVISAO", REVISAO)
                If DATA_CONCLUSAO = "#12:00:00 AM#" Then
                    .AddWithValue("@DATA_CONCLUSAO", DBNull.Value)
                Else
                    .AddWithValue("@DATA_CONCLUSAO", DATA_CONCLUSAO)
                End If
                If DATA_MENSAGEM = "#12:00:00 AM#" Then
                    .AddWithValue("@DATA_MENSAGEM", DBNull.Value)
                Else
                    .AddWithValue("@DATA_MENSAGEM", DATA_MENSAGEM)
                End If
                .AddWithValue("@MSG", "")
            End With


            Using sdr As SqlDataReader = _Command.ExecuteReader
                If sdr.Read Then
                    id = sdr("RESULTADO").ToString
                End If
            End Using

            Return id.ToString
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateControleConsenso(ByVal CODIGO As String, _
                                            ByVal REVISAO As Integer, _
                                            ByVal DATA_CONCLUSAO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_CONTROLE_CONSENC]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@REVISAO", REVISAO)
                If DATA_CONCLUSAO = "#12:00:00 AM#" Then
                    .AddWithValue("@DATA_CONCLUSAO", DBNull.Value)
                Else
                    .AddWithValue("@DATA_CONCLUSAO", DATA_CONCLUSAO)
                End If
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function


#End Region

#Region "APROVAÇÃO"
    Public Function AddControleAprovacao(ByVal CODIGO As String, _
                                         ByVal REVISAO As Integer, _
                                         ByVal DATA_CONCLUSAO As Date, _
                                         ByVal DATA_MENSAGEM As Date, _
                                         Optional ByRef idDoc As Integer = 0) As String


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_CONTROLE_APROVA]"
        Dim id As String = String.Empty

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@DATA_CONCLUSAO", DATA_CONCLUSAO)
                If DATA_MENSAGEM = "#12:00:00 AM#" Then
                    .AddWithValue("@DATA_MENSAGEM", DBNull.Value)
                Else
                    .AddWithValue("@DATA_MENSAGEM", DATA_MENSAGEM)
                End If
                .AddWithValue("@MSG", "")
            End With


            Using sdr As SqlDataReader = _Command.ExecuteReader
                If sdr.Read Then
                    id = sdr("RESULTADO").ToString
                End If
            End Using

            Return id.ToString
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function UpdateControleAprovacao(ByVal CODIGO As String, _
                                                ByVal REVISAO As Integer, _
                                                ByVal DATA_CONCLUSAO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_CONTROLE_APROVA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@REVISAO", REVISAO)
                If DATA_CONCLUSAO = "#12:00:00 AM#" Then
                    .AddWithValue("@DATA_CONCLUSAO", DBNull.Value)
                Else
                    .AddWithValue("@DATA_CONCLUSAO", DATA_CONCLUSAO)
                End If
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "PUBLICAÇÃO"
    Public Function AddControlePublicacao(ByVal CODIGO As String, _
                                            ByVal REVISAO As Integer, _
                                            ByVal DATA_CONCLUSAO As Date, _
                                            ByVal DATA_MENSAGEM As Date, _
                                            Optional ByRef idDoc As Integer = 0) As String

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_CONTROLE_PUBLICACAO]"
        Dim id As String = String.Empty

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@DATA_CONCLUSAO", DATA_CONCLUSAO)
                If DATA_MENSAGEM = "#12:00:00 AM#" Then
                    .AddWithValue("@DATA_MENSAGEM", DBNull.Value)
                Else
                    .AddWithValue("@DATA_MENSAGEM", DATA_MENSAGEM)
                End If
                .AddWithValue("@MSG", "")
            End With


            Using sdr As SqlDataReader = _Command.ExecuteReader
                If sdr.Read Then
                    id = sdr("RESULTADO").ToString
                End If
            End Using

            Return id.ToString
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateControlePublicacao(ByVal CODIGO As String, _
                                                ByVal REVISAO As Integer, _
                                                ByVal DATA_CONCLUSAO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_CONTROLE_PUBLICACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@REVISAO", REVISAO)
                If DATA_CONCLUSAO = "#12:00:00 AM#" Then
                    .AddWithValue("@DATA_CONCLUSAO", DBNull.Value)
                Else
                    .AddWithValue("@DATA_CONCLUSAO", DATA_CONCLUSAO)
                End If
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "HISTÓRICO"
    Public Function AddControleHistorico(ByVal CODIGO As String, _
                                         ByVal REVISAO As Integer, _
                                         ByVal DATA As Date, _
                                         ByVal OCORRENCIA As String, _
                                         Optional ByRef idDoc As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_CONTROLE_HISTORICO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@OCORRENCIA", OCORRENCIA)
            End With

            idDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "EQUIPE ELABORAÇÃO"

    Public Function AddEquipeControleElab(ByVal ID_COLABORADORES As Integer, _
                                            ByVal NOME As String, _
                                            ByVal CONTROLE As String, _
                                            ByVal REVISAO As Integer, _
                                            Optional ByRef idDoc As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_CONTROLE_ELAB_EQUIPE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@CONTROLE", CONTROLE)
                .AddWithValue("@REVISAO", REVISAO)
            End With

            idDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteEquipeControleElab(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_DOCUMENTO_CONTROLE_ELAB_EQUIPE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateEquipeControleElab(ByVal CODIGO_CONTROLE As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_CONTROLE_ELAB_EQUIPE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO_CONTROLE", CODIGO_CONTROLE)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "EQUIPE CONSENCO"

    Public Function AddEquipeControleConsenc(ByVal ID_COLABORADORES As Integer, _
                                                ByVal NOME As String, _
                                                ByVal CONTROLE As String, _
                                                ByVal REVISAO As Integer, _
                                                Optional ByRef idDoc As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_CONTROLE_CONSENC_EQUIPE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@CONTROLE", CONTROLE)
                .AddWithValue("@REVISAO", REVISAO)
            End With

            idDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteEquipeControleConsenc(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_DOCUMENTO_CONTROLE_CONSENC_EQUIPE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateEquipeControleConsenso(ByVal CODIGO_CONTROLE As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_CONTROLE_CONSENC_EQUIPE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO_CONTROLE", CODIGO_CONTROLE)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "EQUIPE APROVAÇÃO"

    Public Function AddEquipeControleAprova(ByVal ID_COLABORADORES As Integer, _
                                            ByVal NOME As String, _
                                            ByVal CONTROLE As String, _
                                            ByVal REVISAO As Integer, _
                                            Optional ByRef idDoc As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_CONTROLE_APROVA_EQUIPE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@CONTROLE", CONTROLE)
                .AddWithValue("@REVISAO", REVISAO)
            End With

            idDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteEquipeControleAprova(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_DOCUMENTO_CONTROLE_APROVA_EQUIPE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateEquipeControleAprova(ByVal CODIGO_CONTROLE As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_CONTROLE_APROVA_EQUIPE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO_CONTROLE", CODIGO_CONTROLE)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "EQUIPE PUBLICAÇÃO"

    Public Function AddEquipeControlePublicacao(ByVal ID_COLABORADORES As Integer, _
                                                ByVal ID_AREAS As Integer, _
                                                ByVal ID_CARGOS As Integer, _
                                                ByVal GRUPOS As String, _
                                                ByVal NOME As String, _
                                                ByVal CONTROLE As String, _
                                                ByVal REVISAO As Integer, _
                                                Optional ByRef idDoc As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_DOCUMENTO_CONTROLE_PUBLICACAO_EQUIPE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_AREAS", ID_AREAS)
                .AddWithValue("@ID_CARGOS", ID_CARGOS)
                .AddWithValue("@GRUPOS", GRUPOS)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@CONTROLE", CONTROLE)
                .AddWithValue("@REVISAO", REVISAO)
            End With

            idDoc = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteEquipeControlePublicacao(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_DOCUMENTO_CONTROLE_PUBLICACAO_EQUIPE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateEquipeControlePublicacao(ByVal CODIGO_CONTROLE As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_CONTROLE_PUBLICACAO_EQUIPE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO_CONTROLE", CODIGO_CONTROLE)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

    Public Function UpdateSituacaoRevisao(ByVal CODIGO As String, _
                                            ByVal REVISAO As Integer, _
                                            ByVal SITUACAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_CONTROLE_DOCUMENTO_SITUACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@SITUACAO", SITUACAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateRevisao(ByVal CODIGO As String, _
                                  ByVal REVISAO As Integer, _
                                  ByVal NOVAREVISAO As Integer, _
                                  ByVal SITUACAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_DOCUMENTO_CONTROLE_DOCUMENTO_REVISAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@NOVAREVISAO", NOVAREVISAO)
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
