Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.cotrCadCargos
Public Class cotrListaCargos

#Region "CARREGA LISTA"

#Region "CARGOS"

    Public Sub CarregaCargos()
        Dim dt As New DataTable
        Dim i As Integer = 1

        Dim sqlId As String = String.Format("SELECT * FROM CARGOS")
        dt = Manager.Util.getDataTableById(sqlId)

        'Monta o Grid
        gridCargos.AutoGenerateColumns = False
        gridCargos.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_CARGOS")

        Try

            'Função para validação de Imagem
            For Each dr As DataRow In dt.Rows

                If dr("SITUACAO") = 1 Then
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

#End Region

#Region "LOAD"

    Private Sub cotrPrincipalCargos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal

        'Carrega Lista de Cargos
        CarregaCargos()

    End Sub

#End Region

#Region "BOTOES"

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridCargos.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Cargos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim frm As New cotrCadCargos
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridCargos(gridCargos.RowSel, 1)
                frm.Cargos = id
                frm.EditarCargo(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#End Region
    
End Class
