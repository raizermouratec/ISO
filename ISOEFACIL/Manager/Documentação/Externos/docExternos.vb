Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid

Public Class docExternos

#Region "VARIAVEIS"
    Private ANEXO() As Byte

    ''' Variavel global que contera o valor passado
    Private isEdit As Boolean = False
    Public idExt As String = String.Empty
    Public iddcexternos

    ''' Pega Id Contrato
    Public WriteOnly Property DocExternos() As String
        Set(ByVal value As String)
            Me.iddcexternos = value
        End Set
    End Property

#End Region

#Region "LOAD"

    Private Sub docExternos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaCompoColab()
        CarregaCompoResp()
        carregaLista()
        Me.dthDataUltimaAlteracao.Value = Today
    End Sub
#End Region

#Region "POPULA COMBOS"

    Sub CarregaCompoColab()
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

    Sub CarregaCompoResp()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES_APROVADOR")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboResponsavel.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboResponsavel.DataSource = dtb
        comboResponsavel.DisplayMember = "COLABORADOR"
        comboResponsavel.ValueMember = "ID"
    End Sub

#End Region

#Region "CARREGA LISTA"
    Public Sub carregaLista()

        'Carrega Lista
        gridDocExterno.AutoGenerateColumns = False
        gridDocExterno.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_DOCUMENTO_EXTERNOS")

    End Sub
#End Region

#Region "BOTÕES"
    ''' <summary>
    ''' Anexos.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botAnexo_Click(sender As System.Object, e As System.EventArgs) Handles botAnexo.Click

        Try

            Dim frm As New docAnexosExternos
            Dim id As Integer = 0

            If gridDocExterno.RowSel < 0 Then
                MessageBox.Show("Não à nenhum registro cadastrado", "Documentos Externos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Passagem de parametros
                id = gridDocExterno(gridDocExterno.RowSel, 1)
                frm.idDocExt = id
                frm.NovoDocExt()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' Incluir
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botIncluir_Click(sender As System.Object, e As System.EventArgs) Handles botIncluir.Click
        Dim classe As New ExternosDoc

        If isEdit Then
            'Editar
            Try
                If classe.UpdateDocExt(idExt, _
                                    comboElaboradopor.SelectedValue, _
                                    comboResponsavel.SelectedValue, _
                                    dthDataUltimaAlteracao.Value, _
                                    txtDocumento.Text, _
                                    txtVersao.Text, _
                                    txtFonteorigem.Text, _
                                    txtLocalguarda.Text, _
                                    txtFrequenciaconsulta.Text, _
                                    dthDataUltimaConsulta.Value) Then
                    MessageBox.Show("Dados do Documento Externo Atualizados com sucesso", "Documentos Externos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Chama a Lista
                    carregaLista()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        Else
            'Salvar
            Try
                If classe.AddDocExt(comboElaboradopor.SelectedValue, _
                                    comboResponsavel.SelectedValue, _
                                    dthDataUltimaAlteracao.Value, _
                                    txtDocumento.Text, _
                                    txtVersao.Text, _
                                    txtFonteorigem.Text, _
                                    txtLocalguarda.Text, _
                                    txtFrequenciaconsulta.Text, _
                                    dthDataUltimaConsulta.Value) Then
                    MessageBox.Show("Dados do Documento Externo Atualizados com sucesso", "Documentos Externos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Chama a Lista
                    carregaLista()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    ''' <summary>
    ''' Editar.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click
        EditarExternos(gridDocExterno(gridDocExterno.RowSel, 1))
    End Sub
    ''' <summary>
    ''' Excluir
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click
        Dim classe As New ExternosDoc
        If MsgBox("Deseja realmente Excluir o registro selecionado ?", MsgBoxStyle.YesNo, "Documentos Externos") = MsgBoxResult.Yes Then
            classe.DeleteDocExt(gridDocExterno(gridDocExterno.RowSel, 1))
            carregaLista()
        End If
    End Sub
    ''' <summary>
    ''' Ultima Data.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botUltimaData_Click(sender As System.Object, e As System.EventArgs) Handles botUltimaData.Click
        ' desativaControles()
        '  Me.botIncluir.Text = "Atualizar"

    End Sub
    ''' <summary>
    ''' Visualizar.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botVisualizar_Click(sender As System.Object, e As System.EventArgs) Handles botVisualizar.Click

    End Sub
#End Region

    Private Sub desativaControles()
        'Desativa
        Me.txtDocumento.Enabled = False
        Me.txtVersao.Enabled = False
        Me.txtFonteorigem.Enabled = False
        Me.txtFrequenciaconsulta.Enabled = False
        Me.txtLocalguarda.Enabled = False
        Me.dthDataUltimaConsulta.Enabled = False
        Me.comboResponsavel.Enabled = False

        Me.botEditar.Enabled = False
        Me.botAnexo.Enabled = False
        Me.botExcluir.Enabled = False
        Me.botVisualizar.Enabled = False

        'Ativa
        Me.dthDataUltimaAlteracao.Enabled = True
        Me.comboElaboradopor.Enabled = True
    End Sub

    Private Sub EditarExternos(ByVal id As Integer)

        'Editar
        isEdit = True

        'Seleciona pelo Id
        Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_EXTERNOS WHERE ID_DOCUMENTO_EXTERNOS = '{0}'", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                idExt = dr("ID_DOCUMENTO_EXTERNOS")

                Me.dthDataUltimaAlteracao.Value = dr("DATA_ULTIMA_ALTERACAO")
                Me.comboElaboradopor.SelectedValue = dr("ID_ELABORADOR")
                Me.txtDocumento.Text = dr("DOCUMENTO")
                Me.txtVersao.Text = dr("VERSAO")
                Me.txtFonteorigem.Text = dr("FONTE_ORIGEM")
                Me.txtLocalguarda.Text = dr("LOCAL_GUARDA")
                Me.txtFrequenciaconsulta.Text = dr("FREQUENCIA_CONSULTA")
                Me.comboResponsavel.SelectedValue = dr("ID_COLABORADORES")

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub

End Class
