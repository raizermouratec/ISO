Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports ISOEFACIL.avaliacao
Public Class forCadAvaliacao

#Region "VARIÁVEIS"

    Public isEditAvalicoes As Boolean = False
    'Variavel global que contera o valor passado 
    Public idAvaliacoes As Integer = 0
    Dim id_Perfil As Integer = 0
    Public id_Avaliacao As Integer = 0
    Dim id_Pergunta As Integer = 0
    Dim Tipo As Integer = 0
    Dim ispontuacao As Boolean = False
    Dim isNotas As Boolean = False
    Dim id_pergunta_pontuacao As Integer = 0
    Dim resposta As Boolean = False
    Dim id_fornecedor As Integer = 0
    Dim resultado As Integer = 0

    Public WriteOnly Property ID As Integer
        Set(ByVal value As Integer)
            id_Avaliacao = value
        End Set
    End Property

#End Region

#Region "POPULA COMBOS"

#Region "TIPO - Fornecedor"

    Sub CarregaCombo()

        With comboTipo
            .DataSource = Manager.Util.getDataTable("SELECT * FROM FORNECEDORES_TIPO_AVALIACAO")
            .DisplayMember = "NOME"
            .ValueMember = "ID"
            .Text = ""
        End With

    End Sub

    Sub CarregaCombo_For()
        With cmb_Fornecedo
            .DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_FORNECEDORES")
            .DisplayMember = "FORNECEDOR"
            .ValueMember = "CODIGO"
        End With
    End Sub

    Sub Carregar_Colaborador()
        With Cmb_Avaliador
            .DataSource = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
            .DisplayMember = "COLABORADOR"
            .ValueMember = "ID"
            .Text = ""
        End With
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub forCadAvaliacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Carregar_Colaborador()

        If isEditAvalicoes = True Then
            Aba_Cadastro.Enabled = False
            'CARREGAR PERGUNTAS
            carregar_grid()
            '##################################################################################################################
            Dim dr As SqlDataReader
            dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACOES_CADASTRO WHERE ID_AVALIACAO =" & id_Avaliacao)
            dr.Read()
            Tipo = dr("TIPO").ToString
            id_fornecedor = dr("ID_FORNECEDOR").ToString
            dr.Close()
            '##################################################################################################################
            dr = Manager.Util.getDataReader("SELECT * FROM VW_LISTAGEM_FORNECEDORES WHERE CODIGO =" & id_fornecedor)
            dr.Read()
            Dim fornecedor As String = dr("FORNECEDOR").ToString
            group_requisitos.Text = "Requisito para Avaliar " & fornecedor
            dr.Close()
            carregar_resposta()
            dr = Manager.Util.getDataReader("SELECT * FROM FORNECEDORES_AVALIACOES_CONCLUIDAS WHERE ID_AVALIACOES =" & id_Avaliacao)
            dr.Read()
            If dr.Read = False Then
            Else
                Cmb_Avaliador.SelectedValue = dr("ID_COLABORADOR").ToString
            End If
            dr.Close()

        Else
            'NOME DO FORNECEDOR
            Aba_Avaliação.Enabled = False
            doc_All.SelectedTab = Aba_Cadastro
            'CARREGA COMBO
            cmb_Fornecedo.ValueMember = ""
            comboTipo.ValueMember = ""
            CarregaCombo_For()
            CarregaCombo()
            Check_Nenhum.Checked = True
            'CARREGA LISTA
            cCarregar_Grid_Perfil()
            dtAvaliacao.Value = Date.Now
        End If

    End Sub

    Private Sub forCadAvaliacao_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.ResizeEnd

        Me.Close()

    End Sub

#End Region

#Region "ATUALIZA CHECK"

    Private Sub gridRequisito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridRequisito.Click

        With gridRequisito
            If .ColSel = 2 Then
                Dim Check As New requisitos
                Dim id As Integer
                Dim Aprovado As Boolean
                Try
                    If .Item(.RowSel, .ColSel) = True Then
                        Aprovado = False
                        .Item(.RowSel, .ColSel) = False
                    Else
                        Aprovado = True
                        .Item(.RowSel, .ColSel) = True
                    End If
                    id = .Item(.RowSel, 0)
                    Check.UpdateMultiplo(id, Aprovado)
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
        End With
    End Sub

#End Region

#Region "SELEÇÃO DE TIPOS"
    Sub CarregarNotas()
        AbaNotas.Location = New Point(0, -1)
        AbaNotas.Visible = True
        AbaNotas.Width = 696
        AbaNotas.Height = 195
        txt_Coment_Notas.Visible = True
        txt_Coment_Notas.Location = New Point(115, 100)
        txt_Coment_Notas.Width = 569
        txt_Coment_Notas.Height = 60

    End Sub
    Sub CarregarAtende()
        AbaAtende.Location = New Point(0, -1)
        AbaAtende.Visible = True
        AbaAtende.Width = 696
        AbaAtende.Height = 195
        txt_Coment_Notas.Visible = True
        txt_Coment_Notas.Location = New Point(115, 90)
        txt_Coment_Notas.Width = 569
        txt_Coment_Notas.Height = 60

    End Sub
    Sub CarregarNivel()
        AbaNivel.Location = New Point(0, -1)
        AbaNivel.Visible = True
        AbaNivel.Width = 696
        AbaNivel.Height = 195
        txt_Coment_Notas.Visible = True
        txt_Coment_Notas.Location = New Point(115, 90)
        txt_Coment_Notas.Width = 569
        txt_Coment_Notas.Height = 60

    End Sub
    Sub CarregarPontuação()
        AbaPontuacao.Location = New Point(0, -1)
        AbaPontuacao.Visible = True
        AbaPontuacao.Width = 696
        AbaPontuacao.Height = 195
        txt_Coment_Notas.Visible = True
        txt_Coment_Notas.Location = New Point(115, 100)
        txt_Coment_Notas.Width = 569
        txt_Coment_Notas.Height = 60
    End Sub

#End Region

