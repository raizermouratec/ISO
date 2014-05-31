Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ISOEFACIL.forListaOcorrencias
Imports ISOEFACIL.forCadFornecedores
Public Class GeralCadContato

#Region "VARIAVEIS"

    'Delegate criada para atualizar o grid
    Public Delegate Sub CarregaContatos(info As Integer)
    Public Event OnDataChange As CarregaContatos

    Private isEditContatos As Boolean = False

    'Variavel global que contera o valor passado 
    Private idFornecedor As String
    Private idClientes As String
    Private idContato As String
    Private modulo As String

    'Pega Id Fornecedor
    Public WriteOnly Property fornecedor() As String
        Set(ByVal value As String)
            Me.idFornecedor = value
        End Set
    End Property

    'Pega Id Clientes
    Public WriteOnly Property cliente() As String
        Set(ByVal value As String)
            Me.idClientes = value
        End Set
    End Property

    'Pega id Modulo
    Public WriteOnly Property Modulos() As String
        Set(ByVal value As String)
            Me.modulo = value
        End Set
    End Property

    'Pega Id Ocorrencias
    Public WriteOnly Property Contatos() As String
        Set(ByVal value As String)
            Me.idContato = value
        End Set
    End Property

#End Region

#Region "LOAD"

    Private Sub GeralCadContato_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

#End Region

#Region "NOVO"

    Public Sub NovoContato()
        'Cadastrar Novo
        isEditContatos = False
        Me.ShowDialog()
    End Sub

#End Region

#Region "SALVAR FORNECEDOR / CLIENTES"

    Private Sub btoSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click

        Try

            '************* FORNECEDORES ****************

            If modulo = "FORNECEDOR" Then

                Dim Contatos As New Contatos

                If isEditContatos Then
                    'Editar Contato/Fornecedor
                    Verificar()

                    If Contatos.Update(idContato, _
                                       txtNome.Text, _
                                       txtCargo.Text, _
                                       txtTel.Text, _
                                       txtCel.Text, _
                                       txtFax.Text, _
                                       txtEmail.Text, _
                                       txtSkype.Text) Then

                        MessageBox.Show("Dados atualizados com sucesso", "Contatos", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        'btoSalvar.Text = "Incluír"
                        RaiseEvent OnDataChange(idFornecedor)
                        Me.Close()

                    End If

                Else
                    'Salva Contato/Fornecedor
                    Verificar()

                    If Contatos.Add(idFornecedor, _
                                    modulo, _
                                    txtNome.Text, _
                                    txtCargo.Text, _
                                    txtTel.Text, _
                                    txtCel.Text, _
                                    txtFax.Text, _
                                    txtEmail.Text, _
                                    txtSkype.Text) Then

                        MessageBox.Show("Novo Contato incluído com sucesso", "Contatos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        RaiseEvent OnDataChange(idFornecedor)
                        Me.Close()
                    End If

                End If


                '************* CLIENTES ****************

            ElseIf modulo = "CLIENTES" Then

                Dim Contatos As New Contatos

                If isEditContatos Then
                    'Editar Contato/Cliente
                    Verificar()

                    If Contatos.Update(idContato, _
                                       txtNome.Text, _
                                       txtCargo.Text, _
                                       txtTel.Text, _
                                       txtCel.Text, _
                                       txtFax.Text, _
                                       txtEmail.Text, _
                                       txtSkype.Text) Then

                        MessageBox.Show("Dados atualizados com sucesso", "Contatos", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        botSalvar.Text = "Incluír"
                        RaiseEvent OnDataChange(idClientes)
                        Me.Close()

                    End If

                Else
                    'Salva Contato/Cliente
                    Verificar()

                    If Contatos.Add(idClientes, _
                                    modulo, _
                                    txtNome.Text, _
                                    txtCargo.Text, _
                                    txtTel.Text, _
                                    txtCel.Text, _
                                    txtFax.Text, _
                                    txtEmail.Text, _
                                    txtSkype.Text) Then

                        MessageBox.Show("Novo Contato incluído com sucesso", "Contatos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        RaiseEvent OnDataChange(idClientes)
                        Me.Close()
                    End If

                End If

            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Verificar()
        'Nome 
        If txtNome.Text = "" Then
            MessageBox.Show("O campo Nome não foi preenchido", "Contatos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNome.Focus()
            Exit Sub
        End If
        'Cargo
        If txtCargo.Text = "" Then
            MessageBox.Show("O campo Cargo não foi preenchido", "Contatos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCargo.Focus()
            Exit Sub
        End If
        'Tel
        If txtTel.Text = "" Then
            MessageBox.Show("O campo Telefone não foi preenchido", "Contatos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTel.Focus()
            Exit Sub
        End If
        'Cel
        If txtCel.Text = "" Then
            MessageBox.Show("O campo Celular não foi preenchido", "Contatos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCel.Focus()
            Exit Sub
        End If
        'Fax
        If txtFax.Text = "" Then
            MessageBox.Show("O campo Fax não foi preenchido", "Contatos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFax.Focus()
            Exit Sub
        End If
        'Email
        If txtEmail.Text = "" Then
            MessageBox.Show("O campo Email não foi preenchido", "Contatos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEmail.Focus()
            Exit Sub
        End If
        'Skype
        If txtSkype.Text = "" Then
            MessageBox.Show("O campo Skype não foi preenchido", "Contatos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSkype.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "EDITAR FORNECEDOR / CLIENTES"

    Public Sub EditarContatos(ByVal id As Integer)

        'Editar
        isEditContatos = True

        'Carrega o Form com esse methodo
        Me.Show()

        'Seleciona Produtos/Serviços pelo Id
        Dim sql As String = String.Format("SELECT * FROM CONTATOS WHERE ID_CONTATOS = {0}", id)

        'Popula os campos com os dados do Banco
        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                Me.txtNome.Text = dr("NOME").ToString
                Me.txtCargo.Text = dr("CARGO").ToString
                Me.txtTel.Text = dr("TELEFONE_FIXO").ToString
                Me.txtCel.Text = dr("TELEFONE_CELULAR").ToString
                Me.txtFax.Text = dr("TELEFONE_FAX").ToString
                Me.txtEmail.Text = dr("EMAIL").ToString
                Me.txtSkype.Text = dr("SKYPE").ToString

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class
