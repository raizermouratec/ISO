Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class acAddListaItensAdd

#Region "VARIAVEIS"

    'Public cod_item As Integer

#End Region

#Region "CARREGA ITENS"

    Public Sub CarregaItens()

        gridItens.AutoGenerateColumns = False
        gridItens.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_ANALISE_CRITICA_DADOS_ITENS_RELATORIO")

    End Sub

#End Region

#Region "LOAD"

    Private Sub acItensAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaItens()
    End Sub

#End Region

#Region "BOTOES"

#Region "ADICIONAR"

    Private Sub botAdicionar_Click(sender As System.Object, e As System.EventArgs) Handles botAdicionar.Click

        'Cadastra novo Item
        Dim itens As New itens
        Dim cod_item As Integer

        'Salvar Item
        Try

            While cod_item > 11

                VerificarItem()
                If itens.Add(cod_item, txtTitulo.Text) Then
                    CarregaItens()
                    MessageBox.Show("Novo Item salvo com sucesso", "Itens", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtTitulo.Text = ""
                End If
                cod_item = cod_item + 1

            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' CONTADOR.
    ''' </summary>
    Private Sub contador()
        Dim dbCont As New DataTable
        Dim cont As Integer = 1
        Try
            'If isEdit Then
            '    cont = idprojetos
            '    txtTitulo.Text = cont.ToString
            'Else
            '    dbCont = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_PROJETOS")
            '    If dbCont.Rows.Count >= 11 Then
            '        cont = cont + dbCont.Rows.Count
            '        txtTitulo.Text = cont.ToString
            '    Else
            '        txtTitulo.Text = cont.ToString
            '    End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub VerificarItem()
        'Titulo
        If txtTitulo.Text = "" Then
            MessageBox.Show("O campo Título não foi preenchido", "Itens", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTitulo.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarItensDados(ByVal id As Integer)

        Dim cod_item As Integer

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona pelo Id
        Dim sql As String = String.Format("SELECT * FROM ANALISE_CRITICA_DADOS_ITENS_RELATORIO WHERE ID_ANALISE_CRITICA_DADOS_ITENS_RELATORIO = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                cod_item = dr("COD_ITEM").ToString

            End While

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botRemover_Click(sender As System.Object, e As System.EventArgs) Handles botRemover.Click

        If gridItens.RowSel <= 0 Then
            MessageBox.Show("Não à nenhum Item selecionado", "Itens", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim itens As New itens

            'Excluir o Registro
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Itens", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    itens.Delete(gridItens(gridItens.RowSel, 1))
                    CarregaItens()
                    MessageBox.Show("Registro excluído com sucesso", "Itens", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If
    End Sub

#End Region

#End Region

#Region "ATUALIZA CHECK GRID"

    Private Sub gridItens_Click(sender As System.Object, e As System.EventArgs) Handles gridItens.Click
        With gridItens
            If .ColSel > 0 Then
                Dim Check As New requisitos
                Dim Aprovado As Boolean
                Dim id As Integer
                Try
                    If .Item(.RowSel, .ColSel) = True Then
                        Aprovado = False
                        .Item(.RowSel, .ColSel) = False
                    Else
                        Aprovado = True
                        .Item(.RowSel, .ColSel) = True
                    End If
                    id = .Item(.RowSel, 1)
                    'Check.UpdateMultiplo(id, Aprovado)
                Catch ex As Exception
                    ' MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
        End With
    End Sub

#End Region

End Class
