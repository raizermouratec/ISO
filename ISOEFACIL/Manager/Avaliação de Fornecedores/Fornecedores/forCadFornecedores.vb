Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ISOEFACIL.forListaOcorrencias
Imports ISOEFACIL.forCadOcorrencias
Imports ISOEFACIL.GeralCadContato
Imports System.IO

Public Class forCadFornecedores

#Region "VARIAVEIS"

    'Variaveis usadas para edição de dados
    Private isEdit As Boolean = False
    Private isEditProServ As Boolean = False
    Public idfornecedor As Integer = 0
    Public idContatos As Integer
    Public idContatosEdit As String
    Public verif As Boolean = False
    Private ANEXO() As Byte
    Public Edit_Contatos As Boolean




    'Pega Id Ocorrencias
    Public WriteOnly Property ID_Fornecedor() As String
        Set(ByVal value As String)
            Me.idfornecedor = value
        End Set
    End Property



    'Public WriteOnly Property Contatos() As String
    '    Set(ByVal value As String)
    '        Me.idContatosEdit = value
    '    End Set
    'End Property

#End Region

#Region "POPULA COMBOS"

#Region "ESTADOS"
    Sub CarregaComboES()
        With cmbEstado
            .DataSource = Manager.Util.getDataTable("SELECT * FROM ESTADOS")
            .DisplayMember = "NOME"
            .ValueMember = "ID_ESTADOS"
        End With
    End Sub
#End Region

#Region "CIDADES"
    Sub CarregaComboCidades()
        With cmbCidade
            .DataSource = Manager.Util.getDataTable("SELECT * FROM CIDADES")
            .DisplayMember = "CIDADE"
            .ValueMember = "ID_CIDADES"
        End With
    End Sub
#End Region

#Region "CHAMA CIDADES POR ESTADO SELECIONADO"

    Private Sub cmbEstado_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstado.LostFocus
        ChamaCidadesById()
    End Sub

    Public Sub ChamaCidadesById() '(ByVal id As Integer)
        Try
            With cmbCidade
                .DataSource = Manager.Util.getDataTable("SELECT * FROM CIDADES WHERE ID_ESTADOS =" & cmbEstado.SelectedValue)
                .DisplayMember = "CIDADE"
                .ValueMember = "ID_CIDADES"
            End With
        Catch ex As Exception

        End Try

    End Sub


#End Region

#End Region

#Region "CARREGAR LISTAS"

#Region "PROD_SERV"

    Public Sub carregaProdServById(ByVal id As String)

        'Monta grid Prod/Serv passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_FORNECEDORES_PROD_SERV WHERE FORNECEDOR = {0}", id)
        Dim dt As New DataTable

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridProdutos.AutoGenerateColumns = False

        'Cria a tabela
        gridProdutos.DataSource = dt

    End Sub

#End Region

#Region "CONTATOS"

    Public Sub CarregaContatos()

        'Monta Lista de Estagios/Atividade do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_FORNECEDORES_CONTATOS WHERE FORNECEDOR = {0} AND MODULO = 'FORNECEDOR'", idfornecedor)
        Dim dt As New DataTable

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridContatos.AutoGenerateColumns = False

        'Cria a tabela
        gridContatos.DataSource = dt

    End Sub

#End Region

#Region "AVALIAÇÕES"

#End Region

#Region "OCORRENCIAS"

    Public Sub CarregaOcorrencias(ByVal id As String)

        'Monta grid Ocorrencias passando Id
        Dim sqlId As String = String.Format("SELECT TOP (50) CODIGO, FORNECEDOR, DATA, DESCRICAO, RESPONSAVEL FROM VW_LISTAGEM_FORNECEDORES_OCORRENCIAS WHERE ID_FORNECEDOR = {0}", id)
        Dim dt As New DataTable

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Tratamento de Erros
        'For Each dr As DataRow In dt.Rows
        '    ' coluna especifica
        '    If dr("CRITICO") = True Then
        '        dr.SetColumnError("CRITICO", "Esse é um produto Critico" & vbCr & vbLf & "Favor proceder.")
        '    End If

        'Next

        'Não gera colunas automaticas
        gridOcorrencias.AutoGenerateColumns = False
        'Cria a tabela
        gridOcorrencias.DataSource = dt

        'Mostra os erros
        'gridProdutos.ShowErrors = True

    End Sub

#End Region

#Region "ANEXOS"



#End Region

#End Region

