Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ISOEFACIL.cotrListaCargos
Imports ISOEFACIL.cotrCadCargos
Public Class configCadCargos

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditarCargos As Boolean = False
    Public idCargos As String
    Public verif As Boolean = False

    'Pega Id Registro
    Public WriteOnly Property Cargos() As String
        Set(ByVal value As String)
            Me.idCargos = value
        End Set
    End Property

#End Region

#Region "LOAD"

    Private Sub configCadCargos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoCargo()
        'Cadastrar Novo
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarCargos(ByVal id As Integer)

        'Editar
        isEdit = True

        'Muda o Label do botão Incluir
        botSalvar.Width = 80
        botSalvar.Text = "Atualizar"

        'Seleciona pelo Id
        Dim sql As String = String.Format("SELECT * FROM CARGOS WHERE ID_CARGOS = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read


                Me.txtCargo.Text = dr("NOME").ToString
                If dr("APROVADOR") = 0 Then
                    'Não
                    cmbAprovador.SelectedItem = optNao
                Else
                    'Sim
                    cmbAprovador.SelectedItem = optSim
                End If
                If dr("SITUACAO") = 1 Then
                    'Ativo
                    optAtivo.Checked = True
                Else
                    'Inativo
                    optInativo.Checked = True
                End If

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

#End Region

#Region "BOTOES"

#Region "SALVAR"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim cargosbasicos As New cargosbasicos

        'Verificando valor de Situação
        Dim sit As Integer
        If optAtivo.Checked = True Then
            sit = 1
        Else
            sit = 0
        End If

        'Verificando valor de Aprovador
        Dim aprovador As Boolean
        If cmbAprovador.Text = "Sim" Then
            aprovador = True
        Else
            aprovador = False
        End If

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If cargosbasicos.Update(idCargos, _
                                            txtCargo.Text, _
                                            aprovador, _
                                            sit) Then
                        MessageBox.Show("Cargo atualizado com sucesso", "Cargos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        configListaBasico.CarregaCargos()
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
                    If cargosbasicos.Add(txtCargo.Text, _
                                         aprovador, _
                                         sit) Then
                        MessageBox.Show("Novo Cargo incluído com sucesso", "Cargos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        configListaBasico.CarregaCargos()
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

#Region "VERIFICAR CAMPOS"

    Sub Verificar()
        verif = False

        'Tratamento de erro Cargo
        If txtCargo.Text = "" Then
            MessageBox.Show("Campo Cargo Obrigatório", "Cargo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCargo.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Aprovador
        If cmbAprovador.Text = "" Then
            MessageBox.Show("Campo Aprovador Obrigatório", "Cargo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbAprovador.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Situação
        If optAtivo.Checked = False And optInativo.Checked = False Then
            MessageBox.Show("Campo Situação Obrigatório", "Cargo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verif = True
            Exit Sub
        End If

        verif = False
    End Sub

#End Region

#End Region

#End Region

End Class
