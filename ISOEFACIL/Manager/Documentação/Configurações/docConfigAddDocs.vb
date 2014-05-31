Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class docConfigAddDocs

#Region "LOAD"
    Private Sub docConfigAddDocs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
#End Region

#Region "VARIAVEIS"

    'Variaveis usadas para edição de dados
    Private isEdit As Boolean = False
    Public idTipoDoc As String
    Private ANEXO() As Byte

    'Pega Id
    Public WriteOnly Property TipoDoc() As String
        Set(ByVal value As String)
            Me.idTipoDoc = value
        End Set
    End Property

#End Region

#Region "NOVO"

    Public Sub NovoAddDocs()
        'Cadastrar Novo
        isEdit = False
        docConfigDocs.idVerifivcar_open = True
        Me.ShowDialog()
    End Sub

#End Region

#Region "BOTÕES"
    ''' <summary>
    ''' Salvar
    ''' </summary>
    Private Sub btAdd_Click(sender As System.Object, e As System.EventArgs) Handles btAdd.Click

        Dim classConfig As New ConfiguracaoDoc
        Dim format As Integer
        Dim check As Integer = 0

        'ID
        If txtId.Text = "" Then
            MessageBox.Show("O campo Identificação não foi preenchido", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtId.Focus()
            Exit Sub
        End If
        'Nome
        If txtNome.Text = "" Then
            MessageBox.Show("O campo Nome não foi preenchido", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNome.Focus()
            Exit Sub
        End If
        'Formato
        If cmbFormato.Text = "" Then
            MessageBox.Show("O campo Formato não foi selecionado", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbFormato.Focus()
            Exit Sub
        End If


        'Pega o Formato
        If cmbFormato.SelectedOption.Text = "Anexar" Then
            format = 0
        Else
            format = 1
        End If

        If isEdit Then
            'Editar
            If classConfig.Updatefm(idTipoDoc, txtId.Text, txtNome.Text, format) Then
                MessageBox.Show("Tipo de Documento salvo com sucesso!", "Configuração de Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                docConfigDocs.carregarTipoDoc()
                docConfigDocs.carregarTipoDocComposicao()
                Me.Close()

            End If
        Else
            'Salvar
            If classConfig.Addfm(txtId.Text, txtNome.Text, format, check) Then
                MessageBox.Show("Novo Tipo de Documento salvo com sucesso!", "Configuração de Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                docConfigDocs.carregarTipoDoc()
                docConfigDocs.carregarTipoDocComposicao()
                Me.Close()

            End If
        End If


    End Sub

#End Region

#Region "METODO EDITAR"

    Public Sub EditarTipoDoc(ByVal id As Integer)

        'Editar
        isEdit = True

        'Carrega o Form com esse methodo
        Me.Show()
        docConfigDocs.idVerifivcar_open = True
        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_CONFIG_TP_DOCUMENTO WHERE ID_DOCUMENTO_CONFIG_TP_DOCUMENTO = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read
                Me.txtId.Text = dr("IDENTIFICACAO").ToString
                Me.txtNome.Text = dr("NOME").ToString
                Me.cmbFormato.SelectedIndex = dr("FORMATO")
            End While

        Catch ex As Exception

        End Try


    End Sub

    Private Sub VerificarCampos()
    

    End Sub

#End Region

End Class
