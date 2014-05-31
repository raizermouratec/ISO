Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Public Class mgApresentacaoElaboracaoManual

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Public idApresentacao As String

    Public WriteOnly Property Apresentacao() As String
        Set(ByVal value As String)
            Me.idApresentacao = value
        End Set
    End Property

#End Region

#Region "LOAD"

    Private Sub mgApresentacao_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Trocando a cor do texto
        txtApresentacao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtRevisao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtControle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtDistribuicao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtResponsavel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")

        'Carrega textos
        Dim sql As String = String.Format("SELECT * FROM MANUAL_APRESENTACAO")

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            If dr.HasRows Then

                While dr.Read

                    Me.txtApresentacao.Text = dr("APRESENTACAO").ToString
                    Me.txtRevisao.Text = dr("REVISOES").ToString
                    Me.txtControle.Text = dr("CONTROLE").ToString
                    Me.txtDistribuicao.Text = dr("DISTRIBUICAO").ToString
                    Me.txtResponsavel.Text = dr("RESPONSAVEL").ToString

                End While

                Me.txtApresentacao.Enabled = False
                Me.txtRevisao.Enabled = False
                Me.txtControle.Enabled = False
                Me.txtDistribuicao.Enabled = False
                Me.txtResponsavel.Enabled = False
            Else
                Me.txtApresentacao.Enabled = True
                Me.txtRevisao.Enabled = True
                Me.txtControle.Enabled = True
                Me.txtDistribuicao.Enabled = True
                Me.txtResponsavel.Enabled = True
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "BOTÕES"

#Region "SALVAR"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        Dim apresentacao As New apresentacao

        If isEdit Then

            Try

                'Editar(Apresentação)
                If apresentacao.Update(txtApresentacao.Text, _
                                       txtRevisao.Text, _
                                       txtControle.Text, _
                                       txtDistribuicao.Text, _
                                       txtResponsavel.Text) Then
                    MessageBox.Show("Dados da Apresentção do Manual atualizados com sucesso", "Apresentação do Manual de Gestão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Desabilita os campos
                    Me.txtApresentacao.Enabled = False
                    Me.txtRevisao.Enabled = False
                    Me.txtControle.Enabled = False
                    Me.txtDistribuicao.Enabled = False
                    Me.txtResponsavel.Enabled = False
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        Else

            Try

                'Salvar(Apresentação)
                If apresentacao.Add(txtApresentacao.Text, _
                                    txtRevisao.Text, _
                                    txtControle.Text, _
                                    txtDistribuicao.Text, _
                                    txtResponsavel.Text) Then
                    MessageBox.Show("Dados da Apresentação do Manual salvos com sucesso", "Apresentação do Manual de Gestão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Desabilita os campos após salvar
                    Me.txtApresentacao.Enabled = False
                    Me.txtRevisao.Enabled = False
                    Me.txtControle.Enabled = False
                    Me.txtDistribuicao.Enabled = False
                    Me.txtResponsavel.Enabled = False
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try

        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEdit_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        Me.txtApresentacao.Enabled = True
        Me.txtRevisao.Enabled = True
        Me.txtControle.Enabled = True
        Me.txtDistribuicao.Enabled = True
        Me.txtResponsavel.Enabled = True

        isEdit = True

    End Sub

#End Region

#Region "CANCELAR"

    Private Sub botCancelar_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

#End Region

End Class
