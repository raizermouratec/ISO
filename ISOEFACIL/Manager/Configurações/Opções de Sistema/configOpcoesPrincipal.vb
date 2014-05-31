Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient

Public Class configOpcoesPrincipal

#Region "VARIAVEIS"

    'Variaveis usadas para edição de dados
    Private isEdit As Boolean = False
    Public idAreas As String

#End Region

#Region "LOAD"
    Private Sub configPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Alinhar o Grid
        MdiParent = principal

        CarregaComboModulos()

    End Sub
#End Region

#Region "POPULA COMBOS"

#Region "MODULOS"
    Sub CarregaComboModulos()
        With cmbSelecioneModulo
            .DataSource = Manager.Util.getDataTable("SELECT * FROM MODULOS_ISO")
            .DisplayMember = "NOME"
            .ValueMember = "ID_MODULOS_ISO"
        End With
    End Sub
#End Region

#End Region

#Region "SELECIONA MODULO"
    Private Sub cmbSelecioneModulo_ChangeCommitted(sender As System.Object, e As System.EventArgs)

        Select Case cmbSelecioneModulo.SelectedValue.ToString
            Case 1
            Case 2
            Case 3
            Case 4
            Case 5
            Case 6
            Case 7
                PanelFornecedores.Visible = True
            Case 8
            Case 9
            Case 10
            Case 11
            Case 12
            Case 13
        End Select
    End Sub
#End Region

#Region "MENU"

#Region "DEFINIÇÃO - AVALIAÇÃO"

#Region "CHAMA DEFINIÇÕES DE NOTAS"

#Region "CHAMA"
    Private Sub botMenuNotas_Click(sender As Object, e As System.EventArgs)
        PanelDefineNotas.BringToFront()
        PanelDefineNotas.Visible = True
    End Sub
#End Region

#Region "INCLUIR"
    Private Sub botDefineNotasOk_Click(sender As System.Object, e As System.EventArgs)

        Dim forAvalia As New FornecedorAvaliacao

        'VALIDAÇÃO
        Dim sql As String = String.Format("SELECT * FROM AVALIACAO_DEFINE_NOTAS")
        Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)
        Dim id As Integer

        Try
            If dr.HasRows = False Then

                'SALVAR
                If forAvalia.AddDefineNotas(txtMinimoNotaAva.Text) Then

                    MessageBox.Show("Definições Salvas com sucesso", "Definições de Avaliações", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtMinimoNotaAva.Text = ""

                End If

            Else

                While dr.Read
                    id = dr("ID_AVALIACAO_DEFINE_NOTAS").ToString
                End While

                If MessageBox.Show("O Item selecionado foi posteriormente Defindo, deseja continuar a operação ?", "Definições de Avaliações", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then

                    forAvalia.DeleteDefineNotas(id)

                    'SALVAR
                    If forAvalia.AddDefineNotas(txtMinimoNotaAva.Text) Then

                        MessageBox.Show("Definições Salvas com sucesso", "Definições de Avaliações", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtMinimoNotaAva.Text = ""

                    End If

                End If

            End If

        Catch ex As Exception
            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
        End Try

    End Sub
#End Region

#Region "CANCELAR"

    Private Sub botDefineNotasCancel_Click(sender As System.Object, e As System.EventArgs)
        PanelDefineNotas.Visible = False
    End Sub
#End Region

#End Region

#End Region

#End Region

End Class
