Imports Microsoft.SqlServer
Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class forListaPerfil


    Private Sub ForAvaliacaoperfil_Listagem_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.MdiParent = principal
        carregar()
        grid_Perfil.AllowMergingFixed = True
    End Sub

    Private Sub botNovo_Click(sender As System.Object, e As System.EventArgs) Handles botNovo.Click
        forCadPerfil.ShowDialog()
    End Sub


    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click
        Dim Teste As New forCadPerfil
        Dim id As Integer = 0
        If grid_Perfil.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            id = grid_Perfil(grid_Perfil.RowSel, 1)
            Teste.ID_Perfil_Rec = id
            Teste.idEdit = True
            Teste.ShowDialog()
        End If
    End Sub
    Sub carregar()
        grid_Perfil.DataSource = Manager.Util.getDataTable("SELECT * FROM FORNECEDORES_AVALIACAO_PERFIL_ID")
    End Sub

    Private Sub bot_Excluir_Click(sender As System.Object, e As System.EventArgs) Handles bot_Excluir.Click

        Dim id_perfil As Integer
        Try
            If grid_Perfil.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Fornecedores", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                id_perfil = grid_Perfil(grid_Perfil.RowSel, 1)
                Deleteperfil_Nome(id_perfil)

                MsgBox("Perfil Excluido Com Suceso.")
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel excluir o perfil.")
        End Try
    End Sub


    Public Function Deleteperfil_Nome(ByVal ID_PERFIL As Integer) As Boolean

        Dim _connectionString As String = My.Settings.connectionString
        Dim _Connection As SqlConnection
        Dim _Command As SqlCommand
        Dim _cmdText As String = "[DELETE_FORNECEDORES_AVALIACAO_PERFIL]"

        Try

            _Connection = New SqlConnection(_connectionString)
            _Connection.Open()

            _Command = New SqlCommand(_cmdText, _Connection)
            _Command.CommandType = CommandType.StoredProcedure

            With _Command.Parameters
                .AddWithValue("@ID_PERFIL", ID_PERFIL)
            End With

            _Command.ExecuteNonQuery()
            _Connection.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
