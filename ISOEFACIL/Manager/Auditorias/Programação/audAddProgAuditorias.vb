Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO

Public Class audAddProgAuditorias

#Region "VARIAVEIS"

    'Variaveis usadas para edição de dados
    Public textoEmpresa As String
    Public idAplanAudtoria As String

    'Pega Id 
    Public WriteOnly Property PlanAuditoria() As String
        Set(ByVal value As String)
            Me.idAplanAudtoria = value
        End Set
    End Property


#End Region

#Region "POPULA COMBOS"

#Region "ÁREA"
    Sub carregaAreaSetor()
        With cmbAreaSetor
            .DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_AREAS")
            .DisplayMember = "DESCRICAO"
            .ValueMember = "ID"
            .Text = ""
        End With
    End Sub
#End Region

#End Region

#Region "LOAD"
    Private Sub audNovoProgAud_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Carrega combo Área/Setor
        carregaAreaSetor()
    End Sub
#End Region

#Region "BOTÕES"

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click
        Try
            If cmbAreaSetor.SelectedValue.ToString = String.Empty Then
                MessageBox.Show("Não há nenhuma Área Selecionada", "Programação de Auditorias", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else

                Dim plano As New planoAnualAuditoria
                Dim ids As Integer = 0
                Dim mes As Integer = 6 '// Add com valor padrão 6 = NUll..

                If plano.AddAuditoria(cmbAreaSetor.SelectedValue, dtAno.Text, mes) Then
                    audProgramacaoAuditorias.carregaListaDatasAno(dtAno.Text)
                    audProgramacaoAuditorias.CarregaComboAno()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub

#End Region

#End Region

End Class
