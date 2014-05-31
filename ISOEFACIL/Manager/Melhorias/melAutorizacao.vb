Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.melListaMelhorias
Public Class melAutorizacao

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Public verif As Boolean = False
    Public idmelhorias As String
    Public idautorizacao As String

    'Pega Id Melhorias
    Public WriteOnly Property Melhorias() As String
        Set(ByVal value As String)
            Me.idmelhorias = value
        End Set
    End Property

    'Pega Id 
    Public WriteOnly Property Autorizacao() As String
        Set(ByVal value As String)
            Me.idautorizacao = value
        End Set
    End Property

#End Region

#Region "CARREGA COMBO"

#Region "CLIENTE"

    Sub CarregaCliente()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_CLIENTES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("CLIENTE") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboCliente.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboCliente.DataSource = dtb
        comboCliente.DisplayMember = "CLIENTE"
        comboCliente.ValueMember = "CODIGO"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub melAutorizacao_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaCliente()
    End Sub

#End Region

#Region "NOVO"

    Public Sub Novo()
        'Cadastrar Novo
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"



#End Region

#Region "RESPOSTA DA EMPRESA"

    Private Sub radioViavel1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioViavel1.SelectedIndexChanged
        If radioViavel1.Checked = True And radioInviavel1.Checked = False Then
            radioViavel1.Checked = True
        End If
    End Sub

    Private Sub radioInviavel1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioInviavel1.SelectedIndexChanged
        If radioInviavel1.Checked = True And radioViavel1.Checked = False Then
            radioInviavel1.Checked = True
        End If
    End Sub

#End Region

#Region "RESPOSTA DO CLIENTE"

    Private Sub radioViavel2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioViavel2.SelectedIndexChanged, radioViavel2.SelectedIndexChanged
        If radioViavel2.Checked = True And radioInviavel2.Checked = False Then
            radioViavel2.Checked = True
        End If
    End Sub

    Private Sub radioInviavel2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioInviavel2.SelectedIndexChanged, radioInviavel2.SelectedIndexChanged
        If radioInviavel2.Checked = True And radioViavel2.Checked = False Then
            radioInviavel2.Checked = True
        End If
    End Sub

#End Region

#Region "BOTOES"

#Region "SALVAR"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim autorizacao As New autorizacao

        'Verificando valor de Autorização Empresa
        Dim autoempresa As Boolean
        If radioViavel1.Checked = True Then
            autoempresa = True
        Else
            autoempresa = False
        End If

        'Verificando valor de Autorização Cliente
        Dim autocliente As Boolean
        If radioViavel1.Checked = True Then
            autocliente = True
        Else
            autocliente = False
        End If

        'Verificando valor do Cliente
        Dim cliente As Integer
        If comboCliente.SelectedValue.ToString = String.Empty Then
            cliente = 0
        Else
            cliente = comboCliente.SelectedValue
        End If

        'Verificando valor de Autorização Cliente
        Dim implementado As Boolean
        If radioSim.Checked = True Then
            implementado = True
        Else
            implementado = False
        End If

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If autorizacao.Update(idautorizacao, _
                                          idmelhorias, _
                                          autoempresa, _
                                          autocliente, _
                                          cliente, _
                                          implementado) Then
                        MessageBox.Show("Dados de Autorização de Implementação atualizados com sucesso", "Autorização", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If autorizacao.Add(idmelhorias, _
                                       autoempresa, _
                                       autocliente, _
                                       cliente, _
                                       implementado) Then
                        MessageBox.Show("Dados de Autorização de Implementação salvo com sucesso", "Autorização", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        isEdit = True
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub Verificar()
        verif = False

        'Tratamento de erro Empresa
        If radioViavel1.Checked = False And radioInviavel1.Checked = False Then
            MessageBox.Show("Campo Avaliação ou resposta da diretoria da Empresa Obrigatórido", "Autorização", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Cliente
        If radioViavel2.Checked = False And radioInviavel2.Checked = False Then
            MessageBox.Show("Campo Avaliação ou resposta da diretoria do Cliente Obrigatórido", "Autorização", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verif = True
            Exit Sub
        Else
            'Tratamento de erro Cliente combo
            If comboCliente.SelectedValue.ToString = String.Empty Then
                MessageBox.Show("Campo Cliente Obrigatórido", "Autorização", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                verif = True
                Exit Sub
            End If
        End If
        'Tratamento de erro Implementado
        If radioSim.Checked = False And radioNao.Checked = False Then
            MessageBox.Show("Campo Implementado Obrigatórido", "Autorização", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "CADASTRO CLIENTE"

    Private Sub botCliente_Click(sender As System.Object, e As System.EventArgs) Handles botCliente.Click, botCliente.Click

    End Sub

#End Region

#End Region

#Region "IMPLEMENTADO"

    Private Sub radioSim_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioSim.SelectedIndexChanged, radioSim.SelectedIndexChanged
        If radioSim.Checked = True And radioNao.Checked = False Then
            radioSim.Checked = True
        End If
    End Sub

    Private Sub radioNao_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioNao.SelectedIndexChanged, radioNao.SelectedIndexChanged
        If radioNao.Checked = True And radioSim.Checked = False Then
            radioNao.Checked = True
        End If
    End Sub

#End Region

End Class
