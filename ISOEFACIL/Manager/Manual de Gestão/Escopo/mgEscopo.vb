Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Public Class mgEscopo

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditEscopo As Boolean = False
    Public idescopo As String
    Public verif As Boolean = False

    'Pega Id Registro
    Public WriteOnly Property Escopo() As String
        Set(ByVal value As String)
            Me.idescopo = value
        End Set
    End Property

#End Region

#Region "CARREGAR ESCOPO"

    Public Sub CarregaTextoEscopo()

        txtEscopo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")

        'Carrega textos
        Dim sql As String = String.Format("SELECT * FROM MANUAL_ESCOPO")

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            If dr.HasRows Then

                While dr.Read
                    Me.txtEscopo.Text = dr("DESCRICAO").ToString
                End While

                Me.txtEscopo.Enabled = False
            Else
                Me.txtEscopo.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "LOAD"

    Private Sub mgEscopo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CarregaTextoEscopo()

    End Sub

#End Region

#Region "BOTOES"

#Region "SALVAR"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim escopo As New escopo

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            VerificarEscopo()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If escopo.UpdateEscopo(txtEscopo.Text) Then
                        MessageBox.Show("Dados de Escopo atualizados com sucesso", "Escopo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtEscopo.Enabled = False
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

            Else

                'Verificar campos obrigatórios
            VerificarEscopo()
                'Checando se campos obrigatórios estão OK
                If verif = False Then
                    Try
                        'Salvar
                        If escopo.AddEscopo(txtEscopo.Text) Then
                            MessageBox.Show("Escopo salva com sucesso", "Escopo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtEscopo.Enabled = False
                        End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub VerificarEscopo()
        verif = False

        'Tratamento de erro Escopo
        If txtEscopo.Text = "" Then
            MessageBox.Show("Campo Escopo Obrigatórido", "Escopo do Manual de Gestão", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEscopo.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click
        txtEscopo.Enabled = True
        isEdit = True
    End Sub

#End Region

#End Region

End Class