#Region "LOAD"
    Private Sub forCadFornecedores_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        forListaFornecedores.idVerifivcar_open = False
    End Sub

    Private Sub forCadastro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CarregaComboES()
        CarregaComboCidades()

        'ToolTip Balão de info.
        Dim buttonToolTip As New ToolTip()
        buttonToolTip.ToolTipIcon = ToolTipIcon.Info
        buttonToolTip.ToolTipTitle = "Replicar"
        buttonToolTip.UseFading = True
        buttonToolTip.UseAnimation = True
        buttonToolTip.ShowAlways = True
        buttonToolTip.IsBalloon = False
        buttonToolTip.AutoPopDelay = 5000
        buttonToolTip.InitialDelay = 1000
        buttonToolTip.ReshowDelay = 500
        buttonToolTip.SetToolTip(btReplicar, "Clique para Replicar a Razão Social")

        'Controles ToolTip Critico
        TooltipCritico.AutomaticDelay = 0
        TooltipCritico.AutoPopDelay = Integer.MaxValue
        TooltipCritico.IsBalloon = True

        'Tras visivel o tipo de cadastro selecionado
        If RadioPF.Checked = True Then
            PainelPF.Visible = True
            PainelPJ.Visible = False
            btReplicar.Visible = False
        End If
        If RadioPJ.Checked = True Then
            PainelPF.Visible = False
            PainelPJ.Visible = True
            btReplicar.Visible = True
        End If

        'Seleciona a Tab 0 (Identificação) como padrão
        C1DockingTab1.SelectedIndex = 0

        'Cor texto 
        RadioPF.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        RadioPJ.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")

    End Sub

#Region "ATALHO: VISUALIZAR CRITÉRIOS"

    Private Sub botCriterio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCriterio.Click
        forCadCriterios.Show()
    End Sub

#End Region

#Region "CHAMA FORMS"

    Private Sub C1Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim geralCadContato As New GeralCadContato
        geralCadContato.fornecedor = idfornecedor
        'Carrega Form
        geralCadContato.Show(Me)
    End Sub

    Private Sub botIncluirAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Carrega Form
        GeralCadAnexo.Show(Me)
    End Sub

    Private Sub botIncluirOcorrencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim forCadastroOcorrencia As New forCadOcorrencias
        forCadastroOcorrencia.fornecedor = idfornecedor
        'Carrega Form
        forCadastroOcorrencia.Show(Me)

    End Sub

    Private Sub botIncluirAvaliacoes_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Carrega Form
        forCadAvaliacao.Show(Me)
    End Sub

#End Region

#Region "CONTROLE DE ERRO"

    Private Function BuildErrorTip(ByVal c As C1.Win.C1InputPanel.InputComponent, ByVal err As String) As String
        Return String.Format( _
            "{0}<table>" + _
            "<tr style='vertical-align:top;'>" + _
            "<td><img src='res://errorinfo'/>" + _
            "<td>{1}</table>", _
            c.ToolTipText, _
            err)
    End Function

    Private Sub txtNome_LostFocus(sender As Object, e As EventArgs) Handles txtNome.LostFocus
        If txtNome.Text.Length <= 0 Then
            txtNome.ErrorText = BuildErrorTip(txtNome, "Campo Obrigatório")
        Else
            txtNome.ErrorText = String.Empty
        End If
    End Sub

    Private Sub txtCPF_LostFocus(sender As Object, e As EventArgs) Handles txtCPF.LostFocus
        If txtCPF.Text = "   .   .   -" Then
            txtCPF.ErrorText = BuildErrorTip(txtCPF, "Campo Obrigatório")
        Else
            txtCPF.ErrorText = String.Empty
        End If
    End Sub


    Private Sub txtRG_LostFocus(sender As Object, e As EventArgs) Handles txtRG.LostFocus
        If txtRG.Text.Length <= 0 Then
            txtRG.ErrorText = BuildErrorTip(txtRG, "Campo Obrigatório")
        Else
            txtRG.ErrorText = String.Empty
        End If
    End Sub

    Private Sub txtRS_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtRS.LostFocus
        If txtRS.Text.Length <= 0 Then
            txtRS.ErrorText = BuildErrorTip(txtRS, "Campo Obrigatório")
        Else
            txtRS.ErrorText = String.Empty
        End If
    End Sub

    Private Sub txtCNPJ_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtCNPJ.LostFocus
        If txtCNPJ.Text = "   .   .   -" Then
            txtCNPJ.ErrorText = BuildErrorTip(txtCNPJ, "Campo Obrigatório")
        Else
            txtCNPJ.ErrorText = String.Empty
        End If
    End Sub


#End Region

#Region "TRATAMENTOS"

    Private Sub RadioPF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioPF.CheckedChanged
        'Mostra ou esconde painel de cadastro
        If RadioPF.Checked = True Then
            PainelPF.Visible = True
            PainelPJ.Visible = False
            btReplicar.Visible = False
        End If
    End Sub

    Private Sub RadioPJ_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioPJ.CheckedChanged
        'Mostra ou esconde painel de cadastro
        If RadioPJ.Checked = True Then
            PainelPF.Visible = False
            PainelPJ.Visible = True
            btReplicar.Visible = True
        End If
    End Sub

    Private Sub btReplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReplicar.Click
        'Repicar Razao Social
        If txtRS.Text <> vbNullString Then
            txtNF.Text = txtRS.Text
        End If
    End Sub

#End Region

