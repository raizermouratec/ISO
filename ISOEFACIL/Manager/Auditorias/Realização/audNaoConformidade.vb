Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.audRealizacaoAuditorias
Public Class audNaoConformidade

#Region "VARIÁVEIS"

    Public idRealiza As String
    Public idNCapontadas As String
    Private isEdit As Boolean = False
    Public verif As Boolean = False

    'Pega Id
    Public WriteOnly Property Realiza() As String
        Set(ByVal value As String)
            Me.idRealiza = value
        End Set
    End Property

    'Pega Id
    Public WriteOnly Property NC_Apontadas() As String
        Set(ByVal value As String)
            Me.idNCapontadas = value
        End Set
    End Property

#End Region

#Region "POPULA COMBOS"

#Region "NÃO CONFORMIDADES"

    Sub CarregaNC()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT VW_LISTAGEM_MELHORIAS.ID_MELHORIAS, VW_LISTAGEM_MELHORIAS.NUMERO + '  -  ' + VW_LISTAGEM_MELHORIAS.TITULO AS NC FROM VW_LISTAGEM_MELHORIAS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NC") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboNaoConformidade.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboNaoConformidade.DataSource = dtb
        comboNaoConformidade.DisplayMember = "NC"
        comboNaoConformidade.ValueMember = "ID_MELHORIAS"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub audNaoConformidade_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaNC()
    End Sub

#End Region

#Region "BOTOES"

#Region "ADICIONAR"

    Private Sub botAdicionar_Click(sender As System.Object, e As System.EventArgs) Handles botAdicionar.Click

        If comboNaoConformidade.Text <> "" Then

            'Seta a Classe
            Dim realizacao As New realizacao

            'Inicio Atualizar/Salvar
            If isEdit Then

                'SELECT NUMERO AS NC, ITEM.NORMAS AS ITEM FROM MELHORIAS LEFT JOIN VW_ITEM_NORMA ITEM ON ITEM.ITEM_NORMA = ITEM.ITEM_NORMA
                'Verificar campos obrigatórios
                'Verificar()
                'Checando se campos obrigatórios estão OK
                'If verif = False Then
                '    Try
                '        'Atualizar
                '        If realizacao.Update(idAnaliseReunioes, _
                '                          comboResp.SelectedValue, _
                '                          txtReuniao.Text,
                '                          achou, _
                '                          dateReuniao.Value) Then
                '            MessageBox.Show("Dados de Reunião atualizados com sucesso", "Reunião", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                '            Me.Close()
                '        End If
                '    Catch ex As Exception
                '        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                '    End Try
                'Else
                '    Exit Sub
                'End If

            Else
                'Verificar campos obrigatórios
                'Verificar()
                'Checando se campos obrigatórios estão OK
                'If verif = False Then
                '    Try
                '        'Salvar
                '        If realizacao.AddRealizacao(idAuditoriasRealizar, _
                '                                    idAuditoriasPlano, _
                '                                    dateData.Value, _
                '                                    timeInicio.Text, _
                '                                    timeTérmino.Text, _
                '                                    comboAuditorLider.SelectedValue, _
                '                                    comboSegundoAuditor.SelectedValue, _
                '                                    txtComentarioEquipe.Text) Then
                '            MessageBox.Show("Dados de Reunião salvos com sucesso", "Reunião", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                '            Me.Close()
                '        End If
                '    Catch ex As Exception
                '        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                '    End Try
                'Else
                '    Exit Sub
                'End If

            End If

        Else



        End If

    End Sub

#End Region

#Region "REMOVER"

    Private Sub botRemover_Click(sender As System.Object, e As System.EventArgs) Handles botRemover.Click

        If gridNCapontadas.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma Não Conformidade selecionada", "Não Conformidades Apontadas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

            If comboNaoConformidade.Text <> "" Then



            Else



            End If

        End If

    End Sub

#End Region

#Region "REGISTRAR"

    Private Sub botRegistrarNC_Click(sender As System.Object, e As System.EventArgs) Handles botRegistrarNC.Click

        If gridNCapontadas.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma Não Conformidade selecionada", "Não Conformidades Apontadas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim frm As New melCadMelhorias

            'Chama novo cadastro de melhorias
            frm.NovoCadMelhoria()
        End If

    End Sub

#End Region

#End Region

End Class
