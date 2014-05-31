Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Public Class audRealizarAuditorias

#Region "VARIAVEIS"

    'Variaveis usadas para edição de dados
    Private isEdit As Boolean = False
    Private isEditProServ As Boolean = False
    Public idfornecedor As String
    Public idOcorrencias As String
    Public idContatos As String
    Public idContatosEdit As String
    Private ANEXO() As Byte


    'Pega Id Ocorrencias
    Public WriteOnly Property Contatos() As String
        Set(ByVal value As String)
            Me.idContatosEdit = value
        End Set
    End Property


#End Region

#Region "LOAD"

    Private Sub audRealizacaoAuditorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaListaAuditorias()
    End Sub

#End Region

#Region "POPULA COMBOS"

#Region "DATAS"

    Sub CarregaComboAno()
        With comboAno
            .DataSource = Manager.Util.getDataTable("SELECT DISTINCT ANO FROM VW_LISTAGEM_AUDITORIAS_PLANO_ANUAL")
            .DisplayMember = "ANO"
            .ValueMember = "ANO"
        End With
    End Sub

#End Region

#End Region

#Region "CARREGA LISTA - FILTRO"

    Public Sub carregaListaAuditorias()

        Dim dt As New DataTable
        Dim i As Integer = 1

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_AUDITORIAS_REALIZAR")
        dt = Manager.Util.getDataTableById(sql)

        'Monta o Grid
        gridRealizaAuditoria.AutoGenerateColumns = False
        gridRealizaAuditoria.DataSource = Manager.Util.getDataTable(sql)

        Try

            For Each dr As DataRow In dt.Rows

                ' coluna especifica
                If dr("SITUACAO") = "Programada" Then
                    gridRealizaAuditoria.SetCellImage(i, 8, _imgListLegenda.Images.Item(0))
                End If

                If dr("SITUACAO") = "Realizada" Then
                    gridRealizaAuditoria.SetCellImage(i, 8, _imgListLegenda.Images.Item(1))
                End If

                If dr("SITUACAO") = "Cancelada" Then
                    gridRealizaAuditoria.SetCellImage(i, 8, _imgListLegenda.Images.Item(2))
                End If

                If dr("SITUACAO") = "Reprogramada" Then
                    gridRealizaAuditoria.SetCellImage(i, 8, _imgListLegenda.Images.Item(3))
                End If

                If dr("SITUACAO") = "Atrasada" Then
                    gridRealizaAuditoria.SetCellImage(i, 8, _imgListLegenda.Images.Item(4))
                End If

                If dr("SITUACAO") = "Em Branco" Then
                    gridRealizaAuditoria.SetCellImage(i, 8, _imgListLegenda.Images.Item(5))
                End If

                i += 1

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub carregaListaDatasAno(ByVal ANO As String)

        Dim dt As New DataTable
        Dim i As Integer = 1

        Dim sqlId As String = String.Format("SELECT * FROM AUDITORIAS_REALIZAR")
        dt = Manager.Util.getDataTableById(sqlId)

        Dim sqlId2 As String = String.Format("SELECT * FROM VW_LISTAGEM_AUDITORIAS_REALIZAR WHERE ANO = {0}", ANO)
        Dim dt2 As New DataTable

        gridRealizaAuditoria.AutoGenerateColumns = False
        dt2 = Manager.Util.getDataTableById(sqlId2)
        gridRealizaAuditoria.DataSource = dt2

        Try

            For Each dr As DataRow In dt2.Rows

                '--PROGRAMADA
                If dr("SITUACAO") = "Programada" Then
                    gridRealizaAuditoria.SetCellImage(i, 8, _imgListLegenda.Images.Item(0))
                End If

                '--REALIZADA
                If dr("SITUACAO") = "Realizada" Then
                    gridRealizaAuditoria.SetCellImage(i, 8, _imgListLegenda.Images.Item(1))
                End If

                '--CANCELADA
                If dr("SITUACAO") = "Cancelada" Then
                    gridRealizaAuditoria.SetCellImage(i, 8, _imgListLegenda.Images.Item(2))
                End If

                '--REPROGRAMADA
                If dr("SITUACAO") = "Reprogramada" Then
                    gridRealizaAuditoria.SetCellImage(i, 8, _imgListLegenda.Images.Item(3))
                End If

                '--ATRASADA
                If dr("SITUACAO") = "Atrasada" Then
                    gridRealizaAuditoria.SetCellImage(i, 8, _imgListLegenda.Images.Item(4))
                End If

                i += 1

            Next

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "FILTRO POR ANO"
    'SELECIONA NO COMBO
    Private Sub comboAno_ChangeCommitted(sender As Object, e As System.EventArgs) Handles comboAno.ChangeCommitted
        Dim ano As String

        Try

            If comboAno.ValueMember = "" Then
                CarregaComboAno()
            End If

            ano = comboAno.SelectedValue.ToString
            carregaListaDatasAno(ano)

        Catch ex As Exception

        End Try
    End Sub

    'RECEBE O FOCO
    Private Sub comboAno_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboAno.GotFocus
        Dim ano As String

        Try

            If comboAno.ValueMember = "" Then
                CarregaComboAno()
            End If

            ano = comboAno.SelectedValue.ToString
            carregaListaDatasAno(ano)

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "BOTÕES"

