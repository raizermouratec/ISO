Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Public Class docRegistros

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditRegistros As Boolean = False
    Public idregistros As String
    Public verif As Boolean = False

    'Pega Id Registro
    Public WriteOnly Property Registros() As String
        Set(ByVal value As String)
            Me.idregistros = value
        End Set
    End Property

#End Region

#Region "POPULA COMBOS"

#Region "ELABORADO POR"

    Sub CarregaElaboradoPor()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboElaboradopor.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboElaboradopor.DataSource = dtb
        comboElaboradopor.DisplayMember = "COLABORADOR"
        comboElaboradopor.ValueMember = "ID"
    End Sub

#End Region

#Region "FILTRO POR"

    Sub CarregaFiltroPor()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES_APROVADOR")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboFiltrarpor.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboFiltrarpor.DataSource = dtb
        comboFiltrarpor.DisplayMember = "COLABORADOR"
        comboFiltrarpor.ValueMember = "ID"
    End Sub

#End Region

#Region "AREA DE ELABORACAO"

    Sub CarregaAreaElaboracao()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES_APROVADOR")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboAreaElaboracao.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboAreaElaboracao.DataSource = dtb
        comboAreaElaboracao.DisplayMember = "COLABORADOR"
        comboAreaElaboracao.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub docRegistros_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaElaboradoPor()
        CarregaFiltroPor()
        CarregaAreaElaboracao()
        Me.DthDataUltimaAlteracao.Value = Today
        carregaLista()
    End Sub

#End Region

#Region "CARREGA LISTA"
    Public Sub carregaLista()

        'Carrega Lista
        gridRegistros.AutoGenerateColumns = False
        gridRegistros.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_DOCUMENTO_REGISTROS")

    End Sub
#End Region

#Region "EDITAR"

    Public Sub EditarRegistros(ByVal id As Integer)

        'Editar
        isEdit = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_REGISTROS WHERE ID_DOCUMENTO_REGISTROS = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.DthDataUltimaAlteracao.Value = dr("DATA_ULTIMA_ALTERACAO").ToString
                Me.comboElaboradopor.SelectedValue = dr("ELABORADOR_POR").ToString
                Me.comboFiltrarpor.SelectedValue = dr("FILTRAR_POR").ToString
                Me.txtIdentificacao.Text = dr("IDENTIFICACAO").ToString
                Me.txtArmazenamento.Text = dr("ARMAZENAMENTO").ToString
                Me.txtProtecao.Text = dr("PROTECAO").ToString
                Me.txtRecuperacao.Text = dr("RECUPERACAO").ToString
                Me.txtRetencao.Text = dr("RETENCAO").ToString
                Me.txtDisposicao.Text = dr("DISPOSICAO").ToString
                Me.comboAreaElaboracao.SelectedValue = dr("AREA_ELABORACAO").ToString

            End While
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "BOTOES"

#Region "INCLUIR"

    Private Sub botIncluir_Click(sender As System.Object, e As System.EventArgs) Handles botIncluir.Click

        'Seta a Classe
        Dim registros As New registrosdoc
        Dim dthUltimaConsultas As Date = Today

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            'VerificarDecisoes()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If registros.Update(idregistros, _
                                       DthDataUltimaAlteracao.Value, _
                                       comboElaboradopor.SelectedValue, _
                                       comboFiltrarpor.SelectedValue, _
                                       txtIdentificacao.Text, _
                                       txtArmazenamento.Text, _
                                       txtProtecao.Text, _
                                       txtRecuperacao.Text, _
                                       txtRetencao.Text, _
                                       txtDisposicao.Text, _
                                       dthUltimaConsultas, _
                                       comboAreaElaboracao.SelectedValue) Then
                        MessageBox.Show("Dados do Registro atualizados com sucesso", "Registros", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        carregaLista()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            'Verificar campos obrigatórios
            'VerificarDecisoes()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If registros.Add(DthDataUltimaAlteracao.Value, _
                                        comboElaboradopor.SelectedValue, _
                                        comboFiltrarpor.SelectedValue, _
                                        txtIdentificacao.Text, _
                                        txtArmazenamento.Text, _
                                        txtProtecao.Text, _
                                        txtRecuperacao.Text, _
                                        txtRetencao.Text, _
                                        txtDisposicao.Text, _
                                        dthUltimaConsultas, _
                                        comboAreaElaboracao.SelectedValue) Then
                        MessageBox.Show("Registro salvo com sucesso", "Registros", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        carregaLista()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

    End Sub

#End Region

#Region "ULTIMA DATA"

    Private Sub botUltimaData_Click(sender As System.Object, e As System.EventArgs) Handles botUltimaData.Click

    End Sub

#End Region

#Region "OBSERVACOES"

    Private Sub botObservacoes_Click(sender As System.Object, e As System.EventArgs) Handles botObservacoes.Click

    End Sub

#End Region

#Region "VISUALIZAR"

    Private Sub botVisualizar_Click(sender As System.Object, e As System.EventArgs) Handles botVisualizar.Click

    End Sub

#End Region

#End Region

End Class
