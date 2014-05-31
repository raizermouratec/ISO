Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Public Class forCadCriterios

#Region "CARREGAR LISTA"

    Public Sub carregaCriterios()

        'Carrega Lista
        gridCriterios.AutoGenerateColumns = False
        gridCriterios.DataSource = Manager.Util.getDataTable("SELECT * FROM CRITERIO_AVALIACAO")

    End Sub

#End Region

#Region "LOAD"

    Private Sub forCadCriterios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LISTA
        carregaCriterios()
    End Sub

#End Region

End Class
