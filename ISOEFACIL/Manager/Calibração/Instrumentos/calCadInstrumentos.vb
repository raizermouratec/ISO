Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.calListaInstrumentos
Public Class calCadInstrumentos

#Region "VARIAVEIS"

    'FOTO
    Private FOTO() As Byte
    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    'Private isEditregistro As Boolean = False
    Public idInstrumentos As String
    Private tipouso As Integer
    Private situacao As Integer
    Private ativo As Integer
    Public verif As Boolean = False
    Public status As Boolean

    'Anexos
    Private ANEXO() As Byte
    Public Modulo As String = "INSTRUMENTOS"
    Public Tela As String = "calCadInstrumentos"

    'Pega Id 
    Public WriteOnly Property Registro() As String
        Set(ByVal value As String)
            Me.idInstrumentos = value
        End Set
    End Property

#End Region

#Region "CARREGA LISTAS"

#Region "CARREGA LISTA DE HISTORICO"

    Public Sub carregaListaHistorico(ByVal id As String)

        gridHistorico.AutoGenerateColumns = False

        Dim dtb As New DataTable
        Dim i As Integer = 1

        Dim sql As String = String.Format("SELECT TIPO, ANO, MES, DATA, VALIDADE, SITUACAO FROM CALIBRACOES_REALIZAR WHERE ID_CALIBRACOES_INSTRUMENTOS = {0}", id)
        dtb = Manager.Util.getDataTable(sql)

        'Monta o Grid
        gridHistorico.DataSource = dtb

        Try

            For Each dr As DataRow In dtb.Rows

                ' coluna especifica
                If dr("SITUACAO") = "Programada" Then
                    gridHistorico.SetCellImage(i, 6, _imgListLegenda2.Images.Item(0))
                End If

                If dr("SITUACAO") = "Realizada" Then
                    gridHistorico.SetCellImage(i, 6, _imgListLegenda2.Images.Item(1))
                End If

                If dr("SITUACAO") = "Cancelada" Then
                    gridHistorico.SetCellImage(i, 6, _imgListLegenda2.Images.Item(2))
                End If

                If dr("SITUACAO") = "Reprogramada" Then
                    gridHistorico.SetCellImage(i, 6, _imgListLegenda2.Images.Item(3))
                End If

                If dr("SITUACAO") = "Atrasada" Then
                    gridHistorico.SetCellImage(i, 6, _imgListLegenda2.Images.Item(4))
                End If

                If dr("SITUACAO") = "Em Branco" Then
                    gridHistorico.SetCellImage(i, 6, _imgListLegenda2.Images.Item(5))
                End If

                i += 1

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

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

#Region "INSTRUMENTOS"

#Region "TIPO DE MEDICAO"

    Sub CarregaTipoMedicao()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM TIPO_MEDICAO")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboTipoMedicao.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboTipoMedicao.DataSource = dtb
        comboTipoMedicao.DisplayMember = "NOME"
        comboTipoMedicao.ValueMember = "ID_TIPO_MEDICAO"
    End Sub

#End Region

#Region "RESPONSAVEL"

    Sub CarregaResp()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
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

#Region "CARREGA TITULO"

    Sub CarregaTitulo()
        txtInstrumento.Text = txtNome.Text
        txtIdent.Text = txtIdentificacao.Text
    End Sub

#End Region

#End Region

#End Region

