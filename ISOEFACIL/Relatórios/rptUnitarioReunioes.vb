Imports System.Xml
Imports ISOEFACIL.acListaReuniao
Public Class rptUnitarioReunioes

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

    Private Sub rptUnitarioReunioes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim id As Integer = 0
        id = acListaReuniao.gridReunioes(acListaReuniao.gridReunioes.RowSel, 1)

        sNameXML = "rptUnitarioReunioes.xml"
        sNameRpt = "RPT_VW_LISTAGEM_REUNIOES"
        sPasta = "Relatórios\XML"
        sQuery = ("SELECT * FROM VW_LISTAGEM_ANALISE_CRITICA_REUNIOES WHERE ID_ANALISE_CRITICA_REUNIOES = " & id)
        'sQuery = ("SELECT DISTINCT VW_LISTAGEM_ANALISE_CRITICA_REUNIOES.RESPONSAVEL," &
        '"VW_LISTAGEM_ANALISE_CRITICA_REUNIOES.DATA," &
        '"VW_LISTAGEM_ANALISE_CRITICA_REUNIOES.TIPO," &
        '"ANALISE_CRITICA_REUNIOES.REUNIOES" &
        '"FROM  VW_LISTAGEM_ANALISE_CRITICA_REUNIOES, ANALISE_CRITICA_REUNIOES" &
        '"WHERE VW_LISTAGEM_ANALISE_CRITICA_REUNIOES.ID_ANALISE_CRITICA_REUNIOES = " & id &
        '"AND ANALISE_CRITICA_REUNIOES.ID_ANALISE_CRITICA_REUNIOES = " & id)
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
