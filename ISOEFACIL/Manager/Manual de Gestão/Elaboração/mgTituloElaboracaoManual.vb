Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1Chart
Imports C1.Win.C1ChartBase
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.mgListaElaboracaoManual
Public Class mgTituloElaboracaoManual

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditarTitulo As Boolean = False
    Public verif As Boolean = False
    Public idtitulo As String

    'Pega Id Titulo
    Public WriteOnly Property Titulo() As String
        Set(ByVal value As String)
            Me.idtitulo = value
        End Set
    End Property

#End Region

#Region "LOAD"

    Private Sub mgTituloItensManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarTitulo(ByVal id As Integer)

        'Editar
        isEdit = True

        'Muda o Label do botão Incluir
        botSalvar.Width = 80
        botSalvar.Text = "Atualizar"

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM ITEM_NORMA WHERE ID_ITEM_NORMA = {0}", id)

        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtTitulo.Text = dr("NORMA").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

#End Region

#Region "BOTOES"

#Region "SALVAR"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim titulo As New titulo

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If titulo.Update(idtitulo, _
                                     txtTitulo.Text) Then
                        mgListaElaboracaoManual.carregaLista()
                        MessageBox.Show("Título atualizado com sucesso", "Manual de Gestão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub Verificar()
        verif = False

        'Tratamento de erro Título
        If txtTitulo.Text = "" Then
            MessageBox.Show("Campo Título Obrigatório", "Manual de Gestão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTitulo.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "CANCELAR"

    Private Sub botCancelar_Click(sender As System.Object, e As System.EventArgs) Handles botCancelar.Click
        Me.Close()
    End Sub

#End Region

#End Region

End Class
