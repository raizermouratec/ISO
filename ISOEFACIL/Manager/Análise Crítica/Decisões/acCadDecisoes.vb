Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ISOEFACIL.acListaDecisoes
Public Class acCadDecisoes

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditarDecisoes As Boolean = False
    Public verif As Boolean = False
    Public idDecisoes As String
    Private situacao As Integer
    Private numero As String

    'Pega Id Registro
    Public WriteOnly Property Registro() As String
        Set(ByVal value As String)
            Me.idDecisoes = value
        End Set
    End Property

#End Region

#Region "POPULA COMBOS"

#Region "RESPONSAVEL"

    Sub CarregaResp()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboResponsavel.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboResponsavel.DataSource = dtb
        comboResponsavel.DisplayMember = "COLABORADOR"
        comboResponsavel.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub acDecisoes_Load_(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaResp()
        contador()
        txtDetalhamento.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtResultados.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

    Private Sub comboSituacao_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles comboSituacao.SelectedIndexChanged

        Try
            'VALOR DO COMBO NO COLLECTION
            If comboSituacao.SelectedIndex = 0 Then
                'Concluído
                situacao = 1
            ElseIf comboSituacao.SelectedIndex = 1 Then
                'Em Desenvolvimento
                situacao = 2
            ElseIf comboSituacao.SelectedIndex = 2 Then
                'Cancelado
                situacao = 3
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovaDecisao()
        'Cadastrar Novo
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarDecisoes(ByVal id As Integer)

        'Editar
        isEdit = True

        'Carrega Combo
        CarregaResp()

        'Muda o Label do botão Incluir
        botSalvarDecisoes.Width = 80
        botSalvarDecisoes.Text = "Atualizar"

        'Seleciona pelo Id
        Dim sql As String = String.Format("SELECT * FROM ANALISE_CRITICA_DECISOES WHERE ID_ANALISE_CRITICA_DECISOES = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.numero = dr("NUMERO").ToString
                Me.txtDecisao.Text = dr("DECISAO").ToString
                Me.txtDetalhamento.Text = dr("DETALHAMENTO").ToString
                If dr("SITUACAO") = 1 Then
                    'Concluído
                    comboSituacao.SelectedIndex = 0
                ElseIf dr("SITUACAO") = 2 Then
                    'Em Desenvolvimento
                    comboSituacao.SelectedIndex = 1
                ElseIf dr("SITUACAO") = 3 Then
                    'Cancelado
                    comboSituacao.SelectedIndex = 2
                End If
                Me.dateDataReuniao.Value = dr("DATA_REUNIAO").ToString
                Me.datePrazo.Value = dr("PRAZO").ToString
                Me.txtResultados.Text = dr("RESULTADO").ToString
                Me.comboResponsavel.SelectedValue = dr("ID_COLABORADORES").ToString

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

    Private Sub botSalvarDecisoes_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarDecisoes.Click

        'Seta a Classe
        Dim decisoes As New decisoes

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            VerificarDecisoes()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If decisoes.Update(idDecisoes, _
                                    comboResponsavel.SelectedValue, _
                                    numero, _
                                    txtDecisao.Text, _
                                    txtDetalhamento.Text, _
                                    situacao, _
                                    dateDataReuniao.Value, _
                                    datePrazo.Value, _
                                    txtResultados.Text) Then
                        VerificarDecisoes()
                        acListaDecisoes.CarregaDecisoes()
                        MessageBox.Show("Dados da Decisão atualizados com sucesso", "Decisões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            VerificarDecisoes()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If decisoes.Add(comboResponsavel.SelectedValue, _
                                    numero, _
                                    txtDecisao.Text, _
                                    txtDetalhamento.Text, _
                                    situacao, _
                                    dateDataReuniao.Value, _
                                    datePrazo.Value, _
                                    txtResultados.Text) Then
                        acListaDecisoes.CarregaDecisoes()
                        MessageBox.Show("Decisão salva com sucesso", "Decisões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub VerificarDecisoes()
        verif = False

        'Tratamento de erro Objetivos
        If txtDecisao.Text = "" Then
            MessageBox.Show("Campo Decisão Obrigatório", "Decisões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDecisao.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Situação
        If comboSituacao.Text = "" Then
            MessageBox.Show("Campo Situação Obrigatório", "Decisões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboSituacao.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data da Reunião
        If dateDataReuniao.Text = "" Then
            MessageBox.Show("Campo Data da Reunião Obrigatório", "Decisões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateDataReuniao.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Responsável
        If comboResponsavel.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável Obrigatório", "Decisões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResponsavel.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data Prazo
        If datePrazo.Text = "" Then
            MessageBox.Show("Campo Data de Prazo Obrigatório", "Decisões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            datePrazo.Focus()
            verif = True
            Exit Sub
        End If
        ''Tratamento de erro Resultados
        'If txtResultados.Text = "" Then
        '    MessageBox.Show("Campo Resultados não foi preenchido", "Decisões", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtResultados.Focus()
        '    Exit Sub
        'End If

    End Sub

#End Region

#End Region

#Region "CONTADOR CODIGO"

    Private Sub contador()
        Dim dbCont As New DataTable
        Dim cont As Integer = 1
        Dim Ano As DateTime = DateTime.Now

        Try
            If isEdit Then
                cont = idDecisoes
                numero = cont.ToString & "/" & Ano.Year
            Else
                dbCont = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_ANALISE_CRITICA_DECISOES")
                If dbCont.Rows.Count >= 1 Then
                    cont = cont + dbCont.Rows.Count
                    numero = cont.ToString & "/" & Ano.Year
                Else
                    numero = cont.ToString & "/" & Ano.Year
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class
