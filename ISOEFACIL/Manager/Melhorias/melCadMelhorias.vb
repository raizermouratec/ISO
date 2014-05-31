Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.melEstruturado
Imports ISOEFACIL.melListaMelhorias
Public Class melCadMelhorias

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditAC As Boolean = False
    Private isEditAP As Boolean = False
    Private isEditAM As Boolean = False
    Private isEditAE As Boolean = False
    Public verifCad As Boolean = False
    Public verifAC As Boolean = False
    Public verifAP As Boolean = False
    Public verifAM As Boolean = False
    Public verifEF As Boolean = False
    Public cliente As Integer
    Public idregistroAC As String
    Public idregistroAP As String
    Public idregistroAM As String
    Public idregistroEF As String
    Public idmelhorias As String = String.Empty
    Public situacao As Integer
    Dim Setor, Resp As Integer
    Public idim As Integer
    Public Novo As Boolean = False

    Private ANEXO() As Byte
    Public Modulo As String = "MELHORIAS"
    Public Tela As String = "melCadMelhorias"

    'Pega Id Melhorias
    Public WriteOnly Property Melhorias() As String
        Set(ByVal value As String)
            Me.idmelhorias = value
        End Set
    End Property

    'Pega Id AC
    Public WriteOnly Property AC() As String
        Set(ByVal value As String)
            Me.idregistroAC = value
        End Set
    End Property

    'Pega Id AP
    Public WriteOnly Property AP() As String
        Set(ByVal value As String)
            Me.idregistroAP = value
        End Set
    End Property

    'Pega Id AM
    Public WriteOnly Property AM() As String
        Set(ByVal value As String)
            Me.idregistroAM = value
        End Set
    End Property

    'Pega Id EF
    Public WriteOnly Property EF() As String
        Set(ByVal value As String)
            Me.idregistroEF = value
        End Set
    End Property

    'Pega Id IM
    Public WriteOnly Property IM() As String
        Set(ByVal value As String)
            Me.idim = value
        End Set
    End Property


#End Region

#Region "CARREGA TITULO"

#Region "TITULO"

    Sub CarregaTitulo()
        txtTitulo.Text = txtTituloNCM.Text
    End Sub

    Private Sub txtTituloNCM_LostFocus(sender As Object, e As System.EventArgs) Handles txtTituloNCM.LostFocus
        CarregaTitulo()
    End Sub

#End Region

#Region "TIPO"

    Sub CarregaTipos()
        txtTipo.Text = comboTipoNCM.Text
    End Sub

    Private Sub comboTipoNCM_LostFocus(sender As Object, e As System.EventArgs) Handles comboTipoNCM.LostFocus
        CarregaTipos()
    End Sub

#End Region

#Region "CONTADOR CODIGO"

    Private Sub contador()
        Dim dbCont As New DataTable
        Dim cont As Integer = 1
        Dim Ano As DateTime = DateTime.Now

        Try
            If isEdit Then
                cont = idmelhorias
                txtNumNCM.Text = cont.ToString
            Else
                dbCont = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_MELHORIAS")
                If dbCont.Rows.Count >= 1 Then
                    cont = cont + dbCont.Rows.Count
                    txtNumNCM.Text = cont.ToString & "/" & Ano.Year
                    txtCodigo.Text = cont.ToString & "/" & Ano.Year
                Else
                    txtNumNCM.Text = cont.ToString & "/" & Ano.Year
                    txtCodigo.Text = cont.ToString & "/" & Ano.Year
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#End Region

#Region "CARREGA ESTRUTURADO"

    Public Sub carregaEstruturadoAC(ByVal id As String)

        'Carrega Lista de Não Conformidades \ Melhorias
        gridEstruturadoAC.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_MELHORIAS_ESTRUTURADO WHERE ACAO = 1 AND ID_MELHORIAS = {0}", id)
        Dim dtb As New DataTable

        Dim i As Integer = 1
        Dim drr As String = String.Format("SELECT ID_MELHORIAS_ESTRUTURADO, QUANDO_DATA, RESULTADOS FROM MELHORIAS_ESTRUTURADO")
        dtb = Manager.Util.getDataTableById(drr)
        For Each drw As DataRow In dtb.Rows
            'While dr.Read
            If drw("QUANDO_DATA") < Today And drw("RESULTADOS") = "" Then
                'gridEstruturadoAC.Rows(i).StyleNew.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF6347")
            End If
            'End While
            i += 1
        Next

        dtb = Manager.Util.getDataTable(sql)
        gridEstruturadoAC.DataSource = dtb
        gridEstruturadoAC.RowSel = False

    End Sub

    Public Sub carregaEstruturadoAP(ByVal id As String)

        'Carrega Lista de Não Conformidades \ Melhorias
        gridEstruturadoAP.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_MELHORIAS_ESTRUTURADO WHERE ACAO = 2 AND ID_MELHORIAS = {0}", id)
        Dim dtb As New DataTable
        dtb = Manager.Util.getDataTable(sql)
        gridEstruturadoAP.DataSource = dtb
        gridEstruturadoAP.RowSel = False

    End Sub

    Public Sub carregaEstruturadoAM(ByVal id As String)

        'Carrega Lista de Não Conformidades \ Melhorias
        gridEstruturadoAM.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_MELHORIAS_ESTRUTURADO WHERE ACAO = 3 AND ID_MELHORIAS = {0}", id)
        Dim dtb As New DataTable
        dtb = Manager.Util.getDataTable(sql)
        gridEstruturadoAM.DataSource = dtb
        gridEstruturadoAM.RowSel = False

    End Sub

#End Region

#Region "CARREGAR LISTA DE ANEXOS"

    Public Sub carregaListaAnexos(ByVal id As String)

        Dim dt As New DataTable
        Dim i As Integer = 1
        If id = String.Empty Then
            id = 0
        End If

        Dim sql As String = String.Format("EXECUTE VW_LISTAGEM_ANEXOS {0}, {1} ,{2}", Modulo, id, Tela)
        dt = Manager.Util.getDataTableById(sql)

        'Monta o Grid
        gridAnexos.AutoGenerateColumns = False
        gridAnexos.DataSource = Manager.Util.getDataTable(sql)

        Try

            For Each dr As DataRow In dt.Rows

                ' coluna especifica
                If dr("TIPO") = "doc" Then
                    gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(0))
                End If

                If dr("TIPO") = "ocx" Then
                    gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(0))
                End If

                If dr("TIPO") = "xls" Then
                    gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(1))
                End If

                If dr("TIPO") = "pdf" Then
                    gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(2))
                End If

                If dr("TIPO") = "txt" Then
                    gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(3))
                End If

                If dr("TIPO") = "ppt" Then
                    gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(4))
                End If

                If dr("TIPO") = "out" Then
                    gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(5))
                End If

                i += 1

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "POPULA COMBOS"

#Region "NÃO CONFORMIDADE / MELHORIA"

#Region "TIPO"

    Sub CarregaTipo()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_MELHORIAS_TIPO_SITUACAO")
        Dim dtr As DataRow = dtb.NewRow
        dtr("DESCRICAO") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboTipoNCM.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboTipoNCM.DataSource = dtb
        comboTipoNCM.DisplayMember = "DESCRICAO"
        comboTipoNCM.ValueMember = "ID"
    End Sub

#End Region

#Region "RECLAMACAO DE CLIENTE"

    Sub CarregaReclamaCliente()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_CLIENTES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("CLIENTE") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboRecCli.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboRecCli.DataSource = dtb
        comboRecCli.DisplayMember = "CLIENTE"
        comboRecCli.ValueMember = "CODIGO"
    End Sub

#End Region

#Region "NORMA DE REFERENCIA"

    Sub CarregaNormaRef()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_NORMAS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboNormaRef.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboNormaRef.DataSource = dtb
        comboNormaRef.DisplayMember = "NOME"
        comboNormaRef.ValueMember = "ID"
    End Sub

#End Region

#Region "NORMA PADRAO"

    Sub CarregaItemNorma()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_NORMA_PADRAO")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NORMAS") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboItemNorma.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboItemNorma.DataSource = dtb
        comboItemNorma.DisplayMember = "NORMAS"
        comboItemNorma.ValueMember = "NORMA_PADRAO"
    End Sub

#End Region

#Region "RESPONSAVEL PELO REGISTRO"

    Sub CarregaRespReg()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboRespReg.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboRespReg.DataSource = dtb
        comboRespReg.DisplayMember = "COLABORADOR"
        comboRespReg.ValueMember = "ID"
    End Sub

#End Region

#Region "SETOR RESPONSAVEL"

    Sub CarregaSetorResp()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT ID_AREAS, DESCRICAO FROM AREAS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("DESCRICAO") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboSetorResp.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboSetorResp.DataSource = dtb
        comboSetorResp.DisplayMember = "DESCRICAO"
        comboSetorResp.ValueMember = "ID_AREAS"
    End Sub

#End Region

#Region "RESPONSAVEL PELO SETOR"

    Sub CarregaRespSetor(ByVal idarea As Integer)
        Dim dtb As New DataTable
        Dim sql As String = String.Format("SELECT ID_COLABORADORES, COLABORADOR FROM COLABORADORES CB JOIN CARGOS CR ON CB.ID_CARGOS = CR.ID_CARGOS JOIN AREAS CA ON CB.ID_AREAS = CA.ID_AREAS WHERE CR.APROVADOR = 1 AND CR.SITUACAO = 1 AND CB.APROVADOR = 1 AND CB.SITUACAO = 1 AND CA.ID_AREAS = {0}", idarea)

        dtb = Manager.Util.getDataTable(sql)

        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboResp.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboResp.DataSource = dtb
        comboResp.DisplayMember = "COLABORADOR"
        comboResp.ValueMember = "ID_COLABORADORES"
    End Sub

    Sub CarregaRespSetorN()

        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES_APROVADOR")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboResp.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboResp.DataSource = dtb
        comboResp.DisplayMember = "COLABORADOR"
        comboResp.ValueMember = "ID"

    End Sub

#End Region

#End Region

#Region "AÇÃO CORRETIVA"

#Region "RESPONSAVEL"

    Sub CarregaRespAC()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboRespAC.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboRespAC.DataSource = dtb
        comboRespAC.DisplayMember = "COLABORADOR"
        comboRespAC.ValueMember = "ID"
    End Sub

