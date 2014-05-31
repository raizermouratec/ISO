Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.projPlanodeProjeto
Public Class projCadControleVerificacao

#Region "VARIAVEIS"

    'Delegate criada para atualizar o grid
    Public Delegate Sub CarregaControleVerif(info As Integer)
    Public Event OnDataChange As CarregaControleVerif

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditControleVerif As Boolean = False
    Public idcontroleVerif As String
    Public idprojetos As String

    'Pega Id Contorle_Verificação
    Public WriteOnly Property ControleVerif() As String
        Set(ByVal value As String)
            Me.idcontroleVerif = value
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

    Sub CarregaRespVerif()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboRespVerif.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboRespVerif.DataSource = dtb
        comboRespVerif.DisplayMember = "COLABORADOR"
        comboRespVerif.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub projCadControleVerificacao_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaRespVerif()
        txtMetodoVerif.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtProgVerif.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

    Private Sub botCancelarVerif_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoControleVerif()
        'Cadastrar Novo
        isEditControleVerif = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvarVerif_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarVerif.Click

        'Cadastra nova Controle/Verificação
        Dim planoprojeto As New planoprojeto

        If isEditControleVerif Then

            'Editar Verificação
            VerificarVerif()
            If planoprojeto.UpdateControleVerif(idcontroleVerif, _
                                             comboRespVerif.SelectedValue, _
                                             idprojetos, _
                                             txtMetodoVerif.Text, _
                                             txtProgVerif.Text) Then
                RaiseEvent OnDataChange(idprojetos)
                MessageBox.Show("Dados de Verificação atualizados com sucesso", "Plano de Projeto - Controle - Verificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Else

            'Salvar Verificação
            VerificarVerif()
            If planoprojeto.AddControleVerif(comboRespVerif.SelectedValue, _
                                          idprojetos, _
                                          txtMetodoVerif.Text, _
                                          txtProgVerif.Text) Then
                RaiseEvent OnDataChange(idprojetos)
                MessageBox.Show("Verificação salva com sucesso", "Plano de Projeto - Controle - Verificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

        End If

    End Sub

    Private Sub VerificarVerif()
        'Método 
        If txtMetodoVerif.Text = "" Then
            MessageBox.Show("O campo Método não foi preenchido", "Plano de Projeto - Controle - Verificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMetodoVerif.Focus()
            Exit Sub
        End If
        'Responsável
        If comboRespVerif.Text = "" Then
            MessageBox.Show("O campo Responsável não foi preenchido", "Plano de Projeto - Controle - Verificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboRespVerif.Focus()
            Exit Sub
        End If
        'Programação
        If txtProgVerif.Text = "" Then
            MessageBox.Show("O campo Programação não foi preenchido", "Plano de Projeto - Controle - Verificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtProgVerif.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarControleVerif(ByVal id As Integer)

        'Editar
        isEditControleVerif = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM PROJETOS_PLANO_CONTROLE_VERIFICACAO WHERE ID_PROJETOS_PLANO_CONTROLE_VERIFICACAO = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtMetodoVerif.Text = dr("PROGRAMACAO").ToString
                Me.comboRespVerif.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.txtProgVerif.Text = dr("METODO").ToString


            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class
