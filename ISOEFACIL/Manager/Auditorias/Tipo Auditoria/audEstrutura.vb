Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.audCadTipoAuditorias
Imports ISOEFACIL.audListaTipoAuditorias
Public Class audEstrutura

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Public idtipoAuditoria As String
    Public idestrutura As String
    Public verif = False

    'Pega Id Tipo de Auditoria
    Public WriteOnly Property TipoAuditoria() As String
        Set(ByVal value As String)
            Me.idtipoAuditoria = value
        End Set
    End Property

    'Pega Id Estrutura
    Public WriteOnly Property Estrutura() As String
        Set(ByVal value As String)
            Me.idestrutura = value
        End Set
    End Property

#End Region

#Region "CARREGAR LISTAS"

#Region "LISTA REQUISITOS"

    Public Sub CarregaRequisitos(ByVal id As Integer)

        'Monta Lista de Saídas do Plano de Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_PROJETOS_PLANO_SAIDAS WHERE PROJETOS = {0}", id)
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridEstrutura.AutoGenerateColumns = False

        'Cria a tabela
        gridEstrutura.DataSource = dt

    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub audEstruturado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

#End Region

#Region "NOVO PLANO"

    Public Sub NovaEstrutura(ByVal id As Integer)

        'Estruturar novo 
        isEdit = False

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_AUDITORIAS_TIPO WHERE ID = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtTipoAuditoria.Text = dr("NORMAS").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        radioI1.Checked = True
        txtItem.Text = "1"
        txtTitulo.Focus()

        Me.ShowDialog()
    End Sub

#End Region

#Region "BOTOES"

#Region "INCLUIR"

    Private Sub botIncluir_Click(sender As System.Object, e As System.EventArgs) Handles botIncluir.Click

        'Seta a Classe
        Dim estrutura As New estrutura

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                'Try
                '    'Atualizar
                '    If estrutura.Update(idestrutura, _
                '                        idtipoAuditoria, _
                '                        txtItem,Text, _   
                '                        txtTitulo,Text, _

                '                        ) Then
                '        'CarregaRequisitos()
                '        MessageBox.Show("Dados de Requisitos atualizados com sucesso", "Estrutura", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    End If
                'Catch ex As Exception
                '    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                'End Try
            Else
                Exit Sub
            End If

        Else

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                'Try
                '    'Salvar
                '    If estrutura.Add(idtipoAuditoria, _
                '                     txtItem,Text, _    
                '                     txtTitulo,Text, _
                '                     ) Then
                '        'CarregaRequisitos()
                '        MessageBox.Show("Item de Requisitos salvos com sucesso", "Estrutura", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                '        isEdit = True
                '    End If
                'Catch ex As Exception
                '    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                'End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub Verificar()
        verif = False

        ''Tratamento de erro Título
        'If txtTitulo.Text = "" Then
        '    MessageBox.Show("Campo Título Obrigatório", "Estrutura", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtTitulo.Focus()
        '    verif = True
        '    Exit Sub
        'End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        Dim id As Integer = 0

        If gridEstrutura.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Tipo de Auditoria - Estrutura", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            isEdit = True

            Try
                'Passagem de parametros
                id = gridEstrutura(gridEstrutura.RowSel, 1)
                Estrutura = id

                'Seleciona Fornecedor pelo Id
                Dim sql As String = String.Format("SELECT * FROM AUDITORIAS_TIPO_ESTRUTURA WHERE ID_AUDITORIAS_TIPO_ESTRUTURA = {0}", id)

                'Popula os campos com os dados do Banco
                Try

                    Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

                    While dr.Read

                        Me.txtTitulo.Text = dr("TITULO").ToString

                    End While

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        Dim estrutura As New estrutura

        If gridEstrutura.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Tipo de Auditoria - Estrutura", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Excluir
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado ?", "Tipos de Auditorias - Estrutura", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    estrutura.Delete(gridEstrutura(gridEstrutura.RowSel, 1))
                    MessageBox.Show("Dados da Tipos de Auditorias excluídos com sucesso", "Tipos de Auditorias - Estrutura", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'CarregaRequisitos()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "VERSAO"


#End Region

#End Region

End Class
