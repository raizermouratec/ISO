Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.mgListaControleManual
Public Class mgCadControleManual

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Public verif As Boolean = False
    Public idConfigDoc As Integer = 0
    Public Situacao As Integer
    Public idControleManuais As String = String.Empty
    Public idComplementares As String = String.Empty

    'Pega Id Melhorias
    Public WriteOnly Property ControleManuais() As String
        Set(ByVal value As String)
            Me.idControleManuais = value
        End Set
    End Property

#End Region

#Region "CARREGA LISTA NORMAS COMPLEMENTARES"

    Sub CarregaNormasComp()

        'Caso não for selecionado nada
        Dim id As Integer = 0
        If comboResp.SelectedValue.ToString = String.Empty Then

        Else
            id = comboNormaBase.SelectedValue

            'Carrega Lista Normas
            gridNormasComplementares.AutoGenerateColumns = False
            gridNormasComplementares.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_NORMAS_COMPLEMENTARES WHERE ID != " & id)
        End If

    End Sub

#Region "GRID CHECK"

    Private Sub gridNormasComplementares_Click(sender As System.Object, e As System.EventArgs) Handles gridNormasComplementares.Click

        With gridNormasComplementares

            If .ColSel = 2 Then

                Dim ControleManuais As New ControleManuais
                Dim nome As String = String.Empty
                Dim Check As Boolean

                Try
                    If .Item(.RowSel, .ColSel) = True Then
                        .Item(.RowSel, .ColSel) = False
                        nome = gridNormasComplementares(gridNormasComplementares.RowSel, 3)
                        ControleManuais.DeleteComp(nome)
                    Else
                        .Item(.RowSel, .ColSel) = True
                        Check = gridNormasComplementares(gridNormasComplementares.RowSel, 2)
                        nome = gridNormasComplementares(gridNormasComplementares.RowSel, 3)
                        ControleManuais.AddComp(nome, Check)
                    End If
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try

            End If

        End With

    End Sub

    Public Sub LimpaAllChecks()
        With gridNormasComplementares
            .Item(.RowSel, .ColSel) = False
        End With
    End Sub

    Public Sub salvar()

        'Dim i As Integer
        'Dim chkbx As CheckBoxList
        'chkbx = CType(Form1.FindControl("CheckBoxList1"), CheckBoxList)
        'For i = 0 To chkbx.Items.Count - 1
        '    If chkbx.Items(i).Selected Then
        '    classe.Add("@CategoryID", chkbx.Items(i).Value);
        '    End If
        'Next

    End Sub

#End Region

#End Region

#Region "POPULA COMBOS"

#Region "NORMA BASE"

    Sub CarregaNorma()

        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_NORMAS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboNormaBase.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboNormaBase.DataSource = dtb
        comboNormaBase.DisplayMember = "NOME"
        comboNormaBase.ValueMember = "ID"

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

#End Region

