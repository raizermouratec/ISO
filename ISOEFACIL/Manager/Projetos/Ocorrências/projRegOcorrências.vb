Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.projListaOcorrencias
Public Class projRegOcorrências

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditregistro As Boolean = False
    Public idocorrencias As String

    'Pega Id Registro
    Public WriteOnly Property Ocorrencias() As String
        Set(ByVal value As String)
            Me.idocorrencias = value
        End Set
    End Property

#End Region

#Region "POPULA COMBOS"

#Region "RESPONSAVEL"

    Sub CarregaResp()
        comboResp.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboResp.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        comboResp.DisplayMember = "COLABORADOR"
        comboResp.ValueMember = "ID"
        comboResp.Text = ""
    End Sub

#End Region

#Region "PROJETOS"

    Sub CarregaTipoProjeto()
        comboTipoProjeto.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboTipoProjeto.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_PROJETOS")
        comboTipoProjeto.DisplayMember = "TITULO"
        comboTipoProjeto.ValueMember = "ID"
        comboTipoProjeto.Text = ""
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub projRegOcorrências_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaTipoProjeto()
        CarregaResp()
        txtDescOcorrencia.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovaOcorrencia()
        'Cadastrar Novo
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarOcorrencias(ByVal id As Integer)

        'Editar
        isEdit = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM PROJETOS_OCORRENCIAS WHERE ID_PROJETOS_OCORRENCIAS = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.comboResp.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.comboTipoProjeto.SelectedValue = dr("ID_PROJETOS").ToString
                Me.txtTituloOcorrencia.Text = dr("TITULO").ToString
                Me.txtDescOcorrencia.Text = dr("DESCRICAO").ToString
                Me.dateData.Value = dr("DATA").ToString
               
            End While

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        'Cadastra nova Ocorrência
        Dim ocorrenciasprojeto As New ocorrenciasprojeto

        If isEdit Then

            Try
                'Editar Ocorrência
                VerificarOcorrencias()
                If ocorrenciasprojeto.Update(idocorrencias, _
                                    comboResp.SelectedValue,
                                    comboTipoProjeto.SelectedValue, _
                                    txtTituloOcorrencia.Text, _
                                    txtDescOcorrencia.Text, _
                                    dateData.Value) Then
                    projListaOcorrencias.CarregaListaOcorrencias()
                    MessageBox.Show("Dados de Ocorrência atualizados com sucesso", "Ocorrência", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception

            End Try

        Else
            Try

                'Salvar Ocorrência
                VerificarOcorrencias()
                If ocorrenciasprojeto.Add(comboResp.SelectedValue,
                                          comboTipoProjeto.SelectedValue, _
                                          txtTituloOcorrencia.Text, _
                                          txtDescOcorrencia.Text, _
                                          dateData.Value) Then
                    projListaOcorrencias.CarregaListaOcorrencias()
                    MessageBox.Show("Ocorrência salva com sucesso", "Ocorrência", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Close()
                End If

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub VerificarOcorrencias()

        'Projeto
        If comboTipoProjeto.Text = "" Then
            MessageBox.Show("O campo Projeto não foi selecionado", "Ocorrência", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboTipoProjeto.Focus()
            Exit Sub
        End If 'Título da Atividade
        If txtTituloOcorrencia.Text = "" Then
            MessageBox.Show("O campo Título da Atividade não foi preenchido", "Ocorrência", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTituloOcorrencia.Focus()
            Exit Sub
        End If
        'Descrição
        If txtDescOcorrencia.Text = "" Then
            MessageBox.Show("O campo Descrição não foi preenchido", "Ocorrência", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDescOcorrencia.Focus()
            Exit Sub
        End If
        'Responsável
        If comboResp.Text = "" Then
            MessageBox.Show("O campo Responsável não foi selecionado", "Ocorrência", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResp.Focus()
            Exit Sub
        End If
        'Data
        If dateData.Text = "" Then
            MessageBox.Show("O campo Data não foi preenchido", "Ocorrência", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateData.Focus()
            Exit Sub
        End If

    End Sub

#End Region

End Class
