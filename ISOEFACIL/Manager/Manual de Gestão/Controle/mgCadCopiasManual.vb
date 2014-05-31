Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.mgListaControleManual
Public Class mgCadCopiasManual

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Public idControleManual As String
    Public idCopiaManuais As String
    Public verif As Boolean

    Public WriteOnly Property ControleManual() As String
        Set(ByVal value As String)
            Me.idControleManual = value
        End Set
    End Property

    Public WriteOnly Property CopiaManuais() As String
        Set(ByVal value As String)
            Me.idCopiaManuais = value
        End Set
    End Property

#End Region

#Region "LOAD"

    Private Sub mgCadCopiasManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoCadCopiasManual()
        'Cadastrar Novo
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarCopiaManual(ByVal id As Integer)

        'Editar
        isEdit = True

        'Seleciona pelo Id
        Dim sql As String = String.Format("SELECT * FROM MANUAL_CONTROLE_COPIA WHERE ID_MANUAL_CONTROLE_COPIA = '{0}'", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtCopia.Text = Format(dr("ID_MANUAL_CONTROLE_COPIA"), "000").ToString
                Me.txtLocal.Text = dr("LOCAL").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Mostrar tela
        Me.ShowDialog()

    End Sub

#End Region

#Region "BOTOES"

#Region "SALVAR"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim manual As New CopiasManuais

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If manual.Update(idCopiaManuais, _
                                     idControleManual, _
                                     txtLocal.Text) Then
                        MessageBox.Show("Dados da Cópia do Manual atualizados com sucesso", "Cópia do Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mgListaControleManual.CarregaCopiaManual()
                        Me.Close()
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If manual.Add(idControleManual, _
                                  txtLocal.Text) Then
                        MessageBox.Show("Dados da Cópia do Manual salvos com sucesso", "Cópia do Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mgListaControleManual.CarregaCopiaManual()
                        Me.Close()
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub Verificar()
        verif = False

        'Tratamento de erro Título
        If txtLocal.Text = "" Then
            MessageBox.Show("Campo Local Obrigatórido", "Cópia do Manual", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtLocal.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#End Region

End Class
