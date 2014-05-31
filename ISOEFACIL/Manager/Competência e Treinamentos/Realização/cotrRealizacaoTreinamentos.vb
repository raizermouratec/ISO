Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO

Public Class cotrRealizacaoTreinamentos

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
    Private Sub cotrRealizacaoTreinamentos_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub
#End Region

#Region "POPULA COMBOS"

#Region "DATAS"

    Sub CarregaComboAno()
        With comboAno
            .DataSource = Manager.Util.getDataTable("SELECT DISTINCT ANO FROM VW_LISTAGEM_TREINAMENTO_PLANO_ANUAL")
            .DisplayMember = "ANO"
            .ValueMember = "ANO"
            InputGroupHeader1.Text = "Treinamentos Cadastrados em " + comboAno.SelectedValue.ToString
        End With
    End Sub

#End Region

#End Region

#Region "CARREGA LISTA - FILTRO"

    Public Sub carregaListaDatasAno(ByVal ANO As String)

        Dim dt As New DataTable
        Dim i As Integer = 1

        Dim sqlId As String = String.Format("SELECT * FROM TREINAMENTO_REALIZAR")
        dt = Manager.Util.getDataTableById(sqlId)

        Dim sqlId2 As String = String.Format("SELECT * FROM VW_LISTAGEM_TREINAMENTO_REALIZAR WHERE ANO = {0}", ANO)
        Dim dt2 As New DataTable

        gridPlanoDatas.AutoGenerateColumns = False
        dt2 = Manager.Util.getDataTableById(sqlId2)
        gridPlanoDatas.DataSource = dt2

        Try

            For Each dr As DataRow In dt2.Rows

                '--PROGRAMADA
                If dr("SITUACAO") = "Programada" Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(0))
                End If

                '--REALIZADA
                If dr("SITUACAO") = "Realizada" Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(1))
                End If

                '--CANCELADA
                If dr("SITUACAO") = "Cancelada" Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(2))
                End If

                '--REPROGRAMADA
                If dr("SITUACAO") = "Reprogramada" Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(3))
                End If

                '--ATRASADA
                If dr("SITUACAO") = "Atrasada" Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(4))
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
    ''' <summary>
    ''' Realizar
    ''' </summary>
    Private Sub botRealizar_Click(sender As System.Object, e As System.EventArgs) Handles botRealizar.Click

        'Passagem de parametros
        Try

            If gridPlanoDatas.RowSel <= 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Realização de Treinamentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim cotrRealiza As New cotrRealizarTreinamentos
                Dim idplano As Integer = 0
                Dim id As Integer = 0
                Dim mes As String = String.Empty
                Dim situacao As String = String.Empty
                Dim ano As String = String.Empty

                situacao = gridPlanoDatas(gridPlanoDatas.RowSel, 9)

                If situacao = "Cancelada" Then
                    MessageBox.Show("Treinamento Cancelado", "Realização de Treinamentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                ElseIf situacao = "Realizada" Then
                    MessageBox.Show("Treinamento já realizado. Para alterar os dados clique no botão Editar.", "Realização de Treinamentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                ElseIf situacao = "Reprogramada" Then
                    MessageBox.Show("Treinamento reprogramado. É necessário programar uma outro Treinamento.", "Realização de Treinamentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                id = gridPlanoDatas(gridPlanoDatas.RowSel, 1)
                idplano = gridPlanoDatas(gridPlanoDatas.RowSel, 2)
                mes = gridPlanoDatas(gridPlanoDatas.RowSel, 5)
                ano = comboAno.SelectedValue.ToString

                cotrRealiza.Mes = mes
                cotrRealiza.Situacao = situacao
                cotrRealiza.Ano = ano
                cotrRealiza.Realizar = id
                cotrRealiza.Realizacao = idplano
                cotrRealiza.NovoRealiza(id)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' Relatório
    ''' </summary>
    Private Sub botRelatorio_Click(sender As System.Object, e As System.EventArgs) Handles botRelatorio.Click
        If gridPlanoDatas.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Realização de Treinamentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
        End If
    End Sub

#End Region

End Class
