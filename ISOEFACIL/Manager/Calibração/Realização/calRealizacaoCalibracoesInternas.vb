Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.calRealizarCalibracoes
Public Class calRealizacaoCalibracoesInternas

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Public idInterno As String
    Public ResultLaudo As Integer
    Public idCalInt As String
    Public idplano As String
    Public strMes As String = String.Empty
    Public strSituacao As String = String.Empty
    Public strAno As String = String.Empty
    Public verif As Boolean = False
    Public SituacaoSit As Integer = 0

    'Anexos
    Private ANEXO() As Byte
    Public Modulo As String = "CALIBRACAO_INTERNA"
    Public Tela As String = "calRealizacaoCalibracoesInternas"

    'Pega Id Registro
    Public WriteOnly Property Interno() As String
        Set(ByVal value As String)
            Me.idInterno = value
        End Set
    End Property

    'Pega Id 
    Public WriteOnly Property CalInterno() As String
        Set(ByVal value As String)
            Me.idCalInt = value
        End Set
    End Property

    'Pega Id 
    Public WriteOnly Property Plano() As String
        Set(ByVal value As String)
            Me.idplano = value
        End Set
    End Property
    Public WriteOnly Property Mes() As String
        Set(ByVal value As String)
            Me.strMes = value
        End Set
    End Property
    Public WriteOnly Property Situacao() As String
        Set(ByVal value As String)
            Me.strSituacao = value
        End Set
    End Property
    Public WriteOnly Property Ano() As String
        Set(ByVal value As String)
            Me.strAno = value
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
        'gridAnexos.AutoGenerateColumns = False
        'gridAnexos.DataSource = Manager.Util.getDataTable(sql)

        Try

            For Each dr As DataRow In dt.Rows

                ' coluna especifica
                If dr("TIPO") = "doc" Then
                    'gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(0))
                End If

                If dr("TIPO") = "ocx" Then
                    'gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(0))
                End If

                If dr("TIPO") = "xls" Then
                    'gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(1))
                End If

                If dr("TIPO") = "pdf" Then
                    'gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(2))
                End If

                If dr("TIPO") = "txt" Then
                    'gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(3))
                End If

                If dr("TIPO") = "ppt" Then
                    'gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(4))
                End If

                If dr("TIPO") = "out" Then
                    'gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(5))
                End If

                i += 1

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "CARREGA LISTA MEDICAO"

    Public Sub carregaListaMedicao(ByVal id As Integer)

        'Monta Lista de Risco do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_REALIZAR_INTERNA_MEDICAO WHERE ID_INTERNA = {0}", id)
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridMedicao.AutoGenerateColumns = False

        'Cria a tabela
        gridMedicao.DataSource = dt

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