#Region "INICIAR AVALIACAO"

    Private Sub btAvaliacao_Click(sender As System.Object, e As System.EventArgs) Handles btAvaliacao.Click

        Dim teste As Integer
        id_fornecedor = cmb_Fornecedo.SelectedValue
        'Cadastra Avaliacao Quando não tem nenhum perfil selecionado 
        If gridRequisito.Rows.Count > 1 Then

            For i = 1 To gridRequisito.Rows.Count - 1
                If teste = 1 Then

                Else
                    If gridRequisito(i, 2) = False Then
                        teste = 0
                    Else
                        teste = 1
                    End If
                End If
            Next i
        End If
        If teste = 0 Then

            MsgBox("Não a Nenhum requisito selesionado.")
        Else


            If ispontuacao = True Then
                carregar_Pontuação()
                input_op.Enabled = False
                input_voltar.Visible = True
                carregar_grid_pontuação()

            Else
                '#### Cadastrar 
                If comboTipo.SelectedValue = 3 Then

                    If Check_Nenhum.Checked = True Then 'Cadastra Avaliacao Quando não tem nenhum perfil selecionado 
                        Try
                            'Cadastra uma nova Avaliacao e pega i ID_avaliacao
                            id_Avaliacao = Add_avaliacao(cmb_Fornecedo.SelectedValue, comboTipo.SelectedValue, Date.Now, 0, 0, "", "Em avaliação")
                            'Cadastra perguntas para a nova avaliacao
                            If fg_pontos.Rows.Count > 1 Then
                                For i = 1 To fg_pontos.Rows.Count - 1
                                    Dim id_requisito As Integer = 0
                                    Dim Requisiro As String = ""
                                    Dim Peso As Integer = 0
                                    If fg_pontos(i, 2) = False Then
                                    Else
                                        id_requisito = fg_pontos(i, 1)
                                        Requisiro = fg_pontos(i, 3)
                                        Peso = fg_pontos(i, 4)
                                        Add_avaliacao_Perguntas(id_Avaliacao, id_requisito, Requisiro, Peso)
                                    End If
                                Next i
                                MsgBox("Perfil Avaliacao Iniciada Com Sucesso")
                                If comboTipo.SelectedValue = 1 Then
                                    Tipo = 1
                                ElseIf comboTipo.SelectedValue = 2 Then
                                    Tipo = 2
                                ElseIf comboTipo.SelectedValue = 3 Then
                                    Tipo = 3
                                ElseIf comboTipo.SelectedValue = 4 Then
                                    Tipo = 4
                                Else
                                    MsgBox("Selecione um Tipo de Avaliação")
                                End If
                                '################################################################################################################
                                carregar_grid()
                                carregar_For()
                                Carregar_Colaborador()
                                Aba_Cadastro.Enabled = False
                                Aba_Avaliação.Enabled = True
                                doc_All.SelectedTab = Aba_Avaliação
                            End If
                        Catch ex As Exception
                            MsgBox("Não Foi possivel Realizar a Avaliação.")
                        End Try
                    Else 'Cadastra Avaliacao Quando tem um perfil selecionado 
                        Try
                            id_Avaliacao = Add_avaliacao(cmb_Fornecedo.SelectedValue, comboTipo.SelectedValue, Date.Now, 1, cmb_Perfil.SelectedValue, "", "Em avaliação")
                            'Cadastra perguntas  para a nova avaliacao
                            If fg_pontos.Rows.Count > 1 Then
                                For i = 1 To fg_pontos.Rows.Count - 1
                                    Dim id_requisito As Integer = 0
                                    Dim Requisiro As String = ""
                                    Dim Peso As Integer = 0
                                    If fg_pontos(i, 2) = False Then
                                    Else
                                        id_requisito = fg_pontos(i, 1)
                                        Requisiro = fg_pontos(i, 3)
                                        Peso = fg_pontos(i, 4)
                                        Add_avaliacao_Perguntas(id_Avaliacao, id_requisito, Requisiro, Peso)
                                    End If
                                Next i
                                '################################################################################################################
                                MsgBox("Avaliacao Iniciada Com Sucesso")
                                If comboTipo.SelectedValue = 1 Then
                                    Tipo = 1
                                ElseIf comboTipo.SelectedValue = 2 Then
                                    Tipo = 2
                                ElseIf comboTipo.SelectedValue = 3 Then
                                    Tipo = 3
                                ElseIf comboTipo.SelectedValue = 4 Then
                                    Tipo = 4
                                End If
                                '################################################################################################################
                                carregar_grid()
                                carregar_For()
                                Carregar_Colaborador()
                                Aba_Cadastro.Enabled = False
                                Aba_Avaliação.Enabled = True
                                doc_All.SelectedTab = Aba_Avaliação
                            End If
                        Catch ex As Exception
                            MsgBox("Não Foi possivel Realizar a Avaliação.")
                        End Try
                    End If

                ElseIf comboTipo.SelectedValue = 2 Then

                    If Check_Nenhum.Checked = True Then 'Cadastra Avaliacao Quando não tem nenhum perfil selecionado 
                        Try
                            'Cadastra uma nova Avaliacao e pega i ID_avaliacao
                            If txt_Notamaxima.Value < 1 Then
                                MsgBox("Nota Maxima não pode ser abaixo de 1")
                            ElseIf txt_Notamaxima.Value <= txt_NotaMinima.Value Then
                                MsgBox("Nota minima não pode ser Maior que a Nota maxima")
                            ElseIf txt_Media.Value < 1 Then
                                MsgBox("A média não pode ser abaixo de 1")
                            ElseIf txt_Media.Value <= txt_NotaMinima.Value Then
                                MsgBox("A média não pode ser menor que a nota minima")
                            ElseIf txt_Media.Value >= txt_Notamaxima.Value Then
                                MsgBox("A média não pode ser Maior que a nota maxima")
                            Else
                                id_Avaliacao = Add_avaliacao(cmb_Fornecedo.SelectedValue, comboTipo.SelectedValue, Date.Now, 0, 0, "", "Em avaliação")
                                Add_Avaliação_Notas(id_Avaliacao, txt_NotaMinima.Value, txt_Notamaxima.Value, txt_Media.Value)

                                'Cadastra perguntas para a nova avaliacao
                                If gridRequisito.Rows.Count > 1 Then
                                    For i = 1 To gridRequisito.Rows.Count - 1
                                        Dim id_requisito As Integer = 0
                                        Dim Requisiro As String = ""
                                        Dim Peso As Integer = 0
                                        If gridRequisito(i, 2) = False Then
                                        Else
                                            id_requisito = gridRequisito(i, 1)
                                            Requisiro = gridRequisito(i, 3)
                                            Peso = gridRequisito(i, 4)
                                            Add_avaliacao_Perguntas(id_Avaliacao, id_requisito, Requisiro, Peso)
                                        End If
                                    Next i
                                    MsgBox("Perfil Avaliacao Iniciada Com Sucesso")
                                    If comboTipo.SelectedValue = 1 Then
                                        Tipo = 1
                                    ElseIf comboTipo.SelectedValue = 2 Then
                                        Tipo = 2
                                    ElseIf comboTipo.SelectedValue = 3 Then
                                        Tipo = 3
                                    ElseIf comboTipo.SelectedValue = 4 Then
                                        Tipo = 4
                                    Else
                                        MsgBox("Selecione um Tipo de Avaliação")
                                    End If
                                    '################################################################################################################
                                    carregar_grid()
                                    carregar_For()
                                    Carregar_Colaborador()
                                    Aba_Cadastro.Enabled = False
                                    Aba_Avaliação.Enabled = True
                                    doc_All.SelectedTab = Aba_Avaliação
                                End If
                            End If
                        Catch ex As Exception
                            MsgBox("Não Foi possivel Realizar a Avaliação.")
                        End Try
                    Else 'Cadastra Avaliacao Quando tem um perfil selecionado 
                        Try
                            If txt_Notamaxima.Value < 1 Then
                                MsgBox("Nota Maxima não pode ser abaixo de 1")
                            ElseIf txt_Notamaxima.Value <= txt_NotaMinima.Value Then
                                MsgBox("Nota minima não pode ser Maior que a Nota maxima")
                            ElseIf txt_Media.Value < 1 Then
                                MsgBox("A média não pode ser abaixo de 1")
                            ElseIf txt_Media.Value <= txt_NotaMinima.Value Then
                                MsgBox("A média não pode ser menor que a nota minima")
                            ElseIf txt_Media.Value >= txt_Notamaxima.Value Then
                                MsgBox("A média não pode ser Maior que a nota maxima")
                            Else
                                id_Avaliacao = Add_avaliacao(cmb_Fornecedo.SelectedValue, comboTipo.SelectedValue, Date.Now, 1, cmb_Perfil.SelectedValue, "", "Em avaliação")
                                Add_Avaliação_Notas(id_Avaliacao, txt_NotaMinima.Value, txt_Notamaxima.Value, txt_Media.Value)

                                'Cadastra perguntas  para a nova avaliacao
                                If gridRequisito.Rows.Count > 1 Then
                                    For i = 1 To gridRequisito.Rows.Count - 1
                                        Dim id_requisito As Integer = 0
                                        Dim Requisiro As String = ""
                                        Dim Peso As Integer = 0
                                        If gridRequisito(i, 2) = False Then
                                        Else
                                            id_requisito = gridRequisito(i, 1)
                                            Requisiro = gridRequisito(i, 3)
                                            Peso = gridRequisito(i, 4)
                                            Add_avaliacao_Perguntas(id_Avaliacao, id_requisito, Requisiro, Peso)
                                        End If
                                    Next i
                                    '################################################################################################################
                                    MsgBox("Perfil Avaliacao Iniciada Com Sucesso")
                                    If comboTipo.SelectedValue = 1 Then
                                        Tipo = 1
                                    ElseIf comboTipo.SelectedValue = 2 Then
                                        Tipo = 2
                                    ElseIf comboTipo.SelectedValue = 3 Then
                                        Tipo = 3
                                    ElseIf comboTipo.SelectedValue = 4 Then
                                        Tipo = 4
                                    End If
                                    '################################################################################################################
                                    carregar_grid()
                                    carregar_For()
                                    Carregar_Colaborador()
                                    Aba_Cadastro.Enabled = False
                                    Aba_Avaliação.Enabled = True
                                    doc_All.SelectedTab = Aba_Avaliação
                                End If
                            End If

                        Catch ex As Exception
                            MsgBox("Não Foi possivel Realizar a Avaliação.")
                        End Try
                    End If

                Else

                    If Check_Nenhum.Checked = True Then 'Cadastra Avaliacao Quando não tem nenhum perfil selecionado 
                        Try
                            'Cadastra uma nova Avaliacao e pega i ID_avaliacao

                            id_Avaliacao = Add_avaliacao(cmb_Fornecedo.SelectedValue, comboTipo.SelectedValue, Date.Now, 0, 0, "", "Em avaliação")
                            Add_Avaliação_Notas(id_Avaliacao, txt_NotaMinima.Value, txt_Notamaxima.Value, txt_Media.Value)


                            'Cadastra perguntas para a nova avaliacao
                            If gridRequisito.Rows.Count > 1 Then
                                For i = 1 To gridRequisito.Rows.Count - 1
                                    Dim id_requisito As Integer = 0
                                    Dim Requisiro As String = ""
                                    Dim Peso As Integer = 0
                                    If gridRequisito(i, 2) = False Then
                                    Else
                                        id_requisito = gridRequisito(i, 1)
                                        Requisiro = gridRequisito(i, 3)
                                        Peso = gridRequisito(i, 4)
                                        Add_avaliacao_Perguntas(id_Avaliacao, id_requisito, Requisiro, Peso)
                                    End If
                                Next i
                                MsgBox("Perfil Avaliacao Iniciada Com Sucesso")
                                If comboTipo.SelectedValue = 1 Then
                                    Tipo = 1
                                ElseIf comboTipo.SelectedValue = 2 Then
                                    Tipo = 2
                                ElseIf comboTipo.SelectedValue = 3 Then
                                    Tipo = 3
                                ElseIf comboTipo.SelectedValue = 4 Then
                                    Tipo = 4
                                Else
                                    MsgBox("Selecione um Tipo de Avaliação")
                                End If
                                '################################################################################################################
                                carregar_grid()
                                carregar_For()
                                Carregar_Colaborador()
                                Aba_Cadastro.Enabled = False
                                Aba_Avaliação.Enabled = True
                                doc_All.SelectedTab = Aba_Avaliação
                            End If
                        Catch ex As Exception
                            MsgBox("Não Foi possivel Realizar a Avaliação.")
                        End Try
                    Else 'Cadastra Avaliacao Quando tem um perfil selecionado 
                        Try

                            id_Avaliacao = Add_avaliacao(cmb_Fornecedo.SelectedValue, comboTipo.SelectedValue, Date.Now, 1, cmb_Perfil.SelectedValue, "", "Em avaliação")


                            'Cadastra perguntas  para a nova avaliacao
                            If gridRequisito.Rows.Count > 1 Then
                                For i = 1 To gridRequisito.Rows.Count - 1
                                    Dim id_requisito As Integer = 0
                                    Dim Requisiro As String = ""
                                    Dim Peso As Integer = 0
                                    If gridRequisito(i, 2) = False Then
                                    Else
                                        id_requisito = gridRequisito(i, 1)
                                        Requisiro = gridRequisito(i, 3)
                                        Peso = gridRequisito(i, 4)
                                        Add_avaliacao_Perguntas(id_Avaliacao, id_requisito, Requisiro, Peso)
                                    End If
                                Next i
                                '################################################################################################################
                                MsgBox("Perfil Avaliacao Iniciada Com Sucesso")
                                If comboTipo.SelectedValue = 1 Then
                                    Tipo = 1
                                ElseIf comboTipo.SelectedValue = 2 Then
                                    Tipo = 2
                                ElseIf comboTipo.SelectedValue = 3 Then
                                    Tipo = 3
                                ElseIf comboTipo.SelectedValue = 4 Then
                                    Tipo = 4
                                End If
                                '################################################################################################################
                                carregar_grid()
                                carregar_For()
                                Carregar_Colaborador()
                                Aba_Cadastro.Enabled = False
                                Aba_Avaliação.Enabled = True
                                doc_All.SelectedTab = Aba_Avaliação
                            End If
                        Catch ex As Exception
                            MsgBox("Não Foi possivel Realizar a Avaliação.")
                        End Try
                    End If
                End If
            End If

        End If

    End Sub

