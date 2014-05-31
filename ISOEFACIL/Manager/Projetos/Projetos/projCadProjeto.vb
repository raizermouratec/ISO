Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.projCadEquipe
Imports ISOEFACIL.projListaProjetos
Public Class projCadProjeto

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditProjeto As Boolean = False
    Public idprojetos As String
    Public strId As String = String.Empty

    'Pega Id Registro
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

        comboAprovador.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboAprovador.DataSource = dtb
        comboAprovador.DisplayMember = "COLABORADOR"
        comboAprovador.ValueMember = "ID"
    End Sub

#End Region

#Region "APROVADOR"

    Sub CarregaAprov()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES_APROVADOR")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboAprovador.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboAprovador.DataSource = dtb
        comboAprovador.DisplayMember = "COLABORADOR"
        comboAprovador.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub projCadastrar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaResp()
        CarregaAprov()
        comboResp.Text = ""
        comboAprovador.Text = ""
    End Sub

    Private Sub datePrevisaoTermino_LostFocus(sender As Object, e As System.EventArgs) Handles datePrevisaoTermino.LostFocus
        'If datePrevisaoTermino.Value < dateInicioEm.Value Then
        '    MessageBox.Show("Data de Término não pode ser menor que a data de Início", "Projeto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    datePrevisaoTermino.Focus()
        'End If
    End Sub

    Private Sub dateInicioEm_LostFocus(sender As Object, e As System.EventArgs) Handles dateInicioEm.LostFocus
        'If dateInicioEm.Value > datePrevisaoTermino.Value Then
        '    MessageBox.Show("Data de Início não pode ser maior que a data de Termino", "Projeto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    dateInicioEm.Focus()
        'End If
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoProjeto()
        'Cadastrar Novo
        Me.txtRevisao.Text = "00"
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarProjeto(ByVal id As Integer)

        'Editar
        isEdit = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM PROJETOS WHERE ID_PROJETOS = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read
                Me.comboResp.SelectedValue = dr("RESPONSAVEL").ToString
                Me.comboAprovador.SelectedValue = dr("APROVADOR").ToString
                Me.txtTituloProjeto.Text = dr("TITULO").ToString
                Me.txtRevisao.Text = dr("REVISAO").ToString
                Me.txtIdentificacao.Text = dr("IDENTIFICACAO").ToString
                Me.txtTipo.Text = dr("TIPO").ToString
                Me.dateInicioEm.Value = dr("INICIO").ToString
                Me.datePrevisaoTermino.Value = dr("TERMINO").ToString
                Me.dateData.Value = dr("DATA_APROVADOR").ToString
                Me.txtDuracao.Text = dr("DURACAO").ToString
            End While
            'Controle de Revisao
            If MsgBox("Deseja alterar a Revisão?", MsgBoxStyle.YesNo, "Projeto") = MsgBoxResult.Yes Then
                If Me.txtRevisao.Text < 9 Then
                    Me.txtRevisao.Text = Me.txtRevisao.Text + 1
                    Me.txtRevisao.Text = "0" & Me.txtRevisao.Text
                Else
                    Me.txtRevisao.Text = Me.txtRevisao.Text + 1
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "BOTOES"

#Region "SALVAR"

#Region "PROJETO"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        'Cadastra novo Projeto
        Dim projeto As New projeto

        If isEdit Then

            Try

                'Editar Projeto
                VerificarProjeto()
                If projeto.Update(idprojetos, _
                                  comboResp.SelectedValue, _
                                  comboAprovador.SelectedValue, _
                                  txtTituloProjeto.Text, _
                                  txtRevisao.Text, _
                                  txtIdentificacao.Text, _
                                  txtTipo.Text, _
                                  dateInicioEm.Value, _
                                  datePrevisaoTermino.Value, _
                                  dateData.Value, _
                                  txtDuracao.Text) Then
                    projListaProjetos.CarregaListaProjetos()
                    MessageBox.Show("Dados de Projeto atualizados com sucesso", "Projeto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        Else

            Try

                'Salvar Projeto
                VerificarProjeto()
                strId = projeto.Add(comboResp.SelectedValue, _
                                    comboAprovador.SelectedValue, _
                                    txtTituloProjeto.Text, _
                                    txtRevisao.Text, _
                                    txtIdentificacao.Text, _
                                    txtTipo.Text, _
                                    dateInicioEm.Value, _
                                    datePrevisaoTermino.Value, _
                                    dateData.Value, _
                                    txtDuracao.Text)
                If strId <> String.Empty Then
                    projListaProjetos.CarregaListaProjetos()
                    MessageBox.Show("Projeto salvo com sucesso", "Projeto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    botEquipe.Enabled = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub VerificarProjeto()
        'Projeto
        If txtTituloProjeto.Text = "" Then
            MessageBox.Show("O campo Projeto não foi preenchido", "Projeto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTituloProjeto.Focus()
            Exit Sub
        End If
        'Revisão
        If txtRevisao.Text = "" Then
            MessageBox.Show("O campo Revisão não foi preenchido", "Projeto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRevisao.Focus()
            Exit Sub
        End If
        'Identificação
        If txtIdentificacao.Text = "" Then
            MessageBox.Show("O campo Identificação não foi preenchido", "Projeto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtIdentificacao.Focus()
            Exit Sub
        End If
        'Responsável
        If comboResp.Text = "" Then
            MessageBox.Show("O campo Responsável não foi selecionado", "Projeto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResp.Focus()
            Exit Sub
        End If
        'Tipo
        If txtTipo.Text = "" Then
            MessageBox.Show("O campo Tipo não foi preenchido", "Projeto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTipo.Focus()
            Exit Sub
        End If
        'Data de Inicio
        If dateInicioEm.Text = "" Then
            MessageBox.Show("O campo Início em não foi preenchido", "Projeto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateInicioEm.Focus()
            Exit Sub
        End If
        'Previsão de Término
        If datePrevisaoTermino.Text = "" Then
            MessageBox.Show("O campo Previsão de Término não foi preenchido", "Projeto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            datePrevisaoTermino.Focus()
            Exit Sub
        End If
        'Tipo
        If txtDuracao.Text = "" Then
            MessageBox.Show("O campo Duração não foi preenchido", "Projeto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDuracao.Focus()
            Exit Sub
        End If
        'If Not IsNumeric(txtDuracao.Text) Or txtDuracao.Text = "" Then
        '    MessageBox.Show("O campo Duração não foi preenchido, Somente Números", "Projeto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtDuracao.Focus()
        '    Exit Sub
        'End If

    End Sub

#End Region

#End Region

#Region "EQUIPE"

    Private Sub botEquipe_Click(sender As System.Object, e As System.EventArgs) Handles botEquipe.Click

        If projListaProjetos.gridProjetos.RowSel <= 0 Then
            Exit Sub
        Else
            'Novo 
            Dim frm As New projCadEquipe
            Dim id As Integer = 0

            'Passagem de parametros
            Try
                id = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                frm.idprojetos = id
                frm.NovaEquipe()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#End Region

End Class
