Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.audProgramacaoAuditorias
Public Class audRealizacaoAuditorias

#Region "VARIÁVEIS"

    Public idAuditoriasRealizar As String
    Public idAuditoriasPlano As String
    Public idAuditoriasRealizacao As String
    Public strMes As String = String.Empty
    Public strSituacao As String = String.Empty
    Public strAno As String = String.Empty
    Private isEdit As Boolean = False
    Public verif As Boolean = False

    'Pega Id
    Public WriteOnly Property Realizacao() As String
        Set(ByVal value As String)
            Me.idAuditoriasRealizacao = value
        End Set
    End Property

    'Pega Id
    Public WriteOnly Property Realizar() As String
        Set(ByVal value As String)
            Me.idAuditoriasRealizar = value
        End Set
    End Property
    Public WriteOnly Property RealizarPlano() As String
        Set(ByVal value As String)
            Me.idAuditoriasPlano = value
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

#Region "CARREGAR LISTA"

    Public Sub carregaItens()

        'Monta o Grid
        gridItem.AutoGenerateColumns = False
        gridItem.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_NORMA_PADRAO")

    End Sub

    Public Sub carregaItensRealiza(ByVal id As Integer)

        'Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_ITEM_NORMA_REALIZA WHERE ID_AUDITORIAS_PLANO = {0} ORDER BY ITEM", id)

        ''Monta o Grid
        'gridItem.AutoGenerateColumns = False
        'gridItem.DataSource = Manager.Util.getDataTable(sql)

        'Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

        'If dr.HasRows = False Then
        '    Exit Sub
        'Else
        '    Dim i As Integer = 1
        '    While dr.Read
        '        gridItem(i, 4) = True
        '        i = i + 1
        '    End While
        'End If

    End Sub

#End Region

#Region "POPULA COMBOS"

#Region "AUDITOR LÍDER"

    Sub CarregaAuditorLider()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT ID_AUDITORES AS ID, NOME = CASE NOME WHEN '' THEN RESP.COLABORADOR ELSE NOME END FROM AUDITORIAS_AUDITORES RG LEFT JOIN dbo.COLABORADORES RESP ON RG.ID_COLABORADORES = RESP.ID_COLABORADORES WHERE CLASSIFICACAO = 1")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboAuditorLider.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboAuditorLider.DataSource = dtb
        comboAuditorLider.DisplayMember = "NOME"
        comboAuditorLider.ValueMember = "ID"
    End Sub

#End Region

