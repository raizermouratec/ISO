Imports System.IO
Imports System.Data.SqlClient
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Public Class docAddAtividades

#Region "VARIAVEIS"
    Public doc1 As String = String.Empty
    Public rev1 As Integer = 0
    Public doc As String = doc1
    Public rev As Integer = rev1

    Private num As Integer

    '// doc
    Public WriteOnly Property Documento() As String
        Set(ByVal value As String)
            Me.doc1 = value
        End Set
    End Property
    '// rev
    Public WriteOnly Property Revisao() As Integer
        Set(ByVal value As Integer)
            Me.rev1 = value
        End Set
    End Property
#End Region

#Region "NOVO"
    Public Sub Novo()
        '//
        doc = doc1.ToString().Trim()
        rev = rev1.ToString().Trim()
        Gb.Text = "Documento:" + "  " + doc1.ToString() + "  -  " + "Revisão:" + "  " + rev1.ToString()

        '//
        Try
            Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_ELABORACAO_ATIVIDADE WHERE CODIGO_DOCUMENTO = '{0}' AND REVISAO = {1}", doc, rev)

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read
                If dr("N_ATIVIDADE") <= 0 Then
                    Me.txtAtividadeN.Text = 1
                Else
                    Me.txtAtividadeN.Text = dr("N_ATIVIDADE") + 1
                End If
            End While
            If Me.txtAtividadeN.Text.Length <= 0 Then
                Me.txtAtividadeN.Text = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

        '//Abre o form...
        Me.ShowDialog()
    End Sub
#End Region

#Region "LOAD"

    Private Sub docAddAtividades_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        tabOque.Show()
        '//DESABILITA CODIGO
        txtAtividadeN.ReadOnly = True


    End Sub
#End Region

#Region "CONTROLE DE SETAS"

    Private Sub cmbTipo_ChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbTipo.ChangeCommitted

        'Controle do combo
        If cmbTipo.SelectedIndex = 1 Then

            'Img
            Me.PicDecisao.Visible = True
            Me.PicExecucao.Visible = False
            Me.PicSetaBaixo.Visible = True

            Me.txtOqueTela.Visible = True
            Me.txtOqueTela.AutoSize = True
            '   Me.txtOqueTela.Text = Me.Size.Width() = 44
            '  Me.txtOqueTela.Text = Me.Size.Height() = 88

            'oque
            Me.lblOque.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.txtOque.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            'Sim/Nao
            Me.lblOqueSim.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.txtOqueSim.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.lblOqueNao.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.txtOqueNao.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            'Atividade Terminal
            Me.lblAtividadeTerminal.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.cmbAtividadeTerminal.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            'Seta
            Me.lblSeta.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.radioDireita.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.radioEsquerda.Visibility = C1.Win.C1InputPanel.Visibility.Visible

        Else

            'Img
            Me.PicExecucao.Visible = True
            Me.PicDecisao.Visible = False
            Me.PicSetaBaixo.Visible = True

            Me.txtOqueTela.Visible = True
            '     Me.txtOqueTela.Text = Me.Size.Width() = 151
            '   Me.txtOqueTela.Text = Me.Size.Height() = 80


            'Setas
            Me.PicSetaEsquerdaSim.Visible = False
            Me.PicSetaDireitaSim.Visible = False
            Me.PicSetaEsquerdaNao.Visible = False
            Me.PicSetaDireitaNao.Visible = False

            'oque
            Me.lblOque.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.txtOque.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            'Sim/Nao
            Me.lblOqueSim.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOqueSim.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.lblOqueNao.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.txtOqueNao.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            'Atividade Terminal
            Me.lblAtividadeTerminal.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            Me.cmbAtividadeTerminal.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            'Seta
            Me.lblSeta.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.radioDireita.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            Me.radioEsquerda.Visibility = C1.Win.C1InputPanel.Visibility.Hidden

        End If

    End Sub

    Private Sub txtOque_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOque.TextChanged
        txtOqueTela.Text = txtOque.Text
    End Sub
    Private Sub txtOqueTela_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOqueTela.TextChanged
        txtOque.Text = txtOqueTela.Text
    End Sub

    Private Sub cmbAtividadeTerminal_ChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbAtividadeTerminal.ChangeCommitted

        If cmbAtividadeTerminal.SelectedIndex = 0 Then
            Me.PicSetaBaixo.Visible = False
        Else
            Me.PicSetaBaixo.Visible = True
        End If

    End Sub

    'SETA DIREITA
    Private Sub radioDireita_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioDireita.SelectedIndexChanged
        If Me.radioDireita.Checked Then
            Me.txtOqueSim.Enabled = True
            Me.txtOqueNao.Enabled = True
        End If
    End Sub

    'SETA ESQUERDA
    Private Sub radioEsquerda_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles radioEsquerda.SelectedIndexChanged
        If Me.radioEsquerda.Checked Then
            Me.txtOqueSim.Enabled = True
            Me.txtOqueNao.Enabled = True
        End If
    End Sub

    Private Sub txtOqueSim_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtOqueSim.ValueChanged

        If Me.radioEsquerda.Checked Then
            Me.PicSetaEsquerdaSim.Visible = True
            Me.PicSetaDireitaSim.Visible = False

            Me.PicSetaEsquerdaNao.Visible = False
            Me.PicSetaDireitaNao.Visible = False

        Else
            Me.PicSetaEsquerdaSim.Visible = False
            Me.PicSetaDireitaSim.Visible = True

            Me.PicSetaEsquerdaNao.Visible = False
            Me.PicSetaDireitaNao.Visible = False

        End If

    End Sub

    Private Sub txtOqueNao_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtOqueNao.ValueChanged

        If Me.radioEsquerda.Checked Then
            Me.PicSetaEsquerdaNao.Visible = True
            Me.PicSetaDireitaNao.Visible = False

            Me.PicSetaEsquerdaSim.Visible = False
            Me.PicSetaDireitaSim.Visible = False

        Else
            Me.PicSetaEsquerdaNao.Visible = False
            Me.PicSetaDireitaNao.Visible = True

            Me.PicSetaEsquerdaSim.Visible = False
            Me.PicSetaDireitaSim.Visible = False

        End If

    End Sub

#End Region

#Region "BOTÕES DE ADD"
    Private Sub btAddComo_Click(sender As System.Object, e As System.EventArgs) Handles btAddComo.Click
        Try
            Dim frm As New docVincularDocElaboracao
            tabComo.Show()
            '//Passa parametros...
            frm.TipoAtividade = "COMO"
            frm.ItemVinc = txtAtividadeN.Text
            frm.Documento = doc
            frm.Revisao = rev
            '//Chama o form...
            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btAddQuem_Click(sender As System.Object, e As System.EventArgs) Handles btAddQuem.Click
        tabQuem.Show()
    End Sub

    Private Sub btAddRegistro_Click(sender As System.Object, e As System.EventArgs) Handles btAddRegistro.Click
        tabRegistro.Show()
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
            gridComo.DataSource = dtb
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region
 

End Class
