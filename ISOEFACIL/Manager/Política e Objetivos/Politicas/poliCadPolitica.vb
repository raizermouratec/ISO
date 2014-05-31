Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports ISOEFACIL.poliListaPolitica
Public Class poliCadPolitica

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEdit As Boolean = False
    Private isEditPolitica As Boolean = False
    Public idPolitica As String = String.Empty
    Public isrevisao As Boolean = False
    Public verif As Boolean = False
    Dim ID As Integer

    'Pega Id Registro
    Public WriteOnly Property Politica() As String
        Set(ByVal value As String)
            Me.idPolitica = value
        End Set
    End Property

#End Region

#Region "PASSANDO PARAMETRO"

    Public Sub AbaOutros(ByVal id As Integer)

        'Dim doc As New docCadDocumentos
        Dim aba As Integer = 0

        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "POPULA COMBOS"

#Region "APROVADOR"

    Sub CarregaAprov()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES_APROVADOR")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboAprov.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboAprov.DataSource = dtb
        comboAprov.DisplayMember = "COLABORADOR"
        comboAprov.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub CadastrarPolitica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaAprov()
        editTextodaPolitica.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoRegistro()
        'Cadastrar Novo
        Me.txtRevisao.Text = "00"
        isEdit = False
        Me.Show()
    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarPolitica(ByVal id As Integer)

        'Editar
        isEdit = True

        'Muda o Label do botão Incluir
        botSalvar.Width = 80
        botSalvar.Text = "Atualizar"

        'Carrega Combo
        CarregaAprov()

        'Seleciona Fornecedor pelo Id
        Dim sql As String = String.Format("SELECT * FROM POLITICA WHERE ID_POLITICA = {0}", id)

        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read
                Me.txtNome.Text = dr("NOME").ToString
                If dr("REVISAO") = "00" Then
                    Me.ID = idPolitica
                Else
                    Me.ID = dr("ID").ToString
                End If
                Me.txtRevisao.Text = dr("REVISAO").ToString
                Me.editTextodaPolitica.Text = dr("TEXTO_POLITICA").ToString
                Me.comboAprov.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.dateData.Value = dr("DATA").ToString
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        'Carrega o Form com esse methodo
        Me.ShowDialog()

    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvar.Click

        'Seta a Classe
        Dim politica As New politica

        'Inicio Atualizar/Salvar
        If isEdit Then

            If MessageBox.Show("Deseja alterar a Revisão?", "Política", Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Dim rev As Integer = 0
                Dim dr As SqlDataReader
                dr = Manager.Util.getDataReader("SELECT MAX(REVISAO) AS REVISAO FROM VW_LISTAGEM_POLITICA WHERE ID = " & ID)
                While dr.Read
                    rev = dr("REVISAO").ToString
                End While
                If rev >= 0 Then
                    txtRevisao.Text = rev + 1
                    txtRevisao.Text = "0" & txtRevisao.Text.ToString
                Else
                    txtRevisao.Text = txtRevisao.Text.ToString
                End If

                'Verificar campos obrigatórios
                VerificarPoli()
                'Checando se campos obrigatórios estão OK
                If verif = False Then
                    Try
                        'Salvar
                        If politica.Add(comboAprov.SelectedValue, _
                                        ID, _
                                        txtNome.Text, _
                                        txtRevisao.Text, _
                                        editTextodaPolitica.Text, _
                                        dateData.Value) Then
                            poliListaPolitica.carregaPoliticas()
                            Close()
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    End Try
                Else
                    Exit Sub
                End If

            Else

                'Verificar campos obrigatórios
                VerificarPoli()
                'Checando se campos obrigatórios estão OK
                If verif = False Then
                    Try
                        'Atualizar
                        If politica.Update(idPolitica, _
                                           comboAprov.SelectedValue, _
                                           ID, _
                                           txtNome.Text, _
                                           txtRevisao.Text, _
                                           editTextodaPolitica.Text, _
                                           dateData.Value) Then
                            poliListaPolitica.carregaPoliticas()
                            MessageBox.Show("Dados da Política atualizados com sucesso", "Política", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Close()
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    End Try
                Else
                    Exit Sub
                End If

            End If

        Else

            'Verificar campos obrigatórios
            VerificarPoli()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    idPolitica = politica.Add(comboAprov.SelectedValue, _
                                              ID, _
                                              txtNome.Text, _
                                              txtRevisao.Text, _
                                              editTextodaPolitica.Text, _
                                              dateData.Value)
                    If idPolitica <> String.Empty Then
                        poliListaPolitica.carregaPoliticas()
                        ID = idPolitica
                        politica.UpdateID(idPolitica, _
                                          ID)
                        If MessageBox.Show("Documento Controlado ?", "Política", Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            DocContDoc.Show()
                        End If
                        Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If


    End Sub

    Private Sub VerificarPoli()
        verif = False

        'Tratamento de erro Nome
        If txtNome.Text = "" Then
            MessageBox.Show("Campo Nome não foi preenchido", "Política", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNome.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Texto Politica
        If editTextodaPolitica.Text.ToString = Nothing Then
            MessageBox.Show("Campo Texto da Política não foi preenchido", "Política", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            editTextodaPolitica.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Aprovador
        If comboAprov.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Aprovador não foi selecionado", "Política", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboAprov.Focus()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Data
        If dateData.Text = "" Then
            MessageBox.Show("Campo Data não foi preenchido", "Política", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateData.Focus()
            verif = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "CONTADOR [INATIVO]"

    '***CONTADOR NÃO USADO
    'Private Sub contador()
    '    Dim dbCont As New DataTable
    '    Dim cont As Integer = 1
    '    Try
    '        If isEdit Then
    '            cont = idPolitica
    '            txtRevisao.Text = cont.ToString
    '        Else
    '            dbCont = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_POLITICA")
    '            If dbCont.Rows.Count >= 1 Then
    '                cont = cont + dbCont.Rows.Count
    '                txtRevisao.Text = cont.ToString
    '                txtRevisao.Text = "0" & txtRevisao.Text.ToString
    '            Else
    '                txtRevisao.Text = cont.ToString
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
    '    End Try
    'End Sub

#End Region

End Class
