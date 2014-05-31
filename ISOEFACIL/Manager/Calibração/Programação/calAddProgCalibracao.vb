Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ISOEFACIL.calProgramacaoCalibracao
Public Class calAddProgCalibracao

#Region "CARREGA LISTA"

    Public Sub carregaInstrumentos()

        'Monta o Grid Prod/Serv
        gridInst.AutoGenerateColumns = False
        gridInst.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_CALIBRACOES_INSTRUMENTOS_ADD_PLANO")

    End Sub

#End Region

#Region "LOAD"

    Private Sub calAddCalibracao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaInstrumentos()
    End Sub

#End Region

#Region "BOTÕES"

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        Dim plano As New planoAnualCalibracao
        Dim progAnual As New calProgramacaoCalibracao
        Dim idInst As Integer = 0
        Dim idProg As Integer = 0

        If gridInst.RowSel < 0 Then
            MessageBox.Show("Não há nenhum Instrumento Cadastrado e Ativo", "Plano Anual de Calibração", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            idInst = gridInst(gridInst.RowSel, 1)

            If plano.Add(idInst, _
                        cmbRealizacao.Text, _
                        dtAno.Text, _
                        6, _
                        idProg) Then
                MessageBox.Show("Novo Plano Anual incluído com sucesso", "Plano Anual de Calibração", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                calProgramacaoCalibracao.carregaListaDatas()
                calProgramacaoCalibracao.CarregaComboAno()
                Me.Close()

            End If
        End If

    End Sub

#End Region

#End Region

End Class
