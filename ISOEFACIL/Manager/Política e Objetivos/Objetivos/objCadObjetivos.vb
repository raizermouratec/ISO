Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1Chart
Imports C1.Win.C1ChartBase
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.objListaObjetivos
Public Class objCadObjetivos

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEdit2 As Boolean = False
    Private isEditarObjetivos As Boolean = False
    Private isEditarResultados As Boolean = False
    Public verif As Boolean = False
    'Public idobjetivos As String
    Public idobjetivos As String = String.Empty
    Public idresultados As String

    'Pega Id Objetivos
    Public WriteOnly Property Objetivos() As String
        Set(ByVal value As String)
            Me.idobjetivos = value
        End Set
    End Property

    'Pega Id Resultados
    Public WriteOnly Property Resultados() As String
        Set(ByVal value As String)
            Me.idresultados = value
        End Set
    End Property

#End Region

#Region "POPULA COMBOS"

#Region "OBJETIVOS"

#Region "TIPO"

    Sub CarregaTipo()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_NORMAS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboTipo.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboTipo.DataSource = dtb
        comboTipo.DisplayMember = "NOME"
        comboTipo.ValueMember = "ID"
    End Sub

#End Region

#Region "UNIDADE MEDIÇÃO"

    Sub CarregaUnidadeMedicao()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM UNIDADE_MEDICAO")
        Dim dtr As DataRow = dtb.NewRow
        dtr("TIPO") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboUnidadedeMedicao.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboUnidadedeMedicao.DataSource = dtb
        comboUnidadedeMedicao.DisplayMember = "TIPO"
        comboUnidadedeMedicao.ValueMember = "ID_UNIDADE_MEDICAO"
    End Sub

#End Region

#Region "RESPONSAVEL"

    Sub CarregaResponsavelObj()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
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

#End Region

#Region "RESULTADOS"

#Region "CARREGA DADOS"

    Sub CarregaDados()
        'Dim Meta As Integer
        'Dim PeriodoX As Date
        'Dim PeriodoY As Date

        'comboUnidadedeMedicao.DataSource = Manager.Util.getDataTable("SELECT TOP 1 ID_OBJETIVOS FROM OBJETIVOS ORDER BY ID_OBJETIVOS DESC")

        'Meta()

    End Sub

#End Region

#Region "RESPONSAVEL"

    Sub CarregaResponsavel()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboResponsavel2.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboResponsavel2.DataSource = dtb
        comboResponsavel2.DisplayMember = "COLABORADOR"
        comboResponsavel2.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "CARREGA TITULO"

    Sub CarregaTitulo()
        txtTituloTitulo.Text = txtTitulo.Text
        txtIdentTitulo.Text = txtIdentificacao.Text
    End Sub

#End Region

#End Region

#Region "GRAFICO"

    Public Sub CarregaGrafico(ByVal id As Integer)

        'Monta Lista de Resultados dos Objetivos passando Id
        Dim Grafico As String = String.Format("SELECT OBJ.ID_OBJETIVOS, METAS_OBJETIVO, OBR.RESULTADO_OBTIDO FROM OBJETIVOS OBJ LEFT JOIN OBJETIVOS_RESULTADOS OBR ON OBJ.ID_OBJETIVOS = OBR.ID_OBJETIVOS WHERE OBJ.ID_OBJETIVOS = {0}", id)
        Dim dt As New DataTable

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(Grafico)

        'Cria a tabela
        'Grafico.DataSource = dt



    End Sub

#End Region

#Region "CARREGA RESULTADOS"

    Public Sub CarregaListaResultados(ByVal id As Integer)

        'Monta Lista de Resultados dos Objetivos passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_OBJETIVOS_RESULTADOS WHERE ID_OBJETIVOS = {0}", id)
        Dim dt As New DataTable

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        ''Não gera colunas automaticas
        gridResult.AutoGenerateColumns = False

        ''Cria a tabela
        gridResult.DataSource = dt

    End Sub

    Private Sub Tab2_Enter(sender As System.Object, e As System.EventArgs) Handles Tab2.Enter
        txtMeta.Text = txtControledeMeta.Text
        datePeriododeMedicaoX.Value = datePeriododevalidade1.Value
        datePeriododeMedicaoY.Value = datePeriododevalidade2.Value
    End Sub

#End Region

