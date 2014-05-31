Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.cotrCurriculo
Public Class cotrCadExperiencia

#Region "VARIAVEIS"

    Private isEdit As Boolean = False
    Public idUsuarioCV As String
    Public idExperiencia As String

    'Pega Id Usuário
    Public WriteOnly Property UsuarioCv() As String
        Set(ByVal value As String)
            Me.idUsuarioCV = value
        End Set
    End Property    'Pega Id

    Public WriteOnly Property Experiencia() As String
        Set(ByVal value As String)
            Me.idExperiencia = value
        End Set
    End Property    'Pega Id

#End Region

#Region "LOAD"

    Private Sub cotrCadExperiencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtAtividades.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoCadForm(ByVal id As Integer)
        'Cadastrar Novo
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarExperiencia(ByVal id As Integer)

        Dim es As Integer = 0

        'Editar
        isEdit = True

        'Muda o Label do botão Incluir
        Me.botSalvar.Width = 80
        Me.botSalvar.Text = "Atualizar"

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_TREINAMENTO_EXPERIENCIA_CV WHERE ID={0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtEmpresa.Text = dr("EMPRESA").ToString
                Me.txtCargo.Text = dr("CARGO").ToString
                Me.txtAtividades.Text = dr("ATIVIDADE").ToString
                Me.dtAdmissao.Text = dr("ADMISSAO")
                Me.dtDesligamento.Text = dr("DEMISSAO")

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

#End Region

#Region "BOTÕES"

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        Dim curriculo As New Curriculo


        ' ''Editar
        If isEdit Then

            If curriculo.UpdateExperienciaCV(idExperiencia, _
                                          idUsuarioCV, _
                                          txtEmpresa.Text, _
                                          txtCargo.Text, _
                                          txtAtividades.Text, _
                                          dtAdmissao.Value, _
                                          dtDesligamento.Value) Then
                MessageBox.Show("Dados de Experiência atualizados com sucesso", "Experiência Profissional", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                cotrCurriculo.carregaExperiencia(idUsuarioCV)
                Me.Close()
            End If

        Else

            If curriculo.AddExperienciaCV(idUsuarioCV, _
                                          txtEmpresa.Text, _
                                          txtCargo.Text, _
                                          txtAtividades.Text, _
                                          dtAdmissao.Value, _
                                          dtDesligamento.Value) Then
                MessageBox.Show("Dados de Experiência salvos com sucesso", "Experiência Profissional", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                cotrCurriculo.carregaExperiencia(idUsuarioCV)
                Me.Close()
            End If
        End If
    End Sub

#End Region

#Region "SEM EXPERIÊNCIA"

    Private Sub botSemExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSemExp.Click

        Dim zero As Integer = 0
        Dim curriculo As New Curriculo

        txtEmpresa.Text = "Sem Experiência"
        txtCargo.Text = "---"
        txtAtividades.Text = "---"

        If curriculo.AddSemExperienciaCV(idUsuarioCV, _
                                     txtEmpresa.Text, _
                                     txtCargo.Text, _
                                     txtAtividades.Text) Then
            MessageBox.Show("Profissional sem Experiência", "Experiência", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            cotrCurriculo.carregaExperiencia(idUsuarioCV)
        End If

    End Sub

#End Region

#End Region

End Class