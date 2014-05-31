Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.prodListaProdutos
Public Class prodCadProdutos

#Region "VARIAVEIS"

    'FOTO
    Private FOTO() As Byte
    'Variaveis usadas para edição de dados
    Private isEdit As Boolean = False
    Private isEditProduto As Boolean = False
    Public idproduto As String = String.Empty
    Dim Grupo As Integer
    Dim SubGrupo As Integer
    Public verif As Boolean = False

    'Anexos
    Private ANEXO() As Byte
    Public Modulo As String = "PRODUTOS"
    Public Tela As String = "prodCadProdutos"

    'Pega Id
    Public WriteOnly Property Produto() As String
        Set(ByVal value As String)
            Me.idproduto = value
        End Set
    End Property

#End Region

#Region "CARREGA LISTAS"

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

#Region "GRUPO"

    Sub CarregaClasseGrupo()

        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM PRODUTOS_GRUPO")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = ""

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboGrupos.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboGrupos.DataSource = dtb
        comboGrupos.DisplayMember = "NOME"
        comboGrupos.ValueMember = "ID_PRODUTOS_GRUPO"

    End Sub

#End Region

#Region "SUB-GRUPOS"

    Sub CarregaClasseSubGrupo()

        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM PRODUTOS_SUBGRUPO")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = ""

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboSubGrupos.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboSubGrupos.DataSource = dtb
        comboSubGrupos.DisplayMember = "NOME"
        comboSubGrupos.ValueMember = "ID_PRODUTOS_SUBGRUPO"

    End Sub

#End Region

