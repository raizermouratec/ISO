Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Net.Mail
Imports Microsoft.Office.Interop
Imports System.Net

Public Class DocContDoc

    '////////////////////////////////GERAL///////////////////////////////////

#Region "VARIAVEIS"
    'Variavel para verificar se a tela já esta aberta 
    Public idVerifivcar_open As Boolean = False
    Public strId As String = String.Empty
    Private allMail As String = String.Empty

    Private codigo As String = String.Empty
    Private revisao As Integer = 0
#End Region

#Region "LOAD"
    Private Sub DocContDoc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ControlaTab()
        carregarLista()
        Tab_Historico.Show()
        filtroTodos.Checked = True
        validaData()
    End Sub
#End Region

#Region "POPULA COMBOS"
    Sub CarregaCombos()
        Try
            'Responsavel Elaboração
            Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_COLABORADORES")
            Dim dtr As DataRow = dtb.NewRow
            dtr("COLABORADOR") = ""

            dtb.Rows.InsertAt(dtr, 0)
            dtb.AcceptChanges()
            With cmbRespElaboracao
                .DataSource = dtb
                .DisplayMember = "COLABORADOR"
                .ValueMember = "ID"
            End With

            'Equipe Elaboração
            Dim dtb1 As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_COLABORADORES")
            Dim dtr1 As DataRow = dtb1.NewRow
            dtr1("COLABORADOR") = ""

            dtb1.Rows.InsertAt(dtr1, 0)
            dtb1.AcceptChanges()
            With cmbEquipeElaboracao
                .DataSource = dtb1
                .DisplayMember = "COLABORADOR"
                .ValueMember = "ID"
            End With

            'Equipe Concenso
            Dim dtb2 As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_COLABORADORES")
            Dim dtr2 As DataRow = dtb2.NewRow
            dtr2("COLABORADOR") = ""

            dtb2.Rows.InsertAt(dtr2, 0)
            dtb2.AcceptChanges()
            With cmbEquipeConcenso
                .DataSource = dtb2
                .DisplayMember = "COLABORADOR"
                .ValueMember = "ID"
            End With

            'Equipe Aprovação
            Dim dtb3 As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_COLABORADORES")
            Dim dtr3 As DataRow = dtb3.NewRow
            dtr3("COLABORADOR") = ""

            dtb3.Rows.InsertAt(dtr3, 0)
            dtb3.AcceptChanges()
            With cmbEquipeAprovacao
                .DataSource = dtb3
                .DisplayMember = "COLABORADOR"
                .ValueMember = "ID"
            End With
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
#End Region

#Region "FILTRO DO GRID"
    ''//TIPO...
    Private Sub filtroTipo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles filtroTipo.CheckedChanged
        Try
            'Responsavel Elaboração
            Dim dtb As DataTable = Manager.Util.getDataTable("SELECT DISTINCT TIPO FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO")
            Dim dtr As DataRow = dtb.NewRow
            dtr("TIPO") = ""

            dtb.Rows.InsertAt(dtr, 0)
            dtb.AcceptChanges()
            With cmbFiltro
                .DataSource = dtb
                .DisplayMember = "TIPO"
                .ValueMember = "TIPO"
            End With
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    ''//TODOS...
    Private Sub filtroTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles filtroTodos.CheckedChanged
        cmbFiltro.DataSource = Nothing
        carregarLista()
    End Sub
    ''//ÁREA...
    Private Sub filtroArea_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles filtroArea.CheckedChanged
        Try
            'Responsavel Elaboração
            Dim dtb As DataTable = Manager.Util.getDataTable("SELECT DISTINCT AREA FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO")
            Dim dtr As DataRow = dtb.NewRow
            dtr("AREA") = ""

            dtb.Rows.InsertAt(dtr, 0)
            dtb.AcceptChanges()
            With cmbFiltro
                .DataSource = dtb
                .DisplayMember = "AREA"
                .ValueMember = "AREA"
            End With
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
#End Region

#Region "FILTRO"
    Private Sub cmbFiltro_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbFiltro.SelectionChangeCommitted
        If cmbFiltro.SelectedValue <> "" Then
            If filtroTipo.Checked Then
                carregarListaTipo(cmbFiltro.SelectedValue)
            ElseIf filtroArea.Checked Then
                carregarListaArea(cmbFiltro.SelectedValue)
            Else
                carregarLista()
            End If
        End If
    End Sub
#End Region

#Region "CONTROLE DE TAB"
    ''' <summary>
    ''' Controla as tabs. 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ControlaTab()
        Dim identifica As String
        Dim check As Boolean
        Try
            Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_ATIVIDADE_TP_DOCUMENTO")
            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)
            While dr.Read
                identifica = dr("IDENTIFICACAO").ToString
                check = dr("CHECK")
                If identifica <> "" Then
                    Select Case identifica
                        Case "Aprovação"
                            If check = True Then
                                Tab_Aprovacao.Enabled = True
                            Else
                                Tab_Aprovacao.Enabled = False
                            End If
                        Case "Elaboração"
                            If check = True Then
                                Tab_Elaboracao.Enabled = True
                            Else
                                Tab_Elaboracao.Enabled = False
                            End If
                        Case Else
                            If check = True Then
                                Tab_Consenso.Enabled = True
                            Else
                                Tab_Consenso.Enabled = False
                            End If
                    End Select
                End If
            End While
            CarregaCombos()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
#End Region

