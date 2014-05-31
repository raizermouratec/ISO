Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.objCadObjetivos
Public Class objAddUnidadeMedicao

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Public verif As Boolean = False

#End Region

#Region "LOAD"

    Private Sub calAddTipoMedicao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAdicionar.Focus()
    End Sub

#End Region

#Region "INCLUIR"

    Private Sub botAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAdicionar.Click

        'Seta a Classe
        Dim tipoAdd As New unidadeMedicao

        'Verificar campos obrigatórios
        Verificar()
        'Checando se campos obrigatórios estão OK
        If verif = False Then
            Try
                'Adicionar
                If tipoAdd.AddTp(txtAdicionar.Text) Then
                    'Carrega novamente o Combo
                    calCadInstrumentos.CarregaTipoMedicao()
                    objCadObjetivos.CarregaUnidadeMedicao()
                    MessageBox.Show("Nova Medição salva com sucesso", "Tipo de Medição", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            End Try
        Else
            Exit Sub
        End If
        'Fechar Janela
        Me.Close()

    End Sub

    Sub Verificar()

        'Tratamento de erro Adicionar
        If txtAdicionar.Text = "" Then
            MessageBox.Show("Não à medição para adicionar", "Tipo de Medição", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            verif = True
            Exit Sub
        End If

        verif = False
    End Sub

#End Region

End Class
