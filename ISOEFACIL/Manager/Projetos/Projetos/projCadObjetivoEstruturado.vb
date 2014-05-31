Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.projPlanodeProjeto
Public Class projCadObjetivoEstruturado

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditregistro As Boolean = False
    Public idestruturado As String
    Public idobjetivos As String
    Public idprojetos As String

    'Pega Id Objetivos Estruturado
    Public WriteOnly Property Estruturado() As String
        Set(ByVal value As String)
            Me.idestruturado = value
        End Set
    End Property

    'Pega Id Objetivos Estruturado
    Public WriteOnly Property Objetivos() As String
        Set(ByVal value As String)
            Me.idobjetivos = value
        End Set
    End Property

    'Pega Id Objetivos Estruturado
    Public WriteOnly Property Projetos() As String
        Set(ByVal value As String)
            Me.idprojetos = value
        End Set
    End Property

#End Region

#Region "CARREGAR LISTA"

    Public Sub CarregaEstruturado(ByVal id As Integer)

        'Monta Lista de Risco do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_PROJETOS_PLANO_OBJETIVOS_ESTRUTURADO WHERE PROJETOS = {0}", id)
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)


        'Não gera colunas automaticas
        gridObjEstruturado.AutoGenerateColumns = False

        'Cria a tabela
        gridObjEstruturado.DataSource = dt


    End Sub

#End Region

#Region "LOAD"

    Private Sub projCadObjetivoEstruturado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaEstruturado(idprojetos)
        txtResultado.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtFormaAvaliacao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoEstruturado()
        'Cadastrar Novo
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "BOTOES"

#Region "INCLUIR"

    Private Sub botIncluir_Click(sender As System.Object, e As System.EventArgs) Handles botIncluir.Click

        Dim alcancado As Boolean

        If radioSim.Checked = True Then
            alcancado = True
        Else
            alcancado = False
        End If

        'Cadastra novo Objetivo Estruturado
        Dim objestruturado As New planoprojeto

        If isEdit Then

            Try

                'Editar Objetivo Estruturado
                VerificarEstruturado()
                If objestruturado.UpdateEstruturado(idestruturado, _
                                                    idprojetos, _
                                                    txtResultado.Text, _
                                                    txtQuantidade.Text, _
                                                    txtUnidade.Text, _
                                                    txtFormaAvaliacao.Text, _
                                                    alcancado) Then

                    txtResultado.Text = ""
                    txtQuantidade.Text = ""
                    txtUnidade.Text = ""
                    txtFormaAvaliacao.Text = ""
                    radioSim.Checked = False
                    radioNao.Checked = False
                    CarregaEstruturado(idprojetos)
                    MessageBox.Show("Dados de Objetivo Estruturado atualizados com sucesso", "Plano de Projeto - Objetivo Estruturado", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        Else

            Try

                'Salvar Objetivo Estruturado
                VerificarEstruturado()
                If objestruturado.AddEstruturado(idprojetos, _
                                                 txtResultado.Text, _
                                                 txtQuantidade.Text, _
                                                 txtUnidade.Text, _
                                                 txtFormaAvaliacao.Text, _
                                                 alcancado) Then
                    txtResultado.Text = ""
                    txtQuantidade.Text = ""
                    txtUnidade.Text = ""
                    txtFormaAvaliacao.Text = ""
                    radioSim.Checked = False
                    radioNao.Checked = False
                    CarregaEstruturado(idprojetos)
                    MessageBox.Show("Objetivo Estruturado salvo com sucesso", "Plano de Projeto - Objetivo Estruturado", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub VerificarEstruturado()

        'Resultado
        If txtResultado.Text = "" Then
            MessageBox.Show("O campo Resultado não foi preenchido", "Plano de Projeto - Objetivo Estruturado", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtResultado.Focus()
            Exit Sub
        End If
        'Quantidade
        If Not IsNumeric(txtQuantidade.Text) Or txtQuantidade.Text = "" Then
            'If txtQuantidade.Text = "" Then
            MessageBox.Show("O campo Quantidade não foi preenchido, Somente Números", "Plano de Projeto  - Objetivo Estruturado", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQuantidade.Focus()
            Exit Sub
        End If
        'Unidade
        If Not IsNumeric(txtUnidade.Text) Or txtUnidade.Text = "" Then
            'If txtUnidade.Text = "" Then
            MessageBox.Show("O campo Unidade em não foi preenchido, Somente Números", "Plano de Projeto - Objetivo Estruturado", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUnidade.Focus()
            Exit Sub
        End If
        'Forma de Avaliação
        If txtFormaAvaliacao.Text = "" Then
            MessageBox.Show("O campo Forma de avaliação não foi preenchido", "Plano de Projeto - Objetivo Estruturado", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFormaAvaliacao.Focus()
            Exit Sub
        End If
        'Alcançado?
        If radioSim.Checked = False And radioNao.Checked = False Then
            MessageBox.Show("O campo Alcançado não foi marcado", "Plano de Projeto - Objetivo Estruturado", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        Dim id As Integer = 0
        Dim idProjeto As Integer = 0

        If gridObjEstruturado.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Objetivo Estruturado", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Passagem de parametros
            Try

                idProjeto = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                idprojetos = idProjeto
                id = gridObjEstruturado(gridObjEstruturado.RowSel, 1)
                Estruturado = id
                EditarEstruturado(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

            CarregaEstruturado(idprojetos)
        End If
    End Sub

    Public Sub EditarEstruturado(ByVal id As Integer)

        'Editar
        isEdit = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM PROJETOS_PLANO_OBJETIVOS_ESTRUTURADO WHERE ID_PROJETOS_PLANO_OBJETIVOS_ESTRUTURADO = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtResultado.Text = ("RESULTADO").ToString
                Me.txtQuantidade.Text = ("QUANTIDADE").ToString
                Me.txtUnidade.Text = ("UNIDADE").ToString
                Me.txtFormaAvaliacao.Text = ("AVALIACAO").ToString
                If dr("ALCANCADO") = 1 Then
                    Me.radioSim.Checked = True
                Else
                    Me.radioNao.Checked = True
                End If

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        Dim objestruturado As New planoprojeto


        If gridObjEstruturado.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Objetivo Estruturado", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Excluir o Objetivo Estruturado
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Plano de Projeto - Objetivo Estruturado", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    objestruturado.DeleteEstruturado(gridObjEstruturado(gridObjEstruturado.RowSel, 1))
                    CarregaEstruturado(idprojetos)
                    MessageBox.Show("Projeto excluído com sucesso", "Plano de Projeto - Objetivo Estruturado", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#End Region

End Class
