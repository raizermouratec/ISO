Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Public Class audChecklist

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Public idCheck As String

    'Pega Id
    Public WriteOnly Property Check() As String
        Set(ByVal value As String)
            Me.idCheck = value
        End Set
    End Property

#End Region

#Region "LOAD"
    Private Sub audChecklist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carregaCheckList()
    End Sub
#End Region

#Region "CARREGAR LISTA"

    Public Sub carregaCheckList()

        'Carrega Lista
        gridCheck.AutoGenerateColumns = False
        gridCheck.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_ITEM_NORMA")

    End Sub

#End Region

#Region "BOTÕES"

#Region "PERGUNTAS"

    Private Sub botPerguntas_Click(sender As System.Object, e As System.EventArgs) Handles botPerguntas.Click

        Dim frmAud As New audPerguntasChecklist
        Dim id As Integer = 0
        Dim item As Integer = 0
        Dim norma As String = ""

        'Passagem de parametros
        Try

            id = gridCheck(gridCheck.RowSel, 1)
            item = gridCheck(gridCheck.RowSel, 2)
            norma = gridCheck(gridCheck.RowSel, 3)

            frmAud.ID = id
            frmAud.Item = item
            frmAud.Normas = norma

            frmAud.Novo()


            'frmAud.EditarAuditorias(id)

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#End Region

#Region "GRID CHECK"

    Private Sub gridCheck_Click(sender As System.Object, e As System.EventArgs) Handles gridCheck.Click

        With gridCheck

            If .ColSel = 4 Then

                Dim Check As New checkList
                Dim Aprovado As Boolean
                Dim id As Integer

                Try
                    If .Item(.RowSel, .ColSel) = True Then
                        Aprovado = False
                        .Item(.RowSel, .ColSel) = False
                    Else
                        Aprovado = True
                        .Item(.RowSel, .ColSel) = True
                    End If
                    id = gridCheck(gridCheck.RowSel, 1)
                    Check.UpdateMultiplo(id, Aprovado)

                Catch ex As Exception
                    MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                End Try

            End If

        End With

    End Sub

    Public Sub LimpaAllChecks()
        With gridCheck
            .Item(.RowSel, .ColSel) = False
        End With
    End Sub

#End Region

End Class
