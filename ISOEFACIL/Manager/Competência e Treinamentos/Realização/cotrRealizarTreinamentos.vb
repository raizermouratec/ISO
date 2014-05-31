Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.cotrProgramacaoTreinamentos
Public Class cotrRealizarTreinamentos

#Region "VARIÁVEIS"

    Public idRealizar As String
    Public idRealizacao As String
    Private isEdit As Boolean = False
    Public verif As Boolean = False
    Public strMes As String = String.Empty
    Public strSituacao As String = String.Empty
    Public strAno As String = String.Empty
    Private Nivel As String = String.Empty
    Private Tipo As String = String.Empty
    Public strId As String = String.Empty

    Private ANEXO() As Byte
    Public Modulo As String = "TREINAMENTOS"
    Public Tela As String = "cotrRealizarTreinamentos"

    'Pega Id
    Public WriteOnly Property Realizacao() As String
        Set(ByVal value As String)
            Me.idRealizacao = value
        End Set
    End Property

    'Pega Id
    Public WriteOnly Property Realizar() As String
        Set(ByVal value As String)
            Me.idRealizar = value
        End Set
    End Property

    Public WriteOnly Property Mes() As String
        Set(ByVal value As String)
            Me.strMes = value
        End Set
    End Property
    Public WriteOnly Property Situacao() As String
        Set(ByVal value As String)
            Me.strSituacao = value
        End Set
    End Property
    Public WriteOnly Property Ano() As String
        Set(ByVal value As String)
            Me.strAno = value
        End Set
    End Property
#End Region

#Region "NOVO"
    Public Sub NovoRealiza(ByVal id As Integer)

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_TREINAMENTO_REALIZAR WHERE ID = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read
                Me.txtAcaoCapacitacao.Text = dr("TREINAMENTO").ToString
                Me.txtNumero.Text = dr("NUMERO").ToString
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        isEdit = False
        Me.ShowDialog()
    End Sub
#End Region

#Region "POPULA COMBOS"

#Region "RESPONSAVEL"

    Sub CarregaResp()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        cmbResponsavel.DataSource = dtb
        cmbResponsavel.DisplayMember = "COLABORADOR"
        cmbResponsavel.ValueMember = "ID"

        cmbResponsavelEficiencia.DataSource = dtb
        cmbResponsavelEficiencia.DisplayMember = "COLABORADOR"
        cmbResponsavelEficiencia.ValueMember = "ID"


    End Sub

#End Region

#End Region

#Region "CARREGA LISTA"

    Public Sub carregaPartitipantesCargo()

        'Monta o Grid

        gridParticipantes.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_TREINAMENTO_PARTICIPANTES_CARGO")

    End Sub
    Public Sub carregaPartitipantesArea()

        'Monta o Grid

        gridParticipantes.DataSource = Manager.Util.getDataTable("SELECT  * FROM AREAS")

    End Sub
#End Region

#Region "LOAD"
    Private Sub cotrRealizarTreinamentos_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        TabProgramacao.Show()
        CarregaResp()
        carregaPartitipantesCargo()
        carregaListaFreqeuncia()
    End Sub
#End Region

#Region "PROGRAMAÇÃO"

