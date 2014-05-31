Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.audListaAuditores
Public Class audCadAuditores

#Region "VARIAVEIS"

    ''' FOTO
    Private FOTO() As Byte

    ''' Variavel global que contera o valor passado
    Private isEdit As Boolean = False
    Private isEditq As Boolean = False
    Public idAuditores As String = String.Empty
    Public idAuditoresQLF As String
    Public verif As Boolean = False

    ''' ANEXO
    Private ANEXO() As Byte
    Public Modulo As String = "AUDITORIAS"
    Public Tela As String = "audCadAuditores"

    ''' Pega Id Contrato
    Public WriteOnly Property Auditor() As String
        Set(ByVal value As String)
            Me.idAuditores = value
        End Set
    End Property

    ''' Pega Id Contrato
    Public WriteOnly Property ClienteS() As String
        Set(ByVal value As String)
            Me.idAuditoresQLF = value
        End Set
    End Property

#End Region

#Region "CARREGA LISTAS"

#Region "AUDITORES"

#Region "CARREGAR LISTA QUALIFICAÇÃO"

    Public Sub carregaAuditoresQlf()

        'Carrega Lista
        gridQualificacao.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_AUDITORIAS_AUDITORES_QUALIFICACAO")

    End Sub

#End Region

#Region "CARREGAR LISTA QUALIFICAÇÃO ID"

    Public Sub carregaAuditoresQlfByID(ByVal id As Integer)

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_AUDITORIAS_AUDITORES_QUALIFICACAO WHERE ID_AUDITORES = {0}", id)

        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                gridQualificacao.AutoGenerateColumns = False
                gridQualificacao.DataSource = Manager.Util.getDataTable(sql)

            End While

        Catch ex As Exception

        End Try


    End Sub

#End Region

#End Region

#Region "CARREGA TITULO"

    Sub CarregaTitulo()

        If radioInterno.Checked = True Then
            txtAuditor.Text = comboInterno.Text
        Else
            txtAuditor.Text = txtNome.Text
        End If

    End Sub

    Private Sub txtNome_LostFocus(sender As Object, e As System.EventArgs) Handles txtNome.LostFocus
        CarregaTitulo()
    End Sub

    Private Sub comboInterno_LostFocus(sender As Object, e As System.EventArgs) Handles comboInterno.LostFocus
        CarregaTitulo()
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

#End Region

#Region "POPULA COMBOS"

#Region "RESPONSAVEL"

    Sub CarregaResponsavel()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboInterno.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboInterno.DataSource = dtb
        comboInterno.DisplayMember = "COLABORADOR"
        comboInterno.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "NOVO"

    Public Sub NovoAuditor()
        'Cadastrar Novo
        isEdit = False
        Me.Show()
    End Sub

#End Region

#Region "LOAD"

    Private Sub audCadastroAuditores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tab_Identificacao.Show()
        CarregaTitulo()
        carregaListaAnexos(idAuditores)
        CarregaResponsavel()
    End Sub

#End Region

#Region "ABAS"

#Region "IDENTIFICAÇÃO"

#Region "FOTO"

    Private Sub botFoto_Click(sender As Object, e As EventArgs) Handles botFoto.Click

        Try
            Dim dlgImage As FileDialog = New OpenFileDialog()
            Dim caminho As String = ""

            If dlgImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
                caminho = dlgImage.FileName
                picFoto.ImageLocation = caminho
            End If

            If Not picFoto.ImageLocation Is Nothing Then
                Dim infoImg As New FileInfo(picFoto.ImageLocation)
                Dim tamanho As Long = infoImg.Length
                Dim arqStream As New FileStream(picFoto.ImageLocation, FileMode.Open, FileAccess.Read)
                FOTO = New Byte(Convert.ToInt32(tamanho - 1)) {}
                arqStream.Read(FOTO, 0, tamanho)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvarId_Click(sender As Object, e As EventArgs) Handles botSalvarId.Click

        'Seta a Classe
        Dim auditores As New auditores

        Dim zero As Integer = 0

        'Verificando valor de Origem
        Dim origem As Integer
        Dim Responsavel As Integer = 0
        If radioInterno.Checked = True Then
            origem = 1
            'Tratamento de erro Nome
            If comboInterno.SelectedValue.ToString = String.Empty Then
                MessageBox.Show("Campo Nome Obrigatório", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                comboInterno.Focus()
                verif = True
                Exit Sub
            Else
                Responsavel = comboInterno.SelectedValue
            End If
        End If
        If radioExterno.Checked = True Then
            origem = 2
            Responsavel = 0
        End If
        If radioCertificador.Checked = True Then
            origem = 3
            Responsavel = 0
        End If

        'Verificando valor de Situação
        Dim situacao As Boolean
        If radioAtivo.Checked = True Then
            situacao = True
        Else
            situacao = False
        End If

        'Verificando valor de Classificação
        Dim classifica As Boolean
        If radioAud1.Checked = True Then
            classifica = True
        Else
            classifica = False
        End If

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If auditores.Update(idAuditores, _
                                        origem, _
                                        Responsavel, _
                                        txtNome.Text, _
                                        situacao, _
                                        classifica, _
                                        DateCadastro.Value, _
                                        txtOrgCertificador.Text, _
                                        FOTO, _
                                        txtTel.Text, _
                                        txtCel.Text, _
                                        txtFax.Text, _
                                        txtEmail.Text, _
                                        txtSkype.Text) Then
                        audListaAuditores.carregaAuditores()
                        MessageBox.Show("Dados do Auditor Atualizados com sucesso", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Tab_Qualificacao.Show()
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
                Try
                    'Salvar
                    idAuditores = auditores.Add(origem, _
                                         Responsavel, _
                                         txtNome.Text, _
                                         situacao, _
                                         classifica, _
                                         DateCadastro.Value, _
                                         txtOrgCertificador.Text, _
                                         FOTO, _
                                         txtTel.Text, _
                                         txtCel.Text, _
                                         txtFax.Text, _
                                         txtEmail.Text, _
                                         txtSkype.Text)
                    If idAuditores <> String.Empty Then
                        Tab_Qualificacao.Enabled = True
                        Tab_Historico.Enabled = True
                        Tab_Anexar.Enabled = True
                        audListaAuditores.carregaAuditores()
                        MessageBox.Show("Dados do Auditor salvos com sucesso", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Tab_Qualificacao.Show()
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

    Private Sub Verificar()
        verif = False

        'Tratamento de erro Origem
        If radioInterno.Checked = False And radioExterno.Checked = False And radioCertificador.Checked = False Then
            MessageBox.Show("Campo Origem Obrigatório", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verif = True
            Exit Sub
        ElseIf radioInterno.Checked = True Then
            'Tratamento de erro Nome
            If comboInterno.SelectedValue.ToString = String.Empty Then
                MessageBox.Show("Campo Nome Obrigatório", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                comboInterno.Focus()
                verif = True
                Exit Sub
            End If
        ElseIf radioExterno.Checked = True Then
            'Tratamento de erro Nome
            If txtNome.Text = "" Then
                MessageBox.Show("Campo Nome Obrigatório", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNome.Focus()
                verif = True
                Exit Sub
            End If
        ElseIf radioCertificador.Checked = True Then
            'Tratamento de erro Certificador
            If radioCertificador.Checked = True Then
                If txtOrgCertificador.Text = "" Then
                    MessageBox.Show("Campo Certificador Obrigatório", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtOrgCertificador.Focus()
                    verif = True
                    Exit Sub
                End If
            End If
        End If
        'Tratamento de erro Situação
        If radioAtivo.Checked = False And radioInativo.Checked = False Then
            MessageBox.Show("Campo Situação Obrigatório", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Classificação
        If radioAud1.Checked = False And radioAud2.Checked = False Then
            MessageBox.Show("Campo Classificação Obrigatório", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data
        If DateCadastro.Text = "" Then
            MessageBox.Show("Campo Data Obrigatório", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            DateCadastro.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarAuditores(ByVal id As Integer)

        Tab_Qualificacao.Enabled = True
        Tab_Historico.Enabled = True
        Tab_Anexar.Enabled = True
        carregaAuditoresQlfByID(idAuditores)
        carregaListaAnexos(idAuditores)
        CarregaResponsavel()

        'Editar
        isEdit = True

        'Muda o Label do botão Incluir
        botSalvarId.Width = 80
        botSalvarId.Text = "Atualizar"

        'Seleciona pelo Id
        Dim sql As String = String.Format("SELECT * FROM AUDITORIAS_AUDITORES WHERE ID_AUDITORES = '{0}'", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                If dr("ORIGEM") = 1 Then
                    radioInterno.Checked = True
                    Me.comboInterno.SelectedValue = dr("ID_COLABORADORES")
                    txtAuditor.Text = comboInterno.Text
                ElseIf dr("ORIGEM") = 2 Then
                    Me.txtOrgCertificador.Text = dr("CERTIFICADOR").ToString
                    radioExterno.Checked = True
                    Me.txtAuditor.Text = dr("NOME")
                    Me.txtNome.Text = dr("NOME")
                ElseIf dr("ORIGEM") = 3 Then
                    Me.txtOrgCertificador.Text = dr("CERTIFICADOR").ToString
                    radioCertificador.Checked = True
                    Me.txtAuditor.Text = dr("NOME")
                    Me.txtNome.Text = dr("NOME")
                End If

                If dr("SITUACAO") = True Then
                    radioAtivo.Checked = True
                Else
                    radioInativo.Checked = True
                End If

                If dr("CLASSIFICACAO") = True Then
                    radioAud1.Checked = True
                Else
                    radioAud2.Checked = True
                End If

                Me.DateCadastro.Value = dr("DATA_CADASTRO").ToString

                If radioInterno.Checked = False Then

                    Me.txtTel.Text = dr("TELEFONE_FIXO")
                    Me.txtCel.Text = dr("TELEFONE_CELULAR")
                    Me.txtFax.Text = dr("TELEFONE_FAX")
                    Me.txtEmail.Text = dr("EMAIL")
                    Me.txtSkype.Text = dr("SKYPE")

                Else
                    Me.txtTel.Mask = "(00) 0000-0000"
                    Me.txtCel.Text = "(00) 0000-0000"
                    Me.txtFax.Text = "(00) 0000-0000"
                    Me.txtEmail.Text = ""
                    Me.txtSkype.Text = ""
                End If

                'FOTO
                Dim bytePicData() As Byte = dr("FOTO")
                Dim PicMemStream As New System.IO.MemoryStream(bytePicData)
                picFoto.Image = Image.FromStream(PicMemStream)
                FOTO = bytePicData

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

#End Region

#Region "CONTROLE DE CONTATOS EXTERNOS"

    Private Sub radioExterno_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioExterno.SelectedIndexChanged
        If radioInterno.Checked = True Then
            PanelContatoExterno.Visible = False
            inpultinterno.Visible = True
        ElseIf radioExterno.Checked = True Then
            PanelContatoExterno.Visible = True
            inpultinterno.Visible = False
            lblOrgCertificador.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            txtOrgCertificador.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        ElseIf radioCertificador.Checked = True Then
            PanelContatoExterno.Visible = True
            inpultinterno.Visible = False
            lblOrgCertificador.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            txtOrgCertificador.Visibility = C1.Win.C1InputPanel.Visibility.Visible
        Else
            PanelContatoExterno.Visible = False
        End If
    End Sub

#End Region

#End Region

#Region "QUALIFICAÇÃO"

#Region "INCLUIR"

    Private Sub botIncluir_Click(sender As System.Object, e As System.EventArgs) Handles botIncluir.Click

        'Seta a Classe
        Dim audiotores As New auditores
        Dim zero As Integer = 0

        'Verificando valor de Homologação
        Dim homologacao As Integer
        If radioSim.Checked = True Then
            homologacao = True
        Else
            homologacao = False
        End If

        'Inicio Atualizar/Salvar
        If isEditq Then

            'Verificar campos obrigatórios
            VerificarQualificacao()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If audiotores.UpdateQLF(idAuditoresQLF, _
                                        idAuditores, _
                                        txtFormacao.Text, _
                                        dataInicio.Value, _
                                        dataTermino.Value, _
                                        txtEntidade.Text, _
                                        NumCargaHoraria.Text, _
                                        homologacao, _
                                        dataHomologacao.Value) Then
                        MessageBox.Show("Dados da Qualificação do Auditor salvos com sucesso", "Qualificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        botIncluir.Text = "Incluir"
                        'CARREGA LISTA ATUALIZADA
                        carregaAuditoresQlfByID(idAuditores)
                        'LIMPA AS CAMPOS
                        txtFormacao.Text = ""
                        dataInicio.Text = ""
                        dataTermino.Text = ""
                        txtEntidade.Text = ""
                        NumCargaHoraria.Text = ""
                        radioSim.Checked = False
                        radioNao.Checked = False
                        dataHomologacao.Text = ""
                        isEditq = False
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            'Verificar campos obrigatórios
            VerificarQualificacao()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If audiotores.AddQLF(idAuditores, _
                                            txtFormacao.Text, _
                                            dataInicio.Value, _
                                            dataTermino.Value, _
                                            txtEntidade.Text, _
                                            NumCargaHoraria.Text, _
                                            homologacao, _
                                            dataHomologacao.Value) Then
                        MessageBox.Show("Dados da Qualificação do Auditor salvos com sucesso", "Qualificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'CARREGA LISTA ATUALIZADA
                        carregaAuditoresQlfByID(idAuditores)
                        'LIMPA AS CAMPOS
                        txtFormacao.Text = ""
                        dataInicio.Text = ""
                        dataTermino.Text = ""
                        txtEntidade.Text = ""
                        NumCargaHoraria.Text = ""
                        radioSim.Checked = False
                        radioNao.Checked = False
                        dataHomologacao.Text = ""
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub VerificarQualificacao()
        verif = False

        'Tratamento de erro Formação
        If txtFormacao.Text = "" Then
            MessageBox.Show("Campo Formação Obrigatório", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFormacao.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data Inicio
        If dataInicio.Text = "" Then
            MessageBox.Show("Campo Início Obrigatório", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataInicio.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data Término
        If dataTermino.Text = "" Then
            MessageBox.Show("Campo Término Obrigatório", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataTermino.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Homologado
        If radioSim.Checked = False And radioNao.Checked = False Then
            MessageBox.Show("Campo Homologado Obrigatório", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data da Homologação
        If dataHomologacao.Text = "" Then
            MessageBox.Show("Campo Data da Homologação Obrigatório", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataHomologacao.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As Object, e As EventArgs) Handles botEditar.Click

        Dim id As Integer = 0

        If gridQualificacao.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma Qualificação cadastrada", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            'Passagem de parametros
            Try

                id = gridQualificacao(gridQualificacao.RowSel, 1)
                idAuditoresQLF = id
                EditarAuditoresQFL(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If
    End Sub

#Region "EDITAR QUALIFICAÇÃO"

    Public Sub EditarAuditoresQFL(ByVal id As Integer)

        'Editar
        isEditq = True

        'Muda o Label do botão Incluir
        botIncluir.Width = 80
        botIncluir.Text = "Atualizar"

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_AUDITORIAS_AUDITORES_QUALIFICACAO WHERE ID = '{0}'", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtFormacao.Text = dr("FORMACAO").ToString
                Me.dataInicio.Value = dr("INICIO").ToString
                Me.dataTermino.Value = dr("TERMINO").ToString
                Me.txtEntidade.Text = dr("ENTIDADE").ToString
                Me.NumCargaHoraria.Text = dr("CH")
                If dr("HOMOLOGADO") = "Sim" Then
                    radioSim.Checked = True
                Else
                    radioNao.Checked = True
                End If
                Me.dataHomologacao.Value = dr("DATA").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As Object, e As EventArgs) Handles botExcluir.Click

        Dim auditores As New auditores

        If gridQualificacao.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma Qualificação cadastrada", "Auditores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            'Excluir o Fornecedor
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado ?", "Qualificação", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    auditores.DeleteQLF(gridQualificacao(gridQualificacao.RowSel, 1))
                    MessageBox.Show("Dados do Auditor excluído com sucesso", "Qualificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    carregaAuditoresQlfByID(idAuditores)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

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
                                    idAuditores, _
                                    Tela, _
                                    descricao, _
                                    ANEXO, _
                                    tipo) Then
                    MessageBox.Show("Anexos salvos com sucesso", "ISO é Fácil", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Status
                    barra.Value = 100
                    lblStatus.Text = "Concluido com sucesso!"

                    'carrega Lista
                    carregaListaAnexos(idAuditores)
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