#Region "SEGUNDO AUDITOR"

    Sub CarregaSegundoAuditor()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT ID_AUDITORES AS ID, NOME = CASE NOME WHEN '' THEN RESP.COLABORADOR ELSE NOME END FROM AUDITORIAS_AUDITORES RG LEFT JOIN dbo.COLABORADORES RESP ON RG.ID_COLABORADORES = RESP.ID_COLABORADORES WHERE CLASSIFICACAO = 0")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboSegundoAuditor.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboSegundoAuditor.DataSource = dtb
        comboSegundoAuditor.DisplayMember = "NOME"
        comboSegundoAuditor.ValueMember = "ID"

    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub audRealizar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaAuditorLider()
        CarregaSegundoAuditor()
        carregaItens()
        txtComentarioEquipe.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoRealiza(ByVal id As Integer, ByVal mes As String, ByVal sit As String)

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_AUDITORIAS_REALIZAR WHERE PLANO={0} AND MES='{1}' AND SITUACAO='{2}'", id, mes, sit)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read
                Me.txtAreaProcesso.Text = dr("AREA").ToString
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        isEdit = False

        'carregaItensRealiza(id)
        Me.ShowDialog()

    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarAuditoria(ByVal id As Integer)

        'Editar
        isEdit = True

        'Carrega Combo
        CarregaAuditorLider()
        CarregaSegundoAuditor()
        carregaItens()

        'Muda o Label do botão Incluir
        botSalvar.Width = 80
        botSalvar.Text = "Atualizar"

        'Seleciona Fornecedor pelo Id
        Dim sql1 As String = String.Format("SELECT * FROM VW_LISTAGEM_AUDITORIAS_REALIZAR WHERE ID = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr1 As SqlDataReader = Manager.Util.getDataReader(sql1)

            While dr1.Read

                Me.txtAreaProcesso.Text = dr1("AREA").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM AUDITORIAS_REALIZAR_REALIZACAO WHERE ID_AUDITORIAS_REALIZAR_REALIZACAO = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read
                Me.dateData.Value = dr("DATA").ToString
                Me.maskInicio.Text = dr("TEMPO1").ToString
                Me.maskTermino.Text = dr("TEMPO2").ToString
                Me.comboAuditorLider.SelectedValue = dr("AUDITOR_LIDER").ToString
                Me.comboSegundoAuditor.SelectedValue = dr("SEGUNDO_AUDITOR").ToString
                Me.txtComentarioEquipe.Text = dr("COMENTARIOS_EQUIPE").ToString
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

#End Region

#Region "BOTOES"

#Region "SALVAR"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim realizacao As New realizacao

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If realizacao.Update(idAuditoriasRealizacao, _
                                         idAuditoriasRealizar, _
                                         dateData.Value, _
                                         maskInicio.Text, _
                                         maskTermino.Text, _
                                         comboAuditorLider.SelectedValue, _
                                         comboSegundoAuditor.SelectedValue, _
                                         txtComentarioEquipe.Text) Then
                        AtualizarStatus()
                        realizacao.Update(idAuditoriasRealizar, _
                                          comboAuditorLider.SelectedValue, _
                                          maskInicio.Text, _
                                          maskTermino.Text)
                        audRealizarAuditorias.carregaListaDatasAno(strAno)
                        MessageBox.Show("Dados de Auditoria atualizados com sucesso", "Auditorias - Realização", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else
            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If realizacao.Add(idAuditoriasRealizar, _
                                      dateData.Value, _
                                      maskInicio.Text, _
                                      maskTermino.Text, _
                                      comboAuditorLider.SelectedValue, _
                                      comboSegundoAuditor.SelectedValue, _
                                      txtComentarioEquipe.Text) Then
                        AtualizarStatus()
                        realizacao.Update(idAuditoriasRealizar, _
                                          comboAuditorLider.SelectedValue, _
                                          maskInicio.Text, _
                                          maskTermino.Text)
                        audRealizarAuditorias.carregaListaDatasAno(strAno)
                        MessageBox.Show("Auditoria realizada com sucesso", "Auditorias - Realização", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub Verificar()
        verif = False

        'Tratamento de erro Comentários da equipe auditada
        If txtComentarioEquipe.Text = "" Then
            MessageBox.Show("Campo Comentários da Equipe Obrigatório", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtComentarioEquipe.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Auditor Líder
        If comboAuditorLider.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Auditor Líder Obrigatório", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboAuditorLider.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Tipo de Segundo Auditor
        If comboSegundoAuditor.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Segundo Auditor Obrigatório", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboSegundoAuditor.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data
        If dateData.Text = "" Then
            MessageBox.Show("Campo Data Obrigatório", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateData.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

    Public Sub AtualizarStatus()

        Dim classe As New realizacao
        Dim mes As String = strMes
        Dim situacao As String = strSituacao

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_AUDITORIAS_REALIZAR WHERE PLANO={0} AND MES='{1}' AND SITUACAO='{2}'", idAuditoriasPlano, strMes, strSituacao)
        classe.UpdateRealizacaoStatus(idAuditoriasPlano, strMes, strSituacao)

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
        'Situacao
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

        Dim sql2 As String = String.Format("SELECT * FROM VW_LISTAGEM_AUDITORIAS_PLANO_ANUAL WHERE ID = {0} AND {1} = {2}", idAuditoriasPlano, mes, situacao)
        classe.UpdatePlanoStatus(idAuditoriasPlano, mes)

    End Sub

#End Region

#Region "CONFORMIDADE"

    Private Sub botConforme_Click(sender As System.Object, e As System.EventArgs) Handles botConforme.Click

        If gridItem.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma Item selecionada", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            audConformidadeAuditoria.Show()
        End If

    End Sub

#End Region

#Region "NÃO CONFORMIDADE"

    Private Sub botNConforme_Click(sender As System.Object, e As System.EventArgs) Handles botNConforme.Click

        If gridItem.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma Item selecionada", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            audNaoConformidade.Show()
        End If

    End Sub

#End Region

#Region "RELATORIO"

    Private Sub botRelatorio_Click(sender As System.Object, e As System.EventArgs) Handles botRelatorio.Click

        If gridItem.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma Item selecionada", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

        End If

    End Sub

#End Region

#End Region

#Region "GRID ITEM CHECK"

#Region "MARCAR TODOS"

    Private Sub radioTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radioTodos.CheckedChanged
        Dim ch As New checkList
        If radioTodos.Checked Then
            ch.UpdateTudo(1)
            SelectAllChecks()
        Else
            ch.UpdateTudo(0)
            LimpaAllChecks()
        End If
    End Sub

    Private Sub gridItem_Click(sender As System.Object, e As System.EventArgs) Handles gridItem.Click
        With gridItem
            If .ColSel = 4 Then
                Dim Check As New planoAnualAuditoria
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
                    id = gridItem(gridItem.RowSel, 2)
                    Check.UpdateMultiplo(id, Aprovado)
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
        End With
    End Sub

    Public Sub LimpaAllChecks()
        With gridItem
            .Item(.RowSel, .ColSel) = False
        End With
    End Sub
    Public Sub SelectAllChecks()
        With gridItem
            .Item(.RowSel, .ColSel) = True
        End With
    End Sub

#End Region

#End Region

End Class
