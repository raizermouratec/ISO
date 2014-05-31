Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ISOEFACIL.cotrListaCargos
Public Class cotrCadCargos

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditarCargos As Boolean = False
    Public verif As Boolean = False
    Public idCargos As String

    'Pega Id Registro
    Public WriteOnly Property Cargos() As String
        Set(ByVal value As String)
            Me.idCargos = value
        End Set
    End Property

#End Region

#Region "POPULA COMBOS"

#Region "AREAS"

    Sub carregaArea()

        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT ID, CODIGO + '  ' + DESCRICAO AS AREA FROM VW_LISTAGEM_AREAS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("AREA") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        cmbArea.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        cmbArea.DataSource = dtb
        cmbArea.DisplayMember = "AREA"
        cmbArea.ValueMember = "ID"

        'With cmbArea
        '    .DataSource = Manager.Util.getDataTable("SELECT ID, CODIGO + '  ' + DESCRICAO AS AREA FROM VW_LISTAGEM_AREAS")
        '    .DisplayMember = "AREA"
        '    .ValueMember = "ID"
        '    .Text = ""
        'End With

    End Sub

#End Region

#Region "CHEFIA"

    Sub CarregaChefia()

        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM CARGOS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        cmbChefiaImediata.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        cmbChefiaImediata.DataSource = dtb
        cmbChefiaImediata.DisplayMember = "NOME"
        cmbChefiaImediata.ValueMember = "ID_CARGOS"

        'With cmbChefiaImediata
        '    .DataSource = Manager.Util.getDataTable("SELECT * FROM CARGOS")
        '    .DisplayMember = "NOME"
        '    .ValueMember = "ID_CARGOS"
        '    .Text = ""
        'End With

    End Sub

#End Region

#Region "SUBSTITUTO"

    Sub carregaSubstituto()

        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM CARGOS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        cmbSubstituto.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        cmbSubstituto.DataSource = dtb
        cmbSubstituto.DisplayMember = "NOME"
        cmbSubstituto.ValueMember = "ID_CARGOS"

        'With cmbSubstituto
        '    .DataSource = Manager.Util.getDataTable("SELECT * FROM CARGOS")
        '    .DisplayMember = "NOME"
        '    .ValueMember = "ID_CARGOS"
        '    .Text = ""
        'End With
    End Sub

#End Region

#Region "ELABORADOR"

    Sub CarregaElaborador()

        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        cmbElaborador.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        cmbElaborador.DataSource = dtb
        cmbElaborador.DisplayMember = "COLABORADOR"
        cmbElaborador.ValueMember = "ID"

        'With cmbElaborador
        '    .DataSource = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        '    .DisplayMember = "COLABORADOR"
        '    .ValueMember = "ID"
        '    .Text = ""
        'End With

    End Sub

#End Region

#Region "APROVADOR"

    Sub CarregaAprovador()

        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES_APROVADOR")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        cmbAprovadorDados.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        cmbAprovadorDados.DataSource = dtb
        cmbAprovadorDados.DisplayMember = "COLABORADOR"
        cmbAprovadorDados.ValueMember = "ID"

        'With cmbAprovadorDados
        '    .DataSource = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES_APROVADOR")
        '    .DisplayMember = "COLABORADOR"
        '    .ValueMember = "ID"
        '    .Text = ""
        'End With

    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub configCadCargos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TabCompetencias.Show()
        TabEducacao.Show()
        carregaArea()
        carregaSubstituto()
        CarregaChefia()
        CarregaElaborador()
        CarregaAprovador()
        txtDescricaoCargo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtResponsabilidades.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtAutoridades.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtEducacao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtEducacao.BackColor = System.Drawing.ColorTranslator.FromHtml("#EAF2FB")
        txtTreinamento.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtTreinamento.BackColor = System.Drawing.ColorTranslator.FromHtml("#EAF2FB")
        txtHabilidade.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtHabilidade.BackColor = System.Drawing.ColorTranslator.FromHtml("#EAF2FB")
        txtExperiencia.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtExperiencia.BackColor = System.Drawing.ColorTranslator.FromHtml("#EAF2FB")
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoCargo()
        'Cadastrar Novo
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "ABAS"

#Region "COMPETENCIAS"

