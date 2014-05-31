Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.projCadProjeto
Public Class projCadEquipe

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditregistro As Boolean = False
    Public idequipeint As String
    Public idequipeext As String
    Public idprojetos As String

    'Pega Id Registro
    Public WriteOnly Property EquipeInt() As String
        Set(ByVal value As String)
            Me.idequipeint = value
        End Set
    End Property

    'Pega Id Registro
    Public WriteOnly Property EquipeExt() As String
        Set(ByVal value As String)
            Me.idequipeext = value
        End Set
    End Property

    'Pega Id Registro
    Public WriteOnly Property Projetos() As String
        Set(ByVal value As String)
            Me.idprojetos = value
        End Set
    End Property

#End Region

#Region "CARREGAR LISTA EQUIPE"

    Public Sub CarregaListaEquipe(ByVal id As Integer)

        'Monta Lista de Equipe do Projeto passando Id
        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_PROJETOS_EQUIPE WHERE ID_PROJETOS = {0}" & id & "ORDER BY TIPO")
        Dim dt As New DataTable
        Dim i As Integer = 1

        'Chama o Methodo que cria o DataTable e coloca na variavel
        dt = Manager.Util.getDataTableById(sqlId)

        'Não gera colunas automaticas
        gridEquipe.AutoGenerateColumns = False

        'Cria a tabela
        gridEquipe.DataSource = dt

    End Sub

#End Region

#Region "POPULA COMBOS"

#Region "RESPONSAVEL"

    Sub CarregaResp()
        comboParticipanteInt.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboParticipanteInt.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        comboParticipanteInt.DisplayMember = "COLABORADOR"
        comboParticipanteInt.ValueMember = "ID"
        comboParticipanteInt.Text = ""
    End Sub

#End Region

#Region "CARGO"

    Sub CarregaCargo()
        comboCargoInt.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboCargoInt.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_CARGOS")
        comboCargoInt.DisplayMember = "CARGO"
        comboCargoInt.ValueMember = "ID"
        comboCargoInt.Text = ""
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub projCadEquipe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' CarregaListaEquipe(idprojetos)
        CarregaResp()
        CarregaCargo()
    End Sub

    Private Sub radioInterno_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioInterno.SelectedIndexChanged
        If radioInterno.Checked = True Then
            InputExterno.Visible = False
        End If
    End Sub

    Private Sub radioExterno_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioExterno.SelectedIndexChanged
        If radioExterno.Checked = True Then
            InputExterno.Visible = True
        End If
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovaEquipe()
        'Cadastrar Nova Equipe
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "BOTOES"

