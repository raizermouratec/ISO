Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.projPlanodeProjeto
Public Class projCadControleAC

#Region "VARIAVEIS"

    'Delegate criada para atualizar o grid
    Public Delegate Sub CarregaControleAC(info As Integer)
    Public Event OnDataChange As CarregaControleAC

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditControle As Boolean = False
    Public idcontroleAC As String
    Public idprojetos As String

    'Pega Id Controle_Análise Critica
    Public WriteOnly Property ControleAC() As String
        Set(ByVal value As String)
            Me.idcontroleAC = value
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

    Sub CarregaRespAC()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboRespAC.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboRespAC.DataSource = dtb
        comboRespAC.DisplayMember = "COLABORADOR"
        comboRespAC.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub projCadControleAC_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaRespAC()
        txtMetodoAC.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtProgramacaoAC.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

    Private Sub botCancelarAC_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoControle()
        'Cadastrar Novo
        isEditControle = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvarAC_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarAC.Click

        'Cadastra nova Controle/Análise Crítica
        Dim planoprojeto As New planoprojeto

        If isEditControle Then

            Try

                'Editar Análise Crítica
                VerificarAC()
                If planoprojeto.UpdateControleAC(idcontroleAC, _
                                                 comboRespAC.SelectedValue, _
                                                 idprojetos, _
                                                 txtMetodoAC.Text, _
                                                 txtProgramacaoAC.Text) Then
                    RaiseEvent OnDataChange(idprojetos)
                    MessageBox.Show("Dados de Análise Crítica atualizados com sucesso", "Plano de Projeto - Controle - Análise Crítica", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        Else

            Try

                'Salvar Análise Crítica
                VerificarAC()
                If planoprojeto.AddControleAC(comboRespAC.SelectedValue, _
                                              idprojetos, _
                                              txtMetodoAC.Text, _
                                              txtProgramacaoAC.Text) Then
                    RaiseEvent OnDataChange(idprojetos)
                    MessageBox.Show("Análise Crítica salvo com sucesso", "Plano de Projeto - Controle - Análise Crítica", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub VerificarAC()
        'Método 
        If txtMetodoAC.Text = "" Then
            MessageBox.Show("O campo Método não foi preenchido", "Plano de Projeto - Controle - Análise Crítica", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMetodoAC.Focus()
            Exit Sub
        End If
        'Responsável
        If comboRespAC.Text = "" Then
            MessageBox.Show("O campo Responsável não foi preenchido", "Plano de Projeto - Controle - Análise Crítica", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboRespAC.Focus()
            Exit Sub
        End If
        'Programação
        If txtProgramacaoAC.Text = "" Then
            MessageBox.Show("O campo Programação não foi preenchido", "Plano de Projeto - Controle - Análise Crítica", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtProgramacaoAC.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarControle(ByVal id As Integer)

        'Editar
        isEditControle = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM PROJETOS_PLANO_CONTROLE_AC WHERE ID_PROJETOS_PLANO_CONTROLE_AC = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtMetodoAC.Text = dr("PROGRAMACAO").ToString
                Me.comboRespAC.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.txtProgramacaoAC.Text = dr("METODO").ToString


            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class