#Region "CHAMA SUB-GRUPO POR GRUPO SELECIONADO"

    Private Sub comboGrupos_ChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If comboGrupos.SelectedValue.ToString = String.Empty Then
            Grupo = 0
        Else

            Dim id As Integer = 0

            Try

                If comboGrupos.ValueMember = "" Then
                    CarregaClasseGrupo()
                End If

                id = comboGrupos.SelectedValue
                ChamaSubGruposById(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub comboGrupos_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If comboGrupos.SelectedValue.ToString = String.Empty Then
            Grupo = 0
        Else

            Dim id As Integer = 0

            Try

                If comboGrupos.ValueMember = "" Then
                    CarregaClasseGrupo()
                End If

                id = comboGrupos.SelectedValue
                ChamaSubGruposById(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Public Sub ChamaSubGruposById(ByVal id As Integer)

        Dim sql As String = String.Format("SELECT * FROM PRODUTOS_SUBGRUPO SUB LEFT JOIN PRODUTOS_GRUPO GP ON GP.ID_PRODUTOS_GRUPO = SUB.ID_PRODUTOS_GRUPO WHERE GP.ID_PRODUTOS_GRUPO = '{0}'", id)

        Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

        Try

            While dr.Read
                comboSubGrupos.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
                comboSubGrupos.DataSource = Manager.Util.getDataTable(sql)
                comboSubGrupos.DisplayMember = "NOME"
                comboSubGrupos.ValueMember = "ID_PRODUTOS_SUBGRUPO"
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try


    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub prodCadastroProduto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TabCadastro.Show()
        tab1.Show()
        CarregaResp()
        CarregaClasseGrupo()
        CarregaClasseSubGrupo()
        carregaListaAnexos(idproduto)
        txtDescricao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtComposicao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtDesempenho.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtComponentes.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtOutros.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoProduto()

        'Cadastrar Novo
        isEdit = False
        TabAnexos.Enabled = False
        Me.Show()

    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarProduto(ByVal id As Integer)

        'Editar
        isEdit = True

        'Muda o Label do botão Incluir
        botSalvar.Width = 80
        botSalvar.Text = "Atualizar"

        'Tab Anexos liberada
        TabAnexos.Enabled = True

        'Carrega Combos
        CarregaResp()
        CarregaClasseGrupo()
        CarregaClasseSubGrupo()
        carregaListaAnexos(idproduto)
        tab1.Show()

        'Seleciona produto pelo Id
        Dim sql As String = String.Format("SELECT * FROM PRODUTOS WHERE ID_PRODUTOS = {0}", id)

        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtCodigo.Text = dr("CODIGO").ToString
                Me.txtNome.Text = dr("NOME").ToString
                Me.txtDescricao.Text = dr("DESCRICAO").ToString

                Dim bytePicData() As Byte = dr("FOTO")
                Dim PiCMemStream As New System.IO.MemoryStream(bytePicData)
                photoFoto.Image = Image.FromStream(PiCMemStream)

                If dr("ID_PRODUTOS_GRUPO") = 0 Then
                    Me.comboGrupos.Text = ""
                Else
                    Me.comboGrupos.SelectedValue = dr("ID_PRODUTOS_GRUPO").ToString
                End If
                If dr("ID_PRODUTOS_SUBGRUPO") = 0 Then
                    Me.comboSubGrupos.Text = ""
                Else
                    Me.comboGrupos.SelectedValue = dr("ID_PRODUTOS_SUBGRUPO").ToString
                End If
                Me.txtComposicao.Text = dr("COMPOSICAO").ToString
                Me.txtDesempenho.Text = dr("DESEMPENHO").ToString
                Me.txtComponentes.Text = dr("COMPONENTES").ToString
                Me.txtOutros.Text = dr("OUTROS").ToString
                Me.comboResp.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.dateData.Value = dr("DATA").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Formulario
        Me.ShowDialog()

    End Sub

#End Region

#Region "ABAS"

#Region "CADASTRO"

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim produto As New produto

        If comboGrupos.Text = "" Then
            Grupo = 0
        Else
            Grupo = comboGrupos.SelectedValue
        End If

        If comboSubGrupos.Text = "" Then
            SubGrupo = 0
        Else
            SubGrupo = comboSubGrupos.SelectedValue
        End If

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Com FOTO
            'Verificando se Tem FOTO
            If Not FOTO Is Nothing Then
                'Verificar campos obrigatórios
                VerificarProdutos()
                'Checando se campos obrigatórios estão OK
                If verif = False Then
                    Try
                        'Atualizar
                        If produto.Update(idproduto, _
                                          Grupo, _
                                          SubGrupo, _
                                          comboResp.SelectedValue, _
                                          txtCodigo.Text, _
                                          txtNome.Text, _
                                          txtDescricao.Text, _
                                          txtComposicao.Text, _
                                          txtDesempenho.Text, _
                                          txtComponentes.Text, _
                                          txtOutros.Text, _
                                          FOTO, _
                                          dateData.Value) Then
                            prodListaProdutos.CarregaProdutos()
                            MessageBox.Show("Dados do Produto atualizados com sucesso", "Produto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    End Try
                Else
                    Exit Sub
                End If
            Else
                'Sem FOTO
                'Verificar campos obrigatórios
                VerificarProdutos()
                'Checando se campos obrigatórios estão OK
                If verif = False Then
                    Try
                        'Atualizar
                        If produto.Update1(idproduto, _
                                 Grupo, _
                                 SubGrupo, _
                                 comboResp.SelectedValue, _
                                 txtCodigo.Text, _
                                 txtNome.Text, _
                                 txtDescricao.Text, _
                                 txtComposicao.Text, _
                                 txtDesempenho.Text, _
                                 txtComponentes.Text, _
                                 txtOutros.Text, _
                                 dateData.Value) Then
                            prodListaProdutos.CarregaProdutos()
                            MessageBox.Show("Dados do Produto atualizados com sucesso", "Produto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Muda o Label do botão Incluir
                            botSalvar.Width = 80
                            botSalvar.Text = "Atualizar"
                            isEdit = True
                            TabAnexos.Enabled = True
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
            VerificarProdutos()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    idproduto = produto.Add(Grupo, _
                                   SubGrupo, _
                                   comboResp.SelectedValue, _
                                   txtCodigo.Text, _
                                   txtNome.Text, _
                                   txtDescricao.Text, _
                                   txtComposicao.Text, _
                                   txtDesempenho.Text, _
                                   txtComponentes.Text, _
                                   txtOutros.Text, _
                                   FOTO, _
                                   dateData.Value)
                    If idproduto <> String.Empty Then
                        prodListaProdutos.CarregaProdutos()
                        MessageBox.Show("Novo produto incluído com sucesso", "Produto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Muda o Label do botão Incluir
                        botSalvar.Width = 80
                        botSalvar.Text = "Atualizar"
                        isEdit = True
                        TabAnexos.Enabled = True
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub VerificarProdutos()
        verif = False

        'Tratamento de erroNome
        If txtNome.Text = "" Then
            MessageBox.Show("Campo Nome Obrigatório", "Produto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNome.Focus()
            verif = True
            Exit Sub
        Else
        End If
        'Tratamento de erroResponsável
        If comboResp.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável Obrigatório", "Produto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResp.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erroData
        If dateData.Text = "" Then
            MessageBox.Show("Campo Data Obrigatório", "Produto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateData.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "FOTO"

    Private Sub botImagem_Click(sender As System.Object, e As System.EventArgs) Handles botImagem.Click

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
                                    idproduto, _
                                    Tela, _
                                    descricao, _
                                    ANEXO, _
                                    tipo) Then
                    MessageBox.Show("Anexos salvos com sucesso", "ISO é Fácil", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Status
                    barra1.Value = 100
                    lblStatus1.Text = "Concluido com sucesso!"

                    'carrega Lista
                    carregaListaAnexos(idproduto)
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
