Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.projPlanodeProjeto
Public Class projCadRisco

#Region "VARIAVEIS"

    'Delegate criada para atualizar o grid
    Public Delegate Sub CarregaRisco(info As Integer)
    Public Event OnDataChange As CarregaRisco

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditRisco As Boolean = False
    Public idrisco As String
    Public idprojetos As String
    Dim P As Integer
    Dim S As Integer

    'Pega Id Risco
    Public WriteOnly Property Risco() As String
        Set(ByVal value As String)
            Me.idrisco = value
        End Set
    End Property

    'Pega Id Objetivos Estruturado
    Public WriteOnly Property Projetos() As String
        Set(ByVal value As String)
            Me.idprojetos = value
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

        comboResp.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboResp.DataSource = dtb
        comboResp.DisplayMember = "COLABORADOR"
        comboResp.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub projCadRisco_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaResp()
        txtDesc.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtImpacto.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtConsequencias.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtAcaoTomada.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtAcompanhamento.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")

    End Sub

    Private Sub botCancelarRisco_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub comboProbabilidade_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles comboProbabilidade.SelectedIndexChanged

        Try
            'VALOR DO COMBO NO COLLECTION
            If comboProbabilidade.SelectedIndex = 0 Then

                P = 1

            ElseIf comboProbabilidade.SelectedIndex = 1 Then

                P = 2

            ElseIf comboProbabilidade.SelectedIndex = 2 Then

                P = 3

            ElseIf comboProbabilidade.SelectedIndex = 3 Then

                P = 4

            ElseIf comboProbabilidade.SelectedIndex = 4 Then

                P = 5
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub comboSeveridade_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles comboSeveridade.SelectedIndexChanged

        Try
            'VALOR DO COMBO NO COLLECTION
            If comboSeveridade.SelectedIndex = 0 Then

                S = 1

            ElseIf comboSeveridade.SelectedIndex = 1 Then

                S = 2

            ElseIf comboSeveridade.SelectedIndex = 2 Then

                S = 3

            ElseIf comboSeveridade.SelectedIndex = 3 Then

                S = 4

            ElseIf comboSeveridade.SelectedIndex = 4 Then

                S = 5

            End If

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoRisco()
        'Cadastrar Novo
        isEditRisco = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvarRisco_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarRisco.Click

        'Cadastra novo Risco
        Dim planoprojeto As New planoprojeto
        Dim Grau As Integer
        Dim Classe As Integer

        'Grau
        Grau = P * S

        'Classe
        If Grau >= 12 Then
            'Alto
            Classe = 1
        ElseIf Grau >= 5 And Grau < 12 Then
            'Médio
            Classe = 2
        ElseIf Grau <= 4 Then
            'Baixo
            Classe = 3
        End If

        If isEditRisco Then

            Try

                'Editar Risco
                VerificarRisco()
                If planoprojeto.UpdateRisco(idrisco, _
                                            comboResp.SelectedValue, _
                                            idprojetos, _
                                            txtDesc.Text, _
                                            txtImpacto.Text, _
                                            txtConsequencias.Text, _
                                            comboProbabilidade.SelectedIndex, _
                                            comboSeveridade.SelectedIndex, _
                                            Grau, _
                                            Classe, _
                                            txtAcaoTomada.Text, _
                                            datePrazo.Value, _
                                            txtAcompanhamento.Text) Then
                    RaiseEvent OnDataChange(idprojetos)
                    MessageBox.Show("Dados de Risco atualizados com sucesso", "Plano de Projeto - Risco", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        Else

            Try

                'Salvar Risco
                VerificarRisco()
                If planoprojeto.AddRisco(comboResp.SelectedValue, _
                                         idprojetos, _
                                         txtDesc.Text, _
                                         txtImpacto.Text, _
                                         txtConsequencias.Text, _
                                         comboProbabilidade.SelectedIndex, _
                                         comboSeveridade.SelectedIndex, _
                                         Grau, _
                                         Classe, _
                                         txtAcaoTomada.Text, _
                                         datePrazo.Value, _
                                         txtAcompanhamento.Text) Then
                    RaiseEvent OnDataChange(idprojetos)
                    MessageBox.Show("Risco salvo com sucesso", "Plano de Projeto - Risco", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub VerificarRisco()
        'Descrição
        If txtDesc.Text = "" Then
            MessageBox.Show("O campo Descrição não foi preenchido", "Plano de Projeto - Risco", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDesc.Focus()
            Exit Sub
        End If
        'Impacto
        If txtImpacto.Text = "" Then
            MessageBox.Show("O campo Impacto não foi preenchido", "Plano de Projeto - Risco", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtImpacto.Focus()
            Exit Sub
        End If
        'Consequências
        If txtConsequencias.Text = "" Then
            MessageBox.Show("O campo Consequências não foi preenchido", "Plano de Projeto - Risco", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtConsequencias.Focus()
            Exit Sub
        End If
        'Probabilidade
        If comboProbabilidade.SelectedIndex = -1 Then
            MessageBox.Show("O campo Probabilidade não foi selecionado", "Plano de Projeto - Risco", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboProbabilidade.Focus()
            Exit Sub
        End If
        'Severidade
        If comboSeveridade.SelectedIndex = -1 Then
            MessageBox.Show("O campo Severidade não foi selecionado", "Plano de Projeto - Risco", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboSeveridade.Focus()
            Exit Sub
        End If
        'Ação a ser tomada
        If txtAcaoTomada.Text = "" Then
            MessageBox.Show("O campo Ação a ser tomada não foi preenchido", "Plano de Projeto - Risco", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAcaoTomada.Focus()
            Exit Sub
        End If
        'Prazo
        If datePrazo.Text = "" Then
            MessageBox.Show("O campo Prazo não foi preenchido", "Plano de Projeto - Risco", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            datePrazo.Focus()
            Exit Sub
        End If
        'Acompanhamento
        If txtAcompanhamento.Text = "" Then
            MessageBox.Show("O campo Acompanhamento não foi preenchido", "Plano de Projeto - Risco", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAcompanhamento.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarRisco(ByVal id As Integer)

        'Editar
        isEditRisco = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM PROJETOS_PLANO_RISCO WHERE ID_PROJETOS_PLANO_RISCO = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.comboResp.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.txtDesc.Text = dr("DESCRICAO").ToString
                Me.txtImpacto.Text = dr("IMPACTO").ToString
                Me.txtConsequencias.Text = dr("CONSEQUENCIAS").ToString
                If dr("P") = 0 Then
                    Me.comboProbabilidade.SelectedIndex = 0
                ElseIf dr("P") = 1 Then
                    Me.comboProbabilidade.SelectedIndex = 1
                ElseIf dr("P") = 2 Then
                    Me.comboProbabilidade.SelectedIndex = 2
                ElseIf dr("P") = 3 Then
                    Me.comboProbabilidade.SelectedIndex = 3
                ElseIf dr("P") = 4 Then
                    Me.comboProbabilidade.SelectedIndex = 4
                End If
                If dr("S") = 0 Then
                    Me.comboSeveridade.SelectedIndex = 0
                ElseIf dr("S") = 1 Then
                    Me.comboSeveridade.SelectedIndex = 1
                ElseIf dr("S") = 2 Then
                    Me.comboSeveridade.SelectedIndex = 2
                ElseIf dr("S") = 3 Then
                    Me.comboSeveridade.SelectedIndex = 3
                ElseIf dr("S") = 4 Then
                    Me.comboSeveridade.SelectedIndex = 4
                End If
                Me.txtAcaoTomada.Text = dr("ACAO").ToString
                Me.datePrazo.Value = dr("PRAZO").ToString
                Me.txtAcompanhamento.Text = dr("ACOMPANHAMENTO").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        projPlanodeProjeto.CarregaRisco(idprojetos)

    End Sub

#End Region

End Class
