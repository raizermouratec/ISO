Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.procListaProcessos
Public Class procCadProcessos

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditProcessos As Boolean = False
    Private isEditAtividade As Boolean = False
    Private isEditProcessosAtividade As Boolean = False
    Public verif As Boolean = False
    'Public idprocessos As String
    Public idprocessos As String = String.Empty
    Public idprocessosatividade As String
    Public Quem As Integer
    Public dbCont As New DataTable
    Public cont As Integer = 1

    'Anexos
    Private ANEXO() As Byte
    Public Modulo As String = "PROCESSOS"
    Public Tela As String = "procCadProcessos"

    'Pega Id Registro
    Public WriteOnly Property Processos() As String
        Set(ByVal value As String)
            Me.idprocessos = value
        End Set
    End Property

    'Pega Id Registro
    Public WriteOnly Property ProcessosAtividade() As String
        Set(ByVal value As String)
            Me.idprocessosatividade = value
        End Set
    End Property

#End Region

#Region "POPULA COMBOS"

#Region "SETOR"

    Sub CarregaSetor()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_AREAS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("DESCRICAO") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboSetor.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboSetor.DataSource = dtb
        comboSetor.DisplayMember = "DESCRICAO"
        comboSetor.ValueMember = "ID"

    End Sub

#End Region

#Region "AREAS"

    Sub CarregaComboAreas()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_AREAS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("DESCRICAO") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboArea.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboArea.DataSource = dtb
        comboArea.DisplayMember = "DESCRICAO"
        comboArea.ValueMember = "ID"

    End Sub

#End Region

#Region "CARGO"

    Sub CarregaComboCargos()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_CARGOS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("CARGO") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboCargo.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboCargo.DataSource = dtb
        comboCargo.DisplayMember = "CARGO"
        comboCargo.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "CARREGA LISTA"

    Public Sub CarregaAtividade(ByVal id As Integer)

        'Monta Lista de Risco do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_PROCESSOS_ATIVIDADE WHERE ID_PROCESSOS = {0}", id)
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridAtividades.AutoGenerateColumns = False

        'Cria a tabela
        gridAtividades.DataSource = dt

    End Sub

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

#End Region

#Region "LOAD"

    Private Sub procCadastroProcesso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tab1.Show()
        CarregaSetor()
        CarregaComboAreas()
        CarregaComboCargos()
        carregaListaAnexos(idprocessos)
        txtObjetivos.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtEntradas.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtFornecedores.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtSaidas.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtClientes.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        'contador()
    End Sub

    Private Sub comboQuem_ChangeCommitted(sender As System.Object, e As System.EventArgs) Handles comboQuem.ChangeCommitted

        If comboQuem.Text = "Todas as áreas" Then
            'op1
            Quem = 1
            txtCampoLivre.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            inpultArea.Visible = False
            inpultCargo.Visible = False
        ElseIf comboQuem.Text = "Campo livre" Then
            'op2
            Quem = 2
            txtCampoLivre.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            inpultArea.Visible = False
            inpultCargo.Visible = False
        ElseIf comboQuem.Text = "Qualquer colaborador" Then
            'op3
            Quem = 3
            txtCampoLivre.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            inpultArea.Visible = False
            inpultCargo.Visible = False
        ElseIf comboQuem.Text = "Área" Then
            'op4
            Quem = 4
            txtCampoLivre.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            inpultArea.Visible = True
            inpultArea.Location = New Point(95, 80)
            inpultCargo.Visible = False
        ElseIf comboQuem.Text = "Cargo" Then
            'op4
            Quem = 5
            txtCampoLivre.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            inpultArea.Visible = False
            inpultCargo.Visible = True
            inpultCargo.Location = New Point(95, 80)
        End If

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoProcesso()

        'Cadastrar Novo
        tab2.Enabled = False
        isEdit = False
        txtNAtividade.Text = "0"
        Numero()
        Me.Show()

    End Sub

#End Region

#Region "BOTOES"

#Region "DEFINICOES"

