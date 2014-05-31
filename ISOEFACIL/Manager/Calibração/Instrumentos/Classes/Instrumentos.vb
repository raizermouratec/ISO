Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class instrumentos

    Public Function Add(ByVal ID_TIPO_MEDICAO As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal NOME As String, _
                        ByVal IDENTIFICACAO As String, _
                        ByVal TIPO_USO As Integer, _
                        ByVal FAIXA_MEDICAO As String, _
                        ByVal PRECISAO As String, _
                        ByVal FABRICANTE As String, _
                        ByVal LOCAL_GUARDA As String, _
                        ByVal ARMAZENAMENTO As String, _
                        ByVal SITUACAO As Integer, _
                        ByVal DATA_AQUISICAO As Date, _
                        ByVal DATA As Date, _
                        ByVal ATIVO As Boolean, _
                        ByVal FOTO() As Byte, _
                        Optional ByRef idInstrumentos As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_CALIBRACOES_INSTRUMENTOS"


        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            'Limpar mascaras
            With _Command.Parameters

                .AddWithValue("@ID_TIPO_MEDICAO", ID_TIPO_MEDICAO)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@IDENTIFICACAO", IDENTIFICACAO)
                .AddWithValue("@TIPO_USO", TIPO_USO)
                .AddWithValue("@FAIXA_MEDICAO", FAIXA_MEDICAO)
                .AddWithValue("@PRECISAO", PRECISAO)
                .AddWithValue("@FABRICANTE", FABRICANTE)
                .AddWithValue("@LOCAL_GUARDA", LOCAL_GUARDA)
                .AddWithValue("@ARMAZENAMENTO", ARMAZENAMENTO)
                .AddWithValue("@SITUACAO", SITUACAO)
                .AddWithValue("@DATA_AQUISICAO", DATA_AQUISICAO)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@ATIVO", ATIVO)

                'Verifica se FOTO é Nothing
                If Not FOTO Is Nothing Then
                    .AddWithValue("@FOTO", FOTO)
                Else : FOTO = New Byte(Convert.ToString(1)) {}
                    .AddWithValue("@FOTO", FOTO)
                End If

            End With

            idInstrumentos = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False

        End Try

    End Function

    Public Function Update(
                        ByVal idInstrumentos As Integer, _
                        ByVal ID_TIPO_MEDICAO As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal NOME As String, _
                        ByVal IDENTIFICACAO As String, _
                        ByVal TIPO_USO As Integer, _
                        ByVal FAIXA_MEDICAO As String, _
                        ByVal PRECISAO As String, _
                        ByVal FABRICANTE As String, _
                        ByVal LOCAL_GUARDA As String, _
                        ByVal ARMAZENAMENTO As String, _
                        ByVal SITUACAO As Integer, _
                        ByVal DATA_AQUISICAO As Date, _
                        ByVal DATA As Date, _
                        ByVal ATIVO As Boolean, _
                        ByVal FOTO() As Byte) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_CALIBRACOES_INSTRUMENTOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_CALIBRACOES_INSTRUMENTOS", idInstrumentos)
                .AddWithValue("@ID_TIPO_MEDICAO", ID_TIPO_MEDICAO)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@IDENTIFICACAO", IDENTIFICACAO)
                .AddWithValue("@TIPO_USO", TIPO_USO)
                .AddWithValue("@FAIXA_MEDICAO", FAIXA_MEDICAO)
                .AddWithValue("@PRECISAO", PRECISAO)
                .AddWithValue("@FABRICANTE", FABRICANTE)
                .AddWithValue("@LOCAL_GUARDA", LOCAL_GUARDA)
                .AddWithValue("@ARMAZENAMENTO", ARMAZENAMENTO)
                .AddWithValue("@SITUACAO", SITUACAO)
                .AddWithValue("@DATA_AQUISICAO", DATA_AQUISICAO)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@ATIVO", ATIVO)

                'Verifica se FOTO é Nothing
                If Not FOTO Is Nothing Then
                    .AddWithValue("@FOTO", FOTO)
                Else : FOTO = New Byte(Convert.ToString(1)) {}
                    .AddWithValue("@FOTO", FOTO)
                End If

            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update1(
                        ByVal idInstrumentos As Integer, _
                        ByVal ID_TIPO_MEDICAO As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal NOME As String, _
                        ByVal IDENTIFICACAO As String, _
                        ByVal TIPO_USO As Integer, _
                        ByVal FAIXA_MEDICAO As String, _
                        ByVal PRECISAO As String, _
                        ByVal FABRICANTE As String, _
                        ByVal LOCAL_GUARDA As String, _
                        ByVal ARMAZENAMENTO As String, _
                        ByVal SITUACAO As Integer, _
                        ByVal DATA_AQUISICAO As Date, _
                        ByVal DATA As Date, _
                        ByVal ATIVO As Boolean) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE1_CALIBRACOES_INSTRUMENTOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_CALIBRACOES_INSTRUMENTOS", idInstrumentos)
                .AddWithValue("@ID_TIPO_MEDICAO", ID_TIPO_MEDICAO)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@IDENTIFICACAO", IDENTIFICACAO)
                .AddWithValue("@TIPO_USO", TIPO_USO)
                .AddWithValue("@FAIXA_MEDICAO", FAIXA_MEDICAO)
                .AddWithValue("@PRECISAO", PRECISAO)
                .AddWithValue("@FABRICANTE", FABRICANTE)
                .AddWithValue("@LOCAL_GUARDA", LOCAL_GUARDA)
                .AddWithValue("@ARMAZENAMENTO", ARMAZENAMENTO)
                .AddWithValue("@SITUACAO", SITUACAO)
                .AddWithValue("@DATA_AQUISICAO", DATA_AQUISICAO)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@ATIVO", ATIVO)

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
        Dim _cmdText As String = "[DELETE_CALIBRACOES_INSTRUMENTOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_CALIBRACOES_INSTRUMENTOS", id)

            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
