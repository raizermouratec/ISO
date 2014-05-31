Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ISOEFACIL.cotrCadFormacao
Imports ISOEFACIL.cotrCadCursos
Public Class cotrCurriculo

#Region "CARREGA LISTAS"

#Region "CARREGA FORMAÇÃO"

    Public Sub carregaFormacao(ByVal id As Integer)

        Dim dt As New DataTable

        Try

            Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_TREINAMENTO_FORMACAO_CV WHERE COLABORADOR ={0}", id)
            dt = Manager.Util.getDataTableById(sql)

            'Monta o Grid
            gridFormacao.AutoGenerateColumns = False
            gridFormacao.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    'Public Sub CarregaFormacaoLista()
    '    'Carrega Lista 
    '    gridFormacao.AutoGenerateColumns = False
    '    gridFormacao.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_TREINAMENTO_FORMACAO_CV")
    'End Sub

#End Region

#Region "CARREGA CURSO"

    Public Sub carregaCurso(ByVal id As Integer)

        Dim dt As New DataTable

        Try

            Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_TREINAMENTO_CURSO_CV WHERE COLABORADOR ={0}", id)
            dt = Manager.Util.getDataTableById(sql)

            'Monta o grid
            gridCurso.AutoGenerateColumns = False
            gridCurso.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    'Public Sub CarregaCursosLista()
    '    'Carrega Lista 
    '    gridCurso.AutoGenerateColumns = False
    '    gridCurso.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_TREINAMENTO_CURSO_CV")
    'End Sub

#End Region

#Region "CARREGA EXPERIENCIA"

    Public Sub carregaExperiencia(ByVal id As Integer)

        Dim dt As New DataTable

        Try

            Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_TREINAMENTO_EXPERIENCIA_CV WHERE COLABORADOR ={0}", id)
            dt = Manager.Util.getDataTableById(sql)

            'Monta o Grid
            gridExperiencia.AutoGenerateColumns = False
            gridExperiencia.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    'Public Sub CarregaExperienciaLista()
    '    'Carrega Lista 
    '    gridExperiencia.AutoGenerateColumns = False
    '    gridExperiencia.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_TREINAMENTO_EXPERIENCIA_CV")
    'End Sub

#End Region

#Region "CARREGA HABILIDADES"

    Public Sub carregaHabilidades(ByVal id As Integer)

        Dim dt As New DataTable

        Try

            Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_TREINAMENTO_HABILIDADES_CV WHERE COLABORADOR ={0}", id)
            dt = Manager.Util.getDataTableById(sql)

            'Monta o Grid
            gridHabilidades.AutoGenerateColumns = False
            gridHabilidades.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    'Public Sub CarregaHabilidadesLista()
    '    'Carrega Lista 
    '    gridHabilidades.AutoGenerateColumns = False
    '    gridHabilidades.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_TREINAMENTO_HABILIDADES_CV")
    'End Sub

#End Region

#End Region

#Region "POPULA COMBOS"

    Sub CarregaComboColaborador()

        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        cmbNome.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        cmbNome.DataSource = dtb
        cmbNome.DisplayMember = "COLABORADOR"
        cmbNome.ValueMember = "ID"

    End Sub

#End Region

#Region "LOAD"

    Private Sub cotrCurriculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaComboColaborador()
        'CarregaFormacaoLista()
        'CarregaCursosLista()
        'CarregaExperienciaLista()
        'CarregaHabilidadesLista()
    End Sub

#Region "METODO DE SELEÇÃO DO FUNCIONÁRIO"

    Private Sub cmbNome_ChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbNome.ChangeCommitted

        Dim id As String

        Try

            If cmbNome.ValueMember = "" Then
                Exit Sub
            Else
                id = cmbNome.SelectedValue.ToString
                'combos
                ChamaCargoById(id)
                ChamaAreaById(id)
                'listas
                carregaFormacao(id)
                carregaCurso(id)
                carregaExperiencia(id)
                carregaHabilidades(id)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbNome_GotFocus(sender As System.Object, e As System.EventArgs) Handles cmbNome.GotFocus

        Dim id As String

        Try

            If cmbNome.SelectedValue.ToString = String.Empty Then
                Exit Sub
            Else
                id = cmbNome.SelectedValue
                'combos
                ChamaCargoById(id)
                ChamaAreaById(id)
                'listas
                carregaFormacao(id)
                carregaExperiencia(id)
                carregaCurso(id)
                carregaHabilidades(id)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "CHAMA CARGO E AREA POR USUARIO SELECIONADO"

    Public Sub ChamaAreaById(ByVal id As Integer)

        Dim sql As String = String.Format("SELECT * FROM AREAS AR INNER JOIN COLABORADORES CL ON AR.ID_AREAS = CL.ID_AREAS WHERE CL.ID_COLABORADORES = {0}", id)

        Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

        Try
            While dr.Read
                txtArea.Text = dr("CODIGO").ToString
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub ChamaCargoById(ByVal id As Integer)

        Dim sql As String = String.Format("SELECT * FROM CARGOS CA INNER JOIN COLABORADORES CL ON CA.ID_CARGOS = CL.ID_CARGOS WHERE ID_COLABORADORES = {0}", id)

        Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

        Try
            While dr.Read
                txtCargo.Text = dr("NOME").ToString
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#End Region