#Region "REALIZAR"

    Private Sub botRealizar_Click(sender As System.Object, e As System.EventArgs) Handles botRealizar.Click

        If gridRealizaAuditoria.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma Auditoria selecionado", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

            Dim audRealiza As New audRealizacaoAuditorias
            Dim idrealziar As Integer = 0
            Dim idplano As Integer = 0
            Dim mes As String = String.Empty
            Dim situacao As String = String.Empty
            Dim ano As String = String.Empty

            'Passagem de parametros
            Try

                idrealziar = gridRealizaAuditoria(gridRealizaAuditoria.RowSel, 1)
                idplano = gridRealizaAuditoria(gridRealizaAuditoria.RowSel, 2)
                mes = gridRealizaAuditoria(gridRealizaAuditoria.RowSel, 4)
                situacao = gridRealizaAuditoria(gridRealizaAuditoria.RowSel, 8)
                ano = comboAno.SelectedValue.ToString

                If situacao = "Cancelada" Then
                    MessageBox.Show("Auditoria Cancelada", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                ElseIf situacao = "Realizada" Then
                    MessageBox.Show("Auditoria já realizada. Para alterar os dados clique no botão Editar.", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                ElseIf situacao = "Reprogramada" Then
                    MessageBox.Show("Auditoria reprogramada. É necessário programar uma outra auditoria.", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                audRealiza.Realizar = idrealziar
                audRealiza.RealizarPlano = idplano
                audRealiza.Mes = mes
                audRealiza.Situacao = situacao
                audRealiza.Ano = ano
                audRealiza.NovoRealiza(idplano, mes, situacao)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridRealizaAuditoria.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma Auditoria selecionado", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

            Dim audRealiza As New audRealizacaoAuditorias
            Dim id As Integer = 0
            Dim idrealziar As Integer = 0
            Dim idplano As Integer = 0
            Dim mes As String = String.Empty
            Dim situacao As String = String.Empty
            Dim ano As String = String.Empty

            'Muda o Label do botão Incluir
            audRealiza.botSalvar.Width = 80
            audRealiza.botSalvar.Text = "Atualizar"

            'Passagem de parametros
            Try
                situacao = gridRealizaAuditoria(gridRealizaAuditoria.RowSel, 8)
                ano = comboAno.SelectedValue.ToString

                If situacao = "Programada" Then
                    MessageBox.Show("Precisa realizar a Auditoria para edita-la", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                ElseIf situacao = "Cancelada" Then
                    MessageBox.Show("Auditoria cancelada", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                ElseIf situacao = "Reprogramada" Then
                    MessageBox.Show("Auditoria reprogramada. É necessário programar uma outra Auditoria", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                id = gridRealizaAuditoria(gridRealizaAuditoria.RowSel, 1)
                audRealiza.Ano = ano
                audRealiza.Realizar = id
                audRealiza.EditarAuditoria(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

#End Region

#Region "CHECK"

    Private Sub botCheck_Click(sender As System.Object, e As System.EventArgs) Handles botCheck.Click

        If gridRealizaAuditoria.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma Auditoria selecionado", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

        End If

    End Sub

#End Region

#Region "VISUALIZAR"

    Private Sub botVisualizar_Click(sender As System.Object, e As System.EventArgs) Handles botVisualizar.Click

        If gridRealizaAuditoria.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma Auditoria selecionada", "Realização de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

        End If

    End Sub

#End Region

#End Region

End Class