#Region "SALVAR DEFINICOES"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim processo As New processo

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            VerificarProcesso()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If processo.Update(idprocessos, _
                                       comboSetor.SelectedValue, _
                                       txtNome.Text, _
                                       txtObjetivos.Text, _
                                       txtEntradas.Text, _
                                       txtFornecedores.Text, _
                                       txtSaidas.Text, _
                                       txtClientes.Text) Then
                        procListaProcessos.CarregaProcessos()
                        MessageBox.Show("Dados do Processo atualizados com sucesso", "Processo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

            Else

                'Verificar campos obrigatórios
                VerificarProcesso()
                'Checando se campos obrigatórios estão OK
                If verif = False Then
                    Try
                        'Salvar
                    idprocessos = processo.Add(comboSetor.SelectedValue, _
                                       txtNome.Text, _
                                       txtObjetivos.Text, _
                                       txtEntradas.Text, _
                                       txtFornecedores.Text, _
                                       txtSaidas.Text, _
                                       txtClientes.Text)
                    If idprocessos <> String.Empty Then
                        procListaProcessos.CarregaProcessos()
                        CarregaAtividade(idprocessos)
                        tab2.Enabled = True
                        MessageBox.Show("Processo salvo com sucesso", "Processos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If


    End Sub

    Private Sub VerificarProcesso()
        verif = False

        'Tratamento de erro Nome
        If txtNome.Text = "" Then
            MessageBox.Show("O campo Nome Obrigatório", "Processos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNome.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Setor
        If comboSetor.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("O campo Setor Obrigatório", "Processos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboSetor.Focus()
            verif = True
            Exit Sub
        End If
        ''Tratamento de erro Objetivos
        'If txtObjetivos.Text = "" Then
        '    MessageBox.Show("O campo Objetivos não foi preenchido", "Processos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtObjetivos.Focus()
        '    Exit Sub
        'End If
        ''Tratamento de erro Entradas
        'If txtEntradas.Text = "" Then
        '    MessageBox.Show("O campo Entradas não foi preenchido", "Processos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtEntradas.Focus()
        '    Exit Sub
        'End If
        ''Tratamento de erro Fornecedores
        'If txtFornecedores.Text = "" Then
        '    MessageBox.Show("O campo Fornecedores não foi preenchido", "Processos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtFornecedores.Focus()
        '    Exit Sub
        'End If
        ''Tratamento de erro Saidas
        'If txtSaidas.Text = "" Then
        '    MessageBox.Show("O campo Saídas não foi preenchido", "Processos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtSaidas.Focus()
        '    Exit Sub
        'End If
        ''Tratamento de erro Clientes
        'If txtClientes.Text = "" Then
        '    MessageBox.Show("O campo Clientes não foi preenchido", "Processos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtClientes.Focus()
        '    Exit Sub
        'End If

    End Sub

#End Region

#Region "EDITAR DEFINICOES"

    Public Sub EditarProcessos(ByVal id As Integer)

        'Editar
        isEdit = True

        'Muda o Label do botão Incluir
        botSalvar.Width = 80
        botSalvar.Text = "Atualizar"

        'Carrega Combos
        CarregaAtividade(id)
        CarregaSetor()
        CarregaComboAreas()
        CarregaComboCargos()
        carregaListaAnexos(id)
        tab2.Enabled = True

        'Seleciona Processo pelo Id
        Dim sql As String = String.Format("SELECT * FROM PROCESSOS WHERE ID_PROCESSOS = {0}", id)

        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.comboSetor.SelectedValue = dr("ID_AREAS").ToString
                Me.txtNome.Text = dr("NOME").ToString
                Me.txtObjetivos.Text = dr("OBJETIVOS").ToString
                Me.txtEntradas.Text = dr("ENTRADAS").ToString
                Me.txtFornecedores.Text = dr("FORNECEDORES").ToString
                Me.txtSaidas.Text = dr("SAIDAS").ToString
                Me.txtClientes.Text = dr("CLIENTES").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

#End Region

#End Region

#Region "ATIVIDADE"

#Region "SALVAR ATIVIDADES"

    Private Sub botSalvarAtividade_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarAtividade.Click

        'Seta a Classe
        Dim atividade As New atividade

        Numero()

        'Verificando valor de Quem
        Dim area, cargo As New Integer
        'Caso seja Todas as areas 
        If Quem = 1 Then
            If Not comboArea.SelectedValue Is Nothing And Not comboCargo.SelectedValue Is Nothing Then
                area = 0
                cargo = 0
            End If
            'Caso seja Campo livre
        ElseIf Quem = 2 Then
            If Not comboArea.SelectedValue Is Nothing And Not comboCargo.SelectedValue Is Nothing Then
                area = 0
                cargo = 0
            End If
            'Caso seja Qualquer Colaborador
        ElseIf Quem = 3 Then
            If Not comboArea.SelectedValue Is Nothing And Not comboCargo.SelectedValue Is Nothing Then
                area = 0
                cargo = 0
            End If
            'Caso seja Área
        ElseIf Quem = 4 Then
            If Not comboCargo.SelectedValue Is Nothing Then
                cargo = 0
            End If
            area = comboArea.SelectedValue
            'Caso seja Cargo
        ElseIf Quem = 5 Then
            If Not comboArea.SelectedValue Is Nothing Then
                area = 0
            End If
            cargo = comboCargo.SelectedValue
        End If

        'Inicio Atualizar/Salvar
        If isEditAtividade Then

            'Verificar campos obrigatórios
            VerificarProcessoAtividade()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If atividade.Update(idprocessosatividade, _
                                        idprocessos, _
                                        txtNAtividade.Text, _
                                        txtOque.Text, _
                                        Quem, _
                                        txtCampoLivre.Text, _
                                        area, _
                                        cargo) Then
                        txtCampoLivre.Text = ""
                        txtCampoLivre.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                        txtOque.Text = ""
                        comboQuem.Text = ""
                        comboArea.Text = ""
                        inpultArea.Visible = False
                        comboCargo.Text = ""
                        inpultCargo.Visible = False
                        isEditAtividade = False
                        CarregaAtividade(idprocessos)
                        MessageBox.Show("Dados do Processo atualizados com sucesso", "Processos Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            'Verificar campos obrigatórios
            VerificarProcessoAtividade()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If atividade.Add(idprocessos, _
                                     txtNAtividade.Text, _
                                     txtOque.Text, _
                                     Quem, _
                                     txtCampoLivre.Text, _
                                     area, _
                                     cargo) Then
                        txtCampoLivre.Text = ""
                        txtCampoLivre.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                        txtOque.Text = ""
                        comboQuem.Text = ""
                        comboArea.Text = ""
                        inpultArea.Visible = False
                        comboCargo.Text = ""
                        inpultCargo.Visible = False
                        CarregaAtividade(idprocessos)
                        MessageBox.Show("Processo salvo com sucesso", "Processos Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Numero()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub VerificarProcessoAtividade()
        verif = False

        'Tratamento de erro O que
        If txtOque.Text = "" Then
            MessageBox.Show("Campo O que Obrigatório", "Processos Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtOque.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Quem
        If comboQuem.Text = "" Then
            MessageBox.Show("Campo Quem Obrigatório", "Processos Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboQuem.Focus()
            verif = True
            Exit Sub
            'Tratamento de erro Campo Livre
        ElseIf comboQuem.Text = "Campo livre" Then
            If txtCampoLivre.Text = "" Then
                MessageBox.Show("Campo livre Obrigatório", "Processos Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCampoLivre.Focus()
                verif = True
                Exit Sub
            End If
            'Tratamento de erro Area
        ElseIf comboQuem.Text = "Área" Then
            If comboArea.SelectedValue.ToString = String.Empty Then
                MessageBox.Show("Campo Área Obrigatório", "Processos Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                comboArea.Focus()
                verif = True
                Exit Sub
            End If
            'Tratamento de erro Cargo
        ElseIf comboQuem.Text = "Cargo" Then
            If comboCargo.SelectedValue.ToString = String.Empty Then
                MessageBox.Show("Campo Cargo Obrigatório", "Processos Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                comboCargo.Focus()
                verif = True
                Exit Sub
            End If
        End If

    End Sub

    Sub Numero()
        'Verificando valor de Número Atividade
        Try
            dbCont = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_PROCESSOS_ATIVIDADE")
            If dbCont.Rows.Count >= 1 Then
                cont = dbCont.Rows.Count + 1
                txtNAtividade.Text = cont.ToString
            Else
                txtNAtividade.Text = cont.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "EDITAR ATIVIDADES"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        Dim id As Integer = 0

        If gridAtividades.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Processos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Passagem de parametros
            Try
                id = gridAtividades(gridAtividades.RowSel, 1)
                ProcessosAtividade = id
                EditarProcessosAtividade(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Sub EditarProcessosAtividade(ByVal id As Integer)

        'Editar
        isEditAtividade = True

        'Muda o Label do botão Incluir
        botSalvarAtividade.Width = 80
        botSalvarAtividade.Text = "Atualizar"

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Processo pelo Id
        Dim sql As String = String.Format("SELECT * FROM PROCESSOS_ATIVIDADE WHERE ID_PROCESSOS_ATIVIDADE = {0}", id)

        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtNAtividade.Text = dr("N_ATIVIDADE").ToString
                Me.txtOque.Text = dr("O_QUE").ToString
                '
                If dr("QUEM") = 1 Then
                    comboQuem.SelectedItem = op1
                    txtCampoLivre.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                    inpultArea.Visible = False
                    inpultCargo.Visible = False
                ElseIf dr("QUEM") = 2 Then
                    comboQuem.SelectedItem = op2
                    txtCampoLivre.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                    inpultArea.Visible = False
                    inpultCargo.Visible = False
                    Me.txtCampoLivre.Text = dr("CAMPO_LIVRE").ToString
                ElseIf dr("QUEM") = 3 Then
                    comboQuem.SelectedItem = op3
                    txtCampoLivre.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                    inpultArea.Visible = False
                    inpultCargo.Visible = False
                ElseIf dr("QUEM") = 4 Then
                    comboQuem.SelectedItem = op4
                    txtCampoLivre.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                    inpultArea.Visible = True
                    inpultArea.Location = New Point(95, 80)
                    inpultCargo.Visible = False
                    Me.comboArea.SelectedValue = dr("AREAS").ToString
                ElseIf dr("QUEM") = 5 Then
                    comboQuem.SelectedItem = op5
                    txtCampoLivre.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                    inpultArea.Visible = False
                    inpultCargo.Visible = True
                    inpultCargo.Location = New Point(95, 80)
                    Me.comboCargo.SelectedValue = dr("CARGOS").ToString
                End If

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "EXCLUIR ATIVIDADES"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        Dim atividade As New atividade

        If gridAtividades.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Processos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Excluir o Atividade
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Processos - Atividade", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    atividade.Delete(gridAtividades(gridAtividades.RowSel, 1))
                    CarregaAtividade(idprocessos)
                    MessageBox.Show("Projeto excluído com sucesso", "Processos - Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "INCLUIR ATIVIDADES"

    Private Sub botIncluirAtiv_Click(sender As System.Object, e As System.EventArgs) Handles botIncluirAtiv.Click

        'Seta a Classe
        Dim atividade As New atividade

        'Verificando valor de Número Atividade
        Try
            dbCont = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_PROCESSOS_ATIVIDADE")
            If dbCont.Rows.Count >= 1 Then
                cont = dbCont.Rows.Count + 1
                txtNAtividade.Text = cont.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Verificando valor de Quem
        Dim area, cargo As New Integer
        'Caso seja Todas as areas 
        If Quem = 1 Then
            If Not comboArea.SelectedValue Is Nothing And Not comboCargo.SelectedValue Is Nothing Then
                area = 0
                cargo = 0
            End If
            'Caso seja Campo livre
        ElseIf Quem = 2 Then
            If Not comboArea.SelectedValue Is Nothing And Not comboCargo.SelectedValue Is Nothing Then
                area = 0
                cargo = 0
            End If
            'Caso seja Qualquer Colaborador
        ElseIf Quem = 3 Then
            If Not comboArea.SelectedValue Is Nothing And Not comboCargo.SelectedValue Is Nothing Then
                area = 0
                cargo = 0
            End If
            'Caso seja Área
        ElseIf Quem = 4 Then
            If Not comboCargo.SelectedValue Is Nothing Then
                cargo = 0
            End If
            area = comboArea.SelectedValue
            'Caso seja Cargo
        ElseIf Quem = 5 Then
            If Not comboArea.SelectedValue Is Nothing Then
                area = 0
            End If
            cargo = comboCargo.SelectedValue
        End If

        'Verificar campos obrigatórios
        VerificarProcessoAtividade()
        'Checando se campos obrigatórios estão OK
        If verif = False Then
            Try
                'Salvar
                If atividade.Add(idprocessos, _
                                 txtNAtividade.Text, _
                                 txtOque.Text, _
                                 Quem, _
                                 txtCampoLivre.Text, _
                                 area, _
                                 cargo) Then
                    txtCampoLivre.Text = ""
                    txtCampoLivre.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                    txtOque.Text = ""
                    comboQuem.Text = ""
                    comboArea.Text = ""
                    inpultArea.Visible = False
                    comboCargo.Text = ""
                    inpultCargo.Visible = False
                    CarregaAtividade(idprocessos)
                    MessageBox.Show("Processo inserido com sucesso", "Processos Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        Else
            Exit Sub
        End If

    End Sub

#End Region

#End Region

#Region "ANEXOS"

#Region "ANEXOS"

#Region "ADD ANEXOS"

    Private Sub botAnexos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAnexos.Click

        Try

            'Status
            barra1.Value = 10
            lblStatus1.Text = "Iniciando Inportação de Arquivo..."

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
                barra1.Value = 0
                barra1.ForeColor = Color.Red
                lblStatus1.Text = "Nenhum aquivo selecionado!"
                Exit Sub
            End If

            'Status
            barra1.Value = 30
            lblStatus1.Text = "Tratamento do Arquivo..."

            If Not picAnexo.ImageLocation Is Nothing Then
                Dim infoImg As New FileInfo(picAnexo.ImageLocation)
                Dim tamanho As Long = infoImg.Length
                Dim arqStream As New FileStream(picAnexo.ImageLocation, FileMode.Open, FileAccess.Read)
                ANEXO = New Byte(Convert.ToInt32(tamanho - 1)) {}
                arqStream.Read(ANEXO, 0, tamanho)
            End If

            'Status
            barra1.Value = 80
            lblStatus1.Text = "Salvando Arquivo..."

            If MessageBox.Show("Tem certeza que deseja Salvar o Anexo selecionado", "ISO é Fácil", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then


                If Manager.Anexos.Add(Modulo, _
                                    idprocessos, _
                                    Tela, _
                                    descricao, _
                                    ANEXO, _
                                    tipo) Then
                    MessageBox.Show("Anexos salvos com sucesso", "ISO é Fácil", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Status
                    barra1.Value = 100
                    lblStatus1.Text = "Concluido com sucesso!"

                    'carrega Lista
                    carregaListaAnexos(idprocessos)
                End If

            Else
                barra1.Value = 0
                barra1.ForeColor = Color.Red
                lblStatus1.Text = "Operação Cancelada!"
            End If

        Catch ex As Exception
            lblStatus1.Text = "Não foi possivel realizar a operação. Tente novamente." & " ... " & lblStatus1.Text
        End Try

    End Sub

#End Region

#Region "EXCLUIR ANEXOS"



#End Region

#End Region

#End Region

#End Region

End Class
