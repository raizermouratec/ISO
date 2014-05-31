Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.projPlanodeProjeto
Public Class projCadEstagios5w2h

#Region "VARIAVEIS"

    'Delegate criada para atualizar o grid
    Public Delegate Sub Carrega5W2H(info As Integer)
    Public Event OnDataChange As Carrega5W2H

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditEstagios5w2h As Boolean = False
    Public idestagios5w2h As String
    Public idprojetos As String

    'Pega Id Estágio_5W2H
    Public WriteOnly Property Estagios5w2h() As String
        Set(ByVal value As String)
            Me.idestagios5w2h = value
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

    Private Sub projCadEstagios5w2h_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtOque.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtComo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtQuem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtQuando.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtOnde.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtPorque.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtQuanto.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

    Private Sub botCancelar5w2h_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoEstagio5w2h()
        'Cadastrar Novo
        isEditEstagios5w2h = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvar5w2h_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar5w2h.Click

        If projPlanodeProjeto.radio5W2H.Focus = True Then

            'Cadastra novo 5w2h
            Dim planoprojeto2 As New planoprojeto

            Dim tipo5w2h As Boolean

            tipo5w2h = False

            If isEditEstagios5w2h Then

                Try
                    'Editar 5w2h
                    Verificar5w2h()
                    If planoprojeto2.UpdateEstagios5W2H(idestagios5w2h, _
                                                       idprojetos, _
                                                       tipo5w2h, _
                                                       txtOque.Text, _
                                                       txtComo.Text, _
                                                       txtQuem.Text, _
                                                       txtQuando.Text, _
                                                       txtOnde.Text, _
                                                       txtPorque.Text, _
                                                       txtQuanto.Text) Then
                        RaiseEvent OnDataChange(idprojetos)
                        MessageBox.Show("Dados de Projeto atualizados com sucesso", "Plano de Projeto - Estágio - 5W2H", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Try
                    'Salvar 5w2h
                    Verificar5w2h()
                    If planoprojeto2.AddEstagios5W2H(idprojetos, _
                                                     tipo5w2h, _
                                                     txtOque.Text, _
                                                     txtComo.Text, _
                                                     txtQuem.Text, _
                                                     txtQuando.Text, _
                                                     txtOnde.Text, _
                                                     txtPorque.Text, _
                                                     txtQuanto.Text) Then
                        RaiseEvent OnDataChange(idprojetos)
                        MessageBox.Show("Projeto salvo com sucesso", "Plano de Projeto - Estágio - 5W2H", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            End If

        End If

    End Sub

    Private Sub Verificar5w2h()
        'Oque
        If txtOque.Text = "" Then
            MessageBox.Show("O campo O que não foi preenchido", "Plano de Projeto - Estágio - 5W2H", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtOque.Focus()
            Exit Sub
        End If
        'Como
        If txtComo.Text = "" Then
            MessageBox.Show("O campo Como não foi preenchido", "Plano de Projeto - Estágio - 5W2H", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtComo.Focus()
            Exit Sub
        End If
        'Quem
        If txtQuem.Text = "" Then
            MessageBox.Show("O campo Quem não foi preenchido", "Plano de Projeto - Estágio - 5W2H", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQuem.Focus()
            Exit Sub
        End If
        'Quando
        If txtQuando.Text = "" Then
            MessageBox.Show("O campo Quando não foi preenchido", "Plano de Projeto - Estágio - 5W2H", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQuando.Focus()
            Exit Sub
        End If
        'Onde
        If txtOnde.Text = "" Then
            MessageBox.Show("O campo Onde não foi preenchido", "Plano de Projeto - Estágio - 5W2H", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtOnde.Focus()
            Exit Sub
        End If
        'Porque
        If txtPorque.Text = "" Then
            MessageBox.Show("O campo Porque não foi preenchido", "Plano de Projeto - Estágio - 5W2H", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPorque.Focus()
            Exit Sub
        End If
        'Quanto
        If txtQuanto.Text = "" Then
            MessageBox.Show("O campo Quanto não foi preenchido", "Plano de Projeto - Estágio - 5W2H", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQuanto.Focus()
            Exit Sub
        End If

    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarEstagio5w2h(ByVal id As Integer)

        'Editar
        isEditEstagios5w2h = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM PROJETOS_PLANO_ESTAGIOS_5W2H WHERE ID_PROJETOS_PLANO_ESTAGIOS_5W2H = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtOque.Text = dr("OQUE").ToString
                Me.txtComo.Text = dr("COMO").ToString
                Me.txtQuem.Text = dr("QUEM").ToString
                Me.txtQuando.Text = dr("QUANDO").ToString
                Me.txtOnde.Text = dr("ONDE").ToString
                Me.txtPorque.Text = dr("PORQUE").ToString
                Me.txtQuanto.Text = dr("QUANTO").ToString


            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class