#Region "ABAS"

#Region "FORMACAO"

    'NOVO
    Public Sub ChamaFormFormacao()

        Dim id As Integer = 0
        Dim cvForm As New cotrCadFormacao

        If cmbNome.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Selecione um Usuário", "Cadastro de Formação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            id = cmbNome.SelectedValue
        End If

        cvForm.UsuarioCv = id
        cvForm.NovoCadForm(id)
    End Sub

    'EDITAR
    Public Sub ChamaFormFormacaoEdit()

        Dim id As Integer = 0
        Dim idFor As Integer = 0
        Dim cvForm As New cotrCadFormacao

        If cmbNome.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Selecione um Usuário", "Cadastro de Formação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            id = cmbNome.SelectedValue
            idFor = gridFormacao(gridFormacao.RowSel, 1)
            cvForm.idUsuarioCV = id
            cvForm.idFormacao = idFor
            cvForm.EditarFormacao(idFor)
        End If

    End Sub

#Region "CHAMA FORMULARIO"

    Private Sub chamaForms(ByVal id As Integer)

        Dim chama As Integer = 0
        Dim formacao As New cotrCadFormacao

        chama = id

        'Condicionando quando o form será aberto
        Select Case chama
            Case 1
                Call ChamaFormFormacao()
            Case 2
                Call ChamaFormCursos()
            Case 3
                Call ChamaFormExperiencia()
            Case 5
                Call ChamaFormHabilidades()
        End Select

    End Sub

    Private Sub chamaFormsEdit(ByVal id As Integer)

        Dim chama As Integer = 0
        Dim formacao As New cotrCadFormacao

        chama = id

        'Condicionando quando o form será aberto
        Select Case chama
            Case 1
                Call ChamaFormFormacaoEdit()
            Case 2
                Call ChamaFormCursosEdit()
            Case 3
                Call ChamaFormExperienciaEdit()
            Case 5
                Call ChamaFormHabilidadesEdit()
        End Select

    End Sub

#End Region

#End Region

#Region "CURSOS COMPLEMENTARES"

    'NOVO
    Public Sub ChamaFormCursos()

        Dim id As Integer = 0
        Dim cvForm As New cotrCadCursos

        If cmbNome.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Selecione um Usuário", "Cadastro de Formação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            id = cmbNome.SelectedValue
        End If

        cvForm.UsuarioCv = id
        cvForm.NovoCadForm(id)
    End Sub

    'EDITAR
    Public Sub ChamaFormCursosEdit()

        Dim id As Integer = 0
        Dim idCur As Integer = 0
        Dim cvForm As New cotrCadCursos

        If cmbNome.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Selecione um Usuário", "Cadastro de Formação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            id = cmbNome.SelectedValue
            idCur = gridCurso(gridCurso.RowSel, 1)
            cvForm.idUsuarioCV = id
            cvForm.idCurso = idCur
            cvForm.EditarCurso(idCur)
        End If

    End Sub


#End Region

#Region "EXPERIENCIA PROFISSIONAL"

    'NOVO
    Public Sub ChamaFormExperiencia()

        Dim id As Integer = 0
        Dim cvForm As New cotrCadExperiencia

        If cmbNome.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Selecione um Usuário", "Cadastro de Formação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            id = cmbNome.SelectedValue
        End If

        cvForm.UsuarioCv = id
        cvForm.NovoCadForm(id)
    End Sub

    'EDITAR
    Public Sub ChamaFormExperienciaEdit()

        Dim id As Integer = 0
        Dim idExp As Integer = 0
        Dim cvForm As New cotrCadExperiencia

        If cmbNome.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Selecione um Usuário", "Cadastro de Formação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            id = cmbNome.SelectedValue
            idExp = gridExperiencia(gridExperiencia.RowSel, 1)
            cvForm.idUsuarioCV = id
            cvForm.idExperiencia = idExp
            cvForm.EditarExperiencia(idExp)
        End If

    End Sub

