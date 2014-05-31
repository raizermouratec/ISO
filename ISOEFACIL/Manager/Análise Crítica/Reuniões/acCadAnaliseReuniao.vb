Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ISOEFACIL.acListaReuniao
Public Class acCadAnaliseReuniao

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditarAnaliseReunioes As Boolean = False
    Public idAnaliseReunioes As String
    Public verif As Boolean = False

    'Pega Id Registro
    Public WriteOnly Property Registro() As String
        Set(ByVal value As String)
            Me.idAnaliseReunioes = value
        End Set
    End Property

#End Region

#Region "POPULA COMBOS"

#Region "REGISTRO REUNIOES"

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

    Private Sub acAnaliseReuniao_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaResp()
        txtReuniao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovaAnaliseReunioes()
        'Cadastrar Novo
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarAnaliseReunioes(ByVal id As Integer)

        'Editar
        isEdit = True

        'Carrega Combos
        CarregaResp()

        'Muda o Label do botão Incluir
        botSalvarAnalise.Width = 80
        botSalvarAnalise.Text = "Atualizar"

        'Seleciona pelo Id
        Dim sql As String = String.Format("SELECT * FROM ANALISE_CRITICA_REUNIOES WHERE ID_ANALISE_CRITICA_REUNIOES = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtReuniao.Text = dr("REUNIOES").ToString
                If dr("TIPO") = True Then
                    Me.radioExtraordinaria.Checked = True
                Else
                    Me.radioOrdinaria.Checked = True
                End If
                Me.dateReuniao.Value = dr("DATA").ToString
                Me.comboResp.SelectedValue = dr("ID_COLABORADORES").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvarAnalise_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarAnalise.Click

        'Seta a Classe
        Dim reuniao As New reuniao

        'Verificando valor de Tipo de Reunião
        Dim achou As Boolean
        If radioExtraordinaria.Checked = True Then
            achou = True
        Else
            achou = False
        End If

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            VerificarReuniao()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If reuniao.Update(idAnaliseReunioes, _
                                      comboResp.SelectedValue, _
                                      txtReuniao.Text,
                                      achou, _
                                      dateReuniao.Value) Then
                        acListaReuniao.CarregaReunioes()
                        MessageBox.Show("Dados de Reunião atualizados com sucesso", "Reunião", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            VerificarReuniao()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If reuniao.Add(comboResp.SelectedValue, _
                                   txtReuniao.Text, _
                                   achou, _
                                   dateReuniao.Value) Then
                        acListaReuniao.CarregaReunioes()
                        MessageBox.Show("Dados de Reunião salvos com sucesso", "Reunião", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub VerificarReuniao()
        verif = False

        'Tratamento de erro Reunião
        If txtReuniao.Text = "" Then
            MessageBox.Show("Campo Reunião Obrigatório", "Reunião", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtReuniao.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Responsável
        If comboResp.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável Obrigatório", "Reunião", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResp.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Tipo de Reunião
        If radioOrdinaria.Checked = False And radioExtraordinaria.Checked = False Then
            MessageBox.Show("Campo Tipo de Reunião Obrigatório", "Reunião", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            radioOrdinaria.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data da Reunião
        If dateReuniao.Text = "" Then
            MessageBox.Show("Campo Data da Reunião Obrigatório", "Reunião", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateReuniao.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

End Class
