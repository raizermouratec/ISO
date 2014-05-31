Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Net.Mail
Imports Microsoft.Office.Interop
Imports System.Net

Public Class docVincularDocElaboracao

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Public TpAtv As String = String.Empty
    Public Item As String = String.Empty
    Public doc As String = String.Empty
    Public rev As Integer = 0

    Public WriteOnly Property TipoAtividade() As String
        Set(ByVal value As String)
            Me.TpAtv = value
        End Set
    End Property

    Public WriteOnly Property ItemVinc() As String
        Set(ByVal value As String)
            Me.Item = value
        End Set
    End Property

    '// doc
    Public WriteOnly Property Documento() As String
        Set(ByVal value As String)
            Me.doc = value
        End Set
    End Property
    '// rev
    Public WriteOnly Property Revisao() As Integer
        Set(ByVal value As Integer)
            Me.rev = value
        End Set
    End Property
#End Region

#Region "POPULA COMBOS"

#Region "COMBO DOCUMENTOS"

    Private Sub CarregaDoc()
        Try
            Dim dtb As DataTable = Manager.Util.getDataTable("SELECT ID, CODIGO + '  -  '+ TITULO AS TITULO FROM VW_DOCUMENTO_CONTROLE_DOCUMENTO")
            Dim dtr As DataRow = dtb.NewRow
            dtr("TITULO") = " "

            dtb.Rows.InsertAt(dtr, 0)
            dtb.AcceptChanges()

            comboDoc.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
            comboDoc.DataSource = dtb
            comboDoc.DisplayMember = "TITULO"
            comboDoc.ValueMember = "ID"

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try        
    End Sub

#End Region

#End Region

#Region "LOAD"
    Private Sub docVincularDocElaboracaoManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaDoc()
        InputGroupHeader1.Text = "Documento(s) vinculados ao item - " + Item
    End Sub
#End Region

#Region "BOTOES"

#Region "ADICIONAR"

    Private Sub botAdd_Click(sender As System.Object, e As System.EventArgs) Handles botAdd.Click
        Try 'Caso não tenha item selecionado
            If comboDoc.SelectedValue.ToString = String.Empty Then
                MessageBox.Show("Selecione um documento", "Elaboração - Vincular Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                comboDoc.Focus()
                Exit Sub
            Else
                Dim classe As New elaboracao()
                Dim cod_doc As String = comboDoc.Text.ToString.Trim
                Dim split As New List(Of String)(cod_doc.Split("-"))
                Dim parsplit As String = split(0).ToString.Trim
                If classe.AddElabVinc(doc, rev, Item, TpAtv, parsplit) Then
                    '  MessageBox.Show("Documento Aprovado com sucesso!", "Elaboração - Vincular Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()                    
                    CarregaListaComo(Item, doc, rev, TpAtv)

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub

#Region "CARREGA LISTA"
    Public Sub CarregaListaComo(ByVal Item As Integer, ByVal doc As String, ByVal rev As Integer, ByVal tpAtv As String)
        Try
            Dim sql As String = String.Format("SELECT CD.ID_DOCUMENTO_CONTROLE_DOCUMENTO AS ID, CD.CODIGO, CD.TITULO FROM DOCUMENTO_ELABORACAO_VICULADOS EL " & _
                                              " INNER JOIN DOCUMENTO_CONTROLE_DOCUMENTO CD " & _
                                              " ON EL.CODIGO_DOCUMENTO = CD.CODIGO " & _
                                              " WHERE Item = {0} " & _
                                              " AND CODIGO_DOCUMENTO = '{1}' " & _
                                              " AND EL.REVISAO = {2} " & _
                                              " AND TIPO_ATIVIDADE = '{3}' ", Item, doc, rev, tpAtv)

            Dim dtb As New DataTable
            dtb = Manager.Util.getDataTable(sql)
            docAddAtividades.gridComo.DataSource = Nothing
            docAddAtividades.gridComo.Refresh()
            docAddAtividades.gridComo.DataSource = dtb

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region

#End Region

End Class
