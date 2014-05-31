Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class produto

    Public Function Add(ByVal ID_PRODUTOS_GRUPO As Integer, _
                        ByVal ID_PRODUTOS_SUBGRUPO As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal CODIGO As String, _
                        ByVal NOME As String, _
                        ByVal DESCRICAO As String, _
                        ByVal COMPOSICAO As String, _
                        ByVal DESEMPENHO As String, _
                        ByVal COMPONENTES As String, _
                        ByVal OUTROS As String, _
                        ByVal FOTO() As Byte, _
                        ByVal DATA As Date, _
                        Optional ByRef idprodutos As Integer = 0) As String

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PRODUTOS"
        Dim id As String = String.Empty

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_PRODUTOS_GRUPO", ID_PRODUTOS_GRUPO)
                .AddWithValue("@ID_PRODUTOS_SUBGRUPO", ID_PRODUTOS_SUBGRUPO)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@COMPOSICAO", COMPOSICAO)
                .AddWithValue("@DESEMPENHO", DESEMPENHO)
                .AddWithValue("@COMPONENTES", COMPONENTES)
                .AddWithValue("@OUTROS", OUTROS)

                'Verifica se FOTO é Nothing
                If Not FOTO Is Nothing Then
                    .AddWithValue("@FOTO", FOTO)
                Else : FOTO = New Byte(Convert.ToString(1)) {}
                    .AddWithValue("@FOTO", FOTO)
                End If

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

    Public Function Update(ByVal idprodutos As Integer, _
                        ByVal ID_PRODUTOS_GRUPO As Integer, _
                        ByVal ID_PRODUTOS_SUBGRUPO As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal CODIGO As String, _
                        ByVal NOME As String, _
                        ByVal DESCRICAO As String, _
                        ByVal COMPOSICAO As String, _
                        ByVal DESEMPENHO As String, _
                        ByVal COMPONENTES As String, _
                        ByVal OUTROS As String, _
                        ByVal FOTO() As Byte, _
                        ByVal DATA As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PRODUTOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_PRODUTOS", idprodutos)
                .AddWithValue("@ID_PRODUTOS_GRUPO", ID_PRODUTOS_GRUPO)
                .AddWithValue("@ID_PRODUTOS_SUBGRUPO", ID_PRODUTOS_SUBGRUPO)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@COMPOSICAO", COMPOSICAO)
                .AddWithValue("@DESEMPENHO", DESEMPENHO)
                .AddWithValue("@COMPONENTES", COMPONENTES)
                .AddWithValue("@OUTROS", OUTROS)

                'Verifica se FOTO é Nothing
                If Not FOTO Is Nothing Then
                    .AddWithValue("@FOTO", FOTO)
                Else : FOTO = New Byte(Convert.ToString(1)) {}
                    .AddWithValue("@FOTO", FOTO)
                End If

                .AddWithValue("@DATA", DATA)

            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update1(ByVal idprodutos As Integer, _
                        ByVal ID_PRODUTOS_GRUPO As Integer, _
                        ByVal ID_PRODUTOS_SUBGRUPO As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal CODIGO As String, _
                        ByVal NOME As String, _
                        ByVal DESCRICAO As String, _
                        ByVal COMPOSICAO As String, _
                        ByVal DESEMPENHO As String, _
                        ByVal COMPONENTES As String, _
                        ByVal OUTROS As String, _
                        ByVal DATA As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE1_PRODUTOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters

                .AddWithValue("@ID_PRODUTOS", idprodutos)
                .AddWithValue("@ID_PRODUTOS_GRUPO", ID_PRODUTOS_GRUPO)
                .AddWithValue("@ID_PRODUTOS_SUBGRUPO", ID_PRODUTOS_SUBGRUPO)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@CODIGO", CODIGO)
                .AddWithValue("@NOME", NOME)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@COMPOSICAO", COMPOSICAO)
                .AddWithValue("@DESEMPENHO", DESEMPENHO)
                .AddWithValue("@COMPONENTES", COMPONENTES)
                .AddWithValue("@OUTROS", OUTROS)
                .AddWithValue("@DATA", DATA)

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
        Dim _cmdText As String = "[DELETE_PRODUTOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PRODUTOS", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
