Imports ISOEFACIL.Manager.Util
Public Class principal

#Region "LOAD"

    Private Sub principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

#Region "CONFIGURAÇÕES"

#Region "SENHAS"
    Private Sub rbnSenhas_Click(sender As System.Object, e As System.EventArgs) Handles rbnSenhas.Click
        'FechaJanelas()
        configSenhasPrincipal.Show()
    End Sub
#End Region

#Region "OPÇOES DE SISTEMA"
    Private Sub rbnOpcoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnOpcoes.Click
        'VAI SER MODIFICADO
        '    docConfiguracao.Show()
        'FechaJanelas()
        configOpcoesPrincipal.Show()
    End Sub
#End Region

#Region "CADASTROS BASICOS"
    Private Sub rbnCadBasicos_Click(sender As System.Object, e As System.EventArgs) Handles rbnCadBasicos.Click
        'FechaJanelas()
        configListaBasico.Show()
    End Sub
#End Region

#Region "PREFERENCIAS DE USUÁRIO"
    Private Sub rbnPreferencias_Click(sender As System.Object, e As System.EventArgs) Handles rbnPreferencias.Click
        'FechaJanelas()
        ConfigPrefUsuarios.Show()
    End Sub
#End Region

#End Region

#Region "MANUAIS"

#Region "CONTROLE DE MANUAIS"

    Private Sub botCadManual_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles botCadManual.Click
        'FechaJanelas()
        mgListaControleManual.Show()
    End Sub

#End Region

#Region "ELABORAÇÃO DE MANUAIS"

    Private Sub cmdManualText0_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdManualText0.Click
        'FechaJanelas()
        mgListaElaboracaoManual.Show()
    End Sub

#End Region

#Region "ESCOPO"

    Private Sub botEscopo_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles botEscopo.Click
        'FechaJanelas()
        mgEscopo.ShowDialog()
    End Sub

#End Region

#End Region

#Region "DOCUMENTAÇÃO"

#Region "PRINCIPAL"
    Private Sub botCadDocumentacao_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles botCadDocumentacao.Click
        'FechaJanelas()
        DocContDoc.ShowDialog()
    End Sub
    Private Sub cmdConfiguraDoc_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles botConfiguraDoc.Click
        'FechaJanelas()
        docConfigDocs.ShowDialog()
    End Sub
    Private Sub CadDoc_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles botCadDoc.Click
        'FechaJanelas()
        DocContDoc.ShowDialog()
    End Sub
    Private Sub cmdElaborar_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles botElaborar.Click
        'FechaJanelas()
        'docElaborar.ShowDialog()
        docElaboracao.Show()
    End Sub
    Private Sub botRegistros_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles botRegistros.Click
        'FechaJanelas()
        docRegistros.ShowDialog()
    End Sub
    Private Sub botDocExterno_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles botDocExterno.Click
        'FechaJanelas()
        docExternos.ShowDialog()
    End Sub
#End Region

#End Region

#Region "MELHORIAS"

    Private Sub botCadMelhorias_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botCadMelhorias.Click
        'FechaJanelas()
        melListaMelhorias.Show()
    End Sub

#End Region

#Region "AUDITORIA"

#Region "TIPO DE AUDITORIAS"

    Private Sub botTipoAuditoria_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botTipoAuditoria.Click
        'FechaJanelas()
        audListaTipoAuditorias.Show()
    End Sub

#End Region

#Region "CADASTRO DE AUDITORES"

    Private Sub botCadAuditores_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botCadAuditores.Click
        'FechaJanelas()
        audListaAuditores.Show()
    End Sub

#End Region

#Region "REALIZAÇÃO DE AUDITORIAS"

    Private Sub cmdRealizaAuditoria_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles botRealizaAuditoria.Click
        'FechaJanelas()
        audRealizarAuditorias.ShowDialog()
    End Sub

#End Region

#Region "PROGRAMA ANUAL"
    Private Sub cmdProgramaAnual_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles botProgramaAnual.Click
        'FechaJanelas()
        audProgramacaoAuditorias.ShowDialog()
    End Sub
#End Region

#Region "CHECK LIST"

    Private Sub cmdCheckList_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles botCheckList.Click
        'FechaJanelas()
        audChecklist.ShowDialog()
    End Sub

#End Region

#End Region

#Region "COMPETENCIA E TREINAMENTO"

#Region "CARGOS"
    Private Sub botCargos_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botCargos.Click
        'FechaJanelas()
        cotrListaCargos.Show()
    End Sub
#End Region

#Region "TREINAMENTO"
    Private Sub botCadastroTreinamentos_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botCadastroTreinamentos.Click
        'FechaJanelas()
        cotrRealizacaoTreinamentos.ShowDialog()
    End Sub
#End Region

#Region "PLANO ANUAL"

    Private Sub botPlanoAnualTreinamento_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botPlanoAnualTreinamento.Click
        'FechaJanelas()
        cotrProgramacaoTreinamentos.ShowDialog()
    End Sub

