Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.projCadProjeto
Imports ISOEFACIL.projListaProjetos
Public Class projPlanodeProjeto

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditObjetivos As Boolean = False
    Private isEditEscopo As Boolean = False
    Private isEditSaidas As Boolean = False
    Public idprojetos As String
    Public idobjetivostexto As String
    Public idescopo As String
    Public idsaidas As String

    'Public idrisco As String
    Dim tipo As Integer

    'Pega Id Projeto
    Public WriteOnly Property Projetos() As String
        Set(ByVal value As String)
            Me.idprojetos = value
        End Set
    End Property

    'Pega Id Objetivos_Texto
    Public WriteOnly Property Objetivos() As String
        Set(ByVal value As String)
            Me.idobjetivostexto = value
        End Set
    End Property

    'Pega Id Escopo
    Public WriteOnly Property Escopo() As String
        Set(ByVal value As String)
            Me.idescopo = value
        End Set
    End Property

    'Pega Id Saída
    Public WriteOnly Property Saidas() As String
        Set(ByVal value As String)
            Me.idsaidas = value
        End Set
    End Property

#End Region

#Region "CARREGAR LISTAS"

#Region "SAÍDAS"

    Public Sub CarregaSaidas(ByVal id As Integer)

        'Monta Lista de Saídas do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_PROJETOS_PLANO_SAIDAS WHERE PROJETOS = {0}", id)
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridSaidas.AutoGenerateColumns = False

        'Cria a tabela
        gridSaidas.DataSource = dt

    End Sub

#End Region

#Region "ESTAGIOS"

    Public Sub CarregaAtividade(ByVal id As Integer)

        'Monta Lista de Estagios/Atividade do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_PROJETOS_PLANO_ESTAGIOS_ATIVIDADE WHERE PROJETOS = {0}", id)
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridAtividade.AutoGenerateColumns = False

        'Cria a tabela
        gridAtividade.DataSource = dt

    End Sub

    Public Sub Carrega5W2H(ByVal id As Integer)

        'Monta Lista de Estagios/5W2H do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_PROJETOS_PLANO_ESTAGIOS_5W2H WHERE PROJETOS = {0}", id)
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        grid5W2H.AutoGenerateColumns = False

        'Cria a tabela
        grid5W2H.DataSource = dt

    End Sub

#End Region

#Region "RECURSOS"

    Public Sub CarregaRecursos(ByVal id As Integer)

        'Monta Lista de Recursos do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_PROJETOS_PLANO_RECURSOS WHERE ID_PROJETOS = {0}", id)
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridRecursos.AutoGenerateColumns = False

        'Cria a tabela
        gridRecursos.DataSource = dt

    End Sub

#End Region

#Region "CONTROLE"

    Public Sub CarregaControleAC(ByVal id As Integer)

        'Monta Lista de Análise Crítica do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_PROJETOS_PLANO_CONTROLE_AC WHERE PROJETOS = {0}", id)
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridAnaliseCritica.AutoGenerateColumns = False

        'Cria a tabela
        gridAnaliseCritica.DataSource = dt

    End Sub

    Public Sub CarregaControleVerif(ByVal id As Integer)

        'Monta Lista de Verificação do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_PROJETOS_PLANO_CONTROLE_VERIFICACAO WHERE PROJETOS = {0}", id)
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridVerif.AutoGenerateColumns = False

        'Cria a tabela
        gridVerif.DataSource = dt

    End Sub

    Public Sub CarregaControleValid(ByVal id As Integer)

        'Monta Lista de Validação do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_PROJETOS_PLANO_CONTROLE_VALIDACAO WHERE PROJETOS = {0}", id)
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridValidacao.AutoGenerateColumns = False

        'Cria a tabela
        gridValidacao.DataSource = dt

    End Sub

#End Region