#End Region

#Region "PROCEDIMENTOS E INSTRUÇÕES"



#End Region

#Region "HABILIDADES"

    'NOVO
    Public Sub ChamaFormHabilidades()

        Dim id As Integer = 0
        Dim cvForm As New cotrCadHabilidades

        If cmbNome.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Selecione um Usuário", "Cadastro de Formação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            id = cmbNome.SelectedValue
        End If

        cvForm.UsuarioCv = id
        cvForm.NovoCadForm(id)
    End Sub

    'EDITAR
    Public Sub ChamaFormHabilidadesEdit()

        Dim id As Integer = 0
        Dim idHab As Integer = 0
        Dim cvForm As New cotrCadHabilidades

        If cmbNome.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Selecione um Usuário", "Cadastro de Formação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            id = cmbNome.SelectedValue
            If gridHabilidades.RowSel < 0 Then
                MessageBox.Show("Selecione um Usuário", "Cadastro de Formação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                idHab = gridHabilidades(gridHabilidades.RowSel, 1)
                cvForm.idUsuarioCV = id
                cvForm.idHabilidades = idHab
                cvForm.EditarHabilidade(idHab)
            End If
            
        End If

    End Sub

#End Region

#End Region

#Region "BOTOES"

#Region "NOVO"

    Private Sub botNovo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles botNovo.Click

        Dim parametroform As Integer

        If docFormacao.Focus = True Then
            parametroform = 1
        ElseIf docCurso.Focus = True Then
            parametroform = 2
        ElseIf docExperiencia.Focus = True Then
            parametroform = 3
        ElseIf docProcInstr.Focus = True Then
            parametroform = 4
        ElseIf docHabilidades.Focus = True Then
            parametroform = 5
        End If

        chamaForms(parametroform)

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If gridFormacao.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Curriculo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim parametroform As Integer

            If docFormacao.Focus = True Then
                parametroform = 1
            ElseIf docCurso.Focus = True Then
                parametroform = 2
            ElseIf docExperiencia.Focus = True Then
                parametroform = 3
            ElseIf docProcInstr.Focus = True Then
                parametroform = 4
            ElseIf docHabilidades.Focus = True Then
                parametroform = 5
            End If

            chamaFormsEdit(parametroform)
        End If
    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        Dim id As Integer = 0
        Dim formacao As New Curriculo

        If cmbNome.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Selecione um Usuário", "Curriculo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            id = cmbNome.SelectedValue
        End If

        If docFormacao.Focus = True Then

            If gridFormacao.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Curriculo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                Try

                    If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Formação", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        formacao.DeleteFormacaoCv(gridFormacao(gridFormacao.RowSel, 1))
                        carregaFormacao(id)
                        MessageBox.Show("Formação excluída com sucesso", "Formação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            End If

        ElseIf docCurso.Focus = True Then

            If gridCurso.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Curriculo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                Try

                    If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Curso", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        formacao.DeleteCursoCV(gridCurso(gridCurso.RowSel, 1))
                        carregaCurso(id)
                        MessageBox.Show("Curso excluído com sucesso", "Curso", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            End If

        ElseIf docExperiencia.Focus = True Then

            If gridExperiencia.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Curriculo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                Try

                    If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Experiência", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        formacao.DeleteExperienciaCV(gridExperiencia(gridExperiencia.RowSel, 1))
                        carregaExperiencia(id)
                        MessageBox.Show("Experiência excluída com sucesso", "Experiência", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            End If

        ElseIf docProcInstr.Focus = True Then

        ElseIf docHabilidades.Focus = True Then

            If gridHabilidades.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Curriculo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                Try

                    If MessageBox.Show("Tem certeza que deseja excluir o item selecionado", "Habilidades", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        formacao.DeleteHabilidadesCV(gridHabilidades(gridHabilidades.RowSel, 1))
                        carregaHabilidades(id)
                        MessageBox.Show("Habilidade excluída com sucesso", "Habilidades", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            End If

        End If

    End Sub

#End Region

#Region "RELACAO"

    Private Sub botRelacao_Click(sender As System.Object, e As System.EventArgs) Handles botRelacao.Click
        If gridFormacao.RowSel < 0 Then
            MessageBox.Show("Não à nenhuma item selecionado", "Curriculo", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
        End If
    End Sub

#End Region

#End Region

End Class
