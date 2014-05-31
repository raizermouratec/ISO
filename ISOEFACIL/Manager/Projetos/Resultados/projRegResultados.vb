Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.projListaResultados
Public Class projRegResultados

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditregistro As Boolean = False
    Public idresultados As String

    'Pega Id Registro
    Public WriteOnly Property Resultados() As String
        Set(ByVal value As String)
            Me.idresultados = value
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
    End Sub

#End Region

#Region "PROJETOS"

    Sub CarregaProjeto()
        comboProjeto.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboProjeto.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_PROJETOS")
        comboProjeto.DisplayMember = "TITULO"
        comboProjeto.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub projRegResultados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaProjeto()
        CarregaResp()
        txtTipox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoResultado()
        'Cadastrar Novo
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarResultados(ByVal id As Integer)

        'Editar
        isEdit = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM PROJETOS_RESULTADOS WHERE ID_PROJETOS_RESULTADOS = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.comboResp.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.comboProjeto.SelectedValue = dr("ID_PROJETOS").ToString
                Me.txtResultadox.Text = dr("TITULO").ToString
                Me.txtTipox.Text = dr("DESCRICAO").ToString
                Me.dateData.Value = dr("DATA").ToString

            End While

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "BOTOES"

#Region "SALVAR"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        'Cadastra nova Resultados
        Dim resultadosprojeto As New resultadosprojeto

        If isEdit Then

            Try
                'Editar Resultados
                VerificarResultados()
                'If resultadosprojeto.Update(idocorrencias, _
                '                    comboResp.SelectedValue,
                '                    comboTipoProjeto.SelectedValue, _
                '                    txtTituloOcorrencia.Text, _
                '                    txtDescOcorrencia.Text, _
                '                    dateData.Value) Then
                '    projListaResultados.CarregaListaResultados()
                '    MessageBox.Show("Dados de Resultados atualizados com sucesso", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                'End If

            Catch ex As Exception

            End Try

        Else
            Try

                'Salvar Resultados
                VerificarResultados()
                'If resultadosprojeto.Add(comboResp.SelectedValue,
                '                          comboTipoProjeto.SelectedValue, _
                '                          txtTituloOcorrencia.Text, _
                '                          txtDescOcorrencia.Text, _
                '                          dateData.Value) Then
                '    projListaResultados.CarregaListaResultados()
                '    MessageBox.Show("Resultados salvo com sucesso", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    Close()
                'End If

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub VerificarResultados()

        'Projeto
        If comboProjeto.Text = "" Then
            MessageBox.Show("O campo Projeto não foi selecionado", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboProjeto.Focus()
            Exit Sub
        End If
        'Resultado
        If txtResultado.Text = "" Then
            MessageBox.Show("O campo Título da Atividade não foi preenchido", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtResultado.Focus()
            Exit Sub
        End If
        'Descrição
        If txtDescricao.Text = "" Then
            MessageBox.Show("O campo Descrição não foi preenchido", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDescricao.Focus()
            Exit Sub
        End If
        'Responsável
        If comboResp.SelectedValue = -1 Then
            MessageBox.Show("O campo Responsável não foi selecionado", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResp.Focus()
            Exit Sub
        End If
        'Data
        If dateData.Text = "" Then
            MessageBox.Show("O campo Data não foi preenchido", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateData.Focus()
            Exit Sub
        End If

    End Sub

#End Region

#Region "ANEXO"

    Private Sub botAnexo_Click(sender As System.Object, e As System.EventArgs) Handles botAnexo.Click

    End Sub

#End Region

#End Region

End Class
