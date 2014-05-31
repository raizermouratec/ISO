Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid

Public Class docContCancelar

#Region "VARIAVEIS"

    ''' Variavel global que contera o valor passado
    Public idDoc As String
    Public verif As Boolean = False

    ''' Pega Id 
    Public WriteOnly Property Documentos() As String
        Set(ByVal value As String)
            Me.idDoc = value
        End Set
    End Property

#End Region

#Region "LOAD"
    Private Sub docContCancelar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub AbriTela()
        Me.ShowDialog()
    End Sub
#End Region

#Region "BOTÕES"
    ''' <summary>
    ''' Salvar Cancelamento...
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click
        Dim classeDoc As New documentos
        Try
            If classeDoc.AddCancelamento(idDoc, txtCancelamento.Text) Then
                MessageBox.Show("Documento Cancelado com sucesso!", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                '//Atuliza status na tabela de DOCUMENTOS...
                classeDoc.UpdateCancelamento(idDoc, "Em cancelamento")
                DocContDoc.carregarLista()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub
    ''' <summary>
    ''' Sair do Cancelamento...
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botCancelar_Click(sender As System.Object, e As System.EventArgs) Handles botCancelar.Click
        Me.Close()
    End Sub
#End Region
    
End Class