#Region "INCLUIR"

    Private Sub botIncluir_Click(sender As System.Object, e As System.EventArgs) Handles botIncluir.Click

        If radioInterno.Checked = True Then

            Dim tipoint As Boolean

            tipoint = True

            'Cadastra nova Equipe Interna
            Dim equipe As New equipe

            If isEdit Then

                Try

                    'Editar Equipe Interna
                    VerificarEquipe()
                    If equipe.UpdateInt(idequipeint, _
                                        idprojetos, _
                                        comboParticipanteInt.SelectedValue, _
                                        comboCargoInt.SelectedValue, _
                                        txtAtribuicaoInt.Text, _
                                        tipoint) Then
                        'CarregaListaEquipe(idprojetos)
                        MessageBox.Show("Dados de Equipe atualizados com sucesso", "Equipe - Interno", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            Else

                Try

                    'Salvar Equipe Interna
                    VerificarEquipe()
                    If equipe.AddInt(idprojetos, _
                                     comboParticipanteInt.SelectedValue, _
                                     comboCargoInt.SelectedValue, _
                                     txtAtribuicaoInt.Text, _
                                     tipoint) Then
                        'CarregaListaEquipe(idprojetos)
                        MessageBox.Show("Equipe Equipe salvo com sucesso", "Equipe - Interno", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            End If

        Else

            Dim tipoext As Boolean

            tipoext = False

            'Cadastra nova Equipe Externa
            Dim equipe As New equipe

            If isEdit Then

                '   Editar Equipe Externa
                VerificarEquipe()
                If equipe.UpdateExt(idequipeext, _
                                    idprojetos, _
                                    txtNomeExt.Text, _
                                    txtCargoExt.Text, _
                                    txtAtribuicaoExt.Text, _
                                    tipoext) Then
                    'CarregaListaEquipe(idprojetos)
                    MessageBox.Show("Dados de Equipe atualizados com sucesso", "Equipe - Externo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else

                'Salvar Equipe Externa
                VerificarEquipe()
                If equipe.AddExt(idprojetos, _
                                 txtNomeExt.Text, _
                                 txtCargoExt.Text, _
                                 txtAtribuicaoExt.Text, _
                                 tipoext) Then
                    'CarregaListaEquipe(idprojetos)
                    MessageBox.Show("Equipe Equipe salvo com sucesso", "Equipe - Externo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If

        End If

    End Sub

    Private Sub VerificarEquipe()
        If radioInterno.Checked = True Then

            'Participante
            If comboParticipanteInt.Text = "" Then
                MessageBox.Show("O campo Participante não foi selecionado", "Equipe - Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                comboParticipanteInt.Focus()
                Exit Sub
            End If
            'Cargo
            If comboCargoInt.Text = "" Then
                MessageBox.Show("O campo Cargo não foi selecionado", "Equipe - Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                comboCargoInt.Focus()
                Exit Sub
            End If
            'Atribuição
            If txtAtribuicaoInt.Text = "" Then
                MessageBox.Show("O campo Atribuição em não foi preenchido", "Equipe - Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAtribuicaoInt.Focus()
                Exit Sub
            End If

        Else

            'Nome
            If txtNomeExt.Text = "" Then
                MessageBox.Show("O campo Nome em não foi preenchido", "Equipe - Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAtribuicaoInt.Focus()
                Exit Sub
            End If
            'Cargo
            If txtCargoExt.Text = "" Then
                MessageBox.Show("O campo Cargo em não foi preenchido", "Equipe - Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAtribuicaoInt.Focus()
                Exit Sub
            End If
            'Atribuição
            If txtAtribuicaoExt.Text = "" Then
                MessageBox.Show("O campo Atribuição em não foi preenchido", "Equipe - Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAtribuicaoInt.Focus()
                Exit Sub
            End If

        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        Dim frm As New projCadEquipe
        Dim id As Integer = 0
        Dim idProjeto As Integer = 0

        If gridEquipe.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Equipe", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Passagem de parametros
            Try

                idProjeto = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
                frm.idprojetos = idProjeto
                id = gridEquipe(gridEquipe.RowSel, 1)
                EquipeInt = id
                EquipeExt = id
                EditarEquipe(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

            CarregaListaEquipe(idprojetos)
        End If
    End Sub

    Public Sub EditarEquipe(ByVal id As Integer)

        If radioInterno.Checked = True Then

            'Editar
            isEdit = True

            Dim sql As String = String.Format("SELECT * FROM PROJETOS_EQUIPE_INTERNO WHERE ID_PROJETOS_EQUIPE_INTERNO = {0}", id)

            'Popula os campos com os dados do Banco
            Try

                Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

                While dr.Read

                    Me.comboParticipanteInt.SelectedValue = ("ID_COLABORADORES").ToString
                    Me.comboCargoInt.SelectedValue = ("ID_CARGOS").ToString
                    Me.txtAtribuicaoInt.Text = ("ATRIBUICAO").ToString

                End While

            Catch ex As Exception

            End Try

        Else

            'Editar
            isEdit = True

            Dim sql As String = String.Format("SELECT * FROM PROJETOS_EQUIPE_EXTERNO WHERE ID_PROJETOS_EQUIPE_EXTERNO = {0}", id)

            'Popula os campos com os dados do Banco
            Try

                Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

                While dr.Read

                    Me.txtNomeExt.Text = ("NOME").ToString
                    Me.txtCargoExt.Text = ("CARGO").ToString
                    Me.txtAtribuicaoExt.Text = ("ATRIBUICAO").ToString

                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        Dim equipe As New equipe

        If gridEquipe.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Equipe", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Excluir o Equipe
            Try
                If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Equipe", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    If radioInterno.Checked = True Then
                        equipe.DeleteInt(gridEquipe(gridEquipe.RowSel, 1))
                    ElseIf radioExterno.Checked = True Then
                        equipe.DeleteExt(gridEquipe(gridEquipe.RowSel, 1))
                    End If
                    CarregaListaEquipe(idprojetos)
                    MessageBox.Show("Participante excluído com sucesso", "Equipe", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#End Region

End Class