#Region "SALVAR"

    Private Sub botIncluir_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarCadastro.Click

        'Seta a Classe
        Dim cargos As New cargos

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If cargos.Add(idCargos, _
                                  cmbArea.SelectedValue, _
                                  cmbSubstituto.SelectedValue, _
                                  cmbChefiaImediata.SelectedValue, _
                                  txtDescricaoCargo.Text, _
                                  txtEducacao.Text, _
                                  txtTreinamento.Text, _
                                  txtHabilidade.Text, _
                                  txtExperiencia.Text, _
                                  cmbElaborador.SelectedValue, _
                                  dataElaborador.Value, _
                                  cmbAprovadorDados.SelectedValue, _
                                  dataAprovador.Value) Then
                        MessageBox.Show("Cargo atualizado com sucesso", "Cargos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cotrListaCargos.CarregaCargos()
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

        ''Tratamento de erro Cargo
        'If txtCargo.Text = "" Then
        '    MessageBox.Show("Campo Cargo Obrigatório", "Cargo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtCargo.Focus()
        '    verif = True
        '    Exit Sub
        'End If
        ''Tratamento de erro Aprovador
        'If cmbAprovador.Text = "" Then
        '    MessageBox.Show("Campo Aprovador Obrigatório", "Cargo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    cmbAprovador.Focus()
        '    verif = True
        '    Exit Sub
        'End If
        ''Tratamento de erro Situação
        'If optAtivo.Checked = False And optInativo.Checked = False Then
        '    MessageBox.Show("Campo Situação Obrigatório", "Cargo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    verif = True
        '    Exit Sub
        'End If

        verif = False
    End Sub

#End Region

#End Region

#Region "EDITAR"

    Public Sub EditarCargo(ByVal id As Integer)

        'Editar
        isEdit = True

        'Carrega Combos
        TabCompetencias.Show()
        TabEducacao.Show()
        carregaArea()
        carregaSubstituto()
        CarregaChefia()
        CarregaElaborador()
        CarregaAprovador()

        'Seleciona Fornecedor pelo Id
        Dim sql2 As String = String.Format("SELECT * FROM VW_LISTAGEM_CARGOS WHERE ID = {0}", id)


        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql2)

            While dr.Read
                Me.txtCargo.Text = dr("CARGO").ToString
                If dr("APROVADOR") = "Não" Then
                    'Não
                    cmbAprovador.SelectedItem = oprNao
                Else
                    'Sim
                    cmbAprovador.SelectedItem = optSim
                End If
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Seleciona pelo Id
        Dim sql As String = String.Format("SELECT * FROM CARGOS_COMPETENCIAS WHERE ID_CARGOS = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.cmbArea.SelectedValue = dr("SETOR").ToString
                Me.cmbSubstituto.SelectedValue = dr("SUBSTITUTO").ToString
                Me.cmbChefiaImediata.SelectedValue = dr("CHEFIA_IMEDIATA").ToString
                Me.txtDescricaoCargo.Text = dr("DESCRICAO").ToString
                Me.txtEducacao.Text = dr("EDUCACAO").ToString
                Me.txtTreinamento.Text = dr("TREINAMENTO").ToString
                Me.txtHabilidade.Text = dr("HABILIDADE").ToString
                Me.txtExperiencia.Text = dr("EXPERIENCIA").ToString
                Me.cmbElaborador.SelectedValue = dr("ELABORADOR").ToString
                Me.dataElaborador.Value = dr("DATA_ELABORADOR").ToString
                Me.cmbAprovadorDados.SelectedValue = dr("APROVADOR").ToString
                Me.dataAprovador.Value = dr("DATA_APROVADOR").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

#End Region

#Region "RELATORIOS"



#End Region

#End Region

#Region "ATRIBUICOES"

#Region "SALVAR"



#End Region

#End Region

#Region "DOCUMENTOS PARA TREINAMENTO"

#Region "INCLUIR"


#End Region

#Region "EXCLUIR"

    Private Sub botExcluirProc_Click(sender As System.Object, e As System.EventArgs) Handles botExcluirProc.Click
        If griSelecionados.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Cargos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
        End If
    End Sub

#End Region

#End Region

#End Region

End Class
