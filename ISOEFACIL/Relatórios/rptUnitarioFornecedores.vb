Imports System.Xml
Imports ISOEFACIL.forListaOcorrencias
Public Class rptUnitarioFornecedores

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

    Private Sub rptUnitarioFornecedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim id_Fornecedor As Integer = 0
        Dim Modulo As String
        id_Fornecedor = forListaFornecedores.gridFornecedores(forListaFornecedores.gridFornecedores.RowSel, 1)
        Modulo = "FORNECEDOR"

        sNameXML = "rptUnitarioFornecedores.xml"
        sNameRpt = "RPT_VW_LISTAGEM_FORNECEDORES"
        sPasta = "Relatórios\XML"
        sQuery = ("SELECT * FROM VW_LISTAGEM_FORNECEDORES WHERE CODIGO = " & id_Fornecedor)
        'sQuery = ("SELECT DISTINCT FORNECEDORES.NOME," &
        '"Fornecedores.CPF," &
        '"Fornecedores.NOME_FANTASIA," &
        '"Fornecedores.CNPJ," &
        '"Fornecedores.INSCRICAO_ESTAD," &
        '"Fornecedores.INSCRICAO_MUNIC," &
        '"Fornecedores.ENDERECO," &
        '"Fornecedores.BAIRRO," &
        '"Fornecedores.CIDADE," &
        '"Fornecedores.ESTADO," &
        '"Fornecedores.CEP," &
        '"Fornecedores.COMPLEMENTO," &
        '"Fornecedores.TELEFONE_01," &
        '"Fornecedores.TELEFONE_02, " &
        '"Fornecedores.TELEFONE_03, " &
        '"Fornecedores.EMAIL, " &
        '"Fornecedores.WEBSITE, " &
        '"Fornecedores.SKYPE, " &
        '"FORNECEDORES_PROD_SERV.DESCRICAO, " &
        '"FORNECEDORES_PROD_SERV.CRITICO," &
        '"Contatos.NOME," &
        '"Contatos.CARGO," &
        '"Contatos.TELEFONE_FIXO," &
        '"Contatos.TELEFONE_CELULAR," &
        '"Contatos.TELEFONE_FAX," &
        '"Contatos.EMAIL," &
        '"Contatos.SKYPE" &
        '"FROM  FORNECEDORES, FORNECEDORES_PROD_SERV, CONTATOS WHERE FORNECEDORES.ID_FORNECEDOR =" & id_Fornecedor & "and FORNECEDORES_PROD_SERV.ID_FORNECEDOR = " & id_Fornecedor & " and CONTATOS.MODULO = " & Modulo)
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