#End Region

#Region "RESPONSAVEL PELA APROVAÇÃO"

    Sub CarregaRespAprovAC()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES_APROVADOR")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboRespAprovAC.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboRespAprovAC.DataSource = dtb
        comboRespAprovAC.DisplayMember = "COLABORADOR"
        comboRespAprovAC.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "AÇÃO PREVENTIVA"

#Region "RESPONSAVEL"

    Sub CarregaRespAP()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboRespAP.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboRespAP.DataSource = dtb
        comboRespAP.DisplayMember = "COLABORADOR"
        comboRespAP.ValueMember = "ID"
    End Sub

#End Region

#Region "RESPONSAVEL PELA APROVAÇÃO"

    Sub CarregaRespAprovAP()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES_APROVADOR")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboRespAprovAP.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboRespAprovAP.DataSource = dtb
        comboRespAprovAP.DisplayMember = "COLABORADOR"
        comboRespAprovAP.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "AÇÃO MELHORIA"

#Region "RESPONSAVEL"

    Sub CarregaRespAM()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboRespAM.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboRespAM.DataSource = dtb
        comboRespAM.DisplayMember = "COLABORADOR"
        comboRespAM.ValueMember = "ID"
    End Sub

#End Region

#Region "RESPONSAVEL PELA APROVAÇÃO"

    Sub CarregaRespAprovAM()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES_APROVADOR")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboRespAprovAM.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboRespAprovAM.DataSource = dtb
        comboRespAprovAM.DisplayMember = "COLABORADOR"
        comboRespAprovAM.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "ANÁLISE EFICÁCIA"

#Region "RESPONSAVEL"

    Sub CarregaRespEF()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES_APROVADOR")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboRespEF.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboRespEF.DataSource = dtb
        comboRespEF.DisplayMember = "COLABORADOR"
        comboRespEF.ValueMember = "ID"
    End Sub

#End Region

#End Region

#End Region

#Region "LOAD"

    Private Sub melRegistro_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        dateVEficacia.Value = DateTimePicker.MinimumDateTime
        dateVEficacia.Text = ""
        dateTratamento.Value = DateTimePicker.MinimumDateTime
        dateTratamento.Text = ""
        Tab1.Show()
        CarregaTipo()
        CarregaNormaRef()
        CarregaItemNorma()
        CarregaRespReg()
        CarregaSetorResp()
        CarregaRespAC()
        CarregaRespAprovAC()
        CarregaRespAP()
        CarregaRespAprovAP()
        CarregaRespAM()
        CarregaRespAprovAM()
        CarregaRespEF()
        CarregaReclamaCliente()
        carregaListaAnexos(idmelhorias)
        'Desabilitando campos de Não Conformidade/Melhoria
        lblJustifique.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        txtJustifiqueOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        lblPrazoEficacia.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        dateVEficacia.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        lblSetorResp.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        comboSetorResp.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        lblPrazoTratamento.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        dateTratamento.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        lblResp.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        comboResp.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        'Cor texto Não Conformidade/Melhoria
        txtDetalhamento.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtJustifique.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        'Desabilitando campos Ação Corretiva

        'Cor texto Ação Corretiva
        txtDescAC.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtCausasAC.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtCorrecaoAC.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtTextoANecessariaAC.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtResultadosAC.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        'Cor texto Ação Preventiva
        txtDescAP.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtCausasAP.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtTextoANecessariaAP.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtResultadosAP.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        'Cor texto Ação Melhoria
        txtObjAM.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtJustAM.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtTextoANecessariaAM.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtResultadosAM.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        'Desabilitando campos Analise Eficácia
        lblSeNegativo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        txtAcaoEficaz.Visible = False
        txtAcaoEficazOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        lblOqfazer.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        txtOqfazer.Visible = False
        txtOqfazerOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        'Cor texto Análise Eficácia
        txtMetodoAnaliseEF.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtResultadosObtidosEF.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtAcaoEficaz.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtOqfazer.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        'Contador de Identificação Nº/ANO
        contador()
    End Sub

#End Region

#Region "NOVO"

#Region "NOVO REGISTRO"

    Public Sub NovoCadMelhoria()
        'Cadastrar Novo
        Novo = False
        isEdit = False
        isEditAC = False
        isEditAP = False
        isEditAM = False
        isEditAE = False

        Tab2.Enabled = False
        Tab3.Enabled = False
        Tab4.Enabled = False
        Me.ShowDialog()
    End Sub

#End Region

#End Region

#Region "EDITAR"