#Region "LOAD"

    Private Sub CadastrarPolitica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tab1.Show()
        CarregaTipo()
        CarregaUnidadeMedicao()
        CarregaResponsavel()
        CarregaResponsavelObj()
        'Cor do texto
        txtDescricao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtFormadeCalculo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

    Private Sub datePeriododevalidade1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles datePeriododevalidade1.Validating
        If datePeriododevalidade1.Value > datePeriododevalidade2.Value Then
            MessageBox.Show("Atenção a data inicial não pode ser maior que a data final", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            datePeriododevalidade1.Focus()
            'datePeriododevalidade1.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub datePeriododevalidade2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles datePeriododevalidade2.Validating
        If datePeriododevalidade2.Value < datePeriododevalidade1.Value Then
            MessageBox.Show("Atenção a data final não pode ser menor que a data inicial", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            datePeriododevalidade2.Focus()
            'datePeriododevalidade2.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub botAdicionarUniMedicao_Click(sender As System.Object, e As System.EventArgs) Handles botAdicionarUniMedicao.Click
        objAddUnidadeMedicao.Show()
    End Sub

    Private Sub comboUnidadedeMedicao_GotFocus(sender As Object, e As System.EventArgs) Handles comboUnidadedeMedicao.GotFocus
        CarregaUnidadeMedicao()
    End Sub

    Private Sub txtControledeMeta_ChangeCommitted(sender As Object, e As System.EventArgs) Handles txtControledeMeta.ChangeCommitted

        If Not IsNumeric(txtControledeMeta.Text) Then
            MessageBox.Show("Campo Metas do Objetivo somente números", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtControledeMeta.Text = ""
            txtControledeMeta.Focus()
        End If

    End Sub

    Private Sub txtPeriodicidadedaMedicao_ChangeCommitted(sender As Object, e As System.EventArgs) Handles txtPeriodicidadedaMedicao.ChangeCommitted

        If Not IsNumeric(txtPeriodicidadedaMedicao.Text) Then
            MessageBox.Show("Campo Periodicidade da Medição somente números", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPeriodicidadedaMedicao.Text = ""
            txtPeriodicidadedaMedicao.Focus()
        End If

    End Sub

    Private Sub txtTitulo_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtTitulo.LostFocus
        CarregaTitulo()
    End Sub

    Private Sub txtIdentificacao_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtIdentificacao.LostFocus
        CarregaTitulo()
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoObjetivo()
        'Cadastrar Novo
        Tab2.Enabled = False
        isEdit = False
        Me.Show()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarObjetivos(ByVal id As Integer)
        'Editar
        isEdit = True
        Tab2.Enabled = True

        'Carrega Combos
        CarregaTipo()
        CarregaUnidadeMedicao()
        CarregaListaResultados(id)
        CarregaResponsavel()
        CarregaResponsavelObj()

        'Muda o Label do botão Incluir
        botSalvar.Width = 80
        botSalvar.Text = "Atualizar"

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM OBJETIVOS WHERE ID_OBJETIVOS = {0}", id)

        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtTitulo.Text = dr("TITULO").ToString
                Me.txtTituloTitulo.Text = dr("TITULO").ToString
                Me.comboTipo.SelectedValue = dr("ID_NORMAS").ToString
                Me.txtIdentificacao.Text = dr("IDENTIFICACAO").ToString
                Me.txtIdentTitulo.Text = dr("IDENTIFICACAO").ToString
                Me.txtDescricao.Text = dr("DESCRICAO").ToString
                Me.txtFormadeCalculo.Text = dr("FORMA_CALCULO").ToString
                Me.comboUnidadedeMedicao.SelectedValue = dr("ID_UNIDADE_MEDICAO").ToString
                Me.txtControledeMeta.Text = dr("METAS_OBJETIVO").ToString
                Me.datePeriododevalidade1.Text = dr("PERIODO_X").ToString
                Me.datePeriododevalidade2.Text = dr("PERIODO_y").ToString
                Me.txtPeriodicidadedaMedicao.Text = dr("PERIODICIDADE_MEDICAO").ToString
                Me.comboResponsavel.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.dateDataCadastro.Text = dr("DATA_CADASTRO").ToString
                Me.txtMeta.Text = dr("METAS_OBJETIVO").ToString
                Me.datePeriododeMedicaoX.Value = dr("PERIODO_X").ToString
                Me.datePeriododeMedicaoY.Value = dr("PERIODO_Y").ToString

                Dim cod As Integer = 0

                'Seleciona o ultimo ID da tabela
                Dim sql1 As String = String.Format("SELECT MAX(ID_OBJETIVOS) as ID FROM OBJETIVOS")

                Try

                    Dim dr1 As SqlDataReader = Manager.Util.getDataReader(sql1)

                    While dr1.Read

                        cod = dr1("ID").ToString

                    End While

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

                'Seleciona o ID do código anterior e traz os atributos de suas respectivas tabelas!
                Dim sql2 As String = String.Format("SELECT * FROM OBJETIVOS WHERE ID_OBJETIVOS = {0}", cod)

                Try

                    Dim dr2 As SqlDataReader = Manager.Util.getDataReader(sql)

                    While dr2.Read

                        Me.txtMeta.Text = dr2("METAS_OBJETIVO").ToString
                        Me.datePeriododeMedicaoX.Value = dr2("PERIODO_X").ToString
                        Me.datePeriododeMedicaoY.Value = dr2("PERIODO_Y").ToString

                    End While

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

    Public Sub EditarResultados(ByVal id As Integer)

        'Editar
        isEdit2 = True
        Tab2.Enabled = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Muda o Label do botão Incluir
        botIncluir.Width = 80
        botIncluir.Text = "Atualizar"
        botIncluir.Image = ImageList.Images.Item(1)

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM OBJETIVOS_RESULTADOS WHERE ID_OBJETIVOS_RESULTADOS = {0}", id)

        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtResultadoObtido.Text = dr("RESULTADO_OBTIDO").ToString
                Me.dataDataMedicao.Value = dr("DATA_MEDICAO").ToString
                Me.comboResponsavel2.SelectedValue = dr("ID_COLABORADORES").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "ABAS"

#Region "OBJETIVOS"

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim objetivos As New objetivos

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            VerificarObj()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If objetivos.Update(idobjetivos, _
                                    comboTipo.SelectedValue, _
                                    comboUnidadedeMedicao.SelectedValue, _
                                    comboResponsavel.SelectedValue, _
                                    txtTitulo.Text, _
                                    txtIdentificacao.Text, _
                                    txtDescricao.Text, _
                                    txtFormadeCalculo.Text, _
                                    txtControledeMeta.Text, _
                                    datePeriododevalidade1.Value, _
                                    datePeriododevalidade2.Value, _
                                    txtPeriodicidadedaMedicao.Text, _
                                    dateDataCadastro.Value) Then
                        objListaObjetivos.carregaObjetivos()
                        MessageBox.Show("Dados de Objetivos atualizados com sucesso", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            'Verificar campos obrigatórios
            VerificarObj()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    idobjetivos = objetivos.Add(comboTipo.SelectedValue, _
                                     comboUnidadedeMedicao.SelectedValue, _
                                     comboResponsavel.SelectedValue, _
                                     txtTitulo.Text, _
                                     txtIdentificacao.Text, _
                                     txtDescricao.Text, _
                                     txtFormadeCalculo.Text, _
                                     txtControledeMeta.Text, _
                                     datePeriododevalidade1.Value, _
                                     datePeriododevalidade2.Value, _
                                     txtPeriodicidadedaMedicao.Text, _
                                     dateDataCadastro.Value)
                    If idobjetivos <> String.Empty Then
                        objListaObjetivos.carregaObjetivos()
                        CarregaListaResultados(idobjetivos)
                        MessageBox.Show("Objetivos salva com sucesso", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Tab2.Enabled = True
                        isEdit = True
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub VerificarObj()
        verif = False

        'Tratamento de erro Título
        If txtTitulo.Text = "" Then
            MessageBox.Show("Campo Título Obrigatório", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTitulo.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Tipo
        If comboTipo.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Tipo Obrigatório", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboTipo.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Forma de Cálculo
        If txtFormadeCalculo.Text = "" Then
            MessageBox.Show("Campo Forma de Cálculo Obrigatório", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFormadeCalculo.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Unidade de Medição
        If comboUnidadedeMedicao.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Unidade de Medição Obrigatório", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboUnidadedeMedicao.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Metas do Objetivo
        If Not IsNumeric(txtControledeMeta.Text) Or txtControledeMeta.Text = "" Then
            MessageBox.Show("Campo Metas do Objetivo Obrigatório, Somente número", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtControledeMeta.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Período de Validade - Início
        If datePeriododevalidade1.Text = "" Then
            MessageBox.Show("Campo Período de validade - Início Obrigatório", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            datePeriododevalidade1.Focus()
            verif = True
            Exit Sub
        Else
            'Tratamento de erro Período e maior que o periodo 2 
            If datePeriododevalidade1.Value > datePeriododevalidade2.Value Then
                MessageBox.Show("Atenção a data inicial não pode ser maior que a data final", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                datePeriododevalidade1.Focus()
                verif = True
                Exit Sub
            End If
        End If
        'Tratamento de erro Período de Validade - Término
        If datePeriododevalidade2.Text = "" Then
            MessageBox.Show("Campo Período de validade - Término Obrigatório", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            datePeriododevalidade2.Focus()
            verif = True
            Exit Sub
        Else
            'Tratamento de erro Período e menor que o periodo 1 
            If datePeriododevalidade2.Value < datePeriododevalidade1.Value Then
                MessageBox.Show("Atenção a data final não pode ser menor que a data inicial", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                datePeriododevalidade2.Focus()
                verif = True
                Exit Sub
            End If
        End If
        'Tratamento de erro Periodicidade da Medição
        If Not IsNumeric(txtPeriodicidadedaMedicao.Text) Or txtPeriodicidadedaMedicao.Text = "" Then
            MessageBox.Show("Campo Periodicidade da Medição Obrigatório, Somente número", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPeriodicidadedaMedicao.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Responsável
        If comboResponsavel.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável Obrigatório", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResponsavel.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data de Cadastro
        If dateDataCadastro.Text = "" Then
            MessageBox.Show("Campo Data de Cadastro Obrigatório", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateDataCadastro.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#End Region

#Region "RESULTADOS"

#Region "INCLUIR"

    Private Sub botIncluir_Click(sender As System.Object, e As System.EventArgs) Handles botIncluir.Click

        'Seta a Classe
        Dim resultados As New resultados

        'Inicio Atualizar/Salvar
        If isEdit2 Then

            'Verificar campos obrigatórios
            VerificarRes()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                'Troca as Configurações do Botão
                botIncluir.Text = "Incluir"
                botIncluir.Image = ImageList.Images.Item(1)
                Try
                    'Atualizar
                    If resultados.Update(idresultados, _
                                         idobjetivos, _
                                         comboResponsavel2.SelectedValue, _
                                         txtResultadoObtido.Text, _
                                         dataDataMedicao.Value) Then
                        CarregaListaResultados(idobjetivos)
                        txtResultadoObtido.Text = ""
                        dataDataMedicao.Text = ""
                        comboResponsavel2.Text = ""
                        comboResponsavel2.Text = ""
                        isEdit2 = False
                        MessageBox.Show("Dados de Resultados atualizados com sucesso", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            'Verificar campos obrigatórios
            VerificarRes()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If resultados.Add(idobjetivos, _
                                      comboResponsavel2.SelectedValue, _
                                      txtResultadoObtido.Text, _
                                      dataDataMedicao.Value) Then
                        CarregaListaResultados(idobjetivos)
                        txtResultadoObtido.Text = ""
                        dataDataMedicao.Text = ""
                        comboResponsavel2.Text = ""
                        comboResponsavel2.Text = ""
                        MessageBox.Show("Resultados salvos com sucesso", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If


    End Sub

    Private Sub VerificarRes()
        verif = False

        'Tratamento de erro Resultado Obtido
        If txtResultadoObtido.Text = "" Then
            MessageBox.Show("Campo Resultado Obtido Obrigatório", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtResultadoObtido.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data de Medição
        If dataDataMedicao.Text = "" Then
            MessageBox.Show("Campo Data de Medição Obrigatório", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataDataMedicao.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Responsável
        If comboResponsavel2.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável Obrigatório", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResponsavel2.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridResult.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim id As Integer = 0

            botIncluir.Text = "Salvar"
            botIncluir.Image = ImageList.Images.Item(0)

            'Passagem de parametros
            Try

                id = gridResult(gridResult.RowSel, 1)
                Resultados = id
                EditarResultados(id)


            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If gridResult.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim resultados As New resultados

            'Excluir o Objetivos
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Resultados", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    resultados.Delete(gridResult(gridResult.RowSel, 1))
                    CarregaListaResultados(idobjetivos)
                    MessageBox.Show("Resultado excluído com sucesso", "Resultados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "EXPORTAR"

    Private Sub botExportExcel_Click(sender As System.Object, e As System.EventArgs) Handles botExportExcel.Click
        Dim strNomeGridexcel = "gridResult.xls" '//NOME DO GRID + EXTENÇÃO .xls
        gridResult.SaveGrid(strNomeGridexcel, C1.Win.C1FlexGrid.FileFormatEnum.Excel, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        MessageBox.Show("Exportação realizada com sucesso", "Operação de Exportação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region

#End Region

#End Region
    
End Class
