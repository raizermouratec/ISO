Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ISOEFACIL.forCadFornecedores
Imports ISOEFACIL.forListaOcorrencias
Public Class forCadRequisitos

#Region "VARIÁVEIS"

    Private isEditRequisitos As Boolean = False

    'Variavel global que contera o valor passado 
    Private idFornecedor As String
    Private idRequisito As String
    Public verif As Boolean = False

    'Pega Id Fornecedor
    Public WriteOnly Property fornecedor() As String
        Set(ByVal value As String)
            Me.idFornecedor = value
        End Set
    End Property

    'Pega Id Requisitos
    Public WriteOnly Property requisito() As String
        Set(ByVal value As String)
            Me.idRequisito = value
        End Set
    End Property

#End Region

#Region "CARREGAR LISTA"

    Public Sub carregaRequisitos()

        'Monta o Grid Prod/Serv
        gridRequisitos.AutoGenerateColumns = False
        gridRequisitos.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_FORNECEDORES_REQUISITOS")

    End Sub

#End Region

#Region "LOAD"

    Private Sub forCadRequisitos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaRequisitos()
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoRequisito()
        'Cadastrar Novo
        idRequisito = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "INCLUIR"

    Private Sub botAdd_Click(sender As Object, e As EventArgs) Handles botAdd.Click

        'Seta a Classe
        Dim requisitos As New requisitos

        'Inicio Atualizar/Salvar
        If isEditRequisitos = True Then

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If requisitos.Update(idRequisito, _
                                         txtRequisitos.Text) Then
                        MessageBox.Show("Dados atualizados com sucesso", "Requisitos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtRequisitos.Text = ""
                        botAdd.Text = "Incluir"
                        carregaRequisitos()
                        isEditRequisitos = False
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            Dim idRequisito As Integer = 0

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If requisitos.Add(txtRequisitos.Text, _
                                      False) Then
                        MessageBox.Show("Novo Requisito incluído com sucesso", "Requisitos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        carregaRequisitos()
                        txtRequisitos.Text = ""
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

#Region "VERIFICAR CAMPOS"

    Sub Verificar()
        verif = False

        'Tratamento de erro Requisito
        If txtRequisitos.Text = "" Then
            MessageBox.Show("Campo Requisito Obrigatório", "Requisitos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRequisitos.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#End Region

#Region "EDITAR"

#Region "EDITAR"

    Public Sub EditarRequisitos(ByVal id As Integer)

        'Editar
        isEditRequisitos = True

        'Seleciona Produtos/Serviços pelo Id
        Dim sql As String = String.Format("SELECT * FROM FORNECEDORES_REQUISITOS WHERE ID_REQUISITOS = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read
                Me.txtRequisitos.Text = dr("DESCRICAO").ToString
            End While

        Catch ex As Exception

            carregaRequisitos()

        End Try

    End Sub

#End Region

#Region "ALTERAR"

    Private Sub botEditar_Click(sender As Object, e As EventArgs) Handles botEditar.Click

        If gridRequisitos.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Requisitos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim id As Integer = 0

            'Muda o Label do botão Incluir
            botAdd.Text = "Atualizar"

            'Passagem de parametros
            Try

                id = gridRequisitos(gridRequisitos.RowSel, 1)
                EditarRequisitos(id)
                idRequisito = id
                'txtIDProdServ.Text = id

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

#End Region

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As Object, e As EventArgs) Handles botExcluir.Click

        If gridRequisitos.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Requisitos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim requisitos As New requisitos

            'Exclui Requisitos
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Requisitos", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    requisitos.Delete(gridRequisitos(gridRequisitos.RowSel, 1))
                    MessageBox.Show("Requisito excluído com sucesso", "Requisitos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    carregaRequisitos()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub

#End Region

#Region "VALIDAÇÃO DE CAMPOS"

#Region "VALIDAÇÃO NO VALIDATING"

    'Private Sub txtRequisitos_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRequisitos.Validating

    '    'If txtRequisitos.Text.Trim().Length = 0 Then
    '    '    txtRequisitos.ErrorText = BuildErrorTip(txtRequisitos, "Informe a Descrição do Requisito")
    '    '    e.Cancel = True
    '    'Else
    '    '    txtRequisitos.ErrorText = String.Empty
    '    'End If

    'End Sub

#End Region

#Region "VALIDAÇÃO NO LOSTFOCUS"

    Private Sub txtRequisitos_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRequisitos.LostFocus

        'FAZER VALIDAÇÃO DE PREENCHIMENTO DE CAMPOS
        If txtRequisitos.Text.Trim().Length = 0 Then
            txtRequisitos.ErrorText = BuildErrorTip(txtRequisitos, "Informe a Descrição do Requisito")
        Else
            txtRequisitos.ErrorText = String.Empty
        End If

    End Sub

#End Region

#Region "FORMATAÇÃO DE MSG"

    Public Function BuildErrorTip(ByVal c As C1.Win.C1InputPanel.InputComponent, ByVal err As String) As String

        Return String.Format( _
             "{0}<table><tr>" + _
         "<tr style='vertical-align:top;'>" + _
         "<td>{1}</table>", _
         c.ToolTipText, _
         err)
    End Function

#End Region

#End Region
   
End Class