#End Region

#Region "cARREGAR fORNECEDOR QUE ESTA SENDO AVALIADO"

    Sub carregar_For()
        Dim dr As SqlDataReader
        dr = Manager.Util.getDataReader("SELECT * FROM VW_LISTAGEM_FORNECEDORES WHERE CODIGO =" & cmb_Fornecedo.SelectedValue)
        dr.Read()
        Dim fornecedor As String = dr("FORNECEDOR").ToString
        group_requisitos.Text = "Requisito para Avaliar " & fornecedor
    End Sub

#End Region

#Region "TIPO DE AVALIACAO- COM PERFIL/SEM PERFIL"

    Private Sub Check_Perfil_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Check_Perfil.CheckedChanged
        If Check_Perfil.Checked = True Then
            Dim dr As SqlDataReader
            dr = Manager.Util.getDataReader("SELECT * FROM FORNECEDORES_AVALIACAO_PERFIL_ID")
            If dr.Read = False Then
                MsgBox("Não existe perfil, Cadastre um perfil")
                Check_Perfil.Checked = False
                Check_Nenhum.Checked = True
            Else
                Check_Nenhum.Checked = False
                cmb_Perfil.Enabled = True
                bot_Add_Perfil.Enabled = True
                Carregar_Perfil()
            End If
            dr.Close()
        End If
    End Sub

    Private Sub Check_Nenhum_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Check_Nenhum.CheckedChanged
        If Check_Nenhum.Checked = True Then
            Check_Perfil.Checked = False
            cmb_Perfil.Text = ""
            cmb_Perfil.Text = ""
            cmb_Perfil.Enabled = False
            bot_Add_Perfil.Enabled = False
            cCarregar_Grid_Perfil()
        End If
    End Sub

    Sub Carregar_Perfil()
        With cmb_Perfil
            .AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
            .DataSource = Manager.Util.getDataTable("SELECT * FROM FORNECEDORES_AVALIACAO_PERFIL_ID")
            .DisplayMember = "NOME_PERFIL"
            .ValueMember = "ID_PERFIL"
            .Text = ""
        End With
    End Sub

#End Region

#Region "CARREGANDO PERFIL"

    Private Sub cmb_Perfil_ChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmb_Perfil.Validated

        If cmb_Perfil.SelectedValue.ToString = String.Empty Then
            MsgBox("Não existe perfil, Cadastre um perfil")
            Exit Sub
        Else
            id_Perfil = cmb_Perfil.SelectedValue
            cCarregar_Grid_Perfil()
        End If

    End Sub

#End Region

#Region "ESCOLHENDO O TIPO DE AVALIACAO"

    Private Sub cmb_TIPO_ChangeCommitted(sender As System.Object, e As System.EventArgs) Handles comboTipo.Validated

        If comboTipo.Text = "Notas" Then
            input_Notas.Enabled = True
            input_Notas.Visible = True
            ispontuacao = False
            isNotas = True
            cCarregar_Grid_Perfil()
        ElseIf comboTipo.Text = "Pontuação" Then
            input_Notas.Enabled = False
            input_Notas.Visible = False
            ispontuacao = True
            isNotas = False
            cCarregar_Grid_Perfil()
        Else
            input_Notas.Enabled = False
            input_Notas.Visible = False
            ispontuacao = False
            isNotas = False
            cCarregar_Grid_Perfil()
        End If

    End Sub

#End Region

#Region "CARREGANDO TABELA DE SELEÇÃO DE REQUISITOS"

    Sub cCarregar_Grid_Perfil()
        If Check_Perfil.Checked = True Then
            Dim dr As SqlDataReader
            Dim id_Requisito As Integer
            Dim dr1 As SqlDataReader

            If comboTipo.Text = "Pontuação" Then
                dr = Manager.Util.getDataReader("SELECT * FROM VW_LISTAGEM_FORNECEDORES_REQUISITOS")
                gridRequisito.Rows.Count = 1
                While dr.Read
                    id_Requisito = dr("CODIGO")
                    dr1 = Manager.Util.getDataReader("SELECT * FROM FORNECEDORES_AVALIACAO_PERFIL where ID_PERFIL = " & id_Perfil & " and ID_REQUISITOS =" & id_Requisito)
                    If dr1.Read = True Then
                        gridRequisito.Rows.Add()
                        gridRequisito(gridRequisito.Rows.Count - 1, 1) = dr("CODIGO")
                        gridRequisito(gridRequisito.Rows.Count - 1, 2) = True
                        gridRequisito(gridRequisito.Rows.Count - 1, 3) = dr("DESCRICAO")
                        gridRequisito.Cols(3).Width = 533
                        gridRequisito(gridRequisito.Rows.Count - 1, 4) = dr("PESO")
                        gridRequisito.Cols(4).Width = 70
                    End If
                End While
            Else
                dr = Manager.Util.getDataReader("SELECT * FROM VW_LISTAGEM_FORNECEDORES_REQUISITOS")
                gridRequisito.Rows.Count = 1
                While dr.Read
                    id_Requisito = dr("CODIGO")
                    dr1 = Manager.Util.getDataReader("SELECT * FROM FORNECEDORES_AVALIACAO_PERFIL where ID_PERFIL = " & id_Perfil & " and ID_REQUISITOS =" & id_Requisito)
                    If dr1.Read = True Then
                        gridRequisito.Rows.Add()
                        gridRequisito(gridRequisito.Rows.Count - 1, 1) = dr("CODIGO")
                        gridRequisito(gridRequisito.Rows.Count - 1, 2) = True
                        gridRequisito.Cols(3).Width = 604
                        gridRequisito(gridRequisito.Rows.Count - 1, 3) = dr("DESCRICAO")
                        gridRequisito(gridRequisito.Rows.Count - 1, 4) = dr("PESO")
                        gridRequisito.Cols(4).Width = 0
                    End If
                End While
            End If
        Else
            If comboTipo.Text = "Pontuação" Then
                Dim dr As SqlDataReader
                dr = Manager.Util.getDataReader("SELECT * FROM VW_LISTAGEM_FORNECEDORES_REQUISITOS")
                gridRequisito.Rows.Count = 1
                While dr.Read
                    gridRequisito.Rows.Add()
                    gridRequisito(gridRequisito.Rows.Count - 1, 1) = dr("CODIGO")
                    gridRequisito(gridRequisito.Rows.Count - 1, 2) = False
                    gridRequisito(gridRequisito.Rows.Count - 1, 3) = dr("DESCRICAO")
                    gridRequisito.Cols(3).Width = 533
                    gridRequisito(gridRequisito.Rows.Count - 1, 4) = dr("PESO")
                    gridRequisito.Cols(4).Width = 70
                End While
            Else
                Dim dr As SqlDataReader
                dr = Manager.Util.getDataReader("SELECT * FROM VW_LISTAGEM_FORNECEDORES_REQUISITOS")
                gridRequisito.Rows.Count = 1
                While dr.Read
                    gridRequisito.Rows.Add()
                    gridRequisito(gridRequisito.Rows.Count - 1, 1) = dr("CODIGO")
                    gridRequisito(gridRequisito.Rows.Count - 1, 2) = False
                    gridRequisito.Cols(3).Width = 604
                    gridRequisito(gridRequisito.Rows.Count - 1, 3) = dr("DESCRICAO")
                    gridRequisito(gridRequisito.Rows.Count - 1, 4) = dr("PESO")
                    gridRequisito.Cols(4).Width = 0
                End While
            End If
        End If
    End Sub

#End Region