#Region "SALVAR"
    Private Sub botSalvarProgramacao_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarProgramacao.Click
        Dim realizacao As New realizacaoTreinamentos

        'TIPO REALIZCAO
        Dim Real As String = String.Empty
        If OptInterna.Checked Then
            Real = "Interna"
        ElseIf optExterna.Checked Then
            Real = "Externa"
        Else
            Real = ""
        End If

        If isEdit Then
            ' Editar
        Else
            ' Salvar
            strId = realizacao.AddProgramacao(idRealizar, _
                                         cmbResponsavel.SelectedValue, _
                                         txtLocal.Text, _
                                         txtInstrutor.Text, _
                                         Tipo, _
                                         Nivel, _
                                         mskCargaHoraria.Text, _
                                         0, _
                                         txtTotalDias.Text, _
                                         dtInicio.Value, _
                                         dtTermino.Value, _
                                         Real, _
                                         txtObs.Text)
            If strId <> String.Empty Then
                MessageBox.Show("Dados atualizados com sucesso", "Treinamentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                CriaFrequencia()
                carregaListaFreqeuncia()
                LimpaAllChecks()
                realizacao.UpdateTudo(0)
                cotrRealizacaoTreinamentos.carregaListaDatasAno(strAno)
            End If
        End If

    End Sub
#End Region

#Region "EDITAR"
    Private Sub botEditarProgramacao_Click(sender As System.Object, e As System.EventArgs) Handles botEditarProgramacao.Click
        If gridParticipantes.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Realização de Treinamentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
        End If
    End Sub
#End Region

    ''' <summary>
    ''' PROGRAMAÇÃO COLABORADORES.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub optColaboradores_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles optColaboradores.SelectedIndexChanged
        If optAreas.Checked Then
            gridParticipantes.DataSource = Nothing
            carregaPartitipantesCargo()
        Else
            gridParticipantes.DataSource = Nothing
            carregaPartitipantesArea()
        End If
    End Sub
    ''' <summary>
    ''' PROGRAMAÇÃO AREAS.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub optAreas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles optAreas.SelectedIndexChanged
        If optAreas.Checked Then
            gridParticipantes.DataSource = Nothing
            carregaPartitipantesArea()
        Else
            gridParticipantes.DataSource = Nothing
            carregaPartitipantesCargo()
        End If

    End Sub
    ''' <summary>
    ''' PROGRAMAÇÃOTIPO.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmbTipo_ChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbTipo.ChangeCommitted
        If cmbTipo.Text = OptTipo_CursoFormcao.Text Then
            InputPanel_Nivel.Visible = True
            InputPanel_Procedimentos.Visible = False
            lblSeparador.Text = "Nível"
            Tipo = OptTipo_CursoFormcao.Text
        ElseIf cmbTipo.Text = OptTipo_CursoComplementar.Text Then
            InputPanel_Nivel.Visible = False
            InputPanel_Procedimentos.Visible = False
            lblSeparador.Text = ""
            Tipo = OptTipo_CursoComplementar.Text
        ElseIf cmbTipo.Text = OptTipo_TreinaProc.Text Then
            InputPanel_Nivel.Visible = False
            InputPanel_Procedimentos.Visible = True
            lblSeparador.Text = ""
            Tipo = OptTipo_TreinaProc.Text
            '*** CASO SEJA PROCEDIMENTO SERÁ GRAVADO EM OUTRA TABELA [TRAINAMENTOS_REALIZAR_PROCEDIMENTOS]
            '*** CRIAR METODO
        Else
            InputPanel_Nivel.Visible = False
            InputPanel_Procedimentos.Visible = False
            lblSeparador.Text = ""
            Tipo = String.Empty
        End If
    End Sub
    ''' <summary>
    ''' PROGRAMAÇÃO NIVEL.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmbNivel_ChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbNivel.ChangeCommitted
        If InputPanel_Nivel.Visible = True Then
            If cmbNivel.Text = optNivel_Medio.Text Then
                Nivel = optNivel_Medio.Text
            ElseIf cmbNivel.Text = optNivel_Tecnico.Text Then
                Nivel = optNivel_Tecnico.Text
            ElseIf cmbNivel.Text = optNivel_Superior.Text Then
                Nivel = optNivel_Superior.Text
            ElseIf cmbNivel.Text = optNivel_Mestrado.Text Then
                Nivel = optNivel_Mestrado.Text
            ElseIf cmbNivel.Text = optNivel_POS.Text Then
                Nivel = optNivel_POS.Text
            Else
                Nivel = String.Empty
            End If
        End If
    End Sub
    ''' <summary>
    ''' CRIAÇÃO DE FREQUENCIA.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CriaFrequencia()

        Dim realizacao As New realizacaoTreinamentos

        Dim dtb As New DataTable
        Dim sql As String = String.Format("SELECT * FROM COLABORADORES WHERE CHECKS = 1")
        dtb = Manager.Util.getDataTableById(sql)

        Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

        With dtb
            Dim status As Integer = 3
            Dim situacao As String = "Em Curso"
            Dim colab As Integer
            Try
                While dr.Read

                    colab = dr("ID_COLABORADORES").ToString

                    realizacao.AddFrequencia(idRealizar, colab, status, situacao)

                End While

            Catch ex As Exception
                MsgBox("Não foi possivel realizar a operação. Tente novamente.")
            End Try

        End With

    End Sub

#Region "GRID CHECK"

    Private Sub gridParticipantes_Click(sender As System.Object, e As System.EventArgs) Handles gridParticipantes.Click
        With gridParticipantes
            If .ColSel = 5 Then
                Dim Check As New realizacaoTreinamentos
                Dim Aprovado As Boolean
                Dim id As Integer
                Try
                    If .Item(.RowSel, .ColSel) = True Then
                        Aprovado = False
                        .Item(.RowSel, .ColSel) = False
                    Else
                        Aprovado = True
                        .Item(.RowSel, .ColSel) = True
                    End If
                    id = gridParticipantes(gridParticipantes.RowSel, 1)
                    Check.UpdateMultiploParticipantes(id, Aprovado)
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
        End With
    End Sub

    Public Sub LimpaAllChecks()
        With gridParticipantes
            .Item(.RowSel, .ColSel) = False
        End With
    End Sub

#End Region

#End Region

#Region "OBJETIVOS"

#Region "SALVAR"
    Private Sub botSalvarObjetivos_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarObjetivos.Click
        Dim realizacao As New realizacaoTreinamentos
        If isEdit Then
            ' Editar
        Else
            ' Salvar
            If realizacao.AddObjetivos(idRealizar, _
                                         txtObjetivos.Text, _
                                         txtJustificativas.Text, _
                                         txtRecursosN.Text, _
                                         txtPlanejamento.Text, _
                                         dtDataElaboracao.Value, _
                                         dtDataEficacia.Value) Then
                MessageBox.Show("Dados atualizados com sucesso", "Treinamentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region

#Region "EDITAR"
    Private Sub botEditarObjetivos_Click(sender As System.Object, e As System.EventArgs) Handles botEditarObjetivos.Click

    End Sub
#End Region



#End Region

#Region "FREQUÊNCIA"
    ''' <summary>
    ''' Finalizar Treinamento.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botFinalizarFrequencia_Click(sender As System.Object, e As System.EventArgs) Handles botFinalizarFrequencia.Click
        If MsgBox("Deseja realmente concluir o Treinamento ?", MsgBoxStyle.YesNo, "Treinamentos") = MsgBoxResult.Yes Then
            AtualizarStatus()
            cotrRealizacaoTreinamentos.carregaListaDatasAno(strAno)
        End If
    End Sub
    ''' <summary>
    ''' PROGRAMAÇÃO ATUALIZAR STATUS.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub AtualizarStatus()
        Dim classe As New realizacaoTreinamentos
        Dim mes As String = strMes
        Dim situacao As String = strSituacao

        classe.UpdateRealizacaoStatus(idRealizar)

        'Mes
        Select Case mes
            Case "Janeiro"
                mes = "JAN"
            Case "Fevereiro"
                mes = "FEV"
            Case "Março"
                mes = "MAR"
            Case "Abril"
                mes = "ABR"
            Case "Maio"
                mes = "MAI"
            Case "Junho"
                mes = "JUN"
            Case "Julho"
                mes = "JUL"
            Case "Agosto"
                mes = "AGO"
            Case "Setembro"
                mes = "JAN"
            Case "Outubro"
                mes = "OUT"
            Case "Novembro"
                mes = "NOV"
            Case "Dezembro"
                mes = "DEZ"
            Case Else

        End Select
        '  Situacao
        Select Case situacao
            Case "Programada"
                situacao = 1
            Case "Realizada"
                situacao = 2
            Case "Cancelada"
                situacao = 3
            Case "Reprogramada"
                situacao = 4
            Case "Atrasada"
                situacao = 5
            Case Else

        End Select

        classe.UpdatePlanoStatus(idRealizacao, mes)
    End Sub
    ''' <summary>
    ''' Carrega Lista de Frequencia.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub carregaListaFreqeuncia()

        Dim dt As New DataTable
        Dim i As Integer = 1

        Dim sqlId As String = String.Format("SELECT * FROM TREINAMENTO_FREQUENCIA")
        dt = Manager.Util.getDataTableById(sqlId)

        Dim sqlId2 As String = String.Format("SELECT * FROM VW_LISTAGEM_TREINAMENTO_FREQUENCIA WHERE ID_TREINAMENTO = {0}", idRealizar)
        Dim dt2 As New DataTable

        'Monta o Grid
        gridFrequencia.AutoGenerateColumns = False
        dt2 = Manager.Util.getDataTableById(sqlId2)
        gridFrequencia.DataSource = dt2


        Try

            'Função para validação de Imagem
            For Each dr As DataRow In dt2.Rows

                ' coluna especifica
                If dr("1") = 1 Then
                    gridFrequencia.SetCellImage(i, 3, _imgListLegenda.Images.Item(1))
                End If
                If dr("1") = 2 Then
                    gridFrequencia.SetCellImage(i, 3, _imgListLegenda.Images.Item(2))
                End If
                If dr("1") = 3 Then
                    gridFrequencia.SetCellImage(i, 3, _imgListLegenda.Images.Item(5))
                End If

                If dr("2") = 1 Then
                    gridFrequencia.SetCellImage(i, 4, _imgListLegenda.Images.Item(1))
                End If
                If dr("2") = 2 Then
                    gridFrequencia.SetCellImage(i, 4, _imgListLegenda.Images.Item(2))
                End If
                If dr("2") = 3 Then
                    gridFrequencia.SetCellImage(i, 4, _imgListLegenda.Images.Item(5))
                End If

                If dr("3") = 1 Then
                    gridFrequencia.SetCellImage(i, 5, _imgListLegenda.Images.Item(1))
                End If
                If dr("3") = 2 Then
                    gridFrequencia.SetCellImage(i, 5, _imgListLegenda.Images.Item(2))
                End If
                If dr("3") = 3 Then
                    gridFrequencia.SetCellImage(i, 5, _imgListLegenda.Images.Item(5))
                End If

                If dr("4") = 1 Then
                    gridFrequencia.SetCellImage(i, 6, _imgListLegenda.Images.Item(1))
                End If
                If dr("4") = 2 Then
                    gridFrequencia.SetCellImage(i, 6, _imgListLegenda.Images.Item(2))
                End If
                If dr("4") = 3 Then
                    gridFrequencia.SetCellImage(i, 6, _imgListLegenda.Images.Item(5))
                End If

                If dr("5") = 1 Then
                    gridFrequencia.SetCellImage(i, 7, _imgListLegenda.Images.Item(1))
                End If
                If dr("5") = 2 Then
                    gridFrequencia.SetCellImage(i, 7, _imgListLegenda.Images.Item(2))
                End If
                If dr("5") = 3 Then
                    gridFrequencia.SetCellImage(i, 7, _imgListLegenda.Images.Item(5))
                End If

                If dr("6") = 1 Then
                    gridFrequencia.SetCellImage(i, 8, _imgListLegenda.Images.Item(1))
                End If
                If dr("6") = 2 Then
                    gridFrequencia.SetCellImage(i, 8, _imgListLegenda.Images.Item(2))
                End If
                If dr("6") = 3 Then
                    gridFrequencia.SetCellImage(i, 8, _imgListLegenda.Images.Item(5))
                End If

                If dr("7") = 1 Then
                    gridFrequencia.SetCellImage(i, 9, _imgListLegenda.Images.Item(1))
                End If
                If dr("7") = 2 Then
                    gridFrequencia.SetCellImage(i, 9, _imgListLegenda.Images.Item(2))
                End If
                If dr("7") = 3 Then
                    gridFrequencia.SetCellImage(i, 9, _imgListLegenda.Images.Item(5))
                End If

                If dr("8") = 1 Then
                    gridFrequencia.SetCellImage(i, 10, _imgListLegenda.Images.Item(1))
                End If
                If dr("8") = 2 Then
                    gridFrequencia.SetCellImage(i, 10, _imgListLegenda.Images.Item(2))
                End If
                If dr("8") = 3 Then
                    gridFrequencia.SetCellImage(i, 10, _imgListLegenda.Images.Item(5))
                End If

                If dr("9") = 1 Then
                    gridFrequencia.SetCellImage(i, 11, _imgListLegenda.Images.Item(1))
                End If
                If dr("9") = 2 Then
                    gridFrequencia.SetCellImage(i, 11, _imgListLegenda.Images.Item(2))
                End If
                If dr("9") = 3 Then
                    gridFrequencia.SetCellImage(i, 11, _imgListLegenda.Images.Item(5))
                End If

                If dr("10") = 1 Then
                    gridFrequencia.SetCellImage(i, 12, _imgListLegenda.Images.Item(1))
                End If
                If dr("10") = 2 Then
                    gridFrequencia.SetCellImage(i, 12, _imgListLegenda.Images.Item(2))
                End If
                If dr("10") = 3 Then
                    gridFrequencia.SetCellImage(i, 12, _imgListLegenda.Images.Item(5))
                End If

                If dr("11") = 1 Then
                    gridFrequencia.SetCellImage(i, 13, _imgListLegenda.Images.Item(1))
                End If
                If dr("11") = 2 Then
                    gridFrequencia.SetCellImage(i, 13, _imgListLegenda.Images.Item(2))
                End If
                If dr("11") = 3 Then
                    gridFrequencia.SetCellImage(i, 13, _imgListLegenda.Images.Item(5))
                End If

                If dr("12") = 1 Then
                    gridFrequencia.SetCellImage(i, 14, _imgListLegenda.Images.Item(1))
                End If
                If dr("12") = 2 Then
                    gridFrequencia.SetCellImage(i, 14, _imgListLegenda.Images.Item(2))
                End If
                If dr("12") = 3 Then
                    gridFrequencia.SetCellImage(i, 14, _imgListLegenda.Images.Item(5))
                End If

                If dr("13") = 1 Then
                    gridFrequencia.SetCellImage(i, 15, _imgListLegenda.Images.Item(1))
                End If
                If dr("13") = 2 Then
                    gridFrequencia.SetCellImage(i, 15, _imgListLegenda.Images.Item(2))
                End If
                If dr("13") = 3 Then
                    gridFrequencia.SetCellImage(i, 15, _imgListLegenda.Images.Item(5))
                End If

                If dr("14") = 1 Then
                    gridFrequencia.SetCellImage(i, 16, _imgListLegenda.Images.Item(1))
                End If
                If dr("14") = 2 Then
                    gridFrequencia.SetCellImage(i, 16, _imgListLegenda.Images.Item(2))
                End If
                If dr("14") = 3 Then
                    gridFrequencia.SetCellImage(i, 16, _imgListLegenda.Images.Item(5))
                End If

                If dr("15") = 1 Then
                    gridFrequencia.SetCellImage(i, 17, _imgListLegenda.Images.Item(1))
                End If
                If dr("15") = 2 Then
                    gridFrequencia.SetCellImage(i, 17, _imgListLegenda.Images.Item(2))
                End If
                If dr("15") = 3 Then
                    gridFrequencia.SetCellImage(i, 17, _imgListLegenda.Images.Item(5))
                End If

                If dr("16") = 1 Then
                    gridFrequencia.SetCellImage(i, 18, _imgListLegenda.Images.Item(1))
                End If
                If dr("16") = 2 Then
                    gridFrequencia.SetCellImage(i, 18, _imgListLegenda.Images.Item(2))
                End If
                If dr("16") = 3 Then
                    gridFrequencia.SetCellImage(i, 18, _imgListLegenda.Images.Item(5))
                End If

                If dr("17") = 1 Then
                    gridFrequencia.SetCellImage(i, 19, _imgListLegenda.Images.Item(1))
                End If
                If dr("17") = 2 Then
                    gridFrequencia.SetCellImage(i, 19, _imgListLegenda.Images.Item(2))
                End If
                If dr("17") = 3 Then
                    gridFrequencia.SetCellImage(i, 19, _imgListLegenda.Images.Item(5))
                End If

                If dr("18") = 1 Then
                    gridFrequencia.SetCellImage(i, 20, _imgListLegenda.Images.Item(1))
                End If
                If dr("18") = 2 Then
                    gridFrequencia.SetCellImage(i, 20, _imgListLegenda.Images.Item(2))
                End If
                If dr("18") = 3 Then
                    gridFrequencia.SetCellImage(i, 20, _imgListLegenda.Images.Item(5))
                End If

                If dr("19") = 1 Then
                    gridFrequencia.SetCellImage(i, 21, _imgListLegenda.Images.Item(1))
                End If
                If dr("19") = 2 Then
                    gridFrequencia.SetCellImage(i, 21, _imgListLegenda.Images.Item(2))
                End If
                If dr("19") = 3 Then
                    gridFrequencia.SetCellImage(i, 21, _imgListLegenda.Images.Item(5))
                End If

                If dr("20") = 1 Then
                    gridFrequencia.SetCellImage(i, 22, _imgListLegenda.Images.Item(1))
                End If
                If dr("20") = 2 Then
                    gridFrequencia.SetCellImage(i, 22, _imgListLegenda.Images.Item(2))
                End If
                If dr("20") = 3 Then
                    gridFrequencia.SetCellImage(i, 22, _imgListLegenda.Images.Item(5))
                End If

                If dr("21") = 1 Then
                    gridFrequencia.SetCellImage(i, 23, _imgListLegenda.Images.Item(1))
                End If
                If dr("21") = 2 Then
                    gridFrequencia.SetCellImage(i, 23, _imgListLegenda.Images.Item(2))
                End If
                If dr("21") = 3 Then
                    gridFrequencia.SetCellImage(i, 23, _imgListLegenda.Images.Item(5))
                End If

                If dr("22") = 1 Then
                    gridFrequencia.SetCellImage(i, 24, _imgListLegenda.Images.Item(1))
                End If
                If dr("22") = 2 Then
                    gridFrequencia.SetCellImage(i, 24, _imgListLegenda.Images.Item(2))
                End If
                If dr("22") = 3 Then
                    gridFrequencia.SetCellImage(i, 24, _imgListLegenda.Images.Item(5))
                End If

                If dr("23") = 1 Then
                    gridFrequencia.SetCellImage(i, 25, _imgListLegenda.Images.Item(1))
                End If
                If dr("23") = 2 Then
                    gridFrequencia.SetCellImage(i, 25, _imgListLegenda.Images.Item(2))
                End If
                If dr("23") = 3 Then
                    gridFrequencia.SetCellImage(i, 25, _imgListLegenda.Images.Item(5))
                End If

                If dr("24") = 1 Then
                    gridFrequencia.SetCellImage(i, 26, _imgListLegenda.Images.Item(1))
                End If
                If dr("24") = 2 Then
                    gridFrequencia.SetCellImage(i, 26, _imgListLegenda.Images.Item(2))
                End If
                If dr("24") = 3 Then
                    gridFrequencia.SetCellImage(i, 26, _imgListLegenda.Images.Item(5))
                End If

                If dr("25") = 1 Then
                    gridFrequencia.SetCellImage(i, 27, _imgListLegenda.Images.Item(1))
                End If
                If dr("25") = 2 Then
                    gridFrequencia.SetCellImage(i, 27, _imgListLegenda.Images.Item(2))
                End If
                If dr("25") = 3 Then
                    gridFrequencia.SetCellImage(i, 27, _imgListLegenda.Images.Item(5))
                End If

                If dr("26") = 1 Then
                    gridFrequencia.SetCellImage(i, 28, _imgListLegenda.Images.Item(1))
                End If
                If dr("26") = 2 Then
                    gridFrequencia.SetCellImage(i, 28, _imgListLegenda.Images.Item(2))
                End If
                If dr("26") = 3 Then
                    gridFrequencia.SetCellImage(i, 28, _imgListLegenda.Images.Item(5))
                End If

                If dr("27") = 1 Then
                    gridFrequencia.SetCellImage(i, 29, _imgListLegenda.Images.Item(1))
                End If
                If dr("27") = 2 Then
                    gridFrequencia.SetCellImage(i, 29, _imgListLegenda.Images.Item(2))
                End If
                If dr("27") = 3 Then
                    gridFrequencia.SetCellImage(i, 29, _imgListLegenda.Images.Item(5))
                End If

                If dr("28") = 1 Then
                    gridFrequencia.SetCellImage(i, 30, _imgListLegenda.Images.Item(1))
                End If
                If dr("28") = 2 Then
                    gridFrequencia.SetCellImage(i, 30, _imgListLegenda.Images.Item(2))
                End If
                If dr("28") = 3 Then
                    gridFrequencia.SetCellImage(i, 30, _imgListLegenda.Images.Item(5))
                End If

                If dr("29") = 1 Then
                    gridFrequencia.SetCellImage(i, 31, _imgListLegenda.Images.Item(1))
                End If
                If dr("29") = 2 Then
                    gridFrequencia.SetCellImage(i, 31, _imgListLegenda.Images.Item(2))
                End If
                If dr("29") = 3 Then
                    gridFrequencia.SetCellImage(i, 31, _imgListLegenda.Images.Item(5))
                End If

                If dr("30") = 1 Then
                    gridFrequencia.SetCellImage(i, 32, _imgListLegenda.Images.Item(1))
                End If
                If dr("30") = 2 Then
                    gridFrequencia.SetCellImage(i, 32, _imgListLegenda.Images.Item(2))
                End If
                If dr("30") = 3 Then
                    gridFrequencia.SetCellImage(i, 32, _imgListLegenda.Images.Item(5))
                End If

                If dr("31") = 1 Then
                    gridFrequencia.SetCellImage(i, 33, _imgListLegenda.Images.Item(1))
                End If
                If dr("31") = 2 Then
                    gridFrequencia.SetCellImage(i, 33, _imgListLegenda.Images.Item(2))
                End If
                If dr("31") = 3 Then
                    gridFrequencia.SetCellImage(i, 33, _imgListLegenda.Images.Item(5))
                End If

                i += 1

            Next

        Catch ex As Exception
            'MsgBox("Não foi possivel realizar a operação. Tente novamente.")
        End Try

    End Sub
    ''' <summary>
    ''' CLICK NO GRID FREQUENCIA.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gridFrequencia_Click(sender As System.Object, e As System.EventArgs) Handles gridFrequencia.Click
        With gridFrequencia
            Dim Check As New realizacaoTreinamentos
            Try
                'SE NADA
                If .GetData(.RowSel, .ColSel) = 3 Then
                    cmdPresente.Enabled = True
                    cmdAusente.Enabled = True
                    cmdRemover.Enabled = False
                    'SE PRESENTE
                ElseIf .GetData(.RowSel, .ColSel) = 1 Then
                    cmdPresente.Enabled = False
                    cmdAusente.Enabled = True
                    cmdRemover.Enabled = True
                    'SE AUSENTE
                ElseIf .GetData(.RowSel, .ColSel) = 2 Then
                    cmdPresente.Enabled = True
                    cmdAusente.Enabled = False
                    cmdRemover.Enabled = True
                Else

                End If
            Catch ex As Exception

            End Try
        End With
    End Sub

#Region "BOTÕES DO MENU"

#Region "PRESENTE"
    Private Sub cmdPresente_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdPresente.Click
        Dim Check As New realizacaoTreinamentos
        Dim id As Integer
        Dim tipo As Integer = 1
        Dim dia As Integer = 0
        With gridFrequencia
            If .ColSel = 3 Then
                Try
                    dia = 1
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 4 Then
                Try
                    dia = 2
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 5 Then
                Try
                    dia = 3
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 6 Then
                Try
                    dia = 4
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 8 Then
                Try
                    dia = 5
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 9 Then
                Try

                    dia = 6
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 10 Then
                Try

                    dia = 7
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 11 Then
                Try

                    dia = 8
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 12 Then
                Try

                    dia = 9
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 13 Then
                Try

                    dia = 10
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 14 Then
                Try

                    dia = 11
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 15 Then
                Try

                    dia = 12
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 16 Then
                Try

                    dia = 13
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 17 Then
                Try

                    dia = 14
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 18 Then
                Try

                    dia = 15
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 19 Then
                Try

                    dia = 16
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 20 Then
                Try

                    dia = 17
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 21 Then
                Try
                    tipo = 1
                    dia = 18
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 22 Then
                Try
                    tipo = 1
                    dia = 19
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 23 Then
                Try
                    tipo = 1
                    dia = 20
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 24 Then
                Try

                    dia = 21
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 25 Then
                Try

                    dia = 22
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 26 Then
                Try

                    dia = 23
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 27 Then
                Try

                    dia = 24
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 28 Then
                Try

                    dia = 25
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 29 Then
                Try

                    dia = 26
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 30 Then
                Try

                    dia = 27
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 31 Then
                Try

                    dia = 28
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 32 Then
                Try

                    dia = 29
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 33 Then
                Try

                    dia = 30
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 34 Then
                Try
                    dia = 31
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
        End With
    End Sub
#End Region

#Region "AUSENTE"
    Private Sub cmdAusente_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAusente.Click
        Dim Check As New realizacaoTreinamentos
        Dim id As Integer
        Dim tipo As Integer = 2
        Dim dia As Integer = 0
        With gridFrequencia
            If .ColSel = 3 Then
                Try
                    dia = 1
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 4 Then
                Try
                    dia = 2
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 5 Then
                Try
                    dia = 3
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 6 Then
                Try
                    dia = 4
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 8 Then
                Try
                    dia = 5
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 9 Then
                Try

                    dia = 6
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 10 Then
                Try

                    dia = 7
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 11 Then
                Try

                    dia = 8
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 12 Then
                Try

                    dia = 9
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 13 Then
                Try

                    dia = 10
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 14 Then
                Try

                    dia = 11
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 15 Then
                Try

                    dia = 12
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 16 Then
                Try

                    dia = 13
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 17 Then
                Try

                    dia = 14
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 18 Then
                Try

                    dia = 15
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 19 Then
                Try

                    dia = 16
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 20 Then
                Try

                    dia = 17
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 21 Then
                Try
                    tipo = 1
                    dia = 18
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 22 Then
                Try
                    tipo = 1
                    dia = 19
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 23 Then
                Try
                    tipo = 1
                    dia = 20
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 24 Then
                Try

                    dia = 21
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 25 Then
                Try

                    dia = 22
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 26 Then
                Try

                    dia = 23
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 27 Then
                Try

                    dia = 24
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 28 Then
                Try

                    dia = 25
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 29 Then
                Try

                    dia = 26
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 30 Then
                Try

                    dia = 27
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 31 Then
                Try

                    dia = 28
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 32 Then
                Try

                    dia = 29
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 33 Then
                Try

                    dia = 30
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 34 Then
                Try
                    dia = 31
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
        End With
    End Sub
#End Region

#Region "REMOVER"
    Private Sub cmdRemover_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRemover.Click
        Dim Check As New realizacaoTreinamentos
        Dim id As Integer
        Dim tipo As Integer = 3
        Dim dia As Integer = 0
        With gridFrequencia
            If .ColSel = 3 Then
                Try
                    dia = 1
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 4 Then
                Try
                    dia = 2
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 5 Then
                Try
                    dia = 3
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 6 Then
                Try
                    dia = 4
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 8 Then
                Try
                    dia = 5
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 9 Then
                Try

                    dia = 6
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 10 Then
                Try

                    dia = 7
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 11 Then
                Try

                    dia = 8
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 12 Then
                Try

                    dia = 9
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 13 Then
                Try

                    dia = 10
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 14 Then
                Try

                    dia = 11
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 15 Then
                Try

                    dia = 12
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 16 Then
                Try

                    dia = 13
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 17 Then
                Try

                    dia = 14
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 18 Then
                Try

                    dia = 15
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 19 Then
                Try

                    dia = 16
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 20 Then
                Try

                    dia = 17
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 21 Then
                Try
                    tipo = 1
                    dia = 18
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 22 Then
                Try
                    tipo = 1
                    dia = 19
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 23 Then
                Try
                    tipo = 1
                    dia = 20
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 24 Then
                Try

                    dia = 21
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 25 Then
                Try

                    dia = 22
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 26 Then
                Try

                    dia = 23
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 27 Then
                Try

                    dia = 24
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 28 Then
                Try

                    dia = 25
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 29 Then
                Try

                    dia = 26
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 30 Then
                Try

                    dia = 27
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 31 Then
                Try

                    dia = 28
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 32 Then
                Try

                    dia = 29
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 33 Then
                Try

                    dia = 30
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
            If .ColSel = 34 Then
                Try
                    dia = 31
                    id = gridFrequencia(.RowSel, 1)
                    Check.Update_Frequencia_Dia(id, tipo, dia)
                    carregaListaFreqeuncia()
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
        End With
    End Sub
#End Region

#End Region

#Region "ANEXOS"
    Private Sub botAnexosFrequencia_Click(sender As System.Object, e As System.EventArgs) Handles botAnexosFrequencia.Click
        Try

            'Status
            barra.Value = 10
            lblStatus.Text = "Iniciando Inportação de Arquivo..."

            Dim dlgAnexo As FileDialog = New OpenFileDialog()
            Dim caminho As String = ""
            Dim tipo As String = ""
            Dim arquivo As String()
            Dim descricao As String = ""

            If dlgAnexo.ShowDialog() = Windows.Forms.DialogResult.OK Then
                caminho = dlgAnexo.FileName
                arquivo = Split(caminho, "\")
                picAnexo.ImageLocation = caminho
                descricao = arquivo.GetValue(arquivo.GetUpperBound(0))
                tipo = caminho.Substring(caminho.Length - 3, 3)
            Else
                barra.Value = 0
                barra.ForeColor = Color.Red
                lblStatus.Text = "Nenhum aquivo selecionado!"
                Exit Sub
            End If

            'Status
            barra.Value = 30
            lblStatus.Text = "Tratamento do Arquivo..."

            If Not picAnexo.ImageLocation Is Nothing Then
                Dim infoImg As New FileInfo(picAnexo.ImageLocation)
                Dim tamanho As Long = infoImg.Length
                Dim arqStream As New FileStream(picAnexo.ImageLocation, FileMode.Open, FileAccess.Read)
                ANEXO = New Byte(Convert.ToInt32(tamanho - 1)) {}
                arqStream.Read(ANEXO, 0, tamanho)
            End If

            'Status
            barra.Value = 80
            lblStatus.Text = "Salvando Arquivo..."

            If MessageBox.Show("Tem certeza que deseja Salvar o Anexo selecionado", "ISO é Fácil", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then


                If Manager.Anexos.Add(Modulo, _
                                    idRealizar, _
                                    Tela, _
                                    descricao, _
                                    ANEXO, _
                                    tipo) Then
                    MessageBox.Show("Anexos salvos com sucesso", "ISO é Fácil", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Status
                    barra.Value = 100
                    lblStatus.Text = "Concluido com sucesso!"

                End If

            Else
                barra.Value = 0
                barra.ForeColor = Color.Red
                lblStatus.Text = "Operação Cancelada!"
            End If

        Catch ex As Exception
            lblStatus.Text = "Não foi possivel realizar a operação. Tente novamente." & " ... " & lblStatus.Text
        End Try
    End Sub
#End Region

#Region "EXCLUIR ANEXOS"



#End Region

#End Region

#Region "EFICÁCIA"

#Region "SALVAR"
    Private Sub botSalvarEficiencia_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarEficiencia.Click
        Dim realizacao As New realizacaoTreinamentos
        Dim eficaz As Boolean

        If optAcaoEficazSim.Checked Then
            eficaz = True
        Else
            eficaz = False
        End If

        If isEdit Then
            ' Editar
        Else
            ' Salvar
            If realizacao.AddEficacia(idRealizar, _
                                      cmbResponsavelEficiencia.SelectedValue, _
                                      txtMetodoAnalise.Text, _
                                      txtResultadosObtidos.Text, _
                                      eficaz, _
                                      txtSeNegativo.Text, _
                                      txtOqueFazer.Text, _
                                      dtDataEficacia.Value) Then
                MessageBox.Show("Dados atualizados com sucesso", "Treinamentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region

    ''' <summary>
    ''' Acao Eficacia
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub optAcaoEficazSim_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles optAcaoEficazSim.SelectedIndexChanged
        If optAcaoEficazSim.Checked Then
            txtSeNegativo.Enabled = False
            txtOqueFazer.Enabled = False
        ElseIf optAcaoEficazNao.Checked Then
            txtSeNegativo.Enabled = True
            txtOqueFazer.Enabled = True
        Else
            txtSeNegativo.Enabled = False
            txtOqueFazer.Enabled = False
        End If
    End Sub

#End Region

#Region "CHAMAR O MENU"

    Private Sub gridFrequencia_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles gridFrequencia.MouseUp
        'Chama o Menu quando o mouse estiver em cima do grid
        If e.Button = Windows.Forms.MouseButtons.Right Then

            Menu_01.ShowContextMenu(gridFrequencia, e.Location)

        End If
    End Sub

#End Region

End Class
