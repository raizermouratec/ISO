Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Public Class mgAprovControleManual

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditAprovacao As Boolean = False
    Public verif As Boolean
    Public idaprovacao As String
    Public idAprovControleManuais As String

    'Pega Id Registro
    Public WriteOnly Property Aprovacao() As String
        Set(ByVal value As String)
            Me.idaprovacao = value
        End Set
    End Property

    'Pega Id Registro
    Public WriteOnly Property AprovControleManuais() As String
        Set(ByVal value As String)
            Me.idAprovControleManuais = value
        End Set
    End Property

#End Region

#Region "CARREGAR LISTA APROVAÇÕES DO MG"

    Public Sub CarregaListaAprovacoes()

        'Carrega Lista Aprovadores
        gridListaAprovacao.AutoGenerateColumns = False
        gridListaAprovacao.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_MANUAL_CONTROLE_APROVACAO WHERE ID_MANUAL_CONTROLE = " & idAprovControleManuais)

    End Sub

    Private Sub VerificaRevisao()

        'Mudar Revisão
        Dim rev As Integer = 0
        Dim dr As SqlDataReader
        dr = Manager.Util.getDataReader("SELECT MAX(REVISOES) AS REVISOES FROM VW_LISTAGEM_MANUAL_CONTROLE_APROVACAO WHERE ID_MANUAL_CONTROLE = " & idAprovControleManuais)

        Try
            While dr.Read
                'Verificando 0 valor da última revisão
                'Caso a primeira vez ( verifica se está vazio então a revisão é 00)
                If dr("REVISOES").ToString = String.Empty Then
                    txtRevisao.Text = "00"
                Else
                    'Verificando se a revisão é maior ou igual a zero para somar mais um
                    rev = dr("REVISOES")
                    If rev < 9 Then
                        txtRevisao.Text = rev + 1
                        txtRevisao.Text = "0" & txtRevisao.Text.ToString
                    Else
                        txtRevisao.Text = rev + 1
                    End If
                End If
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "POPULA COMBOS"

#Region "RESPONSAVEL"

    Sub CarregaResp()

        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES_APROVADOR")
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

    Private Sub comboResp_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles comboResp.SelectedValueChanged

        Dim id As Integer = 0

        Try

            If comboResp.SelectedIndex > 0 Then
                id = comboResp.SelectedValue
                CarregaListaCargoById(id)
            Else
                comboCargo.Text = ""
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#Region "CARGO"

    Public Sub CarregaListaCargoById(ByVal id As Integer)

        If id = 0 Then

            comboCargo.Text = ""
            Exit Sub

        Else

            Dim sql As String = String.Format("SELECT CAR.ID_CARGOS, NOME FROM CARGOS CAR " & _
                                         "INNER JOIN COLABORADORES COL " & _
                                         "ON CAR.ID_CARGOS = COL.ID_CARGOS " & _
                                         "WHERE COL.ID_COLABORADORES =  '{0}'", id)

            Try

                comboCargo.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
                comboCargo.DataSource = Manager.Util.getDataTable(sql)
                comboCargo.DisplayMember = "NOME"
                comboCargo.ValueMember = "ID_CARGOS"

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub mgAprovacao_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaListaAprovacoes()
        CarregaResp()
        dateEmissao.Text = ""
        dateAprovacao.Text = ""
        VerificaRevisao()
        gridListaAprovacao.HighLight = HighLightEnum.WithFocus
    End Sub

#End Region

#Region "BOTOES"