#Region "SELEÇÃO DE PERGUNTA PARA SER RESPONDIDA"

    Private Sub gridSelecionados_Click(sender As System.Object, e As System.EventArgs) Handles gridSelecionados.DoubleClick
        If id_Pergunta > 0 Then
            MsgBox("Já Tem uma perguna para ser respondida.")
        Else
            Dim dr As SqlDataReader
            dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACOES_CADASTRO WHERE ID_AVALIACAO =" & id_Avaliacao)
            dr.Read()
            Tipo = dr("TIPO").ToString
            dr.Close()
            id_Pergunta = gridSelecionados(gridSelecionados.RowSel, 0)
            dr = Manager.Util.getDataReader("SELECT * FROM FORNECEDORES_AVALIACAO_PERGUNTAS WHERE ID_PERGUNTAS =" & id_Pergunta)
            dr.Read()
            If Tipo = 1 Then 'Textual
                CarregarAtende()
                txtDescricao.Text = dr("DESCRICAO_REQUISITOS").ToString
                txt_Coment_Notas.Text = dr("OBSERVACOES").ToString
                AbaAtende.Enabled = True
                txt_Coment_Notas.Enabled = True
            ElseIf Tipo = 2 Then ' Notas
                CarregarNotas()
                Dim dr1 As SqlDataReader
                dr1 = Manager.Util.getDataReader("SELECT * FROM FORNECEDORES_AVALIACAO_NOTA WHERE ID_AVALIACAO =" & id_Avaliacao)
                dr1.Read()
                txtDescricaoN.Text = dr("DESCRICAO_REQUISITOS").ToString
                txt_Coment_Notas.Text = dr("OBSERVACOES").ToString
                txtNotaMedia.Text = dr1("NOTA_MEDIA").ToString
                txt_Nota_Maxima.Text = dr1("NOTA_MAXIMA").ToString
                imgResult.Image = Icones.Images.Item(3)
                AbaNotas.Enabled = True
                txt_Coment_Notas.Enabled = True
            ElseIf Tipo = 3 Then ' Pontuacao
                CarregarPontuação()
                txt_Descicao_Nota.Text = dr("DESCRICAO_REQUISITOS").ToString
                txt_Coment_Notas.Text = dr("OBSERVACOES").ToString
                txt_media_Pnt.Text = dr("peso").ToString
                If dr("RESULTADO_PONTUACAO").ToString = "" Then
                    txtPontuacaoP.Value = 0
                Else
                    txtPontuacaoP.Value = dr("RESULTADO_PONTUACAO").ToString
                End If
                AbaPontuacao.Enabled = True
                txt_Coment_Notas.Enabled = True
            ElseIf Tipo = 4 Then 'Nivel de Pontuacao
                CarregarNivel()
                txtDescricaoA.Text = dr("DESCRICAO_REQUISITOS").ToString
                txt_Coment_Notas.Text = dr("OBSERVACOES").ToString
                AbaNivel.Enabled = True
                txt_Coment_Notas.Enabled = True
            Else
            End If
        End If

    End Sub
#End Region

#Region "CARREGAR TABELA DE PERGUNTAS RESPONDIDAS"

    Sub carregar_grid()
        Dim dr As SqlDataReader
        Dim Tipo As Integer = 0
        Dim i As Integer = 0
        dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACOES_CADASTRO WHERE ID_AVALIACAO =" & id_Avaliacao)
        dr.Read()
        Tipo = dr("TIPO").ToString
        dr.Close()
        dr = Manager.Util.getDataReader("SELECT * FROM FORNECEDORES_AVALIACAO_PERGUNTAS WHERE ID_AVALIACAO =" & id_Avaliacao)
        gridSelecionados.Rows.Count = 1
        If Tipo = 1 Then
            gridSelecionados.Cols(4).Visible = False
            gridSelecionados.Cols(5).Visible = True
        ElseIf Tipo = 2 Then
            gridSelecionados.Cols(5).Visible = False
            gridSelecionados.Cols(4).Visible = True
        ElseIf Tipo = 3 Then
            gridSelecionados.Cols(5).Visible = False
            gridSelecionados.Cols(4).Visible = True
        ElseIf Tipo = 4 Then
            gridSelecionados.Cols(4).Visible = False
            gridSelecionados.Cols(5).Visible = True
        End If
        Try
            While dr.Read
                i = i + 1
                gridSelecionados.Rows.Add()
                gridSelecionados(gridSelecionados.Rows.Count - 1, 0) = dr("ID_PERGUNTAS")
                gridSelecionados(gridSelecionados.Rows.Count - 1, 1) = dr("ID_AVALIACAO")
                gridSelecionados(gridSelecionados.Rows.Count - 1, 2) = dr("ID_REQUISITOS")
                gridSelecionados(gridSelecionados.Rows.Count - 1, 3) = dr("DESCRICAO_REQUISITOS")
                If Tipo = 1 Then
                    gridSelecionados(gridSelecionados.Rows.Count - 1, 5) = dr("RESULTADO_ATENDE")
                    If dr("RESULTADO_ATENDE").ToString = "Atende" Then
                        gridSelecionados.SetCellImage(i, 6, Icones.Images.Item(0))
                    ElseIf dr("RESULTADO_ATENDE").ToString = "Atende Parcialmente" Then
                        gridSelecionados.SetCellImage(i, 6, Icones.Images.Item(2))
                    ElseIf dr("RESULTADO_ATENDE").ToString = "Não Atende" Then
                        gridSelecionados.SetCellImage(i, 6, Icones.Images.Item(1))
                    End If
                ElseIf Tipo = 2 Then
                    Dim dr1 As SqlDataReader
                    Dim Média As Integer = 0
                    dr1 = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_NOTA WHERE ID_AVALIACAO =" & id_Avaliacao)
                    dr1.Read()
                    Média = dr1("NOTA_MEDIA").ToString
                    dr1.Close()
                    gridSelecionados(gridSelecionados.Rows.Count - 1, 4) = dr("RESULTADO_NOTAS")

                    If dr("RESULTADO_NOTAS").ToString = "" Then
                        gridSelecionados.SetCellImage(i, 6, Icones.Images.Item(3))
                    Else
                        If dr("RESULTADO_NOTAS").ToString < Média Then
                            gridSelecionados.SetCellImage(i, 6, Icones.Images.Item(1))
                        ElseIf dr("RESULTADO_NOTAS").ToString >= Média Then
                            gridSelecionados.SetCellImage(i, 6, Icones.Images.Item(0))
                        End If
                    End If

                ElseIf Tipo = 3 Then
                    Dim Resultado As Integer = 0
                    Dim Peso As Integer = 0
                    Dim Resposta As Integer = 0

                    gridSelecionados(gridSelecionados.Rows.Count - 1, 4) = dr("RESULTADO_PONTUACAO")

                    If dr("RESULTADO_PONTUACAO").ToString = "" Then
                        gridSelecionados.SetCellImage(i, 6, Icones.Images.Item(3))
                    Else

                        Peso = dr("PESO")

                        Resultado = dr("RESULTADO_PONTUACAO")

                        Resposta = (Resultado / Peso) * 100

                        If Resposta < 70 Then
                            gridSelecionados.SetCellImage(i, 6, Icones.Images.Item(1))
                        ElseIf Resposta >= 70 Then
                            gridSelecionados.SetCellImage(i, 6, Icones.Images.Item(0))
                        End If
                    End If
                ElseIf Tipo = 4 Then
                    gridSelecionados(gridSelecionados.Rows.Count - 1, 5) = dr("RESULTADO_NIVEL")
                    If dr("RESULTADO_NIVEL").ToString = "Otimo" Then
                        gridSelecionados.SetCellImage(i, 6, Icones.Images.Item(0))
                    ElseIf dr("RESULTADO_NIVEL").ToString = "Bom" Then
                        gridSelecionados.SetCellImage(i, 6, Icones.Images.Item(2))
                    ElseIf dr("RESULTADO_NIVEL").ToString = "Regular" Then
                        gridSelecionados.SetCellImage(i, 6, Icones.Images.Item(3))
                    ElseIf dr("RESULTADO_NIVEL").ToString = "Ruim" Then
                        gridSelecionados.SetCellImage(i, 6, Icones.Images.Item(1))
                    End If
                End If
            End While
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "RESPONDER ATENDE"

    Private Sub bot_Resposta_Atende_Click(sender As System.Object, e As System.EventArgs) Handles bot_Resposta_Atende.Click

        Dim Total_pontos As Integer = 0
        Dim Total_Peso As Integer = 0
        Dim Resposta As Integer = 0
        Dim resposta_ As String = ""
        Try

            If optAtende.Checked = True Then
                Add_Resposta_Atende(id_Pergunta, "Atende", txt_Coment_Notas.Text)
            ElseIf optParcialmente.Checked = True Then
                Add_Resposta_Atende(id_Pergunta, "Atende Parcialmente", txt_Coment_Notas.Text)
            ElseIf optNaoAtende.Checked = True Then
                Add_Resposta_Atende(id_Pergunta, "Não Atende", txt_Coment_Notas.Text)
            End If
            MsgBox("Resquisito Respondido.")
            txtDescricao.Text = ""
            id_Pergunta = 0
            txt_Coment_Notas.Text = ""
            AbaAtende.Enabled = False
            txt_Coment_Notas.Enabled = False
            carregar_grid()
            AbaAtende.Visible = False
            txt_Coment_Notas.Visible = False

            Dim dr As SqlDataReader

            dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_PERGUNTAS  where ID_AVALIACAO =" & id_Avaliacao)
            Dim i As Integer = 0
            While dr.Read()
                If i = 1 Then
                Else
                    If dr("RESULTADO_ATENDE").ToString = "" Then
                        i = 1
                    Else
                        i = 0
                    End If
                End If
            End While

            dr.Close()

            If i = 0 Then
                botSalvarAvalia.Enabled = True
                dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_PERGUNTAS  where ID_AVALIACAO =" & id_Avaliacao)
                Dim Atende As Integer = 0
                Dim A_Parcialmente As Integer = 0
                Dim n_atende As Integer = 0
                While dr.Read

                    If dr("RESULTADO_ATENDE").ToString = "Atende" Then
                        Atende = Atende + 1
                    ElseIf dr("RESULTADO_ATENDE").ToString = "Não Atende" Then
                        n_atende = n_atende + 1
                    ElseIf dr("RESULTADO_ATENDE").ToString = "Atende Parcialmente" Then
                        A_Parcialmente = A_Parcialmente + 1
                    End If

                End While
                If n_atende > 0 Then
                    resposta_ = "Não Qualificado"
                    dt_Pendencia.Enabled = False
                    txt_Pendencia.Enabled = False
                    Radio_Concluido.Enabled = False
                    radio_N_Concluida.Enabled = False
                ElseIf A_Parcialmente > 0 Then
                    resposta_ = "Qualificado com Restrição"
                    dt_Pendencia.Enabled = True
                    txt_Pendencia.Enabled = True
                    Radio_Concluido.Enabled = True
                    radio_N_Concluida.Enabled = True
                Else
                    resposta_ = "Qualificado"
                    dt_Pendencia.Enabled = False
                    txt_Pendencia.Enabled = False
                    Radio_Concluido.Enabled = False
                    radio_N_Concluida.Enabled = False
                End If
                txt_Resultado.Text = "O resultado da avaliação                   ATENDE - " & Atende & "             NÃO ATENDE - " & n_atende & _
                    "                  ATENDE PARCIALMENTE - " & A_Parcialmente & "        - O sistema sugere que este fornecedor seja - " & resposta_
            End If

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "RESPONDER NIVEL"

    Private Sub Bot_Responder_Nivel_Click(sender As System.Object, e As System.EventArgs) Handles Bot_Responder_Nivel.Click

        Dim Resposta As Integer = 0
        Dim resposta_ As String = ""
        Dim numero_perguntas As Integer = 0
        Dim resultado As Integer = 0


        Try
            If checkOtimo.Checked = True Then
                Add_Resposta_Nivel(id_Pergunta, "Otimo", txt_Coment_Notas.Text)
            ElseIf checkBom.Checked = True Then
                Add_Resposta_Nivel(id_Pergunta, "Bom", txt_Coment_Notas.Text)
            ElseIf checkRegular.Checked = True Then
                Add_Resposta_Nivel(id_Pergunta, "Regular", txt_Coment_Notas.Text)
            ElseIf checkRuim.Checked = True Then
                Add_Resposta_Nivel(id_Pergunta, "Ruim", txt_Coment_Notas.Text)
            End If
            MsgBox("Resquisito Respondido.")
            txtDescricaoN.Text = ""
            id_Pergunta = 0
            txt_Coment_Notas.Text = ""
            AbaNivel.Enabled = False
            txt_Coment_Notas.Enabled = False
            carregar_grid()
            AbaNivel.Visible = False
            txt_Coment_Notas.Visible = False


            Dim dr As SqlDataReader

            dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_PERGUNTAS  where ID_AVALIACAO =" & id_Avaliacao)
            Dim i As Integer = 0
            While dr.Read()
                If i = 1 Then
                Else
                    If dr("RESULTADO_NIVEL").ToString = "" Then
                        i = 1
                    Else
                        i = 0
                    End If
                End If
            End While

            dr.Close()

            If i = 0 Then
                botSalvarAvalia.Enabled = True
                dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_PERGUNTAS  where ID_AVALIACAO =" & id_Avaliacao)

                While dr.Read()
                    If dr("RESULTADO_NIVEL").ToString = "Otimo" Then
                        Resposta = Resposta + 3
                    ElseIf dr("RESULTADO_NIVEL").ToString = "Bom" Then
                        Resposta = Resposta + 2
                    ElseIf dr("RESULTADO_NIVEL").ToString = "Regular" Then
                        Resposta = Resposta + 1
                    ElseIf dr("RESULTADO_NIVEL").ToString = "Ruim" Then
                        Resposta = Resposta + 0
                    End If
                    numero_perguntas = numero_perguntas + 3
                End While
                resultado = (Resposta / numero_perguntas) * 100
                If resultado < 70 Then
                    resposta_ = "Não Qualificado"
                    RadioNQualificado.Checked = True
                ElseIf resultado >= 70 Then
                    resposta_ = "Qualificado"
                    RadioQualificado.Checked = True
                End If
                txt_Resultado.Text = "O resultado da avaliação foi de " & resultado & "% - O sistema sugere que este fornecedor seja " & resposta_
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "RESPONDER PONTUACAO"
    Private Sub bot_Responder_Pontuacao_Click(sender As System.Object, e As System.EventArgs) Handles bot_Responder_Pontuacao.Click

        Dim Total_pontos As Integer = 0
        Dim Total_Peso As Integer = 0
        Dim Resposta As Integer = 0
        Dim resposta_ As String = ""
        Try

            Add_Resposta_Pontuacao(id_Pergunta, txtPontuacaoP.Value, txt_Coment_Notas.Text)
            MsgBox("Resquisito Respondido.")


            txt_Descicao_Nota.Text = ""
            id_Pergunta = 0
            txt_Coment_Notas.Text = ""
            AbaPontuacao.Enabled = False
            txt_Coment_Notas.Enabled = False
            carregar_grid()
            AbaPontuacao.Visible = False
            txt_Coment_Notas.Visible = False
            Dim dr As SqlDataReader

            dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_PERGUNTAS  where ID_AVALIACAO =" & id_Avaliacao)
            Dim i As Integer = 0
            While dr.Read()
                If i = 1 Then
                Else
                    If dr("RESULTADO_PONTUACAO").ToString = "" Then
                        i = 1
                    Else
                        Total_Peso = Total_Peso + dr("PESO")
                        Total_pontos = Total_pontos + dr("RESULTADO_PONTUACAO")
                        i = 0
                    End If
                End If
            End While


            If i = 0 Then
                botSalvarAvalia.Enabled = True
                Resposta = (Total_pontos / Total_Peso) * 100

                If Resposta < 70 Then
                    resposta_ = "Não Qualificado"
                    RadioNQualificado.Checked = True
                ElseIf Resposta >= 70 Then
                    resposta_ = "Qualificado"
                    RadioQualificado.Checked = True
                End If

                txt_Resultado.Text = "O resultado da avaliação foi de " & Resposta & "% - O sistema sugere que este fornecedor seja " & resposta_
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "RESULTADO DE PONTUACAO"
    Private Sub txtPontuacaoP_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtPontuacaoP.ValueChanged
        If txtPontuacaoP.Value > txt_media_Pnt.BoundValue Then
            txtPontuacaoP.Value = txt_media_Pnt.BoundValue
        Else
        End If
        Dim resposta As Integer = 0
        resposta = (txtPontuacaoP.Value / txt_media_Pnt.BoundValue) * 100
        txtResultP.Text = (resposta & "%")
        If resposta < 70 Then
            imgResultP.Image = Icones.Images.Item(1)
        ElseIf resposta >= 70 Then
            imgResultP.Image = Icones.Images.Item(0)
        End If
    End Sub

