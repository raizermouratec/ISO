Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid

Public Class docContRevisar

#Region "VARIAVEIS"

    ''' Variavel global que contera o valor passado
    Public idDoc As String
    Public Revisao As String
    Public verif As Boolean = False

    ''' Pega Id 
    Public WriteOnly Property Documentos() As String
        Set(ByVal value As String)
            Me.idDoc = value
        End Set
    End Property

    ''' Pega Revisao
    Public WriteOnly Property Revisaos() As String
        Set(ByVal value As String)
            Me.Revisao = value
        End Set
    End Property

#End Region

#Region "Load"
    Private Sub docContRevisar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub AbriTela()
        Me.ShowDialog()
    End Sub
#End Region

#Region "BOTÕES"
    ''' <summary>
    ''' Salvar...
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click
        Dim classeDoc As New documentos
        Try
            'Salvar
            If classeDoc.AddResumoRevisao(idDoc, Revisao, txtResumoAlteracao.Text) Then
                MessageBox.Show("Resumo salvo com sucesso!", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                '//Atuliza Revisao na tabela de DOCUMENTOS...
                classeDoc.UpdateResumoRevisao(idDoc, Revisao, "Em Revisão")
                DocContDoc.carregarLista()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    ''' <summary>
    ''' Cancelar...
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botCancelar_Click(sender As System.Object, e As System.EventArgs) Handles botCancelar.Click
        Me.Close()
    End Sub
#End Region

End Class
