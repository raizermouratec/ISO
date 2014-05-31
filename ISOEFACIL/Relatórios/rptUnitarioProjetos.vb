Imports System.Xml
Imports ISOEFACIL.projListaProjetos
Imports ISOEFACIL.projPlanodeProjeto
Public Class rptUnitarioProjetos

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

        Dim id_Projeto As Integer = 0
        id_Projeto = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)

        sNameXML = "rptUnitarioProjetos.xml"
        sNameRpt = "RPT_VW_LISTAGEM_PROJETOS"
        sPasta = "Relatórios\XML"
        sQuery = ("SELECT * FROM VW_LISTAGEM_PROJETOS WHERE ID_PROJETOS = " & id_Projeto & "SELECT * FROM VW_LISTAGEM_PROJETOS_PLANO_SAIDAS WHERE PROJETOS = " & id_Projeto)
        'sQuery = ("SELECT DISTINCT VW_LISTAGEM_PROJETOS.IDENTIFICACAO," &
        '"VW_LISTAGEM_PROJETOS.TITULO," &
        '"VW_LISTAGEM_PROJETOS.RESPONSAVEL," &
        '"VW_LISTAGEM_PROJETOS.TIPO," &
        '"VW_LISTAGEM_PROJETOS.INICIO," &
        '"VW_LISTAGEM_PROJETOS.TERMINO," &
        '"VW_LISTAGEM_PROJETOS.APROVADOR," &
        '"VW_LISTAGEM_PROJETOS.DATA_APROVADOR," &
        '"PROJETOS.REVISAO," &
        '"PROJETOS_PLANO_OBJETIVOS_TEXTO.OBJETIVO_GERAL," &
        '"PROJETOS_PLANO_OBJETIVOS_TEXTO.TEXTO," &
        '"PROJETOS_PLANO_ESCOPO.ESPECIFICADOS," &
        '"PROJETOS_PLANO_ESCOPO.ESTATUARIOS," &
        '"PROJETOS_PLANO_ESCOPO.REGULAMENTARES," &
        '"PROJETOS_PLANO_ESCOPO.OUTROS," &
        '"PROJETOS_PLANO_ESCOPO.INFORMACOES," &
        '"PROJETOS_PLANO_ESCOPO.EXCLUSAO," &
        '"PROJETOS_PLANO_SAIDAS.SAIDAS," &
        '"PROJETOS_PLANO_ESTAGIOS_ATIVIDADE.N_SEQUENCIAL," &
        '"PROJETOS_PLANO_ESTAGIOS_ATIVIDADE.ATIVIDADE," &
        '"PROJETOS_PLANO_ESTAGIOS_ATIVIDADE.ID_COLABORADORES," &
        '"PROJETOS_PLANO_ESTAGIOS_ATIVIDADE.INICIO," &
        '"PROJETOS_PLANO_ESTAGIOS_ATIVIDADE.TERMINO," &
        '"PROJETOS_PLANO_ESTAGIOS_ATIVIDADE.OBS," &
        '"PROJETOS_PLANO_RECURSOS.TIPO," &
        '"PROJETOS_PLANO_RECURSOS.RECURSOS," &
        '"PROJETOS_PLANO_RECURSOS.QUANTIDADE," &
        '"PROJETOS_PLANO_RECURSOS.VALOR_TOTAL," &
        '"PROJETOS_PLANO_CONTROLE_AC.METODO," &
        '"PROJETOS_PLANO_CONTROLE_AC.PROGRAMACAO," &
        '"PROJETOS_PLANO_CONTROLE_VERIFICACAO.METODO," &
        '"PROJETOS_PLANO_CONTROLE_VERIFICACAO.PROGRAMACAO," &
        '"PROJETOS_PLANO_CONTROLE_VALIDACAO.METODO," &
        '"PROJETOS_PLANO_CONTROLE_VALIDACAO.PROGRAMACAO" &
        '"FROM (VW_LISTAGEM_PROJETOS, PROJETOS, PROJETOS_PLANO_OBJETIVOS_TEXTO, PROJETOS_PLANO_ESCOPO," &
        '"PROJETOS_PLANO_SAIDAS, PROJETOS_PLANO_ESTAGIOS_ATIVIDADE, PROJETOS_PLANO_RECURSOS, PROJETOS_PLANO_CONTROLE_AC," &
        '"PROJETOS_PLANO_CONTROLE_VERIFICACAO, PROJETOS_PLANO_CONTROLE_VALIDACAO)" &
        '"WHERE(VW_LISTAGEM_PROJETOS.ID_PROJETOS = " & id_Projeto & " AND PROJETOS_PLANO_OBJETIVOS_TEXTO.ID_PROJETOS = " & id_Projeto & " AND PROJETOS_PLANO_ESCOPO.ID_PROJETOS = " & id_Projeto &
        '"AND PROJETOS_PLANO_SAIDAS.ID_PROJETOS = " & id_Projeto & " AND PROJETOS_PLANO_ESTAGIOS_ATIVIDADE.ID_PROJETOS = " & id_Projeto & " AND PROJETOS_PLANO_RECURSOS.ID_PROJETOS = " & id_Projeto &
        '"AND PROJETOS_PLANO_CONTROLE_AC.ID_PROJETOS = " & id_Projeto & " AND PROJETOS_PLANO_CONTROLE_VERIFICACAO.ID_PROJETOS = " & id_Projeto & " AND PROJETOS_PLANO_CONTROLE_VALIDACAO.ID_PROJETOS = " & id_Projeto)
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