#Region "NÃO CONFORMIDADE REAL / POTENCIAL / MELHORIAS"

    Public Sub EditarMelhorias(ByVal id As Integer)

        'Editando Não Conformidade / Melhorias
        isEdit = True
        Novo = True

        'Muda o Label do botão Incluir
        botSalvar.Width = 80
        botSalvar.Text = "Atualizar"

        'Carregando Combos
        CarregaTipo()
        CarregaNormaRef()
        CarregaItemNorma()
        CarregaRespReg()
        CarregaSetorResp()
        CarregaRespAC()
        CarregaRespAprovAC()
        CarregaRespAP()
        CarregaRespAprovAP()
        CarregaRespAM()
        CarregaRespAprovAM()
        CarregaRespEF()
        CarregaReclamaCliente()
        carregaListaAnexos(id)

        'Seleciona pelo Id
        Dim sql As String = String.Format("SELECT * FROM MELHORIAS WHERE ID_MELHORIAS = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtTitulo.Text = dr("TITULO").ToString
                Me.txtTituloNCM.Text = dr("TITULO").ToString
                Me.comboTipoNCM.SelectedValue = dr("ID_MELHORIAS_TIPO_SITUACAO").ToString
                If dr("ID_MELHORIAS_TIPO_SITUACAO") = 1 Then
                    Me.txtTipo.Text = "Não Conformidade Real"
                ElseIf dr("ID_MELHORIAS_TIPO_SITUACAO") = 2 Then
                    Me.txtTipo.Text = "Não Conformidade Potencial"
                ElseIf dr("ID_MELHORIAS_TIPO_SITUACAO") = 3 Then
                    Me.txtTipo.Text = "Melhoria"
                End If
                CarregaAcoes(id)
                If dr("ID_CLIENTES") = 0 Then
                    Me.comboRecCli.Text = ""
                End If
                Me.comboItemNorma.SelectedValue = dr("ID_NORMA_PADRAO").ToString
                Me.txtNumNCM.Text = dr("NUMERO").ToString
                Me.txtCodigo.Text = dr("NUMERO").ToString
                Me.txtDetalhamento.Text = dr("DETALHAMENTO").ToString
                If dr("SITUACAO_ORIGEM") = 1 Then
                    Me.radioAudInt.Checked = True
                ElseIf dr("SITUACAO_ORIGEM") = 2 Then
                    Me.radioAudExt.Checked = True
                ElseIf dr("SITUACAO_ORIGEM") = 3 Then
                    Me.radioProdNC.Checked = True
                ElseIf dr("SITUACAO_ORIGEM") = 4 Then
                    Me.radioEspontanea.Checked = True
                ElseIf dr("SITUACAO_ORIGEM") = 5 Then
                    Me.radioRecCli.Checked = True
                    Me.comboRecCli.SelectedValue = dr("ID_CLIENTES").ToString
                ElseIf dr("SITUACAO_ORIGEM") = 6 Then
                    Me.radioOutro.Checked = True
                    Me.txtOutro.Text = dr("OUTRO_DESCRICAO").ToString
                End If
                Me.comboNormaRef.SelectedValue = dr("NORMAS").ToString
                Me.comboRespReg.SelectedValue = dr("RESPONSAVEL").ToString
                Me.dateReg.Value = dr("DATA_DE_REGISTRO").ToString
                If dr("NOTIFICAR") = True Then
                    checkRD.Checked = True
                Else
                    checkRD.Checked = False
                End If
                If dr("ACEITE_PROCEDENTE") = 1 Then
                    'Habilitando ABA de Ações
                    Tab2.Enabled = True
                    Me.radioSim.Checked = True
                    Me.txtJustifique.Text = dr("NEGATIVO_JUSTIFIQUE").ToString
                    Me.dateTratamento.Value = dr("PRAZO_TRATAMENTO").ToString
                    Me.dateVEficacia.Value = dr("PRAZO_EFICACIA").ToString
                    Me.comboSetorResp.SelectedValue = dr("SETOR_RESPONSAVEL").ToString
                    CarregaRespSetor(comboSetorResp.SelectedValue)
                    Me.comboResp.SelectedValue = dr("RESPONSAVEL_SETOR").ToString
                ElseIf dr("ACEITE_PROCEDENTE") = 2 Then
                    Me.radioNao.Checked = True
                    Me.txtJustifique.Text = dr("NEGATIVO_JUSTIFIQUE").ToString
                    Me.dateTratamento.Value = dr("PRAZO_TRATAMENTO").ToString
                    Me.comboResp.SelectedValue = dr("RESPONSAVEL_SETOR").ToString
                Else
                    Me.radioSim.Checked = False
                    Me.radioNao.Checked = False
                    Me.Tab2.Enabled = False
                    Me.Tab3.Enabled = False
                End If
                
                'Editando Análise de Eficácia
                isEditAE = True

                'Muda o Label do botão Incluir
                botSalvarEficacia.Width = 80
                botSalvarEficacia.Text = "Atualizar"

                'Seleciona pelo Id
                Dim sql4 As String = String.Format("SELECT * FROM MELHORIAS_ANALISE_EFICACIA WHERE ID_MELHORIAS = {0}", id)

                'Popula os campos com os dados do Banco
                Try

                    Dim dr4 As SqlDataReader = Manager.Util.getDataReader(sql4)

                    If dr4.HasRows = False Then
                        isEditAE = False
                    End If

                    While dr4.Read

                        Me.txtMetodoAnaliseEF.Text = dr4("METODO_DE_ANALISE").ToString
                        Me.txtResultadosObtidosEF.Text = dr4("RESULTADOS_OBTIDOS").ToString
                        If dr4("ACAO_EFICAZ") = True Then
                            Me.radioSimEF.Checked = True
                        Else
                            Me.radioNaoEF.Checked = True
                            txtAcaoEficaz.Visible = True
                            Me.txtAcaoEficaz.Text = dr4("NEGATIVO_JUSTIFIQUE").ToString
                            txtOqfazer.Visible = True
                            Me.txtOqfazer.Text = dr4("O_QUE_FAZ").ToString
                        End If
                        Me.comboRespEF.SelectedValue = dr4("RESPONSAVEL").ToString
                        Me.dateEF.Value = dr4("DATA_RESP").ToString

                    End While

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.Show()

    End Sub

    Sub CarregaAcoes(ByVal id As Integer)

        Dim sql As String = String.Format("SELECT * FROM MELHORIAS WHERE ID_MELHORIAS = {0}", id)

        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                'Verificando tipo de Não Conformidade / Melhorias
                If dr("ID_MELHORIAS_TIPO_SITUACAO") = 1 Then

                    'Carrega o Form com esse methodo
                    Me.Show()

                    'Editando Ação Corretiva
                    isEditAC = True

                    'Muda o Label do botão Incluir
                    botSalvarAC.Width = 80
                    botSalvarAC.Text = "Atualizar"

                    'Seleciona pelo Id
                    Dim sql3 As String = String.Format("SELECT * FROM MELHORIAS_AC WHERE ID_MELHORIAS = {0}", id)

                    'Popula os campos com os dados do Banco
                    Try

                        Dim dr3 As SqlDataReader = Manager.Util.getDataReader(sql3)

                        If dr3.HasRows = False Then
                            isEditAC = False
                            Tab3.Enabled = False
                        Else

                            While dr3.Read

                                Me.txtDescAC.Text = dr3("DESCRICAO").ToString
                                Me.txtCausasAC.Text = dr3("CAUSAS").ToString
                                Me.txtCorrecaoAC.Text = dr3("CORRECAO").ToString
                                If dr3("ACOES_NECESSARIAS") = True Then
                                    Me.radioTextoAC.Checked = True
                                    Me.txtTextoANecessariaAC.Text = dr3("ACOES_NECESSARIAS_TEXTO").ToString
                                    Me.txtResultadosAC.Text = dr3("RESULTADOS").ToString
                                Else
                                    Me.radioEstruturadoAC.Checked = True
                                End If
                                Me.comboRespAC.SelectedValue = dr3("RESPONSAVEL").ToString
                                Me.DateAC.Value = dr3("DATA_RESP").ToString
                                If dr3("APROVACAO") = True Then
                                    Me.radioSimAC.Checked = True
                                    'Habilitando ABA de Análise Eficácia
                                    Tab3.Enabled = True
                                Else
                                    Me.radioNaoAC.Checked = True
                                End If
                                Me.comboRespAprovAC.SelectedValue = dr3("RESPONSAVEL_APROVACAO").ToString
                                Me.dateAprovAC.Value = dr3("DATA_APROVACAO").ToString

                            End While

                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    End Try

                ElseIf dr("ID_MELHORIAS_TIPO_SITUACAO") = 2 Then

                    'Carrega o Form com esse methodo
                    Me.Show()

                    'Editando Ação Preventiva
                    isEditAP = True

                    'Muda o Label do botão Incluir
                    botSalvarAP.Width = 80
                    botSalvarAP.Text = "Atualizar"

                    'Seleciona pelo Id
                    Dim sql2 As String = String.Format("SELECT * FROM MELHORIAS_AP WHERE ID_MELHORIAS = {0}", id)

                    'Popula os campos com os dados do Banco
                    Try

                        Dim dr2 As SqlDataReader = Manager.Util.getDataReader(sql2)

                        If dr2.HasRows = False Then
                            isEditAP = False
                            Tab3.Enabled = False
                        End If

                        While dr2.Read

                            Me.txtDescAP.Text = dr2("DESCRICAO").ToString
                            Me.txtCausasAP.Text = dr2("CAUSAS").ToString
                            If dr2("ACOES_NECESSARIAS") = True Then
                                Me.radioTextoAP.Checked = True
                                Me.txtTextoANecessariaAP.Text = dr2("ACOES_NECESSARIAS_TEXTO").ToString
                                Me.txtResultadosAP.Text = dr2("RESULTADOS").ToString
                            Else
                                Me.radioEstruturadoAP.Checked = True
                            End If
                            Me.comboRespAP.SelectedValue = dr2("RESPONSAVEL").ToString
                            Me.DateAP.Value = dr2("DATA_RESP").ToString
                            If dr2("APROVACAO") = True Then
                                Me.radioSimAP.Checked = True
                                'Habilitando ABA de Análise Eficácia
                                Tab3.Enabled = True
                            Else
                                Me.radioNaoAP.Checked = True
                            End If
                            Me.comboRespAprovAP.SelectedValue = dr2("RESPONSAVEL_APROVACAO").ToString
                            Me.dateAprovAP.Value = dr2("DATA_APROVACAO").ToString

                        End While

                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    End Try

                ElseIf dr("ID_MELHORIAS_TIPO_SITUACAO") = 3 Then

                    'Carrega o Form com esse methodo
                    Me.Show()

                    'Editando Ação de Melhorias
                    isEditAM = True

                    'Muda o Label do botão Incluir
                    botSalvarAM.Width = 80
                    botSalvarAM.Text = "Atualizar"

                    'Seleciona pelo Id
                    Dim sql1 As String = String.Format("SELECT * FROM MELHORIAS_AM WHERE ID_MELHORIAS = {0}", id)

                    'Popula os campos com os dados do Banco
                    Try

                        Dim dr1 As SqlDataReader = Manager.Util.getDataReader(sql1)

                        If dr1.HasRows = False Then
                            isEditAM = False
                            Tab3.Enabled = False
                        End If

                        While dr1.Read

                            Me.txtObjAM.Text = dr1("OBJETIVOS").ToString
                            Me.txtJustAM.Text = dr1("JUSTIFICATIVAS").ToString
                            If dr1("ACOES_NECESSARIAS") = True Then
                                Me.radioTextoAM.Checked = True
                                Me.txtTextoANecessariaAM.Text = dr1("ACOES_NECESSARIAS_TEXTO").ToString
                                Me.txtResultadosAM.Text = dr1("RESULTADOS").ToString
                            Else
                                Me.radioEstruturadoAM.Checked = True
                            End If
                            Me.comboRespAM.SelectedValue = dr1("RESPONSAVEL").ToString
                            Me.dateAM.Value = dr1("DATA_RESP").ToString
                            If dr1("APROVACAO") = True Then
                                Me.radioSimAM.Checked = True
                                'Habilitando ABA de Análise Eficácia
                                Tab3.Enabled = True
                            Else
                                Me.radioNaoAM.Checked = True
                            End If
                            Me.comboRespAprovAM.SelectedValue = dr1("RESPONSAVEL_APROVACAO").ToString
                            Me.dateAprovAM.Value = dr1("DATA_APROVACAO").ToString

                        End While

                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    End Try

                End If

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#End Region

#Region "ABAS"

#Region "NÃO CONFORMIDADE / MELHORIAS"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim registro As New melhorias

        If Tab1.Focus = True Then

            'Verificando valor de Origem
            Dim origem As Integer = 0
            If radioAudInt.Checked = True Then
                'Origem Interna
                origem = 1
                'Verificando dar valor a Reclamação de Cliente caso não seja selecionada 
                If comboRecCli.Text = "" Then
                    cliente = 0
                End If
            End If
            If radioAudExt.Checked = True Then
                'Origem Externa
                origem = 2
                'Verificando dar valor a Reclamação de Cliente caso não seja selecionada 
                If comboRecCli.Text = "" Then
                    cliente = 0
                End If
            End If
            If radioProdNC.Checked = True Then
                'Origem Produto Não Conforme
                origem = 3
                'Verificando dar valor a Reclamação de Cliente caso não seja selecionada 
                If comboRecCli.Text = "" Then
                    cliente = 0
                End If
            End If
            If radioEspontanea.Checked = True Then
                'Origem Espontânea
                origem = 4
                'Verificando dar valor a Reclamação de Cliente caso não seja selecionada 
                If comboRecCli.Text = "" Then
                    cliente = 0
                End If
            End If
            If radioRecCli.Checked = True Then
                'Origem Reclamação de Cliente
                origem = 5
                cliente = comboRecCli.SelectedValue
            End If
            If radioOutro.Checked = True Then
                'Origem Outro
                origem = 6
                'Verificando dar valor a Reclamação de Cliente caso não seja selecionada 
                If comboRecCli.Text = "" Then
                    cliente = 0
                End If
            End If

            'Verificando valor de Notificar responsável pela qualidade
            Dim notificar As Boolean
            If checkRD.Checked = True Then
                notificar = True
            Else
                notificar = False
            End If

            'Verificando o a Situação se Registra, Procede ou Não Procede
            'Verificando valor de Aceite / Confirmação
            Dim aceiteNCM As Integer
            If radioSim.Checked = False And radioNao.Checked = False Then
                'SITUACAO - Registrado
                situacao = 1
                aceiteNCM = 0
                If Not comboSetorResp.SelectedValue Is Nothing And Not comboResp.SelectedValue Is Nothing Then
                    Setor = 0
                    Resp = 0
                End If

            ElseIf radioSim.Checked = True Then
                'SITUACAO - Em Desenvolvimento
                verifCad = False
                situacao = 2
                aceiteNCM = 1
                'Tratamento de erro Responsável do Setor
                If comboResp.SelectedValue.ToString = String.Empty Then
                    MessageBox.Show("Campo Responsável do Setor Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    comboResp.Focus()
                    verifCad = True
                    Exit Sub
                Else
                    Resp = comboResp.SelectedValue
                End If
                'Tratamento de erro Setor Responsável
                If comboSetorResp.SelectedValue.ToString = String.Empty Then
                    MessageBox.Show("Campo Setor Responsável Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    comboSetorResp.Focus()
                    verifCad = True
                    Exit Sub
                Else
                    Setor = comboSetorResp.SelectedValue
                End If
            Else
                aceiteNCM = 2
                If radioRecCli.Checked = True Then
                    'SITUACAO - Não Procede
                    situacao = 4
                Else
                    'SITUACAO - Cancelado
                    situacao = 3
                End If
                If Not comboSetorResp.SelectedValue Is Nothing Then
                    Setor = 0
                    'Tratamento de erro Responsável do Setor
                    If comboResp.SelectedValue.ToString = String.Empty Then
                        MessageBox.Show("Campo Responsável do Setor Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        comboResp.Focus()
                        verifCad = True
                        Exit Sub
                    Else
                        Resp = comboResp.SelectedValue
                    End If
                End If
            End If

            'Inicio Atualizar/Salvar
            If isEdit Then

                'Verificar campos obrigatórios
                VerificarCad()
                'Checando se campos obrigatórios estão OK
                If verifCad = False Then
                    Try
                        'Atualizar
                        If registro.Update(idmelhorias, _
                                           comboTipoNCM.SelectedValue, _
                                           comboItemNorma.SelectedValue, _
                                           cliente, _
                                           comboNormaRef.SelectedValue, _
                                           comboRespReg.SelectedValue, _
                                           txtTituloNCM.Text, _
                                           txtNumNCM.Text, _
                                           txtDetalhamento.Text, _
                                           origem, _
                                           txtOutro.Text, _
                                           dateReg.Value, _
                                           notificar, _
                                           aceiteNCM, _
                                           txtJustifique.Text, _
                                           dateTratamento.Value, _
                                           dateVEficacia.Value, _
                                           Setor, _
                                           Resp, _
                                           situacao) Then
                            melListaMelhorias.CarregaMelhorias()
                            If radioSim.Checked = True Then
                                'Libera a Aba de Ações Necessárias
                                Tab2.Enabled = True
                            ElseIf radioNao.Checked = True Then
                                Tab4.Enabled = True
                                Me.Close()
                            End If
                            MessageBox.Show("Dados de Não Conformidade / Melhoria atualizados com sucesso", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Tab2.Show()
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    End Try
                Else
                    Exit Sub
                End If

            Else

                'Verificar campos obrigatórios
                VerificarCad()
                'Checando se campos obrigatórios estão OK
                If verifCad = False Then
                    Try
                        'Salvar
                        idmelhorias = registro.Add(comboTipoNCM.SelectedValue, _
                                        comboItemNorma.SelectedValue, _
                                        cliente, _
                                        comboNormaRef.SelectedValue, _
                                        comboRespReg.SelectedValue, _
                                        txtTituloNCM.Text, _
                                        txtNumNCM.Text, _
                                        txtDetalhamento.Text, _
                                        origem, _
                                        txtOutro.Text, _
                                        dateReg.Value, _
                                        notificar, _
                                        aceiteNCM, _
                                        txtJustifique.Text, _
                                        dateTratamento.Value, _
                                        dateVEficacia.Value, _
                                        Setor, _
                                        Resp, _
                                        situacao)
                        If idmelhorias <> String.Empty Then
                            melListaMelhorias.CarregaMelhorias()
                            audNaoConformidade.CarregaNC()
                            If radioSim.Checked = True Then
                                'Libera a Aba de Ações Necessárias
                                Tab2.Enabled = True
                                Tab2.Show()
                            ElseIf radioNao.Checked = True Then
                                Tab4.Enabled = True
                                Me.Close()
                            End If
                            MessageBox.Show("Nova Não Conformidade / Melhoria salva com sucesso", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Tab2.Show()

                            Dim dr As SqlDataReader
                            dr = Manager.Util.getDataReader("SELECT MAX(ID_MELHORIAS) AS ID FROM MELHORIAS")

                            While dr.Read
                                idim = dr("ID").ToString
                            End While

                            Tab4.Enabled = True
                            isEdit = True
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    End Try
                Else
                    Exit Sub
                End If

            End If

        End If

    End Sub

    Private Sub VerificarCad()
        verifCad = False

        'Tratamento de erro Título
        If txtTituloNCM.Text = "" Then
            MessageBox.Show("Campo Título Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTituloNCM.Focus()
            verifCad = True
            Exit Sub
        End If
        'Tratamento de erro Tipo
        If comboTipoNCM.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Tipo Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboTipoNCM.Focus()
            verifCad = True
            Exit Sub
        End If
        'Tratamento de erro Detalhamento
        If txtDetalhamento.Text = "" Then
            MessageBox.Show("Campo Detalhamento Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDetalhamento.Focus()
            verifCad = True
            Exit Sub
        End If
        'Tratamento de erro Origem
        If radioAudInt.Checked = False And
           radioAudExt.Checked = False And
           radioEspontanea.Checked = False And
           radioProdNC.Checked = False And
           radioRecCli.Checked = False And
           radioOutro.Checked = False Then
            MessageBox.Show("Campo Origem Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verifCad = True
            Exit Sub
        End If
        'Tratamento de erro Reclamação de Cliente
        If radioRecCli.Checked = True Then
            If comboRecCli.SelectedValue.ToString = String.Empty Then
                MessageBox.Show("Campo Reclamação de Cliente Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                comboRecCli.Focus()
                verifCad = True
                Exit Sub
            End If
        End If
        'Tratamento de erro Outro
        If radioOutro.Checked = True Then
            If txtOutro.Text = "" Then
                MessageBox.Show("Campo Outro Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtOutro.Focus()
                verifCad = True
                Exit Sub
            End If
        End If
        'Tratamento de erro Norma de Referencia
        If comboNormaRef.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Norma de Referência não foi selecionado", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboNormaRef.Focus()
            verifCad = True
            Exit Sub
        End If
        'Tratamento de erro Item da Norma
        If comboItemNorma.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("O campo Item da Normal não foi selecionado", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboItemNorma.Focus()
            verifCad = True
            Exit Sub
        End If
        'Tratamento de erro Responsável pelo Registro
        If comboRespReg.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável pelo Registro Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboRespReg.Focus()
            verifCad = True
            Exit Sub
        End If
        'Tratamento de erro Data de Registro
        If dateReg.Text = "" Then
            MessageBox.Show("Campo Data de Registro Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateReg.Focus()
            verifCad = True
            Exit Sub
        End If


        'Tratamento de erro Aceite / Confirmação
        If radioNao.Checked = False And radioSim.Checked = False Then
            'MessageBox.Show("", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf radioSim.Checked = True Then
            'Tratamento de erro Prazo para Tratamento
            If dateTratamento.Text = "" Then
                MessageBox.Show("Campo Prazo de Tratamento Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                dateTratamento.Focus()
                verifCad = True
                Exit Sub
            End If
            'Tratamento de erro Prazo para verificação de Eficáca
            If dateVEficacia.Text = "" Then
                MessageBox.Show("Campo Prazo para verificação de Eficáca Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                dateVEficacia.Focus()
                verifCad = True
                Exit Sub
            End If
            'Tratamento de erro Setor Responsável
            If comboSetorResp.SelectedValue.ToString = String.Empty Then
                MessageBox.Show("Campo Setor Responsável Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                comboSetorResp.Focus()
                verifCad = True
                Exit Sub
            End If
            'Tratamento de erro Responsável do Setor
            If comboResp.SelectedValue.ToString = String.Empty Then
                MessageBox.Show("Campo Responsável do Setor Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                comboResp.Focus()
                verifCad = True
                Exit Sub
            End If
        ElseIf radioNao.Checked = True Then
            'Tratamento de erro Texto Justifique
            If txtJustifique.Text = "" Then
                MessageBox.Show("Campo Justifique Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                verifCad = True
                Exit Sub
            End If
            'Tratamento de erro Data da Decisão
            If dateTratamento.Text = "" Then
                MessageBox.Show("Campo Prazo de Tratamento Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                dateTratamento.Focus()
                verifCad = True
                Exit Sub
            End If
            'Tratamento de erro Responsável
            If comboResp.SelectedValue.ToString = String.Empty Then
                MessageBox.Show("Campo Responsável do Setor Obrigatórido", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                comboResp.Focus()
                verifCad = True
                Exit Sub
            End If
        End If

    End Sub

    Private Sub comboSetorResp_LostFocus(sender As Object, e As System.EventArgs) Handles comboSetorResp.LostFocus
        selecionavalor()
    End Sub

    Private Sub selecionavalor()
        If comboSetorResp.ValueMember <> "" Then

            Dim id As Integer

            If comboSetorResp.SelectedValue.ToString = String.Empty Then
                MessageBox.Show("Setor Responsável não selecionado", "Não Conformidade / Melhoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                id = comboSetorResp.SelectedValue
                CarregaRespSetor(id)
            End If

        End If

    End Sub

#Region "ORIGEM"

    Private Sub radioAudInt_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioAudInt.SelectedIndexChanged

        If radioAudInt.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioAudExt.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioProdNC.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioEspontanea.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioRecCli.Checked = True Then
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.comboRecCli.Focus()
        ElseIf radioOutro.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.txtOutro.Focus()
        End If

    End Sub

    Private Sub radioAudExt_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioAudExt.SelectedIndexChanged

        If radioAudInt.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioAudExt.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioProdNC.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioEspontanea.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioRecCli.Checked = True Then
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.comboRecCli.Focus()
        ElseIf radioOutro.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.txtOutro.Focus()
        End If

    End Sub

    Private Sub radioProdNC_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioProdNC.SelectedIndexChanged

        If radioAudInt.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioAudExt.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioProdNC.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioEspontanea.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioRecCli.Checked = True Then
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.comboRecCli.Focus()
        ElseIf radioOutro.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.txtOutro.Focus()
        End If

    End Sub

    Private Sub radioEspontanea_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioEspontanea.SelectedIndexChanged

        If radioAudInt.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioAudExt.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioProdNC.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioEspontanea.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioRecCli.Checked = True Then
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.comboRecCli.Focus()
        ElseIf radioOutro.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.txtOutro.Focus()
        End If

    End Sub

    Private Sub radioRecCli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioRecCli.SelectedIndexChanged

        If radioAudInt.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioAudExt.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioProdNC.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioEspontanea.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioRecCli.Checked = True Then
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.comboRecCli.Focus()
        ElseIf radioOutro.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.txtOutro.Focus()
        End If

    End Sub

    Private Sub radioOutro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioOutro.SelectedIndexChanged

        If radioAudInt.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioAudExt.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioProdNC.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioEspontanea.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioRecCli.Checked = True Then
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.comboRecCli.Focus()
        ElseIf radioOutro.Checked = True Then
            Me.comboRecCli.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOutro.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.txtOutro.Focus()
        End If

    End Sub

#End Region

#Region "ACEITE / CONFIRMAÇÃO"

    Private Sub radioSim_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioSim.SelectedIndexChanged

        If radioSim.Checked = True And radioNao.Checked = False Then
            lblJustifique.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            txtJustifiqueOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            lblPrazoEficacia.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            dateVEficacia.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            lblSetorResp.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            comboSetorResp.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            lblPrazoTratamento.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            dateTratamento.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            lblResp.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            comboResp.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            lblPrazoTratamento.Text = "Prazo para Tratamento:"
            lblResp.Text = "Responsável do Setor:"
            txtJustifique.Visible = False
            'Else
            '    lblJustifique.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            '    txtJustifique.Visible = True
            '    lblPrazoEficacia.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            '    dateVEficacia.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            '    lblSetorResp.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            '    comboSetorResp.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            '    lblPrazoTratamento.Text = "Data da Decisão:"
            '    lblResp.Text = "Responsável:"
            '    txtJustifique.Focus()
        End If

    End Sub

    Private Sub radioNao_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioNao.SelectedIndexChanged

        If radioNao.Checked = True And radioSim.Checked = False Then
            lblJustifique.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            txtJustifiqueOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            lblPrazoEficacia.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            dateVEficacia.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            lblSetorResp.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            comboSetorResp.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            lblPrazoTratamento.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            lblPrazoTratamento.Text = "Data da Decisão:"
            dateTratamento.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            lblResp.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            lblResp.Text = "Responsável:"
            comboResp.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            txtJustifique.Visible = True
            txtJustifique.Focus()
            CarregaRespSetorN()
        End If

    End Sub

#End Region

#End Region

#Region "AÇÕES NECESSÁRIAS"

#Region "AC"

#Region "SALVAR"

    Private Sub botSalvarAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvarAC.Click

        'Seta a Classe
        Dim acoes As New acoesnecessarias
        Dim status As New melhorias

        'Verificando valor de Ações Necessárias
        Dim achouAC As Boolean
        If radioTextoAC.Checked = True Then
            achouAC = True
        Else
            achouAC = False
        End If

        'Verificando valor de Aprovação
        Dim aceiteAC As Boolean
        If radioSimAC.Checked = True Then
            aceiteAC = True
        Else
            aceiteAC = False
        End If

        'Inicio Atualizar/Salvar
        If isEditAC Then

            'Verificar campos obrigatórios
            VerificarAC()
            'Checando se campos obrigatórios estão OK
            If verifAC = False Then
                Try
                    'Atualizar
                    If acoes.UpdateAC(idregistroAC,
                                      idmelhorias,
                                      txtDescAC.Text, _
                                      txtCausasAC.Text, _
                                      txtCorrecaoAC.Text, _
                                      achouAC, _
                                      txtTextoANecessariaAC.Text, _
                                      txtResultadosAC.Text, _
                                      comboRespAC.SelectedValue, _
                                      DateAC.Value, _
                                      aceiteAC, _
                                      comboRespAprovAC.SelectedValue, _
                                      dateAprovAC.Value) Then
                        If radioSimAC.Checked = True Then
                            'SITUACAO - Ação Realizada
                            situacao = 5
                            Tab3.Enabled = True
                        Else
                            'SITUACAO - Ação Não Realizada
                            situacao = 6
                            Me.Close()
                        End If
                        status.UpdateStatus(idmelhorias, _
                                            situacao)
                        melListaMelhorias.CarregaMelhorias()
                        MessageBox.Show("Dados da Ação Corretiva atualizados com sucesso", "Ação Corretiva", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Tab3.Show()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            'Verificar campos obrigatórios
            VerificarAC()
            'Checando se campos obrigatórios estão OK
            If verifAC = False Then
                Try
                    'Salvar
                    If acoes.AddAC(idmelhorias, _
                                   txtDescAC.Text, _
                                   txtCausasAC.Text, _
                                   txtCorrecaoAC.Text, _
                                   achouAC, _
                                   txtTextoANecessariaAC.Text, _
                                   txtResultadosAC.Text, _
                                   comboRespAC.SelectedValue, _
                                   DateAC.Value, _
                                   aceiteAC, _
                                   comboRespAprovAC.SelectedValue, _
                                   dateAprovAC.Value) Then
                        If radioSimAC.Checked = True Then
                            'SITUACAO - Ação Realizada
                            situacao = 5
                            Tab3.Enabled = True
                        Else
                            'SITUACAO - Ação Não Realizada
                            situacao = 6
                            Me.Close()
                        End If
                        status.UpdateStatus(idmelhorias, _
                                            situacao)
                        melListaMelhorias.CarregaMelhorias()
                        MessageBox.Show("Nova da Ação Corretiva salva com sucesso", "Ação Corretiva", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Tab3.Show()
                        isEditAC = True
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub VerificarAC()
        verifAC = False

        'Tratamento de erro Descrição
        If txtDescAC.Text = "" Then
            MessageBox.Show("Campo Descrição Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDescAC.Focus()
            verifAC = True
            Exit Sub
        End If
        'Tratamento de erro Causas
        If txtCausasAC.Text = "" Then
            MessageBox.Show("Campo Causas Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCausasAC.Focus()
            verifAC = True
            Exit Sub
        End If
        'Tratamento de erro Correção
        If txtCorrecaoAC.Text = "" Then
            MessageBox.Show("Campo Correção Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCorrecaoAC.Focus()
            verifAC = True
            Exit Sub
        End If
        'Tratamento de erro Ações Necessárias 
        If radioTextoAC.Checked = False And radioEstruturadoAC.Checked = False Then
            MessageBox.Show("Campo Ações Necessárias Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verifAC = True
            Exit Sub
        ElseIf radioTextoAC.Checked = True Then
            'Tratamento de erro Ações Necessárias (Texto)
            If txtTextoANecessariaAC.Text = "" Then
                MessageBox.Show("Campo Texto Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtTextoANecessariaAC.Focus()
                verifAC = True
                Exit Sub
            End If
            'Tratamento de erro Ações Necessárias (Resultados)
            If txtResultadosAC.Text = "" Then
                MessageBox.Show("Campo Resultados Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtResultadosAC.Focus()
                verifAC = True
                Exit Sub
            End If
        End If
        'Tratamento de erro Responsável
        If comboRespAC.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboRespAC.Focus()
            verifAC = True
            Exit Sub
        End If
        'Tratamento de erro Data
        If DateAC.Text = "" Then
            MessageBox.Show("Campo Data Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            DateAC.Focus()
            verifAC = True
            Exit Sub
        End If
        'Tratamento de erro Aprovação
        If radioSimAC.Checked = False And radioNaoAC.Checked = False Then
            MessageBox.Show("Campo Aprovação Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verifAC = True
            Exit Sub
        End If
        'Tratamento de erro Responsável pela Aprovação
        If comboRespAprovAC.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável pela Aprovação Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboRespAprovAC.Focus()
            verifAC = True
            Exit Sub
        End If
        'Tratamento de erro Data Aprovação
        If dateAprovAC.Text = "" Then
            MessageBox.Show("Campo Data Aprovação Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateAprovAC.Focus()
            verifAC = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "ACOES NECESSARIAS AC"

    Private Sub radioTextoAC_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioTextoAC.SelectedIndexChanged

        If radioTextoAC.Checked = True Then
            Me.txtTextoANecessariaAC.Visible = True
            Me.txtTextoANecessariaAC.Focus()
            Me.lblResultadosAC.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.txtResultadosAC.Visible = True
            Me.inpultEstruturadoAC.Visible = False
            Me.gridEstruturadoAC.Visible = False
            Me.inpultOptionsEstruturadoAC.Visible = False
        End If

    End Sub

    Private Sub radioEstruturadoAC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioEstruturadoAC.SelectedIndexChanged

        If radioEstruturadoAC.Checked = True Then
            If txtTextoANecessariaAC.Text <> "" Then
                If MessageBox.Show("A Ação Necessária Texto será apagada, Deseja Continuar ?", "Não Conformidade / Aviso", Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Me.txtTextoANecessariaAC.Text = ""
                    Me.txtResultadosAC.Text = ""
                    Me.txtTextoANecessariaAC.Visible = False
                    Me.lblResultadosAC.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                    Me.txtResultadosAC.Visible = False
                    Me.inpultEstruturadoAC.Visible = True
                    Me.gridEstruturadoAC.Visible = True
                    Me.inpultOptionsEstruturadoAC.Visible = True
                Else
                    Me.txtTextoANecessariaAC.Visible = False
                    Me.lblResultadosAC.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                    Me.txtResultadosAC.Visible = False
                    Me.inpultEstruturadoAC.Visible = True
                    Me.gridEstruturadoAC.Visible = True
                    Me.inpultOptionsEstruturadoAC.Visible = True
                End If
            Else
                Me.txtTextoANecessariaAC.Visible = False
                Me.lblResultadosAC.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                Me.txtResultadosAC.Visible = False
                Me.inpultEstruturadoAC.Visible = True
                Me.gridEstruturadoAC.Visible = True
                Me.inpultOptionsEstruturadoAC.Visible = True
            End If
        End If

    End Sub

#End Region

#Region "ESTRUTURADO"

    Private Sub botIncluirAC_Click(sender As System.Object, e As System.EventArgs) Handles botIncluirAC.Click

        Dim frm As New melEstruturado
        Dim IdMelhoria As Integer = 0

        If Novo = False Then
            frm.MelhoriasEs = idim
        Else
            IdMelhoria = melListaMelhorias.gridNC_AC(melListaMelhorias.gridNC_AC.RowSel, 1)
            frm.MelhoriasEs = IdMelhoria
        End If

        'Chama o Novo
        frm.NovoAC()
        carregaEstruturadoAC(idmelhorias)

    End Sub

    Private Sub botEditarAC_Click(sender As System.Object, e As System.EventArgs) Handles botEditarAC.Click

        If gridEstruturadoAC.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Melhorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim id As Integer = 0
            Dim frm As New melEstruturado
            Dim acao As Integer = 0
            Dim IdMelhoria As Integer = 0

            'Passagem de parametros
            Try

                acao = 1
                If Novo = False Then
                    frm.MelhoriasEs = idim
                Else
                    IdMelhoria = melListaMelhorias.gridNC_AC(melListaMelhorias.gridNC_AC.RowSel, 1)
                    frm.MelhoriasEs = IdMelhoria
                End If
                Try
                    id = gridEstruturadoAC(gridEstruturadoAC.RowSel, 1)
                Catch ex As Exception
                    MessageBox.Show("Nenhum item selecionado", "Aviso", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                frm.Estruturado = id
                frm.EditarEstruturado(id, acao)
                carregaEstruturadoAC(idmelhorias)
                gridEstruturadoAC.RowSel = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub botExcluirAC_Click(sender As System.Object, e As System.EventArgs) Handles botExcluirAC.Click

        If gridEstruturadoAC.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Melhorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim IdMelhoria As Integer = 0
            Dim estruturado As New estruturado

            IdMelhoria = melListaMelhorias.gridNC_AC(melListaMelhorias.gridNC_AC.RowSel, 1)

            'Excluir o Registro
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Melhorias", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    estruturado.Delete(gridEstruturadoAC(gridEstruturadoAC.RowSel, 1))
                    MessageBox.Show("Objetivos excluído com sucesso", "Melhorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    carregaEstruturadoAC(IdMelhoria)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "APROVADO"

    Private Sub radioSimAC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioSimAC.SelectedIndexChanged
        If radioSimAC.Checked = True Then
            radioNaoAC.Checked = False
        End If
    End Sub

    Private Sub radioNaoAC_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioNaoAC.SelectedIndexChanged
        If radioNaoAC.Checked = True Then
            radioSimAC.Checked = False
        End If
    End Sub

#End Region

#End Region

#Region "AP"

#Region "SALVAR"

    Private Sub botSalvarAP_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarAP.Click

        'Seta a Classe
        Dim acoes As New acoesnecessarias
        Dim status As New melhorias

        'Verificando valor de Ações Necessárias
        Dim achouAP As Boolean
        If radioTextoAP.Checked = True Then
            achouAP = True
        Else
            achouAP = False
        End If

        'Verificando valor de Aprovação
        Dim aceiteAP As Boolean
        If radioSimAP.Checked = True Then
            aceiteAP = True
        Else
            aceiteAP = False
        End If

        'Inicio Atualizar/Salvar
        If isEditAP Then

            'Verificar campos obrigatórios
            VerificarAP()
            'Checando se campos obrigatórios estão OK
            If verifAP = False Then
                Try
                    If acoes.UpdateAP(idregistroAP,
                                      idmelhorias, _
                                      txtDescAP.Text, _
                                      txtCausasAP.Text, _
                                      achouAP, _
                                      txtTextoANecessariaAP.Text, _
                                      txtResultadosAP.Text, _
                                      comboRespAP.SelectedValue, _
                                      DateAP.Value, _
                                      aceiteAP, _
                                      comboRespAprovAP.SelectedValue, _
                                      dateAprovAP.Value) Then
                        If radioSimAP.Checked = True Then
                            'SITUACAO - Ação Realizada
                            situacao = 5
                            Tab3.Enabled = True
                        Else
                            'SITUACAO - Ação Não Realizada
                            situacao = 6
                            Me.Close()
                        End If
                        status.UpdateStatus(idmelhorias, _
                                           situacao)
                        melListaMelhorias.CarregaMelhorias()
                        MessageBox.Show("Dados de Ação Preventiva atualizados com sucesso", "Ação Preventiva", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        Tab3.Show()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            'Verificar campos obrigatórios
            VerificarAP()
            'Checando se campos obrigatórios estão OK
            If verifAP = False Then
                Try
                    If acoes.AddAP(idmelhorias, _
                                   txtDescAP.Text, _
                                   txtCausasAP.Text, _
                                   achouAP, _
                                   txtTextoANecessariaAP.Text, _
                                   txtResultadosAP.Text, _
                                   comboRespAP.SelectedValue, _
                                   DateAP.Value, _
                                   aceiteAP, _
                                   comboRespAprovAP.SelectedValue, _
                                   dateAprovAP.Value) Then
                        If radioSimAP.Checked = True Then
                            'SITUACAO - Ação Realizada
                            situacao = 5
                            Tab3.Enabled = True
                        Else
                            'SITUACAO - Ação Não Realizada
                            situacao = 6
                            Me.Close()
                        End If
                        status.UpdateStatus(idmelhorias, _
                                           situacao)
                        melListaMelhorias.CarregaMelhorias()
                        MessageBox.Show("Nova Ação Preventiva salva com sucesso", "Ação Preventiva", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        Tab3.Show()
                        isEditAP = True
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub VerificarAP()
        verifAP = False

        'Tratamento de erro Descrição
        If txtDescAP.Text = "" Then
            MessageBox.Show("Campo Descrição Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDescAP.Focus()
            verifAP = True
            Exit Sub
        End If
        'Tratamento de erro Causas
        If txtCausasAP.Text = "" Then
            MessageBox.Show("Campo Causas Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCausasAP.Focus()
            verifAP = True
            Exit Sub
        End If
        'Tratamento de erro Ações Necessárias 
        If radioTextoAP.Checked = False And radioEstruturadoAP.Checked = False Then
            MessageBox.Show("Campo Ações Necessárias Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verifAP = True
            Exit Sub
        ElseIf radioTextoAP.Checked = True Then
            'Tratamento de erro Ações Necessárias (Texto)
            If txtTextoANecessariaAP.Text = "" Then
                MessageBox.Show("Campo Texto Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtTextoANecessariaAP.Focus()
                verifAP = True
                Exit Sub
            End If
            'Tratamento de erro Ações Necessárias (Resultados)
            If txtResultadosAP.Text = "" Then
                MessageBox.Show("Campo Resultados Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtResultadosAP.Focus()
                verifAP = True
                Exit Sub
            End If
        End If
        'Tratamento de erro Responsável
        If comboRespAP.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboRespAP.Focus()
            verifAP = True
            Exit Sub
        End If
        'Tratamento de erro Data
        If DateAP.Text = "" Then
            MessageBox.Show("Campo Data Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            DateAP.Focus()
            verifAP = True
            Exit Sub
        End If
        'Tratamento de erro Aprovação
        If radioSimAP.Checked = False And radioNaoAP.Checked = False Then
            MessageBox.Show("Campo Aprovação Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verifAP = True
            Exit Sub
        End If
        'Tratamento de erro Responsável pela Aprovação
        If comboRespAprovAP.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável pela Aprovação Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboRespAprovAP.Focus()
            verifAP = True
            Exit Sub
        End If
        'Tratamento de erro Data Aprovação
        If dateAprovAP.Text = "" Then
            MessageBox.Show("Campo Data Aprovação Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateAprovAP.Focus()
            verifAP = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "ACOES NECESSARIAS AP"

    Private Sub radioTextoAP_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioTextoAP.SelectedIndexChanged

        If radioTextoAP.Checked = True Then
            Me.txtTextoANecessariaAP.Visible = True
            Me.txtTextoANecessariaAP.Focus()
            Me.lblResultadosAP.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.txtResultadosAP.Visible = True
            Me.inpultEstruturadoAP.Visible = False
            Me.gridEstruturadoAP.Visible = False
            Me.inpultOptionsEstruturadoAP.Visible = False
        End If

    End Sub

    Private Sub radioEstruturadoAP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioEstruturadoAP.SelectedIndexChanged

        If radioEstruturadoAP.Checked = True Then
            If txtTextoANecessariaAP.Text <> "" Then
                If MessageBox.Show("A Ação Necessária Texto será apagada, Deseja Continuar ?", "Não Conformidade / Aviso", Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Me.txtTextoANecessariaAP.Text = ""
                    Me.txtResultadosAP.Text = ""
                    Me.txtTextoANecessariaAP.Visible = False
                    Me.lblResultadosAP.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                    Me.txtResultadosAP.Visible = False
                    Me.inpultEstruturadoAP.Visible = True
                    Me.gridEstruturadoAP.Visible = True
                    Me.inpultOptionsEstruturadoAP.Visible = True
                Else
                    Me.txtTextoANecessariaAC.Visible = False
                    Me.lblResultadosAP.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                    Me.txtResultadosAP.Visible = False
                    Me.inpultEstruturadoAC.Visible = True
                    Me.gridEstruturadoAC.Visible = True
                    Me.inpultOptionsEstruturadoAC.Visible = True
                End If
            Else
                Me.txtTextoANecessariaAP.Visible = False
                Me.lblResultadosAP.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                Me.txtResultadosAP.Visible = False
                Me.inpultEstruturadoAP.Visible = True
                Me.gridEstruturadoAP.Visible = True
                Me.inpultOptionsEstruturadoAP.Visible = True
            End If
        End If

    End Sub

#End Region

#Region "ESTRUTURADO"

    Private Sub botIncluirAP_Click(sender As System.Object, e As System.EventArgs) Handles botIncluirAP.Click

        Dim frm As New melEstruturado
        Dim IdMelhoria As Integer = 0

        If Novo = False Then
            frm.MelhoriasEs = idim
        Else
            IdMelhoria = melListaMelhorias.gridNC_AC(melListaMelhorias.gridNC_AC.RowSel, 1)
            frm.MelhoriasEs = IdMelhoria
        End If

        'Chama o Novo
        frm.NovoAP()
        carregaEstruturadoAP(idmelhorias)

    End Sub

    Private Sub botEditarAP_Click(sender As System.Object, e As System.EventArgs) Handles botEditarAP.Click

        If gridEstruturadoAP.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Melhorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim id As Integer = 0
            Dim frm As New melEstruturado
            Dim acao As Integer = 0
            Dim IdMelhoria As Integer = 0

            'Passagem de parametros
            Try
                acao = 2
                If Novo = False Then
                    frm.MelhoriasEs = idim
                Else
                    IdMelhoria = melListaMelhorias.gridNC_AC(melListaMelhorias.gridNC_AC.RowSel, 1)
                    frm.MelhoriasEs = IdMelhoria
                End If
                Try
                    id = gridEstruturadoAP(gridEstruturadoAP.RowSel, 1)
                Catch ex As Exception
                    MessageBox.Show("Nenhum item selecionado", "Aviso", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                frm.Estruturado = id
                frm.EditarEstruturado(id, acao)
                carregaEstruturadoAP(idmelhorias)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub botExcluirAP_Click(sender As System.Object, e As System.EventArgs) Handles botExcluirAP.Click

        If gridEstruturadoAP.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Melhorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim IdMelhoria As Integer = 0
            Dim estruturado As New estruturado

            IdMelhoria = melListaMelhorias.gridNC_AC(melListaMelhorias.gridNC_AC.RowSel, 1)

            'Excluir o Registro
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Melhorias", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    estruturado.Delete(gridEstruturadoAP(gridEstruturadoAP.RowSel, 1))
                    MessageBox.Show("Objetivos excluído com sucesso", "Melhorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    carregaEstruturadoAP(IdMelhoria)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "APROVADO"

    Private Sub radioSimAP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioSimAP.SelectedIndexChanged
        If radioSimAP.Checked = True Then
            radioNaoAP.Checked = False
        End If
    End Sub

    Private Sub radioNaoAP_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioNaoAP.SelectedIndexChanged
        If radioNaoAP.Checked = True Then
            radioSimAP.Checked = False
        End If
    End Sub

#End Region

#Region "AUTORIZACAO"

    Private Sub botAutorizacaoAP_Click(sender As System.Object, e As System.EventArgs) Handles botAutorizacaoAP.Click

    End Sub

#End Region

#End Region

#Region "AM"

#Region "SALVAR"

    Private Sub botSalvarAM_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarAM.Click

        'Seta a Classe
        Dim acoes As New acoesnecessarias
        Dim status As New melhorias

        'Verificando valor de Ações Necessárias
        Dim achouAM As Boolean
        If radioTextoAM.Checked = True Then
            achouAM = True
        Else
            achouAM = False
        End If

        'Verificando valor de Aprovação
        Dim aceiteAM As Boolean
        If radioSimAM.Checked = True Then
            aceiteAM = True
        Else
            aceiteAM = False
        End If

        'Inicio Atualizar/Salvar
        If isEditAM Then

            'Verificar campos obrigatórios
            VerificarAM()
            'Checando se campos obrigatórios estão OK
            If verifAM = False Then
                Try
                    'Atualizar
                    If acoes.UpdateAM(idregistroAM,
                                      idmelhorias, _
                                      txtObjAM.Text, _
                                      txtJustAM.Text, _
                                      achouAM, _
                                      txtTextoANecessariaAM.Text, _
                                      txtResultadosAM.Text, _
                                      comboRespAM.SelectedValue, _
                                      dateAM.Value, _
                                      aceiteAM, _
                                      comboRespAprovAM.SelectedValue, _
                                      dateAprovAM.Value) Then
                        If radioSimAM.Checked = True Then
                            'SITUACAO - Ação Realizada
                            situacao = 5
                            Tab3.Enabled = True
                        Else
                            'SITUACAO - Ação Não Realizada
                            situacao = 6
                            Me.Close()
                        End If
                        status.UpdateStatus(idmelhorias, _
                                           situacao)
                        melListaMelhorias.CarregaMelhorias()
                        MessageBox.Show("Dados da Ação de Melhoria atualizados com sucesso", "Ação de Melhoria", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        Tab3.Show()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            'Verificar campos obrigatórios
            VerificarAM()
            'Checando se campos obrigatórios estão OK
            If verifAM = False Then
                Try
                    'Salvar
                    If acoes.AddAM(idmelhorias, _
                                   txtObjAM.Text, _
                                   txtJustAM.Text, _
                                   achouAM, _
                                   txtTextoANecessariaAM.Text, _
                                   txtResultadosAM.Text, _
                                   comboRespAM.SelectedValue, _
                                   dateAM.Value, _
                                   aceiteAM, _
                                   comboRespAprovAM.SelectedValue, _
                                   dateAprovAM.Value) Then
                        If radioSimAM.Checked = True Then
                            'SITUACAO - Ação Realizada
                            situacao = 5
                            Tab3.Enabled = True
                        Else
                            'SITUACAO - Ação Não Realizada
                            situacao = 6
                            Me.Close()
                        End If
                        status.UpdateStatus(idmelhorias, _
                                           situacao)
                        melListaMelhorias.CarregaMelhorias()
                        MessageBox.Show("Nova Ação de Melhoria salva com sucesso", "Ação de Melhoria", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        Tab3.Show()
                        isEditAM = True
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub VerificarAM()
        verifAM = False

        'Tratamento de erro Objetivos
        If txtObjAM.Text = "" Then
            MessageBox.Show("Campo Objetivos Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtObjAM.Focus()
            verifAM = True
            Exit Sub
        End If
        'Tratamento de erro Justificativas
        If txtJustAM.Text = "" Then
            MessageBox.Show("Campo Justificativas Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtJustAM.Focus()
            verifAM = True
        End If
        'Tratamento de erro Ações Necessárias 
        If radioTextoAM.Checked = False And radioEstruturadoAM.Checked = False Then
            MessageBox.Show("Campo Ações Necessárias Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verifAM = True
            Exit Sub
        ElseIf radioTextoAM.Checked = True Then
            'Tratamento de erro Ações Necessárias (Texto)
            If txtTextoANecessariaAM.Text = "" Then
                MessageBox.Show("Campo Texto Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtTextoANecessariaAM.Focus()
                verifAM = True
                Exit Sub
            End If
            'Tratamento de erro Ações Necessárias (Resultados)
            If txtResultadosAM.Text = "" Then
                MessageBox.Show("Campo Resultados Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtResultadosAM.Focus()
                verifAM = True
                Exit Sub
            End If
        End If
        'Tratamento de erro Responsável
        If comboRespAM.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboRespAM.Focus()
            verifAM = True
            Exit Sub
        End If
        'Tratamento de erro Data
        If dateAM.Text = "" Then
            MessageBox.Show("Campo Data Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateAM.Focus()
            verifAM = True
            Exit Sub
        End If
        'Tratamento de erro Aprovação
        If radioSimAM.Checked = False And radioNaoAM.Checked = False Then
            MessageBox.Show("Campo Aprovação Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verifAM = True
            Exit Sub
        End If
        'Tratamento de erro Responsável pela Aprovação
        If comboRespAprovAM.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável pela Aprovação Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboRespAprovAM.Focus()
            verifAM = True
            Exit Sub
        End If
        'Tratamento de erro Data Aprovação
        If dateAprovAM.Text = "" Then
            MessageBox.Show("Campo Data Aprovação Obrigatório", "Ações Necessárias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateAprovAM.Focus()
            verifAM = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "ACOES NECESSARIAS AM"

    Private Sub radioTextoAM_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioTextoAM.SelectedIndexChanged

        If radioTextoAM.Checked = True Then
            Me.txtTextoANecessariaAM.Visible = True
            Me.txtTextoANecessariaAM.Focus()
            Me.lblResultadosAM.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.txtResultadosAM.Visible = True
            Me.inpultEstruturadoAM.Visible = False
            Me.gridEstruturadoAM.Visible = False
            Me.inpultOptionsEstruturadoAM.Visible = False
        End If

    End Sub

    Private Sub radioEstruturadoAM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioEstruturadoAM.SelectedIndexChanged

        If radioEstruturadoAM.Checked = True Then
            If txtTextoANecessariaAM.Text <> "" Then
                If MessageBox.Show("A Ação Necessária Texto será apagada, Deseja Continuar ?", "Não Conformidade / Aviso", Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Me.txtTextoANecessariaAM.Text = ""
                    Me.txtResultadosAM.Text = ""
                    Me.txtTextoANecessariaAM.Visible = False
                    Me.lblResultadosAM.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                    Me.txtResultadosAM.Visible = False
                    Me.inpultEstruturadoAM.Visible = True
                    Me.gridEstruturadoAM.Visible = True
                    Me.inpultOptionsEstruturadoAM.Visible = True
                Else
                    Me.txtTextoANecessariaAC.Visible = False
                    Me.lblResultadosAM.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                    Me.txtResultadosAM.Visible = False
                    Me.inpultEstruturadoAC.Visible = True
                    Me.gridEstruturadoAC.Visible = True
                    Me.inpultOptionsEstruturadoAC.Visible = True
                End If
            Else
                Me.txtTextoANecessariaAM.Visible = False
                Me.lblResultadosAM.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                Me.txtResultadosAM.Visible = False
                Me.inpultEstruturadoAM.Visible = True
                Me.gridEstruturadoAM.Visible = True
                Me.inpultOptionsEstruturadoAM.Visible = True
            End If
        End If

    End Sub

#End Region

#Region "ESTRUTURADO"

    Private Sub botIncluirAM_Click(sender As System.Object, e As System.EventArgs) Handles botIncluirAM.Click

        Dim frm As New melEstruturado
        Dim IdMelhoria As Integer = 0

        If Novo = False Then
            frm.MelhoriasEs = idim
        Else
            IdMelhoria = melListaMelhorias.gridNC_AC(melListaMelhorias.gridNC_AC.RowSel, 1)
            frm.MelhoriasEs = IdMelhoria
        End If

        'Chama o Novo
        frm.NovoAM()
        carregaEstruturadoAM(idmelhorias)

    End Sub

    Private Sub botEditarAM_Click(sender As System.Object, e As System.EventArgs) Handles botEditarAM.Click

        If gridEstruturadoAM.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Melhorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim id As Integer = 0
            Dim frm As New melEstruturado
            Dim acao As Integer = 0
            Dim IdMelhoria As Integer = 0

            'Passagem de parametros
            Try
                acao = 3
                If Novo = False Then
                    frm.MelhoriasEs = idim
                Else
                    IdMelhoria = melListaMelhorias.gridNC_AC(melListaMelhorias.gridNC_AC.RowSel, 1)
                    frm.MelhoriasEs = IdMelhoria
                End If
                Try
                    id = gridEstruturadoAM(gridEstruturadoAM.RowSel, 1)
                Catch ex As Exception
                    MessageBox.Show("Nenhum item selecionado", "Aviso", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                frm.Estruturado = id
                carregaEstruturadoAM(idmelhorias)
                frm.EditarEstruturado(id, acao)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub botExcluirAM_Click(sender As System.Object, e As System.EventArgs) Handles botExcluirAM.Click

        Dim IdMelhoria As Integer = 0
        Dim estruturado As New estruturado

        IdMelhoria = melListaMelhorias.gridNC_AC(melListaMelhorias.gridNC_AC.RowSel, 1)

        If gridEstruturadoAM.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Melhorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Excluir o Registro
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Melhorias", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    estruturado.Delete(gridEstruturadoAM(gridEstruturadoAM.RowSel, 1))
                    MessageBox.Show("Objetivos excluído com sucesso", "Melhorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    carregaEstruturadoAM(IdMelhoria)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "APROVADO"

    Private Sub radioSimAM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioSimAM.SelectedIndexChanged
        If radioSimAM.Checked = True Then
            radioNaoAM.Checked = False
        End If
    End Sub

    Private Sub radioNaoAM_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioNaoAM.SelectedIndexChanged
        If radioNaoAM.Checked = True Then
            radioSimAM.Checked = False
        End If
    End Sub

#End Region

#Region "AUTORIZACAO"

    Private Sub botAutorizacaoAM_Click(sender As System.Object, e As System.EventArgs) Handles botAutorizacaoAM.Click

        Dim frm As New melAutorizacao
        Dim IdMelhoria As Integer = 0

        IdMelhoria = melListaMelhorias.gridNC_AC(melListaMelhorias.gridNC_AC.RowSel, 1)
        'Chama o Novo
        frm.Melhorias = IdMelhoria
        frm.Novo()

    End Sub

#End Region

#End Region

#Region "ACOES"

    Private Sub Tab2_GotFocus(sender As Object, e As System.EventArgs) Handles Tab2.GotFocus

        If Tab2.Focus = True Then
            If comboTipoNCM.SelectedValue = 1 Then
                tabACorretiva.Show()
                txtTipo.Text = "Não Conformidade Real"
                carregaEstruturadoAC(idmelhorias)
                tabACorretiva.TabVisible = True
                tabACorretiva.Focus()
                tabAPreventiva.TabVisible = False
                tabMelhorias.TabVisible = False
            ElseIf comboTipoNCM.SelectedValue = 2 Then
                tabAPreventiva.Show()
                txtTipo.Text = "Não Conformidade Potencial"
                carregaEstruturadoAP(idmelhorias)
                tabACorretiva.TabVisible = False
                tabAPreventiva.TabVisible = True
                tabMelhorias.TabVisible = False
            ElseIf comboTipoNCM.SelectedValue = 3 Then
                tabMelhorias.Show()
                txtTipo.Text = "Melhoria"
                carregaEstruturadoAM(idmelhorias)
                tabACorretiva.TabVisible = False
                tabAPreventiva.TabVisible = False
                tabMelhorias.TabVisible = True
            End If
        End If

    End Sub

#End Region

#End Region

#Region "ANÁISE DE EFICÁCIA"

    Private Sub botSalvarEficacia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvarEficacia.Click

        'Seta a Classe
        Dim eficacia As New analiseeficacia
        Dim status As New melhorias

        'Verificando valor de Eficácia
        Dim achouEF As Boolean
        If radioSimEF.Checked = True Then
            achouEF = True
        Else
            achouEF = False
        End If

        'Inicio Atualizar/Salvar
        If isEditAE Then

            'Verificar campos obrigatórios
            VerificarEF()
            'Checando se campos obrigatórios estão OK
            If verifEF = False Then
                Try
                    'Atualizar
                    If eficacia.UpdateEF(idregistroEF, _
                                         idmelhorias, _
                                         txtMetodoAnaliseEF.Text, _
                                         txtResultadosObtidosEF.Text, _
                                         achouEF, _
                                         txtAcaoEficaz.Text, _
                                         txtOqfazer.Text, _
                                         comboRespEF.SelectedValue, _
                                         dateEF.Value) Then
                        If radioSimEF.Checked = True Then
                            'SITUACAO - Concluído
                            situacao = 7
                        Else
                            'SITUACAO - Não Eficaz
                            situacao = 8
                        End If
                        status.UpdateStatus(idmelhorias, _
                                           situacao)
                        melListaMelhorias.CarregaMelhorias()
                        MessageBox.Show("Dados de Análise Eficácia atualizados com sucesso", "Análise Eficácia", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
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
            VerificarEF()
            'Checando se campos obrigatórios estão OK
            If verifEF = False Then
                Try
                    'Salvar
                    If eficacia.AddAEF(idmelhorias, _
                                       txtMetodoAnaliseEF.Text, _
                                       txtResultadosObtidosEF.Text, _
                                       achouEF, _
                                       txtAcaoEficaz.Text, _
                                       txtOqfazer.Text, _
                                       comboRespEF.SelectedValue, _
                                       dateEF.Value) Then

                        If radioSimEF.Checked = True Then
                            'SITUACAO - Concluído
                            situacao = 7
                        Else
                            'SITUACAO - Não Eficaz
                            situacao = 8
                        End If
                        status.UpdateStatus(idmelhorias, _
                                           situacao)
                        melListaMelhorias.CarregaMelhorias()
                        MessageBox.Show("Dados de Análise Eficácia salvo com sucesso", "Análise Eficácia", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        isEditAE = True
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

    Private Sub VerificarEF()
        verifEF = False

        'Tratamento de erro Método de análise
        If txtMetodoAnaliseEF.Text = "" Then
            MessageBox.Show("O campo Método de análise Obrigatório", "Análise Eficácia", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMetodoAnaliseEF.Focus()
            verifEF = True
            Exit Sub
        End If
        'Tratamento de erro Resultados obtidos
        If txtResultadosObtidosEF.Text = "" Then
            MessageBox.Show("O campo Resultados obtidos Obrigatório", "Análise Eficácia", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtResultadosObtidosEF.Focus()
            verifEF = True
            Exit Sub
        End If
        'Tratamento de erro A ação foi eficaz? 
        If radioSimEF.Checked = False And radioNaoEF.Checked = False Then
            MessageBox.Show("Campo A ação foi eficaz? Obrigatório", "Análise Eficácia", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verifEF = True
            Exit Sub
        Else
            '(Se Negativo)
            If radioNaoEF.Checked = True Then
                If txtAcaoEficaz.Text = "" Then
                    MessageBox.Show("Campo Justifique Obrigatório", "Análise Eficácia", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtAcaoEficaz.Focus()
                    verifEF = True
                    Exit Sub
                End If
                If txtOqfazer.Text = "" Then
                    MessageBox.Show("Campo O que fazer Obrigatório", "Análise Eficácia", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtOqfazer.Focus()
                    verifEF = True
                    Exit Sub
                End If
            End If
        End If
        'Tratamento de erro Responsável
        If comboRespEF.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável Obrigatório", "Análise Eficácia", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboRespEF.Focus()
            verifEF = True
            Exit Sub
        End If
        'Tratamento de erro Data
        If dateEF.Text = "" Then
            MessageBox.Show("Campo Data Obrigatório", "Análise Eficácia", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateEF.Focus()
            verifEF = True
            Exit Sub
        End If

    End Sub

#Region "APROVACAO"

    Private Sub radioSimEF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioSimEF.SelectedIndexChanged
        If radioSimEF.Checked = True Then
            lblSeNegativo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            txtAcaoEficaz.Visible = False
            txtAcaoEficazOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            lblOqfazer.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            txtOqfazer.Visible = False
            txtOqfazerOutro.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        End If
    End Sub

    Private Sub radioNaoEF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioNaoEF.SelectedIndexChanged
        If radioNaoEF.Checked = True Then
            lblSeNegativo.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            txtAcaoEficaz.Visible = True
            txtAcaoEficazOutro.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            lblOqfazer.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            txtOqfazer.Visible = True
        End If
    End Sub

#End Region

#End Region

#Region "ANEXOS"

#Region "ADD ANEXOS"

    Private Sub botAnexos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAnexos.Click

        Try

            'Status
            barra.Value = 10
            lblStatus.Text = "Iniciando Inportação de Arquivo..."

            Dim dlgAnexo As FileDialog = New OpenFileDialog()
            Dim caminho As String = ""
            Dim tipo As String = ""
            Dim arquivo As String()
            Dim descricao As String = ""

            If dlgAnexo.ShowDialog() = Windows.Forms.DialogResult.OK Then
                caminho = dlgAnexo.FileName
                arquivo = Split(caminho, "\")
                picAnexo.ImageLocation = caminho
                descricao = arquivo.GetValue(arquivo.GetUpperBound(0))
                tipo = caminho.Substring(caminho.Length - 3, 3)
            Else
                barra.Value = 0
                barra.ForeColor = Color.Red
                lblStatus.Text = "Nenhum aquivo selecionado!"
                Exit Sub
            End If

            'Status
            barra.Value = 30
            lblStatus.Text = "Tratamento do Arquivo..."

            If Not picAnexo.ImageLocation Is Nothing Then
                Dim infoImg As New FileInfo(picAnexo.ImageLocation)
                Dim tamanho As Long = infoImg.Length
                Dim arqStream As New FileStream(picAnexo.ImageLocation, FileMode.Open, FileAccess.Read)
                ANEXO = New Byte(Convert.ToInt32(tamanho - 1)) {}
                arqStream.Read(ANEXO, 0, tamanho)
            End If

            'Status
            barra.Value = 80
            lblStatus.Text = "Salvando Arquivo..."

            If MessageBox.Show("Tem certeza que deseja Salvar o Anexo selecionado", "ISO é Fácil", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then


                If Manager.Anexos.Add(Modulo, _
                                    idmelhorias, _
                                    Tela, _
                                    descricao, _
                                    ANEXO, _
                                    tipo) Then
                    MessageBox.Show("Anexos salvos com sucesso", "ISO é Fácil", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Status
                    barra.Value = 100
                    lblStatus.Text = "Concluido com sucesso!"

                    'carrega Lista
                    carregaListaAnexos(idmelhorias)
                End If

            Else
                barra.Value = 0
                barra.ForeColor = Color.Red
                lblStatus.Text = "Operação Cancelada!"
            End If

        Catch ex As Exception
            lblStatus.Text = "Não foi possivel realizar a operação. Tente novamente." & " ... " & lblStatus.Text
        End Try

    End Sub

#End Region

#Region "EXCLUIR ANEXOS"



#End Region

#End Region

#End Region

End Class
