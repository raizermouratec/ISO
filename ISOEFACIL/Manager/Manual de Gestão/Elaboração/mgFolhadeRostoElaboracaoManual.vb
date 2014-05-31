Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Public Class mgFolhadeRostoElaboracaoManual

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Public idFolhaRosto As String

    Public WriteOnly Property FolhaRosto() As String
        Set(ByVal value As String)
            Me.idFolhaRosto = value
        End Set
    End Property

#End Region

#Region "LOAD"

    Private Sub mgFolhadeRosto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        txtApresentacao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtNota.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtObjetivo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")

        'Carrega textos
        Dim sql As String = String.Format("SELECT * FROM MANUAL_FOLHA")

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            If dr.HasRows Then

                While dr.Read

                    Me.txtApresentacao.Text = dr("APRESENTACAO").ToString
                    Me.txtObjetivo.Text = dr("OBJETIVO").ToString
                    Me.txtNota.Text = dr("NOTA").ToString

                End While

                Me.txtApresentacao.Enabled = False
                Me.txtObjetivo.Enabled = False
                Me.txtNota.Enabled = False
            Else
                Me.txtApresentacao.Enabled = True
                Me.txtObjetivo.Enabled = True
                Me.txtNota.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "BOTÕES"

#Region "SALVAR"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        Dim folha As New folhaderosto

        If isEdit Then

            If folha.Update(txtApresentacao.Text, _
                            txtObjetivo.Text, _
                            txtNota.Text) Then
                MessageBox.Show("Dados da Folha de Rosto do Manual atualizados com sucesso", "Folha de Rosto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                'desabilita os campos
                Me.txtApresentacao.Enabled = False
                Me.txtObjetivo.Enabled = False
                Me.txtNota.Enabled = False
            End If

        Else

            'Add
            If folha.Add(txtApresentacao.Text, _
                         txtObjetivo.Text, _
                         txtNota.Text) Then
                MessageBox.Show("Dados da Folha de Rosto do Manual salvos com sucesso", "Folha de Rosto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                'desabilita os campos
                Me.txtApresentacao.Enabled = False
                Me.txtObjetivo.Enabled = False
                Me.txtNota.Enabled = False
            End If
        End If
    End Sub

#End Region

#Region "EDITAR"
    Private Sub botEdit_Click(sender As System.Object, e As System.EventArgs) Handles botEdit.Click

        Me.txtApresentacao.Enabled = True
        Me.txtObjetivo.Enabled = True
        Me.txtNota.Enabled = True

        isEdit = True

    End Sub
#End Region


#End Region

End Class
