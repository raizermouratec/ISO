Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Public Class audConformidadeAuditoria

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditConformidade As Boolean = False
    Public idConformidade As String

    'Pega Id Registro
    Public WriteOnly Property Conformidade() As String
        Set(ByVal value As String)
            Me.idConformidade = value
        End Set
    End Property

#End Region

#Region "LOAD"

    Private Sub audConformidadeAuditoria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

#End Region

#Region "BOTOES"

#Region "CONFORMIDADES"

    Private Sub botConformidades_Click(sender As System.Object, e As System.EventArgs) Handles botConformidades.Click
        audEvidenciaConformidade.Show()
    End Sub

#End Region

#End Region

End Class