#Region "HTML Tooltip"
    ' html template for super tooltipCritico
    Dim _tip As String = _
        "<table><tr>" + _
          "<td><parm><img src='res://Target.png'></parm>" + _
          "<td><b><parm>Item Crítico</parm></b>" + _
        "</table>" + _
        "<parm><hr noshade size=1 style='margin:2' color=Darker></parm>" + _
        "<div style='margin:1 12'><parm>" + _
        "This tooltip is associated with cell (row,col).<br>" + _
        "You can show it as a balloon or as a regular<br>" + _
        "tooltip." + _
        "</parm></div>" + _
        "<parm><hr noshade size=1 style='margin:2' color=Darker></parm>" + _
        "<table><tr>" + _
          "<td><parm></parm>" + _
          "<td><b><parm>Regularize seus Produtos!</parm></b>" + _
        "</table>"
#End Region

#End Region

#Region "ABAS"

#Region "FORNECEDOR"

#Region "NOVO"

    Public Sub NovoFornecedores()
        'Cadastrar Novo
        isEdit = False
        forListaFornecedores.idVerifivcar_open = True
        Me.Show()

    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click
        'Seta a Classe
        Dim forncederor As New Fornecedores
        'Inicio Atualizar/Salvar
        If isEdit = True Then
            'Checndo se campos obrigatórios estão OK
            If RadioPJ.Checked = True Then
                'Tratamento de erro Razão Social
                If txtRS.Text = "" Then
                    MessageBox.Show("Campo Razão Social Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtRS.Focus()
                    'Tratamento de erro CNPJ
                ElseIf txtCNPJ.Text = "  .   .   /    -" Then
                    MessageBox.Show("Campo CNPJ Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCNPJ.Focus()
                    'Tratamento de erro Inscrição Estadual
                ElseIf txtIE.Text = "" Then
                    MessageBox.Show("Campo Inscrição Estadual Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIE.Focus()

                    'Trataento de erro Inscrição Municipal
                ElseIf txtIM.Text = "" Then
                    MessageBox.Show("Campo Inscrição Municipal Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIM.Focus()
                Else
                    Try
                        If forncederor.Update(idfornecedor, _
                                  "", _
                                  "", _
                                  "", _
                                  "", _
                                  txtRS.Text, _
                                  txtNF.Text, _
                                  txtCNPJ.Text, _
                                  txtIM.Text, _
                                  txtIE.Text, _
                                  txtEndereco.Text, _
                                  txtComplemento.Text, _
                                  txtBairro.Text, _
                                  cmbEstado.SelectedValue, _
                                  cmbCidade.SelectedValue, _
                                  txtCEP.Text, _
                                  txtFixo.Text, _
                                  txtFax.Text, _
                                  txtCelular.Text, _
                                  txtEmail.Text, _
                                  txtSite.Text, _
                                  txtSkype.Text) Then
                            MessageBox.Show("Dados do fornecedor atualizados com sucesso", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                            forListaFornecedores.carregaFornecedor()
                            Me.Close()
                            forListaFornecedores.idVerifivcar_open = False
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    End Try
                End If


            Else
                If txtNome.Text = "" Then
                    MessageBox.Show("Campo Nome Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNome.Focus()
                    'Tratamento de erro CPF
                ElseIf txtCPF.Text = "   .   .   -" Then
                    MessageBox.Show("Campo CPF Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCPF.Focus()
                    'Tratamento de erro RG
                ElseIf txtRG.Text = "" Then
                    MessageBox.Show("Campo RG Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtRG.Focus()
                Else
                    Try
                        If forncederor.Update(idfornecedor, _
                                     txtNome.Text, _
                                     txtCPF.Text, _
                                     txtRG.Text, _
                                     txtProfissao.Text, _
                                     "", _
                                     "", _
                                     "", _
                                     "", _
                                     "", _
                                     txtEndereco.Text, _
                                     txtComplemento.Text, _
                                     txtBairro.Text, _
                                     cmbEstado.SelectedValue, _
                                     cmbCidade.SelectedValue, _
                                     txtCEP.Text, _
                                     txtFixo.Text, _
                                     txtFax.Text, _
                                     txtCelular.Text, _
                                     txtEmail.Text, _
                                     txtSite.Text, _
                                     txtSkype.Text) Then
                            MessageBox.Show("Dados do fornecedor atualizados com sucesso", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                            forListaFornecedores.carregaFornecedor()
                            forListaFornecedores.idVerifivcar_open = False
                            Me.Close()

                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    End Try
                End If
            End If

        Else ' salva novo

            'Verificar campos obrigatórios
            'Checando se campos obrigatórios estão OK

            If RadioPJ.Checked = True Then
                'Tratamento de erro Razão Social
                If txtRS.Text = "" Then
                    MessageBox.Show("Campo Razão Social Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtRS.Focus()
                    'Tratamento de erro CNPJ
                ElseIf txtCNPJ.Text = "" Then
                    MessageBox.Show("Campo CNPJ Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCNPJ.Focus()
                    'Tratamento de erro Inscrição Estadual
                ElseIf txtIE.Text = "" Then
                    MessageBox.Show("Campo Inscrição Estadual Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIE.Focus()
                    'Trataento de erro Inscrição Municipal
                ElseIf txtIM.Text = "" Then
                    MessageBox.Show("Campo Inscrição Municipal Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIM.Focus()
                Else
                    Try
                        idfornecedor = forncederor.Add("", _
                                  "", _
                                  "", _
                                  "", _
                                  txtRS.Text, _
                                  txtNF.Text, _
                                  txtCNPJ.Text, _
                                  txtIM.Text, _
                                  txtIE.Text, _
                                  txtEndereco.Text, _
                                  txtComplemento.Text, _
                                  txtBairro.Text, _
                                  cmbEstado.SelectedValue, _
                                  cmbCidade.SelectedValue, _
                                  txtCEP.Text, _
                                  txtFixo.Text, _
                                  txtFax.Text, _
                                  txtCelular.Text, _
                                  txtEmail.Text, _
                                  txtSite.Text, _
                                  txtSkype.Text)
                        MessageBox.Show("fornecedor Cadastrado com sucesso", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        forListaFornecedores.carregaFornecedor()
                        Fornecedor_NOVO(idfornecedor)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    End Try
                End If
            Else
                If txtNome.Text = "" Then
                    MessageBox.Show("Campo Nome Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNome.Focus()
                    'Tratamento de erro CPF
                ElseIf txtCPF.Text = "" Then
                    MessageBox.Show("Campo CPF Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCPF.Focus()
                    'Tratamento de erro RG
                ElseIf txtRG.Text = "" Then
                    MessageBox.Show("Campo RG Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtRG.Focus()
                Else
                    Try
                        idfornecedor = forncederor.Add(txtNome.Text, _
                                       txtCPF.Text, _
                                       txtRG.Text, _
                                       txtProfissao.Text, _
                                       "", _
                                       "", _
                                       "", _
                                       "", _
                                       "", _
                                       txtEndereco.Text, _
                                       txtComplemento.Text, _
                                       txtBairro.Text, _
                                       cmbEstado.SelectedValue, _
                                       cmbCidade.SelectedValue, _
                                       txtCEP.Text, _
                                       txtFixo.Text, _
                                       txtFax.Text, _
                                       txtCelular.Text, _
                                       txtEmail.Text, _
                                       txtSite.Text, _
                                       txtSkype.Text)


                        MessageBox.Show("fornecedor Cadastrado com sucesso", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        forListaFornecedores.carregaFornecedor()
                        Fornecedor_NOVO(idfornecedor)

                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If
    End Sub

#Region "VERIFICAR CAMPOS"

    Sub VerificarFor()

        'Tratamento de erro Nome
        If RadioPF.Checked = True Then
            If txtNome.Text = "" Then
                MessageBox.Show("Campo Nome Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNome.Focus()
                verif = True
                Exit Sub
            End If
            'Tratamento de erro CPF
            If txtCPF.Text = "" Then
                MessageBox.Show("Campo CPF Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCPF.Focus()
                verif = True
                Exit Sub
            End If
            'Tratamento de erro RG
            If txtRG.Text = "" Then
                MessageBox.Show("Campo RG Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtRG.Focus()
                verif = True
                Exit Sub
            End If
        Else
            'Tratamento de erro Razão Social
            If txtRS.Text = "" Then
                MessageBox.Show("Campo Razão Social Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtRS.Focus()
                verif = True
                Exit Sub
            End If
            'Tratamento de erro CNPJ
            If txtCNPJ.Text = "" Then
                MessageBox.Show("Campo CNPJ Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCNPJ.Focus()
                verif = True
                Exit Sub
            End If
            'Tratamento de erro Inscrição Estadual
            If txtIE.Text = "" Then
                MessageBox.Show("Campo Inscrição Estadual Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtIE.Focus()
                verif = True
                Exit Sub
            End If
            'Tratamento de erro Inscrição Municipal
            If txtIM.Text = "" Then
                MessageBox.Show("Campo Inscrição Municipal Obrigatório", "Clientes", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtIM.Focus()
                verif = True
                Exit Sub
            End If
        End If

        verif = False
    End Sub

#End Region

#End Region

#Region "EDITAR"

    Public Sub EditarFornecedor(ByVal id As Integer)
        idfornecedor = id
        TabProdutos.Enabled = True
        TabContatos.Enabled = True
        tabAvaliacoes.Enabled = True
        TabOcorrencias.Enabled = True
        tabAnexos.Enabled = True

        Dim es As Integer = 0

        'Editar
        isEdit = True

        'Carrega o Form com esse methodo
        Me.Show()
        forListaFornecedores.idVerifivcar_open = True
        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM FORNECEDORES WHERE ID_FORNECEDOR = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(Sql)

            While dr.Read

                Me.txtNome.Text = dr("NOME").ToString
                Me.txtCPF.Text = dr("CPF").ToString
                Me.txtRG.Text = dr("RG").ToString
                Me.txtProfissao.Text = dr("PROFISSAO").ToString
                Me.txtRS.Text = dr("RAZAO_SOCIAL").ToString
                Me.txtNF.Text = dr("NOME_FANTASIA").ToString
                Me.txtCNPJ.Text = dr("CNPJ").ToString
                Me.txtIE.Text = dr("INSCRICAO_ESTAD").ToString
                Me.txtIM.Text = dr("INSCRICAO_MUNIC").ToString
                Me.txtEndereco.Text = dr("ENDERECO").ToString
                Me.txtComplemento.Text = dr("COMPLEMENTO").ToString
                Me.txtBairro.Text = dr("BAIRRO").ToString
                Me.cmbEstado.SelectedValue = dr("ESTADO").ToString
                Me.cmbCidade.SelectedValue = dr("CIDADE").ToString
                Me.txtCEP.Text = dr("CEP").ToString
                Me.txtFixo.Text = dr("TELEFONE_01").ToString
                Me.txtCelular.Text = dr("TELEFONE_02").ToString
                Me.txtFax.Text = dr("TELEFONE_03").ToString
                Me.txtEmail.Text = dr("EMAIL").ToString
                Me.txtSite.Text = dr("WEBSITE").ToString
                Me.txtSkype.Text = dr("SKYPE").ToString

            End While

            'Seleciona o option de PJ/PF
            If txtNome.Text.Length <= 0 Then
                RadioPJ.Select()
            Else
                RadioPF.Select()
            End If
            Carregar_Avaliações(id)
            carregaProdServById(id)
            CarregaContatos()
            CarregaOcorrencias(id)
            ' carregaListaAnexos(id)
            'Dim resultado As String
            'With dr.Read
            '    resultado = dr("Resultado").ToString
            'End With

        Catch ex As Exception

        End Try


    End Sub

    Public Sub Fornecedor_NOVO(ByVal id As Integer)
        idfornecedor = id
        TabProdutos.Enabled = True
        TabContatos.Enabled = True
        tabAvaliacoes.Enabled = True
        TabOcorrencias.Enabled = True
        tabAnexos.Enabled = True

        Dim es As Integer = 0

        'Editar
        isEdit = True

        'Carrega o Form com esse methodo
        forListaFornecedores.idVerifivcar_open = True
        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM FORNECEDORES WHERE ID_FORNECEDOR = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtNome.Text = dr("NOME").ToString
                Me.txtCPF.Text = dr("CPF").ToString
                Me.txtRG.Text = dr("RG").ToString
                Me.txtProfissao.Text = dr("PROFISSAO").ToString
                Me.txtRS.Text = dr("RAZAO_SOCIAL").ToString
                Me.txtNF.Text = dr("NOME_FANTASIA").ToString
                Me.txtCNPJ.Text = dr("CNPJ").ToString
                Me.txtIE.Text = dr("INSCRICAO_ESTAD").ToString
                Me.txtIM.Text = dr("INSCRICAO_MUNIC").ToString
                Me.txtEndereco.Text = dr("ENDERECO").ToString
                Me.txtComplemento.Text = dr("COMPLEMENTO").ToString
                Me.txtBairro.Text = dr("BAIRRO").ToString
                Me.cmbEstado.Text = dr("ESTADO").ToString
                Me.cmbCidade.Text = dr("CIDADE").ToString
                Me.txtCEP.Text = dr("CEP").ToString
                Me.txtFixo.Text = dr("TELEFONE_01").ToString
                Me.txtCelular.Text = dr("TELEFONE_02").ToString
                Me.txtFax.Text = dr("TELEFONE_03").ToString
                Me.txtEmail.Text = dr("EMAIL").ToString
                Me.txtSite.Text = dr("WEBSITE").ToString
                Me.txtSkype.Text = dr("SKYPE").ToString

            End While

            'Seleciona o option de PJ/PF
            If txtNome.Text.Length <= 0 Then
                RadioPJ.Select()
            Else
                RadioPF.Select()
            End If

            carregaProdServById(id)
            CarregaContatos()
            CarregaOcorrencias(id)



        Catch ex As Exception

        End Try


    End Sub
#End Region

#End Region

#Region "PROD/SERV"

#Region "INCLUIR"

    Private Sub botIncluirCritico_Click(sender As Object, e As EventArgs) Handles botIncluirCritico.Click

        'Seta a Classe
        Dim produtosServicos As New produtosServicos
        Dim idProdServ As Integer = 0
        'Inicio Atualizar/Salvar
        If isEditProServ Then

            'Verificar campos obrigatórios

            'Checando se campos obrigatórios estão OK
            If txtProduto.Text = "" Then
                MessageBox.Show("Campo Produto Obrigatório", "Fornecedores - Produtos e Serviços", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtProduto.Focus()
            Else
                Try
                    'Atualizar
                    If produtosServicos.Update(txtIDProdServ.Text, _
                                               txtProduto.Text, _
                                               checkCritico.Checked) Then
                        MessageBox.Show("Dados atualizados com sucesso", "Produtos e Serviços", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        botIncluirCritico.Text = "Incluír"
                        txtProduto.Text = ""
                        checkCritico.Checked = False
                        carregaProdServById(idfornecedor)
                        isEditProServ = False
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            End If

        Else

            'Verificar campos obrigatórios

            'Checando se campos obrigatórios estão OK
            If txtProduto.Text = "" Then
                MessageBox.Show("Campo Produto Obrigatório", "Fornecedores - Produtos e Serviços", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtProduto.Focus()
            Else
                Try
                    'Salvar
                    If produtosServicos.Add(idfornecedor, _
                                            txtProduto.Text, _
                                            checkCritico.Checked) Then
                        MessageBox.Show("Novo Produto/Serviço incluído com sucesso", "Produtos e Serviços", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtProduto.Text = ""
                        checkCritico.Checked = False
                        carregaProdServById(idfornecedor)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

                Exit Sub
            End If

        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditarCritico_Click(sender As Object, e As EventArgs) Handles botEditarCritico.Click

        Dim id As Integer = 0

        If gridProdutos.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Produtos e Serviços", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Muda o Label do botão Incluir
            botIncluirCritico.Text = "Atualizar"

            'Passagem de parametros
            Try

                id = gridProdutos(gridProdutos.RowSel, 1)
                EditarProdServ(id)
                txtIDProdServ.Text = id

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#Region "MÉTODO EDITAR PROD/SERV"

    Public Sub EditarProdServ(ByVal id As Integer)

        'Editar
        isEditProServ = True

        'Seleciona Produtos/Serviços pelo Id
        Dim sql As String = String.Format("SELECT * FROM FORNECEDORES_PROD_SERV WHERE ID_PROD_SERV = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtProduto.Text = dr("DESCRICAO").ToString
                Me.checkCritico.Checked = dr("CRITICO").ToString

            End While


        Catch ex As Exception

        End Try

    End Sub

#End Region

#End Region

#Region "EXCLUIR"

    Private Sub botExlcuirCritico_Click(sender As Object, e As EventArgs) Handles botExlcuirCritico.Click
        Dim produtosServicos As New produtosServicos
        If gridProdutos.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Exclui Produtos/Serviços
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Produtos e Serviços", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    produtosServicos.Delete(gridProdutos(gridProdutos.RowSel, 1))
                    MessageBox.Show("Produto/Servico excluído com sucesso", "Produtos e Serviços", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    carregaProdServById(idfornecedor)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "BLOCO DE CODIGO NÃO UTILIZADO"

    ' update super tooltip using Show/Hide methods
    ' Private Sub _flex3_MouseHoverCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridProdutos.MouseClick
    ' Dim flex As C1.Win.C1FlexGrid.C1FlexGrid = CType(sender, C1.Win.C1FlexGrid.C1FlexGrid)
    ' Dim tip As String = _tip.Replace("(row,col)", String.Format("<b>({0},{1})</b>", flex.MouseRow, flex.MouseCol))
    'Dim pt As Point = flex.PointToClient(Control.MousePosition)
    '    TooltipCritico.Show(tip, flex, pt)
    ' End Sub

#End Region

#End Region

#Region "CONTATOS"

#Region "NOVO"

    Private Sub botIncluirContatos_Click(sender As Object, e As EventArgs) Handles botIncluirContatos.Click
        Dim Modulo As String = "FORNECEDOR"
        Dim Contatos As New Contatos
        '************* FORNECEDORES ****************
        If Edit_Contatos = True Then
            'Editar Contato/Fornecedor
            If txt_Nome_Contato.Text = "" Then
                MessageBox.Show("Campo Nome Obrigatório", "Fornecedores -Contatos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_Nome_Contato.Focus()
            Else
                Try
                    If Contatos.Update(idContatos, _
                                       txt_Nome_Contato.Text, _
                                       txtCargo.Text, _
                                       txtTel.Text, _
                                       txtCel.Text, _
                                       txt_Fax.Text, _
                                       txt_email_Contato.Text, _
                                       txt_skype_Contato.Text) Then
                        MessageBox.Show("Dados atualizados com sucesso", "Contatos", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        CarregaContatos()
                        Limpar_Contatos()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)

                End Try
            End If
        Else
            'Salva Contato/Fornecedor
            If txt_Nome_Contato.Text = "" Then
                MessageBox.Show("Campo Nome Obrigatório", "Fornecedores -Contatos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_Nome_Contato.Focus()
            Else
                Try
                    If Contatos.Add(idfornecedor, _
                                    Modulo, _
                                    txt_Nome_Contato.Text, _
                                    txtCargo.Text, _
                                    txtTel.Text, _
                                    txtCel.Text, _
                                    txt_Fax.Text, _
                                    txt_email_Contato.Text, _
                                    txt_skype_Contato.Text) Then

                        MessageBox.Show("Novo Contato incluído com sucesso", "Contatos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CarregaContatos()
                        Limpar_Contatos()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            End If
        End If

        ''Seta a Classe
        'Dim frmGrContato As New GeralCadContato
        'Dim frmForne As New forListaOcorrencias
        'Dim id As Integer = 0
        'Dim modulo As String = "FORNECEDOR"

        ''Delegate para instancia do grid
        'AddHandler frmGrContato.OnDataChange, AddressOf CarregaContatos

        ''Passagem de parametros
        'Try

        '    id = forListaFornecedores.gridFornecedores(forListaFornecedores.gridFornecedores.RowSel, 1)
        '    id = txtID.Text
        '    frmGrContato.fornecedor = id
        '    frmGrContato.Modulos = modulo
        '    frmGrContato.NovoContato()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        'End Try

    End Sub

    Sub Limpar_Contatos()
        txt_Nome_Contato.Text = ""
        txtCargo.Text = ""
        txtTel.Text = ""
        txtCel.Text = ""
        txt_Fax.Text = ""
        txt_email_Contato.Text = ""
        txt_skype_Contato.Text = ""
    End Sub
#End Region

#Region "EDITAR"

    Private Sub botEditarContatos_Click(sender As Object, e As EventArgs) Handles botEditarContatos.Click
        If gridContatos.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Muda o Label do botão Incluir
            'GeralCadContato.btoSalvar.Width = 80
            'GeralCadContato.btoSalvar.Text = "Atualizar"
            Edit_Contatos = True
            idContatos = gridContatos(gridContatos.RowSel, 1)
            'Passagem de parametros
            Try
                Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_FORNECEDORES_CONTATOS WHERE CODIGO = {0} AND MODULO = 'FORNECEDOR'", idContatos)

                'Popula os campos com os dados do Banco

                Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

                While dr.Read

                    Me.txt_Nome_Contato.Text = dr("NOME").ToString
                    Me.txtCargo.Text = dr("CARGO").ToString
                    Me.txtTel.Text = dr("TELEFONE").ToString
                    Me.txtCel.Text = dr("CELULAR").ToString
                    Me.txt_Fax.Text = dr("FAX").ToString
                    Me.txt_email_Contato.Text = dr("EMAIL").ToString
                    'Me.txt_skype_Contato.Text = dr("NOME_FANTASIA").ToString
                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

            'CarregaContatos(idfornecedor)
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluirContatos_Click(sender As Object, e As EventArgs) Handles botExcluirContatos.Click

        Dim Contatos As New Contatos
        Dim idFornecedor As String

        If gridContatos.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Pega o ID
            idFornecedor = txtID.Text

            'Exclui
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Contatos", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    Contatos.Delete(gridContatos(gridContatos.RowSel, 1))
                    MessageBox.Show("Contato excluído com sucesso", "Contatos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregaContatos()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#End Region

#Region "AVALIAÇÕES"


    Sub Carregar_Avaliações(ByVal id_Forn As Integer)
        Dim dr As SqlDataReader
        Dim i As Integer = 0
        dr = Manager.Util.getDataReader("SELECT * FROM VW_LISTAGEM_FORNECEDORES_AVALIACOES_CONCLUIDAS WHERE ID_FORNECEDOR =" & id_Forn)
        gridAvaliacoes.Rows.Count = 1
        Try


            While dr.Read
                Dim teste As String = ""
                i = i + 1
                gridAvaliacoes.Rows.Add()
                gridAvaliacoes(gridAvaliacoes.Rows.Count - 1, 0) = dr("ID")
                gridAvaliacoes(gridAvaliacoes.Rows.Count - 1, 1) = dr("id_Avaliacao")
                gridAvaliacoes(gridAvaliacoes.Rows.Count - 1, 2) = dr("ID_FORNECEDOR")
                gridAvaliacoes(gridAvaliacoes.Rows.Count - 1, 3) = dr("Responsavél")
                gridAvaliacoes(gridAvaliacoes.Rows.Count - 1, 4) = dr("Observações")
                gridAvaliacoes(gridAvaliacoes.Rows.Count - 1, 5) = dr("Data")
                gridAvaliacoes(gridAvaliacoes.Rows.Count - 1, 6) = dr("Situação")
                teste = dr("Pendencia").ToString
                If teste = "" Then
                    gridAvaliacoes(gridAvaliacoes.Rows.Count - 1, 7) = ""
                    gridAvaliacoes(gridAvaliacoes.Rows.Count - 1, 8) = ""
                    gridAvaliacoes(gridAvaliacoes.Rows.Count - 1, 9) = ""
                Else
                    gridAvaliacoes(gridAvaliacoes.Rows.Count - 1, 7) = dr("Pendencia")
                    gridAvaliacoes(gridAvaliacoes.Rows.Count - 1, 8) = dr("Data_Ocorencia")
                    gridAvaliacoes(gridAvaliacoes.Rows.Count - 1, 9) = dr("Pendencia_Situacao")

                End If

            End While
        Catch ex As Exception

        End Try
    End Sub

#End Region

    '#Region "OCORRENCIAS"

    '#Region "NOVO"

    '    Private Sub botIncluirOcorrencias_Click(sender As Object, e As EventArgs) Handles botIncluirOcorrencias.Click

    '        Dim forOcorrecias As New forCadOcorrencia
    '        Dim frmForne As New forListaOcorrencias
    '        Dim id As Integer = 0

    '        'Delegate para instancia do grid
    '        AddHandler forOcorrecias.OnDataChange, AddressOf CarregaOcorrencias

    '        'Passagem de parametros
    '        Try

    '            id = forListaFornecedores.gridFornecedores(forListaFornecedores.gridFornecedores.RowSel, 1)
    '            id = txtID.Text
    '            forOcorrecias.fornecedor = id
    '            forOcorrecias.NovoOcorrencias()

    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
    '        End Try

    '    End Sub

    '#End Region

    '#Region "EDITAR"

    '    Private Sub botEditarOcorrencias_Click(sender As Object, e As EventArgs) Handles botEditarOcorrencias.Click

    '        Dim frmOcorrencias As New forCadOcorrencia
    '        Dim id As Integer = 0

    '        If gridOcorrencias.RowSel < 0 Then
    '            MessageBox.Show("Não à nenhuma item selecionado", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Else

    '            'Delegate para instancia do grid
    '            AddHandler frmOcorrencias.OnDataChange, AddressOf CarregaOcorrencias

    '            'Muda o Label do botão Incluir
    '            frmOcorrencias.botSalvar.Width = 80
    '            frmOcorrencias.botSalvar.Text = "Atualizar"

    '            'Passagem de parametros
    '            Try

    '                id = gridOcorrencias(gridOcorrencias.RowSel, 1)
    '                frmOcorrencias.fornecedor = idfornecedor
    '                idOcorrencias = id
    '                frmOcorrencias.Ocorrencias = idOcorrencias
    '                frmOcorrencias.EditarOcorrencias(id)

    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
    '            End Try

    '            CarregaOcorrencias(idfornecedor)
    '        End If
    '    End Sub

    '#End Region

    '#Region "EXCLUIR"

    '    Private Sub botExcluirOcorrencias_Click(sender As Object, e As EventArgs) Handles botExcluirOcorrencias.Click

    '        Dim Ocorrencias As New Ocorrencias
    '        Dim idFornecedor As String

    '        If gridOcorrencias.RowSel < 0 Then
    '            MessageBox.Show("Não à nenhuma item selecionado", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Else
    '            'Pega o ID
    '            idFornecedor = txtID.Text

    '            'Exclui Ocorrencias
    '            Try

    '                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Ocorrências", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
    '                    Ocorrencias.Delete(gridOcorrencias(gridOcorrencias.RowSel, 1))
    '                    MessageBox.Show("Ocorrencia excluída com sucesso", "Ocorrências", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    CarregaOcorrencias(idFornecedor)
    '                End If

    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
    '            End Try

    '        End If
    '    End Sub

    '#End Region

    '#End Region

#Region "ANEXOS"

#Region "CADASTRO DE ANEXOS"

    Private Sub botAnexos_Click(sender As System.Object, e As System.EventArgs) Handles botAnexos.Click

        Dim audit As New auditores

        Try

            'Status
            barra.Value = 10
            lblStatus.Text = "Iniciando Inportação de Arquivo..."

            Dim Modulo As String = "FORNECEDORES"
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


            If MessageBox.Show("Tem certeza que deseja Salvar o Anexo selecionado", "fornecedor", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then

                If audit.AddQANEXOS(Modulo, _
                                      idfornecedor, _
                                      descricao, _
                                      ANEXO, _
                                      tipo) Then
                    MessageBox.Show("Anexos do Auditor salvos com sucesso", "fornecedor", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Status
                    barra.Value = 100
                    lblStatus.Text = "Concluido com sucesso!"

                    'carrega Lista
                    carregaListaAnexos(idfornecedor)

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

#Region "CARREGA LISTA DE ANEXOS"

    Public Sub carregaListaAnexos(ByVal id As String)

        Dim dt As New DataTable
        Dim i As Integer = 1

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_ANEXOS_TIPO_FORNECEDORES WHERE ID_MODULO = {0}", id)
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

                If dr("TIPO") = "lsx" Then
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

        End Try

    End Sub

#End Region

#End Region

#End Region

    Private Sub botAddRequisitos_Click(sender As System.Object, e As System.EventArgs) Handles botVisualizar.Click
        If gridAvaliacoes.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma Avaliação selecionada", "", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim frm As New forCadAvaliacao
            'Chama nova avaliacao
            frm.ID = gridAvaliacoes(gridAvaliacoes.RowSel, 1)
            frm.isEditAvalicoes = True
            frm.ShowDialog()
        End If
    End Sub
End Class
