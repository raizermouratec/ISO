Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class Curriculo

#Region "FORMAÇÃO"

#Region "ADD FORMAÇÃO"

    Public Function AddFormacaoCv(ByVal ID_COLABORADORES As Integer, _
                                  ByVal ID_ESCOLARIDADE As Integer, _
                                  ByVal SITUACAO As String, _
                                  ByVal CURSO As String, _
                                  ByVal INSTITUICAO As String, _
                                  ByVal DURACAO_ANO As Integer, _
                                  ByVal DURACAO_MESES As Integer, _
                                  ByVal DATA_CONCLUSAO As Date, _
                        Optional ByRef idFormacaoCv As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_TREINAMENTO_FORMACAO_CV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure


            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_ESCOLARIDADE", ID_ESCOLARIDADE)
                .AddWithValue("@SITUACAO", SITUACAO)
                .AddWithValue("@CURSO", CURSO)
                .AddWithValue("@INSTITUICAO", INSTITUICAO)
                .AddWithValue("@DURACAO_ANO", DURACAO_ANO)
                .AddWithValue("@DURACAO_MESES", DURACAO_MESES)
                .AddWithValue("@DATA_CONCLUSAO", DATA_CONCLUSAO)
            End With

            idFormacaoCv = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE FORMAÇÃO"

    Public Function UpdateFormacaoCv(ByVal idFormacaoCv As Integer, _
                                    ByVal ID_COLABORADORES As Integer, _
                                    ByVal ID_ESCOLARIDADE As Integer, _
                                    ByVal SITUACAO As String, _
                                    ByVal CURSO As String, _
                                    ByVal INSTITUICAO As String, _
                                    ByVal DURACAO_ANO As Integer, _
                                    ByVal DURACAO_MESES As Integer, _
                                    ByVal DATA_CONCLUSAO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_TREINAMENTO_FORMACAO_CV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORMACAO_CV", idFormacaoCv)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_ESCOLARIDADE", ID_ESCOLARIDADE)
                .AddWithValue("@SITUACAO", SITUACAO)
                .AddWithValue("@CURSO", CURSO)
                .AddWithValue("@INSTITUICAO", INSTITUICAO)
                .AddWithValue("@DURACAO_ANO", DURACAO_ANO)
                .AddWithValue("@DURACAO_MESES", DURACAO_MESES)
                .AddWithValue("@DATA_CONCLUSAO", DATA_CONCLUSAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "EXCLUIR FORMAÇÃO"

    Public Function DeleteFormacaoCv(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_TREINAMENTO_FORMACAO_CV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_TREINAMENTO_FORMACAO_CV", id)
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

#Region "EXPERIENCIA"

#Region "ADD EXPERIENCIA"

    Public Function AddExperienciaCV(ByVal ID_COLABORADORES As Integer, _
                                    ByVal EMPRESA As String, _
                                    ByVal CARGO As String, _
                                    ByVal ATIVIDADE As String, _
                                    ByVal DATA_ADMISSAO As Date, _
                                    ByVal DATA_DEMISSAO As Date, _
                        Optional ByRef idExperienciaCv As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_TREINAMENTO_EXPERIENCIA_CV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure


            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@EMPRESA", EMPRESA)
                .AddWithValue("@CARGO", CARGO)
                .AddWithValue("@ATIVIDADE", ATIVIDADE)
                .AddWithValue("@DATA_ADMISSAO", DATA_ADMISSAO)
                .AddWithValue("@DATA_DEMISSAO", DATA_DEMISSAO)
            End With

            idExperienciaCv = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE EXPERIENCIA"

    Public Function UpdateExperienciaCV(ByVal idExperienciaCV As Integer, _
                                    ByVal ID_COLABORADORES As Integer, _
                                    ByVal EMPRESA As String, _
                                    ByVal CARGO As String, _
                                    ByVal ATIVIDADE As String, _
                                    ByVal DATA_ADMISSAO As Date, _
                                    ByVal DATA_DEMISSAO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_TREINAMENTO_EXPERIENCIA_CV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_EXPERIENCIA_CV", idExperienciaCV)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@EMPRESA", EMPRESA)
                .AddWithValue("@CARGO", CARGO)
                .AddWithValue("@ATIVIDADE", ATIVIDADE)
                .AddWithValue("@DATA_ADMISSAO", DATA_ADMISSAO)
                .AddWithValue("@DATA_DEMISSAO", DATA_DEMISSAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "ADD SEM EXPERIENCIA"

    Public Function AddSemExperienciaCV(ByVal ID_COLABORADORES As Integer, _
                                    ByVal EMPRESA As String, _
                                    ByVal CARGO As String, _
                                    ByVal ATIVIDADE As String, _
                        Optional ByRef idSemExperienciaCv As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_TREINAMENTO_SEM_EXPERIENCIA_CV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure


            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@EMPRESA", EMPRESA)
                .AddWithValue("@CARGO", CARGO)
                .AddWithValue("@ATIVIDADE", ATIVIDADE)
            End With

            idSemExperienciaCv = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "EXCLUIR EXPERIENCIA"

    Public Function DeleteExperienciaCV(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_TREINAMENTO_EXPERIENCIA_CV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_TREINAMENTO_EXPERIENCIA_CV", id)
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

#Region "CURSOS"

#Region "ADD CURSOS"

    Public Function AddCursoCV(ByVal ID_COLABORADORES As Integer, _
                               ByVal CURSO As String, _
                               ByVal INSTITUICAO As String, _
                               ByVal CARGA_HORARIA As String, _
                               ByVal DATA_INICIO As Date, _
                               ByVal DATA_TERMINO As Date, _
                        Optional ByRef idCursoCv As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_TREINAMENTO_CURSO_CV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure


            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@CURSO", CURSO)
                .AddWithValue("@INSTITUICAO", INSTITUICAO)
                .AddWithValue("@CARGA_HORARIA", CARGA_HORARIA)
                .AddWithValue("@DATA_INICIO", DATA_INICIO)
                .AddWithValue("@DATA_TERMINO", DATA_TERMINO)
            End With

            idCursoCv = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE CURSOS"

    Public Function UpdateCursoCV(ByVal idCursoCV As Integer, _
                                    ByVal ID_COLABORADORES As Integer, _
                                    ByVal CURSO As String, _
                                    ByVal INSTITUICAO As String, _
                                    ByVal CARGA_HORARIA As String, _
                                    ByVal DATA_INICIO As Date, _
                                    ByVal DATA_TERMINO As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_TREINAMENTO_CURSO_CV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_CURSO_CV", idCursoCV)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@CURSO", CURSO)
                .AddWithValue("@INSTITUICAO", INSTITUICAO)
                .AddWithValue("@CARGA_HORARIA", CARGA_HORARIA)
                .AddWithValue("@DATA_INICIO", DATA_INICIO)
                .AddWithValue("@DATA_TERMINO", DATA_TERMINO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "EXCLUIR CURSOS"

    Public Function DeleteCursoCV(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_TREINAMENTO_CURSO_CV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_TREINAMENTO_CURSO_CV", id)
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

#Region "HABILIDADES"

#Region "ADD HABILIDADES"

    Public Function AddHabilidadesCV(ByVal ID_COLABORADORES As Integer, _
                                    ByVal HABILIDADE As String, _
                                    ByVal METODO As String, _
                                    ByVal RESULTADO As String, _
                                    ByVal DATA As Date, _
                        Optional ByRef idHabilidadesCV As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_TREINAMENTO_HABILIDADES_CV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure


            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@HABILIDADE", HABILIDADE)
                .AddWithValue("@METODO", METODO)
                .AddWithValue("@RESULTADO", RESULTADO)
                .AddWithValue("@DATA", DATA)
            End With

            idHabilidadesCV = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE HABILIADES"

    Public Function UpdateHabilidadesCV(ByVal idHabilidadesCV As Integer, _
                                    ByVal ID_COLABORADORES As Integer, _
                                    ByVal HABILIDADE As String, _
                                    ByVal METODO As String, _
                                    ByVal RESULTADO As String, _
                                    ByVal DATA As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_TREINAMENTO_HABILIDADES_CV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_HABILIDADES_CV", idHabilidadesCV)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@HABILIDADE", HABILIDADE)
                .AddWithValue("@METODO", METODO)
                .AddWithValue("@RESULTADO", RESULTADO)
                .AddWithValue("@DATA", DATA)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "EXCLUIR HABILIDADES"

    Public Function DeleteHabilidadesCV(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_TREINAMENTO_HABILIDADES_CV]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_TREINAMENTO_HABILIDADES_CV", id)
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
