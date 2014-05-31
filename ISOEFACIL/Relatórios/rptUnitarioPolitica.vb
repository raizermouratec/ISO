Imports System.Xml
Imports ISOEFACIL.poliListaPolitica
Public Class rptUnitarioPolitica

    ''' <summary>
    ''' *Definições: 
    ''' [arquivo.xml]
    ''' [nome do relatório]
    ''' [Pasta onde está o arquivo]
    ''' [Query para o relatório]
    ''' </summary>
    Dim sNameXML As String
    Dim sNameRpt As String
    Dim sPasta As String
    Dim sQuery As String

    Private Sub rptUnitarioPolitica_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim id As Integer = 0
        id = poliListaPolitica.gridPolitica(poliListaPolitica.gridPolitica.RowSel, 1)

        sNameXML = "rptUnitarioPolitica.xml"
        sNameRpt = "RPT_VW_LISTAGEM_POLITICA"
        sPasta = "Relatórios\XML"
        sQuery = ("SELECT * FROM VW_LISTAGEM_POLITICA WHERE ID_POLITICA = " & id)

        LoadReports()
    End Sub

    ''' <summary>
    ''' Metodo para pegar o caminho do Arquivo.
    ''' </summary>
    Public Function GetFilePath(FileName As String) As String

        Dim path As String = Application.StartupPath
        Dim pos As Integer = path.IndexOf("\bin")
        path = path.Substring(0, pos) & "\" & sPasta & "\" & FileName

        Return path

    End Function
    ''' <summary>
    ''' Load Report
    ''' </summary>
    Sub LoadReports()
        _rpt.Load(GetFilePath(sNameXML), sNameRpt)
        _rpt.DataSource.Recordset = Manager.Util.getDataTable(sQuery)
        _rpt.DataSource.RecordSource = sQuery
        C1PrintPreviewControl1.Document = _rpt
    End Sub
    Public Sub AlterConnection()
        Dim doc As New XmlDocument()
        Dim node As XmlNode
        Dim path As String = GetFilePath(sNameXML)

        doc.Load(path)
        node = doc.DocumentElement

        Dim node2 As XmlNode 'Used for internal loop.
        Dim nodePriceText As XmlNode
        For Each node In node.ChildNodes
            For Each node2 In node.ChildNodes
                If node2.Name = "DataSource" Then
                    For Each nodePriceText In node2.ChildNodes
                        If nodePriceText.Name = "ConnectionString" Then
                            Dim newvalue As String
                            newvalue = My.Settings.connectionString
                            nodePriceText.InnerText = newvalue
                        End If
                    Next
                End If
            Next
        Next
        doc.Save(path)
        LoadReports()
    End Sub


End Class
