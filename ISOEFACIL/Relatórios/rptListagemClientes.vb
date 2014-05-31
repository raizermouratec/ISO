Imports System.Xml
'Imports ISOEFACIL.cliListaClientes
Public Class rptListagemClientes

    ''' <summary>
    ''' *Definições: 
    ''' [arquivo.xml]
    ''' [nome do relatório]
    ''' [Pasta onde está o arquivo]
    ''' [Query para o relatório]
    ''' </summary>
    Dim sNameXML As String = "rptListagemClientes.xml"
    Dim sNameRpt As String = "RPT_VW_LISTAGEM_CLIENTES"
    Dim sPasta As String = "Relatórios\XML"
    Dim sQuery As String = ("SELECT DISTINCT VW_LISTAGEM_CLIENTES.CLIENTE," & "CLIENTES.CNPJ," & "CLIENTES.CPF," &
                            "CLIENTES.NOME_FANTASIA, " & "VW_LISTAGEM_CLIENTES.ENDERECO, " & "VW_LISTAGEM_CLIENTES.BAIRRO," &
                            "VW_LISTAGEM_CLIENTES.CIDADE," & "VW_LISTAGEM_CLIENTES.ESTADO," & "VW_LISTAGEM_CLIENTES.TELEFONE_FIXO, " &
                            "VW_LISTAGEM_CLIENTES.EMAIL," & "VW_LISTAGEM_CLIENTES.WEBSITE " & "FROM  VW_LISTAGEM_CLIENTES, CLIENTES;")

    Private Sub rptListagemClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
