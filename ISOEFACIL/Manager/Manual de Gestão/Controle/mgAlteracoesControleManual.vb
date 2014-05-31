Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Public Class mgAlteracoesControleManual

#Region "VARIAVEIS"

    Public idAlteracoesControleManuais As String

    'Pega Id 
    Public WriteOnly Property AlteracoesControleManuais() As String
        Set(ByVal value As String)
            Me.idAlteracoesControleManuais = value
        End Set
    End Property

#End Region

#Region "LOAD"

    Private Sub mgAlteracoesControleManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class
