Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ISOEFACIL.projPlanodeProjeto
Public Class projCadRecursos

#Region "VARIAVEIS"

    'Delegate criada para atualizar o grid
    Public Delegate Sub CarregaRecursos(info As Integer)
    Public Event OnDataChange As CarregaRecursos

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditRecursos As Boolean = False
    Public idrecursos As String
    Public idprojetos As String

    'Pega Id Recursos
    Public WriteOnly Property Recursos() As String
        Set(ByVal value As String)
            Me.idrecursos = value
        End Set
    End Property

    'Pega Id Objetivos Estruturado
    Public WriteOnly Property Projetos() As String
        Set(ByVal value As String)
            Me.idprojetos = value
        End Set
    End Property

#End Region

#Region "LOAD"

    Private Sub projCadRecursos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub botCancelar_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoRecursos()
        'Cadastrar Novo
        isEditRecursos = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvarRecursos_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarRecursos.Click

        'Cadastra novo Recurso
        Dim planoprojeto As New planoprojeto

        If isEditRecursos Then

            Try

                'Editar Recurso
                VerificarRecursos()
                If planoprojeto.UpdateRecursos(idrecursos, _
                                             idprojetos, _
                                             txtRecurso.Text, _
                                             txtRecursoTipo.Text, _
                                             txtQuantidade.Text, _
                                             txtUnidade.Text, _
                                             txtValorUnitario.Text, _
                                             txtValorTotal.Text) Then

                    RaiseEvent OnDataChange(idprojetos)
                    MessageBox.Show("Dados de Recurso atualizados com sucesso", "Plano de Projeto - Recursos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        Else

            Try

                'Salvar Recurso
                VerificarRecursos()
                If planoprojeto.AddRecursos(idprojetos, _
                                            txtRecurso.Text, _
                                            txtRecursoTipo.Text, _
                                            txtQuantidade.Text, _
                                            txtUnidade.Text, _
                                            txtValorUnitario.Text, _
                                            txtValorTotal.Text) Then

                    RaiseEvent OnDataChange(idprojetos)
                    MessageBox.Show("Recurso salvo com sucesso", "Plano de Projeto - Recursos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub VerificarRecursos()
        'Recurso
        If txtRecurso.Text = "" Then
            MessageBox.Show("O campo Recurso não foi preenchido", "Plano de Projeto - Recursos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRecurso.Focus()
            Exit Sub
        End If
        'Tipo
        If txtRecursoTipo.Text = "" Then
            MessageBox.Show("O campo Tipo não foi preenchido", "Plano de Projeto - Recursos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRecursoTipo.Focus()
            Exit Sub
        End If
        'Quantidade
        If txtQuantidade.Text = "" Then
            MessageBox.Show("O campo Quantidade não foi preenchido", "Plano de Projeto - Recursos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQuantidade.Focus()
            Exit Sub
        End If
        'Unidade
        If Not IsNumeric(txtUnidade.Text) Or txtUnidade.Text = "" Then
            MessageBox.Show("O campo Unidade não foi preenchido, Somente Números", "Plano de Projeto - Recursos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUnidade.Focus()
            Exit Sub
        End If
        'Valor Unitário
        If Not IsNumeric(txtValorUnitario.Text) Or txtValorUnitario.Text = "" Then
            MessageBox.Show("O campo Valor Unitário não foi preenchido, Somente Números", "Plano de Projeto - Recursos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtValorUnitario.Focus()
            Exit Sub
        End If
        'Valor Total
        If Not IsNumeric(txtValorTotal.Text) Or txtValorTotal.Text = "" Then
            MessageBox.Show("O campo Valor Total não foi preenchido, Somente Números", "Plano de Projeto - Recursos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtValorTotal.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarRecursos(ByVal id As Integer)

        'Editar
        isEditRecursos = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM PROJETOS_PLANO_RECURSOS WHERE ID_PROJETOS_PLANO_RECURSOS = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtRecurso.Text = dr("RECURSOS").ToString
                Me.txtRecursoTipo.Text = dr("TIPO").ToString
                Me.txtQuantidade.Text = dr("QUANTIDADE").ToString
                Me.txtUnidade.Text = dr("UNIDADE").ToString
                Me.txtValorUnitario.Text = dr("VALOR_UNITARIO").ToString
                Me.txtValorTotal.Text = dr("VALOR_TOTAL").ToString


            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class


