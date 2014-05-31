Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.configCadAreas
Imports ISOEFACIL.configCadCargos
Imports ISOEFACIL.configCadColaboradores
Public Class configListaBasico

#Region "CARREGA LISTA"

#Region "AREA"

    Public Sub CarregaAreas()

        'Monta o Grid
        gridArea.AutoGenerateColumns = False
        gridArea.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_AREAS")
    End Sub

#End Region

#Region "CARGOS"

    Public Sub CarregaCargos()

        'Monta grid Prod/Serv passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_CARGOS")
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridCargos.AutoGenerateColumns = False

        'Cria a tabela
        gridCargos.DataSource = dt

        Try

            'Função para validação de Imagem
            For Each dr As DataRow In dt.Rows

                If dr("SITUACAO") = "Ativo" Then
                    'ATIVO
                    gridCargos.SetCellImage(i, 4, _imgListSituacao.Images.Item(0))
                Else
                    'INATIVO
                    gridCargos.SetCellImage(i, 4, _imgListSituacao.Images.Item(1))
                End If
                i += 1

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "COLABORADORES"

    Public Sub CarregaColaboradores()

        'Monta grid Prod/Serv passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_COLABORADORES")
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridColaboradores.AutoGenerateColumns = False

        'Cria a tabela
        gridColaboradores.DataSource = dt

        Try

            'Função para validação de Imagem
            For Each dr As DataRow In dt.Rows

                If dr("SITUACAO") = "Ativo" Then
                    'ATIVO
                    gridColaboradores.SetCellImage(i, 7, _imgListSituacao.Images.Item(0))
                Else
                    'INATIVO
                    gridColaboradores.SetCellImage(i, 7, _imgListSituacao.Images.Item(1))
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

    Private Sub ConfigCadBasico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Alinhar o Grid
        MdiParent = principal

        'tabAreas como padrao
        tabAreas.Show()
        'Listas
        CarregaAreas()
        CarregaCargos()
        CarregaColaboradores()

    End Sub

#End Region

#Region "BOTÕES"

#Region "NOVO"

    Private Sub botIncluirArea_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar_Incluir.Click

        'AREAS
        If tabAreas.Focus = True Then

            Dim frm As New configCadAreas

            'Nova Area
            frm.NovaArea()

            'CARGOS
        ElseIf tabCargos.Focus = True Then

            Dim frm As New configCadCargos

            'Novo Cargo
            frm.NovoCargo()

            'COLABORADORES
        ElseIf tabColaboradores.Focus = True Then

            Dim frm As New configCadColaboradores

            'Novo Colaboradores
            frm.NovoColaborador()

        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        'EDITAR AREAS
        If tabAreas.Focus = True Then

            Try
                If gridArea.RowSel <= 0 Then
                    MessageBox.Show("Não à nenhuma Área cadastrada", "Áreas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim frm As New configCadAreas
                    Dim id As Integer = 0

                    id = gridArea(gridArea.RowSel, 1)
                    frm.Areas = id
                    frm.EditarAreas(id)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

            'EDITAR CARGOS
        ElseIf tabCargos.Focus = True Then

            Try
                If gridCargos.RowSel <= 0 Then
                    MessageBox.Show("Não à nenhum Cargo cadastrado", "Cargos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim frm As New configCadCargos
                    Dim id As Integer = 0

                    id = gridCargos(gridCargos.RowSel, 1)
                    frm.Cargos = id
                    frm.EditarCargos(id)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

            'EDITAR COLABORADORES
        ElseIf tabColaboradores.Focus = True Then

            Try
                If gridColaboradores.RowSel <= 0 Then
                    MessageBox.Show("Não à nenhum Colaborador cadastrado", "Colaboradores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim frm As New configCadColaboradores
                    Dim id As Integer = 0

                    id = gridColaboradores(gridColaboradores.RowSel, 1)
                    frm.Colaboradores = id
                    frm.EditarColaboradores(id)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If tabAreas.Focus = True Then 'EXCLUIR AREA

            If gridArea.RowSel <= 0 Then
                MessageBox.Show("Não à nenhuma Área cadastrada", "Áreas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim areas As New areas

                'Exclui Area
                Try

                    If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Áreas", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        areas.Delete(gridArea(gridArea.RowSel, 1))
                        MessageBox.Show("Área excluída com sucesso", "Áreas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CarregaAreas()
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            End If


        ElseIf tabCargos.Focus = True Then 'EXCLUIR CARGOS

            If gridCargos.RowSel <= 0 Then
                MessageBox.Show("Não à nenhum Cargo cadastrado", "Cargos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim cargos As New cargosbasicos

                'Exclui Cargos
                Try

                    If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Cargos", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        cargos.Delete(gridCargos(gridCargos.RowSel, 1))
                        MessageBox.Show("Cargo excluído com sucesso", "Cargos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CarregaCargos()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            End If

        ElseIf tabColaboradores.Focus = True Then 'EXCLUIR COLABORADORES

            If gridColaboradores.RowSel <= 0 Then
                MessageBox.Show("Não à nenhum Colaborador cadastrado", "Colaboradores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim colaboradores As New colaboradores

                'Exclui Colaboradores
                Try

                    If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Colaboradores", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        colaboradores.Delete(gridColaboradores(gridColaboradores.RowSel, 1))
                        MessageBox.Show("Colaborador excluído com sucesso", "Colaboradores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CarregaColaboradores()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            End If

            End If

    End Sub

#End Region

#Region "RELACAO"

    Private Sub botRelacao_Click(sender As System.Object, e As System.EventArgs) Handles botRelacao.Click

        'AREAS
        If tabAreas.Focus = True Then

            If gridArea.RowSel <= 0 Then
                MessageBox.Show("Não à nenhuma Área selecionada", "Áreas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim rpt As New rptListagemAreas

                rpt.Show()
            End If

            'CARGOS
        ElseIf tabCargos.Focus = True Then

            If gridCargos.RowSel <= 0 Then
                MessageBox.Show("Não à nenhum Cargo selecionado", "Cargos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                'Dim rpt As New rptListagemCargos

                'rpt.Show()
            End If

            'COLABORADORES
        ElseIf tabColaboradores.Focus = True Then

            If gridColaboradores.RowSel <= 0 Then
                MessageBox.Show("Não à nenhum Colaborador selecionado", "Colaboradores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim rpt As New rptListagemColaboradores

                rpt.Show()
            End If

        End If

    End Sub

#End Region

#End Region

End Class
