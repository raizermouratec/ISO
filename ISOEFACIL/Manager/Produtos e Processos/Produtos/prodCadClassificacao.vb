Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Public Class prodCadClassificacao

#Region "VARIÁVEIS"

    Private isEditGrupos As Boolean = False

    'Variavel global que contera o valor passado 
    Private idgrupos As String
    Private idsubgrupos As String
    Public verif As Boolean

    'Pega Id grupos
    Public WriteOnly Property grupos() As String
        Set(ByVal value As String)
            Me.idgrupos = value
        End Set
    End Property

    'Pega Id subgrupos
    Public WriteOnly Property subgrupos() As String
        Set(ByVal value As String)
            Me.idsubgrupos = value
        End Set
    End Property

#End Region

#Region "CARREGAR LISTA"

    Public Sub CarregaClassificacao()

        'Carrega Lista de Classificação de Produtos
        gridClassificacao.AutoGenerateColumns = False
        gridClassificacao.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_PRODUTOS_CLASSIFICACAO")

    End Sub

#End Region

#Region "POPULA COMBOS"

#Region "GRUPO"

    Sub CarregaClasseGrupo()

        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM PRODUTOS_GRUPO")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = ""

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        cmbGrupos.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        cmbGrupos.DataSource = dtb
        cmbGrupos.DisplayMember = "NOME"
        cmbGrupos.ValueMember = "ID_PRODUTOS_GRUPO"

    End Sub

#End Region

#Region "SUB-GRUPOS"

    Sub CarregaClasseSubGrupo()

        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM PRODUTOS_SUBGRUPO")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = ""

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        cmbSubGrupos.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        cmbSubGrupos.DataSource = dtb
        cmbSubGrupos.DisplayMember = "NOME"
        cmbSubGrupos.ValueMember = "ID_PRODUTOS_SUBGRUPO"

    End Sub

#End Region

#Region "CHAMA SUB-GRUPO POR GRUPO SELECIONADO"

    Private Sub cmbGrupos_ChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrupos.ChangeCommitted

        Dim id As String

        Try

            If cmbGrupos.ValueMember = "" Then
                CarregaClasseGrupo()
            End If

            id = cmbGrupos.SelectedValue.ToString
            ChamaSubGruposById(id)

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbGrupos_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrupos.GotFocus

        Dim id As String

        Try

            If cmbGrupos.ValueMember = "" Then
                CarregaClasseGrupo()
            End If

            id = cmbGrupos.SelectedValue.ToString
            ChamaSubGruposById(id)

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub ChamaSubGruposById(ByVal id As String)

        If id = "" Then
            id = 0
        End If
        Dim sql As String = String.Format("SELECT * FROM PRODUTOS_SUBGRUPO SUB LEFT JOIN PRODUTOS_GRUPO GP ON GP.ID_PRODUTOS_GRUPO = SUB.ID_PRODUTOS_GRUPO WHERE GP.ID_PRODUTOS_GRUPO = '{0}'", id)

        Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

        Try

            While dr.Read
                cmbSubGrupos.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
                cmbSubGrupos.DataSource = Manager.Util.getDataTable(sql)
                cmbSubGrupos.DisplayMember = "NOME"
                cmbSubGrupos.ValueMember = "ID_PRODUTOS_SUBGRUPO"
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try


    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub prodCadastroGrupos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Chama combos
        CarregaClasseGrupo()
        CarregaClasseSubGrupo()
        CarregaClassificacao()
        lblNovoGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        txtNovoGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        lblNovoSubGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        txtNovoSubGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        radioNovoGrupo.Checked = False
        radioNovoSubgrupo.Checked = False

        Dim i%
        ' Set up cell merging.
        gridClassificacao.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.RestrictCols
        For i = gridClassificacao.Cols.Fixed To gridClassificacao.Cols.Count - 1
            gridClassificacao.Cols(i).AllowMerging = True
        Next

    End Sub

#End Region

#Region "ABAS"

#Region "SALVAR"

    Private Sub botAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botIncluir.Click

        'Seta a Classe
        Dim grupos As New classificacao
        Dim id As Integer = 0

        'Verificando se o Grupo está checado
        If radioNovoGrupo.Checked Then
            'Verificando situacao campo 
            verificar()
            'verificando campos OK
            If verif = False Then
                'Inserindo novo Grupo
                If grupos.AddGrupos(txtNovoGrupo.Text) Then
                    CarregaClasseGrupo()
                    CarregaClassificacao()
                    MessageBox.Show("Dados do Grupo salvos com sucesso", "Grupos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNovoGrupo.Text = ""
                End If
            Else
                Exit Sub
            End If

        Else
            'Caso o combo Grupo não tenha nenhuma seleção
            If cmbGrupos.Text = "" Then
                MessageBox.Show("Por favor Selecione um Grupo", "Grupos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'Passagem de parametros
            idgrupos = cmbGrupos.SelectedValue
            'Verificando situacao campo 
            verificar()
            'verificando campos OK
            If verif = False Then
                'Inserindo novo Sub Grupo
                If grupos.AddSubGrupos(txtNovoSubGrupo.Text, _
                                       idgrupos) Then
                    CarregaClasseSubGrupo()
                    CarregaClassificacao()
                    MessageBox.Show("Dados do Sub Grupo salvos com sucesso", "Sub Grupos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNovoSubGrupo.Text = ""
                End If
            Else
                Exit Sub
            End If

        End If

    End Sub

    Sub verificar()
        verif = False

        'Tratamento Campo NOVO grupo
        If radioNovoGrupo.Checked Then
            If txtNovoGrupo.Text = "" Then
                MessageBox.Show("Campo Novo Grupo Obrigatório", "Produto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNovoGrupo.Focus()
                verif = True
                Exit Sub
            End If
        End If
        'Tratamento Campo NOVO Sub grupo
        If radioNovoSubgrupo.Checked Then
            If txtNovoSubGrupo.Text = "" Then
                MessageBox.Show("Campo Novo Sub Grupo Obrigatório", "Produto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNovoSubGrupo.Focus()
                verif = True
                Exit Sub
            End If
        End If

    End Sub

#End Region

#Region "CONTROLE DE CLASSIFICACAO"

#Region "HABILITA NOVO GRUPO"

    Private Sub radioNovoGrupo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioNovoGrupo.SelectedIndexChanged

        If radioNovoGrupo.Checked = True Then
            'Visiveis os campos de Novo Grupo
            lblNovoGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            txtNovoGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            cmbGrupos.Text = ""
            'Invisiveis os campos de Novo Sub Grupo
            lblNovoSubGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            txtNovoSubGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            radioNovoSubgrupo.Checked = False
            cmbSubGrupos.Text = ""
        End If

    End Sub

#End Region

#Region "HABILITA NOVO SUB-GRUPO"

    Private Sub radioNovoSubgrupo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioNovoSubgrupo.SelectedIndexChanged

        If radioNovoSubgrupo.Checked = True Then
            'Visiveis os campos de Novo Sub Grupo
            lblNovoSubGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            txtNovoSubGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            'cmbGrupos.Text = ""
            'Invisiveis os campos de Novo Grupo
            lblNovoGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            txtNovoGrupo.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            radioNovoGrupo.Checked = False
            cmbSubGrupos.Text = ""
        End If

    End Sub

#End Region

#End Region

#End Region

End Class
