Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.projPlanodeProjeto
Public Class projCadControleValidacao

#Region "VARIAVEIS"

    'Delegate criada para atualizar o grid
    Public Delegate Sub CarregaControleValid(info As Integer)
    Public Event OnDataChange As CarregaControleValid

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditControleValid As Boolean = False
    Public idcontroleValid As String
    Public idprojetos As String

    'Pega Id Controle_Validação
    Public WriteOnly Property ControleValid() As String
        Set(ByVal value As String)
            Me.idcontroleValid = value
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

    Sub CarregaRespValid()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboRespValidacao.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboRespValidacao.DataSource = dtb
        comboRespValidacao.DisplayMember = "COLABORADOR"
        comboRespValidacao.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub projCadControleValidacao_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaRespValid()
        txtMetodoValidacao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtProgValidacao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

    Private Sub botCancelarValid_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoControleValid()
        'Cadastrar Novo
        isEditControleValid = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvarValid_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarValid.Click

        'Cadastra nova Controle/Validação
        Dim planoprojeto As New planoprojeto

        If isEditControleValid Then
            Try

                'Editar Validação
                VerificarValid()
                If planoprojeto.UpdateControleValid(idcontroleValid, _
                                                 comboRespValidacao.SelectedValue, _
                                                 idprojetos, _
                                                 txtMetodoValidacao.Text, _
                                                 txtProgValidacao.Text) Then
                    RaiseEvent OnDataChange(idprojetos)
                    MessageBox.Show("Dados de Validação atualizados com sucesso", "Plano de Projeto - Controle - Validação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        Else
            Try

                'Salvar Validação
                VerificarValid()
                If planoprojeto.AddControleValid(comboRespValidacao.SelectedValue, _
                                              idprojetos, _
                                              txtMetodoValidacao.Text, _
                                              txtProgValidacao.Text) Then
                    RaiseEvent OnDataChange(idprojetos)
                    MessageBox.Show("Validação salvo com sucesso", "Plano de Projeto - Controle - Validação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub VerificarValid()
        'Método 
        If txtMetodoValidacao.Text = "" Then
            MessageBox.Show("O campo Método não foi preenchido", "Plano de Projeto - Controle - Validação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMetodoValidacao.Focus()
            Exit Sub
        End If
        'Responsável
        If comboRespValidacao.Text = "" Then
            MessageBox.Show("O campo Responsável não foi preenchido", "Plano de Projeto - Controle - Validação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboRespValidacao.Focus()
            Exit Sub
        End If
        'Programação
        If txtProgValidacao.Text = "" Then
            MessageBox.Show("O campo Programação não foi preenchido", "Plano de Projeto - Controle - Validação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtProgValidacao.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarControleValid(ByVal id As Integer)

        'Editar
        isEditControleValid = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM PROJETOS_PLANO_CONTROLE_VERIFICACAO WHERE ID_PROJETOS_PLANO_CONTROLE_VERIFICACAO = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtMetodoValidacao.Text = dr("PROGRAMACAO").ToString
                Me.comboRespValidacao.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.txtProgValidacao.Text = dr("METODO").ToString


            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class
