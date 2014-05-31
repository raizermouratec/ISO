Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class planoprojeto

#Region "OBJETIVOS"

#Region "TEXTO"

    Public Function AddObjetivos(ByVal ID_PROJETOS As Integer, _
                        ByVal OBJETIVO_GERAL As String, _
                        ByVal TIPO As Boolean, _
                        ByVal TEXTO As String,
                        Optional ByRef idobjetivostexto As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_PLANO_OBJETIVOS_TEXTO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@OBJETIVO_GERAL", OBJETIVO_GERAL)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@TEXTO", TEXTO)
            End With

            idobjetivostexto = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateObjetivos(ByVal idobjetivostexto As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal OBJETIVO_GERAL As String, _
                        ByVal TIPO As Boolean, _
                        ByVal TEXTO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_PLANO_OBJETIVOS_TEXTO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_OBJETIVOS_TEXTO", idobjetivostexto)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@OBJETIVO_GERAL", OBJETIVO_GERAL)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@TEXTO", TEXTO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "ESTRUTURADO"

    Public Function AddEstruturado(ByVal ID_PROJETOS As Integer, _
                        ByVal RESULTADO As String, _
                        ByVal QUANTIDADE As Integer, _
                        ByVal UNIDADE As Integer, _
                        ByVal AVALIACAO As String, _
                        ByVal ALCANCADO As Boolean,
                        Optional ByRef idestruturado As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_PLANO_OBJETIVOS_ESTRUTURADO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@RESULTADO", RESULTADO)
                .AddWithValue("@QUANTIDADE", QUANTIDADE)
                .AddWithValue("@UNIDADE", UNIDADE)
                .AddWithValue("@AVALIACAO", AVALIACAO)
                .AddWithValue("@ALCANCADO", ALCANCADO)
            End With

            idestruturado = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateEstruturado(ByVal idestruturado As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal RESULTADO As String, _
                        ByVal QUANTIDADE As Integer, _
                        ByVal UNIDADE As Integer, _
                        ByVal AVALIACAO As String, _
                        ByVal ALCANCADO As Boolean) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_PLANO_OBJETIVOS_ESTRUTURADO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_OBJETIVOS_ESTRUTURADO", idestruturado)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@RESULTADO", RESULTADO)
                .AddWithValue("@QUANTIDADE", QUANTIDADE)
                .AddWithValue("@UNIDADE", UNIDADE)
                .AddWithValue("@AVALIACAO", AVALIACAO)
                .AddWithValue("@ALCANCADO", ALCANCADO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteEstruturado(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_PROJETOS_PLANO_OBJETIVOS_ESTRUTURADO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_OBJETIVOS_ESTRUTURADO", id)
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

#Region "ESCOPO"

    Public Function AddEscopo(ByVal ID_PROJETOS As Integer, _
                        ByVal ESPECIFICADOS As String, _
                        ByVal ESTATUARIOS As String, _
                        ByVal REGULAMENTARES As String, _
                        ByVal OUTROS As String, _
                        ByVal INFORMACOES As String, _
                        ByVal EXCLUSAO As String,
                        Optional ByRef idescopo As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_PLANO_ESCOPO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@ESPECIFICADOS", ESPECIFICADOS)
                .AddWithValue("@ESTATUARIOS", ESTATUARIOS)
                .AddWithValue("@REGULAMENTARES", REGULAMENTARES)
                .AddWithValue("@OUTROS", OUTROS)
                .AddWithValue("@INFORMACOES", INFORMACOES)
                .AddWithValue("@EXCLUSAO", EXCLUSAO)
            End With

            idescopo = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateEscopo(ByVal idescopo As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal ESPECIFICADOS As String, _
                        ByVal ESTATUARIOS As String, _
                        ByVal REGULAMENTARES As String, _
                        ByVal OUTROS As String, _
                        ByVal INFORMACOES As String, _
                        ByVal EXCLUSAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_PLANO_ESCOPO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_ESCOPO", idescopo)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@ESPECIFICADOS", ESPECIFICADOS)
                .AddWithValue("@ESTATUARIOS", ESTATUARIOS)
                .AddWithValue("@REGULAMENTARES", REGULAMENTARES)
                .AddWithValue("@OUTROS", OUTROS)
                .AddWithValue("@INFORMACOES", INFORMACOES)
                .AddWithValue("@EXCLUSAO", EXCLUSAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteEscopo(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_PROJETOS_PLANO_ESCOPO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_ESCOPO", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "SAÍDAS"

    Public Function AddSaidas(ByVal ID_PROJETOS As Integer, _
                        ByVal SAIDAS As String,
                        Optional ByRef idsaidas As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_PLANO_SAIDAS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@SAIDAS", SAIDAS)
            End With

            idsaidas = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateSaidas(ByVal idsaidas As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal SAIDAS As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_PLANO_SAIDAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_SAIDAS", idsaidas)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@SAIDAS", SAIDAS)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteSaidas(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_PROJETOS_PLANO_SAIDAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_SAIDAS", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "ESTÁGIOS"

#Region "ATIVIDADE"

    Public Function AddEstagiosAtiv(ByVal ID_COLABORADORES As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal TIPO As Boolean, _
                        ByVal ATIVIDADE As String, _
                        ByVal N_SEQUENCIAL As Integer, _
                        ByVal INICIO As Date, _
                        ByVal TERMINO As Date, _
                        ByVal OBS As String,
                        Optional ByRef idestagiosAtiv As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_PLANO_ESTAGIOS_ATIVIDADE"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@ATIVIDADE", ATIVIDADE)
                .AddWithValue("@N_SEQUENCIAL", N_SEQUENCIAL)
                .AddWithValue("@INICIO", INICIO)
                .AddWithValue("@TERMINO", TERMINO)
                .AddWithValue("@OBS", OBS)
            End With

            idestagiosAtiv = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateEstagiosAtiv(ByVal idestagiosAtiv As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal TIPO As Boolean, _
                        ByVal ATIVIDADE As String, _
                        ByVal N_SEQUENCIAL As Integer, _
                        ByVal INICIO As Date, _
                        ByVal TERMINO As Date, _
                        ByVal OBS As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_PLANO_ESTAGIOS_ATIVIDADE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_ESTAGIOS_ATIVIDADE", idestagiosAtiv)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@ATIVIDADE", ATIVIDADE)
                .AddWithValue("@N_SEQUENCIAL", N_SEQUENCIAL)
                .AddWithValue("@INICIO", INICIO)
                .AddWithValue("@TERMINO", TERMINO)
                .AddWithValue("@OBS", OBS)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteEstagiosAtiv(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_PROJETOS_PLANO_ESTAGIOS_ATIVIDADE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_ESTAGIOS_ATIVIDADE", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "5W2H"

    Public Function AddEstagios5W2H(ByVal ID_PROJETOS As Integer, _
                                    ByVal TIPO As Boolean, _
                                    ByVal OQUE As String, _
                                    ByVal COMO As String, _
                                    ByVal QUEM As String, _
                                    ByVal QUANDO As String, _
                                    ByVal ONDE As String, _
                                    ByVal PORQUE As String, _
                                    ByVal QUANTO As String,
                                    Optional ByRef idestagios5w2h As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_PLANO_ESTAGIOS_5W2H"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@OQUE", OQUE)
                .AddWithValue("@COMO", COMO)
                .AddWithValue("@QUEM", QUEM)
                .AddWithValue("@QUANDO", QUANDO)
                .AddWithValue("@ONDE", ONDE)
                .AddWithValue("@PORQUE", PORQUE)
                .AddWithValue("@QUANTO", QUANTO)
            End With

            idestagios5w2h = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateEstagios5W2H(ByVal idestagios5w2h As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal TIPO As Boolean, _
                        ByVal OQUE As String, _
                        ByVal COMO As String, _
                        ByVal QUEM As String, _
                        ByVal QUANDO As String, _
                        ByVal ONDE As String, _
                        ByVal PORQUE As String, _
                        ByVal QUANTO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_PLANO_ESTAGIOS_5W2H]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_ESTAGIOS_5W2H", idestagios5w2h)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@OQUE", OQUE)
                .AddWithValue("@COMO", COMO)
                .AddWithValue("@QUEM", QUEM)
                .AddWithValue("@QUANDO", QUANDO)
                .AddWithValue("@ONDE", ONDE)
                .AddWithValue("@PORQUE", PORQUE)
                .AddWithValue("@QUANTO", QUANTO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteEstagios5W2H(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_PROJETOS_PLANO_ESTAGIOS_5W2H]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_ESTAGIOS_5W2H", id)
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

#Region "RECURSOS"

    Public Function AddRecursos(ByVal ID_PROJETOS As Integer, _
                        ByVal RECURSOS As String, _
                        ByVal TIPO As String, _
                        ByVal QUANTIDADE As String, _
                        ByVal UNIDADE As String, _
                        ByVal VALOR_UNITARIO As Integer, _
                        ByVal VALOR_TOTAL As Integer,
                        Optional ByRef idrecursos As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_PLANO_RECURSOS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@RECURSOS", RECURSOS)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@QUANTIDADE", QUANTIDADE)
                .AddWithValue("@UNIDADE", UNIDADE)
                .AddWithValue("@VALOR_UNITARIO", VALOR_UNITARIO)
                .AddWithValue("@VALOR_TOTAL", VALOR_TOTAL)
            End With

            idrecursos = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateRecursos(ByVal idrecursos As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal RECURSOS As String, _
                        ByVal TIPO As String, _
                        ByVal QUANTIDADE As String, _
                        ByVal UNIDADE As String, _
                        ByVal VALOR_UNITARIO As Integer, _
                        ByVal VALOR_TOTAL As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_PLANO_RECURSOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_RECURSOS", idrecursos)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@RECURSOS", RECURSOS)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@QUANTIDADE", QUANTIDADE)
                .AddWithValue("@UNIDADE", UNIDADE)
                .AddWithValue("@VALOR_UNITARIO", VALOR_UNITARIO)
                .AddWithValue("@VALOR_TOTAL", VALOR_TOTAL)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteRecursos(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_PROJETOS_PLANO_RECURSOS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_RECURSOS", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "CONTROLE"

#Region "ANALISE CRITICA"

    Public Function AddControleAC(ByVal ID_COLABORADORES As Integer, _
                            ByVal ID_PROJETOS As Integer, _
                            ByVal METODO As String, _
                            ByVal PROGRAMACAO As String,
                            Optional ByRef idcontroleAC As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_PLANO_CONTROLE_AC"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@METODO", METODO)
                .AddWithValue("@PROGRAMACAO", PROGRAMACAO)
            End With

            idcontroleAC = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateControleAC(ByVal idcontroleAC As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal METODO As String, _
                        ByVal PROGRAMACAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_PLANO_CONTROLE_AC]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_CONTROLE_AC", idcontroleAC)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@METODO", METODO)
                .AddWithValue("@PROGRAMACAO", PROGRAMACAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteControleAC(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_PROJETOS_PLANO_CONTROLE_AC]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_CONTROLE_AC", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "VERIFICAÇÃO"

    Public Function AddControleVerif(ByVal ID_COLABORADORES As Integer, _
                            ByVal ID_PROJETOS As Integer, _
                            ByVal METODO As String, _
                            ByVal PROGRAMACAO As String,
                            Optional ByRef idcontroleVerif As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_PLANO_CONTROLE_VERIFICACAO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@METODO", METODO)
                .AddWithValue("@PROGRAMACAO", PROGRAMACAO)
            End With

            idcontroleVerif = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateControleVerif(ByVal idcontroleVerif As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal METODO As String, _
                        ByVal PROGRAMACAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_PLANO_CONTROLE_VERIFICACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_CONTROLE_VERIFICACAO", idcontroleVerif)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@METODO", METODO)
                .AddWithValue("@PROGRAMACAO", PROGRAMACAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteControleVerif(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_PROJETOS_PLANO_CONTROLE_VERIFICACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_CONTROLE_VERIFICACAO", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "VALIDAÇÃO"

    Public Function AddControleValid(ByVal ID_COLABORADORES As Integer, _
                            ByVal ID_PROJETOS As Integer, _
                            ByVal METODO As String, _
                            ByVal PROGRAMACAO As String,
                            Optional ByRef idcontroleValid As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_PLANO_CONTROLE_VALIDACAO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@METODO", METODO)
                .AddWithValue("@PROGRAMACAO", PROGRAMACAO)
            End With

            idcontroleValid = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateControleValid(ByVal idcontroleValid As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal METODO As String, _
                        ByVal PROGRAMACAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_PLANO_CONTROLE_VALIDACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_CONTROLE_VALIDACAO", idcontroleValid)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@METODO", METODO)
                .AddWithValue("@PROGRAMACAO", PROGRAMACAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteControleValid(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_PROJETOS_PLANO_CONTROLE_VALIDACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_CONTROLE_VALIDACAO", id)
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

#Region "RISCO"

    Public Function AddRisco(ByVal ID_COLABORADORES As Integer, _
                        ByVal ID_PROJETOS As String, _
                        ByVal DESCRICAO As String, _
                        ByVal IMPACTO As String, _
                        ByVal CONSEQUENCIAS As String, _
                        ByVal P As Integer, _
                        ByVal S As Integer, _
                        ByVal GRAU As Integer, _
                        ByVal CLASSE As Integer, _
                        ByVal ACAO As String, _
                        ByVal PRAZO As Date, _
                        ByVal ACOMPANHAMENTO As String,
                        Optional ByRef idrisco As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_PLANO_RISCO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@IMPACTO", IMPACTO)
                .AddWithValue("@CONSEQUENCIAS", CONSEQUENCIAS)
                .AddWithValue("@P", P)
                .AddWithValue("@S", S)
                .AddWithValue("@GRAU", GRAU)
                .AddWithValue("@CLASSE", CLASSE)
                .AddWithValue("@ACAO", ACAO)
                .AddWithValue("@PRAZO", PRAZO)
                .AddWithValue("@ACOMPANHAMENTO", ACOMPANHAMENTO)
            End With

            idrisco = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateRisco(ByVal idrisco As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal ID_PROJETOS As String, _
                        ByVal DESCRICAO As String, _
                        ByVal IMPACTO As String, _
                        ByVal CONSEQUENCIAS As String, _
                        ByVal P As Integer, _
                        ByVal S As Integer, _
                        ByVal GRAU As Integer, _
                        ByVal CLASSE As Integer, _
                        ByVal ACAO As String, _
                        ByVal PRAZO As Date, _
                        ByVal ACOMPANHAMENTO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_PLANO_RISCO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_RISCO", idrisco)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@IMPACTO", IMPACTO)
                .AddWithValue("@CONSEQUENCIAS", CONSEQUENCIAS)
                .AddWithValue("@P", P)
                .AddWithValue("@S", S)
                .AddWithValue("@GRAU", GRAU)
                .AddWithValue("@CLASSE", CLASSE)
                .AddWithValue("@ACAO", ACAO)
                .AddWithValue("@PRAZO", PRAZO)
                .AddWithValue("@ACOMPANHAMENTO", ACOMPANHAMENTO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteRisco(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_PROJETOS_PLANO_RISCO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_RISCO", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "REVISOES"

    Public Function AddRevisoes(ByVal ID_COLABORADORES As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal TIPO As Integer, _
                        ByVal REVISAO As Integer, _
                        ByVal ALTERACAO As String, _
                        ByVal DATA As Date,
                        Optional ByRef idrevisoes As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_PROJETOS_PLANO_REVISOES"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@ALTERACAO", ALTERACAO)
                .AddWithValue("@DATA", DATA)
            End With

            idrevisoes = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateRevisoes(ByVal idrevisoes As Integer, _
                        ByVal ID_COLABORADORES As Integer, _
                        ByVal ID_PROJETOS As Integer, _
                        ByVal TIPO As Integer, _
                        ByVal REVISAO As Integer, _
                        ByVal ALTERACAO As String, _
                        ByVal DATA As Date) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_PROJETOS_PLANO_REVISOES]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_REVISOES", idrevisoes)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@ID_PROJETOS", ID_PROJETOS)
                .AddWithValue("@TIPO", TIPO)
                .AddWithValue("@REVISAO", REVISAO)
                .AddWithValue("@ALTERACAO", ALTERACAO)
                .AddWithValue("@DATA", DATA)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DeleteRevisoes(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_PROJETOS_PLANO_REVISOES]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PROJETOS_PLANO_REVISOES", id)
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