#Region "RISCO"

    Public Sub CarregaRisco(ByVal id As Integer)

        'Monta Lista de Risco do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_PROJETOS_PLANO_RISCO WHERE PROJETOS = {0}", id)
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)
        

        'Não gera colunas automaticas
        gridRisco.AutoGenerateColumns = False

        'Cria a tabela
        gridRisco.DataSource = dt

        Try

            'Função para validação de Imagem
            For Each dr As DataRow In dt.Rows

                If dr("CLASSE") = 1 Then
                    'ALTA
                    gridRisco.SetCellImage(i, 8, _imgListClasse.Images.Item(2))
                ElseIf dr("CLASSE") = 2 Then
                    'MEDIO
                    gridRisco.SetCellImage(i, 8, _imgListClasse.Images.Item(1))
                ElseIf dr("CLASSE") = 3 Then
                    'BAIXO
                    gridRisco.SetCellImage(i, 8, _imgListClasse.Images.Item(0))
                End If
                i += 1

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "REVISOES"

    Public Sub CarregaRevisao(ByVal id As Integer)

        'Monta Lista de Revisões do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_PROJETOS_PLANO_REVISOES WHERE PROJETOS = {0}", id)
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridRevisao.AutoGenerateColumns = False

        'Cria a tabela
        gridRevisao.DataSource = dt

    End Sub

#End Region

#End Region

