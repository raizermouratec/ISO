Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.projPlanodeProjeto
Imports ISOEFACIL.projCadProjeto
Imports ISOEFACIL.projListaProjetos
Public Class projCadEstagiosAtividade

#Region "VARIAVEIS"

    'Delegate criada para atualizar o grid
    Public Delegate Sub CarregaAtividade(info As Integer)
    Public Event OnDataChange As CarregaAtividade

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditEstagiosAtiv As Boolean = False
    Public idestagiosAtiv As String
    Public idprojetos As String

    'Pega Id Estágio_Atividade
    Public WriteOnly Property EstagiosAtiv() As String
        Set(ByVal value As String)
            Me.idestagiosAtiv = value
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

    Sub CarregaRespEstagio()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboEstagioResponsavel.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboEstagioResponsavel.DataSource = dtb
        comboEstagioResponsavel.DisplayMember = "COLABORADOR"
        comboEstagioResponsavel.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub projCadEstagiosAtividade_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaRespEstagio()
        contador()
        txtObservacoes.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

    Private Sub botCancelarEstAtiv_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoEstagioAtiv()
        'Cadastrar Novo
        'Me.txtNumSequencial.Text = "00"
        isEditEstagiosAtiv = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvarEstAtiv_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarEstAtiv.Click

        'Cadastra novo Estágio
        Dim planoprojeto As New planoprojeto

        Dim tipoestagio As Boolean

        tipoestagio = True

        If isEditEstagiosAtiv Then

            Try
                'Editar Estágio
                VerificarEstagios()
                If planoprojeto.UpdateEstagiosAtiv(idestagiosAtiv, _
                                                   comboEstagioResponsavel.SelectedValue, _
                                                   idprojetos, _
                                                   tipoestagio, _
                                                   txtAtividade.Text, _
                                                   txtNumSequencial.Text, _
                                                   dateInicio.Value, _
                                                   dateTermino.Value, _
                                                   txtObservacoes.Text) Then
                    RaiseEvent OnDataChange(idprojetos)
                    MessageBox.Show("Dados de Projeto atualizados com sucesso", "Plano de Projeto - Estágio - Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        Else
            Try
                'Salvar Estágio
                VerificarEstagios()
                If planoprojeto.AddEstagiosAtiv(comboEstagioResponsavel.SelectedValue, _
                                                idprojetos, _
                                                tipoestagio, _
                                                txtAtividade.Text, _
                                                txtNumSequencial.Text, _
                                                dateInicio.Value, _
                                                dateTermino.Value, _
                                                txtObservacoes.Text) Then
                    RaiseEvent OnDataChange(idprojetos)
                    MessageBox.Show("Projeto salvo com sucesso", "Plano de Projeto - Estágio - Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub VerificarEstagios()
        'Atividade
        If txtAtividade.Text = "" Then
            MessageBox.Show("O campo Atividade não foi preenchido", "Plano de Projeto - Estágio - Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAtividade.Focus()
            Exit Sub
        End If
        'Numero Sequencial
        If txtNumSequencial.Text = "" Then
            MessageBox.Show("O campo Número Sequancial não foi preenchido", "Plano de Projeto - Estágio - Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNumSequencial.Focus()
            Exit Sub
        End If
        'Responsável
        If comboEstagioResponsavel.Text = "" Then
            MessageBox.Show("O campo Responsável não foi selecionado", "Plano de Projeto - Estágio - Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboEstagioResponsavel.Focus()
            Exit Sub
        End If
        'Início
        If dateInicio.Text = "" Then
            MessageBox.Show("O campo Início não foi preenchido", "Plano de Projeto - Estágio - Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateInicio.Focus()
            Exit Sub
        End If
        'Término
        If dateTermino.Text = "" Then
            MessageBox.Show("O campo Término não foi preenchido", "Plano de Projeto - Estágio - Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateTermino.Focus()
            Exit Sub
        End If
        'Observações
        If txtObservacoes.Text = "" Then
            MessageBox.Show("O campo Observações não foi preenchido", "Plano de Projeto - Estágio - Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtObservacoes.Focus()
            Exit Sub
        End If

    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarEstagioAtiv(ByVal id As Integer)

        'Editar
        isEditEstagiosAtiv = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM PROJETOS_PLANO_ESTAGIOS_ATIVIDADE WHERE ID_PROJETOS_PLANO_ESTAGIOS_ATIVIDADE = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.comboEstagioResponsavel.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.txtAtividade.Text = dr("ATIVIDADE").ToString
                Me.txtNumSequencial.Text = dr("N_SEQUENCIAL").ToString
                Me.dateInicio.Value = dr("INICIO").ToString
                Me.dateTermino.Value = dr("TERMINO").ToString
                Me.txtObservacoes.Text = dr("OBS").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "CONTADOR"

    Private Sub contador()
        Dim dbCont As New DataTable
        Dim cont As Integer = 1
        Try
            If isEdit Then
                cont = idprojetos
                txtNumSequencial.Text = cont.ToString
            Else
                dbCont = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_PROJETOS_PLANO_ESTAGIOS_ATIVIDADE")
                If dbCont.Rows.Count >= 1 Then
                    cont = cont + dbCont.Rows.Count
                    txtNumSequencial.Text = cont.ToString
                Else
                    txtNumSequencial.Text = cont.ToString
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

End Class
