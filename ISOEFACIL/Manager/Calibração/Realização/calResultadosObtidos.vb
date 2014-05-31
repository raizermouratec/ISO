Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ISOEFACIL.calRealizacaoCalibracoesInternas
Public Class calResultadosObtidos

#Region "VARIAVEIS"

    'Delegate criada para atualizar o grid
    Public Delegate Sub carregaListaMedicao(info As Integer)
    Public Event OnDataChange As carregaListaMedicao

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditregistro As Boolean = False
    Public idMedicao As String
    Public idInterno As String
    Dim Mdpadrao As Integer = 0
    Dim MdVerif As Double = 0
    Dim ErroAbsoluto As Double = 0
    Dim ErroRelativo As String
    Public verif As Boolean = False

    'Pega Id Registro
    Public WriteOnly Property Medicao() As String
        Set(ByVal value As String)
            Me.idMedicao = value
        End Set
    End Property

    'Pega Id Registro
    Public WriteOnly Property Interno() As String
        Set(ByVal value As String)
            Me.idInterno = value
        End Set
    End Property

#End Region

#Region "LOAD"

    Private Sub calResultadosObtidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovaMedicao()
        'Cadastrar Nova Medicao
        isEdit = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim medicao As New medicao

        'Recebendo valores dos campos
        Mdpadrao = txtMedidaPadrao.Text
        MdVerif = txtMedidaVerificada.Text
        ErroAbsoluto = MdVerif - Mdpadrao

        'Calculo
        If ErroAbsoluto <= 0 Then
            ErroAbsoluto = (ErroAbsoluto * -1)
            ErroRelativo = ((ErroAbsoluto / Mdpadrao) * 100) & "%"
        End If

        'Inicio Atualizar/Salvar
        If isEdit Then

            'Verificar campos obrigatórios
            VerificarResultadoObtido()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If medicao.Update(idMedicao, _
                                      idInterno, _
                                      Mdpadrao, _
                                      MdVerif, _
                                      ErroAbsoluto, _
                                      ErroRelativo, _
                                      txtUnidMedida.Text) Then
                        VerificarResultadoObtido()
                        RaiseEvent OnDataChange(idInterno)
                        'calRealizacaoCalibracoesInternas.carregaListaMedicao(idMedicao)
                        MessageBox.Show("Dados de Resultados Obtidos atualizados com sucesso", "Resultados Obtidos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            VerificarResultadoObtido()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    If medicao.Add(idInterno, _
                                   Mdpadrao, _
                                   MdVerif, _
                                   ErroAbsoluto, _
                                   ErroRelativo, _
                                   txtUnidMedida.Text) Then
                        RaiseEvent OnDataChange(idInterno)
                        'calRealizacaoCalibracoesInternas.carregaListaMedicao(idMedicao)
                        MessageBox.Show("Dados de Resultados Obtidos atualizados com sucesso", "Resultados Obtidos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub VerificarResultadoObtido()
        verif = False

        'Tratamento de erro Medida Padrão
        If Not IsNumeric(txtMedidaPadrao.Text) Then
            MessageBox.Show("Digite apenas números", "Resultados Obtidos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMedidaPadrao.Focus()
            verif = True
            Exit Sub
        End If

        'Tratamento de erro Medida Verificada
        If Not IsNumeric(txtMedidaVerificada.Text) Then
            MessageBox.Show("Digite apenas números", "Resultados Obtidos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMedidaVerificada.Focus()
            verif = True
            Exit Sub
        End If

        'Tratamento de erro Unidade de Medida
        If txtUnidMedida.Text = "" Then
            MessageBox.Show("O campo Unidade de Medida não foi preenchido", "Resultados Obtidos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUnidMedida.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

End Class
