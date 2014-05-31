Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ISOEFACIL.acListaDados
Public Class acCadAnaliseDados

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditarAnaliseDados As Boolean = False
    Public idAnaliseDados As String
    Public verif As Integer
    Public tipo_identificacao As Integer = 0
    Public verificar As Boolean = False

    'Pega Id Registro
    Public WriteOnly Property Dados() As String
        Set(ByVal value As String)
            Me.idAnaliseDados = value
        End Set
    End Property

#End Region

#Region "CARREGA CONTEUDO"

    Public Sub CarregaConteudo()

        'Carrega Lista Conteudo
        gridConteudo.AutoGenerateColumns = False
        gridConteudo.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_ANALISE_CRITICA_DADOS_RESULTADO")

    End Sub

#End Region

#Region "POPULA COMBOS"

#Region "REGISTRO DADOS"

#Region "RESPONSAVEL"

    Sub CarregaResp()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboResp.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboResp.DataSource = dtb
        comboResp.DisplayMember = "COLABORADOR"
        comboResp.ValueMember = "ID"
    End Sub

#End Region

#End Region

#End Region

#Region "LOAD"

    Private Sub acAnaliseDados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tabregistro.Show()
        CarregaResp()
        CarregaConteudo()
        Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        txtObejtivos.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")

    End Sub

    Private Sub radioData_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioData.SelectedIndexChanged
        'obtém o data e hora atual.
        Dim agora As DateTime = DateTime.Now

        'obtém o ano.
        Dim anoatual As Integer = agora.Year
        Dim dbCont As New DataTable

        Try
            If radioData.Checked = True Then
                Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                Me.txtOutro.Enabled = False
                Dim strSql As String = String.Format("select max(IDENTIFICACAO) AS  IDENTIFICACAO from ANALISE_CRITICA_DADOS where tipo_identificacao = 1")
                dbCont = Manager.Util.getDataTable(strSql)

                'If dbCont.Rows.Count > 0 Then
                If Not dbCont Is Nothing Then
                    Dim dr As SqlDataReader = Manager.Util.getDataReader(strSql)
                    While dr.Read
                        Me.txtOutro.Text = dr("IDENTIFICACAO").ToString.Substring(0, 2)
                        If Me.txtOutro.Text < 9 Then
                            Me.txtOutro.Text = "0" & Me.txtOutro.Text + 1 & "/" & anoatual
                        Else
                            Me.txtOutro.Text = Me.txtOutro.Text + 1 & "/" & anoatual
                        End If

                    End While
                Else
                    Me.txtOutro.Text = "01" & "/" & anoatual
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub radioRelatorio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioRelatorio.SelectedIndexChanged

        Dim dbCont As New DataTable

        Try
            If radioRelatorio.Checked = True Then
                Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                Me.txtOutro.Enabled = False
                Dim strSql As String = String.Format("select max(IDENTIFICACAO) AS  IDENTIFICACAO from ANALISE_CRITICA_DADOS where tipo_identificacao = 2")
                dbCont = Manager.Util.getDataTable(strSql)

                If dbCont.Rows.Count > 0 Then
                    Dim dr As SqlDataReader = Manager.Util.getDataReader(strSql)
                    While dr.Read
                        Me.txtOutro.Text = dr("IDENTIFICACAO").ToString.Substring(11, 1)
                        If Me.txtOutro.Text < 9 Then
                            Me.txtOutro.Text = "Relatório 0" & Me.txtOutro.Text + 1
                        Else
                            Me.txtOutro.Text = "Relatório " & Me.txtOutro.Text + 1
                        End If
                    End While
                Else
                    Me.txtOutro.Text = "Relatório 01"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub radioOutro_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioOutro.SelectedIndexChanged

        If radioOutro.Checked = True Then
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.txtOutro.Enabled = True
            Me.txtOutro.Text = ""
        End If

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovaAnaliseDados()
        'Cadastrar Novo
        'Me.txtOutro.Text = "00"
        tabconteudo.Enabled = False
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarAnaliseDados(ByVal id As Integer)

        'Editar
        isEdit = True

        'Carrega Combos
        CarregaResp()
        CarregaConteudo()
        tabconteudo.Enabled = True

        'Muda o Label do botão Incluir
        botSalvar.Width = 80
        botSalvar.Text = "Atualizar"

        'Seleciona pelo Id
        Dim sql As String = String.Format("SELECT * FROM ANALISE_CRITICA_DADOS WHERE ID_ANALISE_CRITICA_DADOS = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                If dr("TIPO_IDENTIFICACAO") = 1 Then
                    radioData.Checked = True
                    Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                    Me.txtOutro.Enabled = False
                ElseIf dr("TIPO_IDENTIFICACAO") = 2 Then
                    radioRelatorio.Checked = True
                    Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                    Me.txtOutro.Enabled = False
                ElseIf dr("TIPO_IDENTIFICACAO") = 3 Then
                    radioOutro.Checked = True
                    Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                    Me.txtOutro.Enabled = True
                End If
                Me.txtOutro.Text = dr("IDENTIFICACAO").ToString
                Me.txtObejtivos.Text = dr("OBJETIVOS").ToString
                Me.dateInicio.Value = dr("PERIODO_REF1").ToString
                Me.dateTermino.Value = dr("PERIODO_REF2").ToString
                Me.comboResp.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.dateElab.Value = dr("DATA_ELABORACAO").ToString
                Me.dateAnalisadoem.Value = dr("DATA_ANALISE").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

#End Region

#Region "BOTOES"

#Region "SALVAR REGISTRO"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim dados As New dados
        verif = 0

        'Verificando valor de Identificação de Relatório
        tipo_identificacao = 0
        If radioData.Checked = True Then
            'nº/Ano
            tipo_identificacao = 1

        ElseIf radioRelatorio.Checked = True Then
            'Relatório nº
            tipo_identificacao = 2

        ElseIf radioOutro.Checked = True Then
            'Outros
            tipo_identificacao = 3

        End If

        If isEdit Then

            'Verificar campos obrigatórios
            VerificarAnaliseDados()
            'Checando se campos obrigatórios estão OK
            If verificar = False Then
                Try
                    'Atualizar
                    If dados.Update(idAnaliseDados, _
                                    comboResp.SelectedValue, _
                                    tipo_identificacao, _
                                    txtOutro.Text, _
                                    txtObejtivos.Text, _
                                    dateInicio.Value, _
                                    dateTermino.Value, _
                                    dateElab.Value, _
                                    dateAnalisadoem.Value) Then
                        acListaDados.CarregaDados()
                        MessageBox.Show("Dados da Análise atualizados com sucesso", "Análise de Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            'Verificar campos obrigatórios
            VerificarAnaliseDados()
            'Checando se campos obrigatórios estão OK
            If verificar = False Then
                Try
                    'Salvar
                    If dados.Add(comboResp.SelectedValue, _
                                 tipo_identificacao, _
                                 txtOutro.Text, _
                                 txtObejtivos.Text, _
                                 dateInicio.Value, _
                                 dateTermino.Value, _
                                 dateElab.Value, _
                                 dateAnalisadoem.Value) Then
                        acListaDados.CarregaDados()
                        MessageBox.Show("Análise de Dados salva com sucesso", "Análise de Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        tabconteudo.Enabled = True
                        tabconteudo.Show()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If
    End Sub

    Private Sub VerificarAnaliseDados()
        verificar = False

        'Tratamento de erro Opção de Identificação
        If radioData.Checked And radioRelatorio.Checked And radioOutro.Checked = False Then
            MessageBox.Show("Campo Identificação Obrigatório", "Análise de Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verificar = True
            Exit Sub
        End If
        'Tratamento de erro Objetivos
        If txtObejtivos.Text = "" Then
            MessageBox.Show("Campo Objetivos não foi preenchido", "Análise de Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtObejtivos.Focus()
            Exit Sub
        End If
        'Tratamento de erro Responsável
        If comboResp.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável Obrigatório", "Análise de Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResp.Focus()
            verificar = True
            Exit Sub
        End If
        'Tratamento de erro Data de Inicio
        If dateInicio.Text = "" Then
            MessageBox.Show("Campo Período de Referência - Início Obrigatório", "Análise de Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateInicio.Focus()
            verificar = True
            Exit Sub
        End If
        'Tratamento de erro Data de Termino
        If dateTermino.Text = "" Then
            MessageBox.Show("Campo Período de Referência - Término Obrigatório", "Análise de Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateTermino.Focus()
            verificar = True
            Exit Sub
        End If
        'Tratamento de erro Data de Elaboração
        If dateElab.Text = "" Then
            MessageBox.Show("Campo Data de Elaboração não foi preenchido", "Análise de Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateElab.Focus()
            Exit Sub
        End If
        'Tratamento de erro Analisado Em
        If dateAnalisadoem.Text = "" Then
            MessageBox.Show("Campo Analisado em não foi preenchido", "Análise de Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateAnalisadoem.Focus()
            Exit Sub
        End If

    End Sub

#End Region

#Region "ADICIONAR"

    Private Sub botAdicionar_Click(sender As System.Object, e As System.EventArgs) Handles botAdicionar.Click
        acListaItens.Show()
    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click
        If gridConteudo.RowSel < 0 Then
            MessageBox.Show("Não à nenhum item selecionado", "Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            acResultado.Show()
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluirConteudo_Click(sender As System.Object, e As System.EventArgs) Handles botExcluirConteudo.Click

        Dim conteudo As New resultado

        If gridConteudo.RowSel < 0 Then
            MessageBox.Show("Não à nenhum item selecionado", "Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            'Excluir o Registro
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Dados", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    conteudo.Delete(gridConteudo(gridConteudo.RowSel, 1))
                    CarregaConteudo()
                    MessageBox.Show("Registro excluído com sucesso", "Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If
    End Sub

#End Region

#End Region

End Class
