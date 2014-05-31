Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.forListaOcorrencias
Public Class forCadOcorrencias

#Region "VARIÁVEIS"

    'Delegate criada para atualizar o grid
    Public Delegate Sub CarregaOcorrencias(info As Integer)
    Public Event OnDataChange As CarregaOcorrencias

    Private isEditOcorrencias As Boolean = False
    Public verif As Boolean = False

    'Variavel global que contera o valor passado 
    Private idFornecedor As String
    Private idOcorrencias As String
    Dim Situação As Integer = 0


    'Pega Id Fornecedor
    Public WriteOnly Property fornecedor() As String
        Set(ByVal value As String)
            Me.idFornecedor = value
        End Set
    End Property

    'Pega Id Ocorrencias
    Public WriteOnly Property Ocorrencias() As String
        Set(ByVal value As String)
            Me.idOcorrencias = value
        End Set
    End Property

#End Region

#Region "POPULA COMBOS"

#Region "RESPONSAVEL"

    Sub CarregaResp()
        comboResponsavel.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboResponsavel.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        comboResponsavel.DisplayMember = "COLABORADOR"
        comboResponsavel.ValueMember = "ID"
        comboResponsavel.Text = ""
    End Sub
    Sub CarregaResp_Coclusao()
        cmb_Responsavel_Coclusao.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        cmb_Responsavel_Coclusao.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        cmb_Responsavel_Coclusao.DisplayMember = "COLABORADOR"
        cmb_Responsavel_Coclusao.ValueMember = "ID"
        cmb_Responsavel_Coclusao.Text = ""
    End Sub
    Sub Carregar_Fornecedor()
        cmb_Fornecedor.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        cmb_Fornecedor.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_FORNECEDORES")
        cmb_Fornecedor.DisplayMember = "FORNECEDOR"
        cmb_Fornecedor.ValueMember = "CODIGO"
        cmb_Fornecedor.Text = ""
    End Sub
#End Region

#End Region