#End Region

#Region "RESULTADO DE Notas"
    Private Sub txtNota_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtNota.ValueChanged
        If txtNota.Value > txt_Nota_Maxima.Value Then
            txtNota.Value = txt_Nota_Maxima.BoundValue
        Else
        End If
        Dim resposta As Double = 0
        If txt_Nota_Maxima.Value <= 0 Then
        Else
            resposta = (txtNota.Value / txt_Nota_Maxima.Value) * 100
            txtResultado.Text = (resposta & "%")
            If resposta < 70 Then
                imgResult.Image = Icones.Images.Item(1)
            ElseIf resposta >= 70 Then
                imgResult.Image = Icones.Images.Item(0)
            End If

        End If
    End Sub
#End Region

#Region "Carregar Inserção de Pontos"

    Sub carregar_Pontuação()
        input_Pontuacao.Location = New Point(0, 0)
        input_Pontuacao.Width = 694
        input_Pontuacao.Height = 536
        fg_pontos.Location = New Point(5, 67)
        fg_pontos.Width = 681
        fg_pontos.Height = 472
        input_Pontuacao.Visible = True
        fg_pontos.Visible = True
        input_voltar.Visible = True

    End Sub

    Sub carregar_Pontuação_Cancelar()
        input_Pontuacao.Location = New Point(0, 0)
        input_Pontuacao.Width = 0
        input_Pontuacao.Height = 0
        fg_pontos.Location = New Point(0, 0)
        fg_pontos.Width = 0
        fg_pontos.Height = 0
        input_Pontuacao.Visible = False
        fg_pontos.Visible = False
        input_voltar.Visible = False

    End Sub

    Sub carregar_grid_pontuação()
        Dim dr As SqlDataReader
        Dim Verific As Integer = 0
        Dim peso As Integer = 0
        Dim id As Integer = 0

        fg_pontos.Rows.Count = 1

        For i = 1 To gridRequisito.Rows.Count - 1
            If gridRequisito(i, 2) = False Then
            Else
                id = gridRequisito(i, 1)
                dr = Manager.Util.getDataReader("SELECT * FROM VW_LISTAGEM_FORNECEDORES_REQUISITOS WHERE CODIGO =" & id)
                dr.Read()
                fg_pontos.Rows.Add()
                fg_pontos(fg_pontos.Rows.Count - 1, 1) = dr("CODIGO")
                fg_pontos(fg_pontos.Rows.Count - 1, 2) = True
                fg_pontos(fg_pontos.Rows.Count - 1, 3) = dr("DESCRICAO")
                fg_pontos(fg_pontos.Rows.Count - 1, 4) = dr("PESO")
                peso = dr("PESO")


                If Verific = 1 Then
                Else
                    If peso = 0 Then
                        Verific = 1
                    Else
                        Verific = 0
                    End If
                End If
            End If

        Next i
        If Verific = 0 Then
            input_op.Enabled = True
            input_voltar.Enabled = True
            ispontuacao = False
        End If

    End Sub

    Private Sub fg_pontos_Click(sender As System.Object, e As System.EventArgs) Handles fg_pontos.DoubleClick
        Dim dr As SqlDataReader
        Dim id As Integer = 0
        id_pergunta_pontuacao = fg_pontos(fg_pontos.RowSel, 1)
        dr = Manager.Util.getDataReader("SELECT * FROM VW_LISTAGEM_FORNECEDORES_REQUISITOS where CODIGO=" & id_pergunta_pontuacao)
        dr.Read()
        id = dr("CODIGO")
        txt_Requisito.Text = dr("DESCRICAO")
        txt_Pontos.Enabled = True
        txt_Pontos.Value = dr("PESO")
        dr.Close()
    End Sub

    Private Sub bot_AddPonto_Click(sender As System.Object, e As System.EventArgs) Handles bot_AddPonto.Click

        Try
            ADD_PESO(id_pergunta_pontuacao, txt_Pontos.Value)
            carregar_grid_pontuação()
            txt_Requisito.Text = ""
            txt_Pontos.Value = 0
            txt_Pontos.Enabled = False
            resposta = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub bot_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles bot_cancelar.Click
        fg_pontos.Rows.Count = 1
        carregar_Pontuação_Cancelar()
        cCarregar_Grid_Perfil()
        input_op.Enabled = True
    End Sub

