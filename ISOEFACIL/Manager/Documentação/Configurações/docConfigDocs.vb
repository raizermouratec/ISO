Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Public Class docConfigDocs

    Private ANEXO() As Byte
    Protected Shared strTipo As String
    Protected Shared idTipoDocComp As Integer
    Protected Shared idTpDoc As Integer
    Private isEdit As Boolean = False

    'Variavel para verificar se a tela já esta aberta 
    Public idVerifivcar_open As Boolean = False

#Region "LOAD"

    Private Sub docConfigDocs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListBox1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        ListBox2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        carregarTipoDoc()
        carregarTipoDocComposicao()
        carregarListComposicao()
        carregaListAtividades()
        CarregaComboCargos()
    End Sub

#End Region

#Region "CARREGAR LISTA"

    ''' <summary>
    ''' Carrega a lista de tipos de documentos.
    ''' </summary>
    Public Sub carregarTipoDoc()
        Dim dtb As New DataTable
        'Carrega Lista
        gridTpDoc.AutoGenerateColumns = False
        dtb = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_DOCUMENTO_CONFIG_TP_DOCUMENTO")
        gridTpDoc.DataSource = dtb

    End Sub
    ''' <summary>
    ''' Carrega a lista de tipos de documentos Composição.
    ''' </summary>
    Public Sub carregarTipoDocComposicao()
        Dim dtb As New DataTable
        'Carrega Lista
        gridTpDocComposicao.AutoGenerateColumns = False
        dtb = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_DOCUMENTO_CONFIG_TP_DOCUMENTO WHERE MODO_ELABORACAO <> 'Anexar'")
        gridTpDocComposicao.DataSource = dtb
    End Sub
    ''' <summary>
    ''' Carrega a lista de tipos de Composicao.
    ''' </summary>
    Public Sub carregarListComposicao()
        Try
            ListBox1.Items.Add("Área")
            ListBox1.Items.Add("Tipo Documento")
            ListBox1.Items.Add("Número Sequêncial 01")
            ListBox1.Items.Add("Número Sequêncial 001")
        Catch ex As Exception
        End Try
    End Sub
    ''' <summary>
    ''' Carrega a Lista de Atividades.
    ''' </summary>
    Public Sub carregaListAtividades()
        Dim dtb As New DataTable
        'Carrega Lista
        gridAtvdDoc.AutoGenerateColumns = False
        dtb = Manager.Util.getDataTable("SELECT * FROM DOCUMENTO_ATIVIDADE_TP_DOCUMENTO")
        gridAtvdDoc.DataSource = dtb
    End Sub

    Public Sub carregaListCargoAprovador(ByVal idcargos As Integer)
        Dim dtb As New DataTable
        'Carrega Lista
        gridUsuarioAprovador.AutoGenerateColumns = False

        Dim sql As String = String.Format("SELECT ID_COLABORADORES, CHECKS, COLABORADOR FROM COLABORADORES CB JOIN CARGOS CA ON CB.ID_CARGOS = CA.ID_CARGOS WHERE CB.SITUACAO = 1 AND CA.ID_CARGOS = {0}", idcargos)

        ' Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

        dtb = Manager.Util.getDataTable(sql)

        'dtb = Manager.Util.getDataTable("SELECT ID_COLABORADORES, CHECKS, COLABORADOR FROM COLABORADORES WHERE SITUACAO = 1")
        gridUsuarioAprovador.DataSource = dtb
    End Sub

    Public Sub carregaListCargoAprovadorSelecionado()
        Dim dtb As New DataTable
        'Carrega Lista
        gridAprovadoresSelecionados.AutoGenerateColumns = False
        dtb = Manager.Util.getDataTable("SELECT ID_COLABORADORES, COLABORADOR FROM COLABORADORES WHERE CHECKS = 1")
        gridAprovadoresSelecionados.DataSource = dtb
    End Sub


#End Region