#Region "CARREGAR LISTA"
    '// Carrega Histótico...
    Public Sub CarregaHistorico()
        'Ocorrencias [Emissão]/[Alterado da 0 para a 1]...
        Dim dt As New DataTable
        Try
            Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_DOCUMENTO_CONTROLE_HISTORICO WHERE CODIGO = '{0}'", codigo)
            dt = Manager.Util.getDataTableById(sql)

            'Monta o Grid
            gridDocHistorico.AutoGenerateColumns = False
            gridDocHistorico.DataSource = Manager.Util.getDataTable(sql)

        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    'Carrega lista de documentos..
    Public Sub carregarLista()
        Dim dt As New DataTable
        Dim i As Integer = 1
        Try
            Dim sqlId As String = String.Format("SELECT * FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO")
            dt = Manager.Util.getDataTableById(sqlId)

            'Monta o Grid
            gridProcedimentos.AutoGenerateColumns = False
            gridProcedimentos.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO")

            'Função para validação de Imagem
            For Each dr As DataRow In dt.Rows
                If dr("ARQUIVO") = "docx" Then
                    gridProcedimentos.SetCellImage(i, 12, _imgListLegenda.Images.Item(1))
                Else
                    gridProcedimentos.SetCellImage(i, 12, _imgListLegenda.Images.Item(2))
                End If
                i += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    'Carrega lista de documentos por Tipo...
    Public Sub carregarListaTipo(ByVal tipo As String)
        Dim dt As New DataTable
        Dim i As Integer = 1
        Try
            Dim sqlId As String = String.Format("SELECT * FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO WHERE TIPO = '{0}'", tipo)
            dt = Manager.Util.getDataTableById(sqlId)

            'Monta o Grid
            gridProcedimentos.AutoGenerateColumns = False
            Dim sql As String = String.Format("SELECT * FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO WHERE TIPO = '{0}'", tipo)
            gridProcedimentos.DataSource = Manager.Util.getDataTable(sql)

            'Função para validação de Imagem
            For Each dr As DataRow In dt.Rows
                If dr("ARQUIVO") = "docx" Then
                    gridProcedimentos.SetCellImage(i, 12, _imgListLegenda.Images.Item(1))
                Else
                    gridProcedimentos.SetCellImage(i, 12, _imgListLegenda.Images.Item(2))
                End If
                i += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    'Carrega lista de documentos por Area...
    Public Sub carregarListaArea(ByVal area As String)
        Dim dt As New DataTable
        Dim i As Integer = 1
        Try
            Dim sqlId As String = String.Format("SELECT * FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO WHERE AREA = '{0}'", area)
            dt = Manager.Util.getDataTableById(sqlId)

            'Monta o Grid
            gridProcedimentos.AutoGenerateColumns = False
            Dim sql As String = String.Format("SELECT * FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO WHERE AREA = '{0}'", area)
            gridProcedimentos.DataSource = Manager.Util.getDataTable(sql)

            'Função para validação de Imagem
            For Each dr As DataRow In dt.Rows
                If dr("ARQUIVO") = "docx" Then
                    gridProcedimentos.SetCellImage(i, 12, _imgListLegenda.Images.Item(1))
                Else
                    gridProcedimentos.SetCellImage(i, 12, _imgListLegenda.Images.Item(2))
                End If
                i += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    'Equipe de elaboração...
    Private Sub carregaListaEquipeElab()
        'Monta o Grid
        gridEquipElab.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_DOCUMENTO_CONTROLE_ELAB_EQUIPE WHERE CODIGO_CONTROLE = '{0}' AND REVISAO = {1}", codigo, revisao)
        gridEquipElab.DataSource = Manager.Util.getDataTable(sql)

        Dim sql1 As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_ELAB WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)

        'Popula os campos com os dados do Banco
        Try
            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql1)
            While dr.Read
                Me.cmbRespElaboracao.SelectedValue = dr("ID_COLABORADORES")
                If dr("DATA_CONCLUSAO") Is DBNull.Value Then
                    dthElaboracaoConcluida.Value = Date.MinValue
                    dthElaboracaoConcluida.ValueIsNull = True
                Else
                    Me.dthElaboracaoConcluida.Value = dr("DATA_CONCLUSAO")
                End If
                If dr("DATA_MENSAGEM") Is DBNull.Value Then
                    dthSendElab.Value = Date.MinValue
                    dthSendElab.ValueIsNull = True
                Else
                    Me.dthSendElab.Value = dr("DATA_MENSAGEM")
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub
    'Equipe de consenco...
    Private Sub carregaListaEquipeConsenco()
        'Monta o Grid
        gridEquipeConsenso.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_DOCUMENTO_CONTROLE_CONSENC_EQUIPE WHERE CODIGO_CONTROLE = '{0}' AND REVISAO = {1}", codigo, revisao)
        gridEquipeConsenso.DataSource = Manager.Util.getDataTable(sql)

        Dim sql1 As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_CONSENC WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)

        'Popula os campos com os dados do Banco
        Try
            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql1)
            While dr.Read
                If dr("DATA_CONCLUSAO") Is DBNull.Value Then
                    dthConsensoConcluida.Value = Date.MinValue
                    dthConsensoConcluida.ValueIsNull = True
                Else
                    Me.dthConsensoConcluida.Value = dr("DATA_CONCLUSAO")
                End If
                If dr("DATA_MENSAGEM") Is DBNull.Value Then
                    dthSendConsenso.Value = Date.MinValue
                    dthSendConsenso.ValueIsNull = True
                Else
                    Me.dthSendConsenso.Value = dr("DATA_MENSAGEM")
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub
    'Equipe de Aprovação...
    Private Sub carregaListaEquipeAprovacao()
        'Monta o Grid
        gridEquipAprovacao.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_DOCUMENTO_CONTROLE_APROVA_EQUIPE WHERE CODIGO_CONTROLE = '{0}' AND REVISAO = {1}", codigo, revisao)
        gridEquipAprovacao.DataSource = Manager.Util.getDataTable(sql)

        Dim sql1 As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_APROVA WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)

        'Popula os campos com os dados do Banco
        Try
            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql1)
            While dr.Read
                If dr("DATA_CONCLUSAO") Is DBNull.Value Then
                    dthAprovacaoConcluida.Value = Date.MinValue
                    dthAprovacaoConcluida.ValueIsNull = True
                Else
                    Me.dthAprovacaoConcluida.Value = dr("DATA_CONCLUSAO")
                End If
                If dr("DATA_MENSAGEM") Is DBNull.Value Then
                    dthSendAprocacao.Value = Date.MinValue
                    dthSendAprocacao.ValueIsNull = True
                Else
                    Me.dthSendAprocacao.Value = dr("DATA_MENSAGEM")
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub
    'Equipe de Publicação...
    Private Sub carregaListaEquipePublicacao()
        'Monta o Grid
        gridEquipPublicacao.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_DOCUMENTO_CONTROLE_PUBLICACAO_EQUIPE WHERE CODIGO_CONTROLE = '{0}' AND REVISAO = {1}", codigo, revisao)
        gridEquipPublicacao.DataSource = Manager.Util.getDataTable(sql)

        Dim sql1 As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_PUBLICACAO WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)

        'Popula os campos com os dados do Banco
        Try
            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql1)
            While dr.Read
                If dr("DATA_CONCLUSAO") Is DBNull.Value Then
                    dthPublicacaoConcluida.Value = Date.MinValue
                    dthPublicacaoConcluida.ValueIsNull = True
                Else
                    Me.dthAprovacaoConcluida.Value = dr("DATA_CONCLUSAO")
                End If
                If dr("DATA_MENSAGEM") Is DBNull.Value Then
                    dthSendPublicacao.Value = Date.MinValue
                    dthSendPublicacao.ValueIsNull = True
                Else
                    Me.dthSendPublicacao.Value = dr("DATA_MENSAGEM")
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "VALIDA DATAS"
    Private Sub validaData()
        '//Conclusao Elab...
        dthElaboracaoConcluida.Value = Date.MinValue
        dthElaboracaoConcluida.ValueIsNull = True
        '//Conclusao Consenso...
        dthConsensoConcluida.Value = Date.MinValue
        dthConsensoConcluida.ValueIsNull = True
        '//Conclusao Aprovação...
        dthAprovacaoConcluida.Value = Date.MinValue
        dthAprovacaoConcluida.ValueIsNull = True
        '/////////////////////////////////////
        '//Email elab...
        dthSendElab.Value = Date.MinValue
        dthSendElab.ValueIsNull = True
        '//Email consenso...
        dthSendConsenso.Value = Date.MinValue
        dthSendConsenso.ValueIsNull = True
        '//Email publicacao...
        dthSendPublicacao.Value = Date.MinValue
        dthSendPublicacao.ValueIsNull = True
        '//Email aprovacao...
        dthSendAprocacao.Value = Date.MinValue
        dthSendAprocacao.ValueIsNull = True
    End Sub
#End Region