#End Region

#Region "Concuir Avaliação"

    Private Sub botSalvarAvalia_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarAvalia.Click

        Dim Situacao_Pendencia As Integer
        Dim SITUACAO As String = ""
        Dim Resultado_ As String = ""
        Dim id_Cocluida As Integer = 0
        Dim dr As SqlDataReader


        dr = Manager.Util.getDataReader("SELECT * FROM FORNECEDORES_AVALIACOES_CONCLUIDAS where ID_AVALIACOES=" & id_Avaliacao)

        If dr.Read = True Then
            'id_Cocluida = dr("FORNECEDOR").ToString
            If MessageBox.Show("Tem certeza que deseja Alterar a Avaliação ", " Avaliação de Fornecedores", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                If RadioQualificado.Checked = True Then
                    resultado = 1
                    SITUACAO = "Avaliação Concluida "
                    Resultado_ = "Qualificado"
                ElseIf RadioNQualificado.Checked = True Then
                    resultado = 2
                    SITUACAO = "Avaliação Concluida"
                    Resultado_ = "Não Qualificado"
                ElseIf radioQualificado_restrição.Checked = True Then
                    resultado = 3
                    SITUACAO = "Avaliação Concluida"
                    Resultado_ = "Qualificado Com Restrição"
                End If

                If Radio_Concluido.Checked = True Then
                    Situacao_Pendencia = 1
                ElseIf radio_N_Concluida.Checked = True Then
                    Situacao_Pendencia = 2
                End If
                Try

                    update_Avaliação_Cocluidas(id_Avaliacao, Cmb_Avaliador.SelectedValue, dtAvaliacao.Value, txt_obs.Text, resultado)
                    Add_SITUACAO(id_Avaliacao, SITUACAO)

                    Dim dr1 As SqlDataReader
                    dr1 = Manager.Util.getDataReader("SELECT * FROM FORNECEDORES_AVALIACOES_CONCLUIDAS where ID_AVALIACOES=" & id_Avaliacao)
                    If resultado = 3 Then
                        If dr1.Read = True Then
                            upload_Avaliação_Pendencia(id_Avaliacao, dt_Pendencia.Value, txt_Pendencia.Text, Situacao_Pendencia)
                        Else
                            Add_Avaliação_Pendencia(id_Avaliacao, dt_Pendencia.Value, txt_Pendencia.Text, Situacao_Pendencia)
                        End If
                    ElseIf dr1.Read = True Then
                        upload_Avaliação_Pendencia(id_Avaliacao, dt_Pendencia.Value, txt_Pendencia.Text, Situacao_Pendencia)
                    End If
                    MsgBox("Avaliação Editada com Sucesso.")
                    Me.Close()
                Catch ex As Exception

                End Try
            End If
        Else

            If RadioQualificado.Checked = True Then
                resultado = 1
                SITUACAO = "Avaliação Concluida "
                Resultado_ = "Qualificado"
            ElseIf RadioNQualificado.Checked = True Then
                resultado = 2
                SITUACAO = "Avaliação Concluida"
                Resultado_ = "Não Qualificado"
            ElseIf radioQualificado_restrição.Checked = True Then
                resultado = 3
                SITUACAO = "Avaliação Concluida"
                Resultado_ = "Qualificado Com Restrição"
            End If

            If Radio_Concluido.Checked = True Then
                Situacao_Pendencia = 1
            ElseIf radio_N_Concluida.Checked = True Then
                Situacao_Pendencia = 2
            End If
            Try

                Add_Conclusão(id_Avaliacao, id_fornecedor, Cmb_Avaliador.SelectedValue, dtAvaliacao.Value, txt_obs.Text, resultado)
                Add_SITUACAO(id_Avaliacao, SITUACAO)
                If resultado = 3 Then
                    Add_Avaliação_Pendencia(id_Avaliacao, dt_Pendencia.Value, txt_Pendencia.Text, Situacao_Pendencia)
                End If
                Dim dr1 As SqlDataReader

                dr1 = Manager.Util.getDataReader("select * from VW_LISTAGEM_FORNECEDORES where CODIGO=" & id_fornecedor)
                dr1.Read()
                MsgBox("Avaliação concluida com Susseso. O Fornecedor " & dr1("FORNECEDOR").ToString & " esta " & Resultado_)
                dr1.Close()
                Me.Close()

            Catch ex As Exception

            End Try
        End If
        dr.Close()
    End Sub

#End Region

#Region "RESPONDER ATENDE"

    Private Sub bot_responder_Notas_Click(sender As System.Object, e As System.EventArgs) Handles bot_responder_Notas.Click

        Dim Total_pontos As Double = 0
        Dim Total_Peso As Double = 0
        Dim Resposta As Double = 0
        Dim resposta_ As String = ""
        Dim Média As Double = 0
        Dim Nota_Maxima As Double = 0
        Dim Somatória_Notas As Double = 0
        Try

            Add_Resposta_Nota(id_Pergunta, txtNota.Value, txt_Coment_Notas.Text)
            MsgBox("Resquisito Respondido.")

            txt_Descicao_Nota.Text = ""
            id_Pergunta = 0
            txt_Coment_Notas.Text = ""
            AbaNotas.Enabled = False
            txt_Coment_Notas.Enabled = False
            carregar_grid()
            AbaNotas.Visible = False
            txt_Coment_Notas.Visible = False


            Dim dr As SqlDataReader
            Dim dr1 As SqlDataReader
            dr1 = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_NOTA  where ID_AVALIACAO =" & id_Avaliacao)
            dr1.Read()
            Média = dr1("NOTA_MEDIA").ToString
            Nota_Maxima = dr1("NOTA_MAXIMA").ToString
            dr1.Close()
            dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_PERGUNTAS  where ID_AVALIACAO =" & id_Avaliacao)
            Dim i As Integer = 0
            While dr.Read()
                If i = 1 Then
                Else
                    If dr("RESULTADO_NOTAS").ToString = "" Then
                        i = 1
                    Else
                        i = 0
                        Somatória_Notas = Somatória_Notas + Nota_Maxima
                        Total_pontos = Total_pontos + dr("RESULTADO_NOTAS")
                    End If
                End If
            End While


            If i = 0 Then
                botSalvarAvalia.Enabled = True
                Somatória_Notas = Somatória_Notas * 10
                Total_pontos = Total_pontos * 10
                Resposta = (Total_pontos / Somatória_Notas) * 100

                Média = Média * 10
                If Resposta < Média Then
                    resposta_ = "Não Qualificado"
                    RadioNQualificado.Checked = True
                Else
                    resposta_ = "Qualificado"
                    RadioQualificado.Checked = True
                End If

                txt_Resultado.Text = "O resultado da avaliação foi de " & Resposta & "% - O sistema sugere que este fornecedor seja " & resposta_
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Escolher Resultado"
    Private Sub radioQualificado_restrição_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioQualificado_restrição.CheckedChanged
        dt_Pendencia.Enabled = True
        txt_Pendencia.Enabled = True
        Radio_Concluido.Enabled = True
        radio_N_Concluida.Enabled = True
    End Sub

    Private Sub RadioNQualificado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles RadioNQualificado.CheckedChanged
        dt_Pendencia.Enabled = False
        txt_Pendencia.Enabled = False
        Radio_Concluido.Enabled = False
        radio_N_Concluida.Enabled = False
    End Sub

    Private Sub RadioQualificado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles RadioQualificado.CheckedChanged
        dt_Pendencia.Enabled = False
        txt_Pendencia.Enabled = False
        Radio_Concluido.Enabled = False
        radio_N_Concluida.Enabled = False
    End Sub
#End Region

#Region "Carregar Respostas "

    Sub carregar_resposta()
        If Tipo = 1 Then
            Dim Total_pontos As Integer = 0
            Dim Total_Peso As Integer = 0
            Dim Resposta As Integer = 0
            Dim resposta_ As String = ""
            Try
                Dim dr As SqlDataReader
                dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_PERGUNTAS  where ID_AVALIACAO =" & id_Avaliacao)
                Dim i As Integer = 0
                While dr.Read()
                    If i = 1 Then
                    Else
                        If dr("RESULTADO_ATENDE").ToString = "" Then
                            i = 1
                        Else
                            i = 0
                        End If
                    End If
                End While
                dr.Close()

                If i = 0 Then
                    botSalvarAvalia.Enabled = True
                    dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_PERGUNTAS  where ID_AVALIACAO =" & id_Avaliacao)
                    Dim Atende As Integer = 0
                    Dim A_Parcialmente As Integer = 0
                    Dim n_atende As Integer = 0
                    While dr.Read

                        If dr("RESULTADO_ATENDE").ToString = "Atende" Then
                            Atende = Atende + 1
                        ElseIf dr("RESULTADO_ATENDE").ToString = "Não Atende" Then
                            n_atende = n_atende + 1
                        ElseIf dr("RESULTADO_ATENDE").ToString = "Atende Parcialmente" Then
                            A_Parcialmente = A_Parcialmente + 1
                        End If

                    End While
                    If n_atende > 0 Then
                        resposta_ = "Não Qualificado"
                        dt_Pendencia.Enabled = False
                        txt_Pendencia.Enabled = False
                        Radio_Concluido.Enabled = False
                        radio_N_Concluida.Enabled = False
                    ElseIf A_Parcialmente > 0 Then
                        resposta_ = "Qualificado com Restrição"
                        dt_Pendencia.Enabled = True
                        txt_Pendencia.Enabled = True
                        Radio_Concluido.Enabled = True
                        radio_N_Concluida.Enabled = True
                    Else
                        resposta_ = "Qualificado"
                        dt_Pendencia.Enabled = False
                        txt_Pendencia.Enabled = False
                        Radio_Concluido.Enabled = False
                        radio_N_Concluida.Enabled = False
                    End If
                    txt_Resultado.Text = "O resultado da avaliação                   ATENDE - " & Atende & "             NÃO ATENDE - " & n_atende & _
                        "                  ATENDE PARCIALMENTE - " & A_Parcialmente & "        - O sistema sugere que este fornecedor seja - " & resposta_
                End If

            Catch ex As Exception

            End Try
        ElseIf Tipo = 2 Then

            Dim Total_pontos As Double = 0
            Dim Resposta As Double = 0
            Dim resposta_ As String = ""
            Dim Média As Double = 0
            Dim Nota_Maxima As Double = 0
            Dim Somatória_Notas As Double = 0
            Try


                Dim dr As SqlDataReader
                Dim dr1 As SqlDataReader
                dr1 = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_NOTA  where ID_AVALIACAO =" & id_Avaliacao)
                dr1.Read()
                Média = dr1("NOTA_MEDIA").ToString
                Nota_Maxima = dr1("NOTA_MAXIMA").ToString
                dr1.Close()
                dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_PERGUNTAS  where ID_AVALIACAO =" & id_Avaliacao)
                Dim i As Integer = 0
                While dr.Read()
                    If i = 1 Then
                    Else
                        If dr("RESULTADO_NOTAS").ToString = "" Then
                            i = 1
                        Else
                            i = 0
                            Somatória_Notas = Somatória_Notas + Nota_Maxima
                            Total_pontos = Total_pontos + dr("RESULTADO_NOTAS")
                        End If
                    End If
                End While


                If i = 0 Then
                    botSalvarAvalia.Enabled = True
                    Resposta = (Total_pontos / Somatória_Notas) * 100

                    If Resposta < Média Then
                        resposta_ = "Não Qualificado"
                        RadioNQualificado.Checked = True
                    ElseIf Resposta >= Média Then
                        resposta_ = "Qualificado"
                        RadioQualificado.Checked = True
                    End If

                    txt_Resultado.Text = "O resultado da avaliação foi de " & Resposta & "% - O sistema sugere que este fornecedor seja " & resposta_
                End If
                dr.Close()
            Catch ex As Exception

            End Try

        ElseIf Tipo = 3 Then

            Dim Total_pontos As Integer = 0
            Dim Total_Peso As Integer = 0
            Dim Resposta As Integer = 0
            Dim resposta_ As String = ""
            Try


                Dim dr As SqlDataReader

                dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_PERGUNTAS  where ID_AVALIACAO =" & id_Avaliacao)
                Dim i As Integer = 0
                While dr.Read()
                    If i = 1 Then
                    Else
                        If dr("RESULTADO_PONTUACAO").ToString = "" Then
                            i = 1
                        Else
                            Total_Peso = Total_Peso + dr("PESO")
                            Total_pontos = Total_pontos + dr("RESULTADO_PONTUACAO")
                            i = 0
                        End If
                    End If
                End While


                If i = 0 Then
                    botSalvarAvalia.Enabled = True
                    Resposta = (Total_pontos / Total_Peso) * 100

                    If Resposta < 70 Then
                        resposta_ = "Não Qualificado"
                        RadioNQualificado.Checked = True
                    ElseIf Resposta >= 70 Then
                        resposta_ = "Qualificado"
                        RadioQualificado.Checked = True
                    End If

                    txt_Resultado.Text = "O resultado da avaliação foi de " & Resposta & "% - O sistema sugere que este fornecedor seja " & resposta_
                End If
                dr.Close()
            Catch ex As Exception

            End Try

        ElseIf Tipo = 4 Then
            Try
                Dim dr As SqlDataReader
                Dim numero_perguntas As Integer
                Dim resposta_ As String = ""
                Dim resposta As Integer = ""
                dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_PERGUNTAS  where ID_AVALIACAO =" & id_Avaliacao)
                Dim i As Integer = 0
                While dr.Read()
                    If i = 1 Then
                    Else
                        If dr("RESULTADO_NIVEL").ToString = "" Then
                            i = 1
                        Else
                            i = 0
                        End If
                    End If
                End While

                dr.Close()

                If i = 0 Then
                    botSalvarAvalia.Enabled = True
                    dr = Manager.Util.getDataReader("select * from FORNECEDORES_AVALIACAO_PERGUNTAS  where ID_AVALIACAO =" & id_Avaliacao)

                    While dr.Read()
                        If dr("RESULTADO_NIVEL").ToString = "Otimo" Then
                            resposta = resposta + 3
                        ElseIf dr("RESULTADO_NIVEL").ToString = "Bom" Then
                            resposta = resposta + 2
                        ElseIf dr("RESULTADO_NIVEL").ToString = "Regular" Then
                            resposta = resposta + 1
                        ElseIf dr("RESULTADO_NIVEL").ToString = "Ruim" Then
                            resposta = resposta + 0
                        End If
                        numero_perguntas = numero_perguntas + 3
                    End While
                    resultado = (resposta / numero_perguntas) * 100
                    MsgBox(resultado)

                    If resultado < 70 Then
                        resposta_ = "Não Qualificado"
                        RadioNQualificado.Checked = True
                    ElseIf resultado >= 70 Then
                        resposta_ = "Qualificado"
                        RadioQualificado.Checked = True
                    End If
                    txt_Resultado.Text = "O resultado da avaliação foi de " & resultado & "% - O sistema sugere que este fornecedor seja " & resposta_
                End If
                dr.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub

#End Region

#Region "Classes"

#Region "Add Avaliacao"

    Public Function Add_avaliacao(ByVal ID_FORNECEDOR As Integer, _
                             ByVal ID_TIPO As Integer, _
                             ByVal DATA As Date, _
                             ByVal PERFIL As Integer, _
                             ByVal ID_PERFIL As Integer, _
                             ByVal RESULTADO As String,
                             ByVal SITUACAO As String,
                    Optional ByRef ID_AVALIACAO As Integer = 0) As Integer

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_FORNECEDORES_AVALIACAO_CADASTRO"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDOR", ID_FORNECEDOR)
                .AddWithValue("@TIPO", ID_TIPO)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@PERFIL", PERFIL)
                .AddWithValue("@ID_PERFIL", ID_PERFIL)
                .AddWithValue("@RESULTADO", RESULTADO)
                .AddWithValue("@SITUACAO", SITUACAO)


            End With
            ID_AVALIACAO = _Command.ExecuteScalar
            _Connection.Close()
            Return ID_AVALIACAO

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "Responder pergunta Atende"

    Public Function Add_avaliacao_Perguntas(ByVal ID_AVALIACAO As Integer, _
                           ByVal ID_REQUISITOS As Integer, _
                           ByVal DESCRICAO_REQUISITOS As String, _
                           ByVal PESO As Integer, _
                  Optional ByRef ID_PERGUNTAS As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_FORNECEDORES_AVALIACAO_PERGUNTAS"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AVALIACAO", ID_AVALIACAO)
                .AddWithValue("@ID_REQUISITOS", ID_REQUISITOS)
                .AddWithValue("@DESCRICAO_REQUISITOS", DESCRICAO_REQUISITOS)
                .AddWithValue("@PESO", PESO)

            End With

            ID_PERGUNTAS = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#Region "Add Notas"
    Public Function Add_Avaliação_Notas(ByVal ID_AVALIACAO As Integer, _
                           ByVal NOTA_MINIMA As Integer, _
                            ByVal NOTA_MAXIMA As Integer, _
                            ByVal NOTA_MEDIA As Integer, _
                            Optional ByRef ID_MEDIA As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_FORNECEDORES_AVALIACAO_CADASTRO_NOTA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AVALIACAO", ID_AVALIACAO)
                .AddWithValue("@NOTA_MINIMA", NOTA_MINIMA)
                .AddWithValue("@NOTA_MAXIMA", NOTA_MAXIMA)
                .AddWithValue("@NOTA_MEDIA", NOTA_MEDIA)


            End With
            ID_MEDIA = _Command.ExecuteNonQuery()
            _Connection.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "ADD_AVALICAO_ATENDE"

    Public Function AddAtende(ByVal ID_REQUISITOS As Integer, _
                              ByVal ID_FORNECEDOR As Integer, _
                              ByVal DESCRICAO_REQUISITOS As String, _
                              ByVal ATENDE As Integer, _
                              ByVal COMENTARIOS As String, _
                     Optional ByRef idAtende As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_FORNECEDORES_AVALIACAO_ATENDE"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_REQUISITOS", ID_REQUISITOS)
                .AddWithValue("@ID_FORNECEDOR", ID_FORNECEDOR)
                .AddWithValue("@DESCRICAO_REQUISITOS", DESCRICAO_REQUISITOS)
                .AddWithValue("@ATENDE", ATENDE)
                .AddWithValue("@COMENTARIOS", COMENTARIOS)
            End With

            idAtende = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "DELETE_AVALICAO_ATENDE"

    Public Function DeleteAtende(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_FORNECEDORES_AVALIACAO_ATENDE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDORES_AVALIACAO_ATENDE", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "UPDATE_REQUISITOS_AVALIADO"

    Public Function UpdateRequisitoAvaliado(ByVal idRequisito As Integer, _
                        ByVal AVALIADO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_REQUISITOS_AVALIADO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_REQUISITOS", idRequisito)
                .AddWithValue("@AVALIADO", AVALIADO)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "ADD_AVALICAO_NOTA"

    Public Function AddNota(ByVal ID_REQUISITOS As Integer, _
                              ByVal ID_FORNECEDOR As Integer, _
                              ByVal DESCRICAO_REQUISITOS As String, _
                              ByVal NOTA As Integer, _
                              ByVal NOTA_MEDIA As Integer, _
                              ByVal RESULTADO As String, _
                     Optional ByRef idNota As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_FORNECEDORES_AVALIACAO_NOTA"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_REQUISITOS", ID_REQUISITOS)
                .AddWithValue("@ID_FORNECEDOR", ID_FORNECEDOR)
                .AddWithValue("@DESCRICAO_REQUISITOS", DESCRICAO_REQUISITOS)
                .AddWithValue("@NOTA", NOTA)
                .AddWithValue("@NOTA_MEDIA", NOTA_MEDIA)
                .AddWithValue("@RESULTADO", RESULTADO)
            End With

            idNota = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "DELETE_AVALICAO_NOTA"

    Public Function DeleteNota(ByVal id As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_FORNECEDORES_AVALIACAO_NOTA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDORES_AVALIACAO_NOTA", id)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "ADD_AVALICAO_CONCLUIR"

    Public Function AddConcluir(ByVal ID_FORNECEDOR As Integer, _
                                ByVal ID_COLABORADORES As Integer, _
                                ByVal DATA As Date, _
                                ByVal OBS As String, _
                                ByVal QUALIFICADO As Integer, _
                     Optional ByRef idAvaliaConcluir As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "INSERT_FORNECEDORES_AVALIACOES"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDOR", ID_FORNECEDOR)
                .AddWithValue("@AVALIDADOR", ID_COLABORADORES)
                .AddWithValue("@DATA", DATA)
                .AddWithValue("@OBS", OBS)
                .AddWithValue("@QUALIFICADO", QUALIFICADO)
            End With

            idAvaliaConcluir = _Command.ExecuteScalar
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function


#End Region

    Public Function Add_Resposta_Atende(ByVal ID_PERGUNTA As Integer, _
                            ByVal RESPOSTA As String, _
                            ByVal OBS As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_FORNECEDORES_AVALIACAO_PERGUNTAS_ATENDE]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDORES_PERGUNTAS", ID_PERGUNTA)
                .AddWithValue("@RESPOSTA", RESPOSTA)
                .AddWithValue("@OBS", OBS)

            End With
            _Command.ExecuteNonQuery()
            _Connection.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "Responder pergunta Nota"
    Public Function Add_Resposta_Nota(ByVal ID_PERGUNTA As Integer, _
                            ByVal RESPOSTA As Double, _
                            ByVal OBS As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_FORNECEDORES_AVALIACAO_PERGUNTAS_NOTAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDORES_PERGUNTAS", ID_PERGUNTA)
                .AddWithValue("@RESPOSTA", RESPOSTA)
                .AddWithValue("@OBS", OBS)

            End With
            _Command.ExecuteNonQuery()
            _Connection.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "Responder pergunta Pontuação"

    Public Function Add_Resposta_Pontuacao(ByVal ID_PERGUNTA As Integer, _
                            ByVal RESPOSTA As Integer, _
                            ByVal OBS As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_FORNECEDORES_AVALIACAO_PERGUNTAS_PONTUACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDORES_PERGUNTAS", ID_PERGUNTA)
                .AddWithValue("@RESPOSTA", RESPOSTA)
                .AddWithValue("@OBS", OBS)

            End With
            _Command.ExecuteNonQuery()
            _Connection.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "Responder pergunta Nivel"

    Public Function Add_Resposta_Nivel(ByVal ID_PERGUNTA As Integer, _
                            ByVal RESPOSTA As String, _
                            ByVal OBS As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_FORNECEDORES_AVALIACAO_PERGUNTAS_NIVEL]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_FORNECEDORES_PERGUNTAS", ID_PERGUNTA)
                .AddWithValue("@RESPOSTA", RESPOSTA)
                .AddWithValue("@OBS", OBS)

            End With
            _Command.ExecuteNonQuery()
            _Connection.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "Adicionar Pesso a Pergunta estilo pontuação"

    Public Function ADD_PESO(ByVal ID_PERGUNTA As Integer, _
                           ByVal PESO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_REQUISITOS_PESO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_REQUISITOS", ID_PERGUNTA)
                .AddWithValue("@PESO", PESO)


            End With
            _Command.ExecuteNonQuery()
            _Connection.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "Concluir Avaliação"


    Public Function Add_Conclusão(ByVal ID_AVALIACAO As Integer, _
                           ByVal ID_FORNECEDORES As Integer, _
                             ByVal ID_COLABORADOR As Integer, _
                               ByVal DT_CONCLUSAO As Date, _
                               ByVal OBS As String, _
                                ByVal RESULTADO As Integer, _
                                Optional ByRef ID_AVALICAO_CONCLUIDA As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_FORNECEDORES_AVALIACAO_CONCLUIDAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AVALIACAO", ID_AVALIACAO)
                .AddWithValue("@ID_FORNECEDORES", ID_FORNECEDORES)
                .AddWithValue("@ID_COLABORADOR", ID_COLABORADOR)
                .AddWithValue("@DATA_CONCLUSÃO", DT_CONCLUSAO)
                .AddWithValue("@OBS", OBS)
                .AddWithValue("@RESULTADO", RESULTADO)


            End With
            ID_AVALICAO_CONCLUIDA = _Command.ExecuteNonQuery()
            _Connection.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "Add Situação"
    Public Function Add_SITUACAO(ByVal ID_AVALIACAO As Integer, _
                          ByVal SITUACAO As String) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_FORNECEDORES_AVALIACAO_SITUACAO]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AVALIACAO", ID_AVALIACAO)
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

#Region "Add Pendencia "
    Public Function Add_Avaliação_Pendencia(ByVal ID_AVALIACAO As Integer, _
                            ByVal DT_CONCLUSAO As Date, _
                             ByVal PENDENCIA As String, _
                             ByVal SITUACAO As Integer, _
                             Optional ByRef ID_AVALICAO_PENDENCIA As Integer = 0) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[INSERT_FORNECEDORES_AVALIACOES_PENDENCIAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AVALIACAO", ID_AVALIACAO)
                .AddWithValue("@DATA_PENDENCIA", DT_CONCLUSAO)
                .AddWithValue("@PENDECIA", PENDENCIA)
                .AddWithValue("@SITUACAO", SITUACAO)


            End With
            ID_AVALICAO_PENDENCIA = _Command.ExecuteNonQuery()
            _Connection.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "Update Situação"

    Public Function upload_Avaliação_Pendencia(ByVal ID_AVALIACAO As Integer, _
                            ByVal DT_CONCLUSAO As Date, _
                             ByVal PENDENCIA As String, _
                             ByVal SITUACAO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_FORNECEDORES_AVALIACAO_PENDENCIAS]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AVALIACAO", ID_AVALIACAO)
                .AddWithValue("@DATA_PENDENCIA", DT_CONCLUSAO)
                .AddWithValue("@PENDECIA", PENDENCIA)
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

#Region "update Avaliação Concluida"

    Public Function update_Avaliação_Cocluidas(ByVal ID_AVALIACAO As Integer, _
                                              ByVal ID_COLABORADOR As Integer, _
                               ByVal DT_CONCLUSAO As Date, _
                               ByVal OBS As String, _
                                ByVal RESULTADO As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[UPDATE_FORNECEDORES_AVALIACAO_CONCLUIDA]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_AVALIACAO", ID_AVALIACAO)
                .AddWithValue("@ID_COLABORADOR", ID_COLABORADOR)
                .AddWithValue("@DATA_CONCLUSÃO", DT_CONCLUSAO)
                .AddWithValue("@OBS", OBS)
                .AddWithValue("@RESULTADO", RESULTADO)


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
