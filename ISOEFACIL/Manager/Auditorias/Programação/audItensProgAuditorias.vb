Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Public Class audItensProgAuditorias

#Region "VARIÁVEIS"

    Public idAplanAudtorias As String
    Public idItensPlan As String
    Private isEdit As Boolean = False

    'Pega Id PLANO_AUDITORIA
    Public WriteOnly Property PlanAuditoriaID() As String
        Set(ByVal value As String)
            Me.idAplanAudtorias = value
        End Set
    End Property

    'Pega Id ITEM
    Public WriteOnly Property idItem() As String
        Set(ByVal value As String)
            Me.idItensPlan = value
        End Set
    End Property

#End Region

#Region "LOAD"

    Private Property ArrayList As String

    Private Sub audItensProgAud_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carregaItens()
    End Sub
#End Region

#Region "CARREGAR LISTA"

    Public Sub carregaItens()

        'Monta o Grid
        gridItem.AutoGenerateColumns = False
        gridItem.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_ITEM_NORMA")

    End Sub

    Public Sub carregaItensRealiza(ByVal id As Integer)

        'Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_ITEM_NORMA")
        'Dim sql2 As String = String.Format("SELECT * FROM VW_LISTAGEM_ITEM_NORMA_REALIZA WHERE ID_AUDITORIAS_PLANO = {0} ORDER BY ITEM", id)


        ''Monta o Grid
        'gridItem.AutoGenerateColumns = False
        'gridItem.DataSource = Manager.Util.getDataTable(sql)

        'Dim dr As SqlDataReader = Manager.Util.getDataReader(sql2)

        'If dr.HasRows = False Then
        '    Exit Sub
        'Else
        '    Dim i As Integer = 1
        '    While dr.Read
        '        gridItem(i, 4) = True
        '        i = i + 1
        '    End While
        'End If


    End Sub

#End Region

#Region "BOTÕES"

#Region "SALVAR"

    Public Sub NovoItensAuditoria()
        'Cadastrar Novo
        isEdit = False
        ' carregaItens()
        Me.ShowDialog()
    End Sub

    Public Sub EditarItensAuditoria()
        'Cadastrar Novo
        isEdit = True
        ' carregaItensRealiza(idItensPlan)
        Me.ShowDialog()
    End Sub


    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click
        If isEdit = False Then
            SalvarNovo()
        Else
            SalvarById(idItensPlan)
        End If

    End Sub

    Private Sub SalvarNovo()

        Dim plano As New planoAnualAuditoria

        'Selects nas tabelas
        Dim sql As String = String.Format("SELECT MAX (ID_AUDITORIAS_PLANO) AS ID FROM AUDITORIAS_PLANO")
        Dim sql2 As String = String.Format("SELECT * FROM ITEM_NORMA WHERE [CHECK] = 1")

        Try

            'gera data reader
            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)
            Dim dr2 As SqlDataReader = Manager.Util.getDataReader(sql2)

            Dim id As Integer = 0

            While dr.Read

                id = dr("ID").ToString

            End While

            If dr2.HasRows = False Then
                MessageBox.Show("Selecione um ou mais Itens na lista", "Plano Anual de Auditoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                While dr2.Read

                    ArrayList = dr2("ID_ITEM_NORMA").ToString

                    plano.AddItemAud(id, ArrayList)

                End While

            End If

            MessageBox.Show("Novo Plano Anual incluído com sucesso", "Plano Anual de Auditoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            plano.UpdateNull(0)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SalvarById(ByVal id As Integer)

        Dim plano As New planoAnualAuditoria

        'Selects nas tabelas
        Dim sql As String = String.Format("SELECT * FROM AUDITORIAS_PLANO WHERE ID_AUDITORIAS_PLANO={0}", id)
        Dim sql2 As String = String.Format("SELECT * FROM ITEM_NORMA WHERE [CHECK] = 1")

        Try

            'gera data reader
            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)
            Dim dr2 As SqlDataReader = Manager.Util.getDataReader(sql2)

            Dim idPlan As Integer = 0

            While dr.Read

                idPlan = dr("ID_AUDITORIAS_PLANO").ToString

            End While

            If dr2.HasRows = False Then
                MessageBox.Show("Selecione um ou mais Itens na lista", "Plano Anual de Auditoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                While dr2.Read

                    ArrayList = dr2("ID_ITEM_NORMA").ToString

                    plano.AddItemAud(idPlan, ArrayList)

                End While

            End If

            MessageBox.Show("Novo Plano Anual incluído com sucesso", "Plano Anual de Auditoria", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            plano.UpdateNull(0)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "CHECK"
    Private Sub checkTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkTodos.CheckedChanged
        Dim checked As Boolean   ' Set to True or False, as required.

        If checkTodos.Checked Then
            checked = True
            For i As Integer = 0 To gridItem.Rows.Count - 1
                gridItem.SetData(i, 4, checked)
            Next
        Else
            checked = False
            For i As Integer = 0 To gridItem.Rows.Count - 1
                gridItem.SetData(i, 4, checked)
            Next
        End If
    End Sub
#End Region

#End Region

#Region "ATUALIZA CHECK"

    Private Sub gridItem_Click(sender As System.Object, e As System.EventArgs) Handles gridItem.Click
        With gridItem
            If .ColSel = 4 Then
                Dim Check As New planoAnualAuditoria
                Dim Aprovado As Boolean
                Try
                    If .Item(.RowSel, .ColSel) = True Then
                        Aprovado = True
                    Else
                        Aprovado = False
                    End If
                    Check.UpdateMultiplo(.Item(.RowSel, 1), Aprovado)
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
        End With
    End Sub

#End Region

End Class