#Region "BOTÕES"
    ''' <summary>
    ''' Controle de Novo Documento...
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botNovo_Click(sender As System.Object, e As System.EventArgs) Handles botNovo.Click
        Dim frm As New docCadDocNovo
        frm.Novo()
    End Sub
    ''' <summary>
    ''' Controle de Edição de Documentos...
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botEdit_Click(sender As System.Object, e As System.EventArgs) Handles botEdit.Click
        ''Controle de Revisao
        'If MsgBox("Deseja alterar a Revisão?", MsgBoxStyle.YesNo, "Projeto") = MsgBoxResult.Yes Then
        '    If Me.txtRevisao.Text < 9 Then
        '        Me.txtRevisao.Text = Me.txtRevisao.Text + 1
        '        Me.txtRevisao.Text = "0" & Me.txtRevisao.Text
        '    Else
        '        Me.txtRevisao.Text = Me.txtRevisao.Text + 1
        '    End If
        'End If
    End Sub
    ''' <summary>
    ''' Controle de revisão...
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botRevisao_Click(sender As System.Object, e As System.EventArgs) Handles botRevisao.Click
        Dim frm As New docContRevisar
        Dim id As Integer = 0
        Dim revisao As Integer = 0
        If gridProcedimentos.RowSel < 0 Then
            MessageBox.Show("Não à nenhum Documento Cadastrado", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim _result As DialogResult = MessageBox.Show("Deseja alterar a Revisão?", "Documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If _result = Windows.Forms.DialogResult.Yes Then
                Try
                    id = gridProcedimentos(gridProcedimentos.RowSel, 1)
                    revisao = gridProcedimentos(gridProcedimentos.RowSel, 6)
                    frm.idDoc = id
                    frm.Revisao = revisao
                    frm.AbriTela()
                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf)
                End Try
            End If
        End If
    End Sub
    ''' <summary>
    ''' Controle de Cancelamento do Documento...
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botCancelar_Click(sender As System.Object, e As System.EventArgs) Handles botCancelar.Click
        Dim frm As New docContCancelar
        Dim id As Integer = 0
        Dim i As Integer = 1

        Try
            If gridProcedimentos.RowSel < 0 Then
                MessageBox.Show("Não à nenhum Documento Cadastrado", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                '//Pega o Id...
                id = gridProcedimentos(gridProcedimentos.RowSel, 1)

                '//Verificar situação...
                Dim dtb As DataTable
                Dim sqlId As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_DOCUMENTO WHERE ID_DOCUMENTO_CONTROLE_DOCUMENTO={0}", id)
                dtb = Manager.Util.getDataTableById(sqlId)
                For Each dr As DataRow In dtb.Rows
                    If dr("SITUACAO") = "Em cancelamento" Then
                        MessageBox.Show("Documento com situação: Em cancelamento." & vbCrLf & "Este documento não pode ser Cancelado.", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    ElseIf dr("SITUACAO") = "Cancelado" Then
                        MessageBox.Show("Documento com Cancelado", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    End If
                    i += 1
                Next

                Dim _result As DialogResult = MessageBox.Show("Deseja Cancelar o Documento ?", "Documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If _result = Windows.Forms.DialogResult.No Then
                Else
                    Try
                        frm.idDoc = id
                        frm.AbriTela()
                    Catch ex As Exception
                        MsgBox(ex.Message & vbCrLf)
                    End Try
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    ''' <summary>
    ''' Controle de Salvar em...
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botSalvarEm_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarEm.Click
        Dim documentLocation As String = String.Empty
        Dim dt As DataTable
        Dim i As Integer = 1
        Dim id As String = String.Empty

        Dim salvarComo As SaveFileDialog = New SaveFileDialog()
        Dim caminho As DialogResult
        Dim Arquivo As String

        Try
            If gridProcedimentos.RowSel < 0 Then
                MessageBox.Show("Não à nenhum Documento cadastrado", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                id = gridProcedimentos(gridProcedimentos.RowSel, 2)
                Dim sqlId As String = String.Format("SELECT * FROM DOCUMENTO_BD WHERE CODIGO = '{0}'", id.Trim())

                dt = Manager.Util.getDataTableById(sqlId)
                For Each dr As DataRow In dt.Rows
                    documentLocation = dr("DOCUMENTO_FISICO")
                    i += 1
                Next

                Dim nomeDoc As String = documentLocation
                salvarComo.CheckFileExists = False
                '//Pasta fixa...
                salvarComo.Title = nomeDoc.Replace("C:\ISOEFACIL\Formularios\word\", "")
                salvarComo.FileName = salvarComo.Title
                caminho = salvarComo.ShowDialog
                Arquivo = salvarComo.FileName

                If Arquivo = Nothing Then
                    MessageBox.Show("Arquivo Inválido", "Salvar Como", MessageBoxButtons.OK)
                Else
                    If File.Exists(documentLocation) = True Then
                        File.Copy(documentLocation, Arquivo)
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    ''' <summary>
    ''' Aprova em definitivo o documento...
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botAprovar_Click(sender As System.Object, e As System.EventArgs) Handles botAprovar.Click
        Dim classe As New documentos
        Dim situacao As String = String.Empty
        Dim NovaRevisao As Integer = revisao + 1

        '//Valida o Grid...
        If gridProcedimentos.RowSel < 0 Then
            MessageBox.Show("Não à nenhum documento selecionado.", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Try
                '//valida Status...
                situacao = gridProcedimentos(gridProcedimentos.RowSel, 7) '//Seleção do status...
                Select Case situacao
                    Case "Aprovado"
                        MessageBox.Show("Execute a Revisão do Documento!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    Case "Cadastrado"
                        MessageBox.Show("O Documento ainda não foi Elaborado!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    Case "Cancelado"
                        MessageBox.Show("Documento Cancelado!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    Case "Em Elaboração"
                        MessageBox.Show("Documento Em elaboração, finalize o processo!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    Case "Em Revisão"
                        '//Verificar se o documento foi aprovado...
                        Dim sql As String = String.Format("SELECT DATA_CONCLUSAO FROM DOCUMENTO_CONTROLE_APROVA WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                        Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
                        If dtb.Rows.Count <= 0 Then
                            MessageBox.Show("O Documento ainda não foi Aprovado!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Else
                            Dim _result As DialogResult = MessageBox.Show("Deseja Aprovar o Documento?", "Documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If _result = Windows.Forms.DialogResult.Yes Then
                                'muda status para [Aprovado]
                                ValidaHistorico(codigo, revisao, NovaRevisao, "Aprovado")
                                classe.UpdateRevisao(codigo, revisao, NovaRevisao, "Aprovado")
                                MessageBox.Show("Documento Aprovado com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                carregarLista()
                                CarregaHistorico()
                            End If
                        End If
                    Case "Em cancelamento"
                        '//Verificar se o documento foi aprovado...
                        Dim sql As String = String.Format("SELECT DATA_CONCLUSAO FROM DOCUMENTO_CONTROLE_APROVA WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                        Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
                        If dtb.Rows.Count <= 0 Then
                            MessageBox.Show("O Documento ainda não foi Aprovado!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Else
                            Dim _result As DialogResult = MessageBox.Show("Deseja Aprovar o Documento?", "Documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If _result = Windows.Forms.DialogResult.Yes Then
                                'muda status para [Cancelado]
                                ValidaHistorico(codigo, revisao, NovaRevisao, "Cancelado")
                                classe.UpdateRevisao(codigo, revisao, NovaRevisao, "Cancelado")
                                MessageBox.Show("O Documento foi Cancelado!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                carregarLista()
                                CarregaHistorico()
                            End If
                        End If
                    Case "Não Finalizado"
                        '//Verificar se o documento foi aprovado...
                        Dim sql As String = String.Format("SELECT DATA_CONCLUSAO FROM DOCUMENTO_CONTROLE_APROVA WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                        Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
                        If dtb.Rows.Count <= 0 Then
                            MessageBox.Show("O Documento ainda não foi Aprovado!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Else
                            '//Verificar se o documento foi Elaborado...
                            Dim sql1 As String = String.Format("SELECT DATA_CONCLUSAO FROM DOCUMENTO_CONTROLE_ELAB WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                            Dim dtb1 As DataTable = Manager.Util.getDataTableById(sql)
                            If dtb.Rows.Count <= 0 Then
                                MessageBox.Show("O Documento ainda não foi Aprovado!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                Exit Sub
                            Else
                                '//Verificar se o documento foi Consensado...
                                Dim sql2 As String = String.Format("SELECT DATA_CONCLUSAO FROM DOCUMENTO_CONTROLE_CONSENC WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                                Dim dtb2 As DataTable = Manager.Util.getDataTableById(sql)
                                If dtb.Rows.Count <= 0 Then
                                    MessageBox.Show("O Documento ainda não foi Aprovado!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                    Exit Sub
                                Else
                                    Dim _result As DialogResult = MessageBox.Show("Deseja Aprovar o Documento?", "Documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                    If _result = Windows.Forms.DialogResult.Yes Then
                                        'muda status para [Aprovado]
                                        ValidaHistorico(codigo, revisao, NovaRevisao, "Aprovado")
                                        classe.UpdateRevisao(codigo, revisao, NovaRevisao, "Aprovado")
                                        MessageBox.Show("Documento Aprovado com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        carregarLista()
                                        CarregaHistorico()
                                    End If
                                End If
                            End If
                        End If
                End Select
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf)
            End Try
        End If
    End Sub
#End Region

#Region "EVENTO DO GRID"
    'Abrir documentos...
    Private Sub gridProcedimentos_Click(sender As System.Object, e As System.EventArgs) Handles gridProcedimentos.Click
        Try
            '//seleciona documento e revisao
            codigo = gridProcedimentos(gridProcedimentos.RowSel, 2).ToString.Trim()
            revisao = gridProcedimentos(gridProcedimentos.RowSel, 6)

            CarregaHistorico()
            carregaListaEquipeElab()
            carregaListaEquipeConsenco()
            carregaListaEquipeAprovacao()
            carregaListaEquipePublicacao()

            Dim documentLocation As String = String.Empty
            With gridProcedimentos
                If .GetData(.RowSel, .ColSel) = "docx" Then
                    Dim _result As DialogResult = MessageBox.Show("Deseja visualizar o documento?", "Documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If _result = Windows.Forms.DialogResult.Yes Then
                        Try
                            Dim objWord = New Microsoft.Office.Interop.Word.Application()
                            Dim objDoc = New Word.Document
                            Dim dt As DataTable
                            Dim i As Integer = 1
                            Dim id As String = String.Empty
                            id = gridProcedimentos(.RowSel, 2)
                            Dim sqlId As String = String.Format("SELECT * FROM DOCUMENTO_BD WHERE CODIGO = '{0}'", id.Trim())
                            dt = Manager.Util.getDataTableById(sqlId)
                            For Each dr As DataRow In dt.Rows
                                documentLocation = dr("DOCUMENTO_FISICO")
                                i += 1
                            Next
                            If Dir(documentLocation) <> "" Then
                                If System.IO.File.Exists(documentLocation) = True Then
                                    objDoc = objWord.Documents.Open(documentLocation, Visible:=True)
                                    objWord.Visible = True
                                Else
                                    objDoc.Close()
                                    objWord.Quit()
                                    objWord = Nothing
                                    objDoc = Nothing
                                    MsgBox("O documento não se encontra no diretório", vbCritical, "ATENÇÃO")
                                    Exit Sub
                                End If
                            Else
                                objDoc.Close()
                                objWord.Quit()
                                objWord = Nothing
                                objDoc = Nothing
                                MsgBox("O documento não se encontra no diretório", vbCritical, "ATENÇÃO")
                                Exit Sub
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message & vbCrLf)
                        End Try
                    End If
                Else
                End If
            End With
        Catch ex As Exception
            'MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
#End Region

    '/////////////////////////////////////////////////////////////////////////

    '////////////////////////////////ABAS///////////////////////////////////

#Region "HISTÓRICO"
    '//Resumo...
    Private Sub botResumoHistorico_Click(sender As System.Object, e As System.EventArgs) Handles botResumoHistorico.Click

    End Sub
    '// Grid Histórico...
    Private Sub gridDocHistorico_Click(sender As System.Object, e As System.EventArgs) Handles gridDocHistorico.Click
        '//seleciona documento e revisao
        codigo = gridDocHistorico(gridDocHistorico.RowSel, 2).ToString.Trim()
        revisao = gridDocHistorico(gridDocHistorico.RowSel, 3)
        carregaListaEquipeElab()
        carregaListaEquipeConsenco()
        carregaListaEquipeAprovacao()
        carregaListaEquipePublicacao()
    End Sub
#End Region

#Region "ELABORAÇÃO"

    '//Salvar...
    Private Sub botSalvarElab_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarElab.Click
        Dim classe As New documentos
        Dim situacao As String = String.Empty

        'Validação...
        Try
            '//Grid
            If gridProcedimentos.RowSel < 0 Then
                MessageBox.Show("Não à nenhum documento selecionado.", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Try
                    '//Status...
                    situacao = gridProcedimentos(gridProcedimentos.RowSel, 7) '//Seleção do status...
                    Select Case situacao
                        Case "Cadastrado"
                            Try
                                strId = classe.AddControleElab(cmbRespElaboracao.SelectedValue, codigo, revisao, dthElaboracaoConcluida.Value, dthSendElab.Value)
                                If strId <> String.Empty Then
                                    'muda status para [Em elaboração]
                                    classe.UpdateSituacaoRevisao(codigo, revisao, "Não Finalizado")
                                    ' classe.UpdateEquipeControleElab(codigo)
                                    carregarLista()
                                    InputMsgElab.Enabled = True
                                    MessageBox.Show("Elaboração salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    MessageBox.Show("A ação não pode ser realizada. Verifique!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message & vbCrLf)
                            End Try
                        Case "Não Finalizado"
                            Try
                                Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_ELAB WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                                Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
                                If dtb.Rows.Count <= 0 Then
                                    strId = classe.AddControleElab(cmbRespElaboracao.SelectedValue, codigo, revisao, dthElaboracaoConcluida.Value, dthSendElab.Value)
                                    If strId <> String.Empty Then
                                        classe.UpdateSituacaoRevisao(codigo, revisao, "Não Finalizado")
                                        carregarLista()
                                        InputMsgElab.Enabled = True
                                        MessageBox.Show("Elaboração salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        MessageBox.Show("A ação não pode ser realizada. Verifique!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                    End If
                                Else
                                    classe.UpdateControleElab(cmbRespElaboracao.SelectedValue, codigo, revisao, dthElaboracaoConcluida.Value)
                                    carregarLista()
                                    InputMsgElab.Enabled = True
                                    MessageBox.Show("Alteração salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message & vbCrLf)
                            End Try
                        Case "Em elaboração"
                            MessageBox.Show("Documento Em elaboração, finalize o processo!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Case "Em revisão"
                            '//chamar rotina de revisao...
                        Case "Em cancelamento"
                            MessageBox.Show("Documento em cancelamento, finalize o processo!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Case "Cancelado"
                            MessageBox.Show("Documento Cancelado!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Case "Aprovado"
                            Try
                                Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_ELAB WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                                Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
                                If dtb.Rows.Count <= 0 Then
                                    strId = classe.AddControleElab(cmbRespElaboracao.SelectedValue, codigo, revisao, dthElaboracaoConcluida.Value, dthSendElab.Value)
                                    If strId <> String.Empty Then
                                        classe.UpdateSituacaoRevisao(codigo, revisao, "Não Finalizado")
                                        carregarLista()
                                        InputMsgElab.Enabled = True
                                        MessageBox.Show("Elaboração salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        MessageBox.Show("A ação não pode ser realizada. Verifique!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                    End If
                                Else
                                    classe.UpdateControleElab(cmbRespElaboracao.SelectedValue, codigo, revisao, dthElaboracaoConcluida.Value)
                                    carregarLista()
                                    InputMsgElab.Enabled = True
                                    MessageBox.Show("Alteração salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message & vbCrLf)
                            End Try
                    End Select
                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    '//Relatório...
    Private Sub botRelatorioElab_Click(sender As System.Object, e As System.EventArgs) Handles botRelatorioElab.Click

    End Sub
    '//controle de email...
    Private Sub optSendRespElab_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles optSendRespElab.SelectedIndexChanged
        If optSendRespElab.Checked Then
            allMail = "R"
        End If
    End Sub
    '//controle de email...
    Private Sub optSendTodosElab_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles optSendTodosElab.SelectedIndexChanged
        If optSendTodosElab.Checked Then
            allMail = "T"
        End If
    End Sub

#Region "EQUIPE"
    '//Add lista Equipe de Elaboração...
    Private Sub btaddequipelaboracao_click(sender As System.Object, e As System.EventArgs) Handles btAddEquipElaboracao.Click
        Dim classe As New documentos
        Try
            If cmbEquipeElaboracao.Text = "" Then
                MessageBox.Show("Selecione um colaborador.", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbEquipeElaboracao.Focus()
                Exit Sub
            Else
                If classe.AddEquipeControleElab(cmbEquipeElaboracao.SelectedValue, cmbEquipeElaboracao.Text, codigo, revisao) Then
                    carregaListaEquipeElab()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    '//Delete lista Equipe de Elaboração...
    Private Sub btRetiraEquipElaboracao_Click(sender As System.Object, e As System.EventArgs) Handles btRetiraEquipElaboracao.Click
        Dim classe As New documentos
        Dim id As Integer = 0
        Try
            If gridEquipElab.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                id = gridEquipElab(gridEquipElab.RowSel, 1)
                If classe.DeleteEquipeControleElab(id) Then
                    carregaListaEquipeElab()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
#End Region

#End Region

#Region "CONSENSO"

    '//Salvar...
    Private Sub botSalvarConsenso_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarConsenso.Click
        Dim classe As New documentos
        Dim situacao As String = String.Empty
        Try
            '//Grid
            If gridProcedimentos.RowSel < 0 Then
                MessageBox.Show("Não à nenhum documento selecionado.", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Try
                    '//Status...
                    situacao = gridProcedimentos(gridProcedimentos.RowSel, 7) '//Seleção do status...
                    Select Case situacao
                        Case "Cadastrado"
                            Try
                                strId = classe.AddControleConsenso(codigo, revisao, dthConsensoConcluida.Value, dthSendConsenso.Value)
                                If strId <> String.Empty Then
                                    'muda status para [Em elaboração]
                                    classe.UpdateSituacaoRevisao(codigo, revisao, "Não Finalizado")
                                    carregarLista()
                                    InputMsgConsenso.Enabled = True
                                    MessageBox.Show("Consenso salvo com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    MessageBox.Show("A ação não pode ser realizada. Verifique!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message & vbCrLf)
                            End Try
                        Case "Não Finalizado"
                            Try
                                Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_CONSENC WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                                Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
                                If dtb.Rows.Count <= 0 Then
                                    strId = classe.AddControleConsenso(codigo, revisao, dthConsensoConcluida.Value, dthSendConsenso.Value)
                                    If strId <> String.Empty Then
                                        'muda status para [Em elaboração]
                                        classe.UpdateSituacaoRevisao(codigo, revisao, "Não Finalizado")
                                        carregarLista()
                                        InputMsgConsenso.Enabled = True
                                        MessageBox.Show("Consenso salvo com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        MessageBox.Show("A ação não pode ser realizada. Verifique!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                    End If
                                Else
                                    classe.UpdateControleConsenso(codigo, revisao, dthConsensoConcluida.Value)
                                    carregarLista()
                                    InputMsgElab.Enabled = True
                                    MessageBox.Show("Alteração salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message & vbCrLf)
                            End Try
                        Case "Em elaboração"
                            MessageBox.Show("Documento Em elaboração, finalize o processo!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Case "Em revisão"
                            '//chamar rotina de revisao...
                        Case "Em cancelamento"
                            MessageBox.Show("Documento em cancelamento, finalize o processo!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Case "Cancelado"
                            MessageBox.Show("Documento Cancelado!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Case "Aprovado"
                            '** VALIDAR SE DESEJA ALTERAR REVISAO...
                            Try
                                Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_CONSENC WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                                Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
                                If dtb.Rows.Count <= 0 Then
                                    strId = classe.AddControleConsenso(codigo, revisao, dthConsensoConcluida.Value, dthSendConsenso.Value)
                                    If strId <> String.Empty Then
                                        'muda status para [Em elaboração]
                                        classe.UpdateSituacaoRevisao(codigo, revisao, "Não Finalizado")
                                        carregarLista()
                                        InputMsgConsenso.Enabled = True
                                        MessageBox.Show("Consenso salvo com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        MessageBox.Show("A ação não pode ser realizada. Verifique!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                    End If
                                Else
                                    classe.UpdateControleConsenso(codigo, revisao, dthConsensoConcluida.Value)
                                    carregarLista()
                                    InputMsgElab.Enabled = True
                                    MessageBox.Show("Alteração salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message & vbCrLf)
                            End Try
                    End Select
                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    '//Relatório...
    Private Sub botRelatorioCons_Click(sender As System.Object, e As System.EventArgs) Handles botRelatorioCons.Click

    End Sub

#Region "EQUIPE"
    '//Add lista Equipe Consenso...
    Private Sub btAddEquipConsenso_Click(sender As System.Object, e As System.EventArgs) Handles btAddEquipConsenso.Click
        Dim classe As New documentos
        Try
            If cmbEquipeConcenso.Text = "" Then
                MessageBox.Show("selecione um colaborador", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbEquipeConcenso.Focus()
                Exit Sub
            Else
                If classe.AddEquipeControleConsenc(cmbEquipeConcenso.SelectedValue, cmbEquipeConcenso.Text, codigo, revisao) Then
                    carregaListaEquipeConsenco()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    '//Retira lista Equipe Consenso...
    Private Sub btRetiraEquipConsenso_Click(sender As System.Object, e As System.EventArgs) Handles btRetiraEquipConsenso.Click
        Dim classe As New documentos
        Dim id As Integer = 0
        Try
            If gridEquipeConsenso.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                id = gridEquipeConsenso(gridEquipeConsenso.RowSel, 1)
                If classe.DeleteEquipeControleConsenc(id) Then
                    carregaListaEquipeConsenco()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
#End Region

#End Region

#Region "APROVAÇÃO"
    '//Salvar...
    Private Sub botAprovacao_Click(sender As System.Object, e As System.EventArgs) Handles botAprovacao.Click
        Dim classe As New documentos
        Dim situacao As String = String.Empty
        Try
            '//Grid
            If gridProcedimentos.RowSel < 0 Then
                MessageBox.Show("Não à nenhum documento selecionado.", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Try
                    '//Status...
                    situacao = gridProcedimentos(gridProcedimentos.RowSel, 7) '//Seleção do status...
                    Select Case situacao
                        Case "Cadastrado"
                            Try
                                strId = classe.AddControleAprovacao(codigo, revisao, dthAprovacaoConcluida.Value, dthSendAprocacao.Value)
                                If strId <> String.Empty Then
                                    'muda status para [Em elaboração]
                                    classe.UpdateSituacaoRevisao(codigo, revisao, "Não Finalizado")
                                    carregarLista()
                                    InputMsgAprovacao.Enabled = True
                                    MessageBox.Show("Aprovação salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    MessageBox.Show("A ação não pode ser realizada. Verifique!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message & vbCrLf)
                            End Try
                        Case "Não Finalizado"
                            Try
                                Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_APROVA WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                                Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
                                If dtb.Rows.Count <= 0 Then
                                    strId = classe.AddControleAprovacao(codigo, revisao, dthAprovacaoConcluida.Value, dthSendAprocacao.Value)
                                    If strId <> String.Empty Then
                                        'muda status para [Em elaboração]
                                        classe.UpdateSituacaoRevisao(codigo, revisao, "Não Finalizado")
                                        carregarLista()
                                        InputMsgAprovacao.Enabled = True
                                        MessageBox.Show("Aprovação salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        MessageBox.Show("A ação não pode ser realizada. Verifique!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                    End If
                                Else
                                    classe.UpdateControleAprovacao(codigo, revisao, dthAprovacaoConcluida.Value)
                                    carregarLista()
                                    InputMsgElab.Enabled = True
                                    MessageBox.Show("Alteração salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message & vbCrLf)
                            End Try
                        Case "Em elaboração"
                            MessageBox.Show("Documento Em elaboração, finalize o processo!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Case "Em Revisão"
                            Try
                                Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_APROVA WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                                Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
                                If dtb.Rows.Count <= 0 Then
                                    strId = classe.AddControleAprovacao(codigo, revisao, dthAprovacaoConcluida.Value, dthSendAprocacao.Value)
                                    If strId <> String.Empty Then
                                        'muda status para [Em elaboração]
                                        classe.UpdateSituacaoRevisao(codigo, revisao, "Em Revisão")
                                        carregarLista()
                                        InputMsgAprovacao.Enabled = True
                                        MessageBox.Show("Aprovação salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        MessageBox.Show("A ação não pode ser realizada. Verifique!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                    End If
                                Else
                                    classe.UpdateControleAprovacao(codigo, revisao, dthAprovacaoConcluida.Value)
                                    carregarLista()
                                    InputMsgElab.Enabled = True
                                    MessageBox.Show("Alteração salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message & vbCrLf)
                            End Try
                        Case "Em Cancelamento"
                            Try
                                Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_APROVA WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                                Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
                                If dtb.Rows.Count <= 0 Then
                                    strId = classe.AddControleAprovacao(codigo, revisao, dthAprovacaoConcluida.Value, dthSendAprocacao.Value)
                                    If strId <> String.Empty Then
                                        'muda status para []
                                        classe.UpdateSituacaoRevisao(codigo, revisao, "Em Cancelamento")
                                        carregarLista()
                                        InputMsgAprovacao.Enabled = True
                                        MessageBox.Show("Aprovação salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        MessageBox.Show("A ação não pode ser realizada. Verifique!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                    End If
                                Else
                                    classe.UpdateControleAprovacao(codigo, revisao, dthAprovacaoConcluida.Value)
                                    carregarLista()
                                    InputMsgElab.Enabled = True
                                    MessageBox.Show("Alteração salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message & vbCrLf)
                            End Try
                        Case "Cancelado"
                            MessageBox.Show("Documento Cancelado!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Case "Aprovado"
                            Try
                                Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_APROVA WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                                Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
                                If dtb.Rows.Count <= 0 Then
                                    strId = classe.AddControleAprovacao(codigo, revisao, dthAprovacaoConcluida.Value, dthSendAprocacao.Value)
                                    If strId <> String.Empty Then
                                        'muda status para [Em elaboração]
                                        classe.UpdateSituacaoRevisao(codigo, revisao, "Não Finalizado")
                                        carregarLista()
                                        InputMsgAprovacao.Enabled = True
                                        MessageBox.Show("Aprovação salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        MessageBox.Show("A ação não pode ser realizada. Verifique!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                    End If
                                Else
                                    classe.UpdateControleAprovacao(codigo, revisao, dthAprovacaoConcluida.Value)
                                    carregarLista()
                                    InputMsgElab.Enabled = True
                                    MessageBox.Show("Alteração salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message & vbCrLf)
                            End Try
                    End Select
                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    '//Relatório...
    Private Sub botRelatorioAprov_Click(sender As System.Object, e As System.EventArgs) Handles botRelatorioAprov.Click

    End Sub

#Region "EQUIPE"
    '//Add lista Equipe Aprovação...
    Private Sub btAddEquipAprovacao_Click(sender As System.Object, e As System.EventArgs) Handles btAddEquipAprovacao.Click
        Dim classe As New documentos
        Try
            If cmbEquipeAprovacao.Text = "" Then
                MessageBox.Show("selecione um colaborador", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbEquipeAprovacao.Focus()
                Exit Sub
            Else
                If classe.AddEquipeControleAprova(cmbEquipeAprovacao.SelectedValue, cmbEquipeAprovacao.Text, codigo, revisao) Then
                    carregaListaEquipeAprovacao()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    '//Retira lista Equipe Aprovação...
    Private Sub btRetiraEquipAprovacao_Click(sender As System.Object, e As System.EventArgs) Handles btRetiraEquipAprovacao.Click
        Dim classe As New documentos
        Dim id As Integer = 0
        Try
            If gridEquipAprovacao.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                id = gridEquipAprovacao(gridEquipAprovacao.RowSel, 1)
                If classe.DeleteEquipeControleAprova(id) Then
                    carregaListaEquipeAprovacao()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
#End Region

#End Region

#Region "PUBLICAÇÃO"

    '//Salvar...
    Private Sub botPublicacao_Click(sender As System.Object, e As System.EventArgs) Handles botPublicacao.Click
        Dim classe As New documentos
        Dim situacao As String = String.Empty
        Try
            '//Grid
            If gridProcedimentos.RowSel < 0 Then
                MessageBox.Show("Não à nenhum documento selecionado.", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Try
                    '//Status...
                    situacao = gridProcedimentos(gridProcedimentos.RowSel, 7) '//Seleção do status...
                    Select Case situacao
                        Case "Cadastrado"
                            Try
                                strId = classe.AddControlePublicacao(codigo, revisao, dthPublicacaoConcluida.Value, dthSendPublicacao.Value)
                                If strId <> String.Empty Then
                                    'muda status para [Em elaboração]
                                    classe.UpdateSituacaoRevisao(codigo, revisao, "Não Finalizado")
                                    carregarLista()
                                    InputMsgPublicacao.Enabled = True
                                    MessageBox.Show("Aprovação salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    MessageBox.Show("A ação não pode ser realizada. Verifique!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message & vbCrLf)
                            End Try
                        Case "Não Finalizado"
                            Try
                                Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_PUBLICACAO WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                                Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
                                If dtb.Rows.Count <= 0 Then
                                    strId = classe.AddControlePublicacao(codigo, revisao, dthPublicacaoConcluida.Value, dthSendPublicacao.Value)
                                    If strId <> String.Empty Then
                                        'muda status para [Em elaboração]
                                        classe.UpdateSituacaoRevisao(codigo, revisao, "Não Finalizado")
                                        carregarLista()
                                        InputMsgPublicacao.Enabled = True
                                        MessageBox.Show("Publicação salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        MessageBox.Show("A ação não pode ser realizada. Verifique!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                    End If
                                Else
                                    classe.UpdateControlePublicacao(codigo, revisao, dthAprovacaoConcluida.Value)
                                    carregarLista()
                                    InputMsgElab.Enabled = True
                                    MessageBox.Show("Alteração salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message & vbCrLf)
                            End Try
                        Case "Em elaboração"
                            MessageBox.Show("Documento Em elaboração, finalize o processo!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Case "Em revisão"
                            '//chamar rotina de revisao...
                        Case "Em cancelamento"
                            MessageBox.Show("Documento em cancelamento, finalize o processo!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Case "Cancelado"
                            MessageBox.Show("Documento Cancelado!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Case "Aprovado"
                            Try
                                Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_PUBLICACAO WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                                Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
                                If dtb.Rows.Count <= 0 Then
                                    strId = classe.AddControlePublicacao(codigo, revisao, dthPublicacaoConcluida.Value, dthSendPublicacao.Value)
                                    If strId <> String.Empty Then
                                        'muda status para [Em elaboração]
                                        classe.UpdateSituacaoRevisao(codigo, revisao, "Não Finalizado")
                                        carregarLista()
                                        InputMsgPublicacao.Enabled = True
                                        MessageBox.Show("Publicação salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        MessageBox.Show("A ação não pode ser realizada. Verifique!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                    End If
                                Else
                                    classe.UpdateControlePublicacao(codigo, revisao, dthAprovacaoConcluida.Value)
                                    carregarLista()
                                    InputMsgElab.Enabled = True
                                    MessageBox.Show("Alteração salva com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message & vbCrLf)
                            End Try
                    End Select
                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    '//Chek Pessoa...
    Private Sub chkPessoa_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPessoa.CheckedChanged
        If chkPessoa.Checked Then
            Try
                cmbEquipePublicacao.Enabled = True
                btAddEquipePublicacao.Enabled = True
                btRetiraEquipePublicacao.Enabled = True

                'Responsavel
                Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_COLABORADORES")
                Dim dtr As DataRow = dtb.NewRow
                dtr("COLABORADOR") = ""

                dtb.Rows.InsertAt(dtr, 0)
                dtb.AcceptChanges()
                With cmbEquipePublicacao
                    .DataSource = dtb
                    .DisplayMember = "COLABORADOR"
                    .ValueMember = "ID"
                End With
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf)
            End Try
        Else
            cmbEquipePublicacao.DataSource = Nothing
            cmbEquipePublicacao.Enabled = False
            btAddEquipePublicacao.Enabled = False
            btRetiraEquipePublicacao.Enabled = False
        End If
    End Sub
    '//Chek Área...
    Private Sub chkArea_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkArea.CheckedChanged
        If chkArea.Checked Then
            Try
                cmbEquipePublicacao.Enabled = True
                btAddEquipePublicacao.Enabled = True
                btRetiraEquipePublicacao.Enabled = True

                Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_AREAS")
                Dim dtr As DataRow = dtb.NewRow
                dtr("DESCRICAO") = ""

                dtb.Rows.InsertAt(dtr, 0)
                dtb.AcceptChanges()
                With cmbEquipePublicacao
                    .DataSource = dtb
                    .DisplayMember = "DESCRICAO"
                    .ValueMember = "ID"
                End With
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf)
            End Try
        Else
            cmbEquipePublicacao.DataSource = Nothing
            cmbEquipePublicacao.Enabled = False
            btAddEquipePublicacao.Enabled = False
            btRetiraEquipePublicacao.Enabled = False
        End If
    End Sub
    '//Chek Cargo...
    Private Sub chkCargo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCargo.CheckedChanged
        If chkCargo.Checked Then
            Try
                cmbEquipePublicacao.Enabled = True
                btAddEquipePublicacao.Enabled = True
                btRetiraEquipePublicacao.Enabled = True

                Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_CARGOS")
                Dim dtr As DataRow = dtb.NewRow
                dtr("CARGO") = ""

                dtb.Rows.InsertAt(dtr, 0)
                dtb.AcceptChanges()
                With cmbEquipePublicacao
                    .DataSource = dtb
                    .DisplayMember = "CARGO"
                    .ValueMember = "ID"
                End With
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf)
            End Try
        Else
            cmbEquipePublicacao.DataSource = Nothing
            cmbEquipePublicacao.Enabled = False
            btAddEquipePublicacao.Enabled = False
            btRetiraEquipePublicacao.Enabled = False
        End If
    End Sub

#Region "EQUIPE"
    '//Add lista Equipe...
    Private Sub btAddEquipePublicacao_Click(sender As System.Object, e As System.EventArgs) Handles btAddEquipePublicacao.Click
        Dim classe As New documentos
        Dim colab As Integer = 0
        Dim areas As Integer = 0
        Dim cargos As Integer = 0
        Dim grupos As String = String.Empty

        'VALIDAÇÃO DE CHEKS...
        If chkArea.Checked Then
            areas = cmbEquipePublicacao.SelectedValue
        ElseIf chkCargo.Checked Then
            cargos = cmbEquipePublicacao.SelectedValue
        ElseIf chkPessoa.Checked Then
            colab = cmbEquipePublicacao.SelectedValue
        Else
            grupos = cmbEquipePublicacao.SelectedValue
        End If

        Try
            If cmbEquipePublicacao.Text = "" Then
                MessageBox.Show("selecione um colaborador", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbEquipeAprovacao.Focus()
                Exit Sub
            Else
                If classe.AddEquipeControlePublicacao(colab, areas, cargos, grupos, cmbEquipePublicacao.Text, codigo, revisao) Then
                    carregaListaEquipePublicacao()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    '//Retira lista Equipe...
    Private Sub btRetiraEquipePublicacao_Click(sender As System.Object, e As System.EventArgs) Handles btRetiraEquipePublicacao.Click
        Dim classe As New documentos
        Dim id As Integer = 0
        Try
            If gridEquipPublicacao.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                id = gridEquipPublicacao(gridEquipPublicacao.RowSel, 1)
                If classe.DeleteEquipeControlePublicacao(id) Then
                    carregaListaEquipePublicacao()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
#End Region

#End Region

    '////////////////////////////////////////////////////////////////////////

    '////////////////////////////////FUNÇÕES/////////////////////////////////

#Region "EMAIL"
    ''' Enviar Email...
    Private Sub btSendEmailElab_Click(sender As System.Object, e As System.EventArgs) Handles btSendEmailElab.Click
        Try
            '//[*] validar histórico...
            If gridProcedimentos.RowSel < 0 Then
                MessageBox.Show("Não à nenhum documento selecionado", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                '//Garante que o destinatário é do documento e revisao selecionados...
                If allMail <> "" Then
                    If allMail = "T" Then

                        Dim sqlelab As String = String.Format("SELECT CODIGO, REVISAO, EMAIL FROM DOCUMENTO_CONTROLE_ELAB ELAB " & _
                                                              " INNER JOIN COLABORADORES COLAB ON ELAB.ID_COLABORADORES = COLAB.ID_COLABORADORES " & _
                                                              " WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                        '//pega email do responsavel...
                        Dim sDestinatarioResp As String = String.Empty
                        Dim dr As SqlDataReader = Manager.Util.getDataReader(sqlelab)
                        Dim index As Integer = dr.GetOrdinal("EMAIL")
                        If dr.Read Then
                            sDestinatarioResp = dr("EMAIL").ToString
                        End If

                        '//caso a data não seja informada será a data do dia de cadastro...
                        If dthSendElab.Value = Date.MinValue Then
                            dthSendElab.Value = Today
                        End If

                        '//Texto da Mensagem...
                        Dim sAssuntoEmail As String = "Elaboração de documentos"
                        Dim sMensagemEmail As String = "Uma Elaboração do documento foi criada no dia:  " + dthSendElab.Value

                        '//Configurações...
                        Dim smtpHost As String = String.Empty
                        Dim smtpUsername As String = String.Empty
                        Dim smtpNome As String = String.Empty
                        Dim smtpPassword As String = String.Empty

                        Dim sql As String = "SELECT * FROM CONFIG_EMAIL"
                        Dim dr1 As SqlDataReader = Manager.Util.getDataReader(sql)
                        If dr1.Read Then
                            smtpHost = dr1("HOST").ToString
                            smtpUsername = dr1("USERNAME").ToString
                            smtpNome = dr1("NOME").ToString
                            smtpPassword = dr1("PASSWORD").ToString
                        End If

                        '//Responsa...
                        SendEmail(smtpNome, smtpUsername, smtpPassword, smtpHost, sDestinatarioResp, sAssuntoEmail, sMensagemEmail)

                        '//Destinatario Equipe...
                        Dim sqlMail As String = String.Format("SELECT * FROM VW_EMAIL_ELAB WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                        Dim dt As New DataTable
                        Dim i As Integer = 1
                        Dim sDestinatario As String = String.Empty

                        '//[falta essa parte]...
                        dt = Manager.Util.getDataTableById(sqlMail)
                        'Função para validação de Imagem
                        For Each dr2 As DataRow In dt.Rows
                            sDestinatario = dr2("EMAIL").ToString
                            SendEmail(smtpNome, smtpUsername, smtpPassword, smtpHost, sDestinatario, sAssuntoEmail, sMensagemEmail)
                            i += 1
                        Next
                        MessageBox.Show("O e-mail foi enviado com sucesso.", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                        '//envia apenas para o Responsável...
                    Else
                        Dim sqlelab As String = String.Format("SELECT CODIGO, REVISAO, EMAIL FROM DOCUMENTO_CONTROLE_ELAB ELAB " & _
                                                             " INNER JOIN COLABORADORES COLAB ON ELAB.ID_COLABORADORES = COLAB.ID_COLABORADORES " & _
                                                             " WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                        '//pega email do responsavel...
                        Dim sDestinatarioResp As String = String.Empty
                        Dim dr As SqlDataReader = Manager.Util.getDataReader(sqlelab)
                        Dim index As Integer = dr.GetOrdinal("EMAIL")
                        If dr.Read Then
                            sDestinatarioResp = dr("EMAIL").ToString
                        End If

                        '//caso a data não seja informada será a data do dia de cadastro...
                        If dthSendElab.Value = Date.MinValue Then
                            dthSendElab.Value = Today
                        End If

                        '//Texto da Mensagem...
                        Dim sAssuntoEmail As String = "Elaboração de documentos"
                        Dim sMensagemEmail As String = "Uma Elaboração do documento foi criada no dia:  " + dthSendElab.Value

                        '//Configurações...
                        Dim smtpHost As String = String.Empty
                        Dim smtpUsername As String = String.Empty
                        Dim smtpNome As String = String.Empty
                        Dim smtpPassword As String = String.Empty

                        Dim sql As String = "SELECT * FROM CONFIG_EMAIL"
                        Dim dr1 As SqlDataReader = Manager.Util.getDataReader(sql)
                        If dr1.Read Then
                            smtpHost = dr1("HOST").ToString
                            smtpUsername = dr1("USERNAME").ToString
                            smtpNome = dr1("NOME").ToString
                            smtpPassword = dr1("PASSWORD").ToString
                        End If
                        '//Destinatario Responsavel...
                        SendEmail(smtpNome, smtpUsername, smtpPassword, smtpHost, sDestinatarioResp, sAssuntoEmail, sMensagemEmail)
                        MessageBox.Show("O e-mail foi enviado com sucesso.", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Selecione uma opção de envio.", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    '// Concenco...
    Private Sub botSendEmailConsenco_Click(sender As System.Object, e As System.EventArgs) Handles botSendEmailConsenco.Click
        Try
            '//[*] validar histórico...
            If gridProcedimentos.RowSel < 0 Then
                MessageBox.Show("Não à nenhum documento selecionado", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                '//Destinatario Equipe...
                Dim sqlMail As String = String.Format("SELECT * FROM VW_EMAIL_CONSENC WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                Dim dt As New DataTable
                Dim i As Integer = 1
                Dim sDestinatario As String = String.Empty

                '//caso a data não seja informada será a data do dia de cadastro...
                If dthSendConsenso.Value = Date.MinValue Then
                    dthSendConsenso.Value = Today
                End If

                '//Texto da Mensagem...
                Dim sAssuntoEmail As String = "Consenso de documentos"
                Dim sMensagemEmail As String = "Um Consenso do documento foi criada no dia:  " + dthSendConsenso.Value

                '//Configurações...
                Dim smtpHost As String = String.Empty
                Dim smtpUsername As String = String.Empty
                Dim smtpNome As String = String.Empty
                Dim smtpPassword As String = String.Empty

                Dim sql As String = "SELECT * FROM CONFIG_EMAIL"
                Dim dr1 As SqlDataReader = Manager.Util.getDataReader(sql)
                If dr1.Read Then
                    smtpHost = dr1("HOST").ToString
                    smtpUsername = dr1("USERNAME").ToString
                    smtpNome = dr1("NOME").ToString
                    smtpPassword = dr1("PASSWORD").ToString
                End If

                '//[falta essa parte]...
                dt = Manager.Util.getDataTableById(sqlMail)
                'Função para validação de Imagem
                For Each dr2 As DataRow In dt.Rows
                    sDestinatario = dr2("EMAIL").ToString
                    SendEmail(smtpNome, smtpUsername, smtpPassword, smtpHost, sDestinatario, sAssuntoEmail, sMensagemEmail)
                    i += 1
                Next
                MessageBox.Show("O e-mail foi enviado com sucesso.", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    '// Aprovação...
    Private Sub botSendEmailAprov_Click(sender As System.Object, e As System.EventArgs) Handles botSendEmailAprov.Click
        Try
            '//[*] validar histórico...
            If gridProcedimentos.RowSel < 0 Then
                MessageBox.Show("Não à nenhum documento selecionado", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                '//Destinatario Equipe...
                Dim sqlMail As String = String.Format("SELECT * FROM VW_EMAIL_APROVA WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                Dim dt As New DataTable
                Dim i As Integer = 1
                Dim sDestinatario As String = String.Empty

                '//caso a data não seja informada será a data do dia de cadastro...
                If dthSendAprocacao.Value = Date.MinValue Then
                    dthSendAprocacao.Value = Today
                End If

                '//Texto da Mensagem...
                Dim sAssuntoEmail As String = "Aprovação de documentos"
                Dim sMensagemEmail As String = "Uma Aprovação do documento foi criada no dia:  " + dthSendAprocacao.Value

                '//Configurações...
                Dim smtpHost As String = String.Empty
                Dim smtpUsername As String = String.Empty
                Dim smtpNome As String = String.Empty
                Dim smtpPassword As String = String.Empty

                Dim sql As String = "SELECT * FROM CONFIG_EMAIL"
                Dim dr1 As SqlDataReader = Manager.Util.getDataReader(sql)
                If dr1.Read Then
                    smtpHost = dr1("HOST").ToString
                    smtpUsername = dr1("USERNAME").ToString
                    smtpNome = dr1("NOME").ToString
                    smtpPassword = dr1("PASSWORD").ToString
                End If

                '//[falta essa parte]...
                dt = Manager.Util.getDataTableById(sqlMail)
                'Função para validação de Imagem
                For Each dr2 As DataRow In dt.Rows
                    sDestinatario = dr2("EMAIL").ToString
                    SendEmail(smtpNome, smtpUsername, smtpPassword, smtpHost, sDestinatario, sAssuntoEmail, sMensagemEmail)
                    i += 1
                Next
                MessageBox.Show("O e-mail foi enviado com sucesso.", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    '// Publicação...
    Private Sub botSendEmailPublic_Click(sender As System.Object, e As System.EventArgs) Handles botSendEmailPublic.Click
        Try
            '//[*] validar histórico...
            If gridProcedimentos.RowSel < 0 Then
                MessageBox.Show("Não à nenhum documento selecionado", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                '//Destinatario Equipe...
                Dim sqlMail As String = String.Format("SELECT * FROM VW_EMAIL_PUBLICA WHERE CODIGO = '{0}' AND REVISAO = {1}", codigo, revisao)
                Dim dt As New DataTable
                Dim i As Integer = 1
                Dim sDestinatario As String = String.Empty

                '//caso a data não seja informada será a data do dia de cadastro...
                If dthSendPublicacao.Value = Date.MinValue Then
                    dthSendPublicacao.Value = Today
                End If

                '//Texto da Mensagem...
                Dim sAssuntoEmail As String = "Publicação de documentos"
                Dim sMensagemEmail As String = "Uma Publicação do documento foi criada no dia:  " + dthSendPublicacao.Value

                '//Configurações...
                Dim smtpHost As String = String.Empty
                Dim smtpUsername As String = String.Empty
                Dim smtpNome As String = String.Empty
                Dim smtpPassword As String = String.Empty

                Dim sql As String = "SELECT * FROM CONFIG_EMAIL"
                Dim dr1 As SqlDataReader = Manager.Util.getDataReader(sql)
                If dr1.Read Then
                    smtpHost = dr1("HOST").ToString
                    smtpUsername = dr1("USERNAME").ToString
                    smtpNome = dr1("NOME").ToString
                    smtpPassword = dr1("PASSWORD").ToString
                End If

                '//[falta essa parte]...
                dt = Manager.Util.getDataTableById(sqlMail)
                'Função para validação de Imagem
                For Each dr2 As DataRow In dt.Rows
                    sDestinatario = dr2("EMAIL").ToString
                    SendEmail(smtpNome, smtpUsername, smtpPassword, smtpHost, sDestinatario, sAssuntoEmail, sMensagemEmail)
                    i += 1
                Next
                MessageBox.Show("O e-mail foi enviado com sucesso.", "documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub

    ''' Metodo de envio de email... 
    Private Sub SendEmail(ByVal sRemetenteNome As String, ByVal sRemetente As String, ByVal sSenha As String, ByVal sHost As String, ByVal sDestinatario As String, ByVal sMensagemAssunto As String, ByVal sMensagem As String)

        'Define os dados do e-mail
        Dim nomeRemetente As String = String.Empty
        Dim emailRemetente As String = String.Empty
        Dim senha As String = String.Empty

        nomeRemetente = sRemetenteNome
        emailRemetente = sRemetente
        senha = sSenha

        Dim emailDestinatario As String = String.Empty
        Dim emailComCopia As String = String.Empty
        Dim emailComCopiaOculta As String = String.Empty

        emailDestinatario = sDestinatario
        '//emailComCopia = "email@comcopia.com.br" //caso tenha cópia de email.
        '//emailComCopiaOculta = "email@comcopiaoculta.com.br" //caso tenha cópia oculta de email.

        'Host da porta SMTP
        Dim SMTP As String

        SMTP = sHost ' usando: "smtp.live.com" //windoms live mail...

        Dim assuntoMensagem As String
        Dim conteudoMensagem As String

        assuntoMensagem = sMensagemAssunto
        conteudoMensagem = sMensagem

        'Cria objeto com dados do e-mail.
        Dim objEmail As New System.Net.Mail.MailMessage()

        'Define o Campo From e ReplyTo do e-mail.
        objEmail.From = New System.Net.Mail.MailAddress("<" & emailRemetente & ">")
        'objEmail.ReplyTo = New System.Net.Mail.MailAddress("Nome <email@seudominio.com.br>")

        'Define os destinatários do e-mail.
        objEmail.To.Add("<" & emailDestinatario & ">")

        'Define a prioridade do e-mail.
        objEmail.Priority = System.Net.Mail.MailPriority.Normal

        'Define o formato do e-mail HTML (caso não queira HTML alocar valor false)
        objEmail.IsBodyHtml = True

        'Define o título do e-mail.
        objEmail.Subject = assuntoMensagem

        'Define o corpo do e-mail.
        objEmail.Body = "<b>" & conteudoMensagem & "</b>"

        'Para evitar problemas com caracteres "estranhos", configuramos o Charset para "ISO-8859-1"
        objEmail.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")
        objEmail.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")

        'Cria objeto com os dados do SMTP
        Dim objSmtp As New System.Net.Mail.SmtpClient(SMTP, 587)

        'Alocamos o endereço do host para enviar os e-mails  
        objSmtp.Credentials = New System.Net.NetworkCredential(emailRemetente, senha)
        objSmtp.Host = SMTP
        objSmtp.Port = 587

        'Caso utilize conta de email do exchange da locaweb deve habilitar o SSL
        objSmtp.EnableSsl = True

        Dim credencial = New NetworkCredential(emailRemetente, senha)
        objSmtp.Credentials = credencial

        'Enviamos o e-mail através do método .send()
        Try
            objSmtp.Send(objEmail)
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
        'excluímos o objeto de e-mail da memória
        objEmail.Dispose()
        'anexo.Dispose();
    End Sub

#End Region

#Region "VALIDA HISTÓRICO"
    Public Sub ValidaHistorico(ByVal cod As String, ByVal rev As Integer, ByVal Novarev As Integer, ByVal sit As String)
        Dim classe As New documentos
        Try
            If sit = "Cancelado" Then
                classe.AddControleHistorico(cod, rev, Date.Today, "Cancelamento")
            Else
                Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_CONTROLE_HISTORICO WHERE CODIGO = '{0}'", codigo)
                Dim dtb As DataTable = Manager.Util.getDataTableById(sql)
                If dtb.Rows.Count <= 0 Then
                    classe.AddControleHistorico(cod, rev, Date.Today, "Emissão")
                Else
                    classe.AddControleHistorico(cod, rev, Date.Today, "Alteração da " & rev & " para " & Novarev)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
#End Region

    '////////////////////////////////////////////////////////////////////////

End Class