#Region "ATUALIZA CHECK"

    ''' <summary>
    ''' Grid Tipo Coomposição.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gridTpDocComposicao_Click(sender As System.Object, e As System.EventArgs) Handles gridTpDocComposicao.Click
        With gridTpDocComposicao
            If .ColSel > 0 Then
                Try
                    If .Item(.RowSel, .ColSel) = True Then
                        txtPreVi01.Text = String.Empty
                        .Item(.RowSel, .ColSel) = False
                    Else
                        strTipo = .Item(.RowSel, 4).ToString
                        txtPreVi01.Text = strTipo
                        .Item(.RowSel, .ColSel) = True
                    End If
                    idTipoDocComp = .Item(.RowSel, 1)
                Catch ex As Exception
                    'MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
        End With
    End Sub
    ''' <summary>
    ''' Grid ATividades
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gridAtvdDoc_Click(sender As System.Object, e As System.EventArgs) Handles gridAtvdDoc.Click
        With gridAtvdDoc
            If .ColSel > 0 Then
                Dim Check As New ConfiguracaoDoc
                Dim id As Integer
                Dim Atividade As Boolean
                Try
                    If .Item(.RowSel, .ColSel) = True Then
                        Atividade = False
                        .Item(.RowSel, .ColSel) = False
                    Else
                        Atividade = True
                        .Item(.RowSel, .ColSel) = True
                    End If
                    id = .Item(.RowSel, 1)
                    Check.UpdateMultiploAtividade(id, Atividade)
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
        End With
    End Sub
    ''' <summary>
    ''' Grid Aprovadores Selecionados.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gridUsuarioAprovador_Click(sender As System.Object, e As System.EventArgs) Handles gridUsuarioAprovador.Click
        With gridUsuarioAprovador
            If .ColSel > 0 Then
                Dim Check As New ConfiguracaoDoc
                Dim id As Integer
                Dim Aprovado As Boolean
                Try
                    If .Item(.RowSel, .ColSel) = True Then
                        Aprovado = False
                        .Item(.RowSel, .ColSel) = False
                    Else
                        Aprovado = True
                        .Item(.RowSel, .ColSel) = True
                    End If
                    id = .Item(.RowSel, 1)
                    Check.UpdateMultiploAprovador(id, Aprovado)
                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try
            End If
        End With
    End Sub

#End Region

#Region "POPULA COMBOS"

#Region "Cargos"

    Sub CarregaComboCargos()
        With cmbCargoAprovador
            .DataSource = Manager.Util.getDataTable("SELECT * FROM CARGOS WHERE APROVADOR = 1")
            .DisplayMember = "NOME"
            .ValueMember = "ID_CARGOS"
        End With
    End Sub

#End Region

#End Region

#Region "ABA CONFIGURAÇÃO"

#Region "BOTÕES"

#Region "NOVO"
    Private Sub botAddTipo_Click(sender As System.Object, e As System.EventArgs) Handles botAddTipo.Click
        Dim frm As New docConfigAddDocs
        frm.NovoAddDocs()
    End Sub
#End Region

#Region "EDITAR"
    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click
        If idVerifivcar_open = True Then
        Else
            Dim frm As New docConfigAddDocs
            Dim id As Integer = 0

            'Passagem de parametros
            Try

                id = gridTpDoc(gridTpDoc.RowSel, 1)
                frm.EditarTipoDoc(id)
                frm.idTipoDoc = id

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If

    End Sub
#End Region

