Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.mgCadCopiasManual
Imports ISOEFACIL.mgCadControleManual
Public Class mgListaControleManual

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Public idManuais As String

    Public WriteOnly Property Manuais() As String
        Set(ByVal value As String)
            Me.idManuais = value
        End Set
    End Property

#End Region

#Region "CARREGA LISTA"

    Public Sub CarregaLista()

        'Carrega Lista Controle de Manuais
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_MANUAL_CONTROLE")
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)


        'Não gera colunas automaticas
        gridControleManual.AutoGenerateColumns = False

        'Cria a tabela
        gridControleManual.DataSource = dt

        Try

            'Função para validação de Imagem
            For Each dr As DataRow In dt.Rows

                If dr("REV").ToString < 9 Then
                    Convert.ToString("0" + dr("REV").ToString)
                Else
                    Convert.ToString(dr("REV").ToString)
                End If
                i += 1

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub gridControleManual_Click(sender As System.Object, e As System.EventArgs) Handles gridControleManual.Click

        CarregaCopiaManual()
        gridControleManual.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Always

    End Sub

    Public Sub CarregaCopiaVazio()

        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_MANUAL_CONTROLE_COPIA where ID = 0")
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridCopiasManual.AutoGenerateColumns = False

        'Cria a tabela
        gridCopiasManual.DataSource = dt

    End Sub

    Private Sub gridCopiasManual_Click(sender As System.Object, e As System.EventArgs) Handles gridCopiasManual.Click

        gridControleManual.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Always

    End Sub

    Public Sub CarregaCopiaManual()

        If gridControleManual.RowSel <= 0 Then
            Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_MANUAL_CONTROLE_COPIA")
            Dim dt As New DataTable
            Dim i As Integer = 1

            'Chama o Methodo que cria o DataTable e coloca na variavel
            dt = Manager.Util.getDataTableById(sqlId)

            'Não gera colunas automaticas
            gridCopiasManual.AutoGenerateColumns = False

            'Cria a tabela
            gridCopiasManual.DataSource = dt
            Exit Sub
        Else

            'Carrega Lista
            Dim id As Integer = 0

            id = gridControleManual(gridControleManual.RowSel, 1)
            gridCopiasManual.AutoGenerateColumns = False
            Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_MANUAL_CONTROLE_COPIA WHERE ID_MANUAL = {0}", id)
            Dim dtb As New DataTable

            dtb = Manager.Util.getDataTable(sql)
            gridCopiasManual.DataSource = dtb
            'gridCopiasManual.RowSel = False
            gridControleManual.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Always
        End If

    End Sub

#End Region

#Region "LOAD"

    Private Sub mgControle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal

        CarregaLista()
        gridControleManual.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        CarregaCopiaVazio()

    End Sub

#End Region

