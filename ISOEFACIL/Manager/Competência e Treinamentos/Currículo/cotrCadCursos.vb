Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports ISOEFACIL.cotrCurriculo
Public Class cotrCadCursos

#Region "VARIAVEIS"

    Private isEdit As Boolean = False
    Public idUsuarioCV As String
    Public idCurso As String

    'Pega Id Usuário
    Public WriteOnly Property UsuarioCv() As String
        Set(ByVal value As String)
            Me.idUsuarioCV = value
        End Set
    End Property    'Pega Id

    Public WriteOnly Property Curso() As String
        Set(ByVal value As String)
            Me.idCurso = value
        End Set
    End Property    'Pega Id

#End Region

#Region "LOAD"
    Private Sub cotrCadCursos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
#End Region

#Region "NOVO"

    Public Sub NovoCadForm(ByVal id As Integer)
        'Cadastrar Novo
        Me.ShowDialog()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarCurso(ByVal id As Integer)

        Dim es As Integer = 0

        'Editar
        isEdit = True

        'Muda o Label do botão Incluir
        Me.botSalvar.Width = 80
        Me.botSalvar.Text = "Atualizar"

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM TREINAMENTO_CURSO_CV WHERE ID_TREINAMENTO_CURSO_CV ={0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtCurso.Text = dr("CURSO").ToString
                Me.txtInstituicao.Text = dr("INSTITUICAO").ToString
                Me.NumCargaHoraria.Text = dr("CARGA_HORARIA").ToString
                Me.dtInicio.Text = dr("DATA_INICIO").ToString
                Me.dtTermino.Text = dr("DATA_TERMINO").ToString

            End While

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "BOTÕES"

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        Dim zero As Integer = 0
        Dim curriculo As New Curriculo

        ''Editar
        If isEdit Then

            If curriculo.UpdateCursoCV(idCurso, _
                                    idUsuarioCV, _
                                    txtCurso.Text, _
                                    txtInstituicao.Text, _
                                    NumCargaHoraria.Text, _
                                    dtInicio.Value, _
                                    dtTermino.Value) Then
                MessageBox.Show("Dados de Cursos Atualizados com sucesso", "Cursos Complementares", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                cotrCurriculo.carregaCurso(idUsuarioCV)
                Me.Close()
            End If

        Else

            'Salvar
            If curriculo.AddCursoCV(idUsuarioCV, _
                                    txtCurso.Text, _
                                    txtInstituicao.Text, _
                                    NumCargaHoraria.Text, _
                                    dtInicio.Value, _
                                    dtTermino.Value) Then
                MessageBox.Show("Dados de Cursos salvos com sucesso", "Cursos Complementares", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                cotrCurriculo.carregaCurso(idUsuarioCV)
                Me.Close()
            End If
        End If
    End Sub

#End Region

#End Region

End Class
