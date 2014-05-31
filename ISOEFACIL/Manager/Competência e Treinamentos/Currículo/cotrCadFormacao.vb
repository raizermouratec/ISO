Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.cotrCurriculo
Public Class cotrCadFormacao

#Region "VARIAVEIS"

    Private isEdit As Boolean = False

    Public idUsuarioCV As String
    Public idFormacao As String

    'Pega Id Usuário
    Public WriteOnly Property UsuarioCv() As String
        Set(ByVal value As String)
            Me.idUsuarioCV = value
        End Set
    End Property    'Pega Id

    Public WriteOnly Property Formacao() As String
        Set(ByVal value As String)
            Me.idFormacao = value
        End Set
    End Property    'Pega Id

#End Region

#Region "POPULA COMBOS"

    Sub CarregaComboFormacao()

        With cmbFormacao
            .DataSource = Manager.Util.getDataTable("SELECT * FROM ESCOLARIDADE")
            .DisplayMember = "DESCRICAO"
            .ValueMember = "ID_ESCOLARIDADE"
            .Text = ""
        End With

    End Sub

#End Region

#Region "LOAD"

    Private Sub cotrCadFormacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaComboFormacao()
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoCadForm(ByVal id As Integer)
        'Cadastrar Novo
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarFormacao(ByVal id As Integer)

        Dim es As Integer = 0

        'Editar
        isEdit = True

        'Muda o Label do botão Incluir
        Me.botSalvar.Width = 80
        Me.botSalvar.Text = "Atualizar"

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM TREINAMENTO_FORMACAO_CV WHERE ID_TREINAMENTO_FORMACAO_CV = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.cmbFormacao.SelectedValue = dr("ID_ESCOLARIDADE").ToString
                Me.cmbSituacao.Text = dr("SITUACAO").ToString
                Me.txtCurso.Text = dr("CURSO").ToString
                Me.txtInstituicao.Text = dr("INSTITUICAO").ToString
                Me.mskAno.Text = dr("DURACAO_ANO").ToString
                Me.mskMes.Text = dr("DURACAO_MESES").ToString
                Me.dtCoclusao.Text = dr("DATA_CONCLUSAO").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try


    End Sub

#End Region

#Region "BOTÕES"

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        Dim curriculo As New Curriculo

        ''Editar
        If isEdit Then

            If curriculo.UpdateFormacaoCv(idFormacao, _
                                          idUsuarioCV, _
                                          cmbFormacao.SelectedValue, _
                                         cmbSituacao.Text, _
                                         txtCurso.Text, _
                                         txtInstituicao.Text, _
                                         mskAno.Text, _
                                         mskMes.Text, _
                                         dtCoclusao.Value) Then
                MessageBox.Show("Dados de Formação atualizados com sucesso", "Formação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                cotrCurriculo.carregaFormacao(idUsuarioCV)
                Me.Close()
            End If
        Else

            If curriculo.AddFormacaoCv(idUsuarioCV, _
                                       cmbFormacao.SelectedValue, _
                                        cmbSituacao.Text, _
                                        txtCurso.Text, _
                                        txtInstituicao.Text, _
                                        mskAno.Text, _
                                        mskMes.Text, _
                                        dtCoclusao.Value) Then
                MessageBox.Show("Dados de Formação salvos com sucesso", "Formação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                cotrCurriculo.carregaFormacao(idUsuarioCV)
                Me.Close()
            End If
        End If
    End Sub

#End Region

#End Region

End Class