#Region "CARREGA DADOS PROJETOS"

    Public Sub CarregaDados(ByVal id As Integer)

        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_PROJETOS WHERE ID_PROJETOS = {0}", id)
        Dim sql2 As String = String.Format("SELECT * FROM PROJETOS_PLANO_OBJETIVOS_TEXTO WHERE ID_PROJETOS_PLANO_OBJETIVOS_TEXTO = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtProjeto.Text = dr("TITULO").ToString
                Me.txtIdentificacao.Text = dr("IDENTIFICACAO").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
        'Popula os campos com os dados do Banco
        Try

            Dim dr2 As SqlDataReader = Manager.Util.getDataReader(sql2)


            While dr2.Read

                Me.txtObjGeral.Text = dr2("OBJETIVO_GERAL").ToString
                If dr2("TIPO") = 0 Then
                    Me.radioObjTexto.Checked = True
                End If
                Me.txtObjTexto.Text = dr2("TEXTO").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
        

    End Sub

    Public Sub CarregaEscopo(ByVal id As Integer)

        isEdit = True

        Me.Show()

        Dim sql3 As String = String.Format("SELECT * FROM PROJETOS_PLANO_ESCOPO WHERE ID_PROJETOS_PLANO_ESCOPO = {0}", id)

        'Popula os campos com os dados do Banco
        Try
            Dim dr3 As SqlDataReader = Manager.Util.getDataReader(sql3)

            While dr3.Read

                Me.txtRequisitosEspecificados.Text = dr3("ESPECIFICADOS").ToString
                Me.txtRequisitosEstatutarios.Text = dr3("ESTATUARIOS").ToString
                Me.txtRequisitosRegulamentares.Text = dr3("REGULAMENTARES").ToString
                Me.txtOutrosRequisitos.Text = dr3("OUTROS").ToString
                Me.txtInformacoes.Text = dr3("INFORMACOES").ToString
                Me.txtRequisitosExclusao.Text = dr3("EXCLUSAO").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "LOAD"

    Private Sub projPlanodeProjeto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tabObjetivos.Show()
        tabAC.Show()
        CarregaSaidas(idprojetos)
        CarregaAtividade(idprojetos)
        Carrega5W2H(idprojetos)
        CarregaRecursos(idprojetos)
        CarregaRisco(idprojetos)
        CarregaRevisao(idprojetos)
        CarregaControleAC(idprojetos)
        CarregaControleVerif(idprojetos)
        CarregaControleValid(idprojetos)
        CarregaDados(idprojetos)
        txtObjGeral.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtObjTexto.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtRequisitosEspecificados.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtRequisitosEstatutarios.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtRequisitosRegulamentares.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtOutrosRequisitos.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtInformacoes.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtRequisitosExclusao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

    Private Sub radioObjEstruturado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioObjEstruturado.SelectedIndexChanged
        If radioObjEstruturado.Checked = True Then

            'Novo 
            Dim frm As New projCadObjetivoEstruturado
            Dim id As Integer = 0

            'Passagem de parametros
            Try
                id = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                frm.idprojetos = id
                frm.NovoEstruturado()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

            tipo = 2

        End If
    End Sub

    Private Sub radioObjTexto_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioObjTexto.SelectedIndexChanged
        If radioObjTexto.Checked = True Then
            tipo = 1
        End If
    End Sub

    Private Sub tabEscopo_GotFocus(sender As Object, e As System.EventArgs) Handles tabEscopo.GotFocus
        CarregaEscopo(idprojetos)
    End Sub

    Private Sub radioAtividade_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioAtividade.SelectedIndexChanged
        If radioAtividade.Checked = True Then
            gridAtividade.Visible = True
            grid5W2H.Visible = False
        End If
    End Sub

    Private Sub radio5W2H_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radio5W2H.SelectedIndexChanged
        If radio5W2H.Checked = True Then
            grid5W2H.Visible = True
            gridAtividade.Visible = False
        End If
    End Sub

#End Region

#Region "NOVO PLANO"

    Public Sub NovoPlanoProjeto(ByVal id As Integer)
        'Cadastrar Novo Plano
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "SALVAR"

#Region "PLANO DE PROJETO"

#Region "OBJETIVOS"

    Private Sub botSalvarObjetivos_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarObjetivos.Click

        'Cadastra novo Objetivo
        Dim planoprojeto As New planoprojeto

        If isEdit Then
            Try
                'Editar Objetivos
                VerificarObjetivos()
                If planoprojeto.UpdateObjetivos(idobjetivostexto, _
                                        idprojetos,
                                        txtObjGeral.Text, _
                                        tipo, _
                                        txtObjTexto.Text) Then
                    MessageBox.Show("Dados de Objetivo atualizados com sucesso", "Plano de Projeto - Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        Else
            Try
                'Salvar Objetivos
                VerificarObjetivos()
                If planoprojeto.AddObjetivos(idprojetos,
                                             txtObjGeral.Text, _
                                             tipo, _
                                             txtObjTexto.Text) Then
                    MessageBox.Show("Objetivo salvo com sucesso", "Plano de Projeto - Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub VerificarObjetivos()

        'Obejtivo Geral
        If txtObjGeral.Text = "" Then
            MessageBox.Show("O campo Objetivo Geral não foi preenchido", "Plano de Projeto - Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtObjGeral.Focus()
            Exit Sub
        End If
        'Resultados esperados
        If radioObjTexto.Checked = True Then
            If txtObjTexto.Text = "" Then
                MessageBox.Show("O campo Resultados Texto não foi preenchido", "Plano de Projeto - Objetivos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtObjTexto.Focus()
                Exit Sub
            End If
        End If

    End Sub

#End Region

#Region "ESCOPO"

    Private Sub botSalvarEscopo_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarEscopo.Click

        'Cadastra novo Escopo
        Dim planoprojeto As New planoprojeto

        If isEdit Then
            Try
                'Editar Escopo
                VerificarEscopo()
                If planoprojeto.UpdateEscopo(idescopo, _
                                            idprojetos,
                                            txtRequisitosEspecificados.Text, _
                                            txtRequisitosEstatutarios.Text, _
                                            txtRequisitosRegulamentares.Text, _
                                            txtOutrosRequisitos.Text, _
                                            txtInformacoes.Text, _
                                            txtRequisitosExclusao.Text) Then
                    MessageBox.Show("Dados de Escopo atualizados com sucesso", "Plano de Projeto - Escopo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        Else
            Try
                'Salvar Escopo
                VerificarEscopo()
                If planoprojeto.AddEscopo(idprojetos,
                                          txtRequisitosEspecificados.Text, _
                                          txtRequisitosEstatutarios.Text, _
                                          txtRequisitosRegulamentares.Text, _
                                          txtOutrosRequisitos.Text, _
                                          txtInformacoes.Text, _
                                          txtRequisitosExclusao.Text) Then
                    MessageBox.Show("Escopo salvo com sucesso", "Plano de Projeto - Escopo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub VerificarEscopo()
        'Requisitos Especificados
        If txtRequisitosEspecificados.Text = "" Then
            MessageBox.Show("O campo Requisitos Especificados não foi preenchido", "Plano de Projeto - Escopo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRequisitosEspecificados.Focus()
            Exit Sub
        End If
        'Requisitos Estatutarios
        If txtRequisitosEstatutarios.Text = "" Then
            MessageBox.Show("O campo Requisitos Estatutários não foi preenchido", "Plano de Projeto - Escopo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRequisitosEstatutarios.Focus()
            Exit Sub
        End If
        'Requisitos Regulamentares
        If txtRequisitosRegulamentares.Text = "" Then
            MessageBox.Show("O campo Requisitos Regulamentares não foi preenchido", "Plano de Projeto - Escopo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRequisitosRegulamentares.Focus()
            Exit Sub
        End If
        'Outros requisitos essenciais para o projeto
        If txtOutrosRequisitos.Text = "" Then
            MessageBox.Show("O campo Outros requisitos essenciais para o proejto não foi preenchido", "Plano de Projeto - Escopo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtOutrosRequisitos.Focus()
            Exit Sub
        End If
        'Informações originadas de projetos anteriores
        If txtInformacoes.Text = "" Then
            MessageBox.Show("O campo Informações originadas de projetos anteriores não foi preenchido", "Plano de Projeto - Escopo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtInformacoes.Focus()
            Exit Sub
        End If
        'Requisitos Exclusão
        If txtRequisitosExclusao.Text = "" Then
            MessageBox.Show("O campo Requisitos de Exclusão não foi preenchido", "Plano de Projeto - Escopo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtInformacoes.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "SAÍDAS"

#Region "NOVO"

    Private Sub botIncluirSaidas_Click(sender As System.Object, e As System.EventArgs) Handles botIncluirSaidas.Click

        'Cadastra nova Saída
        Dim planoprojeto As New planoprojeto

        If isEditSaidas Then
            Try
                'Editar Saídas
                VerificarSaidas()
                If planoprojeto.UpdateSaidas(idsaidas, _
                                             idprojetos, _
                                             txtSaidaProj.Text) Then
                    CarregaSaidas(idprojetos)
                    txtSaidaProj.Text = ""
                    isEditSaidas = False
                    MessageBox.Show("Dados de Saída atualizados com sucesso", "Plano de Projeto - Saídas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        Else
            Try
                'Salvar Saídas
                VerificarSaidas()
                If planoprojeto.AddSaidas(idprojetos, _
                                          txtSaidaProj.Text) Then
                    CarregaSaidas(idprojetos)
                    txtSaidaProj.Text = ""
                    MessageBox.Show("Saída salvo com sucesso", "Plano de Projeto - Saídas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub VerificarSaidas()
        'Saídas
        If txtSaidaProj.Text = "" Then
            MessageBox.Show("O campo Saídas não foi preenchido", "Plano de Projeto - Saídas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSaidaProj.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditarSaidas_Click(sender As System.Object, e As System.EventArgs) Handles botEditarSaidas.Click

        Dim id As Integer = 0

        If gridSaidas.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Saídas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            isEditSaidas = True

            Try
                'Passagem de parametros
                id = gridSaidas(gridSaidas.RowSel, 1)
                Saidas = id

                'Seleciona Fornecedor pelo Id
                Dim sql As String = String.Format("SELECT * FROM PROJETOS_PLANO_SAIDAS WHERE ID_PROJETOS_PLANO_SAIDAS = {0}", id)

                'Popula os campos com os dados do Banco
                Try

                    Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

                    While dr.Read

                        Me.txtSaidaProj.Text = dr("SAIDAS").ToString

                    End While

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluirSaidas_Click(sender As System.Object, e As System.EventArgs) Handles botExcluirSaidas.Click

        Dim planoprojeto As New planoprojeto

        If gridSaidas.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Saídas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Excluir o Saidas
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Plano de Projeto - Saídas", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    planoprojeto.DeleteSaidas(gridSaidas(gridSaidas.RowSel, 1))
                    CarregaSaidas(idprojetos)
                    MessageBox.Show("Projeto excluído com sucesso", "Plano de Projeto - Saídas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#End Region

#Region "ESTÁGIOS"

#Region "NOVO"

    Private Sub botIncluirEstagios_Click(sender As System.Object, e As System.EventArgs) Handles botIncluirEstagios.Click

        If radioAtividade.Checked = True Then

            'Novo Projeto
            Dim frm As New projCadEstagiosAtividade
            Dim id As Integer = 0

            'Delegate para instancia do grid
            AddHandler frm.OnDataChange, AddressOf CarregaAtividade

            'Passagem de parametros
            Try
                id = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                frm.idprojetos = id
                frm.NovoEstagioAtiv()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        ElseIf radio5W2H.Checked = True Then

            'Novo Projeto
            Dim frm As New projCadEstagios5w2h
            Dim id As Integer = 0

            'Delegate para instancia do grid
            AddHandler frm.OnDataChange, AddressOf Carrega5W2H

            'Passagem de parametros
            Try
                id = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                frm.idprojetos = id
                frm.NovoEstagio5w2h()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If
        CarregaAtividade(idprojetos)
        Carrega5W2H(idprojetos)
    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditarEstagios_Click(sender As System.Object, e As System.EventArgs) Handles botEditarEstagios.Click

        If radioAtividade.Checked = True Then

            Dim frm As New projCadEstagiosAtividade
            Dim id As Integer = 0
            Dim idProjeto As Integer = 0

            If gridAtividade.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Estágio - Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Delegate para instancia do grid
                AddHandler frm.OnDataChange, AddressOf CarregaAtividade

                'Passagem de parametros
                Try

                    idProjeto = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                    frm.idprojetos = idProjeto
                    id = gridAtividade(gridAtividade.RowSel, 1)
                    frm.EstagiosAtiv = id
                    frm.EditarEstagioAtiv(id)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            End If

        ElseIf radio5W2H.Checked = True Then

            Dim frm As New projCadEstagios5w2h
            Dim id As Integer = 0
            Dim idProjeto As Integer = 0

            If gridAtividade.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Estágio - Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Delegate para instancia do grid
                AddHandler frm.OnDataChange, AddressOf Carrega5W2H

                'Passagem de parametros
                Try

                    idProjeto = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                    frm.idprojetos = idProjeto
                    id = grid5W2H(grid5W2H.RowSel, 1)
                    frm.Estagios5w2h = id
                    frm.EditarEstagio5w2h(id)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            End If
            End If

            CarregaAtividade(idprojetos)

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluirEstagios_Click(sender As System.Object, e As System.EventArgs) Handles botExcluirEstagios.Click

        If radioAtividade.Checked = True Then

            Dim planoprojeto As New planoprojeto

            If gridAtividade.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Estágio - Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Excluir o Estágio
                Try
                    If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Plano de Projeto - Estágio - Atividade", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        planoprojeto.DeleteEstagiosAtiv(gridAtividade(gridAtividade.RowSel, 1))
                        CarregaAtividade(idprojetos)
                        MessageBox.Show("Projeto excluído com sucesso", "Plano de Projeto - Estágio - Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            End If
        ElseIf radio5W2H.Checked = True Then

            Dim planoprojeto As New planoprojeto

            If gridAtividade.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Estágio - Atividade", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Excluir o Estágio
                Try
                    If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Plano de Projeto - Estágio - 5W2H", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        planoprojeto.DeleteEstagios5W2H(grid5W2H(grid5W2H.RowSel, 1))
                        Carrega5W2H(idprojetos)
                        MessageBox.Show("Projeto excluído com sucesso", "Plano de Projeto - Estágio - 5W2H", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            End If
            End If


    End Sub

#End Region

#End Region

#Region "RECURSOS"

#Region "NOVO"

    Private Sub botIncluirRecursos_Click(sender As System.Object, e As System.EventArgs) Handles botIncluirRecursos.Click

        'Novo Projeto
        Dim frm As New projCadRecursos
        Dim id As Integer = 0

        'Delegate para instancia do grid
        AddHandler frm.OnDataChange, AddressOf CarregaRecursos

        'Passagem de parametros
        Try
            id = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
            frm.idprojetos = id
            frm.NovoRecursos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        CarregaRecursos(idprojetos)

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditarRecursos_Click(sender As System.Object, e As System.EventArgs) Handles botEditarRecursos.Click

        Dim frm As New projCadRecursos
        Dim id As Integer = 0
        Dim idProjeto As Integer = 0

        If gridRecursos.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Recursos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Delegate para instancia do grid
            AddHandler frm.OnDataChange, AddressOf CarregaRecursos

            'Passagem de parametros
            Try

                idProjeto = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                frm.idprojetos = idProjeto
                id = gridRecursos(gridRecursos.RowSel, 1)
                frm.Recursos = id
                frm.EditarRecursos(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

            CarregaRecursos(idprojetos)
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluirRecursos_Click(sender As System.Object, e As System.EventArgs) Handles botExcluirRecursos.Click

        Dim planoprojeto As New planoprojeto

        If gridRecursos.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Recursos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Excluir o Recurso
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Plano de Projeto - Recursos", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    planoprojeto.DeleteRecursos(gridRecursos(gridRecursos.RowSel, 1))
                    CarregaRecursos(idprojetos)
                    MessageBox.Show("Projeto excluído com sucesso", "Plano de Projeto - Recursos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#End Region

#Region "CONTROLE"

#Region "ANÁLISE CRÍTICA"

#Region "NOVO"

    Private Sub botIncluirAnaliseCritica_Click(sender As System.Object, e As System.EventArgs) Handles botIncluirAnaliseCritica.Click

        If tabAC.Focus = True Then

            'Novo Projeto
            Dim frm As New projCadControleAC
            Dim id As Integer = 0

            'Delegate para instancia do grid
            AddHandler frm.OnDataChange, AddressOf CarregaControleAC

            'Passagem de parametros
            Try
                id = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                frm.idprojetos = id
                frm.NovoControle()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

            CarregaControleAC(idprojetos)

        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditarAnaliseCritica_Click(sender As System.Object, e As System.EventArgs) Handles botEditarAnaliseCritica.Click

        If tabAC.Focus = True Then

            Dim frm As New projCadControleAC
            Dim id As Integer = 0
            Dim idProjeto As Integer = 0

            If gridAnaliseCritica.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Controle - Análise Crítica", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Delegate para instancia do grid
                AddHandler frm.OnDataChange, AddressOf CarregaControleAC

                'Passagem de parametros
                Try

                    idProjeto = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                    frm.idprojetos = idProjeto
                    id = gridAnaliseCritica(gridAnaliseCritica.RowSel, 1)
                    frm.ControleAC = id
                    frm.EditarControle(id)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            End If

            CarregaControleAC(idprojetos)
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluirAnaliseCritica_Click(sender As System.Object, e As System.EventArgs) Handles botExcluirAnaliseCritica.Click

        If tabAC.Focus = True Then

            Dim planoprojeto As New planoprojeto

            If gridAnaliseCritica.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Controle - Análise Crítica", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Excluir o Controle/Analise Critica
                Try
                    If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Plano de Projeto - Controle - Análise Crítica", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        planoprojeto.DeleteControleAC(gridAnaliseCritica(gridAnaliseCritica.RowSel, 1))
                        CarregaControleAC(idprojetos)
                        MessageBox.Show("Projeto excluído com sucesso", "Plano de Projeto - Controle - Análise Crítica", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            End If
        End If

    End Sub

#End Region

#End Region

#Region "VERIFICAÇÃO"

#Region "NOVO"

    Private Sub botIncluirVerif_Click(sender As System.Object, e As System.EventArgs) Handles botIncluirVerif.Click

        If tabVerif.Focus = True Then

            'Novo Projeto
            Dim frm As New projCadControleVerificacao
            Dim id As Integer = 0

            'Delegate para instancia do grid
            AddHandler frm.OnDataChange, AddressOf CarregaControleVerif

            'Passagem de parametros
            Try
                id = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                frm.idprojetos = id
                frm.NovoControleVerif()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

            CarregaControleVerif(idprojetos)

        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditarVerif_Click(sender As System.Object, e As System.EventArgs) Handles botEditarVerif.Click

        If tabVerif.Focus = True Then

            Dim frm As New projCadControleVerificacao
            Dim id As Integer = 0
            Dim idProjeto As Integer = 0

            If gridVerif.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Controle - Verificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Delegate para instancia do grid
                AddHandler frm.OnDataChange, AddressOf CarregaControleVerif

                'Passagem de parametros
                Try

                    idProjeto = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                    frm.idprojetos = idProjeto
                    id = gridVerif(gridVerif.RowSel, 1)
                    frm.ControleVerif = id
                    frm.EditarControleVerif(id)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            End If

            CarregaControleVerif(idprojetos)
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluirVerif_Click(sender As System.Object, e As System.EventArgs) Handles botExcluirVerif.Click

        If tabVerif.Focus = True Then

            Dim planoprojeto As New planoprojeto

            If gridVerif.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Controle - Verificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Excluir o Controle/Verificação
                Try
                    If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Plano de Projeto - Controle - Verificação", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        planoprojeto.DeleteControleVerif(gridVerif(gridVerif.RowSel, 1))
                        CarregaControleVerif(idprojetos)
                        MessageBox.Show("Projeto excluído com sucesso", "Plano de Projeto - Controle - Verificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            End If
        End If

    End Sub

#End Region

#End Region

#Region "VALIDAÇÃO"

#Region "NOVO"

    Private Sub botIncluirValidacao_Click(sender As System.Object, e As System.EventArgs) Handles botIncluirValidacao.Click

        If tabValidacao.Focus = True Then

            'Novo Projeto
            Dim frm As New projCadControleValidacao
            Dim id As Integer = 0

            'Delegate para instancia do grid
            AddHandler frm.OnDataChange, AddressOf CarregaControleValid

            'Passagem de parametros
            Try
                id = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                frm.idprojetos = id
                frm.NovoControleValid()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

            CarregaControleValid(idprojetos)

        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditarValidacao_Click(sender As System.Object, e As System.EventArgs) Handles botEditarValidacao.Click

        If tabValidacao.Focus = True Then

            Dim frm As New projCadControleValidacao
            Dim id As Integer = 0
            Dim idProjeto As Integer = 0

            If gridValidacao.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Controle - Validação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Delegate para instancia do grid
                AddHandler frm.OnDataChange, AddressOf CarregaControleValid

                'Passagem de parametros
                Try

                    idProjeto = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                    frm.idprojetos = idProjeto
                    id = gridValidacao(gridValidacao.RowSel, 1)
                    frm.ControleValid = id
                    frm.EditarControleValid(id)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            End If

            CarregaControleValid(idprojetos)
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluirValidacao_Click(sender As System.Object, e As System.EventArgs) Handles botExcluirValidacao.Click

        If tabValidacao.Focus = True Then

            Dim planoprojeto As New planoprojeto

            If gridValidacao.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Controle - Validação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Excluir o Controle/Validação
                Try
                    If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Plano de Projeto - Controle - Validação", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        planoprojeto.DeleteControleValid(gridValidacao(gridValidacao.RowSel, 1))
                        CarregaControleValid(idprojetos)
                        MessageBox.Show("Projeto excluído com sucesso", "Plano de Projeto - Controle - Validação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            End If
        End If

    End Sub

#End Region

#End Region

#End Region

#Region "RISCO"

#Region "NOVO"

    Private Sub botIncluirRisco_Click(sender As System.Object, e As System.EventArgs) Handles botIncluirRisco.Click

        'Novo Projeto
        Dim frm As New projCadRisco
        Dim id As Integer = 0

        'Delegate para instancia do grid
        AddHandler frm.OnDataChange, AddressOf CarregaRisco

        'Passagem de parametros
        Try
            id = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
            frm.idprojetos = id
            frm.NovoRisco()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        CarregaRisco(idprojetos)

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditarRisco_Click(sender As System.Object, e As System.EventArgs) Handles botEditarRisco.Click

        Dim frm As New projCadRisco
        Dim id As Integer = 0
        Dim idProjeto As Integer = 0

        If gridRisco.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Risco", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Delegate para instancia do grid
            AddHandler frm.OnDataChange, AddressOf CarregaRisco

            'Passagem de parametros
            Try

                idProjeto = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                frm.idprojetos = idProjeto
                id = gridRisco(gridRisco.RowSel, 1)
                frm.Risco = id
                frm.EditarRisco(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

            CarregaRisco(idprojetos)
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluirRisco_Click(sender As System.Object, e As System.EventArgs) Handles botExcluirRisco.Click

        Dim planoprojeto As New planoprojeto

        If gridRisco.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Risco", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Excluir o Risco
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Plano de Projeto - Risco", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    planoprojeto.DeleteRisco(gridRisco(gridRisco.RowSel, 1))
                    CarregaRisco(idprojetos)
                    MessageBox.Show("Projeto excluído com sucesso", "Plano de Projeto - Risco", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#End Region

#Region "REVISAO"

#Region "NOVO"

    Private Sub botIncluirRevisao_Click(sender As System.Object, e As System.EventArgs) Handles botIncluirRevisao.Click

        'Novo Projeto
        Dim frm As New projCadRevisoes
        Dim id As Integer = 0

        'Delegate para instancia do grid
        AddHandler frm.OnDataChange, AddressOf CarregaRevisao

        'Passagem de parametros
        Try
            id = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
            frm.idprojetos = id
            frm.NovaRevisao()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        CarregaRevisao(idprojetos)

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditarRevisao_Click(sender As System.Object, e As System.EventArgs) Handles botEditarRevisao.Click

        Dim frm As New projCadRevisoes
        Dim id As Integer = 0
        Dim idProjeto As Integer = 0

        If gridRevisao.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Revisão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Delegate para instancia do grid
            AddHandler frm.OnDataChange, AddressOf CarregaRevisao

            'Passagem de parametros
            Try

                idProjeto = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                frm.idprojetos = idProjeto
                id = gridRevisao(gridRevisao.RowSel, 1)
                frm.Revisao = id
                frm.EditarRevisao(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

            CarregaRevisao(idprojetos)
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluirRevisao_Click(sender As System.Object, e As System.EventArgs) Handles botExcluirRevisao.Click

        Dim planoprojeto As New planoprojeto

        If gridRevisao.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Plano de Projeto - Revisão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Excluir o Revisão
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Plano de Projeto - Revisão", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    planoprojeto.DeleteRevisoes(gridRevisao(gridRevisao.RowSel, 1))
                    CarregaRevisao(idprojetos)
                    MessageBox.Show("Projeto excluído com sucesso", "Plano de Projeto - Revisão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#End Region

#End Region

#End Region

End Class
