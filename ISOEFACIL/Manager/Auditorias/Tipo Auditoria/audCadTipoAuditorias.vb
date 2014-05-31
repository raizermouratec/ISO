Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.audListaTipoAuditorias
Public Class audCadTipoAuditorias

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Public idTipoAuditorias As String
    Public verif As Boolean = False

    'Anexos
    Private ANEXO() As Byte
    Public Modulo As String = "AUDITORIAS"
    Public Tela As String = "audCadTipoAuditorias"

    'Pega Id 
    Public WriteOnly Property Auditoria() As String
        Set(ByVal value As String)
            Me.idTipoAuditorias = value
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

#Region "TIPO"

    Sub CarregaTipoAuditorias()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_NORMAS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboTipoAud.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboTipoAud.DataSource = dtb
        comboTipoAud.DisplayMember = "NOME"
        comboTipoAud.ValueMember = "ID"
    End Sub

#End Region

#Region "RESPONSAVEL"

    Sub CarregaResponsavel()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboResponsavelCadastro.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboResponsavelCadastro.DataSource = dtb
        comboResponsavelCadastro.DisplayMember = "COLABORADOR"
        comboResponsavelCadastro.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub audNovoCadTipoAud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabCadastro.Show()
        'POPULA COMBO
        CarregaTipoAuditorias()
        CarregaResponsavel()
        carregaListaAnexos(idTipoAuditorias)

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoTipoAuditorias()
        'Cadastrar Novo
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarAuditorias(ByVal id As Integer)

        'habilita tab
        TabAnexos.Enabled = True

        'Editar
        isEdit = True

        'Muda o Label do botão Incluir
        botSalvar.Width = 80
        botSalvar.Text = "Atualizar"

        'Carrega Combos
        CarregaTipoAuditorias()
        CarregaResponsavel()
        carregaListaAnexos(id)

        'Seleciona pelo Id
        Dim sql As String = String.Format("SELECT * FROM AUDITORIAS_TIPO WHERE ID_AUDITORIAS_TIPO = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.comboTipoAud.SelectedValue = dr("ID").ToString
                If dr("ID_TIPO_VERIFICACAO") = 1 Then
                    radioAtendeSN.Checked = True
                ElseIf dr("ID_TIPO_VERIFICACAO") = 2 Then
                    radioAtendeAPN.Checked = True
                ElseIf dr("ID_TIPO_VERIFICACAO") = 3 Then
                    radioPorcento.Checked = True
                ElseIf dr("ID_TIPO_VERIFICACAO") = 4 Then
                    radioNota.Checked = True
                ElseIf dr("ID_TIPO_VERIFICACAO") = 5 Then
                    radioDados.Checked = True
                ElseIf dr("ID_TIPO_VERIFICACAO") = 6 Then
                    radioTexto.Checked = True
                End If

                If dr("EVIDENCIA") = True Then
                    radioSim2.Checked = True
                ElseIf dr("EVIDENCIA") = False Then
                    radioNao2.Checked = True
                End If

                If dr("FORMATO") = True Then
                    radioRetrato.Checked = True
                ElseIf dr("FORMATO") = False Then
                    radioPaisagem.Checked = True
                End If
                Me.comboResponsavelCadastro.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.dateCadastro.Value = dr("DATA_CADASTRO").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

#End Region

#Region "BOTÕES"

#Region "NOVO TIPO NO COMBO"

    Private Sub botaddNovoTipo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles botaddNovoTipo.Click

        'HABILITA CAMPOS PARA ADICIONAR
        botNovoTipo.Visibility = C1.Win.C1InputPanel.Visibility.Visible
        txtTipoNovo.Visibility = C1.Win.C1InputPanel.Visibility.Visible
        txtTipoNovo.Text = ""
    End Sub

#End Region

#Region "ADD NOVO TIPO DE AUDITORIAS"

    Private Sub botNovoTipo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles botNovoTipo.Click

        'Seta a Classe
        Dim tipoAdd As New TipoAuditorias

        'Verificar campo obrigatório
        checar()
        'Checando se campos obrigatórios estão OK
        If verif = False Then
            'Salvar
            Try
                If tipoAdd.AddTp(txtTipoNovo.Text) Then
                    MessageBox.Show("Novo Tipo inserido com sucesso", "Tipo de Auditoria", Windows.Forms.MessageBoxButtons.OKCancel, Windows.Forms.MessageBoxIcon.Information)
                    'Combo recebe dados do Campo de Inserção
                    comboTipoAud.Text = txtTipoNovo.Text
                    'Esconder Campo de Inserção
                    botNovoTipo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                    txtTipoNovo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                    'Carrega Combo Tipo Auditorias 
                    CarregaTipoAuditorias()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        Else
            Exit Sub
        End If

    End Sub

    Sub checar()

        'Tratamento de erro Tipo de Auditoria
        If txtTipoNovo.Text = Nothing Then
            MessageBox.Show("Campo txtTipoNovo Obrigatório", "Tipo de Auditoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTipoNovo.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim tipoAuditorias As New TipoAuditorias

        Dim zero As Integer = 0

        'Verificando valor de Verificação
        Dim verificacao As Integer
        If radioAtendeSN.Checked = True Then
            verificacao = 1
        End If
        If radioAtendeAPN.Checked = True Then
            verificacao = 2
        End If
        If radioPorcento.Checked = True Then
            verificacao = 3
        End If
        If radioNota.Checked = True Then
            verificacao = 4
        End If
        If radioDados.Checked = True Then
            verificacao = 5
        End If
        If radioTexto.Checked = True Then
            verificacao = 6
        End If

        'Verificando valor de Evidência
        Dim evidencia As Boolean
        If radioSim2.Checked = True Then
            evidencia = True
        Else
            evidencia = False
        End If

        'Verificando valor de Formato
        Dim formato As Boolean
        If radioRetrato.Checked = True Then
            formato = True
        Else
            formato = False
        End If

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If tipoAuditorias.Update(idTipoAuditorias, _
                                             comboTipoAud.SelectedValue, _
                                             verificacao, _
                                             comboResponsavelCadastro.SelectedValue, _
                                             evidencia, _
                                             formato, _
                                             dateCadastro.Value) Then
                        MessageBox.Show("Dados do Tipo de Auditoria salvos com sucesso", "Tipo de Auditoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        audListaTipoAuditorias.carregaAuditorias()
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
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If tipoAuditorias.Add(comboTipoAud.SelectedValue, _
                              verificacao, _
                              comboResponsavelCadastro.SelectedValue, _
                              evidencia, _
                              formato, _
                              dateCadastro.Value) Then
                        MessageBox.Show("Dados do Tipo de Auditoria salvos com sucesso", "Tipo de Auditoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        audListaTipoAuditorias.carregaAuditorias()
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

#Region "VERIFICAR CAMPOS"

    Sub Verificar()
        verif = False

        'Tratamento de erro Tipo da Auditoria
        If comboTipoAud.Text = "" Then
            MessageBox.Show("Campo Tipo de Auditoria Obrigatório", "Tipo de Auditoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboTipoAud.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Verificação
        If radioAtendeSN.Checked = False And radioAtendeAPN.Checked = False And radioPorcento.Checked = False And radioNota.Checked = False And radioDados.Checked = False And radioTexto.Checked = False Then
            MessageBox.Show("Campo Verificação Obrigatório", "Tipo de Auditoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Evidência
        If radioSim2.Checked = False And radioNao2.Checked = False Then
            MessageBox.Show("Campo Evidência Obrigatório", "Tipo de Auditoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Formato
        If radioRetrato.Checked = False And radioPaisagem.Checked = False Then
            MessageBox.Show("Campo Formato Obrigatório", "Tipo de Auditoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data do Cadastro
        If dateCadastro.Text = "" Then
            MessageBox.Show("Campo Data do Cadastro Obrigatório", "Tipo de Auditoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateCadastro.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Responsável pelo Cadastro
        If comboResponsavelCadastro.Text = "" Then
            MessageBox.Show("Campo Responsável pelo Cadastro Obrigatório", "Tipo de Auditoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResponsavelCadastro.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

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
                                    idTipoAuditorias, _
                                    Tela, _
                                    descricao, _
                                    ANEXO, _
                                    tipo) Then
                    MessageBox.Show("Anexos salvos com sucesso", "ISO é Fácil", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Status
                    barra.Value = 100
                    lblStatus.Text = "Concluido com sucesso!"

                    'carrega Lista
                    carregaListaAnexos(idTipoAuditorias)
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

End Class