#Region "LOAD"

    Private Sub forCadastroOcorrencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_Fornecedor()
        CarregaResp()
        CarregaResp_Coclusao()
        Trava_Conclusao()
        txt_Ocorrencia.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoOcorrencias()
        'Cadastrar Novo
        isEditOcorrencias = False
        Radio_Cocluido.Enabled = False
        radio_NCocluido.Checked = True
        Me.Show()

    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarOcorrencias(ByVal id As Integer)
        Libera_Coclusao()
        Radio_Cocluido.Enabled = True
        'Editar
        isEditOcorrencias = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Produtos/Serviços pelo Id
        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_FORNECEDORES_OCORRENCIAS WHERE Codigo = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)



            While dr.Read
                Me.cmb_Fornecedor.SelectedValue = dr("ID_FORNECEDOR")
                Me.dt_ocorencia.Value = dr("Data").ToString
                Me.txt_Ocorrencia.Text = dr("Descrição").ToString
                Me.comboResponsavel.SelectedValue = dr("ID_RESponsavel").ToString
                Situação = dr("Situação")
                If Situação = 1 Then
                    Radio_Cocluido.Checked = True
                Else
                    radio_NCocluido.Checked = True
                End If
                If Situação = 1 Then
                    Me.dt_Coclusao.Value = dr("Data_Conclusão").ToString
                    Me.cmb_Responsavel_Coclusao.SelectedValue = dr("ID_RESP_CONCLUIDO").ToString
                    Me.txt_Conclusao.Text = dr("Conclusão").ToString
                Else


                End If
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe

        'Inicio Atualizar/Salvar
        If isEditOcorrencias Then
            'Verificar campos obrigatórios
            VerificarOcorrencias()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar

                    If Radio_Cocluido.Checked = True Then
                        If Radio_Cocluido.Checked = True Then
                            Situação = 1
                        Else
                            Situação = 2
                        End If

                        If Update_data(idOcorrencias, _
                                         cmb_Fornecedor.SelectedValue, _
                                         dt_ocorencia.Value, _
                                         txt_Ocorrencia.Text, _
                                         comboResponsavel.SelectedValue, Situação, txt_Conclusao.Text, dt_Coclusao.Value, cmb_Responsavel_Coclusao.SelectedValue) Then

                            MessageBox.Show("Dados atualizados com sucesso", "Ocorrências", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'forListaOcorrencias.gridOcorrenciasFornecedores()
                            Me.Close()
                        End If

                    Else
                        If Radio_Cocluido.Checked = True Then
                            Situação = 1
                        Else
                            Situação = 2
                        End If
                        If Update_(idOcorrencias, _
                                           cmb_Fornecedor.SelectedValue, _
                                           dt_ocorencia.Value, _
                                           txt_Ocorrencia.Text, _
                                           comboResponsavel.SelectedValue, Situação) Then

                            MessageBox.Show("Dados atualizados com sucesso", "Ocorrências", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'forListaOcorrencias.gridOcorrenciasFornecedores()
                            Me.Close()
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            'Verificar campos obrigatórios
            VerificarOcorrencias()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try

                    'Salvar

                    If Radio_Cocluido.Checked = True Then
                        If Radio_Cocluido.Checked = True Then
                            Situação = 1
                        Else
                            Situação = 2
                        End If
                        If Add(cmb_Fornecedor.SelectedValue, _
                                           dt_ocorencia.Value, _
                                           txt_Ocorrencia.Text, _
                                           comboResponsavel.SelectedValue, Situação, txt_Conclusao.Text, dt_Coclusao.Value, cmb_Responsavel_Coclusao.SelectedValue) Then

                            MessageBox.Show("Novo Ocorrência incluído com sucesso", "Ocorrências", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'forListaOcorrencias.gridOcorrenciasFornecedores()
                            Me.Close()
                        End If

                    Else
                        If Radio_Cocluido.Checked = True Then
                            Situação = 1
                        Else
                            Situação = 2
                        End If
                        If Add_Ocorencia_DATA(cmb_Fornecedor.SelectedValue, _
                                              dt_ocorencia.Value, _
                                              txt_Ocorrencia.Text, _
                                              comboResponsavel.SelectedValue, Situação) Then

                            MessageBox.Show("Novo Ocorrência incluído com sucesso", "Ocorrências", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'forListaOcorrencias.gridOcorrenciasFornecedores()
                            Me.Close()
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub VerificarOcorrencias()
        'Tratamento de erro Data
        If dt_ocorencia.Text = "" Then
            MessageBox.Show("Campo Data Obrigatório", "Fornecedores - Ocorrência", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dt_ocorencia.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Ocorrências
        If txt_Ocorrencia.Text = "" Then
            MessageBox.Show("Campo Ocorrência Obrigatório", "Fornecedores - Ocorrência", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_Ocorrencia.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Responsável
        If comboResponsavel.Text = "" Then
            MessageBox.Show("Campo Responsável Obrigatório", "Fornecedores - Ocorrência", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResponsavel.Focus()
            verif = True
            Exit Sub
        End If
        verif = False
    End Sub

#End Region


    Sub Libera_Coclusao()
        txt_Conclusao.Enabled = True
        dt_Coclusao.Enabled = True
        cmb_Responsavel_Coclusao.Enabled = True
    End Sub
    Sub Trava_Conclusao()
        txt_Conclusao.Enabled = False
        dt_Coclusao.Enabled = False
        cmb_Responsavel_Coclusao.Enabled = False
    End Sub



    Private Sub Radio_Cocluido_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Radio_Cocluido.CheckedChanged
        Libera_Coclusao()
    End Sub

    Private Sub radio_NCocluido_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radio_NCocluido.CheckedChanged
        Trava_Conclusao()
    End Sub


#Region "Funcoes "
    'Funçoes 

    Public Function Add(ByVal ID_FORNECEDOR As Integer, _
                          ByVal DATA As Date, _
                          ByVal DESCRICAO As String, _
                          ByVal ID_COLABORADORES As Integer, _
                          ByVal SITUACAO As Integer, _
                          ByVal CONCLUSAO As String, _
                          ByVal DATA_CONCLUSAO As Date, _
                          ByVal ID_COLABORADORES_CONCLUSAO As Integer, _
                         Optional ByRef idOcorrencias As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_FORNECEDORES_OCORRENCIAS_DATA"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDOR", ID_FORNECEDOR)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@SITUACAO ", SITUACAO)
                .AddWithValue("@CONCLUSAO  ", CONCLUSAO)
                .AddWithValue("@DATA_CONCLUSAO", DATA_CONCLUSAO)
                .AddWithValue("@ID_COLABORADORES_CONCLUSAO", ID_COLABORADORES_CONCLUSAO)
            End With

            idOcorrencias = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Add_Ocorencia_DATA(ByVal ID_FORNECEDOR As Integer, _
                          ByVal DATA As Date, _
                          ByVal DESCRICAO As String, _
                          ByVal ID_COLABORADORES As Integer, _
                          ByVal SITUACAO As Integer, _
                         Optional ByRef idOcorrencias As Integer = 0) As Boolean


        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_FORNECEDORES_OCORRENCIAS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDOR", ID_FORNECEDOR)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@SITUACAO ", SITUACAO)


            End With

            idOcorrencias = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update_(ByVal idOcorrencias As Integer, _
                           ByVal ID_FORNECEDOR As Integer, _
                           ByVal DATA As Date, _
                           ByVal DESCRICAO As String, _
                           ByVal ID_COLABORADORES As Integer, _
                           ByVal SITUACAO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_FORNECEDORES_OCORRENCIAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDORES_OCORRENCIAS", idOcorrencias)
                .AddWithValue("@ID_FORNECEDOR", ID_FORNECEDOR)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@SITUACAO ", SITUACAO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Update_data(ByVal idOcorrencias As Integer, _
                           ByVal ID_FORNECEDOR As Integer, _
                           ByVal DATA As Date, _
                           ByVal DESCRICAO As String, _
                           ByVal ID_COLABORADORES As Integer, _
                           ByVal SITUACAO As Integer, _
                           ByVal CONCLUSAO As String, _
                           ByVal DATA_CONCLUSAO As Date, _
                           ByVal ID_COLABORADORES_CONCLUSAO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_FORNECEDORES_OCORRENCIAS_DATA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDORES_OCORRENCIAS", idOcorrencias)
                .AddWithValue("@ID_FORNECEDOR", ID_FORNECEDOR)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@DESCRICAO", DESCRICAO)
                .AddWithValue("@ID_COLABORADORES", ID_COLABORADORES)
                .AddWithValue("@SITUACAO ", SITUACAO)
                .AddWithValue("@CONCLUSAO  ", CONCLUSAO)
                .AddWithValue("@DATA_CONCLUSAO", DATA_CONCLUSAO)
                .AddWithValue("@ID_COLABORADORES_CONCLUSAO", ID_COLABORADORES_CONCLUSAO)
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