#Region "CONTROLE DE MANUAIS DE GESTÃO"

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As System.Object, e As System.EventArgs) Handles botNovo.Click

        Dim frm As New mgCadControleManual

        'Chama o Cadastro
        frm.NovoCadManual()

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridControleManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado !", "Controle de Manuais", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim frm As New mgCadControleManual
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridControleManual(gridControleManual.RowSel, 1)
                frm.ControleManuais = id
                frm.EditarControleManuais(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If gridControleManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado !", "Controle de Manuais", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

            If gridControleManual(gridControleManual.RowSel, 6) = "Em Desenvolvimento" Then

                Dim ControleManuais As New ControleManuais

                'Excluir o Controle do Manual
                Try

                    If MessageBox.Show("Tem certeza que deseja excluir o item selecionado ?", "Controle de Manuais", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        ControleManuais.DeleteCreate(gridControleManual(gridControleManual.RowSel, 1))
                        CarregaLista()
                        MessageBox.Show("Ação excluída com sucesso", "Controle de Manuais", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Não pode excluir um manual Aprovado ou Em Revisão !", "Controle de Manuais", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        End If

    End Sub

#End Region

#Region "APROVAR"

    Private Sub botAprovar_Click(sender As System.Object, e As System.EventArgs) Handles botAprovar.Click

        If gridControleManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado !", "Controle de Manuais", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

            Dim frm As New mgAprovControleManual
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridControleManual(gridControleManual.RowSel, 1)
                frm.AprovControleManuais = id
                frm.ShowDialog()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "CANCELAR"

    Private Sub botCancelar_Click(sender As System.Object, e As System.EventArgs) Handles botCancelar.Click

        If gridControleManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado !", "Controle de Manuais", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim ControleManuais As New ControleManuais
            Dim Situacao As Integer = 0

            If gridControleManual(gridControleManual.RowSel, 6) = "Em Revisão" Then
                If MessageBox.Show("Tem certeza que deseja Cancelar o item Em Revisão ?", "Controle de Manuais", Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                    'SITUACAO - Em Revisão
                    Situacao = 3
                    ControleManuais.UpdateStatus(gridControleManual(gridControleManual.RowSel, 1), _
                                                 Situacao)
                    CarregaLista()
                Else
                    Exit Sub
                End If
            ElseIf gridControleManual(gridControleManual.RowSel, 6) = "Aprovado" Then
                If MessageBox.Show("Tem certeza que deseja Cancelar o item Aprovado ?", "Controle de Manuais", Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                    'SITUACAO - Aprovado
                    Situacao = 3
                    ControleManuais.UpdateStatus(gridControleManual(gridControleManual.RowSel, 1), _
                                                 Situacao)
                    CarregaLista()
                Else
                    Exit Sub
                End If
            Else
                MessageBox.Show("Não pode Cancelar um manual não Aprovado !", "Controle de Manuais", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If

    End Sub

#End Region

#Region "ALTERAÇÕES"

    Private Sub botAlteracoes_Click(sender As System.Object, e As System.EventArgs) Handles botAlteracoes.Click

        If gridControleManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado !", "Controle de Manuais", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

            Dim frm As New mgAlteracoesControleManual
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridControleManual(gridControleManual.RowSel, 1)
                frm.AlteracoesControleManuais = id
                frm.ShowDialog()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

#End Region

#Region "ANEXOS"

    Private Sub botAnexos_Click(sender As System.Object, e As System.EventArgs) Handles botAnexos.Click

        If gridControleManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado !", "Controle de Manuais", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

            Dim frm As New mgAnexosControleManual
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridControleManual(gridControleManual.RowSel, 1)
                frm.AnexosControleManuais = id
                frm.ShowDialog()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

#End Region

#End Region

#End Region

#Region "CÓPIAS DO CONTROLE MANUAIS DE GESTÃO"

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovoCopia_Click(sender As System.Object, e As System.EventArgs) Handles botNovoCopia.Click

        If gridControleManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma Manual cadastrado !", "Cópias dos Manuais", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

            Dim frm As New mgCadCopiasManual
            Dim id As Integer

            'Chama o Cadastro
            id = gridControleManual(gridControleManual.RowSel, 1)
            frm.ControleManual = id
            frm.NovoCadCopiasManual()

        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditarCopia_Click(sender As System.Object, e As System.EventArgs) Handles botEditarCopia.Click

        If gridCopiasManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado !", "Cópias dos Manuais", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

            Dim frm As New mgCadCopiasManual
            Dim id As Integer = 0
            Dim idManual As Integer = 0

            'Passagem de parametros
            Try

                idManual = gridControleManual(gridControleManual.RowSel, 1)
                frm.ControleManual = idManual

                id = gridCopiasManual(gridCopiasManual.RowSel, 1)
                frm.CopiaManuais = id
                frm.EditarCopiaManual(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluirCopia_Click(sender As System.Object, e As System.EventArgs) Handles botExcluirCopia.Click

        If gridCopiasManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado !", "Cópias dos Manuais", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

            Dim CopiasManuais As New CopiasManuais

            'Excluir o Cópias dos Manuais
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado ?", "Cópias dos Manuais", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    CopiasManuais.Delete(gridCopiasManual(gridCopiasManual.RowSel, 1))
                    CarregaCopiaManual()
                    MessageBox.Show("Ação excluída com sucesso", "Cópias dos Manuais", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "VISUALIZAR"

    Private Sub botVisualizarCopia_Click(sender As System.Object, e As System.EventArgs) Handles botVisualizarCopia.Click

        If gridCopiasManual.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado !", "Cópias dos Manuais", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

        End If

    End Sub

#End Region

#End Region

#End Region
 
End Class
