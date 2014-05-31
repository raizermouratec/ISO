Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.cotrCurriculo
Public Class cotrCadHabilidades

#Region "VARIAVEIS"

    Private isEdit As Boolean = False
    Public idUsuarioCV As String
    Public idHabilidades As String

    'Pega Id Usuário
    Public WriteOnly Property UsuarioCv() As String
        Set(ByVal value As String)
            Me.idUsuarioCV = value
        End Set
    End Property    'Pega Id

    Public WriteOnly Property Habilidade() As String
        Set(ByVal value As String)
            Me.idHabilidades = value
        End Set
    End Property    'Pega Id

#End Region

#Region "POPULA COMBOS"

    Sub CarregaComboResponsavel()

        With cmbResponsavel
            .DataSource = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
            .DisplayMember = "COLABORADOR"
            .ValueMember = "ID"
            .Text = ""
        End With

    End Sub

#End Region

#Region "LOAD"
    Private Sub cotrCadHabilidades_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaComboResponsavel()
    End Sub
#End Region

#Region "NOVO"

    Public Sub NovoCadForm(ByVal id As Integer)
        'Cadastrar Novo
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarHabilidade(ByVal id As Integer)

        Dim es As Integer = 0

        'Editar
        isEdit = True

        'Muda o Label do botão Incluir
        Me.botSalvar.Width = 80
        Me.botSalvar.Text = "Atualizar"

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_TREINAMENTO_HABILIDADES_CV WHERE ID ={0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtHabilidade.Text = dr("HABILIDADE").ToString
                Me.txtMetodo.Text = dr("METODO").ToString
                Me.txtResultado.Text = dr("RESULTADO").ToString
                'mudar aqui para ID RESPONSAVEL
                Me.cmbResponsavel.SelectedValue = dr("COLABORADOR").ToString
                Me.dtData.Text = dr("DATA")

            End While

        Catch ex As Exception

        End Try


    End Sub

#End Region

#Region "BOTÕES"

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        Dim curriculo As New Curriculo
        ''Editar
        If isEdit Then

            If curriculo.UpdateHabilidadesCV(idHabilidades, _
                                            cmbResponsavel.SelectedValue, _
                                            txtHabilidade.Text, _
                                            txtMetodo.Text, _
                                            txtResultado.Text, _
                                            dtData.Value) Then
                MessageBox.Show("Dados de Habilidades atualizados com sucesso", "Habilidades", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                cotrCurriculo.carregaHabilidades(idUsuarioCV)
                Me.Close()
            End If

        Else

            If curriculo.AddHabilidadesCV(cmbResponsavel.SelectedValue, _
                                            txtHabilidade.Text, _
                                            txtMetodo.Text, _
                                            txtResultado.Text, _
                                            dtData.Value) Then
                MessageBox.Show("Dados de Habilidades salvos com sucesso", "Habilidades", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                cotrCurriculo.carregaHabilidades(idUsuarioCV)
                Me.Close()
            End If
        End If

    End Sub

#End Region

#End Region

End Class
