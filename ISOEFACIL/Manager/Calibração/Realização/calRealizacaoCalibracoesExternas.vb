Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.calRealizarCalibracoes
Public Class calRealizacaoCalibracoesExternas

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Public idExterno As String
    Public ResultLaudo As Integer
    Public idCalExt As String
    Public idplano As String
    Public strMes As String = String.Empty
    Public strSituacao As String = String.Empty
    Public strAno As String = String.Empty
    Public verif As Boolean = False
    Public SituacaoSit As Integer = 0

    'Anexos
    Private ANEXO() As Byte
    Public Modulo As String = "CALIBRACAO_EXTERNA"
    Public Tela As String = "calRealizacaoCalibracoesExternas"

    'Pega Id Registro
    Public WriteOnly Property Externo() As String
        Set(ByVal value As String)
            Me.idExterno = value
        End Set
    End Property

    'Pega Id 
    Public WriteOnly Property CalExterno() As String
        Set(ByVal value As String)
            Me.idCalExt = value
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

    Private Sub calRealizarExterno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cor do texto
        txtObs.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

    Private Sub comboLaudoResult_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboLaudoResult.SelectedIndexChanged
        If comboLaudoResult.SelectedIndex = 0 Then
            ResultLaudo = 1
        ElseIf comboLaudoResult.SelectedIndex = 1 Then
            ResultLaudo = 2
        ElseIf comboLaudoResult.SelectedIndex = 2 Then
            ResultLaudo = 3
        End If
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoCalExterno(ByVal id As Integer, ByVal mes As String, ByVal sit As String)

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_PLANO_EXTERNA WHERE PLANO={0} AND MES='{1}' AND SITUACAO='{2}'", id, mes, sit)

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
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarCalibracaoExterna(ByVal id As Integer)

        'Editar
        isEdit = True

        'Carrega Combos
        carregaListaAnexos(id)

        Dim sql1 As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_PLANO_EXTERNA WHERE ID = {0}", id)

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
        Dim sql As String = String.Format("SELECT * FROM CALIBRACOES_REALIZAR_EXTERNA WHERE ID_CALIBRACOES_REALIZAR = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Externo = dr("ID_CALIBRACOES_REALIZAR_EXTERNA").ToString
                Me.txtOrgResp.Text = dr("ORGANISMO_RESPONSAVEL").ToString
                Me.txtLaudoEmitido.Text = dr("LAUDO_EMITIDO").ToString
                Me.txtObs.Text = dr("OBS").ToString
                Me.dateData.Text = dr("DATA").ToString
                Me.dateValidade.Text = dr("VALIDADE").ToString
                If dr("RESULTADO_LAUDO") = 1 Then
                    comboLaudoResult.SelectedItem = Op1
                ElseIf dr("RESULTADO_LAUDO") = 2 Then
                    comboLaudoResult.SelectedItem = Op2
                ElseIf dr("RESULTADO_LAUDO") = 3 Then
                    comboLaudoResult.SelectedItem = Op3
                End If
                Me.txtNlaudo.Text = dr("NUMERO_LAUDO").ToString
                Me.txtOrgRespRef.Text = dr("ORGANISMO_RESPONSAVEL_PADRAO").ToString
                Me.dateValidadeRef.Text = dr("VALIDADE_PADRAO").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.Show()

    End Sub

#End Region

#Region "BOTOES"

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim externo As New externo
        Dim realizar As New realizar

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            VerificarCalibracaoExterna()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If externo.Update(idExterno, _
                                      idCalExt, _
                                      txtOrgResp.Text, _
                                      txtLaudoEmitido.Text, _
                                      txtObs.Text, _
                                      dateData.Value, _
                                      dateValidade.Value, _
                                      ResultLaudo, _
                                      txtNlaudo.Text, _
                                      txtOrgRespRef.Text, _
                                      dateValidadeRef.Value) Then
                        'Atualizando Grid Realizar com dados de Data e Validade
                        realizar.Update(idExterno, _
                                        dateData.Value, _
                                        dateValidade.Value)
                        'SITUACAO - Calibrado
                        SituacaoSit = 1
                        'Atualizando situação do Instrumento para Calibrado
                        realizar.UpdateSit(idCalExt, _
                                           SituacaoSit)
                        'Atualizar Grid Medição
                        calRealizarCalibracoes.carregaListaExternaAno(strAno)
                        MessageBox.Show("Dados de Calibração Externa atualizados com sucesso", "Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        carregaListaAnexos(idCalExt)
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
            VerificarCalibracaoExterna()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If externo.Add(idCalExt, _
                                   txtOrgResp.Text, _
                                   txtLaudoEmitido.Text, _
                                   txtObs.Text, _
                                   dateData.Value, _
                                   dateValidade.Value, _
                                   ResultLaudo, _
                                   txtNlaudo.Text, _
                                   txtOrgRespRef.Text, _
                                   dateValidadeRef.Value) Then
                        'Atualizando Grid Realizar com dados de Data e Validade
                        AtualizarStatus()
                        realizar.Update(idCalExt, _
                                        dateData.Value, _
                                        dateValidade.Value)
                        'SITUACAO - Calibrado
                        SituacaoSit = 1
                        'Atualizando situação do Instrumento para Calibrado
                        realizar.UpdateSit(idCalExt, _
                                           SituacaoSit)
                        'Atualizar Grid Medição
                        calRealizarCalibracoes.carregaListaExternaAno(strAno)
                        MessageBox.Show("Calibração Externa realizada com sucesso", "Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        carregaListaAnexos(idCalExt)
                        isEdit = True
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

    Private Sub VerificarCalibracaoExterna()
        verif = False

        'Tratamento de erro Organismo Responsável
        If txtOrgResp.Text = "" Then
            MessageBox.Show("Campo Organismo Responsável Obrigatório", "Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtOrgResp.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Laudo Emitido
        If txtLaudoEmitido.Text = "" Then
            MessageBox.Show("Campo Laudo Emitido Obrigatório", "Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtLaudoEmitido.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data
        If dateData.Text = "" Then
            MessageBox.Show("Campo Data Obrigatório", "Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateData.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Validade
        If dateValidade.Text = "" Then
            MessageBox.Show("Campo Validade Obrigatório", "Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateValidade.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Resultado do Laudo
        If comboLaudoResult.Text.ToString = String.Empty Then
            MessageBox.Show("Campo Resultado do Laudo Obrigatório", "Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboLaudoResult.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

    Public Sub AtualizarStatus()

        Dim classe As New externo
        Dim mes As String = strMes
        Dim situacao As String = strSituacao

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_PLANO_EXTERNA WHERE PLANO={0} AND MES='{1}' AND SITUACAO='{2}'", idplano, strMes, strSituacao)
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
                                    idCalExt, _
                                    Tela, _
                                    descricao, _
                                    ANEXO, _
                                    tipo) Then
                    MessageBox.Show("Anexos salvos com sucesso", "ISO é Fácil", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Status
                    barra1.Value = 100
                    lblStatus1.Text = "Concluido com sucesso!"

                    'carrega Lista
                    carregaListaAnexos(idCalExt)
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
