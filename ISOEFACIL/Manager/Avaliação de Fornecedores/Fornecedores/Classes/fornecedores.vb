Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class Fornecedores
    Dim teste As New forCadFornecedores
    Public Function Add(ByVal NOME As String, _
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
                        ByVal ESTADO As Integer, _
                        ByVal CIDADE As Integer, _
                        ByVal CEP As String, _
                        ByVal TELEFONE_01 As String, _
                        ByVal TELEFONE_02 As String, _
                        ByVal TELEFONE_03 As String, _
                        ByVal EMAIL As String, _
                        ByVal WEBSITE As String, _
                        ByVal SKYPE As String, _
                        Optional ByRef idFornecedor As Integer = 0) As Integer


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_FORNECEDORES"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            'Limpar mascaras
            CNPJ = Regex.Replace(CNPJ, "[^0-9]", "")
            CPF = Regex.Replace(CPF, "[^0-9]", "")

            With _Command.Parameters
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

            idFornecedor = _Command.ExecuteScalar


            Return idFornecedor
            _Connection.Close()
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update(ByVal idFornecedor As Integer, _
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
                        ByVal ESTADO As Integer, _
                        ByVal CIDADE As Integer, _
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
        Dim _cmdText As String = "[UPDATE_FORNECEDORES]"

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
                .AddWithValue("@ID_FORNECEDOR", idFornecedor)
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

    Public Function Delete(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_FORNECEDORES]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDOR", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
