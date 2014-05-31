Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.forCadFornecedores
Imports ISOEFACIL.rptUnitarioFornecedores
Imports ISOEFACIL.Manager.Util
Public Class forListaFornecedores

#Region "VARIAVEIS"

    'Variavel para verificar se a tela já esta aberta 
    Public idVerifivcar_open As Boolean = False

#End Region

#Region "CARREGA LISTA"

    Public Sub carregaFornecedor()
        Try
            Dim dr As SqlDataReader
            dr = Manager.Util.getDataReader("SELECT * FROM VW_LISTAGEM_FORNECEDORES")
            gridFornecedores.Rows.Count = 1
            Dim i As Integer = 0
            Dim teste As Integer = 0
            Dim Critico As Boolean = False
            Dim dr1 As SqlDataReader
            While dr.Read
                i = i + 1
                gridFornecedores.Rows.Add()
                gridFornecedores(gridFornecedores.Rows.Count - 1, 0) = dr("CODIGO")
                gridFornecedores(gridFornecedores.Rows.Count - 1, 1) = dr("FORNECEDOR")
                gridFornecedores(gridFornecedores.Rows.Count - 1, 2) = dr("CIDADE")
                gridFornecedores(gridFornecedores.Rows.Count - 1, 3) = dr("UF")
                gridFornecedores(gridFornecedores.Rows.Count - 1, 4) = dr("TELEFONE_FIXO")
                gridFornecedores(gridFornecedores.Rows.Count - 1, 5) = dr("EMAIL")
                gridFornecedores(gridFornecedores.Rows.Count - 1, 6) = dr("WEBSITE")
                Critico = Verificar_Critico(dr("CODIGO"))
                If Critico = True Then
                    gridFornecedores(gridFornecedores.Rows.Count - 1, 7) = "Crítico"
                Else
                    gridFornecedores(gridFornecedores.Rows.Count - 1, 7) = "Não Crítico"
                End If
                dr1 = Manager.Util.getDataReader("SELECT * FROM VW_LISTAGEM_FORNECEDORES_AVALIACOES_CONCLUIDAS WHERE ID_FORNECEDOR =" & dr("CODIGO"))
                Dim id_avaliacao As Integer = 0
                Dim Resultado_AValiacao As String = ""
                While dr1.Read
                    Resultado_AValiacao = dr1("situação").ToString
                End While
                If Resultado_AValiacao = "Não Qualificado" Then
                    gridFornecedores.SetCellImage(i, 8, Icones.Images.Item(1))
                ElseIf Resultado_AValiacao = "" Then
                    gridFornecedores.SetCellImage(i, 8, Icones.Images.Item(2))
                ElseIf Resultado_AValiacao = "Qualificado Com Restrição" Then
                    gridFornecedores.SetCellImage(i, 8, Icones.Images.Item(3))
                Else
                    gridFornecedores.SetCellImage(i, 8, Icones.Images.Item(0))
                End If

                dr1.Close()
                dr1 = Manager.Util.getDataReader("SELECT * FROM  VW_LISTAGEM_FORNECEDORES_OCORRENCIAS WHERE ID_FORNECEDOR =" & dr("CODIGO"))
                Dim Resultado_Ocorrencia As Integer = 0
                While dr1.Read
                    Resultado_Ocorrencia = dr1("Situação")
                End While
                If Resultado_Ocorrencia = 1 Then
                    gridFornecedores.SetCellImage(i, 9, Icones.Images.Item(0))
                ElseIf Resultado_Ocorrencia = 2 Then
                    gridFornecedores.SetCellImage(i, 9, Icones.Images.Item(1))
                Else
                    gridFornecedores.SetCellImage(i, 9, Icones.Images.Item(2))
                End If
            End While

        Catch ex As Exception

        End Try
        'gridFornecedores.AutoGenerateColumns = False


    End Sub

    Public Function Verificar_Critico(ByVal idfornecedor As Integer) As Boolean
        Dim dr1 As SqlDataReader
        dr1 = Manager.Util.getDataReader("SELECT * FROM VW_LISTAGEM_FORNECEDORES_PROD_SERV where FORNECEDOR =" & idfornecedor)
        Dim Resultado As Integer = 0
        Dim critico As Integer


        While dr1.Read
            If Resultado = 1 Then
            Else
                If dr1("CRITICO") = "Crítico" Then
                    critico = 1
                    Resultado = 1
                Else
                    critico = 0
                    Resultado = 0
                End If
            End If
        End While
        If critico = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

#End Region

#Region "LOAD"

    Private Sub forPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        Me.MdiParent = principal

        'Carrega Lista de Fornecedores
        carregaFornecedor()


    End Sub

#End Region

#Region "BOTÕES"

#Region "NOVO"

    Private Sub botNovo_Click(sender As Object, e As EventArgs) Handles botNovo.Click

        If idVerifivcar_open = True Then
        Else
            Dim frm As New forCadFornecedores

            'Chama o forCadastro
            frm.NovoFornecedores()
        End If

    End Sub

#End Region

#Region "ALTERAR"

    Private Sub botEditar_Click(sender As Object, e As EventArgs) Handles botEditar.Click

        If idVerifivcar_open = True Then
        Else
            
            If gridFornecedores.RowSel <= 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else

                Dim frm As New forCadFornecedores
                Dim id As Integer = 0

                'Passagem de parametros
                Try
                    id = gridFornecedores(gridFornecedores.RowSel, 0)
                    frm.ID_Fornecedor = id
                    frm.EditarFornecedor(id)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            End If
        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As Object, e As EventArgs) Handles botExcluir.Click

        If gridFornecedores.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

            Dim fornecedor As New Fornecedores
            Dim sqlId As String     '= String.Format("SELECT * FROM VW_LISTAGEM_FORNECEDORES_CONTATOS WHERE FORNECEDOR = {0} AND MODULO = 'FORNECEDOR'", idfornecedor)
            Dim dr As SqlDataReader
            Dim id As Integer
            Dim Del_ok As Boolean = False

            'Excluir o Fornecedor
            Try
                id = (gridFornecedores(gridFornecedores.RowSel, 0))
                sqlId = String.Format("SELECT * FROM VW_LISTAGEM_FORNECEDORES WHERE CODIGO = {0}", id)
                dr = Manager.Util.getDataReader(sqlId)

                While dr.Read
                    Dim nome As String = dr("fornecedor").ToString
                    If MessageBox.Show("Tem certeza que deseja excluir o Fornecedor " & nome & ".", "Fornecedor", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        Del_ok = True
                        fornecedor.Delete(id)
                        MessageBox.Show("Fornecedor " & nome & " excluído com sucesso", "Fornecedor", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        carregaFornecedor()
                    End If
                End While
                sqlId = ""
                dr.Close()


                If Del_ok = True Then
                    sqlId = String.Format("SELECT * FROM VW_LISTAGEM_FORNECEDORES_CONTATOS WHERE FORNECEDOR = {0} AND MODULO = 'FORNECEDOR'", id)
                    dr = Manager.Util.getDataReader(sqlId)
                    Dim i As Integer = 0
                    Dim Contatos As New Contatos
                    While dr.Read
                        i = dr("CODIGO").ToString
                        Contatos.Delete(i)
                    End While





                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "VISUALIZAR"

    Private Sub botVisualizar_Click(sender As System.Object, e As System.EventArgs) Handles botVisualizar.Click

        If gridFornecedores.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            'Dim rpt As New rptUnitarioFornecedores

            'rpt.Show()
        End If

    End Sub

#End Region

#End Region

End Class