#Region "LOAD"

    Private Sub calCadastrarInstrumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Page1.Show()
        CarregaTipoMedicao()
        CarregaResp()
        CarregaTitulo()
        carregaListaAnexos(idInstrumentos)
        'carregaListaHistorico(idInstrumentos)
        'Cor do texto
        txtArmazenamento.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

    Private Sub botAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAdd.Click

        'Chama a form para adicionar
        calAddTipoMedicao.Show()

    End Sub

    Private Sub comboTipoUso_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboTipoUso.SelectedIndexChanged

        Try
            'VALOR DO COMBO NO COLLECTION
            If comboTipoUso.SelectedIndex = 0 Then
                'Operacional
                tipouso = 1

            ElseIf comboTipoUso.SelectedIndex = 1 Then
                'Padrão Interno
                tipouso = 2
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub comboSituacao_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboSituacao.SelectedIndexChanged

        Try
            'VALOR DO COMBO NO COLLECTION
            If comboSituacao.SelectedIndex = 0 Then
                'Não Calibrado
                situacao = 0
            ElseIf comboSituacao.SelectedIndex = 1 Then
                'Calibração Vencida
                situacao = 2
            ElseIf comboSituacao.SelectedIndex = 2 Then
                'Calibrado
                situacao = 1
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub comboTipoMedicao_GotFocus(sender As Object, e As System.EventArgs) Handles comboTipoMedicao.GotFocus
        CarregaTipoMedicao()
    End Sub

    Private Sub txtNome_LostFocus(sender As Object, e As System.EventArgs) Handles txtNome.LostFocus
        CarregaTitulo()
    End Sub

    Private Sub txtIdentificacao_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtIdentificacao.TextChanged
        CarregaTitulo()
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoInstrumento()
        'Cadastrar Novo
        isEdit = False
        'Novo Instrumento Ativo
        status = True
        ativo = 1
        radioAtivo.Checked = True
        lblStatus.Text = "Ativo"
        imgStatus.Image = ImageList1.Images.Item(1)
        'Situação Não Calibrado
        comboSituacao.SelectedIndex = 0
        situacao = 0
        'Abas Bloqueadas
        Page2.Enabled = False
        Page3.Enabled = False
        Page4.Enabled = False
        Me.ShowDialog()
    End Sub

    Public Sub NovoTipo()
        'Cadastrar Novo
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarInstrumentos(ByVal id As Integer)

        'Editar 
        isEdit = True

        'Abas Liberadas
        Page2.Enabled = True
        Page3.Enabled = True
        Page4.Enabled = True

        'Carrega Combos
        CarregaTipoMedicao()
        CarregaResp()
        CarregaTitulo()
        carregaListaHistorico(idInstrumentos)
        carregaListaAnexos(idInstrumentos)

        'Muda o Label do botão Incluir
        botSalvar.Width = 80
        botSalvar.Text = "Atualizar"

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM CALIBRACOES_INSTRUMENTOS WHERE ID_CALIBRACOES_INSTRUMENTOS = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtNome.Text = dr("NOME").ToString
                Me.txtInstrumento.Text = dr("NOME").ToString
                Me.txtIdentificacao.Text = dr("IDENTIFICACAO").ToString
                Me.txtIdent.Text = dr("IDENTIFICACAO").ToString
                If dr("TIPO_USO") = 1 Then
                    'Operacional
                    comboTipoUso.SelectedIndex = 0
                ElseIf dr("TIPO_USO") = 2 Then
                    'Padrão Interno
                    comboTipoUso.SelectedIndex = 1
                End If
                Me.comboTipoMedicao.SelectedValue = dr("ID_TIPO_MEDICAO").ToString
                Me.txtFaixaMedicao.Text = dr("FAIXA_MEDICAO").ToString
                Me.txtPrecisao.Text = dr("PRECISAO").ToString
                Me.txtFabricante.Text = dr("FABRICANTE").ToString
                Me.txtLocalGuarda.Text = dr("LOCAL_GUARDA").ToString
                Me.txtArmazenamento.Text = dr("ARMAZENAMENTO").ToString
                If dr("SITUACAO") = 0 Then
                    'Não Calibrado
                    comboSituacao.SelectedIndex = 0
                ElseIf dr("SITUACAO") = 1 Then
                    'Calibrado
                    comboSituacao.SelectedIndex = 2
                ElseIf dr("SITUACAO") = 2 Then
                    'Calibração Vencida
                    comboSituacao.SelectedIndex = 1
                End If
                Me.dateAquisicao.Value = dr("DATA_AQUISICAO").ToString
                Me.comboResp.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.dateData.Value = dr("DATA").ToString
                If dr("ATIVO") = True Then
                    ativo = 1 'Ativar 
                    radioAtivo.Checked = True
                    lblStatus.Text = "Ativo"
                    imgStatus.Image = ImageList1.Images.Item(1)
                    status = True
                ElseIf dr("ATIVO") = False Then
                    ativo = 0 'Inativar 
                    radioInativo.Checked = True
                    lblStatus.Text = "Inativo"
                    imgStatus.Image = ImageList1.Images.Item(0)
                    status = False
                End If
                'FOTO
                Dim bytePicData() As Byte = dr("FOTO")
                Dim PicMemStream As New System.IO.MemoryStream(bytePicData)
                photoFoto.Image = Image.FromStream(PicMemStream)
                FOTO = bytePicData

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