#Region "LOAD"

    Private Sub mgCadManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaResp()
        CarregaNorma()
    End Sub

    Private Sub checkComplementar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkComplementar.CheckedChanged

        If comboNormaBase.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Favor selecionar Norma Base", "Controle de Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            checkComplementar.Checked = False
            Exit Sub
        Else
            'Caso Normas Complementares for marcado aparece Grid NormasComplementares
            If checkComplementar.Checked = True Then
                Dim id As Integer = 0

                'Carrega Lista Normas
                id = comboNormaBase.SelectedValue

                'Carrega Lista Normas
                gridNormasComplementares.AutoGenerateColumns = False
                gridNormasComplementares.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_NORMAS_COMPLEMENTARES WHERE ID != " & id)
                'Mostra Grid
                gridNormasComplementares.Visible = True
            Else
                'Oculta Grid
                gridNormasComplementares.Visible = False
            End If

        End If

    End Sub

    Private Sub comboNormaBase_ChangeCommitted(sender As Object, e As System.EventArgs) Handles comboNormaBase.ChangeCommitted

        'CarregaNormasComp

    End Sub

    Private Sub comboNormaBase_LostFocus(sender As Object, e As System.EventArgs) Handles comboNormaBase.LostFocus

        'CarregaNormasComp

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoCadManual()

        Dim dr As SqlDataReader
        dr = Manager.Util.getDataReader("SELECT * FROM DOCUMENTO_CONFIG_TP_DOCUMENTO WHERE ID_DOCUMENTO_CONFIG_TP_DOCUMENTO = 1")

        While dr.Read
            idConfigDoc = dr("ID_DOCUMENTO_CONFIG_TP_DOCUMENTO").ToString
            txtTipo.Text = dr("NOME").ToString
        End While

        txtRevisao.Text = "00"

        Situacao = 0
        If Situacao = 0 Then
            txtSituacao.Text = "Em Desenvolvimento"
        ElseIf Situacao = 1 Then
            txtSituacao.Text = "Aprovado"
        ElseIf Situacao = 2 Then
            txtSituacao.Text = "Em Revisão"
        ElseIf Situacao = 3 Then
            txtSituacao.Text = "Cancelado"
        End If

        'Editar recebe Falso
        isEdit = False

        'Mostrar 
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarControleManuais(ByVal id As Integer)

        'Editando Manual 
        isEdit = True

        'Muda o Label do botão Incluir
        botSalvar.Width = 80
        botSalvar.Text = "Atualizar"

        'Carregando Combos
        CarregaResp()
        CarregaNorma()

        'Seleciona pelo Id
        Dim sql As String = String.Format("SELECT * FROM MANUAL_CONTROLE WHERE ID_MANUAL_CONTROLE = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Dim sql2 As String = String.Format("SELECT * FROM DOCUMENTO_CONFIG_TP_DOCUMENTO WHERE ID_DOCUMENTO_CONFIG_TP_DOCUMENTO = {0}", id)
                Dim dr2 As SqlDataReader = Manager.Util.getDataReader(sql2)

                While dr2.Read
                    idConfigDoc = dr2("ID_DOCUMENTO_CONFIG_TP_DOCUMENTO").ToString
                    txtTipo.Text = dr2("NOME").ToString
                End While

                Me.comboNormaBase.SelectedValue = dr("ID_NORMAS").ToString
                Me.comboResp.SelectedValue = dr("ID_COLABORADORES").ToString

                If dr("CHECK_NORMAS_COMPLEMENTARES") = True Then
                    checkComplementar.Checked = True

                    Dim sql3 As String = String.Format("SELECT * FROM NORMAS_COMPLEMENTARES_CHECK WHERE ID_MANUAL_CONTROLE = {0}", id)
                    Dim dr3 As SqlDataReader = Manager.Util.getDataReader(sql3)
                    Dim nome As String = String.Empty

                    'While dr3.Read
                    '    nome = dr3("NOME").ToString
                    'End While

                    Dim dt2 As New DataTable
                    Dim sql4 As String = String.Format("SELECT * FROM VW_NORMAS_COMPLEMENTARES")

                    dt2 = Manager.Util.getDataTableById(sql4)
                    gridNormasComplementares.DataSource = dt2

                    Dim i As Integer = 1


                    While dr3.Read
                        nome = dr3("NOME").ToString
                        For Each dr1 As DataRow In dt2.Rows
                            If dr1("NOME").ToString = nome Then
                                gridNormasComplementares.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
                                gridNormasComplementares(gridNormasComplementares.ColSel, 2) = True
                                gridNormasComplementares.Update()

                                'gridNormasComplementares(gridNormasComplementares.ColSel, 2) = True
                            End If
                            i += 1
                        Next
                    End While

                    'If dr1("NOME").ToString = nome Then
                    '    gridNormasComplementares(gridNormasComplementares.ColSel, 2) = True
                    'End If
                    'i += 1

                Else
                    checkComplementar.Checked = False
                End If

                Me.txtCodigo.Text = dr("CODIGO").ToString
                Me.txtTítulo.Text = dr("TITULO").ToString

                If dr("REVISAO") < 9 Then
                    txtRevisao.Text = "0" & dr("REVISAO")
                Else
                    txtRevisao.Text = dr("REVISAO")
                End If

                If dr("SITUACAO") = 0 Then
                    'EM DESENVOLVIMENTO
                    Me.txtSituacao.Text = "Em Desenvolvimento"
                ElseIf dr("SITUACAO") = 1 Then
                    'CONCLUÍDO
                    Me.txtSituacao.Text = "Aprovado"
                ElseIf dr("SITUACAO") = 2 Then
                    'EM REVISÃO
                    Me.txtSituacao.Text = "Em Revisão"
                ElseIf dr("SITUACAO") = 3 Then
                    'CANCELADO
                    Me.txtSituacao.Text = "Cancelado"
                End If
                Me.dateData.Value = dr("DATA").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

#End Region

#Region "BOTOES"

#Region "SALVAR"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim classeDoc As New ControleManuais
        Dim ControleManuais As New ControleManuais

        'Verificando valor de Normas Complementares
        Dim Check As Boolean
        If checkComplementar.Checked = True Then
            Check = True
        Else
            Check = False
        End If

        'Verificar valor de Situação
        Dim SituacaoDoc As String = String.Empty
        If Situacao = 0 Then
            txtSituacao.Text = "Em Desenvolvimento"
            SituacaoDoc = "Em Desenvolvimento"
        ElseIf Situacao = 1 Then
            txtSituacao.Text = "Aprovado"
            SituacaoDoc = "Aprovado"
        ElseIf Situacao = 2 Then
            txtSituacao.Text = "Em Revisão"
            SituacaoDoc = "Em Revisão"
        ElseIf Situacao = 3 Then
            txtSituacao.Text = "Cancelado"
            SituacaoDoc = "Cancelado"
        End If

        'Configuração para Controle de Documento
        Dim ConfigDoc As Integer = 1
        'Area 
        Dim Area As Integer = 0
        '[E]laboração – [C]onsenso – [A]provação - [P]ublicação
        Dim _E As Integer = 0
        Dim _C As Integer = 0
        Dim _A As Integer = 0
        Dim _P As Integer = 0
        'Formato do Documento
        Dim format As Integer = 0
        'Arquivo
        Dim arquivo As String = String.Empty
        arquivo = " - "

        'Inicio Atualizar/Salvar
        If isEdit Then

            'If MessageBox.Show("Deseja alterar a Revisão?", "Controle de Manual", Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            '    Dim rev As Integer = 0
            '    Dim dr3 As SqlDataReader
            '    Try
            '        dr3 = Manager.Util.getDataReader("SELECT REV FROM VW_LISTAGEM_MANUAL_CONTROLE WHERE ID = " & idControleManuais)

            '        While dr3.Read
            '            rev = dr3("REV").ToString
            '            If rev >= 0 Then
            '                txtRevisao.Text = rev + 1
            '                txtRevisao.Text = "0" & txtRevisao.Text.ToString
            '            Else
            '                txtRevisao.Text = txtRevisao.Text.ToString
            '            End If
            '        End While
            '    Catch ex As Exception
            '        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            '    End Try

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If ControleManuais.UpdateCreate(idControleManuais, _
                                                    idConfigDoc,
                                                    comboNormaBase.SelectedValue,
                                                    comboResp.SelectedValue,
                                                    Check,
                                                    txtCodigo.Text,
                                                    txtTítulo.Text,
                                                    txtRevisao.Text,
                                                    Situacao,
                                                    dateData.Value) Then

                        With gridNormasComplementares

                            If .ColSel = 2 Then

                                Dim nome As String = String.Empty
                                Dim CheckGRID As Boolean

                                Try
                                    If .Item(.RowSel, .ColSel) = True Then
                                        .Item(.RowSel, .ColSel) = False
                                        nome = gridNormasComplementares(gridNormasComplementares.ColSel, 3)
                                        ControleManuais.DeleteComp(nome)
                                    Else
                                        .Item(.RowSel, .ColSel) = True
                                        CheckGRID = gridNormasComplementares(gridNormasComplementares.ColSel, 2)
                                        nome = gridNormasComplementares(gridNormasComplementares.ColSel, 3)
                                        ControleManuais.AddComp(nome, CheckGRID)
                                    End If
                                Catch ex As Exception
                                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                                End Try

                            End If

                        End With

                        ControleManuais.UpdateComp(idControleManuais)

                        MessageBox.Show("Dados do Manual de Gestão atualizados com sucesso", "Controle de Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mgListaControleManual.CarregaLista()
                        Me.Close()
                    End If


                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            'Else

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    idControleManuais = ControleManuais.AddCreate(idConfigDoc,
                                                                  comboNormaBase.SelectedValue,
                                                                  comboResp.SelectedValue,
                                                                  Check,
                                                                  txtCodigo.Text,
                                                                  txtTítulo.Text,
                                                                  txtRevisao.Text,
                                                                  Situacao,
                                                                  dateData.Value)
                    ControleManuais.UpdateComp(idControleManuais)


                    classeDoc.AddCdoc(txtCodigo.Text,
                                      ConfigDoc,
                                      txtTítulo.Text,
                                      Area,
                                      txtRevisao.Text,
                                      SituacaoDoc,
                                      _E,
                                      _C,
                                      _A,
                                      _P,
                                      format,
                                      False,
                                      arquivo)

                    If idControleManuais <> String.Empty Then
                        mgListaControleManual.CarregaLista()
                        MessageBox.Show("Manual de Gestão salvos com sucesso", "Controle de Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub Verificar()
        verif = False

        'Tratamento de erro Título
        If txtTítulo.Text = "" Then
            MessageBox.Show("Campo Título Obrigatórido", "Controle de Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTítulo.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Norma Base
        If comboNormaBase.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Norma Base Obrigatórido", "Controle de Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboNormaBase.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data
        If dateData.Text = "" Then
            MessageBox.Show("Campo Data Obrigatórido", "Controle de Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateData.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Responsável
        If comboResp.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsável Obrigatórido", "Controle de Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResp.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#End Region
    
End Class
