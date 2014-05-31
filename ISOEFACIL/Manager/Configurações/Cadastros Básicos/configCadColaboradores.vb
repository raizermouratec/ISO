Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ISOEFACIL.configListaBasico
Public Class configCadColaboradores

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditarColaboradores As Boolean = False
    Public idColaboradores As String
    Public verif As Boolean = False

    'Pega Id Colaboradores
    Public WriteOnly Property Colaboradores() As String
        Set(ByVal value As String)
            Me.idColaboradores = value
        End Set
    End Property

#End Region

#Region "CARREGA COMBO"

#Region "AREAS"

    Sub CarregaComboAreas()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_AREAS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("DESCRICAO") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        cmbArea.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        cmbArea.DataSource = dtb
        cmbArea.DisplayMember = "DESCRICAO"
        cmbArea.ValueMember = "ID"
    End Sub

#End Region

#Region "CARGOS"

    Sub CarregaComboCargos()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_CARGOS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("CARGO") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        cmbCargo.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        cmbCargo.DataSource = dtb
        cmbCargo.DisplayMember = "CARGO"
        cmbCargo.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub configCadColaboradores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CarregaComboAreas()
        CarregaComboCargos()

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoColaborador()
        'Cadastrar Novo
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarColaboradores(ByVal id As Integer)

        'Editar
        isEdit = True

        'Muda o Label do botão Incluir
        botSalvar.Width = 80
        botSalvar.Text = "Atualizar"

        'Carrega combos
        CarregaComboAreas()
        CarregaComboCargos()

        'Seleciona Produtos/Serviços pelo Id
        Dim sql As String = String.Format("SELECT * FROM COLABORADORES WHERE ID_COLABORADORES = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtColaborador.Text = dr("COLABORADOR").ToString
                Me.txtEmail.Text = dr("EMAIL").ToString
                Me.cmbArea.SelectedValue = dr("ID_AREAS").ToString
                Me.cmbCargo.SelectedValue = dr("ID_CARGOS").ToString
                If dr("SITUACAO") = True Then
                    'Ativo
                    optAtivo.Checked = True
                Else
                    'Inativo
                    optInativo.Checked = True
                End If
                If dr("APROVADOR") = True Then
                    'Sim
                    comboAprovador.SelectedItem = optSim
                Else
                    'Não
                    comboAprovador.SelectedItem = optNao
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
        Dim Colaboradores As New colaboradores

        'Verificando valor de Situação
        Dim situacao As Boolean
        If optAtivo.Checked = True Then
            situacao = True
        Else
            situacao = False
        End If

        'Verificando valor de Aprovador
        Dim aprovador As Boolean
        If comboAprovador.Text = "Sim" Then
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
                'Atualizar
                Try
                    If Colaboradores.Update(idColaboradores, _
                                            cmbArea.SelectedValue, _
                                            cmbCargo.SelectedValue, _
                                            txtColaborador.Text, _
                                            txtEmail.Text, _
                                            situacao, _
                                            aprovador, False) Then
                        MessageBox.Show("Dados atualizados com sucesso", "Colaboradores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        configListaBasico.CarregaColaboradores()
                        isEdit = False
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
                'Salvar
                Try
                    If Colaboradores.Add(cmbArea.SelectedValue, _
                                         cmbCargo.SelectedValue, _
                                         txtColaborador.Text, _
                                         txtEmail.Text, _
                                         situacao, _
                                         aprovador, False) Then
                        MessageBox.Show("Novo Colaborador incluído com sucesso", "Colaboradores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        configListaBasico.CarregaColaboradores()
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

        'Tratamento de erro Colaborador
        If txtColaborador.Text = "" Then
            MessageBox.Show("Campo Colaborador Obrigatório", "Colaboradores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtColaborador.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Email
        If txtEmail.Text = "" Then
            MessageBox.Show("Campo Email Obrigatório", "Colaboradores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEmail.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Area
        If cmbArea.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Área Obrigatório", "Colaboradores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbArea.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Cargo
        If cmbCargo.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Cargo Obrigatório", "Colaboradores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbCargo.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Situação
        If optAtivo.Checked = False And optInativo.Checked = False Then
            MessageBox.Show("Campo Situação Obrigatório", "Colaboradores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Aprovador
        If comboAprovador.Text = "" Then
            MessageBox.Show("Campo Aprovador Obrigatório", "Colaboradores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboAprovador.Focus()
            verif = True
            Exit Sub
        End If

        verif = False
    End Sub

#End Region

#End Region

#End Region

End Class