#End Region

#Region "ABAS"

#Region "CADASTRO INSTRUMENTO"

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim instrumentos As New instrumentos

        'Verificando Instrumento Ativo ou Inativo
        If radioAtivo.Checked = True Then
            ativo = 1
        ElseIf radioInativo.Checked = True Then
            ativo = 0
        End If

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar se Foto não tem nada
            If Not FOTO Is Nothing Then

                'Verificar campos obrigatórios
                VerificarCadastroInstrumento()
                'Checando se campos obrigatórios estão OK
                If verif = False Then
                    Try
                        'Carrega o Titulo
                        CarregaTitulo()
                        'Atualizar Com Foto
                        If instrumentos.Update(idInstrumentos, _
                                               comboTipoMedicao.SelectedValue, _
                                               comboResp.SelectedValue, _
                                               txtNome.Text, _
                                               txtIdentificacao.Text, _
                                               tipouso, _
                                               txtFaixaMedicao.Text, _
                                               txtPrecisao.Text, _
                                               txtFabricante.Text, _
                                               txtLocalGuarda.Text, _
                                               txtArmazenamento.Text, _
                                               situacao, _
                                               dateAquisicao.Value, _
                                               dateData.Value, _
                                               ativo, _
                                               FOTO) Then
                            calListaInstrumentos.carregaInstrumentos()
                            MessageBox.Show("Dados de Instrumento atualizados com sucesso", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    End Try
                Else
                    Exit Sub
                End If

            Else

                'Verificar campos obrigatórios
                VerificarCadastroInstrumento()
                'Checando se campos obrigatórios estão OK
                If verif = False Then
                    Try
                        'Carrega o Titulo
                        CarregaTitulo()
                        'Atualizar Sem Foto
                        If instrumentos.Update1(idInstrumentos, _
                                                   comboTipoMedicao.SelectedValue, _
                                                   comboResp.SelectedValue, _
                                                   txtNome.Text, _
                                                   txtIdentificacao.Text, _
                                                   tipouso, _
                                                   txtFaixaMedicao.Text, _
                                                   txtPrecisao.Text, _
                                                   txtFabricante.Text, _
                                                   txtLocalGuarda.Text, _
                                                   txtArmazenamento.Text, _
                                                   situacao, _
                                                   dateAquisicao.Value, _
                                                   dateData.Value, _
                                                   ativo) Then
                            calListaInstrumentos.carregaInstrumentos()
                            MessageBox.Show("Dados de Instrumento atualizados com sucesso", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    End Try
                Else
                    Exit Sub
                End If

            End If

        Else

            'Verificar campos obrigatórios
            VerificarCadastroInstrumento()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If instrumentos.Add(comboTipoMedicao.SelectedValue, _
                                           comboResp.SelectedValue, _
                                           txtNome.Text, _
                                           txtIdentificacao.Text, _
                                           tipouso, _
                                           txtFaixaMedicao.Text, _
                                           txtPrecisao.Text, _
                                           txtFabricante.Text, _
                                           txtLocalGuarda.Text, _
                                           txtArmazenamento.Text, _
                                           situacao, _
                                           dateAquisicao.Value, _
                                           dateData.Value, _
                                           ativo, _
                                           FOTO) Then
                        calListaInstrumentos.carregaInstrumentos()
                        MessageBox.Show("Instrumento cadastrado com sucesso", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        isEdit = True
                        'Muda o Label do botão Incluir
                        botSalvar.Width = 80
                        botSalvar.Text = "Atualizar"
                        Page2.Enabled = True
                        Page3.Enabled = True
                        Page4.Enabled = True
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub VerificarCadastroInstrumento()
        verif = False

        'Tratamento de erro Nome
        If txtNome.Text = "" Then
            MessageBox.Show("Campo Nome Obrigatório", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNome.Focus()
            verif = True
            Exit Sub
        Else
            CarregaTitulo()
        End If
        'Tratamento de erro Tipo de Uso
        If comboTipoUso.Text = "" Then
            MessageBox.Show("Campo Tipo de Uso Obrigatório", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboTipoUso.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Tipo de Medição
        If comboTipoMedicao.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Tipo de Medição Obrigatório", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboTipoMedicao.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Faixa de Medição
        If txtFaixaMedicao.Text = "" Then
            MessageBox.Show("Campo Faixa de Medição Obrigatório", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFaixaMedicao.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Precisão
        If txtPrecisao.Text = "" Then
            MessageBox.Show("Campo Precisão Obrigatório", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPrecisao.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Fabricante
        If txtFabricante.Text = "" Then
            MessageBox.Show("Campo Fabricante Obrigatório", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFabricante.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data da Aquisição
        If dateAquisicao.Text = "" Then
            MessageBox.Show("Campo Data da Aquisição Obrigatório", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateAquisicao.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Responsável
        If comboResp.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável Obrigatório", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResp.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data
        If dateData.Text = "" Then
            MessageBox.Show("Campo Data Obrigatório", "Instrumentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateData.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "ATIVO"

    Private Sub radioAtivo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioAtivo.SelectedIndexChanged

        If status = False Then

            If ativo = 0 Then

                If radioAtivo.Checked = True Then

                    If MessageBox.Show("Deseja continuar a Ativação deste instrumento?", "Instrumentos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                        Dim frm As New calJustificar
                        Dim id As Integer = 0

                        'Status muda de Ativo para Inativo
                        lblStatus.Text = "Ativo"
                        imgStatus.Image = ImageList1.Images.Item(1)

                        'Situação muda de Ativo para Inativo
                        ativo = 1
                        radioAtivo.Checked = True

                        'Passagem de parametros
                        Try
                            id = calListaInstrumentos.gridInst(calListaInstrumentos.gridInst.RowSel, 1)
                            frm.Text = "Justificar Ativação"
                            frm.Ativo = 1
                            frm.idInstrumentos = id
                            frm.NovoJustificar()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                        End Try

                    Else

                        status = True
                        radioInativo.Checked = False And radioAtivo.Checked = False

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub radioInativo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioInativo.SelectedIndexChanged

        If status = True Then

            'Verificando se o Instrumento é Ativo
            If ativo = 1 Then

                If radioInativo.Checked = True Then

                    If MessageBox.Show("Deseja continuar a Inativação deste instrumento?", "Instrumentos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                        Dim frm As New calJustificar
                        Dim id As Integer = 0

                        'Status muda de Inativo para Ativo
                        lblStatus.Text = "Inativo"
                        imgStatus.Image = ImageList1.Images.Item(0)

                        'Situação muda de Inativo para Ativo
                        ativo = 0
                        radioInativo.Checked = True

                        'Passagem de parametros
                        Try
                            id = calListaInstrumentos.gridInst(calListaInstrumentos.gridInst.RowSel, 1)
                            frm.Text = "Justificar Inativação"
                            frm.Ativo = 0
                            frm.idInstrumentos = id
                            frm.NovoJustificar()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                        End Try

                    Else

                        status = False
                        radioInativo.Checked = False And radioAtivo.Checked = True

                    End If

                End If

            End If

        End If

    End Sub

#End Region

#Region "FOTO"

    Private Sub botInserirFoto_Click(sender As System.Object, e As System.EventArgs) Handles botInserirFoto.Click

        Try
            Dim dlgImage As FileDialog = New OpenFileDialog()
            Dim caminho As String = ""

            If dlgImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
                caminho = dlgImage.FileName
                photoFoto.ImageLocation = caminho
            End If

            If Not photoFoto.ImageLocation Is Nothing Then
                Dim infoImg As New FileInfo(photoFoto.ImageLocation)
                Dim tamanho As Long = infoImg.Length
                Dim arqStream As New FileStream(photoFoto.ImageLocation, FileMode.Open, FileAccess.Read)
                FOTO = New Byte(Convert.ToInt32(tamanho - 1)) {}
                arqStream.Read(FOTO, 0, tamanho)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#End Region

#Region "CALIBRAÇÕES"

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridCalibracoes.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Calibrações", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

        End If

    End Sub

#End Region

#End Region

#Region "HISTORICO"



#End Region

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
                                    idInstrumentos, _
                                    Tela, _
                                    descricao, _
                                    ANEXO, _
                                    tipo) Then
                    MessageBox.Show("Anexos salvos com sucesso", "ISO é Fácil", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Status
                    barra1.Value = 100
                    lblStatus1.Text = "Concluido com sucesso!"

                    'carrega Lista
                    carregaListaAnexos(idInstrumentos)
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

End Class
