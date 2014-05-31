Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Public Class cotrAddProgTreinamentos

#Region "VARIAVEIS"

    'Variaveis usadas para edição de dados
    Public idAplanTreinamento As String

    'Pega Id 
    Public WriteOnly Property PlanTreinamento() As String
        Set(ByVal value As String)
            Me.idAplanTreinamento = value
        End Set
    End Property

#End Region

#Region "LOAD"
    Private Sub cotrCadProcInst_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
#End Region

#Region "BOTÕES"

#Region "SALVAR"
    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        Dim plano As New planoAnualTreinamento
        Dim ids As Integer = 0
        Dim num As String = String.Empty
        Dim dtb As New DataTable
        Dim sql As String = String.Format("SELECT MAX(NUMERO) AS NUM FROM TREINAMENTO_PLANO WHERE ANO={0}", dtAno.Text)
        dtb = Manager.Util.getDataTable(sql)
        If dtb.Rows.Item(0).Item(0).ToString = "" Then
            num = "1" + "/" + dtAno.Text
        Else
            num = dtb.Rows.Item(0).Item(0).ToString
            num = num.Substring(0, num.IndexOf("/"))
            num = Convert.ToInt32(num) + 1
            num = num + "/" + dtAno.Text
        End If

        If plano.AddTreinamento(txtAcao.Text, _
                                num, _
                                dtAno.Text, _
                                6) Then
            MessageBox.Show("Novo Plano Anual incluído com sucesso", "Plano Anual de Treinamento", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            cotrProgramacaoTreinamentos.carregaListaDatasAno(dtAno.Text)
            cotrProgramacaoTreinamentos.CarregaComboAno()
            Me.Close()

        End If

    End Sub
#End Region

#End Region

End Class
