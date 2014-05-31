Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.calCadInstrumentos
Public Class calJustificar

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditJutificar As Boolean = False
    'Private isEditregistro As Boolean = False
    Public verif As Boolean = False
    Public idInstrumentos As String
    Private tipouso As Integer
    Private situacao As Integer
    Private condicao As Integer
    Private idativo As String

    'Pega Id 
    Public WriteOnly Property Instrumentos() As String
        Set(ByVal value As String)
            Me.idInstrumentos = value
        End Set
    End Property

    'Pega Id 
    Public WriteOnly Property Ativo() As String
        Set(ByVal value As String)
            Me.idAtivo = value
        End Set
    End Property

#End Region

#Region "POPULA COMBO"

#Region "RESPONSAVEL"

    Sub CarregaResp()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboResp.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboResp.DataSource = dtb
        comboResp.DisplayMember = "COLABORADOR"
        comboResp.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub calJustificarInativar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaResp()
        txtJustificar.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoJustificar()
        'Cadastrar Novo
        isEditJutificar = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    'Private Sub botEditarR_Click(sender As System.Object, e As System.EventArgs) Handles botEditarRisco.Click

    '    Dim frm As New projCadRisco
    '    Dim id As Integer = 0
    '    Dim idProjeto As Integer = 0

    '    'Delegate para instancia do grid
    '    AddHandler frm.OnDataChange, AddressOf CarregaRisco

    '    'Passagem de parametros
    '    Try

    '        idProjeto = projListaProjetos.gridProjetos(projListaProjetos.gridProjetos.RowSel, 1)
    '        frm.idprojetos = idProjeto
    '        id = gridRisco(gridRisco.RowSel, 1)
    '        frm.Risco = id
    '        frm.EditarRisco(id)

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
    '    End Try

    'End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim Just As New tipoMedicao

        'Verificar campos obrigatórios
        VerificarJustificativa()
        'Checando se campos obrigatórios estão OK
        If verif = False Then
            Try
                'Salvar
                If Just.AddJs(idInstrumentos, _
                              comboResp.SelectedValue, _
                              idativo, _
                              txtJustificar.Text, _
                              dateData.Value) Then
                    MessageBox.Show("Justificativa salva com sucesso", "Justificar", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        Else
            Exit Sub
        End If

    End Sub

    Private Sub VerificarJustificativa()
        verif = False

        'Tratamento de erro Justificar
        If txtJustificar.Text = "" Then
            MessageBox.Show("Campo Jusificativa Obrigatório", "Justificar", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtJustificar.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Responsável
        If comboResp.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Responsáel Obrigatório", "Justificar", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboResp.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data
        If dateData.Text = "" Then
            MessageBox.Show("Campo Data Obrigatório", "Justificar", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateData.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

End Class
