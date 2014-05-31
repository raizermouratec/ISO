Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.projPlanodeProjeto
Public Class projCadRevisoes

#Region "VARIAVEIS"

    'Delegate criada para atualizar o grid
    Public Delegate Sub CarregaRevisao(info As Integer)
    Public Event OnDataChange As CarregaRevisao

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditRevisao As Boolean = False
    Public idrevisoes As String
    Public idprojetos As String
    Public tipo As Integer

    'Pega Id Revisão
    Public WriteOnly Property Revisao() As String
        Set(ByVal value As String)
            Me.idrevisoes = value
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

    'Sub CarregaResp()
    '    comboRespRevisao.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
    '    comboRespRevisao.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
    '    comboRespRevisao.DisplayMember = "COLABORADOR"
    '    comboRespRevisao.ValueMember = "ID"
    'End Sub

    Sub CarregaResp()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboRespRevisao.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboRespRevisao.DataSource = dtb
        comboRespRevisao.DisplayMember = "COLABORADOR"
        comboRespRevisao.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub projCadRevisoes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaResp()
        txtAlteracao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

    Private Sub comboTipo_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles comboTipo.SelectedIndexChanged

        'Combo de Revisoes
        Try
            'VALOR DO COMBO NO COLLECTION
            If comboTipo.SelectedIndex = 0 Then
                'Objetivos
                tipo = 1

            ElseIf comboTipo.SelectedIndex = 1 Then
                'Escopo
                tipo = 2

            ElseIf comboTipo.SelectedIndex = 2 Then
                'Saídas
                tipo = 3

            ElseIf comboTipo.SelectedIndex = 3 Then
                'Estágios
                tipo = 4

            ElseIf comboTipo.SelectedIndex = 4 Then
                'Recursos
                tipo = 5

            ElseIf comboTipo.SelectedIndex = 5 Then
                'Controle
                tipo = 6

            ElseIf comboTipo.SelectedIndex = 6 Then
                'Risco
                tipo = 7
            End If

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovaRevisao()
        'Cadastrar Novo
        isEditRevisao = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvarRevisoes_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarRevisoes.Click

        'Cadastra nova Revisão
        Dim planoprojeto As New planoprojeto

        If isEditRevisao Then

            Try

                'Editar Revisões
                VerificarRevisao()
                If planoprojeto.UpdateRevisoes(idrevisoes, _
                                               comboRespRevisao.SelectedValue, _
                                               idprojetos, _
                                               tipo, _
                                               txtRevisao.Text, _
                                               txtAlteracao.Text, _
                                               dateData.Value) Then
                    RaiseEvent OnDataChange(idprojetos)
                    MessageBox.Show("Dados de Revisão atualizados com sucesso", "Plano de Projeto - Revisão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        Else

            Try

                'Salvar Revisões
                VerificarRevisao()
                If planoprojeto.AddRevisoes(comboRespRevisao.SelectedValue, _
                                            idprojetos, _
                                            tipo, _
                                            txtRevisao.Text, _
                                            txtAlteracao.Text, _
                                            dateData.Value) Then
                    RaiseEvent OnDataChange(idprojetos)
                    MessageBox.Show("Revisão salva com sucesso", "Plano de Projeto - Revisão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub VerificarRevisao()

        'Aba
        If comboTipo.Text = "" Then
            MessageBox.Show("O campo Aba não foi selecionado", "Plano de Projeto - Revisão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboTipo.Focus()
            Exit Sub
        End If
        'Revisão
        If Not IsNumeric(txtRevisao.Text) Or txtRevisao.Text = "" Then
            MessageBox.Show("O campo Revisão não foi preenchido, Somente Números", "Plano de Projeto  - Revisão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRevisao.Focus()
            Exit Sub
        End If
        'Alteração
        If txtAlteracao.Text = "" Then
            MessageBox.Show("O campo Alteração em não foi preenchido", "Plano de Projeto - Revisão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAlteracao.Focus()
            Exit Sub
        End If
        'Responsável
        If comboRespRevisao.Text = "" Then
            MessageBox.Show("O campo Forma de avaliação não foi selecionado", "Plano de Projeto - Revisão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboRespRevisao.Focus()
            Exit Sub
        End If
        'Data
        If dateData.Text = "" Then
            MessageBox.Show("O campo Data não foi preenchido", "Plano de Projeto - Revisão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateData.Focus()
            Exit Sub
        End If

    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarRevisao(ByVal id As Integer)

        'Editar
        isEditRevisao = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona pelo Id
        Dim sql As String = String.Format("SELECT * FROM PROJETOS_PLANO_REVISOES WHERE ID_PROJETOS_PLANO_REVISOES = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                If dr("TIPO") = 1 Then
                    'Objetivos
                    comboTipo.SelectedIndex = 0
                ElseIf dr("TIPO") = 2 Then
                    'Escopo
                    comboTipo.SelectedIndex = 1
                ElseIf dr("TIPO") = 3 Then
                    'Saídas
                    comboTipo.SelectedIndex = 2
                ElseIf dr("TIPO") = 4 Then
                    'Estágios
                    comboTipo.SelectedIndex = 3
                ElseIf dr("TIPO") = 5 Then
                    'Recursos
                    comboTipo.SelectedIndex = 4
                ElseIf dr("TIPO") = 6 Then
                    'Controle
                    comboTipo.SelectedIndex = 5
                ElseIf dr("TIPO") = 7 Then
                    'Risco
                    comboTipo.SelectedIndex = 6
                End If
                Me.txtRevisao.Text = dr("REVISAO").ToString
                Me.txtAlteracao.Text = dr("ALTERACAO").ToString
                Me.comboRespRevisao.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.dateData.Value = dr("DATA").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        projPlanodeProjeto.CarregaRevisao(idprojetos)

    End Sub

#End Region

End Class
