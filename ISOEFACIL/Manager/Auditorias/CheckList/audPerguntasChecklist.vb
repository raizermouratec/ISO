Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Public Class audPerguntasChecklist

#Region "VARIAVEIS"

    Private isEdit As Boolean = False
    Public idPergunta As String

    Public idID
    Public idItem As String
    Public idNormas As String

    Public WriteOnly Property Perguntas() As String
        Set(ByVal value As String)
            Me.idPergunta = value
        End Set
    End Property

    Public WriteOnly Property ID() As String
        Set(ByVal value As String)
            Me.idID = value
        End Set
    End Property

    Public WriteOnly Property Item() As String
        Set(ByVal value As String)
            Me.idItem = value
        End Set
    End Property

    Public WriteOnly Property Normas() As String
        Set(ByVal value As String)
            Me.idNormas = value
        End Set
    End Property

#End Region

#Region "LOAD"
    Private Sub audPerguntasChecklist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txtPergunta.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")

    End Sub
#End Region

#Region "NOVO"

    Public Sub Novo()
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "BOTÕES"

#Region "SALVAR"
    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        Dim check As New CheckList

        'Editar
        'If isEditq Then



        'Else

        If check.AddPerguntas(idID, idItem, txtPergunta.Text) Then
            MessageBox.Show("Dados salvos com sucesso!", "Perguntas Checklist", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            audChecklist.LimpaAllChecks()
            check.UpdateTudo(0)
            Me.Close()
        End If
        '  End If


    End Sub
#End Region

#End Region
    
End Class
