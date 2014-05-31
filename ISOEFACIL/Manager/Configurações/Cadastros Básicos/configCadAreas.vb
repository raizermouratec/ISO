Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ISOEFACIL.configListaBasico
Public Class configCadAreas

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditarAreas As Boolean = False
    Public idAreas As String
    Public verif As Boolean = False

    'Pega Id Registro
    Public WriteOnly Property Areas() As String
        Set(ByVal value As String)
            Me.idAreas = value
        End Set
    End Property

#End Region

#Region "LOAD"

    Private Sub configCadAreas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



    End Sub

#End Region

#Region "NOVO"

    Public Sub NovaArea()
        'Cadastrar Novo
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

     Public Sub EditarAreas(ByVal id As Integer)

        'Editar
        isEdit = True

        'Muda o Label do botão Incluir
        botSalvar.Width = 80
        botSalvar.Text = "Atualizar"

        'Seleciona Produtos/Serviços pelo Id
        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_AREAS WHERE ID = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtCodigo.Text = dr("CODIGO").ToString
                Me.txtArea.Text = dr("DESCRICAO").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

#End Region

#Region "BOTOES"

#Region "SALVAR"

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim areas As New areas

        Dim check As Boolean = False

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                'Atualizar
                If areas.Update(idAreas, _
                            txtCodigo.Text, _
                            txtArea.Text, _
                            check) Then
                    MessageBox.Show("Dados atualizados com sucesso", "Áreas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    configListaBasico.CarregaAreas()
                    txtArea.Text = ""
                    txtCodigo.Text = ""
                    isEdit = False
                    Me.Close()
                End If
            Else
                Exit Sub
            End If

        Else


            'Verificar campos obrigatórios
            Verificar()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                'Salvar
                If areas.Add(txtCodigo.Text, _
                             txtArea.Text, _
                             check) Then
                    MessageBox.Show("Nova Área incluída com sucesso", "Áreas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    configListaBasico.CarregaAreas()
                    txtArea.Text = ""
                    txtCodigo.Text = ""
                    Me.Close()
                End If
            Else
                Exit Sub
            End If

        End If

    End Sub

#Region "VERIFICAR CAMPOS"

    Sub Verificar()
        verif = False

        'Tratamento de erro Codigo
        If txtCodigo.Text = Nothing Then
            MessageBox.Show("Campo Código Obrigatório", "Áreas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCodigo.Focus()
            verif = True
            Exit Sub
        End If

        'Tratamento de erro Area
        If txtArea.Text = Nothing Then
            MessageBox.Show("Campo Área Obrigatório", "Áreas", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtArea.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#End Region

#End Region

End Class