#Region "EXCLUIR"
    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click
        If gridTpDoc.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Configuração Tipos de documento", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim classConfig As New ConfiguracaoDoc
            Try

                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Configuração Tipos de documento", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    classConfig.Deletefm(gridTpDoc(gridTpDoc.RowSel, 1))
                    MessageBox.Show("Item excluído com sucesso", "Configuração Tipos de documento", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    carregarTipoDoc()
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region

#End Region

#End Region

#Region "ABA COMPOSIÇÃO"

#Region "BOTÕES"

#Region "SALVAR"
    Private Sub botSalvarComposicao_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarComposicao.Click

        '// Vaidação dos campos...
        If txtPreVi01.Text = String.Empty Then
            MessageBox.Show("Por favor informe todos os campos!", "Composição da Codificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtPreVi02.Text = String.Empty Then
            MessageBox.Show("Por favor informe todos os campos!", "Composição da Codificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtPreVi03.Text = String.Empty Then
            MessageBox.Show("Por favor informe todos os campos!", "Composição da Codificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtPreVi04.Text = String.Empty Then
            MessageBox.Show("Por favor informe todos os campos!", "Composição da Codificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim classConfig As New ConfiguracaoDoc

            Dim dtb As New DataTable
            Dim sql As String = String.Format("select * from DOCUMENTO_COMP_TP_DOCUMENTO WHERE ID_DOCUMENTO_CONFIG_TP_DOCUMENTO = '{0}'", idTipoDocComp)
            dtb = Manager.Util.getDataTable(sql)

            Try
                If dtb.Rows.Count <= 0 Then
                    If classConfig.AddCp(idTipoDocComp, txtPreVi02.Text, txtPreVi03.Text, txtPreVi04.Text) Then
                        MessageBox.Show("Nova Composição salva com sucesso!", "Composição da Codificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        carregarTipoDocComposicao()
                        LimpaCampos()
                    End If
                Else
                    If classConfig.UpdateCp(idTipoDocComp, txtPreVi02.Text, txtPreVi03.Text, txtPreVi04.Text) Then
                        MessageBox.Show("Composição Atualizada com sucesso!", "Composição da Codificação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        carregarTipoDocComposicao()
                        LimpaCampos()
                    End If
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region

#Region "EDITAR"
    Private Sub botEditarComposicao_Click(sender As System.Object, e As System.EventArgs) Handles botEditarComposicao.Click
        isEdit = True
        gridTpDocComposicao.Enabled = False

    End Sub
#End Region

#Region "BOTÃO =>"
    ''' <summary>
    ''' Botão [ => ] 
    ''' </summary>
    Private Sub C1Button2_Click(sender As System.Object, e As System.EventArgs) Handles C1Button2.Click
        Try
            If ListBox1.Text = "" Then
                MsgBox("Por favor, selecione um item primeiro..", MsgBoxStyle.Information)
            Else
                Dim a As Integer
                a = ListBox1.Items.IndexOf(ListBox1.Text)
                ListBox2.Items.Add(ListBox1.Items.Item(a))
                If (Me.txtPreVi02.Text = "") Then
                    Me.txtPreVi02.Text = (ListBox1.Items.Item(a))
                ElseIf (Me.txtPreVi03.Text = "") Then
                    Me.txtPreVi03.Text = (ListBox1.Items.Item(a))
                Else
                    Me.txtPreVi04.Text = (ListBox1.Items.Item(a))
                End If
                ListBox1.Items.Remove(ListBox1.Items.Item(a))
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "BOTÃO <="
    Private Sub C1Button1_Click(sender As System.Object, e As System.EventArgs) Handles C1Button1.Click
        Dim a As Integer
        Dim b As String
        Try
            If ListBox2.Text = "" Then
                MsgBox("Por favor, selecione um item primeiro..", MsgBoxStyle.Information)
            Else
                a = ListBox2.Items.IndexOf(ListBox2.Text)
                ListBox1.Items.Remove(ListBox2.Items.Item(a))
                ListBox1.Items.Add(ListBox2.Items.Item(a))
                b = (ListBox2.Items.Item(a))
                ListBox2.Items.RemoveAt(a)
                If (b = Me.txtPreVi02.Text) Then
                    Me.txtPreVi02.Text = ""
                ElseIf (b = Me.txtPreVi03.Text) Then
                    Me.txtPreVi03.Text = ""
                Else
                    Me.txtPreVi04.Text = ""
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "METODOS"
    Private Sub LimpaCampos()
        '//Limpa campos...
        txtPreVi01.Text = String.Empty
        txtPreVi02.Text = String.Empty
        txtPreVi03.Text = String.Empty
        txtPreVi04.Text = String.Empty
        '//Limpa Listas...
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        '//Carrega Lista...
        carregarListComposicao()
        'Limpa Cheks...
        LimpaAllChecks()
    End Sub
    Public Sub LimpaAllChecks()
        With gridTpDocComposicao
            .Item(.RowSel, .ColSel) = False
        End With
    End Sub
#End Region

#End Region

#End Region

#Region "ABA APROVADORES"

    ''' <summary>
    ''' Carrega Lista de Cargo Aprovador.
    ''' </summary>
    ''' 
    Private Sub cmbCargoAprovador_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbCargoAprovador.SelectedValueChanged
        selecionavalor()
    End Sub

    Private Sub selecionavalor()
        If cmbCargoAprovador.ValueMember <> "" Then
            Dim id As Integer

            If cmbCargoAprovador.SelectedValue.ToString = String.Empty Then
                MessageBox.Show("Não existe Cargo no Sistema", "Alerta", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
            Else
                id = cmbCargoAprovador.SelectedValue
                carregaListCargoAprovador(id)
            End If

        End If
    End Sub

#Region "BOTÕES"
    ''' <summary>
    ''' Botão Salvar.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botSalvarAprovador_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarAprovador.Click
        If MsgBox("Deseja realmente Atribuir a função de aprovador para os colaboradores selecionados ?", MsgBoxStyle.YesNo, "Configurações") = MsgBoxResult.Yes Then
            Dim classe As New colaboradores
            Dim id As String
            Dim i As Integer = 1
            Dim j As Integer = 1
            Dim idAreas As Integer = 0
            Dim idCargos As Integer = 0
            Dim sColaborador As String = ""
            Dim sEmail As String = ""
            Dim bSituacao As Boolean
            Dim bAprovador As Boolean
            Dim bChecks As Boolean
            Do While i < gridAprovadoresSelecionados.Rows.Count
                With gridAprovadoresSelecionados
                    If .RowSel > 0 Then
                        Try
                            id = .Item(j, 1)
                            Dim sql As String = String.Format("SELECT * FROM COLABORADORES WHERE ID_COLABORADORES = {0}", id)
                            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)
                            While dr.Read
                                idAreas = dr("ID_AREAS")
                                idCargos = dr("ID_CARGOS")
                                sColaborador = dr("COLABORADOR")
                                bSituacao = dr("SITUACAO")
                                bAprovador = dr("APROVADOR")
                                bChecks = dr("CHECKS")
                            End While
                            classe.Update(id, idAreas, idCargos, sColaborador, sEmail, bSituacao, True, False)
                        Catch ex As Exception
                            MessageBox.Show("Não foi possivel realizar a operação. Tente novamente.", "Configurações", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                    End If
                End With
                i += 1
                j = j + 1
            Loop
            MessageBox.Show("Ação Realizada com sucesso", "Configurações", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    ''' <summary>
    ''' Botão Cancelar.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botCancelarAprovador_Click(sender As System.Object, e As System.EventArgs) Handles botCancelarAprovador.Click
        '   ***OQUE FAZ....
        If MsgBox("Deseja realmente Cancelar a Operação a função de aprovador para os colaboradores selecionados ?", MsgBoxStyle.YesNo, "Configurações") = MsgBoxResult.Yes Then

        End If
        '   UPDATE MULTIPLO PARA CHECK 0 COM TODOS OS DA LISTA
    End Sub
    ''' <summary>
    ''' Adiciona na Lista os Aprovadores selecionados.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub botAddAprovador_Click(sender As System.Object, e As System.EventArgs) Handles botAddAprovador.Click
        carregaListCargoAprovadorSelecionado()
    End Sub
#End Region

#End Region

#Region "ABA ATIVIDADES"

#Region "BOTÕES"
    Private Sub botSalvarAtividades_Click(sender As System.Object, e As System.EventArgs) Handles botSalvarAtividades.Click
        MessageBox.Show("Ação Realizada com sucesso", "Configurações", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region

#End Region

    Private Sub gridAprovadoresSelecionados_Click(sender As System.Object, e As System.EventArgs) Handles gridAprovadoresSelecionados.Click
        'With gridUsuarioAprovador
        '    If .ColSel > 0 Then
        '        Dim Check As New ConfiguracaoDoc
        '        Dim id As Integer
        '        Dim Aprovado As Boolean
        '        Try
        '            If .Item(.RowSel, .ColSel) = True Then
        '                Aprovado = False
        '                .Item(.RowSel, .ColSel) = False
        '            Else
        '                Aprovado = True
        '                .Item(.RowSel, .ColSel) = True
        '            End If
        '            id = .Item(.RowSel, 1)
        '            Check.UpdateMultiploAprovador(id, Aprovado)
        '        Catch ex As Exception
        '            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
        '        End Try
        '    End If
        'End With
    End Sub


End Class
