Imports System.Data.SqlClient
Public Class forCadPerfil
#Region "Variaveis "
    Public idEdit As Boolean = False
    Public id_Perfil As Integer = 0
    ' Public ID_Perfil As Integer
#End Region

#Region "LOAD"
    Private Sub ForAvaliacao_Perfil_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CARREGA LISTA
        If idEdit = True Then
            Dim dr As SqlDataReader
            dr = Manager.Util.getDataReader("SELECT * FROM FORNECEDORES_AVALIACAO_PERFIL_ID where ID_PERFIL = " & id_Perfil)
            While dr.Read
                txtNome.Text = dr("NOME_PERFIL").ToString
            End While
            carregaRequisitos()
        Else

            carregaRequisitos()
        End If

    End Sub
#End Region

#Region "Pega ID"
    Public WriteOnly Property ID_Perfil_Rec() As String
        Set(ByVal value As String)
            Me.id_Perfil = value
        End Set
    End Property
#End Region

#Region "CARREGAR LISTA"
    Public Sub carregaRequisitos()
        If idEdit = True Then
            Dim dr As SqlDataReader
            dr = Manager.Util.getDataReader("SELECT * FROM VW_REQUISITOS")
            gridRequisitos.Rows.Count = 1
            While dr.Read
                Dim id_Requisito As Integer
                gridRequisitos.Rows.Add()
                gridRequisitos(gridRequisitos.Rows.Count - 1, 1) = dr("CODIGO")
                id_Requisito = dr("CODIGO")
                Dim dr1 As SqlDataReader
                dr1 = Manager.Util.getDataReader("SELECT * FROM FORNECEDORES_AVALIACAO_PERFIL where ID_PERFIL = " & id_Perfil & " and ID_REQUISITOS =" & id_Requisito)
                If dr1.Read = True Then
                    gridRequisitos(gridRequisitos.Rows.Count - 1, 2) = True
                Else
                    gridRequisitos(gridRequisitos.Rows.Count - 1, 3) = False
                End If
                gridRequisitos(gridRequisitos.Rows.Count - 1, 3) = dr("DESCRICAO")
            End While

        Else
            gridRequisitos.AutoGenerateColumns = False
            gridRequisitos.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_REQUISITOS")
        End If
    End Sub

#End Region

#Region "ATUALIZA CHECK"
    Private Sub gridRequisito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridRequisitos.Click
        With gridRequisitos
            If .ColSel = 2 Then
                Dim Aprovado As Boolean
                Try
                    If .Item(.RowSel, .ColSel) = True Then
                        Aprovado = False
                        .Item(.RowSel, .ColSel) = False
                    Else
                        Aprovado = True
                        .Item(.RowSel, .ColSel) = True
                    End If
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
        End With
    End Sub

#End Region

#Region "Salvar"
    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click
        Dim i As Integer
        Try
            'Editar 
            If idEdit = True Then
                Try
                    Deleteperfil(id_Perfil)
                    If gridRequisitos.Rows.Count > 1 Then
                        For i = 1 To gridRequisitos.Rows.Count - 1
                            Dim id_requisito As String
                            Dim Requisiro As String

                            If gridRequisitos(i, 2) = False Then
                            Else
                                id_requisito = gridRequisitos(i, 1)
                                Requisiro = gridRequisitos(i, 3)
                                Addperfil(id_Perfil, id_requisito, Requisiro)
                            End If
                        Next i
                        EDITAR_PERFIL(id_Perfil, txtNome.Text)
                        MsgBox("Edição realizada com sucesso!")
                        txtNome.Text = ""
                        Me.Close()
                    End If
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar o registro da conta a pagar, tente novamente.")
                End Try


            Else ' Novo

                'Verificar se Perfil já Eiste 
                Dim Nome As String = ""
                Dim dr1 As SqlDataReader
                dr1 = Manager.Util.getDataReader("SELECT * FROM FORNECEDORES_AVALIACAO_PERFIL_ID where NOME_PERFIL ='" & txtNome.Text & "'")
                If dr1.Read = True Then
                    MsgBox("Esse Perfil Já Existe!  Tente Outro Nome.")
                    txtNome.Focus()

                Else
                    'Salva
                    Try
                        AddperfilNome(txtNome.Text)
                        'Pegar ID Do novo Perfil cadastrado para salvar as Perguntas 
                        Dim dr As SqlDataReader
                        dr = Manager.Util.getDataReader("SELECT * FROM FORNECEDORES_AVALIACAO_PERFIL_ID where NOME_PERFIL ='" & txtNome.Text & "'")
                        While dr.Read
                            id_Perfil = dr("ID_PERFIL")
                        End While
                        'Salva Perguntas para Cada Perfil
                        If gridRequisitos.Rows.Count > 1 Then
                            For i = 1 To gridRequisitos.Rows.Count - 1
                                Dim id_requisito As String
                                Dim Requisiro As String
                                If gridRequisitos(i, 2) = False Then
                                Else
                                    id_requisito = gridRequisitos(i, 1)
                                    Requisiro = gridRequisitos(i, 3)
                                    Addperfil(id_Perfil, id_requisito, Requisiro)
                                End If
                            Next i
                            MsgBox("Perfil Cadastrado Com Sucesso")
                            txtNome.Text = ""
                            Me.Close()
                        End If
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
        End Try
    End Sub
#End Region

#Region "Classes "

#Region "ADD_PERFIL"

    Public Function AddperfilNome(ByVal NOME As String, _
                     Optional ByRef ID_PERFIL As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_FORNECEDOR_AVALIACAO_PERFIL_ID"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@NOME_PERFIL", NOME)
            End With

            ID_PERFIL = _Command.ExecuteScalar
            _Connection.Close()


            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function


    Public Function Addperfil(ByVal ID_Perfil As Integer, _
                              ByVal ID_REQUISIRO As Integer, _
                              ByVal DESCRICAO_REQUISITOS As String, _
                     Optional ByRef ID_Completo As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_FORNECEDOR_AVALIACAO_PERFIL"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PERFIL", ID_Perfil)
                .AddWithValue("@ID_REQUISITOS", ID_REQUISIRO)
                .AddWithValue("@DESCRICAO_REQUISITOS", DESCRICAO_REQUISITOS)

            End With

            ID_Perfil = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "Editar Perfil"
    Public Function EDITAR_PERFIL(ByVal ID_PERFIL As Integer, ByVal NOME As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "UPDATE_FORNECEDORES_AVALIACAO_PERFIL"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PERFIL", ID_PERFIL)
                .AddWithValue("@NOME_PERFIL", NOME)

            End With

            ID_PERFIL = _Command.ExecuteScalar
            _Connection.Close()


            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "DELETE_Perfil"

    Public Function Deleteperfil(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_FORNECEDORE_AVALIACAO_PERFIL]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PERFIL", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Deleteperfil_Nome(ByVal ID_PERFIL As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_FORNECEDORES_AVALIACAO_PERFIL]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PERFIL", ID_PERFIL)
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
