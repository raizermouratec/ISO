Public Class acListaItens

#Region "CARREGA ITENS"

    Public Sub CarregaItens()

        gridItenS.AutoGenerateColumns = False
        gridItenS.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_ANALISE_CRITICA_DADOS_ITENS_RELATORIO")

    End Sub

#End Region

#Region "LOAD"

    Private Sub acItens_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaItens()
    End Sub

#End Region

#Region "ATUALIZA CHECK GRID"

    Private Sub gridItenS_Click(sender As System.Object, e As System.EventArgs) Handles gridItenS.Click
        With gridItenS
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
                    Check.UpdateMultiplo(id, Aprovado)
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
        End With
    End Sub

#End Region

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If gridItenS.RowSel <= 0 Then
            MessageBox.Show("Não à nenhum item selecionado", "Dados", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else


        End If

    End Sub

End Class
