Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports ISOEFACIL.melListaMelhorias
Imports ISOEFACIL.melCadMelhorias
Public Class melEstruturado

#Region "VARIAVEIS"

    'Variavel global que contera o valor passado 
    Private isEditEs As Boolean = False
    Private isEditEstruturado As Boolean = False
    Public idEstruturado As String = String.Empty
    Public IdMelhoria As String
    Public verif As Boolean = False
    Public idacao As String
    Public Numero As String

    'Pega Id Registro
    Public WriteOnly Property Estruturado() As String
        Set(ByVal value As String)
            Me.idEstruturado = value
        End Set
    End Property

    'Pega Id Melhorias
    Public WriteOnly Property MelhoriasEs() As String
        Set(ByVal value As String)
            Me.IdMelhoria = value
        End Set
    End Property

    'Pega Id Ação
    Public WriteOnly Property Acao() As String
        Set(ByVal value As String)
            Me.idacao = value
        End Set
    End Property

#End Region

#Region "POPULA COMBOS"

#Region "QUEM"

    Sub CarregaQuem()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT * FROM VW_COLABORADORES")
        Dim dtr As DataRow = dtb.NewRow
        dtr("COLABORADOR") = " "

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()

        comboQuem.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        comboQuem.DataSource = dtb
        comboQuem.DisplayMember = "COLABORADOR"
        comboQuem.ValueMember = "ID"
    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub melEstruturadoAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Aba1.Show()
        CarregaQuem()
        contador(IdMelhoria, idacao)
        txtOque.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtComo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
        txtResultados.ForeColor = System.Drawing.ColorTranslator.FromHtml("#15429E")
    End Sub

    Private Sub checkData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkData.Click

        If checkData.Checked = True Then
            Me.inpultData.Visible = True
            Me.txtQuando.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtQuando.Text = ""
        Else
            Me.inpultData.Visible = False
            Me.txtQuando.Visibility = C1.Win.C1InputPanel.Visibility.Visible
        End If

    End Sub

    Private Sub contador(ByVal id As Integer, ByVal acao As Integer)

        Dim dbCont As New DataTable
        Dim cont As Integer = 1

        Try
            If isEditEs Then
                'cont = idEstruturado
                'Numero = cont.ToString
            Else
                dbCont = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_MELHORIAS_ESTRUTURADO WHERE ID_MELHORIAS =" & id & "AND ACAO = " & acao)
                If dbCont.Rows.Count >= 1 Then
                    cont = cont + dbCont.Rows.Count
                    Numero = cont.ToString
                Else
                    Numero = cont.ToString
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub checkData_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkData.CheckedChanged

        If checkData.Checked = True Then
            Me.inpultData.Visible = True
            Me.txtQuando.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtQuando.Text = ""
        Else
            Me.inpultData.Visible = False
            Me.txtQuando.Visibility = C1.Win.C1InputPanel.Visibility.Visible
        End If

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoAC()
        'Cadastrar Novo
        Acao = 1
        isEditEs = False
        Me.ShowDialog()
    End Sub

    Public Sub NovoAP()
        'Cadastrar Novo
        Acao = 2
        isEditEs = False
        Me.ShowDialog()
    End Sub

    Public Sub NovoAM()
        'Cadastrar Novo
        Acao = 3
        isEditEs = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "SALVAR"

    Private Sub botSalvarEstruturado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalvarEstruturado.Click

        'Seta a Classe
        Dim estruturado As New estruturado

        contador(IdMelhoria, idacao)

        'Verificando o valor de check_Data
        Dim check_Data As Boolean
        Dim Data As String
        If checkData.Checked = True Then
            check_Data = True
            Data = dateQuando.Value
        Else
            check_Data = False
            Data = dateQuando.Value
        End If

        'Inicio Atualizar/Salvar
        If isEditEs Then

            'Verificar campos obrigatórios
            VerificarCad()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Atualizar
                    If estruturado.Update(idEstruturado, _
                                          IdMelhoria, _
                                          idacao, _
                                          comboQuem.SelectedValue, _
                                          Numero, _
                                          txtOque.Text, _
                                          txtComo.Text, _
                                          check_Data, _
                                          txtQuando.Text, _
                                          Data, _
                                          txtResultados.Text) Then
                        MessageBox.Show("Dados da Ação atualizados com sucesso", "Ação Estruturada", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        Else

            'Verificar campos obrigatórios
            VerificarCad()
            'Checando se campos obrigatórios estão OK
            If verif = False Then
                Try
                    'Salvar
                    idEstruturado = estruturado.Add(IdMelhoria, _
                                       idacao, _
                                       comboQuem.SelectedValue, _
                                       Numero, _
                                       txtOque.Text, _
                                       txtComo.Text, _
                                       check_Data, _
                                       txtQuando.Text, _
                                       Data, _
                                       txtResultados.Text)
                    If idEstruturado <> String.Empty Then
                        MessageBox.Show("Ação incluída com sucesso", "Ação Estruturada", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub VerificarCad()
        verif = False

        'Tratamento de erro O que
        If txtOque.Text = "" Then
            MessageBox.Show("Campo O que Obrigatório", "Adicionar Ação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtOque.Focus()
            Aba1.Show()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Como
        If txtComo.Text = "" Then
            MessageBox.Show("Campo Como Obrigatório", "Adicionar Ação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtComo.Focus()
            Aba2.Show()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Quando Texto
        If checkData.Checked = False Then
            If txtQuando.Text = "" Then
                MessageBox.Show("Campo Quando Obrigatório", "Adicionar Ação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtQuando.Focus()
                Aba3.Show()
                verif = True
                Exit Sub
            End If
            'Tratamento de erro Quando Data
        ElseIf dateQuando.Text = "" Then
            MessageBox.Show("Campo Quando - Data Obrigatório", "Adicionar Ação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            dateQuando.Focus()
            Aba3.Show()
            verif = True
            Exit Sub
        End If
        'Tratamento de erro Quem
        If comboQuem.SelectedValue.ToString = String.Empty Then
            MessageBox.Show("Campo Quem Obrigatório", "Adicionar Ação", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboQuem.Focus()
            verif = True
            Aba4.Show()
            Exit Sub
        End If

    End Sub

#End Region

#Region "EDITAR"

    Public Sub EditarEstruturado(ByVal id As Integer, ByVal acao As Integer)

        'Editar
        isEditEs = True

        'Ação recebe e passa a função
        idacao = acao

        'Muda o Label do botão Incluir
        botSalvarEstruturado.Width = 80
        botSalvarEstruturado.Text = "Atualizar"

        'Carrega combo
        CarregaQuem()

        Dim sql As String = String.Format("SELECT * FROM MELHORIAS_ESTRUTURADO WHERE ACAO =" & acao & "AND ID_MELHORIAS_ESTRUTURADO = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.Numero = dr("NUMERO").ToString
                Me.txtOque.Text = dr("O_QUE").ToString
                Me.txtComo.Text = dr("COMO").ToString
                If dr("QUANDO_CHECK") = True Then
                    Me.checkData.Checked = True
                    Me.dateQuando.Value = dr("QUANDO_DATA").ToString
                Else
                    Me.checkData.Checked = False
                    Me.txtQuando.Text = dr("QUANDO").ToString
                End If
                Me.comboQuem.SelectedValue = dr("ID_COLABORADORES").ToString
                Me.txtResultados.Text = dr("RESULTADOS").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        Me.ShowDialog()

    End Sub

#End Region

End Class