#Region "APROVAR"

    Private Sub botAprovar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAprovar.Click

        'Seta a Classe
        Dim aprovacao As New aprovacao

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            VerificarAprovacao()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If aprovacao.Update(idaprovacao, _
                                        idAprovControleManuais, _
                                        comboResp.SelectedValue, _
                                        comboCargo.SelectedValue, _
                                        dateEmissao.Value, _
                                        txtRevisao.Text, _
                                        dateAprovacao.Value) Then
                        CarregaListaAprovacoes()
                        MessageBox.Show("Dados de Aprovação atualizados com sucesso", "Aprovação do Manual de Gestão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else
            'Mudar Revisão
            Dim rev As Integer = 0
            Dim dr As SqlDataReader
            dr = Manager.Util.getDataReader("SELECT MAX(REVISOES) AS REVISOES FROM VW_LISTAGEM_MANUAL_CONTROLE_APROVACAO WHERE ID_MANUAL_CONTROLE = " & idAprovControleManuais)

            While dr.Read
                'Verificando 0 valor da última revisão
                'Caso a primeira vez ( verifica se está vazio então a revisão é 00)
                If dr("REVISOES").ToString = String.Empty Then
                    txtRevisao.Text = "00"
                Else
                    'Verificando se a revisão é maior ou igual a zero para somar mais um
                    rev = dr("REVISOES")
                    If rev < 9 Then
                        txtRevisao.Text = rev + 1
                        txtRevisao.Text = "0" & txtRevisao.Text.ToString
                    Else
                        txtRevisao.Text = rev + 1
                    End If
                End If

            End While

            'Verificar campos obrigatórios
            VerificarAprovacao()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If aprovacao.Add(idAprovControleManuais, _
                                     comboResp.SelectedValue, _
                                     comboCargo.SelectedValue, _
                                     dateEmissao.Value, _
                                     txtRevisao.Text, _
                                     dateAprovacao.Value) Then
                        aprovacao.UpdateRevisao(idAprovControleManuais, txtRevisao.Text)
                        CarregaListaAprovacoes()
                        mgListaControleManual.CarregaLista()
                        'comboResp.Text = ""
                        CarregaResp()
                        comboResp.Text = ""
                        CarregaListaCargoById(0)
                        comboCargo.Text = ""
                        dateEmissao.Text = ""
                        dateAprovacao.Text = ""
                        VerificaRevisao()
                        MessageBox.Show("Aprovação salvo com sucesso", "Aprovação do Manual de Gestão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub VerificarAprovacao()
        verif = False

        'Tratamento de erro Responsável
        If comboResp.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável Obrigatórido", "Aprovação do Manual de Gestão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResp.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Cargo
        If comboCargo.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Cargo Obrigatórido", "Aprovação do Manual de Gestão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboCargo.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data Emissão
        If dateEmissao.Text = "" Then
            MessageBox.Show("Campo Data de Emissão nObrigatórido", "Aprovação do Manual de Gestão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateEmissao.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Revisão
        If Not IsNumeric(txtRevisao.Text) Or txtRevisao.Text = "" Then
            MessageBox.Show("Campo Revisão Obrigatórido, Somente Números", "Aprovação do Manual de Gestão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRevisao.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data Aprovação
        If dateAprovacao.Text = "" Then
            MessageBox.Show("Campo Data de Aprovação Obrigatórido", "Aprovação do Manual de Gestão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateAprovacao.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEdit_Click(sender As System.Object, e As System.EventArgs) Handles botEdit.Click

        If gridListaAprovacao.RowSel <= 0 Then
            Exit Sub
        Else
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridListaAprovacao(gridListaAprovacao.RowSel, 1)
                Aprovacao = id
                EditarAprovacao(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Public Sub EditarAprovacao(ByVal id As Integer)

        'Editar
        isEdit = True

        'Mudando Imagem e Nome do Botão
        botAprovar.Text = "Salvar"
        botAprovar.Image = ImageList.Images.Item(0)

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM MANUAL_CONTROLE_APROVACAO WHERE ID_MANUAL_CONTROLE_APROVACAO = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.comboResp.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.comboResp.Enabled = False
                Me.comboCargo.SelectedValue = dr("ID_CARGOS").ToString
                Me.dateEmissao.Value = dr("DATA_EMISSAO").ToString
                Me.txtRevisao.Text = dr("REVISOES").ToString
                Me.dateAprovacao.Value = dr("DATA_APROVACAO").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.Show()

    End Sub

#End Region

#Region "CANCELAR"

    Private Sub botCancelar_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

#End Region
 
End Class