#Region "PADRAO INTERNO"

    Sub CarregaPadraoInterno()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT ID_CALIBRACOES_INSTRUMENTOS, NOME FROM CALIBRACOES_INSTRUMENTOS WHERE TIPO_USO = 2")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboPadraoInt.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboPadraoInt.DataSource = dtb
        comboPadraoInt.DisplayMember = "NOME"
        comboPadraoInt.ValueMember = "ID_CALIBRACOES_INSTRUMENTOS"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub calRealizarInterna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaResp()
        CarregaPadraoInterno()
        'Cor do texto
        txtObs.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

    Private Sub comboResultadoFinal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboResultadoFinal.SelectedIndexChanged

        If comboResultadoFinal.SelectedIndex = 0 Then
            ResultLaudo = 1
        ElseIf comboResultadoFinal.SelectedIndex = 1 Then
            ResultLaudo = 2
        ElseIf comboResultadoFinal.SelectedIndex = 2 Then
            ResultLaudo = 3
        End If

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoCalInterno(ByVal id As Integer, ByVal mes As String, ByVal sit As String)

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_PLANO_INTERNA WHERE PLANO={0} AND MES='{1}' AND SITUACAO='{2}'", id, mes, sit)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read
                Me.txtInstrumento.Text = dr("NOME").ToString
                Me.txtIdentificacao.Text = dr("IDENTIFICACAO").ToString
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Cadastrar Novo
        isEdit = False
        Me.Show()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarCalibracaoInterna(ByVal id As Integer)

        'Editar
        isEdit = True

        'Carrega Combos
        CarregaResp()
        CarregaPadraoInterno()
        carregaListaMedicao(id)
        carregaListaAnexos(id)

        Dim sql1 As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_PLANO_INTERNA WHERE ID = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr1 As SqlDataReader = Manager.Util.getDataReader(sql1)

            While dr1.Read
                Me.txtInstrumento.Text = dr1("NOME").ToString
                Me.txtIdentificacao.Text = dr1("IDENTIFICACAO").ToString
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM CALIBRACOES_REALIZAR_INTERNA WHERE ID_CALIBRACOES_REALIZAR = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Interno = dr("ID_CALIBRACOES_REALIZAR_INTERNA").ToString
                Me.comboPadraoInt.SelectedValue = dr("PADRAO_INTERNO").ToString
                If dr("RESULTADO_FINAL") = 1 Then
                    comboResultadoFinal.SelectedItem = Opt1
                ElseIf dr("RESULTADO_FINAL") = 2 Then
                    comboResultadoFinal.SelectedItem = Opt2
                ElseIf dr("RESULTADO_FINAL") = 3 Then
                    comboResultadoFinal.SelectedItem = Opt3
                End If
                Me.txtObs.Text = dr("OBS").ToString
                Me.dateData.Text = dr("DATA").ToString
                Me.dateValidade.Text = dr("VALIDADE").ToString
                Me.comboResp.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.txtLaudo.Text = dr("LAUDO").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs)

        Dim id As Integer = 0

        If gridMedicao.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Medição", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            'Passagem de parametros
            Try

                id = gridMedicao(gridMedicao.RowSel, 1)
                Interno = id
                EditarCalibracaoInterna(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "BOTOES"

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim interno As New interno
        Dim realizar As New realizar

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            VerificarCalibracaoInterna()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If interno.Update(idInterno, _
                                      idCalInt, _
                                      comboResp.SelectedValue, _
                                      comboPadraoInt.SelectedValue, _
                                      ResultLaudo, _
                                      txtObs.Text, _
                                      dateData.Value, _
                                      dateValidade.Value, _
                                      txtLaudo.Text) Then
                        'Atualizando Grid Realizar com dados de Data e Validade
                        realizar.Update(idInterno, _
                                        dateData.Value, _
                                        dateValidade.Value)
                        'SITUACAO - Calibrado
                        SituacaoSit = 1
                        'Atualizando situação do Instrumento para Calibrado
                        realizar.UpdateSit(idCalInt, _
                                           SituacaoSit)
                        'Atualizar Grid Medição
                        carregaListaMedicao(idCalInt)
                        calRealizarCalibracoes.carregaListaExternaAno(strAno)
                        MessageBox.Show("Dados de Calibração Interna atualizados com sucesso", "Calibração Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            VerificarCalibracaoInterna()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If interno.Add(idCalInt, _
                                   comboResp.SelectedValue, _
                                   comboPadraoInt.SelectedValue, _
                                   ResultLaudo, _
                                   txtObs.Text, _
                                   dateData.Value, _
                                   dateValidade.Value, _
                                   txtLaudo.Text) Then
                        'Atualizando Grids Realizar e Plano para Realizado
                        AtualizarStatus()
                        'Atualizando Grid Realizar com dados de Data e Validade
                        realizar.Update(idCalInt, _
                                        dateData.Value, _
                                        dateValidade.Value)
                        'SITUACAO - Calibrado
                        SituacaoSit = 1
                        'Atualizando situação do Instrumento para Calibrado
                        realizar.UpdateSit(idCalInt, _
                                           SituacaoSit)
                        'Atualizar Grid Medição
                        carregaListaMedicao(idCalInt)
                        'Atualizar Grid Anexos
                        carregaListaAnexos(idCalInt)
                        calRealizarCalibracoes.carregaListaInternaAno(strAno)
                        isEdit = True
                        MessageBox.Show("Calibração Interna realizada com sucesso", "Calibração Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub VerificarCalibracaoInterna()
        verif = False

        'Tratamento de erro Padrão Interno
        If comboPadraoInt.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Padrão Interno Obrigatório", "Calibração Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboPadraoInt.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Resultado Final
        If comboResultadoFinal.Text.ToString = String.Empty Then
            MessageBox.Show("Campo Resultado Final Obrigatório", "Calibração Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResultadoFinal.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data
        If dateData.Text = "" Then
            MessageBox.Show("Campo Data Obrigatório", "Calibração Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateData.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Validade
        If dateValidade.Text = "" Then
            MessageBox.Show("Campo Validade Obrigatório", "Calibração Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateValidade.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Responsável
        If comboResp.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável Obrigatório", "Calibração Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResp.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Laudo
        If txtLaudo.Text = "" Then
            MessageBox.Show("Campo Laudo Obrigatório", "Calibração Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtLaudo.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

    Public Sub AtualizarStatus()

        Dim classe As New externo
        Dim mes As String = strMes
        Dim situacao As String = strSituacao

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_PLANO_INTERNO WHERE PLANO={0} AND MES='{1}' AND SITUACAO='{2}'", idplano, strMes, strSituacao)
        classe.UpdateRealizacaoStatus(idplano, strMes, strSituacao)

        'Mes
        Select Case mes
            Case "Janeiro"
                mes = "JAN"
            Case "Fevereiro"
                mes = "FEV"
            Case "Março"
                mes = "MAR"
            Case "Abril"
                mes = "ABR"
            Case "Maio"
                mes = "MAI"
            Case "Junho"
                mes = "JUN"
            Case "Julho"
                mes = "JUL"
            Case "Agosto"
                mes = "AGO"
            Case "Setembro"
                mes = "JAN"
            Case "Outubro"
                mes = "OUT"
            Case "Novembro"
                mes = "NOV"
            Case "Dezembro"
                mes = "DEZ"
            Case Else

        End Select
        'Situacao
        Select Case situacao
            Case "Programada"
                situacao = 1
            Case "Realizada"
                situacao = 2
            Case "Cancelada"
                situacao = 3
            Case "Reprogramada"
                situacao = 4
            Case "Atrasada"
                situacao = 5
            Case Else

        End Select

        Dim sql2 As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_INSTRUMENTOS_PLANO_ANUAL WHERE ID = {0} AND {1} = {2}", idplano, mes, situacao)
        classe.UpdatePlanoStatus(idplano, mes)

    End Sub

#End Region

#Region "ADICIONAR/REMOVER"

    Private Sub botAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAdd.Click

        'Novo 
        Dim frm As New calResultadosObtidos
        Dim id As Integer = 0

        'Delegate para instancia do grid
        AddHandler frm.OnDataChange, AddressOf carregaListaMedicao

        'Passagem de parametros
        Try
            id = idCalInt
            frm.idInterno = id
            frm.NovaMedicao()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub botRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRemove.Click

        If gridMedicao.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Medição", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim medicao As New medicao

            'Excluir a Medicao
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Plano de Projeto - Saídas", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    medicao.Delete(gridMedicao(gridMedicao.RowSel, 1))
                    carregaListaMedicao(idCalInt)
                    MessageBox.Show("Medição excluída com sucesso", "Medição", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

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
                                    idCalInt, _
                                    Tela, _
                                    descricao, _
                                    ANEXO, _
                                    tipo) Then
                    MessageBox.Show("Anexos salvos com sucesso", "ISO é Fácil", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Status
                    barra1.Value = 100
                    lblStatus1.Text = "Concluido com sucesso!"

                    'carrega Lista
                    carregaListaAnexos(idCalInt)
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