#End Region

#Region "CURRICULO"

    Private Sub botCurriculo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botCurriculo.Click
        'FechaJanelas()
        cotrCurriculo.ShowDialog()
    End Sub

#End Region

#End Region

#Region "PRODUTOS & SERVIÇOS"

#Region "PRODUTOS"

    Private Sub botCalProdutos_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botCalProdutos.Click
        'FechaJanelas()
        prodListaProdutos.Show()
    End Sub

#End Region

#Region "PROCESSOS"

    Private Sub botCalProcessos_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botCalProcessos.Click
        'FechaJanelas()
        procListaProcessos.Show()
    End Sub

#End Region

#End Region

#Region "POLITICA & OBJETIVOS"

#Region "POLITICA"

    Private Sub cmdPolitica_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles botPolitica.Click
        'FechaJanelas()
        poliListaPolitica.Show()
    End Sub

#End Region

#Region "OBJETIVOS"

    Private Sub cmdObejtivos_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles botObjetivos.Click
        'FechaJanelas()
        objListaObjetivos.Show()
    End Sub

#End Region

#End Region

#Region "CALIBRAÇÃO"

#Region "CADASTRO"

    Private Sub botCadInstrumentos_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botCadInstrumentos.Click
        'FechaJanelas()
        calListaInstrumentos.Show()
    End Sub

#End Region

#Region "PROGRAMA ANUAL"

    Private Sub botProgramaAnaual_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botProgramaAnaual.Click
        'FechaJanelas()
        calProgramacaoCalibracao.ShowDialog()
    End Sub

#End Region

#Region "CALIBRAÇÕES"

    Private Sub botCalCalibracoes_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles botCalCalibracoes.Click
        'FechaJanelas()
        calRealizarCalibracoes.ShowDialog()
    End Sub

#End Region

#End Region

#Region "ANÁLISE CRÍTICA"

#Region "DADOS"

    Private Sub cmdDados_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles botDados.Click
        'FechaJanelas()
        acListaDados.Show()
    End Sub

#End Region

#Region "REUNIÕES"

    Private Sub cmdReunioes_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles botReunioes.Click
        'FechaJanelas()
        acListaReuniao.Show()
    End Sub

#End Region

#Region "DECISOES"

    Private Sub cmdDecisoes_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles botDecisoes.Click
        'FechaJanelas()
        acListaDecisoes.Show()
    End Sub

#End Region

#End Region

#Region "SATISFAÇÃO DE CLIENTES"

#Region "CADASTRO"

    Private Sub botCadClientes_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botCadClientes.Click
        'FechaJanelas()
        'cliListaClientes.Show()
    End Sub

#End Region

#Region "AVALIACAO"

    Private Sub botAvaliacaoClientes_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botAvaliacaoClientes.Click
        'FechaJanelas()
        'cliListaClientes.Show()
    End Sub

#End Region

#Region "RECLAMACAO"

    Private Sub botReclamacaoClientes_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botReclamacaoClientes.Click
        'FechaJanelas()
        'cliListaClientes.Show()
    End Sub

#End Region

#Region "OCORRENCIAS"

    Private Sub botOcorrenciaClientes_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botOcorrenciaClientes.Click
        'FechaJanelas()
        'cliListaClientes.Show()
    End Sub

#End Region

#End Region

#Region "AVALIAÇÃO DE FORNECEDORES"

#Region "FORNECEDORES"
    Private Sub botCadFornecedores_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles botCadFornecedores.Click
        'FechaJanelas()
        forListaFornecedores.Show()
    End Sub
#End Region

#Region "AVALIACAO"
    Private Sub botAvaliacaoFornecedor_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles botAvaliacaoFornecedor.Click
        'FechaJanelas()
        forListaAvaliacao.Show()
    End Sub
#End Region

#Region "PERFIL"
    Private Sub botPerfilFornecedores_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles botPerfilFornecedores.Click
        'FechaJanelas()
        forListaPerfil.Show()
    End Sub
#End Region

#Region "OCORRENCIA"
    Private Sub botOcorrenciaFornecedor_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles botOcorrenciaFornecedor.Click
        'FechaJanelas()
        forListaOcorrencias.Show()
    End Sub
#End Region

#End Region

#Region "PROJETOS"

#Region "LISTA CADASTRO DE PROJETOS"

    Private Sub cmdProjetos_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botListaProjetos.Click
        'FechaJanelas()
        projListaProjetos.Show()
    End Sub

#End Region

#Region "LISTA DE OCORRENCIAS"

    Private Sub cmdListaOcorrencias_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botListaOcorrencias.Click
        'FechaJanelas()
        projListaOcorrencias.Show()
    End Sub

#End Region

#Region "LISTA RESULTADOS DE PROJETOS"

    Private Sub cmdListaResultados_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles botListaResultados.Click
        'FechaJanelas()
        projListaResultados.Show()
    End Sub

#End Region

#End Region

End Class
